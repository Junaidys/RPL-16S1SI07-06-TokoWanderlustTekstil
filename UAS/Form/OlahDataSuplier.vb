Public Class OlahDataSuplier

    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGSupplier.Rows(br)
                txtKode.Text = .Cells(0).Value.ToString
                TxtNama.Text = .Cells(1).Value.ToString
                TxtAlamat.Text = .Cells(2).Value.ToString
                Txttelp.Text = .Cells(3).Value.ToString
                TxtEmail.Text = .Cells(4).Value.ToString

            End With
        End If
    End Sub
    Private Sub RefreshGrid()
        DTGrid = KontrolSupplier.tampilData.ToTable
        DGSupplier.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGSupplier.CurrentCell = DGSupplier.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub


    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolSupplier.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGSupplier.DataSource = DTGrid
            DGSupplier.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGSupplier.CurrentCell = DGSupplier.Item(1, baris)
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

    Private Sub DGsupplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSupplier.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGSupplier.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub OlahDataSuplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RefreshGrid()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BtnTambah_Click_1(sender As Object, e As EventArgs) Handles BtnTambah.Click
        modeProses = 1

        txtKode.Text = KontrolSupplier.kodeBaru
        TxtNama.Text = ""
        TxtAlamat.Text = ""
        Txttelp.Text = ""
        TxtEmail.Text = ""

        TxtNama.Focus()
    End Sub

    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        With EntitasSupplier
            .KodeSupplier = txtKode.Text
            .NamaSupplier = TxtNama.Text
            .AlamatSupplier = TxtAlamat.Text
            .TelpSupplier = Txttelp.Text
            .EmailSupplier = TxtEmail.Text

        End With
        If modeProses = 1 Then
            KontrolSupplier.InsertData(EntitasSupplier)
        ElseIf modeProses = 2 Then
            KontrolSupplier.updateData(EntitasSupplier)
        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
        Call RefreshGrid()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If MsgBox("Apakah Anda Yakin ingin Menghapus data ini? ",
                 MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolSupplier.deleteData(txtKode.Text)
            MsgBox("Data Telah Terhapus", MsgBoxStyle.Information, "info")
            RefreshGrid()
        End If
    End Sub
End Class