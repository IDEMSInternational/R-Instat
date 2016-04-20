<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ucrDataFrameToRename = New instat.ucrDataFrame()
        Me.lblName = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputNewName = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'ucrDataFrameToRename
        '
        Me.ucrDataFrameToRename.Location = New System.Drawing.Point(0, 0)
        Me.ucrDataFrameToRename.Name = "ucrDataFrameToRename"
        Me.ucrDataFrameToRename.Size = New System.Drawing.Size(127, 41)
        Me.ucrDataFrameToRename.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(145, 21)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(60, 13)
        Me.lblName.TabIndex = 6
        Me.lblName.Tag = "Name"
        Me.lblName.Text = "New Name"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(0, 47)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 7
        '
        'ucrInputNewName
        '
        Me.ucrInputNewName.Location = New System.Drawing.Point(209, 19)
        Me.ucrInputNewName.Name = "ucrInputNewName"
        Me.ucrInputNewName.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputNewName.TabIndex = 8
        '
        'dlgRenameSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 99)
        Me.Controls.Add(Me.ucrInputNewName)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.ucrDataFrameToRename)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgRenameSheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rename Sheet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrDataFrameToRename As ucrDataFrame
    Friend WithEvents lblName As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInputNewName As ucrInputTextBox
End Class
