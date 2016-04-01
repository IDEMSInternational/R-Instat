<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgSplitText
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgSplitText))
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorSplitTextColumn = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblSelectedFactors = New System.Windows.Forms.Label()
        Me.cboPattern = New System.Windows.Forms.ComboBox()
        Me.lblPattern = New System.Windows.Forms.Label()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.ucrReceiverSplitTextColumn = New instat.ucrReceiverMultiple()
        Me.lblNumberofPiecesToReturn = New System.Windows.Forms.Label()
        Me.nudN = New System.Windows.Forms.NumericUpDown()
        Me.ucrInputColumnsIntoText = New instat.ucrInputTextBox()
        CType(Me.nudN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 256)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorSplitTextColumn
        '
        Me.ucrSelectorSplitTextColumn.Location = New System.Drawing.Point(12, 13)
        Me.ucrSelectorSplitTextColumn.lstVariablesInReceivers = CType(resources.GetObject("ucrSelectorSplitTextColumn.lstVariablesInReceivers"), System.Collections.Generic.List(Of String))
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
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(12, 237)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(98, 13)
        Me.lblNewColumnName.TabIndex = 6
        Me.lblNewColumnName.Tag = "New_Column_Name"
        Me.lblNewColumnName.Text = "New Column Name"
        '
        'ucrReceiverSplitTextColumn
        '
        Me.ucrReceiverSplitTextColumn.Location = New System.Drawing.Point(280, 33)
        Me.ucrReceiverSplitTextColumn.Name = "ucrReceiverSplitTextColumn"
        Me.ucrReceiverSplitTextColumn.Selector = Nothing
        Me.ucrReceiverSplitTextColumn.Size = New System.Drawing.Size(121, 104)
        Me.ucrReceiverSplitTextColumn.TabIndex = 8
        '
        'lblNumberofPiecesToReturn
        '
        Me.lblNumberofPiecesToReturn.AutoSize = True
        Me.lblNumberofPiecesToReturn.Location = New System.Drawing.Point(12, 206)
        Me.lblNumberofPiecesToReturn.Name = "lblNumberofPiecesToReturn"
        Me.lblNumberofPiecesToReturn.Size = New System.Drawing.Size(132, 13)
        Me.lblNumberofPiecesToReturn.TabIndex = 9
        Me.lblNumberofPiecesToReturn.Tag = "Number_of_Pieces_to_return"
        Me.lblNumberofPiecesToReturn.Text = "Number of pieces to return"
        '
        'nudN
        '
        Me.nudN.Location = New System.Drawing.Point(280, 199)
        Me.nudN.Name = "nudN"
        Me.nudN.Size = New System.Drawing.Size(120, 20)
        Me.nudN.TabIndex = 10
        '
        'ucrInputColumnsIntoText
        '
        Me.ucrInputColumnsIntoText.Location = New System.Drawing.Point(259, 225)
        Me.ucrInputColumnsIntoText.Name = "ucrInputColumnsIntoText"
        Me.ucrInputColumnsIntoText.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputColumnsIntoText.TabIndex = 11
        '
        'dlgSplitText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 315)
        Me.Controls.Add(Me.ucrInputColumnsIntoText)
        Me.Controls.Add(Me.nudN)
        Me.Controls.Add(Me.lblNumberofPiecesToReturn)
        Me.Controls.Add(Me.ucrReceiverSplitTextColumn)
        Me.Controls.Add(Me.lblNewColumnName)
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
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents ucrReceiverSplitTextColumn As ucrReceiverMultiple
    Friend WithEvents lblNumberofPiecesToReturn As Label
    Friend WithEvents nudN As NumericUpDown
    Friend WithEvents ucrInputColumnsIntoText As ucrInputTextBox
End Class