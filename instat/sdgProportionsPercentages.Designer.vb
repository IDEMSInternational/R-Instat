<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgProportionsPercentages
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgProportionsPercentages))
        Me.rdoByFactors = New System.Windows.Forms.RadioButton()
        Me.rdoByFilter = New System.Windows.Forms.RadioButton()
        Me.rdoByColumn = New System.Windows.Forms.RadioButton()
        Me.lblByFactors = New System.Windows.Forms.Label()
        Me.lblColumn = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkDisplayAsDecimal = New instat.ucrCheck()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.ucrReceiverFilter = New instat.ucrReceiverSingle()
        Me.ucrReceiverColumn = New instat.ucrReceiverSingle()
        Me.ucrButtonsProportionsPercentiles = New instat.ucrButtonsSubdialogue()
        Me.ucrReceiverByFactor = New instat.ucrReceiverMultiple()
        Me.ucrSelectorProportionsPercentiles = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlBY = New instat.UcrPanel()
        Me.ucrChkProportionsPercentages = New instat.ucrCheck()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoByFactors
        '
        resources.ApplyResources(Me.rdoByFactors, "rdoByFactors")
        Me.rdoByFactors.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByFactors.FlatAppearance.BorderSize = 2
        Me.rdoByFactors.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByFactors.Name = "rdoByFactors"
        Me.rdoByFactors.TabStop = True
        Me.rdoByFactors.UseVisualStyleBackColor = True
        '
        'rdoByFilter
        '
        resources.ApplyResources(Me.rdoByFilter, "rdoByFilter")
        Me.rdoByFilter.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByFilter.FlatAppearance.BorderSize = 2
        Me.rdoByFilter.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByFilter.Name = "rdoByFilter"
        Me.rdoByFilter.TabStop = True
        Me.rdoByFilter.UseVisualStyleBackColor = True
        '
        'rdoByColumn
        '
        resources.ApplyResources(Me.rdoByColumn, "rdoByColumn")
        Me.rdoByColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByColumn.FlatAppearance.BorderSize = 2
        Me.rdoByColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByColumn.Name = "rdoByColumn"
        Me.rdoByColumn.TabStop = True
        Me.rdoByColumn.UseVisualStyleBackColor = True
        '
        'lblByFactors
        '
        resources.ApplyResources(Me.lblByFactors, "lblByFactors")
        Me.lblByFactors.Name = "lblByFactors"
        '
        'lblColumn
        '
        resources.ApplyResources(Me.lblColumn, "lblColumn")
        Me.lblColumn.Name = "lblColumn"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrChkDisplayAsDecimal)
        resources.ApplyResources(Me.grpOptions, "grpOptions")
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.TabStop = False
        '
        'ucrChkDisplayAsDecimal
        '
        Me.ucrChkDisplayAsDecimal.Checked = False
        resources.ApplyResources(Me.ucrChkDisplayAsDecimal, "ucrChkDisplayAsDecimal")
        Me.ucrChkDisplayAsDecimal.Name = "ucrChkDisplayAsDecimal"
        '
        'lblFilter
        '
        resources.ApplyResources(Me.lblFilter, "lblFilter")
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.UseMnemonic = False
        '
        'ucrReceiverFilter
        '
        Me.ucrReceiverFilter.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFilter, "ucrReceiverFilter")
        Me.ucrReceiverFilter.Name = "ucrReceiverFilter"
        Me.ucrReceiverFilter.Selector = Nothing
        Me.ucrReceiverFilter.strNcFilePath = ""
        Me.ucrReceiverFilter.ucrSelector = Nothing
        '
        'ucrReceiverColumn
        '
        Me.ucrReceiverColumn.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverColumn, "ucrReceiverColumn")
        Me.ucrReceiverColumn.Name = "ucrReceiverColumn"
        Me.ucrReceiverColumn.Selector = Nothing
        Me.ucrReceiverColumn.strNcFilePath = ""
        Me.ucrReceiverColumn.ucrSelector = Nothing
        '
        'ucrButtonsProportionsPercentiles
        '
        resources.ApplyResources(Me.ucrButtonsProportionsPercentiles, "ucrButtonsProportionsPercentiles")
        Me.ucrButtonsProportionsPercentiles.Name = "ucrButtonsProportionsPercentiles"
        '
        'ucrReceiverByFactor
        '
        Me.ucrReceiverByFactor.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverByFactor, "ucrReceiverByFactor")
        Me.ucrReceiverByFactor.Name = "ucrReceiverByFactor"
        Me.ucrReceiverByFactor.Selector = Nothing
        Me.ucrReceiverByFactor.strNcFilePath = ""
        Me.ucrReceiverByFactor.ucrSelector = Nothing
        '
        'ucrSelectorProportionsPercentiles
        '
        Me.ucrSelectorProportionsPercentiles.bShowHiddenColumns = False
        Me.ucrSelectorProportionsPercentiles.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorProportionsPercentiles, "ucrSelectorProportionsPercentiles")
        Me.ucrSelectorProportionsPercentiles.Name = "ucrSelectorProportionsPercentiles"
        '
        'ucrPnlBY
        '
        resources.ApplyResources(Me.ucrPnlBY, "ucrPnlBY")
        Me.ucrPnlBY.Name = "ucrPnlBY"
        '
        'ucrChkProportionsPercentages
        '
        Me.ucrChkProportionsPercentages.Checked = False
        resources.ApplyResources(Me.ucrChkProportionsPercentages, "ucrChkProportionsPercentages")
        Me.ucrChkProportionsPercentages.Name = "ucrChkProportionsPercentages"
        '
        'sdgProportionsPercentages
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.ucrReceiverFilter)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.lblColumn)
        Me.Controls.Add(Me.ucrReceiverColumn)
        Me.Controls.Add(Me.ucrButtonsProportionsPercentiles)
        Me.Controls.Add(Me.ucrReceiverByFactor)
        Me.Controls.Add(Me.lblByFactors)
        Me.Controls.Add(Me.ucrSelectorProportionsPercentiles)
        Me.Controls.Add(Me.rdoByColumn)
        Me.Controls.Add(Me.rdoByFactors)
        Me.Controls.Add(Me.rdoByFilter)
        Me.Controls.Add(Me.ucrPnlBY)
        Me.Controls.Add(Me.ucrChkProportionsPercentages)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgProportionsPercentages"
        Me.grpOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrChkProportionsPercentages As ucrCheck
    Friend WithEvents rdoByFactors As RadioButton
    Friend WithEvents rdoByFilter As RadioButton
    Friend WithEvents ucrPnlBY As UcrPanel
    Friend WithEvents rdoByColumn As RadioButton
    Friend WithEvents ucrSelectorProportionsPercentiles As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverByFactor As ucrReceiverMultiple
    Friend WithEvents lblByFactors As Label
    Friend WithEvents ucrButtonsProportionsPercentiles As ucrButtonsSubdialogue
    Friend WithEvents ucrReceiverColumn As ucrReceiverSingle
    Friend WithEvents lblColumn As Label
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents ucrChkDisplayAsDecimal As ucrCheck
    Friend WithEvents lblFilter As Label
    Friend WithEvents ucrReceiverFilter As ucrReceiverSingle
End Class
