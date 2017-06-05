'Instat-R
'Copyright (C) 2015
'This program is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'You should have received a copy of the GNU General Public License 
'along with this program.  If not, see <http://www.gnu.org/licenses/>.
'
Imports instat.Translations
Public Class dlgExportToOpenRefine
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsWriteToCSV As New RFunction
    Private clsDefaultRefine As New RFunction
    Private clsDefaultWrite As New RFunction

    Private Sub dlgExportToOpenRefine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 466

        ucrInputDatasetName.SetParameter(New RParameter("project.name", 0))
        ucrInputDatasetName.SetValidationTypeAsRVariable()

        ucrChkOpenBrowser.SetParameter(New RParameter("open.browser", 1))
        ucrChkOpenBrowser.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOpenBrowser.SetRDefault("FALSE")
        ucrChkOpenBrowser.SetText("Open Browser")
    End Sub

    Private Sub SetDefaults()
        clsDefaultRefine = New RFunction
        clsDefaultWrite = New RFunction

        ucrDataFrameOpenRefine.Reset()
        ucrInputDatasetName.Reset()
        NewDefaultName()

        clsDefaultWrite.SetPackageName("utils")
        clsDefaultWrite.SetRCommand("write.csv")
        clsDefaultWrite.AddParameter("row.names", "FALSE")

        clsDefaultRefine.SetPackageName("rrefine")
        clsDefaultRefine.SetRCommand("refine_upload")
        clsDefaultRefine.AddParameter("open.browser", "FALSE")

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRefine)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrInputDatasetName.IsEmpty AndAlso ucrDataFrameOpenRefine.cboAvailableDataFrames.Text <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        frmMain.clsRLink.RunScript(clsDefaultWrite.ToScript(), strComment:="Convert the data set to csv")
    End Sub

    Private Sub NewDefaultName()
        If (ucrDataFrameOpenRefine.cboAvailableDataFrames.Text <> "") AndAlso (Not ucrInputDatasetName.bUserTyped) Then
            ucrInputDatasetName.SetName(ucrDataFrameOpenRefine.cboAvailableDataFrames.SelectedItem & "_clean_up")
        End If
    End Sub

    Private Sub ucrOpenRefineDataFrame_ControlContentsChanged() Handles ucrDataFrameOpenRefine.ControlContentsChanged
        NewDefaultName()
        clsDefaultWrite.RemoveParameterByName("x")
        clsDefaultWrite.RemoveParameterByName("file")
        clsDefaultRefine.RemoveParameterByName("file")
        clsDefaultRefine.RemoveParameterByName("project.name")
        clsDefaultWrite.AddParameter("x", ucrDataFrameOpenRefine.cboAvailableDataFrames.SelectedItem)
        clsDefaultWrite.AddParameter("file", Chr(34) & ucrInputDatasetName.GetText() & ".csv" & Chr(34))
        clsDefaultRefine.AddParameter("file", Chr(34) & ucrInputDatasetName.GetText() & ".csv" & Chr(34))
        clsDefaultRefine.AddParameter("project.name", Chr(34) & ucrInputDatasetName.GetText() & Chr(34))
    End Sub

    Private Sub ucrOpenRefineDataFrame_ContentsChanged() Handles ucrInputDatasetName.ControlContentsChanged, ucrDataFrameOpenRefine.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class