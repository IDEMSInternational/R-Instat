<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDisplayData
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
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverDisplay = New instat.ucrReceiverMultiple()
        Me.lblDataToBeDisplay = New System.Windows.Forms.Label()
        Me.lstDataColumns = New System.Windows.Forms.ListBox()
        Me.lstConstants = New System.Windows.Forms.ListBox()
        Me.lstStrings = New System.Windows.Forms.ListBox()
        Me.lstLabels = New System.Windows.Forms.ListBox()
        Me.chkDataOptions = New System.Windows.Forms.CheckBox()
        Me.chkLayoutOptions = New System.Windows.Forms.CheckBox()
        Me.chkDisplaySpecifiedRows = New System.Windows.Forms.CheckBox()
        Me.lblDataColumns = New System.Windows.Forms.Label()
        Me.lblConstants = New System.Windows.Forms.Label()
        Me.lblStrings = New System.Windows.Forms.Label()
        Me.lblLabels = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 282)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(427, 32)
        Me.ucrBase.TabIndex = 0
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(12, 12)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 117)
        Me.ucrAddRemove.TabIndex = 1
        '
        'ucrReceiverDisplay
        '
        Me.ucrReceiverDisplay.Location = New System.Drawing.Point(242, 26)
        Me.ucrReceiverDisplay.Name = "ucrReceiverDisplay"
        Me.ucrReceiverDisplay.Size = New System.Drawing.Size(121, 103)
        Me.ucrReceiverDisplay.TabIndex = 2
        '
        'lblDataToBeDisplay
        '
        Me.lblDataToBeDisplay.AutoSize = True
        Me.lblDataToBeDisplay.Location = New System.Drawing.Point(252, 7)
        Me.lblDataToBeDisplay.Name = "lblDataToBeDisplay"
        Me.lblDataToBeDisplay.Size = New System.Drawing.Size(104, 13)
        Me.lblDataToBeDisplay.TabIndex = 3
        Me.lblDataToBeDisplay.Tag = "Data_to_be_displayed"
        Me.lblDataToBeDisplay.Text = "Data to be displayed"
        '
        'lstDataColumns
        '
        Me.lstDataColumns.FormattingEnabled = True
        Me.lstDataColumns.Location = New System.Drawing.Point(25, 176)
        Me.lstDataColumns.Name = "lstDataColumns"
        Me.lstDataColumns.Size = New System.Drawing.Size(48, 69)
        Me.lstDataColumns.TabIndex = 4
        '
        'lstConstants
        '
        Me.lstConstants.FormattingEnabled = True
        Me.lstConstants.Location = New System.Drawing.Point(92, 176)
        Me.lstConstants.Name = "lstConstants"
        Me.lstConstants.Size = New System.Drawing.Size(48, 69)
        Me.lstConstants.TabIndex = 4
        '
        'lstStrings
        '
        Me.lstStrings.FormattingEnabled = True
        Me.lstStrings.Location = New System.Drawing.Point(159, 176)
        Me.lstStrings.Name = "lstStrings"
        Me.lstStrings.Size = New System.Drawing.Size(39, 69)
        Me.lstStrings.TabIndex = 4
        '
        'lstLabels
        '
        Me.lstLabels.FormattingEnabled = True
        Me.lstLabels.Location = New System.Drawing.Point(207, 176)
        Me.lstLabels.Name = "lstLabels"
        Me.lstLabels.Size = New System.Drawing.Size(48, 69)
        Me.lstLabels.TabIndex = 4
        '
        'chkDataOptions
        '
        Me.chkDataOptions.AutoSize = True
        Me.chkDataOptions.Location = New System.Drawing.Point(275, 153)
        Me.chkDataOptions.Name = "chkDataOptions"
        Me.chkDataOptions.Size = New System.Drawing.Size(86, 17)
        Me.chkDataOptions.TabIndex = 5
        Me.chkDataOptions.Tag = "Data_Options"
        Me.chkDataOptions.Text = "Data options"
        Me.chkDataOptions.UseVisualStyleBackColor = True
        '
        'chkLayoutOptions
        '
        Me.chkLayoutOptions.AutoSize = True
        Me.chkLayoutOptions.Location = New System.Drawing.Point(275, 190)
        Me.chkLayoutOptions.Name = "chkLayoutOptions"
        Me.chkLayoutOptions.Size = New System.Drawing.Size(95, 17)
        Me.chkLayoutOptions.TabIndex = 5
        Me.chkLayoutOptions.Tag = "Layout_options"
        Me.chkLayoutOptions.Text = "Layout options"
        Me.chkLayoutOptions.UseVisualStyleBackColor = True
        '
        'chkDisplaySpecifiedRows
        '
        Me.chkDisplaySpecifiedRows.AutoSize = True
        Me.chkDisplaySpecifiedRows.Location = New System.Drawing.Point(275, 228)
        Me.chkDisplaySpecifiedRows.Name = "chkDisplaySpecifiedRows"
        Me.chkDisplaySpecifiedRows.Size = New System.Drawing.Size(130, 17)
        Me.chkDisplaySpecifiedRows.TabIndex = 5
        Me.chkDisplaySpecifiedRows.Tag = "Display_specified_rows"
        Me.chkDisplaySpecifiedRows.Text = "Display specified rows"
        Me.chkDisplaySpecifiedRows.UseVisualStyleBackColor = True
        '
        'lblDataColumns
        '
        Me.lblDataColumns.AutoSize = True
        Me.lblDataColumns.Location = New System.Drawing.Point(12, 160)
        Me.lblDataColumns.Name = "lblDataColumns"
        Me.lblDataColumns.Size = New System.Drawing.Size(72, 13)
        Me.lblDataColumns.TabIndex = 3
        Me.lblDataColumns.Tag = "Data_columns"
        Me.lblDataColumns.Text = "Data columns"
        '
        'lblConstants
        '
        Me.lblConstants.AutoSize = True
        Me.lblConstants.Location = New System.Drawing.Point(90, 157)
        Me.lblConstants.Name = "lblConstants"
        Me.lblConstants.Size = New System.Drawing.Size(54, 13)
        Me.lblConstants.TabIndex = 3
        Me.lblConstants.Tag = "Constants"
        Me.lblConstants.Text = "Constants"
        '
        'lblStrings
        '
        Me.lblStrings.AutoSize = True
        Me.lblStrings.Location = New System.Drawing.Point(159, 157)
        Me.lblStrings.Name = "lblStrings"
        Me.lblStrings.Size = New System.Drawing.Size(39, 13)
        Me.lblStrings.TabIndex = 3
        Me.lblStrings.Tag = "Strings"
        Me.lblStrings.Text = "Strings"
        '
        'lblLabels
        '
        Me.lblLabels.AutoSize = True
        Me.lblLabels.Location = New System.Drawing.Point(204, 157)
        Me.lblLabels.Name = "lblLabels"
        Me.lblLabels.Size = New System.Drawing.Size(38, 13)
        Me.lblLabels.TabIndex = 3
        Me.lblLabels.Tag = "Labels"
        Me.lblLabels.Text = "Labels"
        '
        'dlgDisplayData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 326)
        Me.Controls.Add(Me.chkDisplaySpecifiedRows)
        Me.Controls.Add(Me.chkLayoutOptions)
        Me.Controls.Add(Me.chkDataOptions)
        Me.Controls.Add(Me.lstLabels)
        Me.Controls.Add(Me.lstStrings)
        Me.Controls.Add(Me.lstConstants)
        Me.Controls.Add(Me.lstDataColumns)
        Me.Controls.Add(Me.lblLabels)
        Me.Controls.Add(Me.lblStrings)
        Me.Controls.Add(Me.lblConstants)
        Me.Controls.Add(Me.lblDataColumns)
        Me.Controls.Add(Me.lblDataToBeDisplay)
        Me.Controls.Add(Me.ucrReceiverDisplay)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgDisplayData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Display_data"
        Me.Text = "Display data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverDisplay As ucrReceiverMultiple
    Friend WithEvents lblDataToBeDisplay As Label
    Friend WithEvents lstDataColumns As ListBox
    Friend WithEvents lstConstants As ListBox
    Friend WithEvents lstStrings As ListBox
    Friend WithEvents lstLabels As ListBox
    Friend WithEvents chkDataOptions As CheckBox
    Friend WithEvents chkLayoutOptions As CheckBox
    Friend WithEvents chkDisplaySpecifiedRows As CheckBox
    Friend WithEvents lblDataColumns As Label
    Friend WithEvents lblConstants As Label
    Friend WithEvents lblStrings As Label
    Friend WithEvents lblLabels As Label
End Class
