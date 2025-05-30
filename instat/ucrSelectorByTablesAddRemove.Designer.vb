<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrSelectorByTablesAddRemove
    Inherits instat.ucrSelectorByTable

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
        Me.contextMenuStripAdd = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripAddSelected = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripAddAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparatorContext = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAdd = New instat.ucrSplitButton()
        Me.contextMenuStripAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'contextMenuStripAdd
        '
        Me.contextMenuStripAdd.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.contextMenuStripAdd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripAddSelected, Me.toolStripAddAll, Me.ToolStripSeparatorContext, Me.toolStripHelp})
        Me.contextMenuStripAdd.Name = "SelectionMenuStrip"
        Me.contextMenuStripAdd.Size = New System.Drawing.Size(190, 106)
        '
        'toolStripAddSelected
        '
        Me.toolStripAddSelected.Name = "toolStripAddSelected"
        Me.toolStripAddSelected.Size = New System.Drawing.Size(189, 32)
        Me.toolStripAddSelected.Tag = "Add_selected"
        Me.toolStripAddSelected.Text = "Add Selected"
        '
        'toolStripAddAll
        '
        Me.toolStripAddAll.Name = "toolStripAddAll"
        Me.toolStripAddAll.Size = New System.Drawing.Size(189, 32)
        Me.toolStripAddAll.Text = "Add All"
        '
        'ToolStripSeparatorContext
        '
        Me.ToolStripSeparatorContext.Name = "ToolStripSeparatorContext"
        Me.ToolStripSeparatorContext.Size = New System.Drawing.Size(186, 6)
        '
        'toolStripHelp
        '
        Me.toolStripHelp.Name = "toolStripHelp"
        Me.toolStripHelp.Size = New System.Drawing.Size(189, 32)
        Me.toolStripHelp.Text = "Help"
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.ContextMenuStrip = Me.contextMenuStripAdd
        Me.btnAdd.Location = New System.Drawing.Point(234, 85)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 51)
        Me.btnAdd.SplitMenuStrip = Me.contextMenuStripAdd
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'ucrSelectorByTablesAddRemove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "ucrSelectorByTablesAddRemove"
        Me.Size = New System.Drawing.Size(343, 336)
        Me.Controls.SetChildIndex(Me.lstAvailableVariable, 0)
        Me.Controls.SetChildIndex(Me.ucrAvailableTables, 0)
        Me.Controls.SetChildIndex(Me.btnAdd, 0)
        Me.contextMenuStripAdd.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents contextMenuStripAdd As ContextMenuStrip
    Friend WithEvents toolStripAddSelected As ToolStripMenuItem
    Friend WithEvents toolStripAddAll As ToolStripMenuItem
    Friend WithEvents ToolStripSeparatorContext As ToolStripSeparator
    Friend WithEvents toolStripHelp As ToolStripMenuItem
    Friend WithEvents btnAdd As ucrSplitButton
End Class
