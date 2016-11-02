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
        Me.ucrNewColumnName = New instat.ucrInputTextBox()
        Me.lblColumnName = New System.Windows.Forms.Label()
        Me.grpSortOptions = New System.Windows.Forms.GroupBox()
        Me.rdoSortDescending = New System.Windows.Forms.RadioButton()
        Me.rdoSortAscending = New System.Windows.Forms.RadioButton()
        Me.chkAsNumeric = New System.Windows.Forms.CheckBox()
        Me.rdoSortbyRowNames = New System.Windows.Forms.RadioButton()
        Me.rdoResetintoPositiveIntegers = New System.Windows.Forms.RadioButton()
        Me.rdoCopyfromColumn = New System.Windows.Forms.RadioButton()
        Me.rdoCopytoFirstColumn = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverSingleRownamesOrNumbers = New instat.ucrReceiverSingle()
        Me.ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpboxOptionsforRowNamesorNumbercols.SuspendLayout()
        Me.grpSortOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpboxOptionsforRowNamesorNumbercols
        '
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.ucrNewColumnName)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.lblColumnName)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.grpSortOptions)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoSortbyRowNames)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoResetintoPositiveIntegers)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoCopyfromColumn)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoCopytoFirstColumn)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.ucrReceiverSingleRownamesOrNumbers)
        Me.grpboxOptionsforRowNamesorNumbercols.Location = New System.Drawing.Point(230, 10)
        Me.grpboxOptionsforRowNamesorNumbercols.Name = "grpboxOptionsforRowNamesorNumbercols"
        Me.grpboxOptionsforRowNamesorNumbercols.Size = New System.Drawing.Size(236, 248)
        Me.grpboxOptionsforRowNamesorNumbercols.TabIndex = 4
        Me.grpboxOptionsforRowNamesorNumbercols.TabStop = False
        Me.grpboxOptionsforRowNamesorNumbercols.Text = "Options"
        '
        'ucrNewColumnName
        '
        Me.ucrNewColumnName.IsReadOnly = False
        Me.ucrNewColumnName.Location = New System.Drawing.Point(87, 44)
        Me.ucrNewColumnName.Name = "ucrNewColumnName"
        Me.ucrNewColumnName.Size = New System.Drawing.Size(137, 21)
        Me.ucrNewColumnName.TabIndex = 14
        '
        'lblColumnName
        '
        Me.lblColumnName.AutoSize = True
        Me.lblColumnName.Location = New System.Drawing.Point(4, 47)
        Me.lblColumnName.Name = "lblColumnName"
        Me.lblColumnName.Size = New System.Drawing.Size(76, 13)
        Me.lblColumnName.TabIndex = 13
        Me.lblColumnName.Text = "Column Name:"
        '
        'grpSortOptions
        '
        Me.grpSortOptions.Controls.Add(Me.rdoSortDescending)
        Me.grpSortOptions.Controls.Add(Me.rdoSortAscending)
        Me.grpSortOptions.Controls.Add(Me.chkAsNumeric)
        Me.grpSortOptions.Location = New System.Drawing.Point(6, 167)
        Me.grpSortOptions.Name = "grpSortOptions"
        Me.grpSortOptions.Size = New System.Drawing.Size(216, 76)
        Me.grpSortOptions.TabIndex = 12
        Me.grpSortOptions.TabStop = False
        Me.grpSortOptions.Text = "Sort Options"
        '
        'rdoSortDescending
        '
        Me.rdoSortDescending.AutoSize = True
        Me.rdoSortDescending.Location = New System.Drawing.Point(90, 24)
        Me.rdoSortDescending.Name = "rdoSortDescending"
        Me.rdoSortDescending.Size = New System.Drawing.Size(82, 17)
        Me.rdoSortDescending.TabIndex = 14
        Me.rdoSortDescending.TabStop = True
        Me.rdoSortDescending.Text = "Descending"
        Me.rdoSortDescending.UseVisualStyleBackColor = True
        '
        'rdoSortAscending
        '
        Me.rdoSortAscending.AutoSize = True
        Me.rdoSortAscending.Location = New System.Drawing.Point(6, 23)
        Me.rdoSortAscending.Name = "rdoSortAscending"
        Me.rdoSortAscending.Size = New System.Drawing.Size(75, 17)
        Me.rdoSortAscending.TabIndex = 13
        Me.rdoSortAscending.TabStop = True
        Me.rdoSortAscending.Text = "Ascending"
        Me.rdoSortAscending.UseVisualStyleBackColor = True
        '
        'chkAsNumeric
        '
        Me.chkAsNumeric.AutoSize = True
        Me.chkAsNumeric.Location = New System.Drawing.Point(6, 49)
        Me.chkAsNumeric.Name = "chkAsNumeric"
        Me.chkAsNumeric.Size = New System.Drawing.Size(168, 17)
        Me.chkAsNumeric.TabIndex = 11
        Me.chkAsNumeric.Text = "Treat Row Names as Numeric"
        Me.chkAsNumeric.UseVisualStyleBackColor = True
        '
        'rdoSortbyRowNames
        '
        Me.rdoSortbyRowNames.AutoSize = True
        Me.rdoSortbyRowNames.Location = New System.Drawing.Point(5, 144)
        Me.rdoSortbyRowNames.Name = "rdoSortbyRowNames"
        Me.rdoSortbyRowNames.Size = New System.Drawing.Size(119, 17)
        Me.rdoSortbyRowNames.TabIndex = 7
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
        Me.rdoResetintoPositiveIntegers.TabIndex = 6
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
        Me.rdoCopyfromColumn.TabIndex = 5
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
        Me.rdoCopytoFirstColumn.TabIndex = 4
        Me.rdoCopytoFirstColumn.TabStop = True
        Me.rdoCopytoFirstColumn.Text = "Copy Row Names into First Column"
        Me.rdoCopytoFirstColumn.UseVisualStyleBackColor = True
        '
        'ucrReceiverSingleRownamesOrNumbers
        '
        Me.ucrReceiverSingleRownamesOrNumbers.Location = New System.Drawing.Point(24, 98)
        Me.ucrReceiverSingleRownamesOrNumbers.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingleRownamesOrNumbers.Name = "ucrReceiverSingleRownamesOrNumbers"
        Me.ucrReceiverSingleRownamesOrNumbers.Selector = Nothing
        Me.ucrReceiverSingleRownamesOrNumbers.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSingleRownamesOrNumbers.TabIndex = 3
        '
        'ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers
        '
        Me.ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.bShowHiddenColumns = False
        Me.ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.bUseCurrentFilter = False
        Me.ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.Name = "ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers"
        Me.ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.TabIndex = 8
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 274)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'dlgRowNamesOrNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 330)
        Me.Controls.Add(Me.ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers)
        Me.Controls.Add(Me.grpboxOptionsforRowNamesorNumbercols)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRowNamesOrNumbers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Row Names Or Numbers"
        Me.grpboxOptionsforRowNamesorNumbercols.ResumeLayout(False)
        Me.grpboxOptionsforRowNamesorNumbercols.PerformLayout()
        Me.grpSortOptions.ResumeLayout(False)
        Me.grpSortOptions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverSingleRownamesOrNumbers As ucrReceiverSingle
    Friend WithEvents grpboxOptionsforRowNamesorNumbercols As GroupBox
    Friend WithEvents rdoSortbyRowNames As RadioButton
    Friend WithEvents rdoResetintoPositiveIntegers As RadioButton
    Friend WithEvents rdoCopyfromColumn As RadioButton
    Friend WithEvents rdoCopytoFirstColumn As RadioButton
    Friend WithEvents ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers As ucrSelectorByDataFrameAddRemove
    Friend WithEvents chkAsNumeric As CheckBox
    Friend WithEvents grpSortOptions As GroupBox
    Friend WithEvents rdoSortDescending As RadioButton
    Friend WithEvents rdoSortAscending As RadioButton
    Friend WithEvents lblColumnName As Label
    Friend WithEvents ucrNewColumnName As ucrInputTextBox
End Class
