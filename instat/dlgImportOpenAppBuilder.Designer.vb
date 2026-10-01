<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgImportOpenAppBuilder
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkFilter = New instat.ucrCheck()
        Me.ucrInputVariable = New instat.ucrInputComboBox()
        Me.ucrInputValue = New instat.ucrInputComboBox()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.ucrSave = New instat.ucrSave()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.btnConnection = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 230)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrChkFilter
        '
        Me.ucrChkFilter.AutoSize = True
        Me.ucrChkFilter.Checked = False
        Me.ucrChkFilter.Location = New System.Drawing.Point(9, 67)
        Me.ucrChkFilter.Name = "ucrChkFilter"
        Me.ucrChkFilter.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkFilter.TabIndex = 1
        '
        'ucrInputVariable
        '
        Me.ucrInputVariable.AddQuotesIfUnrecognised = True
        Me.ucrInputVariable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputVariable.GetSetSelectedIndex = -1
        Me.ucrInputVariable.IsReadOnly = False
        Me.ucrInputVariable.Location = New System.Drawing.Point(153, 100)
        Me.ucrInputVariable.Name = "ucrInputVariable"
        Me.ucrInputVariable.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputVariable.TabIndex = 2
        '
        'ucrInputValue
        '
        Me.ucrInputValue.AddQuotesIfUnrecognised = True
        Me.ucrInputValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputValue.GetSetSelectedIndex = -1
        Me.ucrInputValue.IsReadOnly = False
        Me.ucrInputValue.Location = New System.Drawing.Point(153, 140)
        Me.ucrInputValue.Name = "ucrInputValue"
        Me.ucrInputValue.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputValue.TabIndex = 3
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.Location = New System.Drawing.Point(37, 103)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(97, 13)
        Me.lblVariable.TabIndex = 4
        Me.lblVariable.Text = "Variable to Filter to:"
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(7, 143)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(127, 13)
        Me.lblValue.TabIndex = 5
        Me.lblValue.Text = "Variable Value to Filter to:"
        '
        'ucrSave
        '
        Me.ucrSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSave.Location = New System.Drawing.Point(9, 187)
        Me.ucrSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSave.Name = "ucrSave"
        Me.ucrSave.Size = New System.Drawing.Size(403, 34)
        Me.ucrSave.TabIndex = 6
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.ForeColor = System.Drawing.Color.Red
        Me.lblConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConnection.Location = New System.Drawing.Point(166, 30)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(78, 13)
        Me.lblConnection.TabIndex = 18
        Me.lblConnection.Text = "No Connection"
        '
        'btnConnection
        '
        Me.btnConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConnection.Location = New System.Drawing.Point(9, 24)
        Me.btnConnection.Name = "btnConnection"
        Me.btnConnection.Size = New System.Drawing.Size(147, 23)
        Me.btnConnection.TabIndex = 17
        Me.btnConnection.Text = "Connect to Database"
        Me.btnConnection.UseVisualStyleBackColor = True
        '
        'dlgImportOpenAppBuilder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 284)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.btnConnection)
        Me.Controls.Add(Me.ucrSave)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.ucrInputValue)
        Me.Controls.Add(Me.ucrInputVariable)
        Me.Controls.Add(Me.ucrChkFilter)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportOpenAppBuilder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import From OpenAppBuilder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkFilter As ucrCheck
    Friend WithEvents ucrInputVariable As ucrInputComboBox
    Friend WithEvents ucrInputValue As ucrInputComboBox
    Friend WithEvents lblVariable As Label
    Friend WithEvents lblValue As Label
    Friend WithEvents ucrSave As ucrSave
    Friend WithEvents lblConnection As Label
    Friend WithEvents btnConnection As Button
End Class
