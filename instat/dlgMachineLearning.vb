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
    Private clsTrainTestSplitFunction As New RFunction
    Private clsTrainFunction As New RFunction
    Private clsTestFunction As New RFunction
    Private clsTrainDataFunction As New RFunction
    Private clsPredictFunction As New RFunction
    Private clsConfusionmatrixFunction As New RFunction
    'Operators
    Private clsTrainClassesoperator, clsTestClassesOperator As New ROperator
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
        ucrSelectorMachineLearning.SetParameter(New RParameter("x", 0))
        ucrSelectorMachineLearning.SetParameterIsrfunction()

        ucrPnlExplanatoryVariable.AddRadioButton(rdoExplanatoryVariable)
        ucrPnlExplanatoryVariable.AddRadioButton(rdoExplanatoryModel)

        ucrPnlModelType.AddRadioButton(rdoClassification)
        ucrPnlModelType.AddRadioButton(rdoRegression)

        ucrReceiverExpressionFitModel.SetParameter(New RParameter("x", 1))
        ucrReceiverExpressionFitModel.Selector = ucrSelectorMachineLearning
        ucrReceiverExpressionFitModel.SetParameterIsString()

        ucrReceiverMultipleExplanatoryVariable.SetParameter(New RParameter("x", 1))
        ucrReceiverMultipleExplanatoryVariable.Selector = ucrSelectorMachineLearning
        ucrReceiverMultipleExplanatoryVariable.SetParameterIsString()
        ucrReceiverMultipleExplanatoryVariable.bForceAsDataFrame = True
        ucrReceiverMultipleExplanatoryVariable.SetIncludedDataTypes({"numeric"})
        ucrReceiverMultipleExplanatoryVariable.SetParameterIncludeArgumentName(False)

        ucrReceiverResponseVariable.SetParameter(New RParameter("y", 1))
        ucrReceiverResponseVariable.Selector = ucrSelectorMachineLearning
        ucrReceiverResponseVariable.SetParameterIsString()
        ucrReceiverResponseVariable.bWithQuotes = False

        ucrInputMethod.SetParameter(New RParameter("method", 3))
        dctMethod.Add("lm", Chr(34) & "lm" & Chr(34))
        dctMethod.Add("nnet", Chr(34) & "nnet" & Chr(34))
        dctMethod.Add("knn", Chr(34) & "knn" & Chr(34))
        dctMethod.Add("rf", Chr(34) & "rf" & Chr(34))
        dctMethod.Add("Adaboost", Chr(34) & "ada" & Chr(34))
        dctMethod.Add("bag", Chr(34) & "bag" & Chr(34))
        ucrInputMethod.SetItems(dctMethod)
        ucrInputMethod.SetDropDownStyleAsNonEditable()

        ucrNudTrainSize.SetParameter(New RParameter("prop", 1))
        ucrNudTrainSize.SetMinMax(0, 1.0)
        'ucrNudTrainSize.SetDefaultState(0.7)
        ucrNudTrainSize.DecimalPlaces = 2
        ucrNudTrainSize.Increment = 0.01

        ucrPnlExplanatoryVariable.AddToLinkedControls(ucrReceiverMultipleExplanatoryVariable, {rdoExplanatoryVariable}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlExplanatoryVariable.AddToLinkedControls(ucrReceiverExpressionFitModel, {rdoExplanatoryModel}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

    End Sub

    Private Sub SetDefaults()
        clsTrainTestSplitFunction = New RFunction
        clsTrainFunction = New RFunction
        clsTestFunction = New RFunction
        clsTrainDataFunction = New RFunction
        clsTrainClassesoperator = New ROperator
        clsTestClassesOperator = New ROperator
        clsPredictFunction = New RFunction
        clsConfusionmatrixFunction = New RFunction

        ucrSelectorMachineLearning.Reset()
        ucrReceiverResponseVariable.SetMeAsReceiver()
        rdoExplanatoryVariable.Checked = True
        rdoClassification.Checked = True

        'train test set ratio
        clsTrainTestSplitFunction.SetPackageName("rsample")
        clsTrainTestSplitFunction.SetRCommand("initial_split")
        clsTrainTestSplitFunction.AddParameter("prop", 0.7, iPosition:=1)
        clsTrainTestSplitFunction.SetAssignTo("ratio")

        'train set
        clsTrainFunction.SetPackageName("rsample")
        clsTrainFunction.SetRCommand("training")
        clsTrainFunction.AddParameter("ratio", clsRFunctionParameter:=clsTrainTestSplitFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsTrainFunction.SetAssignTo("train")

        'test
        clsTestFunction.SetPackageName("rsample")
        clsTestFunction.SetRCommand("testing")
        clsTestFunction.AddParameter("test", clsRFunctionParameter:=clsTrainTestSplitFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsTestFunction.SetAssignTo("test")

        'traindata
        clsTrainDataFunction.SetPackageName("dplyr")
        clsTrainDataFunction.SetRCommand("select")
        clsTrainDataFunction.AddParameter("train", clsRFunctionParameter:=clsTrainFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsTrainDataFunction.SetAssignTo("train_data")

        'trainclases
        clsTrainClassesoperator.SetOperation("$", bBracketsTemp:=False)
        clsTrainClassesoperator.AddParameter("train", clsRFunctionParameter:=clsTrainFunction, iPosition:=0)
        clsTrainClassesoperator.SetAssignTo("train_classes")

        'testclases
        clsTestClassesOperator.SetOperation("$", bBracketsTemp:=False)
        clsTestClassesOperator.AddParameter("test", clsRFunctionParameter:=clsTestFunction, iPosition:=0)
        clsTestClassesOperator.SetAssignTo("test_classes")

        clsTrainFunction.SetPackageName("caret")
        clsTrainFunction.SetRCommand("train")
        clsTrainFunction.AddParameter("train_data", clsRFunctionParameter:=clsTrainDataFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsTrainFunction.AddParameter("train_classes", clsROperatorParameter:=clsTrainClassesoperator, iPosition:=1, bIncludeArgumentName:=False)
        clsTrainFunction.AddParameter("method", Chr(34) & "knn" & Chr(34), iPosition:=2)
        clsTrainFunction.SetAssignTo("learned_model")

        clsPredictFunction.SetPackageName("stats")
        clsPredictFunction.SetRCommand("predict")
        clsPredictFunction.AddParameter("object", clsRFunctionParameter:=clsTrainFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsPredictFunction.AddParameter("test", clsRFunctionParameter:=clsTestFunction, iPosition:=1, bIncludeArgumentName:=False)
        clsPredictFunction.AddParameter("type", Chr(34) & "raw" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsPredictFunction.SetAssignTo("prediction")

        clsConfusionmatrixFunction.SetPackageName("caret")
        clsConfusionmatrixFunction.SetRCommand("confusionMatrix")
        clsConfusionmatrixFunction.AddParameter("data", clsRFunctionParameter:=clsPredictFunction, iPosition:=0)
        clsConfusionmatrixFunction.AddParameter("reference", clsROperatorParameter:=clsTestClassesOperator, iPosition:=1)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverResponseVariable.AddAdditionalCodeParameterPair(clsTestClassesOperator, New RParameter("label", iNewPosition:=1), iAdditionalPairNo:=1)

        ucrSelectorMachineLearning.SetRCode(clsTrainTestSplitFunction, bReset)
        ucrReceiverExpressionFitModel.SetRCode(clsTrainFunction, bReset)
        ucrReceiverMultipleExplanatoryVariable.SetRCode(clsTrainDataFunction, bReset)
        ucrReceiverResponseVariable.SetRCode(clsTrainClassesoperator, bReset)
        ucrInputMethod.SetRCode(clsTrainFunction, bReset)
        ucrNudTrainSize.SetRCode(clsTrainTestSplitFunction, bReset)

        ucrBase.clsRsyntax.SetBaseRFunction(clsConfusionmatrixFunction)
    End Sub

    Private Sub TestOKEnabled()

    End Sub
End Class