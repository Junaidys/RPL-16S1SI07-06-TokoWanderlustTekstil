Imports System.Data.OleDb

Public Class FormPenjualan
    Dim baris As Integer

#Region "SUB"
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Timer1.Tick
        Dim namaHari As String()
        namaHari = New String() {" \M\i\n\g\g\u", "\S\e\n\i\n", "\S\e\l\a\s\a", "\R\a\b\u", "\K\a\m\i\s", "\J\u\m\a\t", "\S\a\b\t\u"}
        LblTanggal.Text = Format(Now, namaHari(Now.DayOfWeek()) & " yyyy/MM/dd ")
    End Sub


    Sub Buattabel()
        LVPenjualan.Columns.Add("kode kain", 120, HorizontalAlignment.Center)
        LVPenjualan.Columns.Add("Nama kain", 180, HorizontalAlignment.Center)
        LVPenjualan.Columns.Add("Harga kain", 120, HorizontalAlignment.Center)
        LVPenjualan.Columns.Add("banyak", 120, HorizontalAlignment.Center)
        LVPenjualan.Columns.Add("Sub Total", 120, HorizontalAlignment.Center)


        LVPenjualan.View = View.Details
        LVPenjualan.GridLines = True
        LVPenjualan.FullRowSelect = True
    End Sub

    Sub JumlahLVKain()
        Dim jumKain As Integer = 0
        Dim jumHarga As Integer = 0
        Dim total As Double = 0
        For baris As Integer = 0 To LVPenjualan.Items.Count - 1
            jumKain = jumKain + LVPenjualan.Items(baris).SubItems(3).Text
            total = total + (txtHarga.Text * txtJumlah.Text)
            jumHarga = jumHarga + LVPenjualan.Items(baris).SubItems(4).Text

        Next
        txtTotal.Text = jumHarga
        lblJumMenu.Text = jumKain
    End Sub
#End Region

#Region "events"
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Sub Bersih()
        LVPenjualan.Items.Clear()
        lblJumMenu.Text = "0"
        txtTotal.Text = "0"
        txtBayar.Text = "0"
        txtKembali.Text = "0"
    End Sub

    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Buattabel()


        lblIDjual.Text = KontrolPenjualan.kodeBaru()

        Call Bersih()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim strMenu(4) As String

        strMenu(0) = txtIDKain.Text
        strMenu(1) = txtNama.Text
        strMenu(2) = txtHarga.Text
        strMenu(3) = txtJumlah.Text
        strMenu(4) = txtHarga.Text * txtJumlah.Text

        LVPenjualan.Items.Add(New ListViewItem(strMenu))
        Call JumlahLVKain()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        LVPenjualan.SelectedItems(0).Remove()
        Call JumlahLVKain()
    End Sub


    Private Sub txtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBayar.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then
            If Val(txtBayar.Text) < Val(txtTotal.Text) Then
                MsgBox("Pembayaran Kurang")
                Exit Sub
            ElseIf Val(txtBayar.Text) = Val(txtTotal.Text) Then
                txtKembali.Text = 0
                btnSimpan.Focus()
            ElseIf Val(txtBayar.Text) > Val(txtTotal.Text) Then
                txtKembali.Text = Val(txtBayar.Text) - Val(txtTotal.Text)
                btnSimpan.Focus()
            End If
        End If
    End Sub

    Private Sub btnCariMenu_Click(sender As Object, e As EventArgs) Handles btnCariMenu.Click
        CariBarangJual.Show()

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim lsdetail As New List(Of ClsEntDetailJual)()
        If LVPenjualan.Items.Count = 0 Then
            MsgBox("Masukkan Kain yang akan dipesan terlebih dahulu")
            Exit Sub
        End If
        With EntitasPenjualan
            .Kodenota = lblIDjual.Text
            .KodeOPerator = lblNamaOperator.Text
            .Tanggaljual = Format(Now, " yyyy/MM/dd ")
            .Qtyj = txtJumlah.Text
        End With

        For i = 0 To LVPenjualan.Items.Count - 1
            LVPenjualan.Items(i).Selected = True
            EntitasDetailJual = New ClsEntDetailJual
            With LVPenjualan.Items(i)

                EntitasDetailJual.Kodenota = lblIDjual.Text
                EntitasDetailJual.Kodekain = .SubItems(0).Text
                EntitasDetailJual.Hargaj = .SubItems(2).Text
                EntitasDetailJual.Jumlah = .SubItems(3).Text
                EntitasDetailJual.Subtotal = .SubItems(4).Text
            End With
            MsgBox(i & " " & EntitasPenjualan.Kodenota)
            lsdetail.Add(EntitasDetailJual)
        Next i
        For I = 0 To lsdetail.Count - 1
            MsgBox(lsdetail(I).Kodenota & " " & lsdetail(I).Hargaj)
        Next
        Dim NONOTA As String
        NONOTA = KontrolPenjualan.SIMPAN_DATA(EntitasPenjualan, lsdetail).ToString
        If MsgBox("Apakah Anda yakin ingin mencetak nota? ",
        MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfrimasi") = MsgBoxResult.Yes Then
            Me.Close()

            Jualan.Show()

            Jualan.CrystalReport11.RecordSelectionFormula = "{penjualan1.kode_nota}='" & NONOTA & "'"
            Jualan.CrystalReport11.Refresh()

            Bersih()
        End If

    End Sub

    Private Sub LblTanggal_Click(sender As Object, e As EventArgs) Handles LblTanggal.Click

    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub LVPenjualan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LVPenjualan.SelectedIndexChanged

    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FormPembelian.Show()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

#End Region
End Class