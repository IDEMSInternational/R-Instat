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
Public Class dlgReferenceLevel
    Private bFirstLoad As Boolean = True
    Public strDefaultDataFrame As String = ""
    Private bReset As Boolean = True
    Private clsSetRefLevel As New RFunction
    Private lstRCodeStructure As List(Of RCodeStructure)
    Private Sub dlgReferenceLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 38

        ucrSelectorForReferenceLevels.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForReferenceLevels.SetParameterIsString()

        ucrReceiverReferenceLevels.SetParameter(New RParameter("col_name", 1))
        ucrReceiverReferenceLevels.SetParameterIsString()
        ucrReceiverReferenceLevels.Selector = ucrSelectorForReferenceLevels
        ucrReceiverReferenceLevels.SetMeAsReceiver()
        ucrReceiverReferenceLevels.SetIncludedDataTypes({"factor"}, bStrict:=True)
        ucrReceiverReferenceLevels.strSelectorHeading = "Factors"
        ucrReceiverReferenceLevels.SetExcludedDataTypes({"ordered,factor"})

        ucrFactorReferenceLevels.SetParameter(New RParameter("new_ref_level", 2))
        ucrFactorReferenceLevels.SetReceiver(ucrReceiverReferenceLevels)
        ucrFactorReferenceLevels.SetAsSingleSelector()
        ucrFactorReferenceLevels.SetIncludeLevels(False)
    End Sub

    Private Sub SetDefaults()
        clsSetRefLevel = New RFunction

        clsSetRefLevel.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_factor_reference_level")
        ucrSelectorForReferenceLevels.Reset()

        If IsNothing(lstRCodeStructure) Then
            'continue as normal
        ElseIf (lstRCodeStructure.Count > 1) Then
            MsgBox("Developer error: List of RCodeStructure must have only one RFunction")
        ElseIf (lstRCodeStructure.Count = 1) Then
            If Not IsNothing(TryCast(lstRCodeStructure(0), RFunction)) Then
                If TryCast(lstRCodeStructure(0), RFunction).strRCommand = frmMain.clsRLink.strInstatDataObject & "$set_factor_reference_level" Then
                    clsSetRefLevel = lstRCodeStructure(0)
                Else
                    MsgBox("Developer Error:This dialogue only allows Functions")
                End If
            End If
        End If
        lstRCodeStructure = Nothing

        ucrBase.clsRsyntax.SetBaseRFunction(clsSetRefLevel)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverReferenceLevels.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SetDefaultDataFrame()
        If strDefaultDataFrame <> "" Then
            ucrSelectorForReferenceLevels.SetDataframe(strDefaultDataFrame)
        End If
        strDefaultDataFrame = ""
    End Sub

    Private Sub ucrReceiverReferenceLevels_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverReferenceLevels.ControlContentsChanged
        TestOKEnabled()
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