<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgSaveColumnPosition
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
        Me.grpColumnPosition = New System.Windows.Forms.GroupBox()
        Me.rdoEnd = New System.Windows.Forms.RadioButton()
        Me.rdoAfter = New System.Windows.Forms.RadioButton()
        Me.rdoBefore = New System.Windows.Forms.RadioButton()
        Me.rdoStart = New System.Windows.Forms.RadioButton()
        Me.ucrPnlColumnPosition = New instat.UcrPanel()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.ucrReceiverColumn = New instat.ucrReceiverSingle()
        Me.ucrSelectorColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.ucrChkKeepExistingPos = New instat.ucrCheck()
        Me.grpColumnPosition.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpColumnPosition
        '
        Me.grpColumnPosition.Controls.Add(Me.rdoEnd)
        Me.grpColumnPosition.Controls.Add(Me.rdoAfter)
        Me.grpColumnPosition.Controls.Add(Me.rdoBefore)
        Me.grpColumnPosition.Controls.Add(Me.rdoStart)
        Me.grpColumnPosition.Controls.Add(Me.ucrPnlColumnPosition)
        Me.grpColumnPosition.Location = New System.Drawing.Point(9, 9)
        Me.grpColumnPosition.Name = "grpColumnPosition"
        Me.grpColumnPosition.Size = New System.Drawing.Size(296, 58)
        Me.grpColumnPosition.TabIndex = 12
        Me.grpColumnPosition.TabStop = False
        Me.grpColumnPosition.Text = "New column will be at:"
        '
        'rdoEnd
        '
        Me.rdoEnd.AutoSize = True
        Me.rdoEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoEnd.Location = New System.Drawing.Point(71, 27)
        Me.rdoEnd.Name = "rdoEnd"
        Me.rdoEnd.Size = New System.Drawing.Size(44, 17)
        Me.rdoEnd.TabIndex = 2
        Me.rdoEnd.Text = "End"
        Me.rdoEnd.UseVisualStyleBackColor = True
        '
        'rdoAfter
        '
        Me.rdoAfter.AutoSize = True
        Me.rdoAfter.Checked = True
        Me.rdoAfter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAfter.Location = New System.Drawing.Point(200, 27)
        Me.rdoAfter.Name = "rdoAfter"
        Me.rdoAfter.Size = New System.Drawing.Size(47, 17)
        Me.rdoAfter.TabIndex = 4
        Me.rdoAfter.TabStop = True
        Me.rdoAfter.Text = "After"
        Me.rdoAfter.UseVisualStyleBackColor = True
        '
        'rdoBefore
        '
        Me.rdoBefore.AutoSize = True
        Me.rdoBefore.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBefore.Location = New System.Drawing.Point(129, 27)
        Me.rdoBefore.Name = "rdoBefore"
        Me.rdoBefore.Size = New System.Drawing.Size(56, 17)
        Me.rdoBefore.TabIndex = 3
        Me.rdoBefore.Text = "Before"
        Me.rdoBefore.UseVisualStyleBackColor = True
        '
        'rdoStart
        '
        Me.rdoStart.AutoSize = True
        Me.rdoStart.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStart.Location = New System.Drawing.Point(9, 27)
        Me.rdoStart.Name = "rdoStart"
        Me.rdoStart.Size = New System.Drawing.Size(47, 17)
        Me.rdoStart.TabIndex = 1
        Me.rdoStart.Text = "Start"
        Me.rdoStart.UseVisualStyleBackColor = True
        '
        'ucrPnlColumnPosition
        '
        Me.ucrPnlColumnPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlColumnPosition.Location = New System.Drawing.Point(6, 19)
        Me.ucrPnlColumnPosition.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrPnlColumnPosition.Name = "ucrPnlColumnPosition"
        Me.ucrPnlColumnPosition.Size = New System.Drawing.Size(264, 31)
        Me.ucrPnlColumnPosition.TabIndex = 0
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(224, 106)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(45, 13)
        Me.lblColumns.TabIndex = 14
        Me.lblColumns.Text = "Column:"
        '
        'ucrReceiverColumn
        '
        Me.ucrReceiverColumn.AutoSize = True
        Me.ucrReceiverColumn.frmParent = Me
        Me.ucrReceiverColumn.Location = New System.Drawing.Point(224, 121)
        Me.ucrReceiverColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumn.Name = "ucrReceiverColumn"
        Me.ucrReceiverColumn.Selector = Nothing
        Me.ucrReceiverColumn.Size = New System.Drawing.Size(129, 20)
        Me.ucrReceiverColumn.strNcFilePath = ""
        Me.ucrReceiverColumn.TabIndex = 15
        Me.ucrReceiverColumn.ucrSelector = Nothing
        '
        'ucrSelectorColumns
        '
        Me.ucrSelectorColumns.AutoSize = True
        Me.ucrSelectorColumns.bDropUnusedFilterLevels = False
        Me.ucrSelectorColumns.bShowHiddenColumns = False
        Me.ucrSelectorColumns.bUseCurrentFilter = True
        Me.ucrSelectorColumns.Location = New System.Drawing.Point(9, 71)
        Me.ucrSelectorColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorColumns.Name = "ucrSelectorColumns"
        Me.ucrSelectorColumns.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorColumns.TabIndex = 13
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(103, 270)
        Me.ucrBaseSubdialog.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(224, 30)
        Me.ucrBaseSubdialog.TabIndex = 7
        '
        'ucrChkKeepExistingPos
        '
        Me.ucrChkKeepExistingPos.AutoSize = True
        Me.ucrChkKeepExistingPos.Checked = False
        Me.ucrChkKeepExistingPos.Location = New System.Drawing.Point(227, 155)
        Me.ucrChkKeepExistingPos.Name = "ucrChkKeepExistingPos"
        Me.ucrChkKeepExistingPos.Size = New System.Drawing.Size(126, 23)
        Me.ucrChkKeepExistingPos.TabIndex = 16
        '
        'sdgSaveColumnPosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(361, 301)
        Me.Controls.Add(Me.ucrChkKeepExistingPos)
        Me.Controls.Add(Me.ucrReceiverColumn)
        Me.Controls.Add(Me.ucrSelectorColumns)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.grpColumnPosition)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgSaveColumnPosition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Save Column Position"
        Me.grpColumnPosition.ResumeLayout(False)
        Me.grpColumnPosition.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents grpColumnPosition As GroupBox
    Friend WithEvents rdoEnd As RadioButton
    Friend WithEvents rdoAfter As RadioButton
    Friend WithEvents rdoBefore As RadioButton
    Friend WithEvents rdoStart As RadioButton
    Friend WithEvents ucrPnlColumnPosition As UcrPanel
    Friend WithEvents ucrReceiverColumn As ucrReceiverSingle
    Friend WithEvents ucrSelectorColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblColumns As Label
    Friend WithEvents ucrChkKeepExistingPos As ucrCheck
End Class
