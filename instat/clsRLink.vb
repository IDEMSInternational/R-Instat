' Instat+R
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
    Public fOutput As Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
    Public clrOutput As Color = Color.Blue
    '
    Public fComments As Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
    Public clrComments As Color = Color.Green

    Public Sub New(Optional bWithInstatObj As Boolean = False, Optional bWithClimsoft As Boolean = False)
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

    Public Sub SetLog(tempLog As TextBox)
        txtLog = tempLog
        bLog = True
    End Sub

    Public Sub FillComboDataFrames(ByRef cboDataFrames As ComboBox, Optional bSetDefault As Boolean = True)
        Dim lstAvailableDataFrames As GenericVector
        Dim i As Integer

        If bInstatObjectExists Then
            lstAvailableDataFrames = clsEngine.Evaluate(strInstatDataObject & "$get_data_names()").AsList
            cboDataFrames.Items.Clear()
            For i = 0 To lstAvailableDataFrames.Length - 1
                cboDataFrames.Items.Add(lstAvailableDataFrames.AsCharacter(i))
            Next
        End If
        If bSetDefault Then
            cboDataFrames.Text = frmEditor.grdData.CurrentWorksheet.Name
        End If
    End Sub

    Public Sub FillColumnNames(strDataFrame As String, Optional ByRef cboColumns As ComboBox = Nothing, Optional ByRef lstColumns As ListView = Nothing)
        Dim lstCurrColumns As GenericVector
        Dim i As Integer

        If bInstatObjectExists Then
            If clsEngine IsNot Nothing Then
                lstCurrColumns = clsEngine.Evaluate(strInstatDataObject & "$get_column_names(" & Chr(34) & strDataFrame & Chr(34) & ")").AsList
                If cboColumns IsNot Nothing Then
                    cboColumns.Items.Clear()
                    For i = 0 To lstCurrColumns.Length - 1
                        cboColumns.Items.Add(lstCurrColumns.AsCharacter(i))
                    Next
                ElseIf lstColumns IsNot Nothing Then
                    lstColumns.Items.Clear()
                    If lstColumns.Columns.Count = 0 Then
                        lstColumns.Columns.Add("Available Data")
                    End If
                    For i = 0 To lstCurrColumns.Length - 1
                        lstColumns.Items.Add(lstCurrColumns.AsCharacter(i))
                    Next
                    lstColumns.Columns(0).Width = -2
                End If
            End If
        End If

    End Sub

    Public Function GetDefaultColumnNames(strPrefix As String)
        Dim lstNextDefaults As GenericVector = Nothing

        If bInstatObjectExists Then
            lstNextDefaults = clsEngine.Evaluate(strInstatDataObject & "$get_next_default_column_name(prefix = " & Chr(34) & strPrefix & Chr(34) & ")").AsList
        End If
        Return lstNextDefaults
    End Function

    Public Sub RunScript(strScript As String, Optional bReturnOutput As Integer = 0, Optional strComment As String = "")
        Dim strCapturedScript As String
        Dim temp As RDotNet.SymbolicExpression
        Dim strTemp As String
        Dim strOutput As String
        Dim strScriptWithComment As String
        Dim strSplitScript As String
        strOutput = ""
        Try
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
                clsEngine.Evaluate(strScript)
            ElseIf bReturnOutput = 1 Then
                temp = clsEngine.Evaluate(strScript)
                strTemp = String.Join(vbCrLf, temp.AsCharacter())
                strOutput = strOutput & strTemp & vbCrLf
            Else
                If strScript.Trim(vbCrLf).LastIndexOf(vbCrLf) = -1 Then
                    strCapturedScript = "capture.output(" & strScript & ")"
                Else
                    strSplitScript = Left(strScript, strScript.Trim(vbCrLf).LastIndexOf(vbCrLf))
                    If strSplitScript <> "" Then
                        clsEngine.Evaluate(strSplitScript)
                    End If
                    strSplitScript = Right(strScript, strScript.Length - strScript.Trim(vbCrLf).LastIndexOf(vbCrLf) - 2)
                    strCapturedScript = "capture.output(" & strSplitScript & ")"
                End If
                temp = clsEngine.Evaluate(strCapturedScript)
                strTemp = String.Join(vbCrLf, temp.AsCharacter())
                strOutput = strOutput & strTemp & vbCrLf
            End If
            If bOutput Then
                'txtOutput.Text = txtOutput.Text & strOutput
                'output format here
                AppendText(txtOutput, clrOutput, fOutput, strOutput)
            End If
        Catch
            MsgBox(strScript)
        End Try
        frmMain.clsGrids.UpdateGrids()
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


    Public Function GetData(strLabel As String) As DataFrame

        Me.clsEngine.Evaluate("temp<-" & strLabel).AsDataFrame()
        Return Me.clsEngine.GetSymbol("temp").AsDataFrame()

    End Function

    Public Function GetVariables(strLabel As String) As CharacterVector

        Return Me.clsEngine.Evaluate(strLabel).AsCharacter

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
            RunScript("setwd('" & frmMain.strStaticPath.Replace("\", "/") & strClimateObjectPath & "')")
            RunScript("source(" & Chr(34) & "SourcingScript.R" & Chr(34) & ")")
            RunScript(strClimateObject & "<-climate$new()")
            bClimateObjectExists = True
        End If
    End Sub

    Public Sub RSetup()
        'run script to load libraries
        RunScript("setwd('" & frmMain.strStaticPath.Replace("\", "/") & strInstatObjectPath & "')") 'This is bad the wd should be flexible and not automatically set to the instat object directory 
        RunScript("source(" & Chr(34) & "data_object.R" & Chr(34) & ")")
        RunScript("source(" & Chr(34) & "instat_object.R" & Chr(34) & ")")
        RunScript("source(" & Chr(34) & "Rsetup.R" & Chr(34) & ")")
    End Sub

    Public Sub CreateNewInstatObject()
        RunScript(strInstatDataObject & " <- instat_obj$new()")
        bInstatObjectExists = True
    End Sub

    Public Sub FillListView(lstView As ListView, Optional strDataType As String = "all", Optional strDataFrameName As String = "")
        Dim dfList As GenericVector
        Dim dfTemp As DataFrame
        Dim i As Integer
        Dim grps As New ListViewGroup
        If bInstatObjectExists Then
            lstView.Clear()
            lstView.Groups.Clear()
            If strDataType = "factor" Then
                lstView.Columns.Add("Available Factors")
            ElseIf strDataType = "numeric" Then
                lstView.Columns.Add("Available Numerics")
            ElseIf strDataType = "all" Then
                lstView.Columns.Add("Available Variables")
            End If
            If strDataFrameName = "" Then
                dfList = clsEngine.Evaluate(strInstatDataObject & "$get_variables_metadata(data_type = " & Chr(34) & strDataType & Chr(34) & ")").AsList
            Else
                dfList = clsEngine.Evaluate("list(" & strDataFrameName & "=" & strInstatDataObject & "$get_variables_metadata(data_name = " & Chr(34) & strDataFrameName & Chr(34) & ", data_type = " & Chr(34) & strDataType & Chr(34) & "))").AsList
                End If

            For i = 0 To dfList.Count - 1
                If dfList.Count = 1 Then
                    grps = New ListViewGroup(key:=dfList.Names(i), headerText:="")
                Else
                    grps = New ListViewGroup(key:=dfList.Names(i), headerText:=dfList.Names(i))
                End If
                If Not lstView.Groups.Contains(grps) Then
                    lstView.Groups.Add(grps)
                End If
                dfTemp = dfList(i).AsDataFrame()
                For j = 0 To dfTemp.RowCount - 1
                    lstView.Items.Add(dfTemp(j, 0)).Group = lstView.Groups(i)
                Next
            Next
            'TODO Find out how to get this to set automatically ( Width = -2 almost works)
            lstView.Columns(0).Width = 115
        End If
    End Sub

    Public Function GetDataFrameLength(strDataFrameName As String) As Integer
        Dim intLength As Integer
        If clsEngine IsNot Nothing Then
            intLength = clsEngine.Evaluate(frmMain.clsRLink.strInstatDataObject & "$length_of_data(" & Chr(34) & strDataFrameName & Chr(34) & ")").AsInteger(0)
        End If
        Return intLength
    End Function
End Class
