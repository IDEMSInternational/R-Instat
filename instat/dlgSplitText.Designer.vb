<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSplitText
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
        Me.ucrSelectorSplitTextColumn = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblSelectedFactors = New System.Windows.Forms.Label()
        Me.cboPattern = New System.Windows.Forms.ComboBox()
        Me.lblPattern = New System.Windows.Forms.Label()
        Me.lblColumnInto = New System.Windows.Forms.Label()
        Me.ucrReceiverSplitTextColumn = New instat.ucrReceiverMultiple()
        Me.lblN = New System.Windows.Forms.Label()
        Me.nudN = New System.Windows.Forms.NumericUpDown()
        Me.ucrInputColumnIntoText = New instat.ucrInputComboBox()
        CType(Me.nudN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 251)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorSplitTextColumn
        '
        Me.ucrSelectorSplitTextColumn.Location = New System.Drawing.Point(12, 13)
        Me.ucrSelectorSplitTextColumn.Name = "ucrSelectorSplitTextColumn"
        Me.ucrSelectorSplitTextColumn.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorSplitTextColumn.TabIndex = 1
        '
        'lblSelectedFactors
        '
        Me.lblSelectedFactors.AutoSize = True
        Me.lblSelectedFactors.Location = New System.Drawing.Point(277, 13)
        Me.lblSelectedFactors.Name = "lblSelectedFactors"
        Me.lblSelectedFactors.Size = New System.Drawing.Size(84, 13)
        Me.lblSelectedFactors.TabIndex = 3
        Me.lblSelectedFactors.Tag = "Selected_Factors"
        Me.lblSelectedFactors.Text = "Selected factors"
        '
        'cboPattern
        '
        Me.cboPattern.FormattingEnabled = True
        Me.cboPattern.Location = New System.Drawing.Point(280, 171)
        Me.cboPattern.Name = "cboPattern"
        Me.cboPattern.Size = New System.Drawing.Size(121, 21)
        Me.cboPattern.TabIndex = 4
        '
        'lblPattern
        '
        Me.lblPattern.AutoSize = True
        Me.lblPattern.Location = New System.Drawing.Point(277, 155)
        Me.lblPattern.Name = "lblPattern"
        Me.lblPattern.Size = New System.Drawing.Size(41, 13)
        Me.lblPattern.TabIndex = 5
        Me.lblPattern.Tag = "Pattern"
        Me.lblPattern.Text = "Pattern"
        '
        'lblColumnInto
        '
        Me.lblColumnInto.AutoSize = True
        Me.lblColumnInto.Location = New System.Drawing.Point(12, 235)
        Me.lblColumnInto.Name = "lblColumnInto"
        Me.lblColumnInto.Size = New System.Drawing.Size(65, 13)
        Me.lblColumnInto.TabIndex = 6
        Me.lblColumnInto.Tag = "Column_Into"
        Me.lblColumnInto.Text = "Column into "
        '
        'ucrReceiverSplitTextColumn
        '
        Me.ucrReceiverSplitTextColumn.Location = New System.Drawing.Point(280, 33)
        Me.ucrReceiverSplitTextColumn.Name = "ucrReceiverSplitTextColumn"
        Me.ucrReceiverSplitTextColumn.Selector = Nothing
        Me.ucrReceiverSplitTextColumn.Size = New System.Drawing.Size(121, 104)
        Me.ucrReceiverSplitTextColumn.TabIndex = 8
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Location = New System.Drawing.Point(12, 205)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(132, 13)
        Me.lblN.TabIndex = 9
        Me.lblN.Tag = "Number_of_pieces_to_return"
        Me.lblN.Text = "Number of pieces to return"
        '
        'nudN
        '
        Me.nudN.Location = New System.Drawing.Point(335, 198)
        Me.nudN.Name = "nudN"
        Me.nudN.Size = New System.Drawing.Size(66, 20)
        Me.nudN.TabIndex = 10
        '
        'ucrInputColumnIntoText
        '
        Me.ucrInputColumnIntoText.Location = New System.Drawing.Point(264, 224)
        Me.ucrInputColumnIntoText.Name = "ucrInputColumnIntoText"
        Me.ucrInputColumnIntoText.Size = New System.Drawing.Size(137, 25)
        Me.ucrInputColumnIntoText.TabIndex = 11
        '
        'dlgSplitText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 315)
        Me.Controls.Add(Me.ucrInputColumnIntoText)
        Me.Controls.Add(Me.nudN)
        Me.Controls.Add(Me.lblN)
        Me.Controls.Add(Me.ucrReceiverSplitTextColumn)
        Me.Controls.Add(Me.lblColumnInto)
        Me.Controls.Add(Me.lblPattern)
        Me.Controls.Add(Me.cboPattern)
        Me.Controls.Add(Me.lblSelectedFactors)
        Me.Controls.Add(Me.ucrSelectorSplitTextColumn)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgSplitText"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Split_text_column"
        Me.Text = "Split text column"
        CType(Me.nudN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorSplitTextColumn As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblSelectedFactors As Label
    Friend WithEvents cboPattern As ComboBox
    Friend WithEvents lblPattern As Label
    Friend WithEvents lblColumnInto As Label
    Friend WithEvents ucrReceiverSplitTextColumn As ucrReceiverMultiple
    Friend WithEvents lblN As Label
    Friend WithEvents nudN As NumericUpDown
    Friend WithEvents ucrInputColumnIntoText As ucrInputComboBox
End Class
