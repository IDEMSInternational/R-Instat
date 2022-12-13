<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgApsimx
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
        Me.ucrChkSilent = New instat.ucrCheck()
        Me.lblExampleList = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputComboList = New instat.ucrInputComboBox()
        Me.lblSaveData = New System.Windows.Forms.Label()
        Me.ucrInputSaveData = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'ucrChkSilent
        '
        Me.ucrChkSilent.AutoSize = True
        Me.ucrChkSilent.Checked = False
        Me.ucrChkSilent.Location = New System.Drawing.Point(7, 43)
        Me.ucrChkSilent.Name = "ucrChkSilent"
        Me.ucrChkSilent.Size = New System.Drawing.Size(138, 23)
        Me.ucrChkSilent.TabIndex = 2
        '
        'lblExampleList
        '
        Me.lblExampleList.AutoSize = True
        Me.lblExampleList.Location = New System.Drawing.Point(7, 17)
        Me.lblExampleList.Name = "lblExampleList"
        Me.lblExampleList.Size = New System.Drawing.Size(69, 13)
        Me.lblExampleList.TabIndex = 0
        Me.lblExampleList.Text = "Example List:"
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(7, 105)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 5
        '
        'ucrInputComboList
        '
        Me.ucrInputComboList.AddQuotesIfUnrecognised = True
        Me.ucrInputComboList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboList.GetSetSelectedIndex = -1
        Me.ucrInputComboList.IsReadOnly = False
        Me.ucrInputComboList.Location = New System.Drawing.Point(135, 12)
        Me.ucrInputComboList.Name = "ucrInputComboList"
        Me.ucrInputComboList.Size = New System.Drawing.Size(219, 23)
        Me.ucrInputComboList.TabIndex = 1
        '
        'lblSaveData
        '
        Me.lblSaveData.AutoSize = True
        Me.lblSaveData.Location = New System.Drawing.Point(7, 79)
        Me.lblSaveData.Name = "lblSaveData"
        Me.lblSaveData.Size = New System.Drawing.Size(61, 13)
        Me.lblSaveData.TabIndex = 3
        Me.lblSaveData.Text = "Save Data:"
        '
        'ucrInputSaveData
        '
        Me.ucrInputSaveData.AddQuotesIfUnrecognised = True
        Me.ucrInputSaveData.AutoSize = True
        Me.ucrInputSaveData.IsMultiline = False
        Me.ucrInputSaveData.IsReadOnly = False
        Me.ucrInputSaveData.Location = New System.Drawing.Point(135, 75)
        Me.ucrInputSaveData.Name = "ucrInputSaveData"
        Me.ucrInputSaveData.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSaveData.TabIndex = 4
        '
        'dlgApsimx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 163)
        Me.Controls.Add(Me.ucrInputSaveData)
        Me.Controls.Add(Me.lblSaveData)
        Me.Controls.Add(Me.ucrInputComboList)
        Me.Controls.Add(Me.ucrChkSilent)
        Me.Controls.Add(Me.lblExampleList)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgApsimx"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Apsimx/Apsim Examples"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrChkSilent As ucrCheck
    Friend WithEvents lblExampleList As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInputComboList As ucrInputComboBox
    Friend WithEvents lblSaveData As Label
    Friend WithEvents ucrInputSaveData As ucrInputTextBox
End Class
