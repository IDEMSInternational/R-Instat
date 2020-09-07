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
    Private clsDefaultFunction As New RFunction

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
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()

        'ucrAvailableSheets.SetParameter(New RParameter("x", 0))
        'ucrAvailableSheets.SetParameterIsRFunction()
        'ucrAvailableSheets.SetText("Data Frame to Export:")


        'multiple reciever control that holds selected objects
        ucrReceiverMultipleDataFrames.SetParameter(New RParameter("x", 0))
        ucrReceiverMultipleDataFrames.SetParameterIsRFunction()
        ucrReceiverMultipleDataFrames.Selector = ucrSelectorDataFrames
        ucrReceiverMultipleDataFrames.SetMeAsReceiver()
        ucrReceiverMultipleDataFrames.strSelectorHeading = "Data Frames"
        ucrReceiverMultipleDataFrames.SetItemType("dataframe")


        ucrFilePath.SetPathControlParameter(New RParameter("file", 1))

        ucrChkSaveAsSingleFile.Text = "Save as single file"

        lblConfirm.Visible = False
        lblConfirm.ForeColor = Color.Green
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction

        ucrSelectorDataFrames.Reset()
        ucrChkSaveAsSingleFile.Checked = True
        ucrChkSaveAsSingleFile.Visible = False
        ucrFilePath.ResetPathControl()


        clsDefaultFunction.SetPackageName("rio")
        clsDefaultFunction.SetRCommand("export")

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverMultipleDataFrames.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrFilePath.SetPathControlRcode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
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
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverMultipleDataFrames_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrReceiverMultipleDataFrames.ControlContentsChanged
        'give a suggestive name from selected data frame and change the file filter accordingly
        If ucrReceiverMultipleDataFrames.GetVariableNamesList().Length = 1 Then
            ucrChkSaveAsSingleFile.Visible = False
            ucrFilePath.DefaultFileSuggestionName = ucrReceiverMultipleDataFrames.GetVariableNames(bWithQuotes:=False)
            ucrFilePath.FilePathDialogFilter = "Comma separated file (*.csv)|*.csv|Excel files (*.xlsx)|*.xlsx|TAB-separated data (*.tsv)|*.tsv|Pipe-separated data (*.psv)|*.psv|Feather r / Python interchange format (*.feather)|*.feather|Fixed-Width format data (*.fwf)|*.fwf|Serialized r objects (*.rds)|*.rds|Saved r objects (*.RData)|*.RData|JSON(*.json)|*.json|YAML(*.yml)|*.yml|Stata(*.dta)|*.dta|SPSS(*.sav)|*.sav|XBASE database files (*.dbf)|*.dbf| Weka Attribute - Relation File Format (*.arff)|*.arff|r syntax object (*.R)|*.R|Xml(*.xml)|*.xml|HTML(*.html)|*.html"
        Else
            ucrChkSaveAsSingleFile.Visible = True
            ucrFilePath.DefaultFileSuggestionName = ""
            ucrFilePath.FilePathDialogFilter = "Excel files (*.xlsx)|*.xlsx|Serialized r objects (*.rds)|*.rds|Saved r objects (*.RData)|*.RData|HTML(*.html)|*.html"
        End If

        'clear the file path contents. 
        ucrFilePath.Clear()
    End Sub

    Private Sub ucrFilePath_FilePathChanged() Handles ucrFilePath.FilePathChanged
        TestOkEnabled()
    End Sub

End Class
