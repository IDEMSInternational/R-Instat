<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgCompareColumns
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
        Me.lblFirstColumn = New System.Windows.Forms.Label()
        Me.lblSecondColumn = New System.Windows.Forms.Label()
        Me.grpComparisions = New System.Windows.Forms.GroupBox()
        Me.ucrChkAllValues = New instat.ucrCheck()
        Me.ucrChkUnion = New instat.ucrCheck()
        Me.ucrChkIntersection = New instat.ucrCheck()
        Me.ucrChkSecondNotFirst = New instat.ucrCheck()
        Me.ucrChkFirstNotSecond = New instat.ucrCheck()
        Me.lblTolerance = New System.Windows.Forms.Label()
        Me.rdoByValue = New System.Windows.Forms.RadioButton()
        Me.rdoByRow = New System.Windows.Forms.RadioButton()
        Me.ucrInputTolerance = New instat.ucrInputComboBox()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrSaveLogical = New instat.ucrSave()
        Me.ucrChkSort = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverSecond = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirst = New instat.ucrReceiverSingle()
        Me.ucrSelectorCompareColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkUnique = New instat.ucrCheck()
        Me.grpComparisions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFirstColumn
        '
        Me.lblFirstColumn.AutoSize = True
        Me.lblFirstColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstColumn.Location = New System.Drawing.Point(267, 83)
        Me.lblFirstColumn.Name = "lblFirstColumn"
        Me.lblFirstColumn.Size = New System.Drawing.Size(67, 13)
        Me.lblFirstColumn.TabIndex = 1
        Me.lblFirstColumn.Text = "First Column:"
        '
        'lblSecondColumn
        '
        Me.lblSecondColumn.AutoSize = True
        Me.lblSecondColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondColumn.Location = New System.Drawing.Point(267, 136)
        Me.lblSecondColumn.Name = "lblSecondColumn"
        Me.lblSecondColumn.Size = New System.Drawing.Size(85, 13)
        Me.lblSecondColumn.TabIndex = 3
        Me.lblSecondColumn.Text = "Second Column:"
        '
        'grpComparisions
        '
        Me.grpComparisions.Controls.Add(Me.ucrChkAllValues)
        Me.grpComparisions.Controls.Add(Me.ucrChkUnion)
        Me.grpComparisions.Controls.Add(Me.ucrChkIntersection)
        Me.grpComparisions.Controls.Add(Me.ucrChkSecondNotFirst)
        Me.grpComparisions.Controls.Add(Me.ucrChkFirstNotSecond)
        Me.grpComparisions.Location = New System.Drawing.Point(10, 270)
        Me.grpComparisions.Name = "grpComparisions"
        Me.grpComparisions.Size = New System.Drawing.Size(342, 154)
        Me.grpComparisions.TabIndex = 7
        Me.grpComparisions.TabStop = False
        Me.grpComparisions.Text = "Comparisons to Display:"
        '
        'ucrChkAllValues
        '
        Me.ucrChkAllValues.AutoSize = True
        Me.ucrChkAllValues.Checked = False
        Me.ucrChkAllValues.Location = New System.Drawing.Point(11, 122)
        Me.ucrChkAllValues.Name = "ucrChkAllValues"
        Me.ucrChkAllValues.Size = New System.Drawing.Size(325, 23)
        Me.ucrChkAllValues.TabIndex = 4
        '
        'ucrChkUnion
        '
        Me.ucrChkUnion.AutoSize = True
        Me.ucrChkUnion.Checked = False
        Me.ucrChkUnion.Location = New System.Drawing.Point(11, 98)
        Me.ucrChkUnion.Name = "ucrChkUnion"
        Me.ucrChkUnion.Size = New System.Drawing.Size(325, 23)
        Me.ucrChkUnion.TabIndex = 3
        '
        'ucrChkIntersection
        '
        Me.ucrChkIntersection.AutoSize = True
        Me.ucrChkIntersection.Checked = False
        Me.ucrChkIntersection.Location = New System.Drawing.Point(11, 74)
        Me.ucrChkIntersection.Name = "ucrChkIntersection"
        Me.ucrChkIntersection.Size = New System.Drawing.Size(325, 23)
        Me.ucrChkIntersection.TabIndex = 2
        '
        'ucrChkSecondNotFirst
        '
        Me.ucrChkSecondNotFirst.AutoSize = True
        Me.ucrChkSecondNotFirst.Checked = False
        Me.ucrChkSecondNotFirst.Location = New System.Drawing.Point(11, 50)
        Me.ucrChkSecondNotFirst.Name = "ucrChkSecondNotFirst"
        Me.ucrChkSecondNotFirst.Size = New System.Drawing.Size(325, 23)
        Me.ucrChkSecondNotFirst.TabIndex = 1
        '
        'ucrChkFirstNotSecond
        '
        Me.ucrChkFirstNotSecond.AutoSize = True
        Me.ucrChkFirstNotSecond.Checked = False
        Me.ucrChkFirstNotSecond.Location = New System.Drawing.Point(11, 26)
        Me.ucrChkFirstNotSecond.Name = "ucrChkFirstNotSecond"
        Me.ucrChkFirstNotSecond.Size = New System.Drawing.Size(325, 23)
        Me.ucrChkFirstNotSecond.TabIndex = 0
        '
        'lblTolerance
        '
        Me.lblTolerance.AutoSize = True
        Me.lblTolerance.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTolerance.Location = New System.Drawing.Point(267, 200)
        Me.lblTolerance.Name = "lblTolerance"
        Me.lblTolerance.Size = New System.Drawing.Size(61, 13)
        Me.lblTolerance.TabIndex = 118
        Me.lblTolerance.Text = "Tolerance: "
        '
        'rdoByValue
        '
        Me.rdoByValue.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoByValue.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByValue.FlatAppearance.BorderSize = 2
        Me.rdoByValue.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoByValue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoByValue.Location = New System.Drawing.Point(215, 13)
        Me.rdoByValue.Name = "rdoByValue"
        Me.rdoByValue.Size = New System.Drawing.Size(96, 28)
        Me.rdoByValue.TabIndex = 115
        Me.rdoByValue.TabStop = True
        Me.rdoByValue.Tag = ""
        Me.rdoByValue.Text = "By Value"
        Me.rdoByValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoByValue.UseVisualStyleBackColor = True
        '
        'rdoByRow
        '
        Me.rdoByRow.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoByRow.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByRow.FlatAppearance.BorderSize = 2
        Me.rdoByRow.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoByRow.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoByRow.Location = New System.Drawing.Point(117, 13)
        Me.rdoByRow.Name = "rdoByRow"
        Me.rdoByRow.Size = New System.Drawing.Size(98, 28)
        Me.rdoByRow.TabIndex = 116
        Me.rdoByRow.TabStop = True
        Me.rdoByRow.Tag = ""
        Me.rdoByRow.Text = "By Row"
        Me.rdoByRow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoByRow.UseVisualStyleBackColor = True
        '
        'ucrInputTolerance
        '
        Me.ucrInputTolerance.AddQuotesIfUnrecognised = True
        Me.ucrInputTolerance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputTolerance.GetSetSelectedIndex = -1
        Me.ucrInputTolerance.IsReadOnly = False
        Me.ucrInputTolerance.Location = New System.Drawing.Point(328, 197)
        Me.ucrInputTolerance.Name = "ucrInputTolerance"
        Me.ucrInputTolerance.Size = New System.Drawing.Size(62, 21)
        Me.ucrInputTolerance.TabIndex = 120
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(101, 8)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(228, 37)
        Me.ucrPnlOptions.TabIndex = 114
        '
        'ucrSaveLogical
        '
        Me.ucrSaveLogical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveLogical.Location = New System.Drawing.Point(11, 426)
        Me.ucrSaveLogical.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveLogical.Name = "ucrSaveLogical"
        Me.ucrSaveLogical.Size = New System.Drawing.Size(355, 22)
        Me.ucrSaveLogical.TabIndex = 8
        '
        'ucrChkSort
        '
        Me.ucrChkSort.AutoSize = True
        Me.ucrChkSort.Checked = False
        Me.ucrChkSort.Location = New System.Drawing.Point(276, 240)
        Me.ucrChkSort.Name = "ucrChkSort"
        Me.ucrChkSort.Size = New System.Drawing.Size(115, 23)
        Me.ucrChkSort.TabIndex = 6
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(11, 456)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 9
        '
        'ucrReceiverSecond
        '
        Me.ucrReceiverSecond.AutoSize = True
        Me.ucrReceiverSecond.frmParent = Me
        Me.ucrReceiverSecond.Location = New System.Drawing.Point(267, 151)
        Me.ucrReceiverSecond.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecond.Name = "ucrReceiverSecond"
        Me.ucrReceiverSecond.Selector = Nothing
        Me.ucrReceiverSecond.Size = New System.Drawing.Size(124, 20)
        Me.ucrReceiverSecond.strNcFilePath = ""
        Me.ucrReceiverSecond.TabIndex = 4
        Me.ucrReceiverSecond.ucrSelector = Nothing
        '
        'ucrReceiverFirst
        '
        Me.ucrReceiverFirst.AutoSize = True
        Me.ucrReceiverFirst.frmParent = Me
        Me.ucrReceiverFirst.Location = New System.Drawing.Point(267, 98)
        Me.ucrReceiverFirst.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirst.Name = "ucrReceiverFirst"
        Me.ucrReceiverFirst.Selector = Nothing
        Me.ucrReceiverFirst.Size = New System.Drawing.Size(124, 20)
        Me.ucrReceiverFirst.strNcFilePath = ""
        Me.ucrReceiverFirst.TabIndex = 2
        Me.ucrReceiverFirst.ucrSelector = Nothing
        '
        'ucrSelectorCompareColumns
        '
        Me.ucrSelectorCompareColumns.AutoSize = True
        Me.ucrSelectorCompareColumns.bDropUnusedFilterLevels = False
        Me.ucrSelectorCompareColumns.bShowHiddenColumns = False
        Me.ucrSelectorCompareColumns.bUseCurrentFilter = True
        Me.ucrSelectorCompareColumns.Location = New System.Drawing.Point(10, 48)
        Me.ucrSelectorCompareColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCompareColumns.Name = "ucrSelectorCompareColumns"
        Me.ucrSelectorCompareColumns.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorCompareColumns.TabIndex = 0
        '
        'ucrChkUnique
        '
        Me.ucrChkUnique.AutoSize = True
        Me.ucrChkUnique.Checked = False
        Me.ucrChkUnique.Location = New System.Drawing.Point(13, 240)
        Me.ucrChkUnique.Name = "ucrChkUnique"
        Me.ucrChkUnique.Size = New System.Drawing.Size(257, 24)
        Me.ucrChkUnique.TabIndex = 5
        '
        'dlgCompareColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(420, 522)
        Me.Controls.Add(Me.grpComparisions)
        Me.Controls.Add(Me.lblTolerance)
        Me.Controls.Add(Me.ucrInputTolerance)
        Me.Controls.Add(Me.rdoByValue)
        Me.Controls.Add(Me.rdoByRow)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrSaveLogical)
        Me.Controls.Add(Me.ucrChkSort)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblSecondColumn)
        Me.Controls.Add(Me.lblFirstColumn)
        Me.Controls.Add(Me.ucrReceiverSecond)
        Me.Controls.Add(Me.ucrReceiverFirst)
        Me.Controls.Add(Me.ucrSelectorCompareColumns)
        Me.Controls.Add(Me.ucrChkUnique)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCompareColumns"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compare Columns"
        Me.grpComparisions.ResumeLayout(False)
        Me.grpComparisions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorCompareColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFirst As ucrReceiverSingle
    Friend WithEvents lblSecondColumn As Label
    Friend WithEvents lblFirstColumn As Label
    Friend WithEvents ucrReceiverSecond As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkUnique As ucrCheck
    Friend WithEvents grpComparisions As GroupBox
    Friend WithEvents ucrChkSort As ucrCheck
    Friend WithEvents ucrChkFirstNotSecond As ucrCheck
    Friend WithEvents ucrChkSecondNotFirst As ucrCheck
    Friend WithEvents ucrChkIntersection As ucrCheck
    Friend WithEvents ucrChkUnion As ucrCheck
    Friend WithEvents ucrChkAllValues As ucrCheck
    Friend WithEvents ucrSaveLogical As ucrSave
    Friend WithEvents lblTolerance As Label
    Friend WithEvents rdoByValue As RadioButton
    Friend WithEvents rdoByRow As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents ucrInputTolerance As ucrInputComboBox
End Class
