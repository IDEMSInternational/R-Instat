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
        autoTranslate(Me)
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
        chkSaveAsSingleFile.Checked = True
        chkSaveAsSingleFile.Visible = False
        cboFileExtension.SelectedIndex = 0
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
        SetSaveAsSeparateFilesControlsVisibilty()
        ucrFilePath.Clear() 'will raise event FilePathChanged
        ChangeFilePathControlSettings()
    End Sub

    ''' <summary>
    ''' this event will always be called when changes happen to the core controls of the form;
    ''' receiver, file path, save as single checkbox
    ''' </summary>
    Private Sub ucrFilePath_FilePathChanged() Handles ucrFilePath.FilePathChanged
        'if no or single data frame selected or save as single checked then just set the base function to the default
        If ucrReceiverMultipleDataFrames.GetVariableNamesList().Length <= 1 OrElse chkSaveAsSingleFile.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
        Else
            'else, create a string command for exporting separate files to a directory.
            'note, as of 09/09/2020 rio didn't support exporting separate files in 1 command see issue ##5590
            Dim lstItems As String() = ucrReceiverMultipleDataFrames.GetVariableNamesList(bWithQuotes:=False)
            Dim strCommand As String = ""
            For Each strItem In lstItems
                strCommand = strCommand & "rio::export( x = data_book$get_data_frame(data_name=""" & strItem & """), file = """ & ucrFilePath.FilePath & "/" & strItem & cboFileExtension.Text & """)" & Environment.NewLine
            Next
            ucrBase.clsRsyntax.SetCommandString(strCommand)
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrMultipleFilesControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleDataFrames.ControlContentsChanged
        SetSaveAsSeparateFilesControlsVisibilty()
        ChangeFilePathControlSettings()
        ucrFilePath.Clear() 'will raise event FilePathChanged
    End Sub

    Private Sub chkSaveAsSingleFile_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveAsSingleFile.CheckedChanged
        SetSaveAsSeparateFilesControlsVisibilty()
        ChangeFilePathControlSettings()
        ucrFilePath.Clear() 'will raise event FilePathChanged
    End Sub

    Private Sub cboFileExtension_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFileExtension.SelectedIndexChanged
        ChangeFilePathControlSettings()
        ucrFilePath.Clear() 'will raise event FilePathChanged
    End Sub

    ''' <summary>
    ''' changes the file path control settings; 
    ''' FolderBrowse, DefaultFileSuggestionName, FilePathDialogFilter
    ''' the changed settings determine the behaviour of the file path contro
    ''' </summary>
    Private Sub ChangeFilePathControlSettings()
        ucrFilePath.FolderBrowse = False 'set file path control to open default SaveFileDialog prompt
        ucrFilePath.DefaultFileSuggestionName = ""
        ucrFilePath.FilePathDialogFilter = ""

        'if its a single data frame selected. Just set file path settings to defaults and exit sub
        If ucrReceiverMultipleDataFrames.GetVariableNamesList().Length <= 1 Then
            ucrFilePath.DefaultFileSuggestionName = ucrReceiverMultipleDataFrames.GetVariableNames(bWithQuotes:=False)
            ucrFilePath.FilePathDialogFilter = "Comma separated file (*.csv)|*.csv|Excel files (*.xlsx)|*.xlsx|TAB-separated data (*.tsv)|*.tsv|Pipe-separated data (*.psv)|*.psv|Feather r / Python interchange format (*.feather)|*.feather|Fixed-Width format data (*.fwf)|*.fwf|Serialized r objects (*.rds)|*.rds|Saved r objects (*.RData)|*.RData|JSON(*.json)|*.json|YAML(*.yml)|*.yml|Stata(*.dta)|*.dta|SPSS(*.sav)|*.sav|XBASE database files (*.dbf)|*.dbf| Weka Attribute - Relation File Format (*.arff)|*.arff|r syntax object (*.R)|*.R|Xml(*.xml)|*.xml|HTML(*.html)|*.html|Matlab(*.mat)|*.mat|SAS(*.sas7bdat)|*.sas7bdat|SAS XPORT(*.xpt)|*.xpt"
            Exit Sub
        End If

        'if multiple data frames have been selected then do the following
        If chkSaveAsSingleFile.Checked Then
            'if checkbox is visible and checked, set the file extension filter to  3 file types; .xlsx,rds,rData
            ucrFilePath.FilePathDialogFilter = "Excel files (*.xlsx)|*.xlsx|Serialized r objects (*.rds)|*.rds|Saved r objects (*.RData)|*.RData|HTML(*.html)|*.html"
        Else
            'if checkbox not checked, set file path control to open folder browser dialog prompt instead of save file dialog prompt
            ucrFilePath.FolderBrowse = True
        End If
    End Sub

    ''' <summary>
    ''' changes the visibilty of the save as separate files controls; lblFileExtension, cboFileExtension
    ''' </summary>
    Private Sub SetSaveAsSeparateFilesControlsVisibilty()
        lblFileExtension.Visible = False
        cboFileExtension.Visible = False
        If ucrReceiverMultipleDataFrames.GetVariableNamesList().Length > 1 AndAlso Not chkSaveAsSingleFile.Checked Then
            lblFileExtension.Visible = True
            cboFileExtension.Visible = True
        End If
    End Sub


End Class
