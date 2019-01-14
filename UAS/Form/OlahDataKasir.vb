Public Class OlahDataKasir

    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGKasir.Rows(br)
                txtKode.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
                txtUsername.Text = .Cells(2).Value.ToString
                txtPassword.Text = .Cells(3).Value.ToString
                txtalamat.Text = .Cells(4).Value.ToString
                txtTelp.Text = .Cells(5).Value.ToString


            End With
        End If
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolKasir.tampilData.ToTable
        DGKasir.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGKasir.CurrentCell = DGKasir.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub
    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolKasir.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGKasir.DataSource = DTGrid
            DGKasir.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGKasir.CurrentCell = DGKasir.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        txtKode.Focus()
        modeProses = 2
        Call RefreshGrid()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Call RefreshGrid()
        modeProses = 0
    End Sub

    Private Sub DGkasir_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGKasir.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGKasir.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub OlahDataKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RefreshGrid()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BtnTambah_Click_1(sender As Object, e As EventArgs) Handles BtnTambah.Click
        modeProses = 1

        txtKode.Text = KontrolKasir.kodeBaru()
        txtNama.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtalamat.Text = ""
        txtTelp.Text = ""

        txtNama.Focus()
    End Sub

    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        With EntitasKasir
            .Kodekasir = txtKode.Text
            .Namakasir = txtNama.Text
            .Usernamekasir = txtUsername.Text
            .Passwordkasir = txtPassword.Text
            .Alamatkasir = txtalamat.Text
            .Telpkasir = txtTelp.Text
        End With
        If modeProses = 1 Then
            KontrolKasir.InsertData(EntitasKasir)
        ElseIf modeProses = 2 Then
            KontrolKasir.updateData(EntitasKasir)
        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
        Call RefreshGrid()
    End Sub



    Private Sub DGKasir_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGKasir.CellContentClick

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If MsgBox("Apakah Anda Yakin ingin Menghapus data ini? ",
                 MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolKasir.deleteData(txtKode.Text)
            MsgBox("Data Telah Terhapus", MsgBoxStyle.Information, "info")
            RefreshGrid()
        End If
    End Sub


End Class