Imports instat.Translations
Public Class dlgPlotRegion
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsPlotRegionFunction As RFunction
    Private clsAsDateTimeFunction As RFunction
    Private Sub dlgPlotRegion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub InitialiseDialog()
        ucrReceiverLongitude.SetParameter(New RParameter("lon", 1))
        ucrReceiverLongitude.Selector = ucrSelectorPlotRegion
        ucrReceiverLongitude.SetParameterIsRFunction()

        ucrReceiverLatitude.SetParameter(New RParameter("lat", 2))
        ucrReceiverLatitude.Selector = ucrSelectorPlotRegion
        ucrReceiverLatitude.SetParameterIsRFunction()

        ucrReceiverElement.SetParameter(New RParameter("product", 3))
        ucrReceiverElement.Selector = ucrSelectorPlotRegion
        ucrReceiverElement.SetParameterIsRFunction()

        ucrReceiverLatitude.SetParameter(New RParameter("time", 4))
        ucrReceiverLatitude.Selector = ucrSelectorPlotRegion
        ucrReceiverLatitude.SetParameterIsRFunction()

    End Sub

    Private Sub SetDefaults()
        clsPlotRegionFunction = New RFunction
        clsAsDateTimeFunction = New RFunction
        ucrSelectorPlotRegion.Reset()
        ucrReceiverLongitude.SetMeAsReceiver()
        clsPlotRegionFunction.SetRCommand("plot_region")
        clsPlotRegionFunction.iCallType = 3
        clsAsDateTimeFunction.SetRCommand("as.Date")
        clsPlotRegionFunction.AddParameter("time_point", clsRFunctionParameter:=clsAsDateTimeFunction)
        AsDate()
        ucrBase.clsRsyntax.SetBaseRFunction(clsPlotRegionFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub ucrBasePlotRegion_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub AsDate()
        clsAsDateTimeFunction.AddParameter("x", Chr(34) & dtpDateTimePicker.Value.Year & "-" & dtpDateTimePicker.Value.Month & "-" & dtpDateTimePicker.Value.Day & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsAsDateTimeFunction.AddParameter("format", Chr(34) & "%Y-%m-%d" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
    End Sub

    Private Sub dtpDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTimePicker.ValueChanged
        AsDate()
    End Sub
End Class