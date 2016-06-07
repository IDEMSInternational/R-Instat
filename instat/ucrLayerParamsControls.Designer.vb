<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrLayerParamsControls
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
        Me.chkParamName = New System.Windows.Forms.CheckBox()
        Me.nudParamValue = New System.Windows.Forms.NumericUpDown()
        Me.ucrcborParamValue = New instat.ucrInputComboBox()
        Me.ucrColor = New instat.ucrColors()
        CType(Me.nudParamValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkParamName
        '
        Me.chkParamName.AutoSize = True
        Me.chkParamName.Location = New System.Drawing.Point(3, 6)
        Me.chkParamName.Name = "chkParamName"
        Me.chkParamName.Size = New System.Drawing.Size(15, 14)
        Me.chkParamName.TabIndex = 0
        Me.chkParamName.UseVisualStyleBackColor = True
        '
        'nudParamValue
        '
        Me.nudParamValue.Location = New System.Drawing.Point(145, 3)
        Me.nudParamValue.Name = "nudParamValue"
        Me.nudParamValue.Size = New System.Drawing.Size(53, 20)
        Me.nudParamValue.TabIndex = 1
        '
        'ucrcborParamValue
        '
        Me.ucrcborParamValue.Location = New System.Drawing.Point(145, 3)
        Me.ucrcborParamValue.Name = "ucrcborParamValue"
        Me.ucrcborParamValue.Size = New System.Drawing.Size(53, 21)
        Me.ucrcborParamValue.TabIndex = 2
        '
        'ucrColor
        '
        Me.ucrColor.Location = New System.Drawing.Point(133, 3)
        Me.ucrColor.Name = "ucrColor"
        Me.ucrColor.Size = New System.Drawing.Size(65, 21)
        Me.ucrColor.TabIndex = 3
        '
        'ucrLayerParamsControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrColor)
        Me.Controls.Add(Me.ucrcborParamValue)
        Me.Controls.Add(Me.nudParamValue)
        Me.Controls.Add(Me.chkParamName)
        Me.Name = "ucrLayerParamsControls"
        Me.Size = New System.Drawing.Size(203, 27)
        CType(Me.nudParamValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkParamName As CheckBox
    Friend WithEvents nudParamValue As NumericUpDown
    Friend WithEvents ucrcborParamValue As ucrInputComboBox
    Friend WithEvents ucrColor As ucrColors
End Class
