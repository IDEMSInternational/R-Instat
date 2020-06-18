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
Public Class sdgFiltersFromFactor
    Private Sub sdgFiltersFromFactor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()

        ucrFactorReceiver.Selector = ucrFactorSelctor
        ucrFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrFactorReceiver.strSelectorHeading = "Factors"
        ucrFactorReceiver.SetParameter(New RParameter("x", 0))
        ucrFactorReceiver.SetMeAsReceiver()
        ucrFactorReceiver.SetParameterIsRFunction()
        ucrFactorReceiver.bWithQuotes = False

        ucrFactorLevel.SetReceiver(ucrFactorReceiver)
        ucrFactorLevel.SetAsViewerOnly()
        ucrFactorLevel.bIncludeCopyOfLevels = True
        ucrFactorLevel.AddEditableColumns({"New Label"})

        ucrFactorSelctor.SetParameter(New RParameter("data", 0))
        ucrFactorSelctor.SetParameterIsrfunction()

        ucrChkAndExistingFilter.SetText("AndExistingFilter")
        ucrChkAndExistingFilter.AddToLinkedControls(ucrReceiverExistingFilter, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
    End Sub
End Class