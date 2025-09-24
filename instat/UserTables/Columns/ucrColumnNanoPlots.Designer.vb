﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrColumnNanoPlots
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
        Me.ucrCboMissingValues = New instat.ucrInputComboBox()
        Me.lblMissingValue = New System.Windows.Forms.Label()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.ucrSelectorCols = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrCboPlotType = New instat.ucrInputComboBox()
        Me.ucrTxtColumnLabel = New instat.ucrInputTextBox()
        Me.lblPlotType = New System.Windows.Forms.Label()
        Me.lblNanoplots = New System.Windows.Forms.Label()
        Me.btnClearSummaries = New System.Windows.Forms.Button()
        Me.btnAddNanoplot = New System.Windows.Forms.Button()
        Me.lblSummaryLabel = New System.Windows.Forms.Label()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.colExpression = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ucrNudPlotHeight = New instat.ucrNud()
        Me.lblPlotHeight = New System.Windows.Forms.Label()
        Me.ucrChkAutoHideCols = New instat.ucrCheck()
        Me.ucrReceiverSingleCol = New instat.ucrReceiverSingle()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrCboMissingValues
        '
        Me.ucrCboMissingValues.AddQuotesIfUnrecognised = True
        Me.ucrCboMissingValues.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboMissingValues.GetSetSelectedIndex = -1
        Me.ucrCboMissingValues.IsReadOnly = False
        Me.ucrCboMissingValues.Location = New System.Drawing.Point(508, 70)
        Me.ucrCboMissingValues.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrCboMissingValues.Name = "ucrCboMissingValues"
        Me.ucrCboMissingValues.Size = New System.Drawing.Size(117, 26)
        Me.ucrCboMissingValues.TabIndex = 390
        '
        'lblMissingValue
        '
        Me.lblMissingValue.AutoSize = True
        Me.lblMissingValue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMissingValue.Location = New System.Drawing.Point(509, 56)
        Me.lblMissingValue.Name = "lblMissingValue"
        Me.lblMissingValue.Size = New System.Drawing.Size(90, 13)
        Me.lblMissingValue.TabIndex = 389
        Me.lblMissingValue.Text = "Replace NA with:"
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(244, 12)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(56, 13)
        Me.lblColumns.TabIndex = 387
        Me.lblColumns.Text = "Column(s):"
        '
        'ucrSelectorCols
        '
        Me.ucrSelectorCols.AutoSize = True
        Me.ucrSelectorCols.bDropUnusedFilterLevels = False
        Me.ucrSelectorCols.bShowHiddenColumns = False
        Me.ucrSelectorCols.bUseCurrentFilter = True
        Me.ucrSelectorCols.Location = New System.Drawing.Point(9, 8)
        Me.ucrSelectorCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCols.Name = "ucrSelectorCols"
        Me.ucrSelectorCols.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorCols.TabIndex = 386
        '
        'ucrCboPlotType
        '
        Me.ucrCboPlotType.AddQuotesIfUnrecognised = True
        Me.ucrCboPlotType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboPlotType.GetSetSelectedIndex = -1
        Me.ucrCboPlotType.IsReadOnly = False
        Me.ucrCboPlotType.Location = New System.Drawing.Point(242, 70)
        Me.ucrCboPlotType.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrCboPlotType.Name = "ucrCboPlotType"
        Me.ucrCboPlotType.Size = New System.Drawing.Size(117, 26)
        Me.ucrCboPlotType.TabIndex = 382
        '
        'ucrTxtColumnLabel
        '
        Me.ucrTxtColumnLabel.AddQuotesIfUnrecognised = True
        Me.ucrTxtColumnLabel.AutoSize = True
        Me.ucrTxtColumnLabel.IsMultiline = False
        Me.ucrTxtColumnLabel.IsReadOnly = False
        Me.ucrTxtColumnLabel.Location = New System.Drawing.Point(374, 71)
        Me.ucrTxtColumnLabel.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrTxtColumnLabel.Name = "ucrTxtColumnLabel"
        Me.ucrTxtColumnLabel.Size = New System.Drawing.Size(120, 21)
        Me.ucrTxtColumnLabel.TabIndex = 381
        '
        'lblPlotType
        '
        Me.lblPlotType.AutoSize = True
        Me.lblPlotType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPlotType.Location = New System.Drawing.Point(240, 55)
        Me.lblPlotType.Name = "lblPlotType"
        Me.lblPlotType.Size = New System.Drawing.Size(55, 13)
        Me.lblPlotType.TabIndex = 379
        Me.lblPlotType.Text = "Plot Type:"
        '
        'lblNanoplots
        '
        Me.lblNanoplots.AutoSize = True
        Me.lblNanoplots.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNanoplots.Location = New System.Drawing.Point(245, 188)
        Me.lblNanoplots.Name = "lblNanoplots"
        Me.lblNanoplots.Size = New System.Drawing.Size(58, 13)
        Me.lblNanoplots.TabIndex = 378
        Me.lblNanoplots.Text = "Nanoplots:"
        '
        'btnClearSummaries
        '
        Me.btnClearSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearSummaries.Location = New System.Drawing.Point(509, 178)
        Me.btnClearSummaries.Name = "btnClearSummaries"
        Me.btnClearSummaries.Size = New System.Drawing.Size(79, 23)
        Me.btnClearSummaries.TabIndex = 377
        Me.btnClearSummaries.Tag = ""
        Me.btnClearSummaries.Text = "Clear"
        Me.btnClearSummaries.UseVisualStyleBackColor = True
        '
        'btnAddNanoplot
        '
        Me.btnAddNanoplot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAddNanoplot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddNanoplot.Location = New System.Drawing.Point(243, 154)
        Me.btnAddNanoplot.Name = "btnAddNanoplot"
        Me.btnAddNanoplot.Size = New System.Drawing.Size(96, 23)
        Me.btnAddNanoplot.TabIndex = 376
        Me.btnAddNanoplot.Tag = ""
        Me.btnAddNanoplot.Text = "Add"
        Me.btnAddNanoplot.UseVisualStyleBackColor = True
        '
        'lblSummaryLabel
        '
        Me.lblSummaryLabel.AutoSize = True
        Me.lblSummaryLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummaryLabel.Location = New System.Drawing.Point(371, 55)
        Me.lblSummaryLabel.Name = "lblSummaryLabel"
        Me.lblSummaryLabel.Size = New System.Drawing.Size(74, 13)
        Me.lblSummaryLabel.TabIndex = 380
        Me.lblSummaryLabel.Text = "Column Label:"
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colExpression})
        Me.dataGrid.Location = New System.Drawing.Point(243, 204)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.ReadOnly = True
        Me.dataGrid.RowHeadersWidth = 62
        Me.dataGrid.Size = New System.Drawing.Size(348, 91)
        Me.dataGrid.TabIndex = 375
        '
        'colExpression
        '
        Me.colExpression.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colExpression.HeaderText = "Nanoplot Expression"
        Me.colExpression.MinimumWidth = 8
        Me.colExpression.Name = "colExpression"
        Me.colExpression.ReadOnly = True
        '
        'ucrNudPlotHeight
        '
        Me.ucrNudPlotHeight.AutoSize = True
        Me.ucrNudPlotHeight.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPlotHeight.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPlotHeight.Location = New System.Drawing.Point(243, 118)
        Me.ucrNudPlotHeight.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPlotHeight.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPlotHeight.Name = "ucrNudPlotHeight"
        Me.ucrNudPlotHeight.Size = New System.Drawing.Size(58, 21)
        Me.ucrNudPlotHeight.TabIndex = 391
        Me.ucrNudPlotHeight.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblPlotHeight
        '
        Me.lblPlotHeight.AutoSize = True
        Me.lblPlotHeight.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPlotHeight.Location = New System.Drawing.Point(240, 101)
        Me.lblPlotHeight.Name = "lblPlotHeight"
        Me.lblPlotHeight.Size = New System.Drawing.Size(62, 13)
        Me.lblPlotHeight.TabIndex = 392
        Me.lblPlotHeight.Text = "Plot Height:"
        '
        'ucrChkAutoHideCols
        '
        Me.ucrChkAutoHideCols.AutoSize = True
        Me.ucrChkAutoHideCols.Checked = False
        Me.ucrChkAutoHideCols.Location = New System.Drawing.Point(375, 116)
        Me.ucrChkAutoHideCols.Name = "ucrChkAutoHideCols"
        Me.ucrChkAutoHideCols.Size = New System.Drawing.Size(251, 23)
        Me.ucrChkAutoHideCols.TabIndex = 393
        '
        'ucrReceiverSingleCol
        '
        Me.ucrReceiverSingleCol.AutoSize = True
        Me.ucrReceiverSingleCol.frmParent = Nothing
        Me.ucrReceiverSingleCol.Location = New System.Drawing.Point(243, 25)
        Me.ucrReceiverSingleCol.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingleCol.Name = "ucrReceiverSingleCol"
        Me.ucrReceiverSingleCol.Selector = Nothing
        Me.ucrReceiverSingleCol.Size = New System.Drawing.Size(120, 21)
        Me.ucrReceiverSingleCol.strNcFilePath = ""
        Me.ucrReceiverSingleCol.TabIndex = 394
        Me.ucrReceiverSingleCol.ucrSelector = Nothing
        '
        'ucrColumnNanoPlots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrReceiverSingleCol)
        Me.Controls.Add(Me.ucrChkAutoHideCols)
        Me.Controls.Add(Me.lblPlotHeight)
        Me.Controls.Add(Me.ucrNudPlotHeight)
        Me.Controls.Add(Me.ucrCboMissingValues)
        Me.Controls.Add(Me.lblMissingValue)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.ucrSelectorCols)
        Me.Controls.Add(Me.ucrCboPlotType)
        Me.Controls.Add(Me.ucrTxtColumnLabel)
        Me.Controls.Add(Me.lblPlotType)
        Me.Controls.Add(Me.lblNanoplots)
        Me.Controls.Add(Me.btnClearSummaries)
        Me.Controls.Add(Me.btnAddNanoplot)
        Me.Controls.Add(Me.lblSummaryLabel)
        Me.Controls.Add(Me.dataGrid)
        Me.Name = "ucrColumnNanoPlots"
        Me.Size = New System.Drawing.Size(637, 309)
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrCboMissingValues As ucrInputComboBox
    Friend WithEvents lblMissingValue As Label
    Friend WithEvents lblColumns As Label
    Friend WithEvents ucrSelectorCols As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrCboPlotType As ucrInputComboBox
    Friend WithEvents ucrTxtColumnLabel As ucrInputTextBox
    Friend WithEvents lblPlotType As Label
    Friend WithEvents lblNanoplots As Label
    Friend WithEvents btnClearSummaries As Button
    Friend WithEvents btnAddNanoplot As Button
    Friend WithEvents lblSummaryLabel As Label
    Friend WithEvents dataGrid As DataGridView
    Friend WithEvents colExpression As DataGridViewTextBoxColumn
    Friend WithEvents ucrNudPlotHeight As ucrNud
    Friend WithEvents lblPlotHeight As Label
    Friend WithEvents ucrChkAutoHideCols As ucrCheck
    Friend WithEvents ucrReceiverSingleCol As ucrReceiverSingle
End Class
