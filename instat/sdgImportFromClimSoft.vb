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
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
    End Sub

    Private Sub InitialiseControls()
        ucrInputDatabaseName.SetParameter(New RParameter("dbname"))
        ucrInputDatabaseName.SetRDefault("mariadb_climsoft_test_db_v4")
        ucrInputHost.SetParameter(New RParameter("host"))
        ucrInputHost.SetRDefault("127.0.0.1")
        ucrInputPort.SetParameter(New RParameter("port"))
        'ucrInputPort.SetRDefault("3308")
        ucrInputPort.AddQuotesIfUnrecognised = False
        ucrInputUserName.SetParameter(New RParameter("user"))
        ucrInputUserName.SetRDefault("root")
        bControlsInitialised = True
    End Sub

    Public Function GetConnectionActiveStatus() As Boolean
        Return bConnected
    End Function

    Public Sub SetRDatabaseConnection(clsNewRDatabaseConnect As RFunction, clsNewRDatabaseDisconnect As RFunction, clsNewHasConnection As RFunction, Optional bConnectionActive As Boolean = False, Optional bResetSubdialog As Boolean = False)
        clsRDatabaseConnect = clsNewRDatabaseConnect
        clsRDatabaseDisconnect = clsNewRDatabaseDisconnect
        clsHasConnection = clsNewHasConnection
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        SetRCode(Me, clsRDatabaseConnect, bResetSubdialog)
    End Sub

    Private Sub cmdEnterPassword_Click(sender As Object, e As EventArgs) Handles cmdEnterPassword.Click
        Dim expTemp As SymbolicExpression
        Dim message, title, defaultPassword As String
        Dim myValue As Object
        ' Set prompt.
        message = "Enter the password"
        ' Set title.
        title = "Climsoft Password"
        'defaultPassword = "admin"
        myValue = InputBox(message, title)
        clsRDatabaseConnect.AddParameter("password", Chr(34) & myValue & Chr(34))

        If bConnected Then
            frmMain.clsRLink.RunScript(clsRDatabaseDisconnect.ToScript(), strComment:="Disconnect database connection.")
        End If
        frmMain.clsRLink.RunScript(clsRDatabaseConnect.ToScript(), strComment:="Connect database connection.")

        expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsHasConnection.ToScript())
        If Not expTemp.Type = Internals.SymbolicExpressionType.Null Then
            bConnected = expTemp.AsLogical(0)
        Else
            bConnected = False
        End If
        If bConnected Then
            lblConnection.Text = strConnected
        Else
            lblConnection.Text = strNoConnection
        End If
        dlgClimSoft.ucrReceiverMultipleStations.SetMeAsReceiver() 'this is necessary to refresh the selector in the main dialog. Should happen on click return from subdialog
    End Sub
End Class