' R- Instat
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

Imports instat
Imports instat.Translations
Imports RDotNet

Public Class ucrReceiver
    Public WithEvents ucrSelector As ucrSelector
    Public lstIncludedMetadataProperties As List(Of KeyValuePair(Of String, String()))
    Public lstExcludedMetadataProperties As List(Of KeyValuePair(Of String, String()))
    Public bFirstLoad As Boolean
    Public bFirstShown As Boolean
    Public strSelectorHeading As String
    Public bUseFilteredData As Boolean = True
    Public bDropUnusedFilterLevels As Boolean = False
    Public bTypeSet As Boolean
    Protected strType As String
    Public bExcludeFromSelector As Boolean = False
    Public Event SelectionChanged(sender As Object, e As EventArgs)
    Public WithEvents frmParent As Form
    Public bRemoveLabels As Boolean = False

    Public strDatabaseQuery As String = ""

    Private strPrvNcFilePath As String = ""

    'Should the receiver attempt to autofill items based on lstIncludedAutoFillProperties?
    Public bAutoFill As Boolean = False
    Public lstIncludedAutoFillProperties As Dictionary(Of String, String())

    Public bAddParameterIfEmpty As Boolean = False
    'If the control is used to set a parameter that is a string i.e. column = "ID"
    Protected bParameterIsString As Boolean = False
    'If the control is used to set a parameter that is an RFunction i.e. x = InstatDataObject$get_columns_from_data()
    Protected bParameterIsRFunction As Boolean = False
    'The name of the parameter which contains the items in the get instat object method (depends on the type of items in the receiver)
    Protected strItemsParameterNameInRFunction As String = "col_names"

    'Name of the data name parameter in the get instat object method (depends on the type of items in the receiver)
    Protected strDataFrameParameterNameInRFunction As String = "data_name"

    'Should quotes be used when bParameterIsString = False
    Public bWithQuotes As Boolean = True

    'Should columns be forced as a data frame object when bParameterIsRFunction = True
    Public bForceAsDataFrame As Boolean = False

    ' If True then this receiver can only contain a column from the selector's primary data frame
    ' and this receiver can set the selector's primary data frame (when current receiver), resetting all other receivers
    Public bAttachedToPrimaryDataFrame As Boolean = True

    ' If not attached to primary data frame, should only data frames linked to the primary data frame be shown.
    Public bOnlyLinkedToPrimaryDataFrames As Boolean = True

    ' When calling GetVariableNames() this is the R package & function name the variables will be inside
    ' Only currently used in Multiple receiver but defined here as needed in general method SetControlValue()
    ' for ExtractItemsFromRList()
    Protected strVariablesListPackageName As String = ""
    Protected strVariablesListFunctionName As String = "c"
    ' Set to True if GetVariableNames() should always return an R list (using function above)
    ' Even when only one variable.
    ' Currently only implemented for multiple receiver.
    Public bForceVariablesAsList As Boolean = False

    'used by the selector to autoswitch from the current receiver
    Public bAutoSwitchFromReceiver As Boolean = False


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lstIncludedMetadataProperties = New List(Of KeyValuePair(Of String, String()))
        lstExcludedMetadataProperties = New List(Of KeyValuePair(Of String, String()))
        bFirstLoad = True
        lstIncludedAutoFillProperties = New Dictionary(Of String, String())
        bFirstShown = True
        bTypeSet = False
        strSelectorHeading = "Variables"
        strType = "column"
        bUpdateRCodeFromControl = True
    End Sub

    Public Overridable Sub AddSelected()

    End Sub

    Public Overridable Sub RemoveSelected()
        If IsCurrentReceiver() Then
            Selector.LoadList()
        End If
    End Sub

    Private Function IsCurrentReceiver() As Boolean
        Return Selector IsNot Nothing AndAlso Selector.CurrentReceiver IsNot Nothing AndAlso Selector.CurrentReceiver.Equals(Me)
    End Function

    Public Overridable Sub Remove(strItems As String())

    End Sub

    Public Overridable Sub Clear()

    End Sub

    Public Overridable Function IsEmpty() As Boolean
        Return True
    End Function

    Public Overridable Sub SetColor()

    End Sub

    Public Overridable Sub RemoveColor()

    End Sub

    Public Property strNcFilePath As String
        Get
            Return strPrvNcFilePath
        End Get
        Set(strFilePath As String)
            strPrvNcFilePath = strFilePath
            If IsCurrentReceiver() Then
                Selector.LoadList()
            End If
        End Set
    End Property

    Public Overridable Function GetVariables(Optional bForceAsDataFrame As Boolean = False) As RFunction
        Dim clsGetVariablesFunc As New RFunction
        Return clsGetVariablesFunc
    End Function

    Public Overridable Function GetVariableNames(Optional bWithQuotes As Boolean = True) As String
        Dim strVarNames As String = ""
        Return strVarNames
    End Function

    Public Overridable Function GetVariableNamesList(Optional bWithQuotes As Boolean = True, Optional strQuotes As String = Chr(34)) As String()
        Dim strVarNames As String() = Nothing
        Return strVarNames
    End Function

    Public Overridable Sub SetMeAsReceiver()
        If Selector IsNot Nothing Then
            Selector.SetCurrentReceiver(Me)
        End If
    End Sub

    Private Sub ucrReceiver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        translateEach(Controls, Me)
        If bFirstLoad Then
            frmParent = ParentForm
            'Remove this line so that single/multiple code can run things on first load as well
            'We never have a receiver not as a single or multiple
            'bFirstLoad = False
        End If
    End Sub

    'TODO make this function available throughout project
    Public Function GetListAsRString(lstStrings As List(Of String), Optional bWithQuotes As Boolean = True) As String
        Dim strTemp As String = ""
        Dim i As Integer
        If lstStrings.Count = 1 Then
            If bWithQuotes Then
                strTemp = Chr(34) & lstStrings.Item(0) & Chr(34)
            Else
                strTemp = lstStrings.Item(0)
            End If
        ElseIf lstStrings.Count > 1 Then
            strTemp = "c" & "("
            For i = 0 To lstStrings.Count - 1
                If i > 0 Then
                    strTemp = strTemp & ","
                End If
                If lstStrings.Item(i) <> "" Then
                    If bWithQuotes Then
                        strTemp = strTemp & Chr(34) & lstStrings.Item(i) & Chr(34)
                    Else
                        strTemp = strTemp & lstStrings.Item(i)
                    End If
                End If
            Next
            strTemp = strTemp & ")"
        End If
        Return strTemp
    End Function

    Private Sub ucrReceiver_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        SetMeAsReceiver()
    End Sub

    Public Event ValueChanged(ByVal sender As Object, ByVal e As EventArgs)

    Public Sub OnValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        RaiseEvent ValueChanged(sender, e)
        OnControlContentsChanged()
        OnControlValueChanged()
    End Sub

    ' If bStrict = True then only columns of the type specific will be included
    ' If bStict = False then a less strict condition will be made for which columns are included, depending on the type
    ' as specified below.
    ' SetDataType("numeric", False) will exclude factor and character columns (so numeric, logical, Date etc. will be included)
    ' SetDataType("factor", False) will include factor and logical columns
    Public Sub SetDataType(strTemp As String, Optional bStrict As Boolean = False)
        If Not bStrict Then
            If strTemp = "numeric" Then
                AddExcludedMetadataProperty("class", {Chr(34) & "factor" & Chr(34), Chr(34) & "character" & Chr(34)})
            ElseIf strTemp = "factor" Then
                AddIncludedMetadataProperty("class", {Chr(34) & "factor" & Chr(34), Chr(34) & "logical" & Chr(34)})
            Else
                AddIncludedMetadataProperty("class", {Chr(34) & strTemp & Chr(34)})
            End If
        Else
            AddIncludedMetadataProperty("class", {Chr(34) & strTemp & Chr(34)})
        End If
    End Sub

    'bStrict used as described in SetDataType.
    'Currently only checks if strInclude has exactly one item.
    Public Overridable Sub SetIncludedDataTypes(strInclude As String(), Optional bStrict As Boolean = False)
        Dim strTypes(strInclude.Count - 1) As String

        Array.Copy(strInclude, strTypes, strInclude.Length)
        'If the two previous lines where not added, the modification of value performed on strTypes was immediately performed on strInclude, then the argument passed into the function such as clsCurrGeom.clsAesParameters(i).strIncludedDataTypes in ucrGeomListWithAes.SetParameters would have been edited (i.e. quotes would have been added to the types names in the strIncludedDataTypes of the i'th AesParameter of the current Geom...), which we don't want !

        For i = 0 To strInclude.Count - 1
            strTypes(i) = Chr(34) & strInclude(i) & Chr(34)
        Next
        If Not bStrict Then
            If strTypes.Count = 1 Then
                If strTypes(0) = Chr(34) & "numeric" & Chr(34) Then
                    AddExcludedMetadataProperty("class", {Chr(34) & "factor" & Chr(34), Chr(34) & "character" & Chr(34)})
                ElseIf strTypes(0) = Chr(34) & "factor" & Chr(34) Then
                    AddIncludedMetadataProperty("class", {Chr(34) & "factor" & Chr(34), Chr(34) & "logical" & Chr(34)})
                Else
                    AddIncludedMetadataProperty("class", strTypes)
                End If
            Else
                AddIncludedMetadataProperty("class", strTypes)
            End If
        Else
            AddIncludedMetadataProperty("class", strTypes)
        End If
    End Sub

    Public Overridable Sub SetExcludedDataTypes(strExclude As String())
        Dim strTypes(strExclude.Count - 1) As String

        Array.Copy(strExclude, strTypes, strExclude.Length)
        'If the two previous lines where not added, the modification of value performed on strTypes was immediately performed on strInclude, then the argument passed into the function such as clsCurrGeom.clsAesParameters(i).strExcludedDataTypes in ucrGeomListWithAes.SetParameters would have been edited (i.e. quotes would have been added to the types names in the strExcludedDataTypes of the i'th AesParameter of the current Geom...), which we don't want !
        For i = 0 To strExclude.Count - 1
            strTypes(i) = Chr(34) & strTypes(i) & Chr(34)
        Next
        AddExcludedMetadataProperty("class", strTypes)
    End Sub

    Public Sub AddIncludedMetadataProperty(strProperty As String, strInclude As String())
        Dim iIncludeIndex As Integer
        'Dim iExcludeIndex As Integer
        Dim kvpIncludeProperty As KeyValuePair(Of String, String())
        If strProperty = "class" AndAlso strInclude.Contains(Chr(34) & "factor" & Chr(34)) Then
            Array.Resize(strInclude, strInclude.Length + 1)
            ' WARNING: This is dependent on the way the metadata is displayed by the Instat object
            ' If this changes in Instat object, ordered factors will not be displayed
            ' TODO: Make this solid - should somehow use is.factor() in R
            strInclude(strInclude.Length - 1) = Chr(34) & "ordered,factor" & Chr(34)
        End If
        kvpIncludeProperty = New KeyValuePair(Of String, String())(strProperty, strInclude)
        iIncludeIndex = lstIncludedMetadataProperties.FindIndex(Function(x) x.Key = strProperty)
        If iIncludeIndex <> -1 Then
            lstIncludedMetadataProperties(iIncludeIndex) = kvpIncludeProperty
        Else
            lstIncludedMetadataProperties.Add(kvpIncludeProperty)
        End If

        'Removes from other list
        'iExcludeIndex = lstExcludedMetadataProperties.FindIndex(Function(x) x.Key = strProperty)
        'If iExcludeIndex <> -1 Then
        '    lstExcludedMetadataProperties.RemoveAt(iExcludeIndex)
        'End If

        If IsCurrentReceiver() Then
            Selector.LoadList()
        End If

    End Sub

    Public Sub RemoveIncludedMetadataProperty(strProperty As String)
        Dim iIncludeIndex As Integer

        iIncludeIndex = lstIncludedMetadataProperties.FindIndex(Function(x) x.Key = strProperty)
        If iIncludeIndex <> -1 Then
            lstIncludedMetadataProperties.RemoveAt(iIncludeIndex)
        End If
        If IsCurrentReceiver() Then
            Selector.LoadList()
        End If

    End Sub

    Public Sub RemoveExcludedMetadataProperty(strProperty As String)
        Dim iIncludeIndex As Integer

        iIncludeIndex = lstExcludedMetadataProperties.FindIndex(Function(x) x.Key = strProperty)
        If iIncludeIndex <> -1 Then
            lstExcludedMetadataProperties.RemoveAt(iIncludeIndex)
        End If
        If IsCurrentReceiver() Then
            Selector.LoadList()
        End If
    End Sub
    Public Sub AddExcludedMetadataProperty(strProperty As String, strExclude As String())
        'Dim iIncludeIndex As Integer
        Dim iExcludeIndex As Integer

        Dim kvpExcludeProperty As KeyValuePair(Of String, String())
        If strProperty = "class" AndAlso strExclude.Contains(Chr(34) & "factor" & Chr(34)) Then
            Array.Resize(strExclude, strExclude.Length + 1)
            ' WARNING: This is dependent on the way the metadata is displayed by the Instat object
            ' If this changes in Instat object, ordered factors will not be displayed
            ' TODO: Make this solid - should somehow use is.factor() in R
            strExclude(strExclude.Length - 1) = Chr(34) & "ordered,factor" & Chr(34)
        End If
        kvpExcludeProperty = New KeyValuePair(Of String, String())(strProperty, strExclude)
        iExcludeIndex = lstExcludedMetadataProperties.FindIndex(Function(x) x.Key = strProperty)
        If iExcludeIndex <> -1 Then
            lstExcludedMetadataProperties(iExcludeIndex) = kvpExcludeProperty
        Else
            lstExcludedMetadataProperties.Add(kvpExcludeProperty)
        End If

        'Removes from other list
        'iIncludeIndex = lstIncludedMetadataProperties.FindIndex(Function(x) x.Key = strProperty)
        'If iIncludeIndex <> -1 Then
        '    lstIncludedMetadataProperties.RemoveAt(iIncludeIndex)
        'End If

        If IsCurrentReceiver() Then
            Selector.LoadList()
        End If
    End Sub

    'TODO if needed create SetExcludedAutoFillProperties
    Public Sub SetIncludedAutoFillProperties(lstNewIncludedAutoFillProperties As Dictionary(Of String, String()))
        lstIncludedAutoFillProperties = lstNewIncludedAutoFillProperties
    End Sub

    Protected Overridable Sub Selector_ResetAll() Handles ucrSelector.ResetReceivers
        Clear()
        CheckAutoFill()
    End Sub

    Private Sub ucrSelector_DataFrameChanged() Handles ucrSelector.DataFrameChanged
        'TODO This is possibly an expensive check, there may be more efficient ways of checking if this is the current receiver
        If ucrSelector IsNot Nothing AndAlso ucrSelector.CurrentReceiver IsNot Nothing AndAlso (ucrSelector.CurrentReceiver.bAttachedToPrimaryDataFrame OrElse ucrSelector.CurrentReceiver.Equals(Me)) Then
            Selector_ResetAll()
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Shift + Keys.Tab) Then
            Selector.Focus()
            Return True
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If
    End Function

    Public Function GetItemType() As String
        Return strType
    End Function

    Public Sub SetItemType(strNewType As String)
        strType = strNewType
        Select Case strType
            Case "column"
                strItemsParameterNameInRFunction = "col_names"
            Case "dataframe"
                strItemsParameterNameInRFunction = "data_name"
            Case "metadata"
                'TODO what should this be?
                strItemsParameterNameInRFunction = ""
            Case "graph"
                strItemsParameterNameInRFunction = "graph_name"
            Case "model"
                strItemsParameterNameInRFunction = "model_name"
            Case "surv"
                strItemsParameterNameInRFunction = "surv_name"
            Case "table"
                strItemsParameterNameInRFunction = "table_name"
            Case "filter"
                strItemsParameterNameInRFunction = "filter_name"
            Case "link"
                strItemsParameterNameInRFunction = "link_name"
            Case "object"
                strItemsParameterNameInRFunction = "object_name"
            Case "calculation"
                strItemsParameterNameInRFunction = "calculation_name"
        End Select
        If IsCurrentReceiver() Then
            Selector.LoadList()
        End If
        bTypeSet = True
    End Sub

    Public Overridable Sub Add(strItem As String, Optional strDataFrame As String = "", Optional bFixReceiver As Boolean = False)
        'SetMeAsReceiver()
        'For i = 0 To Selector.lstAvailableVariable.Items.Count - 1
        '    If Selector.lstAvailableVariable.Items(i).Text = strItem Then
        '        Selector.lstAvailableVariable.SelectedItems.Clear()
        '        Selector.lstAvailableVariable.Items(i).Selected = True
        '        AddSelected()
        '        Selector.lstAvailableVariable.SelectedItems.Clear()
        '        Exit For
        '    End If
        'Next
    End Sub

    Public Sub OnSelectionChanged()
        Dim sender As New Object
        Dim e As New EventArgs
        RaiseEvent SelectionChanged(sender, e)
        OnControlValueChanged()
    End Sub

    Protected Overrides Sub SetControlValue()
        Dim clsTempDataParameter As RParameter
        Dim lstCurrentVariables As String() = Nothing
        Dim clsTempParameter As RParameter
        Dim strTempDataName As String = ""

        clsTempParameter = GetParameter()
        If clsTempParameter IsNot Nothing Then
            If bChangeParameterValue Then
                If bParameterIsString AndAlso clsTempParameter.bIsString Then
                    If strValuesToIgnore Is Nothing OrElse (Not strValuesToIgnore.Contains(clsTempParameter.strArgumentValue)) Then
                        lstCurrentVariables = ExtractItemsFromRList(clsTempParameter.strArgumentValue, strPackageName:=strVariablesListPackageName, strFunctionName:=strVariablesListFunctionName)
                    End If
                    'TODO how to recover the data frame name in this case
                ElseIf bParameterIsRFunction AndAlso clsTempParameter.bIsFunction Then
                    clsTempDataParameter = clsTempParameter.clsArgumentCodeStructure.GetParameter(strItemsParameterNameInRFunction)
                    If clsTempDataParameter IsNot Nothing Then
                        lstCurrentVariables = ExtractItemsFromRList(clsTempParameter.clsArgumentCodeStructure.GetParameter(strItemsParameterNameInRFunction).strArgumentValue, strPackageName:="", strFunctionName:="c")
                    End If
                    'TODO Should this the same for other item types?
                    If strType = "column" Then
                        clsTempDataParameter = clsTempParameter.clsArgumentCodeStructure.GetParameter(strDataFrameParameterNameInRFunction)
                        If clsTempDataParameter IsNot Nothing Then
                            strTempDataName = clsTempParameter.clsArgumentCodeStructure.GetParameter(strDataFrameParameterNameInRFunction).strArgumentValue.Trim(Chr(34))
                        End If
                    End If
                End If
                Clear()
                If lstCurrentVariables IsNot Nothing Then
                    For Each strTemp As String In lstCurrentVariables
                        'TODO This only works if the selector is updated before receivers and dialog only uses one data frame!
                        '     Needs to change eventually.
                        If Selector IsNot Nothing AndAlso strTemp <> "" Then
                            If strTempDataName = "" Then
                                strTempDataName = Selector.strCurrentDataFrame
                            End If
                            Add(strTemp, strTempDataName)
                        End If
                    Next
                End If
            End If
        End If
    End Sub

    Public Overrides Sub UpdateParameter(clsTempParam As RParameter)
        If clsTempParam Is Nothing Then
            clsTempParam = New RParameter
        End If
        'Could need bParameterIsString and bParameterIsRFunction to be properties of RParameter if two functions need string/function
        If bParameterIsString Then
            'TODO this currently only works with one value to ignore. Also may need option not to set parameter value to strValuesToIgnore
            '     although this currently can be done with bAddParameterIfEmpty = True
            If IsEmpty() AndAlso strValuesToIgnore IsNot Nothing AndAlso strValuesToIgnore.Count = 1 Then
                clsTempParam.SetArgumentValue(strValuesToIgnore(0))
            Else
                clsTempParam.SetArgumentValue(GetVariableNames(bWithQuotes))
            End If
        ElseIf bParameterIsRFunction Then
            clsTempParam.SetArgument(GetVariables(bForceAsDataFrame))
        End If
    End Sub

    Public Overridable Sub SetParameterIsString()
        bParameterIsString = True
        bParameterIsRFunction = False
        UpdateAllParameters()
    End Sub

    Public Overridable Sub SetParameterIsRFunction()
        bParameterIsRFunction = True
        bParameterIsString = False
        UpdateAllParameters()
    End Sub

    Public Overrides Function IsRDefault() As Boolean
        If bAddParameterIfEmpty Then
            Return False
        Else
            Return IsEmpty()
        End If
    End Function

    Public Sub SetClimaticType(strTemp As String)
        Dim dctTemp As New Dictionary(Of String, String())

        ' "element" is a special case since it is a different metadata property.
        If strTemp = "element" Then
            dctTemp.Add("Is_Element", {"TRUE"})
            SetIncludedAutoFillProperties(dctTemp)
        Else
            SetClimaticType({strTemp})
        End If
    End Sub

    Public Sub SetClimaticType(enumTypes As IEnumerable(Of String))
        Dim dctTemp As New Dictionary(Of String, String())
        Dim arrTypes() As String = enumTypes.ToArray

        For i As Integer = 0 To arrTypes.Count - 1
            arrTypes(i) = Chr(34) & arrTypes(i) & Chr(34)
        Next
        dctTemp.Add("Climatic_Type", arrTypes)
        SetIncludedAutoFillProperties(dctTemp)
    End Sub

    Public Sub SetOptionsByContextType(strSingleType As String, Optional strQuotes As String = Chr(34))
        AddIncludedMetadataProperty("O_by_C_Type", {strQuotes & strSingleType & strQuotes})
    End Sub

    Public Sub SetOptionsByContextTypes(strTemp() As String)
        AddIncludedMetadataProperty("O_by_C_Type", strTemp)
    End Sub

    Public Sub SetOptionsByContextTypesAllMeasurements()
        AddIncludedMetadataProperty("O_by_C_Type", {Chr(34) & "measurement_1" & Chr(34), Chr(34) & "measurement_other" & Chr(34)})
    End Sub

    Public Sub SetOptionsByContextTypesAllIDs()
        AddIncludedMetadataProperty("O_by_C_Type", {Chr(34) & "id_1" & Chr(34), Chr(34) & "id_other" & Chr(34)})
    End Sub

    Public Sub SetOptionsByContextTypesAllContexts()
        AddIncludedMetadataProperty("O_by_C_Type", {Chr(34) & "context_1" & Chr(34), Chr(34) & "context_2" & Chr(34), Chr(34) & "context_3" & Chr(34), Chr(34) & "context_4" & Chr(34), Chr(34) & "context_other" & Chr(34)})
    End Sub

    Public Sub SetOptionsByContextTypesAllOptions()
        AddIncludedMetadataProperty("O_by_C_Type", {Chr(34) & "option_1" & Chr(34), Chr(34) & "option_other" & Chr(34)})
    End Sub

    Public Sub SetOptionsByContextTypesAllBlockings()
        AddIncludedMetadataProperty("O_by_C_Type", {Chr(34) & "blocking_1" & Chr(34), Chr(34) & "blocking_other" & Chr(34)})
    End Sub

    Public Sub SetOptionsByContextTypesAllOptionsContextsBlockings()
        AddIncludedMetadataProperty("O_by_C_Type", {Chr(34) & "option_1" & Chr(34), Chr(34) & "option_other" & Chr(34), Chr(34) & "context_1" & Chr(34), Chr(34) & "context_2" & Chr(34), Chr(34) & "context_3" & Chr(34), Chr(34) & "context_4" & Chr(34), Chr(34) & "context_other" & Chr(34), Chr(34) & "blocking_1" & Chr(34), Chr(34) & "blocking_other" & Chr(34)})
    End Sub

    Public Overridable Property Selector As ucrSelector
        Get
            Return ucrSelector
        End Get
        Set(ucrNewSelector As ucrSelector)
            'remove the receiver from the former selector
            If ucrSelector IsNot Nothing Then
                ucrSelector.RemoveReceiver(Me)
            End If

            ucrSelector = ucrNewSelector

            'add the receiver to the new selector
            If ucrSelector IsNot Nothing Then
                ucrSelector.AddReceiver(Me)
            End If

        End Set
    End Property

    Protected Overrides Sub ResetControlValue()
        Clear()
    End Sub

    Public Overridable Sub SetTextColour(clrNew As Color)

    End Sub

    Public Overridable Function GetItemsDataFrames() As List(Of String)
        Return New List(Of String)
    End Function

    Public Sub AddItemsWithMetadataProperty(strCurrentDataFrame As String, strProperty As String, strValues As String())
        If Selector IsNot Nothing Then
            SetMeAsReceiver()
            frmMain.clsRLink.SelectColumnsWithMetadataProperty(Me, strCurrentDataFrame, strProperty, strValues)
        End If
    End Sub

    Public Sub SetVariablesListPackageName(strNewVariablesListPackageName As String)
        strVariablesListPackageName = strNewVariablesListPackageName
    End Sub

    Public Sub SetVariablesListFunctionName(strNewVariablesListFunctionName As String)
        strVariablesListFunctionName = strNewVariablesListFunctionName
    End Sub

    Public Overridable Sub SetSelectorHeading(strNewHeading As String)
        strSelectorHeading = strNewHeading
    End Sub

    Private Sub Selector_DataFrameChanged() Handles ucrSelector.DataFrameChanged
        CheckAutoFill()
    End Sub

    Public Overridable Sub CheckAutoFill()
        Dim clsGetItems As New RFunction
        Dim clsIncludeList As New RFunction
        Dim expItems As SymbolicExpression
        Dim chrColumns As CharacterVector

        'TODO When there are receivers with bAttachedToPrimaryDataFrame = False
        '     don't always want to autofill when dataframe is changed.
        '     Something like AndAlso Selector.CurrentReceiver.bAttachedToPrimaryDataFrame
        '     except always want to autofill when resetting regardless of current receiver
        If bAutoFill AndAlso Selector IsNot Nothing AndAlso (Selector.CurrentReceiver Is Nothing OrElse Selector.CurrentReceiver.bAttachedToPrimaryDataFrame) Then
            ' If no autofill properties then simply check if one item is in the selector
            ' (may need to modify behaviour for multiple receivers)
            If lstIncludedAutoFillProperties.Count = 0 Then
                SetMeAsReceiver()
                If Selector.lstAvailableVariable.Items.Count = 1 Then
                    Add(Selector.lstAvailableVariable.Items(0).Text, Selector.strCurrentDataFrame)
                End If
            ElseIf lstIncludedAutoFillProperties.Count > 0 AndAlso ((bTypeSet AndAlso GetItemType() = "column") OrElse Selector.GetItemType() = "column") Then
                SetMeAsReceiver()
                clsGetItems.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_names")
                clsIncludeList.SetRCommand("list")
                For Each kvpInclude In lstIncludedAutoFillProperties
                    clsIncludeList.AddParameter(kvpInclude.Key, GetListAsRString(kvpInclude.Value.ToList(), bWithQuotes:=False))
                Next
                clsGetItems.AddParameter("include", clsRFunctionParameter:=clsIncludeList)
                clsGetItems.AddParameter("data_name", Chr(34) & Selector.strCurrentDataFrame & Chr(34))
                expItems = frmMain.clsRLink.RunInternalScriptGetValue(clsGetItems.ToScript(), bSilent:=True)
                If expItems IsNot Nothing AndAlso Not expItems.Type = Internals.SymbolicExpressionType.Null Then
                    chrColumns = expItems.AsCharacter
                    ' ucrReceiverSingle only autofills if there is exactly one valid item.
                    If TypeOf Me Is ucrReceiverSingle Then
                        If chrColumns.Count = 1 Then
                            For Each lviTempVariable As ListViewItem In Selector.lstAvailableVariable.Items
                                If lviTempVariable.Text = chrColumns(0) Then
                                    Add(lviTempVariable.Text, Selector.strCurrentDataFrame)
                                    Exit For
                                End If
                            Next
                        End If
                        ' ucrReceiverMultipe autofills all valid items.
                    ElseIf TypeOf Me Is ucrReceiverMultiple Then
                        For Each lviTempVariable As ListViewItem In Selector.lstAvailableVariable.Items
                            For Each chrCol As String In chrColumns
                                If lviTempVariable.Text = chrCol Then
                                    Add(lviTempVariable.Text, Selector.strCurrentDataFrame)
                                    Exit For
                                End If
                            Next
                        Next
                    End If
                End If
            End If
        End If
    End Sub
End Class
