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
Partial Class dlgGeneralForGraphics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgGeneralForGraphics))
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.lblFillOrColor = New System.Windows.Forms.Label()
        Me.cmdFacets = New System.Windows.Forms.Button()
        Me.cmdTheme = New System.Windows.Forms.Button()
        Me.ucrSave = New instat.ucrSave()
        Me.ucrVariablesAsFactorForGraphics = New instat.ucrVariablesAsFactor()
        Me.ucrFillOrColourReceiver = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrGraphicsSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrAdditionalLayers = New instat.ucrAdditionalLayers()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblXVariable
        '
        resources.ApplyResources(Me.lblXVariable, "lblXVariable")
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Tag = "X_Variable:"
        '
        'lblFillOrColor
        '
        resources.ApplyResources(Me.lblFillOrColor, "lblFillOrColor")
        Me.lblFillOrColor.Name = "lblFillOrColor"
        Me.lblFillOrColor.Tag = "Fill_Colour:"
        '
        'cmdFacets
        '
        resources.ApplyResources(Me.cmdFacets, "cmdFacets")
        Me.cmdFacets.Name = "cmdFacets"
        Me.cmdFacets.Tag = "Facets"
        Me.cmdFacets.UseVisualStyleBackColor = True
        '
        'cmdTheme
        '
        resources.ApplyResources(Me.cmdTheme, "cmdTheme")
        Me.cmdTheme.Name = "cmdTheme"
        Me.cmdTheme.Tag = "Theme"
        Me.cmdTheme.UseVisualStyleBackColor = True
        '
        'ucrSave
        '
        resources.ApplyResources(Me.ucrSave, "ucrSave")
        Me.ucrSave.Name = "ucrSave"
        '
        'ucrVariablesAsFactorForGraphics
        '
        Me.ucrVariablesAsFactorForGraphics.frmParent = Me
        resources.ApplyResources(Me.ucrVariablesAsFactorForGraphics, "ucrVariablesAsFactorForGraphics")
        Me.ucrVariablesAsFactorForGraphics.Name = "ucrVariablesAsFactorForGraphics"
        Me.ucrVariablesAsFactorForGraphics.Selector = Nothing
        Me.ucrVariablesAsFactorForGraphics.strNcFilePath = ""
        Me.ucrVariablesAsFactorForGraphics.ucrSelector = Nothing
        Me.ucrVariablesAsFactorForGraphics.ucrVariableSelector = Nothing
        '
        'ucrFillOrColourReceiver
        '
        Me.ucrFillOrColourReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrFillOrColourReceiver, "ucrFillOrColourReceiver")
        Me.ucrFillOrColourReceiver.Name = "ucrFillOrColourReceiver"
        Me.ucrFillOrColourReceiver.Selector = Nothing
        Me.ucrFillOrColourReceiver.strNcFilePath = ""
        Me.ucrFillOrColourReceiver.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverX, "ucrReceiverX")
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrGraphicsSelector
        '
        Me.ucrGraphicsSelector.bDropUnusedFilterLevels = False
        Me.ucrGraphicsSelector.bShowHiddenColumns = False
        Me.ucrGraphicsSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrGraphicsSelector, "ucrGraphicsSelector")
        Me.ucrGraphicsSelector.Name = "ucrGraphicsSelector"
        '
        'ucrAdditionalLayers
        '
        resources.ApplyResources(Me.ucrAdditionalLayers, "ucrAdditionalLayers")
        Me.ucrAdditionalLayers.Name = "ucrAdditionalLayers"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgGeneralForGraphics
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdTheme)
        Me.Controls.Add(Me.cmdFacets)
        Me.Controls.Add(Me.ucrSave)
        Me.Controls.Add(Me.lblFillOrColor)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrVariablesAsFactorForGraphics)
        Me.Controls.Add(Me.ucrFillOrColourReceiver)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.ucrGraphicsSelector)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrAdditionalLayers)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgGeneralForGraphics"
        Me.Tag = "General "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAdditionalLayers As ucrAdditionalLayers
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrGraphicsSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrVariablesAsFactorForGraphics As ucrVariablesAsFactor
    Friend WithEvents ucrFillOrColourReceiver As ucrReceiverSingle
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents lblXVariable As Label
    Friend WithEvents lblFillOrColor As Label
    Friend WithEvents ucrSave As ucrSave
    Friend WithEvents cmdTheme As Button
    Friend WithEvents cmdFacets As Button
End Class
