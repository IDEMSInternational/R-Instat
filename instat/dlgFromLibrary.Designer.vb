﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.cboPackages = New System.Windows.Forms.ComboBox()
        Me.rdoDefaultDatasets = New System.Windows.Forms.RadioButton()
        Me.rdoInstatCollection = New System.Windows.Forms.RadioButton()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.lblFromPackage = New System.Windows.Forms.Label()
        Me.grpCollection = New System.Windows.Forms.GroupBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpCollection.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdLibraryCollection
        '
        Me.cmdLibraryCollection.Location = New System.Drawing.Point(6, 19)
        Me.cmdLibraryCollection.Name = "cmdLibraryCollection"
        Me.cmdLibraryCollection.Size = New System.Drawing.Size(142, 23)
        Me.cmdLibraryCollection.TabIndex = 2
        Me.cmdLibraryCollection.Text = "Choose file"
        Me.cmdLibraryCollection.UseVisualStyleBackColor = True
        '
        'lstCollection
        '
        Me.lstCollection.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmDatasets, Me.clmDesc})
        Me.lstCollection.Location = New System.Drawing.Point(15, 56)
        Me.lstCollection.MultiSelect = False
        Me.lstCollection.Name = "lstCollection"
        Me.lstCollection.ShowGroups = False
        Me.lstCollection.ShowItemToolTips = True
        Me.lstCollection.Size = New System.Drawing.Size(415, 173)
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
        'cboPackages
        '
        Me.cboPackages.FormattingEnabled = True
        Me.cboPackages.Location = New System.Drawing.Point(93, 29)
        Me.cboPackages.Name = "cboPackages"
        Me.cboPackages.Size = New System.Drawing.Size(121, 21)
        Me.cboPackages.Sorted = True
        Me.cboPackages.TabIndex = 14
        '
        'rdoDefaultDatasets
        '
        Me.rdoDefaultDatasets.AutoSize = True
        Me.rdoDefaultDatasets.Location = New System.Drawing.Point(15, 6)
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
        Me.rdoInstatCollection.Location = New System.Drawing.Point(15, 235)
        Me.rdoInstatCollection.Name = "rdoInstatCollection"
        Me.rdoInstatCollection.Size = New System.Drawing.Size(149, 17)
        Me.rdoInstatCollection.TabIndex = 6
        Me.rdoInstatCollection.TabStop = True
        Me.rdoInstatCollection.Text = "Load from Instat collection"
        Me.rdoInstatCollection.UseVisualStyleBackColor = True
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(154, 19)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.ReadOnly = True
        Me.txtFilePath.Size = New System.Drawing.Size(267, 20)
        Me.txtFilePath.TabIndex = 7
        '
        'lblFromPackage
        '
        Me.lblFromPackage.AutoSize = True
        Me.lblFromPackage.Location = New System.Drawing.Point(12, 32)
        Me.lblFromPackage.Name = "lblFromPackage"
        Me.lblFromPackage.Size = New System.Drawing.Size(75, 13)
        Me.lblFromPackage.TabIndex = 15
        Me.lblFromPackage.Text = "From package"
        '
        'grpCollection
        '
        Me.grpCollection.AutoSize = True
        Me.grpCollection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpCollection.Controls.Add(Me.cmdLibraryCollection)
        Me.grpCollection.Controls.Add(Me.txtFilePath)
        Me.grpCollection.Location = New System.Drawing.Point(15, 258)
        Me.grpCollection.Name = "grpCollection"
        Me.grpCollection.Size = New System.Drawing.Size(427, 61)
        Me.grpCollection.TabIndex = 16
        Me.grpCollection.TabStop = False
        '
        'ucrBase
        '
        Me.ucrBase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucrBase.Location = New System.Drawing.Point(24, 329)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(406, 53)
        Me.ucrBase.TabIndex = 0
        '
        'dlgFromLibrary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 382)
        Me.Controls.Add(Me.grpCollection)
        Me.Controls.Add(Me.lblFromPackage)
        Me.Controls.Add(Me.cboPackages)
        Me.Controls.Add(Me.rdoDefaultDatasets)
        Me.Controls.Add(Me.rdoInstatCollection)
        Me.Controls.Add(Me.lstCollection)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgFromLibrary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Open dataset from library"
        Me.grpCollection.ResumeLayout(False)
        Me.grpCollection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdLibraryCollection As Button
    Friend WithEvents lstCollection As ListView
    Friend WithEvents clmDatasets As ColumnHeader
    Friend WithEvents clmDesc As ColumnHeader
    Friend WithEvents rdoDefaultDatasets As RadioButton
    Friend WithEvents cboPackages As ComboBox
    Friend WithEvents rdoInstatCollection As RadioButton
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents lblFromPackage As Label
    Friend WithEvents grpCollection As GroupBox
End Class
