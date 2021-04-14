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
Imports RDotNet
Public Class dlgSetupForDataEntry
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsNewDataFrame As New RFunction
    Private clsAddFlag As New RFunction

    Private Sub dlgSetupForDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub
    Private Sub InitialiseDialog()

        ucrBase.iHelpTopicID = 359

        ucrReceiverStation.Selector = ucrSelectorSetupDataEntry
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.SetIncludedDataTypes({"factor"})
        ucrReceiverStation.strSelectorHeading = "Factors"

        ucrInputSelectStation.SetFactorReceiver(ucrReceiverStation)
        ucrInputSelectStation.AddQuotesIfUnrecognised = False
        ucrInputSelectStation.bFirstLevelDefault = True

        'ucrStartDate.SetParameter(New RParameter("start_date", iNewPosition:=8))
        'ucrDateFrom.SetParameterIsRDate()

        'ucrEndDate.SetParameter(New RParameter("end_date", iNewPosition:=9))
        'ucrDateTo.SetParameterIsRDate()

        ucrChkPrecip.SetText("precip")

        ucrChkTmax.SetText("tmax")

        ucrChkTmin.SetText("tmin")

        ucrChkSunh.SetText("sunh")

        ucrChkWD.SetText("wd")

        ucrChkWS.SetText("ws")

        ucrChkSpecify1.SetText("specify1")

        ucrChkSpecify2.SetText("specify2")

        ucrChkSpecify3.SetText("specify3")

        ucrChkAddFlagVariables.SetText("Add Flag Variables")
        'ucrChkAddFlagVariables.SetParameter(New RParameter("add_flag", iNewPosition:=11))
        ucrInputSpecify1.Visible = False
        ucrInputSpecify2.Visible = False
        ucrInputSpecify3.Visible = False

        ' ucrNewSheetName
        ucrNewDFName.SetSaveTypeAsDataFrame()
        ucrNewDFName.SetLabelText("New Data Frame Name:")
        ucrNewDFName.SetIsTextBox()

        ucrPnlOptions.AddRadioButton(rdoNew)
        ucrPnlOptions.AddRadioButton(rdoAddFlags)
        ucrPnlOptions.AddFunctionNamesCondition(rdoNew, "data.frame")
        ucrPnlOptions.AddFunctionNamesCondition(rdoAddFlags, "placeholdercommand")
        ucrPnlOptions.AddToLinkedControls({ucrInputSelectStation, ucrDateFrom, ucrDateTo, ucrChkAddFlagVariables, ucrNewDFName}, {rdoNew}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputSelectStation.SetLinkedDisplayControl(lblSelectStation)
        ucrDateFrom.SetLinkedDisplayControl(lblDateFrom)
        ucrDateTo.SetLinkedDisplayControl(lblDateTo)

    End Sub

    Private Sub SetDefaults()
        clsNewDataFrame = New RFunction
        clsAddFlag = New RFunction

        ucrSelectorSetupDataEntry.Reset()
        ucrReceiverStation.SetMeAsReceiver()
        ucrChkSpecify1.Checked = False
        ucrChkSpecify2.Checked = False
        ucrChkSpecify3.Checked = False
        ucrChkPrecip.Checked = False
        ucrChkSunh.Checked = False
        ucrChkTmax.Checked = False
        ucrChkTmin.Checked = False
        ucrChkWS.Checked = False
        ucrChkWD.Checked = False
        ucrChkAddFlagVariables.Checked = False
        'todo. what should be the default date
        ucrDateFrom.DateValue = Date.Now
        ucrDateTo.DateValue = ucrDateFrom.DateValue.AddMonths(1).AddDays(-1)

        clsNewDataFrame.SetRCommand("data.frame")
        clsAddFlag.SetRCommand("placeholdercommand")

        clsNewDataFrame.SetAssignTo(ucrNewDFName.GetText(), strTempDataframe:=ucrNewDFName.GetText())
        ucrBase.clsRsyntax.SetBaseRFunction(clsNewDataFrame)
    End Sub
    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrNewDFName.SetRCode(clsNewDataFrame, bReset)

    End Sub
    Private Sub TestOkEnabled()
        If Not ucrReceiverStation.IsEmpty AndAlso (ucrChkPrecip.Checked OrElse ucrChkSunh.Checked OrElse ucrChkTmax.Checked OrElse ucrChkTmin.Checked OrElse
            ucrChkWD.Checked OrElse ucrChkWS.Checked OrElse ucrChkSpecify1.Checked OrElse ucrChkSpecify2.Checked OrElse ucrChkSpecify3.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
    Private Sub AddRemoveParameter()
        If ucrChkPrecip.Checked Then
            clsNewDataFrame.AddParameter("precip", "as.numeric(NA)", iPosition:=2)
        Else
            clsNewDataFrame.RemoveParameterByName("precip")
        End If
        If ucrChkTmax.Checked Then
            clsNewDataFrame.AddParameter("tmax", "as.numeric(NA)", iPosition:=3)
        Else
            clsNewDataFrame.RemoveParameterByName("tmax")
        End If
        If ucrChkTmin.Checked Then
            clsNewDataFrame.AddParameter("tmin", "as.numeric(NA)", iPosition:=4)
        Else
            clsNewDataFrame.RemoveParameterByName("tmin")
        End If
        If ucrChkSunh.Checked Then
            clsNewDataFrame.AddParameter("sunh", "as.numeric(NA)", iPosition:=5)
        Else
            clsNewDataFrame.RemoveParameterByName("sunh")
        End If
        If ucrChkWS.Checked Then
            clsNewDataFrame.AddParameter("ws", "as.numeric(NA)", iPosition:=6)
        Else
            clsNewDataFrame.RemoveParameterByName("ws")
        End If
        If ucrChkWD.Checked Then
            clsNewDataFrame.AddParameter("wd", "as.numeric(NA)", iPosition:=7)
        Else
            clsNewDataFrame.RemoveParameterByName("wd")
        End If
    End Sub

    'todo. merge this subroutine with AddRemoveParameter() subroutine
    Private Sub AddFlagVariables()
        Dim nrows As Integer = GetNumberOfRows()

        If ucrChkPrecip.Checked AndAlso ucrChkAddFlagVariables.Checked Then
            clsNewDataFrame.AddParameter("precip_fl", "factor(rep(NA," & nrows & "), levels = c(" & Chr(34) & "data" & Chr(34) & "," & Chr(34) & "edit" & Chr(34) & "," & Chr(34) & "add" & Chr(34) & "))", iPosition:=11)
        Else
            clsNewDataFrame.RemoveParameterByName("precip_fl")
        End If
        If ucrChkTmax.Checked AndAlso ucrChkAddFlagVariables.Checked Then
            clsNewDataFrame.AddParameter("tmax_fl", "factor(rep(NA," & nrows & "), levels = c(" & Chr(34) & "data" & Chr(34) & "," & Chr(34) & "edit" & Chr(34) & "," & Chr(34) & "add" & Chr(34) & "))", iPosition:=12)
        Else
            clsNewDataFrame.RemoveParameterByName("tmax_fl")
        End If
        If ucrChkTmin.Checked AndAlso ucrChkAddFlagVariables.Checked Then
            clsNewDataFrame.AddParameter("tmin_fl", "factor(rep(NA," & nrows & "), levels = c(" & Chr(34) & "data" & Chr(34) & "," & Chr(34) & "edit" & Chr(34) & "," & Chr(34) & "add" & Chr(34) & "))", iPosition:=13)
        Else
            clsNewDataFrame.RemoveParameterByName("tmin_fl")
        End If
        If ucrChkSunh.Checked AndAlso ucrChkAddFlagVariables.Checked Then
            clsNewDataFrame.AddParameter("sunh_fl", "factor(rep(NA," & nrows & "), levels = c(" & Chr(34) & "data" & Chr(34) & "," & Chr(34) & "edit" & Chr(34) & "," & Chr(34) & "add" & Chr(34) & "))", iPosition:=14)
        Else
            clsNewDataFrame.RemoveParameterByName("sunh_fl")
        End If
        If ucrChkWD.Checked AndAlso ucrChkAddFlagVariables.Checked Then
            clsNewDataFrame.AddParameter("wd_fl", "factor(rep(NA," & nrows & "), levels = c(" & Chr(34) & "data" & Chr(34) & "," & Chr(34) & "edit" & Chr(34) & "," & Chr(34) & "add" & Chr(34) & "))", iPosition:=15)
        Else
            clsNewDataFrame.RemoveParameterByName("wd_fl")
        End If
        If ucrChkWS.Checked AndAlso ucrChkAddFlagVariables.Checked Then
            clsNewDataFrame.AddParameter("ws_fl", "factor(rep(NA," & nrows & "), levels = c(" & Chr(34) & "data" & Chr(34) & "," & Chr(34) & "edit" & Chr(34) & "," & Chr(34) & "add" & Chr(34) & "))", iPosition:=16)
        Else
            clsNewDataFrame.RemoveParameterByName("ws_fl")
        End If
        If ucrChkSpecify1.Checked AndAlso ucrChkAddFlagVariables.Checked Then
            clsNewDataFrame.AddParameter(ucrInputSpecify1.GetValue() & "_fl", "factor(rep(NA," & nrows & "), levels = c(" & Chr(34) & "data" & Chr(34) & "," & Chr(34) & "edit" & Chr(34) & "," & Chr(34) & "add" & Chr(34) & "))", iPosition:=17)
        Else
            clsNewDataFrame.RemoveParameterByName(ucrInputSpecify1.GetValue() & "_fl")
        End If
        If ucrChkSpecify2.Checked AndAlso ucrChkAddFlagVariables.Checked Then
            clsNewDataFrame.AddParameter(ucrInputSpecify2.GetValue() & "_fl", "factor(rep(NA," & nrows & "), levels = c(" & Chr(34) & "data" & Chr(34) & "," & Chr(34) & "edit" & Chr(34) & "," & Chr(34) & "add" & Chr(34) & "))", iPosition:=18)
        Else
            clsNewDataFrame.RemoveParameterByName(ucrInputSpecify2.GetValue() & "_fl")
        End If
        If ucrChkSpecify3.Checked AndAlso ucrChkAddFlagVariables.Checked Then
            clsNewDataFrame.AddParameter(ucrInputSpecify3.GetValue() & "_fl", "factor(rep(NA," & nrows & "), levels = c(" & Chr(34) & "data" & Chr(34) & "," & Chr(34) & "edit" & Chr(34) & "," & Chr(34) & "add" & Chr(34) & "))", iPosition:=19)
        Else
            clsNewDataFrame.RemoveParameterByName(ucrInputSpecify3.GetValue() & "_fl")
        End If
    End Sub



    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged, ucrInputSelectStation.ControlValueChanged
        If Not ucrReceiverStation.IsEmpty AndAlso Not ucrInputSelectStation.IsEmpty Then
            clsNewDataFrame.AddParameter(ucrReceiverStation.GetVariableNames(bWithQuotes:=False), "as.factor(" & ucrInputSelectStation.GetValue() & ")", iPosition:=0)
            ucrNewDFName.SetPrefix(ucrInputSelectStation.GetValue().ToString.Trim(Chr(34)).ToLower.Replace(" ", "_"))
        Else
            clsNewDataFrame.RemoveParameterByName(ucrReceiverStation.GetVariableNames(bWithQuotes:=False))
        End If
    End Sub
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub
    Private Sub ucrControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlContentsChanged, ucrChkPrecip.ControlContentsChanged, ucrChkSunh.ControlContentsChanged, ucrChkTmax.ControlContentsChanged, ucrChkTmin.ControlContentsChanged, ucrChkWD.ControlContentsChanged, ucrChkWS.ControlContentsChanged, ucrChkSpecify1.ControlContentsChanged, ucrChkSpecify2.ControlContentsChanged, ucrChkSpecify3.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged
        TestOkEnabled()
    End Sub
    Private Sub ucrDateTo_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrDateTo.ControlValueChanged, ucrDateFrom.ControlValueChanged
        clsNewDataFrame.AddParameter("date", "seq(" & "as.Date(" & Chr(34) & ucrDateFrom.DateValue.ToString("yyyy-MM-dd") & Chr(34) & ")" & "," & "as.Date(" & Chr(34) & ucrDateTo.DateValue.ToString("yyyy-MM-dd") & Chr(34) & ")" & "," & Chr(34) & "day" & Chr(34) & ")", iPosition:=1)
        AddFlagVariables()
    End Sub

    Private Sub ucrChkSpecify1_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSpecify1.ControlValueChanged
        ucrInputSpecify1.Visible = ucrChkSpecify1.Checked
    End Sub
    Private Sub ucrChkSpecify2_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSpecify2.ControlValueChanged
        ucrInputSpecify2.Visible = ucrChkSpecify2.Checked
    End Sub
    Private Sub ucrChkSpecify3_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSpecify3.ControlValueChanged
        ucrInputSpecify3.Visible = ucrChkSpecify3.Checked
    End Sub
    Private Sub ucrInputSpecify1_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSpecify1.ControlValueChanged, ucrChkSpecify1.ControlValueChanged
        If Not ucrInputSpecify1.IsEmpty AndAlso ucrChkSpecify1.Checked Then
            clsNewDataFrame.AddParameter(ucrInputSpecify1.GetValue(), "as.numeric(NA)", iPosition:=8)
        Else
            clsNewDataFrame.RemoveParameterByName(ucrInputSpecify1.GetValue())
        End If
        AddFlagVariables()
    End Sub
    Private Sub ucrInputSpecify2_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSpecify2.ControlValueChanged, ucrChkSpecify2.ControlValueChanged
        If Not ucrInputSpecify2.IsEmpty AndAlso ucrChkSpecify2.Checked Then
            clsNewDataFrame.AddParameter(ucrInputSpecify2.GetValue(), "as.numeric(NA)", iPosition:=9)
        Else
            clsNewDataFrame.RemoveParameterByName(ucrInputSpecify2.GetValue())
        End If
        AddFlagVariables()
    End Sub
    Private Sub ucrInputSpecify3_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSpecify3.ControlValueChanged, ucrChkSpecify3.ControlValueChanged
        If Not ucrInputSpecify3.IsEmpty AndAlso ucrChkSpecify3.Checked Then
            clsNewDataFrame.AddParameter(ucrInputSpecify3.GetValue(), "as.numeric(NA)", iPosition:=10)
        Else
            clsNewDataFrame.RemoveParameterByName(ucrInputSpecify3.GetValue())
        End If
        AddFlagVariables()
    End Sub

    Private Sub ucrChkPrecip_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddFlagVariables.ControlValueChanged, ucrChkPrecip.ControlValueChanged, ucrChkSunh.ControlValueChanged, ucrChkTmax.ControlValueChanged, ucrChkTmin.ControlValueChanged, ucrChkWD.ControlValueChanged, ucrChkWS.ControlValueChanged
        AddRemoveParameter()
        AddFlagVariables()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        If rdoNew.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsNewDataFrame)
            grpElements.Visible = True
            AddRemoveParameter()
            AddFlagVariables()
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsAddFlag)
            grpElements.Visible = False
        End If
    End Sub

    Private Function GetNumberOfRows() As Integer
        Return (ucrDateTo.DateValue.Day - ucrDateFrom.DateValue.Day) + 1
    End Function

End Class