Public Class sdgCreateFilter
    Public clsCurrentFilter As RFunction

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        clsCurrentFilter = ucrCreateFilter.clsFilterFunction
    End Sub

    Private Sub ucrCreateFilter_FilterChanged() Handles ucrCreateFilter.FilterChanged

    End Sub
End Class