﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgIsNAList
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.txtPeriod = New System.Windows.Forms.TextBox()
        Me.txtVariable = New System.Windows.Forms.TextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data list not implement"
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.Location = New System.Drawing.Point(28, 59)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(39, 13)
        Me.lblVariable.TabIndex = 2
        Me.lblVariable.Tag = "Variable"
        Me.lblVariable.Text = "Label2"
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Location = New System.Drawing.Point(28, 109)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(39, 13)
        Me.lblPeriod.TabIndex = 3
        Me.lblPeriod.Tag = "Period"
        Me.lblPeriod.Text = "Label3"
        '
        'txtPeriod
        '
        Me.txtPeriod.Location = New System.Drawing.Point(160, 106)
        Me.txtPeriod.Name = "txtPeriod"
        Me.txtPeriod.Size = New System.Drawing.Size(100, 20)
        Me.txtPeriod.TabIndex = 4
        '
        'txtVariable
        '
        Me.txtVariable.Location = New System.Drawing.Point(160, 52)
        Me.txtVariable.Name = "txtVariable"
        Me.txtVariable.Size = New System.Drawing.Size(100, 20)
        Me.txtVariable.TabIndex = 5
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(19, 204)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 54)
        Me.ucrBase.TabIndex = 0
        '
        'dlgIsNAList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 264)
        Me.Controls.Add(Me.txtVariable)
        Me.Controls.Add(Me.txtPeriod)
        Me.Controls.Add(Me.lblPeriod)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgIsNAList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Is_NA_List"
        Me.Text = "Is NA List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents Label1 As Label
    Friend WithEvents lblVariable As Label
    Friend WithEvents lblPeriod As Label
    Friend WithEvents txtPeriod As TextBox
    Friend WithEvents txtVariable As TextBox
End Class
