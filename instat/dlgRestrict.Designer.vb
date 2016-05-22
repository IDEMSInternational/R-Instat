<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgRestrict
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
        Me.cmdNewFilter = New System.Windows.Forms.Button()
        Me.ucrFilterPreview = New instat.ucrInputTextBox()
        Me.ucrSelectorFilter = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.rdoApplySelected = New System.Windows.Forms.RadioButton()
        Me.rdoRemoveFilter = New System.Windows.Forms.RadioButton()
        Me.grpFilterOptions = New System.Windows.Forms.GroupBox()
        Me.grpFilterOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdNewFilter
        '
        Me.cmdNewFilter.Location = New System.Drawing.Point(15, 243)
        Me.cmdNewFilter.Name = "cmdNewFilter"
        Me.cmdNewFilter.Size = New System.Drawing.Size(75, 23)
        Me.cmdNewFilter.TabIndex = 1
        Me.cmdNewFilter.Tag = "New_Filter"
        Me.cmdNewFilter.Text = "New Filter"
        Me.cmdNewFilter.UseVisualStyleBackColor = True
        '
        'ucrFilterPreview
        '
        Me.ucrFilterPreview.Location = New System.Drawing.Point(130, 24)
        Me.ucrFilterPreview.Name = "ucrFilterPreview"
        Me.ucrFilterPreview.Size = New System.Drawing.Size(263, 21)
        Me.ucrFilterPreview.TabIndex = 6
        '
        'ucrSelectorFilter
        '
        Me.ucrSelectorFilter.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorFilter.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFilter.Name = "ucrSelectorFilter"
        Me.ucrSelectorFilter.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorFilter.TabIndex = 5
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 378)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'rdoApplySelected
        '
        Me.rdoApplySelected.AutoSize = True
        Me.rdoApplySelected.Location = New System.Drawing.Point(6, 24)
        Me.rdoApplySelected.Name = "rdoApplySelected"
        Me.rdoApplySelected.Size = New System.Drawing.Size(121, 17)
        Me.rdoApplySelected.TabIndex = 7
        Me.rdoApplySelected.TabStop = True
        Me.rdoApplySelected.Text = "Apply Selected Filter"
        Me.rdoApplySelected.UseVisualStyleBackColor = True
        '
        'rdoRemoveFilter
        '
        Me.rdoRemoveFilter.AutoSize = True
        Me.rdoRemoveFilter.Location = New System.Drawing.Point(6, 64)
        Me.rdoRemoveFilter.Name = "rdoRemoveFilter"
        Me.rdoRemoveFilter.Size = New System.Drawing.Size(127, 17)
        Me.rdoRemoveFilter.TabIndex = 8
        Me.rdoRemoveFilter.TabStop = True
        Me.rdoRemoveFilter.Text = "Remove Current Filter"
        Me.rdoRemoveFilter.UseVisualStyleBackColor = True
        '
        'grpFilterOptions
        '
        Me.grpFilterOptions.Controls.Add(Me.rdoApplySelected)
        Me.grpFilterOptions.Controls.Add(Me.rdoRemoveFilter)
        Me.grpFilterOptions.Controls.Add(Me.ucrFilterPreview)
        Me.grpFilterOptions.Location = New System.Drawing.Point(10, 272)
        Me.grpFilterOptions.Name = "grpFilterOptions"
        Me.grpFilterOptions.Size = New System.Drawing.Size(399, 100)
        Me.grpFilterOptions.TabIndex = 9
        Me.grpFilterOptions.TabStop = False
        Me.grpFilterOptions.Text = "Filter Options"
        '
        'dlgRestrict
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 432)
        Me.Controls.Add(Me.grpFilterOptions)
        Me.Controls.Add(Me.ucrSelectorFilter)
        Me.Controls.Add(Me.cmdNewFilter)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgRestrict"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Filter"
        Me.Text = "Filter"
        Me.grpFilterOptions.ResumeLayout(False)
        Me.grpFilterOptions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdNewFilter As Button
    Friend WithEvents ucrSelectorFilter As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFilterPreview As ucrInputTextBox
    Friend WithEvents rdoApplySelected As RadioButton
    Friend WithEvents rdoRemoveFilter As RadioButton
    Friend WithEvents grpFilterOptions As GroupBox
End Class
