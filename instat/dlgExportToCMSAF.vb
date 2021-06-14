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

Imports System.IO
Imports instat.Translations
Public Class dlgExportToCMSAF
    Dim bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDataFrameFunction, clsAtrributesFunction, clsSaveFunction As New RFunction
    Private clsAssignOperator As New ROperator

    Private Sub dlgExportToCMSAF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 569
        ucrReceiverStation.Selector = ucrSelectorImportToCMSAF
        ucrReceiverDate.Selector = ucrSelectorImportToCMSAF
        ucrReceiverLongitude.Selector = ucrSelectorImportToCMSAF
        ucrReceiverLatitude.Selector = ucrSelectorImportToCMSAF
        ucrReceiverElement.Selector = ucrSelectorImportToCMSAF

        ucrReceiverStation.SetParameter(New RParameter("station_name ", 0))
        ucrReceiverStation.SetParameterIsRFunction()
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        ucrReceiverDate.SetParameter(New RParameter("date", 1))
        ucrReceiverDate.SetParameterIsRFunction()
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.bAutoFill = True

        ucrReceiverLongitude.SetParameter(New RParameter("lon", 2))
        ucrReceiverLongitude.SetParameterIsRFunction()

        ucrReceiverLatitude.SetParameter(New RParameter("lat", 3))
        ucrReceiverLatitude.SetParameterIsRFunction()

        ucrReceiverElement.SetParameter(New RParameter("right", 1, bNewIncludeArgumentName:=False))
        ucrReceiverElement.SetParameterIsString()

        ucrInputExportFile.SetParameter(New RParameter("file", 1))
        ucrInputExportFile.IsReadOnly = True
    End Sub

    Private Sub SetDefaults()

        clsDataFrameFunction = New RFunction
        clsAtrributesFunction = New RFunction
        clsSaveFunction = New RFunction

        clsAssignOperator = New ROperator

        ucrBase.clsRsyntax.ClearCodes()
        ucrSelectorImportToCMSAF.Reset()
        ucrReceiverElement.SetMeAsReceiver()
        ucrInputExportFile.SetName("")

        clsDataFrameFunction.SetRCommand("data.frame")

        clsAtrributesFunction.SetRCommand("attr")
        clsAtrributesFunction.AddParameter("x", clsRFunctionParameter:=clsDataFrameFunction, iPosition:=0)
        clsAtrributesFunction.AddParameter("which", Chr(34) & "element_name" & Chr(34), iPosition:=1)

        clsAssignOperator.SetOperation("<-")
        clsAssignOperator.AddParameter("left", clsRFunctionParameter:=clsAtrributesFunction, iPosition:=0)

        clsSaveFunction.SetRCommand("save")
        clsSaveFunction.AddParameter("x", clsRFunctionParameter:=clsDataFrameFunction, bIncludeArgumentName:=False, iPosition:=0)

        ucrBase.clsRsyntax.SetBaseRFunction(clsDataFrameFunction)
        ucrBase.clsRsyntax.AddToAfterCodes(clsAssignOperator, iPosition:=0)
        ucrBase.clsRsyntax.AddToAfterCodes(clsSaveFunction, iPosition:=1)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverStation.SetRCode(clsDataFrameFunction, bReset)
        ucrReceiverDate.SetRCode(clsDataFrameFunction, bReset)
        ucrReceiverLongitude.SetRCode(clsDataFrameFunction, bReset)
        ucrReceiverLatitude.SetRCode(clsDataFrameFunction, bReset)
        ucrReceiverElement.SetRCode(clsAssignOperator, bReset)
        ucrInputExportFile.SetRCode(clsSaveFunction, bReset)
        ucrReceiverDate.SetRCode(clsDataFrameFunction, bReset)
        DataFrameAssignTo()
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        Using dlgSave As New SaveFileDialog
            dlgSave.Title = "Save Data File"
            dlgSave.Filter = "RDS Data file (*.RData)|*.RData"
            If ucrInputExportFile.GetText() <> "" Then
                dlgSave.InitialDirectory = ucrInputExportFile.GetText().Replace("/", "\")
            Else
                dlgSave.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
            End If
            If dlgSave.ShowDialog() = DialogResult.OK Then
                ucrInputExportFile.SetName(dlgSave.FileName.Replace("\", "/"))
            End If
        End Using
    End Sub

    Private Sub ucrReceiverElement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlValueChanged, ucrSelectorImportToCMSAF.ControlValueChanged
        Dim strPreviousElement As String = ""

        For Each clsTempParam In clsDataFrameFunction.clsParameters
            If Not {"station_name", "date", "lon", "lat"}.Contains(clsTempParam.strArgumentName) Then
                strPreviousElement = clsTempParam.strArgumentName
                Exit For
            End If
        Next
        If strPreviousElement <> "" Then
            clsDataFrameFunction.RemoveParameterByName(strPreviousElement)
        End If

        If Not ucrReceiverElement.IsEmpty() Then
            clsDataFrameFunction.AddParameter(strParameterName:=ucrReceiverElement.GetVariableNames(bWithQuotes:=False), clsRFunctionParameter:=ucrReceiverElement.GetVariables, iPosition:=4)
        End If
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverStation.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverLatitude.IsEmpty AndAlso Not ucrReceiverLongitude.IsEmpty AndAlso Not ucrReceiverElement.IsEmpty AndAlso Not ucrInputExportFile.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverDate_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverLatitude.ControlContentsChanged, ucrReceiverLongitude.ControlContentsChanged, ucrReceiverElement.ControlContentsChanged, ucrInputExportFile.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorImportToCMSAF_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorImportToCMSAF.ControlValueChanged
        DataFrameAssignTo()
    End Sub

    Private Sub DataFrameAssignTo()
        If ucrSelectorImportToCMSAF.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            clsDataFrameFunction.SetAssignTo(ucrSelectorImportToCMSAF.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            clsDataFrameFunction.RemoveAssignTo()
        End If
    End Sub
End Class