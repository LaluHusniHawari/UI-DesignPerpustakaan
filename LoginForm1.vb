Public Class Login


    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If txtUsername.Text = "Username" Or txtUsername.Text = "" Then
            txtUsername.ForeColor = Color.Silver
            txtUsername.Text = "Username"

        End If
    End Sub

    Private Sub txtUsername_MouseClick(sender As Object, e As MouseEventArgs) Handles txtUsername.MouseClick
        If txtUsername.Text = "Username" Then
            txtUsername.Clear()
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If txtUsername.Text = "Username" Then
            txtUsername.ForeColor = Color.Silver
        Else
            txtUsername.ForeColor = Color.Black
        End If
    End Sub


    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "Password" Or txtPassword.Text = "" Then
            txtPassword.ForeColor = Color.Silver
            txtPassword.Text = "Password"
            txtPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub txtPassword_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPassword.MouseClick
        If txtPassword.Text = "Password" Then
            txtPassword.Clear()
            txtPassword.ForeColor = Color.Silver
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text = "Password" Then
            txtPassword.ForeColor = Color.Silver
        Else
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub BtnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "admin" Then
            MenuUtama.Show()
        Else
            MessageBox.Show("Password yang anda masukan salah",
                            "judul", MessageBoxButtons.OK,
                               MessageBoxIcon.Information)
        End If
    End Sub
End Class
