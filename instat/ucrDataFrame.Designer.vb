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
        Me.lblDataFrame = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboAvailableDataFrames
        '
        Me.cboAvailableDataFrames.FormattingEnabled = True
        Me.cboAvailableDataFrames.Location = New System.Drawing.Point(0, 25)
        Me.cboAvailableDataFrames.Name = "cboAvailableDataFrames"
        Me.cboAvailableDataFrames.Size = New System.Drawing.Size(120, 21)
        Me.cboAvailableDataFrames.TabIndex = 0
        '
        'lblDataFrame
        '
        Me.lblDataFrame.Location = New System.Drawing.Point(0, 3)
        Me.lblDataFrame.Name = "lblDataFrame"
        Me.lblDataFrame.Size = New System.Drawing.Size(65, 13)
        Me.lblDataFrame.TabIndex = 1
        Me.lblDataFrame.Tag = "Data_Frame:"
        Me.lblDataFrame.Text = "Data Frame:"
        '
        'ucrDataFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblDataFrame)
        Me.Controls.Add(Me.cboAvailableDataFrames)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ucrDataFrame"
        Me.Size = New System.Drawing.Size(120, 50)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboAvailableDataFrames As ComboBox
    Friend WithEvents lblDataFrame As Label
End Class
