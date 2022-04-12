Imports System
Imports System.Drawing
Imports System.Windows.Forms

Class SizeablePictureBox
    Inherits PictureBox

    Public Sub New()
        Me.ResizeRedraw = True
        _canResize = True
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        If _canResize Then
            Dim rc = New Rectangle(Me.ClientSize.Width - grab, Me.ClientSize.Height - grab, grab, grab)
            ControlPaint.DrawSizeGrip(e.Graphics, Me.BackColor, rc)
        End If
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        If _canResize Then
            If m.Msg = &H84 Then
                Dim pos = Me.PointToClient(New Point(m.LParam.ToInt32()))
                If pos.X >= Me.ClientSize.Width - grab AndAlso pos.Y >= Me.ClientSize.Height - grab Then
                    m.Result = New IntPtr(17)
                End If
            End If
        End If
    End Sub

    Private _canResize As Boolean
    Public Property CanReSize() As Boolean
        Get
            Return _canResize
        End Get
        Set(ByVal value As Boolean)
            _canResize = value
        End Set
    End Property

    Private Const grab As Integer = 16
End Class

