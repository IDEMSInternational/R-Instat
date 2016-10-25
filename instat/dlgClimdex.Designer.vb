<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimdex
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
        Me.lblTmax = New System.Windows.Forms.Label()
        Me.lblTmin = New System.Windows.Forms.Label()
        Me.lblPrec = New System.Windows.Forms.Label()
        Me.cmdClimdexIndices = New System.Windows.Forms.Button()
        Me.ucrReceiverPrec = New instat.ucrReceiverSingle()
        Me.ucrReceiverTmin = New instat.ucrReceiverSingle()
        Me.ucrReceiverTmax = New instat.ucrReceiverSingle()
        Me.ucrSelectorClimdex = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseClimdex = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblTmax
        '
        Me.lblTmax.AutoSize = True
        Me.lblTmax.Location = New System.Drawing.Point(292, 9)
        Me.lblTmax.Name = "lblTmax"
        Me.lblTmax.Size = New System.Drawing.Size(33, 13)
        Me.lblTmax.TabIndex = 6
        Me.lblTmax.Tag = "Tmax"
        Me.lblTmax.Text = "Tmax"
        '
        'lblTmin
        '
        Me.lblTmin.AutoSize = True
        Me.lblTmin.Location = New System.Drawing.Point(295, 53)
        Me.lblTmin.Name = "lblTmin"
        Me.lblTmin.Size = New System.Drawing.Size(30, 13)
        Me.lblTmin.TabIndex = 7
        Me.lblTmin.Tag = "Tmin"
        Me.lblTmin.Text = "Tmin"
        '
        'lblPrec
        '
        Me.lblPrec.AutoSize = True
        Me.lblPrec.Location = New System.Drawing.Point(296, 105)
        Me.lblPrec.Name = "lblPrec"
        Me.lblPrec.Size = New System.Drawing.Size(29, 13)
        Me.lblPrec.TabIndex = 8
        Me.lblPrec.Tag = "Prec"
        Me.lblPrec.Text = "Prec"
        '
        'cmdClimdexIndices
        '
        Me.cmdClimdexIndices.Location = New System.Drawing.Point(261, 157)
        Me.cmdClimdexIndices.Name = "cmdClimdexIndices"
        Me.cmdClimdexIndices.Size = New System.Drawing.Size(98, 23)
        Me.cmdClimdexIndices.TabIndex = 9
        Me.cmdClimdexIndices.Tag = "Climdex_Indices..."
        Me.cmdClimdexIndices.Text = "Climdex Indices..."
        Me.cmdClimdexIndices.UseVisualStyleBackColor = True
        '
        'ucrReceiverPrec
        '
        Me.ucrReceiverPrec.Location = New System.Drawing.Point(248, 127)
        Me.ucrReceiverPrec.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPrec.Name = "ucrReceiverPrec"
        Me.ucrReceiverPrec.Selector = Nothing
        Me.ucrReceiverPrec.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPrec.TabIndex = 5
        '
        'ucrReceiverTmin
        '
        Me.ucrReceiverTmin.Location = New System.Drawing.Point(248, 75)
        Me.ucrReceiverTmin.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTmin.Name = "ucrReceiverTmin"
        Me.ucrReceiverTmin.Selector = Nothing
        Me.ucrReceiverTmin.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverTmin.TabIndex = 4
        '
        'ucrReceiverTmax
        '
        Me.ucrReceiverTmax.Location = New System.Drawing.Point(248, 22)
        Me.ucrReceiverTmax.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTmax.Name = "ucrReceiverTmax"
        Me.ucrReceiverTmax.Selector = Nothing
        Me.ucrReceiverTmax.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverTmax.TabIndex = 3
        '
        'ucrSelectorClimdex
        '
        Me.ucrSelectorClimdex.bShowHiddenColumns = False
        Me.ucrSelectorClimdex.bUseCurrentFilter = False
        Me.ucrSelectorClimdex.Location = New System.Drawing.Point(13, 9)
        Me.ucrSelectorClimdex.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorClimdex.Name = "ucrSelectorClimdex"
        Me.ucrSelectorClimdex.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorClimdex.TabIndex = 2
        '
        'ucrBaseClimdex
        '
        Me.ucrBaseClimdex.Location = New System.Drawing.Point(13, 246)
        Me.ucrBaseClimdex.Name = "ucrBaseClimdex"
        Me.ucrBaseClimdex.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseClimdex.TabIndex = 0
        '
        'dlgClimdex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 307)
        Me.Controls.Add(Me.cmdClimdexIndices)
        Me.Controls.Add(Me.lblPrec)
        Me.Controls.Add(Me.lblTmin)
        Me.Controls.Add(Me.lblTmax)
        Me.Controls.Add(Me.ucrReceiverPrec)
        Me.Controls.Add(Me.ucrReceiverTmin)
        Me.Controls.Add(Me.ucrReceiverTmax)
        Me.Controls.Add(Me.ucrSelectorClimdex)
        Me.Controls.Add(Me.ucrBaseClimdex)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimdex"
        Me.Tag = "Climdex"
        Me.Text = "Climdex"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseClimdex As ucrButtons

    Friend WithEvents ucrSelectorClimdex As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverTmax As ucrReceiverSingle
    Friend WithEvents ucrReceiverTmin As ucrReceiverSingle
    Friend WithEvents ucrReceiverPrec As ucrReceiverSingle
    Friend WithEvents lblTmax As Label
    Friend WithEvents lblTmin As Label
    Friend WithEvents lblPrec As Label
    Friend WithEvents cmdClimdexIndices As Button
End Class