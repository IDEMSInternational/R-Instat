<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCircularDensityPlot
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
        Me.ucrSelectorDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverVariable = New instat.ucrReceiverSingle()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.ucrSaveDensity = New instat.ucrSave()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrInputBandWidth = New instat.ucrInputTextBox()
        Me.lblBandWidth = New System.Windows.Forms.Label()
        Me.ucrInputComboKernel = New instat.ucrInputComboBox()
        Me.lblKernel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(5, 291)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorDataFrame
        '
        Me.ucrSelectorDataFrame.bDropUnusedFilterLevels = False
        Me.ucrSelectorDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorDataFrame.bUseCurrentFilter = True
        Me.ucrSelectorDataFrame.Location = New System.Drawing.Point(13, 13)
        Me.ucrSelectorDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDataFrame.Name = "ucrSelectorDataFrame"
        Me.ucrSelectorDataFrame.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDataFrame.TabIndex = 1
        '
        'ucrReceiverVariable
        '
        Me.ucrReceiverVariable.frmParent = Me
        Me.ucrReceiverVariable.Location = New System.Drawing.Point(295, 71)
        Me.ucrReceiverVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVariable.Name = "ucrReceiverVariable"
        Me.ucrReceiverVariable.Selector = Nothing
        Me.ucrReceiverVariable.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverVariable.strNcFilePath = ""
        Me.ucrReceiverVariable.TabIndex = 2
        Me.ucrReceiverVariable.ucrSelector = Nothing
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.Location = New System.Drawing.Point(290, 56)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(48, 13)
        Me.lblVariable.TabIndex = 3
        Me.lblVariable.Text = "Variable:"
        '
        'ucrSaveDensity
        '
        Me.ucrSaveDensity.Location = New System.Drawing.Point(13, 260)
        Me.ucrSaveDensity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveDensity.Name = "ucrSaveDensity"
        Me.ucrSaveDensity.Size = New System.Drawing.Size(249, 21)
        Me.ucrSaveDensity.TabIndex = 4
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(13, 214)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(170, 20)
        Me.ucrChkOmitMissing.TabIndex = 5
        '
        'ucrInputBandWidth
        '
        Me.ucrInputBandWidth.AddQuotesIfUnrecognised = True
        Me.ucrInputBandWidth.IsMultiline = False
        Me.ucrInputBandWidth.IsReadOnly = False
        Me.ucrInputBandWidth.Location = New System.Drawing.Point(295, 158)
        Me.ucrInputBandWidth.Name = "ucrInputBandWidth"
        Me.ucrInputBandWidth.Size = New System.Drawing.Size(56, 21)
        Me.ucrInputBandWidth.TabIndex = 6
        '
        'lblBandWidth
        '
        Me.lblBandWidth.AutoSize = True
        Me.lblBandWidth.Location = New System.Drawing.Point(290, 142)
        Me.lblBandWidth.Name = "lblBandWidth"
        Me.lblBandWidth.Size = New System.Drawing.Size(63, 13)
        Me.lblBandWidth.TabIndex = 7
        Me.lblBandWidth.Text = "Bandwidth: "
        '
        'ucrInputComboKernel
        '
        Me.ucrInputComboKernel.AddQuotesIfUnrecognised = True
        Me.ucrInputComboKernel.GetSetSelectedIndex = -1
        Me.ucrInputComboKernel.IsReadOnly = False
        Me.ucrInputComboKernel.Location = New System.Drawing.Point(295, 213)
        Me.ucrInputComboKernel.Name = "ucrInputComboKernel"
        Me.ucrInputComboKernel.Size = New System.Drawing.Size(93, 21)
        Me.ucrInputComboKernel.TabIndex = 8
        '
        'lblKernel
        '
        Me.lblKernel.AutoSize = True
        Me.lblKernel.Location = New System.Drawing.Point(290, 197)
        Me.lblKernel.Name = "lblKernel"
        Me.lblKernel.Size = New System.Drawing.Size(43, 13)
        Me.lblKernel.TabIndex = 9
        Me.lblKernel.Text = "Kernel :"
        '
        'dlgCircularDensityPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 347)
        Me.Controls.Add(Me.lblKernel)
        Me.Controls.Add(Me.ucrInputComboKernel)
        Me.Controls.Add(Me.lblBandWidth)
        Me.Controls.Add(Me.ucrInputBandWidth)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.ucrSaveDensity)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.ucrReceiverVariable)
        Me.Controls.Add(Me.ucrSelectorDataFrame)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCircularDensityPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Density Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverVariable As ucrReceiverSingle
    Friend WithEvents ucrSaveDensity As ucrSave
    Friend WithEvents lblVariable As Label
    Friend WithEvents ucrInputBandWidth As ucrInputTextBox
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents lblBandWidth As Label
    Friend WithEvents lblKernel As Label
    Friend WithEvents ucrInputComboKernel As ucrInputComboBox
End Class
