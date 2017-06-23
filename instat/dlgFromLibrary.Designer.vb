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
        Me.cmdLibraryCollection = New System.Windows.Forms.Button()
        Me.lstCollection = New System.Windows.Forms.ListView()
        Me.clmDatasets = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmDesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rdoDefaultDatasets = New System.Windows.Forms.RadioButton()
        Me.rdoInstatCollection = New System.Windows.Forms.RadioButton()
        Me.lblFromPackage = New System.Windows.Forms.Label()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.ucrInputPackages = New instat.ucrInputComboBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'cmdLibraryCollection
        '
        Me.cmdLibraryCollection.Location = New System.Drawing.Point(129, 33)
        Me.cmdLibraryCollection.Name = "cmdLibraryCollection"
        Me.cmdLibraryCollection.Size = New System.Drawing.Size(117, 23)
        Me.cmdLibraryCollection.TabIndex = 2
        Me.cmdLibraryCollection.Text = "Browse"
        Me.cmdLibraryCollection.UseVisualStyleBackColor = True
        '
        'lstCollection
        '
        Me.lstCollection.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmDatasets, Me.clmDesc})
        Me.lstCollection.FullRowSelect = True
        Me.lstCollection.Location = New System.Drawing.Point(10, 60)
        Me.lstCollection.MultiSelect = False
        Me.lstCollection.Name = "lstCollection"
        Me.lstCollection.ShowGroups = False
        Me.lstCollection.ShowItemToolTips = True
        Me.lstCollection.Size = New System.Drawing.Size(397, 173)
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
        'rdoDefaultDatasets
        '
        Me.rdoDefaultDatasets.AutoSize = True
        Me.rdoDefaultDatasets.Location = New System.Drawing.Point(10, 9)
        Me.rdoDefaultDatasets.Name = "rdoDefaultDatasets"
        Me.rdoDefaultDatasets.Size = New System.Drawing.Size(83, 17)
        Me.rdoDefaultDatasets.TabIndex = 12
        Me.rdoDefaultDatasets.TabStop = True
        Me.rdoDefaultDatasets.Text = "Load from R"
        Me.rdoDefaultDatasets.UseVisualStyleBackColor = True
        '
        'rdoInstatCollection
        '
        Me.rdoInstatCollection.AutoSize = True
        Me.rdoInstatCollection.Location = New System.Drawing.Point(129, 10)
        Me.rdoInstatCollection.Name = "rdoInstatCollection"
        Me.rdoInstatCollection.Size = New System.Drawing.Size(149, 17)
        Me.rdoInstatCollection.TabIndex = 6
        Me.rdoInstatCollection.TabStop = True
        Me.rdoInstatCollection.Text = "Load from Instat collection"
        Me.rdoInstatCollection.UseVisualStyleBackColor = True
        '
        'lblFromPackage
        '
        Me.lblFromPackage.AutoSize = True
        Me.lblFromPackage.Location = New System.Drawing.Point(7, 33)
        Me.lblFromPackage.Name = "lblFromPackage"
        Me.lblFromPackage.Size = New System.Drawing.Size(79, 13)
        Me.lblFromPackage.TabIndex = 15
        Me.lblFromPackage.Text = "From Package:"
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(332, 239)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdHelp.TabIndex = 17
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'ucrInputPackages
        '
        Me.ucrInputPackages.AddQuotesIfUnrecognised = True
        Me.ucrInputPackages.IsReadOnly = False
        Me.ucrInputPackages.Location = New System.Drawing.Point(92, 33)
        Me.ucrInputPackages.Name = "ucrInputPackages"
        Me.ucrInputPackages.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPackages.TabIndex = 18
        '
        'ucrBase
        '
        Me.ucrBase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucrBase.Location = New System.Drawing.Point(7, 266)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(400, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.Location = New System.Drawing.Point(5, 2)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(278, 28)
        Me.ucrPnlOptions.TabIndex = 19
        '
        'dlgFromLibrary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 325)
        Me.Controls.Add(Me.cmdLibraryCollection)
        Me.Controls.Add(Me.ucrInputPackages)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.lblFromPackage)
        Me.Controls.Add(Me.rdoDefaultDatasets)
        Me.Controls.Add(Me.rdoInstatCollection)
        Me.Controls.Add(Me.lstCollection)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFromLibrary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Open Dataset from Library"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdLibraryCollection As Button
    Friend WithEvents lstCollection As ListView
    Friend WithEvents clmDatasets As ColumnHeader
    Friend WithEvents clmDesc As ColumnHeader
    Friend WithEvents rdoDefaultDatasets As RadioButton
    Friend WithEvents rdoInstatCollection As RadioButton
    Friend WithEvents lblFromPackage As Label
    Friend WithEvents cmdHelp As Button
    Friend WithEvents ucrInputPackages As ucrInputComboBox
    Friend WithEvents ucrPnlOptions As UcrPanel
End Class