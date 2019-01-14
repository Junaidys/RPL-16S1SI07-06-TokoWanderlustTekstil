Public Class CariBarangJual
    Sub Buatbarang()
        LvHasilCari.Columns.Add("Kode Kain", 120, HorizontalAlignment.Center)
        LvHasilCari.Columns.Add("Kode Jenis", 120, HorizontalAlignment.Center)
        LvHasilCari.Columns.Add("Nama Barang", 120, HorizontalAlignment.Center)
        LvHasilCari.Columns.Add("Harga Barang", 120, HorizontalAlignment.Center)

        LvHasilCari.View = View.Details
        LvHasilCari.GridLines = True
        LvHasilCari.FullRowSelect = True
    End Sub


    Private Sub cariBarangJual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Buatbarang()

        DTGrid = KontrolKain.cariData(TxtCari.Text).ToTable
        LvHasilCari.Items.Clear()
        Dim strItem(3) As String
        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                strItem(0) = DTGrid.Rows(i).Item(0).ToString
                strItem(1) = DTGrid.Rows(i).Item(1).ToString
                strItem(2) = DTGrid.Rows(i).Item(2).ToString
                strItem(3) = DTGrid.Rows(i).Item(6).ToString

                LvHasilCari.Items.Add(New ListViewItem(strItem))
            Next

        Else
            MsgBox("Data tidak ditemukan")
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        DTGrid = KontrolKain.cariData(TxtCari.Text).ToTable
        LvHasilCari.Items.Clear()
        Dim strItem(3) As String
        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                strItem(0) = DTGrid.Rows(i).Item(0).ToString
                strItem(1) = DTGrid.Rows(i).Item(1).ToString
                strItem(2) = DTGrid.Rows(i).Item(2).ToString
                strItem(3) = DTGrid.Rows(i).Item(3).ToString

                LvHasilCari.Items.Add(New ListViewItem(strItem))
            Next

        Else
            MsgBox("Data tidak ditemukan")
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub LvHasilCari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvHasilCari.SelectedIndexChanged
        With FormPenjualan
            .txtIDKain.Text = LvHasilCari.SelectedItems(0).SubItems(0).Text
            .txtNama.Text = LvHasilCari.SelectedItems(0).SubItems(2).Text
            .txtHarga.Text = LvHasilCari.SelectedItems(0).SubItems(3).Text
            Me.Close()
            .txtJumlah.Focus()
        End With
    End Sub
End Class