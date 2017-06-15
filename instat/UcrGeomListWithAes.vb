
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

Public Class ucrGeomListWithParameters
    Public lstAesParameterLabels As New List(Of Label)
    Public lstAesParameterReceivers As New List(Of ucrReceiverSingle)
    'The two previous fields are the lists of parameter labels and receivers on the ucr.
    Public lstCurrArguments As New List(Of String)
    'lstCurrArguments is the list of aes parameters names of the current geom (ucrGeom.clsCurrGeom), i.e. the list of parameter names of clsGeomAesFunction.
    Public bFirstLoad As Boolean = True
    Public ucrLayersControl As ucrLayerParameters
    Public Event DataFrameChanged()
    'clsGeomAesFunction stores the value (aes function) of the local mapping (of this particular layer). It is used as parameter in sdgLayerOptions.clsGeomFunction.
    Public bAddToLocalAes As Boolean = True
    ' Intermediate aes function which is the combination of the current global aes and the local aes.
    ' This is the function linked to the receivers with it updates and will update from
    ' This is needed to prevent real time changes to global or local aes because this can change e.g. when apply globally is checked
    ' When returning from this control, the intermediate aes with update the global and local aes appropriately
    Private clsInterAesFunction As New RFunction
    Private bControlsInitialised As Boolean = False
    Private bAllowShowGlobalAsLocal As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'Get the lists of parameter labels and receivers.
    End Sub

    Private Sub UcrGeomListWithParameters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            bFirstLoad = False
        End If
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
    End Sub

    Private Sub InitialiseControls()
        lstAesParameterLabels.AddRange({lblGgParam1, lblGgParam2, lblGgParam3, lblGgParam4, lblGgParam5, lblGgParam6, lblGgParam7, lblGgParam8, lblGgParam9, lblGgParam10, lblGgParam11, lblGgParam12, lblGgParam13})
        lstAesParameterReceivers.AddRange({ucrReceiverParam1, ucrReceiverParam2, ucrReceiverParam3, ucrReceiverParam4, ucrReceiverParam5, ucrReceiverParam6, ucrReceiverParam7, ucrReceiverParam8, ucrReceiverParam9, ucrReceiverParam10, ucrReceiverParam11, ucrReceiverParam12, ucrReceiverParam13})
        SetSelector()

        clsInterAesFunction.SetPackageName("ggplot2")
        clsInterAesFunction.SetRCommand("aes")

        ucrChkApplyOnAllLayers.SetText("Apply on All Layers")

        ucrChkIgnoreGlobalAes.SetText("Ignore Global Aesthetics")
        ucrChkIgnoreGlobalAes.SetParameter(New RParameter("inherit.aes"), bNewChangeParameterValue:=True, strNewValueIfChecked:="FALSE", strNewValueIfUnchecked:="TRUE")
        ucrChkIgnoreGlobalAes.SetRDefault("TRUE")
        bControlsInitialised = True
    End Sub

    Public Sub Reset()
        ucrGeomWithAesSelector.Reset()
    End Sub

    Private Sub SetSelector()
        'Link the selector and the receivers
        For Each ucrTempReceiver As ucrReceiver In lstAesParameterReceivers
            ucrTempReceiver.Selector = ucrGeomWithAesSelector
            ucrTempReceiver.SetParameterIsString()
            ucrTempReceiver.bWithQuotes = False
        Next
    End Sub

    Private Sub InitialiseSelectedDataFrame()
        'When setting up the ucrGeomListWithAes, we want the selected dataframe to be the one used in the clsGeomFunction that has been given through. This is also needed for the method in LocalAndGlobalDataFramesAreDifferent() to work when editing a layer.
        Dim strDataFrameName As String
        Dim iIndexOfData_nameParameter As Integer

        strDataFrameName = strGlobalDataFrame
        If clsGeomFunction.ContainsParameter("data") AndAlso clsGeomFunction.GetParameter("data").clsArgumentCodeStructure.clsParameters.FindIndex(Function(x) x.strArgumentName = "data_name") <> -1 Then
            iIndexOfData_nameParameter = clsGeomFunction.GetParameter("data").clsArgumentCodeStructure.clsParameters.FindIndex(Function(x) x.strArgumentName = "data_name")
            strDataFrameName = clsGeomFunction.GetParameter("data").clsArgumentCodeStructure.clsParameters(iIndexOfData_nameParameter).strArgumentValue
            strDataFrameName = strDataFrameName.Substring(1, strDataFrameName.Length - 2) 'The value of the parameter "data_name" has quotes around it that need to be erased as we merely want the name of the data_frame.
            ucrGeomWithAesSelector.SetDataframe(strDataFrameName)
        Else
            ucrGeomWithAesSelector.SetDataframe(strDataFrameName, (Not ucrChkApplyOnAllLayers.Checked) OrElse strGlobalDataFrame = "")
        End If
    End Sub

    Public Overrides Sub Setup(clsNewGgplotFunction As RFunction, clsNewGeomFunc As RFunction, clsNewGlobalAesFunc As RFunction, clsNewLocalAes As RFunction, Optional bFixGeom As Boolean = False, Optional ucrNewBaseSelector As ucrSelectorByDataFrame = Nothing, Optional bApplyAesGlobally As Boolean = True, Optional iNumVariablesForGeoms As Integer = -1, Optional bReset As Boolean = False, Optional strDataFrame As String = "")
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        bAllowShowGlobalAsLocal = False
        MyBase.Setup(clsNewGgplotFunction, clsNewGeomFunc, clsNewGlobalAesFunc, clsNewLocalAes, bFixGeom, ucrNewBaseSelector, bApplyAesGlobally, iNumVariablesForGeoms, bReset, strDataFrame)
        If ucrBaseSelector IsNot Nothing Then
            ucrGeomWithAesSelector.SetLinkedSelector(ucrBaseSelector)
            ucrGeomWithAesSelector.ucrAvailableDataFrames.clsCurrDataFrame = ucrBaseSelector.ucrAvailableDataFrames.clsCurrDataFrame
        End If
        'Using the values of the two relevant parameters, the two following lines determine whether the chkBoxes ApplyToAllLayers and IgnoreGlobalAes should be ticked. 
        'Introduced a safety net: these can't be ticked at the same time, in that case an error has been made in the code and a message is sent to the user.
        ucrChkApplyOnAllLayers.Checked = bApplyAesGlobally
        ucrChkIgnoreGlobalAes.SetRCode(clsGeomFunction, bReset)
        If ucrChkApplyOnAllLayers.Checked AndAlso ucrChkIgnoreGlobalAes.Checked Then
            MsgBox("Error: Cannot check both 'Apply On All Layers' and 'Ignore Global Aesthetics' as this will remove all aesthetics from this layer. Setting both values to checked.", vbOKOnly)
            ucrChkApplyOnAllLayers.Checked = False
            ucrChkIgnoreGlobalAes.Checked = False
        End If
        bAllowShowGlobalAsLocal = True

        ' This might stay as data frame depends on global/local option and therefore can't be linked to a function
        InitialiseSelectedDataFrame()

        SetParameters()
        'This is done last because it requires using correct value of ucrChkIgnoreGlobalAes.Checked
        SetInterAes(bReset, True)

        'Warning: SetAes is called three times when a layer is created... one in the load, one in the setup, one when geom is set, ... 
    End Sub

    Private Sub SetInterAes(Optional bReset As Boolean = False, Optional bClearInterAes As Boolean = False)
        Dim iFirstEmptyAes As Integer = -1
        Dim bAesFound As Boolean = False
        Dim bFirstEmptyFound As Boolean = False
        Dim strCurrGeomAesParamName As String

        If bClearInterAes Then
            clsInterAesFunction.ClearParameters()
        End If
        'Clear code so receivers don't update until intermediate function is set
        For i = 0 To clsCurrGeom.clsAesParameters.Count - 1
            bAesFound = False
            strCurrGeomAesParamName = clsCurrGeom.clsAesParameters(i).strAesParameterName
            'When IgnoreGlobalAes is not checked, we want the applicable global aesthetics to appear in the intermediate function.
            If Not ucrChkIgnoreGlobalAes.Checked Then
                'For some geoms e.g. geom_line, when an aes is not filled in (usually x or y), ggplot syntax requires the aes to be set to "" e.g. x = "". 
                'We do not need to copy this to the intermediate aes as they are affectively empty
                If Not clsInterAesFunction.ContainsParameter(strCurrGeomAesParamName) AndAlso clsGlobalAesFunction.ContainsParameter(strCurrGeomAesParamName) AndAlso Not clsGlobalAesFunction.GetParameter(strCurrGeomAesParamName).strArgumentValue = Chr(34) & Chr(34) Then
                    bAesFound = True
                    clsInterAesFunction.AddParameter(clsGlobalAesFunction.GetParameter(strCurrGeomAesParamName).Clone())
                End If
            End If

            If bClearInterAes Then
                If clsLocalAesFunction.ContainsParameter(strCurrGeomAesParamName) AndAlso Not clsLocalAesFunction.GetParameter(strCurrGeomAesParamName).strArgumentValue = Chr(34) & Chr(34) Then
                    bAesFound = True
                    clsInterAesFunction.AddParameter(clsLocalAesFunction.GetParameter(strCurrGeomAesParamName).Clone())
                End If

                If Not bFirstEmptyFound AndAlso Not bAesFound Then
                    iFirstEmptyAes = i
                    bFirstEmptyFound = True
                End If
            End If
        Next
        If iFirstEmptyAes <> -1 Then
            lstAesParameterReceivers(iFirstEmptyAes).SetMeAsReceiver()
        End If
        SetRCodeForReceivers(clsInterAesFunction, clsCurrGeom.clsAesParameters.Count, bReset)
    End Sub

    Public Sub SetParameters() 'this will set function or aes parameters
        Dim iMaxIndex As Integer
        Dim i As Integer
        Dim strParamName As String

        iMaxIndex = lstAesParameterLabels.Count
        'iMaxIndex will be set as the minimum between the number of aes parameters in the current geom and the number of aesthetics recievers on the dialog.
        'i is just an index variable for the loops.

        'Security check: our current geom has been populated.
        If clsCurrGeom IsNot Nothing Then
            'The following two will be reset as desired.
            lstCurrArguments.Clear()
            ClearReceiversCodeAndParameter()
            If (clsCurrGeom.clsAesParameters.Count < iMaxIndex) Then
                'If the number of aes parameters in the current geom is smaller than the number of receivers, then we hide the exceeding receivers and labels.
                iMaxIndex = clsCurrGeom.clsAesParameters.Count
                For i = iMaxIndex To (lstAesParameterLabels.Count - 1)
                    lstAesParameterLabels(i).Visible = False
                    lstAesParameterReceivers(i).Visible = False
                Next
            ElseIf (clsCurrGeom.clsAesParameters.Count > iMaxIndex) Then
                'If the number of parameters in the current geom is greater than the number of receivers, then there is an error.
                MsgBox("Developer Error, the number of aesthetics parameters of the current geom exceeds the number of aesthetic receivers in ucrGeomListWithAes, on the sdgLayerOptions. The exceding parameters will be ignored.", MsgBoxStyle.OkOnly)
            End If

            'In any case, we show all the receivers that have index lower than the iMaxIndex, and we populate the labels with the appropriate names.
            For i = 0 To (iMaxIndex - 1)
                strParamName = clsCurrGeom.clsAesParameters(i).strAesParameterName
                lstAesParameterLabels(i).Visible = True
                lstAesParameterReceivers(i).Visible = True

                lstAesParameterLabels(i).Text = strParamName & ":"
                lstAesParameterReceivers(i).SetParameter(New RParameter(strParamName))
                If clsCurrGeom.clsAesParameters(i).bIsMandatory Then
                    lstAesParameterLabels(i).Font = New Font(lstAesParameterLabels(i).Font, FontStyle.Bold)
                Else
                    lstAesParameterLabels(i).Font = New Font(lstAesParameterLabels(i).Font, FontStyle.Regular)
                End If
                If clsCurrGeom.clsAesParameters(i).strIncludedDataTypes IsNot Nothing Then
                    lstAesParameterReceivers(i).SetIncludedDataTypes(clsCurrGeom.clsAesParameters(i).strIncludedDataTypes)
                Else
                    lstAesParameterReceivers(i).RemoveIncludedMetadataProperty("class")
                End If
                If clsCurrGeom.clsAesParameters(i).strExcludedDataTypes IsNot Nothing Then
                    lstAesParameterReceivers(i).SetExcludedDataTypes(clsCurrGeom.clsAesParameters(i).strExcludedDataTypes)
                Else
                    lstAesParameterReceivers(i).RemoveExcludedMetadataProperty("class")
                End If
            Next
        Else 'If the current geom has not been populated, then an error has been made in the code
            MsgBox("Developer Error: the current geom (clsCurrGeom) has not been populated before setting the aes parameters for the ucrGeomListWithAes on the sdgLayerOptions.", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Public Sub UcrGeomListWithParameters_cboGeomListIndexChanged() Handles Me.GeomChanged
        If ucrLayersControl IsNot Nothing Then
            ucrLayersControl.SetGeomName(GetGeomName())
        End If
        SetParameters()
        SetInterAes()
    End Sub

    Public Function TestForOkEnabled() As Boolean
        Dim i As Integer = 0
        'Dim iNumberOfMissingDependentlyMandatoryAes As Integer = 0
        'Added a proposal for jointly mandatory situations. For the moment the only case is two jointly mandatory aes.Turns out to be not necessary for geom_point so not used for now.
        'If a mandatory aes or two jointly mandatory aes have empty mapping, then not ok, otherwise ok.
        For i = 0 To (clsCurrGeom.clsAesParameters.Count - 1)
            If (lstAesParameterReceivers(i).IsEmpty()) AndAlso clsCurrGeom.clsAesParameters(i).bIsMandatory Then
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

    Private Sub ucrGeomWithAesSelector_DataFrameChanged() Handles ucrGeomWithAesSelector.DataFrameChanged
        'Warning: When the dataframes in local layers don't correspond to the data in the global ggplot function, inherit.aes should be set to false unless variables have the same name in different dataframes...
        'Warning: in ggplot, one can work with data1 in the global ggplot function and data2 in some layer. If the parameter inherit.aes is not set to false, the mapping in ggplot function will be copied into the layer with different dataframe. Unless the variables used in data1 are also variables in data2, this will give an error and crash the software... 

        'Probably don't need. Could want global aes for different data frames if column names are the same
        'If LocalAndGlobalDataFramesAreDifferent() Then
        'chkIgnoreGlobalAes.Checked = True

        'Else
        'Task: add a warning message explaining the situation to the user when warning messages will have been implemented homogenuously through out the software...

        'chkIgnoreGlobalAes.Checked = False 'Warning, if IgnoreGlobalAes was checked before changing dataframe and coming back, then it will be unchecked now...
        'End If
        'Note SetAes will be called automatically if chkIgnoreGlobalAes.checked has been changed.
    End Sub

    Public Sub ClearReceiversCodeAndParameter()
        For Each ucrTempReceiver As ucrReceiverSingle In lstAesParameterReceivers
            ucrTempReceiver.ClearCodeAndParameters()
            ucrTempReceiver.Clear()
        Next
    End Sub

    Public Sub SetRCodeForReceivers(clsNewRCode As RCodeStructure, iParameterCount As Integer, Optional bReset As Boolean = False)
        For i As Integer = 0 To iParameterCount - 1
            lstAesParameterReceivers(i).SetRCode(clsNewRCode, bReset)
        Next
    End Sub

    Private Sub ucrChkIgnoreGlobalAes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIgnoreGlobalAes.ControlValueChanged
        SetInterAes(False, False)
        'Sets the dataframe to the globaldataframe and fixes it in case that one is not empty and chkApplyOnAllLayers is checked.
        'Question to be discussed: are we happy with this ? We don't want it to be the opposite, i.e. the global data frame to be changed when apply on all layers is ticked ? Would then need to "reset the global aes function"... See issue on github... All this should be revised when linking is studied.
        ucrGeomWithAesSelector.SetDataframe(strGlobalDataFrame, (Not ucrChkApplyOnAllLayers.Checked) OrElse strGlobalDataFrame = "")
        'Warning: the dataframe needs to be set first. Indeed, this will enable IgnoreGlobalAes in the "datafram_changed" sub. In the same sub, Ignore global aes will be unticked and thus setAes called. If not done in this order, Ignore global aes is unticked below before the check box has been enabled and thus the event IngnoreGlobalAes.check.changed is not raised, and set aes never called.
        If ucrChkApplyOnAllLayers.Checked Then
            ucrChkIgnoreGlobalAes.Checked = False
            ucrChkIgnoreGlobalAes.Hide()
        Else
            ucrChkIgnoreGlobalAes.Show()
        End If
        SetReceiverColour()
    End Sub

    Public Sub UpdateGlobalAndLocalAesFromInter()
        Dim clsRelevantAesFunction As New RFunction 'Will be used in the partially mandatory aes filling method below.
        Dim clsCurrentAesFunction As RFunction

        'Two situations: apply on all layers checked or not. Would edit the global or local aes accordingly. 
        If ucrChkApplyOnAllLayers.Checked Then
            'If ucrChkApplyOnAllLayers is checked, inter aes become the global aes.
            For Each clsAesParam As AesParameters In clsCurrGeom.clsAesParameters
                If clsInterAesFunction.ContainsParameter(clsAesParam.strAesParameterName) Then
                    clsGlobalAesFunction.AddParameter(clsInterAesFunction.GetParameter(clsAesParam.strAesParameterName).Clone())
                Else
                    clsGlobalAesFunction.RemoveParameterByName(clsAesParam.strAesParameterName)
                End If
            Next
            'We need to remove local "mapping" and "data" parameters.
            clsGeomFunction.RemoveParameterByName("mapping")
            clsGeomFunction.RemoveParameterByName("data")

            'Here the global ggplot function takes the relevant "mapping" and "data" parameters as required by "ApplyOnAllLayers".
            clsGgplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsGlobalAesFunction, iPosition:=1)
            clsGgplotFunction.AddParameter("data", clsRFunctionParameter:=ucrGeomWithAesSelector.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

            strGlobalDataFrame = ucrGeomWithAesSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text
            clsCurrentAesFunction = clsGlobalAesFunction
        Else 'Warning: in case the sdgLayerOptions has been called by specific dlg, need to refill the aes on that dlg. Imagine the ApplyOnAllLayers has been unticked ? Problem... Also in order to solve this, would need to know on the specific dialog if it has been unticked or not in order to know how to fill in the aes receivers ! The linking will be restudied anyway. There are many ways to go, see discussion on github.
            For Each clsAesParam As AesParameters In clsCurrGeom.clsAesParameters
                If clsInterAesFunction.ContainsParameter(clsAesParam.strAesParameterName) AndAlso (ucrChkIgnoreGlobalAes.Checked OrElse Not (clsGlobalAesFunction.ContainsParameter(clsAesParam.strAesParameterName) AndAlso clsGlobalAesFunction.GetParameter(clsAesParam.strAesParameterName).strArgumentValue = clsInterAesFunction.GetParameter(clsAesParam.strAesParameterName).strArgumentValue)) Then
                    clsLocalAesFunction.AddParameter(clsInterAesFunction.GetParameter(clsAesParam.strAesParameterName).Clone())
                Else
                    clsLocalAesFunction.RemoveParameterByName(clsAesParam.strAesParameterName)
                End If
            Next

            'If global data frame later changes, data parameter is needed in each geom?
            If ucrGeomWithAesSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> strGlobalDataFrame Then
                clsGeomFunction.AddParameter("data", clsRFunctionParameter:=ucrGeomWithAesSelector.ucrAvailableDataFrames.clsCurrDataFrame.Clone(), iPosition:=1)
            Else
                clsGeomFunction.RemoveParameterByName("data")
            End If
            clsCurrentAesFunction = clsLocalAesFunction
        End If

        'This is a temporary solution to issue which should be solved with geoms
        'This adds "" aes for x or y when no variables are mapped to them for geoms which require it, either adding to the global or local aes.
        If clsGeomFunction.strRCommand = "geom_boxplot" OrElse clsGeomFunction.strRCommand = "geom_dotplot" Then
            If (clsGlobalAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "x") = -1 OrElse ucrChkIgnoreGlobalAes.Checked) AndAlso clsLocalAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "x") = -1 Then
                clsCurrentAesFunction.AddParameter("x", Chr(34) & Chr(34))
            End If
        ElseIf clsGeomFunction.strRCommand = "geom_point" OrElse clsGeomFunction.strRCommand = "geom_line" Then
            If (clsGlobalAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "x") = -1 OrElse ucrChkIgnoreGlobalAes.Checked) AndAlso clsLocalAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "x") = -1 Then
                clsCurrentAesFunction.AddParameter("x", Chr(34) & Chr(34))
            End If
            If (clsGlobalAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "y") = -1 OrElse ucrChkIgnoreGlobalAes.Checked) AndAlso clsLocalAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "y") = -1 Then
                clsCurrentAesFunction.AddParameter("y", Chr(34) & Chr(34))
            End If
        End If
        'Adding stat = identity method 
        If {"geom_bar", "geom_density", "geom_freqpoly"}.Contains(clsGeomFunction.strRCommand) Then
            'If there is a y in the global aes, and the global aes are not ignored or if there is a y in the local aes then in case stat has not been set manually, stat is set to identity.
            If (((clsGlobalAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "y") <> -1) AndAlso ((clsGeomFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "inherit.aes") = -1) OrElse (Not ucrChkIgnoreGlobalAes.Checked))) OrElse (clsLocalAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "y") <> -1)) AndAlso (clsGeomFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "stat") = -1) Then
                clsGeomFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34))
                'Task: send a message to the user saying that stat = identity has been added as a parameter in order to avoid error. Can be modified on the LayerParameter tab.
                'In case the "y" mapping has been removed after editing the layer, the added "stat" parameter should probably be removed so it is important for the user to know it has been added in automatically, in case he wants to go to the layer parameters tab and remove it.
            End If
        End If

        'Done after because aes may be added in from above
        If Not ucrChkApplyOnAllLayers.Checked AndAlso clsLocalAesFunction.iParameterCount > 0 Then
            clsGeomFunction.AddParameter("mapping", clsRFunctionParameter:=clsLocalAesFunction.Clone(), iPosition:=0)
        Else
            clsGeomFunction.RemoveParameterByName("mapping")
        End If
    End Sub

    Private Function ContainsGlobalAes(ucrCurrReceiver As ucrReceiverSingle)
        Dim strParamName

        strParamName = ucrCurrReceiver.GetParameterName()
        If Not ucrChkIgnoreGlobalAes.Checked AndAlso clsGlobalAesFunction.ContainsParameter(strParamName) AndAlso clsGlobalAesFunction.GetParameter(strParamName).strArgumentValue = ucrCurrReceiver.GetVariableNames(False) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Receivers_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverParam1.ControlValueChanged, ucrReceiverParam2.ControlValueChanged, ucrReceiverParam3.ControlValueChanged, ucrReceiverParam4.ControlValueChanged, ucrReceiverParam5.ControlValueChanged, ucrReceiverParam6.ControlValueChanged, ucrReceiverParam7.ControlValueChanged, ucrReceiverParam8.ControlValueChanged, ucrReceiverParam9.ControlValueChanged, ucrReceiverParam10.ControlValueChanged, ucrReceiverParam11.ControlValueChanged, ucrReceiverParam12.ControlValueChanged, ucrReceiverParam13.ControlValueChanged
        Dim ucrChangedReceiver As ucrReceiverSingle

        ucrChangedReceiver = TryCast(ucrChangedControl, ucrReceiverSingle)
        If ucrChangedReceiver IsNot Nothing Then
            SetReceiverColour(ucrChangedReceiver)
        End If
    End Sub

    Private Sub SetReceiverColour(Optional ucrCurrReceiver As ucrReceiverSingle = Nothing)
        If ucrCurrReceiver IsNot Nothing Then
            If ContainsGlobalAes(ucrCurrReceiver) Then
                'Should define these globally as options
                ucrCurrReceiver.SetTextColour(Color.Blue)
            Else
                ucrCurrReceiver.SetTextColour(Color.Black)
            End If
        Else
            For Each ucrTempReceiver In lstAesParameterReceivers
                SetReceiverColour(ucrTempReceiver)
            Next
        End If
    End Sub
End Class
