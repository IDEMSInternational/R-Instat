﻿' Instat-R
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
Imports instat
Imports instat.Translations
Public Class dlgTransposeColumns
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsOverallFunction, clsTFunction As New RFunction

    Private Sub dlgTransposeColumns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 277

        ' ucrReceiver
        ucrReceiverColumsToTranspose.SetParameter(New RParameter("x"))
        ucrReceiverColumsToTranspose.SetParameterIsRFunction()
        ucrReceiverColumsToTranspose.Selector = ucrSelectorTransposeColumns
        ucrReceiverColumsToTranspose.SetMeAsReceiver()

        'ucrNewDF
        ucrNewDataframe.SetIsTextBox()
        ucrNewDataframe.SetSaveTypeAsDataFrame()
        ucrNewDataframe.SetDataFrameSelector(ucrSelectorTransposeColumns.ucrAvailableDataFrames)
        ucrNewDataframe.SetLabelText("New Data Frame Name:")

        'chkbox
        'checkbox not implemented as it wasn't on the old version
        'ucrChkNameNewColumns.SetParameter(New RParameter(""))
        ucrChkNameNewColumns.SetText("Name New Columns")
        ucrChkNameNewColumns.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkNameNewColumns.SetRDefault("FALSE")
        ucrChkNameNewColumns.Enabled = False
    End Sub


    Private Sub SetDefaults()
        Dim clsTDefaultFunction As New RFunction
        Dim clsOverallDefaultFunction As New RFunction

        ucrSelectorTransposeColumns.Reset()
        ucrNewDataframe.Reset()
        NewDefaultName()

        clsOverallDefaultFunction.SetRCommand("as.data.frame")
        clsOverallDefaultFunction.SetAssignTo(ucrNewDataframe.GetText(), strTempDataframe:=ucrNewDataframe.GetText())
        clsTDefaultFunction.SetRCommand("t")

        clsTFunction = clsTDefaultFunction.Clone()
        clsOverallFunction = clsOverallDefaultFunction.Clone()

        clsOverallFunction.AddParameter("x", clsRFunctionParameter:=clsTFunction)
        ucrBase.clsRsyntax.SetBaseRFunction(clsOverallFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrReceiverColumsToTranspose.SetRCode(clsTFunction, bReset)
        ucrNewDataframe.SetRCode(clsOverallFunction, bReset)
    End Sub

    Private Sub ReOpenDialog()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverColumsToTranspose.IsEmpty AndAlso ucrNewDataframe.IsComplete() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrs_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTransposeColumns.ControlValueChanged
        NewDefaultName()
    End Sub

    Private Sub NewDefaultName()
        If (Not ucrNewDataframe.bUserTyped) AndAlso ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNewDataframe.SetName(ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_transposed")
        End If
    End Sub

    Private Sub ucrReceiverColumsToTranspose_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumsToTranspose.ControlContentsChanged, ucrNewDataframe.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class