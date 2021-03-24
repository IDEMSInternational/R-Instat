'R-Instat
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
Public Class dlgLocatingPointsInShapeFile
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsStAsSfFunction As New RFunction
    Private clsStIntersectsFunction As New RFunction
    Private clsConcFunction As New RFunction

    Private Sub dlgLocatingPointsInShapeFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitiliseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitiliseDialog()
        ucrSelectorStationFile.SetParameter(New RParameter("x", 0))
        ucrSelectorStationFile.SetParameterIsrfunction()


        ucrReceiverLongitude.SetParameter(New RParameter("longitude", 0))
        ucrReceiverLongitude.Selector = ucrSelectorStationFile
        ucrReceiverLongitude.SetParameterIsString()
        ucrReceiverLongitude.SetDataType("numeric")

        ucrReceiverLatitude.SetParameter(New RParameter("latitude", 1))
        ucrReceiverLatitude.Selector = ucrSelectorStationFile
        ucrReceiverLatitude.SetParameterIsString()
        ucrReceiverLatitude.SetDataType("numeric")

        ucrReceiverGeometry.SetParameter(New RParameter("y", 1))
        ucrReceiverGeometry.Selector = ucrSelectorShapeFile
        ucrReceiverGeometry.SetDataType("numeric")


        ucrNewColumnName.SetPrefix("logical")
        ucrNewColumnName.SetSaveTypeAsColumn()
        ucrNewColumnName.SetDataFrameSelector(ucrSelectorStationFile.ucrAvailableDataFrames)
        ucrNewColumnName.SetIsComboBox()
        ucrNewColumnName.SetLabelText("New column name")
    End Sub

    Private Sub SetDefaults()
        clsStAsSfFunction = New RFunction
        clsStIntersectsFunction = New RFunction
        clsConcFunction = New RFunction

        ucrSelectorShapeFile.Reset()
        ucrSelectorStationFile.Reset()
        ucrNewColumnName.Reset()


        clsStAsSfFunction.SetPackageName("sf")
        clsStAsSfFunction.SetRCommand("st_as_sf")
        clsStAsSfFunction.AddParameter("coords", clsRFunctionParameter:=clsConcFunction, iPosition:=1)
        clsStAsSfFunction.AddParameter("crs", "4326", iPosition:=2)

        clsStIntersectsFunction.SetPackageName("sf")
        clsStIntersectsFunction.SetRCommand("st_intersects")
        clsStIntersectsFunction.AddParameter("x", clsRFunctionParameter:=clsStAsSfFunction, iPosition:=0)
        clsStIntersectsFunction.AddParameter("sparse", "FALSE", iPosition:=2)

        clsConcFunction.SetRCommand("c")

        ucrBase.clsRsyntax.SetBaseRFunction(clsStIntersectsFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrSelectorStationFile.SetRCode(clsStAsSfFunction, bReset)
        ucrReceiverLatitude.SetRCode(clsConcFunction, bReset)
        ucrReceiverLongitude.SetRCode(clsConcFunction, bReset)
        ucrReceiverGeometry.SetRCode(clsStIntersectsFunction, bReset)
        ucrNewColumnName.SetRCode(clsStIntersectsFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub
End Class