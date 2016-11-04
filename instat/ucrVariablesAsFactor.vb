Public Class ucrVariablesAsFactor
    Public bSingleVariable As Boolean
    Public bFirstLoad As Boolean
    Public ucrFactorReceiver As ucrReceiverSingle
    'The ucrVariablesAsFactor has an associated ucrFactorReceiver, set on the dialog it is living in. In multiple mode, the ucrVariablesAsFactor can receive multiple variables that are then stacked in one and distinguished using a factor variable called "variable". The associated factor receiver will then be set in StackedFactorMode and fix it's content to this "variable" factor. 
    Public WithEvents ucrVariableSelector As ucrSelectorByDataFrame

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bFirstLoad = True
    End Sub

    Public Event SelectionChanged()

    Private Sub ucrVariablesAsFactor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        Else SetReceiverStatus()
        End If
    End Sub

    Public Sub SetDefaults()
        bSingleVariable = True
        SetReceiverStatus()
    End Sub

    'The following few subs serve to initialise the ucrVariablesAsFactor in the different dialogs where it is used. They also serve to update parameters such as the dataframe that can be changed on the dlg containing the ucrVariablesAsFactors.
    Public Sub SetFactorReceiver(ucrReceiverToSet As ucrReceiverSingle)
        ucrFactorReceiver = ucrReceiverToSet
    End Sub

    'Question to be discussed: what are the differences between the following three ?
    Public Sub SetDataType(strTemp As String)
        ucrSingleVariable.SetDataType(strTemp)
        ucrMultipleVariables.SetDataType(strTemp)
    End Sub
    Public Sub SetIncludedDataType(strInclude As String())
        ucrSingleVariable.SetIncludedDataTypes(strInclude)
        ucrMultipleVariables.SetIncludedDataTypes(strInclude)
    End Sub

    Public Sub SetExcludedDataTypes(strExclude As String())
        ucrMultipleVariables.SetExcludedDataTypes(strExclude)
        ucrSingleVariable.SetExcludedDataTypes(strExclude)
    End Sub

    Public Sub SetSelector(ucrSelectorToSet As ucrSelectorByDataFrame)
        ucrVariableSelector = ucrSelectorToSet
        ucrSingleVariable.Selector = ucrSelectorToSet
        ucrMultipleVariables.Selector = ucrSelectorToSet
    End Sub


    Private Sub cmdVariables_Click(sender As Object, e As EventArgs) Handles cmdVariables.Click
        'Switching from single to multiple receiver.
        bSingleVariable = Not bSingleVariable
        SetReceiverStatus()
        'After setting the receiver status, the SelectionChanged event is raised for the dlg's that contain the ucrVariablesAsFactors to adapt to the changes operated locally. For instance in the dlgBoxPlot, the sub UcrVariablesAsFactor1_SelectionChanged() is then called and updates it's aesthetics receivers. 
        RaiseEvent SelectionChanged()
    End Sub

    Public Function GetVariableNames(Optional bWithQuotes As Boolean = True) As String
        'This sub provides the name of the variable that should be used by external components that want to access the "content" of this receiver. If it is in single mode, this is simply providing the name of the variable in use. 
        'However in multiple mode, a New variable will be created using the "stack" And "measure.vars" explained in SetReceiverStatus.
        Dim strVariablesToStack As String = ""
        If bSingleVariable Then
            strVariablesToStack = ucrSingleVariable.GetVariableNames(bWithQuotes)
        Else
            If Not bWithQuotes Then
                strVariablesToStack = "value"
            Else strVariablesToStack = Chr(34) & "value" & Chr(34)
            End If
        End If
            Return strVariablesToStack
    End Function

    'Warning: The two following subs seem obsolete.
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
        If Not bSingleVariable Then
            SetMeasureVars()
        End If

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

    Public Sub SetReceiverStatus()
        'This sub sets up the receiver for it to operate as desired depending on the status it is in: multiple or single.
        'In the multiple case, stack_data, measure.vars and id.vars are added to the parameters of the current dataframe RFunction. In the single case, these are removed.
        'In practice, the variables in the multiple receiver will be stacked into one variable called "value" in a temporary dataframe, and a factor variable called "variable" will enable to distinguish the different variables stacked in "value".
        'The associated factor receiver will then be set to StackedFactorMode, which makes it disabled with fixed content "variables". This is done in SetMeasureVars() below.
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
        'This sub sets the ucrFactorReceiver associated to this ucrVariablesAsFactors to the StackedFactorMode. The factor that is then given through is the factor "variables" that distinguishes the different variables that have been stacked into one "value".
        If ucrFactorReceiver IsNot Nothing Then
            ucrFactorReceiver.SetStackedFactorMode(True)
        End If
        If Not ucrMultipleVariables.IsEmpty Then
            ucrVariableSelector.ucrAvailableDataFrames.clsCurrDataFrame.AddParameter("measure.vars", ucrMultipleVariables.GetVariableNames())
        Else
            ucrVariableSelector.ucrAvailableDataFrames.clsCurrDataFrame.RemoveParameterByName("measure.vars")
        End If
    End Sub

    Public Sub ResetControl()
        'this resets the ucrReceiverFactor
        SetDefaults()
    End Sub

    Public Sub Add(strVar As String)
        If bSingleVariable Then
            ucrSingleVariable.Add(strVar)
        Else
            ucrMultipleVariables.Add(strVar)
        End If
    End Sub

    Public Sub Clear()
        If bSingleVariable Then
            ucrSingleVariable.Clear()
        Else
            ucrMultipleVariables.Clear()
        End If
    End Sub

    Public Sub SetSingleReceiverStatus(bSingle As Boolean)
        bSingleVariable = bSingle
        SetReceiverStatus()
    End Sub

    Public Sub SetSingleTypeStatus(bIsSingleType As Boolean)
        ucrMultipleVariables.SetSingleTypeStatus(bIsSingleType)
    End Sub

    Public Sub SetMultipleOnlyStatus(bMultipleOnly As Boolean)
        'TODO Replace this by making stacking a property of 
        'multiple receiver so it can be used instead
        If bMultipleOnly Then
            bSingleVariable = False
            SetReceiverStatus()
            cmdVariables.Hide()
            SetSingleTypeStatus(True)
        Else
            SetReceiverStatus()
            cmdVariables.show()
            setsingletypestatus(False)
        End If
    End Sub
End Class