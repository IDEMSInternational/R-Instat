<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgViewFactorLabels
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
        Me.lblFactorColumns = New System.Windows.Forms.Label()
        Me.grpFactorLabels = New System.Windows.Forms.GroupBox()
        Me.ucrChkShowId = New instat.ucrCheck()
        Me.ucrChkShowPercentage = New instat.ucrCheck()
        Me.ucrChkSortByName = New instat.ucrCheck()
        Me.ucrChkShowValues = New instat.ucrCheck()
        Me.ucrChkShowFrequencies = New instat.ucrCheck()
        Me.ucrChkShowLabels = New instat.ucrCheck()
        Me.ucrChkShowType = New instat.ucrCheck()
        Me.ucrChkShowMissingValues = New instat.ucrCheck()
        Me.ucrChkAlternateColour = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverFactorColumns = New instat.ucrReceiverMultiple()
        Me.ucrSelectorViewFactorLabels = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpFactorLabels.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFactorColumns
        '
        Me.lblFactorColumns.AutoSize = True
        Me.lblFactorColumns.Location = New System.Drawing.Point(266, 45)
        Me.lblFactorColumns.Name = "lblFactorColumns"
        Me.lblFactorColumns.Size = New System.Drawing.Size(83, 13)
        Me.lblFactorColumns.TabIndex = 1
        Me.lblFactorColumns.Text = "Factor Columns:"
        '
        'grpFactorLabels
        '
        Me.grpFactorLabels.Controls.Add(Me.ucrChkShowId)
        Me.grpFactorLabels.Controls.Add(Me.ucrChkShowPercentage)
        Me.grpFactorLabels.Controls.Add(Me.ucrChkSortByName)
        Me.grpFactorLabels.Controls.Add(Me.ucrChkShowValues)
        Me.grpFactorLabels.Controls.Add(Me.ucrChkShowFrequencies)
        Me.grpFactorLabels.Controls.Add(Me.ucrChkShowLabels)
        Me.grpFactorLabels.Controls.Add(Me.ucrChkShowType)
        Me.grpFactorLabels.Controls.Add(Me.ucrChkShowMissingValues)
        Me.grpFactorLabels.Controls.Add(Me.ucrChkAlternateColour)
        Me.grpFactorLabels.Location = New System.Drawing.Point(10, 202)
        Me.grpFactorLabels.Name = "grpFactorLabels"
        Me.grpFactorLabels.Size = New System.Drawing.Size(462, 104)
        Me.grpFactorLabels.TabIndex = 3
        Me.grpFactorLabels.TabStop = False
        Me.grpFactorLabels.Text = "View Variable(s) Options"
        '
        'ucrChkShowId
        '
        Me.ucrChkShowId.Checked = False
        Me.ucrChkShowId.Location = New System.Drawing.Point(8, 50)
        Me.ucrChkShowId.Name = "ucrChkShowId"
        Me.ucrChkShowId.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkShowId.TabIndex = 3
        '
        'ucrChkShowPercentage
        '
        Me.ucrChkShowPercentage.Checked = False
        Me.ucrChkShowPercentage.Location = New System.Drawing.Point(307, 78)
        Me.ucrChkShowPercentage.Name = "ucrChkShowPercentage"
        Me.ucrChkShowPercentage.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkShowPercentage.TabIndex = 8
        '
        'ucrChkSortByName
        '
        Me.ucrChkSortByName.Checked = False
        Me.ucrChkSortByName.Location = New System.Drawing.Point(8, 78)
        Me.ucrChkSortByName.Name = "ucrChkSortByName"
        Me.ucrChkSortByName.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkSortByName.TabIndex = 6
        '
        'ucrChkShowValues
        '
        Me.ucrChkShowValues.Checked = False
        Me.ucrChkShowValues.Location = New System.Drawing.Point(159, 22)
        Me.ucrChkShowValues.Name = "ucrChkShowValues"
        Me.ucrChkShowValues.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkShowValues.TabIndex = 1
        '
        'ucrChkShowFrequencies
        '
        Me.ucrChkShowFrequencies.Checked = False
        Me.ucrChkShowFrequencies.Location = New System.Drawing.Point(307, 50)
        Me.ucrChkShowFrequencies.Name = "ucrChkShowFrequencies"
        Me.ucrChkShowFrequencies.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkShowFrequencies.TabIndex = 5
        '
        'ucrChkShowLabels
        '
        Me.ucrChkShowLabels.Checked = False
        Me.ucrChkShowLabels.Location = New System.Drawing.Point(8, 22)
        Me.ucrChkShowLabels.Name = "ucrChkShowLabels"
        Me.ucrChkShowLabels.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkShowLabels.TabIndex = 0
        '
        'ucrChkShowType
        '
        Me.ucrChkShowType.Checked = False
        Me.ucrChkShowType.Location = New System.Drawing.Point(159, 50)
        Me.ucrChkShowType.Name = "ucrChkShowType"
        Me.ucrChkShowType.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkShowType.TabIndex = 4
        '
        'ucrChkShowMissingValues
        '
        Me.ucrChkShowMissingValues.Checked = False
        Me.ucrChkShowMissingValues.Location = New System.Drawing.Point(159, 78)
        Me.ucrChkShowMissingValues.Name = "ucrChkShowMissingValues"
        Me.ucrChkShowMissingValues.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkShowMissingValues.TabIndex = 7
        '
        'ucrChkAlternateColour
        '
        Me.ucrChkAlternateColour.Checked = False
        Me.ucrChkAlternateColour.Location = New System.Drawing.Point(307, 22)
        Me.ucrChkAlternateColour.Name = "ucrChkAlternateColour"
        Me.ucrChkAlternateColour.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkAlternateColour.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 314)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 4
        '
        'ucrReceiverFactorColumns
        '
        Me.ucrReceiverFactorColumns.frmParent = Me
        Me.ucrReceiverFactorColumns.Location = New System.Drawing.Point(266, 60)
        Me.ucrReceiverFactorColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactorColumns.Name = "ucrReceiverFactorColumns"
        Me.ucrReceiverFactorColumns.Selector = Nothing
        Me.ucrReceiverFactorColumns.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverFactorColumns.TabIndex = 2
        Me.ucrReceiverFactorColumns.ucrSelector = Nothing
        '
        'ucrSelectorViewFactorLabels
        '
        Me.ucrSelectorViewFactorLabels.bShowHiddenColumns = False
        Me.ucrSelectorViewFactorLabels.bUseCurrentFilter = True
        Me.ucrSelectorViewFactorLabels.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorViewFactorLabels.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorViewFactorLabels.Name = "ucrSelectorViewFactorLabels"
        Me.ucrSelectorViewFactorLabels.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorViewFactorLabels.TabIndex = 0
        '
        'dlgViewFactorLabels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 374)
        Me.Controls.Add(Me.grpFactorLabels)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblFactorColumns)
        Me.Controls.Add(Me.ucrReceiverFactorColumns)
        Me.Controls.Add(Me.ucrSelectorViewFactorLabels)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgViewFactorLabels"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Variable(s) Levels/Labels"
        Me.grpFactorLabels.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorViewFactorLabels As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactorColumns As ucrReceiverMultiple
    Friend WithEvents lblFactorColumns As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpFactorLabels As GroupBox
    Friend WithEvents ucrChkShowId As ucrCheck
    Friend WithEvents ucrChkShowPercentage As ucrCheck
    Friend WithEvents ucrChkSortByName As ucrCheck
    Friend WithEvents ucrChkShowValues As ucrCheck
    Friend WithEvents ucrChkShowFrequencies As ucrCheck
    Friend WithEvents ucrChkShowLabels As ucrCheck
    Friend WithEvents ucrChkShowType As ucrCheck
    Friend WithEvents ucrChkShowMissingValues As ucrCheck
    Friend WithEvents ucrChkAlternateColour As ucrCheck
End Class
