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
Imports RDotNet

Public Class dlgName
    Dim bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Dim bUseSelectedColumn As Boolean = False
    Dim strSelectedColumn As String = ""
    Dim strSelectedDataFrame As String = ""
    Private clsDefaultRFunction As New RFunction

    Private Sub dlgName_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If

        'Reset the ucrInputs to change their bUserTyped = True so that their inputs can be changed by ucrReceiverName_ControlValueChanged()
        ucrInputNewName.Reset()
        ucrInputVariableLabel.Reset()

        SetRCodeForControls(bReset)
        bReset = False
        If bUseSelectedColumn Then
            SetSelectedColumn()
        End If

    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 33

        'Selector
        ucrSelectVariables.SetParameter(New RParameter("data_name", 0))
        ucrSelectVariables.SetParameterIsString()

        'Receiver
        ucrReceiverName.SetParameter(New RParameter("column_name", 1))
        ucrReceiverName.SetParameterIsString()
        ucrReceiverName.Selector = ucrSelectVariables
        ucrReceiverName.SetMeAsReceiver()

        'New Name Input
        ucrInputNewName.SetParameter(New RParameter("new_val", 2))
        'set validation of ucrInputNewName as an RVariable.(input should not have any R reserved words like 'if','while')
        ucrInputNewName.SetValidationTypeAsRVariable()

        'Label Input
        ucrInputVariableLabel.SetParameter(New RParameter("label", 3))
    End Sub

    Public Sub SetDefaults()
        clsDefaultRFunction = New RFunction

        ucrSelectVariables.Reset()
        ucrInputNewName.Reset()
        ucrInputVariableLabel.Reset()

        ucrInputNewName.SetName("")
        ucrInputVariableLabel.SetName("")

        clsDefaultRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$rename_column_in_data")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction)

    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverName.IsEmpty() AndAlso Not ucrInputNewName.IsEmpty() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Public Sub SetCurrentColumn(strColumn As String, strDataFrame As String)
        strSelectedColumn = strColumn
        strSelectedDataFrame = strDataFrame
        bUseSelectedColumn = True
    End Sub

    Private Sub SetSelectedColumn()
        ucrSelectVariables.SetDataframe(strSelectedDataFrame)
        ucrReceiverName.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged() Handles ucrInputNewName.ControlContentsChanged, ucrReceiverName.ControlContentsChanged, ucrSelectVariables.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverName_ControlValueChanged() Handles ucrReceiverName.ControlValueChanged
        'if the receiver is not empty
        If Not ucrReceiverName.IsEmpty Then
            'if the user has not typed anything then change the ucrInputNewName contents
            If Not ucrInputNewName.bUserTyped Then
                ucrInputNewName.SetName(ucrReceiverName.GetVariableNames(bWithQuotes:=False))
            End If

            'if the user has not typed anything then change the ucrInputVariableLabel contents
            If Not ucrInputVariableLabel.bUserTyped Then
                'get the label of the column selected(from ucrReceiverName) and set it as ucrInputVariableLabel value
                Dim colmnLabelsRFunction = New RFunction
                Dim expItems As SymbolicExpression

                colmnLabelsRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_labels")
                colmnLabelsRFunction.AddParameter("data_name", Chr(34) & ucrSelectVariables.strCurrentDataFrame & Chr(34))
                colmnLabelsRFunction.AddParameter("columns", ucrReceiverName.GetVariableNames(bWithQuotes:=True))

                expItems = frmMain.clsRLink.RunInternalScriptGetValue(colmnLabelsRFunction.ToScript(), bSilent:=True)

                If expItems IsNot Nothing AndAlso Not (expItems.Type = Internals.SymbolicExpressionType.Null) Then
                    For Each strLabel As String In expItems.AsCharacter.ToArray
                        ucrInputVariableLabel.SetName(strLabel)
                    Next
                End If

            End If

        Else
            'if the receiver is empty. These 2 controls should be empty
            ucrInputNewName.SetName("")
            ucrInputVariableLabel.SetName("")
        End If

    End Sub


End Class
