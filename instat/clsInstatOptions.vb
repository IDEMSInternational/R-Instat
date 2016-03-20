Public Class InstatOptions
    Public bIncludeRDefaultParameters As Boolean

    ' Load all of the saved settings from the Registry.
    Public Shared Sub LoadAllSettings(ByVal app_name As String, ByVal frm As Form)
        ' Load form settings.
        frm.SetBounds(
            CInt(GetSetting(app_name, "Settings", "FormLeft", frm.Left)),
            CInt(GetSetting(app_name, "Settings", "FormTop", frm.Top)),
            CInt(GetSetting(app_name, "Settings", "FormWidth", frm.Width)),
            CInt(GetSetting(app_name, "Settings", "FormHeight", frm.Height)))

        Dim state As Integer = CInt(GetSetting(app_name, "Settings", "FormWindowState", CInt(frm.WindowState)))
        frm.WindowState = DirectCast(state, FormWindowState)

        ' Load the controls' values.
        LoadChildSettings(app_name, frm)
    End Sub

    ' Load all child control settings.
    Public Shared Sub LoadChildSettings(ByVal app_name As String, ByVal parent As Control)
        For Each child As Control In parent.Controls
            ' Restore the child's value.
            Select Case (child.GetType().Name)
                Case "TextBox", "ListBox", "ComboBox"
                    child.Text = GetSetting(app_name, "Settings", child.Name, child.Text)

                Case "CheckBox"
                    Dim chk As CheckBox = DirectCast(child, CheckBox)
                    chk.Checked = Boolean.Parse(
                        GetSetting(app_name, "Settings", child.Name, chk.Checked.ToString()))

                Case "RadioButton"
                    Dim rad As RadioButton = DirectCast(child, RadioButton)
                    rad.Checked = Boolean.Parse(
                        GetSetting(app_name, "Settings", child.Name, rad.Checked.ToString()))

                Case "NumericUpDown"
                    Dim nud As NumericUpDown = DirectCast(child, NumericUpDown)
                    nud.Value = Decimal.Parse(GetSetting(app_name, "Settings",
                        child.Name, nud.Value).ToString())

                    ' Add other control types here like combobox e.t.c.
            End Select

            ' Recursively restore the child's children.
            LoadChildSettings(app_name, child)
        Next child
    End Sub

    ' Save all of the form's settings in the registry.
    Public Shared Sub SaveAllSettings(ByVal app_name As String, ByVal frm As Form)
        ' Save form settings.
        SaveSetting(app_name, "Settings", "FormWindowState", CInt(frm.WindowState))

        If (frm.WindowState = FormWindowState.Normal) Then
            ' Save current bounds.
            SaveSetting(app_name, "Settings", "FormLeft", frm.Left)
            SaveSetting(app_name, "Settings", "FormTop", frm.Top)
            SaveSetting(app_name, "Settings", "FormWidth", frm.Width)
            SaveSetting(app_name, "Settings", "FormHeight", frm.Height)
        Else
            ' Save bounds when we're restored.
            SaveSetting(app_name, "Settings", "FormLeft", frm.RestoreBounds.Left)
            SaveSetting(app_name, "Settings", "FormTop", frm.RestoreBounds.Top)
            SaveSetting(app_name, "Settings", "FormWidth", frm.RestoreBounds.Width)
            SaveSetting(app_name, "Settings", "FormHeight", frm.RestoreBounds.Height)
        End If

        ' Save the controls' values.
        SaveChildSettings(app_name, frm)
    End Sub

    ' Save all child control settings.
    Public Shared Sub SaveChildSettings(ByVal app_name As String, ByVal parent As Control)
        For Each child As Control In parent.Controls
            ' Save the child's value.
            Select Case (child.GetType().Name)
                Case "TextBox", "ListBox", "ComboBox"
                    SaveSetting(app_name, "Settings", child.Name, child.Text)

                Case "CheckBox"
                    Dim chk As CheckBox = DirectCast(child, CheckBox)
                    SaveSetting(app_name, "Settings", child.Name, chk.Checked.ToString())

                Case "RadioButton"
                    Dim rad As RadioButton = DirectCast(child, RadioButton)
                    SaveSetting(app_name, "Settings", child.Name, rad.Checked.ToString())

                Case "NumericUpDown"
                    Dim nud As NumericUpDown = DirectCast(child, NumericUpDown)
                    SaveSetting(app_name, "Settings", child.Name, nud.Value)

                    ' Add other control types here like combo box e.t.c
            End Select


            ' Recursively save the child's children.
            SaveChildSettings(app_name, child)
        Next child
    End Sub

End Class
