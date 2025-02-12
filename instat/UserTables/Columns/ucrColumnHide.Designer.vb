<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrColumnHide
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
        Me.ucrReceiverMultipleCols = New instat.ucrReceiverMultiple()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrSelectorCols = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'ucrReceiverMultipleCols
        '
        Me.ucrReceiverMultipleCols.AutoSize = True
        Me.ucrReceiverMultipleCols.frmParent = Nothing
        Me.ucrReceiverMultipleCols.Location = New System.Drawing.Point(335, 37)
        Me.ucrReceiverMultipleCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleCols.Name = "ucrReceiverMultipleCols"
        Me.ucrReceiverMultipleCols.Selector = Nothing
        Me.ucrReceiverMultipleCols.Size = New System.Drawing.Size(180, 123)
        Me.ucrReceiverMultipleCols.strNcFilePath = ""
        Me.ucrReceiverMultipleCols.TabIndex = 356
        Me.ucrReceiverMultipleCols.ucrSelector = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(340, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 357
        Me.Label1.Text = "Column(s):"
        '
        'ucrSelectorCols
        '
        Me.ucrSelectorCols.AutoSize = True
        Me.ucrSelectorCols.bDropUnusedFilterLevels = False
        Me.ucrSelectorCols.bShowHiddenColumns = False
        Me.ucrSelectorCols.bUseCurrentFilter = True
        Me.ucrSelectorCols.Location = New System.Drawing.Point(9, 6)
        Me.ucrSelectorCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCols.Name = "ucrSelectorCols"
        Me.ucrSelectorCols.Size = New System.Drawing.Size(289, 292)
        Me.ucrSelectorCols.TabIndex = 355
        '
        'ucrColumnHide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrReceiverMultipleCols)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrSelectorCols)
        Me.Name = "ucrColumnHide"
        Me.Size = New System.Drawing.Size(523, 312)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrReceiverMultipleCols As ucrReceiverMultiple
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrSelectorCols As ucrSelectorByDataFrameAddRemove
End Class
