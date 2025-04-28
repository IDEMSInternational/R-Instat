<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTransformTricotData
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ucrReceiverTricotData = New instat.ucrReceiverMultiple()
        Me.cmdCheckTricotData = New System.Windows.Forms.Button()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputTricotData = New instat.ucrInputTextBox()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrSelectorTricotData = New instat.ucrSelectorAddRemove()
        Me.SuspendLayout()
        '
        'ucrReceiverTricotData
        '
        Me.ucrReceiverTricotData.AutoSize = True
        Me.ucrReceiverTricotData.frmParent = Me
        Me.ucrReceiverTricotData.Location = New System.Drawing.Point(292, 52)
        Me.ucrReceiverTricotData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTricotData.Name = "ucrReceiverTricotData"
        Me.ucrReceiverTricotData.Selector = Nothing
        Me.ucrReceiverTricotData.Size = New System.Drawing.Size(123, 110)
        Me.ucrReceiverTricotData.strNcFilePath = ""
        Me.ucrReceiverTricotData.TabIndex = 6
        Me.ucrReceiverTricotData.ucrSelector = Nothing
        '
        'cmdCheckTricotData
        '
        Me.cmdCheckTricotData.Location = New System.Drawing.Point(7, 252)
        Me.cmdCheckTricotData.Name = "cmdCheckTricotData"
        Me.cmdCheckTricotData.Size = New System.Drawing.Size(101, 23)
        Me.cmdCheckTricotData.TabIndex = 7
        Me.cmdCheckTricotData.Text = "Check:"
        Me.cmdCheckTricotData.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(7, 310)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 8
        '
        'ucrInputTricotData
        '
        Me.ucrInputTricotData.AddQuotesIfUnrecognised = True
        Me.ucrInputTricotData.AutoSize = True
        Me.ucrInputTricotData.IsMultiline = False
        Me.ucrInputTricotData.IsReadOnly = True
        Me.ucrInputTricotData.Location = New System.Drawing.Point(116, 254)
        Me.ucrInputTricotData.Name = "ucrInputTricotData"
        Me.ucrInputTricotData.Size = New System.Drawing.Size(183, 21)
        Me.ucrInputTricotData.TabIndex = 9
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(314, 252)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(101, 23)
        Me.cmdOptions.TabIndex = 10
        Me.cmdOptions.Text = "Options:"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrSelectorTricotData
        '
        Me.ucrSelectorTricotData.AutoSize = True
        Me.ucrSelectorTricotData.bShowHiddenColumns = False
        Me.ucrSelectorTricotData.Location = New System.Drawing.Point(18, 52)
        Me.ucrSelectorTricotData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTricotData.Name = "ucrSelectorTricotData"
        Me.ucrSelectorTricotData.Size = New System.Drawing.Size(218, 147)
        Me.ucrSelectorTricotData.TabIndex = 11
        '
        'dlgTransformTricotData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 385)
        Me.Controls.Add(Me.ucrSelectorTricotData)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrInputTricotData)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.cmdCheckTricotData)
        Me.Controls.Add(Me.ucrReceiverTricotData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
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
    Friend WithEvents ucrInputTricotData As ucrInputTextBox
    Friend WithEvents ucrSelectorTricotData As ucrSelectorAddRemove
End Class
