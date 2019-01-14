Public Class OlahDataKain

    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGKain.Rows(br)
                txtkode.Text = .Cells(0).Value.ToString
                txtDetail.Text = .Cells(1).Value.ToString
                txtNama.Text = .Cells(2).Value.ToString
                txtharga.Text = .Cells(3).Value.ToString
                txtStok.Text = .Cells(4).Value.ToString
                txtwarna.Text = .Cells(5).Value.ToString


            End With
        End If
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolKain.tampilData.ToTable
        DGKain.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGKain.CurrentCell = DGKain.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub
    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolKain.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGKain.DataSource = DTGrid
            DGKain.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGKain.CurrentCell = DGKain.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        txtDetail.Focus()
        modeProses = 2
        Call RefreshGrid()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Call RefreshGrid()
        modeProses = 0
    End Sub

    Private Sub DGkain_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGKain.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGKain.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub OlahDataKain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RefreshGrid()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BtnTambah_Click_1(sender As Object, e As EventArgs) Handles BtnTambah.Click
        modeProses = 1

        txtDetail.Text = ""
        txtNama.Text = ""
        txtharga.Text = ""
        txtStok.Text = ""
        txtwarna.Text = ""

        txtDetail.Focus()
    End Sub

    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        With EntitasKain
            .KodeKain = txtkode.Text
            .IdDetail = txtDetail.Text
            .NamaKain = txtNama.Text
            .HargaKain = txtharga.Text
            .StokKain = txtStok.Text
            .Warnakain1 = txtwarna.Text
        End With
        If modeProses = 1 Then
            KontrolKain.InsertData(EntitasKain)
        ElseIf modeProses = 2 Then
            KontrolKain.updateData(EntitasKain)
        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
        Call RefreshGrid()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Call RefreshGrid()
    End Sub

    Private Sub DGKain_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGKain.CellContentClick

    End Sub
End Class