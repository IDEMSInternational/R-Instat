
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

Imports instat.Translations
'for the CharacteVector & SymbolicExpression classes
Imports RDotNet

Public Class dlgVariableSets
    Private bFirstLoad As Boolean = True
    'Rfunctions to hold RCommands for 3 operations(Make,Edit,Delete)
    Private clsRMakeFunction As New RFunction
    Private clsREditFunction As New RFunction
    Private clsRDeleteFunction As New RFunction

    Private Sub dlgVariableSets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            initialiseDialog()
            setDefaults()
            setRCodeForControls(True)
            bFirstLoad = False
        End If
        autoTranslate(Me)
    End Sub

    'block to be called once when the form loads for the first time
    Private Sub initialiseDialog()
        'Set Radio Button Properties to rdo's
        ucrPnlOptions.AddRadioButton(rdoMake)
        ucrPnlOptions.AddRadioButton(rdoEdit)
        ucrPnlOptions.AddRadioButton(rdoDelete)

        'Set the default parameters for the controls
        ucrSelectorVariableSets.SetParameter(New RParameter("data_name", 0))
        ucrSelectorVariableSets.SetParameterIsString()

        ucrReceiverMultipleVariables.SetParameter(New RParameter("columns", 2))
        ucrReceiverMultipleVariables.SetParameterIsString()

        'defaults to param set_name but changes to new_set_name on update operation
        ucrInputSetNewName.SetParameter(New RParameter("set_name", 1))

        ucrReceiverSelectedSet.SetParameter(New RParameter("set_name", 1))
        ucrReceiverSelectedSet.SetParameterIsString()

        'Set the default rdo to be checked. This is based on the set base function 
        'to help the ucrPnlOptions identify which rdo to be checked
        'i.e the set base function name determines the rdo to be checked  
        ucrPnlOptions.AddFunctionNamesCondition(rdoMake, frmMain.clsRLink.strInstatDataObject & "$create_variable_set")
        ucrPnlOptions.AddFunctionNamesCondition(rdoEdit, frmMain.clsRLink.strInstatDataObject & "$update_variable_set")
        ucrPnlOptions.AddFunctionNamesCondition(rdoDelete, frmMain.clsRLink.strInstatDataObject & "$delete_variable_sets")

        'Show ucrInputSetNewName IFF rdoMake & rdoEdit is checked. 
        'The lblSetName will be visible IFF ucrInputSetNewName is visible
        ucrPnlOptions.AddToLinkedControls(ucrInputSetNewName, {rdoMake, rdoEdit}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputSetNewName.SetLinkedDisplayControl(lblSetName)

        'Show ucrInputSetNewName IFF rdoEdit is checked
        'The lblSelectedSet will be visible IFF ucrReceiverSelectedSet is visible
        ucrPnlOptions.AddToLinkedControls(ucrReceiverSelectedSet, {rdoEdit}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverSelectedSet.SetLinkedDisplayControl(lblSelectedSet)

        'set the selector for ucrReceiverMultipleVariables i.e its source of data
        ucrReceiverMultipleVariables.Selector = ucrSelectorVariableSets
        ucrReceiverSelectedSet.Selector = ucrSelectorVariableSets


    End Sub

    'this sub implicitly calls ucrPnlOptions_ControlValueChanged() once the clsRBasefunction.SetRCommand executes
    Private Sub setDefaults()
        'create a base RFunction object. This will be used in calling the base function
        clsRMakeFunction = New RFunction
        clsREditFunction = New RFunction
        clsRDeleteFunction = New RFunction

        'clear the contents of the ucrReceiverMultipleVariables
        ucrReceiverMultipleVariables.Clear()

        'set the base command for diff RFunctions (called thro' the instantobject).Will be used whenever Ok btn is clicked
        clsRMakeFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$create_variable_set")
        clsREditFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$update_variable_set")
        clsRDeleteFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$delete_variable_sets")

        'set the default base function to be called
        ucrBase.clsRsyntax.SetBaseRFunction(clsRMakeFunction)
    End Sub

    Private Sub setRCodeForControls(bReset As Boolean)
        'sets pair parameters for the controls that should receive different paraments based on RFunction passed
        ucrReceiverMultipleVariables.AddAdditionalCodeParameterPair(clsREditFunction, New RParameter("columns", 1), iAdditionalPairNo:=1)
        ucrReceiverMultipleVariables.AddAdditionalCodeParameterPair(clsRDeleteFunction, New RParameter("set_names", 0), iAdditionalPairNo:=2)
        ucrInputSetNewName.AddAdditionalCodeParameterPair(clsREditFunction, New RParameter("new_set_name", 1), iAdditionalPairNo:=1)

        'sets R code for the controls.
        ucrSelectorVariableSets.SetRCode(clsRMakeFunction, bReset)
        ucrReceiverSelectedSet.SetRCode(clsREditFunction, bReset)
        ucrReceiverMultipleVariables.SetRCode(clsRMakeFunction, bReset)
        ucrInputSetNewName.SetRCode(clsRMakeFunction, bReset)
        ucrPnlOptions.SetRCode(clsRMakeFunction, bReset)
    End Sub

    'event called whenever a radio button is clicked
    'this is also implicitly triggered by sub setRCodeForControls(bReset As Boolean)
    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        'Please note this event Is triggered twice whenever there is a change in rdobtn checked due to ucrCore.controlValue being triggerred too
        'Am yet to pinpoint why this happens.
        SetDialogOptions()
    End Sub

    Private Sub SetDialogOptions()
        If rdoMake.Checked Then
            'clear current data
            ucrReceiverMultipleVariables.Clear()
            ucrInputSetNewName.SetName("")
            ucrSelectorVariableSets.SetItemType("column")
            ucrReceiverMultipleVariables.SetMeAsReceiver()
            'switch the base function to clsRMakeFunction
            ucrBase.clsRsyntax.SetBaseRFunction(clsRMakeFunction)
        ElseIf rdoEdit.Checked
            'clear current data 
            ucrReceiverMultipleVariables.Clear()
            ucrInputSetNewName.SetName("")
            ucrReceiverSelectedSet.Clear()
            ucrReceiverSelectedSet.SetMeAsReceiver()
            ucrSelectorVariableSets.SetItemType("variable_sets")
            'switch the base function to clsREditFunction
            ucrBase.clsRsyntax.SetBaseRFunction(clsREditFunction)
        ElseIf rdoDelete.Checked
            'clear current data
            ucrReceiverMultipleVariables.Clear()
            ucrSelectorVariableSets.SetItemType("variable_sets")
            ucrReceiverMultipleVariables.SetMeAsReceiver()
            'switch the base function to clsRDeleteFunction
            ucrBase.clsRsyntax.SetBaseRFunction(clsRDeleteFunction)
        End If
    End Sub

    'event called when ucrReceiverSelectedSet control has a value. 
    'fills ucrReceiverMultipleVariables With the columns Of the set selected
    Private Sub ucrReceiverSelectedSet_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelectedSet.ControlValueChanged
        'For edit operation, populate the ucrReceiverMultipleVariables with the created variable sets
        If rdoEdit.Checked Then
            'clear the contents of the receiver first
            ucrReceiverMultipleVariables.Clear()
            Dim clsGetColsRFunct As New RFunction
            Dim symbExpr As SymbolicExpression
            Dim chrcolnames As CharacterVector
            Dim lstCols As New List(Of String)
            With clsGetColsRFunct
                .SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variable_sets")
                .AddParameter("data_name", Chr(34) & ucrSelectorVariableSets.ucrAvailableDataFrames.strCurrDataFrame & Chr(34))
                .AddParameter("set_names", ucrReceiverSelectedSet.GetVariableNames())
            End With
            symbExpr = frmMain.clsRLink.RunInternalScriptGetValue(clsGetColsRFunct.ToScript(), bSilent:=True)
            If symbExpr IsNot Nothing Then
                chrcolnames = symbExpr.AsCharacter
                lstCols.AddRange(chrcolnames)
                For Each str As String In lstCols
                    'pass in a col & its dataframe
                    ucrReceiverMultipleVariables.Add(str, ucrSelectorVariableSets.ucrAvailableDataFrames.strCurrDataFrame)
                Next
            End If
            'Show the name for the selected set for edit
            ucrInputSetNewName.SetName(ucrReceiverSelectedSet.txtReceiverSingle.Text)
        End If
    End Sub

    'Checks if the user input controls have the necessary values before enabling the ok button of the ucrbase
    'triggered everytime content of the controls is changed
    Private Sub OkControl_Enable(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleVariables.ControlContentsChanged, ucrInputSetNewName.ControlContentsChanged
        'disable the ok button by default
        ucrBase.OKEnabled(False)
        'for rdoMake & rdoEdit check the following
        If rdoMake.Checked OrElse rdoEdit.Checked Then
            If Not ucrReceiverMultipleVariables.IsEmpty AndAlso Not ucrInputSetNewName.IsEmpty Then
                ucrBase.OKEnabled(True)
            End If
        ElseIf rdoDelete.Checked
            If Not ucrReceiverMultipleVariables.IsEmpty Then
                ucrBase.OKEnabled(True)
            End If
        End If
    End Sub

    'Ok button event 
    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        'in the case of delete, clear the ucrReceiverMultipleVariables control to confirm the operation as successful
        If rdoDelete.Checked Then
            ucrReceiverMultipleVariables.Clear()
        End If
    End Sub

    'reset button event
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        setDefaults()
        setRCodeForControls(True)
        'adds parameter data_name manually for operation edit and delete 
        setParameterDataName()
    End Sub

    'called when ucrVariableSetsSelector values change
    Private Sub ucrVariableSetsSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorVariableSets.ControlValueChanged
        'adds parameter data_name manually for operation edit and delete 
        setParameterDataName()
    End Sub

    'appends the data_name parameter to the RFunctions
    Private Sub setParameterDataName()
        'update the parameter data_name for the various RFunctions manually.
        'For clsRDeleteFunction
        If clsRDeleteFunction.GetParameter("data_name") Is Nothing Then
            clsRDeleteFunction.AddParameter("data_name", Chr(34) & ucrSelectorVariableSets.ucrAvailableDataFrames.strCurrDataFrame & Chr(34), iPosition:=0)
        Else
            clsRDeleteFunction.GetParameter("data_name").SetArgumentValue(Chr(34) & ucrSelectorVariableSets.ucrAvailableDataFrames.strCurrDataFrame & Chr(34))
        End If

        'For clsREditFunction
        If clsREditFunction.GetParameter("data_name") Is Nothing Then
            clsREditFunction.AddParameter("data_name", Chr(34) & ucrSelectorVariableSets.ucrAvailableDataFrames.strCurrDataFrame & Chr(34), iPosition:=0)
        Else
            clsREditFunction.GetParameter("data_name").SetArgumentValue(Chr(34) & ucrSelectorVariableSets.ucrAvailableDataFrames.strCurrDataFrame & Chr(34))
        End If
    End Sub
End Class