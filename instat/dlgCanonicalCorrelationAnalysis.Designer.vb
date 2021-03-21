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
Partial Class dlgCanonicalCorrelationAnalysis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCanonicalCorrelationAnalysis))
        Me.lblYVariables = New System.Windows.Forms.Label()
        Me.lblXVariables = New System.Windows.Forms.Label()
        Me.cmdCCAOptions = New System.Windows.Forms.Button()
        Me.ucrReceiverXVariables = New instat.ucrReceiverMultiple()
        Me.ucrReceiverYVariables = New instat.ucrReceiverMultiple()
        Me.ucrSelectorCCA = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveResult = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'lblYVariables
        '
        resources.ApplyResources(Me.lblYVariables, "lblYVariables")
        Me.lblYVariables.Name = "lblYVariables"
        Me.lblYVariables.Tag = "Y_Variables:"
        '
        'lblXVariables
        '
        resources.ApplyResources(Me.lblXVariables, "lblXVariables")
        Me.lblXVariables.Name = "lblXVariables"
        Me.lblXVariables.Tag = "X_Variables:"
        '
        'cmdCCAOptions
        '
        resources.ApplyResources(Me.cmdCCAOptions, "cmdCCAOptions")
        Me.cmdCCAOptions.Name = "cmdCCAOptions"
        Me.cmdCCAOptions.Tag = "Options"
        Me.cmdCCAOptions.UseVisualStyleBackColor = True
        '
        'ucrReceiverXVariables
        '
        Me.ucrReceiverXVariables.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverXVariables, "ucrReceiverXVariables")
        Me.ucrReceiverXVariables.Name = "ucrReceiverXVariables"
        Me.ucrReceiverXVariables.Selector = Nothing
        Me.ucrReceiverXVariables.strNcFilePath = ""
        Me.ucrReceiverXVariables.ucrSelector = Nothing
        '
        'ucrReceiverYVariables
        '
        Me.ucrReceiverYVariables.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverYVariables, "ucrReceiverYVariables")
        Me.ucrReceiverYVariables.Name = "ucrReceiverYVariables"
        Me.ucrReceiverYVariables.Selector = Nothing
        Me.ucrReceiverYVariables.strNcFilePath = ""
        Me.ucrReceiverYVariables.ucrSelector = Nothing
        '
        'ucrSelectorCCA
        '
        Me.ucrSelectorCCA.bShowHiddenColumns = False
        Me.ucrSelectorCCA.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorCCA, "ucrSelectorCCA")
        Me.ucrSelectorCCA.Name = "ucrSelectorCCA"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSaveResult
        '
        resources.ApplyResources(Me.ucrSaveResult, "ucrSaveResult")
        Me.ucrSaveResult.Name = "ucrSaveResult"
        '
        'dlgCanonicalCorrelationAnalysis
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveResult)
        Me.Controls.Add(Me.ucrReceiverYVariables)
        Me.Controls.Add(Me.ucrReceiverXVariables)
        Me.Controls.Add(Me.lblYVariables)
        Me.Controls.Add(Me.cmdCCAOptions)
        Me.Controls.Add(Me.ucrSelectorCCA)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblXVariables)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCanonicalCorrelationAnalysis"
        Me.Tag = "Canonical_Correlation_Analysis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorCCA As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverYVariables As ucrReceiverMultiple
    Friend WithEvents ucrReceiverXVariables As ucrReceiverMultiple
    Friend WithEvents lblYVariables As Label
    Friend WithEvents lblXVariables As Label
    Friend WithEvents cmdCCAOptions As Button
    Friend WithEvents ucrSaveResult As ucrSave
End Class