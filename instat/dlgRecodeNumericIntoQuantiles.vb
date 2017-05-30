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
'You should have received a copy of the GNU General Public License k
'along with this program.  If not, see <http://www.gnu.org/licenses/>.


Imports instat.Translations
Public Class dlgRecodeNumericIntoQuantiles
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private ilength As Integer
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

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrNewColumnName.SetRCode(clsBincodeFunction, bReset)
        ucrReceiverNumeric.SetRCode(clsBincodeFunction, bReset)
        ucrNudNumberOfQuantiles.SetRCode(clsSeqFunction, bReset)
        ucrNudQuantileAlgorithm.SetRCode(clsQuantileFunction, bReset)

    End Sub

    Private Sub SetDefaults()
        ucrSelectorRecodeNumeric.Reset()
        ucrNewColumnName.Reset()
        clsBincodeFunction = New RFunction
        clsQuantileFunction = New RFunction
        clsSeqFunction = New RFunction

        clsSeqFunction.SetRCommand("seq")
        clsSeqFunction.AddParameter("from", 0)
        clsSeqFunction.AddParameter("to", 1)
        clsSeqFunction.AddParameter("length.out", 4)

        clsQuantileFunction.SetRCommand("quantile")
        clsQuantileFunction.AddParameter(clsRFunctionParameter:=clsSeqFunction)
        clsQuantileFunction.AddParameter("type", 7)
        clsQuantileFunction.AddParameter("na.rm", "TRUE")

        clsBincodeFunction.SetRCommand(".bincode")
        clsBincodeFunction.AddParameter("breaks", clsRFunctionParameter:=clsQuantileFunction)
        clsBincodeFunction.AddParameter("include.lowest", "TRUE")

        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnName.GetText, strTempDataframe:=ucrSelectorRecodeNumeric.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText)
        ucrBase.clsRsyntax.SetBaseRFunction(clsBincodeFunction)

    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 537
        ucrReceiverNumeric.Selector = ucrSelectorRecodeNumeric
        ucrReceiverNumeric.SetMeAsReceiver()
        ucrReceiverNumeric.SetDataType("numeric")
        ucrReceiverNumeric.SetParameter(New RParameter("x", 0))
        ucrReceiverNumeric.SetParameterIsRFunction()

        ucrNudNumberOfQuantiles.SetParameter(New RParameter("length.out", 3))
        ucrNudNumberOfQuantiles.SetMinMax(1, Integer.MaxValue)
        ucrNudQuantileAlgorithm.SetParameter(New RParameter("type", 1))
        ucrNudQuantileAlgorithm.SetMinMax(1, 9)
        ilength = ucrNudNumberOfQuantiles.Value + 1

        ucrNewColumnName.SetPrefix("quantiles")
        ucrNewColumnName.SetSaveTypeAsColumn()
        ucrNewColumnName.SetDataFrameSelector(ucrSelectorRecodeNumeric.ucrAvailableDataFrames)
        ucrNewColumnName.SetIsComboBox()
        ucrNewColumnName.SetLabelText("New Column Name:")
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverNumeric.IsEmpty AndAlso ucrNewColumnName.IsComplete AndAlso ucrNudNumberOfQuantiles.GetText() <> "" AndAlso ucrNudQuantileAlgorithm.GetText() <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrNudNumberOfQuantiles_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudNumberOfQuantiles.ControlValueChanged
        ilength = ucrNudNumberOfQuantiles.Value + 1
        clsSeqFunction.AddParameter("length.out", ilength)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverSingle_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverNumeric.ControlContentsChanged, ucrNudQuantileAlgorithm.ControlContentsChanged, ucrNudNumberOfQuantiles.ControlContentsChanged, ucrNewColumnName.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverNumeric_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverNumeric.ControlValueChanged
        clsQuantileFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverNumeric.GetVariables)
    End Sub
End Class