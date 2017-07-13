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
Public Class dlgName
    Dim bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Dim bUseSelectedColumn As Boolean = False
    Dim strSelectedColumn As String = ""
    Dim strSelectedDataFrame As String = ""
    Private clsDefaultRFunction As New RFunction

    Private Sub dlgName_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        If bUseSelectedColumn Then
            SetDefaultColumn()
        End If
    End Sub

    Private Sub ReopenDialog()
        ucrSelectVariables.Reset()
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
        ucrInputNewName.SetValidationTypeAsRVariable()

        'Label Input
        ucrInputVariableLabel.SetParameter(New RParameter("label", 3))
    End Sub

    Public Sub SetDefaults()
        clsDefaultRFunction = New RFunction
        ucrInputVariableLabel.Reset()
        ucrSelectVariables.Reset()
        ucrInputNewName.Reset()

        clsDefaultRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$rename_column_in_data")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction)
        ucrInputVariableLabel.SetName("")
        ucrInputNewName.SetName("")
    End Sub

    Private Sub DefaultNewName()
        If ((Not ucrInputNewName.bUserTyped) AndAlso (Not ucrReceiverName.IsEmpty)) Then
            ucrInputNewName.SetName(ucrReceiverName.GetVariableNames(bWithQuotes:=False))
        End If
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

    Private Sub SetDefaultColumn()
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

    Private Sub ucrReceiverName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverName.ControlValueChanged
        DefaultNewName()
    End Sub
End Class
