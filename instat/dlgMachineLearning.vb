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
Public Class dlgMachineLearning
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    'Functions
    Private clsTrainFunction As New RFunction
    Private Sub dlgMachineLearning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub InitialiseDialog()
        Dim dctMethod As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.iCallType = 2
        ucrSelectorMachineLearning.SetParameter(New RParameter("data", 0))
        ucrSelectorMachineLearning.SetParameterIsrfunction()

        ucrPnlExplanatoryVariable.AddRadioButton(rdoExplanatoryVariable)
        ucrPnlExplanatoryVariable.AddRadioButton(rdoExplanatoryModel)

        ucrReceiverExpressionFitModel.SetParameter(New RParameter("x", 1))
        ucrReceiverExpressionFitModel.Selector = ucrSelectorMachineLearning
        ucrReceiverExpressionFitModel.SetParameterIsString()

        ucrReceiverMultipleExplanatoryVariable.SetParameter(New RParameter("x", 1))
        ucrReceiverMultipleExplanatoryVariable.Selector = ucrSelectorMachineLearning
        ucrReceiverMultipleExplanatoryVariable.SetParameterIsString()
        ucrReceiverMultipleExplanatoryVariable.bWithQuotes = False
        ucrReceiverMultipleExplanatoryVariable.SetIncludedDataTypes({"numeric"})

        ucrReceiverResponseVariable.SetParameter(New RParameter("y", 2))
        ucrReceiverResponseVariable.Selector = ucrSelectorMachineLearning
        ucrReceiverResponseVariable.SetParameterIsString()
        ucrReceiverResponseVariable.bWithQuotes = False

        ucrInputMethod.SetParameter(New RParameter("method", 3))
        dctMethod.Add("lm", Chr(34) & "lm" & Chr(34))
        dctMethod.Add("nnet", Chr(34) & "nnet" & Chr(34))
        dctMethod.Add("knn", Chr(34) & "knn" & Chr(34))
        dctMethod.Add("rf", Chr(34) & "rf" & Chr(34))
        ucrInputMethod.SetItems(dctMethod)
        ucrInputMethod.SetDropDownStyleAsNonEditable()
        ucrInputMethod.SetDefaultState("lm")


        ucrPnlExplanatoryVariable.AddToLinkedControls(ucrReceiverMultipleExplanatoryVariable, {rdoExplanatoryVariable}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlExplanatoryVariable.AddToLinkedControls(ucrReceiverExpressionFitModel, {rdoExplanatoryModel}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

    End Sub

    Private Sub SetDefaults()
        clsTrainFunction = New RFunction

        ucrReceiverResponseVariable.SetMeAsReceiver()
        clsTrainFunction.AddParameter("method", "lm", iPosition:=3)
        rdoExplanatoryVariable.Checked = True

        clsTrainFunction.SetPackageName("caret")
        clsTrainFunction.SetRCommand("train")


    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorMachineLearning.SetRCode(clsTrainFunction, bReset)
        ucrReceiverResponseVariable.SetRCode(clsTrainFunction, bReset)
        ucrReceiverExpressionFitModel.SetRCode(clsTrainFunction, bReset)
        ucrReceiverMultipleExplanatoryVariable.SetRCode(clsTrainFunction, bReset)
        ucrReceiverResponseVariable.SetRCode(clsTrainFunction, bReset)
        ucrReceiverResponseVariable.SetRCode(clsTrainFunction, bReset)
        ucrInputMethod.SetRCode(clsTrainFunction, bReset)

        ucrBase.clsRsyntax.SetBaseRFunction(clsTrainFunction)
    End Sub

    Private Sub TestOKEnabled()

    End Sub
End Class