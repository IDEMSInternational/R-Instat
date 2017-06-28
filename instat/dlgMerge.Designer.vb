<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgMerge
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
        Me.cmdJoinOptions = New System.Windows.Forms.Button()
        Me.lnlJoinType = New System.Windows.Forms.Label()
        Me.ucrSaveMerge = New instat.ucrSave()
        Me.ucrInputJoinType = New instat.ucrInputComboBox()
        Me.ucrSecondDataFrame = New instat.ucrDataFrame()
        Me.ucrFirstDataFrame = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'cmdJoinOptions
        '
        Me.cmdJoinOptions.Location = New System.Drawing.Point(8, 121)
        Me.cmdJoinOptions.Name = "cmdJoinOptions"
        Me.cmdJoinOptions.Size = New System.Drawing.Size(115, 23)
        Me.cmdJoinOptions.TabIndex = 4
        Me.cmdJoinOptions.Text = "Merge Options"
        Me.cmdJoinOptions.UseVisualStyleBackColor = True
        '
        'lnlJoinType
        '
        Me.lnlJoinType.AutoSize = True
        Me.lnlJoinType.Location = New System.Drawing.Point(9, 88)
        Me.lnlJoinType.Name = "lnlJoinType"
        Me.lnlJoinType.Size = New System.Drawing.Size(56, 13)
        Me.lnlJoinType.TabIndex = 2
        Me.lnlJoinType.Text = "Join Type:"
        '
        'ucrSaveMerge
        '
        Me.ucrSaveMerge.Location = New System.Drawing.Point(9, 155)
        Me.ucrSaveMerge.Name = "ucrSaveMerge"
        Me.ucrSaveMerge.Size = New System.Drawing.Size(301, 24)
        Me.ucrSaveMerge.TabIndex = 5
        '
        'ucrInputJoinType
        '
        Me.ucrInputJoinType.AddQuotesIfUnrecognised = True
        Me.ucrInputJoinType.IsReadOnly = False
        Me.ucrInputJoinType.Location = New System.Drawing.Point(71, 85)
        Me.ucrInputJoinType.Name = "ucrInputJoinType"
        Me.ucrInputJoinType.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputJoinType.TabIndex = 3
        '
        'ucrSecondDataFrame
        '
        Me.ucrSecondDataFrame.bUseCurrentFilter = True
        Me.ucrSecondDataFrame.Location = New System.Drawing.Point(209, 22)
        Me.ucrSecondDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSecondDataFrame.Name = "ucrSecondDataFrame"
        Me.ucrSecondDataFrame.Size = New System.Drawing.Size(120, 50)
        Me.ucrSecondDataFrame.TabIndex = 1
        '
        'ucrFirstDataFrame
        '
        Me.ucrFirstDataFrame.bUseCurrentFilter = True
        Me.ucrFirstDataFrame.Location = New System.Drawing.Point(9, 22)
        Me.ucrFirstDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFirstDataFrame.Name = "ucrFirstDataFrame"
        Me.ucrFirstDataFrame.Size = New System.Drawing.Size(120, 50)
        Me.ucrFirstDataFrame.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(8, 185)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 6
        '
        'dlgMerge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 239)
        Me.Controls.Add(Me.ucrSaveMerge)
        Me.Controls.Add(Me.lnlJoinType)
        Me.Controls.Add(Me.ucrInputJoinType)
        Me.Controls.Add(Me.ucrSecondDataFrame)
        Me.Controls.Add(Me.ucrFirstDataFrame)
        Me.Controls.Add(Me.cmdJoinOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMerge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Merge"
        Me.Text = "Merge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdJoinOptions As Button
    Friend WithEvents ucrFirstDataFrame As ucrDataFrame
    Friend WithEvents ucrSecondDataFrame As ucrDataFrame
    Friend WithEvents ucrInputJoinType As ucrInputComboBox
    Friend WithEvents lnlJoinType As Label
    Friend WithEvents ucrSaveMerge As ucrSave
End Class
