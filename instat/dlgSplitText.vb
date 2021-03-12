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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.



Imports instat.Translations
Public Class dlgSplitText
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsTextComponentsFixed, clsTextComponentsMaximum As New RFunction
    Private clsBinaryColumns As New RFunction
    Private lstRCodeStructure As List(Of RCodeStructure)
    Private Sub dlgSplitText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctPatternPairs As New Dictionary(Of String, String)
        ucrBase.iHelpTopicID = 344

        ucrPnlSplitText.AddRadioButton(rdoTextComponents)
        ucrPnlSplitText.AddRadioButton(rdoBinaryColumns)

        ucrPnlSplitText.AddFunctionNamesCondition(rdoBinaryColumns, "multi.split", True)
        ucrPnlSplitText.AddFunctionNamesCondition(rdoTextComponents, "multi.split", False)

        ucrPnlTextComponents.AddRadioButton(rdoFixedNumberOfComponents)
        ucrPnlTextComponents.AddRadioButton(rdoMaximumNumberOfComponents)

        ucrPnlTextComponents.AddFunctionNamesCondition(rdoMaximumNumberOfComponents, "str_split")
        ucrPnlTextComponents.AddFunctionNamesCondition(rdoFixedNumberOfComponents, "str_split_fixed")


        ucrPnlTextComponents.AddToLinkedControls(ucrNudPieces, {rdoFixedNumberOfComponents}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=2, bNewLinkedChangeParameterValue:=True)
        ucrPnlSplitText.AddToLinkedControls(ucrSaveColumn, {rdoTextComponents}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSplitText.AddToLinkedControls(ucrPnlTextComponents, {rdoTextComponents}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoFixedNumberOfComponents)
        ucrNudPieces.SetLinkedDisplayControl(lblNumberofPiecesToReturn)


        ucrReceiverSplitTextColumn.SetParameter(New RParameter("string", 0))
        ucrReceiverSplitTextColumn.SetParameterIsRFunction()
        ucrReceiverSplitTextColumn.Selector = ucrSelectorSplitTextColumn
        ucrReceiverSplitTextColumn.SetMeAsReceiver()
        ucrReceiverSplitTextColumn.bUseFilteredData = False

        ucrInputPattern.SetParameter(New RParameter("pattern", 1))
        dctPatternPairs.Add("Space ( )", Chr(34) & " " & Chr(34))
        dctPatternPairs.Add("Period .", "stringr::fixed(" & Chr(34) & "." & Chr(34) & ")")
        dctPatternPairs.Add("Comma ,", Chr(34) & "," & Chr(34))
        dctPatternPairs.Add("Colon :", Chr(34) & ":" & Chr(34))
        dctPatternPairs.Add("Semicolon ;", Chr(34) & ";" & Chr(34))
        dctPatternPairs.Add("Hyphen -", Chr(34) & "-" & Chr(34))
        dctPatternPairs.Add("Underscore _", Chr(34) & "_" & Chr(34))
        ucrInputPattern.SetItems(dctPatternPairs)
        'ucrInputPattern.SetRDefault(Chr(34) & " " & Chr(34)) 'This is the default for clsTextComponents
        ucrInputPattern.bAllowNonConditionValues = True

        ucrNudPieces.SetParameter(New RParameter("n", 2))
        ucrNudPieces.SetMinMax(2, Integer.MaxValue)

        ucrSaveColumn.SetSaveTypeAsColumn()
        ucrSaveColumn.SetDataFrameSelector(ucrSelectorSplitTextColumn.ucrAvailableDataFrames)
        ucrSaveColumn.SetLabelText("Prefix for New Columns:")
        ucrSaveColumn.SetIsTextBox()
        ucrSaveColumn.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
    End Sub

    Private Sub SetDefaults()
        ResetRFunctions()

        If IsNothing(lstRCodeStructure) Then
            setRFunctionDefaultParameters()
        ElseIf (lstRCodeStructure.Count > 1) Then
            setRFunctionDefaultParameters()
            MsgBox("Developer error: List of RCodeStructure must have only one RFunction")
        ElseIf (lstRCodeStructure.Count = 1) Then
            If Not IsNothing(TryCast(lstRCodeStructure(0), RFunction)) Then
                Dim strRcommand = TryCast(lstRCodeStructure(0), RFunction).strRCommand
                Dim clsParameter As RParameter = Nothing
                Select Case strRcommand
                    Case clsTextComponentsFixed.strRCommand
                        clsTextComponentsFixed = lstRCodeStructure(0)
                        AddClsTextComponentsMaximumDefaultParameters()

                        ucrBase.clsRsyntax.SetBaseRFunction(clsTextComponentsFixed)
                    Case clsBinaryColumns.strRCommand
                        clsBinaryColumns = lstRCodeStructure(0)
                        AddClsTextComponentsFixedDefaultParameters()
                        AddClsTextComponentsMaximumDefaultParameters()

                        ucrBase.clsRsyntax.SetBaseRFunction(clsBinaryColumns)
                        clsParameter = clsBinaryColumns.GetParameter("var").Clone()
                        clsParameter.SetArgumentName("string")
                    Case clsTextComponentsMaximum.strRCommand
                        clsTextComponentsMaximum = lstRCodeStructure(0)
                        AddClsTextComponentsFixedDefaultParameters()

                        ucrBase.clsRsyntax.SetBaseRFunction(clsTextComponentsMaximum)
                        clsParameter = clsTextComponentsMaximum.GetParameter("string").Clone()
                    Case Else
                        setRFunctionDefaultParameters()
                        MsgBox("Developer error:The Rfunction does not match any Rfunction in the dialogue")
                End Select

                'In this dialog, there are three functions that have a parameter set by the 'ucrReceiverSplitTextColumn' receiver.
                'The value displayed by the receiver is initialised from just one of these functions ('clsTextComponentsFixed'). 
                'The receiver is initialised, in the 'SetRCode' function, from the 'clsTextComponentsFixed' 'string' parameter.
                'Therefore, to ensure that the receiver is initialised with the correct value, we need to initialise the 'clsTextComponentsFixed' 'string' parameter.
                If Not IsNothing(clsParameter) Then
                    clsTextComponentsFixed.AddParameter(clsParameter)
                    If Not (ucrBase.clsRsyntax.clsBaseFunction Is clsTextComponentsMaximum) Then
                        clsTextComponentsMaximum.AddParameter(clsParameter)
                    End If
                End If
            Else
                setRFunctionDefaultParameters()
                MsgBox("Developer error:The Script must be an RFunction")
            End If
        End If
        lstScriptsRCodeStructure = Nothing

        clsTextComponentsFixed.SetAssignTo(strTemp:="split", strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="split", bAssignToIsPrefix:=True)
        clsTextComponentsMaximum.SetAssignTo("split", strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="split", bAssignToIsPrefix:=True)
        clsBinaryColumns.SetAssignTo("split", strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bAssignToColumnWithoutNames:=True)
    End Sub

    Private Sub AddClsTextComponentsMaximumDefaultParameters()
        clsTextComponentsMaximum.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=1)
        clsTextComponentsMaximum.AddParameter("n", "Inf", iPosition:=2)
        clsTextComponentsMaximum.AddParameter("simplify", "TRUE", iPosition:=3)
    End Sub

    Private Sub AddClsTextComponentsFixedDefaultParameters()
        clsTextComponentsFixed.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=1)
        clsTextComponentsFixed.AddParameter("n", strParameterValue:=2, iPosition:=2)
    End Sub

    Private Sub ResetRFunctions()
        clsTextComponentsFixed = New RFunction
        clsTextComponentsMaximum = New RFunction
        clsBinaryColumns = New RFunction

        ucrSelectorSplitTextColumn.Reset()

        clsBinaryColumns.SetPackageName("questionr")
        clsBinaryColumns.SetRCommand("multi.split")

        clsTextComponentsFixed.SetPackageName("stringr")
        clsTextComponentsFixed.SetRCommand("str_split_fixed")

        clsTextComponentsMaximum.SetPackageName("stringr")
        clsTextComponentsMaximum.SetRCommand("str_split")
    End Sub

    Private Sub setRFunctionDefaultParameters()
        AddClsTextComponentsFixedDefaultParameters()
        AddClsTextComponentsMaximumDefaultParameters()

        ucrBase.clsRsyntax.SetBaseRFunction(clsTextComponentsFixed)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputPattern.AddAdditionalCodeParameterPair(clsTextComponentsMaximum, New RParameter("pattern", 1), iAdditionalPairNo:=1)
        ucrInputPattern.AddAdditionalCodeParameterPair(clsBinaryColumns, New RParameter("split.char", 1), iAdditionalPairNo:=2)
        ucrReceiverSplitTextColumn.SetRCode(clsTextComponentsFixed, bReset)
        ucrInputPattern.SetRCode(clsTextComponentsFixed, bReset)
        ucrNudPieces.SetRCode(clsTextComponentsFixed, bReset)
        ucrPnlSplitText.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlTextComponents.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrSaveColumn.SetRCode(clsTextComponentsFixed, bReset)
        ucrReceiverSplitTextColumn.AddAdditionalCodeParameterPair(clsTextComponentsMaximum, New RParameter("string", 0), iAdditionalPairNo:=1)
        ucrReceiverSplitTextColumn.AddAdditionalCodeParameterPair(clsBinaryColumns, New RParameter("var", 0), iAdditionalPairNo:=2)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverSplitTextColumn.IsEmpty() AndAlso Not ucrInputPattern.IsEmpty AndAlso ((rdoTextComponents.Checked AndAlso ucrNudPieces.GetText <> "" AndAlso ucrSaveColumn.IsComplete()) OrElse rdoBinaryColumns.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlSplitText_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSplitText.ControlValueChanged

        If rdoBinaryColumns.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsBinaryColumns)
        ElseIf rdoTextComponents.Checked Then
            SplitTextOptions()
        End If
    End Sub
    Private Sub ucrPnlTextComponents_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlTextComponents.ControlValueChanged
        SplitTextOptions()
    End Sub

    Private Sub SplitTextOptions()
        If rdoFixedNumberOfComponents.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsTextComponentsFixed)
        ElseIf rdoMaximumNumberOfComponents.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsTextComponentsMaximum)
        End If
    End Sub
    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputPattern.ControlContentsChanged, ucrReceiverSplitTextColumn.ControlContentsChanged, ucrNudPieces.ControlContentsChanged, ucrSaveColumn.ControlContentsChanged, ucrPnlSplitText.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Public Sub OpenFromScript(lstNewRcodeStructure As List(Of RCodeStructure))
        bReset = True
        lstRCodeStructure = lstNewRcodeStructure
    End Sub

    Public Property lstScriptsRCodeStructure As List(Of RCodeStructure)
        Get
            Return lstRCodeStructure
        End Get
        Set(lstNewRCodeStructure As List(Of RCodeStructure))
            lstRCodeStructure = lstNewRCodeStructure
            bReset = True
        End Set
    End Property
End Class
