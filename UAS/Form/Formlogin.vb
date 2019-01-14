Public Class Formlogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        DTGrid = KontrolOperator.LoginOperator(txtUsername.Text).ToTable

        If DTGrid.Rows.Count > 0 Then
            EntitasOperator.Kodeop = DTGrid.Rows(0).Item(0)
            EntitasOperator.Usernameop = DTGrid.Rows(0).Item(2)
            EntitasOperator.Passwordop = DTGrid.Rows(0).Item(3)
            EntitasOperator.Statusop = DTGrid.Rows(0).Item(4)


            If (EntitasOperator.Statusop = "admin") Then

                If txtPassword.Text = EntitasOperator.Passwordop Then
                    MenuUtamaAdmin.Show()
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    Me.Hide()

                Else
                    MessageBox.Show("PASSWORD SALAH!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtPassword.Text = ""
                    txtUsername.Focus()


                End If
            ElseIf (EntitasOperator.Statusop = "kasir") Then
                If txtPassword.Text = EntitasOperator.Passwordop Then

                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    Me.Hide()
                    HalamanKasir.Show()
                    FormPenjualan.lblNamaOperator.Text = EntitasOperator.Kodeop


                Else
                    MessageBox.Show("PASSWORD SALAH!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtPassword.Text = ""
                    txtUsername.Focus()


                End If


            ElseIf (EntitasOperator.Statusop = "pemilik") Then
                If txtPassword.Text = EntitasOperator.Passwordop Then
                    HalamanPemilik.Show()
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    Me.Hide()

                Else
                    MessageBox.Show("PASSWORD SALAH!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtPassword.Text = ""
                    txtUsername.Focus()

                End If

            Else
                MessageBox.Show("Kode tidak dikenali", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Text = ""
                txtPassword.Focus()
            End If

        End If







    End Sub

    Private Sub Formlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class

