Public Class sdgCreateFilter
    Public clsCurrentFilter As RFunction
    Public bFilterDefined As Boolean
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        clsCurrentFilter = ucrCreateFilter.clsFilterFunction
        bFilterDefined = ucrCreateFilter.bFilterDefined
    End Sub

    Private Sub ucrCreateFilter_FilterChanged() Handles ucrCreateFilter.FilterChanged
        bFilterDefined = ucrCreateFilter.bFilterDefined
    End Sub
End Class