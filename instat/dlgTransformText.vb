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
Imports instat
Imports instat.Translations

Public Class dlgTransformText
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgTransformText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ReopenDialog()
        TestOkEnabled()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 343
        ucrBase.clsRsyntax.bUseBaseFunction = True

        'ucrReceiver
        ucrReceiverTransformText.SetParameter(New RParameter("string", 0))
        ucrReceiverTransformText.SetParameterIsRFunction() ' is r function for getvariables()
        ucrReceiverTransformText.Selector = ucrSelectorForTransformText
        ucrReceiverTransformText.bUseFilteredData = False
        ucrReceiverTransformText.SetMeAsReceiver()
        ucrReceiverTransformText.SetIncludedDataTypes({"factor", "character"})

        'ucrRdoOptions
        ucrPnlOperation.AddRadioButton(rdoConvertCase)
        ucrPnlOperation.AddRadioButton(rdoLength)
        ucrPnlOperation.AddRadioButton(rdoPad)
        ucrPnlOperation.AddRadioButton(rdoTrim)
        ucrPnlOperation.AddRadioButton(rdoWords)
        ucrPnlOperation.AddRadioButton(rdoSubstring)

        ucrPnlOperation.AddFunctionNamesCondition(rdoConvertCase, "") ' this changes depending which rdo is checked
        ucrPnlOperation.AddFunctionNamesCondition(rdoLength, "stringr::str_length")
        ucrPnlOperation.AddFunctionNamesCondition(rdoPad, "stringr::str_pad")
        ucrPnlOperation.AddFunctionNamesCondition(rdoTrim, "stringr::str_trim")
        ucrPnlOperation.AddFunctionNamesCondition(rdoWords, "stringr::word")
        ucrPnlOperation.AddFunctionNamesCondition(rdoSubstring, "stringr::str_sub")
        'to do: check for   .AddParameterPresentCondition

        'rdoConvertCase
        ucrPnlOperation.AddToLinkedControls(ucrInputTo, {rdoConvertCase}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrInputTo
        ucrInputTo.SetLinkedDisplayControl(lblTo)
        ucrInputTo.cboInput.Items.Add("Lower")
        ucrInputTo.cboInput.Items.Add("Upper")
        ucrInputTo.cboInput.Items.Add("Title")
        ucrInputTo.SetName("Lower")

        'Case "Lower"
        'ucrBase.clsRsyntax.SetFunction("stringr::str_to_lower")
        'Case "Upper"
        'ucrBase.clsRsyntax.SetFunction("stringr::str_to_upper")
        'Case "Title"
        'ucrBase.clsRsyntax.SetFunction("stringr::str_to_title")
        'End Select


        'rdoPad
        ucrPnlOperation.AddToLinkedControls(ucrInputPad, {rdoPad}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOperation.AddToLinkedControls(ucrPnlPad, {rdoPad}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOperation.AddToLinkedControls(ucrNudWidth, {rdoPad}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrInputPad
        Dim dctInputPad As New Dictionary(Of String, String)
        ucrInputPad.SetParameter(New RParameter("pad", ))
        dctInputPad.Add("Space", Chr(34) & " " & Chr(34))
        dctInputPad.Add("Hash", Chr(34) & "#" & Chr(34))
        dctInputPad.Add("Hyphen", Chr(34) & "-" & Chr(34))
        dctInputPad.Add("Period", Chr(34) & "." & Chr(34))
        dctInputPad.Add("Underscore", Chr(34) & "_" & Chr(34))
        ' case of else: ucrBase.clsRsyntax.AddParameter("pad", Chr(34) & ucrInputPad.GetText & Chr(34))
        ucrInputPad.SetItems(dctInputPad)
        'space is default
        ''("pad", Chr(34) & " " & Chr(34)) - do I do this for clsDefaultFunction or not? It's not always going to be in.

        'ucrPnlPad
        ucrPnlPad.SetParameter(New RParameter("side", ))
        ucrPnlPad.AddRadioButton(rdoLeftPad, Chr(34) & "left" & Chr(34))
        ucrPnlPad.AddRadioButton(rdoRightPad, Chr(34) & "right" & Chr(34))
        ucrPnlPad.AddRadioButton(rdoBothPad, Chr(34) & "both" & Chr(34))
        '("side", Chr(34) & "left" & Chr(34)) - do I do this for clsDefaultFunction or not? It's not always going to be in.


        'ucrNudWidth
        ucrNudWidth.SetParameter(New RParameter("width", ))
        ucrNudWidth.SetLinkedDisplayControl(lblWidth)
        '.addparameter("width", 1)

        'rdoTrim
        ucrPnlOperation.AddToLinkedControls(ucrPnlPad, {rdoTrim}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'uses ucrPnlPad code from above

        'rdoWords
        ucrPnlOperation.AddToLinkedControls(ucrChkFirstOrColumn, {rdoWords}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOperation.AddToLinkedControls(ucrChkOrColumn, {rdoWords}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOperation.AddToLinkedControls(ucrInputSeparator, {rdoWords}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'if ucrChkFirstOrCol then         '    nudFirstWord.Enabled = False
        ucrReceiverFirstWord.SetParameter(New RParameter("start"))
        ucrChkFirstOrColumn.SetParameter(ucrReceiverFirstWord.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrReceiverFirstWord.SetParameterIsRFunction() 'getvariables()
        ucrReceiverFirstWord.Selector = ucrSelectorForTransformText
        ucrReceiverFirstWord.bUseFilteredData = False
        ucrReceiverFirstWord.SetIncludedDataTypes({"numeric"})

        ucrChkFirstOrColumn.SetText("Or Column")
        ucrChkFirstOrColumn.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkFirstOrColumn.bChangeParameterValue = False
        ucrChkFirstOrColumn.SetRDefault("FALSE")
        ucrChkFirstOrColumn.AddToLinkedControls(ucrLinked:=ucrReceiverFirstWord, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ' If this is checked, then we don't want to have nudFirst enabled or running

        ucrNudFirstWord.SetParameter(New RParameter("start"))
        ucrNudFirstWord.SetLinkedDisplayControl(lblFirstWord)
        'default value is 1


        ucrBase.clsRsyntax.AddParameter("end", clsRFunctionParameter:=ucrReceiverLastWord.GetVariables())
        ucrReceiverLastWord.Selector = ucrSelectorForTransformText
        ucrReceiverLastWord.bUseFilteredData = False
        ucrReceiverLastWord.SetIncludedDataTypes({"numeric"})
        ' nud last word stuff
        '            ucrBase.clsRsyntax.AddParameter("end", nudLastWord.Value)
        'lblLastWord.Visible = True
        'nudLastWord.Visible = True
        'value=1


        'if ucrChkorCol then         '    nudLastWord.Enabled = False
        ucrReceiverLastWord.SetParameter(New RParameter("end"))
        ucrChkOrColumn.SetParameter(ucrReceiverLastWord.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrReceiverLastWord.SetParameterIsRFunction() 'getvariables()
        ucrReceiverLastWord.Selector = ucrSelectorForTransformText
        ucrReceiverLastWord.bUseFilteredData = False
        ucrReceiverLastWord.SetIncludedDataTypes({"numeric"})

        ucrChkOrColumn.SetText("Or Column")
        ucrChkOrColumn.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOrColumn.bChangeParameterValue = False
        ucrChkOrColumn.SetRDefault("FALSE")
        ucrChkOrColumn.AddToLinkedControls(ucrLinked:=ucrReceiverLastWord, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ' If this is checked, then we don't want to have nudLast enabled or running

        ucrNudLastWord.SetParameter(New RParameter("end"))
        ucrNudLastWord.SetLinkedDisplayControl(lblFirstWord)
        'default value is 1

        ' ucrInputSeparator
        Dim dctInputSeparator As New Dictionary(Of String, String)
        ucrInputSeparator.SetParameter(New RParameter("sep"))
        dctInputSeparator.Add("Space", Chr(34) & " " & Chr(34))
        dctInputSeparator.Add("Colon", Chr(34) & ":" & Chr(34))
        dctInputSeparator.Add("Period", Chr(34) & "." & Chr(34))
        dctInputSeparator.Add("Underscore", Chr(34) & "_" & Chr(34))
        ' case of else: ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & ucrInputSeparator.GetText & Chr(34))
        ucrInputPad.SetItems(dctInputSeparator)
        ucrInputPad.SetLinkedDisplayControl(lblSeparator)
        ucrInputPad.cboInput.MaxLength = 1

        'rdoSubstring
        ucrPnlOperation.AddToLinkedControls(ucrNudFrom, {rdoWords}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOperation.AddToLinkedControls(ucrNudTo, {rdoWords}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrNud
        ucrNudFrom.SetParameter(New RParameter("start", ))
        ucrNudFrom.SetLinkedDisplayControl(lblFrom)
        '.AddParameter("start", -1)

        ucrNudTo.SetParameter(New RParameter("end", ))
        ucrNudTo.SetLinkedDisplayControl(lblTo)
        '.AddParameter("end", 1)

        'ucrNewColName
        ucrNewColName.SetIsTextBox()
        ucrNewColName.SetSaveTypeAsColumn()
        ucrNewColName.SetDataFrameSelector(ucrSelectorForTransformText.ucrAvailableDataFrames)
        ucrNewColName.SetLabelText("New Column Name:")
        ucrNewColName.SetPrefix("New_Text")
    End Sub

    Private Sub SetDefaults()
        ucrSelectorForTransformText.Reset()
        'rdoConvertCase.Checked = True

        'ucrInputSeparator.ResetText()
        'ucrInputPad.ResetText()
        'ucrInputTo.ResetText()

        Dim clsDefaultFunction As New RFunction
        ucrSelectorForTransformText.Reset()

        clsDefaultFunction.SetRCommand("") ' first check box, which changes
        clsDefaultFunction.SetAssignTo(strTemp:=ucrNewColName.GetText, strTempDataframe:=ucrSelectorForTransformText.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColName.GetText)

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    '  Private Sub ucrReceiverTransformText_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverTransformText.SelectionChanged
    '       If Not ucrReceiverTransformText.IsEmpty Then
    '      ucrBase.clsRsyntax.AddParameter("string", clsRFunctionParameter:=ucrReceiverTransformText.GetVariables())
    '     Else
    '    ucrBase.clsRsyntax.RemoveParameter("string")
    '   End If
    '  TestOkEnabled()
    'End Sub

    Private Sub FirstWordParameter()
        '        If rdoWords.Checked Then
        '       If chkFirstWord.Checked Then
        '      ucrReceiverFirstWord.SetMeAsReceiver()
        '     ucrReceiverFirstWord.Visible = True
        '    nudFirstWord.Enabled = False
        '   If Not ucrReceiverFirstWord.IsEmpty Then
        '  ucrBase.clsRsyntax.AddParameter("start", clsRFunctionParameter:=ucrReceiverFirstWord.GetVariables())
        ' End If
        'Else
        'ucrReceiverFirstWord.Visible = False
        'nudFirstWord.Enabled = True
        'ucrBase.clsRsyntax.AddParameter("start", nudFirstWord.Value)
        'If ucrReceiverLastWord.Visible Then
        'ucrReceiverLastWord.SetMeAsReceiver()
        'Else
        'ucrReceiverTransformText.SetMeAsReceiver()
        'End If
        'End If
        'End If
    End Sub

    Private Sub ConvertcaseFunc()
        '       If rdoConvertCase.Checked Then
        '      Select Case ucrInputTo.GetText
        '     Case "Lower"
        '    ucrBase.clsRsyntax.SetFunction("stringr::str_to_lower")
        '   Case "Upper"
        '  ucrBase.clsRsyntax.SetFunction("stringr::str_to_upper")
        ' Case "Title"
        'ucrBase.clsRsyntax.SetFunction("stringr::str_to_title")
        'End Select
        '
        'End If
    End Sub

    '   Private Sub WidthParameter()
    '  If rdoPad.Checked Then
    ' If rdoBothPad.Checked Or rdoLeftPad.Checked Or rdoRightPad.Checked Then
    '            ucrBase.clsRsyntax.AddParameter("width", nudWidth.Value)
    'Else
    '           ucrBase.clsRsyntax.RemoveParameter("width")
    'End If
    'End If
    'End Sub

    Private Sub nudFirstWord_TextChanged(sender As Object, e As EventArgs)
        '        If rdoWords.Checked Then
        '       ucrBase.clsRsyntax.AddParameter("start", nudFirstWord.Value)
        '      Else
        '     ucrBase.clsRsyntax.RemoveParameter("start")
        '    End If
    End Sub

    Private Sub nudLastWord_TextChanged(sender As Object, e As EventArgs)
        '   If rdoWords.Checked Then
        '  ucrBase.clsRsyntax.AddParameter("end", nudLastWord.Value)
        ' Else
        'ucrBase.clsRsyntax.RemoveParameter("end")
        'End If
    End Sub


    '   Private Sub WordSepParameter()
    '  If rdoWords.Checked Then
    ' Select Case ucrInputSeparator.GetText
    'Case "Space"
    '               ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & " " & Chr(34))
    'Case "Period"
    '               ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & "." & Chr(34))
    'Case "Colon"
    '               ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & ":" & Chr(34))
    'Case "Underscore"
    '               ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & "_" & Chr(34))
    'Case Else
    '               ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & ucrInputSeparator.GetText & Chr(34))
    'End Select
    'Else
    '       ucrBase.clsRsyntax.RemoveParameter("sep")
    'End If
    'End Sub

    '   Private Sub PadSideParameter()
    '  If rdoPad.Checked Then
    ' If rdoLeftPad.Checked Then
    '            ucrBase.clsRsyntax.AddParameter("side", Chr(34) & "left" & Chr(34))
    'ElseIf rdoRightPad.Checked Then
    '           ucrBase.clsRsyntax.AddParameter("side", Chr(34) & "right" & Chr(34))
    'ElseIf rdoBothPad.Checked Then
    '           ucrBase.clsRsyntax.AddParameter("side", Chr(34) & "both" & Chr(34))
    'Else
    '           ucrBase.clsRsyntax.RemoveParameter("side")
    'End If
    'End If
    'End Sub

    Private Sub TrimSideParameter()
        '        If rdoTrim.Checked Then
        '       ucrBase.clsRsyntax.SetFunction("stringr::str_trim")
        '      If rdoLeftTrim.Checked Then
        '     ucrBase.clsRsyntax.AddParameter("side", Chr(34) & "left" & Chr(34))
        '    ElseIf rdoRightTrim.Checked Then
        '   ucrBase.clsRsyntax.AddParameter("side", Chr(34) & "right" & Chr(34))
        '  ElseIf rdoBothTrim.Checked Then
        ' ucrBase.clsRsyntax.AddParameter("side", Chr(34) & "both" & Chr(34))
        'Else
        'ucrBase.clsRsyntax.RemoveParameter("side")
        'End If
        'End If
    End Sub

    Private Sub NudFromParameter()
        '     If rdoSubstring.Checked Then
        '    ucrBase.clsRsyntax.AddParameter("start", nudFrom.Value)
        '   Else
        '  ucrBase.clsRsyntax.RemoveParameter("start")
        ' End If
    End Sub

    Private Sub nudToParameter()
        '        If rdoSubstring.Checked Then
        '       ucrBase.clsRsyntax.AddParameter("end", nudTo.Value)
        '      Else
        '     ucrBase.clsRsyntax.RemoveParameter("end")
        '    End If
    End Sub

    Private Sub LastWordParameter()
        '       If rdoWords.Checked Then
        '      If chkLastWord.Checked Then
        '     nudLastWord.Enabled = False
        '    ucrReceiverLastWord.Visible = True
        '   ucrReceiverLastWord.SetMeAsReceiver()
        '  If Not ucrReceiverLastWord.IsEmpty Then
        ' ucrBase.clsRsyntax.AddParameter("end", clsRFunctionParameter:=ucrReceiverFirstWord.GetVariables())
        'Else
        'ucrBase.clsRsyntax.AddParameter("end", nudLastWord.Value)
        'End If
        'Else
        'ucrReceiverLastWord.Visible = False
        'nudLastWord.Enabled = True
        'ucrBase.clsRsyntax.AddParameter("end", nudLastWord.Value)
        'If ucrReceiverFirstWord.Visible Then
        'ucrReceiverFirstWord.SetMeAsReceiver()
        'Else
        'ucrReceiverTransformText.SetMeAsReceiver()
        'End If
        'End If
        'End If
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrReceiverTransformText.IsEmpty()) AndAlso ucrNewColName.IsComplete() Then
            If rdoConvertCase.Checked Then
                If Not ucrInputTo.IsEmpty() Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoLength.Checked Then
                ucrBase.OKEnabled(True)
            ElseIf rdoPad.Checked Then
                If Not ucrInputPad.IsEmpty() Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoTrim.Checked Then
                ucrBase.OKEnabled(True)
            ElseIf rdoSubstring.Checked Then
                ucrBase.OKEnabled(True)
            ElseIf rdoWords.Checked Then
                If Not ucrInputSeparator.IsEmpty() Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
    'also if the nuds are empty

    Private Sub ucrReceiverTransformText_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverTransformText.ControlContentsChanged, ucrPnlOperation.ControlContentsChanged, ucrInputPad.ControlContentsChanged, ucrNewColName.ControlContentsChanged, ucrInputSeparator.ControlContentsChanged, ucrInputPad.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class