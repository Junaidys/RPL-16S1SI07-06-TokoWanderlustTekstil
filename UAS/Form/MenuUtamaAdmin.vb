Public Class MenuUtamaAdmin
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        OlahDataKasir.Show()

    End Sub

    Private Sub MenuUtamaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        OlahDataKain.Show()

    End Sub

    Private Sub OlahDataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OlahDataBarangToolStripMenuItem.Click
        OlahDataKain.Show()

    End Sub

    Private Sub OlahDataOperatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OlahDataOperatorToolStripMenuItem.Click
        OlahDataSuplier.Show()

    End Sub

    Private Sub OlahDataSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OlahDataSupplierToolStripMenuItem.Click
        OlahDataSuplier.Show()
    End Sub

    Private Sub DataKasirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKasirToolStripMenuItem.Click

    End Sub

    Private Sub DataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem.Click
        TampilDataKain.Show()

    End Sub
End Class