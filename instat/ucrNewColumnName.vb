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

Imports RDotNet
Imports instat.Translations

Public Class ucrNewColumnName
    Public lstNextDefaultNames As GenericVector
    Public strCurrDataFrame As String
    Public strPrefix As String = "Val"
    Public bDataFrameSelectorSet = False
    Public WithEvents ucrDataFrameSelector As ucrDataFrame
    Public bUseDefault As Boolean = True
    Public strCurrNewColumnText As String

    Private Sub ucrNewColumnName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bUseDefault = True
        GetNextDefaults()
        If ucrDataFrameSelector IsNot Nothing Then
            frmMain.clsRLink.FillColumnNames(ucrDataFrameSelector.cboAvailableDataFrames.Text, cboColumns:=cboColumnName)
            SetDefaultName()
        End If
    End Sub

    Public Sub SetDataFrameSelector(ucrNewSelector As ucrDataFrame)
        ucrDataFrameSelector = ucrNewSelector
        bDataFrameSelectorSet = True
        GetNextDefaults()
        SetDefaultName()
        frmMain.clsRLink.FillColumnNames(ucrDataFrameSelector.cboAvailableDataFrames.Text, cboColumns:=cboColumnName)
    End Sub

    Public Sub SetPrefix(strNewPrefix As String)
        strPrefix = strNewPrefix
        GetNextDefaults()
        SetDefaultName()
    End Sub

    Public Sub GetNextDefaults()
    End Sub

    Public Sub SetDefaultName()
        Dim i As Integer
        If bUseDefault Then
            If bDataFrameSelectorSet Then
                For i = 0 To lstNextDefaultNames.Length - 1
                    If lstNextDefaultNames.Names(i) = ucrDataFrameSelector.cboAvailableDataFrames.Text Then
                        cboColumnName.Text = lstNextDefaultNames.AsCharacter(i)
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub ucrDataFrameSelector_DataFrameChanged(sender As Object, e As EventArgs, strPreviousDataFrame As String) Handles ucrDataFrameSelector.DataFrameChanged
        frmMain.clsRLink.FillColumnNames(ucrDataFrameSelector.cboAvailableDataFrames.Text, cboColumns:=cboColumnName)
        SetDefaultName()
    End Sub

    'NOTE: This could be a bug if the user edits the text without a key press e.g. paste using mouse
    Private Sub cboColumnName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboColumnName.KeyPress
        bUseDefault = False
    End Sub
End Class