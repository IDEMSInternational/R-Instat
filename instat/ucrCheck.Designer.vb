﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrCheck
    Inherits instat.ucrCore

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
        Me.chkCheck = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'chkCheck
        '
        Me.chkCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkCheck.Location = New System.Drawing.Point(0, 0)
        Me.chkCheck.Name = "chkCheck"
        Me.chkCheck.Size = New System.Drawing.Size(100, 20)
        Me.chkCheck.TabIndex = 0
        Me.chkCheck.Text = "CheckBox1"
        Me.chkCheck.UseVisualStyleBackColor = True
        '
        'ucrCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkCheck)
        Me.Name = "ucrCheck"
        Me.Size = New System.Drawing.Size(100, 20)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chkCheck As CheckBox
End Class
