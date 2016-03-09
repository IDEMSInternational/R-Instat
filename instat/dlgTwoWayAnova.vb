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
Public Class dlgNon_ParametricTwoWayAnova
    Public bFirstLoad As Boolean = True
    Public clsmodel, clsmodel1 As New ROperator

    Private Sub dlgTwoWayAnova_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If bFirstLoad Then
            InitialiseDialog()
            setDefaults()
        Else
            ReopenDialog()
        End If
        ucrBaseNPTwoWayANOVA.iHelpTopicID = 184

            autoTranslate(Me)

    End Sub

    Private Sub InitialiseDialog()
        ucrBaseNPTwoWayANOVA.clsRsyntax.SetFunction("friedman.test")
        ucrBaseNPTwoWayANOVA.clsRsyntax.iCallType = 2
        clsmodel.SetOperation("~")
        ucrReceiverDataColumn.Selector = ucrSelectorDataFrameAndVars
        ucrReceiverDataColumn.SetMeAsReceiver()
        ucrReceiverFirstFactor.Selector = ucrSelectorDataFrameAndVars
        ucrReceiverSecondFactor.Selector = ucrSelectorDataFrameAndVars
        ucrReceiverFirstFactor.SetDataType("factor")
        ucrReceiverSecondFactor.SetDataType("factor")

    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorDataFrameAndVars.Reset()
        ucrSelectorDataFrameAndVars.Focus()
        ucrReceiverDataColumn.SetMeAsReceiver()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorDataFrameAndVars_DataFrameChanged() Handles ucrSelectorDataFrameAndVars.DataFrameChanged
        ucrBaseNPTwoWayANOVA.clsRsyntax.AddParameter("data", clsRFunctionParameter:=ucrSelectorDataFrameAndVars.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub Fillformula()
        clsmodel1.SetOperation("+")
        clsmodel1.bBrackets = False
        clsmodel1.SetParameter(True, clsOp:=clsmodel)
        clsmodel1.SetParameter(False, strValue:=ucrReceiverSecondFactor.GetVariableNames(bWithQuotes:=False))
        ucrBaseNPTwoWayANOVA.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsmodel)
        TestOKEnabled()
        frmMain.clsRLink.RunScript(ucrBaseNPTwoWayANOVA.clsRsyntax.clsBaseFunction.ToScript(), 2)
    End Sub

    Private Sub ucrReceiverDataColumn_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDataColumn.SelectionChanged
        clsmodel.SetParameter(True, strValue:=ucrReceiverDataColumn.GetVariableNames(bWithQuotes:=False))
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverFirstFactor_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverFirstFactor.SelectionChanged
        clsmodel.SetParameter(False, strValue:=ucrReceiverFirstFactor.GetVariableNames(bWithQuotes:=False))
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverSecondFactor_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverSecondFactor.SelectionChanged
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverDataColumn.IsEmpty()) And (Not ucrReceiverFirstFactor.IsEmpty()) And (Not ucrReceiverSecondFactor.IsEmpty()) Then
            'ucrBaseNPTwoWayANOVA.clsRsyntax.AddParameter("formula", clsROperatorParameter:=newmodel)

            ucrBaseNPTwoWayANOVA.OKEnabled(True)

        Else
            ucrBaseNPTwoWayANOVA.OKEnabled(False)
        End If
    End Sub
    Private Sub ucrBaseNPTwoWayANOVA_clickReset() Handles ucrBaseNPTwoWayANOVA.Click
        SetDefaults()
    End Sub

    Private Sub ucrBaseNPTwoWayANOVA_ClickOk(sender As Object, e As EventArgs) Handles ucrBaseNPTwoWayANOVA.ClickOk
        Fillformula()
    End Sub



End Class