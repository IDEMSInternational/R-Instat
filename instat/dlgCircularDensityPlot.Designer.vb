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
        Me.lblStats = New System.Windows.Forms.Label()
        Me.ucrInputStats = New instat.ucrInputComboBox()
        Me.ucrChkPercentages = New instat.ucrCheck()
        Me.ucrSaveDensity = New instat.ucrSave()
        Me.ucrVariablesAsFactorforDensity = New instat.ucrVariablesAsFactor()
        Me.ucrFactorReceiver = New instat.ucrReceiverSingle()
        Me.cmdDensityOptions = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrDensitySelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblfactor = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblStats
        '
        Me.lblStats.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStats.Location = New System.Drawing.Point(5, 267)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(32, 18)
        Me.lblStats.TabIndex = 47
        Me.lblStats.Text = "Stats"
        '
        'ucrInputStats
        '
        Me.ucrInputStats.AddQuotesIfUnrecognised = True
        Me.ucrInputStats.GetSetSelectedIndex = -1
        Me.ucrInputStats.IsReadOnly = False
        Me.ucrInputStats.Location = New System.Drawing.Point(48, 259)
        Me.ucrInputStats.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputStats.Name = "ucrInputStats"
        Me.ucrInputStats.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputStats.TabIndex = 48
        '
        'ucrChkPercentages
        '
        Me.ucrChkPercentages.Checked = False
        Me.ucrChkPercentages.Location = New System.Drawing.Point(194, 265)
        Me.ucrChkPercentages.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrChkPercentages.Name = "ucrChkPercentages"
        Me.ucrChkPercentages.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkPercentages.TabIndex = 50
        '
        'ucrSaveDensity
        '
        Me.ucrSaveDensity.Location = New System.Drawing.Point(5, 301)
        Me.ucrSaveDensity.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrSaveDensity.Name = "ucrSaveDensity"
        Me.ucrSaveDensity.Size = New System.Drawing.Size(255, 24)
        Me.ucrSaveDensity.TabIndex = 49
        '
        'ucrVariablesAsFactorforDensity
        '
        Me.ucrVariablesAsFactorforDensity.frmParent = Me
        Me.ucrVariablesAsFactorforDensity.Location = New System.Drawing.Point(242, 27)
        Me.ucrVariablesAsFactorforDensity.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrVariablesAsFactorforDensity.Name = "ucrVariablesAsFactorforDensity"
        Me.ucrVariablesAsFactorforDensity.Selector = Nothing
        Me.ucrVariablesAsFactorforDensity.Size = New System.Drawing.Size(125, 97)
        Me.ucrVariablesAsFactorforDensity.strNcFilePath = ""
        Me.ucrVariablesAsFactorforDensity.TabIndex = 42
        Me.ucrVariablesAsFactorforDensity.ucrSelector = Nothing
        Me.ucrVariablesAsFactorforDensity.ucrVariableSelector = Nothing
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.frmParent = Me
        Me.ucrFactorReceiver.Location = New System.Drawing.Point(242, 190)
        Me.ucrFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Selector = Nothing
        Me.ucrFactorReceiver.Size = New System.Drawing.Size(125, 20)
        Me.ucrFactorReceiver.strNcFilePath = ""
        Me.ucrFactorReceiver.TabIndex = 44
        Me.ucrFactorReceiver.ucrSelector = Nothing
        '
        'cmdDensityOptions
        '
        Me.cmdDensityOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDensityOptions.Location = New System.Drawing.Point(5, 195)
        Me.cmdDensityOptions.Name = "cmdDensityOptions"
        Me.cmdDensityOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdDensityOptions.TabIndex = 45
        Me.cmdDensityOptions.Tag = "Histogram_Options"
        Me.cmdDensityOptions.Text = "Density Options"
        Me.cmdDensityOptions.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(5, 226)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdOptions.TabIndex = 46
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrDensitySelector
        '
        Me.ucrDensitySelector.bDropUnusedFilterLevels = False
        Me.ucrDensitySelector.bShowHiddenColumns = False
        Me.ucrDensitySelector.bUseCurrentFilter = True
        Me.ucrDensitySelector.Location = New System.Drawing.Point(5, 7)
        Me.ucrDensitySelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDensitySelector.Name = "ucrDensitySelector"
        Me.ucrDensitySelector.Size = New System.Drawing.Size(214, 180)
        Me.ucrDensitySelector.TabIndex = 41
        '
        'lblfactor
        '
        Me.lblfactor.AutoSize = True
        Me.lblfactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblfactor.Location = New System.Drawing.Point(242, 175)
        Me.lblfactor.Name = "lblfactor"
        Me.lblfactor.Size = New System.Drawing.Size(85, 13)
        Me.lblfactor.TabIndex = 43
        Me.lblfactor.Tag = "Factor_Selected:"
        Me.lblfactor.Text = "Factor Selected:"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(5, 334)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 51
        '
        'dlgCircularDensityPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 389)
        Me.Controls.Add(Me.lblStats)
        Me.Controls.Add(Me.ucrInputStats)
        Me.Controls.Add(Me.ucrChkPercentages)
        Me.Controls.Add(Me.ucrSaveDensity)
        Me.Controls.Add(Me.ucrVariablesAsFactorforDensity)
        Me.Controls.Add(Me.ucrFactorReceiver)
        Me.Controls.Add(Me.cmdDensityOptions)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrDensitySelector)
        Me.Controls.Add(Me.lblfactor)
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

    Friend WithEvents lblStats As Label
    Friend WithEvents ucrInputStats As ucrInputComboBox
    Friend WithEvents ucrChkPercentages As ucrCheck
    Friend WithEvents ucrSaveDensity As ucrSave
    Friend WithEvents ucrVariablesAsFactorforDensity As ucrVariablesAsFactor
    Friend WithEvents ucrFactorReceiver As ucrReceiverSingle
    Friend WithEvents cmdDensityOptions As Button
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrDensitySelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblfactor As Label
    Friend WithEvents ucrBase As ucrButtons
End Class
