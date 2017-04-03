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
Public Class dlgImportGriddedData
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsRDefaultFunction As New RFunction
    Private Sub dlgImportGriddedData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub InitialiseDialog()
        ucrInputDataName.SetParameter(New RParameter("data_names", 0))
        ucrInputDataName.clsParameter.bIncludeArgumentName = False

        ucrNudMinLat.SetParameter(New RParameter("X1", 1))
        ucrNudMaxLat.SetParameter(New RParameter("X2", 2))
        ucrNudMinLon.SetParameter(New RParameter("Y1", 3))
        ucrNudMaxLon.SetParameter(New RParameter("Y2", 4))

    End Sub

    Private Sub SetDefaults()
        clsRDefaultFunction = New RFunction
        clsRDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_from_iri")
        'clsRDefaultFunction.AddParameter("nc_data", clsRFunctionParameter:=clsRCDF)
        'clsRDefaultFunction.AddParameter("data_names", clsRFunctionParameter:=clsRDatanames)
        ucrBase.clsRsyntax.SetBaseRFunction(clsRDefaultFunction)
    End Sub

    Private Sub TestOkEnabled()
        'If (ucrInputDataName.Text <> "" AndAlso ucrInputLocDataName.Text <> "" AndAlso ucrInputFilePath.Text <> "" AndAlso (Not ucrInputDataName.Text = ucrInputLocDataName.Text)) Then
        If (ucrInputDataName.Text <> "") Then
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

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputDataName.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class