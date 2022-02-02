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
Public Class dlgRecodeNumeric
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsCut2Function As New RFunction
    Private clsDummyRfunction As New RFunction
    Public strDefaultDataFrame As String = ""
    Public strDefaultColumn As String = ""

    Private Sub dlgRecode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 43

        ucrPnlRadioButtons.SetParameter(New RParameter("type", 0))
        ucrPnlRadioButtons.AddRadioButton(rdoLevels, "levels")
        ucrPnlRadioButtons.AddRadioButton(rdoMinimum, "minimum")
        ucrPnlRadioButtons.AddRadioButton(rdoBreakPoints, "points")

        ucrReceiverRecode.SetParameter(New RParameter("x", 0))
        ucrReceiverRecode.SetParameterIsRFunction()
        ucrReceiverRecode.Selector = ucrSelectorForRecode
        ucrReceiverRecode.SetIncludedDataTypes({"numeric"})
        ucrReceiverRecode.strSelectorHeading = "Numerics"
        ucrReceiverRecode.SetMeAsReceiver()

        ucrNudLevels.SetParameter(New RParameter("g", 1))
        ucrNudLevels.SetMinMax(1)
        ucrNudLevels.Value = 4

        ucrNudMinimum.SetParameter(New RParameter("m", 2))
        ucrNudMinimum.SetMinMax(1)

        ucrMultipleNumericRecode.SetValidationTypeAsNumericList(bNewAllowInf:=True)

        ttMinimum.SetToolTip(rdoMinimum, "Splits the data into groups of at least the specified size.")
        ttLevels.SetToolTip(rdoLevels, "For a value of 4, splits the data so 4 groups are produced of (roughly) equal size.")
        ttBreakpoint.SetToolTip(rdoBreakPoints, "Separate values by commas. For example 20, 30, 40, 50 gives 3 groups. If minimum is less than 20 then a 4th group is added. Similarly with a maximum more than 50.")

        ucrChkAddLabels.SetParameter(New RParameter("levels.mean", 4))
        ucrChkAddLabels.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkAddLabels.SetText("Label Groups with Means")
        ucrChkAddLabels.SetRDefault("FALSE")

        ucrPnlRadioButtons.AddToLinkedControls(ucrNudLevels, {rdoLevels}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="4")
        ucrPnlRadioButtons.AddToLinkedControls(ucrNudMinimum, {rdoMinimum}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="5")
        ucrPnlRadioButtons.AddToLinkedControls(ucrMultipleNumericRecode, {rdoBreakPoints}, bNewLinkedHideIfParameterMissing:=True)

        ucrSaveRecode.SetPrefix("recode")
        ucrSaveRecode.SetSaveTypeAsColumn()
        ucrSaveRecode.SetDataFrameSelector(ucrSelectorForRecode.ucrAvailableDataFrames)
        ucrSaveRecode.SetIsComboBox()
        ucrSaveRecode.SetLabelText("New Column Name:")
        ucrSaveRecode.setLinkedReceiver(ucrReceiverRecode)
    End Sub

    Private Sub SetDefaults()
        clsCut2Function = New RFunction
        clsDummyRfunction = New RFunction

        ucrSelectorForRecode.Reset()
        ucrSaveRecode.Reset()
        ucrMultipleNumericRecode.SetName("")

        clsCut2Function.SetPackageName("Hmisc")
        clsCut2Function.SetRCommand("cut2")
        clsDummyRfunction.AddParameter("type", "levels", iPosition:=0)

        ucrBase.clsRsyntax.SetBaseRFunction(clsCut2Function)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrNudMinimum.SetRCode(clsCut2Function, bReset)
        ucrNudLevels.SetRCode(clsCut2Function, bReset)
        ucrReceiverRecode.SetRCode(clsCut2Function, bReset)
        ucrSaveRecode.SetRCode(clsCut2Function, bReset)
        ucrChkAddLabels.SetRCode(clsCut2Function, bReset)
        ucrPnlRadioButtons.SetRCode(clsDummyRfunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverRecode.IsEmpty() AndAlso ucrSaveRecode.IsComplete AndAlso (rdoMinimum.Checked AndAlso Not ucrNudMinimum.IsEmpty OrElse rdoLevels.Checked AndAlso Not ucrNudLevels.IsEmpty OrElse rdoBreakPoints.Checked AndAlso Not ucrMultipleNumericRecode.IsEmpty) Then
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

    Private Sub ucrChkAddLabels_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddLabels.ControlValueChanged
        If ucrChkAddLabels.Checked Then
            clsCut2Function.AddParameter("digits", "3", iPosition:=6)
        Else
            clsCut2Function.RemoveParameterByName("digits")
        End If
    End Sub

    Private Sub ucrPnlRadioButtons_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlRadioButtons.ControlValueChanged, ucrMultipleNumericRecode.ControlValueChanged
        If rdoBreakPoints.Checked Then
            clsCut2Function.AddParameter("cuts", clsRFunctionParameter:=ucrMultipleNumericRecode.clsRList, iPosition:=5)
        Else
            clsCut2Function.RemoveParameterByName("cuts")
        End If
    End Sub

    Private Sub ucrControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrMultipleNumericRecode.ControlContentsChanged, ucrReceiverRecode.ControlContentsChanged,
        ucrSaveRecode.ControlContentsChanged, ucrChkAddLabels.ControlContentsChanged, ucrNudMinimum.ControlContentsChanged, ucrNudLevels.ControlContentsChanged, ucrPnlRadioButtons.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class