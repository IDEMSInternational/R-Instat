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

Imports instat

Public Class ucrDayOfYear
    ' Is the parameter value associated with the control a number
    ' If so then when the control value is e.g. 1 February the parameter value will be 32
    ' Otherwise, parameter value will be set as a string e.g. "1 February" or similar depending on string options
    Private bParameterIsNumber As Boolean = True
    Private bParameterIsString As Boolean = False
    ' If True uses 29 February is included and 31 December = 366
    ' Otherwise 29 February is not included and 31 December = 365
    ' TODO Not all features inplemented for b366DayOfYear = False
    Private b366DayOfYear As Boolean = True
    ' The start day for the doy column, usually 1 unless a shifted doy e.g. doy shifted to 1 February has iStartDay = 32
    Private iStartDay As Integer = 1
    Private dtbMonths As DataTable
    Private strMonthsFull As String()
    Private strMonthsAbbreviated As String()
    Private bUpdate As Boolean = True
    Private str31Days(30) As String
    Private str30Days(29) As String
    Private str28Days(27) As String
    Private str29Days(28) As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitialiseControls()
    End Sub

    Private Sub InitialiseControls()
        dtbMonths = New DataTable
        dtbMonths.Columns.Add("Number", GetType(Integer))
        dtbMonths.Columns.Add("Full", GetType(String))
        dtbMonths.Columns.Add("Abbreviated", GetType(String))
        'TODO should we use these instead of fixed English names?
        'System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames
        'System.Globalization.DateTimeFormatInfo.InvariantInfo.AbbreviatedMonthNames
        strMonthsFull = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
        strMonthsAbbreviated = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
        For i As Integer = 0 To 11
            dtbMonths.Rows.Add(i, strMonthsFull(i), strMonthsAbbreviated(i))
        Next
        'TODO Display/Value member should be changeable
        ucrInputMonth.SetDataSource(dtbMonths, strDisplayMember:="Abbreviated", strValueMember:="Number")
        ucrInputMonth.SetDropDownStyleAsNonEditable()
        For i As Integer = 0 To 30
            str31Days(i) = i + 1
            If i < 30 Then
                str30Days(i) = i + 1
            End If
            If i < 28 Then
                str28Days(i) = i + 1
            End If
            If i < 29 Then
                str29Days(i) = i + 1
            End If
        Next
        ucrInputDay.SetItems(str31Days)

        'The individual controls do not read the R code so they are not active.
        ucrInputDay.bIsActiveRControl = False
        ucrInputMonth.bIsActiveRControl = False
    End Sub

    Public Overrides Sub UpdateParameter(clsTempParam As RParameter)
        If bChangeParameterValue AndAlso clsTempParam IsNot Nothing AndAlso bUpdate Then
            clsTempParam.SetArgumentValue(GetValue())
        End If
    End Sub

    Public Sub SetParameterIsNumber()
        bParameterIsNumber = True
        bParameterIsString = False
    End Sub

    Public Sub SetParameterIsString()
        bParameterIsString = True
        bParameterIsNumber = False
    End Sub

    Public Sub SetStartDay(iNewStartDay As Integer)
        iStartDay = iNewStartDay
    End Sub

    ' Returns a string to be used as the parameter value, depending on the options set e.g. 366 or "31 December" or "31/12"
    Public Function GetValue() As String
        If bParameterIsNumber Then
            Return DayOfYearNumber()
        ElseIf bParameterIsString Then
            'TODO allow options to determine this format
            Return ucrInputDay.GetText() & " " & ucrInputMonth.GetText()
        Else
            Return ""
        End If
    End Function

    Public Function DayOfYearNumber() As Integer
        Dim iYear As Integer
        Dim dtTemp As Date
        Dim iMonth As Integer
        Dim iDay As Integer
        Dim iDoy As Integer

        If b366DayOfYear Then
            iYear = 2000
        Else
            iYear = 1999
        End If
        If ucrInputMonth.GetValue() IsNot Nothing AndAlso ucrInputDay.GetValue() IsNot Nothing Then
            Try
                If Integer.TryParse(ucrInputMonth.GetValue(), iMonth) AndAlso Integer.TryParse(ucrInputDay.GetValue(), iDay) Then
                    dtTemp = New Date(year:=iYear, month:=ucrInputMonth.GetValue() + 1, day:=ucrInputDay.GetValue())
                    iDoy = dtTemp.DayOfYear
                    iDoy = ModPos(iDoy - iStartDay + 1, If(b366DayOfYear, 366, 365))
                    Return iDoy
                End If
            Catch ex As Exception
                MsgBox("Developer error: Invalid month and/or day value. For control: " & Name & ".")
            End Try
        End If
        Return 1
    End Function

    Protected Overrides Sub SetControlValue()
        Dim strDayOfYearNumber As String
        Dim iDayOfYearNumber As Integer
        Dim clsTempParameter As RParameter
        Dim bInvalid As Boolean = False

        clsTempParameter = GetParameter()
        If clsTempParameter IsNot Nothing Then
            If bChangeParameterValue Then
                If bParameterIsNumber Then
                    If clsTempParameter.bIsString Then
                        strDayOfYearNumber = clsTempParameter.strArgumentValue
                        If Integer.TryParse(strDayOfYearNumber, iDayOfYearNumber) Then
                            bInvalid = Not SetValue(iDayOfYearNumber)
                        Else
                            bInvalid = True
                        End If
                    ElseIf clsTempParameter.bIsFunction OrElse clsTempParameter.bIsOperator Then
                        bInvalid = True
                    Else
                        'Clear? Reset?
                    End If
                Else
                    'TODO case where parameter isn't a number e.g. "14 Jan"
                End If
                If bInvalid Then
                    MsgBox("Developer error: Cannot set value of control: " & Name & ". Expecting parameter value to an R expression that can be interpreted as a day of the year")
                End If
            End If
        End If
    End Sub

    Public Overrides Sub SetRDefault(objNewDefault As Object)
        Dim iDefault As Integer

        MyBase.SetRDefault(objNewDefault)
        If Integer.TryParse(objNewDefault, iDefault) Then
            If Not (iDefault < 1 OrElse iDefault > 366 OrElse (Not b366DayOfYear AndAlso iDefault > 365)) Then
                MsgBox("Developer error: Cannot set the default value of control " & Me.Name & ". The default must be an integer day of the year.")
            End If
        End If
    End Sub

    Public Overrides Function IsRDefault() As Boolean
        Dim iDefault As Integer

        If Integer.TryParse(objRDefault, iDefault) Then
            Return (iDefault = GetValue())
        Else
            Return False
        End If
    End Function

    Private Sub ucrInputDay_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputDay.ControlContentsChanged
        OnControlContentsChanged()
    End Sub

    Private Sub ucrInputMonth_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputMonth.ControlContentsChanged
        OnControlContentsChanged()
    End Sub

    Private Sub ucrInputDay_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputDay.ControlValueChanged
        OnControlValueChanged()
    End Sub

    Private Sub ucrInputMonth_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputMonth.ControlValueChanged
        bUpdate = False
        AdjustDay()
        bUpdate = True
        OnControlValueChanged()
    End Sub

    Private Sub AdjustDay()
        Dim iMonth As Integer
        Dim iDay As Integer
        Dim iMaxFebDay As Integer
        Dim strFebDays As String()
        Dim iMaxDay As Integer = 31

        If b366DayOfYear Then
            iMaxFebDay = 29
            strFebDays = str29Days
        Else
            iMaxFebDay = 28
            strFebDays = str28Days
        End If

        If Integer.TryParse(ucrInputDay.GetValue(), iDay) Then
            If Integer.TryParse(ucrInputMonth.GetValue() + 1, iMonth) Then
                If {4, 6, 9, 11}.Contains(iMonth) AndAlso iDay = 31 Then
                    ucrInputDay.SetName(30)
                ElseIf iMonth = 2 AndAlso iDay > iMaxFebDay Then
                    ucrInputDay.SetName(iMaxFebDay)
                End If
                If {4, 6, 9, 11}.Contains(iMonth) Then
                    ucrInputDay.SetItems(str30Days)
                    iMaxDay = 30
                ElseIf iMonth = 2 Then
                    ucrInputDay.SetItems(strFebDays)
                    iMaxDay = iMaxFebDay
                Else
                    ucrInputDay.SetItems(str31Days)
                    iMaxDay = 31
                End If
            End If
        End If
        ucrInputDay.SetValidationTypeAsNumeric(dcmMin:=1, dcmMax:=iMaxDay)
    End Sub

    Public Function IsComplete() As Boolean
        Return (ucrInputDay.GetText() <> "" AndAlso ucrInputMonth.GetText() <> "")
    End Function

    Public Function SetValue(iDoy As Integer) As Boolean
        Dim iYear As Integer
        Dim dtTemp As Date
        Dim bSuccess As Boolean = True

        If b366DayOfYear Then
            iYear = 2000
            If iDoy < 1 OrElse iDoy > 366 Then
                bSuccess = False
            End If
        Else
            iYear = 1999
            If iDoy < 1 OrElse iDoy > 365 Then
                bSuccess = False
            End If
        End If
        If bSuccess Then
            Try
                iDoy = ModPos(iDoy + iStartDay - 1, If(b366DayOfYear, 366, 365))
                dtTemp = New Date(year:=iYear, month:=1, day:=1).AddDays(iDoy - 1)
                bUpdate = False

                'TODO this should be done through a method in ucrInputMonth
                ucrInputMonth.cboInput.SelectedIndex = dtTemp.Month - 1
                ucrInputDay.SetName(dtTemp.Day)
                bUpdate = True
                UpdateAllParameters()
            Catch ex As Exception
                bSuccess = False
            End Try
        End If
        Return bSuccess
    End Function

    Public Sub SetValue(iDay As Integer, iMonth As Integer)

    End Sub

    ' This is just x Mod m but this ensures positive (or non negative for bExcludeZero = False) is always returned
    Private Function ModPos(x As Integer, m As Integer, Optional bExcludeZero As Boolean = True) As Integer
        Dim y As Integer

        y = ((x Mod m) + m) Mod m
        If bExcludeZero Then
            If y = 0 Then
                y = m
            End If
        End If
        Return y
    End Function

End Class