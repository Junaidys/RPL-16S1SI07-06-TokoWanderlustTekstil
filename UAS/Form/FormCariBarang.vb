Public Class FormCariBarang
    Sub Buatbarang()
        LVCariBarang.Columns.Add("Kode Barang", 120, HorizontalAlignment.Center)
        LVCariBarang.Columns.Add("Kode Jenis", 120, HorizontalAlignment.Center)
        LVCariBarang.Columns.Add("Nama Barang", 120, HorizontalAlignment.Center)
        LVCariBarang.Columns.Add("Harga Barang", 120, HorizontalAlignment.Center)

        LVCariBarang.View = View.Details
        LVCariBarang.GridLines = True
        LVCariBarang.FullRowSelect = True
    End Sub


    Private Sub FormCariBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Buatbarang()

        DTGrid = KontrolKain.cariData(txtBarang.Text).ToTable
        LVCariBarang.Items.Clear()
        Dim strItem(3) As String
        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                strItem(0) = DTGrid.Rows(i).Item(0).ToString
                strItem(1) = DTGrid.Rows(i).Item(1).ToString
                strItem(2) = DTGrid.Rows(i).Item(2).ToString
                strItem(3) = DTGrid.Rows(i).Item(3).ToString

                LVCariBarang.Items.Add(New ListViewItem(strItem))
            Next

        Else
            MsgBox("Data tidak ditemukan")
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        DTGrid = KontrolKain.cariData(txtBarang.Text).ToTable
        LVCariBarang.Items.Clear()
        Dim strItem(3) As String
        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                strItem(0) = DTGrid.Rows(i).Item(0).ToString
                strItem(1) = DTGrid.Rows(i).Item(1).ToString
                strItem(2) = DTGrid.Rows(i).Item(2).ToString
                strItem(3) = DTGrid.Rows(i).Item(3).ToString

                LVCariBarang.Items.Add(New ListViewItem(strItem))
            Next

        Else
            MsgBox("Data tidak ditemukan")
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub LVCariBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LVCariBarang.SelectedIndexChanged
        With FormPenjualan
            '   .txtKode.Text = LVCariBarang.SelectedItems(0).SubItems(0).Text
            '  .txtNama.Text = LVCariBarang.SelectedItems(0).SubItems(2).Text
            ' .txtHarga.Text = LVCariBarang.SelectedItems(0).SubItems(3).Text
            'Me.Close()
            '.txtQty.Focus()
        End With
    End Sub
End Class