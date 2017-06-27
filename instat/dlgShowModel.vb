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
    Private bReset As Boolean = True
    Private bFirstLoad As Boolean = True
    Private clsProbabilities, clsQuantiles As New RFunction
    Private Sub dlgTablePlus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverExpressionForTablePlus.IsEmpty) OrElse (Not ucrInputProbabilities.IsEmpty) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub InitialiseDialog()
        '  ucrBase.clsRsyntax.iCallType = 2


        ucrBase.iHelpTopicID = 157
        ucrReceiverExpressionForTablePlus.Selector = ucrSelectorForDataFrame
        ucrReceiverExpressionForTablePlus.SetMeAsReceiver()
        ucrReceiverExpressionForTablePlus.SetIncludedDataTypes({"numeric"})

        ucrPnlDistTypes.AddRadioButton(rdoProbabilities)
        ucrPnlDistTypes.AddRadioButton(rdoQuantiles)

        ucrPnlDistTypes.AddFunctionNamesCondition(rdoQuantiles, "qdist")
        ucrPnlDistTypes.AddFunctionNamesCondition(rdoQuantiles, "pdist")

        ucrSaveGraphResults.SetDataFrameSelector(ucrSelectorForDataFrame.ucrAvailableDataFrames)
        ucrSaveGraphResults.SetSaveTypeAsColumn()
        ucrSaveGraphResults.SetIsComboBox()
        ucrSaveGraphResults.SetLabelText("Save Graph  Result:")


        ucrChkEnterValues.SetText("Enter value(s)")

        ucrChkDisplayGraphResults.SetParameter(New RParameter("plot"))
        ucrChkDisplayGraphResults.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkDisplayGraphResults.SetText("Display Graph Results")
    End Sub


    Private Sub SetDefaults()

        clsQuantiles = New RFunction
        clsProbabilities = New RFunction

        ucrSelectorForDataFrame.Reset()
        ucrInputProbabilities.Reset()
        ucrSaveGraphResults.Reset()

        clsProbabilities.SetPackageName("mosaic")
        clsQuantiles.SetPackageName("mosaic")

        clsProbabilities.SetRCommand("pdist")
        clsQuantiles.SetRCommand("qdist")

        ucrBase.clsRsyntax.SetBaseRFunction(clsQuantiles)



        receiverlabels()
        SaveResults()
        SetItems()
        TestOKEnabled()
    End Sub

    Private Sub SetItems()
        If rdoProbabilities.Checked Then
            ucrInputProbabilities.SetItems({"1", "0.1, 1, 3, 5, 10 ", "-2, -1, 0, 1, 2"})
            ucrInputProbabilities.SetName("1")
        Else
            ucrInputProbabilities.SetItems({"0.5", "0.1, 0.2, 0.4, 0.6, 0.8, 0.9 ", "0.2, 0.5, 0.8", " 0.5, 0.8, 0.9, 0.95, 0.99"})
            ucrInputProbabilities.SetName("0.5")
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub PqParameters()
        If rdoProbabilities.Checked Then
            If ucrChkEnterValues.Checked Then
                If Not ucrInputProbabilities.IsEmpty Then
                    ucrBase.clsRsyntax.AddParameter("q", "c(" & ucrInputProbabilities.GetText & ")")
                Else
                    ucrBase.clsRsyntax.RemoveParameter("q")
                End If
            ElseIf Not ucrChkEnterValues.Checked Then
                If Not ucrReceiverExpressionForTablePlus.IsEmpty Then
                    ucrBase.clsRsyntax.AddParameter("q", clsRFunctionParameter:=ucrReceiverExpressionForTablePlus.GetVariables)
                Else
                    ucrBase.clsRsyntax.RemoveParameter("q")
                End If
            End If
        Else
            If ucrChkEnterValues.Checked Then
                If ucrInputProbabilities.IsEmpty = False Then
                    ucrBase.clsRsyntax.AddParameter("p", "c(" & ucrInputProbabilities.GetText & ")")
                Else
                    ucrBase.clsRsyntax.RemoveParameter("p")
                End If
            ElseIf Not ucrChkEnterValues.Checked Then
                If Not ucrReceiverExpressionForTablePlus.IsEmpty Then
                    ucrBase.clsRsyntax.AddParameter("p", clsRFunctionParameter:=ucrReceiverExpressionForTablePlus.GetVariables)
                Else
                    ucrBase.clsRsyntax.RemoveParameter("p")
                End If
            End If
        End If
    End Sub

    Private Sub SaveResults()
        'If ucrSaveGraphResults.ucrChkSave.Checked AndAlso Not ucrChkEnterValues.Checked Then
        '    '  ucrInputNewColNameforTablePlus.Visible = True
        '    ucrBase.clsRsyntax.SetAssignTo(ucrInputNewColNameforTablePlus.GetText(), strTempColumn:=ucrInputNewColNameforTablePlus.GetText(), strTempDataframe:=ucrSelectorForDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bAssignToIsPrefix:=False)
        '    ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
        'Else
        '    ucrBase.clsRsyntax.RemoveAssignTo()
        '    ucrInputNewColNameforTablePlus.Visible = False
        '    ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        'End If
    End Sub

    Private Sub rdoProbabilitiesandQuantiles_CheckedChanged(sender As Object, e As EventArgs)
        SetItems()
        receiverlabels()
    End Sub

    Private Sub receiverlabels()
        ucrBase.clsRsyntax.ClearParameters()
        ucrBase.clsRsyntax.AddParameter("dist", Chr(34) & ucrDistributionsFOrTablePlus.clsCurrDistribution.strRName & Chr(34))
        PqParameters()
        If rdoProbabilities.Checked Then
            If Not ucrSaveGraphResults.bUserTyped Then
                ucrSaveGraphResults.SetPrefix("prob")
            End If
            lblQuantValues.Visible = True
            lblProbValues.Visible = False
            ucrBase.clsRsyntax.SetFunction("mosaic:: pdist")
        Else
            If Not ucrSaveGraphResults.bUserTyped Then
                ucrSaveGraphResults.SetPrefix("quant")
            End If
            lblQuantValues.Visible = False
            lblProbValues.Visible = True
            ucrBase.clsRsyntax.SetFunction("mosaic::qdist")
        End If
        For Each clstempparam In ucrDistributionsFOrTablePlus.clsCurrRFunction.clsParameters
            ucrBase.clsRsyntax.AddParameter(clstempparam.Clone())
        Next
    End Sub

    Private Sub ucrReceiverExpressionForTablePlus_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverExpressionForTablePlus.SelectionChanged
        receiverlabels()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputProbabilities_ContentsChanged() Handles ucrInputProbabilities.ContentsChanged
        receiverlabels()
        TestOKEnabled()
    End Sub

    Private Sub ucrDistributionsFOrTablePlus_ParameterChanged() Handles ucrDistributionsFOrTablePlus.ControlContentsChanged
        receiverlabels()
    End Sub

    'Private Sub Results()
    '    If chkSingleValues.Checked Then
    '        chkSaveResults.Visible = False
    '        ucrInputNewColNameforTablePlus.Visible = False
    '        ucrReceiverExpressionForTablePlus.Visible = False
    '        ucrSelectorForDataFrame.Reset()
    '        ucrInputProbabilities.Visible = True
    '    Else
    '        chkSaveResults.Visible = True
    '        ucrInputProbabilities.Reset()
    '        ucrReceiverExpressionForTablePlus.Visible = True
    '        ucrInputNewColNameforTablePlus.Visible = False
    '        ucrInputProbabilities.Visible = False
    '        ucrReceiverExpressionForTablePlus.Visible = True
    '    End If
    'End Sub
End Class