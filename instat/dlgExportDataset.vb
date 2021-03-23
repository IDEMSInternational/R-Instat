' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat
Imports instat.Translations
Public Class dlgExportDataset
    Dim bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultFunction As RFunction

    Private Sub dlgExportDataset_Load(sender As Object, e As EventArgs) Handles Me.Load
        'temporarily commented out because it overwrites lblConfirm text contents
        'autoTranslate(Me) 

        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
    End Sub

    Private Sub InitialiseDialog()
        'multiple reciever control that holds selected objects
        ucrReceiverMultipleDataFrames.SetParameter(New RParameter("x", 0))
        ucrReceiverMultipleDataFrames.SetParameterIsRFunction()
        ucrReceiverMultipleDataFrames.Selector = ucrSelectorDataFrames
        ucrReceiverMultipleDataFrames.SetMeAsReceiver()
        ucrReceiverMultipleDataFrames.strSelectorHeading = "Data Frames"
        ucrReceiverMultipleDataFrames.SetItemType("dataframe")

        'file path control 
        ucrFilePath.SetPathControlParameter(New RParameter("file", 1))
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction

        ucrSelectorDataFrames.Reset()
        chkSaveAsSingleFile.Checked = False
        chkSaveAsSingleFile.Visible = False
        cboFileType.SelectedIndex = 0
        lblConfirm.Visible = False
        ucrFilePath.ResetPathControl()

        clsDefaultFunction.SetPackageName("rio")
        clsDefaultFunction.SetRCommand("export")

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        'done this way because, the selected base function could be a command string or clsDefaultFunction.
        'so we don't want to reset the controls if command string was the base function on reloading the form
        If bReset Then
            ucrReceiverMultipleDataFrames.SetRCode(clsDefaultFunction, bReset)
            ucrFilePath.SetPathControlRcode(clsDefaultFunction, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrFilePath.IsEmpty AndAlso Not ucrReceiverMultipleDataFrames.IsEmpty Then
            ucrBase.OKEnabled(True)
            lblConfirm.Visible = True
        Else
            ucrBase.OKEnabled(False)
            lblConfirm.Visible = False
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
    End Sub

    Private Sub ucrReceiverMultipleDataFrames_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrReceiverMultipleDataFrames.ControlContentsChanged
        chkSaveAsSingleFile.Visible = ucrReceiverMultipleDataFrames.GetVariableNamesList().Length > 1
        ChangeFileControlsValues()
        ucrFilePath.Clear() 'will raise event FilePathChanged
    End Sub

    Private Sub chkSaveAsSingleFile_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveAsSingleFile.CheckedChanged
        ChangeFileControlsValues()
        ucrFilePath.Clear() 'will raise event FilePathChanged
    End Sub

    Private Sub cboFileExtension_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFileType.SelectedIndexChanged
        ucrFilePath.Clear() 'will raise event FilePathChanged
        ucrFilePath.FilePathDialogFilter = GetFilePathDialogFilterText(cboFileType.SelectedItem)
    End Sub

    ''' <summary>
    ''' this event will always be called when changes happen to the core controls of the form;
    ''' receiver, file path, save as single checkbox
    ''' </summary>
    Private Sub ucrFilePath_FilePathChanged() Handles ucrFilePath.FilePathChanged
        'if no or single data frame selected or save as single checked then just set the base function to the default
        If ucrReceiverMultipleDataFrames.GetVariableNamesList().Length <= 1 OrElse chkSaveAsSingleFile.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
            lblConfirm.Text = "Click Ok to Confirm the Export."
        Else
            'else, create a string command for exporting separate files to a directory.
            'note, as of 09/09/2020 rio didn't support exporting separate files in 1 command see issue #5590
            Dim lstItems As String() = ucrReceiverMultipleDataFrames.GetVariableNamesList(bWithQuotes:=False)
            Dim strCommand As String = ""
            For Each strItem In lstItems
                strCommand = strCommand & "rio::export( x = data_book$get_data_frame(data_name=""" & strItem & """), file = """ & ucrFilePath.FilePath & "/" & strItem & GetSelectedExtension(cboFileType.SelectedItem) & """)" & Environment.NewLine
            Next
            ucrBase.clsRsyntax.SetCommandString(strCommand)
            lblConfirm.Text = "Files with the same names will be overwritten." & Environment.NewLine & "Click Ok to Confirm the Export."
        End If
        TestOkEnabled()
    End Sub


    ''' <summary>
    ''' changes the file path and cboFileType control values; 
    ''' the FolderBrowse, DefaultFileSuggestionName, FilePathDialogFilter, selectable file types
    ''' the changed settings determine the behaviour of the file path contro
    ''' </summary>
    Private Sub ChangeFileControlsValues()
        Dim strPrevSelectedFileType As String = cboFileType.SelectedItem
        Dim iSelectedDataFrames As Integer = ucrReceiverMultipleDataFrames.GetVariableNamesList().Length
        ucrFilePath.FolderBrowse = False 'set file path control to open default SaveFileDialog prompt
        ucrFilePath.DefaultFileSuggestionName = ""
        ucrFilePath.FilePathDialogFilter = ""
        cboFileType.Items.Clear()


        ucrFilePath.FolderBrowse = iSelectedDataFrames > 1 AndAlso Not chkSaveAsSingleFile.Checked

        If iSelectedDataFrames > 1 AndAlso chkSaveAsSingleFile.Checked Then
            'file types currently supported insaving of multiple files into a single file
            cboFileType.Items.Add("Excel files (*.xlsx)")
            cboFileType.Items.Add("Serialized r objects (*.rds)")
            cboFileType.Items.Add("Saved r objects (*.RData)")
            cboFileType.Items.Add("HTML (*.html)")
        Else
            'file types supported
            cboFileType.Items.Add("Comma separated file (*.csv)")
            cboFileType.Items.Add("Excel files (*.xlsx)")
            cboFileType.Items.Add("TAB-separated data (*.tsv)")
            cboFileType.Items.Add("Pipe-separated data (*.psv)")
            cboFileType.Items.Add("Feather r / Python interchange format (*.feather)")
            cboFileType.Items.Add("Fixed-Width format data (*.fwf)")
            cboFileType.Items.Add("Serialized r objects (*.rds)")
            cboFileType.Items.Add("Saved r objects (*.RData)")
            cboFileType.Items.Add("JSON (*.json)")
            cboFileType.Items.Add("YAML (*.yml)")
            cboFileType.Items.Add("Stata (*.dta)")
            cboFileType.Items.Add("SPSS (*.sav)")
            cboFileType.Items.Add("XBASE database files (*.dbf)")
            cboFileType.Items.Add("Weka Attribute - Relation File Format (*.arff)")
            cboFileType.Items.Add("r syntax object (*.R)")
            cboFileType.Items.Add("Xml (*.xml)")
            cboFileType.Items.Add("HTML (*.html)")
            cboFileType.Items.Add("Matlab (*.mat)")
            cboFileType.Items.Add("SAS (*.sas7bdat)")
            cboFileType.Items.Add("SAS XPORT (*.xpt)")

            'set the default suggested name
            ucrFilePath.DefaultFileSuggestionName = ucrReceiverMultipleDataFrames.GetVariableNames(bWithQuotes:=False)
        End If

        'previous selected file type may not be there in the current combobox items
        cboFileType.SelectedItem = strPrevSelectedFileType
        If String.IsNullOrEmpty(cboFileType.SelectedItem) Then
            cboFileType.SelectedIndex = 0
        End If

        ucrFilePath.FilePathDialogFilter = GetFilePathDialogFilterText(cboFileType.SelectedItem)
    End Sub

    ''' <summary>
    ''' expected string format  "filetype (*.ext)" 
    ''' </summary>
    ''' <param name="strText"></param>
    ''' <returns></returns>
    Private Function GetFilePathDialogFilterText(strText As String) As String
        If String.IsNullOrEmpty(strText) Then
            Return ""
        End If
        'example of required format; Excel files (*.xlsx)|*.xlsx
        Dim arrStr() As String = strText.Split({"(", ")"}, StringSplitOptions.RemoveEmptyEntries)
        Return arrStr(0) & "(" & arrStr(1) & ")|" & arrStr(1)

    End Function

    ''' <summary>
    ''' expected string format  "filetype (*.ext)" 
    ''' </summary>
    ''' <param name="strText"></param>
    ''' <returns></returns>
    Private Function GetSelectedExtension(strText As String) As String
        If String.IsNullOrEmpty(strText) Then
            Return ""
        End If
        'example of required format;.xlsx
        Return strText.Split({"(", "*", ")"}, StringSplitOptions.RemoveEmptyEntries)(1)
    End Function

End Class
