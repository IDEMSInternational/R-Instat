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
        Me.lblSelectedFactor = New System.Windows.Forms.Label()
        Me.cboPattern = New System.Windows.Forms.ComboBox()
        Me.lblPattern = New System.Windows.Forms.Label()
        Me.lblNewColumnNames = New System.Windows.Forms.Label()
        Me.lblNumberofPiecesToReturn = New System.Windows.Forms.Label()
        Me.nudN = New System.Windows.Forms.NumericUpDown()
        Me.ucrReceiverSplitTextColumn = New instat.ucrReceiverSingle()
        Me.ucrInputColumnsIntoText = New instat.ucrInputComboBox()
        Me.ucrSelectorSplitTextColumn = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.nudN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelectedFactor
        '
        Me.lblSelectedFactor.AutoSize = True
        Me.lblSelectedFactor.Location = New System.Drawing.Point(260, 13)
        Me.lblSelectedFactor.Name = "lblSelectedFactor"
        Me.lblSelectedFactor.Size = New System.Drawing.Size(82, 13)
        Me.lblSelectedFactor.TabIndex = 3
        Me.lblSelectedFactor.Tag = "Selected_Factor"
        Me.lblSelectedFactor.Text = "Selected Factor"
        '
        'cboPattern
        '
        Me.cboPattern.FormattingEnabled = True
        Me.cboPattern.Items.AddRange(New Object() {"Whitespace", "Hyphen", "Period", "Underscore"})
        Me.cboPattern.Location = New System.Drawing.Point(263, 75)
        Me.cboPattern.Name = "cboPattern"
        Me.cboPattern.Size = New System.Drawing.Size(120, 21)
        Me.cboPattern.TabIndex = 4
        '
        'lblPattern
        '
        Me.lblPattern.AutoSize = True
        Me.lblPattern.Location = New System.Drawing.Point(260, 59)
        Me.lblPattern.Name = "lblPattern"
        Me.lblPattern.Size = New System.Drawing.Size(41, 13)
        Me.lblPattern.TabIndex = 5
        Me.lblPattern.Tag = "Pattern"
        Me.lblPattern.Text = "Pattern"
        '
        'lblNewColumnNames
        '
        Me.lblNewColumnNames.AutoSize = True
        Me.lblNewColumnNames.Location = New System.Drawing.Point(12, 194)
        Me.lblNewColumnNames.Name = "lblNewColumnNames"
        Me.lblNewColumnNames.Size = New System.Drawing.Size(116, 13)
        Me.lblNewColumnNames.TabIndex = 6
        Me.lblNewColumnNames.Tag = ""
        Me.lblNewColumnNames.Text = "Prefix for New Columns"
        '
        'lblNumberofPiecesToReturn
        '
        Me.lblNumberofPiecesToReturn.AutoSize = True
        Me.lblNumberofPiecesToReturn.Location = New System.Drawing.Point(260, 99)
        Me.lblNumberofPiecesToReturn.Name = "lblNumberofPiecesToReturn"
        Me.lblNumberofPiecesToReturn.Size = New System.Drawing.Size(138, 13)
        Me.lblNumberofPiecesToReturn.TabIndex = 9
        Me.lblNumberofPiecesToReturn.Tag = "Number_of_Pieces_to_Return"
        Me.lblNumberofPiecesToReturn.Text = "Number of Pieces to Return"
        '
        'nudN
        '
        Me.nudN.Location = New System.Drawing.Point(263, 115)
        Me.nudN.Name = "nudN"
        Me.nudN.Size = New System.Drawing.Size(120, 20)
        Me.nudN.TabIndex = 10
        '
        'ucrReceiverSplitTextColumn
        '
        Me.ucrReceiverSplitTextColumn.Location = New System.Drawing.Point(263, 30)
        Me.ucrReceiverSplitTextColumn.Name = "ucrReceiverSplitTextColumn"
        Me.ucrReceiverSplitTextColumn.Selector = Nothing
        Me.ucrReceiverSplitTextColumn.Size = New System.Drawing.Size(120, 26)
        Me.ucrReceiverSplitTextColumn.TabIndex = 12
        '
        'ucrInputColumnsIntoText
        '
        Me.ucrInputColumnsIntoText.Location = New System.Drawing.Point(181, 188)
        Me.ucrInputColumnsIntoText.Name = "ucrInputColumnsIntoText"
        Me.ucrInputColumnsIntoText.Size = New System.Drawing.Size(137, 25)
        Me.ucrInputColumnsIntoText.TabIndex = 11
        '
        'ucrSelectorSplitTextColumn
        '
        Me.ucrSelectorSplitTextColumn.Location = New System.Drawing.Point(12, 13)
        Me.ucrSelectorSplitTextColumn.lstVariablesInReceivers = CType(resources.GetObject("ucrSelectorSplitTextColumn.lstVariablesInReceivers"), System.Collections.Generic.List(Of String))
        Me.ucrSelectorSplitTextColumn.Name = "ucrSelectorSplitTextColumn"
        Me.ucrSelectorSplitTextColumn.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorSplitTextColumn.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 214)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'dlgSplitText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 277)
        Me.Controls.Add(Me.ucrReceiverSplitTextColumn)
        Me.Controls.Add(Me.ucrInputColumnsIntoText)
        Me.Controls.Add(Me.nudN)
        Me.Controls.Add(Me.lblNumberofPiecesToReturn)
        Me.Controls.Add(Me.lblNewColumnNames)
        Me.Controls.Add(Me.lblPattern)
        Me.Controls.Add(Me.cboPattern)
        Me.Controls.Add(Me.lblSelectedFactor)
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
    Friend WithEvents lblSelectedFactor As Label
    Friend WithEvents cboPattern As ComboBox
    Friend WithEvents lblPattern As Label
    Friend WithEvents lblNewColumnNames As Label
    Friend WithEvents lblNumberofPiecesToReturn As Label
    Friend WithEvents nudN As NumericUpDown
    Friend WithEvents ucrInputColumnsIntoText As ucrInputComboBox
    Friend WithEvents ucrReceiverSplitTextColumn As ucrReceiverSingle
End Class