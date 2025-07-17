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

Public Class sdgPLModelOptions
    Private bControlsInitialised As Boolean = False
    Public bFirstLoad As Boolean = True
    Private clsRSyntax As New RSyntax
    Private clsPlacketFunction, clsVectorFunction, clsRepMeanFunction, clsRepSigFunction, clsdiagFunction, clsListNormalFunction, clsListGammaFunction As RFunction
    Private ReadOnly strgetOption As String = "getOption(""na.action"")"
    Private ReadOnly strFreq As String = "PlackettLuce::freq(.x)"
    Public enumPLModelOptionsMode As String = PLModelOptionsMode.Covariates

    Private Sub sdgPLModelOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        setHelpOptions()
    End Sub

    Public Enum PLModelOptionsMode
        Covariates
        Tree
    End Enum

    Private Sub InitialiseDialog()
        ucrChkMultivariateNormal.SetParameter(New RParameter("normal"))
        ucrChkMultivariateNormal.SetText("Normal")
        ucrChkMultivariateNormal.AddRSyntaxContainsFunctionNamesCondition(True, {"confint"}, True)
        ucrChkMultivariateNormal.AddRSyntaxContainsFunctionNamesCondition(False, {"confint"}, False)
        ucrChkMultivariateNormal.AddToLinkedControls({ucrNudMean, ucrNudSigma}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True) ', bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.95")

        ucrNudMean.SetParameter(New RParameter("x", 0, False))
        ucrNudMean.Increment = 1
        ucrNudMean.Minimum = 1
        ucrNudMean.SetLinkedDisplayControl(lblMean)
        ucrNudMean.SetRDefault(1)

        ucrNudSigma.SetParameter(New RParameter("x", 0, False))
        ucrNudSigma.Increment = 1
        ucrNudSigma.Minimum = 1
        ucrNudSigma.SetLinkedDisplayControl(lblSigma)
        ucrNudSigma.SetRDefault(1)

        ucrChkGamma.SetParameter(New RParameter("gamma"))
        ucrChkGamma.SetText("Gamma")
        ucrChkGamma.AddRSyntaxContainsFunctionNamesCondition(True, {"confint"}, True)
        ucrChkGamma.AddRSyntaxContainsFunctionNamesCondition(False, {"confint"}, False)
        ucrChkGamma.AddToLinkedControls({ucrNudShape, ucrNudRate}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True) ', bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.95")

        ucrNudShape.SetParameter(New RParameter("shape", 0))
        ucrNudShape.Increment = 1
        ucrNudShape.Minimum = 1
        ucrNudShape.SetLinkedDisplayControl(lblShape)
        ucrNudShape.SetRDefault(1)

        ucrNudRate.SetParameter(New RParameter("rate", 1))
        ucrNudRate.Increment = 1
        ucrNudRate.Minimum = 1
        ucrNudRate.SetLinkedDisplayControl(lblRate)
        ucrNudRate.SetRDefault(1)

        ucrChkMethod.SetText("Method")
        ucrChkMethod.AddRSyntaxContainsFunctionNamesCondition(True, {"method"}, True)
        ucrChkMethod.AddRSyntaxContainsFunctionNamesCondition(False, {"method"}, False)
        ucrChkMethod.AddToLinkedControls(ucrInputMethod, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True) ', bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.95")

        ucrInputMethod.SetParameter(New RParameter("method"))
        ucrInputMethod.SetItems({"iterative scaling", "BFGS", "L-BFGS"})
        ucrInputMethod.SetDropDownStyleAsNonEditable()
        ucrInputMethod.bAllowNonConditionValues = True
        ucrInputMethod.SetText("BFGS")

        ucrChkWeights.SetParameter(New RParameter("weights"))
        ucrChkWeights.SetText("Weights")
        ucrChkWeights.AddRSyntaxContainsFunctionNamesCondition(True, {"confint"}, True)
        ucrChkWeights.AddRSyntaxContainsFunctionNamesCondition(False, {"confint"}, False)
        ucrChkWeights.AddToLinkedControls(ucrInputWeight, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True) ', bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.95")
        ucrInputWeight.SetRDefault("freq(rankings)")

        ucrChkTreatsNAs.SetParameter(New RParameter("na.action"))
        ucrChkTreatsNAs.SetText("Treats NAs")
        ucrChkTreatsNAs.AddRSyntaxContainsFunctionNamesCondition(True, {"confint"}, True)
        ucrChkTreatsNAs.AddRSyntaxContainsFunctionNamesCondition(False, {"confint"}, False)
        ucrChkTreatsNAs.AddToLinkedControls(ucrInputNA, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True) ', bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.95")
        ucrInputNA.SetRDefault("getOption(""na.action"")")

        ucrChkMaxit.SetParameter(New RParameter("maxit"))
        ucrChkMaxit.SetText("Iterations")
        ucrChkMaxit.AddRSyntaxContainsFunctionNamesCondition(True, {"maxit"}, True)
        ucrChkMaxit.AddRSyntaxContainsFunctionNamesCondition(False, {"maxit"}, False)
        ucrChkMaxit.AddToLinkedControls({ucrNudMaxIterations, ucrNudOuterIterations}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True) ', bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.95")

        ucrNudMaxIterations.SetParameter(New RParameter("maxita", 0, False))
        ucrNudMaxIterations.Increment = 100
        ucrNudMaxIterations.Minimum = 100
        ucrNudMaxIterations.Maximum = 10000
        ucrNudMaxIterations.SetLinkedDisplayControl(lblMaximumIterations)
        ucrNudMaxIterations.SetRDefault(500)

        ucrNudOuterIterations.SetParameter(New RParameter("maxitb", 1, False))
        ucrNudOuterIterations.Increment = 1
        ucrNudOuterIterations.Minimum = 1
        ucrNudOuterIterations.SetLinkedDisplayControl(lblOuterIterations)
        ucrNudOuterIterations.SetRDefault(10)

        ucrChkSteffenson.SetText("Steffensen")
        ucrChkSteffenson.AddRSyntaxContainsFunctionNamesCondition(True, {"steffensen"}, True)
        ucrChkSteffenson.AddRSyntaxContainsFunctionNamesCondition(False, {"steffensen"}, False)
        ucrChkSteffenson.AddToLinkedControls(ucrNudSteffenson, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True) ', bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.95")

        ucrNudSteffenson.SetParameter(New RParameter("steffensen"))
        ucrNudSteffenson.DecimalPlaces = 1
        ucrNudSteffenson.Increment = 0.1
        ucrNudSteffenson.Minimum = 0
        ucrNudSteffenson.SetRDefault(0.1)



        ucrChkMinSize.SetText("Minimum Size for Partition Group")
        ucrChkMinSize.AddRSyntaxContainsFunctionNamesCondition(True, {"minsize"}, True)
        ucrChkMinSize.AddRSyntaxContainsFunctionNamesCondition(False, {"minsize"}, False)
        ucrChkMinSize.AddToLinkedControls(ucrNudMinSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrNudMinSize.SetParameter(New RParameter("minsize"))
        ucrNudMinSize.Increment = 1
        ucrNudMinSize.Minimum = 2
        ucrNudMinSize.SetRDefault(5)

        ucrChkPValue.SetText("P-value")
        ucrChkPValue.AddRSyntaxContainsFunctionNamesCondition(True, {"alpha"}, True)
        ucrChkPValue.AddRSyntaxContainsFunctionNamesCondition(False, {"alpha"}, False)
        ucrChkPValue.AddToLinkedControls(ucrInputComboPValue, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrInputComboPValue.SetParameter(New RParameter("alpha"))
        ucrInputComboPValue.SetItems({0.01, 0.05, 0.1, 0.5})
        ucrInputComboPValue.SetDropDownStyleAsEditable(bAdditionsAllowed:=True)
        ucrInputComboPValue.SetText(0.05)
        ucrInputComboPValue.bAllowNonConditionValues = True



        ucrChkEpsilon.SetText("Epsilon")
        ucrChkEpsilon.AddRSyntaxContainsFunctionNamesCondition(True, {"epsilon"}, True)
        ucrChkEpsilon.AddRSyntaxContainsFunctionNamesCondition(False, {"epsilon"}, False)
        ucrChkEpsilon.AddToLinkedControls(ucrInputEpsilon, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True) ', bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.95")

        ucrInputEpsilon.SetParameter(New RParameter("epsilon"))
        ucrInputEpsilon.SetValidationTypeAsNumeric()
        ucrInputEpsilon.SetRDefault(0.0001)

        ucrInputWeight.SetText(strFreq)
        ucrInputNA.SetText(strgetOption)
        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsNewRSyntax As RSyntax, clsNewPlacketFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseDialog()
        End If

        clsVectorFunction = New RFunction
        clsVectorFunction.SetRCommand("c")
        clsListNormalFunction = New RFunction
        clsListNormalFunction.SetRCommand("list")
        clsListGammaFunction = New RFunction
        clsListGammaFunction.SetRCommand("list")
        clsRepMeanFunction = New RFunction
        clsRepMeanFunction.SetRCommand("rep")
        clsdiagFunction = New RFunction
        clsdiagFunction.SetRCommand("diag")
        clsRepSigFunction = New RFunction
        clsRepSigFunction.SetRCommand("rep")

        clsPlacketFunction = clsNewPlacketFunction
        clsRSyntax = clsNewRSyntax
        If bReset Then
            ucrNudMaxIterations.SetRCode(clsVectorFunction, bReset)
            ucrNudOuterIterations.SetRCode(clsVectorFunction, bReset)
            ucrNudRate.SetRCode(clsListGammaFunction, bReset)
            ucrNudShape.SetRCode(clsListGammaFunction, bReset)
            ucrNudSigma.SetRCode(clsRepSigFunction, bReset)
            ucrNudMean.SetRCode(clsRepMeanFunction, bReset)
            ucrChkSteffenson.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrChkEpsilon.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrChkMethod.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrChkGamma.SetRCode(clsPlacketFunction, bReset, bCloneIfNeeded:=True)
            ucrChkMultivariateNormal.SetRCode(clsPlacketFunction, bReset, bCloneIfNeeded:=True)
            ucrChkTreatsNAs.SetRCode(clsPlacketFunction, bReset, bCloneIfNeeded:=True)
            ucrChkWeights.SetRCode(clsPlacketFunction, bReset, bCloneIfNeeded:=True)
            ucrChkMaxit.SetRCode(clsPlacketFunction, bReset, bCloneIfNeeded:=True)
            ucrInputMethod.SetRCode(clsPlacketFunction, bReset, bCloneIfNeeded:=True)
            ucrInputNA.SetRCode(clsPlacketFunction, bReset, bCloneIfNeeded:=True)
            ucrInputWeight.SetRCode(clsPlacketFunction, bReset, bCloneIfNeeded:=True)
            ucrInputEpsilon.SetRCode(clsPlacketFunction, bReset, bCloneIfNeeded:=True)

            ucrNudSteffenson.SetRCode(clsPlacketFunction, bReset, bCloneIfNeeded:=True)

        End If
        AddRemoveEpsilon()
        AddRemoveMethod()
        AddRemoveSteff()
        AddRemoveNas()
        SetVisibilityControls()
    End Sub

    Private Sub AddRemoveGamma()
        If ucrChkGamma.Checked Then
            ucrChkMethod.Enabled = False
            If Not ucrNudShape.IsEmpty Then
                clsListGammaFunction.AddParameter("shape", ucrNudShape.GetText(), iPosition:=0)
            Else
                clsListGammaFunction.RemoveParameterByName("rate")
            End If
            If Not ucrNudRate.IsEmpty Then
                clsListGammaFunction.AddParameter("rate", ucrNudRate.GetText(), iPosition:=1)
            Else
                clsListGammaFunction.RemoveParameterByName("rate")
            End If
            clsPlacketFunction.AddParameter("gamma", clsRFunctionParameter:=clsListGammaFunction)
        Else
            ucrChkMethod.Enabled = True
            clsPlacketFunction.RemoveParameterByName("gamma")
        End If
    End Sub

    Private Sub ucrChkGamma_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkGamma.ControlValueChanged ', ucrNudShape.ControlValueChanged, ucrNudRate.ControlValueChanged
        AddRemoveGamma()
    End Sub

    Private Sub ucrChkMultivariateNormal_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMultivariateNormal.ControlValueChanged ', ucrNudMean.ControlValueChanged, ucrNudSigma.ControlValueChanged
        If ucrChkMultivariateNormal.Checked Then
            If Not ucrNudSigma.IsEmpty Then
                clsRepSigFunction.AddParameter("x", ucrNudSigma.GetText(), iPosition:=0)
                clsRepSigFunction.AddParameter("y", "ncol(.x)", iPosition:=1, bIncludeArgumentName:=False)
            Else
                clsRepSigFunction.RemoveParameterByName("x")
                clsRepSigFunction.RemoveParameterByName("y")
            End If
            If Not ucrNudMean.IsEmpty Then
                clsRepMeanFunction.AddParameter("x", ucrNudMean.GetText(), iPosition:=0, bIncludeArgumentName:=False)
                clsRepMeanFunction.AddParameter("y", "ncol(.x)", iPosition:=1, bIncludeArgumentName:=False)
            Else
                clsRepMeanFunction.RemoveParameterByName("x")
                clsRepMeanFunction.RemoveParameterByName("y")
            End If
            clsdiagFunction.AddParameter("y", clsRFunctionParameter:=clsRepSigFunction, iPosition:=0, bIncludeArgumentName:=False)
            clsListNormalFunction.AddParameter("mu", clsRFunctionParameter:=clsRepMeanFunction, iPosition:=0)
            clsListNormalFunction.AddParameter("Sigma", clsRFunctionParameter:=clsdiagFunction, iPosition:=1)
            clsPlacketFunction.AddParameter("normal", clsRFunctionParameter:=clsListNormalFunction)
        Else
            clsPlacketFunction.RemoveParameterByName("normal")
        End If
    End Sub

    Public Sub SetVisibilityControls()
        ucrNudMinSize.Visible = ucrChkMinSize.Checked
        ucrInputComboPValue.Visible = ucrChkPValue.Checked
    End Sub

    Private Sub ucrChkMinSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMinSize.ControlValueChanged
        If ucrChkMinSize.Checked Then
            clsPlacketFunction.AddParameter("minsize", ucrNudMinSize.GetText(), iPosition:=11)
        Else
            If clsPlacketFunction.ContainsParameter("minsize") Then
                clsPlacketFunction.RemoveParameterByName("minsize")
            End If
        End If
    End Sub


    Private Sub ucrChkPValue_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPValue.ControlValueChanged
        If ucrChkPValue.Checked Then
            clsPlacketFunction.AddParameter("alpha", ucrInputComboPValue.GetText(), iPosition:=12)
        Else
            If clsPlacketFunction.ContainsParameter("minsize") Then
                clsPlacketFunction.RemoveParameterByName("minsize")
            End If
        End If
    End Sub

    Private Sub ucrChkWeights_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkWeights.ControlValueChanged ', ucrInputWeight.ControlValueChanged
        If ucrChkWeights.Checked Then
            If Not ucrInputWeight.IsEmpty Then
                clsPlacketFunction.AddParameter("weights", ucrInputWeight.GetText())
            Else
                clsPlacketFunction.RemoveParameterByName("weights")
            End If
        Else
            clsPlacketFunction.RemoveParameterByName("weights")
        End If
    End Sub

    Private Sub ucrChkTreatsNAs_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTreatsNAs.ControlValueChanged ', ucrInputNA.ControlValueChanged
        AddRemoveNas()
    End Sub

    Private Sub AddRemoveNas()
        If ucrChkTreatsNAs.Checked Then
            If Not ucrInputNA.IsEmpty Then
                clsPlacketFunction.AddParameter("na.action", ucrInputNA.GetText())
            Else
                clsPlacketFunction.RemoveParameterByName("na.action")
            End If
        Else
            clsPlacketFunction.RemoveParameterByName("na.action")
        End If
    End Sub


    Private Sub AddRemoveMethod()
        If ucrChkMethod.Checked Then
            If Not ucrInputMethod.IsEmpty Then
                clsPlacketFunction.AddParameter("method", Chr(34) & ucrInputMethod.GetText() & Chr(34))
            Else
                clsPlacketFunction.RemoveParameterByName("method")
            End If
        Else
            clsPlacketFunction.RemoveParameterByName("method")
        End If
    End Sub

    Private Sub AddRemoveEpsilon()
        If ucrChkEpsilon.Checked Then
            If Not ucrInputEpsilon.IsEmpty Then
                clsPlacketFunction.AddParameter("epsilon", ucrInputEpsilon.GetText())
            Else
                clsPlacketFunction.RemoveParameterByName("epsilon")
            End If
        Else
            clsPlacketFunction.RemoveParameterByName("epsilon")
        End If
    End Sub

    Private Sub AddRemoveSteff()
        If ucrChkSteffenson.Checked Then
            If Not ucrNudSteffenson.IsEmpty Then
                clsPlacketFunction.AddParameter("steffensen", ucrNudSteffenson.GetText())
            Else
                clsPlacketFunction.RemoveParameterByName("steffensen")
            End If
        Else
            clsPlacketFunction.RemoveParameterByName("steffensen")
        End If
    End Sub


    Private Sub AddRemovemaxit()
        If ucrChkMaxit.Checked Then
            If Not ucrNudMaxIterations.IsEmpty Then
                clsVectorFunction.AddParameter("maxita", ucrNudMaxIterations.GetText(), iPosition:=0, bIncludeArgumentName:=False)
            Else
                clsVectorFunction.RemoveParameterByName("maxita")
            End If
            If Not ucrNudOuterIterations.IsEmpty Then
                clsVectorFunction.AddParameter("maxitb", ucrNudOuterIterations.GetText(), iPosition:=1, bIncludeArgumentName:=False)
            Else
                clsVectorFunction.RemoveParameterByName("maxitb")
            End If
            clsPlacketFunction.AddParameter("maxit", clsRFunctionParameter:=clsVectorFunction)
        Else
            clsPlacketFunction.RemoveParameterByName("maxit")
        End If
    End Sub

    Private Sub setHelpOptions()
        Select Case enumPLModelOptionsMode
            Case PLModelOptionsMode.Covariates
                ucrBase.iHelpTopicID = 721
            Case PLModelOptionsMode.Tree
                ucrBase.iHelpTopicID = 723
        End Select
    End Sub

    Private Sub ucrChkMaxit_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMaxit.ControlValueChanged
        AddRemovemaxit()
    End Sub

    Private Sub ucrChkMethod_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMethod.ControlValueChanged
        AddRemoveMethod()
    End Sub

    Private Sub ucrChkSteffenson_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSteffenson.ControlValueChanged
        AddRemoveSteff()
    End Sub

    Private Sub ucrChkEpsilon_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEpsilon.ControlValueChanged
        AddRemoveEpsilon()
    End Sub
End Class
