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
        resources.ApplyResources(Me.lblSelectedFactor, "lblSelectedFactor")
        Me.lblSelectedFactor.Name = "lblSelectedFactor"
        Me.lblSelectedFactor.Tag = "Selected_Factor"
        '
        'lblSplitBy
        '
        resources.ApplyResources(Me.lblSplitBy, "lblSplitBy")
        Me.lblSplitBy.Name = "lblSplitBy"
        Me.lblSplitBy.Tag = ""
        '
        'lblNewColumnNames
        '
        resources.ApplyResources(Me.lblNewColumnNames, "lblNewColumnNames")
        Me.lblNewColumnNames.Name = "lblNewColumnNames"
        Me.lblNewColumnNames.Tag = ""
        '
        'lblNumberofPiecesToReturn
        '
        resources.ApplyResources(Me.lblNumberofPiecesToReturn, "lblNumberofPiecesToReturn")
        Me.lblNumberofPiecesToReturn.Name = "lblNumberofPiecesToReturn"
        Me.lblNumberofPiecesToReturn.Tag = "Number_of_Pieces_to_Return"
        '
        'nudN
        '
        resources.ApplyResources(Me.nudN, "nudN")
        Me.nudN.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudN.Name = "nudN"
        Me.nudN.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrInputPattern
        '
        Me.ucrInputPattern.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPattern, "ucrInputPattern")
        Me.ucrInputPattern.Name = "ucrInputPattern"
        '
        'ucrReceiverSplitTextColumn
        '
        resources.ApplyResources(Me.ucrReceiverSplitTextColumn, "ucrReceiverSplitTextColumn")
        Me.ucrReceiverSplitTextColumn.Name = "ucrReceiverSplitTextColumn"
        Me.ucrReceiverSplitTextColumn.Selector = Nothing
        '
        'ucrInputColumnsIntoText
        '
        Me.ucrInputColumnsIntoText.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputColumnsIntoText, "ucrInputColumnsIntoText")
        Me.ucrInputColumnsIntoText.Name = "ucrInputColumnsIntoText"
        '
        'ucrSelectorSplitTextColumn
        '
        Me.ucrSelectorSplitTextColumn.bShowHiddenColumns = False
        Me.ucrSelectorSplitTextColumn.bUseCurrentFilter = False
        resources.ApplyResources(Me.ucrSelectorSplitTextColumn, "ucrSelectorSplitTextColumn")
        Me.ucrSelectorSplitTextColumn.Name = "ucrSelectorSplitTextColumn"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgSplitText
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.PerformLayout()

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