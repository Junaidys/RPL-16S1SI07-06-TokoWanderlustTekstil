Public Class TampilDataKain
    Dim baris As Integer
    Private Sub TampilDataKain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolDataKainAs.tampilData.ToTable
        dgtampilkain.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            dgtampilkain.CurrentCell = dgtampilkain.Item(1, baris)

        End If
    End Sub
End Class