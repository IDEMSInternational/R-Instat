' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version. 
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class sdgPMConstants
    Public bFirstLoad As Boolean = True
    Public bControlsInitialised As Boolean = False
    Public clsListFunction As New RFunction
    Private bRCodeset As Boolean = True
    Private Sub sdgPMConstants_Load(sender As Object, e As EventArgs) Handles  UcrButtonsSubdialogue1.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        ucrInputLambda.SetParameter(New RParameter("lambda", 1))
        ucrInputLambda.AddQuotesIfUnrecognised = False
        'ucrInputLambda.IsReadOnly = True
        ucrInputLambda.SetLinkedDisplayControl(lblLambda)
        'ucrInputLambda.SetRDefault(2.45)

        ucrInputSigma.SetParameter(New RParameter("sigma", 5))
        ucrInputSigma.AddQuotesIfUnrecognised = False
        'ucrInputSigma.IsReadOnly = True
        'ucrInputSigma.SetRDefault(4.903 * 10 ^ -9)

        ucrInputSolarConstant.SetParameter(New RParameter("Gsc", 3))
        ucrInputSolarConstant.AddQuotesIfUnrecognised = False
        'ucrInputSolarConstant.IsReadOnly = True
        ucrInputSolarConstant.SetLinkedDisplayControl(lblSolarConstant)
        'ucrInputSolarConstant.SetRDefault(0.082)

        ucrNudHeigth.SetParameter(New RParameter("z", 4))
        ucrNudHeigth.SetMinMax(0, 10)
        ucrNudHeigth.Increment = 1
        'ucrNudHeigth.SetRDefault(2)

        ucrInputSoilFlux.SetParameter(New RParameter("G", 6))
        ucrInputSoilFlux.AddQuotesIfUnrecognised = False
        ucrInputSoilFlux.SetLinkedDisplayControl(lblSoilFlux)
        'ucrInputSoilFlux.SetRDefault(0)

        'Radiation Constants'
        ucrInputAs.SetParameter(New RParameter("as", 7))
        ucrInputAs.AddQuotesIfUnrecognised = False
        'ucrInputAs.IsReadOnly = True
        ucrInputAs.SetLinkedDisplayControl(lblAS)
        'ucrInputAs.SetRDefault(0.25)

        ucrInputBS.SetParameter(New RParameter("bs", 8))
        ucrInputBS.AddQuotesIfUnrecognised = False
        'ucrInputBS.IsReadOnly = True
        ucrInputBS.SetLinkedDisplayControl(lblBS)
        'ucrInputBS.SetRDefault(0.5)

        bControlsInitialised = True

    End Sub

    Public Sub SetRFunction(clsNewListFunction As RFunction, Optional bReset As Boolean = False)
        clsListFunction = clsNewListFunction
        bRCodeset = False
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        ucrNudHeigth.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLambda.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrInputSigma.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrInputSoilFlux.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrInputSolarConstant.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrInputAS.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrInputBS.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        bRCodeset = True
    End Sub
End Class