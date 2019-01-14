Public Class HalamanKasir
    Private Sub TransaksiPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiPenjualanToolStripMenuItem.Click

    End Sub

    Private Sub TransaksiPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiPembelianToolStripMenuItem.Click
        FormPenjualan.Show()
    End Sub

    Private Sub TransaksiPembelianToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TransaksiPembelianToolStripMenuItem1.Click
        FormPembelian.Show()

    End Sub

    Private Sub DataPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPenjualanToolStripMenuItem.Click
        TampilDataPenjualan.Show()

    End Sub
End Class