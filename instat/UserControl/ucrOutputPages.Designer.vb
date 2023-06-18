<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrOutputPages
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrOutputPages))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tsButtons = New System.Windows.Forms.ToolStrip()
        Me.tdbAddToExisting = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tbAddToNew = New System.Windows.Forms.ToolStripButton()
        Me.tbCopy = New System.Windows.Forms.ToolStripButton()
        Me.tbMoveUp = New System.Windows.Forms.ToolStripButton()
        Me.tbMoveDown = New System.Windows.Forms.ToolStripButton()
        Me.tbDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbRename = New System.Windows.Forms.ToolStripButton()
        Me.tbSave = New System.Windows.Forms.ToolStripButton()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tpMain = New System.Windows.Forms.TabPage()
        Me.ucrMainOutputPage = New instat.ucrOutputPage()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tsButtons.SuspendLayout()
        Me.tabControl.SuspendLayout()
        Me.tpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tsButtons, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tabControl, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(628, 352)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'tsButtons
        '
        Me.tsButtons.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.tsButtons.BackColor = System.Drawing.Color.White
        Me.tsButtons.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.tsButtons.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tdbAddToExisting, Me.tbAddToNew, Me.tbCopy, Me.tbMoveUp, Me.tbMoveDown, Me.tbDelete, Me.ToolStripSeparator1, Me.tbRename, Me.tbSave})
        Me.tsButtons.Location = New System.Drawing.Point(0, 0)
        Me.tsButtons.Name = "tsButtons"
        Me.tsButtons.Size = New System.Drawing.Size(628, 25)
        Me.tsButtons.TabIndex = 11
        Me.tsButtons.Text = "ToolStrip1"
        '
        'tdbAddToExisting
        '
        Me.tdbAddToExisting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tdbAddToExisting.Image = CType(resources.GetObject("tdbAddToExisting.Image"), System.Drawing.Image)
        Me.tdbAddToExisting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tdbAddToExisting.Name = "tdbAddToExisting"
        Me.tdbAddToExisting.Size = New System.Drawing.Size(101, 22)
        Me.tdbAddToExisting.Text = "Add To Existing"
        '
        'tbAddToNew
        '
        Me.tbAddToNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbAddToNew.Image = CType(resources.GetObject("tbAddToNew.Image"), System.Drawing.Image)
        Me.tbAddToNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbAddToNew.Name = "tbAddToNew"
        Me.tbAddToNew.Size = New System.Drawing.Size(75, 22)
        Me.tbAddToNew.Text = "Add To New"
        '
        'tbCopy
        '
        Me.tbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbCopy.Image = CType(resources.GetObject("tbCopy.Image"), System.Drawing.Image)
        Me.tbCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbCopy.Name = "tbCopy"
        Me.tbCopy.Size = New System.Drawing.Size(39, 22)
        Me.tbCopy.Text = "Copy"
        '
        'tbMoveUp
        '
        Me.tbMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbMoveUp.Image = CType(resources.GetObject("tbMoveUp.Image"), System.Drawing.Image)
        Me.tbMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbMoveUp.Name = "tbMoveUp"
        Me.tbMoveUp.Size = New System.Drawing.Size(59, 22)
        Me.tbMoveUp.Text = "Move Up"
        '
        'tbMoveDown
        '
        Me.tbMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbMoveDown.Image = CType(resources.GetObject("tbMoveDown.Image"), System.Drawing.Image)
        Me.tbMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbMoveDown.Name = "tbMoveDown"
        Me.tbMoveDown.Size = New System.Drawing.Size(75, 22)
        Me.tbMoveDown.Text = "Move Down"
        '
        'tbDelete
        '
        Me.tbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbDelete.Image = CType(resources.GetObject("tbDelete.Image"), System.Drawing.Image)
        Me.tbDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbDelete.Name = "tbDelete"
        Me.tbDelete.Size = New System.Drawing.Size(44, 22)
        Me.tbDelete.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tbRename
        '
        Me.tbRename.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbRename.Image = CType(resources.GetObject("tbRename.Image"), System.Drawing.Image)
        Me.tbRename.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbRename.Name = "tbRename"
        Me.tbRename.Size = New System.Drawing.Size(54, 22)
        Me.tbRename.Text = "Rename"
        '
        'tbSave
        '
        Me.tbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbSave.Image = CType(resources.GetObject("tbSave.Image"), System.Drawing.Image)
        Me.tbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbSave.Name = "tbSave"
        Me.tbSave.Size = New System.Drawing.Size(35, 22)
        Me.tbSave.Text = "Save"
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tpMain)
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl.Location = New System.Drawing.Point(3, 34)
        Me.tabControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(622, 316)
        Me.tabControl.TabIndex = 1
        '
        'tpMain
        '
        Me.tpMain.Controls.Add(Me.ucrMainOutputPage)
        Me.tpMain.Location = New System.Drawing.Point(4, 25)
        Me.tpMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpMain.Name = "tpMain"
        Me.tpMain.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpMain.Size = New System.Drawing.Size(614, 287)
        Me.tpMain.TabIndex = 0
        Me.tpMain.Text = "Main"
        Me.tpMain.UseVisualStyleBackColor = True
        '
        'ucrMainOutputPage
        '
        Me.ucrMainOutputPage.AutoSize = True
        Me.ucrMainOutputPage.BCanDelete = True
        Me.ucrMainOutputPage.BCanRename = False
        Me.ucrMainOutputPage.BCanReOrder = False
        Me.ucrMainOutputPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrMainOutputPage.Location = New System.Drawing.Point(3, 2)
        Me.ucrMainOutputPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ucrMainOutputPage.Name = "ucrMainOutputPage"
        Me.ucrMainOutputPage.Size = New System.Drawing.Size(608, 283)
        Me.ucrMainOutputPage.TabIndex = 0
        '
        'ucrOutputPages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ucrOutputPages"
        Me.Size = New System.Drawing.Size(628, 352)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tsButtons.ResumeLayout(False)
        Me.tsButtons.PerformLayout()
        Me.tabControl.ResumeLayout(False)
        Me.tpMain.ResumeLayout(False)
        Me.tpMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tabControl As TabControl
    Friend WithEvents tpMain As TabPage
    Friend WithEvents ucrMainOutputPage As ucrOutputPage
    Friend WithEvents tdbAddToExisting As ToolStripDropDownButton
    Friend WithEvents tbAddToNew As ToolStripButton
    Friend WithEvents tbCopy As ToolStripButton
    Friend WithEvents tbMoveUp As ToolStripButton
    Friend WithEvents tbMoveDown As ToolStripButton
    Friend WithEvents tbDelete As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tbRename As ToolStripButton
    Friend WithEvents tbSave As ToolStripButton
    Public WithEvents tsButtons As ToolStrip
End Class
