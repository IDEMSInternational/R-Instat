﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgThemeOptions
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
        Me.ucrBaseSdgThemeOptions = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'ucrBaseSdgThemeOptions
        '
        Me.ucrBaseSdgThemeOptions.Location = New System.Drawing.Point(59, 213)
        Me.ucrBaseSdgThemeOptions.Name = "ucrBaseSdgThemeOptions"
        Me.ucrBaseSdgThemeOptions.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSdgThemeOptions.TabIndex = 0
        '
        'sdgThemeOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 267)
        Me.Controls.Add(Me.ucrBaseSdgThemeOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgThemeOptions"
        Me.Tag = "Theme_Options"
        Me.Text = "Theme Options"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseSdgThemeOptions As ucrButtonsSubdialogue
End Class
