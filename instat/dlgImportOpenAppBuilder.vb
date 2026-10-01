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

Public Class dlgImportOpenAppBuilder
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsGetUserDataFunction, clsGetDataBaseConnection As New RFunction

    Private Sub dlgImportOpenAppBuilder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        CheckAndUpdateConnectionStatus()
    End Sub

    Private Sub InitialiseDialog()

        Dim dctVariable As New Dictionary(Of String, String)
        Dim dctValue As New Dictionary(Of String, String)

        ucrChkFilter.SetText("Filter")
        ucrChkFilter.SetParameter(New RParameter("filter ", 1))
        ucrChkFilter.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkFilter.SetRDefault("FALSE")
        ucrChkFilter.AddToLinkedControls({ucrInputVariable}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="app_deployment_name")
        ucrChkFilter.AddToLinkedControls({ucrInputValue}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="virtual_maths_camp")

        ucrInputVariable.SetParameter(New RParameter("filter_variable", 2))
        dctVariable.Add("app_deployment_name", Chr(34) & "app_deployment_name" & Chr(34))
        ucrInputVariable.SetItems(dctVariable)
        ucrInputVariable.SetLinkedDisplayControl(lblVariable)

        ucrInputValue.SetParameter(New RParameter("filter_variable_value", 3))
        dctValue.Add("virtual_maths_camp", Chr(34) & "virtual_maths_camp" & Chr(34))
        dctValue.Add("plh_za", Chr(34) & "plh_za" & Chr(34))
        dctValue.Add("wash", Chr(34) & "wash" & Chr(34))
        dctValue.Add("plh_tz", Chr(34) & "plh_tz" & Chr(34))
        dctValue.Add("plh_global", Chr(34) & "plh_global" & Chr(34))
        dctValue.Add("early_family_math", Chr(34) & "early_family_math" & Chr(34))
        dctValue.Add("ae_soils", Chr(34) & "ae_soils" & Chr(34))
        dctValue.Add("plh_teens_tz", Chr(34) & "plh_teens_tz" & Chr(34))
        dctValue.Add("pfr", Chr(34) & "pfr" & Chr(34))
        dctValue.Add("ae_app", Chr(34) & "ae_app" & Chr(34))
        ucrInputValue.SetItems(dctValue)
        ucrInputValue.SetLinkedDisplayControl(lblValue)

        ucrSave.SetSaveTypeAsDataFrame()
        ucrSave.SetIsTextBox()
        ucrSave.SetPrefix("openappdata")
        ucrSave.SetLabelText("Data Frame Name:")

    End Sub

    Private Sub SetDefaults()
        clsGetUserDataFunction = New RFunction
        clsGetDataBaseConnection = New RFunction

        clsGetDataBaseConnection.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_database_connection")
        clsGetDataBaseConnection.SetAssignTo("plh_con")

        clsGetUserDataFunction.SetPackageName("openappr")
        clsGetUserDataFunction.SetRCommand("get_user_data")
        clsGetUserDataFunction.AddParameter("site", "plh_con", iPosition:=0)

        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDataBaseConnection)
        ucrBase.clsRsyntax.SetBaseRFunction(clsGetUserDataFunction)

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputValue.SetRCode(clsGetUserDataFunction, bReset)
        ucrInputVariable.SetRCode(clsGetUserDataFunction, bReset)
        ucrChkFilter.SetRCode(clsGetUserDataFunction, bReset)
        ucrSave.SetRCode(clsGetUserDataFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        sdgImportFromClimSoft.Reset()
        CheckAndUpdateConnectionStatus()
    End Sub

    Private Sub CheckAndUpdateConnectionStatus()
        If sdgImportFromClimSoft.IsConnectionIsActive() Then
            lblConnection.Text = "Connected"
            lblConnection.ForeColor = Color.Green
        Else
            lblConnection.Text = "No Connection"
            lblConnection.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnConnection_Click(sender As Object, e As EventArgs) Handles btnConnection.Click
        sdgImportFromClimSoft.ShowDialog()
        CheckAndUpdateConnectionStatus()
    End Sub

    Private Sub ucrChkFilter_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFilter.ControlValueChanged, ucrInputVariable.ControlValueChanged, ucrInputValue.ControlValueChanged
        If ucrChkFilter.Checked AndAlso Not ucrInputVariable.IsEmpty Then
            clsGetUserDataFunction.AddParameter("filter_variable", Chr(34) & ucrInputVariable.GetText & Chr(34))
        Else
            clsGetUserDataFunction.RemoveParameterByName("filter_variable")
        End If

        If ucrChkFilter.Checked AndAlso Not ucrInputValue.IsEmpty Then
            clsGetUserDataFunction.AddParameter("filter_variable_value", Chr(34) & ucrInputValue.GetText & Chr(34))
        Else
            clsGetUserDataFunction.RemoveParameterByName("filter_variable_value")
        End If
    End Sub
End Class
