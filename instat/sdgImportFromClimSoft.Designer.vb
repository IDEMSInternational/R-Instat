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
        Me.lblDatabaseName.AutoSize = True
        Me.lblDatabaseName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDatabaseName.Location = New System.Drawing.Point(12, 24)
        Me.lblDatabaseName.Name = "lblDatabaseName"
        Me.lblDatabaseName.Size = New System.Drawing.Size(87, 13)
        Me.lblDatabaseName.TabIndex = 0
        Me.lblDatabaseName.Text = "Database Name:"
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHost.Location = New System.Drawing.Point(62, 53)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(32, 13)
        Me.lblHost.TabIndex = 2
        Me.lblHost.Text = "Host:"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPort.Location = New System.Drawing.Point(65, 80)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(29, 13)
        Me.lblPort.TabIndex = 4
        Me.lblPort.Text = "Port:"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUserName.Location = New System.Drawing.Point(36, 106)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(58, 13)
        Me.lblUserName.TabIndex = 6
        Me.lblUserName.Text = "Username:"
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.ForeColor = System.Drawing.Color.Red
        Me.lblConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConnection.Location = New System.Drawing.Point(185, 157)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(78, 13)
        Me.lblConnection.TabIndex = 8
        Me.lblConnection.Text = "No Connection"
        '
        'chkRememberCredentials
        '
        Me.chkRememberCredentials.AutoSize = True
        Me.chkRememberCredentials.Checked = True
        Me.chkRememberCredentials.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRememberCredentials.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkRememberCredentials.Location = New System.Drawing.Point(103, 129)
        Me.chkRememberCredentials.Name = "chkRememberCredentials"
        Me.chkRememberCredentials.Size = New System.Drawing.Size(132, 17)
        Me.chkRememberCredentials.TabIndex = 5
        Me.chkRememberCredentials.Text = "Remember Credentials"
        Me.chkRememberCredentials.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConnect.Location = New System.Drawing.Point(104, 152)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(76, 22)
        Me.btnConnect.TabIndex = 6
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'ucrComboBoxPort
        '
        Me.ucrComboBoxPort.AddQuotesIfUnrecognised = False
        Me.ucrComboBoxPort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrComboBoxPort.GetSetSelectedIndex = -1
        Me.ucrComboBoxPort.IsReadOnly = False
        Me.ucrComboBoxPort.Location = New System.Drawing.Point(103, 77)
        Me.ucrComboBoxPort.Name = "ucrComboBoxPort"
        Me.ucrComboBoxPort.Size = New System.Drawing.Size(153, 21)
        Me.ucrComboBoxPort.TabIndex = 3
        '
        'ucrTxtHost
        '
        Me.ucrTxtHost.AddQuotesIfUnrecognised = True
        Me.ucrTxtHost.AutoSize = True
        Me.ucrTxtHost.IsMultiline = False
        Me.ucrTxtHost.IsReadOnly = False
        Me.ucrTxtHost.Location = New System.Drawing.Point(103, 49)
        Me.ucrTxtHost.Name = "ucrTxtHost"
        Me.ucrTxtHost.Size = New System.Drawing.Size(153, 21)
        Me.ucrTxtHost.TabIndex = 2
        '
        'ucrComboBoxDatabaseName
        '
        Me.ucrComboBoxDatabaseName.AddQuotesIfUnrecognised = True
        Me.ucrComboBoxDatabaseName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrComboBoxDatabaseName.GetSetSelectedIndex = -1
        Me.ucrComboBoxDatabaseName.IsReadOnly = False
        Me.ucrComboBoxDatabaseName.Location = New System.Drawing.Point(103, 21)
        Me.ucrComboBoxDatabaseName.Name = "ucrComboBoxDatabaseName"
        Me.ucrComboBoxDatabaseName.Size = New System.Drawing.Size(153, 21)
        Me.ucrComboBoxDatabaseName.TabIndex = 1
        '
        'ucrBaseSdgClimSoft
        '
        Me.ucrBaseSdgClimSoft.AutoSize = True
        Me.ucrBaseSdgClimSoft.Location = New System.Drawing.Point(52, 192)
        Me.ucrBaseSdgClimSoft.Name = "ucrBaseSdgClimSoft"
        Me.ucrBaseSdgClimSoft.Size = New System.Drawing.Size(224, 30)
        Me.ucrBaseSdgClimSoft.TabIndex = 7
        '
        'ucrTxtUserName
        '
        Me.ucrTxtUserName.AddQuotesIfUnrecognised = True
        Me.ucrTxtUserName.AutoSize = True
        Me.ucrTxtUserName.IsMultiline = False
        Me.ucrTxtUserName.IsReadOnly = False
        Me.ucrTxtUserName.Location = New System.Drawing.Point(103, 102)
        Me.ucrTxtUserName.Name = "ucrTxtUserName"
        Me.ucrTxtUserName.Size = New System.Drawing.Size(153, 21)
        Me.ucrTxtUserName.TabIndex = 4
        '
        'sdgImportFromClimSoft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(268, 225)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connect To ClimSoft Database"
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
