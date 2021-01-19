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
Public Class dlgClimaticNCMPTrendGraphs
    Public bFirstLoad As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private bReset As Boolean = True
    Private clsNCMPFunction, clsBaseFunction As New RFunction
    Private bSubDialogOKEnabled As Boolean = True

    Private Sub dlgClimaticNCMPTrendGraphs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        If bFirstLoad Then
            bFirstLoad = False
        End If
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctResolution As New Dictionary(Of String, String)

        ucrSelectorForA2.SetParameter(New RParameter("a2", 0))
        ucrSelectorForA2.SetParameterIsrfunction()
        ucrSelectorForA2.ucrAvailableDataFrames.lblDataFrame.Text = "Indices Data Frame:"

        ucrReceiverStation.SetParameter(New RParameter("station", 1))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorForA2
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        ucrReceiverYearA2.SetParameter(New RParameter("a2_year", 2))
        ucrReceiverYearA2.SetParameterIsString()
        ucrReceiverYearA2.Selector = ucrSelectorForA2
        ucrReceiverYearA2.SetClimaticType("year")
        ucrReceiverYearA2.bAutoFill = True

        ucrReceiverMonthA2.SetParameter(New RParameter("month", 3)) ' TODO: in R code should this be a2_month
        ucrReceiverMonthA2.SetParameterIsString()
        ucrReceiverMonthA2.Selector = ucrSelectorForA2
        ucrReceiverMonthA2.SetClimaticType("month")
        ucrReceiverMonthA2.bAutoFill = True

        ucrSelectorForA4.SetParameter(New RParameter("a4", 4))
        ucrSelectorForA4.SetParameterIsrfunction()
        ucrSelectorForA4.ucrAvailableDataFrames.lblDataFrame.Text = "Region Average Data Frame:"

        ucrReceiverYearA4.SetParameter(New RParameter("a4_year", 5))
        ucrReceiverYearA4.SetParameterIsString()
        ucrReceiverYearA4.Selector = ucrSelectorForA4
        ucrReceiverYearA4.SetClimaticType("year")
        ucrReceiverYearA4.bAutoFill = True

        ucrReceiverMonthA4.SetParameter(New RParameter("a4_month", 6))
        ucrReceiverMonthA4.SetParameterIsString()
        ucrReceiverMonthA4.Selector = ucrSelectorForA4
        ucrReceiverMonthA4.SetClimaticType("month")
        ucrReceiverMonthA4.bAutoFill = True

        ucrNudNYBA.SetParameter(New RParameter("nyba", 8))
        ucrNudNYBA.SetMinMax(1900) ' min/max?

        ucrNudNYEA.SetParameter(New RParameter("nyea", 9))
        ucrNudNYEA.SetMinMax(1900) ' min/max?

        ucrNudNYB.Visible = False
        ucrNudNYB.SetParameter(New RParameter("nyb", 10))
        ucrNudNYB.SetMinMax(1900)

        ucrNudNYE.Visible = False
        ucrNudNYE.SetParameter(New RParameter("nye", 11))
        ucrNudNYE.SetMinMax(1900) ' TODO: how to set as current year - 1

        ucrInputFilePath.SetParameter(New RParameter("ncmp_folder", 12))
        ucrInputFilePath.IsReadOnly = True
    End Sub

    Private Sub SetDefaults()
        clsBaseFunction = New RFunction
        clsNCMPFunction = New RFunction

        ucrSelectorForA2.Reset()
        ucrSelectorForA4.Reset()
        ucrReceiverStation.SetMeAsReceiver()
        ucrReceiverYearA4.SetMeAsReceiver()
        ucrInputFilePath.Reset()
        ucrInputFilePath.SetName("")
        bSubDialogOKEnabled = False
        bResetSubdialog = True

        clsBaseFunction.SetRCommand("data_book$import_data")
        clsBaseFunction.AddParameter("data_tables", clsRFunctionParameter:=clsNCMPFunction)
        clsNCMPFunction.SetRCommand("p5_trends_graphs")
        clsNCMPFunction.AddParameter("nyba", 1950, iPosition:=8)
        clsNCMPFunction.AddParameter("nyea", 2020, iPosition:=9)
        clsNCMPFunction.SetAssignTo("trend_graphs_dfs")
        ucrBase.clsRsyntax.SetBaseRFunction(clsBaseFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        SetRCode(Me, clsNCMPFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverStation.IsEmpty OrElse ucrReceiverYearA4.IsEmpty OrElse ucrReceiverMonthA4.IsEmpty OrElse ucrReceiverYearA2.IsEmpty OrElse ucrReceiverMonthA2.IsEmpty OrElse ucrNudNYB.GetText = "" OrElse ucrNudNYE.GetText = "" OrElse ucrInputFilePath.IsEmpty OrElse ucrNudNYBA.GetText = "" OrElse ucrNudNYEA.GetText = "" OrElse Not bSubDialogOKEnabled Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub cmdStationMetadata_click(sender As Object, e As EventArgs) Handles cmdStationMetadata.Click
        sdgClimaticNCMPMetadata.SetRFunction(clsNCMPFunction, bReset:=bResetSubdialog)
        bResetSubdialog = True
        sdgClimaticNCMPMetadata.ShowDialog()
        bSubDialogOKEnabled = sdgClimaticNCMPMetadata.bOKEnabled
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrInputFilePath_Click(sender As Object, e As EventArgs) Handles ucrInputFilePath.Click
        If ucrInputFilePath.IsEmpty() Then
            SelectLocationToSave()
        End If
    End Sub

    Private Sub SelectLocationToSave()
        Dim strPath As String
        Using dlgFolder As New FolderBrowserDialog
            dlgFolder.Description = "Choose Folder"
            If dlgFolder.ShowDialog() = DialogResult.OK Then
                strPath = dlgFolder.SelectedPath
                ucrInputFilePath.SetName(Replace(strPath, "\", "/"))
            End If
            TestOkEnabled()
        End Using
    End Sub

    Private Sub cmdChooseFile_Click(sender As Object, e As EventArgs) Handles cmdChooseFile.Click
        SelectLocationToSave()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlContentsChanged, ucrReceiverYearA4.ControlContentsChanged, ucrReceiverMonthA4.ControlContentsChanged, ucrReceiverYearA2.ControlContentsChanged, ucrReceiverMonthA2.ControlContentsChanged, ucrNudNYB.ControlContentsChanged, ucrNudNYE.ControlContentsChanged, ucrInputFilePath.ControlContentsChanged, ucrNudNYBA.ControlContentsChanged, ucrNudNYEA.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class