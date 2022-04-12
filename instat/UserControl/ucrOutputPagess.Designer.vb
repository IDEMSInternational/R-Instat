<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrOutputPagess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrOutputPagess))
        Me.Ribbon = New System.Windows.Forms.Ribbon()
        Me.rtPage = New System.Windows.Forms.RibbonTab()
        Me.rpSelect = New System.Windows.Forms.RibbonPanel()
        Me.rbSelectEdit = New System.Windows.Forms.RibbonButton()
        Me.rbSelectGroup = New System.Windows.Forms.RibbonButton()
        Me.rbSelectElement = New System.Windows.Forms.RibbonButton()
        Me.rpShow = New System.Windows.Forms.RibbonPanel()
        Me.rcbShowComments = New System.Windows.Forms.RibbonCheckBox()
        Me.rcbShowScripts = New System.Windows.Forms.RibbonCheckBox()
        Me.rcbShowImages = New System.Windows.Forms.RibbonCheckBox()
        Me.rcbShowTextOutputs = New System.Windows.Forms.RibbonCheckBox()
        Me.rcbShowCleanUp = New System.Windows.Forms.RibbonCheckBox()
        Me.rpPage = New System.Windows.Forms.RibbonPanel()
        Me.rbSave = New System.Windows.Forms.RibbonButton()
        Me.rbResetView = New System.Windows.Forms.RibbonButton()
        Me.rtElement = New System.Windows.Forms.RibbonTab()
        Me.rpSelected = New System.Windows.Forms.RibbonPanel()
        Me.rbRunAgain = New System.Windows.Forms.RibbonButton()
        Me.rbMoveToNew = New System.Windows.Forms.RibbonButton()
        Me.rbMoveToExisting = New System.Windows.Forms.RibbonButton()
        Me.rbCopy = New System.Windows.Forms.RibbonButton()
        Me.rbDelete = New System.Windows.Forms.RibbonButton()
        Me.rpGroupShow = New System.Windows.Forms.RibbonPanel()
        Me.rcbShowPreScriptsGroup = New System.Windows.Forms.RibbonCheckBox()
        Me.rcbShowScriptGroup = New System.Windows.Forms.RibbonCheckBox()
        Me.rcbShowPostScriptsGroup = New System.Windows.Forms.RibbonCheckBox()
        Me.rcbShowCleanUpGroup = New System.Windows.Forms.RibbonCheckBox()
        Me.rpElement = New System.Windows.Forms.RibbonPanel()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.SuspendLayout()
        '
        'Ribbon
        '
        Me.Ribbon.CaptionBarVisible = False
        Me.Ribbon.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Ribbon.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon.Minimized = False
        Me.Ribbon.Name = "Ribbon"
        '
        '
        '
        Me.Ribbon.OrbDropDown.BorderRoundness = 8
        Me.Ribbon.OrbDropDown.Enabled = False
        Me.Ribbon.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon.OrbDropDown.Name = ""
        Me.Ribbon.OrbDropDown.Size = New System.Drawing.Size(527, 447)
        Me.Ribbon.OrbDropDown.TabIndex = 0
        Me.Ribbon.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013
        Me.Ribbon.OrbVisible = False
        '
        '
        '
        Me.Ribbon.QuickAccessToolbar.Visible = False
        Me.Ribbon.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Ribbon.Size = New System.Drawing.Size(1052, 103)
        Me.Ribbon.TabIndex = 0
        Me.Ribbon.Tabs.Add(Me.rtPage)
        Me.Ribbon.Tabs.Add(Me.rtElement)
        Me.Ribbon.TabSpacing = 4
        '
        'rtPage
        '
        Me.rtPage.Name = "rtPage"
        Me.rtPage.Panels.Add(Me.rpSelect)
        Me.rtPage.Panels.Add(Me.rpShow)
        Me.rtPage.Panels.Add(Me.rpPage)
        Me.rtPage.Text = "Page"
        '
        'rpSelect
        '
        Me.rpSelect.Items.Add(Me.rbSelectEdit)
        Me.rpSelect.Items.Add(Me.rbSelectGroup)
        Me.rpSelect.Items.Add(Me.rbSelectElement)
        Me.rpSelect.Name = "rpSelect"
        Me.rpSelect.Text = "Select"
        '
        'rbSelectEdit
        '
        Me.rbSelectEdit.Checked = True
        Me.rbSelectEdit.CheckedGroup = "Select"
        Me.rbSelectEdit.CheckOnClick = True
        Me.rbSelectEdit.Image = CType(resources.GetObject("rbSelectEdit.Image"), System.Drawing.Image)
        Me.rbSelectEdit.LargeImage = CType(resources.GetObject("rbSelectEdit.LargeImage"), System.Drawing.Image)
        Me.rbSelectEdit.Name = "rbSelectEdit"
        Me.rbSelectEdit.SmallImage = CType(resources.GetObject("rbSelectEdit.SmallImage"), System.Drawing.Image)
        Me.rbSelectEdit.Text = "Edit"
        '
        'rbSelectGroup
        '
        Me.rbSelectGroup.CheckedGroup = "Select"
        Me.rbSelectGroup.CheckOnClick = True
        Me.rbSelectGroup.Image = CType(resources.GetObject("rbSelectGroup.Image"), System.Drawing.Image)
        Me.rbSelectGroup.LargeImage = CType(resources.GetObject("rbSelectGroup.LargeImage"), System.Drawing.Image)
        Me.rbSelectGroup.Name = "rbSelectGroup"
        Me.rbSelectGroup.SmallImage = CType(resources.GetObject("rbSelectGroup.SmallImage"), System.Drawing.Image)
        Me.rbSelectGroup.Text = "Group"
        '
        'rbSelectElement
        '
        Me.rbSelectElement.CheckedGroup = "Select"
        Me.rbSelectElement.CheckOnClick = True
        Me.rbSelectElement.Image = CType(resources.GetObject("rbSelectElement.Image"), System.Drawing.Image)
        Me.rbSelectElement.LargeImage = CType(resources.GetObject("rbSelectElement.LargeImage"), System.Drawing.Image)
        Me.rbSelectElement.Name = "rbSelectElement"
        Me.rbSelectElement.SmallImage = CType(resources.GetObject("rbSelectElement.SmallImage"), System.Drawing.Image)
        Me.rbSelectElement.Text = "Element"
        '
        'rpShow
        '
        Me.rpShow.Items.Add(Me.rcbShowComments)
        Me.rpShow.Items.Add(Me.rcbShowScripts)
        Me.rpShow.Items.Add(Me.rcbShowImages)
        Me.rpShow.Items.Add(Me.rcbShowTextOutputs)
        Me.rpShow.Items.Add(Me.rcbShowCleanUp)
        Me.rpShow.Name = "rpShow"
        Me.rpShow.Text = "Show"
        '
        'rcbShowComments
        '
        Me.rcbShowComments.Name = "rcbShowComments"
        Me.rcbShowComments.Text = "Comments"
        '
        'rcbShowScripts
        '
        Me.rcbShowScripts.Name = "rcbShowScripts"
        Me.rcbShowScripts.Text = "Scripts"
        '
        'rcbShowImages
        '
        Me.rcbShowImages.Name = "rcbShowImages"
        Me.rcbShowImages.Text = "Images"
        '
        'rcbShowTextOutputs
        '
        Me.rcbShowTextOutputs.Name = "rcbShowTextOutputs"
        Me.rcbShowTextOutputs.Text = "Text Outputs"
        '
        'rcbShowCleanUp
        '
        Me.rcbShowCleanUp.Name = "rcbShowCleanUp"
        Me.rcbShowCleanUp.Text = "Clean Up"
        '
        'rpPage
        '
        Me.rpPage.Items.Add(Me.rbSave)
        Me.rpPage.Items.Add(Me.rbResetView)
        Me.rpPage.Name = "rpPage"
        Me.rpPage.Text = "Page"
        '
        'rbSave
        '
        Me.rbSave.Image = CType(resources.GetObject("rbSave.Image"), System.Drawing.Image)
        Me.rbSave.LargeImage = CType(resources.GetObject("rbSave.LargeImage"), System.Drawing.Image)
        Me.rbSave.Name = "rbSave"
        Me.rbSave.SmallImage = CType(resources.GetObject("rbSave.SmallImage"), System.Drawing.Image)
        Me.rbSave.Text = "Save"
        '
        'rbResetView
        '
        Me.rbResetView.Image = CType(resources.GetObject("rbResetView.Image"), System.Drawing.Image)
        Me.rbResetView.LargeImage = CType(resources.GetObject("rbResetView.LargeImage"), System.Drawing.Image)
        Me.rbResetView.MinimumSize = New System.Drawing.Size(80, 0)
        Me.rbResetView.Name = "rbResetView"
        Me.rbResetView.SmallImage = CType(resources.GetObject("rbResetView.SmallImage"), System.Drawing.Image)
        Me.rbResetView.Text = "Reset View"
        '
        'rtElement
        '
        Me.rtElement.Name = "rtElement"
        Me.rtElement.Panels.Add(Me.rpSelected)
        Me.rtElement.Panels.Add(Me.rpGroupShow)
        Me.rtElement.Panels.Add(Me.rpElement)
        Me.rtElement.Text = "Selected"
        '
        'rpSelected
        '
        Me.rpSelected.Items.Add(Me.rbRunAgain)
        Me.rpSelected.Items.Add(Me.rbMoveToNew)
        Me.rpSelected.Items.Add(Me.rbMoveToExisting)
        Me.rpSelected.Items.Add(Me.rbCopy)
        Me.rpSelected.Items.Add(Me.rbDelete)
        Me.rpSelected.Name = "rpSelected"
        Me.rpSelected.Text = "Selected"
        '
        'rbRunAgain
        '
        Me.rbRunAgain.Image = CType(resources.GetObject("rbRunAgain.Image"), System.Drawing.Image)
        Me.rbRunAgain.LargeImage = CType(resources.GetObject("rbRunAgain.LargeImage"), System.Drawing.Image)
        Me.rbRunAgain.Name = "rbRunAgain"
        Me.rbRunAgain.SmallImage = CType(resources.GetObject("rbRunAgain.SmallImage"), System.Drawing.Image)
        Me.rbRunAgain.Text = "Run"
        '
        'rbMoveToNew
        '
        Me.rbMoveToNew.Image = CType(resources.GetObject("rbMoveToNew.Image"), System.Drawing.Image)
        Me.rbMoveToNew.LargeImage = CType(resources.GetObject("rbMoveToNew.LargeImage"), System.Drawing.Image)
        Me.rbMoveToNew.MinimumSize = New System.Drawing.Size(80, 0)
        Me.rbMoveToNew.Name = "rbMoveToNew"
        Me.rbMoveToNew.SmallImage = CType(resources.GetObject("rbMoveToNew.SmallImage"), System.Drawing.Image)
        Me.rbMoveToNew.Text = "Move to New"
        '
        'rbMoveToExisting
        '
        Me.rbMoveToExisting.Image = CType(resources.GetObject("rbMoveToExisting.Image"), System.Drawing.Image)
        Me.rbMoveToExisting.LargeImage = CType(resources.GetObject("rbMoveToExisting.LargeImage"), System.Drawing.Image)
        Me.rbMoveToExisting.MinimumSize = New System.Drawing.Size(80, 0)
        Me.rbMoveToExisting.Name = "rbMoveToExisting"
        Me.rbMoveToExisting.SmallImage = CType(resources.GetObject("rbMoveToExisting.SmallImage"), System.Drawing.Image)
        Me.rbMoveToExisting.Text = "Move to . ."
        '
        'rbCopy
        '
        Me.rbCopy.Image = CType(resources.GetObject("rbCopy.Image"), System.Drawing.Image)
        Me.rbCopy.LargeImage = CType(resources.GetObject("rbCopy.LargeImage"), System.Drawing.Image)
        Me.rbCopy.Name = "rbCopy"
        Me.rbCopy.SmallImage = CType(resources.GetObject("rbCopy.SmallImage"), System.Drawing.Image)
        Me.rbCopy.Text = "Copy"
        '
        'rbDelete
        '
        Me.rbDelete.Image = CType(resources.GetObject("rbDelete.Image"), System.Drawing.Image)
        Me.rbDelete.LargeImage = CType(resources.GetObject("rbDelete.LargeImage"), System.Drawing.Image)
        Me.rbDelete.Name = "rbDelete"
        Me.rbDelete.SmallImage = CType(resources.GetObject("rbDelete.SmallImage"), System.Drawing.Image)
        Me.rbDelete.Text = "Delete"
        '
        'rpGroupShow
        '
        Me.rpGroupShow.Items.Add(Me.rcbShowPreScriptsGroup)
        Me.rpGroupShow.Items.Add(Me.rcbShowScriptGroup)
        Me.rpGroupShow.Items.Add(Me.rcbShowPostScriptsGroup)
        Me.rpGroupShow.Items.Add(Me.rcbShowCleanUpGroup)
        Me.rpGroupShow.Name = "rpGroupShow"
        Me.rpGroupShow.Text = "Show"
        '
        'rcbShowPreScriptsGroup
        '
        Me.rcbShowPreScriptsGroup.Name = "rcbShowPreScriptsGroup"
        Me.rcbShowPreScriptsGroup.Text = "Pre Scripts"
        '
        'rcbShowScriptGroup
        '
        Me.rcbShowScriptGroup.Name = "rcbShowScriptGroup"
        Me.rcbShowScriptGroup.Text = "Script"
        '
        'rcbShowPostScriptsGroup
        '
        Me.rcbShowPostScriptsGroup.Name = "rcbShowPostScriptsGroup"
        Me.rcbShowPostScriptsGroup.Text = "Post Script"
        '
        'rcbShowCleanUpGroup
        '
        Me.rcbShowCleanUpGroup.Name = "rcbShowCleanUpGroup"
        Me.rcbShowCleanUpGroup.Text = "Clean Up"
        '
        'rpElement
        '
        Me.rpElement.Name = "rpElement"
        Me.rpElement.Text = "Element"
        '
        'tabControl
        '
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl.Location = New System.Drawing.Point(0, 103)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(1052, 318)
        Me.tabControl.TabIndex = 1
        '
        'ucrOutputPagess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.Ribbon)
        Me.Name = "ucrOutputPagess"
        Me.Size = New System.Drawing.Size(1052, 421)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtPage As RibbonTab
    Friend WithEvents rtElement As RibbonTab
    Friend WithEvents tabControl As TabControl
    Friend WithEvents rpSelect As RibbonPanel
    Friend WithEvents rbSelectEdit As RibbonButton
    Friend WithEvents rbSelectGroup As RibbonButton
    Friend WithEvents rbSelectElement As RibbonButton
    Friend WithEvents rpShow As RibbonPanel
    Friend WithEvents rcbShowComments As RibbonCheckBox
    Friend WithEvents rcbShowScripts As RibbonCheckBox
    Friend WithEvents rcbShowImages As RibbonCheckBox
    Friend WithEvents rcbShowTextOutputs As RibbonCheckBox
    Friend WithEvents rcbShowCleanUp As RibbonCheckBox
    Friend WithEvents rpPage As RibbonPanel
    Friend WithEvents rbSave As RibbonButton
    Friend WithEvents rbResetView As RibbonButton
    Friend WithEvents Ribbon As Ribbon
    Friend WithEvents rpSelected As RibbonPanel
    Friend WithEvents rbRunAgain As RibbonButton
    Friend WithEvents rbMoveToNew As RibbonButton
    Friend WithEvents rbMoveToExisting As RibbonButton
    Friend WithEvents rbCopy As RibbonButton
    Friend WithEvents rbDelete As RibbonButton
    Friend WithEvents rpGroupShow As RibbonPanel
    Friend WithEvents rcbShowPreScriptsGroup As RibbonCheckBox
    Friend WithEvents rcbShowScriptGroup As RibbonCheckBox
    Friend WithEvents rcbShowPostScriptsGroup As RibbonCheckBox
    Friend WithEvents rcbShowCleanUpGroup As RibbonCheckBox
    Friend WithEvents rpElement As RibbonPanel
End Class
