<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPackageIssues
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPackageIssues))
        Me.lblPacksNotInstalled = New System.Windows.Forms.Label()
        Me.lblPossibleSolutions = New System.Windows.Forms.Label()
        Me.cmdInstallPackages = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.ucrInputPackageNames = New instat.ucrInputTextBox()
        Me.cmdCloseRInstat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPacksNotInstalled
        '
        Me.lblPacksNotInstalled.AutoSize = True
        Me.lblPacksNotInstalled.Location = New System.Drawing.Point(12, 15)
        Me.lblPacksNotInstalled.Name = "lblPacksNotInstalled"
        Me.lblPacksNotInstalled.Size = New System.Drawing.Size(237, 13)
        Me.lblPacksNotInstalled.TabIndex = 0
        Me.lblPacksNotInstalled.Text = "The following R packages could not be installed:"
        '
        'lblPossibleSolutions
        '
        Me.lblPossibleSolutions.Location = New System.Drawing.Point(12, 123)
        Me.lblPossibleSolutions.Name = "lblPossibleSolutions"
        Me.lblPossibleSolutions.Size = New System.Drawing.Size(425, 253)
        Me.lblPossibleSolutions.TabIndex = 2
        Me.lblPossibleSolutions.Text = resources.GetString("lblPossibleSolutions.Text")
        '
        'cmdInstallPackages
        '
        Me.cmdInstallPackages.Location = New System.Drawing.Point(15, 377)
        Me.cmdInstallPackages.Name = "cmdInstallPackages"
        Me.cmdInstallPackages.Size = New System.Drawing.Size(172, 23)
        Me.cmdInstallPackages.TabIndex = 3
        Me.cmdInstallPackages.Text = "Install Missing Packages (Online)"
        Me.cmdInstallPackages.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(181, 406)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(80, 23)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'ucrInputPackageNames
        '
        Me.ucrInputPackageNames.AddQuotesIfUnrecognised = True
        Me.ucrInputPackageNames.AutoSize = True
        Me.ucrInputPackageNames.IsMultiline = False
        Me.ucrInputPackageNames.IsReadOnly = False
        Me.ucrInputPackageNames.Location = New System.Drawing.Point(15, 42)
        Me.ucrInputPackageNames.Name = "ucrInputPackageNames"
        Me.ucrInputPackageNames.Size = New System.Drawing.Size(376, 63)
        Me.ucrInputPackageNames.TabIndex = 1
        '
        'cmdCloseRInstat
        '
        Me.cmdCloseRInstat.Location = New System.Drawing.Point(15, 156)
        Me.cmdCloseRInstat.Name = "cmdCloseRInstat"
        Me.cmdCloseRInstat.Size = New System.Drawing.Size(120, 23)
        Me.cmdCloseRInstat.TabIndex = 5
        Me.cmdCloseRInstat.Text = "Close R-Instat now"
        Me.cmdCloseRInstat.UseVisualStyleBackColor = True
        '
        'frmPackageIssues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(443, 437)
        Me.Controls.Add(Me.cmdCloseRInstat)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdInstallPackages)
        Me.Controls.Add(Me.lblPossibleSolutions)
        Me.Controls.Add(Me.ucrInputPackageNames)
        Me.Controls.Add(Me.lblPacksNotInstalled)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPackageIssues"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "R Package Issues"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPacksNotInstalled As Label
    Friend WithEvents ucrInputPackageNames As ucrInputTextBox
    Friend WithEvents lblPossibleSolutions As Label
    Friend WithEvents cmdInstallPackages As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdCloseRInstat As Button
End Class
