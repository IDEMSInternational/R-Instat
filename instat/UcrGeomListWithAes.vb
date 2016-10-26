
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

Imports instat

Public Class UcrGeomListWithParameters
    Public lstAesParameterLabels As New List(Of Label)
    Public lstAesParameterUcr As New List(Of ucrReceiverSingle)
    Public lstCurrArguments As New List(Of String)
    Public bFirstLoad As Boolean = True
    Public ucrLayersControl As ucrLayerParameters
    Public bCheckEnabled As Boolean = True
    Public Event DataFrameChanged()
    Public clsGeomAesFunction As RFunction
    'clsGeomAesFunction stores the value (aes function) of the local mapping (of this particular layer). It is used as parameter in sdgLayerOptions.clsGeomFunction.
    Public bAddToLocalAes As Boolean = True
    Public bCurrentFixAes As Boolean = True

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SetSelector()
        clsGeomAesFunction = New RFunction
        clsGeomAesFunction.SetRCommand("aes")
    End Sub

    Private Sub UcrGeomListWithParameters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            SetParameters()
            bFirstLoad = False
        End If
        SetAes(bCurrentFixAes)
    End Sub

    Private Sub SetSelector()
        ucrReceiverParam1.Selector = UcrSelector
        ucrReceiverParam2.Selector = UcrSelector
        ucrReceiverParam3.Selector = UcrSelector
        ucrReceiverParam4.Selector = UcrSelector
        ucrReceiverParam5.Selector = UcrSelector
        ucrReceiverParam6.Selector = UcrSelector
        ucrReceiverParam7.Selector = UcrSelector
        ucrReceiverParam8.Selector = UcrSelector
        ucrReceiverParam9.Selector = UcrSelector
        ucrReceiverParam1.SetMeAsReceiver()
    End Sub

    Public Overrides Sub Setup(clsTempGgPlot As RFunction, clsTempGeomFunc As RFunction, clsTempGlobalAesFunc As RFunction, Optional bFixAes As Boolean = False, Optional bFixGeom As Boolean = False, Optional strDataframe As String = "", Optional bApplyAesGlobally As Boolean = True, Optional bIgnoreGlobalAes As Boolean = False, Optional iNumVariablesForGeoms As Integer = -1, Optional clsTempLocalAes As RFunction = Nothing)
        'See ucrAdditionalLayers and Specific Plots dlg to see how the SetUp Parameters are chosen within the sdgLayerOptions.SetupLayer call.
        MyBase.Setup(clsTempGgPlot, clsTempGeomFunc, clsTempGlobalAesFunc, bFixAes, bFixGeom, strDataframe, bApplyAesGlobally, bIgnoreGlobalAes, iNumVariablesForGeoms, clsTempLocalAes)
        strGlobalDataFrame = strDataframe
        If clsTempLocalAes IsNot Nothing Then
            clsGeomAesFunction = clsTempLocalAes
        Else
            clsGeomAesFunction = New RFunction
            clsGeomAesFunction.SetRCommand("aes")
        End If
        UcrSelector.SetDataframe(strGlobalDataFrame, (Not bApplyAesGlobally) OrElse strGlobalDataFrame = "")
        UcrSelector.Reset()
        bCurrentFixAes = bFixAes
        SetAes(bCurrentFixAes)

        'Using the values of the two relevant parameters, the two following lines determine whether the chkBoxes ApplyToAllLayers and IgnoreGlobalAes should be ticked. 
        'Introduced a safety net: these can't be ticked at the same time, in that case an error has been made in the code and a message is sent to the user.
        If bApplyAesGlobally AndAlso bIgnoreGlobalAes Then
            MsgBox("Error: the sdgLayerOptions.ucrGeomWithAes.Setup is asking to tick both check boxes ApplyOnAllLayers and IgnoreGlobalAesthetics which is not appropriate. An error has been made when setting the parameters bApplyAesGlobally and bIgnoreGlobalAes in ucrAdditionalLayers or in a Specific PLot dlg. Both check boxes have been unticked by default.", vbOKOnly)
            bApplyAesGlobally = False
            bIgnoreGlobalAes = False
        End If
        chkApplyOnAllLayers.Checked = bApplyAesGlobally
        chkIgnoreGlobalAes.Checked = bIgnoreGlobalAes
    End Sub

    Private Sub SetAes(Optional bFixAes As Boolean = False)
        Dim bFirstEnabled As Boolean = True
        Dim iFirstEnabled As Integer = 0
        bAddToLocalAes = False
        For i = 0 To clsCurrGeom.clsAesParameters.Count - 1
            lstAesParameterUcr(i).Enabled = True
            For Each clsParam In clsGgplotAesFunction.clsParameters
                If clsParam.strArgumentName = lstCurrArguments(i) Then
                    'Should do this for any geom where x = "" ?
                    If (clsCurrGeom.strGeomName = "geom_boxplot" OrElse clsCurrGeom.strGeomName = "geom_dotplot" OrElse clsCurrGeom.strGeomName = "geom_bar") AndAlso clsParam.strArgumentName = "x" AndAlso clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                        lstAesParameterUcr(i).Clear()
                        lstAesParameterUcr(i).Enabled = True
                    Else
                        lstAesParameterUcr(i).Add(clsParam.strArgumentValue)
                        lstAesParameterUcr(i).Enabled = Not bFixAes
                        Exit For
                    End If
                End If
            Next
            For Each clsParam In clsGeomAesFunction.clsParameters
                If clsParam.strArgumentName = lstCurrArguments(i) Then
                    If clsCurrGeom.strGeomName = "geom_boxplot" AndAlso clsParam.strArgumentName = "x" AndAlso clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                        lstAesParameterUcr(i).Clear()
                        lstAesParameterUcr(i).Enabled = True
                    Else
                        lstAesParameterUcr(i).Add(clsParam.strArgumentValue)
                        lstAesParameterUcr(i).Enabled = True
                        Exit For
                    End If
                End If
            Next
            If bFirstEnabled AndAlso lstAesParameterUcr(i).Enabled Then
                iFirstEnabled = i
                bFirstEnabled = False
            End If
        Next
        lstAesParameterUcr(iFirstEnabled).SetMeAsReceiver()
        bAddToLocalAes = True
    End Sub

    Public Sub SetParameters() 'this will set function or aes parameters
        Dim i As Integer = 0

        If lstAesParameterLabels.Count = 0 Then
            lstAesParameterLabels.AddRange({lblGgParam1, lblGgParam2, lblGgParam3, lblGgParam4, lblGgParam5, lblGgParam6, lblGgParam7, lblGgParam8, lblGgParam9}) 'Adds range for the parameter labels
        End If

        If lstAesParameterUcr.Count = 0 Then
            'Adds range for the parameter receivers
            lstAesParameterUcr.AddRange({ucrReceiverParam1, ucrReceiverParam2, ucrReceiverParam3, ucrReceiverParam4, ucrReceiverParam5, ucrReceiverParam6, ucrReceiverParam7, ucrReceiverParam8, ucrReceiverParam9})
        End If

        If clsCurrGeom.clsAesParameters.Count < 9 Then
            lblGgParam9.Visible = False
            ucrReceiverParam9.Visible = False
        Else
            lblGgParam9.Visible = True
            ucrReceiverParam9.Visible = True
        End If

        If clsCurrGeom.clsAesParameters.Count < 8 Then
            lblGgParam8.Visible = False
            ucrReceiverParam8.Visible = False
        Else
            lblGgParam8.Visible = True
            ucrReceiverParam8.Visible = True
        End If

        If clsCurrGeom.clsAesParameters.Count < 7 Then
            lblGgParam7.Visible = False
            ucrReceiverParam7.Visible = False
        Else
            lblGgParam7.Visible = True
            ucrReceiverParam7.Visible = True
        End If
        If clsCurrGeom.clsAesParameters.Count < 6 Then
            lblGgParam6.Visible = False
            ucrReceiverParam6.Visible = False
        Else
            lblGgParam6.Visible = True
            ucrReceiverParam6.Visible = True
        End If
        If clsCurrGeom.clsAesParameters.Count < 5 Then
            lblGgParam5.Visible = False
            ucrReceiverParam5.Visible = False
        Else
            lblGgParam5.Visible = True
            ucrReceiverParam5.Visible = True
        End If

        If clsCurrGeom.clsAesParameters.Count < 4 Then
            lblGgParam4.Visible = False
            ucrReceiverParam4.Visible = False
        Else
            lblGgParam4.Visible = True
            ucrReceiverParam4.Visible = True
        End If

        If clsCurrGeom.clsAesParameters.Count < 3 Then
            lblGgParam3.Visible = False
            ucrReceiverParam3.Visible = False
        Else
            lblGgParam3.Visible = True
            ucrReceiverParam3.Visible = True
        End If

        If clsCurrGeom.clsAesParameters.Count < 2 Then 'this is available for some cases like piechart
            lblGgParam2.Visible = False
            ucrReceiverParam2.Visible = False
        Else
            lblGgParam2.Visible = True
            ucrReceiverParam2.Visible = True
        End If
        'populating labels with appropriate names
        clsGeomAesFunction.ClearParameters()
        If clsCurrGeom IsNot Nothing Then
            lstCurrArguments.Clear()
            For i = 0 To (clsCurrGeom.clsAesParameters.Count - 1)
                lstAesParameterLabels(i).Text = clsCurrGeom.clsAesParameters(i).strAesParameterName
                lstCurrArguments.Add(clsCurrGeom.clsAesParameters(i).strAesParameterName)
                lstAesParameterUcr(i).Clear()
                If clsCurrGeom.clsAesParameters(i).bIsMandatory Then
                    lstAesParameterLabels(i).Font = New Font(lstAesParameterLabels(i).Font, FontStyle.Bold)
                Else
                    lstAesParameterLabels(i).Font = New Font(lstAesParameterLabels(i).Font, FontStyle.Regular)
                End If
                If clsCurrGeom.clsAesParameters(i).strIncludedDataTypes IsNot Nothing Then
                    lstAesParameterUcr(i).SetIncludedDataTypes(clsCurrGeom.clsAesParameters(i).strIncludedDataTypes)
                ElseIf clsCurrGeom.clsAesParameters(i).strExcludedDataTypes IsNot Nothing Then
                    lstAesParameterUcr(i).SetExcludedDataTypes(clsCurrGeom.clsAesParameters(i).strExcludedDataTypes)
                End If
            Next
        End If
        SetAes(bCurrentFixAes)
    End Sub

    Public Sub UcrGeomListWithParameters_cboGeomListIndexChanged(sender As Object, e As EventArgs) Handles Me.GeomChanged
        'this would only work on sdgLayers only
        'sdgLayerOptions.ucrLayerParameter.cboGeomList.SelectedItem = Me.cboGeomList.SelectedItem
        If ucrLayersControl IsNot Nothing Then
            ucrLayersControl.cboGeomList.SelectedItem = Me.cboGeomList.SelectedItem
        End If
        SetParameters()
    End Sub

    Private Sub ucrReceiverParam_WithMeSelectionChanged(ucrChangedReceiver As ucrReceiverSingle) Handles ucrReceiverParam1.WithMeSelectionChanged, ucrReceiverParam2.WithMeSelectionChanged, ucrReceiverParam3.WithMeSelectionChanged, ucrReceiverParam4.WithMeSelectionChanged, ucrReceiverParam5.WithMeSelectionChanged, ucrReceiverParam6.WithMeSelectionChanged, ucrReceiverParam7.WithMeSelectionChanged, ucrReceiverParam8.WithMeSelectionChanged, ucrReceiverParam9.WithMeSelectionChanged
        Dim iIndex As Integer

        If bAddToLocalAes Then
            iIndex = lstAesParameterUcr.IndexOf(ucrChangedReceiver)
            If Not ucrChangedReceiver.IsEmpty Then
                clsGeomAesFunction.AddParameter(lstCurrArguments(iIndex), ucrChangedReceiver.GetVariableNames(False))
            Else
                clsGeomAesFunction.RemoveParameterByName(lstCurrArguments(iIndex))
            End If
            TestForOkEnabled()
        End If
    End Sub

    Public Function TestForOkEnabled() As Boolean
        Dim i As Integer = 0

        For i = 0 To (clsCurrGeom.clsAesParameters.Count - 1)
            If (clsCurrGeom.clsAesParameters(i).bIsMandatory = True) AndAlso (lstAesParameterUcr(i).IsEmpty()) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub chkChangeAes_CheckedChanged(sender As Object, e As EventArgs) Handles chkApplyOnAllLayers.CheckedChanged
        If chkApplyOnAllLayers.Checked Then
            chkIgnoreGlobalAes.Checked = False
            chkIgnoreGlobalAes.Hide()
        Else
            chkIgnoreGlobalAes.Show()
        End If
        UcrSelector.SetDataframe(strGlobalDataFrame, (Not chkApplyOnAllLayers.Checked) OrElse strGlobalDataFrame = "")
    End Sub

    Private Sub chkIgnoreGlobalAes_CheckedChanged(sender As Object, e As EventArgs) Handles chkIgnoreGlobalAes.CheckedChanged
        If chkIgnoreGlobalAes.Checked Then
            clsGeomFunction.AddParameter("inherit.aes", "FALSE")
        Else
            clsGeomFunction.RemoveParameterByName("inherit.aes")
        End If
    End Sub
End Class
