﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgFileNew
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
        Me.lblRows = New System.Windows.Forms.Label()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrNudRows = New instat.ucrNud()
        Me.ucrNudCols = New instat.ucrNud()
        Me.ucrNewDFName = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'lblRows
        '
        Me.lblRows.AutoSize = True
        Me.lblRows.Location = New System.Drawing.Point(10, 15)
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Size = New System.Drawing.Size(37, 13)
        Me.lblRows.TabIndex = 0
        Me.lblRows.Text = "Rows:"
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.Location = New System.Drawing.Point(10, 43)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(50, 13)
        Me.lblColumns.TabIndex = 2
        Me.lblColumns.Text = "Columns:"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 103)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(399, 48)
        Me.ucrBase.TabIndex = 5
        '
        'ucrNudRows
        '
        Me.ucrNudRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRows.Location = New System.Drawing.Point(73, 12)
        Me.ucrNudRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRows.Name = "ucrNudRows"
        Me.ucrNudRows.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudRows.TabIndex = 1
        Me.ucrNudRows.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudCols
        '
        Me.ucrNudCols.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCols.Location = New System.Drawing.Point(73, 40)
        Me.ucrNudCols.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCols.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCols.Name = "ucrNudCols"
        Me.ucrNudCols.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCols.TabIndex = 3
        Me.ucrNudCols.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNewDFName
        '
        Me.ucrNewDFName.Location = New System.Drawing.Point(10, 73)
        Me.ucrNewDFName.Name = "ucrNewDFName"
        Me.ucrNewDFName.Size = New System.Drawing.Size(300, 24)
        Me.ucrNewDFName.TabIndex = 4
        '
        'dlgFileNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 162)
        Me.Controls.Add(Me.ucrNewDFName)
        Me.Controls.Add(Me.ucrNudCols)
        Me.Controls.Add(Me.ucrNudRows)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.lblRows)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFileNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblColumns As Label
    Friend WithEvents lblRows As Label
    Friend WithEvents ucrNudRows As ucrNud
    Friend WithEvents ucrNudCols As ucrNud
    Friend WithEvents ucrNewDFName As ucrSave
End Class
