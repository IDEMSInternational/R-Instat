Public Class ucrCellFormatEmail

    Private clsFormatEmailRFunction, clsFromColumnRFunction As New RFunction
    Private bFirstload As Boolean = True

    Private Sub InitialiseControl()
        ucrReceiverSingleDisplayName.SetParameter(New RParameter("display_name", 0))
        ucrReceiverSingleDisplayName.SetParameterIsString()


        ucrChkAsButton.SetText("Display As Button")
        ucrChkAsButton.SetParameter(New RParameter("as_button", 5))
        ucrChkAsButton.SetRDefault("FALSE")

        ucrChkShowUnderline.SetText("Show underline")
    End Sub

    Public Sub Setup()
        If bFirstload Then
            InitialiseControl()
            bFirstload = False
        End If


        clsFormatEmailRFunction = New RFunction
        clsFormatEmailRFunction.SetRCommand("fmt_email")
        'TODO. This gt function is documented in https://gt.rstudio.com/reference/fmt_email.html but RStudio could not find the function.
        ' Implement later.

        clsFromColumnRFunction = New RFunction
        clsFromColumnRFunction.SetRCommand("from_column")

    End Sub


End Class
