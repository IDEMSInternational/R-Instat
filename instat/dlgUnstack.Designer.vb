<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgUnstack
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
        Me.ucrDataFrame = New instat.ucrDataFrame()
        Me.ucrSelectorByDataFrameAddRemove = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverFactors = New instat.ucrReceiverMultiple()
        Me.ucrReceiverColumns = New instat.ucrReceiverMultiple()
        Me.lblFactorstoUnstackBy = New System.Windows.Forms.Label()
        Me.lblColumnstoUnstack = New System.Windows.Forms.Label()
        Me.chkUseFactoLabels = New System.Windows.Forms.CheckBox()
        Me.grpOutputOptions = New System.Windows.Forms.GroupBox()
        Me.txtSheetName = New System.Windows.Forms.TextBox()
        Me.lblSheetName = New System.Windows.Forms.Label()
        Me.rdoNewWorksheet = New System.Windows.Forms.RadioButton()
        Me.rdoExistingWorksheet = New System.Windows.Forms.RadioButton()
        Me.grpOutputOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 355)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 56)
        Me.ucrBase.TabIndex = 2
        '
        'ucrDataFrame
        '
        Me.ucrDataFrame.Location = New System.Drawing.Point(7, 11)
        Me.ucrDataFrame.Name = "ucrDataFrame"
        Me.ucrDataFrame.Size = New System.Drawing.Size(127, 41)
        Me.ucrDataFrame.TabIndex = 6
        '
        'ucrSelectorByDataFrameAddRemove
        '
        Me.ucrSelectorByDataFrameAddRemove.Location = New System.Drawing.Point(7, 49)
        Me.ucrSelectorByDataFrameAddRemove.Name = "ucrSelectorByDataFrameAddRemove"
        Me.ucrSelectorByDataFrameAddRemove.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorByDataFrameAddRemove.TabIndex = 7
        '
        'ucrReceiverFactors
        '
        Me.ucrReceiverFactors.Location = New System.Drawing.Point(245, 65)
        Me.ucrReceiverFactors.Name = "ucrReceiverFactors"
        Me.ucrReceiverFactors.Size = New System.Drawing.Size(121, 128)
        Me.ucrReceiverFactors.TabIndex = 8
        '
        'ucrReceiverColumns
        '
        Me.ucrReceiverColumns.Location = New System.Drawing.Point(387, 65)
        Me.ucrReceiverColumns.Name = "ucrReceiverColumns"
        Me.ucrReceiverColumns.Size = New System.Drawing.Size(121, 128)
        Me.ucrReceiverColumns.TabIndex = 8
        '
        'lblFactorstoUnstackBy
        '
        Me.lblFactorstoUnstackBy.AutoSize = True
        Me.lblFactorstoUnstackBy.Location = New System.Drawing.Point(245, 38)
        Me.lblFactorstoUnstackBy.Name = "lblFactorstoUnstackBy"
        Me.lblFactorstoUnstackBy.Size = New System.Drawing.Size(121, 13)
        Me.lblFactorstoUnstackBy.TabIndex = 9
        Me.lblFactorstoUnstackBy.Tag = "Factor(s)_to_Unstrack_By"
        Me.lblFactorstoUnstackBy.Text = "Factor(s) to Unstrack By"
        '
        'lblColumnstoUnstack
        '
        Me.lblColumnstoUnstack.AutoSize = True
        Me.lblColumnstoUnstack.Location = New System.Drawing.Point(384, 39)
        Me.lblColumnstoUnstack.Name = "lblColumnstoUnstack"
        Me.lblColumnstoUnstack.Size = New System.Drawing.Size(102, 13)
        Me.lblColumnstoUnstack.TabIndex = 9
        Me.lblColumnstoUnstack.Tag = "Columns_to_Unstack"
        Me.lblColumnstoUnstack.Text = "Columns to Unstack"
        '
        'chkUseFactoLabels
        '
        Me.chkUseFactoLabels.AutoSize = True
        Me.chkUseFactoLabels.Location = New System.Drawing.Point(13, 225)
        Me.chkUseFactoLabels.Name = "chkUseFactoLabels"
        Me.chkUseFactoLabels.Size = New System.Drawing.Size(193, 17)
        Me.chkUseFactoLabels.TabIndex = 10
        Me.chkUseFactoLabels.Tag = "Use_Factor_labels_in_Column_Names"
        Me.chkUseFactoLabels.Text = "Use Factor labels in Column Names"
        Me.chkUseFactoLabels.UseVisualStyleBackColor = True
        '
        'grpOutputOptions
        '
        Me.grpOutputOptions.Controls.Add(Me.txtSheetName)
        Me.grpOutputOptions.Controls.Add(Me.lblSheetName)
        Me.grpOutputOptions.Controls.Add(Me.rdoNewWorksheet)
        Me.grpOutputOptions.Controls.Add(Me.rdoExistingWorksheet)
        Me.grpOutputOptions.Location = New System.Drawing.Point(22, 249)
        Me.grpOutputOptions.Name = "grpOutputOptions"
        Me.grpOutputOptions.Size = New System.Drawing.Size(199, 100)
        Me.grpOutputOptions.TabIndex = 11
        Me.grpOutputOptions.TabStop = False
        Me.grpOutputOptions.Tag = "Output_Options"
        Me.grpOutputOptions.Text = "Output Options"
        '
        'txtSheetName
        '
        Me.txtSheetName.Location = New System.Drawing.Point(95, 66)
        Me.txtSheetName.Name = "txtSheetName"
        Me.txtSheetName.Size = New System.Drawing.Size(100, 20)
        Me.txtSheetName.TabIndex = 2
        '
        'lblSheetName
        '
        Me.lblSheetName.AutoSize = True
        Me.lblSheetName.Location = New System.Drawing.Point(31, 67)
        Me.lblSheetName.Name = "lblSheetName"
        Me.lblSheetName.Size = New System.Drawing.Size(66, 13)
        Me.lblSheetName.TabIndex = 1
        Me.lblSheetName.Tag = "Sheet_Name"
        Me.lblSheetName.Text = "Sheet Name"
        '
        'rdoNewWorksheet
        '
        Me.rdoNewWorksheet.AutoSize = True
        Me.rdoNewWorksheet.Location = New System.Drawing.Point(7, 43)
        Me.rdoNewWorksheet.Name = "rdoNewWorksheet"
        Me.rdoNewWorksheet.Size = New System.Drawing.Size(102, 17)
        Me.rdoNewWorksheet.TabIndex = 0
        Me.rdoNewWorksheet.TabStop = True
        Me.rdoNewWorksheet.Tag = "New_Worksheet"
        Me.rdoNewWorksheet.Text = "New Worksheet"
        Me.rdoNewWorksheet.UseVisualStyleBackColor = True
        '
        'rdoExistingWorksheet
        '
        Me.rdoExistingWorksheet.AutoSize = True
        Me.rdoExistingWorksheet.Location = New System.Drawing.Point(7, 20)
        Me.rdoExistingWorksheet.Name = "rdoExistingWorksheet"
        Me.rdoExistingWorksheet.Size = New System.Drawing.Size(116, 17)
        Me.rdoExistingWorksheet.TabIndex = 0
        Me.rdoExistingWorksheet.TabStop = True
        Me.rdoExistingWorksheet.Tag = "Existing_Worksheet"
        Me.rdoExistingWorksheet.Text = "Existing Worksheet"
        Me.rdoExistingWorksheet.UseVisualStyleBackColor = True
        '
        'dlgUnstack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 408)
        Me.Controls.Add(Me.grpOutputOptions)
        Me.Controls.Add(Me.chkUseFactoLabels)
        Me.Controls.Add(Me.lblColumnstoUnstack)
        Me.Controls.Add(Me.lblFactorstoUnstackBy)
        Me.Controls.Add(Me.ucrReceiverColumns)
        Me.Controls.Add(Me.ucrReceiverFactors)
        Me.Controls.Add(Me.ucrSelectorByDataFrameAddRemove)
        Me.Controls.Add(Me.ucrDataFrame)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgUnstack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Unstack_split_columns"
        Me.Text = "Unstack(Split) columns"
        Me.grpOutputOptions.ResumeLayout(False)
        Me.grpOutputOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrame As ucrDataFrame
    Friend WithEvents ucrSelectorByDataFrameAddRemove As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactors As ucrReceiverMultiple
    Friend WithEvents ucrReceiverColumns As ucrReceiverMultiple
    Friend WithEvents lblFactorstoUnstackBy As Label
    Friend WithEvents lblColumnstoUnstack As Label
    Friend WithEvents chkUseFactoLabels As CheckBox
    Friend WithEvents grpOutputOptions As GroupBox
    Friend WithEvents txtSheetName As TextBox
    Friend WithEvents lblSheetName As Label
    Friend WithEvents rdoNewWorksheet As RadioButton
    Friend WithEvents rdoExistingWorksheet As RadioButton
End Class
