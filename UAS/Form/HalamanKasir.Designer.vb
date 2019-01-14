<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HalamanKasir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TransaksiPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiPembelianToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiPenjualanToolStripMenuItem, Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(652, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TransaksiPenjualanToolStripMenuItem
        '
        Me.TransaksiPenjualanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiPembelianToolStripMenuItem, Me.TransaksiPembelianToolStripMenuItem1})
        Me.TransaksiPenjualanToolStripMenuItem.Name = "TransaksiPenjualanToolStripMenuItem"
        Me.TransaksiPenjualanToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.TransaksiPenjualanToolStripMenuItem.Text = "transaksi"
        '
        'TransaksiPembelianToolStripMenuItem
        '
        Me.TransaksiPembelianToolStripMenuItem.Name = "TransaksiPembelianToolStripMenuItem"
        Me.TransaksiPembelianToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.TransaksiPembelianToolStripMenuItem.Text = "Transaksi Penjualan"
        '
        'TransaksiPembelianToolStripMenuItem1
        '
        Me.TransaksiPembelianToolStripMenuItem1.Name = "TransaksiPembelianToolStripMenuItem1"
        Me.TransaksiPembelianToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.TransaksiPembelianToolStripMenuItem1.Text = "Transaksi Pembelian"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPenjualanToolStripMenuItem, Me.DataPembelianToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'DataPenjualanToolStripMenuItem
        '
        Me.DataPenjualanToolStripMenuItem.Name = "DataPenjualanToolStripMenuItem"
        Me.DataPenjualanToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataPenjualanToolStripMenuItem.Text = "Data Penjualan"
        '
        'DataPembelianToolStripMenuItem
        '
        Me.DataPembelianToolStripMenuItem.Name = "DataPembelianToolStripMenuItem"
        Me.DataPembelianToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataPembelianToolStripMenuItem.Text = "Data Pembelian"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Niagara Solid", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(274, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 47)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Halaman Kasir"
        '
        'HalamanKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.kasir
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(652, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HalamanKasir"
        Me.Text = "HalamanKasir"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TransaksiPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiPembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiPembelianToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPembelianToolStripMenuItem As ToolStripMenuItem
End Class
