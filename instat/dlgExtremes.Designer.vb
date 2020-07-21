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
Partial Class dlgExtremes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgExtremes))
        Me.lblDataToFit = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdFittingOptions = New System.Windows.Forms.Button()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.ucrSaveExtremes = New instat.ucrSave()
        Me.ucrInputExtremes = New instat.ucrInputComboBox()
        Me.ucrSelectorExtremes = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverVariable = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblDataToFit
        '
        resources.ApplyResources(Me.lblDataToFit, "lblDataToFit")
        Me.lblDataToFit.Name = "lblDataToFit"
        Me.lblDataToFit.Tag = "Data_to_be_fitted"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'cmdFittingOptions
        '
        resources.ApplyResources(Me.cmdFittingOptions, "cmdFittingOptions")
        Me.cmdFittingOptions.Name = "cmdFittingOptions"
        Me.cmdFittingOptions.UseVisualStyleBackColor = True
        '
        'cmdDisplayOptions
        '
        resources.ApplyResources(Me.cmdDisplayOptions, "cmdDisplayOptions")
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'ucrSaveExtremes
        '
        resources.ApplyResources(Me.ucrSaveExtremes, "ucrSaveExtremes")
        Me.ucrSaveExtremes.Name = "ucrSaveExtremes"
        '
        'ucrInputExtremes
        '
        Me.ucrInputExtremes.AddQuotesIfUnrecognised = True
        Me.ucrInputExtremes.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputExtremes, "ucrInputExtremes")
        Me.ucrInputExtremes.Name = "ucrInputExtremes"
        '
        'ucrSelectorExtremes
        '
        Me.ucrSelectorExtremes.bDropUnusedFilterLevels = False
        Me.ucrSelectorExtremes.bShowHiddenColumns = False
        Me.ucrSelectorExtremes.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorExtremes, "ucrSelectorExtremes")
        Me.ucrSelectorExtremes.Name = "ucrSelectorExtremes"
        '
        'ucrReceiverVariable
        '
        Me.ucrReceiverVariable.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverVariable, "ucrReceiverVariable")
        Me.ucrReceiverVariable.Name = "ucrReceiverVariable"
        Me.ucrReceiverVariable.Selector = Nothing
        Me.ucrReceiverVariable.strNcFilePath = ""
        Me.ucrReceiverVariable.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgExtremes
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveExtremes)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.cmdFittingOptions)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrInputExtremes)
        Me.Controls.Add(Me.ucrSelectorExtremes)
        Me.Controls.Add(Me.lblDataToFit)
        Me.Controls.Add(Me.ucrReceiverVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExtremes"
        Me.Tag = "Fit_an_Extreme_distribution"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverVariable As ucrReceiverSingle
    Friend WithEvents lblDataToFit As Label
    Friend WithEvents ucrSelectorExtremes As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputExtremes As ucrInputComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents cmdFittingOptions As Button
    Friend WithEvents ucrSaveExtremes As ucrSave
End Class
