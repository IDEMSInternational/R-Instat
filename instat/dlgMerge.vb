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
Imports instat.Translations

Public Class dlgMerge
    Private bFirstLoad As Boolean = True
    Private clsMerge As RFunction
    Private clsByList As RFunction
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = True
    Private ttJoinType As New ToolTip
    Private dctJoinTexts As New Dictionary(Of String, String)

    ' This dialog has a bug when using numeric and integer columns as the joining columns.
    ' Issue reported here: https://github.com/hadley/dplyr/issues/2164
    ' The current fix we suggest is to first convert integer joining columns to numeric columns.
    ' Alternatives would be to use the much slower base merge 
    ' or plyr::join which cannot handle joining columns with different names
    Private Sub dlgMerge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctJoinTypes As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 60

        'sdgMerge.SetRSyntax(ucrBase.clsRsyntax)
        dctJoinTypes.Add("Full Join", "full_join")
        dctJoinTypes.Add("Left Join", "left_join")
        dctJoinTypes.Add("Right Join", "right_join")
        dctJoinTypes.Add("Inner Join", "inner_join")
        dctJoinTypes.Add("Semi Join", "semi_join")
        dctJoinTypes.Add("Anti Join", "anti_join")
        ucrInputJoinType.SetItems(dctItemParameterValuePairs:=dctJoinTypes, bSetCondtions:=False)

        dctJoinTexts.Add("Full Join", "Include all rows and all columns from both data frames. Where there are not matching values, returns NA for the one missing.")
        dctJoinTexts.Add("Left Join", "Include all rows from the 1st data frame, and all columns from both data frames." & Environment.NewLine & "Rows in the 1st data frame with no match in the second data frame will have NA values in the new columns." & Environment.NewLine & "If there are multiple matches, all combinations of the matches are included.")
        dctJoinTexts.Add("Right Join", "Include all rows from the 2nd data frame, and all columns from both data frames." & Environment.NewLine & "Rows in the second data frame with no match in the 1st data frame will have NA values in the new columns." & Environment.NewLine & "If there are multiple matches, all combinations of the matches are included.")
        dctJoinTexts.Add("Inner Join", "Include all rows from the 1st data frame where there are matching values in the 2nd data frame, and all columns from both data frames." & Environment.NewLine & "If there are multiple matches, all combination of the matches are included.")
        dctJoinTexts.Add("Semi Join", "Include all rows from the 1st data frame where there are matching values in the 2nd data frame, keeping just columns from the 1st data frame." & Environment.NewLine & "(A semi join differs from an inner join because an inner join will include one row of the 1st data frame for each matching row of the 2nd data frame, where a semi join will never duplicate rows of the 1st data frame.)")
        dctJoinTexts.Add("Anti Join", "Include all rows from the 1st data frame where there are not matching values the 2nd data frame, keeping just columns from the 1st data frame.")

        ucrInputJoinType.AddFunctionNamesCondition("Full Join", "full_join")
        ucrInputJoinType.AddFunctionNamesCondition("Left Join", "left_join")
        ucrInputJoinType.AddFunctionNamesCondition("Right Join", "right_join")
        ucrInputJoinType.AddFunctionNamesCondition("Inner Join", "inner_join")
        ucrInputJoinType.AddFunctionNamesCondition("Semi Join", "semi_join")
        ucrInputJoinType.AddFunctionNamesCondition("Anti Join", "anti_join")
        ucrInputJoinType.SetDropDownStyleAsNonEditable()

        ucrFirstDataFrame.SetParameter(New RParameter("x", 0))
        ucrFirstDataFrame.SetParameterIsRFunction()
        ucrFirstDataFrame.SetLabelText("First Data Frame:")

        ucrSecondDataFrame.SetParameter(New RParameter("y", 1))
        ucrSecondDataFrame.SetParameterIsRFunction()
        ucrSecondDataFrame.SetLabelText("Second Data Frame:")

        ucrSaveMerge.SetLabelText("New Data Frame Name:")
        ucrSaveMerge.SetIsTextBox()
        ucrSaveMerge.SetSaveTypeAsDataFrame()
        ucrSaveMerge.SetPrefix("merge")
    End Sub

    Private Sub SetDefaults()
        clsMerge = New RFunction
        clsByList = New RFunction

        ucrFirstDataFrame.Reset()
        ucrSecondDataFrame.Reset()

        ucrSaveMerge.Reset()

        clsMerge.SetPackageName("dplyr")
        clsMerge.SetRCommand("full_join")

        clsByList.SetRCommand("c")

        ucrBase.clsRsyntax.SetBaseRFunction(clsMerge)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bResetControls As Boolean)
        ucrFirstDataFrame.SetRCode(clsMerge, bResetControls)
        ucrSecondDataFrame.SetRCode(clsMerge, bResetControls)
        ucrInputJoinType.SetRCode(clsMerge, bResetControls)
        ucrSaveMerge.SetRCode(clsMerge, bResetControls)
    End Sub

    Private Sub TestOKEnabled()
        If ucrSaveMerge.IsComplete() AndAlso ucrFirstDataFrame.cboAvailableDataFrames.Text <> "" AndAlso ucrSecondDataFrame.cboAvailableDataFrames.Text <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdJoinOptions_Click(sender As Object, e As EventArgs) Handles cmdJoinOptions.Click
        sdgMerge.Setup(ucrFirstDataFrame.cboAvailableDataFrames.Text, ucrSecondDataFrame.cboAvailableDataFrames.Text, clsMerge, clsByList, bResetSubdialog)
        sdgMerge.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub ucrInputJoinType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputJoinType.ControlValueChanged
        Dim bFound As Boolean = True

        If Not ucrInputJoinType.IsEmpty() Then
            Select Case ucrInputJoinType.GetText()
                Case "Full Join"
                    clsMerge.SetRCommand("full_join")
                Case "Left Join"
                    clsMerge.SetRCommand("left_join")
                Case "Right Join"
                    clsMerge.SetRCommand("right_join")
                Case "Inner Join"
                    clsMerge.SetRCommand("inner_join")
                Case "Semi Join"
                    clsMerge.SetRCommand("semi_join")
                Case "Anti Join"
                    clsMerge.SetRCommand("anti_join")
                Case Else
                    bFound = False
            End Select
            'This stops the tool tip popping up during selection
            ttJoinType.Active = False
            If bFound Then
                ttJoinType.SetToolTip(ucrInputJoinType.cboInput, dctJoinTexts(ucrInputJoinType.GetText()))
                ttJoinType.Active = True
            End If
        End If
    End Sub

    Private Sub DataFrames_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrFirstDataFrame.ControlValueChanged, ucrSecondDataFrame.ControlValueChanged
        If ucrFirstDataFrame.cboAvailableDataFrames.Text <> "" AndAlso ucrSecondDataFrame.cboAvailableDataFrames.Text <> "" Then
            clsMerge.AddParameter("suffix", "c(" & Chr(34) & ucrFirstDataFrame.cboAvailableDataFrames.Text & Chr(34) & ", " & Chr(34) & ucrSecondDataFrame.cboAvailableDataFrames.Text & Chr(34) & ")")
        Else
            clsMerge.RemoveParameterByName("suffix")
        End If
    End Sub

    Private Sub ucrFirstDataFrame_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrFirstDataFrame.ControlContentsChanged, ucrSecondDataFrame.ControlContentsChanged, ucrSaveMerge.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class