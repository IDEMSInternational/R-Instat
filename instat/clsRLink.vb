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
Imports unvell.ReoGrid

Public Class RLink
    ' R interface class. Each instance of the class has its own REngine instance
    Dim strClimateObjectPath As String = "/ClimateObject/R" 'new climateobject path
    Public strClimateObject As String = "ClimateObject"
    Dim strInstatObjectPath As String = "/InstatObject/R" 'path to the Instat object
    Public strInstatDataObject As String = "InstatDataObject"
    Public clsEngine As REngine
    Public rtbOutput As New ucrWPFRichTextBox
    Public txtLog As New TextBox
    Public bLog As Boolean = False
    Public bOutput As Boolean = False
    Public bClimateObjectExists As Boolean = False
    Public bInstatObjectExists As Boolean = False
    Public bClimsoftLinkExists As Boolean = False
    'sets the default fonts and colors

    Public bShowCommands As Boolean = True
    Public fScript As Font = New Font("Microsoft Sans Serif", 11, FontStyle.Regular)
    Public clrScript As Color = Color.Black
    '
    Public fOutput As Font = New Font(FontFamily.GenericMonospace, 11, FontStyle.Regular)
    Public clrOutput As Color = Color.Blue
    '
    Public fComments As Font = New Font("Microsoft Sans Serif", 11, FontStyle.Regular)
    Public clrComments As Color = Color.Green

    Public strGraphDisplayOption As String = "view_output_window"

    Private grdDataView As ReoGridControl

    Public Sub New(Optional bWithInstatObj As Boolean = False, Optional bWithClimsoft As Boolean = False)

    End Sub

    Public Sub SetEngine()
        Try
            REngine.SetEnvironmentVariables()
        Catch ex As Exception
            MsgBox(ex.Message & Environment.NewLine & "Ensure that the correct version of R is installed and restart the program.", MsgBoxStyle.Critical, "Cannot initialise R Link.")
            Application.Exit()
        End Try
        Try
            clsEngine = REngine.GetInstance()
        Catch ex As Exception
            MsgBox(ex.Message & Environment.NewLine & "Ensure that the correct version of R is installed and restart the program.", MsgBoxStyle.Critical, "Cannot initialise R Link.")
            Application.Exit()
        End Try
        clsEngine.Initialize()
    End Sub

    Public Sub SetDataViewGrid(grdNewDataGrid As ReoGridControl)
        grdDataView = grdNewDataGrid
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

    Public Sub SetOutput(tempOutput As ucrWPFRichTextBox)
        'TEST temporary
        rtbOutput = tempOutput
        bOutput = True
    End Sub

    Public Sub SetLog(tempLog As TextBox)
        txtLog = tempLog
        bLog = True
    End Sub

    Public Function GetDataFrameNames() As List(Of String)
        Dim chrDataFrameNames As CharacterVector = Nothing
        Dim lstDataFrameNames As New List(Of String)
        Dim clsGetDataNames As New RFunction
        Dim expNames As SymbolicExpression

        clsGetDataNames.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_names")
        If bInstatObjectExists Then
            expNames = RunInternalScriptGetValue(clsGetDataNames.ToScript(), bSilent:=True)
            If expNames IsNot Nothing AndAlso Not expNames.Type = Internals.SymbolicExpressionType.Null Then
                chrDataFrameNames = expNames.AsCharacter
                lstDataFrameNames.AddRange(chrDataFrameNames)
            End If
        End If
        Return lstDataFrameNames
    End Function

    Public Function GetColumnNames(strDataFrameName As String) As List(Of String)
        Dim chrCurrColumns As CharacterVector = Nothing
        Dim lstCurrColumns As New List(Of String)
        Dim clsGetColumnNames As New RFunction
        Dim expNames As SymbolicExpression

        If strDataFrameName <> "" AndAlso DataFrameExists(strDataFrameName) Then
            clsGetColumnNames.SetRCommand(strInstatDataObject & "$get_column_names")
            clsGetColumnNames.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
            expNames = RunInternalScriptGetValue(clsGetColumnNames.ToScript(), bSilent:=True)
            If expNames IsNot Nothing AndAlso Not expNames.Type = Internals.SymbolicExpressionType.Null Then
                chrCurrColumns = expNames.AsCharacter
                lstCurrColumns.AddRange(chrCurrColumns)
            End If
        End If
        Return lstCurrColumns
    End Function

    'bIncludeOverall = True includes an extra item in the combo box for overall i.e. items not at data frame level 
    Public Sub FillComboDataFrames(ByRef cboDataFrames As ComboBox, Optional bSetDefault As Boolean = True, Optional bIncludeOverall As Boolean = False, Optional strCurrentDataFrame As String = "")
        'This sub is filling the cboDataFrames with the relevant dat frame names (obtained by using GetDataFrameNames()) and potentially "[Overall]".  On thing it is doing, is setting the selected index in the cboDataFrames.
        'It is used on the ucrDataFrame in the FillComboBox sub.
        If bInstatObjectExists Then
            If bIncludeOverall Then
                cboDataFrames.Items.Add("[Overall]") 'Task/question: explain this.
            End If
            cboDataFrames.Items.AddRange(GetDataFrameNames().ToArray)
            AdjustComboBoxWidth(cboDataFrames)
            'Task/Question: From what I understood, if bSetDefault is true or if the strCurrentDataFrame (given as an argument) is actually not in cboDataFrames (is this case generic or should it never happen ?), then the selected Index should be the current worksheet.
            If (bSetDefault OrElse cboDataFrames.Items.IndexOf(strCurrentDataFrame) = -1) AndAlso (grdDataView IsNot Nothing) AndAlso (grdDataView.CurrentWorksheet IsNot Nothing) Then
                cboDataFrames.SelectedIndex = cboDataFrames.Items.IndexOf(grdDataView.CurrentWorksheet.Name)
            ElseIf cboDataFrames.Items.IndexOf(strCurrentDataFrame) <> -1 Then
                cboDataFrames.SelectedIndex = cboDataFrames.Items.IndexOf(strCurrentDataFrame)
            End If
        End If
    End Sub

    'TODO This is used above but will not be once ucrDataFrame uses proper controls
    ' Then this can be removed
    Public Shared Sub AdjustComboBoxWidth(cboCurrent As ComboBox)
        Dim iWidth As Integer = cboCurrent.DropDownWidth
        Dim graTemp As System.Drawing.Graphics = cboCurrent.CreateGraphics()
        Dim font As Font = cboCurrent.Font
        Dim iScrollBarWidth As Integer
        Dim iNewWidth As Integer

        If cboCurrent.Items.Count > cboCurrent.MaxDropDownItems Then
            iScrollBarWidth = SystemInformation.VerticalScrollBarWidth
        Else
            iScrollBarWidth = 0
        End If

        For Each strItem As String In cboCurrent.Items
            iNewWidth = CInt(graTemp.MeasureString(strItem, font).Width) + iScrollBarWidth
            iWidth = Math.Max(iWidth, iNewWidth)
        Next
        cboCurrent.DropDownWidth = iWidth
    End Sub

    Public Sub FillColumnNames(strDataFrame As String, ByRef cboColumns As ComboBox)
        Dim lstCurrColumns As New List(Of String)

        If strDataFrame <> "" Then
            lstCurrColumns = GetColumnNames(strDataFrame)
        End If
        cboColumns.Items.Clear()
        cboColumns.Items.AddRange(lstCurrColumns.ToArray)
    End Sub

    Public Sub FillColumnNames(strDataFrame As String, ByRef lstColumns As ListView)
        Dim lstCurrColumns As List(Of String)

        lstCurrColumns = GetColumnNames(strDataFrame)
        lstColumns.Items.Clear()
        If lstColumns.Columns.Count = 0 Then
            lstColumns.Columns.Add("Available Data")
        End If
        For Each strTemp In lstCurrColumns
            lstColumns.Items.Add(strTemp)
        Next
        lstColumns.Columns(0).Width = -2

    End Sub

    Public Function GetDefaultColumnNames(strPrefix As String, strDataFrameName As String) As String
        Dim strNextDefault As String = ""
        Dim clsGetNextDefault As New RFunction
        clsGetNextDefault.SetRCommand(strInstatDataObject & "$get_next_default_column_name")
        clsGetNextDefault.AddParameter("prefix", Chr(34) & strPrefix & Chr(34))
        clsGetNextDefault.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        If strDataFrameName <> "" AndAlso DataFrameExists(strDataFrameName) Then
            strNextDefault = RunInternalScriptGetValue(clsGetNextDefault.ToScript()).AsCharacter(0)
        End If
        Return strNextDefault
    End Function

    Public Function GetNextDefault(strPrefix As String, lstItems As List(Of String)) As String
        Dim strNextDefault As String
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
        If expPrefix IsNot Nothing AndAlso Not expPrefix.Type = Internals.SymbolicExpressionType.Null Then
            strNextDefault = expPrefix.AsCharacter(0)
        Else
            strNextDefault = ""
        End If
        Return strNextDefault
    End Function

    Public Sub RunScript(strScript As String, Optional iCallType As Integer = 0, Optional strComment As String = "")
        Dim strCapturedScript As String
        Dim temp As RDotNet.SymbolicExpression
        Dim strTemp As String
        Dim strOutput As String
        Dim strScriptWithComment As String
        Dim strSplitScript As String
        Dim strTempGraphsDirectory As String
        Dim clsPNGFunction As New RFunction

        strTempGraphsDirectory = System.IO.Path.Combine(System.IO.Path.GetTempPath() & "R_Instat_Temp_Graphs")
        strOutput = ""

        If strComment <> "" Then
            strComment = "# " & strComment
            strScriptWithComment = strComment & Environment.NewLine & strScript
        Else
            strScriptWithComment = strScript
        End If
        If bLog Then
            txtLog.Text = txtLog.Text & strScriptWithComment & Environment.NewLine
        End If
        If bOutput Then
            If strComment <> "" AndAlso bShowCommands Then
                rtbOutput.AppendText(clrComments, fComments, strComment & Environment.NewLine, clrScript, fScript, strScript.TrimEnd(Environment.NewLine.ToCharArray) & Environment.NewLine)
            Else
                If strComment <> "" Then
                    rtbOutput.AppendText(clrComments, fComments, strComment & Environment.NewLine, clrScript)
                End If
                If bShowCommands Then
                    rtbOutput.AppendText(clrScript, fScript, strScript & Environment.NewLine)
                End If
            End If
        End If

        'If strScript.Length > 2000 Then
        '    MsgBox("The following command cannot be run because it exceeds the character limit of 2000 characters for a command in R-Instat." & Environment.NewLine & strScript & Environment.NewLine & Environment.NewLine & "It may be possible to run the command directly in R.", MsgBoxStyle.Critical, "Cannot run command")
        If iCallType = 0 OrElse iCallType = 3 Then
            Try
                If iCallType = 3 Then
                    If strGraphDisplayOption = "view_output_window" OrElse strGraphDisplayOption = "view_separate_window" Then
                        clsPNGFunction.SetPackageName("grDevices")
                        clsPNGFunction.SetRCommand("png")
                        clsPNGFunction.AddParameter("filename", Chr(34) & System.IO.Path.Combine(strTempGraphsDirectory & "/Graph.png").Replace("\", "/") & Chr(34))
                        clsPNGFunction.AddParameter("width", 4000)
                        clsPNGFunction.AddParameter("height", 4000)
                        clsPNGFunction.AddParameter("res", 500)
                        clsEngine.Evaluate(clsPNGFunction.ToScript())
                        'need to boost resolution of the devices, it's not as good as with ggsave.
                    End If
                End If
                clsEngine.Evaluate(strScript)
                If iCallType = 3 Then
                    If strGraphDisplayOption = "view_output_window" OrElse strGraphDisplayOption = "view_separate_window" Then
                        'add an R script (maybe in the form of one of our methods) that copies divices to the temp directory, using the default device production... use dev.list() and dev.copy() with arguments device = the devices in the list and which = jpeg devices with different paths leading to the temp directory, using a paste() method to find different names for the files
                        clsEngine.Evaluate("graphics.off()") 'not quite sure if this would work, otherwise find the right way to close the appropriate devices.
                        'clsEngine.Evaluate("ggsave(" & Chr(34) & strTempGraphsDirectory.Replace("\", "/") & "Graph.jpg" & Chr(34) & ")")
                        'This sub is used to display graphics in the output window when necessary.
                        'This sub is checking the temp directory "R_Instat_Temp_Graphs", created during setup to see if there are any graphs to display. If there are some, then it sends them to the output window, and removes them from the directory.
                        'It is called from RLink at the end of RunScript.
                        Dim lstTempGraphFiles As ObjectModel.ReadOnlyCollection(Of String)
                        Dim iNumberOfFiles As Integer = -1
                        strTempGraphsDirectory = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "R_Instat_Temp_Graphs")
                        Try
                            lstTempGraphFiles = FileIO.FileSystem.GetFiles(strTempGraphsDirectory)
                        Catch e As Exception
                            lstTempGraphFiles = Nothing
                            MsgBox(e.Message & Environment.NewLine & "A problem occured in getting the content of the temporary graphs directory: " & strTempGraphsDirectory & " Possible exceptions are described here: https://msdn.microsoft.com/en-us/library/kf41fdf4.aspx", MsgBoxStyle.Critical)
                        End Try
                        If lstTempGraphFiles IsNot Nothing Then
                            iNumberOfFiles = CStr(lstTempGraphFiles.Count)
                        End If
                        If iNumberOfFiles > 0 Then
                            For Each strFileName As String In lstTempGraphFiles
                                If strGraphDisplayOption = "view_output_window" Then
                                    rtbOutput.DisplayGraph(strFileName)
                                ElseIf strGraphDisplayOption = "view_separate_window" Then
                                    frmMain.AddGraphForm(strFileName)
                                End If
                                Try
                                    My.Computer.FileSystem.DeleteFile(strFileName)
                                Catch e As Exception
                                    MsgBox(e.Message & Environment.NewLine & "A problem occured in attempting to delete the temporary file: " & strFileName & " The possible exceptions are described here: https://msdn.microsoft.com/en-us/library/tdx72k4b.aspx", MsgBoxStyle.Critical)
                                End Try
                            Next
                        End If
                    End If
                End If
            Catch e As Exception
                MsgBox(e.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
            End Try

        ElseIf iCallType = 1 OrElse iCallType = 4 Then
            Try
                temp = clsEngine.Evaluate(strScript)
                strTemp = String.Join(Environment.NewLine, temp.AsCharacter())
                strOutput = strOutput & strTemp & Environment.NewLine
                If iCallType = 4 Then

                End If
            Catch e As Exception
                MsgBox(e.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
            End Try
        Else
            If strScript.Trim(Environment.NewLine.ToCharArray).LastIndexOf(Environment.NewLine.ToCharArray) = -1 Then
                strCapturedScript = "capture.output(" & strScript & ")"
            Else
                strSplitScript = Left(strScript, strScript.Trim(Environment.NewLine.ToCharArray).LastIndexOf(Environment.NewLine.ToCharArray))
                If strSplitScript <> "" Then
                    Try
                        clsEngine.Evaluate(strSplitScript)
                    Catch e As Exception
                        MsgBox(e.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
                    End Try
                End If
                strSplitScript = Right(strScript, strScript.Length - strScript.Trim(Environment.NewLine.ToCharArray).LastIndexOf(Environment.NewLine.ToCharArray) - 2)
                strCapturedScript = "capture.output(" & strSplitScript & ")"
            End If
            Try
                temp = clsEngine.Evaluate(strCapturedScript)
                strTemp = String.Join(Environment.NewLine, temp.AsCharacter())
                strOutput = strOutput & strTemp & Environment.NewLine
            Catch e As Exception
                MsgBox(e.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
            End Try
        End If
        If bOutput AndAlso strOutput IsNot Nothing AndAlso strOutput <> "" Then
            If iCallType = 4 Then
                rtbOutput.AddIntoWebBrowser(strHtmlCode:=strOutput)
            Else
                rtbOutput.AppendText(clrOutput, fOutput, strOutput)
            End If
        End If
        frmMain.clsGrids.UpdateGrids()
    End Sub

    Public Function RunInternalScriptGetValue(strScript As String, Optional strVariableName As String = ".temp_value", Optional bSilent As Boolean = False) As SymbolicExpression
        Dim expTemp As SymbolicExpression
        Dim strCommand As String
        'Dim iSplitIndex As Integer
        'Dim iRemaining As Integer
        'Dim iStartPoint As Integer

        expTemp = Nothing
        strCommand = strVariableName & "<-" & strScript
        'If strCommand.Length > 2000 Then
        'MsgBox("The following command cannot be run because it exceeds the character limit of 2000 characters for a command in R-Instat." & Environment.NewLine & strScript & Environment.NewLine & Environment.NewLine & "It may be possible to run the command directly in R.", MsgBoxStyle.Critical, "Cannot run command")
        If clsEngine IsNot Nothing Then
            Try
                'iRemaining = strScript.Length
                'iStartPoint = 1000
                'While iRemaining > 1000
                '    iSplitIndex = strScript.Substring(iStartPoint).IndexOf(",") + iStartPoint
                '    iRemaining = strScript.Length - iSplitIndex
                '    strScript = strScript.Insert(iSplitIndex + 1, Environment.NewLine)
                '    iStartPoint = iSplitIndex + 1000
                'End While
                clsEngine.Evaluate(strCommand)
                expTemp = clsEngine.GetSymbol(strVariableName)
            Catch ex As Exception
                If Not bSilent Then
                    MsgBox(ex.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
                End If
            End Try
        End If
        Return expTemp
    End Function

    Public Function RunInternalScriptGetOutput(strScript As String, Optional bSilent As Boolean = False) As CharacterVector
        Dim chrTemp As CharacterVector
        Dim expTemp As SymbolicExpression

        expTemp = RunInternalScriptGetValue("capture.output(" & strScript & ")", bSilent:=bSilent)
        Try
            chrTemp = expTemp.AsCharacter()
        Catch ex As Exception
            If Not bSilent Then
                MsgBox(ex.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
            End If
            chrTemp = Nothing
        End Try
        Return chrTemp
    End Function

    Public Function RunInternalScript(strScript As String, Optional strVariableName As String = "", Optional bSilent As Boolean = False) As Boolean
        'Dim iSplitIndex As Integer
        'Dim iRemaining As Integer
        Dim strCommand As String

        strCommand = strVariableName & "<-" & strScript
        'If strCommand.Length > 2000 Then
        '    MsgBox("The following command cannot be run because it exceeds the character limit of 2000 characters for a command in R-Instat." & Environment.NewLine & strScript & Environment.NewLine & Environment.NewLine & "It may be possible to run the command directly in R.", MsgBoxStyle.Critical, "Cannot run command")
        '    Return False
        If clsEngine IsNot Nothing Then
            Try
                'iRemaining = strScript.Length
                'While iRemaining > 1000
                '    iSplitIndex = strScript.Substring(1000).IndexOf(",")
                '    iRemaining = strScript.Length - iSplitIndex
                '    strScript = strScript.Insert(iSplitIndex + 1, Environment.NewLine)
                'End While
                If strVariableName <> "" Then
                    clsEngine.Evaluate(strVariableName & "<-" & strScript)
                Else
                    clsEngine.Evaluate(strScript)
                End If
                Return True
            Catch ex As Exception
                If Not bSilent Then
                    MsgBox(ex.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
                End If
                Return False
            End Try
        Else
            Return False
        End If
    End Function


    Public Function GetDefaultDataFrameName(strPrefix As String, Optional iStartIndex As Integer = 1, Optional bIncludeIndex As Boolean = True) As String
        Dim strTemp As String
        Dim clsGetNextDataName As New RFunction
        Dim expName As SymbolicExpression

        clsGetNextDataName.SetRCommand(strInstatDataObject & "$get_next_default_dataframe_name")
        clsGetNextDataName.AddParameter("prefix", Chr(34) & strPrefix & Chr(34))
        clsGetNextDataName.AddParameter("start_index", iStartIndex)
        If Not bInstatObjectExists Then
            CreateNewInstatObject()
        End If
        If bIncludeIndex Then
            clsGetNextDataName.AddParameter("include_index", "TRUE")
        Else
            clsGetNextDataName.AddParameter("include_index", "FALSE")
        End If
        expName = RunInternalScriptGetValue(clsGetNextDataName.ToScript(), bSilent:=True)
        If expName IsNot Nothing AndAlso Not expName.Type = Internals.SymbolicExpressionType.Null Then
            strTemp = expName.AsCharacter(0)
        Else
            strTemp = ""
        End If
        Return strTemp
    End Function

    Public Sub RSetup()
        'run script to load libraries
        frmMain.Cursor = Cursors.WaitCursor
        frmSetupLoading.Show()
        RunScript("setwd('" & frmMain.strStaticPath.Replace("\", "/") & strInstatObjectPath & "')", strComment:="Setting the working directory") 'This is bad the wd should be flexible and not automatically set to the instat object directory 
        RunScript("source(" & Chr(34) & "Rsetup.R" & Chr(34) & ")", strComment:="Sourcing the Instat Object R code")
        CreateNewInstatObject()
        frmSetupLoading.Close()
        frmMain.Cursor = Cursors.Default
    End Sub

    Public Sub CreateNewInstatObject()
        RunScript(strInstatDataObject & " <- instat_object$new()", strComment:="Defining new Instat Object")
        bInstatObjectExists = True
    End Sub

    Public Sub FillListView(lstView As ListView, strType As String, Optional lstIncludedDataTypes As List(Of KeyValuePair(Of String, String())) = Nothing, Optional lstExcludedDataTypes As List(Of KeyValuePair(Of String, String())) = Nothing, Optional strDataFrameName As String = "", Optional strHeading As String = "Variables", Optional strExcludedItems As String() = Nothing, Optional strDatabaseQuery As String = "", Optional strNcFilePath As String = "")
        Dim vecColumns As GenericVector = Nothing
        Dim chrCurrColumns As CharacterVector
        Dim i As Integer
        Dim grps As New ListViewGroup
        Dim clsGetItems As New RFunction
        Dim clsIncludeList As New RFunction
        Dim clsExcludeList As New RFunction
        Dim kvpInclude As KeyValuePair(Of String, String())
        Dim kvpExclude As KeyValuePair(Of String, String())
        Dim expItems As SymbolicExpression

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
                Case "dataframe"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_data_names")
                Case "link"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_link_names")
                Case "key"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_key_names")
                Case "database_variables"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_database_variable_names")
                    clsGetItems.AddParameter("query", Chr(34) & strDatabaseQuery & Chr(34))
                Case "nc_dim_variables"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_nc_variable_names")
                    clsGetItems.AddParameter("file", Chr(34) & strNcFilePath & Chr(34))
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
            expItems = RunInternalScriptGetValue(clsGetItems.ToScript(), bSilent:=True)
            If expItems IsNot Nothing AndAlso Not expItems.Type = Internals.SymbolicExpressionType.Null Then
                vecColumns = expItems.AsList
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
        End If
    End Sub

    Public Sub SelectColumnsWithMetadataProperty(ucrCurrentReceiver As ucrReceiverMultiple, strDataFrameName As String, strProperty As String, strValues As String())
        Dim vecColumns As GenericVector
        Dim chrCurrColumns As CharacterVector
        Dim i As Integer
        Dim clsGetItems As New RFunction
        Dim clsIncludeList As New RFunction
        Dim kvpInclude As KeyValuePair(Of String, String())
        Dim lstItems As New List(Of KeyValuePair(Of String, String))
        Dim expColumns As SymbolicExpression

        kvpInclude = New KeyValuePair(Of String, String())(strProperty, strValues)
        ucrCurrentReceiver.Selector.LoadList()
        If bInstatObjectExists Then
            clsGetItems.SetRCommand(strInstatDataObject & "$get_column_names")
            clsGetItems.AddParameter("as_list", "TRUE")
            If strDataFrameName <> "" Then
                clsGetItems.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
            End If
            clsIncludeList.SetRCommand("list")
            clsIncludeList.AddParameter(kvpInclude.Key, GetListAsRString(kvpInclude.Value.ToList(), bWithQuotes:=False))
            clsGetItems.AddParameter("include", clsRFunctionParameter:=clsIncludeList)
            expColumns = RunInternalScriptGetValue(clsGetItems.ToScript(), bSilent:=True)
            If expColumns IsNot Nothing AndAlso Not expColumns.Type = Internals.SymbolicExpressionType.Null Then
                vecColumns = expColumns.AsList
            Else
                vecColumns = Nothing
            End If
            ucrCurrentReceiver.Clear()
            If vecColumns IsNot Nothing Then
                For i = 0 To vecColumns.Count - 1
                    chrCurrColumns = vecColumns(i).AsCharacter
                    If chrCurrColumns Is Nothing Then
                        Continue For
                    End If
                    For Each strColumn As String In chrCurrColumns
                        lstItems.Add(New KeyValuePair(Of String, String)(strDataFrameName, strColumn))
                    Next
                    ucrCurrentReceiver.AddMultiple(lstItems.ToArray())
                Next
            End If
        End If
        ucrCurrentReceiver.Selector.LoadList()
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
        Dim clsDataFrameExists As New RFunction
        Dim expExists As SymbolicExpression

        clsDataFrameExists.SetRCommand(strInstatDataObject & "$data_frame_exists")
        clsDataFrameExists.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        expExists = RunInternalScriptGetValue(clsDataFrameExists.ToScript(), bSilent:=True)
        If expExists IsNot Nothing AndAlso Not expExists.Type = Internals.SymbolicExpressionType.Null Then
            bExists = expExists.AsLogical(0)
        Else
            bExists = False
        End If
        Return bExists
    End Function

    Public Function GetDataFrameLength(strDataFrameName As String, Optional bUseCurrentFilter As Boolean = False) As Integer
        Dim iLength As Integer
        Dim clsDataFrameLength As New RFunction
        Dim expLength As SymbolicExpression

        clsDataFrameLength.SetRCommand(strInstatDataObject & "$get_data_frame_length")
        clsDataFrameLength.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        If bUseCurrentFilter Then
            clsDataFrameLength.AddParameter("use_current_filter", "TRUE")
        Else
            clsDataFrameLength.AddParameter("use_current_filter", "FALSE")
        End If
        expLength = RunInternalScriptGetValue(clsDataFrameLength.ToScript(), bSilent:=True)
        If expLength IsNot Nothing AndAlso Not expLength.Type = Internals.SymbolicExpressionType.Null Then
            iLength = expLength.AsInteger(0)
        Else
            iLength = 0
        End If
        Return iLength
    End Function

    Public Function GetDataFrameColumnCount(strDataFrameName As String) As Integer
        Dim iColumnCount As Integer
        Dim clsDataFrameColCount As New RFunction
        Dim expCount As SymbolicExpression

        clsDataFrameColCount.SetRCommand(strInstatDataObject & "$get_column_count")
        clsDataFrameColCount.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        expCount = RunInternalScriptGetValue(clsDataFrameColCount.ToScript(), bSilent:=True)
        If expCount IsNot Nothing AndAlso Not expCount.Type = Internals.SymbolicExpressionType.Null Then
            iColumnCount = expCount.AsInteger(0)
        Else
            iColumnCount = 0
        End If
        Return iColumnCount
    End Function

    Public Function GetModelNames(Optional strDataFrameName As String = "") As List(Of String)
        Dim chrModelNames As CharacterVector
        Dim lstModelNames As New List(Of String)
        Dim clsGetModelNames As New RFunction
        Dim expModelNames As SymbolicExpression

        clsGetModelNames.SetRCommand(strInstatDataObject & "$get_model_names")
        If strDataFrameName <> "" Then
            clsGetModelNames.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        End If
        expModelNames = RunInternalScriptGetValue(clsGetModelNames.ToScript(), bSilent:=True)
        If expModelNames IsNot Nothing AndAlso Not expModelNames.Type = Internals.SymbolicExpressionType.Null Then
            chrModelNames = expModelNames.AsCharacter()
            If chrModelNames.Length > 0 Then
                lstModelNames.AddRange(chrModelNames)
            End If
        End If
        Return lstModelNames
    End Function

    Public Function GetTableNames(Optional strDataFrameName As String = "") As List(Of String)
        Dim chrTableNames As CharacterVector
        Dim lstTableNames As New List(Of String)
        Dim clsGetTableNames As New RFunction
        Dim expTableNames As SymbolicExpression

        clsGetTableNames.SetRCommand(strInstatDataObject & "$get_table_names")
        If strDataFrameName <> "" Then
            clsGetTableNames.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        End If
        expTableNames = RunInternalScriptGetValue(clsGetTableNames.ToScript(), bSilent:=True)
        If expTableNames IsNot Nothing AndAlso Not expTableNames.Type = Internals.SymbolicExpressionType.Null Then
            chrTableNames = expTableNames.AsCharacter()
            If chrTableNames.Length > 0 Then
                lstTableNames.AddRange(chrTableNames)
            End If
        End If
        Return lstTableNames
    End Function

    Public Function GetFilterNames(strDataFrameName As String) As List(Of String)
        Dim expFilterNames As SymbolicExpression
        Dim chrFilterNames As CharacterVector
        Dim lstFilterNames As New List(Of String)
        Dim clsGetFilterNames As New RFunction

        clsGetFilterNames.SetRCommand(strInstatDataObject & "$get_filter_names")
        If strDataFrameName <> "" Then
            clsGetFilterNames.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        End If
        expFilterNames = RunInternalScriptGetValue(clsGetFilterNames.ToScript(), bSilent:=True)
        If expFilterNames IsNot Nothing AndAlso Not expFilterNames.Type = Internals.SymbolicExpressionType.Null Then
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

        clsGetGraphNames.SetRCommand(strInstatDataObject & "$get_graph_names")
        If strDataFrameName <> "" Then
            clsGetGraphNames.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        End If
        expGraphNames = RunInternalScriptGetValue(clsGetGraphNames.ToScript(), bSilent:=True)
        If expGraphNames IsNot Nothing AndAlso Not expGraphNames.Type = Internals.SymbolicExpressionType.Null Then
            chrGraphNames = expGraphNames.AsCharacter()
            If chrGraphNames.Length > 0 Then
                lstGraphNames.AddRange(chrGraphNames)
            End If
        End If
        Return lstGraphNames
    End Function

    Public Function GetDataType(strDataFrameName As String, strColumnName As String) As String
        Dim strDataType As String
        Dim clsGetDataType As New RFunction
        Dim expType As SymbolicExpression

        clsGetDataType.SetRCommand(strInstatDataObject & "$get_data_type")
        clsGetDataType.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        clsGetDataType.AddParameter("col_name", Chr(34) & strColumnName & Chr(34))
        expType = RunInternalScriptGetValue(clsGetDataType.ToScript(), bSilent:=True)
        If expType IsNot Nothing AndAlso Not expType.Type = Internals.SymbolicExpressionType.Null Then
            strDataType = expType.AsCharacter(0)
        Else
            strDataType = ""
        End If
        Return strDataType
    End Function

    Public Function GetColumnType(strDataName As String, strColumnName As String) As String
        Dim strDataType As String
        Dim clsGetColumnType As New RFunction
        Dim expDateType As SymbolicExpression

        clsGetColumnType.SetRCommand(strInstatDataObject & "$get_variables_metadata")
        clsGetColumnType.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
        clsGetColumnType.AddParameter("column", Chr(34) & strColumnName & Chr(34))
        clsGetColumnType.AddParameter("property", Chr(34) & "class" & Chr(34))
        expDateType = RunInternalScriptGetValue(clsGetColumnType.ToScript(), bSilent:=True)
        If expDateType IsNot Nothing AndAlso Not expDateType.Type = Internals.SymbolicExpressionType.Null Then
            strDataType = expDateType.AsCharacter(0)
        Else
            strDataType = ""
        End If
        Return strDataType
    End Function

    Public Function MakeValidText(strText As String) As String
        Dim strOut As String
        Dim clsMakeNames As New RFunction
        Dim expOut As SymbolicExpression

        clsMakeNames.SetRCommand("make.names")
        clsMakeNames.AddParameter("names", Chr(34) & strText & Chr(34))
        expOut = RunInternalScriptGetValue(clsMakeNames.ToScript(), bSilent:=True)
        If expOut IsNot Nothing AndAlso Not expOut.Type = Internals.SymbolicExpressionType.Null Then
            strOut = expOut.AsCharacter(0)
        Else
            strOut = ""
        End If
        Return strOut
    End Function

    Public Function IsValidText(strText As String) As String
        Dim strValidText As String
        Dim clsMakeNames As New RFunction

        strValidText = MakeValidText(strText)
        Return (strText = strValidText)
    End Function

    'Corruption analysis functions
    Public Function GetCorruptionContractDataFrameNames() As List(Of String)
        Dim clsGetDataNames As New RFunction
        Dim lstNames As List(Of String)
        Dim expDataNames As SymbolicExpression

        clsGetDataNames.SetRCommand(strInstatDataObject & "$get_corruption_contract_data_names")
        expDataNames = RunInternalScriptGetValue(clsGetDataNames.ToScript(), bSilent:=True)
        If expDataNames IsNot Nothing AndAlso Not expDataNames.Type = Internals.SymbolicExpressionType.Null Then
            lstNames = expDataNames.AsCharacter.ToList()
        Else
            lstNames = New List(Of String)
        End If
        Return lstNames
    End Function

    Public Function GetCorruptionColumnOfType(strDataName As String, strType As String) As String
        Dim clsGetColumnName As New RFunction
        Dim strColumn As String
        Dim expColumn As SymbolicExpression

        clsGetColumnName.SetRCommand(strInstatDataObject & "$get_corruption_column_name")
        clsGetColumnName.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
        clsGetColumnName.AddParameter("type", strType)
        expColumn = RunInternalScriptGetValue(clsGetColumnName.ToScript(), bSilent:=True)
        If expColumn IsNot Nothing AndAlso Not expColumn.Type = Internals.SymbolicExpressionType.Null Then
            strColumn = expColumn.AsCharacter(0)
        Else
            strColumn = ""
        End If
        Return strColumn
    End Function

    Public Function IsBinary(strDataName As String, strColumn As String) As Boolean
        Dim clsGetColumn As New RFunction
        Dim clsIsBinary As New RFunction
        Dim bIsBinary As Boolean
        Dim expBinary As SymbolicExpression

        clsGetColumn.SetRCommand(strInstatDataObject & "$get_columns_from_data")
        clsGetColumn.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
        clsGetColumn.AddParameter("col_names", Chr(34) & strColumn & Chr(34))
        clsIsBinary.SetRCommand("is.binary")
        clsIsBinary.AddParameter("x", clsRFunctionParameter:=clsGetColumn)
        expBinary = RunInternalScriptGetValue(clsIsBinary.ToScript())
        If expBinary IsNot Nothing AndAlso Not expBinary.Type = Internals.SymbolicExpressionType.Null Then
            bIsBinary = expBinary.AsLogical(0)
        Else
            bIsBinary = False
        End If
        Return bIsBinary
    End Function

    Public Function IsVariablesMetadata(strDataName As String, strProperty As String, Optional strColumn As String = "") As Boolean
        Dim clsIsVarMetadata As New RFunction
        Dim bIsVarMetadata As Boolean
        Dim expIsVar As SymbolicExpression

        clsIsVarMetadata.SetRCommand(strInstatDataObject & "$is_variables_metadata")
        clsIsVarMetadata.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
        If strColumn <> "" Then
            clsIsVarMetadata.AddParameter("column", Chr(34) & strColumn & Chr(34))
        End If
        clsIsVarMetadata.AddParameter("property", Chr(34) & strProperty & Chr(34))
        expIsVar = RunInternalScriptGetValue(clsIsVarMetadata.ToScript())
        If expIsVar IsNot Nothing AndAlso expIsVar.Type = Internals.SymbolicExpressionType.Null Then
            bIsVarMetadata = expIsVar.AsLogical(0)
        Else
            bIsVarMetadata = False
        End If
        Return bIsVarMetadata
    End Function
End Class