<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrDataFrame
    Inherits System.Windows.Forms.UserControl

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
        Me.cboAvailableDataFrames = New System.Windows.Forms.ComboBox()
        Me.lblSelectDataFrame = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboAvailableDataFrames
        '
        Me.cboAvailableDataFrames.FormattingEnabled = True
        Me.cboAvailableDataFrames.Location = New System.Drawing.Point(14, 29)
        Me.cboAvailableDataFrames.Name = "cboAvailableDataFrames"
        Me.cboAvailableDataFrames.Size = New System.Drawing.Size(121, 21)
        Me.cboAvailableDataFrames.TabIndex = 0
        '
        'lblSelectDataFrame
        '
        Me.lblSelectDataFrame.AutoSize = True
        Me.lblSelectDataFrame.Location = New System.Drawing.Point(11, 9)
        Me.lblSelectDataFrame.Name = "lblSelectDataFrame"
        Me.lblSelectDataFrame.Size = New System.Drawing.Size(98, 13)
        Me.lblSelectDataFrame.TabIndex = 1
        Me.lblSelectDataFrame.Text = "Select Data Frame:"
        '
        'ucrDataFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblSelectDataFrame)
        Me.Controls.Add(Me.cboAvailableDataFrames)
        Me.Name = "ucrDataFrame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboAvailableDataFrames As ComboBox
    Friend WithEvents lblSelectDataFrame As Label
End Class
