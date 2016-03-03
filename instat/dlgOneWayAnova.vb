﻿' Instat-R
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

Public Class dlgOneWayANOVA

    Public bFirstLoad As Boolean = True
    Dim clsModel As New ROperator

    Private Sub dlgOneWayAnova_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaultSettings()
            bFirstLoad = False
        End If

    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction("aov")
        ucrBase.clsRsyntax.iCallType = 2
        ucrYVariate.Selector = ucrAddRemoveDataFrame
        ucrFactor.Selector = ucrAddRemoveDataFrame
        ucrFactor.SetDataType("factor")
        clsModel.SetOperation("~")

        autoTranslate(Me)

        ucrBase.iHelpTopicID = 315
    End Sub

    Private Sub SetDefaultSettings()
        ucrAddRemoveDataFrame.Reset()
        ucrAddRemoveDataFrame.Focus()
        ucrYVariate.SetMeAsReceiver()
        TestOKEnabled()

    End Sub


    Private Sub ucrYVariate_SelectionChanged(sender As Object, e As EventArgs) Handles ucrYVariate.SelectionChanged
        clsModel.SetParameter(True, strValue:=ucrYVariate.GetVariableNames(bWithQuotes:=False))
        TestOKEnabled()
    End Sub

    Private Sub ucrFactor_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFactor.SelectionChanged
        clsModel.SetParameter(False, strValue:=ucrFactor.GetVariableNames(bWithQuotes:=False))
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrYVariate.IsEmpty()) And (Not ucrFactor.IsEmpty()) Then
            ucrBase.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsModel)
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrAddRemoveDataframe_DataFrameChanged() Handles ucrAddRemoveDataFrame.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=ucrAddRemoveDataFrame.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgANOVAOptions.ShowDialog()
    End Sub
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaultSettings()
    End Sub
End Class