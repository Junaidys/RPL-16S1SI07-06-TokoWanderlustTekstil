<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OlahDataKain
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
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtwarna = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtDetail = New System.Windows.Forms.TextBox()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.DGKain = New System.Windows.Forms.DataGridView()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGKain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBatal
        '
        Me.BtnBatal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnBatal.Location = New System.Drawing.Point(417, 335)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(84, 40)
        Me.BtnBatal.TabIndex = 5
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnProses
        '
        Me.BtnProses.BackColor = System.Drawing.Color.Transparent
        Me.BtnProses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnProses.Location = New System.Drawing.Point(310, 335)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(84, 40)
        Me.BtnProses.TabIndex = 4
        Me.BtnProses.Text = "Proses"
        Me.BtnProses.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Image = Global.WindowsApp1.My.Resources.Resources.stitching1
        Me.Label6.Location = New System.Drawing.Point(332, -8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 135)
        Me.Label6.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtwarna)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnTambah)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BtnEdit)
        Me.GroupBox1.Controls.Add(Me.BtnHapus)
        Me.GroupBox1.Controls.Add(Me.txtStok)
        Me.GroupBox1.Controls.Add(Me.txtharga)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.txtDetail)
        Me.GroupBox1.Controls.Add(Me.txtkode)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(705, 181)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(311, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Warna"
        '
        'txtwarna
        '
        Me.txtwarna.Location = New System.Drawing.Point(372, 119)
        Me.txtwarna.Name = "txtwarna"
        Me.txtwarna.Size = New System.Drawing.Size(161, 20)
        Me.txtwarna.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(311, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Stok"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(311, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nama Kain"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Kode Detail"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Kode Kain"
        '
        'BtnTambah
        '
        Me.BtnTambah.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnTambah.Location = New System.Drawing.Point(611, 13)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 39)
        Me.BtnTambah.TabIndex = 15
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(372, 233)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 32)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Batal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(244, 233)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 32)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Proses"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEdit.Location = New System.Drawing.Point(611, 58)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 39)
        Me.BtnEdit.TabIndex = 17
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnHapus.Location = New System.Drawing.Point(611, 109)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 39)
        Me.BtnHapus.TabIndex = 16
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'txtStok
        '
        Me.txtStok.Location = New System.Drawing.Point(373, 75)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(161, 20)
        Me.txtStok.TabIndex = 8
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(373, 36)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(161, 20)
        Me.txtharga.TabIndex = 6
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(90, 119)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(168, 20)
        Me.txtNama.TabIndex = 2
        '
        'txtDetail
        '
        Me.txtDetail.Location = New System.Drawing.Point(90, 75)
        Me.txtDetail.Name = "txtDetail"
        Me.txtDetail.Size = New System.Drawing.Size(168, 20)
        Me.txtDetail.TabIndex = 1
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(90, 36)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(168, 20)
        Me.txtkode.TabIndex = 0
        '
        'DGKain
        '
        Me.DGKain.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGKain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGKain.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGKain.Location = New System.Drawing.Point(45, 381)
        Me.DGKain.Name = "DGKain"
        Me.DGKain.ShowCellToolTips = False
        Me.DGKain.Size = New System.Drawing.Size(705, 255)
        Me.DGKain.TabIndex = 7
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Location = New System.Drawing.Point(693, 346)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.BtnRefresh.TabIndex = 8
        Me.BtnRefresh.Text = "Button3"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'OlahDataKain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 629)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.DGKain)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnProses)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "OlahDataKain"
        Me.Text = "OlahDataKain"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGKain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtDetail As TextBox
    Friend WithEvents txtkode As TextBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnProses As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGKain As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txtwarna As TextBox
    Friend WithEvents BtnRefresh As Button
End Class
