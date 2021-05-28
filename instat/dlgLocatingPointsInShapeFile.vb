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
    Private clsStAsIntegerFunction As New RFunction
    Private clsExtractColumnStIntersectsFunction As New RFunction
    Private clsDollarOperator As New ROperator
    Private clsOpeningSubsetOperator, clsIsEqualToOperator, clsEqualOpeningSubsetOperator, clsClosingSubsetOperator As New ROperator

    Private Sub dlgLocatingPointsInShapeFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        autoTranslate(Me)
    End Sub

    Private Sub InitiliseDialog()
        ucrSelectorStationFile.SetParameter(New RParameter("x", 0))
        ucrSelectorStationFile.SetParameterIsrfunction()

        ucrSelectorShapeFile.SetParameter(New RParameter("y", 1))
        ucrSelectorShapeFile.SetParameterIsrfunction()

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

        ucrReceiverShapeFilePolygon.SetParameter(New RParameter("left", 0))
        ucrReceiverShapeFilePolygon.Selector = ucrSelectorShapeFile
        ucrReceiverShapeFilePolygon.SetParameterIsRFunction()

        ucrReceiverStationFilePolygon.SetParameter(New RParameter("left", 0))
        ucrReceiverStationFilePolygon.Selector = ucrSelectorStationFile
        ucrReceiverStationFilePolygon.SetParameterIsRFunction()

        ucrChkOmitMissing.SetParameter(New RParameter("na.fail", 3))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("FALSE", "TRUE")
        ucrChkOmitMissing.SetRDefault("TRUE")

        ttStationFile.SetToolTip(ucrReceiverStationFilePolygon.txtReceiverSingle, "Name of the country, county or ward, if available in the station file")
        ttStationFile.SetToolTip(ucrReceiverShapeFilePolygon.txtReceiverSingle, "Name of the country, county or ward in the shapefile")

        ucrSaveNewColumnName.SetPrefix("location")
        ucrSaveNewColumnName.SetSaveTypeAsColumn()
        ucrSaveNewColumnName.SetDataFrameSelector(ucrSelectorStationFile.ucrAvailableDataFrames)
        ucrSaveNewColumnName.SetIsComboBox()
        ucrSaveNewColumnName.SetLabelText("New Column Name:")
    End Sub

    Private Sub SetDefaults()
        clsStAsSfFunction = New RFunction
        clsStAsIntegerFunction = New RFunction
        clsStIntersectsFunction = New RFunction
        clsExtractColumnStIntersectsFunction = New RFunction
        clsStCombineFunction = New RFunction
        clsConcFunction = New RFunction
        clsSubsetOperator = New ROperator
        clsDollarOperator = New ROperator
        clsOpeningSubsetOperator = New ROperator
        clsEqualOpeningSubsetOperator = New ROperator
        clsClosingSubsetOperator = New ROperator
        clsIsEqualToOperator = New ROperator

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

        clsDollarOperator.SetOperation("$")
        clsDollarOperator.bSpaceAroundOperation = False
        clsDollarOperator.AddParameter("left", clsRFunctionParameter:=clsStAsSfFunction, iPosition:=0)
        clsDollarOperator.AddParameter("right", "geometry", iPosition:=1)

        clsExtractColumnStIntersectsFunction.SetPackageName("sf")
        clsExtractColumnStIntersectsFunction.SetRCommand("st_intersects")
        clsExtractColumnStIntersectsFunction.AddParameter("x", clsROperatorParameter:=clsDollarOperator, iPosition:=0)

        clsStAsIntegerFunction.SetRCommand("as.integer")
        clsStAsIntegerFunction.AddParameter("x", clsRFunctionParameter:=clsExtractColumnStIntersectsFunction, iPosition:=0)
        clsStAsIntegerFunction.SetAssignTo("intersection")

        clsEqualOpeningSubsetOperator.SetOperation("[")
        clsEqualOpeningSubsetOperator.bSpaceAroundOperation = False
        clsEqualOpeningSubsetOperator.AddParameter("right", clsROperatorParameter:=clsClosingSubsetOperator, iPosition:=1)

        clsOpeningSubsetOperator.SetOperation("[")
        clsOpeningSubsetOperator.bSpaceAroundOperation = False
        clsOpeningSubsetOperator.AddParameter("right", clsROperatorParameter:=clsClosingSubsetOperator, iPosition:=1)
        clsOpeningSubsetOperator.SetAssignTo("polygon")

        clsClosingSubsetOperator.SetOperation("]")
        clsClosingSubsetOperator.bSpaceAroundOperation = False
        clsClosingSubsetOperator.AddParameter("left", clsRFunctionParameter:=clsStAsIntegerFunction, iPosition:=0)
        clsClosingSubsetOperator.AddParameter("right", "", iPosition:=1)

        clsIsEqualToOperator.SetOperation("==")
        clsIsEqualToOperator.AddParameter("right", clsROperatorParameter:=clsEqualOpeningSubsetOperator, iPosition:=1)
        clsIsEqualToOperator.SetAssignTo("polygon_logical")

        ucrBase.clsRsyntax.SetBaseROperator(clsSubsetOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrSelectorShapeFile.AddAdditionalCodeParameterPair(clsExtractColumnStIntersectsFunction, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=1)

        ucrSelectorStationFile.SetRCode(clsStAsSfFunction, bReset)
        ucrSelectorShapeFile.SetRCode(clsExtractColumnStIntersectsFunction, bReset)
        ucrReceiverLatitude.SetRCode(clsConcFunction, bReset)
        ucrReceiverLongitude.SetRCode(clsConcFunction, bReset)
        ucrReceiverGeometry.SetRCode(clsStCombineFunction, bReset)
        ucrReceiverStationFilePolygon.SetRCode(clsIsEqualToOperator, bReset)
        ucrReceiverShapeFilePolygon.SetRCode(clsOpeningSubsetOperator, bReset)
        ucrReceiverShapeFilePolygon.AddAdditionalCodeParameterPair(clsEqualOpeningSubsetOperator, New RParameter("left", 0), iAdditionalPairNo:=1)

        ucrSaveNewColumnName.SetRCode(clsSubsetOperator, bReset)
        ucrSaveNewColumnName.AddAdditionalRCode(clsOpeningSubsetOperator, iAdditionalPairNo:=1)
        ucrSaveNewColumnName.AddAdditionalRCode(clsIsEqualToOperator, iAdditionalPairNo:=2)

        ucrChkOmitMissing.SetRCode(clsStAsSfFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiverLongitude.IsEmpty OrElse ucrReceiverLatitude.IsEmpty OrElse ucrReceiverGeometry.IsEmpty OrElse (Not ucrReceiverStationFilePolygon.IsEmpty AndAlso ucrReceiverShapeFilePolygon.IsEmpty) OrElse Not ucrSaveNewColumnName.IsComplete Then
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

    Private Sub CoreControlsContentsChanged_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverLatitude.ControlContentsChanged, ucrReceiverLongitude.ControlContentsChanged,
        ucrSaveNewColumnName.ControlContentsChanged, ucrReceiverGeometry.ControlContentsChanged, ucrReceiverShapeFilePolygon.ControlContentsChanged, ucrReceiverStationFilePolygon.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverShapeFilePolygon_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverShapeFilePolygon.ControlContentsChanged, ucrReceiverStationFilePolygon.ControlContentsChanged
        If Not ucrReceiverShapeFilePolygon.IsEmpty AndAlso Not ucrReceiverStationFilePolygon.IsEmpty Then
            ucrBase.clsRsyntax.SetBaseROperator(clsIsEqualToOperator)
        ElseIf Not ucrReceiverShapeFilePolygon.IsEmpty AndAlso ucrReceiverStationFilePolygon.IsEmpty Then
            ucrBase.clsRsyntax.SetBaseROperator(clsOpeningSubsetOperator)
        Else
            ucrBase.clsRsyntax.SetBaseROperator(clsSubsetOperator)
        End If
    End Sub
End Class
