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
Public Class dlgImportFromPostgres
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsGetFormsFunction As New RFunction, clsDefaultRFunction As New RFunction

    Private Sub dlgImportFromPostgres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()


        ucrInputChooseDataset.SetParameter(New RParameter("Dataset_name", 3))
        ucrInputChooseDataset.bAllowNonConditionValues = True

        ucrInputUsername.SetParameter(New RParameter("username", 1))
        ucrInputPort.SetParameter(New RParameter("port", 2))
        ucrInputDatabase.SetParameter(New RParameter("database", 1))
        ucrInputHost.SetParameter(New RParameter("host", 1))

        ucrBase.clsRsyntax.bSeparateThread = False
        ucrBase.clsRsyntax.bShowWaitDialogOverride = False
    End Sub

    Private Sub SetDefaults()
        clsDefaultRFunction = New RFunction
        clsGetFormsFunction = New RFunction

        ucrInputChooseDataset.bAllowNonConditionValues = True
        ucrInputChooseDataset.SetName("")
        ucrInputUsername.SetName("")
        ucrInputDatabase.SetName("")
        ucrInputHost.SetName("")
        ucrInputPort.SetName("")


        clsGetFormsFunction.SetPackageName("postgresr")
        clsDefaultRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_from_Postgres")
        clsGetFormsFunction.SetRCommand("get_postgres_data")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrInputChooseDataset.IsEmpty AndAlso Not ucrInputUsername.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrInputUsername_NameChanged() Handles ucrInputUsername.ControlValueChanged
        If ucrInputUsername.IsEmpty() Then
            clsGetFormsFunction.RemoveParameterByName("site")
        Else
            clsGetFormsFunction.AddParameter("site", Chr(34) & ucrInputUsername.GetText & Chr(34))
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrInputUsername_ContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputUsername.ControlContentsChanged
        If ucrInputUsername.IsEmpty() Then
            cmdGetData.Enabled = False
        Else
            cmdGetData.Enabled = True
        End If
        ucrInputChooseDataset.cboInput.Items.Clear()
        ucrInputChooseDataset.SetText("")
        TestOKEnabled()
    End Sub

    Private Sub ucrInputChooseDataset_ContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputChooseDataset.ControlContentsChanged, ucrInputUsername.ControlContentsChanged ', ucrInputPassword.ControlContentsChanged 
        TestOKEnabled()
    End Sub

    Private Sub cmdGetData_click(sender As Object, e As EventArgs) Handles cmdGetData.Click
        Dim strFormNames() As String
        Dim expTemp As SymbolicExpression

        Cursor = Cursors.WaitCursor
        expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsGetFormsFunction.ToScript(), bSeparateThread:=False, bShowWaitDialogOverride:=False)
        Cursor = Cursors.Default
        If expTemp IsNot Nothing Then
            strFormNames = expTemp.AsCharacter().ToArray()
            If strFormNames.Length > 0 Then
                ucrInputChooseDataset.SetItems(strFormNames)
                ucrInputChooseDataset.SetName(ucrInputChooseDataset.cboInput.Items(0))
            Else
                ucrInputChooseDataset.cboInput.Items.Clear()
            End If
        Else
            ucrInputChooseDataset.cboInput.Items.Clear()
        End If
    End Sub
=======

Public Class dlgImportFromPostgres


End Class