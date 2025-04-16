''' <summary>
''' Each instance of this class specifies how to make a single update to a dictionary of 
''' configurable values. The dictionary is updated according to the current state of the control 
''' associated with this instance.<para>
''' A list of instances of this class can be used to fully update a dictionary of configurable 
''' values based upon the current state of all controls in a particular dialog.</para>
''' </summary>
Public Class clsTransformationControl

    ''' <summary>
    ''' The control used to update the configurable value.
    ''' </summary>
    Public clsControl As ucrCore

    ''' <summary>
    ''' The type of value to request from the control
    ''' </summary>
    Public enumTextType As [Enum] = Nothing

    ''' <summary>
    ''' They key of the value to update in the dictionary of configurable values.
    ''' </summary>
    Public strKey As String

    ''' <summary>
    ''' Updates <paramref name="dctConfigurableValues"/> using the data members of this object.
    ''' </summary>
    ''' <param name="dctConfigurableValues">The disctionary to update</param>
    Public Sub UpdateConfigurableValue(dctConfigurableValues As Dictionary(Of String, String))
        dctConfigurableValues(strKey) = clsControl.GetText(enumTextType)
    End Sub

End Class
