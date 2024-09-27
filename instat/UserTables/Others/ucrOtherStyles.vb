Public Class ucrOtherStyles
    Private clsOperator As New ROperator
    Private bFirstload As Boolean = True

    Private Sub ucrOtherStyles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseControl()
            bFirstload = False
        End If
    End Sub

    Private Sub InitialiseControl()
        cboLocation.SelectedIndex = 0
    End Sub

    Public Sub Setup(clsOperator As ROperator)
        Me.clsOperator = clsOperator

        ' Clear and Set up the data grid with contents
        dataGridStyles.Rows.Clear()
        SetupDataGrid(clsTablesUtils.FindRFunctionsParamsWithRParamValue({"tab_style"}, "locations", "cells_footnotes", clsOperator), "Foot Notes")
        SetupDataGrid(clsTablesUtils.FindRFunctionsParamsWithRParamValue({"tab_style"}, "locations", "cells_source_notes", clsOperator), "Souce Notes")
    End Sub

    Private Sub SetupDataGrid(lstRParams As List(Of RParameter), strLocation As String)
        For Each clsRParam As RParameter In lstRParams
            ' Create a new row that represents the tab_style() parameters
            Dim row As New DataGridViewRow
            row.CreateCells(dataGridStyles)
            row.Cells(0).Value = strLocation
            row.Cells(1).Value = clsRParam.clsArgumentCodeStructure.Clone.ToScript

            ' Tag and add the tab_style() parameter function contents as a row
            row.Tag = clsRParam
            dataGridStyles.Rows.Add(row)
        Next
    End Sub

    Private Sub btnEnterStyle_Click(sender As Object, e As EventArgs) Handles btnEnterStyle.Click

        Dim clsListStyleRFunction As RFunction = clsTablesUtils.ShowStyleSubDialog(Me.ParentForm)
        If clsListStyleRFunction Is Nothing Then
            Exit Sub
        End If

        Dim clsLocationsRFunction As New RFunction
        clsLocationsRFunction.SetPackageName("gt")

        If cboLocation.Text = "Foot Notes" Then
            clsLocationsRFunction.SetRCommand("cells_footnotes")

        ElseIf cboLocation.Text = "Souce Notes" Then
            clsLocationsRFunction.SetRCommand("cells_source_notes")
        Else
            Exit Sub
        End If

        Dim clsTabStyleRFunction As RFunction = clsTablesUtils.GetNewStyleRFunction(clsListStyleRFunction, clsLocationsRFunction)

        ' Create parameter with unique name
        Dim clsRParam As New RParameter(strParameterName:="tab_style_others_param" & (dataGridStyles.Rows.Count + 1), strParamValue:=clsTabStyleRFunction, bNewIncludeArgumentName:=False)
        Dim row As DataGridViewRow = Nothing

        ' Update location style if it exists
        For Each existingRow As DataGridViewRow In dataGridStyles.Rows
            If existingRow.Cells(0).Value = cboLocation.Text Then
                row = existingRow
                row.Cells(1).Value = clsTabStyleRFunction.Clone.ToScript
                row.Tag = clsRParam
                Exit For
            End If
        Next

        ' If it does not exist then add new column label
        If row Is Nothing Then
            row = New DataGridViewRow
            row.CreateCells(dataGridStyles)
            row.Cells(0).Value = cboLocation.Text
            row.Cells(1).Value = clsTabStyleRFunction.Clone.ToScript
            row.Tag = clsRParam
            dataGridStyles.Rows.Add(row)
        End If
    End Sub

    Private Sub btnClearStyle_Click(sender As Object, e As EventArgs) Handles btnClearStyles.Click
        dataGridStyles.Rows.Clear()
    End Sub

    Public Sub SetValuesToOperator()
        clsTablesUtils.RemoveRParams(clsTablesUtils.FindRFunctionsParamsWithRParamValue({"tab_style"}, "locations", "cells_footnotes", clsOperator), clsOperator)
        clsTablesUtils.RemoveRParams(clsTablesUtils.FindRFunctionsParamsWithRParamValue({"tab_style"}, "locations", "cells_source_notes", clsOperator), clsOperator)
        clsTablesUtils.AddGridRowTagsRParamsToROperator(dataGridStyles, clsOperator)
    End Sub
End Class
