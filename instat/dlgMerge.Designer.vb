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
Partial Class dlgMerge
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgMerge))
        Me.cmdJoinOptions = New System.Windows.Forms.Button()
        Me.lnlJoinType = New System.Windows.Forms.Label()
        Me.ucrSaveMerge = New instat.ucrSave()
        Me.ucrInputJoinType = New instat.ucrInputComboBox()
        Me.ucrSecondDataFrame = New instat.ucrDataFrame()
        Me.ucrFirstDataFrame = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'cmdJoinOptions
        '
        resources.ApplyResources(Me.cmdJoinOptions, "cmdJoinOptions")
        Me.cmdJoinOptions.Name = "cmdJoinOptions"
        Me.cmdJoinOptions.UseVisualStyleBackColor = True
        '
        'lnlJoinType
        '
        resources.ApplyResources(Me.lnlJoinType, "lnlJoinType")
        Me.lnlJoinType.Name = "lnlJoinType"
        '
        'ucrSaveMerge
        '
        resources.ApplyResources(Me.ucrSaveMerge, "ucrSaveMerge")
        Me.ucrSaveMerge.Name = "ucrSaveMerge"
        '
        'ucrInputJoinType
        '
        Me.ucrInputJoinType.AddQuotesIfUnrecognised = True
        Me.ucrInputJoinType.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputJoinType, "ucrInputJoinType")
        Me.ucrInputJoinType.Name = "ucrInputJoinType"
        '
        'ucrSecondDataFrame
        '
        Me.ucrSecondDataFrame.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSecondDataFrame, "ucrSecondDataFrame")
        Me.ucrSecondDataFrame.Name = "ucrSecondDataFrame"
        '
        'ucrFirstDataFrame
        '
        Me.ucrFirstDataFrame.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrFirstDataFrame, "ucrFirstDataFrame")
        Me.ucrFirstDataFrame.Name = "ucrFirstDataFrame"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgMerge
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveMerge)
        Me.Controls.Add(Me.lnlJoinType)
        Me.Controls.Add(Me.ucrInputJoinType)
        Me.Controls.Add(Me.ucrSecondDataFrame)
        Me.Controls.Add(Me.ucrFirstDataFrame)
        Me.Controls.Add(Me.cmdJoinOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMerge"
        Me.Tag = "Merge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdJoinOptions As Button
    Friend WithEvents ucrFirstDataFrame As ucrDataFrame
    Friend WithEvents ucrSecondDataFrame As ucrDataFrame
    Friend WithEvents ucrInputJoinType As ucrInputComboBox
    Friend WithEvents lnlJoinType As Label
    Friend WithEvents ucrSaveMerge As ucrSave
End Class
