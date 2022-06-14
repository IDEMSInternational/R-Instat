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

Public Class ucrDataFrame
    Public clsCurrDataFrame As New RFunction
    Public bFirstLoad As Boolean = True
    Private bPvtUseFilteredData As Boolean
    Private bPvtDropUnusedFilterLevels As Boolean = False

    Private strCachedDataFrameName As String = ""

    'todo. rename this property to SelectedDataFrameName. 
    Public ReadOnly Property strCurrDataFrame As String
        Get
            'return cboAvailableDataFrames.Text because cboAvailableDataFrames.SelectedItem
            'could be Nothing
            Return cboAvailableDataFrames.Text
        End Get
    End Property

    'If the control is used to set a parameter that is a string i.e. data_name = "survey"
    Private bParameterIsString As Boolean = False
    'If the control is used to set a parameter that is an RFunction i.e. x = InstatDataObject$get_data_frame(data_name = "survey")
    Private bParameterIsRFunction As Boolean = False
    'The name of the data parameter in the get data frame instat object method (should always be the same)
    Private strDataParameterNameInRFunction As String = "data_name"
    'Same as strPrimaryDataFrame in ucrSelector
    Private strPrimaryDataFrame As String = ""
    'If True, only data frames linked to the primary data frame will be displayed
    'This is usually set by the current receiver of the dialog
    Private bOnlyLinkedToPrimaryDataFrames As Boolean = False
    'If bOnlyLinkedToPrimaryDataFrames then should the primary data frame itself be displayed
    Private bIncludePrimaryDataFrameAsLinked As Boolean = True
    ''' <summary>
    ''' Used as a flag to prevent circular refreshing of data frame list
    ''' </summary>    
    Private bSuppressRefresh As Boolean = False

    Public ReadOnly Property iDataFrameLength As Integer
        Get
            Return If(cboAvailableDataFrames.Text = "", 0, frmMain.DataBook.GetDataFrame(cboAvailableDataFrames.Text).iTotalRowCount)
        End Get
    End Property

    Public ReadOnly Property iColumnCount As Integer
        Get
            Return If(cboAvailableDataFrames.Text = "", 0, frmMain.DataBook.GetDataFrame(cboAvailableDataFrames.Text).iTotalColumnCount)
        End Get
    End Property

    Private Sub ucrDataFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseControl()
            bFirstLoad = False
        End If

        'always load data frame names on load event because a data frame may have been deleted
        'and the control needs to refresh the data frame names.
        LoadDataFrameNamesAndFillComboBox()
    End Sub

    Private Sub InitialiseControl()
        bUseCurrentFilter = True
        lblDataFrame.AutoSize = True
        bUpdateRCodeFromControl = True
    End Sub

    Public Sub Reset()
        cboAvailableDataFrames.Items.Clear()
        LoadDataFrameNamesAndFillComboBox()
        'if there is a default data frame name then just select it, if it exists
        If Not String.IsNullOrEmpty(frmMain.strDefaultDataFrame) AndAlso cboAvailableDataFrames.Items.Contains(frmMain.strDefaultDataFrame) Then
            cboAvailableDataFrames.SelectedItem = frmMain.strDefaultDataFrame
        End If

        'todo. temporary and can be changed once some dialogs are correctly set up. 
        'Note. This is necessary because of the way some dialogs are set up
        'for instance, dialogs that manually add parameters to their R Functions
        'need these events raised even though the data frame has not changed.
        OnControlValueChanged()
    End Sub

    ''' <summary>
    ''' <para>loads data frame names and fills the combobox used for selection</para> 
    ''' <para>Updates the necessary values too</para>
    ''' </summary>
    Private Sub LoadDataFrameNamesAndFillComboBox()
        bSuppressRefresh = True

        'get current selected data frame name first before deleting
        Dim strSelectedDataFrameName As String = cboAvailableDataFrames.Text
        'then clear items
        cboAvailableDataFrames.Items.Clear()
        'add new items 
        If bOnlyLinkedToPrimaryDataFrames Then
            'todo. GetLinkedToDataFrameNames should also be done through the data book
            'As of 22/04/022 the data book did not have this feature
            cboAvailableDataFrames.Items.AddRange(frmMain.clsRLink.GetLinkedToDataFrameNames(strPrimaryDataFrame, bIncludePrimaryDataFrameAsLinked).ToArray)
        ElseIf frmMain.DataBook IsNot Nothing Then
            'Above check was added because of issue #4557.
            'todo. Once the DataBook is moved to a global class, then it can be removed
            For Each dataFrame As clsDataFrame In frmMain.DataBook.DataFrames
                cboAvailableDataFrames.Items.Add(dataFrame.strName)
            Next
        End If

        If cboAvailableDataFrames.Items.Count > 0 Then
            If cboAvailableDataFrames.Items.Contains(strSelectedDataFrameName) Then
                'try to restore the data frame name that was previously selected
                cboAvailableDataFrames.SelectedItem = strSelectedDataFrameName
            Else
                'if this control did not have any any data frame previously selected
                'then set one from data viewer focused data frame
                'get data viewer selected data frame 
                cboAvailableDataFrames.SelectedItem = frmMain.ucrDataViewer.GetCurrentDataFrameNameFocus()
            End If

        End If

        bSuppressRefresh = False

        UpdateValuesAndRaiseEvents()
    End Sub

    ''' <summary>
    ''' updates necessary values if the cached data frame is not equal to selected data frame
    ''' </summary>
    Private Sub UpdateValuesAndRaiseEvents()

        'only set the other values and raise events if the data frame truly changed
        If strCachedDataFrameName = cboAvailableDataFrames.Text Then
            Exit Sub
        End If

        'set parameter properties. Note we are updating this R Function at this level because
        'of how it's being used by other dialogs
        clsCurrDataFrame.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsCurrDataFrame.AddParameter(strParameterName:="data_name",
                                      strParameterValue:=Chr(34) & cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsCurrDataFrame.SetAssignTo(cboAvailableDataFrames.Text)

        'set cached data frame name
        strCachedDataFrameName = cboAvailableDataFrames.Text

        'raise event
        OnControlValueChanged()

        'if dialogs are set to change 'overall' selected data frame
        'then pass the selected data frame to frmMain as the  selected current 'overall' data frame
        If frmMain.clsInstatOptions.bChangeDataFrame Then
            frmMain.SetCurrentDataFrame(cboAvailableDataFrames.Text)
        End If
    End Sub

    Private Sub cboAvailableDataFrames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAvailableDataFrames.SelectedIndexChanged
        If Not bSuppressRefresh Then
            UpdateValuesAndRaiseEvents()
        End If
    End Sub

    'displays the data frame name slected in red if it differs with the selected sheet in the data frame
    Private Sub cboAvailableDataFrames_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cboAvailableDataFrames.DrawItem

        If e.Index < 0 Then
            Exit Sub
        End If

        e.DrawBackground()

        'get the item text of the combobox item being draw    
        Dim strItemtext As String = cboAvailableDataFrames.Items(e.Index).ToString()

        'determine the forecolor of the combo box item  
        'display data frame name in red if it's different from the data viewer selected sheet name
        Dim strSelectedSheetName As String = frmMain.ucrDataViewer.GetCurrentDataFrameNameFocus()

        Dim brush As Brush = If(Not cboAvailableDataFrames.DroppedDown AndAlso
            strItemtext <> strSelectedSheetName AndAlso
            strItemtext = cboAvailableDataFrames.Text,
            Brushes.Red,
            Brushes.Black)

        'draw the item text 
        e.Graphics.DrawString(strItemtext, DirectCast(sender, ComboBox).Font, brush, e.Bounds.X, e.Bounds.Y)
    End Sub

    Public Overrides Sub UpdateParameter(clsTempParam As RParameter)
        If clsTempParam IsNot Nothing Then
            If bParameterIsString Then
                clsTempParam.SetArgumentValue(Chr(34) & cboAvailableDataFrames.Text & Chr(34))
            ElseIf bParameterIsRFunction Then
                clsTempParam.SetArgument(clsCurrDataFrame)
            End If
        End If
    End Sub


    ''' <summary>
    ''' Sets the data frame name that will be selected by the control
    ''' </summary>
    ''' <param name="strDataFrameName">
    ''' <para>Data frame name to select. The data frame name will only be selected if it exists</para>
    ''' </param>
    ''' <param name="bEnableUserSelection">
    ''' <para>If true, data frame selection by user will be enabled, false otherwise.</para> 
    ''' <para>Default is True.</para>
    ''' </param>
    Public Sub SetDataframe(strDataFrameName As String, Optional bEnableUserSelection As Boolean = True)
        'set if data frame name should be selectable
        cboAvailableDataFrames.Enabled = bEnableUserSelection

        'load and fill all the data frame names
        LoadDataFrameNamesAndFillComboBox()

        'set the passed data frame name as the selected one
        If cboAvailableDataFrames.Items.Contains(strDataFrameName) Then
            cboAvailableDataFrames.SelectedItem = strDataFrameName
        End If
    End Sub

    Public Property bUseCurrentFilter As Boolean
        Get
            Return bPvtUseFilteredData
        End Get
        Set(bValue As Boolean)
            bPvtUseFilteredData = bValue
            If bPvtUseFilteredData Then
                If frmMain.clsInstatOptions IsNot Nothing AndAlso frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                    clsCurrDataFrame.AddParameter("use_current_filter", "TRUE")
                Else
                    clsCurrDataFrame.RemoveParameterByName("use_current_filter")
                End If
            Else
                clsCurrDataFrame.AddParameter("use_current_filter", "FALSE")
            End If
        End Set
    End Property

    Public Property bDropUnusedFilterLevels As Boolean
        Get
            Return bPvtDropUnusedFilterLevels
        End Get
        Set(bValue As Boolean)
            bPvtDropUnusedFilterLevels = bValue
            If bPvtDropUnusedFilterLevels Then
                clsCurrDataFrame.AddParameter("drop_unused_filter_levels", "TRUE")
            Else
                If frmMain.clsInstatOptions IsNot Nothing AndAlso frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                    clsCurrDataFrame.AddParameter("drop_unused_filter_levels", "FALSE")
                Else
                    clsCurrDataFrame.RemoveParameterByName("drop_unused_filter_levels")
                End If
            End If
        End Set
    End Property

    Private Sub mnuRightClickCopy_Click(sender As Object, e As EventArgs) Handles mnuRightClickCopy.Click
        'TODO Combo box should be replaced by ucrInput so that context menu done automatically
        If cboAvailableDataFrames.Text <> "" Then
            Clipboard.SetText(cboAvailableDataFrames.Text)
        End If
    End Sub

    Public Overrides Sub UpdateControl(Optional bReset As Boolean = False, Optional bCloneIfNeeded As Boolean = False)
        Dim clsTempDataParameter As RParameter
        Dim strDataFrameName As String = ""
        Dim clsMainParameter As RParameter

        MyBase.UpdateControl(bReset:=bReset, bCloneIfNeeded:=bCloneIfNeeded)

        clsMainParameter = GetParameter()
        If clsMainParameter IsNot Nothing Then
            If bChangeParameterValue Then
                If bParameterIsString AndAlso clsMainParameter.bIsString Then
                    strDataFrameName = clsMainParameter.strArgumentValue
                ElseIf bParameterIsRFunction AndAlso clsMainParameter.bIsFunction Then
                    clsTempDataParameter = clsMainParameter.clsArgumentCodeStructure.GetParameter(strDataParameterNameInRFunction)
                    If clsTempDataParameter IsNot Nothing Then
                        strDataFrameName = clsMainParameter.clsArgumentCodeStructure.GetParameter(strDataParameterNameInRFunction).strArgumentValue
                    End If
                End If
            End If
        End If
        If strDataFrameName <> "" AndAlso strDataFrameName <> strCurrDataFrame Then
            'Substring used to removed quotes on either side
            strDataFrameName = strDataFrameName.Substring(1, strDataFrameName.Length - 2)
            SetDataframe(strDataFrameName)
        End If
    End Sub

    Public Sub SetParameterIsString()
        bParameterIsString = True
        bParameterIsRFunction = False
        UpdateAllParameters()
    End Sub

    Public Sub SetParameterIsRFunction()
        bParameterIsRFunction = True
        bParameterIsString = False
        UpdateAllParameters()
    End Sub

    Public Overrides Function IsRDefault() As Boolean
        Return GetParameter() IsNot Nothing AndAlso objRDefault IsNot Nothing AndAlso objRDefault.Equals(cboAvailableDataFrames.Text)
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary> 
    '''    Translates <paramref name="strText"/> to the current language and then sets 
    '''    the `Text` property of the label to the translated text.<para>
    '''    Translations can be bi-directional (e.g. from English to French or from French to English).
    '''    If <paramref name="strText"/> is already in the current language, or if no translation 
    '''    can be found, then sets the `Text` property of the control to <paramref name="strText"/>.
    ''' </para></summary>
    ''' 
    ''' <param name="strText"> The parameter's String value.</param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetLabelText(strText As String)
        lblDataFrame.Text = GetTranslation(strText)
    End Sub

    Private Sub mnuRightClickSetData_Click(sender As Object, e As EventArgs) Handles mnuRightClickSetData.Click
        frmMain.SetCurrentDataFrame(cboAvailableDataFrames.Text)
    End Sub

    Public Sub SetPrimaryDataFrameOptions(strNewPrimaryDataFrame As String, bNewOnlyLinkedToPrimaryDataFrames As Boolean, Optional bNewIncludePrimaryDataFrameAsLinked As Boolean = False)
        Dim bUpdate As Boolean = False

        If (bNewOnlyLinkedToPrimaryDataFrames <> bOnlyLinkedToPrimaryDataFrames) OrElse (bNewOnlyLinkedToPrimaryDataFrames AndAlso (strPrimaryDataFrame <> strNewPrimaryDataFrame OrElse bNewIncludePrimaryDataFrameAsLinked <> bIncludePrimaryDataFrameAsLinked)) Then
            bUpdate = True
        End If
        strPrimaryDataFrame = strNewPrimaryDataFrame
        bOnlyLinkedToPrimaryDataFrames = bNewOnlyLinkedToPrimaryDataFrames
        bIncludePrimaryDataFrameAsLinked = bNewIncludePrimaryDataFrameAsLinked
        If bUpdate Then
            LoadDataFrameNamesAndFillComboBox()
        End If
    End Sub

End Class