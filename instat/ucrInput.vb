﻿' Instat-R
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

Public Class ucrInput
    Public bUserTyped As Boolean = False
    Public Event NameChanged()
    Public Event ContentsChanged()
    Protected strValidationType As String = "None"
    Dim strReservedWords() As String = ({"if", "else", "repeat", "while", "function", "for", "in", "next", "break", "TRUE", "FALSE", "NULL", "Inf", "NaN", "NA", "NA_integer_", "NA_real_", "NA_complex_", "NA_character_"})
    Public clsRList As New RFunction
    Protected dcmMinimum As Decimal = Decimal.MinValue
    Protected dcmMaximum As Decimal = Decimal.MaxValue
    Protected bMinimumIncluded, bMaximumIncluded As Boolean
    Protected strDefaultType As String = ""
    Protected strDefaultPrefix As String = ""
    Protected WithEvents ucrDataFrameSelector As ucrDataFrame
    Protected bIsReadOnly As Boolean = False
    Public bAutoChangeOnLeave As Boolean = False
    Private bLastSilent As Boolean = False
    Public bAddQuotesIfUnrecognised As Boolean = True
    Protected dctDisplayParameterValues As New Dictionary(Of String, String)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bUpdateRCodeFromControl = True
    End Sub

    Public Overridable Sub SetName(strName As String, Optional bSilent As Boolean = False)
        bLastSilent = bSilent
    End Sub

    Public Overridable Function GetText() As String
        Return ""
    End Function

    Public Overridable Sub Reset()
        bUserTyped = False
    End Sub

    Public Sub OnNameChanged()
        Me.Text = Me.GetText()
        If bChangeParameterValue AndAlso clsParameter IsNot Nothing Then
            If dctDisplayParameterValues.ContainsKey(GetText()) Then
                clsParameter.SetArgumentValue(dctDisplayParameterValues(GetText()))
            Else
                If bAddQuotesIfUnrecognised Then
                    clsParameter.SetArgumentValue(Chr(34) & GetText() & Chr(34))
                Else
                    clsParameter.SetArgumentValue(GetText())
                End If
            End If
        End If
        UpdateRCode()
        RaiseEvent NameChanged()
        OnControlValueChanged()
    End Sub

    Public Sub OnContentsChanged()
        RaiseEvent ContentsChanged()
        OnControlContentsChanged()
    End Sub

    Public Function UserTyped() As Boolean
        Return bUserTyped
    End Function

    Public Sub SetDefaultTypeAsColumn()
        strDefaultType = "Column"
        SetDefaultName()
    End Sub

    Public Sub SetDefaultTypeAsModel()
        strDefaultType = "Model"
        SetDefaultName()
    End Sub

    Public Sub SetDefaultTypeAsDataFrame()
        strDefaultType = "Data Frame"
        SetDefaultName()
    End Sub

    Public Sub SetDefaultTypeAsGraph()
        strDefaultType = "Graph"
        SetDefaultName()
    End Sub

    Public Sub SetValidationTypeAsRVariable()
        strValidationType = "RVariable"
        SetDefaultName()
    End Sub

    Public Sub SetDefaultTypeAsFilter()
        strDefaultType = "Filter"
        SetDefaultName()
    End Sub

    Public Overridable Sub SetDataFrameSelector(ucrNewSelector As ucrDataFrame)
        ucrDataFrameSelector = ucrNewSelector
        If Not bUserTyped Then
            SetDefaultName()
        End If
    End Sub

    Public Sub SetPrefix(strNewPrefix As String)
        strDefaultPrefix = strNewPrefix
        SetDefaultName()
    End Sub

    Public Sub SetDefaultName()
        If strDefaultPrefix <> "" Then
            If strDefaultType = "Column" Then
                If ucrDataFrameSelector IsNot Nothing AndAlso ucrDataFrameSelector.cboAvailableDataFrames.Text <> "" AndAlso frmMain.clsRLink.DataFrameExists(ucrDataFrameSelector.cboAvailableDataFrames.Text) Then
                    SetName(frmMain.clsRLink.GetDefaultColumnNames(strDefaultPrefix, ucrDataFrameSelector.cboAvailableDataFrames.Text))
                Else
                    SetName("")
                End If
            ElseIf strDefaultType = "Model" Then
                If ucrDataFrameSelector IsNot Nothing AndAlso ucrDataFrameSelector.cboAvailableDataFrames.Text <> "" Then
                    SetName(frmMain.clsRLink.GetNextDefault(strDefaultPrefix, frmMain.clsRLink.GetModelNames(ucrDataFrameSelector.cboAvailableDataFrames.Text)))
                Else
                    SetName(frmMain.clsRLink.GetNextDefault(strDefaultPrefix, frmMain.clsRLink.GetModelNames()))
                End If
            ElseIf strDefaultType = "Data Frame" Then
                SetName(frmMain.clsRLink.GetNextDefault(strDefaultPrefix, frmMain.clsRLink.GetDataFrameNames()))
            ElseIf strDefaultType = "Graph" Then
                If ucrDataFrameSelector IsNot Nothing AndAlso ucrDataFrameSelector.cboAvailableDataFrames.Text <> "" Then
                    SetName(frmMain.clsRLink.GetNextDefault(strDefaultPrefix, frmMain.clsRLink.GetGraphNames(ucrDataFrameSelector.cboAvailableDataFrames.Text)))
                Else
                    SetName(frmMain.clsRLink.GetNextDefault(strDefaultPrefix, frmMain.clsRLink.GetGraphNames()))
                End If
            ElseIf strDefaultType = "Filter" Then
                If ucrDataFrameSelector IsNot Nothing AndAlso ucrDataFrameSelector.cboAvailableDataFrames.Text <> "" Then
                    SetName(frmMain.clsRLink.GetNextDefault(strDefaultPrefix, frmMain.clsRLink.GetFilterNames(ucrDataFrameSelector.cboAvailableDataFrames.Text)))
                Else
                    SetName("")
                End If
            End If
        End If
    End Sub

    Public Sub SetValidationTypeAsNumeric(Optional dcmMin As Decimal = Decimal.MinValue, Optional bIncludeMin As Boolean = True, Optional dcmMax As Decimal = Decimal.MaxValue, Optional bIncludeMax As Boolean = True)
        strValidationType = "Numeric"
        If dcmMin <> Decimal.MinValue Then
            dcmMinimum = dcmMin
            bMinimumIncluded = bIncludeMin
        End If
        If dcmMax <> Decimal.MaxValue Then
            dcmMaximum = dcmMax
            bMaximumIncluded = bIncludeMax
        End If
    End Sub

    Public Function GetNumericRange() As String
        Dim strRange As String = ""
        If strValidationType = "Numeric" Then
            If dcmMinimum <> Decimal.MinValue Then
                If bMinimumIncluded Then
                    strRange = ">= " & dcmMinimum.ToString()
                Else
                    strRange = "> " & dcmMinimum.ToString()
                End If
                If dcmMaximum <> Decimal.MaxValue Then
                    strRange = strRange & " and "
                End If
            End If
            If dcmMaximum <> Decimal.MaxValue Then
                If bMaximumIncluded Then
                    strRange = strRange & "<= " & dcmMaximum.ToString()
                Else
                    strRange = strRange & "< " & dcmMaximum.ToString()
                End If
            End If
        End If
        Return strRange
    End Function

    Public Sub SetValidationTypeAsList()
        strValidationType = "List"
    End Sub

    Public Sub SetValidationTypeAsNumericList()
        strValidationType = "NumericList"
    End Sub

    Public Function IsValid(strText As String) As Boolean
        Return (GetValidationCode(strText) = 0)
    End Function

    Public Function GetValidationCode(strText As String) As Integer
        Dim iType As Integer
        Select Case strValidationType
            Case "None"
                iType = 0
            Case "RVariable"
                iType = ValidateRVariable(strText)
            Case "Numeric"
                iType = ValidateNumeric(strText)
            Case "List"
                iType = ValidateList(strText, False)
            Case "NumericList"
                iType = ValidateList(strText, True)
        End Select
        Return iType
    End Function

    Public Function ValidateText(strText As String) As Boolean
        Dim iValidationCode As Integer

        iValidationCode = GetValidationCode(strText)

        Select Case iValidationCode
            Case 0

            Case 1
                Select Case strValidationType
                    Case "RVariable"
                        MsgBox(Chr(34) & strText & Chr(34) & " is a reserved word in R and cannot be used.", vbOKOnly)
                    Case "Numeric"
                        MsgBox("Entry must be numeric.", vbOKOnly)
                    Case "List"
                        MsgBox("Textbox requires a list separated by commas.", vbOKOnly, "Validation Error")
                    Case "NumericList"
                        MsgBox("Textbox requires a list of numbers separated by commas.", vbOKOnly, "Validation Error")
                End Select
            Case 2
                Select Case strValidationType
                    Case "RVariable"
                        MsgBox("This name cannot start with " & strText(0), vbOKOnly)
                    Case "Numeric"
                        MsgBox("This number must be: " & GetNumericRange(), vbOKOnly)
                    Case "NumericList"
                        MsgBox("Each item in the list must be numeric.", vbOKOnly, "Validation Error")
                End Select
            Case 3
                Select Case strValidationType
                    Case "RVariable"
                        MsgBox("This name cannot start with a dot followed by a number/nothing", vbOKOnly)
                End Select
            Case 4
                Select Case strValidationType
                    Case "RVariable"
                        MsgBox("This name cannot contain a space", vbOKOnly)
                End Select
            Case 5
                Select Case strValidationType
                    Case "RVariable"
                        MsgBox("This name contains an invalid character", vbOKOnly)
                End Select
        End Select
        Return (iValidationCode = 0)
    End Function

    'Returns integer as code for validation
    ' 0 : string is valid
    ' 1 : string is not numeric
    ' 2 : string is outside range
    Public Function ValidateNumeric(strText As String) As Integer
        Dim dcmText As Decimal
        Dim iType As Integer = 0

        If strText <> "" Then
            If Not IsNumeric(strText) Then
                iType = 1
            Else
                dcmText = Convert.ToDecimal(strText)
                If (dcmText < dcmMinimum) OrElse (dcmText > dcmMaximum) OrElse (Not bMinimumIncluded And dcmText <= dcmMinimum) OrElse (Not bMaximumIncluded And dcmText >= dcmMaximum) Then
                    iType = 2
                End If
            End If
        End If
        Return iType
    End Function

    'Returns integer as code for validation
    ' 0 : string is valid
    ' 1 : string is a reserved word
    ' 2 : string starts with invalid character
    ' 3 : string starts with "." followed by a number/nothing
    ' 4 : string contains a space
    ' 5 : string contains other invalid character
    Public Function ValidateRVariable(strText As String) As Integer
        Dim chrFirst As Char
        Dim chrCurr As Char
        Dim bAcceptableString As Boolean

        If strText = "" Then
            Return 0
        End If

        If strReservedWords.Contains(strText) Then
            Return 1
        End If
        chrFirst = strText(0)
        If Not Char.IsLetter(chrFirst) Then
            If chrFirst <> "." Then
                Return 2
            Else
                If strText.Length > 1 Then
                    If Char.IsNumber(strText(1)) Then
                        Return 3
                    End If
                Else
                    Return 3
                End If
            End If
        End If

        For Each chrCurr In strText
            bAcceptableString = Char.IsLetterOrDigit(chrCurr) Or chrCurr = "." Or chrCurr = "_"
            If Not bAcceptableString Then
                If chrCurr = " " Then
                    Return 4
                Else
                    Return 5
                End If
            End If
        Next
        Return 0
    End Function

    'Returns integer as code for validation
    ' 0 : string is valid
    ' 1 : an item is empty
    ' 2 : an item is not numeric
    Public Function ValidateList(strText As String, Optional bIsNumericInput As Boolean = False) As Integer
        Dim strItems As String()
        Dim strTemp As String

        If strText = "" Then Return 0
        clsRList.ClearParameters()
        clsRList.SetRCommand("c")
        'TODO deal with spaces differently e.g. "8 8" should give error/warning instead of "88"
        strTemp = strText.Replace(" ", "")
        If strTemp <> "" Then
            strItems = strTemp.Split(",")
            For Each strVal In strItems
                If strVal = "" Then Return 1
                Dim clsTempParam As New RParameter
                If bIsNumericInput Then
                    If Not IsNumeric(strVal) Then
                        Return 2
                        'MsgBox("Textbox requires a list of numbers separated by commas.", vbOKOnly, "Validation Error")
                        'txtNumericItems.Focus()
                    End If
                    clsTempParam.SetArgumentValue(strVal)
                Else
                    clsTempParam.SetArgumentValue(Chr(34) & strVal & Chr(34))
                End If
                clsRList.AddParameter(clsTempParam)
            Next
        End If
        Return 0
    End Function

    Private Sub ucrDataFrameSelector_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrDataFrameSelector.DataFrameChanged
        If Not bUserTyped Then
            SetDefaultName()
        End If
    End Sub

    Public Overridable Function IsEmpty() As Boolean
        Return True
    End Function

    Private Sub ucrInput_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not bUserTyped Then
            SetDefaultName()
        End If
        'RaiseEvent NameChanged()
    End Sub

    Private Sub ucrInput_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        SetName(Me.Text, bLastSilent)
    End Sub

    Public Overridable Property IsReadOnly() As Boolean
        Get
            Return bIsReadOnly
        End Get
        Set(bReadOnly As Boolean)
            bIsReadOnly = bReadOnly
        End Set
    End Property

    Protected Overrides Sub SetToValue(objTemp As Object)
        If objTemp IsNot Nothing Then
            SetName(objTemp.ToString())
        End If
    End Sub

    Public Overrides Function GetValueToSet() As Object
        If clsParameter IsNot Nothing Then
            If clsParameter.bIsString Then
                If dctDisplayParameterValues.ContainsKey(clsParameter.strArgumentValue) Then
                    Return clsParameter.strArgumentValue
                Else
                    If bAddQuotesIfUnrecognised Then
                        Return clsParameter.strArgumentValue.Trim(Chr(34))
                    Else
                        Return clsParameter.strArgumentValue
                    End If
                End If
            ElseIf clsParameter.bIsFunction OrElse clsParameter.bIsOperator Then
                Return clsParameter.clsArgumentCodeStructure
            Else
                Return ""
            End If
        Else
            Return ""
        End If
    End Function

    ' key = parameter value
    ' value = item text
    Public Sub SetParameterValueItemsPairs(dctNewDisplayParameterValues As Dictionary(Of String, String))
        dctDisplayParameterValues = dctNewDisplayParameterValues
    End Sub

    Public Sub AddToParameterValueItemsPairs(kvpNewPair As KeyValuePair(Of String, String))
        AddToParameterValueItemsPairs(kvpNewPair.Key, kvpNewPair.Value)
    End Sub

    Public Sub AddToParameterValueItemsPairs(strDisplayValue As String, strParameterValue As String)
        dctDisplayParameterValues.Add(strDisplayValue, strParameterValue)
    End Sub
End Class