' Instat-R
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

Imports instat.Translations
Public Class dlgFactorDataFrame
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub ucrSelectorFactorDataFrame_Load(sender As Object, e As EventArgs) Handles ucrSelectorFactorDataFrame.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 162

        'ucrselector
        ucrSelectorFactorDataFrame.SetParameter(New RParameter("data_name", 0))
        ucrSelectorFactorDataFrame.SetParameterIsString()

        ' ucrreceiver
        ucrReceiverFactorDataFrame.SetParameter(New RParameter("factor", 1))
        ucrReceiverFactorDataFrame.strSelectorHeading = "Factors"
        ucrReceiverFactorDataFrame.SetParameterIsString()
        ucrReceiverFactorDataFrame.Selector = ucrSelectorFactorDataFrame
        ucrReceiverFactorDataFrame.SetMeAsReceiver()
        ucrReceiverFactorDataFrame.SetIncludedDataTypes({"factor"})

        'ucrnewname
        ucrInputFactorNames.SetParameter(New RParameter("factor_data_frame_name", 2))
        ucrInputFactorNames.SetValidationTypeAsRVariable()

        'chk boxes
        ucrChkAddCurrentContrasts.SetText("Add Current Contrasts")
        ucrChkAddCurrentContrasts.SetParameter(New RParameter("include_contrasts", 3))
        ucrChkAddCurrentContrasts.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkAddCurrentContrasts.SetRDefault("TRUE")

        ucrChkReplaceIfAlreadyExists.SetText("Replace if Already Exists")
        ucrChkReplaceIfAlreadyExists.SetParameter(New RParameter("replace", 4))
        ucrChkReplaceIfAlreadyExists.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkReplaceIfAlreadyExists.SetRDefault("TRUE")
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction

        ucrInputFactorNames.Reset()
        ucrSelectorFactorDataFrame.Reset()
        ucrInputFactorNames.ResetText()

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$create_factor_data_frame")

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())

        CheckAutoName()
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverFactorDataFrame.IsEmpty AndAlso Not ucrInputFactorNames.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrInputFactorNames_ContentsChanged() Handles ucrInputFactorNames.ControlContentsChanged, ucrReceiverFactorDataFrame.ControlContentsChanged, ucrSelectorFactorDataFrame.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrDataFrameToRename_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactorDataFrame.ControlValueChanged
        CheckAutoName()
    End Sub

    Private Sub CheckAutoName()
        If Not ucrReceiverFactorDataFrame.IsEmpty AndAlso Not ucrInputFactorNames.bUserTyped Then
            ucrInputFactorNames.SetName(ucrReceiverFactorDataFrame.GetVariableNames(False))
        End If
    End Sub
End Class