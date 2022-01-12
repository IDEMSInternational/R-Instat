<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConvertToNumeric
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConvertToNumeric))
        Me.lblPossibleSolutions = New System.Windows.Forms.Label()
        Me.cmdNormalConvert = New System.Windows.Forms.Button()
        Me.cmdLabelledConvert = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.lblN = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.lblColumn = New System.Windows.Forms.Label()
        Me.lblColumnName = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.cmdInspectValues = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPossibleSolutions
        '
        Me.lblPossibleSolutions.Location = New System.Drawing.Point(13, 30)
        Me.lblPossibleSolutions.Name = "lblPossibleSolutions"
        Me.lblPossibleSolutions.Size = New System.Drawing.Size(423, 103)
        Me.lblPossibleSolutions.TabIndex = 4
        Me.lblPossibleSolutions.Text = resources.GetString("lblPossibleSolutions.Text")
        '
        'cmdNormalConvert
        '
        Me.cmdNormalConvert.Location = New System.Drawing.Point(100, 143)
        Me.cmdNormalConvert.Name = "cmdNormalConvert"
        Me.cmdNormalConvert.Size = New System.Drawing.Size(96, 23)
        Me.cmdNormalConvert.TabIndex = 6
        Me.cmdNormalConvert.Text = "Normal Convert"
        Me.cmdNormalConvert.UseVisualStyleBackColor = True
        '
        'cmdLabelledConvert
        '
        Me.cmdLabelledConvert.Location = New System.Drawing.Point(197, 143)
        Me.cmdLabelledConvert.Name = "cmdLabelledConvert"
        Me.cmdLabelledConvert.Size = New System.Drawing.Size(96, 23)
        Me.cmdLabelledConvert.TabIndex = 7
        Me.cmdLabelledConvert.Text = "Labelled Convert"
        Me.cmdLabelledConvert.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(302, 143)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(66, 23)
        Me.cmdHelp.TabIndex = 8
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.ForeColor = System.Drawing.Color.Red
        Me.lblN.Location = New System.Drawing.Point(261, 9)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(0, 13)
        Me.lblN.TabIndex = 3
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(370, 143)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(66, 23)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'lblColumn
        '
        Me.lblColumn.AutoSize = True
        Me.lblColumn.Location = New System.Drawing.Point(16, 8)
        Me.lblColumn.Name = "lblColumn"
        Me.lblColumn.Size = New System.Drawing.Size(48, 13)
        Me.lblColumn.TabIndex = 0
        Me.lblColumn.Text = "Column: "
        '
        'lblColumnName
        '
        Me.lblColumnName.AutoSize = True
        Me.lblColumnName.ForeColor = System.Drawing.Color.Red
        Me.lblColumnName.Location = New System.Drawing.Point(63, 8)
        Me.lblColumnName.Name = "lblColumnName"
        Me.lblColumnName.Size = New System.Drawing.Size(0, 13)
        Me.lblColumnName.TabIndex = 1
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(138, 8)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(123, 13)
        Me.lblNumber.TabIndex = 2
        Me.lblNumber.Text = "Number of non-numeric: "
        '
        'cmdInspectValues
        '
        Me.cmdInspectValues.Location = New System.Drawing.Point(3, 143)
        Me.cmdInspectValues.Name = "cmdInspectValues"
        Me.cmdInspectValues.Size = New System.Drawing.Size(96, 23)
        Me.cmdInspectValues.TabIndex = 5
        Me.cmdInspectValues.Text = "Inspect Values"
        Me.cmdInspectValues.UseVisualStyleBackColor = True
        '
        'frmConvertToNumeric
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(440, 171)
        Me.Controls.Add(Me.cmdInspectValues)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblColumnName)
        Me.Controls.Add(Me.lblColumn)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.lblN)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdLabelledConvert)
        Me.Controls.Add(Me.cmdNormalConvert)
        Me.Controls.Add(Me.lblPossibleSolutions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConvertToNumeric"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convert to Numeric"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPossibleSolutions As Label
    Friend WithEvents cmdNormalConvert As Button
    Friend WithEvents cmdLabelledConvert As Button
    Friend WithEvents cmdHelp As Button
    Friend WithEvents lblN As Label
    Friend WithEvents cmdCancel As Button
    Friend WithEvents lblColumn As Label
    Friend WithEvents lblColumnName As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents cmdInspectValues As Button
End Class
