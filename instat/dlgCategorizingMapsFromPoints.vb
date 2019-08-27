Imports instat

Public Class dlgCategorizingMapsFromPoints
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsStASSfStationFunction As RFunction
    Private clsStASSfShapeFileFunction As RFunction
    Private clsCoordsList As RFunction
    Private clsStIntersects As RFunction
    Private clsUnlist As RFunction
    Private clsAsCharacter As RFunction
    Private clsDollarSignOperator As ROperator
    Private Sub dlgCategorizingMApsFromPoints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrSelectorStationAndShapeFile.SetParameter(New RParameter("data", 0, bNewIncludeArgumentName:=False))
        ucrSelectorStationAndShapeFile.SetParameterIsrfunction()
        ucrSelectorStationAndShapeFile.SetDataframe("", bSilent:=True)

        'Station File
        ucrReceiverLongitude.SetParameter(New RParameter("longitude", 0, bNewIncludeArgumentName:=False))
        ucrReceiverLongitude.Selector = ucrSelectorStationAndShapeFile
        ucrReceiverLongitude.SetIncludedDataTypes({"numeric"})
        ucrReceiverLongitude.strSelectorHeading = "Numerics"
        ucrReceiverLongitude.SetParameterIsString()

        ucrReceiverLatitude.SetParameter(New RParameter("latitude", 1, bNewIncludeArgumentName:=False))
        ucrReceiverLatitude.Selector = ucrSelectorStationAndShapeFile
        ucrReceiverLatitude.SetIncludedDataTypes({"numeric"})
        ucrReceiverLatitude.strSelectorHeading = "Numerics"
        ucrReceiverLatitude.SetParameterIsString()

        'Shape File
        ucrReceiverPolygon.SetParameter(New RParameter("shape file", 0, bNewIncludeArgumentName:=False))
        ucrReceiverPolygon.SetParameterIsString()
        ucrReceiverPolygon.Selector = ucrSelectorStationAndShapeFile
        ucrReceiverPolygon.txtReceiverSingle.Text = ucrSelectorStationAndShapeFile.GetValueToSet()

        'ucrReceiverPolygon.bAttachedToPrimaryDataFrame = False

        'End Receiver
        ucrReceiverName.Selector = ucrSelectorStationAndShapeFile
        ucrReceiverName.SetParameter(New RParameter())
        ucrReceiverName.SetParameterIsString()
        'ucrReceiverName.bAttachedToPrimaryDataFrame = False

        ucrSaveColumn.SetSaveTypeAsColumn()
        ucrSaveColumn.SetDataFrameSelector(ucrSelectorStationAndShapeFile.ucrAvailableDataFrames)
        ucrSaveColumn.SetLabelText("New Column:")
        ucrSaveColumn.SetIsTextBox()
        ucrSaveColumn.SetName("Location1")
        ucrSaveColumn.SetAssignToBooleans(bTempAssignToIsPrefix:=True)


    End Sub
    Private Sub SetDefaults()
        clsStASSfShapeFileFunction = New RFunction
        clsStASSfStationFunction = New RFunction
        clsCoordsList = New RFunction
        clsStIntersects = New RFunction
        clsUnlist = New RFunction
        clsAsCharacter = New RFunction
        clsDollarSignOperator = New ROperator

        ucrSelectorStationAndShapeFile.Reset()
        ucrReceiverLongitude.SetMeAsReceiver()
        ucrReceiverLatitude.SetMeAsReceiver()

        clsStASSfShapeFileFunction.SetPackageName("sf")
        clsStASSfShapeFileFunction.SetRCommand("st_as_sf")

        clsStASSfStationFunction.SetPackageName("sf")
        clsStASSfStationFunction.SetRCommand("st_as_sf")
        clsStASSfStationFunction.AddParameter("coords", clsRFunctionParameter:=clsCoordsList, iPosition:=1)
        clsStASSfStationFunction.AddParameter("crs", "4326")

        clsStIntersects.SetPackageName("sf")
        clsStIntersects.SetRCommand("st_intersects")
        clsStIntersects.AddParameter("station", clsRFunctionParameter:=clsStASSfStationFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsStIntersects.AddParameter("shape file", clsRFunctionParameter:=clsStASSfShapeFileFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsCoordsList.SetRCommand("c")

        clsDollarSignOperator.AddParameter(clsRFunctionParameter:=clsStASSfShapeFileFunction, iPosition:=0)
        clsDollarSignOperator.AddParameter("Dollar", "$", iPosition:=1)
        clsDollarSignOperator.AddParameter("column", "NAME_1", iPosition:=2)
        clsDollarSignOperator.AddParameter("brace", "[", iPosition:=3)
        clsDollarSignOperator.AddParameter(clsRFunctionParameter:=clsUnlist, iPosition:=4)
        clsDollarSignOperator.AddParameter("brace2", "]", iPosition:=5)


        clsUnlist.SetRCommand("unlist")
        clsUnlist.AddParameter(clsRFunctionParameter:=clsStIntersects)

        clsAsCharacter.SetRCommand("as.character")
        clsAsCharacter.AddParameter(clsROperatorParameter:=clsDollarSignOperator)

        ucrBase.clsRsyntax.SetBaseRFunction(clsAsCharacter)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorStationAndShapeFile.SetRCode(clsStASSfStationFunction, bReset)
        ucrReceiverLatitude.SetRCode(clsCoordsList, bReset)
        ucrReceiverLongitude.SetRCode(clsCoordsList, bReset)
        ucrReceiverPolygon.SetRCode(clsStASSfShapeFileFunction, bReset)
        ucrSaveColumn.SetRCode(clsAsCharacter, bReset)
    End Sub

    Private Sub TestOkEnabled()
        Dim bOkEnabled As Boolean = True
        ucrBase.OKEnabled(bOkEnabled)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ShapeFileUpdate()
        Dim ShapeFilePosition As Integer = ucrSelectorStationAndShapeFile.ucrAvailableDataFrames.cboAvailableDataFrames.FindString("gadm")
        If ShapeFilePosition <> -1 Then
            ucrSelectorStationAndShapeFile.ucrAvailableDataFrames.SetText(ucrSelectorStationAndShapeFile.ucrAvailableDataFrames.cboAvailableDataFrames.Items.Item(ShapeFilePosition))
            ucrReceiverPolygon.SetText(ucrSelectorStationAndShapeFile.ucrAvailableDataFrames.cboAvailableDataFrames.Items.Item(ShapeFilePosition))
        End If
    End Sub
    Private Sub ucrReceiverLatitude_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverLatitude.ControlValueChanged
        If Not ucrReceiverLongitude.IsEmpty Then
            ShapeFileUpdate()
        End If
    End Sub

    Private Sub ucrReceiverLongitude_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverLongitude.ControlValueChanged
        If Not ucrReceiverLatitude.IsEmpty Then
            ShapeFileUpdate()
        End If
    End Sub
End Class