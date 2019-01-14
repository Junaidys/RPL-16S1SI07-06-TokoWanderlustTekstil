Public Class DataPenjualan
Public Class TampilDataPenjualan
    Dim baris As Integer
    Private Sub TampilDataPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolDataPenjualan.tampilData.ToTable
        DGDataPenjualan.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGDataPenjualan.CurrentCell = DGDataPenjualan.Item(1, baris)

        End If
    End Sub
End Class

End Class
