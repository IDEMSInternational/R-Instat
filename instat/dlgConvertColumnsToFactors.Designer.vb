<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgConvertColumnsToFactors
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFrameSelector = New instat.ucrDataFrame()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverColumnsToConvert = New instat.ucrReceiverMultiple()
        Me.lblColumnsToConvert = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(0, 244)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrDataFrameSelector
        '
        Me.ucrDataFrameSelector.Location = New System.Drawing.Point(0, 3)
        Me.ucrDataFrameSelector.Name = "ucrDataFrameSelector"
        Me.ucrDataFrameSelector.Size = New System.Drawing.Size(127, 41)
        Me.ucrDataFrameSelector.TabIndex = 1
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(0, 67)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 127)
        Me.ucrAddRemove.TabIndex = 2
        '
        'ucrReceiverColumnsToConvert
        '
        Me.ucrReceiverColumnsToConvert.Location = New System.Drawing.Point(229, 85)
        Me.ucrReceiverColumnsToConvert.Name = "ucrReceiverColumnsToConvert"
        Me.ucrReceiverColumnsToConvert.Size = New System.Drawing.Size(121, 104)
        Me.ucrReceiverColumnsToConvert.TabIndex = 3
        '
        'lblColumnsToConvert
        '
        Me.lblColumnsToConvert.AutoSize = True
        Me.lblColumnsToConvert.Location = New System.Drawing.Point(235, 70)
        Me.lblColumnsToConvert.Name = "lblColumnsToConvert"
        Me.lblColumnsToConvert.Size = New System.Drawing.Size(98, 13)
        Me.lblColumnsToConvert.TabIndex = 4
        Me.lblColumnsToConvert.Tag = "Columns_to_convert"
        Me.lblColumnsToConvert.Text = "Columns to convert"
        '
        'dlgConvertColumnsToFactors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 295)
        Me.Controls.Add(Me.lblColumnsToConvert)
        Me.Controls.Add(Me.ucrReceiverColumnsToConvert)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrDataFrameSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgConvertColumnsToFactors"
        Me.Tag = "Convert_columns_to_factors"
        Me.Text = "Convert Columns To Factors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameSelector As ucrDataFrame
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverColumnsToConvert As ucrReceiverMultiple
    Friend WithEvents lblColumnsToConvert As Label
End Class
