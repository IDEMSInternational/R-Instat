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
        Me.ucrNewValue = New instat.ucrReceiverMetadataProperty()
        Me.grpProperty = New System.Windows.Forms.GroupBox()
        Me.ucrInputDefineProperty = New instat.ucrInputTextBox()
        Me.grpProperty.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 279)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 10
        '
        'ucrSelectByMetadata
        '
        Me.ucrSelectByMetadata.bShowHiddenColumns = False
        Me.ucrSelectByMetadata.bUseCurrentFilter = False
        Me.ucrSelectByMetadata.Location = New System.Drawing.Point(9, 12)
        Me.ucrSelectByMetadata.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectByMetadata.Name = "ucrSelectByMetadata"
        Me.ucrSelectByMetadata.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectByMetadata.TabIndex = 9
        '
        'ucrReceiverChooseProperty
        '
        Me.ucrReceiverChooseProperty.Location = New System.Drawing.Point(242, 65)
        Me.ucrReceiverChooseProperty.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverChooseProperty.Name = "ucrReceiverChooseProperty"
        Me.ucrReceiverChooseProperty.Selector = Nothing
        Me.ucrReceiverChooseProperty.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverChooseProperty.TabIndex = 8
        '
        'rdoChooseProperty
        '
        Me.rdoChooseProperty.Location = New System.Drawing.Point(6, 19)
        Me.rdoChooseProperty.Name = "rdoChooseProperty"
        Me.rdoChooseProperty.Size = New System.Drawing.Size(104, 24)
        Me.rdoChooseProperty.TabIndex = 0
        Me.rdoChooseProperty.TabStop = True
        Me.rdoChooseProperty.Text = "Choose Property"
        Me.rdoChooseProperty.UseVisualStyleBackColor = True
        '
        'rdoDefineNewProperty
        '
        Me.rdoDefineNewProperty.Location = New System.Drawing.Point(116, 19)
        Me.rdoDefineNewProperty.Name = "rdoDefineNewProperty"
        Me.rdoDefineNewProperty.Size = New System.Drawing.Size(138, 24)
        Me.rdoDefineNewProperty.TabIndex = 1
        Me.rdoDefineNewProperty.TabStop = True
        Me.rdoDefineNewProperty.Text = "Define New Property"
        Me.rdoDefineNewProperty.UseVisualStyleBackColor = True
        '
        'lblChooseColumns
        '
        Me.lblChooseColumns.Location = New System.Drawing.Point(239, 89)
        Me.lblChooseColumns.Name = "lblChooseColumns"
        Me.lblChooseColumns.Size = New System.Drawing.Size(100, 23)
        Me.lblChooseColumns.TabIndex = 7
        Me.lblChooseColumns.Text = "Choose Columns"
        '
        'ucrReceiverChooseColumns
        '
        Me.ucrReceiverChooseColumns.Location = New System.Drawing.Point(242, 112)
        Me.ucrReceiverChooseColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverChooseColumns.Name = "ucrReceiverChooseColumns"
        Me.ucrReceiverChooseColumns.Selector = Nothing
        Me.ucrReceiverChooseColumns.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverChooseColumns.TabIndex = 6
        '
        'lblCurrentValue
        '
        Me.lblCurrentValue.Location = New System.Drawing.Point(6, 221)
        Me.lblCurrentValue.Name = "lblCurrentValue"
        Me.lblCurrentValue.Size = New System.Drawing.Size(84, 23)
        Me.lblCurrentValue.TabIndex = 5
        Me.lblCurrentValue.Text = "Current Value"
        '
        'lblNewValue
        '
        Me.lblNewValue.Location = New System.Drawing.Point(6, 255)
        Me.lblNewValue.Name = "lblNewValue"
        Me.lblNewValue.Size = New System.Drawing.Size(76, 18)
        Me.lblNewValue.TabIndex = 4
        Me.lblNewValue.Text = "New Value"
        '
        'ucrCurrentValue
        '
        Me.ucrCurrentValue.IsReadOnly = False
        Me.ucrCurrentValue.Location = New System.Drawing.Point(105, 221)
        Me.ucrCurrentValue.Name = "ucrCurrentValue"
        Me.ucrCurrentValue.Size = New System.Drawing.Size(137, 21)
        Me.ucrCurrentValue.TabIndex = 3
        '
        'ucrNewValue
        '
        Me.ucrNewValue.Location = New System.Drawing.Point(102, 251)
        Me.ucrNewValue.Name = "ucrNewValue"
        Me.ucrNewValue.Size = New System.Drawing.Size(140, 22)
        Me.ucrNewValue.TabIndex = 2
        '
        'grpProperty
        '
        Me.grpProperty.Controls.Add(Me.rdoChooseProperty)
        Me.grpProperty.Controls.Add(Me.rdoDefineNewProperty)
        Me.grpProperty.Location = New System.Drawing.Point(242, 12)
        Me.grpProperty.Name = "grpProperty"
        Me.grpProperty.Size = New System.Drawing.Size(282, 49)
        Me.grpProperty.TabIndex = 1
        Me.grpProperty.TabStop = False
        '
        'ucrInputDefineProperty
        '
        Me.ucrInputDefineProperty.IsReadOnly = False
        Me.ucrInputDefineProperty.Location = New System.Drawing.Point(242, 65)
        Me.ucrInputDefineProperty.Name = "ucrInputDefineProperty"
        Me.ucrInputDefineProperty.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDefineProperty.TabIndex = 0
        '
        'dlgMetadata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 338)
        Me.Controls.Add(Me.ucrInputDefineProperty)
        Me.Controls.Add(Me.grpProperty)
        Me.Controls.Add(Me.ucrNewValue)
        Me.Controls.Add(Me.ucrCurrentValue)
        Me.Controls.Add(Me.lblNewValue)
        Me.Controls.Add(Me.lblCurrentValue)
        Me.Controls.Add(Me.ucrReceiverChooseColumns)
        Me.Controls.Add(Me.lblChooseColumns)
        Me.Controls.Add(Me.ucrReceiverChooseProperty)
        Me.Controls.Add(Me.ucrSelectByMetadata)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMetadata"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Metadata"
        Me.Text = "Metadata"
        Me.grpProperty.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents ucrNewValue As ucrReceiverMetadataProperty
    Friend WithEvents grpProperty As GroupBox
    Friend WithEvents ucrInputDefineProperty As ucrInputTextBox
End Class
