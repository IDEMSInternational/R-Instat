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
    Private clsStCombineFunction As New RFunction
    Private clsConcFunction As New RFunction
    Private clsSubsetOperator As New ROperator

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
        TestOKEnabled()
    End Sub

    Private Sub InitiliseDialog()
        ucrSelectorStationFile.SetParameter(New RParameter("x", 0))
        ucrSelectorStationFile.SetParameterIsrfunction()

        ucrReceiverLongitude.SetParameter(New RParameter("longitude", 0, bNewIncludeArgumentName:=False))
        ucrReceiverLongitude.Selector = ucrSelectorStationFile
        ucrReceiverLongitude.SetParameterIsString()
        ucrReceiverLongitude.SetDataType("numeric")

        ucrReceiverLatitude.SetParameter(New RParameter("latitude", 1, bNewIncludeArgumentName:=False))
        ucrReceiverLatitude.Selector = ucrSelectorStationFile
        ucrReceiverLatitude.SetParameterIsString()
        ucrReceiverLatitude.SetDataType("numeric")

        ucrReceiverGeometry.SetParameter(New RParameter("x", 1))
        ucrReceiverGeometry.Selector = ucrSelectorShapeFile
        ucrReceiverGeometry.SetParameterIsRFunction()
        ucrReceiverGeometry.SetDataType("numeric")

        ucrChkOmitMissing.SetParameter(New RParameter("na.fail", 3))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("FALSE", "TRUE")
        ucrChkOmitMissing.SetRDefault("TRUE")

        ucrSaveNewColumnName.SetPrefix("location")
        ucrSaveNewColumnName.SetSaveTypeAsColumn()
        ucrSaveNewColumnName.SetDataFrameSelector(ucrSelectorStationFile.ucrAvailableDataFrames)
        ucrSaveNewColumnName.SetIsComboBox()
        ucrSaveNewColumnName.SetLabelText("New Column Name")
    End Sub

    Private Sub SetDefaults()
        clsStAsSfFunction = New RFunction
        clsStIntersectsFunction = New RFunction
        clsStCombineFunction = New RFunction
        clsConcFunction = New RFunction
        clsSubsetOperator = New ROperator

        ucrSelectorShapeFile.Reset()
        ucrSelectorStationFile.Reset()
        ucrSaveNewColumnName.Reset()
        ucrReceiverLongitude.SetMeAsReceiver()
        ucrReceiverGeometry.SetMeAsReceiver()

        clsStAsSfFunction.SetPackageName("sf")
        clsStAsSfFunction.SetRCommand("st_as_sf")
        clsStAsSfFunction.AddParameter("coords", clsRFunctionParameter:=clsConcFunction, iPosition:=1)
        clsStAsSfFunction.AddParameter("na.fail", "FALSE", iPosition:=3)
        clsStAsSfFunction.AddParameter("crs", "4326", iPosition:=2)
        clsStAsSfFunction.SetAssignTo("points")

        clsStIntersectsFunction.SetPackageName("sf")
        clsStIntersectsFunction.SetRCommand("st_intersects")
        clsStIntersectsFunction.AddParameter("x", clsRFunctionParameter:=clsStAsSfFunction, iPosition:=0)
        clsStIntersectsFunction.AddParameter("y", clsRFunctionParameter:=clsStCombineFunction, iPosition:=1)
        clsStIntersectsFunction.AddParameter("sparse", "FALSE", iPosition:=2)
        clsStIntersectsFunction.SetAssignTo("logical_matrix")

        clsConcFunction.SetRCommand("c")

        clsStCombineFunction.SetPackageName("sf")
        clsStCombineFunction.SetRCommand("st_combine")

        clsSubsetOperator.SetOperation("[")
        clsSubsetOperator.AddParameter("left", clsRFunctionParameter:=clsStIntersectsFunction, iPosition:=0)
        clsSubsetOperator.AddParameter("right", ",1]", iPosition:=1)

        ucrBase.clsRsyntax.SetBaseROperator(clsSubsetOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrSelectorStationFile.SetRCode(clsStAsSfFunction, bReset)
        ucrReceiverLatitude.SetRCode(clsConcFunction, bReset)
        ucrReceiverLongitude.SetRCode(clsConcFunction, bReset)
        ucrReceiverGeometry.SetRCode(clsStCombineFunction, bReset)
        ucrSaveNewColumnName.SetRCode(clsSubsetOperator, bReset)
        ucrChkOmitMissing.SetRCode(clsStAsSfFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiverLongitude.IsEmpty OrElse ucrReceiverLatitude.IsEmpty OrElse ucrReceiverGeometry.IsEmpty OrElse Not ucrSaveNewColumnName.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub CoreControlsContentsChanged_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverLatitude.ControlContentsChanged, ucrReceiverLongitude.ControlContentsChanged, ucrSaveNewColumnName.ControlContentsChanged, ucrReceiverGeometry.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class