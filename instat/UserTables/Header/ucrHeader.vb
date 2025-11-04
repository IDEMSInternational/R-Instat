
Public Class ucrHeader
    Private clsOperator As New ROperator
    Private clsHeaderRFunction, clsTitleFooterRFunction, clsSubtitleFooterRFunction, clsTitleLocationRFunction, clsSubtitleLocationRFunction, clsTitleStyleRFunction, clsSubtitleStyleRFunction As New RFunction
    Private bFirstload As Boolean = True

    Public Sub Setup(clsOperator As ROperator, Optional bShowSubtitle As Boolean = True)
        Me.clsOperator = clsOperator

        SetRFunctions(clsOperator)

        ' Set contents to the controls
        If clsHeaderRFunction.GetParameter("title") IsNot Nothing Then
            ucrInputTitle.SetName(clsTablesUtils.GetStringValue(clsHeaderRFunction.GetParameter("title").strArgumentValue, bwithQuotes:=False))
        End If

        If clsHeaderRFunction.GetParameter("subtitle") IsNot Nothing Then
            ucrInputSubtitle.SetName(clsTablesUtils.GetStringValue(clsHeaderRFunction.GetParameter("subtitle").strArgumentValue, bwithQuotes:=False))
        End If

        If clsTitleFooterRFunction.GetParameter("footnote") IsNot Nothing Then
            ucrInputTitleFooter.SetName(clsTablesUtils.GetStringValue(clsTitleFooterRFunction.GetParameter("footnote").strArgumentValue, bwithQuotes:=False))
        End If

        If clsSubtitleFooterRFunction.GetParameter("footnote") IsNot Nothing Then
            ucrInputSubtitleFooter.SetName(clsTablesUtils.GetStringValue(clsSubtitleFooterRFunction.GetParameter("footnote").strArgumentValue, bwithQuotes:=False))
        End If

        ' The general table dialog needs to hide the subtitle
        grpBoxSubtitle.Visible = bShowSubtitle
    End Sub

    Private Sub SetRFunctions(clsOperator As ROperator)
        clsHeaderRFunction = Nothing
        clsTitleStyleRFunction = Nothing
        clsSubtitleStyleRFunction = Nothing
        clsTitleLocationRFunction = Nothing
        clsSubtitleLocationRFunction = Nothing
        clsTitleFooterRFunction = Nothing
        clsSubtitleFooterRFunction = Nothing

        '--------------
        ' Set up the header R function for title and subtitle
        clsHeaderRFunction = clsTablesUtils.FindRFunctionsParamsWithRCommand({"tab_header"}, clsOperator).FirstOrDefault()?.clsArgumentCodeStructure
        If clsHeaderRFunction Is Nothing Then
            clsHeaderRFunction = New RFunction
            clsHeaderRFunction.SetPackageName("gt")
            clsHeaderRFunction.SetRCommand("tab_header")
        End If
        '--------------

        '--------------
        ' Set up the title and subtitle styles R function
        Dim lstTabStyleForRParams As List(Of RParameter) = clsTablesUtils.FindRFunctionsParamsWithRParamValue({"tab_style"}, "locations", "cells_title", clsOperator)
        For Each clsTabStyleRParam As RParameter In lstTabStyleForRParams
            For Each clsStyleLocationParam As RParameter In clsTabStyleRParam.clsArgumentCodeStructure.clsParameters
                If clsStyleLocationParam.strArgumentName = "locations" AndAlso clsStyleLocationParam.clsArgumentCodeStructure.ContainsParameter("groups") Then
                    If clsTablesUtils.GetStringValue(clsStyleLocationParam.clsArgumentCodeStructure.GetParameter("groups").strArgumentValue, False) = "title" Then
                        clsTitleStyleRFunction = clsTabStyleRParam.clsArgumentCodeStructure
                        clsTitleLocationRFunction = clsStyleLocationParam.clsArgumentCodeStructure
                    ElseIf clsTablesUtils.GetStringValue(clsStyleLocationParam.clsArgumentCodeStructure.GetParameter("groups").strArgumentValue, False) = "subtitle" Then
                        clsSubtitleStyleRFunction = clsTabStyleRParam.clsArgumentCodeStructure
                        clsSubtitleLocationRFunction = clsStyleLocationParam.clsArgumentCodeStructure
                    End If
                End If
            Next
        Next
        '--------------

        '--------------
        ' Set up the title footer and subtitle footer, locations R function
        Dim lstTabFootNoteRParams As List(Of RParameter) = clsTablesUtils.FindRFunctionsParamsWithRParamValue({"tab_footnote"}, "locations", "cells_title", clsOperator)
        For Each clsTabFootNoteRParam As RParameter In lstTabFootNoteRParams
            For Each clsFooterParam As RParameter In clsTabFootNoteRParam.clsArgumentCodeStructure.clsParameters
                If clsFooterParam.strArgumentName = "locations" AndAlso clsFooterParam.clsArgumentCodeStructure.ContainsParameter("groups") Then
                    If clsTablesUtils.GetStringValue(clsFooterParam.clsArgumentCodeStructure.GetParameter("groups").strArgumentValue, False) = "title" Then
                        clsTitleFooterRFunction = clsTabFootNoteRParam.clsArgumentCodeStructure
                        clsTitleLocationRFunction = clsFooterParam.clsArgumentCodeStructure
                    ElseIf clsTablesUtils.GetStringValue(clsFooterParam.clsArgumentCodeStructure.GetParameter("groups").strArgumentValue, False) = "subtitle" Then
                        clsSubtitleFooterRFunction = clsTabFootNoteRParam.clsArgumentCodeStructure
                        clsSubtitleLocationRFunction = clsFooterParam.clsArgumentCodeStructure
                    End If
                End If
            Next
        Next

        If clsTitleFooterRFunction Is Nothing Then
            clsTitleLocationRFunction = GetNewCellsTitleRFunction("title")
            clsTitleFooterRFunction = New RFunction

            clsTitleFooterRFunction.SetPackageName("gt")
            clsTitleFooterRFunction.SetRCommand("tab_footnote")
            clsTitleFooterRFunction.AddParameter(strParameterName:="locations", clsRFunctionParameter:=clsTitleLocationRFunction, iPosition:=1)
        End If

        If clsSubtitleFooterRFunction Is Nothing Then
            clsSubtitleLocationRFunction = GetNewCellsTitleRFunction("subtitle")
            clsSubtitleFooterRFunction = New RFunction

            clsSubtitleFooterRFunction.SetPackageName("gt")
            clsSubtitleFooterRFunction.SetRCommand("tab_footnote")
            clsSubtitleFooterRFunction.AddParameter(strParameterName:="locations", clsRFunctionParameter:=clsSubtitleLocationRFunction, iPosition:=1)
        End If
        '--------------
    End Sub

    Private Function GetNewCellsTitleRFunction(strGroupParamValue As String)
        Dim clsCellsTitleRFunction As New RFunction
        clsCellsTitleRFunction.SetPackageName("gt")
        clsCellsTitleRFunction.SetRCommand("cells_title")
        clsCellsTitleRFunction.AddParameter(strParameterName:="groups", strParameterValue:=Chr(34) & strGroupParamValue & Chr(34), iPosition:=0)
        Return clsCellsTitleRFunction
    End Function

    Private Sub btnTitleFormat_Click(sender As Object, e As EventArgs) Handles btnTitleStyle.Click
        Dim clsListStyleRFunction As RFunction = clsTablesUtils.ShowStyleSubDialog(Me.ParentForm, clsTitleStyleRFunction)
        If clsListStyleRFunction Is Nothing Then
            Exit Sub
        End If

        clsTitleStyleRFunction = clsTablesUtils.GetNewStyleRFunction(clsListStyleRFunction, clsTitleLocationRFunction)
    End Sub


    Private Sub btnSubtitleFormat_Click(sender As Object, e As EventArgs) Handles btnSubTitleStyle.Click
        Dim clsListStyleRFunction As RFunction = clsTablesUtils.ShowStyleSubDialog(Me.ParentForm, clsSubtitleStyleRFunction)
        If clsListStyleRFunction Is Nothing Then
            Exit Sub
        End If

        clsSubtitleStyleRFunction = clsTablesUtils.GetNewStyleRFunction(clsListStyleRFunction, clsSubtitleLocationRFunction)
    End Sub

    Private Sub ucrInputControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputTitle.ControlContentsChanged, ucrInputTitleFooter.ControlContentsChanged, ucrInputSubtitle.ControlContentsChanged, ucrInputSubtitleFooter.ControlContentsChanged
        ucrInputTitleFooter.Enabled = Not ucrInputTitle.IsEmpty()
        ucrInputSubtitle.Enabled = Not ucrInputTitle.IsEmpty()
        ucrInputSubtitleFooter.Enabled = ucrInputSubtitle.Enabled AndAlso Not ucrInputSubtitle.IsEmpty()
    End Sub

    Public Sub SetValuesToOperator()
        SetValuesToOperator(clsOperator)
    End Sub

    Public Sub SetValuesToOperator(clsOperator As ROperator)

        ' Remove any previous header parameters 
        clsTablesUtils.RemoveRFunctionsParamsWithRCommand({"tab_header"}, clsOperator)
        clsTablesUtils.RemoveRParams(clsTablesUtils.FindRFunctionsParamsWithRParamValue({"tab_footnote", "tab_style"}, "locations", "cells_title", clsOperator), clsOperator)


        ' Add new changes
        If Not ucrInputTitle.IsEmpty Then
            clsOperator.AddParameter(strParameterName:="tab_header_param", clsRFunctionParameter:=clsHeaderRFunction)

            clsHeaderRFunction.AddParameter(strParameterName:="title", strParameterValue:=Chr(34) & ucrInputTitle.GetText() & Chr(34), iPosition:=0)
            If Not ucrInputSubtitle.IsEmpty Then
                clsHeaderRFunction.AddParameter(strParameterName:="subtitle", strParameterValue:=Chr(34) & ucrInputSubtitle.GetText() & Chr(34), iPosition:=1)
            End If


            If Not ucrInputTitleFooter.IsEmpty Then
                clsOperator.AddParameter(strParameterName:="tab_footer_for_title_param", clsRFunctionParameter:=clsTitleFooterRFunction)
                clsTitleFooterRFunction.AddParameter(strParameterName:="footnote", strParameterValue:=Chr(34) & ucrInputTitleFooter.GetText() & Chr(34), iPosition:=0)
            End If

            If Not ucrInputSubtitleFooter.IsEmpty Then
                clsOperator.AddParameter(strParameterName:="tab_footer_for_subtitle_param", clsRFunctionParameter:=clsSubtitleFooterRFunction)
                clsSubtitleFooterRFunction.AddParameter(strParameterName:="footnote", strParameterValue:=Chr(34) & ucrInputSubtitleFooter.GetText() & Chr(34), iPosition:=0)
            End If
        End If

        If clsTitleStyleRFunction IsNot Nothing Then
            clsOperator.AddParameter(strParameterName:="tab_style_for_title_param", clsRFunctionParameter:=clsTitleStyleRFunction)
        End If

        If clsSubtitleStyleRFunction IsNot Nothing Then
            clsOperator.AddParameter(strParameterName:="tab_style_for_subtitle_param", clsRFunctionParameter:=clsSubtitleStyleRFunction)
        End If
    End Sub

End Class
