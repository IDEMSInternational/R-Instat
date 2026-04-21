<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgTransformTricotData
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmdCheckTricotData = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblData = New System.Windows.Forms.Label()
        Me.ucrInputTricotData = New instat.ucrInputTextBox()
        Me.ucrSelectorTricotData = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverTricotData = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'cmdCheckTricotData
        '
        Me.cmdCheckTricotData.Location = New System.Drawing.Point(10, 270)
        Me.cmdCheckTricotData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdCheckTricotData.Name = "cmdCheckTricotData"
        Me.cmdCheckTricotData.Size = New System.Drawing.Size(152, 35)
        Me.cmdCheckTricotData.TabIndex = 3
        Me.cmdCheckTricotData.Text = "Check"
        Me.cmdCheckTricotData.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(460, 320)
        Me.cmdOptions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(152, 35)
        Me.cmdOptions.TabIndex = 5
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(392, 69)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(98, 20)
        Me.lblData.TabIndex = 1
        Me.lblData.Text = "Data Frame:"
        '
        'ucrInputTricotData
        '
        Me.ucrInputTricotData.AddQuotesIfUnrecognised = True
        Me.ucrInputTricotData.AutoSize = True
        Me.ucrInputTricotData.IsMultiline = True
        Me.ucrInputTricotData.IsReadOnly = True
        Me.ucrInputTricotData.Location = New System.Drawing.Point(166, 273)
        Me.ucrInputTricotData.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputTricotData.Name = "ucrInputTricotData"
        Me.ucrInputTricotData.Size = New System.Drawing.Size(446, 32)
        Me.ucrInputTricotData.TabIndex = 4
        '
        'ucrSelectorTricotData
        '
        Me.ucrSelectorTricotData.AutoSize = True
        Me.ucrSelectorTricotData.bShowHiddenColumns = False
        Me.ucrSelectorTricotData.Location = New System.Drawing.Point(10, 49)
        Me.ucrSelectorTricotData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTricotData.Name = "ucrSelectorTricotData"
        Me.ucrSelectorTricotData.Size = New System.Drawing.Size(327, 199)
        Me.ucrSelectorTricotData.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 369)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 6
        '
        'ucrReceiverTricotData
        '
        Me.ucrReceiverTricotData.AutoSize = True
        Me.ucrReceiverTricotData.frmParent = Me
        Me.ucrReceiverTricotData.Location = New System.Drawing.Point(392, 92)
        Me.ucrReceiverTricotData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTricotData.Name = "ucrReceiverTricotData"
        Me.ucrReceiverTricotData.Selector = Nothing
        Me.ucrReceiverTricotData.Size = New System.Drawing.Size(184, 154)
        Me.ucrReceiverTricotData.strNcFilePath = ""
        Me.ucrReceiverTricotData.TabIndex = 2
        Me.ucrReceiverTricotData.ucrSelector = Nothing
        '
        'dlgTransformTricotData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 459)
        Me.Controls.Add(Me.ucrInputTricotData)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.ucrSelectorTricotData)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.cmdCheckTricotData)
        Me.Controls.Add(Me.ucrReceiverTricotData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimizeBox = False
        Me.Name = "dlgTransformTricotData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transform Tricot Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Friend WithEvents ucrReceiverTricotData As ucrReceiverMultiple
    Friend WithEvents cmdCheckTricotData As Button
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrSelectorTricotData As ucrSelectorAddRemove
    Friend WithEvents lblData As Label
    Friend WithEvents ucrInputTricotData As ucrInputTextBox
End Class
