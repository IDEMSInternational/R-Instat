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
        Me.lblNewName = New System.Windows.Forms.Label()
        Me.ucrInputNewName = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFrameToRename = New instat.ucrDataFrame()
        Me.SuspendLayout()
        '
        'lblNewName
        '
        Me.lblNewName.AutoSize = True
        Me.lblNewName.Location = New System.Drawing.Point(207, 9)
        Me.lblNewName.Name = "lblNewName"
        Me.lblNewName.Size = New System.Drawing.Size(60, 13)
        Me.lblNewName.TabIndex = 1
        Me.lblNewName.Tag = "New_Name"
        Me.lblNewName.Text = "New Name"
        '
        'ucrInputNewName
        '
        Me.ucrInputNewName.Location = New System.Drawing.Point(210, 25)
        Me.ucrInputNewName.Name = "ucrInputNewName"
        Me.ucrInputNewName.Size = New System.Drawing.Size(185, 21)
        Me.ucrInputNewName.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(0, 52)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 3
        '
        'ucrDataFrameToRename
        '
        Me.ucrDataFrameToRename.Location = New System.Drawing.Point(0, 0)
        Me.ucrDataFrameToRename.Name = "ucrDataFrameToRename"
        Me.ucrDataFrameToRename.Size = New System.Drawing.Size(127, 41)
        Me.ucrDataFrameToRename.TabIndex = 2
        '
        'dlgRenameSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 110)
        Me.Controls.Add(Me.ucrInputNewName)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblNewName)
        Me.Controls.Add(Me.ucrDataFrameToRename)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgRenameSheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rename Sheet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrDataFrameToRename As ucrDataFrame
    Friend WithEvents lblNewName As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInputNewName As ucrInputTextBox
End Class
