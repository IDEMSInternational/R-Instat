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

Public Class dlgRecodeFactor
    Public bFirstLoad As Boolean = True

    Private Sub dlgRecodeFactor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction("revalue")
        ucrReceiverFactor.Selector = ucrSelectorForRecode
        ucrReceiverFactor.SetIncludedDataTypes({"factor"})
        'ucrBase.iHelpTopicID = 

        ucrInputColumnName.SetPrefix("Recode")
        ucrInputColumnName.SetItemsTypeAsColumns()
        ucrInputColumnName.SetDefaultTypeAsColumn()
        ucrInputColumnName.SetDataFrameSelector(ucrSelectorForRecode.ucrAvailableDataFrames)
        'temporary until code is included here
        ucrBase.OKEnabled(False)
    End Sub

    Private Sub SetDefaults()
        ucrSelectorForRecode.Reset()
        ucrReceiverFactor.SetMeAsReceiver()
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()

    End Sub

End Class