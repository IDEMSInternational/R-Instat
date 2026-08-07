<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrSelectorByOutputObject
    Inherits instat.ucrSelector

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
        Me.components = New System.ComponentModel.Container()
        Me.lblObjectTypeLabel = New System.Windows.Forms.Label()
        Me.btnAdd = New instat.ucrSplitButton()
        Me.contextMenuStripAdd = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripAddSelected = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripAddAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparatorContext = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtObjectName = New System.Windows.Forms.TextBox()
        Me.contextMenuStripAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstAvailableVariable
        '
        Me.lstAvailableVariable.Dock = System.Windows.Forms.DockStyle.None
        Me.lstAvailableVariable.Location = New System.Drawing.Point(1, 40)
        '
        'lblObjectTypeLabel
        '
        Me.lblObjectTypeLabel.AutoSize = True
        Me.lblObjectTypeLabel.Location = New System.Drawing.Point(3, 2)
        Me.lblObjectTypeLabel.Name = "lblObjectTypeLabel"
        Me.lblObjectTypeLabel.Size = New System.Drawing.Size(97, 13)
        Me.lblObjectTypeLabel.TabIndex = 85
        Me.lblObjectTypeLabel.Text = "Object Type Label:"
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.Location = New System.Drawing.Point(154, 39)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(59, 34)
        Me.btnAdd.TabIndex = 86
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'contextMenuStripAdd
        '
        Me.contextMenuStripAdd.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.contextMenuStripAdd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripAddSelected, Me.toolStripAddAll, Me.ToolStripSeparatorContext, Me.toolStripHelp})
        Me.contextMenuStripAdd.Name = "SelectionMenuStrip"
        Me.contextMenuStripAdd.Size = New System.Drawing.Size(144, 76)
        '
        'toolStripAddSelected
        '
        Me.toolStripAddSelected.Name = "toolStripAddSelected"
        Me.toolStripAddSelected.Size = New System.Drawing.Size(143, 22)
        Me.toolStripAddSelected.Tag = "Add_selected"
        Me.toolStripAddSelected.Text = "Add Selected"
        '
        'toolStripAddAll
        '
        Me.toolStripAddAll.Name = "toolStripAddAll"
        Me.toolStripAddAll.Size = New System.Drawing.Size(143, 22)
        Me.toolStripAddAll.Text = "Add All"
        '
        'ToolStripSeparatorContext
        '
        Me.ToolStripSeparatorContext.Name = "ToolStripSeparatorContext"
        Me.ToolStripSeparatorContext.Size = New System.Drawing.Size(140, 6)
        '
        'toolStripHelp
        '
        Me.toolStripHelp.Name = "toolStripHelp"
        Me.toolStripHelp.Size = New System.Drawing.Size(143, 22)
        Me.toolStripHelp.Text = "Help"
        '
        'txtObjectName
        '
        Me.txtObjectName.Enabled = False
        Me.txtObjectName.Location = New System.Drawing.Point(3, 17)
        Me.txtObjectName.Name = "txtObjectName"
        Me.txtObjectName.Size = New System.Drawing.Size(146, 20)
        Me.txtObjectName.TabIndex = 87
        '
        'ucrSelectorByOutputObject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtObjectName)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblObjectTypeLabel)
        Me.Name = "ucrSelectorByOutputObject"
        Me.Size = New System.Drawing.Size(216, 173)
        Me.Controls.SetChildIndex(Me.lstAvailableVariable, 0)
        Me.Controls.SetChildIndex(Me.lblObjectTypeLabel, 0)
        Me.Controls.SetChildIndex(Me.btnAdd, 0)
        Me.Controls.SetChildIndex(Me.txtObjectName, 0)
        Me.contextMenuStripAdd.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblObjectTypeLabel As Label
    Friend WithEvents btnAdd As ucrSplitButton
    Friend WithEvents contextMenuStripAdd As ContextMenuStrip
    Friend WithEvents toolStripAddSelected As ToolStripMenuItem
    Friend WithEvents toolStripAddAll As ToolStripMenuItem
    Friend WithEvents ToolStripSeparatorContext As ToolStripSeparator
    Friend WithEvents toolStripHelp As ToolStripMenuItem
    Friend WithEvents txtObjectName As TextBox
End Class
