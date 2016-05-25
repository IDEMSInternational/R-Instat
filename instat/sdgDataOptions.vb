' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat.Translations
Public Class sdgDataOptions
    Public bFirstLoad As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bFirstLoad = True
    End Sub

    Private Sub sdgDataOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverFilter.Selector = ucrSelectorFilters
        ucrReceiverFilter.SetItemType("filter")
        ucrReceiverFilter.SetMeAsReceiver()
    End Sub

    Public Sub SetDefaults()
        chkShowHiddenColumns.Checked = False
        rdoAllDialogs.Checked = True
    End Sub

    Public Function ShowHiddenColumns() As Boolean
        Return chkShowHiddenColumns.Checked
    End Function

    Private Sub cmdNewFilter_Click(sender As Object, e As EventArgs) Handles cmdNewFilter.Click
        sdgCreateFilter.ShowDialog()
        If sdgCreateFilter.bFilterDefined Then
            frmMain.clsRLink.RunScript(sdgCreateFilter.clsCurrentFilter.ToScript(), strComment:="Create Filter subdialog: Created new filter")
        End If
    End Sub

    Private Sub ucrSubDialogueBase_ClickReturn(sender As Object, e As EventArgs) Handles ucrSubDialogueBase.ClickReturn
        If Not ucrReceiverFilter.IsEmpty() Then
            If rdoAllDialogs.Checked Then
                frmMain.clsRLink.RunScript(ucrReceiverFilter.GetVariables().ToScript(), strComment:="Data Options subdialog: Set the current filter")
            Else
                'TODO Set Local Filter
            End If
        End If
    End Sub
End Class