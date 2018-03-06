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

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgImportFromClimSoft
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgImportFromClimSoft))
        Me.ucrInputDatabaseName = New instat.ucrInputTextBox()
        Me.lblDatabaseName = New System.Windows.Forms.Label()
        Me.ucrInputHost = New instat.ucrInputTextBox()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.ucrInputPort = New instat.ucrInputTextBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.ucrInputUserName = New instat.ucrInputTextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.ucrBaseSdgClimSoft = New instat.ucrButtonsSubdialogue()
        Me.cmdEnterPassword = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrInputDatabaseName
        '
        Me.ucrInputDatabaseName.AddQuotesIfUnrecognised = True
        Me.ucrInputDatabaseName.IsMultiline = False
        Me.ucrInputDatabaseName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDatabaseName, "ucrInputDatabaseName")
        Me.ucrInputDatabaseName.Name = "ucrInputDatabaseName"
        '
        'lblDatabaseName
        '
        resources.ApplyResources(Me.lblDatabaseName, "lblDatabaseName")
        Me.lblDatabaseName.Name = "lblDatabaseName"
        '
        'ucrInputHost
        '
        Me.ucrInputHost.AddQuotesIfUnrecognised = True
        Me.ucrInputHost.IsMultiline = False
        Me.ucrInputHost.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputHost, "ucrInputHost")
        Me.ucrInputHost.Name = "ucrInputHost"
        '
        'lblHost
        '
        resources.ApplyResources(Me.lblHost, "lblHost")
        Me.lblHost.Name = "lblHost"
        '
        'ucrInputPort
        '
        Me.ucrInputPort.AddQuotesIfUnrecognised = True
        Me.ucrInputPort.IsMultiline = False
        Me.ucrInputPort.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPort, "ucrInputPort")
        Me.ucrInputPort.Name = "ucrInputPort"
        '
        'lblPort
        '
        resources.ApplyResources(Me.lblPort, "lblPort")
        Me.lblPort.Name = "lblPort"
        '
        'ucrInputUserName
        '
        Me.ucrInputUserName.AddQuotesIfUnrecognised = True
        Me.ucrInputUserName.IsMultiline = False
        Me.ucrInputUserName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputUserName, "ucrInputUserName")
        Me.ucrInputUserName.Name = "ucrInputUserName"
        '
        'lblUserName
        '
        resources.ApplyResources(Me.lblUserName, "lblUserName")
        Me.lblUserName.Name = "lblUserName"
        '
        'lblConnection
        '
        resources.ApplyResources(Me.lblConnection, "lblConnection")
        Me.lblConnection.Name = "lblConnection"
        '
        'ucrBaseSdgClimSoft
        '
        resources.ApplyResources(Me.ucrBaseSdgClimSoft, "ucrBaseSdgClimSoft")
        Me.ucrBaseSdgClimSoft.Name = "ucrBaseSdgClimSoft"
        '
        'cmdEnterPassword
        '
        resources.ApplyResources(Me.cmdEnterPassword, "cmdEnterPassword")
        Me.cmdEnterPassword.Name = "cmdEnterPassword"
        Me.cmdEnterPassword.UseVisualStyleBackColor = True
        '
        'sdgImportFromClimSoft
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrBaseSdgClimSoft)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.cmdEnterPassword)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.ucrInputUserName)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.ucrInputPort)
        Me.Controls.Add(Me.lblHost)
        Me.Controls.Add(Me.ucrInputHost)
        Me.Controls.Add(Me.lblDatabaseName)
        Me.Controls.Add(Me.ucrInputDatabaseName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgImportFromClimSoft"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrInputDatabaseName As ucrInputTextBox
    Friend WithEvents lblDatabaseName As Label
    Friend WithEvents ucrInputHost As ucrInputTextBox
    Friend WithEvents lblHost As Label
    Friend WithEvents ucrInputPort As ucrInputTextBox
    Friend WithEvents lblPort As Label
    Friend WithEvents ucrInputUserName As ucrInputTextBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblConnection As Label
    Friend WithEvents ucrBaseSdgClimSoft As ucrButtonsSubdialogue
    Friend WithEvents cmdEnterPassword As Button
End Class
