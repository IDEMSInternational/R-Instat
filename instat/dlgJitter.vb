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
Public Class dlgJitter
    Public bReset As Boolean = True
    Public bFirstLoad As Boolean = True
    Private clsRunif As New RFunction
    Private clsRunifOperator As New ROperator

    Private Sub dlgJitter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 396

        'ucrReceiver
        ucrReceiverJitter.Selector = ucrSelectorForJitter
        ucrReceiverJitter.SetMeAsReceiver()

        ucrReceiverJitter.strSelectorHeading = "Numerics"
        ucrBase.clsRsyntax.SetOperation("+")
        clsRunif.SetRCommand("runif")
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRunif)
        'ucrInputNewColumnName.SetItemsTypeAsColumns()
        'ucrInputNewColumnName.SetDefaultTypeAsColumn()
        'ucrInputNewColumnName.SetDataFrameSelector(ucrSelectorForJitter.ucrAvailableDataFrames)

        ucrReceiverJitter.SetIncludedDataTypes({"numeric"})
        ucrReceiverJitter.SetParameterIsRFunction()

        ucrPnlDistance.AddRadioButton(rdoMaximumDistanceFromZero)
        ucrPnlDistance.AddRadioButton(rdoMinimumAndMaximum)

        ucrPnlDistance.AddParameterPresentCondition(rdoMaximumDistanceFromZero, "max")
        ucrPnlDistance.AddParameterPresentCondition(rdoMaximumDistanceFromZero, "min")
        ucrPnlDistance.AddParameterPresentCondition(rdoMaximumDistanceFromZero, "n", True)

        ' link
        ucrPnlDistance.AddToLinkedControls(ucrInputMaximumDistanceFromZero, {rdoMaximumDistanceFromZero}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=1)
        ucrPnlDistance.AddToLinkedControls(ucrInputMinimum, {rdoMinimumAndMaximum}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=0)
        ucrPnlDistance.AddToLinkedControls(ucrInputMaximum, {rdoMinimumAndMaximum}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=1)

        ucrInputMinimum.SetParameter(New RParameter("min"))
        ucrInputMinimum.bAddRemoveParameter = False
        ucrInputMinimum.SetValidationTypeAsNumeric()
        ucrInputMinimum.SetRDefault(0)
        ucrInputMinimum.AddQuotesIfUnrecognised = False

        ucrInputMaximum.SetParameter(New RParameter("max"))
        ucrInputMaximum.bAddRemoveParameter = False
        ucrInputMaximum.SetValidationTypeAsNumeric()
        ucrInputMaximum.SetRDefault(1)
        ucrInputMaximum.AddQuotesIfUnrecognised = False

        ucrInputMaximumDistanceFromZero.SetParameter(New RParameter("min"))
        ucrInputMaximumDistanceFromZero.bAddRemoveParameter = False
        ucrInputMaximumDistanceFromZero.SetValidationTypeAsNumeric()
        ucrInputMaximumDistanceFromZero.SetRDefault(1)
        ucrInputMaximumDistanceFromZero.AddQuotesIfUnrecognised = False

        'ucrInputNewColName
        ucrInputNewColName.SetIsComboBox()
        ucrInputNewColName.SetSaveTypeAsColumn()
        ucrInputNewColName.SetDataFrameSelector(ucrSelectorForJitter.ucrAvailableDataFrames)
        ucrInputNewColName.SetLabelText("Column Name:")
        ucrInputNewColName.SetPrefix("Jitter_values")

    End Sub

    Private Sub SetDefaults()
        clsRunif = New RFunction
        clsRunifOperator = New ROperator

        ucrSelectorForJitter.Reset()
        clsRunif.SetRCommand("runif")
        clsRunif.AddParameter("min", "1")
        clsRunif.AddParameter("max", "1")
        clsRunif.AddParameter("n", ucrSelectorForJitter.ucrAvailableDataFrames.iDataFrameLength)

        'Operations Set
        clsRunifOperator.SetOperation("+")
        clsRunifOperator.AddParameter("variable", clsRFunctionParameter:=clsRunif, iPosition:=1)
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputNewColName.GetText, strTempDataframe:=ucrSelectorForJitter.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputNewColName.GetText)
        ucrBase.clsRsyntax.SetBaseROperator(clsRunifOperator)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrInputMaximumDistanceFromZero.AddAdditionalCodeParameterPair(clsRunif, New RParameter("max"), iAdditionalPairNo:=1)
        ucrPnlDistance.SetRCode(clsRunif, bReset)
        ucrInputMaximum.SetRCode(clsRunif, bReset)
        ucrInputMinimum.SetRCode(clsRunif, bReset)
        ucrInputMaximumDistanceFromZero.SetRCode(clsRunif, bReset)
        ucrSelectorForJitter.SetRCode(clsRunif, bReset)
        ucrInputNewColName.SetRCode(ucrBase.clsRsyntax.clsBaseOperator, bReset)
        ucrReceiverJitter.SetRCode(ucrBase.clsRsyntax.clsBaseOperator, bReset)
        'Distance()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverJitter.IsEmpty AndAlso ucrInputNewColName.IsComplete AndAlso ((rdoMaximumDistanceFromZero.Checked AndAlso Not ucrInputMaximumDistanceFromZero.IsEmpty) OrElse Not rdoMaximumDistanceFromZero.Checked) AndAlso ((rdoMinimumAndMaximum.Checked AndAlso Not ucrInputMaximum.IsEmpty AndAlso Not ucrInputMinimum.IsEmpty) OrElse Not rdoMinimumAndMaximum.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub Distance()
        If rdoMaximumDistanceFromZero.Checked Then
            If Not ucrInputMaximumDistanceFromZero.IsEmpty Then
                clsRunif.AddParameter("min", -(ucrInputMaximumDistanceFromZero.GetText))
                clsRunif.AddParameter("max", ucrInputMaximumDistanceFromZero.GetText)
            End If
            ' Else
            '    If Not ucrInputMinimum.IsEmpty Then
            '        clsRunif.AddParameter("min", ucrInputMinimum.GetText)
            '    Else
            '        'clsRunif.RemoveParameterByName("min")
            '    End If
            '    If Not ucrInputMaximum.IsEmpty Then
            '        clsRunif.AddParameter("max", ucrInputMaximum.GetText) '
            '    Else
            '        'clsRunif.RemoveParameterByName("max")
            '    End If
        End If
    End Sub

    'Private Sub ucrSelectorForJitter_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForJitter.ControlValueChanged
    '    clsRunif.AddParameter("n", ucrSelectorForJitter.ucrAvailableDataFrames.iDataFrameLength)
    'End Sub

    Private Sub ucrForDistance_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputMaximum.ControlValueChanged, ucrInputMaximumDistanceFromZero.ControlValueChanged, ucrInputMinimum.ControlValueChanged, ucrPnlDistance.ControlValueChanged
        Distance()
        '  DefaultValue()
    End Sub

    Private Sub ucrReceiverJitter_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverJitter.ControlValueChanged
        ucrBase.clsRsyntax.SetOperatorParameter(1, clsRFunc:=ucrReceiverJitter.GetVariables)
    End Sub


    Private Sub ucrSelectorForJitter_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForJitter.ControlValueChanged
        'LengthOfDataset()

    End Sub

End Class