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
Partial Class ucrReceiverMetadataProperty
    Inherits instat.ucrCore

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrReceiverMetadataProperty))
        Me.ucrInputTextValue = New instat.ucrInputTextBox()
        Me.ucrInputCboParamValue = New instat.ucrInputComboBox()
        Me.ucrColor = New instat.ucrColors()
        Me.ucrNudParamValue = New instat.ucrNud()
        Me.SuspendLayout()
        '
        'ucrInputTextValue
        '
        Me.ucrInputTextValue.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputTextValue, "ucrInputTextValue")
        Me.ucrInputTextValue.IsMultiline = False
        Me.ucrInputTextValue.IsReadOnly = False
        Me.ucrInputTextValue.Name = "ucrInputTextValue"
        '
        'ucrInputCboParamValue
        '
        Me.ucrInputCboParamValue.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputCboParamValue, "ucrInputCboParamValue")
        Me.ucrInputCboParamValue.IsReadOnly = False
        Me.ucrInputCboParamValue.Name = "ucrInputCboParamValue"
        '
        'ucrColor
        '
        Me.ucrColor.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrColor, "ucrColor")
        Me.ucrColor.IsReadOnly = False
        Me.ucrColor.Name = "ucrColor"
        '
        'ucrNudParamValue
        '
        Me.ucrNudParamValue.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudParamValue, "ucrNudParamValue")
        Me.ucrNudParamValue.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudParamValue.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudParamValue.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudParamValue.Name = "ucrNudParamValue"
        Me.ucrNudParamValue.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverMetadataProperty
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrNudParamValue)
        Me.Controls.Add(Me.ucrInputTextValue)
        Me.Controls.Add(Me.ucrInputCboParamValue)
        Me.Controls.Add(Me.ucrColor)
        Me.Name = "ucrReceiverMetadataProperty"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucrColor As ucrColors
    Friend WithEvents ucrInputCboParamValue As ucrInputComboBox
    Friend WithEvents ucrInputTextValue As ucrInputTextBox
    Friend WithEvents ucrNudParamValue As ucrNud
End Class
