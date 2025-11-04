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

Public Class sdgBeforeTablesOption
    Private lstFormatRFunctions As New List(Of RFunction)

    Private clsOperator As ROperator
    Private clsThemeRFunction, clsSubMissingRFunction As RFunction
    Private bFirstload As Boolean = True

    Private ReadOnly strZero As String = "0"
    Private ReadOnly strMultipleDashes As String = "...."
    Private ReadOnly strMissing As String = "missing"
    Private ReadOnly strStar As String = "***"

    Private Sub sdgBeforeTablesOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
            'adding these  because it's ignored on first load
            ucrCboSelectThemes.SetText(dlgGeneralTable.ucrCboSelectThemes.GetText)
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrSdgBaseButtons.iHelpTopicID = 146
        ucrChkSelectTheme.Checked = True
        ucrChkSelectTheme.SetText("Select Theme")
        ucrChkManualTheme.SetText("Manual Theme")

        ucrChkDataFormat.SetText("Specify the Data Format")
        ucrChkMissingValues.SetText("Replace NA")
        ucrChkDataFormat.Enabled = False
        grpMissingValues.Visible = False
        btnNumberFormat.Visible = False
        btnDateFormat.Visible = False
        btnTextFormat.Visible = False
        rdoNumber.Visible = False
        rdoDate.Visible = False
        rdoText.Visible = False

        ucrPnlFormat.AddRadioButton(rdoNumber)
        ucrPnlFormat.AddRadioButton(rdoDate)
        ucrPnlFormat.AddRadioButton(rdoText)

        ucrTxtMissingText.SetItems({strZero, strMultipleDashes, strMissing, strStar})
        ucrCboSelectThemes.SetItems({"None", "Dark Theme", "538 Theme", "Dot Matrix Theme", "Espn Theme", "Excel Theme", "Guardian Theme", "NY Times Theme", "PFF Theme"})
        ucrCboSelectThemes.SetDropDownStyleAsNonEditable()
    End Sub

    ''' <summary>
    ''' Sets up the sub dialog, this is the simpler version of the main sdgTableOptions dialog but has only 4 options.
    ''' Expected to be called before showing the dialog. 
    ''' </summary>
    ''' <param name="strDataFrameName">Name of the data frame contained in the data book</param>
    ''' <param name="clsNewOperator">R operator that has a 'gt' parameter that produces a 'gt' object.</param>
    Public Sub Setup1(strDataFrameName As String, clsNewOperator As ROperator)
        clsOperator = clsNewOperator

        ucrHeader.Setup(clsOperator)
        ucrSourceNotes.Setup(clsOperator)
        ucrOtherStyles.Setup(clsOperator)

        ucrCboSelectThemes.SetText(dlgGeneralTable.ucrCboSelectThemes.GetText)
        ucrChkSelectTheme.Checked = dlgGeneralTable.ucrChkSelectTheme.Checked
        sdgTableStyles.GetNewUserInputAsRFunction()
        SetupTheme(clsOperator)
        SetupSubMissing(clsOperator)
        SetupFormatFunctions(clsOperator)
    End Sub

    Private Sub ucrSdgBaseButtons_ClickReturn(sender As Object, e As EventArgs) Handles ucrSdgBaseButtons.ClickReturn
        ucrHeader.SetValuesToOperator()
        ucrSourceNotes.SetValuesToOperator()
        ucrOtherStyles.SetValuesToOperator()
        SetThemeValuesOnReturn(clsOperator)
        SetSubMissingValuesOnReturn(clsOperator)
    End Sub

    '-----------------------------------------
    ' Themes

    Private Sub SetupTheme(clsOperator As ROperator)
        If clsOperator.ContainsParameter("theme_format") Then
            clsThemeRFunction = clsOperator.GetParameter("theme_format").clsArgumentCodeStructure
        Else
            clsThemeRFunction = New RFunction
            clsThemeRFunction.SetPackageName("gtExtras")
        End If
        If ucrChkManualTheme.Checked Then
            sdgSummaryThemes.SetRCode(bReset:=True, clsNewThemesTabOption:=clsThemeRFunction)
        End If
    End Sub

    Private Sub ucrChkSelectTheme_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSelectTheme.ControlValueChanged
        If ucrChkSelectTheme.Checked Then
            btnManualTheme.Visible = False
            ucrCboSelectThemes.Visible = True
        ElseIf ucrChkSelectTheme.Checked Then
            ucrChkManualTheme.Checked = True
        Else
            ucrCboSelectThemes.Visible = False
        End If
    End Sub

    Private Sub ucrChkManualTheme_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkManualTheme.ControlValueChanged

        If ucrChkManualTheme.Checked Then
            btnManualTheme.Visible = True
            ucrChkSelectTheme.Checked = Not ucrChkManualTheme.Checked
            btnManualTheme.Visible = ucrChkManualTheme.Checked
        End If
    End Sub

    Private Sub btnManualTheme_Click(sender As Object, e As EventArgs) Handles btnManualTheme.Click
        clsThemeRFunction.SetPackageName("gt")
        clsThemeRFunction.SetRCommand("tab_options")
        sdgSummaryThemes.SetRCode(bReset:=True, clsNewThemesTabOption:=clsThemeRFunction)
        sdgSummaryThemes.ShowDialog(Me)
    End Sub

    Private Sub ucrCboSelectThemes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrCboSelectThemes.ControlValueChanged

        If clsThemeRFunction Is Nothing Then
            Exit Sub
        End If

        Dim strCommand As String = ""
        Select Case ucrCboSelectThemes.GetText
            Case "Dark Theme"
                strCommand = "gt_theme_dark"
            Case "538 Theme"
                strCommand = "gt_theme_538"
            Case "Dot Matrix Theme"
                strCommand = "gt_theme_dot_matrix"
            Case "Espn Theme"
                strCommand = "gt_theme_espn"
            Case "Excel Theme"
                strCommand = "gt_theme_excel"
            Case "Guardian Theme"
                strCommand = "gt_theme_guardian"
            Case "NY Times Theme"
                strCommand = "gt_theme_nytimes"
            Case "PFF Theme"
                strCommand = "gt_theme_pff"
        End Select

        clsThemeRFunction.SetRCommand(strCommand)
    End Sub

    Private Sub ucrChkDataFormat_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDataFormat.ControlValueChanged
        If ucrChkDataFormat.Checked Then
            ucrPnlFormat.Visible = True
            rdoNumber.Visible = True
            rdoDate.Visible = True
            rdoText.Visible = True
        Else
            rdoNumber.Visible = False
            rdoDate.Visible = False
            rdoText.Visible = False
        End If

    End Sub

    Private Sub ucrChkMissingValues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMissingValues.ControlValueChanged
        If ucrChkMissingValues.Checked Then
            grpMissingValues.Visible = True
        Else
            grpMissingValues.Visible = False
        End If
    End Sub

    Private Sub ucrPnlFormat_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlFormat.ControlValueChanged
        If rdoNumber.Checked Then
            btnNumberFormat.Visible = True
        Else
            btnNumberFormat.Visible = False
        End If
        If rdoDate.Checked Then
            btnDateFormat.Visible = True
        Else
            btnDateFormat.Visible = False
        End If
        If rdoText.Checked Then
            btnTextFormat.Visible = True
        Else
            btnTextFormat.Visible = False
        End If
    End Sub

    Private Sub SetThemeValuesOnReturn(clsOperator As ROperator)
        ' Set the themes parameter if there was a theme selected
        If ucrChkManualTheme.Checked Then
            sdgSummaryThemes.SetRCode(bReset:=True, clsNewThemesTabOption:=clsThemeRFunction)
        End If
        If clsThemeRFunction IsNot Nothing AndAlso Not String.IsNullOrEmpty(clsThemeRFunction.strRCommand) Then
            clsOperator.AddParameter("theme_format", clsRFunctionParameter:=clsThemeRFunction)
        Else
            clsOperator.RemoveParameterByName("theme_format")
        End If
    End Sub

    Private Sub btnTextFormat_Click(sender As Object, e As EventArgs) Handles btnTextFormat.Click
        Dim clsFormatRFunction As RFunction = Nothing
        sdgCellFormatTextOptions.ShowDialog(Me.ParentForm)
        clsFormatRFunction = sdgCellFormatTextOptions.GetNewUserInputAsRFunction()
        If clsFormatRFunction Is Nothing Then
            Exit Sub
        Else
            lstFormatRFunctions.Add(clsFormatRFunction)
        End If

    End Sub

    Private Sub btnDateFormat_Click(sender As Object, e As EventArgs) Handles btnDateFormat.Click
        Dim clsFormatRFunction As RFunction = Nothing
        sdgCellFormatDateOptions.ShowDialog(Me.ParentForm)
        clsFormatRFunction = sdgCellFormatDateOptions.GetNewUserInputAsRFunction()
        If clsFormatRFunction Is Nothing Then
            Exit Sub
        Else
            lstFormatRFunctions.Add(clsFormatRFunction)
        End If
    End Sub

    Private Sub btnNumberFormat_Click(sender As Object, e As EventArgs) Handles btnNumberFormat.Click
        Dim clsFormatRFunction As RFunction = Nothing
        sdgCellFormatNumberOptions.ShowDialog(Me.ParentForm)
        clsFormatRFunction = sdgCellFormatNumberOptions.GetNewUserInputAsRFunction()

        If clsFormatRFunction Is Nothing Then
            Exit Sub
        Else
            lstFormatRFunctions.Add(clsFormatRFunction)
        End If

    End Sub

    Private Sub SetupSubMissing(clsOperator As ROperator)
        If clsOperator.ContainsParameter("sub_missing") Then
            clsSubMissingRFunction = clsOperator.GetParameter("sub_missing").clsArgumentCodeStructure
        Else
            clsSubMissingRFunction = New RFunction
            clsSubMissingRFunction.SetPackageName("gt")
            clsSubMissingRFunction.SetRCommand("sub_missing")
            ' seed it with whatever is currently in the text box (could be blank)
            UpdateSubMissingParam(ucrTxtMissingText.GetText())
        End If
    End Sub

    Private Sub UpdateSubMissingParam(strText As String)
        If Not String.IsNullOrEmpty(strText) Then
            clsOperator.RemoveParameterByName("sub_missing")
            Dim quoted = Chr(34) & strText & Chr(34)
            clsSubMissingRFunction.AddParameter(strParameterName:="missing_text",
                                            strParameterValue:=quoted,
                                            iPosition:=1)
        End If
    End Sub

    Private Sub SetSubMissingValuesOnReturn(clsOperator As ROperator)
        ' Set the sub_missing parameter if it was configured
        If clsSubMissingRFunction IsNot Nothing AndAlso Not String.IsNullOrEmpty(clsSubMissingRFunction.strRCommand) Then
            clsOperator.AddParameter("sub_missing", clsRFunctionParameter:=clsSubMissingRFunction)
        Else
            clsOperator.RemoveParameterByName("sub_missing")
        End If
    End Sub

    Private Sub ucrTxtMissingText_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrTxtMissingText.ControlValueChanged
        UpdateSubMissingParam(ucrTxtMissingText.GetText())

    End Sub

    Private Sub SetupFormatFunctions(clsOperator As ROperator)
        lstFormatRFunctions.Clear()

        Dim clsFormatParams = clsTablesUtils.FindRFunctionsParamsWithRCommand(
        {"fmt", "fmt_units", "fmt_number", "fmt_currency"}, clsOperator)

        For Each clsParam In clsFormatParams
            Dim clsFunc As RFunction = clsParam.clsArgumentCodeStructure
            If clsFunc IsNot Nothing Then
                lstFormatRFunctions.Add(clsFunc)
            End If
        Next
    End Sub

    Private Sub SetFormatFunctionsOnReturn(clsOperator As ROperator)
        ' Remove existing
        clsTablesUtils.RemoveRFunctionsParamsWithRCommand(
        {"fmt", "fmt_units", "fmt_number", "fmt_currency"}, clsOperator)

        ' Add new
        For i = 0 To lstFormatRFunctions.Count - 1
            Dim clsFunc = lstFormatRFunctions(i)
            Dim strParamName = "fmt_param" & (i + 1)

            Dim clsParam As New RParameter(strParamName, clsFunc, bNewIncludeArgumentName:=False)
            clsOperator.AddParameter(strParameterName:=strParamName, clsRFunctionParameter:=clsFunc)

        Next
    End Sub

    '-----------------------------------------
End Class