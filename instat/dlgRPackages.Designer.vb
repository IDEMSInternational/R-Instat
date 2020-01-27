<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRPackages
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRPackages))
        Me.lblRPackage = New System.Windows.Forms.Label()
        Me.cmdTry = New System.Windows.Forms.Button()
        Me.UcrInputComboBox1 = New instat.ucrInputComboBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputTextBoxRPackage = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'lblRPackage
        '
        resources.ApplyResources(Me.lblRPackage, "lblRPackage")
        Me.lblRPackage.Name = "lblRPackage"
        '
        'cmdTry
        '
        resources.ApplyResources(Me.cmdTry, "cmdTry")
        Me.cmdTry.Name = "cmdTry"
        Me.cmdTry.UseVisualStyleBackColor = True
        '
        'UcrInputComboBox1
        '
        Me.UcrInputComboBox1.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox1.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputComboBox1, "UcrInputComboBox1")
        Me.UcrInputComboBox1.Name = "UcrInputComboBox1"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrInputTextBoxRPackage
        '
        Me.ucrInputTextBoxRPackage.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBoxRPackage.IsMultiline = False
        Me.ucrInputTextBoxRPackage.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTextBoxRPackage, "ucrInputTextBoxRPackage")
        Me.ucrInputTextBoxRPackage.Name = "ucrInputTextBoxRPackage"
        '
        'dlgRPackages
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UcrInputComboBox1)
        Me.Controls.Add(Me.cmdTry)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblRPackage)
        Me.Controls.Add(Me.ucrInputTextBoxRPackage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRPackages"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRPackage As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdTry As Button
    Friend WithEvents UcrInputComboBox1 As ucrInputComboBox
    Friend WithEvents ucrInputTextBoxRPackage As ucrInputTextBox
End Class
