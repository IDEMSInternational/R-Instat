﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRenameSheet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.lblNewName = New System.Windows.Forms.Label()
        Me.ucrInputNewName = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFrameToRename = New instat.ucrDataFrame()
        Me.SuspendLayout()
        '
        'lblNewName
        '
        Me.lblNewName.Location = New System.Drawing.Point(196, 13)
        Me.lblNewName.Name = "lblNewName"
        Me.lblNewName.Size = New System.Drawing.Size(100, 15)
        Me.lblNewName.TabIndex = 1
        Me.lblNewName.Tag = "New_Name"
        Me.lblNewName.Text = "New Name:"
        '
        'ucrInputNewName
        '
        Me.ucrInputNewName.IsMultiline = False
        Me.ucrInputNewName.IsReadOnly = False
        Me.ucrInputNewName.Location = New System.Drawing.Point(194, 28)
        Me.ucrInputNewName.Name = "ucrInputNewName"
        Me.ucrInputNewName.Size = New System.Drawing.Size(131, 22)
        Me.ucrInputNewName.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 74)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 3
        '
        'ucrDataFrameToRename
        '
        Me.ucrDataFrameToRename.bUseCurrentFilter = True
        Me.ucrDataFrameToRename.Location = New System.Drawing.Point(10, 10)
        Me.ucrDataFrameToRename.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameToRename.Name = "ucrDataFrameToRename"
        Me.ucrDataFrameToRename.Size = New System.Drawing.Size(120, 40)
        Me.ucrDataFrameToRename.TabIndex = 0
        '
        'dlgRenameSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 134)
        Me.Controls.Add(Me.ucrInputNewName)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblNewName)
        Me.Controls.Add(Me.ucrDataFrameToRename)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRenameSheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rename Sheet"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrDataFrameToRename As ucrDataFrame
    Friend WithEvents lblNewName As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInputNewName As ucrInputTextBox
End Class
