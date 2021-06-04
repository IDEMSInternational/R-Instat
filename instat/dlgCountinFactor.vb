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
Public Class dlgCountinFactor
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultFunction As New RFunction
    Private lstRCodeStructure As List(Of RCodeStructure)

    Private Sub dlgCountinFactor_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 457

        'ucrReceiver
        ucrCountReceiver.SetParameter(New RParameter("nesting.fac", 0))
        ucrCountReceiver.SetParameterIsRFunction()
        ucrCountReceiver.Selector = ucrCountSelector
        ucrCountReceiver.SetIncludedDataTypes({"factor"}, bStrict:=True)
        ucrCountReceiver.strSelectorHeading = "Factors"
        ucrCountReceiver.SetMeAsReceiver()
        ucrCountReceiver.bUseFilteredData = False

        ' ucrNewColName
        ucrNewColName.SetIsComboBox()
        ucrNewColName.SetPrefix("Count")
        ucrNewColName.SetSaveTypeAsColumn()
        ucrNewColName.SetDataFrameSelector(ucrCountSelector.ucrAvailableDataFrames)
        ucrNewColName.SetLabelText("New Column Name:")
        ucrNewColName.setLinkedReceiver(ucrCountReceiver)
    End Sub

    Private Sub SetRFunctionDefaultParameters()
        clsDefaultFunction.SetPackageName("dae")
        clsDefaultFunction.SetRCommand("fac.nested")
        clsDefaultFunction.SetAssignTo(strTemp:=ucrNewColName.GetText(), strTempDataframe:=ucrCountSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColName.GetText())

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction

        ucrCountSelector.Reset()
        ucrNewColName.Reset()

        If IsNothing(lstRCodeStructure) Then
            SetRFunctionDefaultParameters()
        ElseIf (lstRCodeStructure.Count > 1) Then
            SetRFunctionDefaultParameters()
            MsgBox("Developer error: List of RCodeStructure must have only one RFunction")
        ElseIf (lstRCodeStructure.Count = 1) Then
            If Not IsNothing(TryCast(lstRCodeStructure(0), RFunction)) Then
                If TryCast(lstRCodeStructure(0), RFunction).strRCommand = "fac.nested" Then
                    clsDefaultFunction = lstRCodeStructure(0)
                    ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
                Else
                    SetRFunctionDefaultParameters()
                    MsgBox("Developer error:This dialogue only uses one Function ie ""fac.nested""")
                End If
            Else
                SetRFunctionDefaultParameters()
                MsgBox("Developer error:The Script must be an RFunction")
            End If
        End If
        lstRCodeStructure = Nothing
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrCountReceiver.IsEmpty AndAlso ucrNewColName.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrCountReceiver_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrCountReceiver.ControlContentsChanged, ucrNewColName.ControlContentsChanged
        TestOkEnabled()
    End Sub
    Public Property lstScriptsRCodeStructure As List(Of RCodeStructure)
        Get
            Return lstRCodeStructure
        End Get
        Set(lstNewRCodeStructure As List(Of RCodeStructure))
            lstRCodeStructure = lstNewRCodeStructure
            bReset = True
        End Set
    End Property
End Class