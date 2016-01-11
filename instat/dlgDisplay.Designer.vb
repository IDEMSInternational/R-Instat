<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDisplay
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
        Me.ucrDisplayDataSelector = New instat.ucrSelectorAddRemove()
        Me.ucrDisplayMultipleReceiver = New instat.ucrReceiverMultiple()
        Me.lblDataToBeDisplayed = New System.Windows.Forms.Label()
        Me.lblConstants = New System.Windows.Forms.Label()
        Me.lstConstants = New System.Windows.Forms.ListBox()
        Me.lblStrings = New System.Windows.Forms.Label()
        Me.lstStrings = New System.Windows.Forms.ListBox()
        Me.lblLabels = New System.Windows.Forms.Label()
        Me.lstLabels = New System.Windows.Forms.ListBox()
        Me.chkDataOptions = New System.Windows.Forms.CheckBox()
        Me.chkLayoutOptions = New System.Windows.Forms.CheckBox()
        Me.grpDataOptions = New System.Windows.Forms.GroupBox()
        Me.chkDisplayasColumns = New System.Windows.Forms.CheckBox()
        Me.chkDisplaySerially = New System.Windows.Forms.CheckBox()
        Me.chkDisplayFactorswithLabels = New System.Windows.Forms.CheckBox()
        Me.chkNoOfDecimalPlaces = New System.Windows.Forms.CheckBox()
        Me.chkNoofSigFigures = New System.Windows.Forms.CheckBox()
        Me.txtNoofSigFigures = New System.Windows.Forms.TextBox()
        Me.txtDecimalPlaces = New System.Windows.Forms.TextBox()
        Me.lblSeparatedby = New System.Windows.Forms.Label()
        Me.txtSeparator = New System.Windows.Forms.TextBox()
        Me.lblLines = New System.Windows.Forms.Label()
        Me.grpLayoutOptions = New System.Windows.Forms.GroupBox()
        Me.txtFieldWidth = New System.Windows.Forms.TextBox()
        Me.lblFieldWidth = New System.Windows.Forms.Label()
        Me.lbtLineWidth = New System.Windows.Forms.Label()
        Me.txtLineWidth = New System.Windows.Forms.TextBox()
        Me.chkDisplaySpecifiedRows = New System.Windows.Forms.CheckBox()
        Me.grpDataOptions.SuspendLayout()
        Me.grpLayoutOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(27, 310)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'ucrDisplayDataSelector
        '
        Me.ucrDisplayDataSelector.Location = New System.Drawing.Point(12, 12)
        Me.ucrDisplayDataSelector.Name = "ucrDisplayDataSelector"
        Me.ucrDisplayDataSelector.Size = New System.Drawing.Size(203, 127)
        Me.ucrDisplayDataSelector.TabIndex = 1
        '
        'ucrDisplayMultipleReceiver
        '
        Me.ucrDisplayMultipleReceiver.Location = New System.Drawing.Point(221, 21)
        Me.ucrDisplayMultipleReceiver.Name = "ucrDisplayMultipleReceiver"
        Me.ucrDisplayMultipleReceiver.Size = New System.Drawing.Size(121, 129)
        Me.ucrDisplayMultipleReceiver.TabIndex = 2
        '
        'lblDataToBeDisplayed
        '
        Me.lblDataToBeDisplayed.AutoSize = True
        Me.lblDataToBeDisplayed.Location = New System.Drawing.Point(221, 8)
        Me.lblDataToBeDisplayed.Name = "lblDataToBeDisplayed"
        Me.lblDataToBeDisplayed.Size = New System.Drawing.Size(111, 13)
        Me.lblDataToBeDisplayed.TabIndex = 3
        Me.lblDataToBeDisplayed.Tag = "Data_To_Be_Displayed"
        Me.lblDataToBeDisplayed.Text = "Data To Be Displayed"
        '
        'lblConstants
        '
        Me.lblConstants.AutoSize = True
        Me.lblConstants.Location = New System.Drawing.Point(343, 8)
        Me.lblConstants.Name = "lblConstants"
        Me.lblConstants.Size = New System.Drawing.Size(54, 13)
        Me.lblConstants.TabIndex = 4
        Me.lblConstants.Tag = "Constants"
        Me.lblConstants.Text = "Constants"
        '
        'lstConstants
        '
        Me.lstConstants.FormattingEnabled = True
        Me.lstConstants.Items.AddRange(New Object() {"", "", "", ""})
        Me.lstConstants.Location = New System.Drawing.Point(346, 26)
        Me.lstConstants.Name = "lstConstants"
        Me.lstConstants.Size = New System.Drawing.Size(40, 121)
        Me.lstConstants.TabIndex = 5
        '
        'lblStrings
        '
        Me.lblStrings.AutoSize = True
        Me.lblStrings.Location = New System.Drawing.Point(403, 8)
        Me.lblStrings.Name = "lblStrings"
        Me.lblStrings.Size = New System.Drawing.Size(39, 13)
        Me.lblStrings.TabIndex = 4
        Me.lblStrings.Tag = "Strings"
        Me.lblStrings.Text = "Strings"
        '
        'lstStrings
        '
        Me.lstStrings.FormattingEnabled = True
        Me.lstStrings.Items.AddRange(New Object() {"", "", "", ""})
        Me.lstStrings.Location = New System.Drawing.Point(402, 26)
        Me.lstStrings.Name = "lstStrings"
        Me.lstStrings.Size = New System.Drawing.Size(40, 121)
        Me.lstStrings.TabIndex = 5
        '
        'lblLabels
        '
        Me.lblLabels.AutoSize = True
        Me.lblLabels.Location = New System.Drawing.Point(460, 8)
        Me.lblLabels.Name = "lblLabels"
        Me.lblLabels.Size = New System.Drawing.Size(38, 13)
        Me.lblLabels.TabIndex = 4
        Me.lblLabels.Tag = "Labels"
        Me.lblLabels.Text = "Labels"
        '
        'lstLabels
        '
        Me.lstLabels.FormattingEnabled = True
        Me.lstLabels.Items.AddRange(New Object() {"", "", "", ""})
        Me.lstLabels.Location = New System.Drawing.Point(458, 26)
        Me.lstLabels.Name = "lstLabels"
        Me.lstLabels.Size = New System.Drawing.Size(40, 121)
        Me.lstLabels.TabIndex = 5
        '
        'chkDataOptions
        '
        Me.chkDataOptions.AutoSize = True
        Me.chkDataOptions.Location = New System.Drawing.Point(27, 156)
        Me.chkDataOptions.Name = "chkDataOptions"
        Me.chkDataOptions.Size = New System.Drawing.Size(88, 17)
        Me.chkDataOptions.TabIndex = 6
        Me.chkDataOptions.Tag = "Data_Options"
        Me.chkDataOptions.Text = "Data Options"
        Me.chkDataOptions.UseVisualStyleBackColor = True
        '
        'chkLayoutOptions
        '
        Me.chkLayoutOptions.AutoSize = True
        Me.chkLayoutOptions.Location = New System.Drawing.Point(27, 179)
        Me.chkLayoutOptions.Name = "chkLayoutOptions"
        Me.chkLayoutOptions.Size = New System.Drawing.Size(97, 17)
        Me.chkLayoutOptions.TabIndex = 6
        Me.chkLayoutOptions.Tag = "Layout_Options"
        Me.chkLayoutOptions.Text = "Layout Options"
        Me.chkLayoutOptions.UseVisualStyleBackColor = True
        '
        'grpDataOptions
        '
        Me.grpDataOptions.Controls.Add(Me.lblLines)
        Me.grpDataOptions.Controls.Add(Me.lblSeparatedby)
        Me.grpDataOptions.Controls.Add(Me.txtSeparator)
        Me.grpDataOptions.Controls.Add(Me.txtDecimalPlaces)
        Me.grpDataOptions.Controls.Add(Me.txtNoofSigFigures)
        Me.grpDataOptions.Controls.Add(Me.chkNoofSigFigures)
        Me.grpDataOptions.Controls.Add(Me.chkNoOfDecimalPlaces)
        Me.grpDataOptions.Controls.Add(Me.chkDisplayFactorswithLabels)
        Me.grpDataOptions.Controls.Add(Me.chkDisplaySerially)
        Me.grpDataOptions.Controls.Add(Me.chkDisplayasColumns)
        Me.grpDataOptions.Location = New System.Drawing.Point(214, 156)
        Me.grpDataOptions.Name = "grpDataOptions"
        Me.grpDataOptions.Size = New System.Drawing.Size(183, 148)
        Me.grpDataOptions.TabIndex = 7
        Me.grpDataOptions.TabStop = False
        Me.grpDataOptions.Tag = "DataIOptions"
        Me.grpDataOptions.Text = "Data Options"
        '
        'chkDisplayasColumns
        '
        Me.chkDisplayasColumns.AutoSize = True
        Me.chkDisplayasColumns.Location = New System.Drawing.Point(6, 19)
        Me.chkDisplayasColumns.Name = "chkDisplayasColumns"
        Me.chkDisplayasColumns.Size = New System.Drawing.Size(117, 17)
        Me.chkDisplayasColumns.TabIndex = 7
        Me.chkDisplayasColumns.Tag = "Display_as_Columns"
        Me.chkDisplayasColumns.Text = "Display as Columns"
        Me.chkDisplayasColumns.UseVisualStyleBackColor = True
        '
        'chkDisplaySerially
        '
        Me.chkDisplaySerially.AutoSize = True
        Me.chkDisplaySerially.Location = New System.Drawing.Point(6, 42)
        Me.chkDisplaySerially.Name = "chkDisplaySerially"
        Me.chkDisplaySerially.Size = New System.Drawing.Size(96, 17)
        Me.chkDisplaySerially.TabIndex = 7
        Me.chkDisplaySerially.Tag = "Display_Serially"
        Me.chkDisplaySerially.Text = "Display Serially"
        Me.chkDisplaySerially.UseVisualStyleBackColor = True
        '
        'chkDisplayFactorswithLabels
        '
        Me.chkDisplayFactorswithLabels.AutoSize = True
        Me.chkDisplayFactorswithLabels.Location = New System.Drawing.Point(6, 81)
        Me.chkDisplayFactorswithLabels.Name = "chkDisplayFactorswithLabels"
        Me.chkDisplayFactorswithLabels.Size = New System.Drawing.Size(154, 17)
        Me.chkDisplayFactorswithLabels.TabIndex = 7
        Me.chkDisplayFactorswithLabels.Tag = "Display_Factors_with_Labels"
        Me.chkDisplayFactorswithLabels.Text = "Display Factors with Labels"
        Me.chkDisplayFactorswithLabels.UseVisualStyleBackColor = True
        '
        'chkNoOfDecimalPlaces
        '
        Me.chkNoOfDecimalPlaces.AutoSize = True
        Me.chkNoOfDecimalPlaces.Location = New System.Drawing.Point(6, 104)
        Me.chkNoOfDecimalPlaces.Name = "chkNoOfDecimalPlaces"
        Me.chkNoOfDecimalPlaces.Size = New System.Drawing.Size(130, 17)
        Me.chkNoOfDecimalPlaces.TabIndex = 7
        Me.chkNoOfDecimalPlaces.Tag = "No_Of_Decimal_Places"
        Me.chkNoOfDecimalPlaces.Text = "No Of Decimal Places"
        Me.chkNoOfDecimalPlaces.UseVisualStyleBackColor = True
        '
        'chkNoofSigFigures
        '
        Me.chkNoofSigFigures.AutoSize = True
        Me.chkNoofSigFigures.Location = New System.Drawing.Point(6, 127)
        Me.chkNoofSigFigures.Name = "chkNoofSigFigures"
        Me.chkNoofSigFigures.Size = New System.Drawing.Size(113, 17)
        Me.chkNoofSigFigures.TabIndex = 7
        Me.chkNoofSigFigures.Tag = "No._of_Sig._Figures"
        Me.chkNoofSigFigures.Text = "No. of Sig. Figures"
        Me.chkNoofSigFigures.UseVisualStyleBackColor = True
        '
        'txtNoofSigFigures
        '
        Me.txtNoofSigFigures.Location = New System.Drawing.Point(143, 122)
        Me.txtNoofSigFigures.Name = "txtNoofSigFigures"
        Me.txtNoofSigFigures.Size = New System.Drawing.Size(34, 20)
        Me.txtNoofSigFigures.TabIndex = 8
        '
        'txtDecimalPlaces
        '
        Me.txtDecimalPlaces.Location = New System.Drawing.Point(143, 96)
        Me.txtDecimalPlaces.Name = "txtDecimalPlaces"
        Me.txtDecimalPlaces.Size = New System.Drawing.Size(34, 20)
        Me.txtDecimalPlaces.TabIndex = 9
        '
        'lblSeparatedby
        '
        Me.lblSeparatedby.AutoSize = True
        Me.lblSeparatedby.Location = New System.Drawing.Point(29, 62)
        Me.lblSeparatedby.Name = "lblSeparatedby"
        Me.lblSeparatedby.Size = New System.Drawing.Size(70, 13)
        Me.lblSeparatedby.TabIndex = 10
        Me.lblSeparatedby.Tag = "Separated_by"
        Me.lblSeparatedby.Text = "Separated by"
        '
        'txtSeparator
        '
        Me.txtSeparator.Location = New System.Drawing.Point(99, 60)
        Me.txtSeparator.Name = "txtSeparator"
        Me.txtSeparator.Size = New System.Drawing.Size(34, 20)
        Me.txtSeparator.TabIndex = 9
        '
        'lblLines
        '
        Me.lblLines.AutoSize = True
        Me.lblLines.Location = New System.Drawing.Point(139, 64)
        Me.lblLines.Name = "lblLines"
        Me.lblLines.Size = New System.Drawing.Size(32, 13)
        Me.lblLines.TabIndex = 11
        Me.lblLines.Tag = "Lines"
        Me.lblLines.Text = "Lines"
        '
        'grpLayoutOptions
        '
        Me.grpLayoutOptions.Controls.Add(Me.txtLineWidth)
        Me.grpLayoutOptions.Controls.Add(Me.lbtLineWidth)
        Me.grpLayoutOptions.Controls.Add(Me.txtFieldWidth)
        Me.grpLayoutOptions.Controls.Add(Me.lblFieldWidth)
        Me.grpLayoutOptions.Location = New System.Drawing.Point(27, 203)
        Me.grpLayoutOptions.Name = "grpLayoutOptions"
        Me.grpLayoutOptions.Size = New System.Drawing.Size(165, 74)
        Me.grpLayoutOptions.TabIndex = 8
        Me.grpLayoutOptions.TabStop = False
        Me.grpLayoutOptions.Tag = "Layout_Options"
        Me.grpLayoutOptions.Text = "Layout Options"
        '
        'txtFieldWidth
        '
        Me.txtFieldWidth.Location = New System.Drawing.Point(81, 17)
        Me.txtFieldWidth.Name = "txtFieldWidth"
        Me.txtFieldWidth.Size = New System.Drawing.Size(55, 20)
        Me.txtFieldWidth.TabIndex = 9
        '
        'lblFieldWidth
        '
        Me.lblFieldWidth.AutoSize = True
        Me.lblFieldWidth.Location = New System.Drawing.Point(11, 19)
        Me.lblFieldWidth.Name = "lblFieldWidth"
        Me.lblFieldWidth.Size = New System.Drawing.Size(60, 13)
        Me.lblFieldWidth.TabIndex = 10
        Me.lblFieldWidth.Tag = "Field_Width"
        Me.lblFieldWidth.Text = "Field Width"
        '
        'lbtLineWidth
        '
        Me.lbtLineWidth.AutoSize = True
        Me.lbtLineWidth.Location = New System.Drawing.Point(11, 51)
        Me.lbtLineWidth.Name = "lbtLineWidth"
        Me.lbtLineWidth.Size = New System.Drawing.Size(58, 13)
        Me.lbtLineWidth.TabIndex = 10
        Me.lbtLineWidth.Tag = "Line_Width"
        Me.lbtLineWidth.Text = "Line Width"
        '
        'txtLineWidth
        '
        Me.txtLineWidth.Location = New System.Drawing.Point(81, 49)
        Me.txtLineWidth.Name = "txtLineWidth"
        Me.txtLineWidth.Size = New System.Drawing.Size(55, 20)
        Me.txtLineWidth.TabIndex = 9
        '
        'chkDisplaySpecifiedRows
        '
        Me.chkDisplaySpecifiedRows.AutoSize = True
        Me.chkDisplaySpecifiedRows.Location = New System.Drawing.Point(27, 287)
        Me.chkDisplaySpecifiedRows.Name = "chkDisplaySpecifiedRows"
        Me.chkDisplaySpecifiedRows.Size = New System.Drawing.Size(137, 17)
        Me.chkDisplaySpecifiedRows.TabIndex = 7
        Me.chkDisplaySpecifiedRows.Tag = "Display_Specified_Rows"
        Me.chkDisplaySpecifiedRows.Text = "Display Specified Rows"
        Me.chkDisplaySpecifiedRows.UseVisualStyleBackColor = True
        '
        'dlgDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 345)
        Me.Controls.Add(Me.grpLayoutOptions)
        Me.Controls.Add(Me.grpDataOptions)
        Me.Controls.Add(Me.chkLayoutOptions)
        Me.Controls.Add(Me.chkDataOptions)
        Me.Controls.Add(Me.lstLabels)
        Me.Controls.Add(Me.lstStrings)
        Me.Controls.Add(Me.lstConstants)
        Me.Controls.Add(Me.lblLabels)
        Me.Controls.Add(Me.lblStrings)
        Me.Controls.Add(Me.chkDisplaySpecifiedRows)
        Me.Controls.Add(Me.lblConstants)
        Me.Controls.Add(Me.lblDataToBeDisplayed)
        Me.Controls.Add(Me.ucrDisplayMultipleReceiver)
        Me.Controls.Add(Me.ucrDisplayDataSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgDisplay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Display"
        Me.Text = "Display"
        Me.grpDataOptions.ResumeLayout(False)
        Me.grpDataOptions.PerformLayout()
        Me.grpLayoutOptions.ResumeLayout(False)
        Me.grpLayoutOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDisplayDataSelector As ucrSelectorAddRemove
    Friend WithEvents ucrDisplayMultipleReceiver As ucrReceiverMultiple
    Friend WithEvents lblDataToBeDisplayed As Label
    Friend WithEvents lblConstants As Label
    Friend WithEvents lstConstants As ListBox
    Friend WithEvents lblStrings As Label
    Friend WithEvents lstStrings As ListBox
    Friend WithEvents lblLabels As Label
    Friend WithEvents lstLabels As ListBox
    Friend WithEvents chkDataOptions As CheckBox
    Friend WithEvents chkLayoutOptions As CheckBox
    Friend WithEvents grpDataOptions As GroupBox
    Friend WithEvents chkNoofSigFigures As CheckBox
    Friend WithEvents chkNoOfDecimalPlaces As CheckBox
    Friend WithEvents chkDisplayFactorswithLabels As CheckBox
    Friend WithEvents chkDisplaySerially As CheckBox
    Friend WithEvents chkDisplayasColumns As CheckBox
    Friend WithEvents txtNoofSigFigures As TextBox
    Friend WithEvents lblLines As Label
    Friend WithEvents lblSeparatedby As Label
    Friend WithEvents txtSeparator As TextBox
    Friend WithEvents txtDecimalPlaces As TextBox
    Friend WithEvents grpLayoutOptions As GroupBox
    Friend WithEvents txtLineWidth As TextBox
    Friend WithEvents lbtLineWidth As Label
    Friend WithEvents txtFieldWidth As TextBox
    Friend WithEvents lblFieldWidth As Label
    Friend WithEvents chkDisplaySpecifiedRows As CheckBox
End Class
