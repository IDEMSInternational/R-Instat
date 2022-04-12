

Imports System.ComponentModel

Public Class clsOutputElementViewModel
    Implements INotifyPropertyChanged
    Private _outputElement As clsOutputElement
    Private _text As String
    Public Property Text() As String
        Get
            Return _text
        End Get
        Set(ByVal value As String)
            _text = value
        End Set
    End Property

    Public Property Font() As Font

    Public Property FontColour As Color

    Public Property IsReadOnly As Boolean

    Public Property Selected As Boolean



    Private HeaderComment As String
    Private RScript As String
    Private FooterComment As String
    Private OutputImage As Image
    Private OutputString As String
    Private CleanUpScript As String



    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
