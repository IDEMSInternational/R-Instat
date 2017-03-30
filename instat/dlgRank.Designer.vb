<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgRank
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
        Me.lblColumnsToRank = New System.Windows.Forms.Label()
        Me.grpTies = New System.Windows.Forms.GroupBox()
        Me.rdoRandom = New System.Windows.Forms.RadioButton()
        Me.rdoFirst = New System.Windows.Forms.RadioButton()
        Me.rdoMaximum = New System.Windows.Forms.RadioButton()
        Me.rdoMinimum = New System.Windows.Forms.RadioButton()
        Me.rdoAverage = New System.Windows.Forms.RadioButton()
        Me.ucrPanelTies = New instat.UcrPanel()
        Me.grpMissingValues = New System.Windows.Forms.GroupBox()
        Me.rdoKeptAsMissing = New System.Windows.Forms.RadioButton()
        Me.rdoLast = New System.Windows.Forms.RadioButton()
        Me.rdoFirstMissingValues = New System.Windows.Forms.RadioButton()
        Me.ucrPanelMissingValues = New instat.UcrPanel()
        Me.ucrSaveRank = New instat.ucrSave()
        Me.ucrSelectorForRank = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverRank = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpTies.SuspendLayout()
        Me.grpMissingValues.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumnsToRank
        '
        Me.lblColumnsToRank.AutoSize = True
        Me.lblColumnsToRank.Location = New System.Drawing.Point(244, 45)
        Me.lblColumnsToRank.Name = "lblColumnsToRank"
        Me.lblColumnsToRank.Size = New System.Drawing.Size(91, 13)
        Me.lblColumnsToRank.TabIndex = 1
        Me.lblColumnsToRank.Tag = ""
        Me.lblColumnsToRank.Text = "Columns to Rank:"
        '
        'grpTies
        '
        Me.grpTies.Controls.Add(Me.rdoRandom)
        Me.grpTies.Controls.Add(Me.rdoFirst)
        Me.grpTies.Controls.Add(Me.rdoMaximum)
        Me.grpTies.Controls.Add(Me.rdoMinimum)
        Me.grpTies.Controls.Add(Me.rdoAverage)
        Me.grpTies.Controls.Add(Me.ucrPanelTies)
        Me.grpTies.Location = New System.Drawing.Point(244, 89)
        Me.grpTies.Name = "grpTies"
        Me.grpTies.Size = New System.Drawing.Size(120, 135)
        Me.grpTies.TabIndex = 3
        Me.grpTies.TabStop = False
        Me.grpTies.Tag = "Ties"
        Me.grpTies.Text = "Ties"
        '
        'rdoRandom
        '
        Me.rdoRandom.AutoSize = True
        Me.rdoRandom.Location = New System.Drawing.Point(13, 113)
        Me.rdoRandom.Name = "rdoRandom"
        Me.rdoRandom.Size = New System.Drawing.Size(65, 17)
        Me.rdoRandom.TabIndex = 5
        Me.rdoRandom.TabStop = True
        Me.rdoRandom.Tag = "Random"
        Me.rdoRandom.Text = "Random"
        Me.rdoRandom.UseVisualStyleBackColor = True
        '
        'rdoFirst
        '
        Me.rdoFirst.AutoSize = True
        Me.rdoFirst.Location = New System.Drawing.Point(13, 90)
        Me.rdoFirst.Name = "rdoFirst"
        Me.rdoFirst.Size = New System.Drawing.Size(44, 17)
        Me.rdoFirst.TabIndex = 4
        Me.rdoFirst.TabStop = True
        Me.rdoFirst.Tag = "First"
        Me.rdoFirst.Text = "First"
        Me.rdoFirst.UseVisualStyleBackColor = True
        '
        'rdoMaximum
        '
        Me.rdoMaximum.AutoSize = True
        Me.rdoMaximum.Location = New System.Drawing.Point(13, 67)
        Me.rdoMaximum.Name = "rdoMaximum"
        Me.rdoMaximum.Size = New System.Drawing.Size(69, 17)
        Me.rdoMaximum.TabIndex = 3
        Me.rdoMaximum.TabStop = True
        Me.rdoMaximum.Tag = "Maximum"
        Me.rdoMaximum.Text = "Maximum"
        Me.rdoMaximum.UseVisualStyleBackColor = True
        '
        'rdoMinimum
        '
        Me.rdoMinimum.AutoSize = True
        Me.rdoMinimum.Location = New System.Drawing.Point(13, 44)
        Me.rdoMinimum.Name = "rdoMinimum"
        Me.rdoMinimum.Size = New System.Drawing.Size(66, 17)
        Me.rdoMinimum.TabIndex = 2
        Me.rdoMinimum.TabStop = True
        Me.rdoMinimum.Tag = "Minimum"
        Me.rdoMinimum.Text = "Minimum"
        Me.rdoMinimum.UseVisualStyleBackColor = True
        '
        'rdoAverage
        '
        Me.rdoAverage.AutoSize = True
        Me.rdoAverage.Location = New System.Drawing.Point(13, 21)
        Me.rdoAverage.Name = "rdoAverage"
        Me.rdoAverage.Size = New System.Drawing.Size(65, 17)
        Me.rdoAverage.TabIndex = 1
        Me.rdoAverage.TabStop = True
        Me.rdoAverage.Tag = "Average"
        Me.rdoAverage.Text = "Average"
        Me.rdoAverage.UseVisualStyleBackColor = True
        '
        'ucrPanelTies
        '
        Me.ucrPanelTies.Location = New System.Drawing.Point(3, 16)
        Me.ucrPanelTies.Name = "ucrPanelTies"
        Me.ucrPanelTies.Size = New System.Drawing.Size(96, 114)
        Me.ucrPanelTies.TabIndex = 0
        '
        'grpMissingValues
        '
        Me.grpMissingValues.Controls.Add(Me.rdoKeptAsMissing)
        Me.grpMissingValues.Controls.Add(Me.rdoLast)
        Me.grpMissingValues.Controls.Add(Me.rdoFirstMissingValues)
        Me.grpMissingValues.Controls.Add(Me.ucrPanelMissingValues)
        Me.grpMissingValues.Location = New System.Drawing.Point(10, 230)
        Me.grpMissingValues.Name = "grpMissingValues"
        Me.grpMissingValues.Size = New System.Drawing.Size(354, 48)
        Me.grpMissingValues.TabIndex = 4
        Me.grpMissingValues.TabStop = False
        Me.grpMissingValues.Tag = "Misssing_Values"
        Me.grpMissingValues.Text = "Missing Values"
        '
        'rdoKeptAsMissing
        '
        Me.rdoKeptAsMissing.AutoSize = True
        Me.rdoKeptAsMissing.Location = New System.Drawing.Point(12, 20)
        Me.rdoKeptAsMissing.Name = "rdoKeptAsMissing"
        Me.rdoKeptAsMissing.Size = New System.Drawing.Size(102, 17)
        Me.rdoKeptAsMissing.TabIndex = 1
        Me.rdoKeptAsMissing.TabStop = True
        Me.rdoKeptAsMissing.Tag = "Kept_as_missing"
        Me.rdoKeptAsMissing.Text = "Keep as Missing"
        Me.rdoKeptAsMissing.UseVisualStyleBackColor = True
        '
        'rdoLast
        '
        Me.rdoLast.AutoSize = True
        Me.rdoLast.Location = New System.Drawing.Point(292, 20)
        Me.rdoLast.Name = "rdoLast"
        Me.rdoLast.Size = New System.Drawing.Size(45, 17)
        Me.rdoLast.TabIndex = 3
        Me.rdoLast.TabStop = True
        Me.rdoLast.Tag = "Last"
        Me.rdoLast.Text = "Last"
        Me.rdoLast.UseVisualStyleBackColor = True
        '
        'rdoFirstMissingValues
        '
        Me.rdoFirstMissingValues.AutoSize = True
        Me.rdoFirstMissingValues.Location = New System.Drawing.Point(181, 20)
        Me.rdoFirstMissingValues.Name = "rdoFirstMissingValues"
        Me.rdoFirstMissingValues.Size = New System.Drawing.Size(44, 17)
        Me.rdoFirstMissingValues.TabIndex = 2
        Me.rdoFirstMissingValues.TabStop = True
        Me.rdoFirstMissingValues.Tag = "First"
        Me.rdoFirstMissingValues.Text = "First"
        Me.rdoFirstMissingValues.UseVisualStyleBackColor = True
        '
        'ucrPanelMissingValues
        '
        Me.ucrPanelMissingValues.Location = New System.Drawing.Point(6, 17)
        Me.ucrPanelMissingValues.Name = "ucrPanelMissingValues"
        Me.ucrPanelMissingValues.Size = New System.Drawing.Size(345, 23)
        Me.ucrPanelMissingValues.TabIndex = 0
        '
        'ucrSaveRank
        '
        Me.ucrSaveRank.Location = New System.Drawing.Point(10, 284)
        Me.ucrSaveRank.Name = "ucrSaveRank"
        Me.ucrSaveRank.Size = New System.Drawing.Size(271, 24)
        Me.ucrSaveRank.TabIndex = 5
        '
        'ucrSelectorForRank
        '
        Me.ucrSelectorForRank.bShowHiddenColumns = False
        Me.ucrSelectorForRank.bUseCurrentFilter = True
        Me.ucrSelectorForRank.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForRank.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForRank.Name = "ucrSelectorForRank"
        Me.ucrSelectorForRank.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForRank.TabIndex = 0
        '
        'ucrReceiverRank
        '
        Me.ucrReceiverRank.frmParent = Me
        Me.ucrReceiverRank.Location = New System.Drawing.Point(244, 60)
        Me.ucrReceiverRank.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRank.Name = "ucrReceiverRank"
        Me.ucrReceiverRank.Selector = Nothing
        Me.ucrReceiverRank.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRank.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 314)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 6
        '
        'dlgRank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 371)
        Me.Controls.Add(Me.ucrSaveRank)
        Me.Controls.Add(Me.grpMissingValues)
        Me.Controls.Add(Me.grpTies)
        Me.Controls.Add(Me.ucrSelectorForRank)
        Me.Controls.Add(Me.lblColumnsToRank)
        Me.Controls.Add(Me.ucrReceiverRank)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRank"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Rank"
        Me.Text = "Rank"
        Me.grpTies.ResumeLayout(False)
        Me.grpTies.PerformLayout()
        Me.grpMissingValues.ResumeLayout(False)
        Me.grpMissingValues.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverRank As ucrReceiverSingle
    Friend WithEvents lblColumnsToRank As Label
    Friend WithEvents grpMissingValues As GroupBox
    Friend WithEvents rdoKeptAsMissing As RadioButton
    Friend WithEvents rdoLast As RadioButton
    Friend WithEvents rdoFirstMissingValues As RadioButton
    Friend WithEvents ucrSelectorForRank As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpTies As GroupBox
    Friend WithEvents rdoRandom As RadioButton
    Friend WithEvents rdoFirst As RadioButton
    Friend WithEvents rdoMaximum As RadioButton
    Friend WithEvents rdoMinimum As RadioButton
    Friend WithEvents rdoAverage As RadioButton
    Friend WithEvents ucrPanelTies As UcrPanel
    Friend WithEvents ucrPanelMissingValues As UcrPanel
    Friend WithEvents ucrSaveRank As ucrSave
End Class
