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
        Me.ucrCboParamValue = New instat.ucrInputComboBox()
        Me.UcrColor = New instat.ucrColors()
        CType(Me.nudParamValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudParamValue
        '
        Me.nudParamValue.Location = New System.Drawing.Point(94, 2)
        Me.nudParamValue.Name = "nudParamValue"
        Me.nudParamValue.Size = New System.Drawing.Size(45, 20)
        Me.nudParamValue.TabIndex = 8
        '
        'ucrCboParamValue
        '
        Me.ucrCboParamValue.IsReadOnly = False
        Me.ucrCboParamValue.Location = New System.Drawing.Point(0, 1)
        Me.ucrCboParamValue.Name = "ucrCboParamValue"
        Me.ucrCboParamValue.Size = New System.Drawing.Size(139, 21)
        Me.ucrCboParamValue.TabIndex = 10
        '
        'UcrColor
        '
        Me.UcrColor.IsReadOnly = False
        Me.UcrColor.Location = New System.Drawing.Point(2, 2)
        Me.UcrColor.Name = "UcrColor"
        Me.UcrColor.Size = New System.Drawing.Size(137, 21)
        Me.UcrColor.TabIndex = 9
        '
        'ucrReceiverMetadataProperty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrCboParamValue)
        Me.Controls.Add(Me.UcrColor)
        Me.Controls.Add(Me.nudParamValue)
        Me.Name = "ucrReceiverMetadataProperty"
        Me.Size = New System.Drawing.Size(137, 23)
        CType(Me.nudParamValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents nudParamValue As NumericUpDown
    Friend WithEvents UcrColor As ucrColors
    Friend WithEvents ucrCboParamValue As ucrInputComboBox
End Class
