<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembelian
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnBaru = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblJumItem = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LVItemBeli = New System.Windows.Forms.ListView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBanyak = New System.Windows.Forms.TextBox()
        Me.TxtHargaKain = New System.Windows.Forms.TextBox()
        Me.TxtNamaKain = New System.Windows.Forms.TextBox()
        Me.BtnCariKain = New System.Windows.Forms.Button()
        Me.TxtKodeKain = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblKasir = New System.Windows.Forms.Label()
        Me.LblWaktu = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSimpan)
        Me.GroupBox1.Controls.Add(Me.BtnBaru)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(783, 512)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaksi Pembelian"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(146, 481)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpan.TabIndex = 3
        Me.BtnSimpan.Text = "Button3"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnBaru
        '
        Me.BtnBaru.Location = New System.Drawing.Point(16, 481)
        Me.BtnBaru.Name = "BtnBaru"
        Me.BtnBaru.Size = New System.Drawing.Size(75, 23)
        Me.BtnBaru.TabIndex = 2
        Me.BtnBaru.Text = "Baru"
        Me.BtnBaru.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(561, 481)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "ORDER"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.BtnHapus)
        Me.GroupBox2.Controls.Add(Me.BtnTambah)
        Me.GroupBox2.Controls.Add(Me.LblTotal)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.LblJumItem)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.LVItemBeli)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtBanyak)
        Me.GroupBox2.Controls.Add(Me.TxtHargaKain)
        Me.GroupBox2.Controls.Add(Me.TxtNamaKain)
        Me.GroupBox2.Controls.Add(Me.BtnCariKain)
        Me.GroupBox2.Controls.Add(Me.TxtKodeKain)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(767, 456)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(685, 200)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(8, 8)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(666, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(666, 114)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(61, 23)
        Me.BtnHapus.TabIndex = 17
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(666, 85)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(61, 23)
        Me.BtnTambah.TabIndex = 16
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(587, 386)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(14, 13)
        Me.LblTotal.TabIndex = 13
        Me.LblTotal.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(457, 386)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Total Belanja"
        '
        'LblJumItem
        '
        Me.LblJumItem.AutoSize = True
        Me.LblJumItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJumItem.Location = New System.Drawing.Point(143, 386)
        Me.LblJumItem.Name = "LblJumItem"
        Me.LblJumItem.Size = New System.Drawing.Size(14, 13)
        Me.LblJumItem.TabIndex = 11
        Me.LblJumItem.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(7, 386)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Jumlah Item"
        '
        'LVItemBeli
        '
        Me.LVItemBeli.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LVItemBeli.Location = New System.Drawing.Point(10, 85)
        Me.LVItemBeli.Name = "LVItemBeli"
        Me.LVItemBeli.Size = New System.Drawing.Size(650, 289)
        Me.LVItemBeli.TabIndex = 9
        Me.LVItemBeli.UseCompatibleStateImageBehavior = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(517, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Banyak Kain"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(387, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Harga Kain"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(171, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nama Kain"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Kode Kain"
        '
        'TxtBanyak
        '
        Me.TxtBanyak.Location = New System.Drawing.Point(520, 42)
        Me.TxtBanyak.Name = "TxtBanyak"
        Me.TxtBanyak.Size = New System.Drawing.Size(100, 20)
        Me.TxtBanyak.TabIndex = 4
        '
        'TxtHargaKain
        '
        Me.TxtHargaKain.Location = New System.Drawing.Point(390, 42)
        Me.TxtHargaKain.Name = "TxtHargaKain"
        Me.TxtHargaKain.Size = New System.Drawing.Size(96, 20)
        Me.TxtHargaKain.TabIndex = 3
        '
        'TxtNamaKain
        '
        Me.TxtNamaKain.Location = New System.Drawing.Point(174, 42)
        Me.TxtNamaKain.Name = "TxtNamaKain"
        Me.TxtNamaKain.Size = New System.Drawing.Size(184, 20)
        Me.TxtNamaKain.TabIndex = 2
        '
        'BtnCariKain
        '
        Me.BtnCariKain.Location = New System.Drawing.Point(112, 39)
        Me.BtnCariKain.Name = "BtnCariKain"
        Me.BtnCariKain.Size = New System.Drawing.Size(45, 23)
        Me.BtnCariKain.TabIndex = 1
        Me.BtnCariKain.Text = "....."
        Me.BtnCariKain.UseVisualStyleBackColor = True
        '
        'TxtKodeKain
        '
        Me.TxtKodeKain.Location = New System.Drawing.Point(6, 39)
        Me.TxtKodeKain.Name = "TxtKodeKain"
        Me.TxtKodeKain.Size = New System.Drawing.Size(100, 20)
        Me.TxtKodeKain.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(361, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "KASIR"
        '
        'LblKasir
        '
        Me.LblKasir.AutoSize = True
        Me.LblKasir.Location = New System.Drawing.Point(429, 13)
        Me.LblKasir.Name = "LblKasir"
        Me.LblKasir.Size = New System.Drawing.Size(28, 13)
        Me.LblKasir.TabIndex = 2
        Me.LblKasir.Text = "auto"
        '
        'LblWaktu
        '
        Me.LblWaktu.AutoSize = True
        Me.LblWaktu.Location = New System.Drawing.Point(562, 13)
        Me.LblWaktu.Name = "LblWaktu"
        Me.LblWaktu.Size = New System.Drawing.Size(55, 13)
        Me.LblWaktu.TabIndex = 3
        Me.LblWaktu.Text = "Auto Time"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'FormPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(781, 597)
        Me.Controls.Add(Me.LblWaktu)
        Me.Controls.Add(Me.LblKasir)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormPembelian"
        Me.Text = "FormPembelian"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBanyak As TextBox
    Friend WithEvents TxtHargaKain As TextBox
    Friend WithEvents TxtNamaKain As TextBox
    Friend WithEvents BtnCariKain As Button
    Friend WithEvents TxtKodeKain As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblJumItem As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LVItemBeli As ListView
    Friend WithEvents Label7 As Label
    Friend WithEvents LblKasir As Label
    Friend WithEvents LblWaktu As Label
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnBaru As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
End Class
