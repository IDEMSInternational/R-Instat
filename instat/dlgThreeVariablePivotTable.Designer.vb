<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgThreeVariablePivotTable
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
        Me.components = New System.ComponentModel.Container()
        Me.lblAdditionalRowFactor = New System.Windows.Forms.Label()
        Me.lblInitialColumnFactor = New System.Windows.Forms.Label()
        Me.lblInitialRowFactor = New System.Windows.Forms.Label()
        Me.ttSelectedVariable = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblTableChart = New System.Windows.Forms.Label()
        Me.ucrInputTableChart = New instat.ucrInputComboBox()
        Me.ucrReceiverInitialRowFactors = New instat.ucrReceiverMultiple()
        Me.ucrReceiverAdditionalRowFactor = New instat.ucrReceiverSingle()
        Me.ucrSavePivot = New instat.ucrSave()
        Me.ucrChkIncludeSubTotals = New instat.ucrCheck()
        Me.ucrReceiverSelectedVariable = New instat.ucrReceiverMultiple()
        Me.ucrChkSelectedVariable = New instat.ucrCheck()
        Me.ucrReceiverInitialColumnFactor = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorPivot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputSummary = New instat.ucrInputComboBox()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAdditionalRowFactor
        '
        Me.lblAdditionalRowFactor.AutoSize = True
        Me.lblAdditionalRowFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAdditionalRowFactor.Location = New System.Drawing.Point(258, 187)
        Me.lblAdditionalRowFactor.Name = "lblAdditionalRowFactor"
        Me.lblAdditionalRowFactor.Size = New System.Drawing.Size(51, 13)
        Me.lblAdditionalRowFactor.TabIndex = 60
        Me.lblAdditionalRowFactor.Tag = "Initial Column Factor:"
        Me.lblAdditionalRowFactor.Text = "Variable :"
        '
        'lblInitialColumnFactor
        '
        Me.lblInitialColumnFactor.AutoSize = True
        Me.lblInitialColumnFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInitialColumnFactor.Location = New System.Drawing.Point(260, 142)
        Me.lblInitialColumnFactor.Name = "lblInitialColumnFactor"
        Me.lblInitialColumnFactor.Size = New System.Drawing.Size(105, 13)
        Me.lblInitialColumnFactor.TabIndex = 54
        Me.lblInitialColumnFactor.Tag = "Initial Column Factor:"
        Me.lblInitialColumnFactor.Text = "Initial Column Factor:"
        '
        'lblInitialRowFactor
        '
        Me.lblInitialRowFactor.AutoSize = True
        Me.lblInitialRowFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInitialRowFactor.Location = New System.Drawing.Point(260, 42)
        Me.lblInitialRowFactor.Name = "lblInitialRowFactor"
        Me.lblInitialRowFactor.Size = New System.Drawing.Size(106, 13)
        Me.lblInitialRowFactor.TabIndex = 52
        Me.lblInitialRowFactor.Tag = "Initial Row Factor:"
        Me.lblInitialRowFactor.Text = "Initial Row Factor(s) :"
        '
        'lblTableChart
        '
        Me.lblTableChart.AutoSize = True
        Me.lblTableChart.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTableChart.Location = New System.Drawing.Point(6, 233)
        Me.lblTableChart.Name = "lblTableChart"
        Me.lblTableChart.Size = New System.Drawing.Size(73, 13)
        Me.lblTableChart.TabIndex = 63
        Me.lblTableChart.Text = "Table/Chart  :"
        '
        'ucrInputTableChart
        '
        Me.ucrInputTableChart.AddQuotesIfUnrecognised = True
        Me.ucrInputTableChart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputTableChart.GetSetSelectedIndex = -1
        Me.ucrInputTableChart.IsReadOnly = False
        Me.ucrInputTableChart.Location = New System.Drawing.Point(78, 227)
        Me.ucrInputTableChart.Name = "ucrInputTableChart"
        Me.ucrInputTableChart.Size = New System.Drawing.Size(104, 21)
        Me.ucrInputTableChart.TabIndex = 64
        '
        'ucrReceiverInitialRowFactors
        '
        Me.ucrReceiverInitialRowFactors.AutoSize = True
        Me.ucrReceiverInitialRowFactors.frmParent = Me
        Me.ucrReceiverInitialRowFactors.Location = New System.Drawing.Point(260, 55)
        Me.ucrReceiverInitialRowFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverInitialRowFactors.Name = "ucrReceiverInitialRowFactors"
        Me.ucrReceiverInitialRowFactors.Selector = Nothing
        Me.ucrReceiverInitialRowFactors.Size = New System.Drawing.Size(120, 77)
        Me.ucrReceiverInitialRowFactors.strNcFilePath = ""
        Me.ucrReceiverInitialRowFactors.TabIndex = 62
        Me.ucrReceiverInitialRowFactors.ucrSelector = Nothing
        '
        'ucrReceiverAdditionalRowFactor
        '
        Me.ucrReceiverAdditionalRowFactor.AutoSize = True
        Me.ucrReceiverAdditionalRowFactor.frmParent = Me
        Me.ucrReceiverAdditionalRowFactor.Location = New System.Drawing.Point(260, 201)
        Me.ucrReceiverAdditionalRowFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAdditionalRowFactor.Name = "ucrReceiverAdditionalRowFactor"
        Me.ucrReceiverAdditionalRowFactor.Selector = Nothing
        Me.ucrReceiverAdditionalRowFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverAdditionalRowFactor.strNcFilePath = ""
        Me.ucrReceiverAdditionalRowFactor.TabIndex = 61
        Me.ucrReceiverAdditionalRowFactor.ucrSelector = Nothing
        '
        'ucrSavePivot
        '
        Me.ucrSavePivot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSavePivot.Location = New System.Drawing.Point(9, 361)
        Me.ucrSavePivot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSavePivot.Name = "ucrSavePivot"
        Me.ucrSavePivot.Size = New System.Drawing.Size(382, 23)
        Me.ucrSavePivot.TabIndex = 59
        '
        'ucrChkIncludeSubTotals
        '
        Me.ucrChkIncludeSubTotals.AutoSize = True
        Me.ucrChkIncludeSubTotals.Checked = False
        Me.ucrChkIncludeSubTotals.Location = New System.Drawing.Point(9, 194)
        Me.ucrChkIncludeSubTotals.Name = "ucrChkIncludeSubTotals"
        Me.ucrChkIncludeSubTotals.Size = New System.Drawing.Size(167, 23)
        Me.ucrChkIncludeSubTotals.TabIndex = 58
        '
        'ucrReceiverSelectedVariable
        '
        Me.ucrReceiverSelectedVariable.AutoSize = True
        Me.ucrReceiverSelectedVariable.frmParent = Me
        Me.ucrReceiverSelectedVariable.Location = New System.Drawing.Point(260, 253)
        Me.ucrReceiverSelectedVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelectedVariable.Name = "ucrReceiverSelectedVariable"
        Me.ucrReceiverSelectedVariable.Selector = Nothing
        Me.ucrReceiverSelectedVariable.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverSelectedVariable.strNcFilePath = ""
        Me.ucrReceiverSelectedVariable.TabIndex = 57
        Me.ucrReceiverSelectedVariable.ucrSelector = Nothing
        '
        'ucrChkSelectedVariable
        '
        Me.ucrChkSelectedVariable.AutoSize = True
        Me.ucrChkSelectedVariable.Checked = False
        Me.ucrChkSelectedVariable.Location = New System.Drawing.Point(260, 233)
        Me.ucrChkSelectedVariable.Name = "ucrChkSelectedVariable"
        Me.ucrChkSelectedVariable.Size = New System.Drawing.Size(135, 23)
        Me.ucrChkSelectedVariable.TabIndex = 56
        '
        'ucrReceiverInitialColumnFactor
        '
        Me.ucrReceiverInitialColumnFactor.AutoSize = True
        Me.ucrReceiverInitialColumnFactor.frmParent = Me
        Me.ucrReceiverInitialColumnFactor.Location = New System.Drawing.Point(260, 157)
        Me.ucrReceiverInitialColumnFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverInitialColumnFactor.Name = "ucrReceiverInitialColumnFactor"
        Me.ucrReceiverInitialColumnFactor.Selector = Nothing
        Me.ucrReceiverInitialColumnFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverInitialColumnFactor.strNcFilePath = ""
        Me.ucrReceiverInitialColumnFactor.TabIndex = 55
        Me.ucrReceiverInitialColumnFactor.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 392)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 51
        '
        'ucrSelectorPivot
        '
        Me.ucrSelectorPivot.AutoSize = True
        Me.ucrSelectorPivot.bDropUnusedFilterLevels = False
        Me.ucrSelectorPivot.bShowHiddenColumns = False
        Me.ucrSelectorPivot.bUseCurrentFilter = True
        Me.ucrSelectorPivot.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorPivot.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorPivot.Name = "ucrSelectorPivot"
        Me.ucrSelectorPivot.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorPivot.TabIndex = 50
        '
        'ucrInputSummary
        '
        Me.ucrInputSummary.AddQuotesIfUnrecognised = True
        Me.ucrInputSummary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSummary.GetSetSelectedIndex = -1
        Me.ucrInputSummary.IsReadOnly = False
        Me.ucrInputSummary.Location = New System.Drawing.Point(78, 262)
        Me.ucrInputSummary.Name = "ucrInputSummary"
        Me.ucrInputSummary.Size = New System.Drawing.Size(104, 21)
        Me.ucrInputSummary.TabIndex = 66
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummary.Location = New System.Drawing.Point(6, 265)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(59, 13)
        Me.lblSummary.TabIndex = 65
        Me.lblSummary.Text = "Summary : "
        '
        'dlgThreeVariablePivotTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(417, 456)
        Me.Controls.Add(Me.ucrInputSummary)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.ucrInputTableChart)
        Me.Controls.Add(Me.lblTableChart)
        Me.Controls.Add(Me.ucrReceiverInitialRowFactors)
        Me.Controls.Add(Me.lblAdditionalRowFactor)
        Me.Controls.Add(Me.lblInitialColumnFactor)
        Me.Controls.Add(Me.lblInitialRowFactor)
        Me.Controls.Add(Me.ucrReceiverAdditionalRowFactor)
        Me.Controls.Add(Me.ucrSavePivot)
        Me.Controls.Add(Me.ucrChkIncludeSubTotals)
        Me.Controls.Add(Me.ucrReceiverSelectedVariable)
        Me.Controls.Add(Me.ucrChkSelectedVariable)
        Me.Controls.Add(Me.ucrReceiverInitialColumnFactor)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorPivot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgThreeVariablePivotTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pivot Table"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAdditionalRowFactor As Label
    Friend WithEvents lblInitialColumnFactor As Label
    Friend WithEvents lblInitialRowFactor As Label
    Friend WithEvents ttSelectedVariable As ToolTip
    Friend WithEvents ucrReceiverAdditionalRowFactor As ucrReceiverSingle
    Friend WithEvents ucrSavePivot As ucrSave
    Friend WithEvents ucrChkIncludeSubTotals As ucrCheck
    Friend WithEvents ucrReceiverSelectedVariable As ucrReceiverMultiple
    Friend WithEvents ucrChkSelectedVariable As ucrCheck
    Friend WithEvents ucrReceiverInitialColumnFactor As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorPivot As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverInitialRowFactors As ucrReceiverMultiple
    Friend WithEvents ucrInputTableChart As ucrInputComboBox
    Friend WithEvents lblTableChart As Label
    Friend WithEvents ucrInputSummary As ucrInputComboBox
    Friend WithEvents lblSummary As Label
End Class
