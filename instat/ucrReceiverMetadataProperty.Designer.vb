<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrReceiverMetadataProperty
    Inherits System.Windows.Forms.UserControl

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
        Me.nudParamValue = New System.Windows.Forms.NumericUpDown()
        Me.ucrInputTextValue = New instat.ucrInputTextBox()
        Me.ucrCboParamValue = New instat.ucrInputComboBox()
        Me.ucrColor = New instat.ucrColors()
        CType(Me.nudParamValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudParamValue
        '
        Me.nudParamValue.Location = New System.Drawing.Point(0, 0)
        Me.nudParamValue.Name = "nudParamValue"
        Me.nudParamValue.Size = New System.Drawing.Size(45, 20)
        Me.nudParamValue.TabIndex = 8
        '
        'ucrInputTextValue
        '
        Me.ucrInputTextValue.IsReadOnly = False
        Me.ucrInputTextValue.Location = New System.Drawing.Point(0, 0)
        Me.ucrInputTextValue.Name = "ucrInputTextValue"
        Me.ucrInputTextValue.Size = New System.Drawing.Size(139, 20)
        Me.ucrInputTextValue.TabIndex = 11
        '
        'ucrCboParamValue
        '
        Me.ucrCboParamValue.IsReadOnly = False
        Me.ucrCboParamValue.Location = New System.Drawing.Point(0, 0)
        Me.ucrCboParamValue.Name = "ucrCboParamValue"
        Me.ucrCboParamValue.Size = New System.Drawing.Size(139, 20)
        Me.ucrCboParamValue.TabIndex = 10
        '
        'ucrColor
        '
        Me.ucrColor.IsReadOnly = False
        Me.ucrColor.Location = New System.Drawing.Point(0, 0)
        Me.ucrColor.Name = "ucrColor"
        Me.ucrColor.Size = New System.Drawing.Size(139, 20)
        Me.ucrColor.TabIndex = 9
        '
        'ucrReceiverMetadataProperty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputTextValue)
        Me.Controls.Add(Me.ucrCboParamValue)
        Me.Controls.Add(Me.ucrColor)
        Me.Controls.Add(Me.nudParamValue)
        Me.Name = "ucrReceiverMetadataProperty"
        Me.Size = New System.Drawing.Size(140, 22)
        CType(Me.nudParamValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents nudParamValue As NumericUpDown
    Friend WithEvents ucrColor As ucrColors
    Friend WithEvents ucrCboParamValue As ucrInputComboBox
    Friend WithEvents ucrInputTextValue As ucrInputTextBox
End Class
