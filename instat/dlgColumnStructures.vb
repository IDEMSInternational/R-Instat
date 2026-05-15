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
Imports RDotNet
Public Class dlgColumnStructure
    Private bReset As Boolean = True
    Private clsColourByMetadata, clsColumnStructure, clsUncolourByMetadata As New RFunction
    'this RFunction is just used for setting the appropriate RCODE of the ucrChkColourColumnsByStructure control
    Private clsColourStructure As New RFunction
    Private bFirstLoad As Boolean = True
    Private Sub ucrSelectorColumnStructures_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        SetColumnStructureInReceiver()
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 51

        ucrSelectorColumnStructure.SetParameter(New RParameter("data_name", 0))
        ucrSelectorColumnStructure.SetParameterIsString()

        ucrReceiverLayout.SetParameter(New RParameter("struc_type_1", 1))
        ucrReceiverLayout.SetParameterIsString()
        ucrReceiverLayout.Selector = ucrSelectorColumnStructure
        ucrReceiverLayout.bExcludeFromSelector = True

        ucrReceiverTreatment.SetParameter(New RParameter("struc_type_2", 2))
        ucrReceiverTreatment.SetParameterIsString()
        ucrReceiverTreatment.Selector = ucrSelectorColumnStructure
        ucrReceiverTreatment.bExcludeFromSelector = True

        ucrReceiverMeasurement.SetParameter(New RParameter("struc_type_3", 3))
        ucrReceiverMeasurement.SetParameterIsString()
        ucrReceiverMeasurement.Selector = ucrSelectorColumnStructure
        ucrReceiverMeasurement.bExcludeFromSelector = True

        ucrChkColourColumnsByStructure.SetText("Colour Columns by Structure")
        ucrChkColourColumnsByStructure.AddFunctionNamesCondition(True, frmMain.clsRLink.strInstatDataObject & "$set_column_colours_by_metadata")
        ucrChkColourColumnsByStructure.AddFunctionNamesCondition(False, frmMain.clsRLink.strInstatDataObject & "$remove_column_colours")
        ucrChkColourColumnsByStructure.SetRDefault("TRUE")
    End Sub

    Private Sub SetDefaults()
        clsColourByMetadata = New RFunction
        clsColumnStructure = New RFunction
        clsUncolourByMetadata = New RFunction
        clsColourStructure = clsUncolourByMetadata

        ucrSelectorColumnStructure.Reset()
        SetColumnStructureInReceiver()
        ucrReceiverLayout.SetMeAsReceiver()

        clsColumnStructure.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_structure_columns")

        clsColourByMetadata.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_column_colours_by_metadata")
        clsColourByMetadata.AddParameter("property", Chr(34) & "Structure" & Chr(34))

        clsUncolourByMetadata.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_column_colours")

        ucrBase.clsRsyntax.SetBaseRFunction(clsColumnStructure)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorColumnStructure.AddAdditionalCodeParameterPair(clsColourByMetadata, ucrSelectorColumnStructure.GetParameter(), iAdditionalPairNo:=1)
        ucrSelectorColumnStructure.AddAdditionalCodeParameterPair(clsUncolourByMetadata, ucrSelectorColumnStructure.GetParameter(), iAdditionalPairNo:=2)
        ucrSelectorColumnStructure.SetRCode(clsColumnStructure, bReset)

        If bReset Then
            ucrReceiverLayout.SetRCode(clsColumnStructure, bReset)
            ucrReceiverTreatment.SetRCode(clsColumnStructure, bReset)
            ucrReceiverMeasurement.SetRCode(clsColumnStructure, bReset)
        End If
    End Sub

    Private Sub TestOKEnabled()
        If ucrSelectorColumnStructure.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrChkColourColumnsByStructure_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkColourColumnsByStructure.ControlValueChanged
        'assign the appropriate Colour Metadata RFunction to the clsColourStructure RFunction accordingly
        If ucrChkColourColumnsByStructure.Checked Then
            clsColourStructure = clsColourByMetadata
        Else
            clsColourStructure = clsUncolourByMetadata
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        frmMain.clsRLink.RunScript(clsColourStructure.ToScript)
    End Sub

    Private Sub SetColumnStructureInReceiver()
        If ucrSelectorColumnStructure.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            Dim strDataName As String = ucrSelectorColumnStructure.ucrAvailableDataFrames.cboAvailableDataFrames.Text
            'Dim currentColumns As List(Of String) = frmMain.clsRLink.GetColumnNames(strDataName)
            Dim currentColumns As New HashSet(Of String)(frmMain.clsRLink.GetColumnNames(strDataName))

            AddValidColumnsToReceiver(ucrReceiverLayout, strDataName, currentColumns, "Structure", {"structure_type_1_label"})
            AddValidColumnsToReceiver(ucrReceiverTreatment, strDataName, currentColumns, "Structure", {"structure_type_2_label"})
            AddValidColumnsToReceiver(ucrReceiverMeasurement, strDataName, currentColumns, "Structure", {"structure_type_3_label"})

            ucrReceiverLayout.SetMeAsReceiver()
        End If
    End Sub

    Private Sub AddValidColumnsToReceiver(receiver As ucrReceiver, strDataName As String, currentColumns As HashSet(Of String), strProperty As String, strValues As String())
        ' Get columns with the metadata property from R
        Dim clsGetItems As New RFunction
        Dim clsIncludeList As New RFunction
        Dim expColumns As SymbolicExpression
        Dim lstItems As New List(Of KeyValuePair(Of String, String))

        clsGetItems.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_names")
        clsGetItems.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
        clsGetItems.AddParameter("as_list", "TRUE")
        clsIncludeList.SetRCommand("list")
        clsIncludeList.AddParameter(strProperty, frmMain.clsRLink.GetListAsRString(strValues.ToList(), bWithQuotes:=False))
        clsGetItems.AddParameter("include", clsRFunctionParameter:=clsIncludeList)

        expColumns = frmMain.clsRLink.RunInternalScriptGetValue(clsGetItems.ToScript(), bSilent:=True)

        receiver.Clear()

        If expColumns IsNot Nothing AndAlso expColumns.Type <> RDotNet.Internals.SymbolicExpressionType.Null Then
            Dim vecColumns = expColumns.AsList
            For i = 0 To vecColumns.Count - 1
                Dim chrCols = vecColumns(i).AsCharacter
                If chrCols IsNot Nothing Then
                    For Each col As String In chrCols
                        ' Only add if column still exists in dataset
                        If currentColumns.Contains(col) Then
                            lstItems.Add(New KeyValuePair(Of String, String)(strDataName, col))
                        End If
                    Next
                End If
            Next
        End If
        'DirectCast(receiver, ucrReceiverMultiple).AddMultiple(lstItems)
        DirectCast(receiver, ucrReceiverMultiple).AddMultiple(lstItems.ToArray())
    End Sub

    Private Sub ucrSelectorColumnStructure_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorColumnStructure.ControlContentsChanged
        TestOKEnabled()
    End Sub

End Class