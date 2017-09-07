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
    Public bControlsInitialised As Boolean = False
    Private lstMinTextBoxes As List(Of ucrInputTextBox)
    Private lstMaxTextBoxes As List(Of ucrInputTextBox)
    Private lstMinLabels As List(Of Label)
    Private lstMaxLabels As List(Of Label)
    Private lstDims As List(Of String)
    Private lstFunctions As List(Of RFunction)

    Private Sub sdgOpenNetCDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ' subset = list(lat = c(a,b), long = c(a, b), z = c(a, b), time = c(a, b))

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

        lstDims = New List(Of String)(New String() {"X", "Y", "Z", "T"})
        lstMinTextBoxes = New List(Of ucrInputTextBox)(New ucrInputTextBox() {ucrInputMinX, ucrInputMinY, ucrInputMinZ, ucrInputMinS})
        lstMaxTextBoxes = New List(Of ucrInputTextBox)(New ucrInputTextBox() {ucrInputMaxX, ucrInputMaxY, ucrInputMaxZ, ucrInputMaxS})
        lstMinLabels = New List(Of Label)(New Label() {lblMinX, lblMinY, lblMinZ, lblMinT})
        lstMaxLabels = New List(Of Label)(New Label() {lblMaxX, lblMaxY, lblMaxZ, lblMaxT})

        InitialiseTabs()
    End Sub

    Public Sub SetRFunction(clsNewImportNetcdfFunction As RFunction, clsNewNcOpenFunction As RFunction, clsNewBoundaryListFunction As RFunction, clsNewXLimitsFunction As RFunction, clsNewYLimitsFunction As RFunction, clsNewZLimitsFunction As RFunction, clsNewSLimitsFunction As RFunction, clsNewTLimitsFunction As RFunction, strNewShortDescription As String, Optional bReset As Boolean = False)
        Dim numMinMax As NumericVector
        Dim dcmMin As Nullable(Of Decimal)
        Dim dcmMax As Nullable(Of Decimal)
        Dim iIndex As Integer
        Dim clsGetDimNames As New RFunction
        Dim clsGetBoundsFunction As New RFunction
        Dim expTemp As SymbolicExpression
        Dim strDimNames() As String
        Dim strDimAxes() As String

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
        'TODO Add S function to list once extra text boxes added
        lstFunctions = New List(Of RFunction)(New RFunction() {clsXLimitsFunction, clsYLimitsFunction, clsZLimitsFunction, clsTLimitsFunction})

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
                If strDimAxes.Contains(lstDims(i)) Then
                    iIndex = Array.IndexOf(strDimAxes, lstDims(i))
                    clsGetBoundsFunction.AddParameter("dimension", Chr(34) & strDimNames(iIndex) & Chr(34))
                    lstMinLabels(i).Text = "Minimum '" & strDimNames(iIndex) & "':"
                    lstMaxLabels(i).Text = "Maximum '" & strDimNames(iIndex) & "':"
                    expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsGetBoundsFunction.ToScript, bSilent:=True)
                    If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
                        numMinMax = expTemp.AsNumeric
                        If numMinMax.Count = 2 Then
                            dcmMin = numMinMax(0)
                            dcmMax = numMinMax(1)
                        End If
                    End If
                End If
                If dcmMin.HasValue AndAlso dcmMax.HasValue Then
                    lstMinTextBoxes(i).Enabled = True
                    lstMaxTextBoxes(i).Enabled = True
                    lstMinTextBoxes(i).SetValidationTypeAsNumeric(dcmMin:=dcmMin, dcmMax:=dcmMax)
                    lstMaxTextBoxes(i).SetValidationTypeAsNumeric(dcmMin:=dcmMin, dcmMax:=dcmMax)
                    lstFunctions(i).AddParameter("min", dcmMin, bIncludeArgumentName:=False)
                    lstFunctions(i).AddParameter("max", dcmMax, bIncludeArgumentName:=False)
                    clsBoundaryListFunction.AddParameter(strDimNames(iIndex), clsRFunctionParameter:=lstFunctions(i))
                Else
                    lstMinTextBoxes(i).Enabled = False
                    lstMaxTextBoxes(i).Enabled = False
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
            ucrInputMinS.SetRCode(clsTLimitsFunction, bReset, bCloneIfNeeded:=True)
            ucrInputMaxS.SetRCode(clsTLimitsFunction, bReset, bCloneIfNeeded:=True)

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
End Class