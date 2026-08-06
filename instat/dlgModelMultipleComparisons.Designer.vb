<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgModelMultipleComparisons
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
        Me.lblFirstVariables = New System.Windows.Forms.Label()
        Me.ucrSaveModelMultipleComparisons = New instat.ucrSave()
        Me.ucrReceiverFirstVariables = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorModelMultipleComparisons = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblFirstVariables
        '
        Me.lblFirstVariables.AutoSize = True
        Me.lblFirstVariables.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstVariables.Location = New System.Drawing.Point(377, 64)
        Me.lblFirstVariables.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstVariables.Name = "lblFirstVariables"
        Me.lblFirstVariables.Size = New System.Drawing.Size(68, 16)
        Me.lblFirstVariables.TabIndex = 25
        Me.lblFirstVariables.Tag = ""
        Me.lblFirstVariables.Text = "Variables:"
        '
        'ucrSaveModelMultipleComparisons
        '
        Me.ucrSaveModelMultipleComparisons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveModelMultipleComparisons.Location = New System.Drawing.Point(12, 368)
        Me.ucrSaveModelMultipleComparisons.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSaveModelMultipleComparisons.Name = "ucrSaveModelMultipleComparisons"
        Me.ucrSaveModelMultipleComparisons.Size = New System.Drawing.Size(408, 30)
        Me.ucrSaveModelMultipleComparisons.TabIndex = 27
        '
        'ucrReceiverFirstVariables
        '
        Me.ucrReceiverFirstVariables.AutoSize = True
        Me.ucrReceiverFirstVariables.frmParent = Me
        Me.ucrReceiverFirstVariables.Location = New System.Drawing.Point(377, 82)
        Me.ucrReceiverFirstVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstVariables.Name = "ucrReceiverFirstVariables"
        Me.ucrReceiverFirstVariables.Selector = Nothing
        Me.ucrReceiverFirstVariables.Size = New System.Drawing.Size(160, 97)
        Me.ucrReceiverFirstVariables.strNcFilePath = ""
        Me.ucrReceiverFirstVariables.TabIndex = 26
        Me.ucrReceiverFirstVariables.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(12, 425)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(511, 65)
        Me.ucrBase.TabIndex = 24
        '
        'ucrSelectorModelMultipleComparisons
        '
        Me.ucrSelectorModelMultipleComparisons.AutoSize = True
        Me.ucrSelectorModelMultipleComparisons.bDropUnusedFilterLevels = False
        Me.ucrSelectorModelMultipleComparisons.bShowHiddenColumns = False
        Me.ucrSelectorModelMultipleComparisons.bUseCurrentFilter = True
        Me.ucrSelectorModelMultipleComparisons.Location = New System.Drawing.Point(12, 43)
        Me.ucrSelectorModelMultipleComparisons.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorModelMultipleComparisons.Name = "ucrSelectorModelMultipleComparisons"
        Me.ucrSelectorModelMultipleComparisons.Size = New System.Drawing.Size(284, 227)
        Me.ucrSelectorModelMultipleComparisons.TabIndex = 5
        '
        'dlgModelMultipleComparisons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 507)
        Me.Controls.Add(Me.ucrSaveModelMultipleComparisons)
        Me.Controls.Add(Me.ucrReceiverFirstVariables)
        Me.Controls.Add(Me.lblFirstVariables)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorModelMultipleComparisons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "dlgModelMultipleComparisons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiple Comparisons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorModelMultipleComparisons As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverFirstVariables As ucrReceiverMultiple
    Friend WithEvents lblFirstVariables As Label
    Friend WithEvents ucrSaveModelMultipleComparisons As ucrSave
End Class
