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
        Me.lblSelectedFactor = New System.Windows.Forms.Label()
        Me.lblSplitBy = New System.Windows.Forms.Label()
        Me.lblNewColumnNames = New System.Windows.Forms.Label()
        Me.lblNumberofPiecesToReturn = New System.Windows.Forms.Label()
        Me.nudN = New System.Windows.Forms.NumericUpDown()
        Me.ucrInputPattern = New instat.ucrInputComboBox()
        Me.ucrReceiverSplitTextColumn = New instat.ucrReceiverSingle()
        Me.ucrInputColumnsIntoText = New instat.ucrInputComboBox()
        Me.ucrSelectorSplitTextColumn = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.nudN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelectedFactor
        '
        Me.lblSelectedFactor.Location = New System.Drawing.Point(275, 43)
        Me.lblSelectedFactor.Name = "lblSelectedFactor"
        Me.lblSelectedFactor.Size = New System.Drawing.Size(140, 23)
        Me.lblSelectedFactor.TabIndex = 7
        Me.lblSelectedFactor.Tag = "Selected_Factor"
        Me.lblSelectedFactor.Text = "Selected Factor:"
        '
        'lblSplitBy
        '
        Me.lblSplitBy.Location = New System.Drawing.Point(275, 90)
        Me.lblSplitBy.Name = "lblSplitBy"
        Me.lblSplitBy.Size = New System.Drawing.Size(140, 23)
        Me.lblSplitBy.TabIndex = 6
        Me.lblSplitBy.Tag = ""
        Me.lblSplitBy.Text = "Split by:"
        '
        'lblNewColumnNames
        '
        Me.lblNewColumnNames.Location = New System.Drawing.Point(10, 202)
        Me.lblNewColumnNames.Name = "lblNewColumnNames"
        Me.lblNewColumnNames.Size = New System.Drawing.Size(161, 23)
        Me.lblNewColumnNames.TabIndex = 5
        Me.lblNewColumnNames.Tag = ""
        Me.lblNewColumnNames.Text = "Prefix for New Columns:"
        '
        'lblNumberofPiecesToReturn
        '
        Me.lblNumberofPiecesToReturn.Location = New System.Drawing.Point(273, 140)
        Me.lblNumberofPiecesToReturn.Name = "lblNumberofPiecesToReturn"
        Me.lblNumberofPiecesToReturn.Size = New System.Drawing.Size(149, 23)
        Me.lblNumberofPiecesToReturn.TabIndex = 4
        Me.lblNumberofPiecesToReturn.Tag = "Number_of_Pieces_to_Return"
        Me.lblNumberofPiecesToReturn.Text = "Number of Pieces to Return:"
        '
        'nudN
        '
        Me.nudN.Location = New System.Drawing.Point(276, 157)
        Me.nudN.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudN.Name = "nudN"
        Me.nudN.Size = New System.Drawing.Size(37, 20)
        Me.nudN.TabIndex = 3
        Me.nudN.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrInputPattern
        '
        Me.ucrInputPattern.IsReadOnly = False
        Me.ucrInputPattern.Location = New System.Drawing.Point(276, 60)
        Me.ucrInputPattern.Name = "ucrInputPattern"
        Me.ucrInputPattern.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPattern.TabIndex = 0
        '
        'ucrReceiverSplitTextColumn
        '
        Me.ucrReceiverSplitTextColumn.Location = New System.Drawing.Point(276, 106)
        Me.ucrReceiverSplitTextColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSplitTextColumn.Name = "ucrReceiverSplitTextColumn"
        Me.ucrReceiverSplitTextColumn.Selector = Nothing
        Me.ucrReceiverSplitTextColumn.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverSplitTextColumn.TabIndex = 1
        '
        'ucrInputColumnsIntoText
        '
        Me.ucrInputColumnsIntoText.IsReadOnly = False
        Me.ucrInputColumnsIntoText.Location = New System.Drawing.Point(131, 200)
        Me.ucrInputColumnsIntoText.Name = "ucrInputColumnsIntoText"
        Me.ucrInputColumnsIntoText.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputColumnsIntoText.TabIndex = 2
        '
        'ucrSelectorSplitTextColumn
        '
        Me.ucrSelectorSplitTextColumn.bShowHiddenColumns = False
        Me.ucrSelectorSplitTextColumn.bUseCurrentFilter = False
        Me.ucrSelectorSplitTextColumn.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorSplitTextColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSplitTextColumn.Name = "ucrSelectorSplitTextColumn"
        Me.ucrSelectorSplitTextColumn.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorSplitTextColumn.TabIndex = 8
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 230)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 9
        '
        'dlgSplitText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 288)
        Me.Controls.Add(Me.ucrInputPattern)
        Me.Controls.Add(Me.ucrReceiverSplitTextColumn)
        Me.Controls.Add(Me.ucrInputColumnsIntoText)
        Me.Controls.Add(Me.nudN)
        Me.Controls.Add(Me.lblNumberofPiecesToReturn)
        Me.Controls.Add(Me.lblNewColumnNames)
        Me.Controls.Add(Me.lblSplitBy)
        Me.Controls.Add(Me.lblSelectedFactor)
        Me.Controls.Add(Me.ucrSelectorSplitTextColumn)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSplitText"
        Me.Tag = "Split_Text_Column"
        CType(Me.nudN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorSplitTextColumn As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblSelectedFactor As Label
    Friend WithEvents lblSplitBy As Label
    Friend WithEvents lblNewColumnNames As Label
    Friend WithEvents lblNumberofPiecesToReturn As Label
    Friend WithEvents nudN As NumericUpDown
    Friend WithEvents ucrInputColumnsIntoText As ucrInputComboBox
    Friend WithEvents ucrReceiverSplitTextColumn As ucrReceiverSingle
    Friend WithEvents ucrInputPattern As ucrInputComboBox
End Class