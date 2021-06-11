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
Public Class dlgLabelsLevels
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsViewLabels As New RFunction
    Public strSelectedDataFrame As String = ""
    Private bUseSelectedColumn As Boolean = False
    Private strSelectedColumn As String = ""
    Private lstRCodeStructure As List(Of RCodeStructure)

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
        autoTranslate(Me)
        If bUseSelectedColumn Then
            SetDefaultColumn()
        End If
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
        ucrChkIncludeLevelNumbers.AddParameterPresentCondition(True, "new_levels")
        ucrChkIncludeLevelNumbers.AddParameterPresentCondition(False, "new_levels", False)
    End Sub

    Private Sub ResetFunction()
        clsViewLabels = New RFunction
        clsViewLabels.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_factor_levels")
    End Sub

    Private Sub SetDefaults()
        ResetFunction()
        ucrSelectorForLabels.Reset()
        ucrSelectorForLabels.Focus()

        If IsNothing(lstRCodeStructure) Then

        ElseIf (lstRCodeStructure.Count > 1) Then
            MsgBox("Developer error: List of RCodeStructure must have only one RFunction")
        ElseIf (lstRCodeStructure.Count = 1) Then
            If Not IsNothing(TryCast(lstRCodeStructure(0), RFunction)) Then
                If TryCast(lstRCodeStructure(0), RFunction).strRCommand = "data_book$set_factor_levels" Then
                    clsViewLabels = lstRCodeStructure(0)
                Else
                    MsgBox("This dialogue uses the ""data_book$set_factor_levels"" function only")
                End If
            Else
                MsgBox("Developer error:The Script must be an RFunction")
            End If
        End If
        lstRCodeStructure = Nothing

        ucrBase.clsRsyntax.SetBaseRFunction(clsViewLabels)
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

    Private Sub ucrReceiverLabels_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverLabels.ControlContentsChanged, ucrFactorLabels.ControlContentsChanged
        AddLevelButtonEnabled()
        TestOKEnabled()
    End Sub

    Private Sub AddLevelButtonEnabled()
        cmdAddLevel.Enabled = ucrFactorLabels.grdFactorData.Visible AndAlso Not ucrReceiverLabels.IsEmpty
    End Sub

    'TODO modify factor control to be able to manage two parameters from different columns
    Private Sub ucrFactorLabels_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrFactorLabels.ControlValueChanged, ucrChkIncludeLevelNumbers.ControlValueChanged
        If (ucrChkIncludeLevelNumbers.Checked OrElse Not ucrChkIncludeLevelNumbers.Visible) AndAlso ucrFactorLabels.IsColumnComplete(ucrFactorLabels.strLevelsName) Then
            clsViewLabels.AddParameter("new_levels", strParameterValue:=ucrFactorLabels.GetColumnInFactorSheet(ucrFactorLabels.strLevelsName, bWithQuotes:=False))
        Else
            clsViewLabels.RemoveParameterByName("new_levels")
        End If
    End Sub

    Public Property lstScriptsRCodeStructure As List(Of RCodeStructure)
        Get
            Return lstRCodeStructure
        End Get
        Set(lstNewRCodeStructure As List(Of RCodeStructure))
            lstRCodeStructure = lstNewRCodeStructure
            bReset = True
        End Set
    End Property
End Class