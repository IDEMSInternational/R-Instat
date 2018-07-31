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

    Private clsAsDataFrameFunction, clsAtrributesFunction, clsExportFunction As New RFunction
    Private clsAssignOperator As New ROperator
    Private Sub dlgExportToCMSAF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrReceiverStation.Selector = ucrSelectorImportToCMSAF
        ucrReceiverDate.Selector = ucrSelectorImportToCMSAF
        ucrReceiverLongitude.Selector = ucrSelectorImportToCMSAF
        ucrReceiverLatitude.Selector = ucrSelectorImportToCMSAF
        ucrReceiverElement.Selector = ucrSelectorImportToCMSAF

        ucrSelectorImportToCMSAF.SetParameter(New RParameter("x", 0))
        ucrSelectorImportToCMSAF.SetParameterIsrfunction()

        ucrReceiverStation.SetParameter(New RParameter("station_name ", 0))
        ucrReceiverStation.SetParameterIsRFunction()
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        ucrReceiverDate.SetParameter(New RParameter("date", 1))
        ucrReceiverDate.SetParameterIsRFunction()


        ucrReceiverLongitude.SetParameter(New RParameter("lon", 2))
        ucrReceiverLongitude.SetParameterIsRFunction()

        ucrReceiverLatitude.SetParameter(New RParameter("lat", 3))
        ucrReceiverLatitude.SetParameterIsRFunction()

        ucrReceiverElement.SetParameter(New RParameter("SIS", 4))
        ucrReceiverElement.SetParameterIsRFunction()

        ucrInputExportFile.SetParameter(New RParameter("file", 1))
        ucrInputExportFile.IsReadOnly = True

    End Sub

    Private Sub SetDefaults()
        Dim strSIS As String = "SIS"

        clsAsDataFrameFunction = New RFunction
        clsAtrributesFunction = New RFunction
        clsExportFunction = New RFunction

        clsAssignOperator = New ROperator

        ucrBase.clsRsyntax.ClearCodes()
        ucrReceiverElement.SetMeAsReceiver()
        ucrSelectorImportToCMSAF.Reset()
        ucrInputExportFile.SetName("")

        clsAsDataFrameFunction.SetRCommand("data.frame")
        clsAsDataFrameFunction.SetAssignTo("x")

        clsAtrributesFunction.SetRCommand("attr")
        clsAtrributesFunction.AddParameter("x", clsRFunctionParameter:=clsAsDataFrameFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsAtrributesFunction.AddParameter("element_name", Chr(34) & "element_name" & Chr(34), bIncludeArgumentName:=False, iPosition:=1)

        clsAssignOperator.SetOperation("<-")
        clsAssignOperator.AddParameter("left", clsRFunctionParameter:=clsAtrributesFunction, iPosition:=0)
        clsAssignOperator.AddParameter("right", strParameterValue:=Chr(34) & strSIS & Chr(34), iPosition:=1)

        clsExportFunction.SetPackageName("rio")
        clsExportFunction.SetRCommand("export")
        clsExportFunction.AddParameter("x", clsRFunctionParameter:=clsAsDataFrameFunction, bIncludeArgumentName:=False, iPosition:=0)

        ucrBase.clsRsyntax.SetBaseRFunction(clsAsDataFrameFunction)
        ucrBase.clsRsyntax.AddToAfterCodes(clsAssignOperator, iPosition:=0)
        ucrBase.clsRsyntax.AddToAfterCodes(clsExportFunction, iPosition:=1)
    End Sub

    Private Sub SetRCodeForControls(bRese As Boolean)
        ucrReceiverStation.SetRCode(clsAsDataFrameFunction, bReset)
        ucrReceiverDate.SetRCode(clsAsDataFrameFunction, bReset)
        ucrReceiverLongitude.SetRCode(clsAsDataFrameFunction, bReset)
        ucrReceiverLatitude.SetRCode(clsAsDataFrameFunction, bReset)
        ucrReceiverElement.SetRCode(clsAsDataFrameFunction, bReset)
        ucrInputExportFile.SetRCode(clsExportFunction, bReset)
        ucrReceiverDate.SetRCode(clsAsDataFrameFunction, bReset)
        ucrSelectorImportToCMSAF.SetRCode(clsAsDataFrameFunction, bReset)
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click

        Using dlgSave As New SaveFileDialog
            dlgSave.Title = "Save Data File"
            dlgSave.Filter = "RDS Data file (*.Rdata)|*.Rdata"
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
End Class