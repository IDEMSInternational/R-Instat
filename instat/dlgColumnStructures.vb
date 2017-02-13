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
Public Class dlgColumnStructure
    Public clsdefaultCourByStructure As New RFunction
    Private clsSetStructure As New RFunction
    'clsCourByStructure is here to construct the R-command that will colour columns according to their type in case it is required (see relevant tick box).
    Public bFirstLoad As Boolean = True
    Private Sub ucrSelectorColumnStructures_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        SetColumnStructureInReceiver()
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 51

        ucrReceiverType2.Selector = ucrSelectorColumnStructure
        ucrReceiverType1.Selector = ucrSelectorColumnStructure
        ucrReceiverType3.Selector = ucrSelectorColumnStructure
        ucrReceiverType1.bExcludeFromSelector = True
        ucrReceiverType3.bExcludeFromSelector = True
        ucrReceiverType2.bExcludeFromSelector = True

        ucrReceiverType1.SetParameter(New RParameter("struc_type_1"))
        ucrReceiverType1.SetParameterIsString()

        ucrReceiverType2.SetParameter(New RParameter("struc_type_2"))
        ucrReceiverType2.SetParameterIsString()

        ucrReceiverType3.SetParameter(New RParameter("struc_type_3"))
        ucrReceiverType3.SetParameterIsString()

        ucrSelectorColumnStructure.SetParameter(New RParameter("data_name"))
        ucrSelectorColumnStructure.SetParameterIsString()

        ucrColourColumnsByStr.SetText("Color Columns by Structure")

        ' clsdefaultCourByStructure.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_column_colours_by_metadata")
        ' clsSetStructure.AddParameter("property", Chr(34) & "Structure" & Chr(34))

        clsSetStructure.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_structure_columns")
    End Sub

    Private Sub SetDefaults()
        SetColumnStructureInReceiver()
        ucrReceiverType1.SetMeAsReceiver()
        ucrColourColumnsByStr.Checked = False
        ucrBase.clsRsyntax.SetBaseRFunction(clsSetStructure.Clone())
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetColumnStructureInReceiver()
        ucrReceiverType1.AddItemsWithMetadataProperty(ucrSelectorColumnStructure.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Structure", {"structure_type_1_label"})
        ucrReceiverType2.AddItemsWithMetadataProperty(ucrSelectorColumnStructure.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Structure", {"structure_type_2_label"})
        ucrReceiverType3.AddItemsWithMetadataProperty(ucrSelectorColumnStructure.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Structure", {"structure_type_3_label"})
        ucrReceiverType1.SetMeAsReceiver()
    End Sub


    Private Sub TestOKEnabled()
        If (Not ucrReceiverType1.IsEmpty) OrElse (Not ucrReceiverType2.IsEmpty) OrElse (Not ucrReceiverType3.IsEmpty) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverType1_ControlContentChanged(ucrChangedControl As ucrCore) Handles ucrReceiverType1.ControlContentsChanged, ucrReceiverType2.ControlContentsChanged, ucrReceiverType3.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class