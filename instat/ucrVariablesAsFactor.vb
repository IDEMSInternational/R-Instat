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
Imports instat.Translations

Public Class ucrVariablesAsFactor
    Public bSingleVariable As Boolean
    Public ucrFactorReceiver As ucrReceiverSingle
    Public WithEvents ucrVariableSelector As ucrSelectorByDataFrame

    'The ucrVariablesAsFactor has an associated ucrFactorReceiver, set on the dialog it is living in. In multiple mode, the ucrVariablesAsFactor can receive multiple variables that are then stacked in one and distinguished using a factor variable called "variable". The associated factor receiver will then be set in StackedFactorMode and fix it's content to this "variable" factor. 

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bFirstLoad = True
    End Sub

    Private Sub ucrVariablesAsFactor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
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

    Private Sub cmdVariables_Click(sender As Object, e As EventArgs) Handles cmdVariables.Click
        'Switching from single to multiple receiver.
        bSingleVariable = Not bSingleVariable
        SetReceiverStatus()
        If bSingleVariable Then
            ucrSingleVariable.SetMeAsReceiver()
        Else
            ucrMultipleVariables.SetMeAsReceiver()
        End If
        'After setting the receiver status, the SelectionChanged event is raised for the dlg's that contain the ucrVariablesAsFactors to adapt to the changes operated locally. For instance in the dlgBoxPlot, the sub UcrVariablesAsFactor1_SelectionChanged() is then called and updates it's aesthetics receivers. 
        OnSelectionChanged()
    End Sub

    Public Overrides Function GetVariableNames(Optional bWithQuotes As Boolean = True) As String
        'This sub provides the name of the variable that should be used by external components that want to access the "content" of this receiver. If it is in single mode, this is simply providing the name of the variable in use. 
        'However in multiple mode, a New variable will be created using the "stack" And "measure.vars" explained in SetReceiverStatus.
        Dim strVariables As String = ""

        If bSingleVariable Then
            strVariables = ucrSingleVariable.GetVariableNames(bWithQuotes)
        Else
            If ucrMultipleVariables.IsEmpty Then
                strVariables = ""
            Else
                strVariables = "value"
                If bWithQuotes Then
                    strVariables = Chr(34) & strVariables & Chr(34)
                End If
            End If
        End If
        Return strVariables
    End Function

    'Warning: The two following subs seem obsolete.
    Public Function GetStackedVariableNames(Optional bWithQuotes As Boolean = True) As String
        Dim strVariablesToStack As String = ""

        If Not bSingleVariable Then
            strVariablesToStack = ucrMultipleVariables.GetVariableNames(bWithQuotes)
        End If
        Return strVariablesToStack
    End Function

    Public Overrides Function GetVariables(Optional bForceAsDataFrame As Boolean = False) As RFunction
        Dim clsVariables As New RFunction

        If bSingleVariable Then
            clsVariables = ucrSingleVariable.GetVariables(bForceAsDataFrame)
        Else
            clsVariables = ucrMultipleVariables.GetVariables(bForceAsDataFrame)
        End If
        Return clsVariables
    End Function

    Private Sub ucrMultipleVariables_SelectionChanged() Handles ucrMultipleVariables.SelectionChanged
        If Not bSingleVariable Then
            SetMeasureVars()
        End If
        OnSelectionChanged()
    End Sub

    Private Sub ucrSingleVariable_SelectionChanged(sender As Object, e As EventArgs) Handles ucrSingleVariable.SelectionChanged
        OnSelectionChanged()
    End Sub

    Public Overrides Function IsEmpty() As Boolean
        If bSingleVariable Then
            Return ucrSingleVariable.IsEmpty()
        Else
            Return ucrMultipleVariables.IsEmpty()
        End If
    End Function

    'This is called the first time this control is loaded, cmdVariables is clicked on
    'And everytime  SetControlValue() is executed (Note.  SetControlValue() is called by setRCode() of ucrCore )
    Public Sub SetReceiverStatus()
        'This sub sets up the receiver for it to operate as desired depending on the status it is in: multiple or single.
        'In the multiple case, stack_data, measure.vars and id.vars are added to the parameters of the current dataframe RFunction. In the single case, these are removed.
        'In practice, the variables in the multiple receiver will be stacked into one variable called "value" in a temporary dataframe, and a factor variable called "variable" will enable to distinguish the different variables stacked in "value".
        'The associated factor receiver will then be set to StackedFactorMode, which makes it disabled with fixed content "variables". This is done in SetMeasureVars() below.
        If bSingleVariable Then
            'need to translate correctly
            cmdVariables.Text = GetTranslation("Single Variable")
            cmdVariables.FlatStyle = FlatStyle.Popup
            ucrSingleVariable.Visible = True
            ucrMultipleVariables.Visible = False
            If ucrVariableSelector IsNot Nothing Then
                ucrVariableSelector.ucrAvailableDataFrames.clsCurrDataFrame.RemoveParameterByName("stack_data")
                ucrVariableSelector.ucrAvailableDataFrames.clsCurrDataFrame.RemoveParameterByName("measure.vars")
                ucrVariableSelector.ucrAvailableDataFrames.clsCurrDataFrame.RemoveParameterByName("id.vars")
            End If
            If ucrFactorReceiver IsNot Nothing Then
                ucrFactorReceiver.SetStackedFactorMode(False)
            End If
            If Selector IsNot Nothing Then
                Selector.bIsStacked = False
            End If
        Else
            ucrSingleVariable.Visible = False
            ucrMultipleVariables.Visible = True
            'TODO need to translate correctly
            cmdVariables.Text = GetTranslation("Multiple Variables")
            cmdVariables.FlatStyle = FlatStyle.Flat
            If ucrVariableSelector IsNot Nothing Then
                ucrVariableSelector.ucrAvailableDataFrames.clsCurrDataFrame.AddParameter("stack_data", "TRUE")
                SetMeasureVars()
            End If
            If Selector IsNot Nothing Then
                Selector.bIsStacked = True
            End If
        End If
        OnControlValueChanged()
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

    Public Overrides Sub Add(strVar As String, Optional strDataFrame As String = "", Optional bFixReceiver As Boolean = False)
        If bSingleVariable Then
            ucrSingleVariable.Add(strVar, strDataFrame, bFixReceiver)
        Else
            ucrMultipleVariables.Add(strVar, strDataFrame, bFixReceiver)
        End If
    End Sub

    Public Overrides Sub Clear()
        If bSingleVariable Then
            ucrSingleVariable.Clear()
        Else
            ucrMultipleVariables.Clear()
        End If
    End Sub

    Protected Overrides Sub Selector_ResetAll()
        ucrSingleVariable.Clear()
        ucrMultipleVariables.Clear()
        'SetDefaults()
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
            cmdVariables.Show()
            SetSingleTypeStatus(False)
        End If
    End Sub

    Public Overrides Sub SetMeAsReceiver()
        If Selector IsNot Nothing Then
            If bSingleVariable Then
                ucrSingleVariable.SetMeAsReceiver()
            Else
                ucrMultipleVariables.SetMeAsReceiver()
            End If
        End If
    End Sub

    Protected Overrides Sub SetControlValue()
        Dim clsTempDataParameter As RParameter
        Dim lstCurrentVariables As String() = Nothing
        Dim lstMeasureVars As String() = Nothing
        Dim clsTempParameter As RParameter
        Dim clsTempRCode As RCodeStructure
        Dim clsMeasureVarsParam As RParameter = Nothing

        clsTempParameter = GetParameter()
        clsTempRCode = GetRCode()

        If clsTempParameter IsNot Nothing Then
            If bChangeParameterValue Then
                If bParameterIsString AndAlso clsTempParameter.bIsString Then
                    If strValuesToIgnore Is Nothing OrElse (Not strValuesToIgnore.Contains(clsTempParameter.strArgumentValue)) Then
                        lstCurrentVariables = ExtractItemsFromRList(clsTempParameter.strArgumentValue)
                    End If
                ElseIf bParameterIsRFunction AndAlso clsTempParameter.bIsFunction Then
                    clsTempDataParameter = clsTempParameter.clsArgumentCodeStructure.GetParameter(strItemsParameterNameInRFunction)
                    If clsTempDataParameter IsNot Nothing Then
                        lstCurrentVariables = ExtractItemsFromRList(clsTempParameter.clsArgumentCodeStructure.GetParameter(strItemsParameterNameInRFunction).strArgumentValue)
                    End If
                End If
                If clsTempRCode.ContainsParameter("data") Then
                    clsMeasureVarsParam = clsTempRCode.GetParameter("data").clsArgumentCodeStructure.GetParameter("measure.vars")
                ElseIf ucrVariableSelector IsNot Nothing AndAlso ucrVariableSelector.ucrAvailableDataFrames.clsCurrDataFrame IsNot Nothing AndAlso ucrVariableSelector.ucrAvailableDataFrames.clsCurrDataFrame.ContainsParameter("measure.vars") Then
                    clsMeasureVarsParam = ucrVariableSelector.ucrAvailableDataFrames.clsCurrDataFrame.GetParameter("measure.vars")
                End If
                Clear()
                If lstCurrentVariables IsNot Nothing Then
                    If lstCurrentVariables.Count = 1 Then
                        If lstCurrentVariables(0) = "value" Then
                            bSingleVariable = False
                            If clsMeasureVarsParam IsNot Nothing Then
                                lstMeasureVars = ExtractItemsFromRList(clsMeasureVarsParam.strArgumentValue)
                            End If
                            If lstMeasureVars IsNot Nothing Then
                                For Each strTemp As String In lstMeasureVars
                                    'TODO This only works if the selector is updated before receivers!
                                    '     Needs to change eventually.
                                    If Selector IsNot Nothing AndAlso strTemp <> "" Then
                                        ucrMultipleVariables.Add(strTemp, Selector.strCurrentDataFrame)
                                    End If
                                Next
                            End If
                        Else
                            bSingleVariable = True
                            If Selector IsNot Nothing AndAlso lstCurrentVariables(0) <> "" Then
                                ucrSingleVariable.Add(lstCurrentVariables(0), Selector.strCurrentDataFrame)
                            End If
                        End If
                    Else
                        MsgBox("Developer error: Only expected one item for ucrVariablesAsFactor parameter. It must be either a single column or 'value' when multiple columns.")
                    End If
                End If
            End If
        End If
        SetReceiverStatus()
    End Sub

    Public Overrides Property Selector As ucrSelector
        Get
            Return MyBase.Selector
        End Get
        Set(ucrNewSelector As ucrSelector)
            'This line automatically adds ucrVariablesAsFactor (Me) as the receiver of ucrNewSelector. 
            'This is undesirable because ucrVariablesAsFactor is a receiver that has two receivers 
            '(its child controls) which it uses to manipulate data. 
            MyBase.Selector = ucrNewSelector
            'Therefore remove ucrVariablesAsFactor (Me) and leave only it's child controls in the 
            'list of receivers used for autoswitching.
            ' 
            'TODO Currently the selector only uses the list of receivers to manipulate the focus 
            'switching. In future the usage of the receivers could change which may require this 
            'implementation to be changed 
            If MyBase.Selector IsNot Nothing Then
                MyBase.Selector.RemoveReceiver(Me)
            End If

            'set the selector to the children receivers. This by default adds the receivers to the selector
            ucrSingleVariable.Selector = ucrNewSelector
            ucrMultipleVariables.Selector = ucrNewSelector

            If ucrNewSelector IsNot Nothing Then
                ucrVariableSelector = TryCast(ucrNewSelector, ucrSelectorByDataFrame)
                If ucrVariableSelector Is Nothing Then
                    MsgBox("Developer error: ucrVariablesAsFactor must be associated with a ucrSelectorByDataFrame not a base ucrSelector.")
                End If
            End If

        End Set
    End Property

    Public Overrides Sub SetIncludedDataTypes(strInclude As String(), Optional bStrict As Boolean = False)
        ucrSingleVariable.SetIncludedDataTypes(strInclude, bStrict)
        ucrMultipleVariables.SetIncludedDataTypes(strInclude, bStrict)
    End Sub

    Public Overrides Sub SetExcludedDataTypes(strExclude As String())
        ucrSingleVariable.SetExcludedDataTypes(strExclude)
        ucrMultipleVariables.SetExcludedDataTypes(strExclude)
    End Sub

    Public Overrides Sub SetSelectorHeading(strNewHeading As String)
        MyBase.SetSelectorHeading(strNewHeading)
        ucrSingleVariable.SetSelectorHeading(strNewHeading)
        ucrMultipleVariables.SetSelectorHeading(strNewHeading)
    End Sub
End Class
