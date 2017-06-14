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
Public Class dlgShowModel
    Public bFirstLoad As Boolean = True
    Private Sub dlgTablePlus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If ucrDistributionsFOrTablePlus.bParametersFilled Then
            If ((Not ucrReceiverExpressionForTablePlus.IsEmpty) OrElse (Not ucrInputProbabilities.IsEmpty)) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 157
        ucrReceiverExpressionForTablePlus.Selector = ucrSelectorForDataFrame
        ucrReceiverExpressionForTablePlus.SetMeAsReceiver()
        ucrReceiverExpressionForTablePlus.SetIncludedDataTypes({"numeric"})
        ucrInputNewColNameforTablePlus.SetItemsTypeAsColumns()
        ucrInputNewColNameforTablePlus.SetDefaultTypeAsColumn()
        ucrBase.clsRsyntax.iCallType = 2
        ucrInputNewColNameforTablePlus.SetDataFrameSelector(ucrSelectorForDataFrame.ucrAvailableDataFrames)
        ucrInputNewColNameforTablePlus.SetValidationTypeAsRVariable()
        ucrInputProbabilities.SetValidationTypeAsNumericList()
    End Sub

    Private Sub SetDefaults()
        ucrSelectorForDataFrame.Reset()
        ucrInputProbabilities.Reset()
        ucrInputNewColNameforTablePlus.Reset()
        ucrDistributionsFOrTablePlus.SetRDistributions()
        ucrDistributionsFOrTablePlus.SetParameters()
        rdoQuantiles.Checked = True
        SetName()
        chkSingleValues.Checked = True
        chkGraphResults.Checked = True
        ReceiverLabels()
        Results()
        SaveResults()
        SetItems()
    End Sub

    Private Sub SetItems()
        If rdoProbabilities.Checked Then
            ucrInputProbabilities.SetItems({"1", "0.1, 1, 3, 5, 10 ", "-2, -1, 0, 1, 2"})
        Else
            ucrInputProbabilities.SetItems({"0.5", "0.1, 0.2, 0.4, 0.6, 0.8, 0.9 ", "0.2, 0.5, 0.8", " 0.5, 0.8, 0.9, 0.95, 0.99"})
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub SetName()
        If rdoProbabilities.Checked Then
            ucrInputProbabilities.SetName("1")
        Else
            ucrInputProbabilities.SetName("0.5")
        End If
    End Sub

    Private Sub chkSaveResults_CheckedChanged(sender As Object, e As EventArgs) Handles chkGraphResults.CheckedChanged, chkSaveResults.CheckedChanged
        ucrInputProbabilities.Reset()
        ReceiverLabels()
        SaveResults()
    End Sub

    Private Sub PqParameters()
        If rdoProbabilities.Checked Then
            If chkSingleValues.Checked Then
                If Not ucrInputProbabilities.IsEmpty Then
                    ucrBase.clsRsyntax.AddParameter("q", "c(" & ucrInputProbabilities.GetText & ")")
                Else
                    ucrBase.clsRsyntax.RemoveParameter("q")
                End If
            ElseIf Not chkSingleValues.Checked Then
                If Not ucrReceiverExpressionForTablePlus.IsEmpty Then
                    ucrBase.clsRsyntax.AddParameter("q", clsRFunctionParameter:=ucrReceiverExpressionForTablePlus.GetVariables)
                Else
                    ucrBase.clsRsyntax.RemoveParameter("q")
                End If
            End If
        Else
            If chkSingleValues.Checked Then
                If ucrInputProbabilities.IsEmpty = False Then
                    ucrBase.clsRsyntax.AddParameter("p", "c(" & ucrInputProbabilities.GetText & ")")
                Else
                    ucrBase.clsRsyntax.RemoveParameter("p")
                End If
            ElseIf Not chkSingleValues.Checked Then
                If Not ucrReceiverExpressionForTablePlus.IsEmpty Then
                    ucrBase.clsRsyntax.AddParameter("p", clsRFunctionParameter:=ucrReceiverExpressionForTablePlus.GetVariables)
                Else
                    ucrBase.clsRsyntax.RemoveParameter("p")
                End If
            End If
        End If
    End Sub

    Private Sub SaveResults()
        If chkSaveResults.Checked AndAlso Not chkSingleValues.Checked Then
            ucrInputNewColNameforTablePlus.Visible = True
            ucrBase.clsRsyntax.SetAssignTo(ucrInputNewColNameforTablePlus.GetText(), strTempColumn:=ucrInputNewColNameforTablePlus.GetText(), strTempDataframe:=ucrSelectorForDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bAssignToIsPrefix:=False)
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
        Else
            ucrBase.clsRsyntax.RemoveAssignTo()
            ucrInputNewColNameforTablePlus.Visible = False
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
    End Sub

    Private Sub DisplayGraphResults()
        If chkGraphResults.Checked Then
            ucrBase.clsRsyntax.AddParameter("plot", "TRUE")
            ucrBase.clsRsyntax.iCallType = 3
        Else
            ucrBase.clsRsyntax.AddParameter("plot", "FALSE")
            ucrBase.clsRsyntax.iCallType = 2
        End If
    End Sub
    Private Sub rdoProbabilitiesandQuantiles_CheckedChanged(sender As Object, e As EventArgs) Handles rdoProbabilities.CheckedChanged, rdoQuantiles.CheckedChanged
        SetName()
        SetItems()
        ReceiverLabels()
    End Sub

    Private Sub ReceiverLabels()
        ucrBase.clsRsyntax.ClearParameters()
        ucrBase.clsRsyntax.AddParameter("dist", Chr(34) & ucrDistributionsFOrTablePlus.clsCurrDistribution.strRName & Chr(34))
        PqParameters()
        DisplayGraphResults()
        If rdoProbabilities.Checked Then
            If Not ucrInputNewColNameforTablePlus.bUserTyped Then
                ucrInputNewColNameforTablePlus.SetPrefix("Prob")
            End If
            lblQuantValues.Visible = True
            lblProbValues.Visible = False
            ucrBase.clsRsyntax.SetFunction("mosaic:: pdist")
        Else
            If Not ucrInputNewColNameforTablePlus.bUserTyped Then
                ucrInputNewColNameforTablePlus.SetPrefix("Quant")
            End If
            lblQuantValues.Visible = False
            lblProbValues.Visible = True
            ucrBase.clsRsyntax.SetFunction("mosaic::qdist")
        End If
        For Each clstempparam In ucrDistributionsFOrTablePlus.clsCurrRFunction.clsParameters
            ucrBase.clsRsyntax.AddParameter(clstempparam.Clone())
        Next
    End Sub

    Private Sub ucrInputProbabilities_ContentsChanged() Handles ucrInputProbabilities.ContentsChanged
        ReceiverLabels()
        TestOKEnabled()
    End Sub

    Private Sub ucrDistributionsFOrTablePlus_ParameterChanged() Handles ucrDistributionsFOrTablePlus.ControlContentsChanged
        ReceiverLabels()
        TestOKEnabled()
    End Sub

    Private Sub chkSingleValues_CheckedChanged(sender As Object, e As EventArgs) Handles chkSingleValues.CheckedChanged
        Results()
        ReceiverLabels()
    End Sub

    Private Sub Results()
        If chkSingleValues.Checked Then
            chkSaveResults.Visible = False
            SetName()
            ucrInputNewColNameforTablePlus.Visible = False
            ucrReceiverExpressionForTablePlus.Visible = False
            ucrSelectorForDataFrame.Reset()
            ucrInputProbabilities.Visible = True
            ucrSelectorForDataFrame.SetVariablesVisible(False)
        Else
            chkSaveResults.Visible = True
            ucrInputProbabilities.SetName("")
            ucrInputProbabilities.Reset()
            ucrReceiverExpressionForTablePlus.Visible = True
            ucrInputNewColNameforTablePlus.Visible = False
            ucrInputProbabilities.Visible = False
            ucrSelectorForDataFrame.SetVariablesVisible(True)
        End If
    End Sub

    Private Sub ucrInputNewColNameforTablePlus_NameChanged() Handles ucrInputNewColNameforTablePlus.NameChanged
        SaveResults()
    End Sub

    Private Sub ucrReceiverExpressionForTablePlus_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverExpressionForTablePlus.ControlValueChanged
        ReceiverLabels()
        DisplayGraphResults()
    End Sub

    Private Sub ucrInputNewColNameforTablePlus_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputNewColNameforTablePlus.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class