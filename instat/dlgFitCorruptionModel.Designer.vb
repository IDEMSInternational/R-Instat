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
Partial Class dlgFitCorruptionModel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgFitCorruptionModel))
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.lblControlVariables = New System.Windows.Forms.Label()
        Me.lblCorruptionOutput = New System.Windows.Forms.Label()
        Me.lblIndicators = New System.Windows.Forms.Label()
        Me.ucrSaveCorruptionModel = New instat.ucrSave()
        Me.ucrInputModelPreview = New instat.ucrInputTextBox()
        Me.ucrReceiverOutput = New instat.ucrReceiverSingle()
        Me.ucrReceiverIndicators = New instat.ucrReceiverMultiple()
        Me.ucrReceiverControlVariables = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorFitModel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'cmdDisplayOptions
        '
        resources.ApplyResources(Me.cmdDisplayOptions, "cmdDisplayOptions")
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'lblModelPreview
        '
        resources.ApplyResources(Me.lblModelPreview, "lblModelPreview")
        Me.lblModelPreview.Name = "lblModelPreview"
        '
        'lblControlVariables
        '
        resources.ApplyResources(Me.lblControlVariables, "lblControlVariables")
        Me.lblControlVariables.Name = "lblControlVariables"
        '
        'lblCorruptionOutput
        '
        resources.ApplyResources(Me.lblCorruptionOutput, "lblCorruptionOutput")
        Me.lblCorruptionOutput.Name = "lblCorruptionOutput"
        '
        'lblIndicators
        '
        resources.ApplyResources(Me.lblIndicators, "lblIndicators")
        Me.lblIndicators.Name = "lblIndicators"
        '
        'ucrSaveCorruptionModel
        '
        resources.ApplyResources(Me.ucrSaveCorruptionModel, "ucrSaveCorruptionModel")
        Me.ucrSaveCorruptionModel.Name = "ucrSaveCorruptionModel"
        '
        'ucrInputModelPreview
        '
        Me.ucrInputModelPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputModelPreview.IsMultiline = False
        Me.ucrInputModelPreview.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputModelPreview, "ucrInputModelPreview")
        Me.ucrInputModelPreview.Name = "ucrInputModelPreview"
        '
        'ucrReceiverOutput
        '
        Me.ucrReceiverOutput.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverOutput, "ucrReceiverOutput")
        Me.ucrReceiverOutput.Name = "ucrReceiverOutput"
        Me.ucrReceiverOutput.Selector = Nothing
        Me.ucrReceiverOutput.strNcFilePath = ""
        Me.ucrReceiverOutput.ucrSelector = Nothing
        '
        'ucrReceiverIndicators
        '
        Me.ucrReceiverIndicators.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverIndicators, "ucrReceiverIndicators")
        Me.ucrReceiverIndicators.Name = "ucrReceiverIndicators"
        Me.ucrReceiverIndicators.Selector = Nothing
        Me.ucrReceiverIndicators.strNcFilePath = ""
        Me.ucrReceiverIndicators.ucrSelector = Nothing
        '
        'ucrReceiverControlVariables
        '
        Me.ucrReceiverControlVariables.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverControlVariables, "ucrReceiverControlVariables")
        Me.ucrReceiverControlVariables.Name = "ucrReceiverControlVariables"
        Me.ucrReceiverControlVariables.Selector = Nothing
        Me.ucrReceiverControlVariables.strNcFilePath = ""
        Me.ucrReceiverControlVariables.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorFitModel
        '
        Me.ucrSelectorFitModel.bShowHiddenColumns = False
        Me.ucrSelectorFitModel.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorFitModel, "ucrSelectorFitModel")
        Me.ucrSelectorFitModel.Name = "ucrSelectorFitModel"
        '
        'dlgFitCorruptionModel
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblIndicators)
        Me.Controls.Add(Me.lblCorruptionOutput)
        Me.Controls.Add(Me.lblControlVariables)
        Me.Controls.Add(Me.ucrSaveCorruptionModel)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrInputModelPreview)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.ucrReceiverOutput)
        Me.Controls.Add(Me.ucrReceiverIndicators)
        Me.Controls.Add(Me.ucrReceiverControlVariables)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorFitModel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFitCorruptionModel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverControlVariables As ucrReceiverMultiple
    Friend WithEvents ucrReceiverOutput As ucrReceiverSingle
    Friend WithEvents ucrReceiverIndicators As ucrReceiverMultiple
    Friend WithEvents lblCorruptionOutput As Label
    Friend WithEvents lblControlVariables As Label
    Friend WithEvents ucrSaveCorruptionModel As ucrSave
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents ucrInputModelPreview As ucrInputTextBox
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents lblIndicators As Label
    Friend WithEvents ucrSelectorFitModel As ucrSelectorByDataFrameAddRemove
End Class
