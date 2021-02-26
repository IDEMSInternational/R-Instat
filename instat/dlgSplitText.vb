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
            SetDefaults(lstRCodeStructure)
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
        ucrInputPattern.SetItems(dctPatternPairs, bNewHasRParamFunctionAsString:=True)
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

    Private Sub SetDefaults(Optional lstOfRCodeStructure As List(Of RCodeStructure) = Nothing)
        clsTextComponentsFixed = New RFunction
        clsTextComponentsMaximum = New RFunction
        clsBinaryColumns = New RFunction

        ucrSelectorSplitTextColumn.Reset()

        'Setting of Package name and R commands for Rfunction happens before  we can check if any of these
        'Rfunction matches the one lstOfRcodeStructure
        clsBinaryColumns.SetPackageName("questionr")
        clsBinaryColumns.SetRCommand("multi.split")

        clsTextComponentsFixed.SetPackageName("stringr")
        clsTextComponentsFixed.SetRCommand("str_split_fixed")

        clsTextComponentsMaximum.SetPackageName("stringr")
        clsTextComponentsMaximum.SetRCommand("str_split")

        If IsNothing(lstRCodeStructure) Then
            clsTextComponentsFixed.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=1)
            clsTextComponentsFixed.AddParameter("n", strParameterValue:=2, iPosition:=2)

            clsTextComponentsMaximum.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=1)
            clsTextComponentsMaximum.AddParameter("n", "Inf", iPosition:=2)
            clsTextComponentsMaximum.AddParameter("simplify", "TRUE", iPosition:=3)
            ucrBase.clsRsyntax.SetBaseRFunction(clsTextComponentsFixed)
            'This dialogue only requires one line of code to load
        ElseIf (lstRCodeStructure.Count = 1) Then
            If Not IsNothing(TryCast(lstOfRCodeStructure(0), RFunction)) Then
                Dim bMatchOneRfunction As Boolean = False
                'loop through the three Rfunctions
                If TryCast(lstOfRCodeStructure(0), RFunction).strRCommand = clsTextComponentsFixed.strRCommand Then
                    If bMatchOneRfunction Then
                        MsgBox("Developer error:More Than one Rfunctions match the Rfunction from the script")
                        ' Exit if
                    Else
                        clsTextComponentsFixed = lstOfRCodeStructure(0)

                        clsTextComponentsMaximum.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=1)
                        clsTextComponentsMaximum.AddParameter("n", "Inf", iPosition:=2)
                        clsTextComponentsMaximum.AddParameter("simplify", "TRUE", iPosition:=3)

                        ucrBase.clsRsyntax.SetBaseRFunction(clsTextComponentsFixed)
                        bMatchOneRfunction = True
                    End If
                ElseIf TryCast(lstOfRCodeStructure(0), RFunction).strRCommand = clsBinaryColumns.strRCommand Then
                    If bMatchOneRfunction Then
                        MsgBox("Developer error:More Than one Rfunctions match the Rfunction from the script")
                        ' Exit if
                    Else
                        clsBinaryColumns = lstOfRCodeStructure(0)

                        clsTextComponentsFixed.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=1)
                        clsTextComponentsFixed.AddParameter("n", strParameterValue:=2, iPosition:=2)

                        clsTextComponentsMaximum.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=1)
                        clsTextComponentsMaximum.AddParameter("n", "Inf", iPosition:=2)
                        clsTextComponentsMaximum.AddParameter("simplify", "TRUE", iPosition:=3)

                        ucrBase.clsRsyntax.SetBaseRFunction(clsBinaryColumns)
                        bMatchOneRfunction = True
                    End If
                ElseIf TryCast(lstOfRCodeStructure(0), RFunction).strRCommand = clsTextComponentsMaximum.strRCommand Then
                    If bMatchOneRfunction Then
                        MsgBox("Developer error:More Than one Rfunctions match the Rfunction from the script")
                        ' Exit if
                    Else
                        clsTextComponentsMaximum = lstOfRCodeStructure(0)

                        clsTextComponentsFixed.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=1)
                        clsTextComponentsFixed.AddParameter("n", strParameterValue:=2, iPosition:=2)

                        ucrBase.clsRsyntax.SetBaseRFunction(clsBinaryColumns)
                        bMatchOneRfunction = True
                    End If
                End If
            Else
                MsgBox("Developer error:The Script must be an RFunction")
            End If
        Else
            MsgBox("Developer error: List of RCodeStructure must have only one RFunction")
        End If



        clsTextComponentsFixed.SetAssignTo(strTemp:="split", strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="split", bAssignToIsPrefix:=True)
        clsTextComponentsMaximum.SetAssignTo("split", strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="split", bAssignToIsPrefix:=True)
        clsBinaryColumns.SetAssignTo("split", strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bAssignToColumnWithoutNames:=True)
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
End Class