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
        Me.cmdIndices = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverPrec = New instat.ucrReceiverSingle()
        Me.ucrReceiverTmin = New instat.ucrReceiverSingle()
        Me.ucrReceiverTmax = New instat.ucrReceiverSingle()
        Me.ucrSelectorClimdex = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseClimdex = New instat.ucrButtons()
        Me.ucrChkSave = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblTmax
        '
        Me.lblTmax.AutoSize = True
        Me.lblTmax.Location = New System.Drawing.Point(286, 63)
        Me.lblTmax.Name = "lblTmax"
        Me.lblTmax.Size = New System.Drawing.Size(33, 13)
        Me.lblTmax.TabIndex = 3
        Me.lblTmax.Tag = "Tmax"
        Me.lblTmax.Text = "Tmax"
        '
        'lblTmin
        '
        Me.lblTmin.AutoSize = True
        Me.lblTmin.Location = New System.Drawing.Point(286, 100)
        Me.lblTmin.Name = "lblTmin"
        Me.lblTmin.Size = New System.Drawing.Size(30, 13)
        Me.lblTmin.TabIndex = 5
        Me.lblTmin.Tag = "Tmin"
        Me.lblTmin.Text = "Tmin"
        '
        'lblPrec
        '
        Me.lblPrec.AutoSize = True
        Me.lblPrec.Location = New System.Drawing.Point(286, 139)
        Me.lblPrec.Name = "lblPrec"
        Me.lblPrec.Size = New System.Drawing.Size(29, 13)
        Me.lblPrec.TabIndex = 7
        Me.lblPrec.Tag = "Prec"
        Me.lblPrec.Text = "Prec"
        '
        'cmdIndices
        '
        Me.cmdIndices.Location = New System.Drawing.Point(286, 193)
        Me.cmdIndices.Name = "cmdIndices"
        Me.cmdIndices.Size = New System.Drawing.Size(62, 23)
        Me.cmdIndices.TabIndex = 10
        Me.cmdIndices.Tag = "Indices..."
        Me.cmdIndices.Text = "Indices..."
        Me.cmdIndices.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(286, 20)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Tag = "Date"
        Me.lblDate.Text = "Date"
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(286, 39)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.TabIndex = 2
        '
        'ucrReceiverPrec
        '
        Me.ucrReceiverPrec.frmParent = Me
        Me.ucrReceiverPrec.Location = New System.Drawing.Point(286, 156)
        Me.ucrReceiverPrec.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPrec.Name = "ucrReceiverPrec"
        Me.ucrReceiverPrec.Selector = Nothing
        Me.ucrReceiverPrec.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPrec.TabIndex = 8
        '
        'ucrReceiverTmin
        '
        Me.ucrReceiverTmin.frmParent = Me
        Me.ucrReceiverTmin.Location = New System.Drawing.Point(286, 116)
        Me.ucrReceiverTmin.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTmin.Name = "ucrReceiverTmin"
        Me.ucrReceiverTmin.Selector = Nothing
        Me.ucrReceiverTmin.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverTmin.TabIndex = 6
        '
        'ucrReceiverTmax
        '
        Me.ucrReceiverTmax.frmParent = Me
        Me.ucrReceiverTmax.Location = New System.Drawing.Point(286, 79)
        Me.ucrReceiverTmax.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTmax.Name = "ucrReceiverTmax"
        Me.ucrReceiverTmax.Selector = Nothing
        Me.ucrReceiverTmax.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverTmax.TabIndex = 4
        '
        'ucrSelectorClimdex
        '
        Me.ucrSelectorClimdex.bShowHiddenColumns = False
        Me.ucrSelectorClimdex.bUseCurrentFilter = True
        Me.ucrSelectorClimdex.Location = New System.Drawing.Point(10, 3)
        Me.ucrSelectorClimdex.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorClimdex.Name = "ucrSelectorClimdex"
        Me.ucrSelectorClimdex.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorClimdex.TabIndex = 0
        '
        'ucrBaseClimdex
        '
        Me.ucrBaseClimdex.Location = New System.Drawing.Point(10, 222)
        Me.ucrBaseClimdex.Name = "ucrBaseClimdex"
        Me.ucrBaseClimdex.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseClimdex.TabIndex = 11
        '
        'ucrChkSave
        '
        Me.ucrChkSave.Checked = False
        Me.ucrChkSave.Location = New System.Drawing.Point(10, 196)
        Me.ucrChkSave.Name = "ucrChkSave"
        Me.ucrChkSave.Size = New System.Drawing.Size(107, 20)
        Me.ucrChkSave.TabIndex = 9
        '
        'dlgClimdex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 278)
        Me.Controls.Add(Me.ucrChkSave)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.cmdIndices)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Climdex Indices"
        Me.Text = "Climdex Indices"
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
    Friend WithEvents cmdIndices As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrChkSave As ucrCheck
End Class