Public Class Formlogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        MenuUtama.lblAdmin.Text = txtUsername.Text
        DTGrid = KontrolAdmin.loginAdmin(txtUsername.Text).ToTable

        If DTGrid.Rows.Count > 0 Then
            EntitasAdmin.User_name = DTGrid.Rows(0).Item(2)
            EntitasAdmin.Password = DTGrid.Rows(0).Item(3)

            If txtPassword.Text = EntitasAdmin.Password Then
                MenuUtamaAdmin.Show()
                txtUsername.Text = ""
                txtPassword.Text = ""
                Me.Hide()


            Else
                MessageBox.Show("PASSWORD SALAH!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Text = ""
                txtUsername.Focus()

            End If

        Else
            MessageBox.Show("ID tidak dikenal!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Text = ""
            txtPassword.Text = ""

            txtUsername.Focus()
        End If

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub Formloginadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.PasswordChar = "*"
    End Sub
End Class

