<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgMetadata
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectByMetadata = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverChooseProperty = New instat.ucrReceiverSingle()
        Me.rdoChooseProperty = New System.Windows.Forms.RadioButton()
        Me.rdoDefineNewProperty = New System.Windows.Forms.RadioButton()
        Me.lblChooseColumns = New System.Windows.Forms.Label()
        Me.ucrReceiverChooseColumns = New instat.ucrReceiverMultiple()
        Me.lblCurrentValue = New System.Windows.Forms.Label()
        Me.lblNewValue = New System.Windows.Forms.Label()
        Me.ucrCurrentValue = New instat.ucrInputTextBox()
        Me.ucrReceiverNewValue = New instat.ucrReceiverMetadataProperty()
        Me.grpProperty = New System.Windows.Forms.GroupBox()
        Me.ucrInputDefineProperty = New instat.ucrInputTextBox()
        Me.grpProperty.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 255)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(402, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectByMetadata
        '
        Me.ucrSelectByMetadata.bShowHiddenColumns = False
        Me.ucrSelectByMetadata.bUseCurrentFilter = False
        Me.ucrSelectByMetadata.Location = New System.Drawing.Point(12, 13)
        Me.ucrSelectByMetadata.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectByMetadata.Name = "ucrSelectByMetadata"
        Me.ucrSelectByMetadata.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectByMetadata.TabIndex = 8
        '
        'ucrReceiverChooseProperty
        '
        Me.ucrReceiverChooseProperty.Location = New System.Drawing.Point(216, 38)
        Me.ucrReceiverChooseProperty.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverChooseProperty.Name = "ucrReceiverChooseProperty"
        Me.ucrReceiverChooseProperty.Selector = Nothing
        Me.ucrReceiverChooseProperty.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverChooseProperty.TabIndex = 10
        '
        'rdoChooseProperty
        '
        Me.rdoChooseProperty.AutoSize = True
        Me.rdoChooseProperty.Location = New System.Drawing.Point(6, 8)
        Me.rdoChooseProperty.Name = "rdoChooseProperty"
        Me.rdoChooseProperty.Size = New System.Drawing.Size(103, 17)
        Me.rdoChooseProperty.TabIndex = 11
        Me.rdoChooseProperty.TabStop = True
        Me.rdoChooseProperty.Text = "Choose Property"
        Me.rdoChooseProperty.UseVisualStyleBackColor = True
        '
        'rdoDefineNewProperty
        '
        Me.rdoDefineNewProperty.AutoSize = True
        Me.rdoDefineNewProperty.Location = New System.Drawing.Point(115, 8)
        Me.rdoDefineNewProperty.Name = "rdoDefineNewProperty"
        Me.rdoDefineNewProperty.Size = New System.Drawing.Size(121, 17)
        Me.rdoDefineNewProperty.TabIndex = 11
        Me.rdoDefineNewProperty.TabStop = True
        Me.rdoDefineNewProperty.Text = "Define new Property"
        Me.rdoDefineNewProperty.UseVisualStyleBackColor = True
        '
        'lblChooseColumns
        '
        Me.lblChooseColumns.AutoSize = True
        Me.lblChooseColumns.Location = New System.Drawing.Point(223, 63)
        Me.lblChooseColumns.Name = "lblChooseColumns"
        Me.lblChooseColumns.Size = New System.Drawing.Size(92, 13)
        Me.lblChooseColumns.TabIndex = 12
        Me.lblChooseColumns.Text = "Choose Column(s)"
        '
        'ucrReceiverChooseColumns
        '
        Me.ucrReceiverChooseColumns.Location = New System.Drawing.Point(226, 80)
        Me.ucrReceiverChooseColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverChooseColumns.Name = "ucrReceiverChooseColumns"
        Me.ucrReceiverChooseColumns.Selector = Nothing
        Me.ucrReceiverChooseColumns.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverChooseColumns.TabIndex = 13
        '
        'lblCurrentValue
        '
        Me.lblCurrentValue.AutoSize = True
        Me.lblCurrentValue.Location = New System.Drawing.Point(9, 206)
        Me.lblCurrentValue.Name = "lblCurrentValue"
        Me.lblCurrentValue.Size = New System.Drawing.Size(70, 13)
        Me.lblCurrentValue.TabIndex = 14
        Me.lblCurrentValue.Text = "Current value"
        '
        'lblNewValue
        '
        Me.lblNewValue.AutoSize = True
        Me.lblNewValue.Location = New System.Drawing.Point(9, 239)
        Me.lblNewValue.Name = "lblNewValue"
        Me.lblNewValue.Size = New System.Drawing.Size(58, 13)
        Me.lblNewValue.TabIndex = 15
        Me.lblNewValue.Text = "New value"
        '
        'ucrCurrentValue
        '
        Me.ucrCurrentValue.IsReadOnly = False
        Me.ucrCurrentValue.Location = New System.Drawing.Point(97, 202)
        Me.ucrCurrentValue.Name = "ucrCurrentValue"
        Me.ucrCurrentValue.Size = New System.Drawing.Size(249, 21)
        Me.ucrCurrentValue.TabIndex = 16
        '
        'ucrReceiverNewValue
        '
        Me.ucrReceiverNewValue.Location = New System.Drawing.Point(97, 229)
        Me.ucrReceiverNewValue.Name = "ucrReceiverNewValue"
        Me.ucrReceiverNewValue.Size = New System.Drawing.Size(187, 23)
        Me.ucrReceiverNewValue.TabIndex = 17
        '
        'grpProperty
        '
        Me.grpProperty.Controls.Add(Me.rdoChooseProperty)
        Me.grpProperty.Controls.Add(Me.rdoDefineNewProperty)
        Me.grpProperty.Location = New System.Drawing.Point(216, -2)
        Me.grpProperty.Name = "grpProperty"
        Me.grpProperty.Size = New System.Drawing.Size(243, 33)
        Me.grpProperty.TabIndex = 18
        Me.grpProperty.TabStop = False
        '
        'ucrInputDefineProperty
        '
        Me.ucrInputDefineProperty.IsReadOnly = False
        Me.ucrInputDefineProperty.Location = New System.Drawing.Point(216, 37)
        Me.ucrInputDefineProperty.Name = "ucrInputDefineProperty"
        Me.ucrInputDefineProperty.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDefineProperty.TabIndex = 19
        '
        'dlgMetadata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 308)
        Me.Controls.Add(Me.ucrInputDefineProperty)
        Me.Controls.Add(Me.grpProperty)
        Me.Controls.Add(Me.ucrReceiverNewValue)
        Me.Controls.Add(Me.ucrCurrentValue)
        Me.Controls.Add(Me.lblNewValue)
        Me.Controls.Add(Me.lblCurrentValue)
        Me.Controls.Add(Me.ucrReceiverChooseColumns)
        Me.Controls.Add(Me.lblChooseColumns)
        Me.Controls.Add(Me.ucrReceiverChooseProperty)
        Me.Controls.Add(Me.ucrSelectByMetadata)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgMetadata"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Metadata"
        Me.Text = "Metadata"
        Me.grpProperty.ResumeLayout(False)
        Me.grpProperty.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectByMetadata As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverChooseProperty As ucrReceiverSingle
    Friend WithEvents rdoChooseProperty As RadioButton
    Friend WithEvents rdoDefineNewProperty As RadioButton
    Friend WithEvents lblChooseColumns As Label
    Friend WithEvents ucrReceiverChooseColumns As ucrReceiverMultiple
    Friend WithEvents lblCurrentValue As Label
    Friend WithEvents lblNewValue As Label
    Friend WithEvents ucrCurrentValue As ucrInputTextBox
    Friend WithEvents ucrReceiverNewValue As ucrReceiverMetadataProperty
    Friend WithEvents grpProperty As GroupBox
    Friend WithEvents ucrInputDefineProperty As ucrInputTextBox
End Class
