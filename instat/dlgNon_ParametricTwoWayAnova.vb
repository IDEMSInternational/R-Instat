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
Public Class dlgNon_ParametricTwoWayAnova
    Public bFirstLoad As Boolean = True
    Dim clsModel, clsModel1 As New ROperator

    Private Sub dlgTwoWayANOVA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()

        ucrBaseNPTwoWayANOVA.clsRsyntax.SetFunction("friedman.test")
        ucrBaseNPTwoWayANOVA.clsRsyntax.iCallType = 2
        clsModel.SetOperation("~")
        clsModel1.SetOperation("|")
        ucrReceiverDataColumn.Selector = ucrSelectorDataFrameAndVars
        ucrReceiverFirstFactor.Selector = ucrSelectorDataFrameAndVars
        ucrReceiverSecondFactor.Selector = ucrSelectorDataFrameAndVars
        ucrBaseNPTwoWayANOVA.iHelpTopicID = 184
        ucrReceiverFirstFactor.SetDataType("factor")
        ucrReceiverSecondFactor.SetDataType("factor")

    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorDataFrameAndVars.Reset()
        ucrReceiverDataColumn.SetMeAsReceiver()
        ucrSelectorDataFrameAndVars.Focus()
        TestOKEnabled()
    End Sub

    Public Sub TestOKEnabled()
        If (Not ucrReceiverDataColumn.IsEmpty()) And (Not ucrReceiverFirstFactor.IsEmpty()) And (Not ucrReceiverSecondFactor.IsEmpty()) Then
            clsModel1.bBrackets = False
            clsModel1.AddParameter(iPosition:=0, clsROperatorParameter:=clsModel)

            ucrBaseNPTwoWayANOVA.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsModel1)
            ucrBaseNPTwoWayANOVA.OKEnabled(True)

        Else
            ucrBaseNPTwoWayANOVA.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrSelectorDataFrameAndVars_DataFrameChanged() Handles ucrSelectorDataFrameAndVars.DataFrameChanged
        ucrBaseNPTwoWayANOVA.clsRsyntax.AddParameter("data", clsRFunctionParameter:=ucrSelectorDataFrameAndVars.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrReceiverDataColumn_SelectionChanged() Handles ucrReceiverDataColumn.SelectionChanged
        clsModel.AddParameter(iPosition:=0, strParameterValue:=ucrReceiverDataColumn.GetVariableNames(bWithQuotes:=False))
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverFirstFactor_SelectionChanged() Handles ucrReceiverFirstFactor.SelectionChanged
        clsModel.AddParameter(strParameterValue:=ucrReceiverFirstFactor.GetVariableNames(bWithQuotes:=False))
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverSecondFactor_SelectionChanged() Handles ucrReceiverSecondFactor.SelectionChanged
        clsModel1.AddParameter(strParameterValue:=ucrReceiverSecondFactor.GetVariableNames(bWithQuotes:=False))
        TestOKEnabled()
    End Sub

    Private Sub ucrBaseNPTwoWayANOVA_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseNPTwoWayANOVA.ClickReset
        SetDefaults()
    End Sub
End Class