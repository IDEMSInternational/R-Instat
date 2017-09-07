' R-Instat
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
Imports RDotNet

Public Class sdgOpenNetCDF
    Private clsImportNetcdfFunction, clsNcOpenFunction As New RFunction
    Private clsBoundaryListFunction, clsYLimitsFunction, clsXLimitsFunction, clsZLimitsFunction, clsSLimitsFunction, clsTLimitsFunction As New RFunction
    Private clsAsDateMin, clsAsDateMax As New RFunction
    Public bControlsInitialised As Boolean = False
    Private lstMinTextBoxes As List(Of ucrInputTextBox)
    Private lstMaxTextBoxes As List(Of ucrInputTextBox)
    Private lstAxesLabels As List(Of Label)
    Private lstMinLabels As List(Of Label)
    Private lstMaxLabels As List(Of Label)
    Private lstDims As List(Of String)
    Private lstFunctions As List(Of RFunction)

    Private Sub sdgOpenNetCDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()

        clsAsDateMin.SetRCommand("as.Date")
        clsAsDateMax.SetRCommand("as.Date")

        ucrInputFileDetails.txtInput.ScrollBars = ScrollBars.Vertical

        ucrInputMinX.SetParameter(New RParameter("min", 0, bNewIncludeArgumentName:=False))
        ucrInputMinX.SetValidationTypeAsNumeric()
        ucrInputMinX.AddQuotesIfUnrecognised = False
        ucrInputMinX.Focus()

        ucrInputMaxX.SetParameter(New RParameter("max", 1, bNewIncludeArgumentName:=False))
        ucrInputMaxX.SetValidationTypeAsNumeric()
        ucrInputMaxX.AddQuotesIfUnrecognised = False

        ucrInputMinY.SetParameter(New RParameter("min", 0, bNewIncludeArgumentName:=False))
        ucrInputMinY.SetValidationTypeAsNumeric()
        ucrInputMinY.AddQuotesIfUnrecognised = False

        ucrInputMaxY.SetParameter(New RParameter("max", 1, bNewIncludeArgumentName:=False))
        ucrInputMaxY.SetValidationTypeAsNumeric()
        ucrInputMaxY.AddQuotesIfUnrecognised = False

        ucrInputMinZ.SetParameter(New RParameter("min", 0, bNewIncludeArgumentName:=False))
        ucrInputMinZ.SetValidationTypeAsNumeric()
        ucrInputMinZ.AddQuotesIfUnrecognised = False

        ucrInputMaxZ.SetParameter(New RParameter("max", 1, bNewIncludeArgumentName:=False))
        ucrInputMaxZ.SetValidationTypeAsNumeric()
        ucrInputMaxZ.AddQuotesIfUnrecognised = False

        ucrInputMinS.SetParameter(New RParameter("min", 0, bNewIncludeArgumentName:=False))
        ucrInputMinS.SetValidationTypeAsNumeric()
        ucrInputMinS.AddQuotesIfUnrecognised = False

        ucrInputMaxS.SetParameter(New RParameter("max", 1, bNewIncludeArgumentName:=False))
        ucrInputMaxS.SetValidationTypeAsNumeric()
        ucrInputMaxS.AddQuotesIfUnrecognised = False

        ucrChkOnlyDataVariables.SetParameter(New RParameter("only_data_vars", 2))
        ucrChkOnlyDataVariables.SetText("Only Data Variables")
        ucrChkOnlyDataVariables.SetRDefault("TRUE")

        ucrChkKeepRawTime.SetParameter(New RParameter("keep_raw_time", 3))
        ucrChkKeepRawTime.SetText("Keep Raw Time")
        ucrChkKeepRawTime.SetRDefault("TRUE")

        ucrChkIncludeMetadata.SetParameter(New RParameter("include_metadata", 4))
        ucrChkIncludeMetadata.SetText("Include Metadata")
        ucrChkIncludeMetadata.SetRDefault("TRUE")

        lstDims = New List(Of String)(New String() {"X", "Y", "Z", "S", "T"})
        lstMinTextBoxes = New List(Of ucrInputTextBox)(New ucrInputTextBox() {ucrInputMinX, ucrInputMinY, ucrInputMinZ, ucrInputMinS})
        lstMaxTextBoxes = New List(Of ucrInputTextBox)(New ucrInputTextBox() {ucrInputMaxX, ucrInputMaxY, ucrInputMaxZ, ucrInputMaxS})
        lstAxesLabels = New List(Of Label)(New Label() {lblX, lblY, lblZ, lblS, lblT})
        lstMinLabels = New List(Of Label)(New Label() {lblMinX, lblMinY, lblMinZ, lblMinS, lblMinT})
        lstMaxLabels = New List(Of Label)(New Label() {lblMaxX, lblMaxY, lblMaxZ, lblMaxS, lblMaxT})
        InitialiseTabs()
    End Sub

    Public Sub SetRFunction(clsNewImportNetcdfFunction As RFunction, clsNewNcOpenFunction As RFunction, clsNewBoundaryListFunction As RFunction, clsNewXLimitsFunction As RFunction, clsNewYLimitsFunction As RFunction, clsNewZLimitsFunction As RFunction, clsNewSLimitsFunction As RFunction, clsNewTLimitsFunction As RFunction, strNewShortDescription As String, Optional bReset As Boolean = False)
        Dim numMinMax As NumericVector
        Dim chrMinMaxDates As CharacterVector
        Dim dcmMin As Nullable(Of Decimal)
        Dim dcmMax As Nullable(Of Decimal)
        Dim strMinDate As String
        Dim strMaxDate As String
        Dim strMinDateSplit() As String
        Dim strMaxDateSplit() As String
        Dim iIndex As Integer
        Dim clsGetDimNames As New RFunction
        Dim clsGetBoundsFunction As New RFunction
        Dim expTemp As SymbolicExpression
        Dim strDimNames() As String
        Dim strDimAxes() As String
        Dim bShowDimension As Boolean
        Dim dtMin As DateTime
        Dim dtMax As DateTime

        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsImportNetcdfFunction = clsNewImportNetcdfFunction
        clsNcOpenFunction = clsNewNcOpenFunction
        clsBoundaryListFunction = clsNewBoundaryListFunction
        clsYLimitsFunction = clsNewYLimitsFunction
        clsXLimitsFunction = clsNewXLimitsFunction
        clsZLimitsFunction = clsNewZLimitsFunction
        clsSLimitsFunction = clsNewSLimitsFunction
        clsTLimitsFunction = clsNewTLimitsFunction

        clsTLimitsFunction.AddParameter("min", clsRFunctionParameter:=clsAsDateMin)
        clsTLimitsFunction.AddParameter("max", clsRFunctionParameter:=clsAsDateMax)
        'TODO Add S function to list once extra text boxes added
        lstFunctions = New List(Of RFunction)(New RFunction() {clsXLimitsFunction, clsYLimitsFunction, clsZLimitsFunction, clsSLimitsFunction, clsTLimitsFunction})

        ucrInputFileDetails.SetName(strNewShortDescription)
        'ucrInputFileDetails.txtInput.ScrollToCaret()

        clsGetDimNames.SetPackageName("ncdf4.helpers")
        clsGetDimNames.SetRCommand("nc.get.dim.axes")
        clsGetDimNames.AddParameter("f", clsRFunctionParameter:=clsNcOpenFunction)
        expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsGetDimNames.ToScript, bSilent:=True)
        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            strDimNames = expTemp.AsCharacter.Names.ToArray
            strDimAxes = expTemp.AsCharacter.ToArray
        Else
            strDimNames = Nothing
            strDimAxes = Nothing
        End If
        If strDimAxes IsNot Nothing Then
            clsGetBoundsFunction.SetRCommand("nc_get_dim_min_max")
            clsGetBoundsFunction.AddParameter("nc", clsRFunctionParameter:=clsNcOpenFunction)
            For i As Integer = 0 To lstDims.Count - 1
                dcmMin = Nothing
                dcmMax = Nothing
                strMinDate = ""
                strMaxDate = ""
                If strDimAxes.Contains(lstDims(i)) Then
                    iIndex = Array.IndexOf(strDimAxes, lstDims(i))
                    clsGetBoundsFunction.AddParameter("dimension", Chr(34) & strDimNames(iIndex) & Chr(34))
                    expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsGetBoundsFunction.ToScript, bSilent:=True)
                    If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
                        If lstDims(i) = "T" Then
                            chrMinMaxDates = expTemp.AsCharacter
                            If chrMinMaxDates.Count = 2 Then
                                strMinDate = chrMinMaxDates(0)
                                strMaxDate = chrMinMaxDates(1)
                            End If
                        Else
                            numMinMax = expTemp.AsNumeric
                            If numMinMax.Count = 2 Then
                                dcmMin = numMinMax(0)
                                dcmMax = numMinMax(1)
                            End If
                        End If
                    End If
                End If
                If lstDims(i) = "T" Then
                    bShowDimension = True
                    If strMinDate <> "" AndAlso strMaxDate <> "" Then
                        strMinDateSplit = strMinDate.Split("-")
                        strMaxDateSplit = strMaxDate.Split("-")
                        If strMinDateSplit.Count = 3 AndAlso strMaxDateSplit.Count = 3 Then
                            Try
                                dtMin = New DateTime(strMinDateSplit(0), strMinDateSplit(1), strMinDateSplit(2))
                                dtMax = New DateTime(strMaxDateSplit(0), strMaxDateSplit(1), strMaxDateSplit(2))
                                dtpMinT.MinDate = dtMin
                                dtpMinT.MaxDate = dtMax
                                dtpMaxT.MinDate = dtMin
                                dtpMaxT.MaxDate = dtMax
                                dtpMinT.Value = dtMin
                                dtpMaxT.Value = dtMax
                            Catch ex As Exception
                                bShowDimension = False
                                lstAxesLabels(i).Text = "Could not read time dimension dates from file."
                            End Try
                            If bShowDimension Then
                                lstAxesLabels(i).Text = strDimNames(iIndex) & ":"
                            End If
                        Else
                            bShowDimension = False
                            lstAxesLabels(i).Text = "No " & lstDims(i) & " dimension."
                        End If
                    Else
                        bShowDimension = False
                        lstAxesLabels(i).Text = "No " & lstDims(i) & " dimension."
                    End If
                    If bShowDimension Then
                        dtpMinT.Visible = True
                        dtpMaxT.Visible = True
                        lstMinLabels(i).Visible = True
                        lstMaxLabels(i).Visible = True
                        clsBoundaryListFunction.AddParameter(strDimNames(iIndex), clsRFunctionParameter:=lstFunctions(i))
                    Else
                        dtpMinT.Visible = False
                        dtpMaxT.Visible = False
                        lstMinLabels(i).Visible = False
                        lstMaxLabels(i).Visible = False
                    End If
                Else
                    If dcmMin.HasValue AndAlso dcmMax.HasValue Then
                        lstMinTextBoxes(i).Visible = True
                        lstMaxTextBoxes(i).Visible = True
                        lstMinLabels(i).Visible = True
                        lstMinLabels(i).Visible = True
                        lstMinTextBoxes(i).SetValidationTypeAsNumeric(dcmMin:=dcmMin, dcmMax:=dcmMax)
                        lstMaxTextBoxes(i).SetValidationTypeAsNumeric(dcmMin:=dcmMin, dcmMax:=dcmMax)
                        lstFunctions(i).AddParameter("min", dcmMin, bIncludeArgumentName:=False)
                        lstFunctions(i).AddParameter("max", dcmMax, bIncludeArgumentName:=False)
                        clsBoundaryListFunction.AddParameter(strDimNames(iIndex), clsRFunctionParameter:=lstFunctions(i))
                        lstAxesLabels(i).Text = strDimNames(iIndex) & ":"
                    Else
                        lstMinTextBoxes(i).Visible = False
                        lstMaxTextBoxes(i).Visible = False
                        lstMinLabels(i).Visible = False
                        lstMinLabels(i).Visible = False
                        lstAxesLabels(i).Text = "No " & lstDims(i) & " dimension."
                    End If
                End If
            Next
            If clsBoundaryListFunction.clsParameters.Count > 0 Then
                clsImportNetcdfFunction.AddParameter("boundary", clsRFunctionParameter:=clsBoundaryListFunction)
            End If

            ucrInputMinX.SetRCode(clsXLimitsFunction, bReset, bCloneIfNeeded:=True)
            ucrInputMaxX.SetRCode(clsXLimitsFunction, bReset, bCloneIfNeeded:=True)
            ucrInputMinY.SetRCode(clsYLimitsFunction, bReset, bCloneIfNeeded:=True)
            ucrInputMaxY.SetRCode(clsYLimitsFunction, bReset, bCloneIfNeeded:=True)
            ucrInputMinZ.SetRCode(clsZLimitsFunction, bReset, bCloneIfNeeded:=True)
            ucrInputMaxZ.SetRCode(clsZLimitsFunction, bReset, bCloneIfNeeded:=True)
            ucrInputMinS.SetRCode(clsSLimitsFunction, bReset, bCloneIfNeeded:=True)
            ucrInputMaxS.SetRCode(clsSLimitsFunction, bReset, bCloneIfNeeded:=True)

            ucrChkOnlyDataVariables.SetRCode(clsImportNetcdfFunction, bReset, bCloneIfNeeded:=True)
            ucrChkKeepRawTime.SetRCode(clsImportNetcdfFunction, bReset, bCloneIfNeeded:=True)
            ucrChkIncludeMetadata.SetRCode(clsImportNetcdfFunction, bReset, bCloneIfNeeded:=True)

            ucrInputMinX.Focus()
        End If
    End Sub

    Private Sub InitialiseTabs()
        For i = 0 To tbNetCDF.TabCount - 1
            tbNetCDF.SelectedIndex = i
        Next
        tbNetCDF.SelectedIndex = 0
    End Sub

    Private Sub dtpMinT_ValueChanged(sender As Object, e As EventArgs) Handles dtpMinT.ValueChanged
        clsAsDateMin.AddParameter("x", Chr(34) & dtpMinT.Value.Year & "-" & dtpMinT.Value.Month & "-" & dtpMinT.Value.Day & Chr(34), iPosition:=0)
        clsAsDateMin.AddParameter("format", Chr(34) & "%Y-%m-%d" & Chr(34), iPosition:=1)
    End Sub

    Private Sub dtpMaxT_ValueChanged(sender As Object, e As EventArgs) Handles dtpMaxT.ValueChanged
        clsAsDateMax.AddParameter("x", Chr(34) & dtpMaxT.Value.Year & "-" & dtpMaxT.Value.Month & "-" & dtpMaxT.Value.Day & Chr(34), iPosition:=0)
        clsAsDateMax.AddParameter("format", Chr(34) & "%Y-%m-%d" & Chr(34), iPosition:=1)
    End Sub
End Class