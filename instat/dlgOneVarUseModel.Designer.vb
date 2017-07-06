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
Partial Class dlgOneVarUseModel
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
        Me.lblReceiverObject = New System.Windows.Forms.Label()
        Me.cmdFitModelandBootstrap = New System.Windows.Forms.Button()
        Me.ucrChkProduceBootstrap = New instat.ucrCheck()
        Me.ucrSaveObjects = New instat.ucrSave()
        Me.ucrNewDataFrameName = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverObject = New instat.ucrReceiverSingle()
        Me.ucrSelectorUseModel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblReceiverObject
        '
        Me.lblReceiverObject.AutoSize = True
        Me.lblReceiverObject.Location = New System.Drawing.Point(239, 45)
        Me.lblReceiverObject.Name = "lblReceiverObject"
        Me.lblReceiverObject.Size = New System.Drawing.Size(86, 13)
        Me.lblReceiverObject.TabIndex = 1
        Me.lblReceiverObject.Text = "Selected Object:"
        '
        'cmdFitModelandBootstrap
        '
        Me.cmdFitModelandBootstrap.Location = New System.Drawing.Point(333, 200)
        Me.cmdFitModelandBootstrap.Name = "cmdFitModelandBootstrap"
        Me.cmdFitModelandBootstrap.Size = New System.Drawing.Size(76, 23)
        Me.cmdFitModelandBootstrap.TabIndex = 7
        Me.cmdFitModelandBootstrap.Text = "Options"
        Me.cmdFitModelandBootstrap.UseVisualStyleBackColor = True
        '
        'ucrChkProduceBootstrap
        '
        Me.ucrChkProduceBootstrap.Checked = False
        Me.ucrChkProduceBootstrap.Location = New System.Drawing.Point(239, 88)
        Me.ucrChkProduceBootstrap.Name = "ucrChkProduceBootstrap"
        Me.ucrChkProduceBootstrap.Size = New System.Drawing.Size(172, 20)
        Me.ucrChkProduceBootstrap.TabIndex = 3
        '
        'ucrSaveObjects
        '
        Me.ucrSaveObjects.Location = New System.Drawing.Point(239, 114)
        Me.ucrSaveObjects.Name = "ucrSaveObjects"
        Me.ucrSaveObjects.Size = New System.Drawing.Size(189, 24)
        Me.ucrSaveObjects.TabIndex = 4
        '
        'ucrNewDataFrameName
        '
        Me.ucrNewDataFrameName.Location = New System.Drawing.Point(10, 200)
        Me.ucrNewDataFrameName.Name = "ucrNewDataFrameName"
        Me.ucrNewDataFrameName.Size = New System.Drawing.Size(265, 24)
        Me.ucrNewDataFrameName.TabIndex = 6
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 230)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 8
        '
        'ucrReceiverObject
        '
        Me.ucrReceiverObject.frmParent = Me
        Me.ucrReceiverObject.Location = New System.Drawing.Point(239, 60)
        Me.ucrReceiverObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverObject.Name = "ucrReceiverObject"
        Me.ucrReceiverObject.Selector = Nothing
        Me.ucrReceiverObject.Size = New System.Drawing.Size(138, 20)
        Me.ucrReceiverObject.strNcFilePath = ""
        Me.ucrReceiverObject.TabIndex = 2
        Me.ucrReceiverObject.ucrSelector = Nothing
        '
        'ucrSelectorUseModel
        '
        Me.ucrSelectorUseModel.bShowHiddenColumns = False
        Me.ucrSelectorUseModel.bUseCurrentFilter = True
        Me.ucrSelectorUseModel.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorUseModel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorUseModel.Name = "ucrSelectorUseModel"
        Me.ucrSelectorUseModel.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorUseModel.TabIndex = 0
        '
        'dlgOneVarUseModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 289)
        Me.Controls.Add(Me.ucrChkProduceBootstrap)
        Me.Controls.Add(Me.ucrSaveObjects)
        Me.Controls.Add(Me.ucrNewDataFrameName)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblReceiverObject)
        Me.Controls.Add(Me.ucrReceiverObject)
        Me.Controls.Add(Me.ucrSelectorUseModel)
        Me.Controls.Add(Me.cmdFitModelandBootstrap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneVarUseModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Variable Use Model"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblReceiverObject As Label
    Friend WithEvents ucrReceiverObject As ucrReceiverSingle
    Friend WithEvents ucrSelectorUseModel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdFitModelandBootstrap As Button
    Friend WithEvents ucrNewDataFrameName As ucrSave
    Friend WithEvents ucrSaveObjects As ucrSave
    Friend WithEvents ucrChkProduceBootstrap As ucrCheck
End Class
