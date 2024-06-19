
Public Class ucrHeader
    Private clsOperator As New ROperator
    Private clsTabTitleFootRParameter, clsTabSubtitleFootRParameter As RParameter
    Private clsTitleFootNoteRFunction, clsSubtitleFootNoteRFunction As New RFunction

    Private bFirstload As Boolean = True

    Private Sub InitialiseDialog()
        ucrInputHeaderTitleFooter.SetParameter(New RParameter("title_footer_text_param", 0, bNewIncludeArgumentName:=False))
        ucrInputHeaderTitleFooter.SetLinkedDisplayControl(New List(Of Control)({lblHeaderTitle, btnHeaderTitleFooterFormat}))

        ucrInputHeaderSubtitleFooter.SetParameter(New RParameter("subtitle_footer_text_param", 0, bNewIncludeArgumentName:=False))
        ucrInputHeaderSubtitleFooter.SetLinkedDisplayControl(New List(Of Control)({lblHeaderSubtitle, btnHeaderSubTitleFooterFormat}))
    End Sub

    Public Sub Setup(clsNewOperator As ROperator)
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If

        clsOperator = clsNewOperator

        clsTabTitleFootRParameter = Nothing
        clsTitleFootNoteRFunction = Nothing

        clsTabSubtitleFootRParameter = Nothing
        clsSubtitleFootNoteRFunction = Nothing

        SetupRFunctionsFromOperator()

        If clsTabTitleFootRParameter Is Nothing Then
            Dim clsTabTitleFootRFunction As New RFunction
            clsTabTitleFootRFunction.SetPackageName("gt")
            clsTabTitleFootRFunction.SetRCommand("tab_footnote")

            clsTitleFootNoteRFunction = clsTablesUtils.GetNewHtmlSpanRFunction()

            clsTabTitleFootRFunction.AddParameter(New RParameter(strParameterName:="footnote", strParamValue:=clsTitleFootNoteRFunction, iNewPosition:=0))
            clsTabTitleFootRFunction.AddParameter(New RParameter(strParameterName:="locations", strParamValue:=GetNewTitleLocationRFunction("title"), iNewPosition:=1))

            clsTabTitleFootRParameter = New RParameter("title_footer_param", clsTabTitleFootRFunction, bNewIncludeArgumentName:=False)
        End If

        If clsTabSubtitleFootRParameter Is Nothing Then
            Dim clsTabSubtitleFootRFunction As New RFunction
            clsTabSubtitleFootRFunction.SetPackageName("gt")
            clsTabSubtitleFootRFunction.SetRCommand("tab_footnote")

            clsSubtitleFootNoteRFunction = clsTablesUtils.GetNewHtmlSpanRFunction()

            clsTabSubtitleFootRFunction.AddParameter(New RParameter(strParameterName:="footnote", strParamValue:=clsSubtitleFootNoteRFunction, iNewPosition:=0))
            clsTabSubtitleFootRFunction.AddParameter(New RParameter(strParameterName:="locations", strParamValue:=GetNewTitleLocationRFunction("subtitle"), iNewPosition:=1))

            clsTabSubtitleFootRParameter = New RParameter("subtitle_footer_param", clsTabSubtitleFootRFunction, bNewIncludeArgumentName:=False)
        End If

        ucrInputHeaderTitleFooter.SetRCode(clsTitleFootNoteRFunction, bReset:=True)
        ucrInputHeaderSubtitleFooter.SetRCode(clsSubtitleFootNoteRFunction, bReset:=True)

    End Sub

    Private Sub SetupRFunctionsFromOperator()
        Dim lstRParams As List(Of RParameter) = clsTablesUtils.FindRFunctionsParamsWithRCommand({"tab_footnote"}, clsOperator)

        For Each clsTabFooterRParam As RParameter In lstRParams

            Dim clsFootNoteRFunction As RFunction = Nothing
            Dim clsLocationsRFunction As RFunction = Nothing

            For Each clsFootNoteRParam As RParameter In clsTabFooterRParam.clsArgumentCodeStructure.clsParameters
                If clsFootNoteRParam.strArgumentName = "footnote" Then
                    clsFootNoteRFunction = clsFootNoteRParam.clsArgumentCodeStructure
                ElseIf clsFootNoteRParam.strArgumentName = "locations" Then
                    Dim clsNewLocationRFunction As RFunction = clsFootNoteRParam.clsArgumentCodeStructure
                    If clsNewLocationRFunction.strRCommand = "cells_title" Then
                        clsLocationsRFunction = clsNewLocationRFunction
                    End If
                End If
            Next

            If clsFootNoteRFunction IsNot Nothing AndAlso clsLocationsRFunction IsNot Nothing AndAlso clsLocationsRFunction.clsParameters.Count > 0 Then
                If clsLocationsRFunction.clsParameters(0).strArgumentValue = clsTablesUtils.GetStringValue("title", True) Then
                    clsTabTitleFootRParameter = clsTabFooterRParam
                    clsTitleFootNoteRFunction = clsFootNoteRFunction
                ElseIf clsLocationsRFunction.clsParameters(0).strArgumentValue = clsTablesUtils.GetStringValue("subtitle", True) Then
                    clsTabSubtitleFootRParameter = clsTabFooterRParam
                    clsSubtitleFootNoteRFunction = clsFootNoteRFunction
                End If
            End If

        Next
    End Sub

    Private Function GetNewTitleLocationRFunction(StrLocation As String) As RFunction
        Dim clsLocationRFunction As New RFunction
        clsLocationRFunction.SetPackageName("gt")
        clsLocationRFunction.SetRCommand("cells_title")
        clsLocationRFunction.AddParameter(New RParameter(strParameterName:="groups", strParamValue:=Chr(34) & StrLocation & Chr(34)))
        Return clsLocationRFunction
    End Function

    Private Sub btnHeaderTitleFooterFormat_Click(sender As Object, e As EventArgs) Handles btnHeaderTitleFooterFormat.Click
        clsTablesUtils.ShowTextFormatSubDialog(Me.ParentForm, clsTitleFootNoteRFunction)
    End Sub

    Private Sub btnHeaderSubTitleFooterFormat_Click(sender As Object, e As EventArgs) Handles btnHeaderSubTitleFooterFormat.Click
        clsTablesUtils.ShowTextFormatSubDialog(Me.ParentForm, clsSubtitleFootNoteRFunction)
    End Sub

    Private Sub ucrInputHeaderTitleFooter_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputHeaderTitleFooter.ControlValueChanged
        If ucrInputHeaderTitleFooter.IsEmpty Then
            clsOperator.RemoveParameter(clsTabTitleFootRParameter)
        Else
            clsOperator.AddParameter(clsTabTitleFootRParameter)
        End If
    End Sub

    Private Sub ucrInputHeaderFooter_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputHeaderTitleFooter.ControlValueChanged, ucrInputHeaderSubtitleFooter.ControlValueChanged
        If ucrInputHeaderTitleFooter.IsEmpty OrElse ucrInputHeaderSubtitleFooter.IsEmpty Then
            clsOperator.RemoveParameter(clsTabSubtitleFootRParameter)
        Else
            clsOperator.AddParameter(clsTabSubtitleFootRParameter)
        End If
    End Sub
End Class
