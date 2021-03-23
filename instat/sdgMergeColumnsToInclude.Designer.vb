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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgMergeColumnstoInclude))
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
        Me.ucrChkMergeWithSubsetSecond.Checked = False
        resources.ApplyResources(Me.ucrChkMergeWithSubsetSecond, "ucrChkMergeWithSubsetSecond")
        Me.ucrChkMergeWithSubsetSecond.Name = "ucrChkMergeWithSubsetSecond"
        '
        'ucrChkMergeWithSubsetFirst
        '
        Me.ucrChkMergeWithSubsetFirst.Checked = False
        resources.ApplyResources(Me.ucrChkMergeWithSubsetFirst, "ucrChkMergeWithSubsetFirst")
        Me.ucrChkMergeWithSubsetFirst.Name = "ucrChkMergeWithSubsetFirst"
        '
        'lblVariablesToIncludeSecond
        '
        resources.ApplyResources(Me.lblVariablesToIncludeSecond, "lblVariablesToIncludeSecond")
        Me.lblVariablesToIncludeSecond.Name = "lblVariablesToIncludeSecond"
        '
        'lblVariablesToIncludeFirst
        '
        resources.ApplyResources(Me.lblVariablesToIncludeFirst, "lblVariablesToIncludeFirst")
        Me.lblVariablesToIncludeFirst.Name = "lblVariablesToIncludeFirst"
        '
        'ucrReceiverSecondSelected
        '
        Me.ucrReceiverSecondSelected.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSecondSelected, "ucrReceiverSecondSelected")
        Me.ucrReceiverSecondSelected.Name = "ucrReceiverSecondSelected"
        Me.ucrReceiverSecondSelected.Selector = Nothing
        Me.ucrReceiverSecondSelected.strNcFilePath = ""
        Me.ucrReceiverSecondSelected.ucrSelector = Nothing
        '
        'ucrReceiverFirstSelected
        '
        Me.ucrReceiverFirstSelected.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFirstSelected, "ucrReceiverFirstSelected")
        Me.ucrReceiverFirstSelected.Name = "ucrReceiverFirstSelected"
        Me.ucrReceiverFirstSelected.Selector = Nothing
        Me.ucrReceiverFirstSelected.strNcFilePath = ""
        Me.ucrReceiverFirstSelected.ucrSelector = Nothing
        '
        'ucrSelectorColumnsToIncludeSecond
        '
        Me.ucrSelectorColumnsToIncludeSecond.bDropUnusedFilterLevels = False
        Me.ucrSelectorColumnsToIncludeSecond.bShowHiddenColumns = False
        Me.ucrSelectorColumnsToIncludeSecond.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorColumnsToIncludeSecond, "ucrSelectorColumnsToIncludeSecond")
        Me.ucrSelectorColumnsToIncludeSecond.Name = "ucrSelectorColumnsToIncludeSecond"
        '
        'ucrSelectorColumnsToIncludeFirst
        '
        Me.ucrSelectorColumnsToIncludeFirst.bDropUnusedFilterLevels = False
        Me.ucrSelectorColumnsToIncludeFirst.bShowHiddenColumns = False
        Me.ucrSelectorColumnsToIncludeFirst.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorColumnsToIncludeFirst, "ucrSelectorColumnsToIncludeFirst")
        Me.ucrSelectorColumnsToIncludeFirst.Name = "ucrSelectorColumnsToIncludeFirst"
        '
        'ucrSubBase
        '
        resources.ApplyResources(Me.ucrSubBase, "ucrSubBase")
        Me.ucrSubBase.Name = "ucrSubBase"
        '
        'sdgMergeColumnstoInclude
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
