<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgChangeType
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
        Me.ucrReceiverSingle = New instat.ucrReceiverSingle()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpColumnType = New System.Windows.Forms.GroupBox()
        Me.rdoFactor = New System.Windows.Forms.RadioButton()
        Me.rdoText = New System.Windows.Forms.RadioButton()
        Me.rdoVariate = New System.Windows.Forms.RadioButton()
        Me.chkReadTextAsDateValues = New System.Windows.Forms.CheckBox()
        Me.btnDateFormat = New System.Windows.Forms.Button()
        Me.grpColumnType.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrReceiverSingle
        '
        Me.ucrReceiverSingle.Location = New System.Drawing.Point(217, 25)
        Me.ucrReceiverSingle.Name = "ucrReceiverSingle"
        Me.ucrReceiverSingle.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverSingle.TabIndex = 0
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(12, 12)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(182, 118)
        Me.ucrAddRemove.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 247)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 2
        '
        'grpColumnType
        '
        Me.grpColumnType.Controls.Add(Me.rdoFactor)
        Me.grpColumnType.Controls.Add(Me.rdoText)
        Me.grpColumnType.Controls.Add(Me.rdoVariate)
        Me.grpColumnType.Location = New System.Drawing.Point(217, 57)
        Me.grpColumnType.Name = "grpColumnType"
        Me.grpColumnType.Size = New System.Drawing.Size(170, 100)
        Me.grpColumnType.TabIndex = 3
        Me.grpColumnType.TabStop = False
        Me.grpColumnType.Tag = "Column_type"
        Me.grpColumnType.Text = "Column type"
        '
        'rdoFactor
        '
        Me.rdoFactor.AutoSize = True
        Me.rdoFactor.Location = New System.Drawing.Point(7, 68)
        Me.rdoFactor.Name = "rdoFactor"
        Me.rdoFactor.Size = New System.Drawing.Size(55, 17)
        Me.rdoFactor.TabIndex = 2
        Me.rdoFactor.TabStop = True
        Me.rdoFactor.Tag = "Factor"
        Me.rdoFactor.Text = "Factor"
        Me.rdoFactor.UseVisualStyleBackColor = True
        '
        'rdoText
        '
        Me.rdoText.AutoSize = True
        Me.rdoText.Location = New System.Drawing.Point(7, 44)
        Me.rdoText.Name = "rdoText"
        Me.rdoText.Size = New System.Drawing.Size(46, 17)
        Me.rdoText.TabIndex = 1
        Me.rdoText.TabStop = True
        Me.rdoText.Tag = "Text"
        Me.rdoText.Text = "Text"
        Me.rdoText.UseVisualStyleBackColor = True
        '
        'rdoVariate
        '
        Me.rdoVariate.AutoSize = True
        Me.rdoVariate.Location = New System.Drawing.Point(7, 20)
        Me.rdoVariate.Name = "rdoVariate"
        Me.rdoVariate.Size = New System.Drawing.Size(58, 17)
        Me.rdoVariate.TabIndex = 0
        Me.rdoVariate.TabStop = True
        Me.rdoVariate.Tag = "Variate"
        Me.rdoVariate.Text = "Variate"
        Me.rdoVariate.UseVisualStyleBackColor = True
        '
        'chkReadTextAsDateValues
        '
        Me.chkReadTextAsDateValues.AutoSize = True
        Me.chkReadTextAsDateValues.Location = New System.Drawing.Point(224, 164)
        Me.chkReadTextAsDateValues.Name = "chkReadTextAsDateValues"
        Me.chkReadTextAsDateValues.Size = New System.Drawing.Size(144, 17)
        Me.chkReadTextAsDateValues.TabIndex = 4
        Me.chkReadTextAsDateValues.Tag = "Read_text_as_date_values"
        Me.chkReadTextAsDateValues.Text = "Read text as date values"
        Me.chkReadTextAsDateValues.UseVisualStyleBackColor = True
        '
        'btnDateFormat
        '
        Me.btnDateFormat.Location = New System.Drawing.Point(224, 197)
        Me.btnDateFormat.Name = "btnDateFormat"
        Me.btnDateFormat.Size = New System.Drawing.Size(99, 23)
        Me.btnDateFormat.TabIndex = 5
        Me.btnDateFormat.Tag = "Date_format"
        Me.btnDateFormat.Text = "Date format"
        Me.btnDateFormat.UseVisualStyleBackColor = True
        '
        'dlgChangeType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 291)
        Me.Controls.Add(Me.btnDateFormat)
        Me.Controls.Add(Me.chkReadTextAsDateValues)
        Me.Controls.Add(Me.grpColumnType)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrReceiverSingle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgChangeType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Change_type"
        Me.Text = "Change type"
        Me.grpColumnType.ResumeLayout(False)
        Me.grpColumnType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrReceiverSingle As ucrReceiverSingle
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpColumnType As GroupBox
    Friend WithEvents rdoFactor As RadioButton
    Friend WithEvents rdoText As RadioButton
    Friend WithEvents rdoVariate As RadioButton
    Friend WithEvents chkReadTextAsDateValues As CheckBox
    Friend WithEvents btnDateFormat As Button
End Class
