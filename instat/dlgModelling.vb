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

Imports instat.Translations
Imports RDotNet

Public Class dlgModelling
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private strPackageName As String

    Private Sub dlgModelling_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOkEnabled()
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverForTestColumn.Selector = ucrSelectorModelling
        ucrReceiverMultiple.Selector = ucrSelectorModelling
        'ucrReceiverForTestColumn.SetMeAsReceiver()
        ucrChkIncludeArguments.SetText("Include Arguments")
        ucrBase.clsRsyntax.SetCommandString("")
        ucrSaveResult.SetPrefix("Model")
        ucrSaveResult.SetIsComboBox()
        ucrSaveResult.SetSaveTypeAsModel()
        ucrSaveResult.SetCheckBoxText("Save Model")
        ucrSaveResult.SetAssignToIfUncheckedValue("Last_Model")
        ucrSaveResult.SetDataFrameSelector(ucrSelectorModelling.ucrAvailableDataFrames)

        ucrInputComboRPackage.SetItems({"Stats", "extRemes", "lme4", "MASS"})
        ucrInputComboRPackage.SetDropDownStyleAsNonEditable()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorModelling.Reset()
        ucrReceiverForTestColumn.SetMeAsReceiver()
        ucrSaveResult.Reset()
        ucrSaveResult.ucrChkSave.Checked = False
        ucrBase.clsRsyntax.SetAssignTo("Last_Model", strTempModel:="Last_Model", strTempDataframe:=ucrSelectorModelling.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 2
        ucrChkIncludeArguments.Checked = False
        ucrInputComboRPackage.SetName("Stats")

    End Sub

    Private Sub SetRCodeForControls(bReset)

    End Sub

    Private Sub TestOkEnabled()
        If ucrSaveResult.IsComplete AndAlso Not ucrReceiverForTestColumn.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrInputComboRPackage_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboRPackage.ControlValueChanged
        Select Case ucrInputComboRPackage.GetText
            Case "Stats"
                strPackageName = "stat"
                grpStats.Visible = True
                grpextRemes.Visible = False
                grplme4.Visible = False
                grpMASS.Visible = False

            Case "extRemes"
                strPackageName = "extRemes"
                grpStats.Visible = False
                grpextRemes.Visible = True
                grplme4.Visible = False
                grpMASS.Visible = False

            Case "lme4"
                strPackageName = "lme4"
                grpStats.Visible = False
                grpextRemes.Visible = False
                grplme4.Visible = True
                grpMASS.Visible = False

            Case "MASS"
                strPackageName = "MASS"
                grpStats.Visible = False
                grpextRemes.Visible = False
                grplme4.Visible = False
                grpMASS.Visible = True
        End Select
    End Sub

    Private Sub ucrSaveResult_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveResult.ControlContentsChanged, ucrReceiverForTestColumn.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class