<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrCalculationSummary
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
        Me.lstAvailableData = New System.Windows.Forms.ListView()
        Me.cmdBottom = New System.Windows.Forms.Button()
        Me.cmdDown = New System.Windows.Forms.Button()
        Me.cmdUp = New System.Windows.Forms.Button()
        Me.cmdTop = New System.Windows.Forms.Button()
        Me.lblCalcSummary = New System.Windows.Forms.Label()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdDuplicate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstAvailableData
        '
        Me.lstAvailableData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAvailableData.FullRowSelect = True
        Me.lstAvailableData.Location = New System.Drawing.Point(31, 39)
        Me.lstAvailableData.Name = "lstAvailableData"
        Me.lstAvailableData.Size = New System.Drawing.Size(116, 150)
        Me.lstAvailableData.TabIndex = 10
        Me.lstAvailableData.UseCompatibleStateImageBehavior = False
        Me.lstAvailableData.View = System.Windows.Forms.View.Details
        '
        'cmdBottom
        '
        Me.cmdBottom.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdBottom.AutoSize = True
        Me.cmdBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdBottom.Image = Global.instat.My.Resources.Resources.arrows_bottom
        Me.cmdBottom.Location = New System.Drawing.Point(3, 145)
        Me.cmdBottom.Name = "cmdBottom"
        Me.cmdBottom.Size = New System.Drawing.Size(22, 22)
        Me.cmdBottom.TabIndex = 9
        Me.cmdBottom.UseVisualStyleBackColor = True
        '
        'cmdDown
        '
        Me.cmdDown.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdDown.AutoSize = True
        Me.cmdDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdDown.Image = Global.instat.My.Resources.Resources.arrows_down
        Me.cmdDown.Location = New System.Drawing.Point(3, 116)
        Me.cmdDown.Name = "cmdDown"
        Me.cmdDown.Size = New System.Drawing.Size(22, 22)
        Me.cmdDown.TabIndex = 8
        Me.cmdDown.UseVisualStyleBackColor = True
        '
        'cmdUp
        '
        Me.cmdUp.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdUp.AutoSize = True
        Me.cmdUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdUp.Image = Global.instat.My.Resources.Resources.arrows_up
        Me.cmdUp.Location = New System.Drawing.Point(3, 87)
        Me.cmdUp.Name = "cmdUp"
        Me.cmdUp.Size = New System.Drawing.Size(22, 22)
        Me.cmdUp.TabIndex = 7
        Me.cmdUp.UseVisualStyleBackColor = True
        '
        'cmdTop
        '
        Me.cmdTop.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdTop.AutoSize = True
        Me.cmdTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdTop.Image = Global.instat.My.Resources.Resources.arrows_top
        Me.cmdTop.Location = New System.Drawing.Point(3, 59)
        Me.cmdTop.Name = "cmdTop"
        Me.cmdTop.Size = New System.Drawing.Size(22, 22)
        Me.cmdTop.TabIndex = 6
        Me.cmdTop.UseVisualStyleBackColor = True
        '
        'lblCalcSummary
        '
        Me.lblCalcSummary.AutoSize = True
        Me.lblCalcSummary.Location = New System.Drawing.Point(31, 24)
        Me.lblCalcSummary.Name = "lblCalcSummary"
        Me.lblCalcSummary.Size = New System.Drawing.Size(115, 13)
        Me.lblCalcSummary.TabIndex = 11
        Me.lblCalcSummary.Text = "Calculations/Summary:"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(153, 116)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 12
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(153, 87)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdEdit.TabIndex = 13
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(153, 58)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 14
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdDuplicate
        '
        Me.cmdDuplicate.Location = New System.Drawing.Point(153, 145)
        Me.cmdDuplicate.Name = "cmdDuplicate"
        Me.cmdDuplicate.Size = New System.Drawing.Size(75, 23)
        Me.cmdDuplicate.TabIndex = 15
        Me.cmdDuplicate.Text = "Duplicate"
        Me.cmdDuplicate.UseVisualStyleBackColor = True
        '
        'ucrCalculationSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdDuplicate)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lblCalcSummary)
        Me.Controls.Add(Me.lstAvailableData)
        Me.Controls.Add(Me.cmdBottom)
        Me.Controls.Add(Me.cmdDown)
        Me.Controls.Add(Me.cmdUp)
        Me.Controls.Add(Me.cmdTop)
        Me.Name = "ucrCalculationSummary"
        Me.Size = New System.Drawing.Size(306, 192)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstAvailableData As ListView
    Friend WithEvents cmdBottom As Button
    Friend WithEvents cmdDown As Button
    Friend WithEvents cmdUp As Button
    Friend WithEvents cmdTop As Button
    Friend WithEvents lblCalcSummary As Label
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdDuplicate As Button
End Class
