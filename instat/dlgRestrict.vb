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

Imports instat.Translations
Imports RDotNet
Public Class dlgRestrict
    Public bFirstLoad As Boolean
    Private clsRemoveFilter As New RFunction
    Private clsSetCurrentFilter As New RFunction
    Private clsSubset As New RFunction
    Private clsFilterView As New RFunction
    Private clsCatFunction As New RFunction
    Public bIsSubsetDialog As Boolean
    Public strDefaultDataframe As String = ""
    Public strDefaultColumn As String = ""
    Public bAutoOpenSubDialog As Boolean = False
    Private bResetSubdialog = False

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        clsSubset = New RFunction
        clsRemoveFilter = New RFunction
        clsSetCurrentFilter = New RFunction
        clsFilterView = New RFunction
        clsCatFunction = New RFunction

        bFirstLoad = True
        clsCatFunction.SetRCommand("cat")
        clsRemoveFilter.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_current_filter")
        clsSetCurrentFilter.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_current_filter")
        clsSubset.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$copy_data_object")
        clsFilterView.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$filter_string")
    End Sub

    Private Sub dlgRestrict_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        SetDefaultDataFrame()
        UpdateFilterReceiver()
        If bAutoOpenSubDialog Then
            OpenNewFilterSubDialog()
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrInputFilterPreview.txtInput.ReadOnly = True
        ucrReceiverFilter.SetItemType("filter")
        ucrReceiverFilter.strSelectorHeading = "Filters"
        ucrReceiverFilter.Selector = ucrSelectorFilter
        ucrReceiverFilter.SetMeAsReceiver()
        ucrBase.iHelpTopicID = 340

        ' ucrSave
        ucrNewDataFrameName.SetSaveTypeAsDataFrame()
        ucrNewDataFrameName.SetLabelText("New Data Frame Name:")
        ucrNewDataFrameName.SetDataFrameSelector(ucrSelectorFilter.ucrAvailableDataFrames)
        ucrNewDataFrameName.SetIsTextBox()
    End Sub

    Private Sub SetDefaults()
        ucrNewDataFrameName.Reset()
        ucrSelectorFilter.Reset()
        SetDefaultNewDataFrameName()
        SetFilterSubsetStatus()
        SetDefaultDataFrame()
        bResetSubdialog = True
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverFilter.IsEmpty AndAlso ((rdoApplyAsSubset.Checked AndAlso ucrNewDataFrameName.IsComplete) OrElse (rdoApplyAsFilter.Checked) OrElse (rdoSavefilter.Checked)) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetFilterSubsetStatus()
        Me.Text = If(bIsSubsetDialog, "Subset", "Filter")
        rdoApplyAsFilter.Enabled = Not bIsSubsetDialog
        If bIsSubsetDialog Then
            rdoApplyAsSubset.Checked = True
        Else
            rdoApplyAsFilter.Checked = True
        End If
    End Sub

    Private Sub SetDefaultDataFrame()
        If strDefaultDataframe <> "" Then
            ucrSelectorFilter.SetDataframe(strDefaultDataframe)
        End If
    End Sub

    Private Sub cmdNewFilter_Click(sender As Object, e As EventArgs) Handles cmdDefineNewFilter.Click
        OpenNewFilterSubDialog()
    End Sub

    Private Sub OpenNewFilterSubDialog()
        sdgCreateFilter.ucrCreateFilter.SetDefaultDataFrame(ucrSelectorFilter.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        If strDefaultColumn <> "" AndAlso ucrSelectorFilter.ucrAvailableDataFrames.cboAvailableDataFrames.Text = strDefaultDataframe Then
            sdgCreateFilter.ucrCreateFilter.SetDefaultColumn(strDefaultColumn)
        End If
        sdgCreateFilter.ShowDialog()
        strDefaultColumn = ""
        If sdgCreateFilter.bFilterDefined Then
            frmMain.clsRLink.RunScript(sdgCreateFilter.clsCurrentFilter.ToScript(), strComment:="Create Filter subdialog: Created new filter")
            ucrSelectorFilter.SetDataframe(sdgCreateFilter.ucrCreateFilter.ucrSelectorForFitler.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            'Clear the receiver if the filter created is the same as the filter currently in the receiver. 
            'Clearing ensures that the filter preview is updated correctly because it might have changed.
            If ucrReceiverFilter.GetVariableNames(False) = sdgCreateFilter.ucrCreateFilter.ucrInputFilterName.GetText() Then
                ucrReceiverFilter.Clear()
            End If
            ucrReceiverFilter.Add(sdgCreateFilter.ucrCreateFilter.ucrInputFilterName.GetText())
        End If
        ucrSelectorFilter.LoadList()
    End Sub

    Private Sub ucrSelectorFilter_DataFrameChanged() Handles ucrSelectorFilter.DataFrameChanged
        Dim strDataFrame As String = Chr(34) & ucrSelectorFilter.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34)
        clsSetCurrentFilter.AddParameter("data_name", strDataFrame, iPosition:=0)
        clsRemoveFilter.AddParameter("data_name", strDataFrame, iPosition:=0)
        clsFilterView.AddParameter("data_name", strDataFrame, iPosition:=0)
        clsSubset.AddParameter("data_name", strDataFrame, iPosition:=0)
        SetDefaultNewDataFrameName()
    End Sub

    Private Sub SetDefaultNewDataFrameName()
        If ucrSelectorFilter.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNewDataFrameName.SetPrefix(ucrSelectorFilter.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_subset")
        End If
    End Sub

    Private Sub ucrReceiverFilter_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverFilter.SelectionChanged
        SetFilterOptions()
        SetBaseFunction()
    End Sub

    Private Sub SetFilterOptions()
        If ucrReceiverFilter.IsEmpty Then
            'TODO translate this
            ucrInputFilterPreview.SetName("( )")
            clsSubset.RemoveParameterByName("filter_name")
            clsFilterView.RemoveParameterByName("filter_name")
            clsSetCurrentFilter.RemoveParameterByName("filter_name")
        Else
            clsFilterView.AddParameter("filter_name", ucrReceiverFilter.GetVariableNames())
            clsSubset.AddParameter("filter_name", ucrReceiverFilter.GetVariableNames())
            clsSetCurrentFilter.AddParameter("filter_name", ucrReceiverFilter.GetVariableNames())
            Try
                ucrInputFilterPreview.SetName(frmMain.clsRLink.RunInternalScriptGetValue(clsFilterView.ToScript(), bSilent:=True).AsCharacter(0))
            Catch ex As Exception
                ucrInputFilterPreview.SetName("Preview not available")
            End Try
        End If
        TestOkEnabled()
    End Sub

    Private Sub rdoApplyAs_CheckedChanged(sender As Object, e As EventArgs) Handles rdoApplyAsFilter.CheckedChanged, rdoApplyAsSubset.CheckedChanged, rdoSavefilter.CheckedChanged
        ucrNewDataFrameName.Visible = Not (rdoApplyAsFilter.Checked OrElse rdoSavefilter.Checked)
        SetFilterOptions()
        SetBaseFunction()
        TestOkEnabled()
    End Sub

    Private Sub SetBaseFunction()
        If rdoApplyAsFilter.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(If(ucrReceiverFilter.IsEmpty,
                                                clsRemoveFilter, clsSetCurrentFilter))
            ucrBase.clsRsyntax.RemoveAssignTo()
        ElseIf rdoApplyAsSubset.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSubset)
            clsSubset.AddParameter("new_name", Chr(34) & ucrNewDataFrameName.GetText() & Chr(34), iPosition:=1)
        Else
            clsCatFunction.AddParameter("dispay", Chr(34) & "Saved column selection" & Chr(34), bIncludeArgumentName:=False)
            ucrBase.clsRsyntax.SetBaseRFunction(clsCatFunction)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        autoTranslate(Me)
    End Sub

    Private Sub ucrNewDataFrameName_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewDataFrameName.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrNewDataFrameName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNewDataFrameName.ControlValueChanged
        SetBaseFunction()
    End Sub

    Private Sub cmdFilterFromFactors_Click(sender As Object, e As EventArgs) Handles cmdFilterFromFactors.Click
        sdgFiltersFromFactor.SetRcodeAndDefaultDataFrame(ucrSelectorFilter, bReset:=bResetSubdialog)
        sdgFiltersFromFactor.ShowDialog()
        bResetSubdialog = False
        ucrSelectorFilter.LoadList()
    End Sub

    Private Sub UpdateFilterReceiver()
        If ucrReceiverFilter.IsEmpty Then
            Exit Sub
        End If
        Dim clsGetFilterNamesFunction As New RFunction
        Dim expItems As SymbolicExpression
        Dim vecFilters As GenericVector = Nothing

        clsGetFilterNamesFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_filter_names")
        clsGetFilterNamesFunction.AddParameter("data_name", Chr(34) & ucrSelectorFilter.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)

        expItems = frmMain.clsRLink.RunInternalScriptGetValue(clsGetFilterNamesFunction.ToScript(), bSilent:=True)
        If expItems Is Nothing OrElse expItems.Type = Internals.SymbolicExpressionType.Null Then
            Exit Sub
        End If
        vecFilters = expItems.AsList
        If Not vecFilters.AsCharacter.Contains(ucrReceiverFilter.GetVariableNames(False)) Then
            ucrReceiverFilter.Clear()
        End If
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        If rdoApplyAsSubset.Checked Then
            SetDefaults()
        End If
    End Sub
End Class