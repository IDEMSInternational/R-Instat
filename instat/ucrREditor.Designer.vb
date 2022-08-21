<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrREditor
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
        Me.tlpTableContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.lblHeaderScript = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdRunAll = New System.Windows.Forms.Button()
        Me.cmdRunLineSelection = New System.Windows.Forms.Button()
        Me.PanelScintillaNet = New System.Windows.Forms.Panel()
        Me.tlpTableContainer.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpTableContainer
        '
        Me.tlpTableContainer.ColumnCount = 1
        Me.tlpTableContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.Controls.Add(Me.lblHeaderScript, 0, 0)
        Me.tlpTableContainer.Controls.Add(Me.Panel1, 0, 3)
        Me.tlpTableContainer.Controls.Add(Me.Panel2, 0, 1)
        Me.tlpTableContainer.Controls.Add(Me.PanelScintillaNet, 0, 2)
        Me.tlpTableContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTableContainer.Location = New System.Drawing.Point(0, 0)
        Me.tlpTableContainer.Name = "tlpTableContainer"
        Me.tlpTableContainer.RowCount = 4
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpTableContainer.Size = New System.Drawing.Size(414, 311)
        Me.tlpTableContainer.TabIndex = 10
        '
        'lblHeaderScript
        '
        Me.lblHeaderScript.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.lblHeaderScript.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeaderScript.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblHeaderScript.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHeaderScript.Location = New System.Drawing.Point(3, 0)
        Me.lblHeaderScript.Name = "lblHeaderScript"
        Me.lblHeaderScript.Size = New System.Drawing.Size(408, 20)
        Me.lblHeaderScript.TabIndex = 8
        Me.lblHeaderScript.Text = "R Editor Window"
        Me.lblHeaderScript.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(3, 294)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 14)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmdHelp)
        Me.Panel2.Controls.Add(Me.cmdClear)
        Me.Panel2.Controls.Add(Me.cmdRunAll)
        Me.Panel2.Controls.Add(Me.cmdRunLineSelection)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(408, 27)
        Me.Panel2.TabIndex = 10
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(165, 1)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(51, 23)
        Me.cmdHelp.TabIndex = 5
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(110, 1)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(51, 23)
        Me.cmdClear.TabIndex = 4
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdRunAll
        '
        Me.cmdRunAll.Location = New System.Drawing.Point(56, 1)
        Me.cmdRunAll.Name = "cmdRunAll"
        Me.cmdRunAll.Size = New System.Drawing.Size(51, 23)
        Me.cmdRunAll.TabIndex = 3
        Me.cmdRunAll.Text = "Run All"
        Me.cmdRunAll.UseVisualStyleBackColor = True
        '
        'cmdRunLineSelection
        '
        Me.cmdRunLineSelection.Location = New System.Drawing.Point(2, 1)
        Me.cmdRunLineSelection.Name = "cmdRunLineSelection"
        Me.cmdRunLineSelection.Size = New System.Drawing.Size(51, 23)
        Me.cmdRunLineSelection.TabIndex = 2
        Me.cmdRunLineSelection.Text = "Run"
        Me.cmdRunLineSelection.UseVisualStyleBackColor = True
        '
        'PanelScintillaNet
        '
        Me.PanelScintillaNet.Location = New System.Drawing.Point(3, 56)
        Me.PanelScintillaNet.Name = "PanelScintillaNet"
        Me.PanelScintillaNet.Size = New System.Drawing.Size(408, 232)
        Me.PanelScintillaNet.TabIndex = 11
        '
        'ucrREditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpTableContainer)
        Me.Name = "ucrREditor"
        Me.Size = New System.Drawing.Size(414, 311)
        Me.tlpTableContainer.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpTableContainer As TableLayoutPanel
    Friend WithEvents lblHeaderScript As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmdHelp As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdRunAll As Button
    Friend WithEvents cmdRunLineSelection As Button
    Friend WithEvents PanelScintillaNet As Panel
End Class
