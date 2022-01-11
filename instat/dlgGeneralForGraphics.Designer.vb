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
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(6, 401)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(137, 25)
        Me.cmdOptions.TabIndex = 6
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXVariable.Location = New System.Drawing.Point(264, 183)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(58, 13)
        Me.lblXVariable.TabIndex = 2
        Me.lblXVariable.Tag = "X_Variable:"
        Me.lblXVariable.Text = "X Variable:"
        '
        'lblFillOrColor
        '
        Me.lblFillOrColor.AutoSize = True
        Me.lblFillOrColor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFillOrColor.Location = New System.Drawing.Point(264, 231)
        Me.lblFillOrColor.Name = "lblFillOrColor"
        Me.lblFillOrColor.Size = New System.Drawing.Size(57, 13)
        Me.lblFillOrColor.TabIndex = 4
        Me.lblFillOrColor.Tag = "Fill_Colour:"
        Me.lblFillOrColor.Text = "Fill/Colour:"
        '
        'cmdFacets
        '
        Me.cmdFacets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFacets.Location = New System.Drawing.Point(146, 401)
        Me.cmdFacets.Name = "cmdFacets"
        Me.cmdFacets.Size = New System.Drawing.Size(110, 25)
        Me.cmdFacets.TabIndex = 18
        Me.cmdFacets.Tag = "Facets"
        Me.cmdFacets.Text = "Facets"
        Me.cmdFacets.UseVisualStyleBackColor = True
        '
        'cmdTheme
        '
        Me.cmdTheme.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTheme.Location = New System.Drawing.Point(258, 401)
        Me.cmdTheme.Name = "cmdTheme"
        Me.cmdTheme.Size = New System.Drawing.Size(110, 25)
        Me.cmdTheme.TabIndex = 19
        Me.cmdTheme.Tag = "Theme"
        Me.cmdTheme.Text = "Theme"
        Me.cmdTheme.UseVisualStyleBackColor = True
        '
        'ucrSave
        '
        Me.ucrSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSave.Location = New System.Drawing.Point(6, 434)
        Me.ucrSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSave.Name = "ucrSave"
        Me.ucrSave.Size = New System.Drawing.Size(346, 24)
        Me.ucrSave.TabIndex = 17
        '
        'ucrVariablesAsFactorForGraphics
        '
        Me.ucrVariablesAsFactorForGraphics.AutoSize = True
        Me.ucrVariablesAsFactorForGraphics.frmParent = Me
        Me.ucrVariablesAsFactorForGraphics.Location = New System.Drawing.Point(262, 33)
        Me.ucrVariablesAsFactorForGraphics.Name = "ucrVariablesAsFactorForGraphics"
        Me.ucrVariablesAsFactorForGraphics.Selector = Nothing
        Me.ucrVariablesAsFactorForGraphics.Size = New System.Drawing.Size(125, 136)
        Me.ucrVariablesAsFactorForGraphics.strNcFilePath = ""
        Me.ucrVariablesAsFactorForGraphics.TabIndex = 1
        Me.ucrVariablesAsFactorForGraphics.ucrSelector = Nothing
        Me.ucrVariablesAsFactorForGraphics.ucrVariableSelector = Nothing
        '
        'ucrFillOrColourReceiver
        '
        Me.ucrFillOrColourReceiver.AutoSize = True
        Me.ucrFillOrColourReceiver.frmParent = Me
        Me.ucrFillOrColourReceiver.Location = New System.Drawing.Point(262, 246)
        Me.ucrFillOrColourReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFillOrColourReceiver.Name = "ucrFillOrColourReceiver"
        Me.ucrFillOrColourReceiver.Selector = Nothing
        Me.ucrFillOrColourReceiver.Size = New System.Drawing.Size(125, 26)
        Me.ucrFillOrColourReceiver.strNcFilePath = ""
        Me.ucrFillOrColourReceiver.TabIndex = 5
        Me.ucrFillOrColourReceiver.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.AutoSize = True
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(262, 198)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(125, 26)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 3
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrGraphicsSelector
        '
        Me.ucrGraphicsSelector.AutoSize = True
        Me.ucrGraphicsSelector.bDropUnusedFilterLevels = False
        Me.ucrGraphicsSelector.bShowHiddenColumns = False
        Me.ucrGraphicsSelector.bUseCurrentFilter = True
        Me.ucrGraphicsSelector.Location = New System.Drawing.Point(6, 14)
        Me.ucrGraphicsSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrGraphicsSelector.Name = "ucrGraphicsSelector"
        Me.ucrGraphicsSelector.Size = New System.Drawing.Size(226, 195)
        Me.ucrGraphicsSelector.TabIndex = 0
        '
        'ucrAdditionalLayers
        '
        Me.ucrAdditionalLayers.AutoSize = True
        Me.ucrAdditionalLayers.Location = New System.Drawing.Point(6, 213)
        Me.ucrAdditionalLayers.Name = "ucrAdditionalLayers"
        Me.ucrAdditionalLayers.Size = New System.Drawing.Size(218, 182)
        Me.ucrAdditionalLayers.TabIndex = 7
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(6, 464)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 9
        '
        'dlgGeneralForGraphics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(416, 519)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "General "
        Me.Text = "Graphics"
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
