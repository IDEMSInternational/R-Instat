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
        Me.cmdDefineNewFilter = New System.Windows.Forms.Button()
        Me.ucrSelectorFilter = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.ucrReceiverFilter = New instat.ucrReceiverSingle()
        Me.lblFilterPreview = New System.Windows.Forms.Label()
        Me.ucrInputFilterPreview = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'cmdDefineNewFilter
        '
        Me.cmdDefineNewFilter.Location = New System.Drawing.Point(250, 95)
        Me.cmdDefineNewFilter.Name = "cmdDefineNewFilter"
        Me.cmdDefineNewFilter.Size = New System.Drawing.Size(120, 23)
        Me.cmdDefineNewFilter.TabIndex = 1
        Me.cmdDefineNewFilter.Tag = "Define_New_Filter"
        Me.cmdDefineNewFilter.Text = "Define New Filter"
        Me.cmdDefineNewFilter.UseVisualStyleBackColor = True
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
        Me.ucrBase.Location = New System.Drawing.Point(10, 227)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(247, 21)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(29, 13)
        Me.lblFilter.TabIndex = 10
        Me.lblFilter.Text = "Filter"
        '
        'ucrReceiverFilter
        '
        Me.ucrReceiverFilter.Location = New System.Drawing.Point(250, 38)
        Me.ucrReceiverFilter.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFilter.Name = "ucrReceiverFilter"
        Me.ucrReceiverFilter.Selector = Nothing
        Me.ucrReceiverFilter.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFilter.TabIndex = 11
        '
        'lblFilterPreview
        '
        Me.lblFilterPreview.AutoSize = True
        Me.lblFilterPreview.Location = New System.Drawing.Point(10, 202)
        Me.lblFilterPreview.Name = "lblFilterPreview"
        Me.lblFilterPreview.Size = New System.Drawing.Size(115, 13)
        Me.lblFilterPreview.TabIndex = 12
        Me.lblFilterPreview.Text = "Selected Filter Preview"
        '
        'ucrInputFilterPreview
        '
        Me.ucrInputFilterPreview.Location = New System.Drawing.Point(131, 199)
        Me.ucrInputFilterPreview.Name = "ucrInputFilterPreview"
        Me.ucrInputFilterPreview.Size = New System.Drawing.Size(270, 21)
        Me.ucrInputFilterPreview.TabIndex = 13
        '
        'dlgRestrict
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 282)
        Me.Controls.Add(Me.ucrInputFilterPreview)
        Me.Controls.Add(Me.lblFilterPreview)
        Me.Controls.Add(Me.ucrReceiverFilter)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.ucrSelectorFilter)
        Me.Controls.Add(Me.cmdDefineNewFilter)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgRestrict"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Filter"
        Me.Text = "Filter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdDefineNewFilter As Button
    Friend WithEvents ucrSelectorFilter As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFilter As Label
    Friend WithEvents ucrReceiverFilter As ucrReceiverSingle
    Friend WithEvents lblFilterPreview As Label
    Friend WithEvents ucrInputFilterPreview As ucrInputTextBox
End Class
