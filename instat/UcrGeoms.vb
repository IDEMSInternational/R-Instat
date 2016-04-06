Public Class UcrGeoms
    Public lstAllGeoms As New List(Of Geoms)
    Public lstCurrentGeoms As New List(Of Geoms)

    Private Sub UcrGeoms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateGeomList()
        SetGeoms()

    End Sub

    Public Sub SetGeoms()
        For Each Geom In lstAllGeoms
            cboGeomList.Items.Add(Geom.strGeomName)
        Next

    End Sub

    Public Sub CreateGeomList()
        Dim clsgeom_boxplot As New Geoms

        clsgeom_boxplot.strGeomName = "geom_boxplot"
        clsgeom_boxplot.AddGeomParameter("", "")
        clsgeom_boxplot.AddGeomAes("")

        lstAllGeoms.Add(clsgeom_boxplot)
    End Sub
End Class
