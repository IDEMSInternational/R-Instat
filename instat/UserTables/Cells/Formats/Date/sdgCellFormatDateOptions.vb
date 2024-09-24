Public Class sdgCellFormatDateOptions

    Private clsFormatDateRFunction As New RFunction
    Private bFirstload As Boolean = True

    Private bUserMadeChanges As Boolean = False
    Private bUserClickedReturn As Boolean = False

    Private Sub sdgCellFormatDateOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If

        SetDefaults()
        SetRCode(True)

        bUserMadeChanges = False
        bUserClickedReturn = False
    End Sub

    Private Sub InitialiseDialog()
        Dim dctDateFormat As New Dictionary(Of String, String) From {
            {"2000-02-29", Chr(34) & "iso" & Chr(34)},
            {"Tuesday, February 29, 2000", Chr(34) & "wday_month_day_year" & Chr(34)},
            {"Tue, Feb 29, 2000", Chr(34) & "wd_m_day_year" & Chr(34)},
            {"Tuesday 29 February 2000", Chr(34) & "wday_day_month_year" & Chr(34)},
            {"February 29, 2000", Chr(34) & "month_day_year" & Chr(34)},
            {"Feb 29, 2000", Chr(34) & "m_day_year" & Chr(34)},
            {"29 Feb 2000", Chr(34) & "day_m_year" & Chr(34)},
            {"29 February 2000", Chr(34) & "day_month_year" & Chr(34)},
            {"29 February", Chr(34) & "day_month" & Chr(34)},
            {"29 Feb", Chr(34) & "day_m" & Chr(34)},
            {"2000", Chr(34) & "year" & Chr(34)},
            {"February", Chr(34) & "month" & Chr(34)},
            {"29", Chr(34) & "day" & Chr(34)},
            {"2000/02/29", Chr(34) & "year.mn.day" & Chr(34)},
            {"00/02/2", Chr(34) & " y.mn.day" & Chr(34)},
            {"2000-W09", Chr(34) & "year_week" & Chr(34)},
            {"2000-Q1", Chr(34) & "year_quarter" & Chr(34)},
            {"2/29/2000 (flexible)", Chr(34) & "yMd" & Chr(34)},
            {"Tue, 2/29/2000 (flexible)", Chr(34) & "yMEd" & Chr(34)},
            {"Feb 2000 (flexible)", Chr(34) & "yMMM" & Chr(34)},
            {"February 2000 (flexible)", Chr(34) & "yMMMM" & Chr(34)},
            {"Feb 29, 2000 (flexible)", Chr(34) & "yMMMd" & Chr(34)},
            {"Tue, Feb 29, 2000 (flexible)", Chr(34) & "yMMMEd" & Chr(34)},
            {"2/29/2000 A (flexible)", Chr(34) & "GyMd" & Chr(34)},
            {"Feb 29, 2000 AD (flexible)", Chr(34) & "GyMMMd" & Chr(34)},
            {"Tue, Feb 29, 2000 AD  (flexible)", Chr(34) & "GyMMMEd" & Chr(34)},
            {"2/2000 (flexible)", Chr(34) & "yM" & Chr(34)},
            {"2/29 (flexible)", Chr(34) & "Md" & Chr(34)},
            {"Tue, 2/29 (flexible)", Chr(34) & "MEd" & Chr(34)},
            {"Feb 29 (flexible)", Chr(34) & "MMMd" & Chr(34)},
            {"Tue, Feb 29 (flexible)", Chr(34) & "MMMEd" & Chr(34)},
            {"February 29 (flexible)", Chr(34) & "MMMMd" & Chr(34)},
            {"Feb 2000 AD (flexible)", Chr(34) & "GyMMM" & Chr(34)},
            {"Q1 2000 (flexible)", Chr(34) & "yQQQ" & Chr(34)},
            {"1st quarter 2000", Chr(34) & "yQQQQ" & Chr(34)},
            {"2000 AD (flexible)", Chr(34) & "Gy" & Chr(34)},
            {"2000 (flexible)", Chr(34) & "y" & Chr(34)},
            {"Feb (flexible)", Chr(34) & "MMM" & Chr(34)},
            {"29 (flexible)", Chr(34) & "d" & Chr(34)},
            {"29 Tue (flexible)", Chr(34) & "Ed" & Chr(34)}
        }

        ucrInputCboDateFormat.SetParameter(New RParameter("date_style", 3))
        ucrInputCboDateFormat.SetItems(dctDateFormat)
        ucrInputCboDateFormat.SetDropDownStyleAsNonEditable()
        ucrInputCboDateFormat.SetRDefault("iso")

    End Sub

    Private Sub SetDefaults()
        clsFormatDateRFunction = New RFunction

        clsFormatDateRFunction.SetPackageName("gt")
        clsFormatDateRFunction.SetRCommand("fmt_date")
        clsFormatDateRFunction.AddParameter(strParameterName:="date_style", strParameterValue:=Chr(34) & "iso" & Chr(34))

    End Sub

    Private Sub SetRCode(bReset As Boolean)
        ucrInputCboDateFormat.SetRCode(clsFormatDateRFunction, bReset)
    End Sub

    Public Function GetNewUserInputAsRFunction() As RFunction
        If Not bUserClickedReturn OrElse Not bUserMadeChanges Then
            Return Nothing
        End If

        Return clsFormatDateRFunction
    End Function


    Private Sub ucrSdgBaseButtons_ClickReturn(sender As Object, e As EventArgs) Handles ucrSdgBaseButtons.ClickReturn
        bUserClickedReturn = True
    End Sub

    Private Sub controls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputCboDateFormat.ControlValueChanged
        bUserMadeChanges = True
    End Sub


End Class