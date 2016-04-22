Public Class UcrGeoms
    Public strGgParameterName As String
    Public strGgParameterValue As String
    Public lstAllGeoms As New List(Of Geoms)
    Public lstGgParameters As New List(Of RParameter)
    Public clsCurrRFunction As New RFunction
    Public clsCurrGeom As New Geoms
    Public lstFunctionParameters As New List(Of RParameter)
    Private bFirstLoad As Boolean = True

    Private Sub UcrGeoms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            CreateGeomList()
            SetGeoms()
            bFirstLoad = False
        End If
    End Sub

    Public Sub SetGeoms()
        Dim GeomCount As New Geoms
        cboGeomList.Items.Clear()
        For Each GeomCount In lstAllGeoms
            cboGeomList.Items.Add(GeomCount.strGeomName)
        Next
        cboGeomList.SelectedIndex = 0
    End Sub

    Public Sub AddParameter(strGgParameterName As String, strGgParameterValue As String)
        'this adds parameters TODO pass appropriate parameters.
        Dim i As Integer
        Dim clsParam As New RParameter
        i = lstFunctionParameters.FindIndex(Function(x) x.strArgumentName.Equals(Me.strGgParameterName))
        If i = -1 Then
            clsParam.SetArgumentName(Me.strGgParameterName)
            clsParam.SetArgumentValue(Me.strGgParameterValue)
            lstFunctionParameters.Add(clsParam)
        Else
            lstFunctionParameters(i).strArgumentValue = Me.strGgParameterValue
        End If
    End Sub


    Public Sub CreateGeomList()
        Dim clsgeom_boxplot As New Geoms
        Dim clsgeom_dotplot As New Geoms
        Dim clsgeom_histogram As New Geoms

        clsgeom_boxplot.strGeomName = "geom_boxplot"
        clsgeom_boxplot.AddGgParameter("x")
        clsgeom_boxplot.AddGgParameter("fill")
        clsgeom_boxplot.AddGgParameter("colour")
        clsgeom_boxplot.AddGgParameter("shape")
        clsgeom_boxplot.AddGgParameter("lower")
        clsgeom_boxplot.AddGgParameter("middle")
        clsgeom_boxplot.AddGgParameter("upper")
        lstAllGeoms.Add(clsgeom_boxplot)


        clsgeom_dotplot.strGeomName = "geom_dotplot"
        clsgeom_dotplot.AddGgParameter("x")
        clsgeom_dotplot.AddGgParameter("y")
        clsgeom_dotplot.AddGgParameter("alpha")
        clsgeom_dotplot.AddGgParameter("colour")
        clsgeom_dotplot.AddGgParameter("fill")
        lstAllGeoms.Add(clsgeom_dotplot)


        clsgeom_histogram.strGeomName = "geom_histogram"
        clsgeom_histogram.AddGgParameter("x")
        clsgeom_histogram.AddGgParameter("alpha")
        clsgeom_histogram.AddGgParameter("colour")
        clsgeom_histogram.AddGgParameter("fill")
        clsgeom_histogram.AddGgParameter("linetype")
        clsgeom_histogram.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_histogram)

    End Sub
    Public Event cboGeomListIndexChanged(sender As Object, e As EventArgs)
    Private Sub cboDistributions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGeomList.SelectedIndexChanged
        clsCurrGeom = lstAllGeoms(cboGeomList.SelectedIndex)
        clsCurrRFunction.SetRCommand(clsCurrGeom.strGeomName)
        'clsCurrRFunction.SetRCommand(cboGeomList.SelectedItem) 'i wonder what the difference is with previous line
        RaiseEvent cboGeomListIndexChanged(sender, e)

    End Sub

End Class
