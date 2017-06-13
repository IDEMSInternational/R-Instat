<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAddLink
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
        Me.cmdSpecifyLink = New System.Windows.Forms.Button()
        Me.lblLinkName = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblKeys = New System.Windows.Forms.Label()
        Me.lvwLinkViewBox = New System.Windows.Forms.ListView()
        Me.ucrInputLinkName = New instat.ucrInputTextBox()
        Me.ucrDataSelectorTo = New instat.ucrDataFrame()
        Me.ucrDataSelectorFrom = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblSelectedKey = New System.Windows.Forms.Label()
        Me.ucrInputSelectedKey = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'cmdSpecifyLink
        '
        Me.cmdSpecifyLink.Location = New System.Drawing.Point(287, 171)
        Me.cmdSpecifyLink.Name = "cmdSpecifyLink"
        Me.cmdSpecifyLink.Size = New System.Drawing.Size(121, 23)
        Me.cmdSpecifyLink.TabIndex = 6
        Me.cmdSpecifyLink.Text = "Specify Link"
        Me.cmdSpecifyLink.UseVisualStyleBackColor = True
        '
        'lblLinkName
        '
        Me.lblLinkName.AutoSize = True
        Me.lblLinkName.Location = New System.Drawing.Point(10, 239)
        Me.lblLinkName.Name = "lblLinkName"
        Me.lblLinkName.Size = New System.Drawing.Size(61, 13)
        Me.lblLinkName.TabIndex = 9
        Me.lblLinkName.Text = "Link Name:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(10, 10)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(10, 76)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 2
        Me.lblTo.Text = "To:"
        '
        'lblKeys
        '
        Me.lblKeys.AutoSize = True
        Me.lblKeys.Location = New System.Drawing.Point(168, 30)
        Me.lblKeys.Name = "lblKeys"
        Me.lblKeys.Size = New System.Drawing.Size(33, 13)
        Me.lblKeys.TabIndex = 4
        Me.lblKeys.Text = "Keys:"
        '
        'lvwLinkViewBox
        '
        Me.lvwLinkViewBox.FullRowSelect = True
        Me.lvwLinkViewBox.Location = New System.Drawing.Point(168, 45)
        Me.lvwLinkViewBox.Name = "lvwLinkViewBox"
        Me.lvwLinkViewBox.Size = New System.Drawing.Size(240, 123)
        Me.lvwLinkViewBox.TabIndex = 5
        Me.lvwLinkViewBox.UseCompatibleStateImageBehavior = False
        Me.lvwLinkViewBox.View = System.Windows.Forms.View.Details
        '
        'ucrInputLinkName
        '
        Me.ucrInputLinkName.AddQuotesIfUnrecognised = True
        Me.ucrInputLinkName.IsMultiline = False
        Me.ucrInputLinkName.IsReadOnly = False
        Me.ucrInputLinkName.Location = New System.Drawing.Point(92, 235)
        Me.ucrInputLinkName.Name = "ucrInputLinkName"
        Me.ucrInputLinkName.Size = New System.Drawing.Size(316, 21)
        Me.ucrInputLinkName.TabIndex = 10
        '
        'ucrDataSelectorTo
        '
        Me.ucrDataSelectorTo.bUseCurrentFilter = True
        Me.ucrDataSelectorTo.Location = New System.Drawing.Point(15, 92)
        Me.ucrDataSelectorTo.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataSelectorTo.Name = "ucrDataSelectorTo"
        Me.ucrDataSelectorTo.Size = New System.Drawing.Size(120, 50)
        Me.ucrDataSelectorTo.TabIndex = 3
        '
        'ucrDataSelectorFrom
        '
        Me.ucrDataSelectorFrom.bUseCurrentFilter = True
        Me.ucrDataSelectorFrom.Location = New System.Drawing.Point(15, 26)
        Me.ucrDataSelectorFrom.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataSelectorFrom.Name = "ucrDataSelectorFrom"
        Me.ucrDataSelectorFrom.Size = New System.Drawing.Size(120, 50)
        Me.ucrDataSelectorFrom.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 262)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 11
        '
        'lblSelectedKey
        '
        Me.lblSelectedKey.AutoSize = True
        Me.lblSelectedKey.Location = New System.Drawing.Point(10, 211)
        Me.lblSelectedKey.Name = "lblSelectedKey"
        Me.lblSelectedKey.Size = New System.Drawing.Size(73, 13)
        Me.lblSelectedKey.TabIndex = 7
        Me.lblSelectedKey.Text = "Selected Key:"
        '
        'ucrInputSelectedKey
        '
        Me.ucrInputSelectedKey.AddQuotesIfUnrecognised = True
        Me.ucrInputSelectedKey.IsMultiline = False
        Me.ucrInputSelectedKey.IsReadOnly = True
        Me.ucrInputSelectedKey.Location = New System.Drawing.Point(92, 208)
        Me.ucrInputSelectedKey.Name = "ucrInputSelectedKey"
        Me.ucrInputSelectedKey.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSelectedKey.TabIndex = 8
        '
        'dlgAddLink
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 320)
        Me.Controls.Add(Me.ucrInputSelectedKey)
        Me.Controls.Add(Me.lblSelectedKey)
        Me.Controls.Add(Me.lblKeys)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.lvwLinkViewBox)
        Me.Controls.Add(Me.lblLinkName)
        Me.Controls.Add(Me.ucrInputLinkName)
        Me.Controls.Add(Me.cmdSpecifyLink)
        Me.Controls.Add(Me.ucrDataSelectorTo)
        Me.Controls.Add(Me.ucrDataSelectorFrom)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAddLink"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Link"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataSelectorFrom As ucrDataFrame
    Friend WithEvents ucrDataSelectorTo As ucrDataFrame
    Friend WithEvents cmdSpecifyLink As Button
    Friend WithEvents ucrInputLinkName As ucrInputTextBox
    Friend WithEvents lblLinkName As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents lblKeys As Label
    Friend WithEvents lvwLinkViewBox As ListView
    Friend WithEvents lblSelectedKey As Label
    Friend WithEvents ucrInputSelectedKey As ucrInputTextBox
End Class
