<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CariBarangJual
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
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.LvHasilCari = New System.Windows.Forms.ListView()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCari
        '
        Me.BtnCari.Location = New System.Drawing.Point(590, 17)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(38, 23)
        Me.BtnCari.TabIndex = 11
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(576, 425)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(52, 23)
        Me.BtnTutup.TabIndex = 10
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'LvHasilCari
        '
        Me.LvHasilCari.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LvHasilCari.Location = New System.Drawing.Point(15, 60)
        Me.LvHasilCari.Name = "LvHasilCari"
        Me.LvHasilCari.Size = New System.Drawing.Size(613, 350)
        Me.LvHasilCari.TabIndex = 8
        Me.LvHasilCari.UseCompatibleStateImageBehavior = False
        '
        'TxtCari
        '
        Me.TxtCari.Location = New System.Drawing.Point(167, 19)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(402, 20)
        Me.TxtCari.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Masukkan Judul yang di Cari :"
        '
        'CariBarangJual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(731, 450)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.LvHasilCari)
        Me.Controls.Add(Me.TxtCari)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CariBarangJual"
        Me.Text = "CariBarangJual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCari As Button
    Friend WithEvents BtnTutup As Button
    Friend WithEvents LvHasilCari As ListView
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents Label1 As Label
End Class
