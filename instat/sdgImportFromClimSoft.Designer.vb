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
        Me.ucrInputDrv = New instat.ucrInputComboBox()
        Me.lblDrv = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDatabaseName
        '
        Me.lblDatabaseName.AutoSize = True
        Me.lblDatabaseName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDatabaseName.Location = New System.Drawing.Point(18, 27)
        Me.lblDatabaseName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatabaseName.Name = "lblDatabaseName"
        Me.lblDatabaseName.Size = New System.Drawing.Size(129, 20)
        Me.lblDatabaseName.TabIndex = 0
        Me.lblDatabaseName.Text = "Database Name:"
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHost.Location = New System.Drawing.Point(93, 106)
        Me.lblHost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(47, 20)
        Me.lblHost.TabIndex = 2
        Me.lblHost.Text = "Host:"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPort.Location = New System.Drawing.Point(98, 146)
        Me.lblPort.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(42, 20)
        Me.lblPort.TabIndex = 4
        Me.lblPort.Text = "Port:"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUserName.Location = New System.Drawing.Point(54, 185)
        Me.lblUserName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(87, 20)
        Me.lblUserName.TabIndex = 6
        Me.lblUserName.Text = "Username:"
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.ForeColor = System.Drawing.Color.Red
        Me.lblConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConnection.Location = New System.Drawing.Point(278, 262)
        Me.lblConnection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(114, 20)
        Me.lblConnection.TabIndex = 8
        Me.lblConnection.Text = "No Connection"
        '
        'chkRememberCredentials
        '
        Me.chkRememberCredentials.AutoSize = True
        Me.chkRememberCredentials.Checked = True
        Me.chkRememberCredentials.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRememberCredentials.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkRememberCredentials.Location = New System.Drawing.Point(154, 220)
        Me.chkRememberCredentials.Margin = New System.Windows.Forms.Padding(4)
        Me.chkRememberCredentials.Name = "chkRememberCredentials"
        Me.chkRememberCredentials.Size = New System.Drawing.Size(198, 24)
        Me.chkRememberCredentials.TabIndex = 5
        Me.chkRememberCredentials.Text = "Remember Credentials"
        Me.chkRememberCredentials.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConnect.Location = New System.Drawing.Point(156, 254)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(114, 33)
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
        Me.ucrComboBoxPort.Location = New System.Drawing.Point(154, 142)
        Me.ucrComboBoxPort.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrComboBoxPort.Name = "ucrComboBoxPort"
        Me.ucrComboBoxPort.Size = New System.Drawing.Size(230, 32)
        Me.ucrComboBoxPort.TabIndex = 3
        '
        'ucrTxtHost
        '
        Me.ucrTxtHost.AddQuotesIfUnrecognised = True
        Me.ucrTxtHost.AutoSize = True
        Me.ucrTxtHost.IsMultiline = False
        Me.ucrTxtHost.IsReadOnly = False
        Me.ucrTxtHost.Location = New System.Drawing.Point(154, 100)
        Me.ucrTxtHost.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrTxtHost.Name = "ucrTxtHost"
        Me.ucrTxtHost.Size = New System.Drawing.Size(230, 32)
        Me.ucrTxtHost.TabIndex = 2
        '
        'ucrComboBoxDatabaseName
        '
        Me.ucrComboBoxDatabaseName.AddQuotesIfUnrecognised = True
        Me.ucrComboBoxDatabaseName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrComboBoxDatabaseName.GetSetSelectedIndex = -1
        Me.ucrComboBoxDatabaseName.IsReadOnly = False
        Me.ucrComboBoxDatabaseName.Location = New System.Drawing.Point(154, 23)
        Me.ucrComboBoxDatabaseName.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrComboBoxDatabaseName.Name = "ucrComboBoxDatabaseName"
        Me.ucrComboBoxDatabaseName.Size = New System.Drawing.Size(230, 32)
        Me.ucrComboBoxDatabaseName.TabIndex = 1
        '
        'ucrBaseSdgClimSoft
        '
        Me.ucrBaseSdgClimSoft.AutoSize = True
        Me.ucrBaseSdgClimSoft.Location = New System.Drawing.Point(33, 314)
        Me.ucrBaseSdgClimSoft.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBaseSdgClimSoft.Name = "ucrBaseSdgClimSoft"
        Me.ucrBaseSdgClimSoft.Size = New System.Drawing.Size(336, 45)
        Me.ucrBaseSdgClimSoft.TabIndex = 7
        '
        'ucrTxtUserName
        '
        Me.ucrTxtUserName.AddQuotesIfUnrecognised = True
        Me.ucrTxtUserName.AutoSize = True
        Me.ucrTxtUserName.IsMultiline = False
        Me.ucrTxtUserName.IsReadOnly = False
        Me.ucrTxtUserName.Location = New System.Drawing.Point(154, 179)
        Me.ucrTxtUserName.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrTxtUserName.Name = "ucrTxtUserName"
        Me.ucrTxtUserName.Size = New System.Drawing.Size(230, 32)
        Me.ucrTxtUserName.TabIndex = 4
        '
        'ucrInputDrv
        '
        Me.ucrInputDrv.AddQuotesIfUnrecognised = True
        Me.ucrInputDrv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDrv.GetSetSelectedIndex = -1
        Me.ucrInputDrv.IsReadOnly = False
        Me.ucrInputDrv.Location = New System.Drawing.Point(154, 62)
        Me.ucrInputDrv.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputDrv.Name = "ucrInputDrv"
        Me.ucrInputDrv.Size = New System.Drawing.Size(230, 32)
        Me.ucrInputDrv.TabIndex = 9
        '
        'lblDrv
        '
        Me.lblDrv.AutoSize = True
        Me.lblDrv.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDrv.Location = New System.Drawing.Point(93, 65)
        Me.lblDrv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDrv.Name = "lblDrv"
        Me.lblDrv.Size = New System.Drawing.Size(34, 20)
        Me.lblDrv.TabIndex = 10
        Me.lblDrv.Text = "drv:"
        '
        'sdgImportFromClimSoft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(402, 365)
        Me.Controls.Add(Me.lblDrv)
        Me.Controls.Add(Me.ucrInputDrv)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents ucrInputDrv As ucrInputComboBox
    Friend WithEvents lblDrv As Label
End Class
