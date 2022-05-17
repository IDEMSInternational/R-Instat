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
Public Class dlgLabelsLevels
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsViewLabelsFunction, clsSumCountMissingFunction As New RFunction
    Public strSelectedDataFrame As String = ""
    Private bUseSelectedColumn As Boolean = False
    Private strSelectedColumn As String = ""

    Private Sub dlgLabels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        If bUseSelectedColumn Then
            SetDefaultColumn()
        End If
        CountLevels()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 35

        ucrSelectorForLabels.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForLabels.SetParameterIsString()

        ucrReceiverLabels.SetParameter(New RParameter("col_name", 1))
        ucrReceiverLabels.SetParameterIsString()
        ucrReceiverLabels.Selector = ucrSelectorForLabels
        ucrReceiverLabels.SetMeAsReceiver()
        ucrReceiverLabels.SetIncludedDataTypes({"factor"}, bStrict:=True)
        ucrReceiverLabels.strSelectorHeading = "Factors"

        Dim dctParamAndColNames As New Dictionary(Of String, String)
        dctParamAndColNames.Add("new_labels", ucrFactor.DefaultColumnNames.Label)
        'todo. commented out temporarily
        'until when full support of adding or removing specific parameters will be implemented
        'dctParamAndColNames.Add("new_levels", ucrFactor.DefaultColumnNames.Level)

        ucrFactorLabels.SetParameter(New RParameter("new_labels", 2))
        ucrFactorLabels.SetAsNormalGridColumn(ucrReceiverLabels, dctParamAndColNames,
                                              editableColNames:={ucrFactor.DefaultColumnNames.Label,
                                              ucrFactor.DefaultColumnNames.Level},
                                              hiddenColNames:={ucrFactor.DefaultColumnNames.Level})

        ucrChkIncludeLevelNumbers.SetText("Include Level Numbers")

        lblNaValue.ForeColor = Color.Red
        lblLevelNumber.ForeColor = Color.Red
    End Sub

    Private Sub SetDefaults()
        clsViewLabelsFunction = New RFunction
        clsSumCountMissingFunction = New RFunction

        cmdAddLevel.Enabled = False
        ucrSelectorForLabels.Reset()
        ucrSelectorForLabels.Focus()


        clsSumCountMissingFunction.SetRCommand("summary_count_missing")

        clsViewLabelsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_factor_levels")
        ucrBase.clsRsyntax.SetBaseRFunction(clsViewLabelsFunction)
    End Sub

    Public Sub SetCurrentColumn(strColumn As String, strDataFrame As String)
        strSelectedColumn = strColumn
        strSelectedDataFrame = strDataFrame
        bUseSelectedColumn = True
    End Sub

    Private Sub SetDefaultColumn()
        ucrSelectorForLabels.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem = strSelectedDataFrame
        ucrReceiverLabels.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)

        ucrSelectorForLabels.SetRCode(clsViewLabelsFunction, bReset)
        ucrReceiverLabels.SetRCode(clsViewLabelsFunction, bReset)

        'todo. commented out temporarily
        'until when full support of adding or removing specific parameters will be implemented
        'ucrFactorLabels.AddAdditionalCodeParameterPair(clsViewLabelsFunction, New RParameter("new_levels", 1), iAdditionalPairNo:=1)
        ucrFactorLabels.SetRCode(clsViewLabelsFunction, bReset)

    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled(Not ucrReceiverLabels.IsEmpty() _
                          AndAlso ucrFactorLabels.IsColumnComplete({ucrFactor.DefaultColumnNames.Label}) _
                          AndAlso (ucrFactorLabels.IsColumnComplete({ucrFactor.DefaultColumnNames.Level}) _
                                   OrElse Not ucrChkIncludeLevelNumbers.Checked))
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdAddLevel_Click(sender As Object, e As EventArgs) Handles cmdAddLevel.Click
        ucrFactorLabels.AddNewRowInGrid()
    End Sub

    Private Sub CountLevels()
        Static iMissingValue As Integer
        Dim clsGetColumnFunction As RFunction

        clsGetColumnFunction = ucrReceiverLabels.GetVariables()
        clsGetColumnFunction.RemoveAssignTo()

        If Not ucrReceiverLabels.IsEmpty AndAlso {"factor"}.Contains(ucrReceiverLabels.strCurrDataType) Then
            clsSumCountMissingFunction.AddParameter("x", clsRFunctionParameter:=clsGetColumnFunction, iPosition:=0)
            iMissingValue = frmMain.clsRLink.RunInternalScriptGetValue(clsSumCountMissingFunction.ToScript(), bSilent:=False).AsNumeric(0)
        Else
            iMissingValue = 0
            clsSumCountMissingFunction.RemoveParameterByName("x")
        End If

        lblNaValue.Text = "Missing Values: " & iMissingValue
        lblNaValue.Visible = iMissingValue > 0
        lblLevelNumber.Text = "Levels: " & ucrFactorLabels.RowCount
        lblLevelNumber.Visible = ucrFactorLabels.RowCount > 0
    End Sub

    Private Sub ucrReceiverLabels_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverLabels.ControlValueChanged
        'check if the variable selected has value labels.
        'If it has then disable ucrChkIncludeLevelNumbers and set it as checked
        'because it already has level number, so just show them to user
        ucrChkIncludeLevelNumbers.Checked = frmMain.clsRLink.IsVariablesMetadata(
                ucrReceiverLabels.GetDataName(), "labels", ucrReceiverLabels.GetVariableNames(False))
        ucrChkIncludeLevelNumbers.Enabled = Not ucrChkIncludeLevelNumbers.Checked
    End Sub

    Private Sub ucrFactorLabels_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrFactorLabels.ControlValueChanged, ucrChkIncludeLevelNumbers.ControlValueChanged

        'only add levels if indicated by the user
        Dim bAddParam As Boolean
        If ucrChkIncludeLevelNumbers.Checked Then
            ucrFactorLabels.ShowColumns({ucrFactor.DefaultColumnNames.Level})
            bAddParam = ucrFactorLabels.IsColumnComplete({ucrFactor.DefaultColumnNames.Level})
        Else
            ucrFactorLabels.HideColumns({ucrFactor.DefaultColumnNames.Level})
            bAddParam = False
        End If

        'this adding or removing could be possible if the custom controls could
        'add or remove their own specific parameters in a context like this
        'so we do it manually here
        If bAddParam Then
            clsViewLabelsFunction.AddParameter("new_levels",
                                           strParameterValue:=mdlCoreControl.GetRVector(
                                           ucrFactorLabels.GetCellValues(ucrFactor.DefaultColumnNames.Level, bWithQuotes:=False)),
                                           iPosition:=3)

        Else
            clsViewLabelsFunction.RemoveParameterByName("new_levels")
        End If

        cmdAddLevel.Enabled = Not ucrReceiverLabels.IsEmpty
        CountLevels()
        TestOKEnabled()
    End Sub

End Class