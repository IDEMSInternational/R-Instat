Imports System.ComponentModel
Imports System.Reflection
Imports System.Runtime
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization

Public Class clsControlJson
    Public Property strName As String
    Public Property strType As String
    Public Property dctFields As Dictionary(Of String, Object)

    Public Sub New(clsControl As Control)

        strName = clsControl.Name
        strType = clsControl.GetType().Name

        dctFields = New Dictionary(Of String, Object)
        Dim bindingFlags As Reflection.BindingFlags =
                Reflection.BindingFlags.Public _
                Or Reflection.BindingFlags.NonPublic _
                Or Reflection.BindingFlags.Instance _
                Or Reflection.BindingFlags.FlattenHierarchy

        For Each clsField As Reflection.FieldInfo In clsControl.GetType().GetFields(bindingFlags)
            Dim clsFieldType As Type = clsField.FieldType
            If clsFieldType Is GetType(ucrNud) Then
                Console.WriteLine("*** ignored ucrNud: " & clsField.Name)
            ElseIf GetType(RSyntax).IsAssignableFrom(clsFieldType) Then
                Dim clsRSyntax As RSyntax = DirectCast(clsField.GetValue(clsControl), RSyntax)
                If clsRSyntax IsNot Nothing Then
                    dctFields.Add(clsField.Name, clsRSyntax)
                End If
            ElseIf GetType(ucrReceiverSingle).IsAssignableFrom(clsFieldType) Then
                Dim ucrReceiverSingle As ucrReceiverSingle = DirectCast(clsField.GetValue(clsControl), ucrReceiverSingle)
                If ucrReceiverSingle IsNot Nothing Then
                    Dim ucrReceiverSingleJson = New ucrReceiverSingleJson(ucrReceiverSingle)
                    dctFields.Add(clsField.Name, ucrReceiverSingleJson)
                End If
            ElseIf GetType(Control).IsAssignableFrom(clsFieldType) Then 'field is a WinForm control
                Console.WriteLine(clsField.Name)
                dctFields.Add(clsField.Name, New clsControlJson(clsField.GetValue(clsControl)))
                'Else
                '    dctFields.Add(clsField.Name, clsField.GetValue(clsControl))
                '    Dim clsJsonSettings As New JsonSerializerSettings With {
                '            .ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                '            .Formatting = Formatting.Indented
                '    }
                '    Console.WriteLine("***" & clsField.Name & vbCrLf & JsonConvert.SerializeObject(clsField.GetValue(clsControl), clsJsonSettings))
            End If
        Next

    End Sub

    Public Function ToJsonString() As String
        Dim clsJsonSettings As New JsonSerializerSettings With {
            .ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            .Formatting = Formatting.Indented
        }
        Return JsonConvert.SerializeObject(Me, clsJsonSettings)
    End Function

    Public Shared Function FromJsonString(jsonString As String) As clsControlJson
        Return JsonConvert.DeserializeObject(Of clsControlJson)(jsonString)
    End Function

    Public Class ucrCoreJson

        Public bAddRemoveParameter As Boolean = True
        Public bChangeParameterValue As Boolean = True
        'todo Public objValueToRemoveParameter As Object
        Public bLinkedAddRemoveParameter As Boolean = False
        Public bLinkedUpdateFunction As Boolean = False
        Public bLinkedDisabledIfParameterMissing As Boolean = False
        Public bLinkedHideIfParameterMissing As Boolean = False
        Public bLinkedChangeToDefaultState As Boolean = False
        Public bLinkedChangeParameterValue As Boolean = False
        Public bIsActiveRControl As Boolean = True
        Public bUpdateRCodeFromControl As Boolean = False
        Public bAllowNonConditionValues As Boolean = True
        Public bIsVisible As Boolean = True

        Public Sub New(ucrCore As ucrCore)
            bAddRemoveParameter = ucrCore.bAddRemoveParameter
            bChangeParameterValue = ucrCore.bChangeParameterValue
            bLinkedAddRemoveParameter = ucrCore.bLinkedAddRemoveParameter
            bLinkedUpdateFunction = ucrCore.bLinkedUpdateFunction
            bLinkedDisabledIfParameterMissing = ucrCore.bLinkedDisabledIfParameterMissing
            bLinkedHideIfParameterMissing = ucrCore.bLinkedHideIfParameterMissing
            bLinkedChangeToDefaultState = ucrCore.bLinkedChangeToDefaultState
            bLinkedChangeParameterValue = ucrCore.bLinkedChangeParameterValue
            bIsActiveRControl = ucrCore.bIsActiveRControl
            bUpdateRCodeFromControl = ucrCore.bUpdateRCodeFromControl
            bAllowNonConditionValues = ucrCore.bAllowNonConditionValues
            bIsVisible = ucrCore.bIsVisible
        End Sub
    End Class

    Public Class ucrReceiverJson
        Inherits ucrCoreJson

        Public lstIncludedMetadataProperties As List(Of KeyValuePair(Of String, String()))
        Public lstExcludedMetadataProperties As List(Of KeyValuePair(Of String, String()))
        Public bFirstLoad As Boolean
        Public bFirstShown As Boolean
        Public strSelectorHeading As String
        Public bUseFilteredData As Boolean
        Public bDropUnusedFilterLevels As Boolean
        Public bTypeSet As Boolean
        Public bExcludeFromSelector As Boolean
        Public bRemoveLabels As Boolean
        Public strDatabaseQuery As String
        Public bAutoFill As Boolean
        Public lstIncludedAutoFillProperties As Dictionary(Of String, String())
        Public bAddParameterIfEmpty As Boolean
        Public bWithQuotes As Boolean
        Public bForceAsDataFrame As Boolean
        Public bAttachedToPrimaryDataFrame As Boolean
        Public bOnlyLinkedToPrimaryDataFrames As Boolean
        Public bForceVariablesAsList As Boolean
        Public bAutoSwitchFromReceiver As Boolean

        Public Sub New(ucrReceiver As ucrReceiver)
            MyBase.New(ucrReceiver)

            lstIncludedMetadataProperties = ucrReceiver.lstIncludedMetadataProperties
            lstExcludedMetadataProperties = ucrReceiver.lstExcludedMetadataProperties
            strSelectorHeading = ucrReceiver.strSelectorHeading
            bUseFilteredData = ucrReceiver.bUseFilteredData
            bDropUnusedFilterLevels = ucrReceiver.bDropUnusedFilterLevels
            bTypeSet = ucrReceiver.bTypeSet
            bExcludeFromSelector = ucrReceiver.bExcludeFromSelector
            bRemoveLabels = ucrReceiver.bRemoveLabels
            strDatabaseQuery = ucrReceiver.strSelectorHeading
            bAutoFill = ucrReceiver.bAutoFill
            lstIncludedAutoFillProperties = ucrReceiver.lstIncludedAutoFillProperties
            bAddParameterIfEmpty = ucrReceiver.bAddParameterIfEmpty
            bWithQuotes = ucrReceiver.bWithQuotes
            bForceAsDataFrame = ucrReceiver.bForceAsDataFrame
            bAttachedToPrimaryDataFrame = ucrReceiver.bAttachedToPrimaryDataFrame
            bOnlyLinkedToPrimaryDataFrames = ucrReceiver.bOnlyLinkedToPrimaryDataFrames
            bForceVariablesAsList = ucrReceiver.bForceVariablesAsList
            bAutoSwitchFromReceiver = ucrReceiver.bAutoSwitchFromReceiver
        End Sub
    End Class

    Private Class ucrReceiverSingleJson
        Inherits ucrReceiverJson

        Public strCurrDataType As String
        Public bPrintGraph As Boolean
        Public bIncludeDataFrameInAssignment As Boolean

        Public Sub New(ucrReceiverSingle As ucrReceiverSingle)
            MyBase.New(ucrReceiverSingle)
            strCurrDataType = ucrReceiverSingle.strCurrDataType
            bPrintGraph = ucrReceiverSingle.bPrintGraph
            bIncludeDataFrameInAssignment = ucrReceiverSingle.bIncludeDataFrameInAssignment
        End Sub
    End Class

End Class


