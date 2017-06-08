<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrGridUnit
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.grpUnits = New System.Windows.Forms.GroupBox()
        Me.ucrInputData = New instat.ucrInputTextBox()
        Me.ucrInputVector = New instat.ucrInputTextBox()
        Me.ucrInputUnits = New instat.ucrInputComboBox()
        Me.ucrChkUnits = New instat.ucrCheck()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpUnits.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpUnits
        '
        Me.grpUnits.Controls.Add(Me.Label1)
        Me.grpUnits.Controls.Add(Me.ucrInputData)
        Me.grpUnits.Controls.Add(Me.ucrInputVector)
        Me.grpUnits.Controls.Add(Me.ucrInputUnits)
        Me.grpUnits.Controls.Add(Me.ucrChkUnits)
        Me.grpUnits.Location = New System.Drawing.Point(-2, -3)
        Me.grpUnits.Name = "grpUnits"
        Me.grpUnits.Size = New System.Drawing.Size(279, 120)
        Me.grpUnits.TabIndex = 108
        Me.grpUnits.TabStop = False
        Me.grpUnits.Text = "Units"
        '
        'ucrInputData
        '
        Me.ucrInputData.AddQuotesIfUnrecognised = True
        Me.ucrInputData.IsMultiline = False
        Me.ucrInputData.IsReadOnly = False
        Me.ucrInputData.Location = New System.Drawing.Point(134, 89)
        Me.ucrInputData.Name = "ucrInputData"
        Me.ucrInputData.Size = New System.Drawing.Size(106, 23)
        Me.ucrInputData.TabIndex = 111
        '
        'ucrInputVector
        '
        Me.ucrInputVector.AddQuotesIfUnrecognised = True
        Me.ucrInputVector.IsMultiline = False
        Me.ucrInputVector.IsReadOnly = False
        Me.ucrInputVector.Location = New System.Drawing.Point(134, 18)
        Me.ucrInputVector.Name = "ucrInputVector"
        Me.ucrInputVector.Size = New System.Drawing.Size(106, 23)
        Me.ucrInputVector.TabIndex = 110
        '
        'ucrInputUnits
        '
        Me.ucrInputUnits.AddQuotesIfUnrecognised = True
        Me.ucrInputUnits.IsReadOnly = False
        Me.ucrInputUnits.Location = New System.Drawing.Point(134, 42)
        Me.ucrInputUnits.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputUnits.Name = "ucrInputUnits"
        Me.ucrInputUnits.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputUnits.TabIndex = 109
        '
        'ucrChkUnits
        '
        Me.ucrChkUnits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrChkUnits.Checked = False
        Me.ucrChkUnits.Location = New System.Drawing.Point(10, 18)
        Me.ucrChkUnits.Name = "ucrChkUnits"
        Me.ucrChkUnits.Size = New System.Drawing.Size(122, 20)
        Me.ucrChkUnits.TabIndex = 108
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Data (Optional)"
        '
        'ucrGridUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpUnits)
        Me.Name = "ucrGridUnit"
        Me.Size = New System.Drawing.Size(280, 119)
        Me.grpUnits.ResumeLayout(False)
        Me.grpUnits.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpUnits As GroupBox
    Friend WithEvents ucrInputData As ucrInputTextBox
    Friend WithEvents ucrInputVector As ucrInputTextBox
    Friend WithEvents ucrInputUnits As ucrInputComboBox
    Friend WithEvents ucrChkUnits As ucrCheck
    Friend WithEvents Label1 As Label
End Class
