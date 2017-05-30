' Instat-R
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

Imports instat.Translations
Imports RDotNet

Public Class sdgImportFromClimSoft
    Private clsRDatabaseConnect As RFunction
    Private clsRDatabaseDisconnect As RFunction
    Private clsHasConnection As New RFunction
    Private bControlsInitialised As Boolean = False
    Private bConnected As Boolean = False
    Private strConnected As String = "Connected"
    Private strNoConnection As String = "No Connection"

    Private Sub sdgImportFromClimSoft_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
    End Sub

    Private Sub InitialiseControls()
        ucrInputDatabaseName.SetParameter(New RParameter("dbname", 0))
        ucrInputHost.SetParameter(New RParameter("host", 1))
        ucrInputPort.SetParameter(New RParameter("port", 2))
        ucrInputPort.AddQuotesIfUnrecognised = False
        ucrInputUserName.SetParameter(New RParameter("user", 3))
        cmdEnterPassword.Enabled = False
        bControlsInitialised = True
    End Sub

    Public Function GetConnectionActiveStatus() As Boolean
        Return bConnected
    End Function

    Public Sub SetRDatabaseConnection(clsNewRDatabaseConnect As RFunction, clsNewRDatabaseDisconnect As RFunction, clsNewHasConnection As RFunction, Optional bConnectionActive As Boolean = False, Optional bReset As Boolean = False)
        clsRDatabaseConnect = clsNewRDatabaseConnect
        clsRDatabaseDisconnect = clsNewRDatabaseDisconnect
        clsHasConnection = clsNewHasConnection
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        SetRCode(Me, clsRDatabaseConnect, bReset)
    End Sub

    Private Sub cmdEnterPassword_Click(sender As Object, e As EventArgs) Handles cmdEnterPassword.Click
        Dim expTemp As SymbolicExpression
        cmdEnterPassword.Enabled = False
        If bConnected Then
            frmMain.clsRLink.RunScript(clsRDatabaseDisconnect.ToScript(), strComment:="Disconnect database connection.")
            bConnected = False
        Else
            frmMain.clsRLink.RunScript(clsRDatabaseConnect.ToScript(), strComment:="Connect database connection.")
            expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsHasConnection.ToScript())
            If Not expTemp.Type = Internals.SymbolicExpressionType.Null Then
                bConnected = expTemp.AsLogical(0)
            Else
                bConnected = False
            End If
        End If
        If bConnected Then
            lblConnection.Text = strConnected
            cmdEnterPassword.Text = "Disconnnect"
        Else
            lblConnection.Text = strNoConnection
            cmdEnterPassword.Text = "Enter Password"
        End If
        cmdEnterPassword.Enabled = True
    End Sub

    Private Sub ucrControlsContents_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputDatabaseName.ControlContentsChanged, ucrInputHost.ControlContentsChanged, ucrInputPort.ControlContentsChanged, ucrInputUserName.ControlContentsChanged
        Dim strHost As String = ""
        Dim strUser As String = ""
        Dim strPort As String = ""
        Dim strDatabaseName As String = ""

        If ucrInputPort.GetText() <> "" AndAlso ucrInputUserName.GetText() <> "" AndAlso ucrInputHost.GetText() <> "" AndAlso ucrInputDatabaseName.GetText() <> "" Then
            cmdEnterPassword.Enabled = True
        Else
            cmdEnterPassword.Enabled = False
        End If

        If clsRDatabaseConnect IsNot Nothing Then
            If clsRDatabaseConnect.ContainsParameter("host") Then
                strHost = clsRDatabaseConnect.GetParameter("host").strArgumentValue
            End If
            If clsRDatabaseConnect.ContainsParameter("user") Then
                strUser = clsRDatabaseConnect.GetParameter("user").strArgumentValue
            End If
            If clsRDatabaseConnect.ContainsParameter("port") Then
                strPort = clsRDatabaseConnect.GetParameter("port").strArgumentValue
            End If
            If clsRDatabaseConnect.ContainsParameter("dbname") Then
                strDatabaseName = clsRDatabaseConnect.GetParameter("dbname").strArgumentValue
            End If
        End If
        If bConnected AndAlso (strPort <> ucrInputPort.GetText() OrElse strDatabaseName <> Chr(34) & ucrInputDatabaseName.GetText() & Chr(34) OrElse strHost <> Chr(34) & ucrInputHost.GetText() & Chr(34) OrElse strUser <> Chr(34) & ucrInputUserName.GetText() & Chr(34)) Then
            frmMain.clsRLink.RunScript(clsRDatabaseDisconnect.ToScript(), strComment:="Disconnect database connection.")
            lblConnection.Text = strNoConnection
            bConnected = False
        End If
        If bConnected Then
            lblConnection.Text = strConnected
            cmdEnterPassword.Text = "Disconnnect"
        Else
            lblConnection.Text = strNoConnection
            cmdEnterPassword.Text = "Enter Password"
        End If
    End Sub
End Class