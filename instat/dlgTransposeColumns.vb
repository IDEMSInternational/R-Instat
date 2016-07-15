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
Public Class dlgTransposeColumns
    Private bFirstLoad As Boolean = True
    Public clsRToDataFrame, clsTranspose As New RFunction
    Private Sub dlgTransposeColumns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReOpenDialog()
        End If
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBaseTransposeColumns.clsRsyntax.SetFunction("")
        ucrReceiverColumsToTranspose.Selector = ucrSelectorTransposeColumns
        ucrReceiverColumsToTranspose.SetMeAsReceiver()
        ucrBaseTransposeColumns.iHelpTopicID = 277
        ucrNewDataFrameName.SetValidationTypeAsRVariable()
    End Sub

    Private Sub SetDefaults()
        ucrSelectorTransposeColumns.Reset()
        ucrNewDataFrameName.Reset()
        ucrReceiverColumsToTranspose.Selector = ucrSelectorTransposeColumns
        ucrReceiverColumsToTranspose.SetMeAsReceiver()
        If (ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "") Then
            ucrNewDataFrameName.SetName(ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_transposed")
        End If
        TestOkEnabled()

    End Sub

    Private Sub ReOpenDialog()
        If ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNewDataFrameName.SetName(ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_transposed")
        End If
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverColumsToTranspose.IsEmpty Then
            ucrBaseTransposeColumns.OKEnabled(False)
        Else
            ucrBaseTransposeColumns.OKEnabled(True)
        End If
    End Sub

    Public Sub ucrReceiverColumsToTranspose_SelectionChanged() Handles ucrReceiverColumsToTranspose.SelectionChanged
        TestOkEnabled()
        clsTranspose.SetRCommand("t")
        clsTranspose.AddParameter("x", clsRFunctionParameter:=ucrReceiverColumsToTranspose.GetVariables())
        clsRToDataFrame.SetRCommand("as.data.frame")
        clsRToDataFrame.AddParameter("x", clsRFunctionParameter:=clsTranspose)
        ucrBaseTransposeColumns.clsRsyntax.AddParameter("", clsRFunctionParameter:=clsRToDataFrame)

    End Sub

    Private Sub ucrSelectorTransposeColumns_DataFrameChanged() Handles ucrSelectorTransposeColumns.DataFrameChanged
        If (Not ucrNewDataFrameName.UserTyped()) AndAlso ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNewDataFrameName.SetName(ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_transposed")
        End If
        TestOkEnabled()
    End Sub

    Public Sub ucrNewDataFrameName_NameChanged() Handles ucrNewDataFrameName.NameChanged
        If Not ucrNewDataFrameName.IsEmpty Then
            ucrBaseTransposeColumns.clsRsyntax.SetAssignTo(ucrNewDataFrameName.GetText(), strTempDataframe:=ucrNewDataFrameName.GetText())
        Else
            ucrBaseTransposeColumns.clsRsyntax.RemoveAssignTo()
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseTransposeColumns.ClickReset
        SetDefaults()
    End Sub
End Class