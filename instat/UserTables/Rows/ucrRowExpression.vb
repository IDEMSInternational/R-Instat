Public Class ucrRowExpression

    Public Event ControlContentsChanged(ucrChangedControl As ucrCore)
    Private strDataFrameName As String
    Private bFirstload As Boolean = True

    Private Sub UcrInputRowExpression_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseControl()
            bFirstload = False
        End If
    End Sub

    Private Sub InitialiseControl()
        Dim btnOptions As New Button
        'add the button to the comment textbox first
        ucrInputExpression.txtInput.Controls.Clear()
        ucrInputExpression.txtInput.Controls.Add(btnOptions)

        'then set the  button properties
        btnOptions.Text = ":::" 'temp. This will be shown as centered ... An image as below commended code is preferred
        'btn.Image = Image.FromFile("C:\patowhiz\3dots.png")
        btnOptions.Size = New Size(25, ucrInputExpression.txtInput.ClientSize.Height + 2)
        btnOptions.TextAlign = ContentAlignment.TopCenter
        btnOptions.FlatStyle = FlatStyle.Standard
        btnOptions.FlatAppearance.BorderSize = 0
        btnOptions.Cursor = Cursors.Default
        btnOptions.Dock = DockStyle.Right
        'btnOptions.BackColor = Parent.BackColor
        btnOptions.UseVisualStyleBackColor = True

        'set the btn event handler
        AddHandler btnOptions.Click, Sub()
                                         sdgTableRowExpression.Setup(strDataFrameName)
                                         sdgTableRowExpression.ShowDialog(Me.ParentForm)
                                         If sdgTableRowExpression.bUserClickedReturn Then
                                             ucrInputExpression.SetName(sdgTableRowExpression.GetUserInputRowExpression())
                                         End If
                                     End Sub
    End Sub

    Public Sub Setup(strDataFrameName As String)
        Me.strDataFrameName = strDataFrameName
    End Sub

    Public Function IsEmpty() As Boolean
        Return ucrInputExpression.IsEmpty()
    End Function

    Public Function GetText() As String
        Return ucrInputExpression.GetText()
    End Function

    Public Sub Clear()
        ucrInputExpression.SetName("")
    End Sub

    Private Sub ucrInputExpression_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputExpression.ControlContentsChanged
        RaiseEvent ControlContentsChanged(ucrChangedControl)
    End Sub
End Class
