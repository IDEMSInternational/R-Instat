<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgRowNamesOrNumbers
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
        Me.grpboxOptionsforRowNamesorNumbercols = New System.Windows.Forms.GroupBox()
        Me.ucrChkAsNumeric = New instat.ucrCheck()
        Me.ucrNewColumnName = New instat.ucrSave()
        Me.rdoSortAscending = New System.Windows.Forms.RadioButton()
        Me.rdoSortDescending = New System.Windows.Forms.RadioButton()
        Me.UcrPanel1 = New instat.UcrPanel()
        Me.rdoSortbyRowNames = New System.Windows.Forms.RadioButton()
        Me.rdoResetintoPositiveIntegers = New System.Windows.Forms.RadioButton()
        Me.rdoCopyfromColumn = New System.Windows.Forms.RadioButton()
        Me.rdoCopytoFirstColumn = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverRowNames = New instat.ucrReceiverSingle()
        Me.ucrPnlOverallOptions = New instat.UcrPanel()
        Me.ucrSelectorRowNames = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlSortOptions = New instat.UcrPanel()
        Me.grpboxOptionsforRowNamesorNumbercols.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpboxOptionsforRowNamesorNumbercols
        '
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.ucrChkAsNumeric)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.ucrNewColumnName)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoSortAscending)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoSortDescending)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.UcrPanel1)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoSortbyRowNames)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoResetintoPositiveIntegers)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoCopyfromColumn)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoCopytoFirstColumn)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.ucrReceiverRowNames)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.ucrPnlOverallOptions)
        Me.grpboxOptionsforRowNamesorNumbercols.Location = New System.Drawing.Point(222, 10)
        Me.grpboxOptionsforRowNamesorNumbercols.Name = "grpboxOptionsforRowNamesorNumbercols"
        Me.grpboxOptionsforRowNamesorNumbercols.Size = New System.Drawing.Size(236, 256)
        Me.grpboxOptionsforRowNamesorNumbercols.TabIndex = 1
        Me.grpboxOptionsforRowNamesorNumbercols.TabStop = False
        Me.grpboxOptionsforRowNamesorNumbercols.Text = "Options"
        '
        'ucrChkAsNumeric
        '
        Me.ucrChkAsNumeric.bAddRemoveParameter = True
        Me.ucrChkAsNumeric.bChangeParameterValue = True
        Me.ucrChkAsNumeric.Checked = False
        Me.ucrChkAsNumeric.Location = New System.Drawing.Point(24, 213)
        Me.ucrChkAsNumeric.Name = "ucrChkAsNumeric"
        Me.ucrChkAsNumeric.Size = New System.Drawing.Size(201, 20)
        Me.ucrChkAsNumeric.TabIndex = 9
        '
        'ucrNewColumnName
        '
        Me.ucrNewColumnName.bAddRemoveParameter = True
        Me.ucrNewColumnName.bChangeParameterValue = True
        Me.ucrNewColumnName.Location = New System.Drawing.Point(11, 42)
        Me.ucrNewColumnName.Name = "ucrNewColumnName"
        Me.ucrNewColumnName.Size = New System.Drawing.Size(217, 24)
        Me.ucrNewColumnName.TabIndex = 1
        '
        'rdoSortAscending
        '
        Me.rdoSortAscending.AutoSize = True
        Me.rdoSortAscending.Location = New System.Drawing.Point(11, 186)
        Me.rdoSortAscending.Name = "rdoSortAscending"
        Me.rdoSortAscending.Size = New System.Drawing.Size(75, 17)
        Me.rdoSortAscending.TabIndex = 7
        Me.rdoSortAscending.TabStop = True
        Me.rdoSortAscending.Text = "Ascending"
        Me.rdoSortAscending.UseVisualStyleBackColor = True
        '
        'rdoSortDescending
        '
        Me.rdoSortDescending.AutoSize = True
        Me.rdoSortDescending.Location = New System.Drawing.Point(113, 186)
        Me.rdoSortDescending.Name = "rdoSortDescending"
        Me.rdoSortDescending.Size = New System.Drawing.Size(82, 17)
        Me.rdoSortDescending.TabIndex = 8
        Me.rdoSortDescending.TabStop = True
        Me.rdoSortDescending.Text = "Descending"
        Me.rdoSortDescending.UseVisualStyleBackColor = True
        '
        'UcrPanel1
        '
        Me.UcrPanel1.bAddRemoveParameter = True
        Me.UcrPanel1.bChangeParameterValue = True
        Me.UcrPanel1.Location = New System.Drawing.Point(5, 178)
        Me.UcrPanel1.Name = "UcrPanel1"
        Me.UcrPanel1.Size = New System.Drawing.Size(225, 67)
        Me.UcrPanel1.TabIndex = 6
        '
        'rdoSortbyRowNames
        '
        Me.rdoSortbyRowNames.AutoSize = True
        Me.rdoSortbyRowNames.Location = New System.Drawing.Point(5, 144)
        Me.rdoSortbyRowNames.Name = "rdoSortbyRowNames"
        Me.rdoSortbyRowNames.Size = New System.Drawing.Size(119, 17)
        Me.rdoSortbyRowNames.TabIndex = 5
        Me.rdoSortbyRowNames.TabStop = True
        Me.rdoSortbyRowNames.Text = "Sort by Row Names"
        Me.rdoSortbyRowNames.UseVisualStyleBackColor = True
        '
        'rdoResetintoPositiveIntegers
        '
        Me.rdoResetintoPositiveIntegers.AutoSize = True
        Me.rdoResetintoPositiveIntegers.Location = New System.Drawing.Point(5, 121)
        Me.rdoResetintoPositiveIntegers.Name = "rdoResetintoPositiveIntegers"
        Me.rdoResetintoPositiveIntegers.Size = New System.Drawing.Size(207, 17)
        Me.rdoResetintoPositiveIntegers.TabIndex = 4
        Me.rdoResetintoPositiveIntegers.TabStop = True
        Me.rdoResetintoPositiveIntegers.Text = "Reset Row Names to Positive Integers"
        Me.rdoResetintoPositiveIntegers.UseVisualStyleBackColor = True
        '
        'rdoCopyfromColumn
        '
        Me.rdoCopyfromColumn.AutoSize = True
        Me.rdoCopyfromColumn.Location = New System.Drawing.Point(5, 77)
        Me.rdoCopyfromColumn.Name = "rdoCopyfromColumn"
        Me.rdoCopyfromColumn.Size = New System.Drawing.Size(163, 17)
        Me.rdoCopyfromColumn.TabIndex = 2
        Me.rdoCopyfromColumn.TabStop = True
        Me.rdoCopyfromColumn.Text = "Set Row Names from Column"
        Me.rdoCopyfromColumn.UseVisualStyleBackColor = True
        '
        'rdoCopytoFirstColumn
        '
        Me.rdoCopytoFirstColumn.AutoSize = True
        Me.rdoCopytoFirstColumn.Location = New System.Drawing.Point(5, 19)
        Me.rdoCopytoFirstColumn.Name = "rdoCopytoFirstColumn"
        Me.rdoCopytoFirstColumn.Size = New System.Drawing.Size(190, 17)
        Me.rdoCopytoFirstColumn.TabIndex = 0
        Me.rdoCopytoFirstColumn.TabStop = True
        Me.rdoCopytoFirstColumn.Text = "Copy Row Names into First Column"
        Me.rdoCopytoFirstColumn.UseVisualStyleBackColor = True
        '
        'ucrReceiverRowNames
        '
        Me.ucrReceiverRowNames.bAddRemoveParameter = True
        Me.ucrReceiverRowNames.bChangeParameterValue = True
        Me.ucrReceiverRowNames.frmParent = Me
        Me.ucrReceiverRowNames.Location = New System.Drawing.Point(24, 98)
        Me.ucrReceiverRowNames.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRowNames.Name = "ucrReceiverRowNames"
        Me.ucrReceiverRowNames.Selector = Nothing
        Me.ucrReceiverRowNames.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRowNames.TabIndex = 3
        '
        'ucrPnlOverallOptions
        '
        Me.ucrPnlOverallOptions.bAddRemoveParameter = True
        Me.ucrPnlOverallOptions.bChangeParameterValue = True
        Me.ucrPnlOverallOptions.Location = New System.Drawing.Point(4, 14)
        Me.ucrPnlOverallOptions.Name = "ucrPnlOverallOptions"
        Me.ucrPnlOverallOptions.Size = New System.Drawing.Size(227, 153)
        Me.ucrPnlOverallOptions.TabIndex = 9
        '
        'ucrSelectorRowNames
        '
        Me.ucrSelectorRowNames.bAddRemoveParameter = True
        Me.ucrSelectorRowNames.bChangeParameterValue = True
        Me.ucrSelectorRowNames.bShowHiddenColumns = False
        Me.ucrSelectorRowNames.bUseCurrentFilter = True
        Me.ucrSelectorRowNames.Location = New System.Drawing.Point(9, 10)
        Me.ucrSelectorRowNames.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorRowNames.Name = "ucrSelectorRowNames"
        Me.ucrSelectorRowNames.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorRowNames.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 274)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 2
        '
        'ucrPnlSortOptions
        '
        Me.ucrPnlSortOptions.bAddRemoveParameter = True
        Me.ucrPnlSortOptions.bChangeParameterValue = True
        Me.ucrPnlSortOptions.Location = New System.Drawing.Point(241, 196)
        Me.ucrPnlSortOptions.Name = "ucrPnlSortOptions"
        Me.ucrPnlSortOptions.Size = New System.Drawing.Size(201, 47)
        Me.ucrPnlSortOptions.TabIndex = 10
        '
        'dlgRowNamesOrNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 330)
        Me.Controls.Add(Me.grpboxOptionsforRowNamesorNumbercols)
        Me.Controls.Add(Me.ucrSelectorRowNames)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlSortOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRowNamesOrNumbers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Row Names Or Numbers"
        Me.grpboxOptionsforRowNamesorNumbercols.ResumeLayout(False)
        Me.grpboxOptionsforRowNamesorNumbercols.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorRowNames As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrPnlSortOptions As UcrPanel
    Friend WithEvents grpboxOptionsforRowNamesorNumbercols As GroupBox
    Friend WithEvents ucrChkAsNumeric As ucrCheck
    Friend WithEvents ucrNewColumnName As ucrSave
    Friend WithEvents rdoSortAscending As RadioButton
    Friend WithEvents rdoSortDescending As RadioButton
    Friend WithEvents rdoSortbyRowNames As RadioButton
    Friend WithEvents rdoResetintoPositiveIntegers As RadioButton
    Friend WithEvents UcrPanel1 As UcrPanel
    Friend WithEvents rdoCopyfromColumn As RadioButton
    Friend WithEvents rdoCopytoFirstColumn As RadioButton
    Friend WithEvents ucrReceiverRowNames As ucrReceiverSingle
    Friend WithEvents ucrPnlOverallOptions As UcrPanel
End Class
