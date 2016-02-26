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
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.grpTies = New System.Windows.Forms.GroupBox()
        Me.rdoRandom = New System.Windows.Forms.RadioButton()
        Me.rdoFirst = New System.Windows.Forms.RadioButton()
        Me.rdoMaximum = New System.Windows.Forms.RadioButton()
        Me.rdoMinimum = New System.Windows.Forms.RadioButton()
        Me.rdoAverage = New System.Windows.Forms.RadioButton()
        Me.grpMissingValues = New System.Windows.Forms.GroupBox()
        Me.rdoKeptAsMissing = New System.Windows.Forms.RadioButton()
        Me.rdoLast = New System.Windows.Forms.RadioButton()
        Me.rdoFirstMissingValues = New System.Windows.Forms.RadioButton()
        Me.ucrSelectorForRank = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrNewColumnNameSelector = New instat.ucrNewColumnName()
        Me.ucrReceiverRank = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpTies.SuspendLayout()
        Me.grpMissingValues.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
        Me.lblSelectedVariable.Location = New System.Drawing.Point(261, 33)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(89, 13)
        Me.lblSelectedVariable.TabIndex = 1
        Me.lblSelectedVariable.Tag = "Selected_variable"
        Me.lblSelectedVariable.Text = "Selected variable"
        '
        'grpTies
        '
        Me.grpTies.Controls.Add(Me.rdoRandom)
        Me.grpTies.Controls.Add(Me.rdoFirst)
        Me.grpTies.Controls.Add(Me.rdoMaximum)
        Me.grpTies.Controls.Add(Me.rdoMinimum)
        Me.grpTies.Controls.Add(Me.rdoAverage)
        Me.grpTies.Location = New System.Drawing.Point(261, 81)
        Me.grpTies.Name = "grpTies"
        Me.grpTies.Size = New System.Drawing.Size(154, 140)
        Me.grpTies.TabIndex = 3
        Me.grpTies.TabStop = False
        Me.grpTies.Tag = "Ties"
        Me.grpTies.Text = "Ties"
        '
        'rdoRandom
        '
        Me.rdoRandom.AutoSize = True
        Me.rdoRandom.Location = New System.Drawing.Point(0, 115)
        Me.rdoRandom.Name = "rdoRandom"
        Me.rdoRandom.Size = New System.Drawing.Size(65, 17)
        Me.rdoRandom.TabIndex = 4
        Me.rdoRandom.TabStop = True
        Me.rdoRandom.Tag = "Random"
        Me.rdoRandom.Text = "Random"
        Me.rdoRandom.UseVisualStyleBackColor = True
        '
        'rdoFirst
        '
        Me.rdoFirst.AutoSize = True
        Me.rdoFirst.Location = New System.Drawing.Point(0, 91)
        Me.rdoFirst.Name = "rdoFirst"
        Me.rdoFirst.Size = New System.Drawing.Size(44, 17)
        Me.rdoFirst.TabIndex = 3
        Me.rdoFirst.TabStop = True
        Me.rdoFirst.Tag = "First"
        Me.rdoFirst.Text = "First"
        Me.rdoFirst.UseVisualStyleBackColor = True
        '
        'rdoMaximum
        '
        Me.rdoMaximum.AutoSize = True
        Me.rdoMaximum.Location = New System.Drawing.Point(0, 67)
        Me.rdoMaximum.Name = "rdoMaximum"
        Me.rdoMaximum.Size = New System.Drawing.Size(69, 17)
        Me.rdoMaximum.TabIndex = 2
        Me.rdoMaximum.TabStop = True
        Me.rdoMaximum.Tag = "Maximum"
        Me.rdoMaximum.Text = "Maximum"
        Me.rdoMaximum.UseVisualStyleBackColor = True
        '
        'rdoMinimum
        '
        Me.rdoMinimum.AutoSize = True
        Me.rdoMinimum.Location = New System.Drawing.Point(0, 43)
        Me.rdoMinimum.Name = "rdoMinimum"
        Me.rdoMinimum.Size = New System.Drawing.Size(66, 17)
        Me.rdoMinimum.TabIndex = 1
        Me.rdoMinimum.TabStop = True
        Me.rdoMinimum.Tag = "Minimum"
        Me.rdoMinimum.Text = "Minimum"
        Me.rdoMinimum.UseVisualStyleBackColor = True
        '
        'rdoAverage
        '
        Me.rdoAverage.AutoSize = True
        Me.rdoAverage.Location = New System.Drawing.Point(0, 19)
        Me.rdoAverage.Name = "rdoAverage"
        Me.rdoAverage.Size = New System.Drawing.Size(65, 17)
        Me.rdoAverage.TabIndex = 0
        Me.rdoAverage.TabStop = True
        Me.rdoAverage.Tag = "Average"
        Me.rdoAverage.Text = "Average"
        Me.rdoAverage.UseVisualStyleBackColor = True
        '
        'grpMissingValues
        '
        Me.grpMissingValues.Controls.Add(Me.rdoKeptAsMissing)
        Me.grpMissingValues.Controls.Add(Me.rdoLast)
        Me.grpMissingValues.Controls.Add(Me.rdoFirstMissingValues)
        Me.grpMissingValues.Location = New System.Drawing.Point(12, 202)
        Me.grpMissingValues.Name = "grpMissingValues"
        Me.grpMissingValues.Size = New System.Drawing.Size(180, 94)
        Me.grpMissingValues.TabIndex = 4
        Me.grpMissingValues.TabStop = False
        Me.grpMissingValues.Tag = "Misssing_values"
        Me.grpMissingValues.Text = "Missing values"
        '
        'rdoKeptAsMissing
        '
        Me.rdoKeptAsMissing.AutoSize = True
        Me.rdoKeptAsMissing.Location = New System.Drawing.Point(6, 19)
        Me.rdoKeptAsMissing.Name = "rdoKeptAsMissing"
        Me.rdoKeptAsMissing.Size = New System.Drawing.Size(98, 17)
        Me.rdoKeptAsMissing.TabIndex = 0
        Me.rdoKeptAsMissing.TabStop = True
        Me.rdoKeptAsMissing.Tag = "Kept_as_missing"
        Me.rdoKeptAsMissing.Text = "Kept as missing"
        Me.rdoKeptAsMissing.UseVisualStyleBackColor = True
        '
        'rdoLast
        '
        Me.rdoLast.AutoSize = True
        Me.rdoLast.Location = New System.Drawing.Point(7, 67)
        Me.rdoLast.Name = "rdoLast"
        Me.rdoLast.Size = New System.Drawing.Size(45, 17)
        Me.rdoLast.TabIndex = 2
        Me.rdoLast.TabStop = True
        Me.rdoLast.Tag = "Last"
        Me.rdoLast.Text = "Last"
        Me.rdoLast.UseVisualStyleBackColor = True
        '
        'rdoFirstMissingValues
        '
        Me.rdoFirstMissingValues.AutoSize = True
        Me.rdoFirstMissingValues.Location = New System.Drawing.Point(7, 42)
        Me.rdoFirstMissingValues.Name = "rdoFirstMissingValues"
        Me.rdoFirstMissingValues.Size = New System.Drawing.Size(44, 17)
        Me.rdoFirstMissingValues.TabIndex = 1
        Me.rdoFirstMissingValues.TabStop = True
        Me.rdoFirstMissingValues.Tag = "First"
        Me.rdoFirstMissingValues.Text = "First"
        Me.rdoFirstMissingValues.UseVisualStyleBackColor = True
        '
        'ucrSelectorForRank
        '
        Me.ucrSelectorForRank.Location = New System.Drawing.Point(13, 13)
        Me.ucrSelectorForRank.Name = "ucrSelectorForRank"
        Me.ucrSelectorForRank.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorForRank.TabIndex = 0
        '
        'ucrNewColumnNameSelector
        '
        Me.ucrNewColumnNameSelector.Location = New System.Drawing.Point(12, 302)
        Me.ucrNewColumnNameSelector.Name = "ucrNewColumnNameSelector"
        Me.ucrNewColumnNameSelector.Size = New System.Drawing.Size(367, 35)
        Me.ucrNewColumnNameSelector.TabIndex = 5
        Me.ucrNewColumnNameSelector.ucrDataFrameSelector = Nothing
        '
        'ucrReceiverRank
        '
        Me.ucrReceiverRank.Location = New System.Drawing.Point(261, 49)
        Me.ucrReceiverRank.Name = "ucrReceiverRank"
        Me.ucrReceiverRank.Selector = Nothing
        Me.ucrReceiverRank.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverRank.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 343)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(403, 53)
        Me.ucrBase.TabIndex = 6
        '
        'dlgRank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 408)
        Me.Controls.Add(Me.ucrSelectorForRank)
        Me.Controls.Add(Me.ucrNewColumnNameSelector)
        Me.Controls.Add(Me.grpMissingValues)
        Me.Controls.Add(Me.grpTies)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.ucrReceiverRank)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgRank"
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
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents grpTies As GroupBox
    Friend WithEvents rdoRandom As RadioButton
    Friend WithEvents rdoFirst As RadioButton
    Friend WithEvents rdoMaximum As RadioButton
    Friend WithEvents rdoMinimum As RadioButton
    Friend WithEvents rdoAverage As RadioButton
    Friend WithEvents grpMissingValues As GroupBox
    Friend WithEvents rdoKeptAsMissing As RadioButton
    Friend WithEvents rdoLast As RadioButton
    Friend WithEvents rdoFirstMissingValues As RadioButton
    Friend WithEvents ucrNewColumnNameSelector As ucrNewColumnName
    Friend WithEvents ucrSelectorForRank As ucrSelectorByDataFrameAddRemove
End Class
