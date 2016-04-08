Public Class UcrGeoms
    Public lstAllGeoms As New List(Of Geoms)
    Public lstCurrentGeoms As New List(Of Geoms)
    Public lstGgParameters As New List(Of RParameter)

    Private Sub UcrGeoms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateGeomList()
        SetGeoms()

    End Sub

    Public Sub SetGeoms()
        For Each Geom In lstAllGeoms
            cboGeomList.Items.Add(Geom.strGeomName)
        Next

    End Sub

    Public Sub AddParameter(strArgumentName As String, strArgumentValue As String)
        Dim i As Integer
        Dim clsParam As New RParameter
        i = lstGgParameters.FindIndex(Function(x) x.strArgumentName.Equals(strArgumentName))
        If i = -1 Then
            clsParam.SetArgumentName(strArgumentName)
            clsParam.SetArgumentValue(strArgumentValue)
            lstGgParameters.Add(clsParam)
        Else
            lstGgParameters(i).strArgumentValue = strArgumentValue
        End If
    End Sub

    Public Sub CreateGeomList()
        Dim clsgeom_boxplot As New Geoms

        clsgeom_boxplot.strGeomName = "geom_boxplot"
        clsgeom_boxplot.AddGgParameter("x", " ")
        clsgeom_boxplot.AddGgParameter("fill", " ")
        clsgeom_boxplot.AddGgParameter("colour", " ")
        clsgeom_boxplot.AddGgParameter("shape", " ")
        clsgeom_boxplot.AddGgParameter("lower", " ")
        clsgeom_boxplot.AddGgParameter("middle", " ")
        clsgeom_boxplot.AddGgParameter("upper", " ")
        clsgeom_boxplot.AddGgParameter("width", " ")
        lstAllGeoms.Add(clsgeom_boxplot)
    End Sub


End Class
