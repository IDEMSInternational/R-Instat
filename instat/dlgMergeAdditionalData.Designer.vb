<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMergeAdditionalData
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
        Me.lblVariablesToIncludeSecond = New System.Windows.Forms.Label()
        Me.cmdModify = New System.Windows.Forms.Button()
        Me.ucrInputMergingBy = New instat.ucrInputTextBox()
        Me.ucrFirstDataFrame = New instat.ucrDataFrame()
        Me.ucrReceiverSecond = New instat.ucrReceiverMultiple()
        Me.ucrSecondSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblMergeBy = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblVariablesToIncludeSecond
        '
        Me.lblVariablesToIncludeSecond.AutoSize = True
        Me.lblVariablesToIncludeSecond.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVariablesToIncludeSecond.Location = New System.Drawing.Point(248, 121)
        Me.lblVariablesToIncludeSecond.Name = "lblVariablesToIncludeSecond"
        Me.lblVariablesToIncludeSecond.Size = New System.Drawing.Size(103, 13)
        Me.lblVariablesToIncludeSecond.TabIndex = 2
        Me.lblVariablesToIncludeSecond.Text = "Variables to Include:"
        '
        'cmdModify
        '
        Me.cmdModify.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdModify.Location = New System.Drawing.Point(282, 332)
        Me.cmdModify.Name = "cmdModify"
        Me.cmdModify.Size = New System.Drawing.Size(90, 23)
        Me.cmdModify.TabIndex = 6
        Me.cmdModify.Text = "Join Options"
        Me.cmdModify.UseVisualStyleBackColor = True
        '
        'ucrInputMergingBy
        '
        Me.ucrInputMergingBy.AddQuotesIfUnrecognised = True
        Me.ucrInputMergingBy.AutoSize = True
        Me.ucrInputMergingBy.IsMultiline = False
        Me.ucrInputMergingBy.IsReadOnly = False
        Me.ucrInputMergingBy.Location = New System.Drawing.Point(72, 286)
        Me.ucrInputMergingBy.Name = "ucrInputMergingBy"
        Me.ucrInputMergingBy.Size = New System.Drawing.Size(300, 40)
        Me.ucrInputMergingBy.TabIndex = 5
        '
        'ucrFirstDataFrame
        '
        Me.ucrFirstDataFrame.AutoSize = True
        Me.ucrFirstDataFrame.bDropUnusedFilterLevels = False
        Me.ucrFirstDataFrame.bUseCurrentFilter = True
        Me.ucrFirstDataFrame.Location = New System.Drawing.Point(10, 10)
        Me.ucrFirstDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFirstDataFrame.Name = "ucrFirstDataFrame"
        Me.ucrFirstDataFrame.Size = New System.Drawing.Size(151, 50)
        Me.ucrFirstDataFrame.TabIndex = 0
        '
        'ucrReceiverSecond
        '
        Me.ucrReceiverSecond.AutoSize = True
        Me.ucrReceiverSecond.frmParent = Me
        Me.ucrReceiverSecond.Location = New System.Drawing.Point(248, 136)
        Me.ucrReceiverSecond.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecond.Name = "ucrReceiverSecond"
        Me.ucrReceiverSecond.Selector = Nothing
        Me.ucrReceiverSecond.Size = New System.Drawing.Size(120, 119)
        Me.ucrReceiverSecond.strNcFilePath = ""
        Me.ucrReceiverSecond.TabIndex = 3
        Me.ucrReceiverSecond.ucrSelector = Nothing
        '
        'ucrSecondSelector
        '
        Me.ucrSecondSelector.AutoSize = True
        Me.ucrSecondSelector.bDropUnusedFilterLevels = False
        Me.ucrSecondSelector.bShowHiddenColumns = False
        Me.ucrSecondSelector.bUseCurrentFilter = True
        Me.ucrSecondSelector.Location = New System.Drawing.Point(10, 86)
        Me.ucrSecondSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSecondSelector.Name = "ucrSecondSelector"
        Me.ucrSecondSelector.Size = New System.Drawing.Size(213, 183)
        Me.ucrSecondSelector.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 364)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 7
        '
        'lblMergeBy
        '
        Me.lblMergeBy.AutoSize = True
        Me.lblMergeBy.Location = New System.Drawing.Point(12, 289)
        Me.lblMergeBy.Name = "lblMergeBy"
        Me.lblMergeBy.Size = New System.Drawing.Size(44, 13)
        Me.lblMergeBy.TabIndex = 4
        Me.lblMergeBy.Text = "Join By:"
        '
        'dlgMergeAdditionalData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(420, 424)
        Me.Controls.Add(Me.lblMergeBy)
        Me.Controls.Add(Me.cmdModify)
        Me.Controls.Add(Me.ucrInputMergingBy)
        Me.Controls.Add(Me.ucrFirstDataFrame)
        Me.Controls.Add(Me.lblVariablesToIncludeSecond)
        Me.Controls.Add(Me.ucrReceiverSecond)
        Me.Controls.Add(Me.ucrSecondSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMergeAdditionalData"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Merge Additional Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblVariablesToIncludeSecond As Label
    Friend WithEvents ucrReceiverSecond As ucrReceiverMultiple
    Friend WithEvents ucrSecondSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFirstDataFrame As ucrDataFrame
    Friend WithEvents ucrInputMergingBy As ucrInputTextBox
    Friend WithEvents cmdModify As Button
    Friend WithEvents lblMergeBy As Label
End Class
