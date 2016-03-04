Public Class ucrInputConfidenceLimit
    Public Event NameChanged()
    Private Sub ucrConfidenceLimit_NameChanged() Handles ucrConfidenceLimit.NameChanged
        RaiseEvent NameChanged()
    End Sub

    Private Sub ucrInputConfidenceLimit_Load(sender As Object, e As EventArgs) Handles Me.Load
        ucrConfidenceLimit.AddItems({99.9, 99, 95, 90, 85, 80})
        ucrConfidenceLimit.SetValidationTypeAsNumeric(dcmMin:=0, bIncludeMin:=False, dcmMax:=100, bIncludeMax:=False)
        ucrConfidenceLimit.SetName(95)
    End Sub
End Class
