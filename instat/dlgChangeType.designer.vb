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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChangetypeReceiver = New instat.ucrReceiverSingle()
        Me.ucrChangeTypeSelector = New instat.ucrSelectorAddRemove()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.grpColumnType = New System.Windows.Forms.GroupBox()
        Me.rdoUnitsVector = New System.Windows.Forms.RadioButton()
        Me.rdoFactor = New System.Windows.Forms.RadioButton()
        Me.rdoText = New System.Windows.Forms.RadioButton()
        Me.rdoVariate = New System.Windows.Forms.RadioButton()
        Me.chkReadTextAsDateValues = New System.Windows.Forms.CheckBox()
        Me.cmdDateFormat = New System.Windows.Forms.Button()
        Me.lblReadTextAsDateValues = New System.Windows.Forms.Label()
        Me.grpColumnType.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 267)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrChangetypeReceiver
        '
        Me.ucrChangetypeReceiver.Location = New System.Drawing.Point(227, 34)
        Me.ucrChangetypeReceiver.Name = "ucrChangetypeReceiver"
        Me.ucrChangetypeReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrChangetypeReceiver.TabIndex = 1
        '
        'ucrChangeTypeSelector
        '
        Me.ucrChangeTypeSelector.Location = New System.Drawing.Point(12, 12)
        Me.ucrChangeTypeSelector.Name = "ucrChangeTypeSelector"
        Me.ucrChangeTypeSelector.Size = New System.Drawing.Size(209, 136)
        Me.ucrChangeTypeSelector.TabIndex = 2
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.Location = New System.Drawing.Point(261, 18)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(45, 13)
        Me.lblVariable.TabIndex = 3
        Me.lblVariable.Tag = "Variable"
        Me.lblVariable.Text = "Variable"
        '
        'grpColumnType
        '
        Me.grpColumnType.Controls.Add(Me.rdoUnitsVector)
        Me.grpColumnType.Controls.Add(Me.rdoFactor)
        Me.grpColumnType.Controls.Add(Me.rdoText)
        Me.grpColumnType.Controls.Add(Me.rdoVariate)
        Me.grpColumnType.Location = New System.Drawing.Point(217, 66)
        Me.grpColumnType.Name = "grpColumnType"
        Me.grpColumnType.Size = New System.Drawing.Size(200, 119)
        Me.grpColumnType.TabIndex = 4
        Me.grpColumnType.TabStop = False
        Me.grpColumnType.Tag = "Column_Type"
        Me.grpColumnType.Text = "Column type"
        '
        'rdoUnitsVector
        '
        Me.rdoUnitsVector.AutoSize = True
        Me.rdoUnitsVector.Location = New System.Drawing.Point(6, 88)
        Me.rdoUnitsVector.Name = "rdoUnitsVector"
        Me.rdoUnitsVector.Size = New System.Drawing.Size(83, 17)
        Me.rdoUnitsVector.TabIndex = 0
        Me.rdoUnitsVector.TabStop = True
        Me.rdoUnitsVector.Tag = "Units_Vector"
        Me.rdoUnitsVector.Text = "Units Vector"
        Me.rdoUnitsVector.UseVisualStyleBackColor = True
        '
        'rdoFactor
        '
        Me.rdoFactor.AutoSize = True
        Me.rdoFactor.Location = New System.Drawing.Point(6, 65)
        Me.rdoFactor.Name = "rdoFactor"
        Me.rdoFactor.Size = New System.Drawing.Size(55, 17)
        Me.rdoFactor.TabIndex = 0
        Me.rdoFactor.TabStop = True
        Me.rdoFactor.Tag = "Factor"
        Me.rdoFactor.Text = "Factor"
        Me.rdoFactor.UseVisualStyleBackColor = True
        '
        'rdoText
        '
        Me.rdoText.AutoSize = True
        Me.rdoText.Location = New System.Drawing.Point(6, 42)
        Me.rdoText.Name = "rdoText"
        Me.rdoText.Size = New System.Drawing.Size(46, 17)
        Me.rdoText.TabIndex = 0
        Me.rdoText.TabStop = True
        Me.rdoText.Tag = "Text"
        Me.rdoText.Text = "Text"
        Me.rdoText.UseVisualStyleBackColor = True
        '
        'rdoVariate
        '
        Me.rdoVariate.AutoSize = True
        Me.rdoVariate.Location = New System.Drawing.Point(6, 19)
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
        Me.chkReadTextAsDateValues.Location = New System.Drawing.Point(148, 212)
        Me.chkReadTextAsDateValues.Name = "chkReadTextAsDateValues"
        Me.chkReadTextAsDateValues.Size = New System.Drawing.Size(16, 23)
        Me.chkReadTextAsDateValues.TabIndex = 0
        Me.chkReadTextAsDateValues.Tag = ""
        Me.chkReadTextAsDateValues.UseVisualStyleBackColor = True
        '
        'cmdDateFormat
        '
        Me.cmdDateFormat.Location = New System.Drawing.Point(314, 212)
        Me.cmdDateFormat.Name = "cmdDateFormat"
        Me.cmdDateFormat.Size = New System.Drawing.Size(86, 23)
        Me.cmdDateFormat.TabIndex = 5
        Me.cmdDateFormat.Tag = "Date_Format"
        Me.cmdDateFormat.Text = "Date Format"
        Me.cmdDateFormat.UseVisualStyleBackColor = True
        '
        'lblReadTextAsDateValues
        '
        Me.lblReadTextAsDateValues.AutoSize = True
        Me.lblReadTextAsDateValues.Location = New System.Drawing.Point(170, 217)
        Me.lblReadTextAsDateValues.Name = "lblReadTextAsDateValues"
        Me.lblReadTextAsDateValues.Size = New System.Drawing.Size(125, 13)
        Me.lblReadTextAsDateValues.TabIndex = 6
        Me.lblReadTextAsDateValues.Tag = "Read_text_as_date_values"
        Me.lblReadTextAsDateValues.Text = "Read text as date values"
        '
        'dlgChangeType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 326)
        Me.Controls.Add(Me.lblReadTextAsDateValues)
        Me.Controls.Add(Me.cmdDateFormat)
        Me.Controls.Add(Me.chkReadTextAsDateValues)
        Me.Controls.Add(Me.grpColumnType)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.ucrChangeTypeSelector)
        Me.Controls.Add(Me.ucrChangetypeReceiver)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgChangeType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Change_Type"
        Me.Text = "Change Type"
        Me.grpColumnType.ResumeLayout(False)
        Me.grpColumnType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChangetypeReceiver As ucrReceiverSingle
    Friend WithEvents ucrChangeTypeSelector As ucrSelectorAddRemove
    Friend WithEvents lblVariable As Label
    Friend WithEvents grpColumnType As GroupBox
    Friend WithEvents rdoUnitsVector As RadioButton
    Friend WithEvents rdoFactor As RadioButton
    Friend WithEvents rdoText As RadioButton
    Friend WithEvents rdoVariate As RadioButton
    Friend WithEvents chkReadTextAsDateValues As CheckBox
    Friend WithEvents cmdDateFormat As Button
    Friend WithEvents lblReadTextAsDateValues As Label
End Class
