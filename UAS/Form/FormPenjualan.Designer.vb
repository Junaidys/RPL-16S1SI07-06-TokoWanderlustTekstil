<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblTanggal = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LVPenjualan = New System.Windows.Forms.ListView()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCariMenu = New System.Windows.Forms.Button()
        Me.txtIDKain = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblJumMenu = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.txtKembali = New System.Windows.Forms.TextBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.lblNamaOperator = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblIDjual = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Nota"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(326, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kode Kasir"
        '
        'LblTanggal
        '
        Me.LblTanggal.AutoSize = True
        Me.LblTanggal.Location = New System.Drawing.Point(635, 23)
        Me.LblTanggal.Name = "LblTanggal"
        Me.LblTanggal.Size = New System.Drawing.Size(55, 13)
        Me.LblTanggal.TabIndex = 4
        Me.LblTanggal.Text = "Auto Time"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LVPenjualan)
        Me.GroupBox1.Controls.Add(Me.txtJumlah)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtHarga)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnCariMenu)
        Me.GroupBox1.Controls.Add(Me.txtIDKain)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(749, 328)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaksi Penjualan"
        '
        'LVPenjualan
        '
        Me.LVPenjualan.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LVPenjualan.Location = New System.Drawing.Point(24, 95)
        Me.LVPenjualan.Name = "LVPenjualan"
        Me.LVPenjualan.Size = New System.Drawing.Size(688, 208)
        Me.LVPenjualan.TabIndex = 15
        Me.LVPenjualan.UseCompatibleStateImageBehavior = False
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(616, 65)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(108, 20)
        Me.txtJumlah.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(639, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Qty"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(479, 65)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(108, 20)
        Me.txtHarga.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(476, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Harga Kain"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(242, 65)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(218, 20)
        Me.txtNama.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(239, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Nama Kain"
        '
        'btnCariMenu
        '
        Me.btnCariMenu.Location = New System.Drawing.Point(151, 66)
        Me.btnCariMenu.Name = "btnCariMenu"
        Me.btnCariMenu.Size = New System.Drawing.Size(49, 23)
        Me.btnCariMenu.TabIndex = 8
        Me.btnCariMenu.Text = "..."
        Me.btnCariMenu.UseVisualStyleBackColor = True
        '
        'txtIDKain
        '
        Me.txtIDKain.Location = New System.Drawing.Point(36, 66)
        Me.txtIDKain.Name = "txtIDKain"
        Me.txtIDKain.Size = New System.Drawing.Size(100, 20)
        Me.txtIDKain.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Kode Kain"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 433)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Jumlah Kain"
        '
        'lblJumMenu
        '
        Me.lblJumMenu.AutoSize = True
        Me.lblJumMenu.Location = New System.Drawing.Point(167, 432)
        Me.lblJumMenu.Name = "lblJumMenu"
        Me.lblJumMenu.Size = New System.Drawing.Size(45, 13)
        Me.lblJumMenu.TabIndex = 9
        Me.lblJumMenu.Text = "Label11"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(508, 432)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Total Harga"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(509, 460)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Dibayar"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(508, 484)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Kembali"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(606, 424)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 15
        '
        'txtBayar
        '
        Me.txtBayar.Location = New System.Drawing.Point(606, 453)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(100, 20)
        Me.txtBayar.TabIndex = 16
        '
        'txtKembali
        '
        Me.txtKembali.Location = New System.Drawing.Point(606, 481)
        Me.txtKembali.Name = "txtKembali"
        Me.txtKembali.Size = New System.Drawing.Size(100, 20)
        Me.txtKembali.TabIndex = 17
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(781, 481)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 44)
        Me.btnKeluar.TabIndex = 18
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'lblNamaOperator
        '
        Me.lblNamaOperator.AutoSize = True
        Me.lblNamaOperator.Location = New System.Drawing.Point(471, 26)
        Me.lblNamaOperator.Name = "lblNamaOperator"
        Me.lblNamaOperator.Size = New System.Drawing.Size(29, 13)
        Me.lblNamaOperator.TabIndex = 20
        Me.lblNamaOperator.Text = "Auto"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lblIDjual
        '
        Me.lblIDjual.AutoSize = True
        Me.lblIDjual.Location = New System.Drawing.Point(148, 23)
        Me.lblIDjual.Name = "lblIDjual"
        Me.lblIDjual.Size = New System.Drawing.Size(39, 13)
        Me.lblIDjual.TabIndex = 22
        Me.lblIDjual.Text = "Label2"
        '
        'BackgroundWorker1
        '
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.WindowsApp1.My.Resources.Resources.save__1_
        Me.btnSimpan.Location = New System.Drawing.Point(767, 245)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(41, 48)
        Me.btnSimpan.TabIndex = 11
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Image = Global.WindowsApp1.My.Resources.Resources.trash
        Me.btnHapus.Location = New System.Drawing.Point(767, 185)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(41, 44)
        Me.btnHapus.TabIndex = 7
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.WindowsApp1.My.Resources.Resources.plus1
        Me.btnTambah.Location = New System.Drawing.Point(767, 130)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(41, 39)
        Me.btnTambah.TabIndex = 6
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(902, 539)
        Me.Controls.Add(Me.lblIDjual)
        Me.Controls.Add(Me.lblNamaOperator)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.txtKembali)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.lblJumMenu)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblTanggal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPenjualan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblTanggal As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCariMenu As Button
    Friend WithEvents txtIDKain As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LVPenjualan As ListView
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents lblJumMenu As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents txtKembali As TextBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents lblNamaOperator As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblIDjual As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnTambah As Button
End Class
