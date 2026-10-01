<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrCellFormatEmail
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
        Me.ucrCboColors = New instat.ucrColors()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.ucrChkShowUnderline = New instat.ucrCheck()
        Me.ucrChkAsButton = New instat.ucrCheck()
        Me.ucrReceiverSingleDisplayName = New instat.ucrReceiverSingle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrCboColors
        '
        Me.ucrCboColors.AddQuotesIfUnrecognised = True
        Me.ucrCboColors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboColors.GetSetSelectedIndex = -1
        Me.ucrCboColors.IsReadOnly = False
        Me.ucrCboColors.Location = New System.Drawing.Point(9, 129)
        Me.ucrCboColors.Name = "ucrCboColors"
        Me.ucrCboColors.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboColors.TabIndex = 1
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(6, 113)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(34, 13)
        Me.lblColor.TabIndex = 2
        Me.lblColor.Text = "Color:"
        '
        'ucrChkShowUnderline
        '
        Me.ucrChkShowUnderline.AutoSize = True
        Me.ucrChkShowUnderline.Checked = False
        Me.ucrChkShowUnderline.Location = New System.Drawing.Point(6, 80)
        Me.ucrChkShowUnderline.Name = "ucrChkShowUnderline"
        Me.ucrChkShowUnderline.Size = New System.Drawing.Size(189, 23)
        Me.ucrChkShowUnderline.TabIndex = 3
        '
        'ucrChkAsButton
        '
        Me.ucrChkAsButton.AutoSize = True
        Me.ucrChkAsButton.Checked = False
        Me.ucrChkAsButton.Location = New System.Drawing.Point(6, 47)
        Me.ucrChkAsButton.Name = "ucrChkAsButton"
        Me.ucrChkAsButton.Size = New System.Drawing.Size(189, 23)
        Me.ucrChkAsButton.TabIndex = 4
        '
        'ucrReceiverSingleDisplayName
        '
        Me.ucrReceiverSingleDisplayName.AutoSize = True
        Me.ucrReceiverSingleDisplayName.frmParent = Nothing
        Me.ucrReceiverSingleDisplayName.Location = New System.Drawing.Point(10, 19)
        Me.ucrReceiverSingleDisplayName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingleDisplayName.Name = "ucrReceiverSingleDisplayName"
        Me.ucrReceiverSingleDisplayName.Selector = Nothing
        Me.ucrReceiverSingleDisplayName.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSingleDisplayName.strNcFilePath = ""
        Me.ucrReceiverSingleDisplayName.TabIndex = 5
        Me.ucrReceiverSingleDisplayName.ucrSelector = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Link Email To:"
        '
        'ucrCellFormatEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrReceiverSingleDisplayName)
        Me.Controls.Add(Me.ucrChkAsButton)
        Me.Controls.Add(Me.ucrChkShowUnderline)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.ucrCboColors)
        Me.Name = "ucrCellFormatEmail"
        Me.Size = New System.Drawing.Size(205, 154)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrCboColors As ucrColors
    Friend WithEvents lblColor As Label
    Friend WithEvents ucrChkShowUnderline As ucrCheck
    Friend WithEvents ucrChkAsButton As ucrCheck
    Friend WithEvents ucrReceiverSingleDisplayName As ucrReceiverSingle
    Friend WithEvents Label1 As Label
End Class
