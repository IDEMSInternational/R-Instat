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
    Private clsClassificationTrainFunction, clsRegressionTrainFunction, clsTrainingFunction, clsTestFunction As New RFunction
    Private clsRegressionTrainDataFunction, clsClassificationTrainDataFunction, clspostResampleFunction As New RFunction
    Private clsConfusionmatrixFunction, clsClassificationPredictFunction, clsRegressionPredictFunction As New RFunction
    'Operators
    Private clsTrainClassesoperator, clsTestClassesOperator, clsDeltaOperator As New ROperator

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
        Dim dctClassificationMethod As New Dictionary(Of String, String)
        Dim dctRegressionMethod As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.iCallType = 2
        ucrSelectorMachineLearning.SetParameter(New RParameter("data", 0))
        ucrSelectorMachineLearning.SetParameterIsrfunction()

        ucrPnlExplanatoryVariable.AddRadioButton(rdoExplanatoryVariable)
        ucrPnlExplanatoryVariable.AddRadioButton(rdoExplanatoryModel)

        ucrPnlModelType.AddRadioButton(rdoClassification)
        ucrPnlModelType.AddRadioButton(rdoRegression)
        ucrPnlModelType.AddFunctionNamesCondition(rdoClassification, "confusionMatrix")
        ucrPnlModelType.AddFunctionNamesCondition(rdoRegression, "postResample")

        'ucrPnlClassificationPerformanceMeasure.AddRadioButton(rdoClassificationModelSummary)
        'ucrPnlClassificationPerformanceMeasure.AddRadioButton(rdoClassificationPerformanceStatistics)
        'ucrPnlClassificationPerformanceMeasure.AddFunctionNamesCondition(rdoClassificationModelSummary, "train")
        'ucrPnlClassificationPerformanceMeasure.AddFunctionNamesCondition(rdoClassificationPerformanceStatistics, "confusionMatrix")

        'ucrPnlRegressionPerformanceMeasure.AddRadioButton(rdoRegressionModelSummary)
        'ucrPnlRegressionPerformanceMeasure.AddRadioButton(rdoRegressionPerformanceStatistics)
        'ucrPnlRegressionPerformanceMeasure.AddFunctionNamesCondition(rdoRegressionModelSummary, "train")
        'ucrPnlRegressionPerformanceMeasure.AddFunctionNamesCondition(rdoRegressionPerformanceStatistics, "postResample")

        'ucrReceiverExpressionFitModel.SetParameter(New RParameter("x", 1))
        'ucrReceiverExpressionFitModel.Selector = ucrSelectorMachineLearning
        'ucrReceiverExpressionFitModel.SetParameterIsString()

        ucrReceiverMultipleExplanatoryVariable.SetParameter(New RParameter("x", 1))
        ucrReceiverMultipleExplanatoryVariable.Selector = ucrSelectorMachineLearning
        ucrReceiverMultipleExplanatoryVariable.SetParameterIsString()
        ucrReceiverMultipleExplanatoryVariable.bForceAsDataFrame = True
        'ucrReceiverMultipleExplanatoryVariable.SetIncludedDataTypes({"numeric"})
        ucrReceiverMultipleExplanatoryVariable.SetParameterIncludeArgumentName(False)

        ucrReceiverClassificationResponseVariable.SetParameter(New RParameter("y", 1))
        ucrReceiverClassificationResponseVariable.Selector = ucrSelectorMachineLearning
        ucrReceiverClassificationResponseVariable.SetParameterIsString()
        ucrReceiverClassificationResponseVariable.bWithQuotes = False

        ucrReceiverRegressionResponse.SetParameter(New RParameter("y", 0))
        ucrReceiverRegressionResponse.Selector = ucrSelectorMachineLearning
        ucrReceiverRegressionResponse.SetParameterIsString()
        ucrReceiverRegressionResponse.bWithQuotes = False
        'ucrReceiverRegressionResponse.SetIncludedDataTypes({"numeric"})

        ucrChkClassificationPerformance.SetText("Performance Measure")
        ucrChkClassificationPerformance.AddFunctionNamesCondition(True, {"confusionMatrix"})
        ucrChkClassificationPerformance.AddFunctionNamesCondition(False, {"confusionMatrix"}, False)

        ucrChkRegressionPerformance.SetText("Performance Measure")
        ucrChkRegressionPerformance.AddFunctionNamesCondition(True, {"postResample"})
        ucrChkRegressionPerformance.AddFunctionNamesCondition(False, {"postResample"}, False)

        ucrInputClassificationMethod.SetParameter(New RParameter("method", 2))
        'Commonly used Methods
        dctClassificationMethod.Add("knn", Chr(34) & "knn" & Chr(34))
        dctClassificationMethod.Add("nnet", Chr(34) & "nnet" & Chr(34))
        dctClassificationMethod.Add("glm", Chr(34) & "glm" & Chr(34))
        'Other Methods
        'dctClassificationMethod.Add("AdaBoost.M1", Chr(34) & "AdaBoost.M1" & Chr(34))
        'dctClassificationMethod.Add("amdai", Chr(34) & "amdai" & Chr(34))
        'dctClassificationMethod.Add("avNNet", Chr(34) & "avNNet" & Chr(34))
        'dctClassificationMethod.Add("awnb", Chr(34) & "awnb" & Chr(34))
        'dctClassificationMethod.Add("awtan", Chr(34) & "awtan" & Chr(34))
        'dctClassificationMethod.Add("bagEarth", Chr(34) & "bagEarth" & Chr(34))
        'dctClassificationMethod.Add("bagEarthGCV", Chr(34) & "bagEarthGCV" & Chr(34))
        'dctClassificationMethod.Add("bagFDA", Chr(34) & "bagFDA" & Chr(34))
        'dctClassificationMethod.Add("bagFDAGCV", Chr(34) & "bagFDAGCV" & Chr(34))
        'dctClassificationMethod.Add("bam", Chr(34) & "bam" & Chr(34))
        'dctClassificationMethod.Add("bartMachine", Chr(34) & "bartMachine" & Chr(34))
        'dctClassificationMethod.Add("binda", Chr(34) & "binda" & Chr(34))
        'dctClassificationMethod.Add("blackboost", Chr(34) & "blackboost" & Chr(34))
        'dctClassificationMethod.Add("BstLm", Chr(34) & "BstLm" & Chr(34))
        'dctClassificationMethod.Add("bstSm", Chr(34) & "bstSm" & Chr(34))
        'dctClassificationMethod.Add("bstTree", Chr(34) & "bstTree" & Chr(34))
        'dctClassificationMethod.Add("C5.0", Chr(34) & "C5" & Chr(34))
        'dctClassificationMethod.Add("fda", Chr(34) & "fda" & Chr(34))
        'dctClassificationMethod.Add("gam", Chr(34) & "gam" & Chr(34))
        'dctClassificationMethod.Add("gamboost", Chr(34) & "gamboost" & Chr(34))
        'dctClassificationMethod.Add("gamLoess", Chr(34) & "gamLoess" & Chr(34))
        'dctClassificationMethod.Add("gamSpline", Chr(34) & "gamSpline" & Chr(34))
        'dctClassificationMethod.Add("gaussprLinear", Chr(34) & "gaussprLinear" & Chr(34))
        'dctClassificationMethod.Add("glmboost", Chr(34) & "glmboost" & Chr(34))
        'dctClassificationMethod.Add("glmnet", Chr(34) & "glmnet" & Chr(34))
        'dctClassificationMethod.Add("glmnet_h2o", Chr(34) & "glmnet_h2o" & Chr(34))
        'dctClassificationMethod.Add("glmStepAIC", Chr(34) & "glmStepAIC" & Chr(34))
        'dctClassificationMethod.Add("kknn", Chr(34) & "kknn" & Chr(34))
        'dctClassificationMethod.Add("LogitBoost", Chr(34) & "LogitBoost" & Chr(34))
        'dctClassificationMethod.Add("logreg", Chr(34) & "logreg" & Chr(34))
        'dctClassificationMethod.Add("ranger", Chr(34) & "ranger" & Chr(34))
        'dctClassificationMethod.Add("rbf", Chr(34) & "rbf" & Chr(34))
        'dctClassificationMethod.Add("rbfDDA", Chr(34) & "rbfDDA" & Chr(34))
        'dctClassificationMethod.Add("Rborist", Chr(34) & "Rborist" & Chr(34))
        'dctClassificationMethod.Add("rda", Chr(34) & "rda" & Chr(34))
        'dctClassificationMethod.Add("regLogistic", Chr(34) & "regLogistic" & Chr(34))
        'dctClassificationMethod.Add("rFerns", Chr(34) & "rFerns" & Chr(34))
        'dctClassificationMethod.Add("RFlda", Chr(34) & "RFlda" & Chr(34))
        'dctClassificationMethod.Add("rfRules", Chr(34) & "rfRules" & Chr(34))
        'dctClassificationMethod.Add("rlda", Chr(34) & "rlda" & Chr(34))
        'dctClassificationMethod.Add("rmda", Chr(34) & "rmda" & Chr(34))
        'dctClassificationMethod.Add("rocc", Chr(34) & "rocc" & Chr(34))
        'dctClassificationMethod.Add("rotationForest", Chr(34) & "rotationForest" & Chr(34))
        'dctClassificationMethod.Add("rotationForestCp", Chr(34) & "rotationForestCp" & Chr(34))
        'dctClassificationMethod.Add("rpart", Chr(34) & "rpart" & Chr(34))
        'dctClassificationMethod.Add("rpart1SE", Chr(34) & "rpart1SE" & Chr(34))
        'dctClassificationMethod.Add("rpart2", Chr(34) & "rpart2" & Chr(34))
        'dctClassificationMethod.Add("rpartCost", Chr(34) & "rpartCost" & Chr(34))
        'dctClassificationMethod.Add("rpartScore", Chr(34) & "rpartScore" & Chr(34))
        'dctClassificationMethod.Add("RRF", Chr(34) & "RRF" & Chr(34))
        'dctClassificationMethod.Add("RRFglobal", Chr(34) & "RRFglobal" & Chr(34))
        'dctClassificationMethod.Add("rrlda", Chr(34) & "rrlda" & Chr(34))
        'dctClassificationMethod.Add("RSimca", Chr(34) & "RSimca" & Chr(34))
        'dctClassificationMethod.Add("sda", Chr(34) & "sda" & Chr(34))
        'dctClassificationMethod.Add("sdwd", Chr(34) & "sdwd" & Chr(34))
        'dctClassificationMethod.Add("simpls", Chr(34) & "simpls" & Chr(34))
        'dctClassificationMethod.Add("SLAVE", Chr(34) & "SLAVE" & Chr(34))
        'dctClassificationMethod.Add("slda", Chr(34) & "slda" & Chr(34))
        'dctClassificationMethod.Add("smda", Chr(34) & "smda" & Chr(34))
        'dctClassificationMethod.Add("snn", Chr(34) & "snn" & Chr(34))
        'dctClassificationMethod.Add("sparseLDA", Chr(34) & "sparseLDA" & Chr(34))
        'dctClassificationMethod.Add("spls", Chr(34) & "spls" & Chr(34))
        'dctClassificationMethod.Add("stepLDA", Chr(34) & "stepLDA" & Chr(34))
        'dctClassificationMethod.Add("stepQDA", Chr(34) & "stepQDA" & Chr(34))
        'dctClassificationMethod.Add("svmBoundrangeString", Chr(34) & "svmBoundrangeString" & Chr(34))
        'dctClassificationMethod.Add("svmExpoString", Chr(34) & "svmExpoString" & Chr(34))
        'dctClassificationMethod.Add("svmLinear", Chr(34) & "svmLinear" & Chr(34))
        'dctClassificationMethod.Add("svmLinear2", Chr(34) & "svmLinear2" & Chr(34))
        'dctClassificationMethod.Add("svmLinear3", Chr(34) & "svmLinear3" & Chr(34))
        'dctClassificationMethod.Add("svmLinearWeights", Chr(34) & "svmLinearWeights" & Chr(34))
        'dctClassificationMethod.Add("svmLinearWeights2", Chr(34) & "svmLinearWeights2" & Chr(34))
        'dctClassificationMethod.Add("svmPoly", Chr(34) & "svmPoly" & Chr(34))
        'dctClassificationMethod.Add("svmRadial", Chr(34) & "svmRadial" & Chr(34))
        'dctClassificationMethod.Add("svmRadialCost", Chr(34) & "svmRadialCost" & Chr(34))
        'dctClassificationMethod.Add("svmRadialSigma", Chr(34) & "svmRadialSigma" & Chr(34))
        'dctClassificationMethod.Add("svmRadialWeights", Chr(34) & "svmRadialWeights" & Chr(34))
        'dctClassificationMethod.Add("svmSpectrumString", Chr(34) & "svmSpectrumString" & Chr(34))
        'dctClassificationMethod.Add("tan", Chr(34) & "tan" & Chr(34))
        'dctClassificationMethod.Add("tanSearch", Chr(34) & "tanSearch" & Chr(34))
        'dctClassificationMethod.Add("treebag", Chr(34) & "treebag" & Chr(34))
        'dctClassificationMethod.Add("vbmpRadial", Chr(34) & "vbmpRadial" & Chr(34))
        'dctClassificationMethod.Add("vglmAdjCat", Chr(34) & "vglmAdjCat" & Chr(34))
        'dctClassificationMethod.Add("vglmContRatio", Chr(34) & "vglmContRatio" & Chr(34))
        'dctClassificationMethod.Add("widekernelpls", Chr(34) & "widekernelpls" & Chr(34))
        'dctClassificationMethod.Add("wsrf", Chr(34) & "wsrf" & Chr(34))
        'dctClassificationMethod.Add("xgbDART", Chr(34) & "xgbDART" & Chr(34))
        'dctClassificationMethod.Add("xgbLinear", Chr(34) & "xgbLinear" & Chr(34))
        'dctClassificationMethod.Add("xgbTree", Chr(34) & "xgbTree" & Chr(34))
        'dctClassificationMethod.Add("xyf", Chr(34) & "xyf" & Chr(34))
        ucrInputClassificationMethod.SetItems(dctClassificationMethod)
        ucrInputClassificationMethod.SetDropDownStyleAsNonEditable()

        ucrInputRegressionMethod.SetParameter(New RParameter("method", 2))
        'Commonly used methods
        dctRegressionMethod.Add("knn", Chr(34) & "knn" & Chr(34))
        dctRegressionMethod.Add("kknn", Chr(34) & "kknn" & Chr(34))
        dctRegressionMethod.Add("lm", Chr(34) & "lm" & Chr(34))
        dctRegressionMethod.Add("glm", Chr(34) & "glm" & Chr(34))
        dctRegressionMethod.Add("svmBoundrangeString", Chr(34) & "svmBoundrangeString" & Chr(34))
        dctRegressionMethod.Add("svmLinear", Chr(34) & "svmLinear" & Chr(34))
        dctRegressionMethod.Add("svmSpectrumString", Chr(34) & "svmSpectrumString" & Chr(34))
        'Other methods
        'dctRegressionMethod.Add("gam", Chr(34) & "gam" & Chr(34))
        'dctRegressionMethod.Add("gamboost", Chr(34) & "gamboost" & Chr(34))
        'dctRegressionMethod.Add("gamLoess", Chr(34) & "gamLoess" & Chr(34))
        'dctRegressionMethod.Add("gamSpline", Chr(34) & "gamSpline" & Chr(34))
        'dctRegressionMethod.Add("gaussprLinear", Chr(34) & "gaussprLinear" & Chr(34))
        'dctRegressionMethod.Add("gaussprPoly", Chr(34) & "gaussprPoly" & Chr(34))
        'dctRegressionMethod.Add("gaussprRadial", Chr(34) & "gaussprRadial" & Chr(34))
        'dctRegressionMethod.Add("gbm", Chr(34) & "gbm" & Chr(34))
        'dctRegressionMethod.Add("gbm_h2o", Chr(34) & "gbm_h2o" & Chr(34))
        'dctRegressionMethod.Add("glm.nb", Chr(34) & "glm.nb" & Chr(34))
        'dctRegressionMethod.Add("glmboost", Chr(34) & "glmboost" & Chr(34))
        'dctRegressionMethod.Add("glmnet", Chr(34) & "glmnet" & Chr(34))
        'dctRegressionMethod.Add("glmnet_h2o", Chr(34) & "glmnet_h2o" & Chr(34))
        'dctRegressionMethod.Add("glmStepAIC", Chr(34) & "glmStepAIC" & Chr(34))
        'dctRegressionMethod.Add("lasso", Chr(34) & "lasso" & Chr(34))
        'dctRegressionMethod.Add("neuralnet", Chr(34) & "neuralnet" & Chr(34))
        'dctRegressionMethod.Add("randomGLM", Chr(34) & "randomGLM" & Chr(34)) 'Needs a package installation
        'dctRegressionMethod.Add("rf", Chr(34) & "rf" & Chr(34))
        'dctRegressionMethod.Add("ridge", Chr(34) & "ridge" & Chr(34))
        'dctRegressionMethod.Add("rpart", Chr(34) & "rpart" & Chr(34))
        'dctRegressionMethod.Add("rpart1SE", Chr(34) & "rpart1SE" & Chr(34))
        'dctRegressionMethod.Add("rpart2", Chr(34) & "rpart2" & Chr(34))
        'dctRegressionMethod.Add("svmLinear2", Chr(34) & "svmLinear2" & Chr(34))
        'dctRegressionMethod.Add("svmLinear3", Chr(34) & "svmLinear3" & Chr(34))
        'dctRegressionMethod.Add("svmPoly", Chr(34) & "svmPoly" & Chr(34))
        'dctRegressionMethod.Add("svmRadial", Chr(34) & "svmRadial" & Chr(34))
        'dctRegressionMethod.Add("svmRadialCost", Chr(34) & "svmRadialCost" & Chr(34))
        'dctRegressionMethod.Add("svmRadialSigma", Chr(34) & "svmRadialSigma" & Chr(34))
        'dctRegressionMethod.Add("xgbDART", Chr(34) & "xgbDART" & Chr(34))
        'dctRegressionMethod.Add("xgbTree", Chr(34) & "xgbTree" & Chr(34))
        ucrInputRegressionMethod.SetItems(dctRegressionMethod)
        ucrInputRegressionMethod.SetDropDownStyleAsNonEditable()

        ucrNudTrainTestSize.SetParameter(New RParameter("prop", 1))
        ucrNudTrainTestSize.SetMinMax(0.01, 0.99)
        ucrNudTrainTestSize.DecimalPlaces = 2
        ucrNudTrainTestSize.Increment = 0.05

        ucrPnlExplanatoryVariable.AddToLinkedControls(ucrReceiverMultipleExplanatoryVariable, {rdoExplanatoryVariable}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        'ucrPnlExplanatoryVariable.AddToLinkedControls(ucrReceiverExpressionFitModel, {rdoExplanatoryModel}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrPnlModelType.AddToLinkedControls({ucrReceiverClassificationResponseVariable, ucrInputClassificationMethod, ucrChkClassificationPerformance}, {rdoClassification}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlModelType.AddToLinkedControls({ucrReceiverRegressionResponse, ucrInputRegressionMethod, ucrChkRegressionPerformance}, {rdoRegression}, bNewLinkedHideIfParameterMissing:=True)

        ucrModelName.SetDataFrameSelector(ucrSelectorMachineLearning.ucrAvailableDataFrames)
        ucrModelName.SetPrefix("machine_learning_model")
        ucrModelName.SetSaveTypeAsModel()
        ucrModelName.SetCheckBoxText("Save Model")
        ucrModelName.SetIsComboBox()
        'ucrModelName.SetAssignToIfUncheckedValue("last_model")
    End Sub

    Private Sub SetDefaults()
        clsClassificationTrainFunction = New RFunction
        clsRegressionTrainFunction = New RFunction
        clsConfusionmatrixFunction = New RFunction
        clsTrainTestSplitFunction = New RFunction
        clsTrainingFunction = New RFunction
        clsClassificationPredictFunction = New RFunction
        clsRegressionPredictFunction = New RFunction
        clsTestFunction = New RFunction
        clspostResampleFunction = New RFunction
        clsRegressionTrainDataFunction = New RFunction
        clsClassificationTrainDataFunction = New RFunction
        clsTrainClassesoperator = New ROperator
        clsTestClassesOperator = New ROperator
        clsDeltaOperator = New ROperator

        ucrSelectorMachineLearning.Reset()
        ucrModelName.Reset()
        rdoExplanatoryVariable.Checked = True
        'rdoClassification.Checked = True

        'train test set ratio
        clsTrainTestSplitFunction.SetPackageName("rsample")
        clsTrainTestSplitFunction.SetRCommand("initial_split")
        clsTrainTestSplitFunction.AddParameter("prop", 0.7, iPosition:=1)
        clsTrainTestSplitFunction.SetAssignTo("sampled_data")

        'train set
        clsTrainingFunction.SetPackageName("rsample")
        clsTrainingFunction.SetRCommand("training")
        clsTrainingFunction.AddParameter("sampled_data", clsRFunctionParameter:=clsTrainTestSplitFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsTrainingFunction.SetAssignTo("train")

        'test
        clsTestFunction.SetPackageName("rsample")
        clsTestFunction.SetRCommand("testing")
        clsTestFunction.AddParameter("sampled_data", clsRFunctionParameter:=clsTrainTestSplitFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsTestFunction.SetAssignTo("test")

        'Classification traindata
        clsClassificationTrainDataFunction.SetPackageName("dplyr")
        clsClassificationTrainDataFunction.SetRCommand("select")
        clsClassificationTrainDataFunction.AddParameter("train", clsRFunctionParameter:=clsTrainingFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsClassificationTrainDataFunction.SetAssignTo("train_data")

        'trainclases
        clsTrainClassesoperator.SetOperation("$", bBracketsTemp:=False)
        clsTrainClassesoperator.AddParameter("train", clsRFunctionParameter:=clsTrainingFunction, iPosition:=0)
        clsTrainClassesoperator.SetAssignTo("train_classes")

        'testclases
        clsTestClassesOperator.SetOperation("$", bBracketsTemp:=False)
        clsTestClassesOperator.AddParameter("test", clsRFunctionParameter:=clsTestFunction, iPosition:=0)
        clsTestClassesOperator.SetAssignTo("test_classes")

        clsClassificationTrainFunction.SetPackageName("caret")
        clsClassificationTrainFunction.SetRCommand("train")
        clsClassificationTrainFunction.AddParameter("train_data", clsRFunctionParameter:=clsClassificationTrainDataFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsClassificationTrainFunction.AddParameter("train_classes", clsROperatorParameter:=clsTrainClassesoperator, iPosition:=1, bIncludeArgumentName:=False)
        clsClassificationTrainFunction.AddParameter("method", Chr(34) & "knn" & Chr(34), iPosition:=2)
        'clsClassificationTrainFunction.SetAssignTo("classification_model")

        clsClassificationPredictFunction.SetPackageName("stats")
        clsClassificationPredictFunction.SetRCommand("predict")
        clsClassificationPredictFunction.AddParameter("object", clsRFunctionParameter:=clsClassificationTrainFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsClassificationPredictFunction.AddParameter("test", clsRFunctionParameter:=clsTestFunction, iPosition:=1, bIncludeArgumentName:=False)
        clsClassificationPredictFunction.AddParameter("type", Chr(34) & "raw" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsClassificationPredictFunction.SetAssignTo("prediction")

        clsConfusionmatrixFunction.SetPackageName("caret")
        clsConfusionmatrixFunction.SetRCommand("confusionMatrix")
        clsConfusionmatrixFunction.AddParameter("data", clsRFunctionParameter:=clsClassificationPredictFunction, iPosition:=0)
        clsConfusionmatrixFunction.AddParameter("reference", clsROperatorParameter:=clsTestClassesOperator, iPosition:=1)

        'Regression Traindata
        clsRegressionTrainDataFunction.SetPackageName("dplyr")
        clsRegressionTrainDataFunction.SetRCommand("select")
        clsRegressionTrainDataFunction.AddParameter("train", clsRFunctionParameter:=clsTrainingFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsRegressionTrainDataFunction.SetAssignTo("train_data")

        clsDeltaOperator.SetOperation("~")
        clsDeltaOperator.AddParameter("dot", ".", iPosition:=1)

        clsRegressionTrainFunction.SetPackageName("caret")
        clsRegressionTrainFunction.SetRCommand("train")
        clsRegressionTrainFunction.AddParameter("formula", clsROperatorParameter:=clsDeltaOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsRegressionTrainFunction.AddParameter("data", clsRFunctionParameter:=clsRegressionTrainDataFunction, iPosition:=1)
        clsRegressionTrainFunction.AddParameter("method", Chr(34) & "knn" & Chr(34), iPosition:=2)
        'clsRegressionTrainFunction.SetAssignTo("regression_model")

        clsRegressionPredictFunction.SetPackageName("stats")
        clsRegressionPredictFunction.SetRCommand("predict")
        clsRegressionPredictFunction.AddParameter("object", clsRFunctionParameter:=clsRegressionTrainFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsRegressionPredictFunction.AddParameter("test", clsRFunctionParameter:=clsTestFunction, iPosition:=1, bIncludeArgumentName:=False)
        'clsRegressionPredictFunction.AddParameter("type", Chr(34) & "raw" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsRegressionPredictFunction.SetAssignTo("prediction")

        clspostResampleFunction.SetRCommand("postResample")
        clspostResampleFunction.AddParameter("pred", clsRFunctionParameter:=clsRegressionPredictFunction, iPosition:=0) ', bIncludeArgumentName:=False)
        clspostResampleFunction.AddParameter("obs", clsROperatorParameter:=clsTestClassesOperator, iPosition:=1) ', bIncludeArgumentName:=False)

        ucrBase.clsRsyntax.SetBaseRFunction(clsClassificationTrainFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrModelName.AddAdditionalRCode(clsRegressionTrainFunction, 1)
        ucrReceiverClassificationResponseVariable.AddAdditionalCodeParameterPair(clsTestClassesOperator, New RParameter("label", iNewPosition:=1), iAdditionalPairNo:=1)
        ucrReceiverRegressionResponse.AddAdditionalCodeParameterPair(clsRegressionTrainDataFunction, New RParameter("response", iNewPosition:=2, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverRegressionResponse.AddAdditionalCodeParameterPair(clsTestClassesOperator, New RParameter("label", iNewPosition:=1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverMultipleExplanatoryVariable.AddAdditionalCodeParameterPair(clsRegressionTrainDataFunction, New RParameter("train_data", iNewPosition:=1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)

        ucrSelectorMachineLearning.SetRCode(clsTrainTestSplitFunction, bReset)
        ucrReceiverMultipleExplanatoryVariable.SetRCode(clsClassificationTrainDataFunction, bReset)
        ucrReceiverClassificationResponseVariable.SetRCode(clsTrainClassesoperator, bReset)
        ucrReceiverRegressionResponse.SetRCode(clsDeltaOperator, bReset)
        ucrInputClassificationMethod.SetRCode(clsClassificationTrainFunction, bReset)
        ucrInputRegressionMethod.SetRCode(clsRegressionTrainFunction, bReset)
        ucrNudTrainTestSize.SetRCode(clsTrainTestSplitFunction, bReset)
        ucrPnlModelType.SetRCode(clsConfusionmatrixFunction)
        ucrPnlModelType.SetRCode(clspostResampleFunction)
        ucrChkClassificationPerformance.SetRCode(clsConfusionmatrixFunction, bReset)
        ucrChkRegressionPerformance.SetRCode(clspostResampleFunction, bReset)
        ucrModelName.SetRCode(clsClassificationTrainFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiverMultipleExplanatoryVariable.IsEmpty OrElse (rdoClassification.Checked AndAlso ucrReceiverClassificationResponseVariable.IsEmpty) OrElse (rdoRegression.Checked AndAlso ucrReceiverRegressionResponse.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrPnlModelType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlModelType.ControlValueChanged, ucrChkClassificationPerformance.ControlValueChanged, ucrChkRegressionPerformance.ControlValueChanged
        If rdoClassification.Checked Then
            ucrReceiverClassificationResponseVariable.SetMeAsReceiver()
            'rdoRegression.Checked = False
            'rdoClassification.Checked = True
            If ucrChkClassificationPerformance.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsClassificationTrainFunction)
            Else
                ucrBase.clsRsyntax.SetBaseRFunction(clsConfusionmatrixFunction)
            End If
        Else
            ucrReceiverRegressionResponse.SetMeAsReceiver()
            'rdoClassification.Checked = False
            'rdoRegression.Checked = True
            ucrReceiverRegressionResponse.SetMeAsReceiver()
            If ucrChkRegressionPerformance.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsRegressionTrainFunction)
            Else
                ucrBase.clsRsyntax.SetBaseRFunction(clspostResampleFunction)
            End If
        End If
    End Sub

    Private Sub ucrReceiverMultipleExplanatoryVariable_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlModelType.ControlContentsChanged, ucrReceiverMultipleExplanatoryVariable.ControlContentsChanged, ucrReceiverClassificationResponseVariable.ControlContentsChanged, ucrReceiverRegressionResponse.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class