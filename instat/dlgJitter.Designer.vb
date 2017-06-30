<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgJitter
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
        Me.ucrSelectorForJitter = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverJitter = New instat.ucrReceiverSingle()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.grpMaximumAndMinimumValues = New System.Windows.Forms.GroupBox()
        Me.ucrInputMaximum = New instat.ucrInputTextBox()
        Me.ucrInputMinimum = New instat.ucrInputTextBox()
        Me.ucrInputMaximumDistanceFromZero = New instat.ucrInputTextBox()
        Me.rdoMinimumAndMaximum = New System.Windows.Forms.RadioButton()
        Me.rdoMaximumDistanceFromZero = New System.Windows.Forms.RadioButton()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.ucrInputNewColumnName = New instat.ucrInputComboBox()
        Me.grpMaximumAndMinimumValues.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 246)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 6
        '
        'ucrSelectorForJitter
        '
        Me.ucrSelectorForJitter.bShowHiddenColumns = False
        Me.ucrSelectorForJitter.bUseCurrentFilter = True
        Me.ucrSelectorForJitter.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForJitter.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForJitter.Name = "ucrSelectorForJitter"
        Me.ucrSelectorForJitter.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForJitter.TabIndex = 0
        '
        'ucrReceiverJitter
        '
        Me.ucrReceiverJitter.frmParent = Me
        Me.ucrReceiverJitter.Location = New System.Drawing.Point(249, 43)
        Me.ucrReceiverJitter.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverJitter.Name = "ucrReceiverJitter"
        Me.ucrReceiverJitter.Selector = Nothing
        Me.ucrReceiverJitter.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverJitter.strNcFilePath = ""
        Me.ucrReceiverJitter.TabIndex = 2
        Me.ucrReceiverJitter.ucrSelector = Nothing
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
        Me.lblSelectedVariable.Location = New System.Drawing.Point(249, 28)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(93, 13)
        Me.lblSelectedVariable.TabIndex = 1
        Me.lblSelectedVariable.Text = "Selected Variable:"
        '
        'grpMaximumAndMinimumValues
        '
        Me.grpMaximumAndMinimumValues.Controls.Add(Me.ucrInputMaximum)
        Me.grpMaximumAndMinimumValues.Controls.Add(Me.ucrInputMinimum)
        Me.grpMaximumAndMinimumValues.Controls.Add(Me.ucrInputMaximumDistanceFromZero)
        Me.grpMaximumAndMinimumValues.Controls.Add(Me.rdoMinimumAndMaximum)
        Me.grpMaximumAndMinimumValues.Controls.Add(Me.rdoMaximumDistanceFromZero)
        Me.grpMaximumAndMinimumValues.Location = New System.Drawing.Point(242, 66)
        Me.grpMaximumAndMinimumValues.Name = "grpMaximumAndMinimumValues"
        Me.grpMaximumAndMinimumValues.Size = New System.Drawing.Size(167, 147)
        Me.grpMaximumAndMinimumValues.TabIndex = 3
        Me.grpMaximumAndMinimumValues.TabStop = False
        '
        'ucrInputMaximum
        '
        Me.ucrInputMaximum.AddQuotesIfUnrecognised = True
        Me.ucrInputMaximum.IsMultiline = False
        Me.ucrInputMaximum.IsReadOnly = False
        Me.ucrInputMaximum.Location = New System.Drawing.Point(7, 120)
        Me.ucrInputMaximum.Name = "ucrInputMaximum"
        Me.ucrInputMaximum.Size = New System.Drawing.Size(59, 21)
        Me.ucrInputMaximum.TabIndex = 4
        '
        'ucrInputMinimum
        '
        Me.ucrInputMinimum.AddQuotesIfUnrecognised = True
        Me.ucrInputMinimum.IsMultiline = False
        Me.ucrInputMinimum.IsReadOnly = False
        Me.ucrInputMinimum.Location = New System.Drawing.Point(7, 94)
        Me.ucrInputMinimum.Name = "ucrInputMinimum"
        Me.ucrInputMinimum.Size = New System.Drawing.Size(59, 21)
        Me.ucrInputMinimum.TabIndex = 3
        '
        'ucrInputMaximumDistanceFromZero
        '
        Me.ucrInputMaximumDistanceFromZero.AddQuotesIfUnrecognised = True
        Me.ucrInputMaximumDistanceFromZero.IsMultiline = False
        Me.ucrInputMaximumDistanceFromZero.IsReadOnly = False
        Me.ucrInputMaximumDistanceFromZero.Location = New System.Drawing.Point(7, 43)
        Me.ucrInputMaximumDistanceFromZero.Name = "ucrInputMaximumDistanceFromZero"
        Me.ucrInputMaximumDistanceFromZero.Size = New System.Drawing.Size(59, 21)
        Me.ucrInputMaximumDistanceFromZero.TabIndex = 1
        '
        'rdoMinimumAndMaximum
        '
        Me.rdoMinimumAndMaximum.AutoSize = True
        Me.rdoMinimumAndMaximum.Location = New System.Drawing.Point(7, 71)
        Me.rdoMinimumAndMaximum.Name = "rdoMinimumAndMaximum"
        Me.rdoMinimumAndMaximum.Size = New System.Drawing.Size(134, 17)
        Me.rdoMinimumAndMaximum.TabIndex = 2
        Me.rdoMinimumAndMaximum.TabStop = True
        Me.rdoMinimumAndMaximum.Text = "Minimum and Maximum"
        Me.rdoMinimumAndMaximum.UseVisualStyleBackColor = True
        '
        'rdoMaximumDistanceFromZero
        '
        Me.rdoMaximumDistanceFromZero.AutoSize = True
        Me.rdoMaximumDistanceFromZero.Location = New System.Drawing.Point(7, 19)
        Me.rdoMaximumDistanceFromZero.Name = "rdoMaximumDistanceFromZero"
        Me.rdoMaximumDistanceFromZero.Size = New System.Drawing.Size(146, 17)
        Me.rdoMaximumDistanceFromZero.TabIndex = 0
        Me.rdoMaximumDistanceFromZero.TabStop = True
        Me.rdoMaximumDistanceFromZero.Text = "Maximum Distance from 0"
        Me.rdoMaximumDistanceFromZero.UseVisualStyleBackColor = True
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(8, 223)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(101, 13)
        Me.lblNewColumnName.TabIndex = 4
        Me.lblNewColumnName.Text = "New Column Name:"
        '
        'ucrInputNewColumnName
        '
        Me.ucrInputNewColumnName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewColumnName.IsReadOnly = False
        Me.ucrInputNewColumnName.Location = New System.Drawing.Point(115, 219)
        Me.ucrInputNewColumnName.Name = "ucrInputNewColumnName"
        Me.ucrInputNewColumnName.Size = New System.Drawing.Size(193, 21)
        Me.ucrInputNewColumnName.TabIndex = 5
        '
        'dlgJitter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 302)
        Me.Controls.Add(Me.ucrInputNewColumnName)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.grpMaximumAndMinimumValues)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.ucrReceiverJitter)
        Me.Controls.Add(Me.ucrSelectorForJitter)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgJitter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Jitter"
        Me.Text = "Jitter"
        Me.grpMaximumAndMinimumValues.ResumeLayout(False)
        Me.grpMaximumAndMinimumValues.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForJitter As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverJitter As ucrReceiverSingle
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents grpMaximumAndMinimumValues As GroupBox
    Friend WithEvents rdoMinimumAndMaximum As RadioButton
    Friend WithEvents rdoMaximumDistanceFromZero As RadioButton
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents ucrInputNewColumnName As ucrInputComboBox
    Friend WithEvents ucrInputMaximumDistanceFromZero As ucrInputTextBox
    Friend WithEvents ucrInputMinimum As ucrInputTextBox
    Friend WithEvents ucrInputMaximum As ucrInputTextBox
End Class
