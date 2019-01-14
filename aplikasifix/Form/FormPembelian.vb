Public Class FormPembelian

#Region "events"
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Timer1.Tick
        Dim namaHari As String()
        namaHari = New String() {" \M\i\n\g\g\u", "\S\e\n\i\n", "\S\e\l\a\s\a", "\R\a\b\u", "\K\a\m\i\s", "\J\u\m\a\t", "\S\a\b\t\u"}
        LblWaktu.Text = Format(Now, namaHari(Now.DayOfWeek()) & " yyyy/MM/dd hh:mm:ss")
    End Sub

    Private Sub LVItemBeli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LVItemBeli.SelectedIndexChanged

    End Sub
    Sub Buattabel()
        LVItemBeli.Columns.Add("kode kain", 120, HorizontalAlignment.Center)
        LVItemBeli.Columns.Add("Nama kain", 180, HorizontalAlignment.Center)
        LVItemBeli.Columns.Add("Harga kain", 120, HorizontalAlignment.Center)
        LVItemBeli.Columns.Add("banyak", 120, HorizontalAlignment.Center)
        LVItemBeli.Columns.Add("Sub Total", 120, HorizontalAlignment.Center)


        LVItemBeli.View = View.Details
        LVItemBeli.GridLines = True
        LVItemBeli.FullRowSelect = True
    End Sub

    Private Sub FormPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim strItem(4) As String

        strItem(0) = TxtKodeKain.Text
        strItem(1) = TxtNamaKain.Text
        strItem(2) = TxtHargaKain.Text
        strItem(3) = TxtBanyak.Text
        strItem(4) = TxtHargaKain.Text * TxtBanyak.Text

        LVItemBeli.Items.Add(New ListViewItem(strItem))

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        LVItemBeli.SelectedItems(0).Remove()

    End Sub
    Sub JumlahLVKain()
        Dim jumKain As Integer = 0
        Dim jumHarga As Integer = 0
        Dim total As Double = 0
        For baris As Integer = 0 To LVItemBeli.Items.Count - 1
            jumKain = jumKain + LVItemBeli.Items(baris).SubItems(3).Text
            total = total + (TxtHargaKain.Text * TxtBanyak.Text)
            jumHarga = jumHarga + LVItemBeli.Items(baris).SubItems(4).Text

        Next
        LblTotal.Text = jumHarga
        LblJumItem.Text = jumKain
    End Sub

#End Region
End Class