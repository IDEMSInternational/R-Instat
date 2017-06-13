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

Imports RDotNet
Imports instat.Translations

Public Class dlgRemoveUnusedLevels
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsUnusedLevels, clstable, clsSum, clsFactorColumn As New RFunction
    Private clsTableOperation As New ROperator

    Private Sub dlgRemoveUnusedLevels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 40

        'Set receiver
        ucrReceiverFactorColumn.Selector = ucrSelectorFactorColumn
        ucrReceiverFactorColumn.SetMeAsReceiver()
        ucrReceiverFactorColumn.SetIncludedDataTypes({"factor"})

        ucrRemoveUnusedFactorLevels.SetReceiver(ucrReceiverFactorColumn)
        ucrRemoveUnusedFactorLevels.SetIncludeLevels(False)

        'Set selector data frame
        ucrSelectorFactorColumn.SetParameter(New RParameter("data_name", 0))
        ucrSelectorFactorColumn.SetParameterIsString()

        ucrReceiverFactorColumn.SetParameter(New RParameter("col_name", 1))
        ucrReceiverFactorColumn.SetParameterIsString()
    End Sub

    Private Sub SetDefaults()
        clsUnusedLevels = New RFunction
        clstable = New RFunction
        clsFactorColumn = New RFunction
        clsSum = New RFunction

        ucrSelectorFactorColumn.Reset()
        ucrInputUnusedLevels.SetName("")
        ucrInputUnusedLevels.Reset()

        clstable.SetRCommand("table")
        clsSum.SetRCommand("sum")
        clsFactorColumn.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsUnusedLevels.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$drop_unused_factor_levels")

        ucrBase.clsRsyntax.SetBaseRFunction(clsUnusedLevels)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)

        ucrSelectorFactorColumn.AddAdditionalCodeParameterPair(clsFactorColumn, ucrSelectorFactorColumn.GetParameter, iAdditionalPairNo:=1)
        ucrReceiverFactorColumn.AddAdditionalCodeParameterPair(clsFactorColumn, ucrReceiverFactorColumn.GetParameter, iAdditionalPairNo:=1)

        ucrSelectorFactorColumn.SetRCode(clsUnusedLevels, bReset)
        ucrReceiverFactorColumn.SetRCode(clsUnusedLevels, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverFactorColumn.IsEmpty() AndAlso Not ucrInputUnusedLevels.IsEmpty Then
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

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactorColumn.ControlContentsChanged, ucrInputUnusedLevels.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverFactorColumn_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactorColumn.ControlValueChanged, ucrRemoveUnusedFactorLevels.ControlValueChanged
        Dim iNumOutput As Integer

        If Not ucrReceiverFactorColumn.IsEmpty Then
            clstable.AddParameter("x", clsRFunctionParameter:=clsFactorColumn)
            clsTableOperation.SetOperation("==")
            clsTableOperation.AddParameter(clsRFunctionParameter:=clstable, iPosition:=0)
            clsTableOperation.AddParameter("threshhold", 0, iPosition:=1)

            clsSum.AddParameter("x", clsROperatorParameter:=clsTableOperation)

            iNumOutput = frmMain.clsRLink.RunInternalScriptGetValue(clsSum.ToScript).AsNumeric(0)
            ucrInputUnusedLevels.txtInput.BackColor = Color.Green
            If iNumOutput = 0 Then
                ucrInputUnusedLevels.SetName("no unused levels to remove")
                ucrInputUnusedLevels.txtInput.BackColor = Color.Red
            Else
                ucrInputUnusedLevels.SetName(iNumOutput & " unused levels will be removed")
                ucrInputUnusedLevels.txtInput.BackColor = Color.Green
            End If
        Else
            ucrInputUnusedLevels.txtInput.BackColor = Color.White
            clstable.RemoveParameterByName("x")
            ucrInputUnusedLevels.ResetText()
        End If
    End Sub
End Class