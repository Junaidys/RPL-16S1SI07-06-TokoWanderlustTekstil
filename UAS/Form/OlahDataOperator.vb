Public Class OlahDataOperator

    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGOperator.Rows(br)
                txtKode.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
                txtUsername.Text = .Cells(2).Value.ToString
                txtPassword.Text = .Cells(3).Value.ToString
                txtStatus.Text = .Cells(4).Value.ToString



            End With
        End If
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolOperator.TampilData.ToTable
        DGOperator.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGOperator.CurrentCell = DGOperator.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub
    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolOperator.CariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGOperator.DataSource = DTGrid
            DGOperator.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGOperator.CurrentCell = DGOperator.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txtKode.Focus()
        modeProses = 2
        Call RefreshGrid()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call RefreshGrid()
        modeProses = 0
    End Sub

    Private Sub DGOperator_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGOperator.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGOperator.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub OlahDataOperator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RefreshGrid()

    End Sub

    Private Sub BtnTambah_Click_1(sender As Object, e As EventArgs) Handles btnTambah.Click
        modeProses = 1

        txtKode.Text = KontrolOperator.kodeBaru()
        txtnama.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtStatus.Text = ""


        txtnama.Focus()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasOperator
            .Kodeop = txtKode.Text
            .Namaop = txtnama.Text
            .Usernameop = Txtusername.Text
            .Passwordop = txtPassword.Text

            .Statusop = txtStatus.Text
        End With
        If modeProses = 1 Then
            KontrolOperator.InsertData(EntitasOperator)
        ElseIf modeProses = 2 Then
            KontrolOperator.UpdateData(EntitasOperator)
        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
        Call RefreshGrid()
    End Sub



    Private Sub DGOperator_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGOperator.CellContentClick

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Apakah Anda Yakin ingin Menghapus data ini? ",
                 MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolOperator.DeleteData(txtKode.Text)
            MsgBox("Data Telah Terhapus", MsgBoxStyle.Information, "info")
            RefreshGrid()
        End If
    End Sub


End Class