<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgMergeColumnstoInclude
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
        Me.ucrChkMergeWithSubsetSecond = New instat.ucrCheck()
        Me.ucrChkMergeWithSubsetFirst = New instat.ucrCheck()
        Me.lblVariablesToIncludeSecond = New System.Windows.Forms.Label()
        Me.lblVariablesToIncludeFirst = New System.Windows.Forms.Label()
        Me.ucrReceiverSecondSelected = New instat.ucrReceiverMultiple()
        Me.ucrReceiverFirstSelected = New instat.ucrReceiverMultiple()
        Me.ucrSelectorColumnsToIncludeSecond = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSelectorColumnsToIncludeFirst = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSubBase = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'ucrChkMergeWithSubsetSecond
        '
        Me.ucrChkMergeWithSubsetSecond.AutoSize = True
        Me.ucrChkMergeWithSubsetSecond.Checked = False
        Me.ucrChkMergeWithSubsetSecond.Location = New System.Drawing.Point(255, 15)
        Me.ucrChkMergeWithSubsetSecond.Name = "ucrChkMergeWithSubsetSecond"
        Me.ucrChkMergeWithSubsetSecond.Size = New System.Drawing.Size(210, 23)
        Me.ucrChkMergeWithSubsetSecond.TabIndex = 2
        '
        'ucrChkMergeWithSubsetFirst
        '
        Me.ucrChkMergeWithSubsetFirst.AutoSize = True
        Me.ucrChkMergeWithSubsetFirst.Checked = False
        Me.ucrChkMergeWithSubsetFirst.Location = New System.Drawing.Point(13, 15)
        Me.ucrChkMergeWithSubsetFirst.Name = "ucrChkMergeWithSubsetFirst"
        Me.ucrChkMergeWithSubsetFirst.Size = New System.Drawing.Size(206, 23)
        Me.ucrChkMergeWithSubsetFirst.TabIndex = 0
        '
        'lblVariablesToIncludeSecond
        '
        Me.lblVariablesToIncludeSecond.AutoSize = True
        Me.lblVariablesToIncludeSecond.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVariablesToIncludeSecond.Location = New System.Drawing.Point(252, 228)
        Me.lblVariablesToIncludeSecond.Name = "lblVariablesToIncludeSecond"
        Me.lblVariablesToIncludeSecond.Size = New System.Drawing.Size(103, 13)
        Me.lblVariablesToIncludeSecond.TabIndex = 6
        Me.lblVariablesToIncludeSecond.Text = "Variables to Include:"
        '
        'lblVariablesToIncludeFirst
        '
        Me.lblVariablesToIncludeFirst.AutoSize = True
        Me.lblVariablesToIncludeFirst.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVariablesToIncludeFirst.Location = New System.Drawing.Point(13, 228)
        Me.lblVariablesToIncludeFirst.Name = "lblVariablesToIncludeFirst"
        Me.lblVariablesToIncludeFirst.Size = New System.Drawing.Size(103, 13)
        Me.lblVariablesToIncludeFirst.TabIndex = 4
        Me.lblVariablesToIncludeFirst.Text = "Variables to Include:"
        '
        'ucrReceiverSecondSelected
        '
        Me.ucrReceiverSecondSelected.AutoSize = True
        Me.ucrReceiverSecondSelected.frmParent = Me
        Me.ucrReceiverSecondSelected.Location = New System.Drawing.Point(255, 243)
        Me.ucrReceiverSecondSelected.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondSelected.Name = "ucrReceiverSecondSelected"
        Me.ucrReceiverSecondSelected.Selector = Nothing
        Me.ucrReceiverSecondSelected.Size = New System.Drawing.Size(120, 119)
        Me.ucrReceiverSecondSelected.strNcFilePath = ""
        Me.ucrReceiverSecondSelected.TabIndex = 7
        Me.ucrReceiverSecondSelected.ucrSelector = Nothing
        '
        'ucrReceiverFirstSelected
        '
        Me.ucrReceiverFirstSelected.AutoSize = True
        Me.ucrReceiverFirstSelected.frmParent = Me
        Me.ucrReceiverFirstSelected.Location = New System.Drawing.Point(13, 243)
        Me.ucrReceiverFirstSelected.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstSelected.Name = "ucrReceiverFirstSelected"
        Me.ucrReceiverFirstSelected.Selector = Nothing
        Me.ucrReceiverFirstSelected.Size = New System.Drawing.Size(120, 119)
        Me.ucrReceiverFirstSelected.strNcFilePath = ""
        Me.ucrReceiverFirstSelected.TabIndex = 5
        Me.ucrReceiverFirstSelected.ucrSelector = Nothing
        '
        'ucrSelectorColumnsToIncludeSecond
        '
        Me.ucrSelectorColumnsToIncludeSecond.AutoSize = True
        Me.ucrSelectorColumnsToIncludeSecond.bDropUnusedFilterLevels = False
        Me.ucrSelectorColumnsToIncludeSecond.bShowHiddenColumns = False
        Me.ucrSelectorColumnsToIncludeSecond.bUseCurrentFilter = True
        Me.ucrSelectorColumnsToIncludeSecond.Location = New System.Drawing.Point(255, 39)
        Me.ucrSelectorColumnsToIncludeSecond.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorColumnsToIncludeSecond.Name = "ucrSelectorColumnsToIncludeSecond"
        Me.ucrSelectorColumnsToIncludeSecond.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorColumnsToIncludeSecond.TabIndex = 3
        '
        'ucrSelectorColumnsToIncludeFirst
        '
        Me.ucrSelectorColumnsToIncludeFirst.AutoSize = True
        Me.ucrSelectorColumnsToIncludeFirst.bDropUnusedFilterLevels = False
        Me.ucrSelectorColumnsToIncludeFirst.bShowHiddenColumns = False
        Me.ucrSelectorColumnsToIncludeFirst.bUseCurrentFilter = True
        Me.ucrSelectorColumnsToIncludeFirst.Location = New System.Drawing.Point(13, 39)
        Me.ucrSelectorColumnsToIncludeFirst.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorColumnsToIncludeFirst.Name = "ucrSelectorColumnsToIncludeFirst"
        Me.ucrSelectorColumnsToIncludeFirst.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorColumnsToIncludeFirst.TabIndex = 1
        '
        'ucrSubBase
        '
        Me.ucrSubBase.AutoSize = True
        Me.ucrSubBase.Location = New System.Drawing.Point(159, 381)
        Me.ucrSubBase.Name = "ucrSubBase"
        Me.ucrSubBase.Size = New System.Drawing.Size(224, 30)
        Me.ucrSubBase.TabIndex = 8
        '
        'sdgMergeColumnstoInclude
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(478, 414)
        Me.Controls.Add(Me.ucrSubBase)
        Me.Controls.Add(Me.ucrChkMergeWithSubsetSecond)
        Me.Controls.Add(Me.ucrChkMergeWithSubsetFirst)
        Me.Controls.Add(Me.lblVariablesToIncludeSecond)
        Me.Controls.Add(Me.lblVariablesToIncludeFirst)
        Me.Controls.Add(Me.ucrReceiverSecondSelected)
        Me.Controls.Add(Me.ucrReceiverFirstSelected)
        Me.Controls.Add(Me.ucrSelectorColumnsToIncludeSecond)
        Me.Controls.Add(Me.ucrSelectorColumnsToIncludeFirst)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgMergeColumnstoInclude"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Columns to Include"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrChkMergeWithSubsetSecond As ucrCheck
    Friend WithEvents ucrChkMergeWithSubsetFirst As ucrCheck
    Friend WithEvents lblVariablesToIncludeSecond As Label
    Friend WithEvents lblVariablesToIncludeFirst As Label
    Friend WithEvents ucrReceiverSecondSelected As ucrReceiverMultiple
    Friend WithEvents ucrReceiverFirstSelected As ucrReceiverMultiple
    Friend WithEvents ucrSelectorColumnsToIncludeSecond As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectorColumnsToIncludeFirst As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSubBase As ucrButtonsSubdialogue
End Class
