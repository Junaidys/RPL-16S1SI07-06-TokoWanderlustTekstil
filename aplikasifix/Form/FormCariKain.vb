Public Class FormCariKain
    Private Sub FormCariKain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Buattabel()
    End Sub
    Sub Buattabel()
        LvHasilCari.Columns.Add("Kode Kain", 120, HorizontalAlignment.Center)
        LvHasilCari.Columns.Add("Nama kain", 180, HorizontalAlignment.Center)
        LvHasilCari.Columns.Add("warna kain", 180, HorizontalAlignment.Center)

        LvHasilCari.View = View.Details
        LvHasilCari.GridLines = True
        LvHasilCari.FullRowSelect = True
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        FormPenjualan.Show()
        Me.Close()
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        DTGrid = KontrolKain.cariData(TxtCari.Text).ToTable
        LvHasilCari.Items.Clear()
        Dim strItem(2) As String
        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                strItem(0) = DTGrid.Rows(i).Item(0).ToString
                strItem(1) = DTGrid.Rows(i).Item(1).ToString
                strItem(2) = DTGrid.Rows(i).Item(2).ToString
            Next
            LvHasilCari.Items.Add(New ListViewItem(strItem))
        Else
            MsgBox("Data Yang Di Cari Tidak Di Temukan")
        End If

    End Sub

    Private Sub LvHasilCari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvHasilCari.SelectedIndexChanged

    End Sub

    Private Sub LvHasilCari_DoubleClick(sender As Object, e As EventArgs) Handles LvHasilCari.DoubleClick
        With FormPembelian
            .TxtKodeKain.Text = LvHasilCari.SelectedItems(0).SubItems(0).Text
            .TxtNamaKain.Text = LvHasilCari.SelectedItems(1).SubItems(1).Text

            Me.Close()
            .TxtHargaKain.Focus()

        End With
    End Sub
End Class