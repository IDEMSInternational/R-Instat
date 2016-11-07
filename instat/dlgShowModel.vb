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
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If ((Not ucrReceiverExpressionForTablePlus.IsEmpty) OrElse (Not ucrInputProbabilities.IsEmpty)) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverExpressionForTablePlus.Selector = ucrSelectorForDataFrame
        ucrReceiverExpressionForTablePlus.SetMeAsReceiver()
        ucrReceiverExpressionForTablePlus.SetIncludedDataTypes({"numeric"})
        ucrInputNewColNameforTablePlus.SetItemsTypeAsColumns()
        ucrInputNewColNameforTablePlus.SetDefaultTypeAsColumn()
        ucrInputNewColNameforTablePlus.SetDataFrameSelector(ucrSelectorForDataFrame.ucrAvailableDataFrames)
        ucrInputNewColNameforTablePlus.SetValidationTypeAsRVariable()
    End Sub

    Private Sub SetDefaults()
        ucrSelectorForDataFrame.Reset()
        ucrInputProbabilities.Reset()
        rdoQuantiles.Checked = True
        chkSingleValues.Checked = True
        chkGraphResults.Checked = True
        DisplayGraphResults()
        results()
        ReceiverLabels()
        SaveResults()
        If rdoProbabilities.Checked Then
            ucrInputProbabilities.SetName("1")
        Else
            ucrInputProbabilities.SetName("0.5")
        End If
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub chkGraphResults_CheckedChanged(sender As Object, e As EventArgs) Handles chkGraphResults.CheckedChanged, chkSaveResults.CheckedChanged
        DisplayGraphResults()
        SaveResults()
        TestOKEnabled()
    End Sub

    Private Sub pqParameters()
        If rdoProbabilities.Checked Then
            ttprobability.SetToolTip(ucrInputProbabilities, "enter e.g 0.1, 1, 3, 5, 10 " & vbCrLf & "-2, -1, 0, 1, 2 ")
            If chkSingleValues.Checked Then
                If ucrInputProbabilities.IsEmpty = False Then
                    ucrBase.clsRsyntax.AddParameter("q", "c(" & ucrInputProbabilities.GetText & ")")
                Else
                    ucrBase.clsRsyntax.RemoveParameter("q")
                End If
            ElseIf chkSingleValues.Checked = False Then
                If ucrReceiverExpressionForTablePlus.IsEmpty = False Then
                    ucrBase.clsRsyntax.AddParameter("q", clsRFunctionParameter:=ucrReceiverExpressionForTablePlus.GetVariables)
                Else
                    ucrBase.clsRsyntax.RemoveParameter("q")
                End If
            End If
        Else

            ttprobability.SetToolTip(ucrInputProbabilities, "enter e.g 0.1, 0.2, 0.4, 0.6, 0.8, 0.9 " & vbCrLf & "0.2, 0.5, 0.8" & vbCrLf & " 0.5, 0.8, 0.9, 0.95, 0.99")
            If chkSingleValues.Checked Then
                If ucrInputProbabilities.IsEmpty = False Then
                    ucrBase.clsRsyntax.AddParameter("p", "c(" & ucrInputProbabilities.GetText & ")")
                Else
                    ucrBase.clsRsyntax.RemoveParameter("p")
                End If
            ElseIf chkSingleValues.Checked = False Then
                If ucrReceiverExpressionForTablePlus.IsEmpty = False Then
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
            ucrBase.clsRsyntax.iCallType = 0
        Else
            ucrBase.clsRsyntax.RemoveAssignTo()
            ucrBase.clsRsyntax.iCallType = 0
            ucrInputNewColNameforTablePlus.Visible = False
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
    End Sub
    Private Sub DisplayGraphResults()
        If chkGraphResults.Checked Then
            ucrBase.clsRsyntax.AddParameter("plot", "TRUE")
            ucrBase.clsRsyntax.iCallType = 0
        Else
            ucrBase.clsRsyntax.AddParameter("plot", "FALSE")
        End If
    End Sub
    Private Sub rdoProbabilitiesandQuantiles_CheckedChanged(sender As Object, e As EventArgs) Handles rdoProbabilities.CheckedChanged, rdoQuantiles.CheckedChanged
        ReceiverLabels()
    End Sub

    Private Sub ReceiverLabels()
        ucrBase.clsRsyntax.ClearParameters()
        ucrBase.clsRsyntax.AddParameter("dist", Chr(34) & ucrDistributionsFOrTablePlus.clsCurrDistribution.strRName & Chr(34))
        pqParameters()
        If rdoProbabilities.Checked Then
            ucrInputNewColNameforTablePlus.SetName("prob")
            lblQuantValues.Visible = True
            lblProbValues.Visible = False
            ucrBase.clsRsyntax.SetFunction("mosaic::pdist")

        Else
            ucrInputNewColNameforTablePlus.SetPrefix("Quant")
            ucrInputNewColNameforTablePlus.SetName("Quant")
            lblQuantValues.Visible = False
            lblProbValues.Visible = True
            ucrBase.clsRsyntax.SetFunction("mosaic::qdist")
        End If

        For Each clstempparam In ucrDistributionsFOrTablePlus.clsCurrRFunction.clsParameters
            ucrBase.clsRsyntax.AddParameter(clstempparam.Clone())
        Next
    End Sub

    Private Sub ucrReceiverExpressionForTablePlus_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverExpressionForTablePlus.SelectionChanged
        ReceiverLabels()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputProbabilities_ContentsChanged() Handles ucrInputProbabilities.ContentsChanged
        ReceiverLabels()
        TestOKEnabled()
    End Sub

    Private Sub ucrDistributionsFOrTablePlus_ParameterChanged() Handles ucrDistributionsFOrTablePlus.ParameterChanged
        ReceiverLabels()
    End Sub

    Private Sub chkSIngleValues_CheckedChanged(sender As Object, e As EventArgs) Handles chkSingleValues.CheckedChanged
        results()
        pqParameters()
    End Sub

    Private Sub results()
        If chkSingleValues.Checked Then
            chkSaveResults.Visible = False
            ucrInputNewColNameforTablePlus.Visible = False
            ucrReceiverExpressionForTablePlus.Visible = False
            ucrInputProbabilities.Visible = True
        Else
            chkSaveResults.Visible = True
            ucrReceiverExpressionForTablePlus.Visible = False
            ucrInputNewColNameforTablePlus.Visible = True
            ucrInputProbabilities.Visible = False
            ucrReceiverExpressionForTablePlus.Visible = True
        End If
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ttprobability.Popup

    End Sub
End Class
