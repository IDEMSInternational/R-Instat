Namespace R_Adapter.RLink

    'ToDo would be good if R packages was passed in. Allowing them to be defined within the dialogs.
    Public Class RSetupOptions

        'These are passed in to allow for seperation - possible to have different front end version
        Public ReadOnly Property ExpectedMajorVersion As Integer

        Public ReadOnly Property ExpectedMinorVersion As Integer
        Public ReadOnly Property DirectoryOfRFiles As String
        Public ReadOnly Property RPath As String
        Public ReadOnly Property RHome As String
        Public Property NumberOfDigitsToDisplay As Integer
        Public Property ShowStarsOnCoefficients As Boolean

        Public Sub New(ByVal expectedMajorVersion As Integer, ByVal expectedMinorVersion As Integer, ByVal directoryOfRFiles As String, ByVal rPath As String, ByVal rHome As String)
            expectedMajorVersion = expectedMajorVersion
            expectedMinorVersion = expectedMinorVersion
            directoryOfRFiles = directoryOfRFiles
            rPath = rPath
            rHome = rHome
            NumberOfDigitsToDisplay = 4
            ShowStarsOnCoefficients = False
        End Sub

    End Class

End Namespace