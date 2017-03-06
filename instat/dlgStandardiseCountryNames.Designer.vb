<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgStandardiseCountryNames
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
        Me.lblCountryNames = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverCountryNames = New instat.ucrReceiverMultiple()
        Me.ucrSelectorStandardiseCountry = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblCountryNames
        '
        Me.lblCountryNames.AutoSize = True
        Me.lblCountryNames.Location = New System.Drawing.Point(267, 43)
        Me.lblCountryNames.Name = "lblCountryNames"
        Me.lblCountryNames.Size = New System.Drawing.Size(82, 13)
        Me.lblCountryNames.TabIndex = 1
        Me.lblCountryNames.Text = "Country Names:"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 220)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 3
        '
        'ucrReceiverCountryNames
        '
        Me.ucrReceiverCountryNames.frmParent = Me
        Me.ucrReceiverCountryNames.Location = New System.Drawing.Point(270, 60)
        Me.ucrReceiverCountryNames.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCountryNames.Name = "ucrReceiverCountryNames"
        Me.ucrReceiverCountryNames.Selector = Nothing
        Me.ucrReceiverCountryNames.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverCountryNames.TabIndex = 2
        '
        'ucrSelectorStandardiseCountry
        '
        Me.ucrSelectorStandardiseCountry.bShowHiddenColumns = False
        Me.ucrSelectorStandardiseCountry.bUseCurrentFilter = True
        Me.ucrSelectorStandardiseCountry.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorStandardiseCountry.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStandardiseCountry.Name = "ucrSelectorStandardiseCountry"
        Me.ucrSelectorStandardiseCountry.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorStandardiseCountry.TabIndex = 0
        '
        'dlgStandardiseCountryNames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 283)
        Me.Controls.Add(Me.lblCountryNames)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverCountryNames)
        Me.Controls.Add(Me.ucrSelectorStandardiseCountry)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStandardiseCountryNames"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Standardise Country Names"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCountryNames As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverCountryNames As ucrReceiverMultiple
    Friend WithEvents ucrSelectorStandardiseCountry As ucrSelectorByDataFrameAddRemove
End Class
