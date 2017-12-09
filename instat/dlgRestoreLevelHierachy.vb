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

Imports instat.Translations
Public Class dlgRestoreLevelHierachy
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgRestoreLevelHierachy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()

        ucrSelectorRestoreHierachy.SetParameter(New RParameter(""))

        ucrReceiverKeyVariables.Selector = ucrSelectorRestoreHierachy
        ucrReceiverKeyVariables.SetParameter(New RParameter(""))
        ucrReceiverKeyVariables.SetIncludedDataTypes({"factor"})

        ucrReceiverCarryVariables.Selector = ucrSelectorRestoreHierachy
        ucrReceiverCarryVariables.SetParameter(New RParameter(""))
        tipRestoreHierachy.SetToolTip(ucrReceiverCarryVariables, "Variables at the same level as key column.")

        ucrChkWarn.SetText("Warn if the other variables are not constant")
        ucrChkWarn.SetParameter(New RParameter(""))
        tipRestoreHierachy.SetToolTip(ucrChkWarn, "columns at the same level as the key column should take a single value at each level of that column.")


        ucrChkDelete.SetText("Delete other variables from the original data frame")
        ucrChkDelete.SetParameter(New RParameter(""))
        tipRestoreHierachy.SetToolTip(ucrChkDelete, "Columns are only deleted if they are constant within levels of the key column.")

        ucrSaveColumn.SetPrefix("Hierachy")
        ucrSaveColumn.SetSaveTypeAsColumn()
        ucrSaveColumn.SetDataFrameSelector(ucrSelectorRestoreHierachy.ucrAvailableDataFrames)
        ucrSaveColumn.SetLabelText("New Column Name:")
        ucrSaveColumn.SetIsComboBox()

    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub TestOkEnabled()

    End Sub
    Private Sub SetRCodeForControls(bReset As Boolean)

    End Sub

End Class