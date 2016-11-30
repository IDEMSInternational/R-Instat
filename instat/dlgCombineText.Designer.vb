<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCombineText
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
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.lblColumnsToCobine = New System.Windows.Forms.Label()
        Me.ucrInputSeparator = New instat.ucrInputComboBox()
        Me.ucrInputColumnInto = New instat.ucrInputComboBox()
        Me.ucrReceiverCombineText = New instat.ucrReceiverMultiple()
        Me.ucrSelectorForCombineText = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.Location = New System.Drawing.Point(255, 152)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(56, 13)
        Me.lblSeparator.TabIndex = 4
        Me.lblSeparator.Text = "Separator:"
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(9, 213)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(101, 13)
        Me.lblNewColumnName.TabIndex = 5
        Me.lblNewColumnName.Tag = "New_Column_Name:"
        Me.lblNewColumnName.Text = "New Column Name:"
        '
        'lblColumnsToCobine
        '
        Me.lblColumnsToCobine.AutoSize = True
        Me.lblColumnsToCobine.Location = New System.Drawing.Point(255, 28)
        Me.lblColumnsToCobine.Name = "lblColumnsToCobine"
        Me.lblColumnsToCobine.Size = New System.Drawing.Size(106, 13)
        Me.lblColumnsToCobine.TabIndex = 7
        Me.lblColumnsToCobine.Tag = "Columns_to_Combine:"
        Me.lblColumnsToCobine.Text = "Columns to Combine:"
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.IsReadOnly = False
        Me.ucrInputSeparator.Location = New System.Drawing.Point(255, 168)
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        Me.ucrInputSeparator.Size = New System.Drawing.Size(145, 21)
        Me.ucrInputSeparator.TabIndex = 10
        '
        'ucrInputColumnInto
        '
        Me.ucrInputColumnInto.IsReadOnly = False
        Me.ucrInputColumnInto.Location = New System.Drawing.Point(116, 209)
        Me.ucrInputColumnInto.Name = "ucrInputColumnInto"
        Me.ucrInputColumnInto.Size = New System.Drawing.Size(145, 21)
        Me.ucrInputColumnInto.TabIndex = 9
        '
        'ucrReceiverCombineText
        '
        Me.ucrReceiverCombineText.Location = New System.Drawing.Point(255, 44)
        Me.ucrReceiverCombineText.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCombineText.Name = "ucrReceiverCombineText"
        Me.ucrReceiverCombineText.Selector = Nothing
        Me.ucrReceiverCombineText.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverCombineText.TabIndex = 2
        '
        'ucrSelectorForCombineText
        '
        Me.ucrSelectorForCombineText.bShowHiddenColumns = False
        Me.ucrSelectorForCombineText.bUseCurrentFilter = True
        Me.ucrSelectorForCombineText.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForCombineText.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForCombineText.Name = "ucrSelectorForCombineText"
        Me.ucrSelectorForCombineText.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForCombineText.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 236)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'dlgCombineText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 297)
        Me.Controls.Add(Me.ucrInputSeparator)
        Me.Controls.Add(Me.ucrInputColumnInto)
        Me.Controls.Add(Me.lblColumnsToCobine)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.ucrReceiverCombineText)
        Me.Controls.Add(Me.ucrSelectorForCombineText)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCombineText"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Combine_Text_Columns"
        Me.Text = "Combine Text Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForCombineText As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverCombineText As ucrReceiverMultiple
    Friend WithEvents lblSeparator As Label
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents lblColumnsToCobine As Label
    Friend WithEvents ucrInputColumnInto As ucrInputComboBox
    Friend WithEvents ucrInputSeparator As ucrInputComboBox
End Class
