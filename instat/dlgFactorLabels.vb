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
Public Class dlgViewFactorLabels
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsViewFunc As RFunction

    Private Sub dlgFactorLabels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        'TODO: HElP ID

        ucrReceiverFactorColumns.SetParameter(New RParameter("x", 0))
        ucrReceiverFactorColumns.SetParameterIsRFunction()
        ucrReceiverFactorColumns.SetIncludedDataTypes({"factor", "ordered"})
        ucrReceiverFactorColumns.bForceAsDataFrame = True
        ucrReceiverFactorColumns.Selector = ucrSelectorViewFactorLabels
        ucrReceiverFactorColumns.SetMeAsReceiver()

        ucrChkShowLabels.SetParameter(New RParameter("show.labels", 1))
        ucrChkShowLabels.SetText("Show Variable Labels")
        ucrChkShowLabels.SetRDefault("TRUE")

        ucrChkShowType.SetParameter(New RParameter("show.type", 2))
        ucrChkShowType.SetText("Show Variable Type")
        ucrChkShowType.SetRDefault("FALSE")

        ucrChkShowValues.SetParameter(New RParameter("show.values", 3))
        ucrChkShowValues.SetText("Show Variable Values")
        ucrChkShowValues.SetRDefault("TRUE")

        ucrChkShowMissingValues.SetParameter(New RParameter("show.na", 4))
        ucrChkShowMissingValues.SetText("Show Missing Values")
        ucrChkShowMissingValues.SetRDefault("FALSE")

        ucrChkShowId.SetParameter(New RParameter("show.id", 5))
        ucrChkShowId.SetText("Show Id")
        ucrChkShowId.SetRDefault("TRUE")

        ucrChkShowPercentage.SetParameter(New RParameter("show.prc", 6))
        ucrChkShowPercentage.SetText("Add Percentage Column")
        ucrChkShowPercentage.SetRDefault("FALSE")

        ucrChkShowFrequencies.SetParameter(New RParameter("show.frq", 7))
        ucrChkShowFrequencies.SetText("Add Frequencies Column")
        ucrChkShowFrequencies.SetRDefault("FALSE")

        ucrChkAlternateColour.SetParameter(New RParameter("altr.row.col", 8))
        ucrChkAlternateColour.SetText("Highlight Alternate Rows")
        ucrChkAlternateColour.SetRDefault("TRUE")

        ucrChkSortByName.SetParameter(New RParameter("sort.by.name", 9))
        ucrChkSortByName.SetText("Sort by Name")
        ucrChkSortByName.SetRDefault("FALSE")
    End Sub

    Private Sub SetDefaults()
        clsViewFunc = New RFunction

        'Reset
        ucrSelectorViewFactorLabels.Reset()

        'Defining the function
        clsViewFunc.SetPackageName("sjPlot")
        clsViewFunc.SetRCommand("view_df")
        clsViewFunc.AddParameter("show.id", "FALSE")
        ucrBase.clsRsyntax.SetBaseRFunction(clsViewFunc)
    End Sub

    Private Sub TestOkEnabled()
        If (Not (ucrReceiverFactorColumns.IsEmpty) AndAlso (ucrChkAlternateColour.Checked OrElse ucrChkShowFrequencies.Checked OrElse ucrChkShowId.Checked OrElse ucrChkShowLabels.Checked OrElse ucrChkShowMissingValues.Checked OrElse ucrChkShowPercentage.Checked OrElse ucrChkShowType.Checked OrElse ucrChkShowValues.Checked OrElse ucrChkSortByName.Checked)) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverFactorColumns_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactorColumns.ControlContentsChanged, ucrChkAlternateColour.ControlContentsChanged, ucrChkShowFrequencies.ControlContentsChanged, ucrChkShowId.ControlContentsChanged, ucrChkShowLabels.ControlContentsChanged, ucrChkShowMissingValues.ControlContentsChanged, ucrChkShowPercentage.ControlContentsChanged, ucrChkShowType.ControlContentsChanged, ucrChkShowValues.ControlContentsChanged, ucrChkSortByName.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class