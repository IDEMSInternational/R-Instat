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
Public Class dlgDummyVariables
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDummyFunction As New RFunction
    Private lstRCodeStructure As List(Of RCodeStructure)

    Private Sub dlgIndicatorVariable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 41
        ucrChkWithXVariable.Enabled = False ' temporary
        lblVariate.Enabled = False ' temporary
        ucrVariateReceiver.Enabled = False ' temporary
        grpLevelOmitted.Enabled = False ' temporary

        'Set Receiver
        ucrReceiverFactor.SetParameter(New RParameter("x", 0))
        ucrReceiverFactor.Selector = ucrSelectorDummyVariable
        ucrReceiverFactor.SetMeAsReceiver()
        ucrReceiverFactor.SetIncludedDataTypes({"factor"}, bStrict:=True)
        ucrReceiverFactor.strSelectorHeading = "Factors"
        ucrReceiverFactor.SetParameterIsRFunction()

        'Set RadioBattons : Parameters yet to be set up
        'ucrPnlLevelOmitted.SetParameter(New RParameter(""))
        'ucrPnlLevelOmitted.AddRadioButton(rdoNone, "")
        'ucrPnlLevelOmitted.AddRadioButton(rdoFirst, "")
        'ucrPnlLevelOmitted.AddRadioButton(rdoLast, "")
        'ucrPnlLevelOmitted.AddRadioButton(rdoLevelNumber, "")
        ucrPnlLevelOmitted.bAllowNonConditionValues = True
        'currently disabled sice the functions and parameters are yet to be set

        ' ucrChkWithXVariable.SetParameter(New RParameter(""))
        ucrChkWithXVariable.SetText("With X Variable")

        'ucrChkWithXVariable.AddToLinkedControls(ucrVariateReceiver, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
        'ucrVariateReceiver.SetLinkedDisplayControl(lblVariate)
        ucrVariateReceiver.Selector = ucrSelectorDummyVariable

        'ucrSaveDummy.SetPrefix("dummy")
        'ucrSaveDummy.SetSaveTypeAsColumn()
        'ucrSaveDummy.SetDataFrameSelector(ucrSelectorDummyVariable.ucrAvailableDataFrames)
        'ucrSaveDummy.SetCheckBoxText("Save Dummy:")
        'ucrSaveDummy.SetIsComboBox()
    End Sub

    Private Sub ResetFunction()
        clsDummyFunction = New RFunction
        clsDummyFunction.SetPackageName("dummies")
        clsDummyFunction.SetRCommand("dummy")
    End Sub

    Private Sub SetDefaults()
        ResetFunction()
        ucrSelectorDummyVariable.Reset()

        If IsNothing(lstRCodeStructure) Then

        ElseIf (lstRCodeStructure.Count > 1) Then
            MsgBox("Developer error: List of RCodeStructure must have only one RFunction")
        ElseIf (lstRCodeStructure.Count = 1) Then
            If Not IsNothing(TryCast(lstRCodeStructure(0), RFunction)) Then
                If TryCast(lstRCodeStructure(0), RFunction).strRCommand = "dummy" Then
                    clsDummyFunction = lstRCodeStructure(0)
                Else
                    MsgBox("This dialogue uses the ""dummy"" function only")
                End If
            Else
                    MsgBox("Developer error:The Script must be an RFunction")
            End If
        End If
        lstRCodeStructure = Nothing

        ucrBase.clsRsyntax.SetBaseRFunction(clsDummyFunction)
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:="dummy", strTempDataframe:=ucrSelectorDummyVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bAssignToColumnWithoutNames:=True)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverFactor.IsEmpty AndAlso ((ucrChkWithXVariable.Checked AndAlso Not ucrVariateReceiver.IsEmpty) OrElse Not ucrChkWithXVariable.Checked) Then
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

    'Private Sub SetMeAsReceiver()
    '    If ucrChkWithXVariable.Checked Then
    '        ucrVariateReceiver.SetMeAsReceiver()
    '    Else
    '        ucrReceiverFactor.SetMeAsReceiver()
    '    End If
    'End Sub

    'Private Sub ucrChkWithXVariable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkWithXVariable.ControlValueChanged
    '    VariateVisible()
    ' SetReceiver()
    'End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactor.ControlContentsChanged, ucrChkWithXVariable.ControlContentsChanged, ucrVariateReceiver.ControlContentsChanged
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