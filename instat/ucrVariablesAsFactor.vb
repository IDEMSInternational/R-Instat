﻿Public Class ucrVariablesAsFactor
    Public bSingleVariable As Boolean = True
    Public bFirstLoad As Boolean = True
    Public ucrFactorReceiver As ucrReceiverSingle
    Public WithEvents ucrVariableSelector As ucrSelectorByDataFrame
    Public Event SelectionChanged()

    Private Sub ucrVariablesAsFactor_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            SetDefaults()
        End If
    End Sub

    Public Sub SetDefaults()
        SetReceiverStatus()
    End Sub

    Public Sub SetFactorReceiver(ucrReceiverToSet As ucrReceiverSingle)
        ucrFactorReceiver = ucrReceiverToSet
    End Sub
    Public Sub SetDataType(strTemp As String)
        ucrSingleVariable.SetDataType(strTemp)
        ucrMultipleVariables.SetDataType(strTemp)
    End Sub

    Public Sub SetSelector(ucrSelectorToSet As ucrSelectorByDataFrame)
        ucrVariableSelector = ucrSelectorToSet
        ucrSingleVariable.Selector = ucrSelectorToSet
        ucrMultipleVariables.Selector = ucrSelectorToSet
    End Sub

    Private Sub cmdVariables_Click(sender As Object, e As EventArgs) Handles cmdVariables.Click
        bSingleVariable = Not bSingleVariable
        SetReceiverStatus()
        RaiseEvent SelectionChanged()
    End Sub

    Public Function GetVariableNames(Optional bWithQuotes As Boolean = True) As String
        Dim strVariablesToStack As String = ""
        If bSingleVariable Then
            strVariablesToStack = ucrSingleVariable.GetVariableNames(bWithQuotes)
        Else
            strVariablesToStack = "value"
        End If
        Return strVariablesToStack
    End Function

    Public Function GetStackedVariableNames(Optional bWithQuotes As Boolean = True) As String
        Dim strVariablesToStack As String = ""
        If Not bSingleVariable Then
            strVariablesToStack = ucrMultipleVariables.GetVariableNames(bWithQuotes)
        End If
        Return strVariablesToStack
    End Function

    Public Function GetVariables(Optional bForceAsDataFrame As Boolean = False) As RFunction
        Dim clsVariables As New RFunction
        If bSingleVariable Then
            clsVariables = ucrSingleVariable.GetVariables(bForceAsDataFrame)
        Else
            'TODO fix this case if needed
            'clsVariables = ucrMultipleVariables.GetVariables(bForceAsDataFrame)
        End If
        Return clsVariables
    End Function

    Public Function GetIDVarNamesFromSelector(Optional bWithQuotes As Boolean = True) As String
        Dim strIDVars As String
        Dim lstVariablesFromSelector As List(Of String) = ucrVariableSelector.lstVariablesInReceivers

        For i = 0 To ucrMultipleVariables.lstSelectedVariables.Items.Count - 1
            lstVariablesFromSelector.Remove(ucrMultipleVariables.lstSelectedVariables.Items(i).Text)
        Next

        If lstVariablesFromSelector.Count = 1 Then
            If bWithQuotes Then
                strIDVars = Chr(34) & lstVariablesFromSelector(0) & Chr(34)
            Else
                strIDVars = lstVariablesFromSelector(0)
            End If
        ElseIf lstVariablesFromSelector.Count > 1 Then
            strIDVars = "c("
            For i = 0 To lstVariablesFromSelector.Count - 1
                If i > 0 Then
                    strIDVars = strIDVars & ","
                End If
                If lstVariablesFromSelector(i) <> "" Then
                    If bWithQuotes Then
                        strIDVars = strIDVars & Chr(34) & lstVariablesFromSelector(i) & Chr(34)
                    Else
                        strIDVars = strIDVars & lstVariablesFromSelector(i)
                    End If
                End If
            Next
            strIDVars = strIDVars & ")"
        Else
            strIDVars = "NULL"
        End If
        Return strIDVars
    End Function

    Private Sub ucrMultipleVariables_SelectionChanged() Handles ucrMultipleVariables.SelectionChanged
        SetMeasureVars()
        RaiseEvent SelectionChanged()
    End Sub

    Private Sub ucrSingleVariable_SelectionChanged(sender As Object, e As EventArgs) Handles ucrSingleVariable.SelectionChanged
        RaiseEvent SelectionChanged()
    End Sub

    Public Function IsEmpty() As Boolean
        If bSingleVariable Then
            Return ucrSingleVariable.IsEmpty()
        Else
            Return ucrMultipleVariables.IsEmpty()
        End If
    End Function

    Private Sub SetReceiverStatus()
        If bSingleVariable Then
            'need to translate correctly
            cmdVariables.Text = "Single Variable"
            cmdVariables.FlatStyle = FlatStyle.Popup
            ucrSingleVariable.Visible = True
            ucrMultipleVariables.Visible = False
            If ucrVariableSelector IsNot Nothing Then
                ucrSingleVariable.SetMeAsReceiver()
                ucrVariableSelector.ucrAvailableDataFrames.clsCurrDataFrame.RemoveParameterByName("stack_data")
                ucrVariableSelector.ucrAvailableDataFrames.clsCurrDataFrame.RemoveParameterByName("measure.vars")
                ucrVariableSelector.ucrAvailableDataFrames.clsCurrDataFrame.RemoveParameterByName("id.vars")
            End If
            If ucrFactorReceiver IsNot Nothing Then
                ucrFactorReceiver.SetStackedFactorMode(False)
            End If

        Else
            ucrSingleVariable.Visible = False
            ucrMultipleVariables.Visible = True
            'TODO need to translate correctly
            cmdVariables.Text = "Multiple Variables"
            cmdVariables.FlatStyle = FlatStyle.Flat
            If ucrVariableSelector IsNot Nothing Then
                ucrMultipleVariables.SetMeAsReceiver()
                ucrVariableSelector.ucrAvailableDataFrames.clsCurrDataFrame.AddParameter("stack_data", "TRUE")
                SetMeasureVars()
                ucrVariableSelector.ucrAvailableDataFrames.clsCurrDataFrame.AddParameter("id.vars", GetIDVarNamesFromSelector())
            End If
        End If
    End Sub

    Private Sub ucrVariableSelector_VariablesInReceiversChanged() Handles ucrVariableSelector.VariablesInReceiversChanged
        If Not bSingleVariable AndAlso ucrVariableSelector IsNot Nothing Then
            ucrVariableSelector.ucrAvailableDataFrames.clsCurrDataFrame.AddParameter("id.vars", GetIDVarNamesFromSelector())
        End If
    End Sub

    Private Sub SetMeasureVars()
        If ucrFactorReceiver IsNot Nothing Then
            ucrFactorReceiver.SetStackedFactorMode(True)
        End If
        If Not ucrMultipleVariables.IsEmpty Then
            ucrVariableSelector.ucrAvailableDataFrames.clsCurrDataFrame.AddParameter("measure.vars", ucrMultipleVariables.GetVariableNames())
        Else
            ucrVariableSelector.ucrAvailableDataFrames.clsCurrDataFrame.RemoveParameterByName("measure.vars")
        End If
    End Sub
End Class