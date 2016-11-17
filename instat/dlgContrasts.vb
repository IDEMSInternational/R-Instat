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
Imports RDotNet
Imports unvell.ReoGrid
Imports unvell.ReoGrid.Events
Public Class dlgContrasts
    Public WithEvents grdCurrSheet As Worksheet
    Public bFirstLoad As Boolean = True
    Public clsnlevels, clsFactorCol, clsContrMatrix As New RFunction
    Public inLvels As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        grdLayoutForContrasts.SetSettings(WorkbookSettings.View_ShowSheetTabControl, False)
        grdLayoutForContrasts.SetSettings(WorkbookSettings.View_ShowHorScroll, False)
        grdLayoutForContrasts.SheetTabNewButtonVisible = False
        grdCurrSheet = grdLayoutForContrasts.CurrentWorksheet
        grdCurrSheet.SetSettings(WorksheetSettings.Edit_DragSelectionToMoveCells, False)
    End Sub

    Private Sub dlgContrasts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub TestOKEnabled()
        If Not ucrReceiverForContrasts.IsEmpty AndAlso Not ucrInputContrast.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()

    End Sub
    Private Sub InitialiseDialog()
        ucrReceiverForContrasts.Selector = ucrSelectorForContrast
        ucrReceiverForContrasts.SetMeAsReceiver()
        ucrReceiverForContrasts.SetIncludedDataTypes({"factor"})
        ucrBase.iHelpTopicID = 353
        clsnlevels.SetRCommand("nlevels")
        clsContrMatrix.SetRCommand("matrix")
        clsFactorCol.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        ucrInputContrast.SetItems({"Helmert", "Polynomials", "Treatment/Control", "Sum to Zero", "User_defined"})
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_contrasts_of_factor")

    End Sub
    Private Sub SetDefaults()
        ucrInputContrast.SetName("Treatment/Control")
        ucrSelectorForContrast.Reset()
        ucrInputContrast.Reset()
        ucrInputContrast.Enabled = False
        SelectContrast()
        ucrInputContrast.SetEditable(True)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrReceiverForContrasts_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForContrasts.SelectionChanged
        If Not ucrReceiverForContrasts.IsEmpty Then
            ucrInputContrast.Enabled = True
            gridRowscolumns()
            ucrBase.clsRsyntax.AddParameter("col_name", ucrReceiverForContrasts.GetVariableNames)
            gridRowscolumns()
        Else
            ucrInputContrast.Enabled = False
            ucrBase.clsRsyntax.RemoveParameter("col_name")
        End If

        TestOKEnabled()
    End Sub


    Private Sub ucrSelectorForContrast_DataFrameChanged() Handles ucrSelectorForContrast.DataFrameChanged
        clsFactorCol.AddParameter("data_name", Chr(34) & ucrSelectorForContrast.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorForContrast.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrInputContrast_ContentsChanged() Handles ucrInputContrast.ContentsChanged
        If Not ucrInputContrast.IsEmpty Then
            SelectContrast()
        Else
            ucrBase.clsRsyntax.RemoveParameter("new_contrasts")
        End If
        TestOKEnabled()
    End Sub

    Private Sub gridRowscolumns()
        If Not ucrReceiverForContrasts.IsEmpty Then
            clsFactorCol.AddParameter("col_name", ucrReceiverForContrasts.GetVariableNames())
            clsnlevels.AddParameter("x", clsRFunctionParameter:=clsFactorCol)
            ucrInputContrast.Enabled = True
        Else
            clsFactorCol.RemoveParameterByName("col_name")
            clsnlevels.RemoveParameterByName("x")
            ucrInputContrast.Enabled = False
        End If
        grdCurrSheet.Rows = frmMain.clsRLink.RunInternalScriptGetValue(clsnlevels.ToScript).AsNumeric(0)
        grdCurrSheet.Columns = grdCurrSheet.Rows - 1
    End Sub

    Private Sub SelectContrast()
        Select Case ucrInputContrast.GetText
            Case "Treatment/Control"
                Me.Size = New System.Drawing.Size(435, 294)
                ucrBase.clsRsyntax.AddParameter("new_contrasts", Chr(34) & "contr.treatment" & Chr(34))
            Case "Helmert"
                Me.Size = New System.Drawing.Size(435, 294)
                ucrBase.clsRsyntax.AddParameter("new_contrasts", Chr(34) & "contr.helmert" & Chr(34))
            Case "Polynomials"
                Me.Size = New System.Drawing.Size(435, 294)
                ucrBase.clsRsyntax.AddParameter("new_contrasts", Chr(34) & "contr.poly" & Chr(34))
            Case "Sum to Zero"
                Me.Size = New System.Drawing.Size(435, 294)
                ucrBase.clsRsyntax.AddParameter("new_contrasts", Chr(34) & "contr.sum" & Chr(34))
            Case "User_defined"
                gridRowscolumns()
                Me.Size = New System.Drawing.Size(440 + grdLayoutForContrasts.Width, 294)
                ucrBase.clsRsyntax.AddParameter("new_contrasts", Chr(34) & "user_defined" & Chr(34))
        End Select
    End Sub

    Private Sub grdLayoutForContrasts_Leave(sender As Object, e As EventArgs) Handles grdLayoutForContrasts.Leave
        SetMatrixFunction()
    End Sub

    Public Sub SetMatrixFunction()
        Dim i As Integer
        Dim j As Integer
        Dim lstNumbers As New List(Of Integer)
        Dim strMatrix As String = ""

        If grdCurrSheet IsNot Nothing Then
            For i = 0 To grdCurrSheet.ColumnCount - 1
                For j = 0 To grdCurrSheet.RowCount - 1
                    lstNumbers.Add(grdCurrSheet(row:=j, col:=i))
                    strMatrix = strMatrix & grdCurrSheet(row:=j, col:=i)
                    If Not ((i = grdCurrSheet.ColumnCount - 1) AndAlso (j = grdCurrSheet.RowCount - 1)) Then
                        strMatrix = strMatrix & ","
                    End If

                Next
            Next
        End If
        strMatrix = "c" & "(" & strMatrix & ")"
        clsContrMatrix.AddParameter("data", strMatrix)
        clsContrMatrix.AddParameter("ncol", grdCurrSheet.Columns)
        clsContrMatrix.AddParameter("nrow", grdCurrSheet.Rows)
        ucrBase.clsRsyntax.AddParameter("defined_contr_matrix", clsRFunctionParameter:=clsContrMatrix)
    End Sub
End Class