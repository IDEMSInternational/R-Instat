<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgFromLibrary
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
        Me.lblBrowse = New System.Windows.Forms.Label()
        Me.cmdLibraryCollection = New System.Windows.Forms.Button()
        Me.chkChooseFrom = New System.Windows.Forms.CheckBox()
        Me.lstCollection = New System.Windows.Forms.ListView()
        Me.clmDatasets = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmDesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ucrBase = New instat.ucrButtons()
        Me.grpR = New System.Windows.Forms.GroupBox()
        Me.cboPackages = New System.Windows.Forms.ComboBox()
        Me.rdoChooseDatasets = New System.Windows.Forms.RadioButton()
        Me.rdoDefaultDatasets = New System.Windows.Forms.RadioButton()
        Me.lblDatasetsNumber = New System.Windows.Forms.Label()
        Me.lblDatasets = New System.Windows.Forms.Label()
        Me.grpR.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBrowse
        '
        Me.lblBrowse.AutoSize = True
        Me.lblBrowse.Location = New System.Drawing.Point(12, 9)
        Me.lblBrowse.Name = "lblBrowse"
        Me.lblBrowse.Size = New System.Drawing.Size(131, 13)
        Me.lblBrowse.TabIndex = 1
        Me.lblBrowse.Text = "Browse from our collection"
        '
        'cmdLibraryCollection
        '
        Me.cmdLibraryCollection.Location = New System.Drawing.Point(176, 9)
        Me.cmdLibraryCollection.Name = "cmdLibraryCollection"
        Me.cmdLibraryCollection.Size = New System.Drawing.Size(142, 23)
        Me.cmdLibraryCollection.TabIndex = 2
        Me.cmdLibraryCollection.Text = "Browse Collection"
        Me.cmdLibraryCollection.UseVisualStyleBackColor = True
        '
        'chkChooseFrom
        '
        Me.chkChooseFrom.AutoSize = True
        Me.chkChooseFrom.Location = New System.Drawing.Point(15, 45)
        Me.chkChooseFrom.Name = "chkChooseFrom"
        Me.chkChooseFrom.Size = New System.Drawing.Size(98, 17)
        Me.chkChooseFrom.TabIndex = 3
        Me.chkChooseFrom.Text = "Or Load from R"
        Me.chkChooseFrom.UseVisualStyleBackColor = True
        '
        'lstCollection
        '
        Me.lstCollection.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstCollection.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmDatasets, Me.clmDesc})
        Me.lstCollection.Enabled = False
        Me.lstCollection.HotTracking = True
        Me.lstCollection.HoverSelection = True
        Me.lstCollection.Location = New System.Drawing.Point(15, 148)
        Me.lstCollection.MultiSelect = False
        Me.lstCollection.Name = "lstCollection"
        Me.lstCollection.ShowGroups = False
        Me.lstCollection.ShowItemToolTips = True
        Me.lstCollection.Size = New System.Drawing.Size(415, 208)
        Me.lstCollection.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstCollection.TabIndex = 4
        Me.lstCollection.UseCompatibleStateImageBehavior = False
        Me.lstCollection.View = System.Windows.Forms.View.Details
        '
        'clmDatasets
        '
        Me.clmDatasets.Text = "Data"
        Me.clmDatasets.Width = 142
        '
        'clmDesc
        '
        Me.clmDesc.Text = "Description"
        Me.clmDesc.Width = 266
        '
        'ucrBase
        '
        Me.ucrBase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucrBase.Location = New System.Drawing.Point(24, 362)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(406, 53)
        Me.ucrBase.TabIndex = 0
        '
        'grpR
        '
        Me.grpR.AutoSize = True
        Me.grpR.Controls.Add(Me.cboPackages)
        Me.grpR.Controls.Add(Me.rdoChooseDatasets)
        Me.grpR.Controls.Add(Me.rdoDefaultDatasets)
        Me.grpR.Controls.Add(Me.lblDatasetsNumber)
        Me.grpR.Controls.Add(Me.lblDatasets)
        Me.grpR.Location = New System.Drawing.Point(15, 76)
        Me.grpR.Name = "grpR"
        Me.grpR.Size = New System.Drawing.Size(415, 66)
        Me.grpR.TabIndex = 5
        Me.grpR.TabStop = False
        '
        'cboPackages
        '
        Me.cboPackages.FormattingEnabled = True
        Me.cboPackages.Location = New System.Drawing.Point(117, 26)
        Me.cboPackages.Name = "cboPackages"
        Me.cboPackages.Size = New System.Drawing.Size(121, 21)
        Me.cboPackages.TabIndex = 14
        Me.cboPackages.Visible = False
        '
        'rdoChooseDatasets
        '
        Me.rdoChooseDatasets.AutoSize = True
        Me.rdoChooseDatasets.Location = New System.Drawing.Point(117, 3)
        Me.rdoChooseDatasets.Name = "rdoChooseDatasets"
        Me.rdoChooseDatasets.Size = New System.Drawing.Size(129, 17)
        Me.rdoChooseDatasets.TabIndex = 13
        Me.rdoChooseDatasets.TabStop = True
        Me.rdoChooseDatasets.Text = "Choose from package"
        Me.rdoChooseDatasets.UseVisualStyleBackColor = True
        '
        'rdoDefaultDatasets
        '
        Me.rdoDefaultDatasets.AutoSize = True
        Me.rdoDefaultDatasets.Location = New System.Drawing.Point(13, 3)
        Me.rdoDefaultDatasets.Name = "rdoDefaultDatasets"
        Me.rdoDefaultDatasets.Size = New System.Drawing.Size(96, 17)
        Me.rdoDefaultDatasets.TabIndex = 12
        Me.rdoDefaultDatasets.TabStop = True
        Me.rdoDefaultDatasets.Text = "Default datsets"
        Me.rdoDefaultDatasets.UseVisualStyleBackColor = True
        '
        'lblDatasetsNumber
        '
        Me.lblDatasetsNumber.AutoSize = True
        Me.lblDatasetsNumber.Location = New System.Drawing.Point(389, 8)
        Me.lblDatasetsNumber.Name = "lblDatasetsNumber"
        Me.lblDatasetsNumber.Size = New System.Drawing.Size(13, 13)
        Me.lblDatasetsNumber.TabIndex = 11
        Me.lblDatasetsNumber.Text = "0"
        '
        'lblDatasets
        '
        Me.lblDatasets.AutoSize = True
        Me.lblDatasets.Location = New System.Drawing.Point(249, 7)
        Me.lblDatasets.Name = "lblDatasets"
        Me.lblDatasets.Size = New System.Drawing.Size(134, 13)
        Me.lblDatasets.TabIndex = 10
        Me.lblDatasets.Text = "Number of datasets loaded"
        '
        'dlgFromLibrary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 415)
        Me.Controls.Add(Me.grpR)
        Me.Controls.Add(Me.lstCollection)
        Me.Controls.Add(Me.chkChooseFrom)
        Me.Controls.Add(Me.cmdLibraryCollection)
        Me.Controls.Add(Me.lblBrowse)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgFromLibrary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Open from library"
        Me.grpR.ResumeLayout(False)
        Me.grpR.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblBrowse As Label
    Friend WithEvents cmdLibraryCollection As Button
    Friend WithEvents chkChooseFrom As CheckBox
    Friend WithEvents lstCollection As ListView
    Friend WithEvents clmDatasets As ColumnHeader
    Friend WithEvents clmDesc As ColumnHeader
    Friend WithEvents grpR As GroupBox
    Friend WithEvents lblDatasets As Label
    Friend WithEvents lblDatasetsNumber As Label
    Friend WithEvents rdoDefaultDatasets As RadioButton
    Friend WithEvents rdoChooseDatasets As RadioButton
    Friend WithEvents cboPackages As ComboBox
End Class
