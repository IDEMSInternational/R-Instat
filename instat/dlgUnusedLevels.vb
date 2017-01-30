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
Public Class dlgUnusedLevels
    Private clsDefaultFunction As New RFunction
    Public bFirstLoad As Boolean = True
    Private Sub dlgUnusedLevels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefault()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If

        TestOKEnabled()
        autoTranslate(Me)
    End Sub
    Private Sub ReopenDialog()

    End Sub
    Private Sub SetDefault()
        ' Set default RFunction as the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        ucrSelectorFactorColumn.Reset()
        ucrSelectorFactorColumn.Focus()
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 40

        'Set receiver
        ucrReceiverFactorColumn.Selector = ucrSelectorFactorColumn
        ucrReceiverFactorColumn.SetMeAsReceiver()
        ucrReceiverFactorColumn.SetIncludedDataTypes({"factor"})
        ucrRemoveUnusedFactorLevels.SetReceiver(ucrReceiverFactorColumn)
        ucrReceiverFactorColumn.SetParameter(New RParameter("col_name", 1))
        ucrReceiverFactorColumn.SetParameterIsString()

        'Set selector data frame
        ucrSelectorFactorColumn.SetParameter(New RParameter("data_name", 0))
        ucrSelectorFactorColumn.SetParameterIsString()

        'Set function
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$drop_unused_factor_levels")

    End Sub

    Private Sub ucrBase_clickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefault()
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiverFactorColumn.IsEmpty() Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorFactorColumn.ControlContentsChanged, ucrReceiverFactorColumn.ControlContentsChanged
        TestOKEnabled()
    End Sub

End Class