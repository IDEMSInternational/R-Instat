
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
    'The two previous fields are the lists of parameter labels and receivers on the ucr.
    Public lstCurrArguments As New List(Of String)
    'lstCurrArguments is the list of aes parameters names of the current geom (ucrGeom.clsCurrGeom), i.e. the list of parameter names of clsGeomAesFunction.
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
        'Get the lists of parameter labels and receivers.
        lstAesParameterLabels.AddRange({lblGgParam1, lblGgParam2, lblGgParam3, lblGgParam4, lblGgParam5, lblGgParam6, lblGgParam7, lblGgParam8, lblGgParam9, lblGgParam10, lblGgParam11, lblGgParam12, lblGgParam13})
        lstAesParameterUcr.AddRange({ucrReceiverParam1, ucrReceiverParam2, ucrReceiverParam3, ucrReceiverParam4, ucrReceiverParam5, ucrReceiverParam6, ucrReceiverParam7, ucrReceiverParam8, ucrReceiverParam9, ucrReceiverParam10, ucrReceiverParam11, ucrReceiverParam12, ucrReceiverParam13})
        'Set the R command of the local Aes function.
        clsGeomAesFunction = New RFunction
        clsGeomAesFunction.SetRCommand("aes")
    End Sub

    Private Sub UcrGeomListWithParameters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            SetParameters()
            'This one is called when the geom is changed, which is apparently the case when the Layer is loaded (first thing that happens). Left in for security but could be taken out.
            bFirstLoad = False
        End If
        'SetAes(bCurrentFixAes)
        'Apparently, this is not necessary as SetAes is called several places, when geom is changed and when Layer is set up which always happen at load.
    End Sub

    Private Sub SetSelector()
        'Link the selector and the receivers
        ucrReceiverParam1.Selector = ucrGeomWithAesSelector
        ucrReceiverParam2.Selector = ucrGeomWithAesSelector
        ucrReceiverParam3.Selector = ucrGeomWithAesSelector
        ucrReceiverParam4.Selector = ucrGeomWithAesSelector
        ucrReceiverParam5.Selector = ucrGeomWithAesSelector
        ucrReceiverParam6.Selector = ucrGeomWithAesSelector
        ucrReceiverParam7.Selector = ucrGeomWithAesSelector
        ucrReceiverParam8.Selector = ucrGeomWithAesSelector
        ucrReceiverParam9.Selector = ucrGeomWithAesSelector
        ucrReceiverParam10.Selector = ucrGeomWithAesSelector
        ucrReceiverParam11.Selector = ucrGeomWithAesSelector
        ucrReceiverParam12.Selector = ucrGeomWithAesSelector
        ucrReceiverParam13.Selector = ucrGeomWithAesSelector
    End Sub

    Private Sub InitialiseSelectedDataFrame()
        'When setting up the ucrGeomListWithAes, we want the selected dataframe to be the one used in the clsGeomFunction that has been given through. This is also needed for the method in LocalAndGlobalDataFramesAreDifferent() to work when editing a layer.
        Dim strDataFrameName As String
        Dim iIndexOfData_nameParameter As Integer

        strDataFrameName = strGlobalDataFrame
        If clsGeomFunction.GetParameter("data") IsNot Nothing AndAlso clsGeomFunction.GetParameter("data").clsArgumentCodeStructure.clsParameters.FindIndex(Function(x) x.strArgumentName = "data_name") <> -1 Then
            iIndexOfData_nameParameter = clsGeomFunction.GetParameter("data").clsArgumentCodeStructure.clsParameters.FindIndex(Function(x) x.strArgumentName = "data_name")
            strDataFrameName = clsGeomFunction.GetParameter("data").clsArgumentCodeStructure.clsParameters(iIndexOfData_nameParameter).strArgumentValue
            strDataFrameName = strDataFrameName.Substring(1, strDataFrameName.Length - 2) 'The value of the parameter "data_name" has quotes around it that need to be erased as we merely want the name of the data_frame.
            ucrGeomWithAesSelector.SetDataframe(strDataFrameName)
        Else
            ucrGeomWithAesSelector.SetDataframe(strDataFrameName, (Not chkApplyOnAllLayers.Checked) OrElse strGlobalDataFrame = "")
        End If
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

        'ucrGeomWithAesSelector.Reset() 'Warning: Not sure this is necessary anymore... Testing will confirm.
        InitialiseSelectedDataFrame()

        'Using the values of the two relevant parameters, the two following lines determine whether the chkBoxes ApplyToAllLayers and IgnoreGlobalAes should be ticked. 
        'Introduced a safety net: these can't be ticked at the same time, in that case an error has been made in the code and a message is sent to the user.
        If bApplyAesGlobally AndAlso bIgnoreGlobalAes Then
            MsgBox("Error: the sdgLayerOptions.ucrGeomWithAes.Setup is asking to tick both check boxes ApplyOnAllLayers and IgnoreGlobalAesthetics which is not appropriate. An error has been made when setting the parameters bApplyAesGlobally and bIgnoreGlobalAes in ucrAdditionalLayers or in a Specific PLot dlg. Both check boxes have been unticked by default.", vbOKOnly)
            bApplyAesGlobally = False
            bIgnoreGlobalAes = False
        End If
        chkApplyOnAllLayers.Checked = bApplyAesGlobally
        chkIgnoreGlobalAes.Checked = bIgnoreGlobalAes 'Note: raises the event check changed if the value has indeed changed.





        bCurrentFixAes = bFixAes 'Warning/Question/Task: this is not flexible enough. Some of the aesthetics are set in the options. They cannot be editted on the main, however when coming back to options these are fixed and so cannot be editted anywhere anymore. Would need to be able to choose which aesthetics among a Layer should be fixed maybe.
        'SetAes needs to be called after the IgnoreGlobalAes has been setup as it determines whether the global aes are written in the rceivers or not.
        SetAes(bCurrentFixAes)
        'Warning: SetAes is called three times when a layer is created... one in the load, one in the setup, one when geom is set, ... 
    End Sub

    Private Function LocalAndGlobalDataFramesAreDifferent() As Boolean
        'This methods checks whether the dataframe used for this layer is different from the global dataframe. If they are different, then chkIgnoreGlobalAes is checked. See UcrSelector_DataFrameChanged. Might also be used to print global aes in red when dataframes are different.
        Dim bValue As Boolean = False
        If strGlobalDataFrame <> "" AndAlso ucrGeomWithAesSelector.strCurrentDataFrame <> strGlobalDataFrame Then 'Warning: if the CurrentDataframe is chosen appropriately, which is the case thanks to InitialiseSelectedDataFrame
            bValue = True
        End If
        Return bValue
    End Function
    Private Sub SetAes(Optional bFixAes As Boolean = False)
        'This function fills in the aesthetic receivers with the appropriate values, starting with the values coming from the global aes (if IgnoreGlobalAes is not chacked) and then in the local aes.
        Dim bFirstEnabled As Boolean = True
        Dim iFirstEnabled As Integer = 0
        bAddToLocalAes = False
        'We are changing the content of the receivers according to the info in the clsGgplotAesFunction and clsGeomAesFunction. We don't want to change the content of clsGeomAesFunction according to the changed content of the receivers. Hence we set bApplyToLocalAes to False at the beginning of this procedure, then reset it to True at the end (see ucrReceiverParam_WithMeSelectionChanged).
        For i = 0 To clsCurrGeom.clsAesParameters.Count - 1
            'Clear the potentially up to date content of the Aesthetics receivers. If the content of lstAesParameterUcr(i) is still relevant, then one of the parameters's name in clsGgplotAesFunction will match lstCurrArguments(i) and the value recovered accordingly.
            'Warning/Question: when geom is changed, local aes of previous geom are not kept. Is that fine ? Could change the method for layer to remember the previous selection for common aes between the two geoms.
            'Warning: the order in which the two following are called counts as clearing only operates when ucr is enabled. Not that this sub will always enable all ucr's that were previously disabled.
            lstAesParameterUcr(i).Enabled = True
            lstAesParameterUcr(i).Clear()
            'When IgnoreGlobalAes is checked, we don't want the global aesthetics to appear in the receivers.
            'Task: print global aesthetics in blue within the receivers and perhaps global aesthetics inherited from another dataframe in red ?
            If Not chkIgnoreGlobalAes.Checked Then
                For Each clsParam In clsGgplotAesFunction.clsParameters
                    If clsParam.strArgumentName = lstCurrArguments(i) Then
                        'For some geoms like LinePlot, when the x or y aes is not filled, ggplot R syntax requires to set x="". This x="" might be copied into the global aes if the ApplyOnAllLayers is set to true for a BoxPlot Layer. This might be copied from the GgplotAesFunction parameters into the aes receivers by error in subsequent layers.
                        If Not ((clsParam.strArgumentName = "x" OrElse clsParam.strArgumentName = "y") AndAlso clsParam.strArgumentValue = Chr(34) & Chr(34)) Then
                            lstAesParameterUcr(i).Add(clsParam.strArgumentValue)
                            lstAesParameterUcr(i).Enabled = Not bFixAes 'Warning/Question/Task: this is not flexible enough. Some of the aesthetics are set in the options. They cannot be editted on the main, however when coming back to options these are fixed and so cannot be editted anywhere anymore. Would need to be able to choose which aesthetics among a Layer should be fixed maybe.
                            Exit For
                        End If
                    End If
                Next
            End If
            For Each clsParam In clsGeomAesFunction.clsParameters
                If clsParam.strArgumentName = lstCurrArguments(i) Then
                    If Not ((clsParam.strArgumentName = "x" OrElse clsParam.strArgumentName = "y") AndAlso clsParam.strArgumentValue = Chr(34) & Chr(34)) Then 'As before, check that x is not mapped to "" before putting in receivers.
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

        Dim iMaxIndex As Integer = lstAesParameterLabels.Count
        'iMaxIndex will be set as the minimum between the number of aes parameters in the current geom and the number of aesthetics recievers on the dialog.
        Dim i As Integer = iMaxIndex
        'i is just an index variable for the loops.

        'Security check: our current geom has been populated.
        If clsCurrGeom IsNot Nothing Then
            'The following two will be reset as desired.
            clsGeomAesFunction.ClearParameters()
            lstCurrArguments.Clear()

            If (clsCurrGeom.clsAesParameters.Count < iMaxIndex) Then
                'If the number of aes parameters in the current geom is smaller than the number of receivers, then we hide the exceeding receivers and labels.
                iMaxIndex = clsCurrGeom.clsAesParameters.Count
                For i = iMaxIndex To (lstAesParameterLabels.Count - 1)
                    lstAesParameterLabels(i).Visible = False
                    lstAesParameterUcr(i).Visible = False
                Next
            ElseIf (clsCurrGeom.clsAesParameters.Count > iMaxIndex) Then
                'If the number of parameters in the current geom is greater than the number of receivers, then there is an error.
                MsgBox("Developer Error, the number of aesthetics parameters of the current geom exceeds the number of aesthetic receivers in ucrGeomListWithAes, on the sdgLayerOptions. The exceding parameters will be ignored.", MsgBoxStyle.OkOnly)
            End If

            'In any case, we show all the receivers that have index lower than the iMaxIndex, and we populate the labels with the appropriate names.
            i = 0
            For i = 0 To (iMaxIndex - 1)
                lstAesParameterLabels(i).Visible = True
                lstAesParameterUcr(i).Visible = True

                lstAesParameterLabels(i).Text = clsCurrGeom.clsAesParameters(i).strAesParameterName & ":"
                lstCurrArguments.Add(clsCurrGeom.clsAesParameters(i).strAesParameterName)
                lstAesParameterUcr(i).Clear()
                If clsCurrGeom.clsAesParameters(i).bIsMandatory Then
                    lstAesParameterLabels(i).Font = New Font(lstAesParameterLabels(i).Font, FontStyle.Bold)
                Else
                    lstAesParameterLabels(i).Font = New Font(lstAesParameterLabels(i).Font, FontStyle.Regular)
                End If
                If clsCurrGeom.clsAesParameters(i).strIncludedDataTypes IsNot Nothing Then
                    lstAesParameterUcr(i).SetIncludedDataTypes(clsCurrGeom.clsAesParameters(i).strIncludedDataTypes)
                Else lstAesParameterUcr(i).RemoveIncludedMetadataProperty("class")
                End If
                If clsCurrGeom.clsAesParameters(i).strExcludedDataTypes IsNot Nothing Then
                    lstAesParameterUcr(i).SetExcludedDataTypes(clsCurrGeom.clsAesParameters(i).strExcludedDataTypes)
                Else lstAesParameterUcr(i).RemoveExcludedMetadataProperty("class")
                End If
            Next
        Else 'If the current geom has not been populated, then an error has been made in the code
            MsgBox("Developer Error: the current geom (clsCurrGeom) has not been populated before setting the aes parameters for the ucrGeomListWithAes on the sdgLayerOptions.", MsgBoxStyle.OkOnly)
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

    Private Sub ucrReceiverParam_WithMeSelectionChanged(ucrChangedReceiver As ucrReceiverSingle) Handles ucrReceiverParam1.WithMeSelectionChanged, ucrReceiverParam2.WithMeSelectionChanged, ucrReceiverParam3.WithMeSelectionChanged, ucrReceiverParam4.WithMeSelectionChanged, ucrReceiverParam5.WithMeSelectionChanged, ucrReceiverParam6.WithMeSelectionChanged, ucrReceiverParam7.WithMeSelectionChanged, ucrReceiverParam8.WithMeSelectionChanged, ucrReceiverParam9.WithMeSelectionChanged, ucrReceiverParam10.WithMeSelectionChanged, ucrReceiverParam11.WithMeSelectionChanged, ucrReceiverParam12.WithMeSelectionChanged, ucrReceiverParam13.WithMeSelectionChanged
        Dim iIndex As Integer
        'bApplyToLocalAes is used to avoid changing the content of clsGeomAesFunction when the receivers are setup according to the content of clsGeomAesFunction and clsGgplotAesFunction in SetAes().
        If bAddToLocalAes Then
            iIndex = lstAesParameterUcr.IndexOf(ucrChangedReceiver)
            If Not ucrChangedReceiver.IsEmpty Then
                clsGeomAesFunction.AddParameter(lstCurrArguments(iIndex), ucrChangedReceiver.GetVariableNames(False))
            ElseIf iIndex < lstCurrArguments.Count Then 'Warning/Task: got an error here. The iIndex was longer than lstCurrArguments when clicking on edit layer. Don't really understand how this is possible. Just added the reality check but might need to put more thoughts into this...
                clsGeomAesFunction.RemoveParameterByName(lstCurrArguments(iIndex))
            Else MsgBox("Developer Error: the iIndex (going through lstAesParameterUcr) in ucrReceiverParam_WithMeSelectionChanged is greater than lstAesParameterUcr.count. We beleive that this occurs when editting a layer with fewer aes parameters than there are filled aesthetics parameters in the GlobalAesthetics.", MsgBoxStyle.OkOnly)
            End If
        End If
    End Sub

    Public Function TestForOkEnabled() As Boolean
        Dim i As Integer = 0
        'Dim iNumberOfMissingDependentlyMandatoryAes As Integer = 0
        'Added a proposal for jointly mandatory situations. For the moment the only case is two jointly mandatory aes.Turns out to be not necessary for geom_point so not used for now.
        'If a mandatory aes or two jointly mandatory aes have empty mapping, then not ok, otherwise ok.
        For i = 0 To (clsCurrGeom.clsAesParameters.Count - 1)
            If (lstAesParameterUcr(i).IsEmpty()) AndAlso clsCurrGeom.clsAesParameters(i).bIsMandatory Then
                ' If clsCurrGeom.clsAesParameters(i).bIsMandatory Then
                Return False
                'ElseIf clsCurrGeom.clsAesParameters(i).bIsDependentlyMandatory Then
                'iNumberOfMissingDependentlyMandatoryAes = iNumberOfMissingDependentlyMandatoryAes + 1
                'End If
            End If
        Next
        'If iNumberOfMissingDependentlyMandatoryAes <= 1 Then
        Return True
        ' Else Return False
        ' End If
    End Function

    Private Sub chkChangeAes_CheckedChanged(sender As Object, e As EventArgs) Handles chkApplyOnAllLayers.CheckedChanged
        'Sets the dataframe to the globaldataframe and fixes it in case that one is not empty and chkApplyOnAllLayers is checked.
        'Question to be discussed: are we happy with this ? We don't want it to be the opposite, i.e. the global data frame to be changed when apply on all layers is ticked ? Would then need to "reset the global aes function"... See issue on github... All this should be revised when linking is studied.
        ucrGeomWithAesSelector.SetDataframe(strGlobalDataFrame, (Not chkApplyOnAllLayers.Checked) OrElse strGlobalDataFrame = "")
        'Warning: the dataframe needs to be set first. Indeed, this will enable IgnoreGlobalAes in the "datafram_changed" sub. In the same sub, Ignore global aes will be unticked and thus setAes called. If not done in this order, Ignore global aes is unticked below before the check box has been enabled and thus the event IngnoreGlobalAes.check.changed is not raised, and set aes never called.
        If chkApplyOnAllLayers.Checked Then
            chkIgnoreGlobalAes.Checked = False
            chkIgnoreGlobalAes.Hide()
        Else
            chkIgnoreGlobalAes.Show()
        End If
    End Sub

    Private Sub chkIgnoreGlobalAes_CheckedChanged(sender As Object, e As EventArgs) Handles chkIgnoreGlobalAes.CheckedChanged
        If chkIgnoreGlobalAes.Checked Then
            clsGeomFunction.AddParameter("inherit.aes", "FALSE")
        Else
            clsGeomFunction.RemoveParameterByName("inherit.aes")
        End If
        'When IgnoreGlobalAes is checked, we don't want the global aesthetics to appear in the receivers anymore.
        SetAes()
    End Sub

    Private Sub ucrGeomWithAesSelector_DataFrameChanged() Handles ucrGeomWithAesSelector.DataFrameChanged
        'Warning: When the dataframes in local layers don't correspond to the data in the global ggplot function, inherit.aes should be set to false unless variables have the same name in different dataframes...
        'Warning: in ggplot, one can work with data1 in the global ggplot function and data2 in some layer. If the parameter inherit.aes is not set to false, the mapping in ggplot function will be copied into the layer with different dataframe. Unless the variables used in data1 are also variables in data2, this will give an error and crash the software... 
        If LocalAndGlobalDataFramesAreDifferent() Then
            chkIgnoreGlobalAes.Checked = True

        Else
            'Task: add a warning message explaining the situation to the user when warning messages will have been implemented homogenuously through out the software...

            'chkIgnoreGlobalAes.Checked = False 'Warning, if IgnoreGlobalAes was checked before changing dataframe and coming back, then it will be unchecked now...
        End If
        'Note SetAes will be called automatically if chkIgnoreGlobalAes.checked has been changed.
    End Sub
End Class
