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
    Private clsFirstNrowFunction As New RFunction
    Private clsSecondNrowFunction As New RFunction
    Private clsSampleFunction, clsTrainDataFunction, clsTestDataFunction, clsPredictFunction, clsConfusionmatrixFunction As New RFunction
    Private clsSortFunction As New RFunction
    'Operators
    Private clsMultiplicationOperator, clsFirstCommaOperator, clsFirstOpeningOperator, clsSecondCommaOperator, clsNegativeOperator, clsSecondOpeningOperator, clsTrainClassesoperator, clsTestClassesOperator As New ROperator
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
        ucrReceiverMultipleExplanatoryVariable.bForceAsDataFrame = True
        ucrReceiverMultipleExplanatoryVariable.SetIncludedDataTypes({"numeric"})

        ucrReceiverResponseVariable.SetParameter(New RParameter("y", 2))
        ucrReceiverResponseVariable.Selector = ucrSelectorMachineLearning
        ucrReceiverResponseVariable.SetParameterIsString()

        ucrInputMethod.SetParameter(New RParameter("method", 3))
        dctMethod.Add("lm", Chr(34) & "lm" & Chr(34))
        dctMethod.Add("nnet", Chr(34) & "nnet" & Chr(34))
        dctMethod.Add("knn", Chr(34) & "knn" & Chr(34))
        dctMethod.Add("rf", Chr(34) & "rf" & Chr(34))
        ucrInputMethod.SetItems(dctMethod)
        ucrInputMethod.SetDropDownStyleAsNonEditable()
        ucrInputMethod.SetDefaultState("lm")

        ucrNudTrainSize.SetParameter(New RParameter("ratio", 2))
        ucrNudTrainSize.SetMinMax(0, 1.0)
        ucrNudTrainSize.SetDefaultState(1)
        ucrNudTrainSize.DecimalPlaces = 2

        ucrPnlExplanatoryVariable.AddToLinkedControls(ucrReceiverMultipleExplanatoryVariable, {rdoExplanatoryVariable}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlExplanatoryVariable.AddToLinkedControls(ucrReceiverExpressionFitModel, {rdoExplanatoryModel}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

    End Sub

    Private Sub SetDefaults()
        clsTrainFunction = New RFunction
        clsFirstNrowFunction = New RFunction
        clsSecondNrowFunction = New RFunction
        clsSampleFunction = New RFunction
        clsMultiplicationOperator = New ROperator
        clsSortFunction = New RFunction
        clsFirstCommaOperator = New ROperator
        clsFirstOpeningOperator = New ROperator
        clsSecondCommaOperator = New ROperator
        clsNegativeOperator = New ROperator
        clsSecondOpeningOperator = New ROperator
        clsTrainDataFunction = New RFunction
        clsTestDataFunction = New RFunction
        clsTrainClassesoperator = New ROperator
        clsTestClassesOperator = New ROperator
        clsPredictFunction = New RFunction
        clsConfusionmatrixFunction = New RFunction

        ucrReceiverResponseVariable.SetMeAsReceiver()
        rdoExplanatoryVariable.Checked = True

        'train test set ratio
        clsFirstNrowFunction.SetRCommand("new")

        clsSecondNrowFunction.SetRCommand("new")

        clsMultiplicationOperator.SetOperation("*")
        clsMultiplicationOperator.AddParameter("new", clsRFunctionParameter:=clsSecondNrowFunction, iPosition:=0)

        clsSampleFunction.SetRCommand("sample")
        clsSampleFunction.AddParameter("x", clsRFunctionParameter:=clsFirstNrowFunction, iPosition:=0)
        clsSampleFunction.AddParameter("size", clsROperatorParameter:=clsMultiplicationOperator, iPosition:=1)

        clsSortFunction.SetRCommand("sort")
        clsSortFunction.AddParameter("x", clsRFunctionParameter:=clsSampleFunction, iPosition:=0)
        clsSortFunction.SetAssignTo("ratio")

        'train set
        clsFirstCommaOperator.SetOperation(",")
        clsFirstCommaOperator.AddParameter("ratio", clsRFunctionParameter:=clsSortFunction, iPosition:=0)
        clsFirstCommaOperator.AddParameter("close", "]", iPosition:=1)

        clsFirstOpeningOperator.SetOperation("[")
        clsFirstOpeningOperator.AddParameter("comma", clsROperatorParameter:=clsFirstCommaOperator, iPosition:=1)
        clsFirstOpeningOperator.SetAssignTo("train")

        'test
        clsSecondCommaOperator.SetOperation(",")
        clsSecondCommaOperator.AddParameter("ratio", clsRFunctionParameter:=clsSortFunction, iPosition:=0)
        clsSecondCommaOperator.AddParameter("close", "]", iPosition:=1)

        clsSecondOpeningOperator.SetOperation("[-")
        clsSecondOpeningOperator.AddParameter("comma", clsROperatorParameter:=clsSecondCommaOperator, iPosition:=1)
        clsSecondOpeningOperator.SetAssignTo("train")

        'traindata
        clsTrainDataFunction.SetPackageName("dplyr")
        clsTrainDataFunction.SetRCommand("select")
        clsTrainDataFunction.AddParameter("train", clsROperatorParameter:=clsFirstOpeningOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsTrainDataFunction.SetAssignTo("Traindata")

        'trainclases
        clsTrainClassesoperator.SetOperation("$")
        clstrainClassesoperator.AddParameter("train", clsRFunctionParameter:=clsTrainDataFunction, iPosition:=0)
        clstrainClassesoperator.SetAssignTo("TrainClasses")

        clstestDataFunction.SetRCommand("select")
        clstestDataFunction.AddParameter("test", clsROperatorParameter:=clsSecondOpeningOperator, iPosition:=0)
        clstestDataFunction.SetAssignTo("Testdata")

        clsTestClassesOperator.SetOperation("$")
        clsTestClassesOperator.AddParameter("test", clsRFunctionParameter:=clstestDataFunction, iPosition:=0)
        clsTestClassesOperator.SetAssignTo("Testclasses")

        clsTrainFunction.SetPackageName("caret")
        clsTrainFunction.SetRCommand("train")
        clsTrainFunction.AddParameter("TrainData", clsRFunctionParameter:=clsTrainDataFunction, iPosition:=0)
        clsTrainFunction.AddParameter("TrainClasses", clsROperatorParameter:=clsTrainClassesoperator, iPosition:=1)
        clsTrainFunction.AddParameter("method", "knn", iPosition:=3)
        clsTrainFunction.SetAssignTo("Model")

        clsPredictFunction.SetPackageName("stats")
        clsPredictFunction.SetRCommand("predict")
        clsPredictFunction.AddParameter("object", clsRFunctionParameter:=clsTrainFunction, iPosition:=0)
        clsPredictFunction.AddParameter("test", clsROperatorParameter:=clsSecondOpeningOperator, iPosition:=1)
        clsPredictFunction.AddParameter("type", "raw", iPosition:=2)
        clsPredictFunction.SetAssignTo("Predicrion")


        clsConfusionmatrixFunction.SetPackageName("caret")
        clsConfusionmatrixFunction.SetRCommand("train")
        clsConfusionmatrixFunction.AddParameter("data", clsRFunctionParameter:=clsPredictFunction, iPosition:=0)
        clsConfusionmatrixFunction.AddParameter("rference", clsROperatorParameter:=clsTestClassesOperator, iPosition:=1)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverResponseVariable.AddAdditionalCodeParameterPair(clsTrainClassesoperator, New RParameter("label", iNewPosition:=1), iAdditionalPairNo:=1)
        ucrReceiverResponseVariable.AddAdditionalCodeParameterPair(clsTestClassesOperator, New RParameter("label", iNewPosition:=1), iAdditionalPairNo:=2)

        ucrSelectorMachineLearning.SetRCode(clsFirstNrowFunction, bReset)
        ucrReceiverResponseVariable.SetRCode(clsTrainFunction, bReset)
        ucrReceiverExpressionFitModel.SetRCode(clsTrainFunction, bReset)
        ucrReceiverMultipleExplanatoryVariable.SetRCode(clsTrainDataFunction, bReset)
        ucrReceiverResponseVariable.SetRCode(clsTrainFunction, bReset)
        ucrReceiverResponseVariable.SetRCode(clsTrainFunction, bReset)
        ucrInputMethod.SetRCode(clsTrainFunction, bReset)
        ucrNudTrainSize.SetRCode(clsMultiplicationOperator, bReset)

        ucrBase.clsRsyntax.SetBaseRFunction(clsTrainFunction)
    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub ucrSelectorMachineLearning_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorMachineLearning.ControlValueChanged
        clsFirstNrowFunction.AddParameter("data", ucrSelectorMachineLearning.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=0)
        clsSecondNrowFunction.AddParameter("data", ucrSelectorMachineLearning.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=0)
        clsFirstOpeningOperator.AddParameter("data", ucrSelectorMachineLearning.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=0)
        clsSecondOpeningOperator.AddParameter("data", ucrSelectorMachineLearning.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=0)
    End Sub
End Class