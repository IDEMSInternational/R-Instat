Public Class sdgClimsoftDataOptions
    'Public bFirstLoad As Boolean = True
    Public bControlsInitialised As Boolean = False
    Public clsDefaultFunction As New RFunction
    Public bOKEnabled As Boolean = True

    Private Sub sdgClimsoftDataOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bControlsInitialised Then
            InitialiseControls()
            bControlsInitialised = False
        End If
        'autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()

        '--------------------------------------------------------------------
        'Include columns controls

        ucrChkFlags.SetText("Include Flags")
        ucrChkFlags.SetParameter(New RParameter("include_flags", 7))
        ucrChkFlags.SetRDefault("FALSE")

        ucrChkQc.SetText("Include QC Status")
        ucrChkQc.SetParameter(New RParameter("include_qc_status", 7))
        ucrChkQc.SetRDefault("FALSE")

        ucrChkDataForm.SetText("Include Entry Form")
        ucrChkDataForm.SetParameter(New RParameter("include_entry_form", 7))
        ucrChkDataForm.SetRDefault("FALSE")

        '--------------------------------------------------------------------
        'QC controls 
        ucrChkQCFilter.SetText("Select Data with QC Status")

        Dim dctQCFilter As New Dictionary(Of String, String)
        dctQCFilter.Add("Zero (No QC Check)", Chr(34) & "0" & Chr(34))
        dctQCFilter.Add("One (Passed Limits Check)", Chr(34) & "1" & Chr(34))
        dctQCFilter.Add("Two (Passed Interelement Check)", Chr(34) & "2" & Chr(34))
        ucrCboQCFilter.SetParameter(New RParameter("qc_status", 1))
        ucrCboQCFilter.SetItems(dctQCFilter)
        ucrCboQCFilter.bAllowNonConditionValues = False
        ucrCboQCFilter.SetDropDownStyleAsNonEditable()
        ucrChkQCFilter.AddToLinkedControls({ucrCboQCFilter}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        '---------------------------------------------------------------
        'filter controls 

        ucrChkFormFilter.SetText("Select Data of Form")

        Dim dctFormFilter As New Dictionary(Of String, String)
        dctFormFilter.Add("frm_daily2", Chr(34) & "frm_daily2" & Chr(34))
        dctFormFilter.Add("frm_hourly", Chr(34) & "frm_hourly" & Chr(34))
        dctFormFilter.Add("frm_hourlywind", Chr(34) & "frm_hourlywind" & Chr(34))
        dctFormFilter.Add("frm_monthly", Chr(34) & "frm_monthly" & Chr(34))
        dctFormFilter.Add("frm_synoptic_2_ra1", Chr(34) & "frm_synoptic_2_ra1" & Chr(34))
        dctFormFilter.Add("frm_upperair1", Chr(34) & "frm_upperair1" & Chr(34))

        ucrCboFormFilter.SetParameter(New RParameter("form_source", 1))
        ucrCboFormFilter.SetItems(dctFormFilter)
        ucrCboFormFilter.bAllowNonConditionValues = False
        ucrCboFormFilter.SetDropDownStyleAsNonEditable()
        ucrChkFormFilter.AddToLinkedControls({ucrCboFormFilter}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        '---------------------------------------------------------------
        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewDefaultFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsDefaultFunction = clsNewDefaultFunction

        ucrChkFlags.SetRCode(clsDefaultFunction, bReset)
        ucrChkQc.SetRCode(clsDefaultFunction, bReset)
        ucrChkDataForm.SetRCode(clsDefaultFunction, bReset)

        ucrCboQCFilter.SetRCode(clsDefaultFunction, bReset)
        ucrChkFormFilter.SetRCode(clsDefaultFunction, bReset)

        'todo. left here. uncheck or check the combobox check boxes. Probably in the load event

    End Sub
End Class