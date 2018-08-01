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
Public Class dlgRecodeNumericIntoQuantiles
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private iLength As Integer
    Private clsBincodeFunction, clsQuantileFunction, clsSeqFunction As New RFunction
    Private Sub dlgRecodeNumericIntoQuantiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 537

        ucrReceiverNumeric.SetParameter(New RParameter("x", 0))
        ucrReceiverNumeric.SetParameterIsRFunction()
        ucrReceiverNumeric.Selector = ucrSelectorRecodeNumeric
        ucrReceiverNumeric.SetMeAsReceiver()
        ucrReceiverNumeric.SetDataType("numeric")
        ucrReceiverNumeric.strSelectorHeading = "Numerics"

        ucrNudQuantileAlgorithm.SetParameter(New RParameter("type", 1))
        ucrNudQuantileAlgorithm.SetMinMax(1, 9)
        ucrNudQuantileAlgorithm.SetRDefault(7)
        iLength = ucrNudNumberOfQuantiles.Value + 1

        ucrNudNumberOfQuantiles.SetParameter(New RParameter("length.out", 3))
        ucrNudNumberOfQuantiles.SetMinMax(1, Integer.MaxValue)

        ucrNewColumnName.SetPrefix("quantiles")
        ucrNewColumnName.SetSaveTypeAsColumn()
        ucrNewColumnName.SetDataFrameSelector(ucrSelectorRecodeNumeric.ucrAvailableDataFrames)
        ucrNewColumnName.SetIsComboBox()
        ucrNewColumnName.SetLabelText("New Column Name:")
    End Sub

    Private Sub SetDefaults()
        clsBincodeFunction = New RFunction
        clsQuantileFunction = New RFunction
        clsSeqFunction = New RFunction

        ucrSelectorRecodeNumeric.Reset()
        ucrNewColumnName.Reset()

        clsSeqFunction.SetRCommand("seq")
        clsSeqFunction.AddParameter("from", 0)
        clsSeqFunction.AddParameter("to", 1)
        clsSeqFunction.AddParameter("length.out", 4)

        clsQuantileFunction.SetRCommand("quantile")
        clsQuantileFunction.AddParameter(clsRFunctionParameter:=clsSeqFunction)
        clsQuantileFunction.AddParameter("na.rm", "TRUE")

        clsBincodeFunction.SetRCommand(".bincode")
        clsBincodeFunction.AddParameter("breaks", clsRFunctionParameter:=clsQuantileFunction)
        clsBincodeFunction.AddParameter("include.lowest", "TRUE")

        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnName.GetText, strTempDataframe:=ucrSelectorRecodeNumeric.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText)
        ucrBase.clsRsyntax.SetBaseRFunction(clsBincodeFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverNumeric.AddAdditionalCodeParameterPair(clsQuantileFunction, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrNewColumnName.SetRCode(clsBincodeFunction, bReset)
        ucrReceiverNumeric.SetRCode(clsBincodeFunction, bReset)
        ucrNudNumberOfQuantiles.SetRCode(clsSeqFunction, bReset)
        ucrNudQuantileAlgorithm.SetRCode(clsQuantileFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverNumeric.IsEmpty AndAlso ucrNewColumnName.IsComplete AndAlso ucrNudNumberOfQuantiles.GetText <> "" AndAlso ucrNudQuantileAlgorithm.GetText <> "" Then
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

    Private Sub ucrNudNumberOfQuantiles_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudNumberOfQuantiles.ControlValueChanged
        iLength = ucrNudNumberOfQuantiles.Value + 1
        clsSeqFunction.AddParameter("length.out", iLength)
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverNumeric.ControlContentsChanged, ucrNudQuantileAlgorithm.ControlContentsChanged, ucrNudNumberOfQuantiles.ControlContentsChanged, ucrNewColumnName.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class