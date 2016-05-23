<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgDataOptions
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
        Me.ucrSubDialogueBase = New instat.ucrButtonsSubdialogue()
        Me.tbcDataOptions = New System.Windows.Forms.TabControl()
        Me.tbFilter = New System.Windows.Forms.TabPage()
        Me.tbColumns = New System.Windows.Forms.TabPage()
        Me.chkShowHiddenColumns = New System.Windows.Forms.CheckBox()
        Me.tbcDataOptions.SuspendLayout()
        Me.tbColumns.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSubDialogueBase
        '
        Me.ucrSubDialogueBase.Location = New System.Drawing.Point(60, 227)
        Me.ucrSubDialogueBase.Name = "ucrSubDialogueBase"
        Me.ucrSubDialogueBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrSubDialogueBase.TabIndex = 0
        '
        'tbcDataOptions
        '
        Me.tbcDataOptions.Controls.Add(Me.tbFilter)
        Me.tbcDataOptions.Controls.Add(Me.tbColumns)
        Me.tbcDataOptions.Location = New System.Drawing.Point(0, 0)
        Me.tbcDataOptions.Name = "tbcDataOptions"
        Me.tbcDataOptions.SelectedIndex = 0
        Me.tbcDataOptions.Size = New System.Drawing.Size(273, 221)
        Me.tbcDataOptions.TabIndex = 1
        '
        'tbFilter
        '
        Me.tbFilter.Location = New System.Drawing.Point(4, 22)
        Me.tbFilter.Name = "tbFilter"
        Me.tbFilter.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFilter.Size = New System.Drawing.Size(265, 195)
        Me.tbFilter.TabIndex = 0
        Me.tbFilter.Tag = "Filter"
        Me.tbFilter.Text = "Filter"
        Me.tbFilter.UseVisualStyleBackColor = True
        '
        'tbColumns
        '
        Me.tbColumns.Controls.Add(Me.chkShowHiddenColumns)
        Me.tbColumns.Location = New System.Drawing.Point(4, 22)
        Me.tbColumns.Name = "tbColumns"
        Me.tbColumns.Padding = New System.Windows.Forms.Padding(3)
        Me.tbColumns.Size = New System.Drawing.Size(265, 195)
        Me.tbColumns.TabIndex = 1
        Me.tbColumns.Tag = "Columns"
        Me.tbColumns.Text = "Columns"
        Me.tbColumns.UseVisualStyleBackColor = True
        '
        'chkShowHiddenColumns
        '
        Me.chkShowHiddenColumns.AutoSize = True
        Me.chkShowHiddenColumns.Location = New System.Drawing.Point(6, 39)
        Me.chkShowHiddenColumns.Name = "chkShowHiddenColumns"
        Me.chkShowHiddenColumns.Size = New System.Drawing.Size(186, 17)
        Me.chkShowHiddenColumns.TabIndex = 0
        Me.chkShowHiddenColumns.Tag = "Show_Hidden_Columns_in_Selector"
        Me.chkShowHiddenColumns.Text = "Show Hidden Columns in Selector"
        Me.chkShowHiddenColumns.UseVisualStyleBackColor = True
        '
        'sdgDataOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 261)
        Me.Controls.Add(Me.tbcDataOptions)
        Me.Controls.Add(Me.ucrSubDialogueBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgDataOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Data_Options"
        Me.Text = "Data Options"
        Me.TopMost = True
        Me.tbcDataOptions.ResumeLayout(False)
        Me.tbColumns.ResumeLayout(False)
        Me.tbColumns.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSubDialogueBase As ucrButtonsSubdialogue
    Friend WithEvents tbcDataOptions As TabControl
    Friend WithEvents tbFilter As TabPage
    Friend WithEvents tbColumns As TabPage
    Friend WithEvents chkShowHiddenColumns As CheckBox
End Class
