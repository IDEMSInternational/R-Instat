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
    Public clsReadInputs, clsDataFunction, clsListFunction As New RFunction
    Private Sub sdgMissingOptionsEvapotranspiration_Load(sender As Object, e As EventArgs) Handles ucrSdgButtons.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        'Location'
        ucrNudLatitude.SetParameter(New RParameter("lat_rad", 2))
        ucrNudLatitude.SetMinMax(0, 1.57)
        ucrNudLatitude.DecimalPlaces = 2
        ucrNudLatitude.Increment = 0.01
        ucrNudLatitude.SetLinkedDisplayControl(lblLatitude)
        ucrNudLatitude.SetRDefault(0.00)


        ucrNudAltitude.SetParameter(New RParameter("Elev", 0))
        ucrNudAltitude.SetMinMax(0, 5000)
        ucrNudAltitude.Increment = 1
        ucrNudAltitude.SetRDefault(0)
        ucrNudAltitude.SetLinkedDisplayControl(lblAltitude)

        ucrNudLongitude.SetParameter(New RParameter("Y", 9))
        ucrNudLongitude.SetMinMax(-3.2, 3.2)
        ucrNudLongitude.DecimalPlaces = 2
        ucrNudLongitude.Increment = 0.01
        ucrNudLongitude.SetLinkedDisplayControl(lblLongitude)
        ucrNudLongitude.SetRDefault(0.00)

        'Constants'
        ucrNudLambda.SetParameter(New RParameter("lambda", 1))
        ucrNudLambda.SetMinMax(0, 10)
        ucrNudLambda.DecimalPlaces = 2
        ucrNudLambda.Increment = 0.01
        ucrNudLambda.SetLinkedDisplayControl(lblLambda)
        ucrNudLambda.SetRDefault(2.45)

        ucrInputSigma.SetParameter(New RParameter("sigma", 5))
        ucrInputSigma.AddQuotesIfUnrecognised = False
        'ucrInputSigma.SetValidationTypeAsNumeric()
        'ucrInputSigma.SetLinkedDisplayControl(lblSigma)
        ''ucrInputSigma.SetRDefault(4.903 * 10 ^ -9)

        ucrNudSolar.SetParameter(New RParameter("Gsc", 3))
        ucrNudSolar.SetMinMax(0, 1)
        ucrNudSolar.DecimalPlaces = 3
        ucrNudSolar.Increment = 0.001
        ucrNudSolar.SetLinkedDisplayControl(lblSolarConstant)
        ucrNudSolar.SetRDefault(0.082)

        ucrNudHeith.SetParameter(New RParameter("z", 4))
        ucrNudHeith.SetMinMax(0, 10)
        ucrNudHeith.Increment = 1
        ucrNudHeith.SetRDefault(2)

        ucrNudSoil.SetParameter(New RParameter("G", 6))
        ucrNudSoil.SetMinMax(0, 10)
        ucrNudSoil.DecimalPlaces = 2
        ucrNudSoil.Increment = 0.01
        ucrNudSoil.SetLinkedDisplayControl(lblSoilHeatFlux)
        ucrNudSoil.SetRDefault(0.00)

        ucrNudAS.SetParameter(New RParameter("as", 7))
        ucrNudAS.SetMinMax(0, 1)
        ucrNudAS.DecimalPlaces = 2
        ucrNudAS.Increment = 0.01
        ucrNudAS.SetLinkedDisplayControl(lblAS)
        ucrNudAS.SetRDefault(0.25)

        ucrNudBS.SetParameter(New RParameter("bs", 8))
        ucrNudBS.SetMinMax(0, 1)
        ucrNudBS.DecimalPlaces = 2
        ucrNudBS.Increment = 0.01
        ucrNudBS.SetLinkedDisplayControl(lblBS)
        ucrNudBS.SetRDefault(0.5)
    End Sub

    Public Sub SetRFunction(clsNewReadInputs As RFunction, clsNewDataFunction As RFunction, clsNewListFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsReadInputs = clsNewReadInputs
        clsDataFunction = clsNewDataFunction
        clsListFunction = clsNewListFunction

        ucrNudLatitude.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrNudAltitude.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrNudLongitude.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrNudHeith.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrNudLambda.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrInputSigma.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrNudSoil.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrNudSolar.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrNudAS.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrNudBS.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
    End Sub
End Class