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
Imports RDotNet

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
    Protected bAllowInf As Boolean = False
    Private bLastSilent As Boolean = False
    Private bPrivateAddQuotesIfUnrecognised As Boolean = True
    Protected dctDisplayParameterValues As New Dictionary(Of String, String)
    Protected bFirstLoad As Boolean = True

    'used to determine if valid expressions are allowed for numeric validations e.g 20/2, 30-1
    Protected bNumericExpressionAllowed As Boolean = True

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bUpdateRCodeFromControl = False
    End Sub

    Public Overridable Sub SetName(strName As String, Optional bSilent As Boolean = False)
        bLastSilent = bSilent
    End Sub

    Public Overridable Function GetText() As String
        Return ""
    End Function

    Public Overridable Function GetValue() As Object
        Return Nothing
    End Function

    Public Overridable Sub Reset()
        bUserTyped = False
    End Sub

    Public Sub OnNameChanged()
        Me.Text = Me.GetText()
        RaiseEvent NameChanged()
        OnControlValueChanged()
    End Sub

    Public Overrides Sub UpdateParameter(clsTempParam As RParameter)
        If bChangeParameterValue AndAlso clsTempParam IsNot Nothing Then
            If dctDisplayParameterValues.ContainsKey(GetText()) Then
                clsTempParam.SetArgumentValue(dctDisplayParameterValues(GetText()))
            Else
                If AddQuotesIfUnrecognised Then
                    clsTempParam.SetArgumentValue(Chr(34) & GetText() & Chr(34))
                Else
                    clsTempParam.SetArgumentValue(GetText())
                End If
            End If
        End If
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

    Public Sub SetDefaultTypeAsSurv()
        strDefaultType = "Surv"
        SetDefaultName()
    End Sub

    Public Sub SetDefaultTypeAsTable()
        strDefaultType = "Table"
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

    Public Sub SetDefaultTypeAsKey()
        strDefaultType = "Key"
        SetDefaultName()
    End Sub

    Public Sub SetDefaultTypeAsLink()
        strDefaultType = "Link"
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

    Public Sub SetDefaultTypeAsColumnSelection()
        strDefaultType = "Column Selection"

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
                    'temp disabled as causing bug and not currently needed
                    'SetName(frmMain.clsRLink.GetNextDefault(strDefaultPrefix, frmMain.clsRLink.GetModelNames()))
                End If
            ElseIf strDefaultType = "Table" Then
                If ucrDataFrameSelector IsNot Nothing AndAlso ucrDataFrameSelector.cboAvailableDataFrames.Text <> "" Then
                    SetName(frmMain.clsRLink.GetNextDefault(strDefaultPrefix, frmMain.clsRLink.GetTableNames(ucrDataFrameSelector.cboAvailableDataFrames.Text)))
                Else
                    'temp disabled as causing bug and not currently needed
                    'SetName(frmMain.clsRLink.GetNextDefault(strDefaultPrefix, frmMain.clsRLink.GetTableNames()))
                End If
            ElseIf strDefaultType = "Data Frame" Then
                SetName(frmMain.clsRLink.GetNextDefault(strDefaultPrefix, frmMain.clsRLink.GetDataFrameNames()))
            ElseIf strDefaultType = "Graph" Then
                If ucrDataFrameSelector IsNot Nothing AndAlso ucrDataFrameSelector.cboAvailableDataFrames.Text <> "" Then
                    SetName(frmMain.clsRLink.GetNextDefault(strDefaultPrefix, frmMain.clsRLink.GetGraphNames(ucrDataFrameSelector.cboAvailableDataFrames.Text)))
                Else
                    'temp disabled as causing bug and not currently needed
                    'SetName(frmMain.clsRLink.GetNextDefault(strDefaultPrefix, frmMain.clsRLink.GetGraphNames()))
                End If
            ElseIf strDefaultType = "Filter" Then
                If ucrDataFrameSelector IsNot Nothing AndAlso ucrDataFrameSelector.cboAvailableDataFrames.Text <> "" Then
                    SetName(frmMain.clsRLink.GetNextDefault(strDefaultPrefix, frmMain.clsRLink.GetFilterNames(ucrDataFrameSelector.cboAvailableDataFrames.Text)))
                Else
                    SetName("")
                End If
            ElseIf strDefaultType = "Column Selection" Then

                If ucrDataFrameSelector IsNot Nothing AndAlso ucrDataFrameSelector.cboAvailableDataFrames.Text <> "" Then
                    SetName(frmMain.clsRLink.GetNextDefault(strDefaultPrefix, frmMain.clsRLink.GetColumnSelectionNames(ucrDataFrameSelector.cboAvailableDataFrames.Text)))
                Else
                    SetName("")
                End If
            ElseIf strDefaultType = "Surv" Then
                If ucrDataFrameSelector IsNot Nothing AndAlso ucrDataFrameSelector.cboAvailableDataFrames.Text <> "" Then
                    SetName(frmMain.clsRLink.GetNextDefault(strDefaultPrefix, frmMain.clsRLink.GetSurvNames(ucrDataFrameSelector.cboAvailableDataFrames.Text)))
                Else
                    SetName("")
                End If
            ElseIf strDefaultType = "Key" Then
                If ucrDataFrameSelector IsNot Nothing AndAlso ucrDataFrameSelector.cboAvailableDataFrames.Text <> "" Then
                    SetName(frmMain.clsRLink.GetNextDefault(strDefaultPrefix, frmMain.clsRLink.GetKeyNames(ucrDataFrameSelector.cboAvailableDataFrames.Text)))
                Else
                    SetName("")
                End If
            ElseIf strDefaultType = "Link" Then
                If ucrDataFrameSelector IsNot Nothing AndAlso ucrDataFrameSelector.cboAvailableDataFrames.Text <> "" Then
                    SetName(frmMain.clsRLink.GetNextDefault(strDefaultPrefix, frmMain.clsRLink.GetLinkNames(ucrDataFrameSelector.cboAvailableDataFrames.Text)))
                Else
                    SetName("")
                End If
            End If
        End If
    End Sub

    Public Sub SetValidationTypeAsNumeric(Optional dcmMin As Decimal = Decimal.MinValue, Optional bIncludeMin As Boolean = True, Optional dcmMax As Decimal = Decimal.MaxValue, Optional bIncludeMax As Boolean = True, Optional bNumericExpressionAllowed As Boolean = True)
        strValidationType = "Numeric"
        Me.bNumericExpressionAllowed = bNumericExpressionAllowed
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
        ElseIf strValidationType = "NumericList" Then
            If dcmMinimum <> Double.MinValue Then
                If bMinimumIncluded Then
                    strRange = ">= " & dcmMinimum.ToString()
                Else
                    strRange = "> " & dcmMinimum.ToString()
                End If
                If dcmMaximum <> Double.MaxValue Then
                    strRange = strRange & " and "
                End If
            End If
            If dcmMaximum <> Double.MaxValue Then
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

    Public Sub SetValidationTypeAsNumericList(Optional bNewAllowInf As Boolean = False, Optional bIncludeMin As Boolean = True, Optional dcmMin As Double = Double.MinValue, Optional dcmMax As Double = Double.MaxValue, Optional bIncludeMax As Boolean = True)
        ' Dim Dmax As Double = Maximum
        ' Dim Dmin As Double = Minimum
        strValidationType = "NumericList"
        If dcmMin <> Double.MinValue Then
            dcmMinimum = dcmMin
        End If
        If dcmMax <> Double.MaxValue Then
            dcmMaximum = dcmMax
        End If
        bAllowInf = bNewAllowInf
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
                iType = ValidateList(strText, True, bAllowInf)
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
                    Case "NumericList"
                        MsgBox("Each item in the list must be " & GetNumericRange(), vbOKOnly, "Validation Error")
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

        If strText <> "" AndAlso (strValuesToIgnore Is Nothing OrElse (strValuesToIgnore IsNot Nothing AndAlso Not strValuesToIgnore.Contains(strText))) Then
            If Not IsNumeric(strText) Then
                iType = 1 'reset as invalid entry 
                'if numeric expressions are allowed check the expression results to a valid numeric
                If bNumericExpressionAllowed Then
                    Dim vecOutput As CharacterVector
                    'is.numeric(x) returns true if the x expression is a valid one. 
                    'So we use it here to check validity of the entry
                    vecOutput = frmMain.clsRLink.RunInternalScriptGetOutput("is.numeric(" & strText & ")", bSilent:=True)
                    If vecOutput IsNot Nothing AndAlso vecOutput.Length > 0 AndAlso Mid(vecOutput(0), 5).ToUpper = "TRUE" Then
                        iType = 0 'set as valid entry
                    End If
                End If
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
    ' 3 : an item is between max and min values
    Public Function ValidateList(strText As String, Optional bIsNumericInput As Boolean = False, Optional bAllowInf As Boolean = False) As Integer
        Dim strItems As String()
        Dim strTemp As String
        Dim i As Integer = 0
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
                    If Not IsNumeric(strVal) AndAlso (Not (bAllowInf AndAlso ({"Inf", "-Inf"}.Contains(strVal)))) Then
                        Return 2
                    ElseIf IsNumeric(strVal) AndAlso (strVal > dcmMaximum OrElse strVal < dcmMinimum) Then
                        Return 3
                    End If
                    clsTempParam.SetArgumentValue(strVal)
                Else
                    clsTempParam.SetArgumentValue(Chr(34) & strVal & Chr(34))
                End If
                clsTempParam.Position = i
                clsRList.AddParameter(clsTempParam)
                i = i + 1
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

    Public Overrides Sub SetToValue(objTemp As Object)
        If objTemp IsNot Nothing Then
            SetName(objTemp.ToString())
        Else
            'If no value reset to a default value
            SetName("")
        End If
    End Sub

    Public Overrides Function GetValueToSet() As Object
        Dim clsMainParameter As RParameter

        clsMainParameter = GetParameter()
        If clsMainParameter IsNot Nothing Then
            If clsMainParameter.bIsString Then
                If dctDisplayParameterValues.ContainsKey(clsMainParameter.strArgumentValue) Then
                    Return clsMainParameter.strArgumentValue
                Else
                    If AddQuotesIfUnrecognised Then
                        Return clsMainParameter.strArgumentValue.Trim(Chr(34))
                    Else
                        Return clsMainParameter.strArgumentValue
                    End If
                End If
            ElseIf clsMainParameter.bIsFunction OrElse clsMainParameter.bIsOperator Then
                Return clsMainParameter.clsArgumentCodeStructure
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

    Public Property AddQuotesIfUnrecognised As Boolean
        Get
            Return bPrivateAddQuotesIfUnrecognised
        End Get
        Set(bValue As Boolean)
            bPrivateAddQuotesIfUnrecognised = bValue
            If GetText() IsNot Nothing Then
                SetName(GetText().Trim(Chr(34)))
            End If
        End Set
    End Property

    Public Overrides Function ControlValueContainedIn(lstTemp() As Object) As Boolean
        For Each objTemp As Object In lstTemp
            If objTemp.ToString() = GetText() Then
                Return True
            End If
        Next
        Return False
    End Function

    Protected Overrides Sub ResetControlValue()
        SetName("")
    End Sub
End Class