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
Imports System.IO
Imports System.Text.RegularExpressions

Public Class dlgOpenNetCDF
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsRDefaultFunction, clsRCDF As New RFunction
    Dim strFileType As String
    Dim bComponentsInitialised As Boolean
    Public bStartOpenDialog As Boolean
    Dim lstReceivers As New List(Of ucrReceiverSingle)
    Dim lstRecognisedTypes As New List(Of KeyValuePair(Of String, List(Of String)))

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        bFirstLoad = True
        bComponentsInitialised = True
        bStartOpenDialog = True
        ucrInputDataName.bAutoChangeOnLeave = True
    End Sub

    Private Sub dlgOpenNetCDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        If bStartOpenDialog Then
            GetFileFromOpenDialog()
            bStartOpenDialog = False
        End If
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputDataName.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrInputLocDataName.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrInputFilePath.SetRCode(clsRCDF, bReset)
        ucrReceiverLatName.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverLonName.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverTimeName.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkAddDateTime.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub InitialiseDialog()
        'ucrBase.iHelpTopicID = 
        Dim kvpLat As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("lat", {"y", "lat", "latitude", "latit"}.ToList())
        Dim kvpLon As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("lon", {"x", "lon", "longitude", "longit"}.ToList())
        Dim kvpTime As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("time", {"t", "time", "period", "pd"}.ToList())

        ucrInputDataName.SetDefaultTypeAsDataFrame()
        ucrInputDataName.SetValidationTypeAsRVariable()

        ucrInputLocDataName.SetDefaultTypeAsDataFrame()
        ucrInputLocDataName.SetValidationTypeAsRVariable()

        ucrInputFilePath.SetParameter(New RParameter("filename", 0))
        ucrInputDataName.SetParameter(New RParameter("main_data_name", 1))
        ucrInputLocDataName.SetParameter(New RParameter("loc_data_name", 2))

        ucrReceiverLatName.SetParameter(New RParameter("latitude_col_name", 3))
        ucrReceiverLatName.SetParameterIsString()
        ucrReceiverLatName.Selector = ucrSelectorNetCDF
        ucrReceiverLatName.SetItemType("nc_dim_variables")

        ucrReceiverLonName.SetParameter(New RParameter("longitude_col_name", 4))
        ucrReceiverLonName.SetParameterIsString()
        ucrReceiverLonName.Selector = ucrSelectorNetCDF
        ucrReceiverLonName.SetItemType("nc_dim_variables")

        ucrReceiverTimeName.SetParameter(New RParameter("time_col_name", 5))
        ucrReceiverTimeName.SetParameterIsString()
        ucrReceiverTimeName.Selector = ucrSelectorNetCDF
        ucrReceiverTimeName.SetItemType("nc_dim_variables")

        ucrChkAddDateTime.SetParameter(New RParameter("add_date_time", 6))
        ucrChkAddDateTime.SetText("Add Date/Time Column")
        ucrChkAddDateTime.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        lstRecognisedTypes.AddRange({kvpLat, kvpLon, kvpTime})
        lstReceivers.AddRange({ucrReceiverLatName, ucrReceiverLonName, ucrReceiverTimeName})
        ucrReceiverLatName.Tag = "lat"
        ucrReceiverLonName.Tag = "lon"
        ucrReceiverTimeName.Tag = "time"
        SetRSelector()
    End Sub

    Private Sub SetDefaults()
        clsRDefaultFunction = New RFunction
        ucrInputDataName.SetName("")
        ucrSelectorNetCDF.Reset()
        ucrInputFilePath.IsReadOnly = True
        ucrInputFilePath.SetName("")
        clsRDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_NetCDF")
        clsRDefaultFunction.AddParameter("nc_data", clsRFunctionParameter:=clsRCDF)
        clsRDefaultFunction.AddParameter("add_date_time", "TRUE")
        clsRDefaultFunction.AddParameter("loc_data_name", "lat_lon_data")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRDefaultFunction)
        AutoFillReceivers()
    End Sub

    Private Sub TestOkEnabled()
        If (ucrInputDataName.Text <> "" AndAlso ucrInputLocDataName.Text <> "" AndAlso ucrInputFilePath.Text <> "" AndAlso (Not ucrInputDataName.Text = ucrInputLocDataName.Text) AndAlso Not ucrReceiverLatName.IsEmpty() AndAlso Not ucrReceiverLonName.IsEmpty()) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetRSelector()
        Dim ucrTempReceiver As ucrReceiver
        For Each ucrTempReceiver In lstReceivers
            ucrTempReceiver.SetParameter(New RParameter(ucrTempReceiver.Tag))
            ucrTempReceiver.Selector = ucrSelectorNetCDF
            ucrTempReceiver.SetParameterIsString()
            ucrTempReceiver.bExcludeFromSelector = True
        Next
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    'Loads the open dialog on load and click
    Public Sub GetFileFromOpenDialog()
        Dim strFilePath As String = ""
        Dim strFileName As String = ""
        Dim strFileExt As String = ""
        Using dlgOpen As New OpenFileDialog
            dlgOpen.Filter = "All Data files|*.nc|NetCDF files|*.nc"
            dlgOpen.Title = "Open Data from file"
            If Not ucrInputFilePath.IsEmpty() Then
                dlgOpen.InitialDirectory = Path.GetDirectoryName(Replace(ucrInputFilePath.GetText(), "/", "\"))
            Else
                dlgOpen.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
            End If

            If dlgOpen.ShowDialog() = DialogResult.OK Then
                ucrInputDataName.SetName("")
                'checks if the file name is not blank'
                If dlgOpen.FileName <> "" Then
                    strFileName = Path.GetFileNameWithoutExtension(dlgOpen.FileName)
                    strFilePath = Replace(dlgOpen.FileName, "\", "/")
                    strFileExt = Path.GetExtension(strFilePath)
                    ucrInputFilePath.SetName(strFilePath)
                    If strFileExt = ".nc" Then
                        clsRCDF.SetRCommand("nc_open")
                        clsRCDF.SetPackageName("ncdf4")
                        clsRCDF.AddParameter("filename", Chr(34) & strFilePath & Chr(34))
                        strFileType = "nc"
                        ucrInputDataName.SetName(strFileName, bSilent:=True)
                        ucrInputDataName.Focus()
                    End If
                End If
            End If
        End Using
    End Sub

    Private Sub cmdOpenDataSet_Click(sender As Object, e As EventArgs) Handles cmdOpenDataSet.Click
        GetFileFromOpenDialog()
        TestOkEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputFilePath.ControlContentsChanged
        TestOkEnabled()
        AutoFillReceivers()
        ucrReceiverLatName.strNcFilePath = ucrInputFilePath.GetText()
        ucrReceiverLonName.strNcFilePath = ucrInputFilePath.GetText()
        ucrReceiverTimeName.strNcFilePath = ucrInputFilePath.GetText()
    End Sub

    Private Sub Receivers_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverLatName.ControlContentsChanged, ucrReceiverLonName.ControlContentsChanged, ucrInputDataName.ControlContentsChanged, ucrInputLocDataName.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub AutoFillReceivers()
        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver
        Dim bFound As Boolean = False
        'ucrCurrentReceiver.Clear()
        ucrCurrentReceiver = ucrSelectorNetCDF.CurrentReceiver

        For Each ucrTempReceiver As ucrReceiver In lstReceivers
            ucrTempReceiver.Clear()
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetRecognisedValues(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In ucrSelectorNetCDF.lstAvailableVariable.Items
                    For Each strValue As String In lstRecognisedValues
                        If Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]|_", String.Empty).Contains(strValue) Then
                            ucrTempReceiver.Add(lviTempVariable.Text, ucrSelectorNetCDF.lstAvailableVariable.Text)
                            bFound = True
                            Exit For
                        End If
                    Next
                    If bFound Then
                        bFound = False
                        Exit For
                    End If
                Next
            End If
        Next

        If ucrCurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver.SetMeAsReceiver()
        End If
    End Sub

    Private Function GetRecognisedValues(strVariable As String) As List(Of String)
        Dim lstValues As New List(Of String)

        For Each kvpTemp As KeyValuePair(Of String, List(Of String)) In lstRecognisedTypes
            If kvpTemp.Key = strVariable Then
                lstValues = kvpTemp.Value
                Exit For
            End If
        Next
        Return lstValues
    End Function

    Private Sub Selector_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorNetCDF.ControlContentsChanged
        AutoFillReceivers()
    End Sub
End Class