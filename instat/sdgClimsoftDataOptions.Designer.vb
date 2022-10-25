<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgClimsoftDataOptions
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
        Me.ucrChkDataForm = New instat.ucrCheck()
        Me.ucrChkQc = New instat.ucrCheck()
        Me.ucrChkFlags = New instat.ucrCheck()
        Me.ucrBaseSdgClimSoft = New instat.ucrButtonsSubdialogue()
        Me.ucrCboQCFilter = New instat.ucrInputComboBox()
        Me.lbFilter = New System.Windows.Forms.Label()
        Me.ucrCboFormFilter = New instat.ucrInputComboBox()
        Me.lblFormFilter = New System.Windows.Forms.Label()
        Me.ucrChkQCFilter = New instat.ucrCheck()
        Me.ucrChkFormFilter = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'ucrChkDataForm
        '
        Me.ucrChkDataForm.AutoSize = True
        Me.ucrChkDataForm.Checked = False
        Me.ucrChkDataForm.Location = New System.Drawing.Point(20, 71)
        Me.ucrChkDataForm.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkDataForm.Name = "ucrChkDataForm"
        Me.ucrChkDataForm.Size = New System.Drawing.Size(188, 23)
        Me.ucrChkDataForm.TabIndex = 51
        '
        'ucrChkQc
        '
        Me.ucrChkQc.AutoSize = True
        Me.ucrChkQc.Checked = False
        Me.ucrChkQc.Location = New System.Drawing.Point(20, 46)
        Me.ucrChkQc.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkQc.Name = "ucrChkQc"
        Me.ucrChkQc.Size = New System.Drawing.Size(188, 23)
        Me.ucrChkQc.TabIndex = 50
        '
        'ucrChkFlags
        '
        Me.ucrChkFlags.AutoSize = True
        Me.ucrChkFlags.Checked = False
        Me.ucrChkFlags.Location = New System.Drawing.Point(20, 17)
        Me.ucrChkFlags.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkFlags.Name = "ucrChkFlags"
        Me.ucrChkFlags.Size = New System.Drawing.Size(188, 23)
        Me.ucrChkFlags.TabIndex = 49
        '
        'ucrBaseSdgClimSoft
        '
        Me.ucrBaseSdgClimSoft.AutoSize = True
        Me.ucrBaseSdgClimSoft.Location = New System.Drawing.Point(9, 204)
        Me.ucrBaseSdgClimSoft.Name = "ucrBaseSdgClimSoft"
        Me.ucrBaseSdgClimSoft.Size = New System.Drawing.Size(224, 30)
        Me.ucrBaseSdgClimSoft.TabIndex = 52
        '
        'ucrCboQCFilter
        '
        Me.ucrCboQCFilter.AddQuotesIfUnrecognised = True
        Me.ucrCboQCFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboQCFilter.GetSetSelectedIndex = -1
        Me.ucrCboQCFilter.IsReadOnly = False
        Me.ucrCboQCFilter.Location = New System.Drawing.Point(172, 103)
        Me.ucrCboQCFilter.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrCboQCFilter.Name = "ucrCboQCFilter"
        Me.ucrCboQCFilter.Size = New System.Drawing.Size(145, 21)
        Me.ucrCboQCFilter.TabIndex = 54
        '
        'lbFilter
        '
        Me.lbFilter.AutoSize = True
        Me.lbFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbFilter.Location = New System.Drawing.Point(18, 103)
        Me.lbFilter.Name = "lbFilter"
        Me.lbFilter.Size = New System.Drawing.Size(142, 13)
        Me.lbFilter.TabIndex = 53
        Me.lbFilter.Text = "Select Data with QC Status :"
        Me.lbFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucrCboFormFilter
        '
        Me.ucrCboFormFilter.AddQuotesIfUnrecognised = True
        Me.ucrCboFormFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboFormFilter.GetSetSelectedIndex = -1
        Me.ucrCboFormFilter.IsReadOnly = False
        Me.ucrCboFormFilter.Location = New System.Drawing.Point(172, 168)
        Me.ucrCboFormFilter.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrCboFormFilter.Name = "ucrCboFormFilter"
        Me.ucrCboFormFilter.Size = New System.Drawing.Size(145, 21)
        Me.ucrCboFormFilter.TabIndex = 56
        '
        'lblFormFilter
        '
        Me.lblFormFilter.AutoSize = True
        Me.lblFormFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFormFilter.Location = New System.Drawing.Point(18, 149)
        Me.lblFormFilter.Name = "lblFormFilter"
        Me.lblFormFilter.Size = New System.Drawing.Size(107, 13)
        Me.lblFormFilter.TabIndex = 55
        Me.lblFormFilter.Text = "Select Data of Form :"
        Me.lblFormFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucrChkQCFilter
        '
        Me.ucrChkQCFilter.AutoSize = True
        Me.ucrChkQCFilter.Checked = False
        Me.ucrChkQCFilter.Location = New System.Drawing.Point(200, 46)
        Me.ucrChkQCFilter.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkQCFilter.Name = "ucrChkQCFilter"
        Me.ucrChkQCFilter.Size = New System.Drawing.Size(188, 23)
        Me.ucrChkQCFilter.TabIndex = 57
        '
        'ucrChkFormFilter
        '
        Me.ucrChkFormFilter.AutoSize = True
        Me.ucrChkFormFilter.Checked = False
        Me.ucrChkFormFilter.Location = New System.Drawing.Point(186, 139)
        Me.ucrChkFormFilter.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkFormFilter.Name = "ucrChkFormFilter"
        Me.ucrChkFormFilter.Size = New System.Drawing.Size(188, 23)
        Me.ucrChkFormFilter.TabIndex = 58
        '
        'sdgClimsoftDataOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 245)
        Me.Controls.Add(Me.ucrChkFormFilter)
        Me.Controls.Add(Me.ucrChkQCFilter)
        Me.Controls.Add(Me.ucrCboFormFilter)
        Me.Controls.Add(Me.lblFormFilter)
        Me.Controls.Add(Me.ucrCboQCFilter)
        Me.Controls.Add(Me.lbFilter)
        Me.Controls.Add(Me.ucrBaseSdgClimSoft)
        Me.Controls.Add(Me.ucrChkDataForm)
        Me.Controls.Add(Me.ucrChkQc)
        Me.Controls.Add(Me.ucrChkFlags)
        Me.Name = "sdgClimsoftDataOptions"
        Me.Text = "Climsoft Data Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrChkDataForm As ucrCheck
    Friend WithEvents ucrChkQc As ucrCheck
    Friend WithEvents ucrChkFlags As ucrCheck
    Friend WithEvents ucrBaseSdgClimSoft As ucrButtonsSubdialogue
    Friend WithEvents ucrCboQCFilter As ucrInputComboBox
    Friend WithEvents lbFilter As Label
    Friend WithEvents ucrCboFormFilter As ucrInputComboBox
    Friend WithEvents lblFormFilter As Label
    Friend WithEvents ucrChkQCFilter As ucrCheck
    Friend WithEvents ucrChkFormFilter As ucrCheck
End Class
