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
        SetDefaultColumn()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 43

        ucrPnlRadioButtons.AddRadioButton(rdoQuantiles)
        ucrPnlRadioButtons.AddRadioButton(rdoMinimum)

        ucrPnlRadioButtons.AddToLinkedControls(ucrNudQuantiles, {rdoQuantiles}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlRadioButtons.AddToLinkedControls(ucrNudMinimum, {rdoMinimum}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverRecode.SetParameter(New RParameter("x", iNewPosition:=2))
        ucrReceiverRecode.SetParameterIsRFunction()
        ucrReceiverRecode.Selector = ucrSelectorForRecode
        ucrReceiverRecode.SetIncludedDataTypes({"numeric"})
        ucrReceiverRecode.strSelectorHeading = "Numerics"

        ucrNudQuantiles.SetParameter(New RParameter("g", iNewPosition:=3))
        ucrNudQuantiles.SetMinMax(1, Integer.MaxValue)
        ucrNudQuantiles.SetRDefault(4)

        ucrNudMinimum.SetParameter(New RParameter("m", 2))
        ucrNudMinimum.SetMinMax(1, Integer.MaxValue)
        ucrNudMinimum.SetRDefault(1)

        ttMinimum.Show("Opens a control", rdoMinimum)
        ttMinimum.Hide(rdoMinimum)


        ttQuantiles.Show("Opens a control", rdoQuantiles)
        ttQuantiles.Hide(rdoQuantiles)

        ucrChkAddLabels.SetText("Label Groups with Means")

        ucrSaveRecode.SetPrefix("recode")
        ucrSaveRecode.SetSaveTypeAsColumn()
        ucrSaveRecode.SetDataFrameSelector(ucrSelectorForRecode.ucrAvailableDataFrames)
        ucrSaveRecode.SetIsComboBox()
        ucrSaveRecode.SetLabelText("New column name:")
        ucrSaveRecode.setLinkedReceiver(ucrReceiverRecode)

        ucrMultipleNumericRecode.SetValidationTypeAsNumericList(bNewAllowInf:=True)
        ucrMultipleNumericRecode.SetParameter(New RParameter("cuts", iNewPosition:=3,))


        ttBreakpoint.SetToolTip(ucrMultipleNumericRecode.txtInput, "Seperate break point with comma")
    End Sub

    Private Sub SetDefaultColumn()
        If strDefaultDataFrame <> "" Then
            ucrSelectorForRecode.SetDataframe(strDefaultDataFrame)
        End If
        If strDefaultColumn <> "" Then
            ucrReceiverRecode.Add(strDefaultColumn, strDefaultDataFrame)
            ucrSaveRecode.Focus()
        End If
        strDefaultDataFrame = ""
        strDefaultColumn = ""
    End Sub

    Private Sub SetDefaults()
        clsCut2Function = New RFunction

        rdoQuantiles.Checked = True

        ucrSelectorForRecode.Reset()
        ucrSaveRecode.Reset()
        ucrReceiverRecode.SetMeAsReceiver()
        ucrMultipleNumericRecode.SetName("")

        clsCut2Function.SetRCommand("cut2")
        clsCut2Function.SetPackageName("Hmisc")

        AddParameters()
        ucrBase.clsRsyntax.SetBaseRFunction(clsCut2Function)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrNudMinimum.SetRCode(clsCut2Function, bReset)
        ucrNudQuantiles.SetRCode(clsCut2Function, bReset)
        ucrReceiverRecode.SetRCode(clsCut2Function, bReset)
        ucrSaveRecode.SetRCode(clsCut2Function, bReset)

    End Sub

    Private Sub TestOKEnabled()

        If Not ucrReceiverRecode.IsEmpty() AndAlso ucrSaveRecode.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub AddParameters()
        If rdoMinimum.Checked = True Then
            rdoMinimum.Visible = True
        ElseIf rdoQuantiles.Checked = True Then
            ucrNudQuantiles.Visible = True
        Else
            ucrNudQuantiles.Visible = False
            ucrNudMinimum.Visible = False
        End If

        If ucrMultipleNumericRecode.IsEmpty Then
            clsCut2Function.RemoveParameterByName("cuts")
        Else
            clsCut2Function.AddParameter("cuts", clsRFunctionParameter:=ucrMultipleNumericRecode.clsRList, iPosition:=3)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrMultipleNumericRecode.ControlContentsChanged, ucrReceiverRecode.ControlContentsChanged,
            ucrSaveRecode.ControlContentsChanged, ucrChkAddLabels.ControlContentsChanged, ucrNudMinimum.ControlContentsChanged, ucrNudQuantiles.ControlContentsChanged, ucrPnlRadioButtons.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrChkAddLabels_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddLabels.ControlValueChanged
        If ucrChkAddLabels.Checked Then
            clsCut2Function.AddParameter(New RParameter("levels.mean", "TRUE", iNewPosition:=5))
            clsCut2Function.AddParameter(New RParameter("digits", "3", iNewPosition:=6))
        Else
            clsCut2Function.RemoveParameterByName("levels.mean")
            clsCut2Function.RemoveParameterByName("digits")
        End If
    End Sub

    Private Sub ucrMultipleNumericRecode_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrMultipleNumericRecode.ControlValueChanged
        AddParameters()
    End Sub
End Class