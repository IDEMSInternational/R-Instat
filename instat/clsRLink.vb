﻿' Instat+R
' Copyright (C) 2015
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports RDotNet

Public Class RLink
    ' R interface class. Each instance of the class has its own REngine instance
    Dim strClimateObjectPath As String = "/ClimateObject/R" 'new climateobject path
    Public strClimateObject As String = "ClimateObject"
    Dim strInstatObjectPath As String = "/InstatObject/R" 'path to the Instat object
    Public strInstatDataObject As String = "InstatDataObject"
    Public clsEngine As REngine
    Dim txtOutput As New RichTextBox
    Dim txtLog As New TextBox
    Public bLog As Boolean = False
    Public bOutput As Boolean = False
    Public bClimateObjectExists As Boolean = False
    Public bInstatObjectExists As Boolean = False
    Public bClimsoftLinkExists As Boolean = False
    'sets the default fonts and colors
    Public fScript As Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
    Public clrScript As Color = Color.Black
    '
    Public fOutput As Font = New Font(FontFamily.GenericMonospace, 8, FontStyle.Regular)
    Public clrOutput As Color = Color.Blue
    '
    Public fComments As Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
    Public clrComments As Color = Color.Green

    Public fEditor As Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
    Public clrEditor As Color = Color.Black

    Public Sub New(Optional bWithInstatObj As Boolean = False, Optional bWithClimsoft As Boolean = False)

    End Sub

    Public Sub SetEngine()
        Try
            REngine.SetEnvironmentVariables()
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & "Ensure that the correct version of R is installed and restart the program.", MsgBoxStyle.Critical, "Cannot initialise R Link.")
            Application.Exit()
        End Try
        Try
            clsEngine = REngine.GetInstance()
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & "Ensure that the correct version of R is installed and restart the program.", MsgBoxStyle.Critical, "Cannot initialise R Link.")
            Application.Exit()
        End Try
        clsEngine.Initialize()
    End Sub
    Public Sub setFormatOutput(tempFont As Font, tempColor As Color)
        fOutput = tempFont
        clrOutput = tempColor
    End Sub

    Public Sub setFormatScript(tempFont As Font, tempColor As Color)
        fScript = tempFont
        clrScript = tempColor
    End Sub

    Public Sub setFormatComment(tempFont As Font, tempColor As Color)
        fComments = tempFont
        clrComments = tempColor
    End Sub

    Public Sub SetOutput(tempOutput As RichTextBox)
        txtOutput = tempOutput
        bOutput = True
    End Sub

    Public Sub SetFormatDataView(tempFont As Font, tempColor As Color)
        fEditor = tempFont
        clrEditor = tempColor
    End Sub

    Public Sub SetLog(tempLog As TextBox)
        txtLog = tempLog
        bLog = True
    End Sub

    Public Function GetDataFrameNames() As List(Of String)
        Dim chrDataFrameNames As CharacterVector
        Dim lstDataFrameNames As New List(Of String)
        chrDataFrameNames = clsEngine.Evaluate(frmMain.clsRLink.strInstatDataObject & "$get_data_names()").AsCharacter
        lstDataFrameNames.AddRange(chrDataFrameNames)
        Return lstDataFrameNames
    End Function

    Public Function GetColumnNames(strDataFrameName As String) As List(Of String)
        Dim chrCurrColumns As CharacterVector
        Dim lstCurrColumns As New List(Of String)
        chrCurrColumns = clsEngine.Evaluate(strInstatDataObject & "$get_column_names(" & Chr(34) & strDataFrameName & Chr(34) & ")").AsCharacter
        lstCurrColumns.AddRange(chrCurrColumns)
        Return lstCurrColumns
    End Function

    Public Sub FillComboDataFrames(ByRef cboDataFrames As ComboBox, Optional bSetDefault As Boolean = True, Optional bIncludeOverall As Boolean = False)

        If bInstatObjectExists Then
            cboDataFrames.Items.Clear()
            If bIncludeOverall Then
                cboDataFrames.Items.Add("[Overall]")
            End If
            cboDataFrames.Items.AddRange(GetDataFrameNames().ToArray)
        End If

        If bSetDefault Then
            cboDataFrames.SelectedIndex = cboDataFrames.Items.IndexOf(frmEditor.grdData.CurrentWorksheet.Name)
        End If
    End Sub

    Public Sub FillColumnNames(strDataFrame As String, ByRef cboColumns As ComboBox)
        Dim lstCurrColumns As List(Of String)

        If bInstatObjectExists AndAlso clsEngine IsNot Nothing Then
            lstCurrColumns = GetColumnNames(strDataFrame)
            cboColumns.Items.Clear()
            cboColumns.Items.AddRange(lstCurrColumns.ToArray)
        End If
    End Sub

    Public Sub FillColumnNames(strDataFrame As String, ByRef lstColumns As ListView)
        Dim lstCurrColumns As List(Of String)

        If bInstatObjectExists AndAlso clsEngine IsNot Nothing Then
            lstCurrColumns = GetColumnNames(strDataFrame)
            lstColumns.Items.Clear()
            If lstColumns.Columns.Count = 0 Then
                lstColumns.Columns.Add("Available Data")
            End If
            For Each strTemp In lstCurrColumns
                lstColumns.Items.Add(strTemp)
            Next
            lstColumns.Columns(0).Width = -2
        End If

    End Sub

    Public Function GetDefaultColumnNames(strPrefix As String) As GenericVector
        Dim lstNextDefaults As GenericVector = Nothing

        If bInstatObjectExists Then
            lstNextDefaults = clsEngine.Evaluate(strInstatDataObject & "$get_next_default_column_name(prefix = " & Chr(34) & strPrefix & Chr(34) & ")").AsList
        End If
        Return lstNextDefaults
    End Function

    Public Function GetDefaultColumnNames(strPrefix As String, strDataFrameName As String) As String
        Dim strNextDefault As String = ""

        If bInstatObjectExists Then
            strNextDefault = clsEngine.Evaluate(strInstatDataObject & "$get_next_default_column_name(data_name = " & Chr(34) & strDataFrameName & Chr(34) & ", prefix = " & Chr(34) & strPrefix & Chr(34) & ")").AsCharacter(0)
        End If
        Return strNextDefault
    End Function

    Public Function GetNextDefault(strPrefix As String, lstItems As List(Of String)) As String
        Dim strNextDefault As String = ""
        Dim clsGetDefault As New RFunction
        Dim strExistingNames As String
        Dim expPrefix As SymbolicExpression

        clsGetDefault.SetRCommand("next_default_item")
        clsGetDefault.AddParameter("prefix", Chr(34) & strPrefix & Chr(34))
        strExistingNames = GetListAsRString(lstItems)
        If strExistingNames <> "" Then
            clsGetDefault.AddParameter("existing_names", GetListAsRString(lstItems))
        End If
        expPrefix = RunInternalScriptGetValue(clsGetDefault.ToScript())
        If Not expPrefix.Type = Internals.SymbolicExpressionType.Null Then
            strNextDefault = expPrefix.AsCharacter(0)
        End If
        Return strNextDefault
    End Function

    Public Sub RunScript(strScript As String, Optional bReturnOutput As Integer = 0, Optional strComment As String = "")
        Dim strCapturedScript As String
        Dim temp As RDotNet.SymbolicExpression
        Dim strTemp As String
        Dim strOutput As String
        Dim strScriptWithComment As String
        Dim strSplitScript As String
        strOutput = ""
        If strComment <> "" Then
            strComment = "# " & strComment
            strScriptWithComment = strComment & vbCrLf & strScript
        Else
            strScriptWithComment = strScript
        End If
        If bLog Then
            txtLog.Text = txtLog.Text & strScriptWithComment & vbCrLf
        End If
        If bOutput Then
            If strComment <> "" Then
                AppendText(txtOutput, clrComments, fComments, strComment & vbCrLf)
            End If
            AppendText(txtOutput, clrScript, fScript, strScript & vbCrLf)
        End If
        If bReturnOutput = 0 Then
            Try
                clsEngine.Evaluate(strScript)
            Catch e As Exception
                MsgBox("Error occured in attempting to run:" & vbNewLine & strScript & vbNewLine & vbNewLine & "With error message:" & vbNewLine & e.Message & vbNewLine & vbNewLine, MsgBoxStyle.Critical, "Error running R code")
            End Try
        ElseIf bReturnOutput = 1 Then
            Try
                temp = clsEngine.Evaluate(strScript)
                strTemp = String.Join(vbCrLf, temp.AsCharacter())
                strOutput = strOutput & strTemp & vbCrLf
            Catch e As Exception
                MsgBox("Error occured in attempting to run:" & vbNewLine & strScript & vbNewLine & vbNewLine & "With error message:" & vbNewLine & e.Message & vbNewLine & vbNewLine, MsgBoxStyle.Critical, "Error running R code")
            End Try
        Else
            If strScript.Trim(vbCrLf).LastIndexOf(vbCrLf) = -1 Then
                strCapturedScript = "capture.output(" & strScript & ")"
            Else
                strSplitScript = Left(strScript, strScript.Trim(vbCrLf).LastIndexOf(vbCrLf))
                If strSplitScript <> "" Then
                    Try
                        clsEngine.Evaluate(strSplitScript)
                    Catch e As Exception
                        MsgBox("Error occured in attempting to run:" & vbNewLine & strSplitScript & vbNewLine & vbNewLine & "With error message:" & vbNewLine & e.Message & vbNewLine & vbNewLine, MsgBoxStyle.Critical, "Error running R code")
                    End Try
                End If
                strSplitScript = Right(strScript, strScript.Length - strScript.Trim(vbCrLf).LastIndexOf(vbCrLf) - 2)
                strCapturedScript = "capture.output(" & strSplitScript & ")"
            End If
            Try
                temp = clsEngine.Evaluate(strCapturedScript)
                strTemp = String.Join(vbCrLf, temp.AsCharacter())
                strOutput = strOutput & strTemp & vbCrLf
            Catch e As Exception
                MsgBox("Error occured in attempting to run:" & vbNewLine & strCapturedScript & vbNewLine & vbNewLine & "With error message:" & vbNewLine & e.Message & vbNewLine & vbNewLine, MsgBoxStyle.Critical, "Error running R code")
            End Try
        End If
        If bOutput Then
            AppendText(txtOutput, clrOutput, fOutput, strOutput)
        End If
        frmMain.clsGrids.UpdateGrids()
        frmMain.clsGrids.FormatDataVIew(fEditor, clrEditor)
    End Sub

    Private Sub AppendText(box As RichTextBox, color As Color, font As Font, text As String)
        Dim iStart As Integer = box.TextLength
        Dim iEnd As Integer

        box.AppendText(text)
        iEnd = box.TextLength

        ' Textbox may transform chars, so (end-start) != text.Length
        box.[Select](iStart, iEnd - iStart)
        box.SelectionColor = color
        box.SelectionFont = font
        'TClears selection
        box.SelectionLength = 0
        ' clear
    End Sub


    Public Function GetData(strLabel As String) As CharacterMatrix

        Me.clsEngine.Evaluate("temp<-" & strLabel)
        Me.clsEngine.Evaluate("temp <- convert_to_character_matrix(temp)")
        Return Me.clsEngine.GetSymbol("temp").AsCharacterMatrix()

    End Function

    Public Function RunInternalScriptGetValue(strScript As String, Optional strVariableName As String = ".temp_value", Optional bSilent As Boolean = True) As SymbolicExpression
        Dim expTemp As SymbolicExpression

        If clsEngine IsNot Nothing Then
            Try
                clsEngine.Evaluate(strVariableName & " <- " & strScript)
                expTemp = clsEngine.GetSymbol(strVariableName)
            Catch ex As Exception
                If Not bSilent Then
                    MsgBox("Error occured in attempting to run:" & vbNewLine & strScript & vbNewLine & vbNewLine & "With error message:" & vbNewLine & ex.Message & vbNewLine & vbNewLine, MsgBoxStyle.Critical, "Error running R code")
                End If
                expTemp = Nothing
            End Try
        Else
            expTemp = Nothing
        End If
        Return expTemp
    End Function

    Public Function RunInternalScriptGetOutput(strScript As String, Optional bSilent As Boolean = True) As CharacterVector
        Dim chrTemp As CharacterVector
        Dim expTemp As SymbolicExpression

        expTemp = RunInternalScriptGetValue("capture.output(" & strScript & ")")
        Try
            chrTemp = expTemp.AsCharacter()
        Catch ex As Exception
            If Not bSilent Then
                MsgBox("Error occured in attempting to run:" & vbNewLine & strScript & vbNewLine & vbNewLine & "With error message:" & vbNewLine & ex.Message & vbNewLine & vbNewLine, MsgBoxStyle.Critical, "Error running R code")
            End If
            chrTemp = Nothing
        End Try
        Return chrTemp
    End Function

    Public Function RunInternalScript(strScript As String, Optional strVariableName As String = "", Optional bSilent As Boolean = True) As Boolean
        If clsEngine IsNot Nothing Then
            Try
                If strVariableName <> "" Then
                    clsEngine.Evaluate(strVariableName & "<-" & strScript)
                Else
                    clsEngine.Evaluate(strScript)
                End If
                Return True
            Catch ex As Exception
                If Not bSilent Then
                    MsgBox("Error occured in attempting to run:" & vbNewLine & strScript & vbNewLine & vbNewLine & "With error message:" & vbNewLine & ex.Message & vbNewLine & vbNewLine, MsgBoxStyle.Critical, "Error running R code")
                End If
                Return False
            End Try
        Else
            Return False
        End If
    End Function

    Public Function GetDefaultDataFrameName(strPrefix As String, Optional iStartIndex As Integer = 1, Optional bIncludeIndex As Boolean = True) As String
        Dim strTemp As String
        If Not bInstatObjectExists Then
            CreateNewInstatObject()
        End If
        If bIncludeIndex Then
            strTemp = clsEngine.Evaluate(strInstatDataObject & "$get_next_default_dataframe_name(prefix = " & Chr(34) & strPrefix & Chr(34) & ", include_index = TRUE, start_index =" & iStartIndex & ")").AsCharacter()(0)
        Else
            strTemp = clsEngine.Evaluate(strInstatDataObject & "$get_next_default_dataframe_name(prefix = " & Chr(34) & strPrefix & Chr(34) & ", include_index = FALSE, start_index =" & iStartIndex & ")").AsCharacter()(0)
        End If

        Return strTemp
    End Function

    Public Function GetVar(strLabel As String) As CharacterVector

        Try
            Return Me.clsEngine.Evaluate(strLabel).AsCharacter()
        Catch
            MsgBox(strLabel)
            Return Nothing
        End Try

    End Function

    Public Sub CreateNewClimateObject() 'creates an instance of the climate object
        If Not bClimateObjectExists Then
            frmSetupLoading.Show()
            RunScript("setwd('" & frmMain.strStaticPath.Replace("\", "/") & strClimateObjectPath & "')")
            RunScript("source(" & Chr(34) & "SourcingScript.R" & Chr(34) & ")")
            RunScript(strClimateObject & "<-climate$new()")
            bClimateObjectExists = True
            frmSetupLoading.Close()
        End If
    End Sub

    Public Sub RSetup()
        'run script to load libraries
        frmSetupLoading.Show()
        RunScript("setwd('" & frmMain.strStaticPath.Replace("\", "/") & strInstatObjectPath & "')") 'This is bad the wd should be flexible and not automatically set to the instat object directory 
        RunScript("source(" & Chr(34) & "Rsetup.R" & Chr(34) & ")")
        frmSetupLoading.Close()
    End Sub

    Public Sub CreateNewInstatObject()
        RunScript(strInstatDataObject & " <- instat_object$new()")
        bInstatObjectExists = True
    End Sub

    Public Sub FillListView(lstView As ListView, strType As String, Optional lstIncludedDataTypes As List(Of KeyValuePair(Of String, String())) = Nothing, Optional lstExcludedDataTypes As List(Of KeyValuePair(Of String, String())) = Nothing, Optional strDataFrameName As String = "", Optional strHeading As String = "Variables", Optional strExcludedItems As String() = Nothing)
        Dim vecColumns As GenericVector
        Dim chrCurrColumns As CharacterVector
        Dim i As Integer
        Dim grps As New ListViewGroup
        Dim clsGetItems As New RFunction
        Dim clsIncludeList As New RFunction
        Dim clsExcludeList As New RFunction
        Dim kvpInclude As KeyValuePair(Of String, String())
        Dim kvpExclude As KeyValuePair(Of String, String())

        If bInstatObjectExists Then
            Select Case strType
                Case "column"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_column_names")
                Case "metadata"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_metadata_fields")
                Case "filter"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_filter_names")
                Case "object"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_object_names")
                Case "model"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_model_names")
                Case "graph"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_graph_names")
            End Select
            clsGetItems.AddParameter("as_list", "TRUE")
            lstView.Clear()
            lstView.Groups.Clear()
            lstView.Columns.Add(strHeading)

            If lstIncludedDataTypes.Count > 0 Then
                clsIncludeList.SetRCommand("list")
                For Each kvpInclude In lstIncludedDataTypes
                    clsIncludeList.AddParameter(kvpInclude.Key, GetListAsRString(kvpInclude.Value.ToList(), bWithQuotes:=False))
                Next
                clsGetItems.AddParameter("include", clsRFunctionParameter:=clsIncludeList)
            End If
            If lstExcludedDataTypes.Count > 0 Then
                clsExcludeList.SetRCommand("list")
                For Each kvpExclude In lstExcludedDataTypes
                    clsExcludeList.AddParameter(kvpExclude.Key, GetListAsRString(kvpExclude.Value.ToList(), bWithQuotes:=False))
                Next
                clsGetItems.AddParameter("exclude", clsRFunctionParameter:=clsExcludeList)
            End If
            If strDataFrameName <> "" Then
                clsGetItems.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
            End If
            If strExcludedItems IsNot Nothing AndAlso strExcludedItems.Count > 0 Then
                clsGetItems.AddParameter("excluded_items", GetListAsRString(strExcludedItems.ToList()))
            End If
            vecColumns = RunInternalScriptGetValue(clsGetItems.ToScript()).AsList

            For i = 0 To vecColumns.Count - 1
                If vecColumns.Count > 1 Then
                    grps = New ListViewGroup(key:=vecColumns.Names(i), headerText:=vecColumns.Names(i))
                    lstView.Groups.Add(grps)
                End If
                chrCurrColumns = vecColumns(i).AsCharacter
                If chrCurrColumns IsNot Nothing Then
                    For j = 0 To chrCurrColumns.Count - 1
                        lstView.Items.Add(chrCurrColumns(j))
                        lstView.Items(j).Tag = vecColumns.Names(i)
                        If vecColumns.Count > 1 Then
                            lstView.Items(j).Group = lstView.Groups(i)
                        End If
                    Next
                End If
            Next
            'TODO Find out how to get this to set automatically ( Width = -2 almost works)
            lstView.Columns(0).Width = lstView.Width - 25
        End If
    End Sub

    Public Sub SelectColumnsWithMetadataProperty(ucrCurrentReceiver As ucrReceiverMultiple, strDataFrameName As String, strProperty As String, strValues As String())
        Dim vecColumns As GenericVector
        Dim chrCurrColumns As CharacterVector
        Dim i As Integer
        Dim clsGetItems As New RFunction
        Dim clsIncludeList As New RFunction
        Dim kvpInclude As KeyValuePair(Of String, String())

        kvpInclude = New KeyValuePair(Of String, String())(strProperty, strValues)

        If bInstatObjectExists Then
            clsGetItems.SetRCommand(strInstatDataObject & "$get_column_names")
            clsGetItems.AddParameter("as_list", "TRUE")
            If strDataFrameName <> "" Then
                clsGetItems.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
            End If
            clsIncludeList.SetRCommand("list")
            clsIncludeList.AddParameter(kvpInclude.Key, GetListAsRString(kvpInclude.Value.ToList(), bWithQuotes:=False))
            clsGetItems.AddParameter("include", clsRFunctionParameter:=clsIncludeList)
            vecColumns = RunInternalScriptGetValue(clsGetItems.ToScript()).AsList
            ucrCurrentReceiver.Clear()
            For i = 0 To vecColumns.Count - 1
                chrCurrColumns = vecColumns(i).AsCharacter
                ucrCurrentReceiver.Add(chrCurrColumns.ToArray())
            Next
        End If
    End Sub

    Public Function GetListAsRString(lstStrings As List(Of String), Optional bWithQuotes As Boolean = True) As String
        Dim strTemp As String = ""
        Dim i As Integer
        If lstStrings.Count = 1 Then
            If bWithQuotes Then
                strTemp = Chr(34) & lstStrings.Item(0) & Chr(34)
            Else
                strTemp = lstStrings.Item(0)
            End If
        ElseIf lstStrings.Count > 1 Then
            strTemp = "c" & "("
            For i = 0 To lstStrings.Count - 1
                If i > 0 Then
                    strTemp = strTemp & ","
                End If
                If lstStrings.Item(i) <> "" Then
                    If bWithQuotes Then
                        strTemp = strTemp & Chr(34) & lstStrings.Item(i) & Chr(34)
                    Else
                        strTemp = strTemp & lstStrings.Item(i)
                    End If
                End If
            Next
            strTemp = strTemp & ")"
        End If
        Return strTemp
    End Function

    Public Function DataFrameExists(strDataFrameName As String) As Boolean
        Dim bExists As Boolean
        If clsEngine IsNot Nothing Then
            bExists = clsEngine.Evaluate(frmMain.clsRLink.strInstatDataObject & "$data_frame_exists(" & Chr(34) & strDataFrameName & Chr(34) & ")").AsLogical(0)
        End If
        Return bExists
    End Function

    Public Function GetDataFrameLength(strDataFrameName As String) As Integer
        Dim intLength As Integer
        If clsEngine IsNot Nothing Then
            intLength = clsEngine.Evaluate(frmMain.clsRLink.strInstatDataObject & "$get_data_frame_length(" & Chr(34) & strDataFrameName & Chr(34) & ")").AsInteger(0)
        End If
        Return intLength
    End Function

    Public Function GetDataFrameColumnCount(strDataFrameName As String) As Integer
        Dim intColumnCount As Integer
        If clsEngine IsNot Nothing Then
            intColumnCount = clsEngine.Evaluate(frmMain.clsRLink.strInstatDataObject & "$get_column_count(" & Chr(34) & strDataFrameName & Chr(34) & ")").AsInteger(0)
        End If
        Return intColumnCount
    End Function

    Public Function GetModelNames(Optional strDataFrameName As String = "") As List(Of String)
        Dim chrModelNames As CharacterVector
        Dim lstModelNames As New List(Of String)
        Dim clsGetModelNames As New RFunction
        Dim expModelNames As SymbolicExpression

        clsGetModelNames.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_model_names")
        If strDataFrameName <> "" Then
            clsGetModelNames.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        End If
        expModelNames = RunInternalScriptGetValue(clsGetModelNames.ToScript())
        If Not expModelNames.Type = Internals.SymbolicExpressionType.Null Then
            chrModelNames = expModelNames.AsCharacter()
            If chrModelNames.Length > 0 Then
                lstModelNames.AddRange(chrModelNames)
            End If
        End If
        Return lstModelNames
    End Function

    Public Function GetFilterNames(strDataFrameName As String) As List(Of String)
        Dim expFilterNames As SymbolicExpression
        Dim chrFilterNames As CharacterVector
        Dim lstFilterNames As New List(Of String)
        Dim clsGetFilterNames As New RFunction

        clsGetFilterNames.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_filter_names")
        clsGetFilterNames.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        expFilterNames = RunInternalScriptGetValue(clsGetFilterNames.ToScript())
        If Not expFilterNames.Type = Internals.SymbolicExpressionType.Null Then
            chrFilterNames = expFilterNames.AsCharacter()
            If chrFilterNames.Length > 0 Then
                lstFilterNames.AddRange(chrFilterNames)
            End If
        End If
        Return lstFilterNames
    End Function

    Public Function GetGraphNames(Optional strDataFrameName As String = "") As List(Of String)
        Dim chrGraphNames As CharacterVector
        Dim lstGraphNames As New List(Of String)
        Dim clsGetGraphNames As New RFunction
        Dim expGraphNames As SymbolicExpression

        clsGetGraphNames.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_graph_names")
        If strDataFrameName <> "" Then
            clsGetGraphNames.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        End If
        expGraphNames = RunInternalScriptGetValue(clsGetGraphNames.ToScript())
        If Not expGraphNames.Type = Internals.SymbolicExpressionType.Null Then
            chrGraphNames = expGraphNames.AsCharacter()
            If chrGraphNames.Length > 0 Then
                lstGraphNames.AddRange(chrGraphNames)
            End If
        End If
        Return lstGraphNames
    End Function

    Public Function GetDataType(strDataFrameName As String, strColumnName As String) As String
        Dim strDataType As CharacterVector
        strDataType = RunInternalScriptGetValue(frmMain.clsRLink.strInstatDataObject & "$get_data_type(data_name = " & Chr(34) & strDataFrameName & Chr(34) & ",col_name=" & Chr(34) & strColumnName & Chr(34) & ")").AsCharacter
        Return strDataType(0)
    End Function

End Class