<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrDayOfYear
    Inherits instat.ucrCore

    'UserControl overrides dispose to clean up the component list.
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
        Me.ucrInputDay = New instat.ucrInputComboBox()
        Me.ucrInputMonth = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'ucrInputDay
        '
        Me.ucrInputDay.AddQuotesIfUnrecognised = True
        Me.ucrInputDay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDay.GetSetSelectedIndex = -1
        Me.ucrInputDay.IsReadOnly = False
        Me.ucrInputDay.Location = New System.Drawing.Point(99, 0)
        Me.ucrInputDay.Name = "ucrInputDay"
        Me.ucrInputDay.Size = New System.Drawing.Size(59, 21)
        Me.ucrInputDay.TabIndex = 0
        '
        'ucrInputMonth
        '
        Me.ucrInputMonth.AddQuotesIfUnrecognised = True
        Me.ucrInputMonth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMonth.GetSetSelectedIndex = -1
        Me.ucrInputMonth.IsReadOnly = False
        Me.ucrInputMonth.Location = New System.Drawing.Point(0, 0)
        Me.ucrInputMonth.Name = "ucrInputMonth"
        Me.ucrInputMonth.Size = New System.Drawing.Size(94, 21)
        Me.ucrInputMonth.TabIndex = 1
        '
        'ucrDayOfYear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.ucrInputMonth)
        Me.Controls.Add(Me.ucrInputDay)
        Me.Name = "ucrDayOfYear"
        Me.Size = New System.Drawing.Size(176, 24)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrInputDay As ucrInputComboBox
    Friend WithEvents ucrInputMonth As ucrInputComboBox
End Class
