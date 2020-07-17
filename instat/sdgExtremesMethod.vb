Public Class sdgExtremesMethod
    Private clsFevdFunction As New RFunction
    Public bControlsInitialised As Boolean = False
    Public Sub InitialiseControls()
        ucrPanelExtreme.SetParameter(New RParameter("method"))
        ucrPanelExtreme.AddRadioButton(rdoMLE, Chr(34) & "MLE" & Chr(34))
        ucrPanelExtreme.AddRadioButton(rdoBayesian, Chr(34) & "Bayesian" & Chr(34))
        ucrPanelExtreme.AddRadioButton(rdoGMLE, Chr(34) & "GMLE" & Chr(34))
        ucrPanelExtreme.AddRadioButton(rdoLmoments, Chr(34) & "Lmoments" & Chr(34))
        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsNewFevdFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsFevdFunction = clsNewFevdFunction
        ucrPanelExtreme.SetRCode(clsFevdFunction, bReset)
    End Sub
End Class