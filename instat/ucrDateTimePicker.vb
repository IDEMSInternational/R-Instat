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

Imports RDotNet

Public Class ucrDateTimePicker
    ' Is the parameter value associated with the control an R Date type?
    ' If so then the control will set the parameter value in the form of: as.Date("2000/1/1")
    ' Otherwise, parameter value will be set as a string e.g. "2000/1/1"
    Public bIsRDate As Boolean = True

    Private strFormat As String = ""

    Private Sub ucrDateTimePicker_Load(sender As Object, e As EventArgs) Handles Me.Load
        If strFormat = "" Then
            Format = "dd MMM yyyy"
        End If
    End Sub

    Public Overrides Sub UpdateParameter(clsTempParam As RParameter)
        If bChangeParameterValue AndAlso clsTempParam IsNot Nothing Then
            clsTempParam.SetArgument(ValueAsRDate())
        End If
    End Sub

    Public Sub SetMinMax(dtNewMin As Date, dtNewMax As Date)
        MinDate = dtNewMin
        MaxDate = dtNewMax
    End Sub

    Public Property MinDate As Date
        Get
            Return dtpDateTime.MinDate
        End Get
        Set(dtNewMin As Date)
            dtpDateTime.MinDate = dtNewMin
        End Set
    End Property

    Public Property MaxDate As Date
        Get
            Return dtpDateTime.MaxDate
        End Get
        Set(dtNewMax As Date)
            dtpDateTime.MaxDate = dtNewMax
        End Set
    End Property

    Public Sub SetParameterIsRDate()
        bIsRDate = True
    End Sub

    ' Returns an RFunction which when run in R will return a Date type object of the form as.Date("2000/1/1")
    Public Function ValueAsRDate() As RFunction
        Dim clsAsDate As New RFunction

        clsAsDate.SetRCommand("as.Date")
        clsAsDate.AddParameter("x", Chr(34) & dtpDateTime.Value.Year & "/" & dtpDateTime.Value.Month & "/" & dtpDateTime.Value.Day & Chr(34))

        Return clsAsDate
    End Function

    Protected Overrides Sub SetControlValue()
        Dim clsDateCode As RCodeStructure
        Dim strDateExpression As String
        Dim lstCurrentVariables As String() = Nothing
        Dim clsTempParameter As RParameter
        Dim bInvalid As Boolean = False
        Dim clsIsDateFunction As RFunction
        Dim clsAsCharacterFunction As RFunction
        Dim expTemp As SymbolicExpression
        Dim bParameterIsDate As Boolean
        Dim strDateCharacter As String
        Dim strDateComponents As String()
        Dim dtNewDate As Date

        clsIsDateFunction = New RFunction
        clsIsDateFunction.SetPackageName("lubridate")
        clsIsDateFunction.SetRCommand("is.Date")
        clsAsCharacterFunction = New RFunction
        clsAsCharacterFunction.SetRCommand("as.character")

        clsTempParameter = GetParameter()
        If clsTempParameter IsNot Nothing Then
            If bChangeParameterValue Then
                If bIsRDate Then
                    If clsTempParameter.bIsFunction OrElse clsTempParameter.bIsOperator Then
                        clsDateCode = clsTempParameter.clsArgumentCodeStructure
                        If clsDateCode IsNot Nothing Then
                            If clsTempParameter.bIsFunction Then
                                clsIsDateFunction.AddParameter("x", clsRFunctionParameter:=clsDateCode)
                                clsAsCharacterFunction.AddParameter("x", clsRFunctionParameter:=clsDateCode)
                            Else
                                clsIsDateFunction.AddParameter("x", clsROperatorParameter:=clsDateCode)
                                clsAsCharacterFunction.AddParameter("x", clsROperatorParameter:=clsDateCode)
                            End If
                        Else
                            bInvalid = True
                        End If
                    ElseIf clsTempParameter.bIsString Then
                        strDateExpression = clsTempParameter.strArgumentValue
                        clsIsDateFunction.AddParameter("x", strParameterValue:=strDateExpression)
                        clsAsCharacterFunction.AddParameter("x", strParameterValue:=strDateExpression)
                    Else
                        'TODO This is when there is no value in the parameter. Should it give an error?
                        Exit Sub
                    End If
                    If Not bInvalid Then
                        ' Check if the parameter value is an R Date type object
                        expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsIsDateFunction.ToScript(), bSilent:=True, bShowWaitDialogOverride:=False)
                        If expTemp IsNot Nothing AndAlso expTemp.Type = Internals.SymbolicExpressionType.LogicalVector AndAlso expTemp.AsLogical.Count > 0 Then
                            bParameterIsDate = expTemp.AsLogical(0)
                        Else
                            bInvalid = True
                        End If
                        If bParameterIsDate Then
                            ' Convert the Date object to character so that the date can be correctly interpreted.
                            expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsAsCharacterFunction.ToScript(), bSilent:=True, bShowWaitDialogOverride:=False)
                            If expTemp IsNot Nothing AndAlso expTemp.Type = Internals.SymbolicExpressionType.CharacterVector AndAlso expTemp.AsLogical.Count > 0 Then
                                strDateCharacter = expTemp.AsCharacter(0)
                                strDateComponents = strDateCharacter.Split("-")
                                If strDateComponents.Count = 3 Then
                                    Try
                                        dtNewDate = New Date(year:=strDateComponents(0), month:=strDateComponents(1), day:=strDateComponents(2))
                                        'TODO Should this give an error or be allowed?
                                        If dtNewDate < dtpDateTime.MinDate Then
                                            dtpDateTime.Value = dtpDateTime.MinDate
                                        ElseIf dtNewDate > dtpDateTime.MaxDate Then
                                            dtpDateTime.Value = dtpDateTime.MaxDate
                                        Else
                                            dtpDateTime.Value = dtNewDate
                                        End If
                                    Catch ex As Exception
                                        bInvalid = True
                                    End Try
                                End If
                            Else
                                bInvalid = True
                            End If
                        End If
                    End If
                Else
                    'TODO case where parameter doesn't contain an R Date object e.g. this control could be used in as.Date and store a string.
                End If
                If bInvalid Then
                    MsgBox("Developer error: Cannot set value of control: " & Name & ". Expecting parameter value to be an R expression which evaluates an R Date object")
                End If
            End If
        End If
    End Sub

    Private Sub dtpDateTime_TextChanged(sender As Object, e As EventArgs) Handles dtpDateTime.TextChanged
        'TODO not sure what to raise here (if anything)
        'OnControlValueChanged()
    End Sub

    Private Sub dtpDateTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTime.ValueChanged
        OnControlValueChanged()
    End Sub

    Public Overrides Sub SetRDefault(objNewDefault As Object)
        Dim dtDefault As Date

        MyBase.SetRDefault(objNewDefault)
        If Not Date.TryParse(objNewDefault, dtDefault) Then
            MsgBox("Developer error: Cannot set the default value of control " & Me.Name & " because the value cannot be converted to a Date.")
        End If
    End Sub

    Public Overrides Function IsRDefault() As Boolean
        Dim dtDefault As Date

        If Date.TryParse(objRDefault, dtDefault) Then
            Return dtpDateTime.Value = dtDefault
        Else
            Return False
        End If
    End Function

    Public Property Format() As String
        Get
            Return strFormat
        End Get
        Set(strFormat As String)
            Me.strFormat = strFormat
            dtpDateTime.Format = DateTimePickerFormat.Custom
            dtpDateTime.CustomFormat = strFormat
        End Set
    End Property

    Public Property DateValue() As Date
        Get
            Return dtpDateTime.Value
        End Get
        Set(value As Date)
            dtpDateTime.Value = value
        End Set
    End Property
End Class
