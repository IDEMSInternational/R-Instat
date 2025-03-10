﻿' R- Instat
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
Public Class sdgFiltersFromFactor
    Private bFirstLoad As Boolean
    Private bReset As Boolean = True
    Private clsAddFilterFromFactors As RFunction
    Public enumFactorMode As String = FactorMode.Filter
    Public Enum FactorMode
        OutFilling
        Filter
    End Enum

    Public Sub New()
        'This call is required by the designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call.
        bFirstLoad = True
        clsAddFilterFromFactors = New RFunction
        clsAddFilterFromFactors.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_filter_as_levels")
    End Sub

    Private Sub sdgFiltersFromFactor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseControls()
            bFirstLoad = False
        End If
        OpeningMode()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        ucrSelectorFiltersFromFactors.SetParameterIsString()

        ucrReceiverFactor.SetParameter(New RParameter("column", 2))
        ucrReceiverFactor.Selector = ucrSelectorFiltersFromFactors
        ucrReceiverFactor.SetParameterIsString()
        ucrReceiverFactor.SetMeAsReceiver()
        ucrReceiverFactor.SetDataType("factor", bStrict:=True)

        Dim dctParamAndColNames As New Dictionary(Of String, String)
        dctParamAndColNames.Add("filter_levels", ucrFactor.DefaultColumnNames.Label)

        ucrFactorLevels.SetParameter(New RParameter("filter_levels", 1))
        ucrFactorLevels.SetAsMultipleSelectorGrid(ucrReceiverFactor,
                                                  dctParamAndColNames:=dctParamAndColNames,
                                                  hiddenColNames:={ucrFactor.DefaultColumnNames.Level},
                                                  bIncludeNALevel:=False)
        ' Automatically select all rows by default
        AddHandler ucrReceiverFactor.SelectionChanged, AddressOf SelectAllFactorLevels

    End Sub

    Public Sub SetRcodeAndDefaultDataFrame(ucrNewBaseSelector As ucrSelector, bReset As Boolean)
        If ucrNewBaseSelector IsNot Nothing AndAlso ucrNewBaseSelector.strCurrentDataFrame <> "" Then
            ucrSelectorFiltersFromFactors.SetDataframe(ucrNewBaseSelector.strCurrentDataFrame, False)
        End If

        If bReset Then
            ucrSelectorFiltersFromFactors.Reset()
            ucrFactorLevels.SetRCode(clsAddFilterFromFactors, bReset)
            ucrReceiverFactor.SetRCode(clsAddFilterFromFactors, bReset)
        End If
    End Sub

    Private Sub ucrBase_ClickReturn(sender As Object, e As EventArgs) Handles ucrBase.ClickReturn
        If ucrFactorLevels.IsAnyGridRowSelected Then
            frmMain.clsRLink.RunScript(clsAddFilterFromFactors.ToScript, strComment:="Filter From Factors subdialog: Created new filter", bSilent:=False)
        End If
    End Sub

    Private Sub ucrSelectorFiltersFromFactors_DataFrameChanged() Handles ucrSelectorFiltersFromFactors.DataFrameChanged
        clsAddFilterFromFactors.AddParameter("data_name", Chr(34) & ucrSelectorFiltersFromFactors.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
    End Sub

    Public Function GetSelectedStations() As String
        Dim strSelectedLevels As String = mdlCoreControl.GetRVector(
        ucrFactorLevels.GetSelectedCellValues(ucrFactor.DefaultColumnNames.Label, True)
    )

        If strSelectedLevels <> "" Then
            Return strSelectedLevels
        Else
            Return ""
        End If
    End Function

    Private Sub SelectAllFactorLevels()
        If ucrFactorLevels.RowCount > 0 Then
            ucrFactorLevels.SelectAllGridRows(True) ' Pass True to select all rows
        End If
    End Sub

    Private Sub OpeningMode()
        Select Case enumFactorMode
            Case FactorMode.Filter
                Me.Text = "Filters From Factor"
            Case FactorMode.OutFilling
                Me.Text = "Stations to Include"
        End Select
    End Sub
End Class