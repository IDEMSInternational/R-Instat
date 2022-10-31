Public Class sdgClimsoftDataOptions
    Private bControlsInitialised As Boolean = False
    Private clsLinkedRFunction As New RFunction
    Private dctQCFilter As New Dictionary(Of String, String)
    Private dctFormFilter As New Dictionary(Of String, String)

    Private Sub sdgClimsoftDataOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not bControlsInitialised Then
            InitialiseControls()
            bControlsInitialised = True
        End If
        'autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()

        '--------------------------------------------------------------------
        'Include columns controls

        ucrChkFlags.SetText("Include Flags")
        ucrChkFlags.SetParameter(New RParameter("include_flags", 8))
        ucrChkFlags.SetRDefault("FALSE")

        ucrChkQc.SetText("Include QC Status")
        ucrChkQc.SetParameter(New RParameter("include_qc_status", 9))
        ucrChkQc.SetRDefault("FALSE")

        ucrChkDataForm.SetText("Include Entry Form")
        ucrChkDataForm.SetParameter(New RParameter("include_entry_form", 10))
        ucrChkDataForm.SetRDefault("FALSE")

        '--------------------------------------------------------------------
        'QC controls 
        ucrChkQCFilter.SetText("Select Data with QC Status")
        ucrChkQCFilter.Checked = True

        dctQCFilter.Add("Zero (No QC Check)", "0")
        dctQCFilter.Add("One (Passed Limits Check)", "1")
        dctQCFilter.Add("Two (Passed Interelement Check)", "2")
        ucrCboQCFilter.SetParameter(New RParameter("qc_status", 13))
        ucrCboQCFilter.SetItems(dctQCFilter)
        ucrCboQCFilter.GetSetSelectedIndex = 0
        ucrCboQCFilter.bAllowNonConditionValues = False
        ucrCboQCFilter.SetDropDownStyleAsNonEditable()
        ucrChkQCFilter.AddToLinkedControls({ucrCboQCFilter}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        '---------------------------------------------------------------
        'filter controls 

        ucrChkFormFilter.SetText("Select Data of Form")
        ucrChkFormFilter.Checked = True

        dctFormFilter.Add("frm_daily2", Chr(34) & "form_daily2" & Chr(34))
        dctFormFilter.Add("frm_hourly", Chr(34) & "form_hourly" & Chr(34))
        dctFormFilter.Add("frm_hourlywind", Chr(34) & "form_hourlywind" & Chr(34))
        dctFormFilter.Add("frm_monthly", Chr(34) & "form_monthly" & Chr(34))
        dctFormFilter.Add("frm_synoptic_2_ra1", Chr(34) & "form_synoptic_2_ra1" & Chr(34))
        dctFormFilter.Add("frm_upperair1", Chr(34) & "form_upperair1" & Chr(34))

        ucrCboFormFilter.SetParameter(New RParameter("form_source", 14))
        ucrCboFormFilter.SetItems(dctFormFilter)
        ucrCboFormFilter.GetSetSelectedIndex = 0
        ucrCboFormFilter.bAllowNonConditionValues = False
        ucrCboFormFilter.SetDropDownStyleAsNonEditable()
        ucrChkFormFilter.AddToLinkedControls({ucrCboFormFilter}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        '---------------------------------------------------------------
        bControlsInitialised = True
    End Sub

    Public Sub SetUpRCode(clsNewRFunction As RFunction, bDisableIncludeColsOptions As Boolean)
        If Not bControlsInitialised Then
            InitialiseControls()
            bControlsInitialised = True
        End If

        clsLinkedRFunction = clsNewRFunction

        ucrChkQc.Enabled = bDisableIncludeColsOptions
        ucrChkDataForm.Enabled = bDisableIncludeColsOptions
        ucrChkFlags.Enabled = bDisableIncludeColsOptions
        'omit set r code for the controls if disabled
        If bDisableIncludeColsOptions Then
            ucrChkQc.SetRCode(clsLinkedRFunction, True)
            ucrChkDataForm.SetRCode(clsLinkedRFunction, True)
            ucrChkFlags.SetRCode(clsLinkedRFunction, True)
        End If

        ucrChkQCFilter.Checked = clsLinkedRFunction.ContainsParameter("qc_status")
        ucrChkFormFilter.Checked = clsLinkedRFunction.ContainsParameter("form_source")
    End Sub

    'todo. change these to dropdowns
    Private Sub ucrQCFilter_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkQCFilter.ControlValueChanged, ucrCboQCFilter.ControlValueChanged
        If ucrChkQCFilter.Checked AndAlso dctQCFilter.Count > 0 Then
            clsLinkedRFunction.AddParameter(strParameterName:="qc_status",
                                            strParameterValue:=dctQCFilter.Item(ucrCboQCFilter.GetText),
                                            iPosition:=13)
        Else
            clsLinkedRFunction.RemoveParameterByName("qc_status")
        End If
    End Sub

    Private Sub ucrFormFilter_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFormFilter.ControlValueChanged, ucrCboFormFilter.ControlValueChanged
        If ucrChkFormFilter.Checked AndAlso dctFormFilter.Count > 0 Then
            clsLinkedRFunction.AddParameter(strParameterName:="form_source",
                                            strParameterValue:=dctFormFilter.Item(ucrCboFormFilter.GetText),
                                            iPosition:=14)
        Else
            clsLinkedRFunction.RemoveParameterByName("form_source")
        End If
    End Sub

End Class