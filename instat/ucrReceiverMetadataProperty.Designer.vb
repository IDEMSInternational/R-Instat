<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrReceiverMetadataProperty
    Inherits instat.ucrCore

    'UserControl overrides dispose to clean up the component list.
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
        Me.ucrInputTextValue = New instat.ucrInputTextBox()
        Me.ucrInputCboParamValue = New instat.ucrInputComboBox()
        Me.ucrColor = New instat.ucrColors()
        Me.ucrNudParamValue = New instat.ucrNud()
        Me.SuspendLayout()
        '
        'ucrInputTextValue
        '
        Me.ucrInputTextValue.AddQuotesIfUnrecognised = True
        Me.ucrInputTextValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrInputTextValue.IsMultiline = False
        Me.ucrInputTextValue.IsReadOnly = False
        Me.ucrInputTextValue.Location = New System.Drawing.Point(0, 0)
        Me.ucrInputTextValue.Name = "ucrInputTextValue"
        Me.ucrInputTextValue.Size = New System.Drawing.Size(140, 22)
        Me.ucrInputTextValue.TabIndex = 11
        '
        'ucrInputCboParamValue
        '
        Me.ucrInputCboParamValue.AddQuotesIfUnrecognised = True
        Me.ucrInputCboParamValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrInputCboParamValue.IsReadOnly = False
        Me.ucrInputCboParamValue.Location = New System.Drawing.Point(0, 0)
        Me.ucrInputCboParamValue.Name = "ucrInputCboParamValue"
        Me.ucrInputCboParamValue.Size = New System.Drawing.Size(140, 22)
        Me.ucrInputCboParamValue.TabIndex = 10
        '
        'ucrColor
        '
        Me.ucrColor.AddQuotesIfUnrecognised = True
        Me.ucrColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrColor.IsReadOnly = False
        Me.ucrColor.Location = New System.Drawing.Point(0, 0)
        Me.ucrColor.Name = "ucrColor"
        Me.ucrColor.Size = New System.Drawing.Size(140, 22)
        Me.ucrColor.TabIndex = 9
        '
        'ucrNudParamValue
        '
        Me.ucrNudParamValue.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudParamValue.Dock = System.Windows.Forms.DockStyle.Left
        Me.ucrNudParamValue.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudParamValue.Location = New System.Drawing.Point(0, 0)
        Me.ucrNudParamValue.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudParamValue.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudParamValue.Name = "ucrNudParamValue"
        Me.ucrNudParamValue.Size = New System.Drawing.Size(50, 22)
        Me.ucrNudParamValue.TabIndex = 12
        Me.ucrNudParamValue.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverMetadataProperty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrNudParamValue)
        Me.Controls.Add(Me.ucrInputTextValue)
        Me.Controls.Add(Me.ucrInputCboParamValue)
        Me.Controls.Add(Me.ucrColor)
        Me.Name = "ucrReceiverMetadataProperty"
        Me.Size = New System.Drawing.Size(140, 22)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucrColor As ucrColors
    Friend WithEvents ucrInputCboParamValue As ucrInputComboBox
    Friend WithEvents ucrInputTextValue As ucrInputTextBox
    Friend WithEvents ucrNudParamValue As ucrNud
End Class
