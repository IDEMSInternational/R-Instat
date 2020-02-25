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
Public Class dlgGlance
    Public bfirstload As Boolean = True
    Public bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsRSyntax As RSyntax
    Private clsGlance As New RFunction

    Private Sub dlgGlance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bfirstload Then
            InitialiseDialog()
            bfirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()

        ucrModelReceiver.SetItemType("model")
        ucrModelReceiver.strSelectorHeading = "Model"
        ucrModelReceiver.SetParameterIsRFunction()
        ucrModelReceiver.Selector = ucrModelSelector

        ucrChkDisplayinOutput.SetText("Display in Output")
        ucrChkDisplayinOutput.Checked = True

        ucrModelSelector.SetParameter(New RParameter("data", 0))
        ucrModelSelector.SetParameterIsrfunction()

        ucrSaveNewDataFrame.SetPrefix("Newdataframe")
        ucrSaveNewDataFrame.SetIsComboBox()
        ucrSaveNewDataFrame.SetSaveTypeAsModel()
        ucrSaveNewDataFrame.SetCheckBoxText("Save New data frame")
        ucrSaveNewDataFrame.SetAssignToIfUncheckedValue("Last_Model")
        ucrSaveNewDataFrame.SetDataFrameSelector(ucrModelSelector.ucrAvailableDataFrames)
        ucrSaveNewDataFrame.ucrChkSave.Checked = False

        ucrModelReceiver.SetParameter(New RParameter("x", 0))
        ucrModelReceiver.Selector = ucrModelSelector
        ucrModelReceiver.SetMeAsReceiver()


    End Sub

    Private Sub SetDefaults()

        ucrSaveNewDataFrame.Reset()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 2
        clsGlance.SetRCommand("glance")
        clsGlance.SetPackageName("broom")
        ucrBase.clsRsyntax.SetBaseRFunction(clsGlance)
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrSaveNewDataFrame.SetRCode(ucrBase.clsRsyntax.clsBaseCommandString, bReset)
        ucrModelReceiver.SetRCode(clsGlance, bReset)
    End Sub

    Private Sub TestOKEnabled()
        'Tests when ok can be enabled
        If ucrModelReceiver.IsEmpty OrElse Not ucrSaveNewDataFrame.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub CoreControls_ControlContentsChanged() Handles ucrModelReceiver.ControlContentsChanged, ucrSaveNewDataFrame.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class
