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

Public Class dlgRegressionSimple
    Public bFirstLoad As Boolean = True

    Private Sub dlgRegressionSimple_Load(sender As Object, e As EventArgs) Handles Me.Load
        ucrBase.clsRsyntax.SetFunction("lm")
        ucrBase.clsRsyntax.iCallType = 2
        ucrResponse.Selector = UcrSelectorByDataFrameAddRemoveSimpleReg
        ucrResponse.SetMeAsReceiver()
        ucrExplanatory.Selector = UcrSelectorByDataFrameAddRemoveSimpleReg
        ucrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=UcrSelectorByDataFrameAddRemoveSimpleReg.ucrAvailableDataFrames.clsCurrDataFrame)
        autoTranslate(Me)
        'To add correct help ID
        ucrBase.iHelpTopicID = 44

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
            'Else
            'ReopenDialog()
        End If

        TestOKEnabled()
    End Sub

    Private Sub SetDefaults()
        ucrResponse.Clear()
        ucrExplanatory.Clear()
        'include last lm
        'Test ok enabled
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        Dim strResponse As String = ""
        Dim strExplanatory As String = ""
        strResponse = ucrResponse.GetVariableNames(bWithQuotes:=False)
        strExplanatory = ucrExplanatory.GetVariableNames(bWithQuotes:=False)

        If ((Not (strResponse = "")) And (Not (strExplanatory = ""))) Then
            ucrBase.clsRsyntax.AddParameter("formula", strResponse & "~" & strExplanatory)


            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub



    Private Sub ucrResponse_Leave(sender As Object, e As EventArgs) Handles ucrResponse.Leave
        TestOKEnabled()
    End Sub

    Private Sub ucrExplanatory_Leave(sender As Object, e As EventArgs) Handles ucrExplanatory.Leave
        TestOKEnabled()
    End Sub
    Private Sub UcrSelectorByDataFrameAddRemoveSimpleReg_Leave(sender As Object, e As EventArgs) Handles UcrSelectorByDataFrameAddRemoveSimpleReg.Leave
        ucrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=UcrSelectorByDataFrameAddRemoveSimpleReg.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub cmdRegressionOptions_Click(sender As Object, e As EventArgs) Handles cmdRegressionOptions.Click
        ' sdgSimpleRegressionOptions.ShowDialog()
    End Sub

    Private Sub ucrResponse_SelectionChanged() Handles ucrResponse.SelectionChanged
        'Test ok enabled
        TestOKEnabled()
    End Sub
    Private Sub ucrExplanatory_SelectionChanged() Handles ucrExplanatory.SelectionChanged
        'Test ok enabled
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    'TO DO reopen dialogue given the options
End Class