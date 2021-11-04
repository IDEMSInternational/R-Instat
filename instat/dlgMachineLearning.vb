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
    Private clsRegressionTrainDataFunction, clsClassificationTrainDataFunction, clsPredictFunction As New RFunction
    Private clsConfusionmatrixFunction As New RFunction
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

        'ucrReceiverExpressionFitModel.SetParameter(New RParameter("x", 1))
        'ucrReceiverExpressionFitModel.Selector = ucrSelectorMachineLearning
        'ucrReceiverExpressionFitModel.SetParameterIsString()

        ucrReceiverMultipleExplanatoryVariable.SetParameter(New RParameter("x", 1))
        ucrReceiverMultipleExplanatoryVariable.Selector = ucrSelectorMachineLearning
        ucrReceiverMultipleExplanatoryVariable.SetParameterIsString()
        ucrReceiverMultipleExplanatoryVariable.bForceAsDataFrame = True
        ucrReceiverMultipleExplanatoryVariable.SetIncludedDataTypes({"numeric"})
        ucrReceiverMultipleExplanatoryVariable.SetParameterIncludeArgumentName(False)

        ucrReceiverClassificationResponseVariable.SetParameter(New RParameter("y", 1))
        ucrReceiverClassificationResponseVariable.Selector = ucrSelectorMachineLearning
        ucrReceiverClassificationResponseVariable.SetParameterIsString()
        ucrReceiverClassificationResponseVariable.bWithQuotes = False

        ucrReceiverRegressionResponse.SetParameter(New RParameter("y", 0))
        ucrReceiverRegressionResponse.Selector = ucrSelectorMachineLearning
        ucrReceiverRegressionResponse.SetParameterIsString()
        ucrReceiverRegressionResponse.bWithQuotes = False
        ucrReceiverRegressionResponse.SetIncludedDataTypes({"numeric"})

        ucrInputClassificationMethod.SetParameter(New RParameter("method", 2))
        dctClassificationMethod.Add("knn", Chr(34) & "knn" & Chr(34))
        dctClassificationMethod.Add("nnet", Chr(34) & "nnet" & Chr(34))
        dctClassificationMethod.Add("rf", Chr(34) & "rf" & Chr(34))
        dctClassificationMethod.Add("Adaboost", Chr(34) & "Adaboost" & Chr(34))
        dctClassificationMethod.Add("bag", Chr(34) & "bag" & Chr(34))
        dctClassificationMethod.Add("ada", Chr(34) & "ada" & Chr(34))
        dctClassificationMethod.Add("AdaBag", Chr(34) & "AdaBag" & Chr(34))
        dctClassificationMethod.Add("AdaBoost.M1", Chr(34) & "AdaBoost.M1" & Chr(34))
        dctClassificationMethod.Add("amdai", Chr(34) & "amdai" & Chr(34))
        dctClassificationMethod.Add("avNNet", Chr(34) & "avNNet" & Chr(34))
        dctClassificationMethod.Add("awnb", Chr(34) & "awnb" & Chr(34))
        dctClassificationMethod.Add("awtan", Chr(34) & "awtan" & Chr(34))
        dctClassificationMethod.Add("bagEarth", Chr(34) & "bagEarth" & Chr(34))
        dctClassificationMethod.Add("bagEarthGCV", Chr(34) & "bagEarthGCV" & Chr(34))
        dctClassificationMethod.Add("bagFDA", Chr(34) & "bagFDA" & Chr(34))
        dctClassificationMethod.Add("bagFDAGCV", Chr(34) & "bagFDAGCV" & Chr(34))
        dctClassificationMethod.Add("bam", Chr(34) & "bam" & Chr(34))
        dctClassificationMethod.Add("bartMachine", Chr(34) & "bartMachine" & Chr(34))
        dctClassificationMethod.Add("bayesglm", Chr(34) & "bayesglm" & Chr(34))
        dctClassificationMethod.Add("binda", Chr(34) & "binda" & Chr(34))
        dctClassificationMethod.Add("blackboost", Chr(34) & "blackboost" & Chr(34))
        dctClassificationMethod.Add("BstLm", Chr(34) & "BstLm" & Chr(34))
        dctClassificationMethod.Add("bstSm", Chr(34) & "bstSm" & Chr(34))
        dctClassificationMethod.Add("bstTree", Chr(34) & "bstTree" & Chr(34))
        dctClassificationMethod.Add("C5.0", Chr(34) & "C5" & Chr(34))
        dctClassificationMethod.Add("fda", Chr(34) & "fda" & Chr(34))
        dctClassificationMethod.Add("gam", Chr(34) & "gam" & Chr(34))
        dctClassificationMethod.Add("gamboost", Chr(34) & "gamboost" & Chr(34))
        dctClassificationMethod.Add("gamLoess", Chr(34) & "gamLoess" & Chr(34))
        dctClassificationMethod.Add("gamSpline", Chr(34) & "gamSpline" & Chr(34))
        dctClassificationMethod.Add("gaussprLinear", Chr(34) & "gaussprLinear" & Chr(34))
        dctClassificationMethod.Add("glm", Chr(34) & "glm" & Chr(34))
        dctClassificationMethod.Add("glmboost", Chr(34) & "glmboost" & Chr(34))
        dctClassificationMethod.Add("glmnet", Chr(34) & "glmnet" & Chr(34))
        dctClassificationMethod.Add("glmnet_h2o", Chr(34) & "glmnet_h2o" & Chr(34))
        dctClassificationMethod.Add("glmStepAIC", Chr(34) & "glmStepAIC" & Chr(34))
        dctClassificationMethod.Add("kknn", Chr(34) & "kknn" & Chr(34))
        dctClassificationMethod.Add("knn", Chr(34) & "knn" & Chr(34))
        dctClassificationMethod.Add("LogitBoost", Chr(34) & "LogitBoost" & Chr(34))
        dctClassificationMethod.Add("logreg", Chr(34) & "logreg" & Chr(34))
        dctClassificationMethod.Add("ranger", Chr(34) & "ranger" & Chr(34))
        dctClassificationMethod.Add("rbf", Chr(34) & "rbf" & Chr(34))
        ucrInputClassificationMethod.SetItems(dctClassificationMethod)
        ucrInputClassificationMethod.SetDropDownStyleAsNonEditable()

        ucrInputRegressionMethod.SetParameter(New RParameter("method", 2))
        dctRegressionMethod.Add("lm", Chr(34) & "lm" & Chr(34))
        dctRegressionMethod.Add("glm", Chr(34) & "glm" & Chr(34))
        ucrInputRegressionMethod.SetItems(dctRegressionMethod)
        ucrInputRegressionMethod.SetDropDownStyleAsNonEditable()

        ucrNudTrainSize.SetParameter(New RParameter("prop", 1))
        ucrNudTrainSize.SetMinMax(0, 1.0)
        ucrNudTrainSize.DecimalPlaces = 2
        ucrNudTrainSize.Increment = 0.05

        ucrPnlExplanatoryVariable.AddToLinkedControls(ucrReceiverMultipleExplanatoryVariable, {rdoExplanatoryVariable}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        'ucrPnlExplanatoryVariable.AddToLinkedControls(ucrReceiverExpressionFitModel, {rdoExplanatoryModel}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrPnlModelType.AddToLinkedControls({ucrReceiverClassificationResponseVariable, ucrInputClassificationMethod}, {rdoClassification}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlModelType.AddToLinkedControls({ucrReceiverRegressionResponse, ucrInputRegressionMethod}, {rdoRegression}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

    End Sub

    Private Sub SetDefaults()
        clsClassificationTrainFunction = New RFunction
        clsRegressionTrainFunction = New RFunction
        clsConfusionmatrixFunction = New RFunction
        clsTrainTestSplitFunction = New RFunction
        clsTrainingFunction = New RFunction
        clsPredictFunction = New RFunction
        clsTestFunction = New RFunction
        clsRegressionTrainDataFunction = New RFunction
        clsClassificationTrainDataFunction = New RFunction
        clsTrainClassesoperator = New ROperator
        clsTestClassesOperator = New ROperator
        clsDeltaOperator = New ROperator

        ucrSelectorMachineLearning.Reset()
        ucrReceiverClassificationResponseVariable.SetMeAsReceiver()
        rdoExplanatoryVariable.Checked = True
        rdoClassification.Checked = True

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

        'clsPredictFunction.SetPackageName("stats")
        'clsPredictFunction.SetRCommand("predict")
        'clsPredictFunction.AddParameter("object", clsRFunctionParameter:=clsClassificationTrainFunction, iPosition:=0, bIncludeArgumentName:=False)
        'clsPredictFunction.AddParameter("test", clsRFunctionParameter:=clsTestFunction, iPosition:=1, bIncludeArgumentName:=False)
        'clsPredictFunction.AddParameter("type", Chr(34) & "raw" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        'clsPredictFunction.SetAssignTo("prediction")

        'clsConfusionmatrixFunction.SetPackageName("caret")
        'clsConfusionmatrixFunction.SetRCommand("confusionMatrix")
        'clsConfusionmatrixFunction.AddParameter("data", clsRFunctionParameter:=clsPredictFunction, iPosition:=0)
        'clsConfusionmatrixFunction.AddParameter("reference", clsROperatorParameter:=clsTestClassesOperator, iPosition:=1)

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
        clsRegressionTrainFunction.AddParameter("method", Chr(34) & "lm" & Chr(34), iPosition:=2)
        'clsRegressionTrainFunction.SetAssignTo("regression_model")
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverClassificationResponseVariable.AddAdditionalCodeParameterPair(clsTestClassesOperator, New RParameter("label", iNewPosition:=1), iAdditionalPairNo:=1)
        ucrReceiverRegressionResponse.AddAdditionalCodeParameterPair(clsRegressionTrainDataFunction, New RParameter("response", iNewPosition:=2, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverMultipleExplanatoryVariable.AddAdditionalCodeParameterPair(clsRegressionTrainDataFunction, New RParameter("train_data", iNewPosition:=1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)

        ucrSelectorMachineLearning.SetRCode(clsTrainTestSplitFunction, bReset)
        ucrReceiverMultipleExplanatoryVariable.SetRCode(clsClassificationTrainDataFunction, bReset)
        ucrReceiverClassificationResponseVariable.SetRCode(clsTrainClassesoperator, bReset)
        ucrReceiverRegressionResponse.SetRCode(clsDeltaOperator, bReset)
        ucrInputClassificationMethod.SetRCode(clsClassificationTrainFunction, bReset)
        ucrInputRegressionMethod.SetRCode(clsRegressionTrainFunction, bReset)
        ucrNudTrainSize.SetRCode(clsTrainTestSplitFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiverMultipleExplanatoryVariable.IsEmpty OrElse (rdoClassification.Checked AndAlso ucrReceiverClassificationResponseVariable.IsEmpty) OrElse (rdoRegression.Checked AndAlso ucrReceiverRegressionResponse.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrPnlModelType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlModelType.ControlValueChanged
        If rdoClassification.Checked Then
            rdoRegression.Checked = False
            rdoClassification.Checked = True
            ucrBase.clsRsyntax.SetBaseRFunction(clsClassificationTrainFunction)
        Else
            rdoClassification.Checked = False
            rdoRegression.Checked = True
            ucrReceiverRegressionResponse.SetMeAsReceiver()
            ucrBase.clsRsyntax.SetBaseRFunction(clsRegressionTrainFunction)
        End If
    End Sub

    Private Sub ucrReceiverMultipleExplanatoryVariable_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlModelType.ControlContentsChanged, ucrReceiverMultipleExplanatoryVariable.ControlContentsChanged, ucrReceiverClassificationResponseVariable.ControlContentsChanged, ucrReceiverRegressionResponse.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class