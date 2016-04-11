Public Class UcrGeoms
    Public lstAllGeoms As New List(Of Geoms)
    Public lstCurrentGeoms As New List(Of Geoms)
    Public lstGgParameters As New List(Of RParameter)
    Public clsCurrGeom As New Geoms

    Private Sub UcrGeoms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateGeomList()
        SetGeoms()

    End Sub

    Public Sub SetGeoms()
        Dim GeomCount As New Geoms
        lstCurrentGeoms.Clear()
        cboGeomList.Items.Clear()

        For Each GeomCount In lstAllGeoms
            cboGeomList.Items.Add(GeomCount.strGeomName)
        Next
        lstCurrentGeoms.Add(GeomCount)

        cboGeomList.SelectedIndex = 0
    End Sub
    Public Sub CreateGeomList()
        Dim clsgeom_boxplot As New Geoms

        clsgeom_boxplot.strGeomName = "geom_boxplot"
        clsgeom_boxplot.AddGgParameter("x")
        clsgeom_boxplot.AddGgParameter("fill")
        clsgeom_boxplot.AddGgParameter("colour")
        clsgeom_boxplot.AddGgParameter("shape")
        clsgeom_boxplot.AddGgParameter("lower")
        clsgeom_boxplot.AddGgParameter("middle")
        clsgeom_boxplot.AddGgParameter("upper")
        clsgeom_boxplot.AddGgParameter("width")
        lstAllGeoms.Add(clsgeom_boxplot)
    End Sub
    Public Event cboGeomListIndexChanged(sender As Object, e As EventArgs)
    Private Sub cboDistributions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGeomList.SelectedIndexChanged
        clsCurrGeom = lstCurrentGeoms(cboGeomList.SelectedIndex)
        RaiseEvent cboGeomListIndexChanged(sender, e)
    End Sub
End Class
