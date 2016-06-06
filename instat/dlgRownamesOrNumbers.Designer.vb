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
        Me.chkDecreasingforRownamesOrNumbers = New System.Windows.Forms.CheckBox()
        Me.rdoCopytoColumnsforRownamesOrNumbers = New System.Windows.Forms.RadioButton()
        Me.rdoSortbyRowNamesorNumbers = New System.Windows.Forms.RadioButton()
        Me.rdoResetintoPositiveIntegers = New System.Windows.Forms.RadioButton()
        Me.rdoCopyfromColumn = New System.Windows.Forms.RadioButton()
        Me.rdoCopytoFirstColumn = New System.Windows.Forms.RadioButton()
        Me.ucrNewColumnNameforRownamesOrNumbers = New instat.ucrNewColumnName()
        Me.ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverSingleRownamesOrNumbers = New instat.ucrReceiverSingle()
        Me.ucrBaseRownamesorNumbers = New instat.ucrButtons()
        Me.grpboxOptionsforRowNamesorNumbercols.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpboxOptionsforRowNamesorNumbercols
        '
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.chkDecreasingforRownamesOrNumbers)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoCopytoColumnsforRownamesOrNumbers)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoSortbyRowNamesorNumbers)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoResetintoPositiveIntegers)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoCopyfromColumn)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoCopytoFirstColumn)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.ucrReceiverSingleRownamesOrNumbers)
        Me.grpboxOptionsforRowNamesorNumbercols.Location = New System.Drawing.Point(230, 0)
        Me.grpboxOptionsforRowNamesorNumbercols.Name = "grpboxOptionsforRowNamesorNumbercols"
        Me.grpboxOptionsforRowNamesorNumbercols.Size = New System.Drawing.Size(200, 198)
        Me.grpboxOptionsforRowNamesorNumbercols.TabIndex = 4
        Me.grpboxOptionsforRowNamesorNumbercols.TabStop = False
        Me.grpboxOptionsforRowNamesorNumbercols.Text = "Options"
        '
        'chkDecreasingforRownamesOrNumbers
        '
        Me.chkDecreasingforRownamesOrNumbers.AutoSize = True
        Me.chkDecreasingforRownamesOrNumbers.Location = New System.Drawing.Point(31, 172)
        Me.chkDecreasingforRownamesOrNumbers.Name = "chkDecreasingforRownamesOrNumbers"
        Me.chkDecreasingforRownamesOrNumbers.Size = New System.Drawing.Size(80, 17)
        Me.chkDecreasingforRownamesOrNumbers.TabIndex = 9
        Me.chkDecreasingforRownamesOrNumbers.Text = "Decreasing"
        Me.chkDecreasingforRownamesOrNumbers.UseVisualStyleBackColor = True
        Me.chkDecreasingforRownamesOrNumbers.Visible = False
        '
        'rdoCopytoColumnsforRownamesOrNumbers
        '
        Me.rdoCopytoColumnsforRownamesOrNumbers.AutoSize = True
        Me.rdoCopytoColumnsforRownamesOrNumbers.Location = New System.Drawing.Point(6, 41)
        Me.rdoCopytoColumnsforRownamesOrNumbers.Name = "rdoCopytoColumnsforRownamesOrNumbers"
        Me.rdoCopytoColumnsforRownamesOrNumbers.Size = New System.Drawing.Size(99, 17)
        Me.rdoCopytoColumnsforRownamesOrNumbers.TabIndex = 8
        Me.rdoCopytoColumnsforRownamesOrNumbers.TabStop = True
        Me.rdoCopytoColumnsforRownamesOrNumbers.Text = "Copy to Column"
        Me.rdoCopytoColumnsforRownamesOrNumbers.UseVisualStyleBackColor = True
        '
        'rdoSortbyRowNamesorNumbers
        '
        Me.rdoSortbyRowNamesorNumbers.AutoSize = True
        Me.rdoSortbyRowNamesorNumbers.Location = New System.Drawing.Point(6, 149)
        Me.rdoSortbyRowNamesorNumbers.Name = "rdoSortbyRowNamesorNumbers"
        Me.rdoSortbyRowNamesorNumbers.Size = New System.Drawing.Size(176, 17)
        Me.rdoSortbyRowNamesorNumbers.TabIndex = 7
        Me.rdoSortbyRowNamesorNumbers.TabStop = True
        Me.rdoSortbyRowNamesorNumbers.Text = "Sort by Row Names or Numbers"
        Me.rdoSortbyRowNamesorNumbers.UseVisualStyleBackColor = True
        '
        'rdoResetintoPositiveIntegers
        '
        Me.rdoResetintoPositiveIntegers.AutoSize = True
        Me.rdoResetintoPositiveIntegers.Location = New System.Drawing.Point(6, 125)
        Me.rdoResetintoPositiveIntegers.Name = "rdoResetintoPositiveIntegers"
        Me.rdoResetintoPositiveIntegers.Size = New System.Drawing.Size(154, 17)
        Me.rdoResetintoPositiveIntegers.TabIndex = 6
        Me.rdoResetintoPositiveIntegers.TabStop = True
        Me.rdoResetintoPositiveIntegers.Text = "Reset into Positive Integers"
        Me.rdoResetintoPositiveIntegers.UseVisualStyleBackColor = True
        '
        'rdoCopyfromColumn
        '
        Me.rdoCopyfromColumn.AutoSize = True
        Me.rdoCopyfromColumn.Location = New System.Drawing.Point(6, 64)
        Me.rdoCopyfromColumn.Name = "rdoCopyfromColumn"
        Me.rdoCopyfromColumn.Size = New System.Drawing.Size(110, 17)
        Me.rdoCopyfromColumn.TabIndex = 5
        Me.rdoCopyfromColumn.TabStop = True
        Me.rdoCopyfromColumn.Text = "Copy from Column"
        Me.rdoCopyfromColumn.UseVisualStyleBackColor = True
        '
        'rdoCopytoFirstColumn
        '
        Me.rdoCopytoFirstColumn.AutoSize = True
        Me.rdoCopytoFirstColumn.Location = New System.Drawing.Point(6, 19)
        Me.rdoCopytoFirstColumn.Name = "rdoCopytoFirstColumn"
        Me.rdoCopytoFirstColumn.Size = New System.Drawing.Size(129, 17)
        Me.rdoCopytoFirstColumn.TabIndex = 4
        Me.rdoCopytoFirstColumn.TabStop = True
        Me.rdoCopytoFirstColumn.Text = "Copy into First Column"
        Me.rdoCopytoFirstColumn.UseVisualStyleBackColor = True
        '
        'ucrNewColumnNameforRownamesOrNumbers
        '
        Me.ucrNewColumnNameforRownamesOrNumbers.Location = New System.Drawing.Point(0, 198)
        Me.ucrNewColumnNameforRownamesOrNumbers.Name = "ucrNewColumnNameforRownamesOrNumbers"
        Me.ucrNewColumnNameforRownamesOrNumbers.Size = New System.Drawing.Size(367, 35)
        Me.ucrNewColumnNameforRownamesOrNumbers.TabIndex = 9
        Me.ucrNewColumnNameforRownamesOrNumbers.ucrDataFrameSelector = Nothing
        Me.ucrNewColumnNameforRownamesOrNumbers.Visible = False
        '
        'ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers
        '
        Me.ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.Name = "ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers"
        Me.ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.TabIndex = 8
        '
        'ucrReceiverSingleRownamesOrNumbers
        '
        Me.ucrReceiverSingleRownamesOrNumbers.Location = New System.Drawing.Point(31, 91)
        Me.ucrReceiverSingleRownamesOrNumbers.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingleRownamesOrNumbers.Name = "ucrReceiverSingleRownamesOrNumbers"
        Me.ucrReceiverSingleRownamesOrNumbers.Selector = Nothing
        Me.ucrReceiverSingleRownamesOrNumbers.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSingleRownamesOrNumbers.TabIndex = 3
        '
        'ucrBaseRownamesorNumbers
        '
        Me.ucrBaseRownamesorNumbers.Location = New System.Drawing.Point(30, 234)
        Me.ucrBaseRownamesorNumbers.Name = "ucrBaseRownamesorNumbers"
        Me.ucrBaseRownamesorNumbers.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseRownamesorNumbers.TabIndex = 0
        '
        'dlgRowNamesOrNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 285)
        Me.Controls.Add(Me.ucrNewColumnNameforRownamesOrNumbers)
        Me.Controls.Add(Me.ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers)
        Me.Controls.Add(Me.grpboxOptionsforRowNamesorNumbercols)
        Me.Controls.Add(Me.ucrBaseRownamesorNumbers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "dlgRowNamesOrNumbers"
        Me.Text = "Row Names Or Numbers"
        Me.grpboxOptionsforRowNamesorNumbercols.ResumeLayout(False)
        Me.grpboxOptionsforRowNamesorNumbercols.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseRownamesorNumbers As ucrButtons
    Friend WithEvents ucrReceiverSingleRownamesOrNumbers As ucrReceiverSingle
    Friend WithEvents grpboxOptionsforRowNamesorNumbercols As GroupBox
    Friend WithEvents rdoSortbyRowNamesorNumbers As RadioButton
    Friend WithEvents rdoResetintoPositiveIntegers As RadioButton
    Friend WithEvents rdoCopyfromColumn As RadioButton
    Friend WithEvents rdoCopytoFirstColumn As RadioButton
    Friend WithEvents chkDecreasingforRownamesOrNumbers As CheckBox
    Friend WithEvents rdoCopytoColumnsforRownamesOrNumbers As RadioButton
    Friend WithEvents ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrNewColumnNameforRownamesOrNumbers As ucrNewColumnName
End Class
