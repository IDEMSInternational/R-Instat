
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
        ucrInputRegressionMethod.SetItems(dctRegressionMethod)
        ucrInputRegressionMethod.SetDropDownStyleAsNonEditable()

        ucrNudTrainTestSize.SetParameter(New RParameter("prop", 1))
        ucrNudTrainTestSize.SetMinMax(0.01, 0.99)
        ucrNudTrainTestSize.DecimalPlaces = 2
        ucrNudTrainTestSize.Increment = 0.05

        ucrPnlExplanatoryVariable.AddToLinkedControls(ucrReceiverMultipleExplanatoryVariable, {rdoExplanatoryVariable}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrReceiverMultipleExplanatoryVariable.SetLinkedDisplayControl(lblExplanatoryVariable)
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