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
        Me.lblDatabaseName = New System.Windows.Forms.Label()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.chkRememberCredentials = New System.Windows.Forms.CheckBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.ucrComboBoxPort = New instat.ucrInputComboBox()
        Me.ucrTxtHost = New instat.ucrInputTextBox()
        Me.ucrComboBoxDatabaseName = New instat.ucrInputComboBox()
        Me.ucrBaseSdgClimSoft = New instat.ucrButtonsSubdialogue()
        Me.ucrTxtUserName = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'lblDatabaseName
        '
        resources.ApplyResources(Me.lblDatabaseName, "lblDatabaseName")
        Me.lblDatabaseName.Name = "lblDatabaseName"
        '
        'lblHost
        '
        resources.ApplyResources(Me.lblHost, "lblHost")
        Me.lblHost.Name = "lblHost"
        '
        'lblPort
        '
        resources.ApplyResources(Me.lblPort, "lblPort")
        Me.lblPort.Name = "lblPort"
        '
        'lblUserName
        '
        resources.ApplyResources(Me.lblUserName, "lblUserName")
        Me.lblUserName.Name = "lblUserName"
        '
        'lblConnection
        '
        resources.ApplyResources(Me.lblConnection, "lblConnection")
        Me.lblConnection.ForeColor = System.Drawing.Color.Red
        Me.lblConnection.Name = "lblConnection"
        '
        'chkRememberCredentials
        '
        resources.ApplyResources(Me.chkRememberCredentials, "chkRememberCredentials")
        Me.chkRememberCredentials.Checked = True
        Me.chkRememberCredentials.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRememberCredentials.Name = "chkRememberCredentials"
        Me.chkRememberCredentials.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        resources.ApplyResources(Me.btnConnect, "btnConnect")
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'ucrComboBoxPort
        '
        Me.ucrComboBoxPort.AddQuotesIfUnrecognised = False
        Me.ucrComboBoxPort.GetSetSelectedIndex = -1
        Me.ucrComboBoxPort.IsReadOnly = False
        resources.ApplyResources(Me.ucrComboBoxPort, "ucrComboBoxPort")
        Me.ucrComboBoxPort.Name = "ucrComboBoxPort"
        '
        'ucrTxtHost
        '
        Me.ucrTxtHost.AddQuotesIfUnrecognised = True
        Me.ucrTxtHost.IsMultiline = False
        Me.ucrTxtHost.IsReadOnly = False
        resources.ApplyResources(Me.ucrTxtHost, "ucrTxtHost")
        Me.ucrTxtHost.Name = "ucrTxtHost"
        '
        'ucrComboBoxDatabaseName
        '
        Me.ucrComboBoxDatabaseName.AddQuotesIfUnrecognised = True
        Me.ucrComboBoxDatabaseName.GetSetSelectedIndex = -1
        Me.ucrComboBoxDatabaseName.IsReadOnly = False
        resources.ApplyResources(Me.ucrComboBoxDatabaseName, "ucrComboBoxDatabaseName")
        Me.ucrComboBoxDatabaseName.Name = "ucrComboBoxDatabaseName"
        '
        'ucrBaseSdgClimSoft
        '
        resources.ApplyResources(Me.ucrBaseSdgClimSoft, "ucrBaseSdgClimSoft")
        Me.ucrBaseSdgClimSoft.Name = "ucrBaseSdgClimSoft"
        '
        'ucrTxtUserName
        '
        Me.ucrTxtUserName.AddQuotesIfUnrecognised = True
        Me.ucrTxtUserName.IsMultiline = False
        Me.ucrTxtUserName.IsReadOnly = False
        resources.ApplyResources(Me.ucrTxtUserName, "ucrTxtUserName")
        Me.ucrTxtUserName.Name = "ucrTxtUserName"
        '
        'sdgImportFromClimSoft
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrComboBoxPort)
        Me.Controls.Add(Me.ucrTxtHost)
        Me.Controls.Add(Me.ucrComboBoxDatabaseName)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.chkRememberCredentials)
        Me.Controls.Add(Me.ucrBaseSdgClimSoft)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.ucrTxtUserName)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.lblHost)
        Me.Controls.Add(Me.lblDatabaseName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgImportFromClimSoft"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDatabaseName As Label
    Friend WithEvents lblHost As Label
    Friend WithEvents lblPort As Label
    Friend WithEvents ucrTxtUserName As ucrInputTextBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblConnection As Label
    Friend WithEvents ucrBaseSdgClimSoft As ucrButtonsSubdialogue
    Friend WithEvents chkRememberCredentials As CheckBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents ucrComboBoxDatabaseName As ucrInputComboBox
    Friend WithEvents ucrTxtHost As ucrInputTextBox
    Friend WithEvents ucrComboBoxPort As ucrInputComboBox
End Class
