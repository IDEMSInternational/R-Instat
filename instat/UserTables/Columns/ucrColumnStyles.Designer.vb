﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrColumnStyles
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
        Me.lblFormats = New System.Windows.Forms.Label()
        Me.btnClearFormats = New System.Windows.Forms.Button()
        Me.dataGridFormats = New System.Windows.Forms.DataGridView()
        Me.colStyles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ucrReceiverMultipleCols = New instat.ucrReceiverMultiple()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnterStyle = New System.Windows.Forms.Button()
        Me.ucrSelectorCols = New instat.ucrSelectorByDataFrameAddRemove()
        CType(Me.dataGridFormats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFormats
        '
        Me.lblFormats.AutoSize = True
        Me.lblFormats.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFormats.Location = New System.Drawing.Point(234, 149)
        Me.lblFormats.Name = "lblFormats"
        Me.lblFormats.Size = New System.Drawing.Size(38, 13)
        Me.lblFormats.TabIndex = 338
        Me.lblFormats.Text = "Styles:"
        '
        'btnClearFormats
        '
        Me.btnClearFormats.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearFormats.Location = New System.Drawing.Point(473, 140)
        Me.btnClearFormats.Name = "btnClearFormats"
        Me.btnClearFormats.Size = New System.Drawing.Size(75, 23)
        Me.btnClearFormats.TabIndex = 336
        Me.btnClearFormats.Tag = ""
        Me.btnClearFormats.Text = "Clear"
        Me.btnClearFormats.UseVisualStyleBackColor = True
        '
        'dataGridFormats
        '
        Me.dataGridFormats.AllowUserToAddRows = False
        Me.dataGridFormats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridFormats.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colStyles})
        Me.dataGridFormats.Location = New System.Drawing.Point(237, 166)
        Me.dataGridFormats.Name = "dataGridFormats"
        Me.dataGridFormats.RowHeadersWidth = 62
        Me.dataGridFormats.Size = New System.Drawing.Size(315, 73)
        Me.dataGridFormats.TabIndex = 337
        '
        'colStyles
        '
        Me.colStyles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colStyles.HeaderText = "Style Expressions"
        Me.colStyles.MinimumWidth = 8
        Me.colStyles.Name = "colStyles"
        '
        'ucrReceiverMultipleCols
        '
        Me.ucrReceiverMultipleCols.AutoSize = True
        Me.ucrReceiverMultipleCols.frmParent = Nothing
        Me.ucrReceiverMultipleCols.Location = New System.Drawing.Point(234, 21)
        Me.ucrReceiverMultipleCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleCols.Name = "ucrReceiverMultipleCols"
        Me.ucrReceiverMultipleCols.Selector = Nothing
        Me.ucrReceiverMultipleCols.Size = New System.Drawing.Size(120, 80)
        Me.ucrReceiverMultipleCols.strNcFilePath = ""
        Me.ucrReceiverMultipleCols.TabIndex = 334
        Me.ucrReceiverMultipleCols.ucrSelector = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(237, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 340
        Me.Label1.Text = "Column(s):"
        '
        'btnEnterStyle
        '
        Me.btnEnterStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnEnterStyle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEnterStyle.Location = New System.Drawing.Point(237, 110)
        Me.btnEnterStyle.Name = "btnEnterStyle"
        Me.btnEnterStyle.Size = New System.Drawing.Size(126, 23)
        Me.btnEnterStyle.TabIndex = 335
        Me.btnEnterStyle.Tag = ""
        Me.btnEnterStyle.Text = "Enter Style"
        Me.btnEnterStyle.UseVisualStyleBackColor = True
        '
        'ucrSelectorCols
        '
        Me.ucrSelectorCols.AutoSize = True
        Me.ucrSelectorCols.bDropUnusedFilterLevels = False
        Me.ucrSelectorCols.bShowHiddenColumns = False
        Me.ucrSelectorCols.bUseCurrentFilter = True
        Me.ucrSelectorCols.Location = New System.Drawing.Point(5, 5)
        Me.ucrSelectorCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCols.Name = "ucrSelectorCols"
        Me.ucrSelectorCols.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorCols.TabIndex = 333
        '
        'ucrColumnStyles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblFormats)
        Me.Controls.Add(Me.btnClearFormats)
        Me.Controls.Add(Me.dataGridFormats)
        Me.Controls.Add(Me.ucrReceiverMultipleCols)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnterStyle)
        Me.Controls.Add(Me.ucrSelectorCols)
        Me.Name = "ucrColumnStyles"
        Me.Size = New System.Drawing.Size(556, 243)
        CType(Me.dataGridFormats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormats As Label
    Friend WithEvents btnClearFormats As Button
    Friend WithEvents dataGridFormats As DataGridView
    Friend WithEvents colStyles As DataGridViewTextBoxColumn
    Friend WithEvents ucrReceiverMultipleCols As ucrReceiverMultiple
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEnterStyle As Button
    Friend WithEvents ucrSelectorCols As ucrSelectorByDataFrameAddRemove
End Class
