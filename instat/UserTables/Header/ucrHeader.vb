
Public Class ucrHeader
    Private clsOperator As New ROperator
    Private clsHeaderRFunction, clsTitleFooterRFunction, clsSubtitleFooterRFunction, clsTitleLocationRFunction, clsSubtitleLocationRFunction, clsTitleStyleRFunction, clsSubtitleStyleRFunction As New RFunction


    Private bFirstload As Boolean = True

    Private Sub InitialiseDialog()

        ucrInputTitle.SetParameter(New RParameter("title", iNewPosition:=0))

        ucrInputSubtitle.SetParameter(New RParameter("subtitle", iNewPosition:=1))

        ucrInputTitleFooter.SetParameter(New RParameter("footnote", iNewPosition:=0))

        ucrInputSubtitleFooter.SetParameter(New RParameter("footnote", iNewPosition:=0))

    End Sub

    Public Sub Setup(clsOperator As ROperator)
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If

        Me.clsOperator = clsOperator

        SetRFunctions(clsOperator)
        SetRCode()

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

    Private Sub SetRCode()

        ucrInputTitle.SetRCode(clsHeaderRFunction, True, bCloneIfNeeded:=True)
        ucrInputSubtitle.SetRCode(clsHeaderRFunction, True, bCloneIfNeeded:=True)

        ucrInputTitleFooter.SetRCode(clsTitleFooterRFunction, True, bCloneIfNeeded:=True)
        ucrInputSubtitleFooter.SetRCode(clsSubtitleFooterRFunction, True, bCloneIfNeeded:=True)

    End Sub

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
        ' Remove any previous header parameters 
        clsTablesUtils.RemoveRFunctionsParamsWithRCommand({"tab_header"}, clsOperator)
        clsTablesUtils.RemoveRParams(clsTablesUtils.FindRFunctionsParamsWithRParamValue({"tab_footnote", "tab_style"}, "locations", "cells_title", clsOperator), clsOperator)

        ' Add new changes
        If Not ucrInputTitle.IsEmpty Then
            clsOperator.AddParameter(strParameterName:="tab_header_param", clsRFunctionParameter:=clsHeaderRFunction)

            If ucrInputTitleFooter.Enabled AndAlso Not ucrInputTitleFooter.IsEmpty Then
                clsOperator.AddParameter(strParameterName:="tab_footer_for_tile_param", clsRFunctionParameter:=clsTitleFooterRFunction)
            End If

            If ucrInputSubtitleFooter.Enabled AndAlso Not ucrInputSubtitleFooter.IsEmpty Then
                clsOperator.AddParameter(strParameterName:="tab_footer_for_subtitle_param", clsRFunctionParameter:=clsSubtitleFooterRFunction)
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
