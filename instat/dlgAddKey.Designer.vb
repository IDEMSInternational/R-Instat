' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgAddKey
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.cmdCheckUnique = New System.Windows.Forms.Button()
        Me.lblKeyColumns = New System.Windows.Forms.Label()
        Me.ucrSaveKey = New instat.ucrSave()
        Me.ucrInputCheckInput = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorKeyColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverKeyColumns = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'cmdCheckUnique
        '
        Me.cmdCheckUnique.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCheckUnique.Location = New System.Drawing.Point(10, 230)
        Me.cmdCheckUnique.Name = "cmdCheckUnique"
        Me.cmdCheckUnique.Size = New System.Drawing.Size(98, 23)
        Me.cmdCheckUnique.TabIndex = 5
        Me.cmdCheckUnique.Text = "Check Unique"
        Me.cmdCheckUnique.UseVisualStyleBackColor = True
        '
        'lblKeyColumns
        '
        Me.lblKeyColumns.AutoSize = True
        Me.lblKeyColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblKeyColumns.Location = New System.Drawing.Point(254, 45)
        Me.lblKeyColumns.Name = "lblKeyColumns"
        Me.lblKeyColumns.Size = New System.Drawing.Size(71, 13)
        Me.lblKeyColumns.TabIndex = 1
        Me.lblKeyColumns.Text = "Key Columns:"
        '
        'ucrSaveKey
        '
        Me.ucrSaveKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveKey.Location = New System.Drawing.Point(5, 197)
        Me.ucrSaveKey.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveKey.Name = "ucrSaveKey"
        Me.ucrSaveKey.Size = New System.Drawing.Size(306, 27)
        Me.ucrSaveKey.TabIndex = 8
        '
        'ucrInputCheckInput
        '
        Me.ucrInputCheckInput.AddQuotesIfUnrecognised = True
        Me.ucrInputCheckInput.AutoSize = True
        Me.ucrInputCheckInput.IsMultiline = False
        Me.ucrInputCheckInput.IsReadOnly = False
        Me.ucrInputCheckInput.Location = New System.Drawing.Point(114, 232)
        Me.ucrInputCheckInput.Name = "ucrInputCheckInput"
        Me.ucrInputCheckInput.Size = New System.Drawing.Size(294, 21)
        Me.ucrInputCheckInput.TabIndex = 6
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 261)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 7
        '
        'ucrSelectorKeyColumns
        '
        Me.ucrSelectorKeyColumns.AutoSize = True
        Me.ucrSelectorKeyColumns.bDropUnusedFilterLevels = False
        Me.ucrSelectorKeyColumns.bShowHiddenColumns = False
        Me.ucrSelectorKeyColumns.bUseCurrentFilter = True
        Me.ucrSelectorKeyColumns.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorKeyColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorKeyColumns.Name = "ucrSelectorKeyColumns"
        Me.ucrSelectorKeyColumns.Size = New System.Drawing.Size(241, 183)
        Me.ucrSelectorKeyColumns.TabIndex = 0
        '
        'ucrReceiverKeyColumns
        '
        Me.ucrReceiverKeyColumns.AutoSize = True
        Me.ucrReceiverKeyColumns.frmParent = Me
        Me.ucrReceiverKeyColumns.Location = New System.Drawing.Point(254, 60)
        Me.ucrReceiverKeyColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverKeyColumns.Name = "ucrReceiverKeyColumns"
        Me.ucrReceiverKeyColumns.Selector = Nothing
        Me.ucrReceiverKeyColumns.Size = New System.Drawing.Size(129, 130)
        Me.ucrReceiverKeyColumns.strNcFilePath = ""
        Me.ucrReceiverKeyColumns.TabIndex = 2
        Me.ucrReceiverKeyColumns.ucrSelector = Nothing
        '
        'dlgAddKey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(418, 321)
        Me.Controls.Add(Me.ucrSaveKey)
        Me.Controls.Add(Me.lblKeyColumns)
        Me.Controls.Add(Me.ucrInputCheckInput)
        Me.Controls.Add(Me.cmdCheckUnique)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorKeyColumns)
        Me.Controls.Add(Me.ucrReceiverKeyColumns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAddKey"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Key"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverKeyColumns As instat.ucrReceiverMultiple
    Friend WithEvents ucrSelectorKeyColumns As instat.ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As instat.ucrButtons
    Friend WithEvents cmdCheckUnique As System.Windows.Forms.Button
    Friend WithEvents ucrInputCheckInput As instat.ucrInputTextBox
    Friend WithEvents lblKeyColumns As System.Windows.Forms.Label
    Friend WithEvents ucrSaveKey As ucrSave
End Class