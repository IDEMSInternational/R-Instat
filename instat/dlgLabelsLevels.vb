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
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 35

        ucrFactorLabels.SetParameter(New RParameter("new_labels", 2))
        ucrFactorLabels.SetReceiver(ucrReceiverLabels)
        ucrFactorLabels.SetAsViewerOnly()
        ucrFactorLabels.AddEditableColumns({ucrFactorLabels.strLevelsName, ucrFactorLabels.strLabelsName})
        ucrFactorLabels.SetIsGridColumn(ucrFactorLabels.strLabelsName)
        ucrFactorLabels.SetLevelsCheckbox(ucrChkIncludeLevelNumbers)

        ucrReceiverLabels.SetParameter(New RParameter("col_name", 1))
        ucrReceiverLabels.SetParameterIsString()
        ucrReceiverLabels.Selector = ucrSelectorForLabels
        ucrReceiverLabels.SetMeAsReceiver()
        ucrReceiverLabels.SetIncludedDataTypes({"factor"}, bStrict:=True)
        ucrReceiverLabels.strSelectorHeading = "Factors"

        ucrSelectorForLabels.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForLabels.SetParameterIsString()

        ucrChkIncludeLevelNumbers.SetText("Include Level Numbers")

        lblNaValue.ForeColor = Color.Red
        lblLevelNumber.ForeColor = Color.Red
    End Sub

    Private Sub SetDefaults()
        clsViewLabelsFunction = New RFunction
        clsSumCountMissingFunction = New RFunction
        ucrSelectorForLabels.Reset()
        ucrSelectorForLabels.Focus()

        clsSumCountMissingFunction.SetRCommand("summary_count_missing")

        clsViewLabelsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_factor_levels")
        ucrBase.clsRsyntax.SetBaseRFunction(clsViewLabelsFunction)
        AddLevelButtonEnabled()
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
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverLabels.IsEmpty() AndAlso ucrFactorLabels.IsColumnComplete(ucrFactorLabels.strLabelsName) AndAlso (ucrChkIncludeLevelNumbers.Visible AndAlso Not ucrChkIncludeLevelNumbers.Checked OrElse (ucrFactorLabels.IsColumnComplete(ucrFactorLabels.strLevelsName))) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdAddLevel_Click(sender As Object, e As EventArgs) Handles cmdAddLevel.Click
        ucrFactorLabels.AddLevel()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverLabels_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverLabels.ControlValueChanged
        Dim iMissingValue As Integer
        Dim clsGetColumnFunction As RFunction = ucrReceiverLabels.GetVariables()
        clsGetColumnFunction.RemoveAssignTo()

        If Not ucrReceiverLabels.IsEmpty AndAlso {"factor"}.Contains(ucrReceiverLabels.strCurrDataType) Then
            clsSumCountMissingFunction.AddParameter("x", clsRFunctionParameter:=clsGetColumnFunction, iPosition:=0)
            iMissingValue = frmMain.clsRLink.RunInternalScriptGetValue(clsSumCountMissingFunction.ToScript(), bSilent:=False).AsNumeric(0)
        Else
            clsSumCountMissingFunction.RemoveParameterByName("x")
        End If

        lblNaValue.Text = "Missing Values: " & iMissingValue
        lblNaValue.Visible = iMissingValue > 0
        lblLevelNumber.Visible = If(Not ucrReceiverLabels.IsEmpty, True, False)
    End Sub

    Private Sub AddLevelButtonEnabled()
        cmdAddLevel.Enabled = ucrFactorLabels.grdFactorData.Visible AndAlso Not ucrReceiverLabels.IsEmpty
    End Sub

    'TODO modify factor control to be able to manage two parameters from different columns
    Private Sub ucrFactorLabels_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrFactorLabels.ControlValueChanged, ucrChkIncludeLevelNumbers.ControlValueChanged
        If (ucrChkIncludeLevelNumbers.Checked OrElse Not ucrChkIncludeLevelNumbers.Visible) AndAlso ucrFactorLabels.IsColumnComplete(ucrFactorLabels.strLevelsName) Then
            clsViewLabelsFunction.AddParameter("new_levels", strParameterValue:=ucrFactorLabels.GetColumnInFactorSheet(ucrFactorLabels.strLevelsName, bWithQuotes:=False))
        Else
            clsViewLabelsFunction.RemoveParameterByName("new_levels")
        End If
        If ucrFactorLabels.grdFactorData.CurrentWorksheet IsNot Nothing Then
            lblLevelNumber.Text = "Levels: " & ucrFactorLabels.grdFactorData.CurrentWorksheet.RowCount
        End If
    End Sub

    Private Sub ucrReceiverLabels_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverLabels.ControlContentsChanged, ucrFactorLabels.ControlContentsChanged
        AddLevelButtonEnabled()
        TestOKEnabled()
    End Sub
End Class