<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFindInVariableOrFilter
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
        Me.ucrInputPattern = New instat.ucrInputTextBox()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.lblPattern = New System.Windows.Forms.Label()
        Me.ucrReceiverVariable = New instat.ucrReceiverSingle()
        Me.ucrSelectorFind = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'ucrInputPattern
        '
        Me.ucrInputPattern.AddQuotesIfUnrecognised = True
        Me.ucrInputPattern.AutoSize = True
        Me.ucrInputPattern.IsMultiline = False
        Me.ucrInputPattern.IsReadOnly = False
        Me.ucrInputPattern.Location = New System.Drawing.Point(427, 204)
        Me.ucrInputPattern.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputPattern.Name = "ucrInputPattern"
        Me.ucrInputPattern.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputPattern.TabIndex = 1
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(427, 248)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(112, 36)
        Me.cmdFind.TabIndex = 2
        Me.cmdFind.Text = "Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.Location = New System.Drawing.Point(428, 116)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(71, 20)
        Me.lblVariable.TabIndex = 3
        Me.lblVariable.Text = "Variable:"
        '
        'lblPattern
        '
        Me.lblPattern.AutoSize = True
        Me.lblPattern.Location = New System.Drawing.Point(428, 179)
        Me.lblPattern.Name = "lblPattern"
        Me.lblPattern.Size = New System.Drawing.Size(65, 20)
        Me.lblPattern.TabIndex = 4
        Me.lblPattern.Text = "Pattern:"
        '
        'ucrReceiverVariable
        '
        Me.ucrReceiverVariable.AutoSize = True
        Me.ucrReceiverVariable.frmParent = Me
        Me.ucrReceiverVariable.Location = New System.Drawing.Point(427, 139)
        Me.ucrReceiverVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVariable.Name = "ucrReceiverVariable"
        Me.ucrReceiverVariable.Selector = Nothing
        Me.ucrReceiverVariable.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverVariable.strNcFilePath = ""
        Me.ucrReceiverVariable.TabIndex = 10
        Me.ucrReceiverVariable.ucrSelector = Nothing
        '
        'ucrSelectorFind
        '
        Me.ucrSelectorFind.AutoSize = True
        Me.ucrSelectorFind.bDropUnusedFilterLevels = False
        Me.ucrSelectorFind.bShowHiddenColumns = False
        Me.ucrSelectorFind.bUseCurrentFilter = True
        Me.ucrSelectorFind.Location = New System.Drawing.Point(22, 64)
        Me.ucrSelectorFind.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFind.Name = "ucrSelectorFind"
        Me.ucrSelectorFind.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorFind.TabIndex = 11
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 351)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 13
        '
        'dlgFindInVariableOrFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(665, 442)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorFind)
        Me.Controls.Add(Me.ucrReceiverVariable)
        Me.Controls.Add(Me.lblPattern)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.ucrInputPattern)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgFindInVariableOrFilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find In Variable Or Filter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrInputPattern As ucrInputTextBox
    Friend WithEvents cmdFind As Button
    Friend WithEvents lblVariable As Label
    Friend WithEvents lblPattern As Label
    Friend WithEvents ucrReceiverVariable As ucrReceiverSingle
    Friend WithEvents ucrSelectorFind As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
End Class
