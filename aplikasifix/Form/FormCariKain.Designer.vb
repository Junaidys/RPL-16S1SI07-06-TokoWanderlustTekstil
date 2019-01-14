<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCariKain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.LvHasilCari = New System.Windows.Forms.ListView()
        Me.BtnPilih = New System.Windows.Forms.Button()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Masukkan Judul yang di Cari :"
        '
        'TxtCari
        '
        Me.TxtCari.Location = New System.Drawing.Point(167, 20)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(341, 20)
        Me.TxtCari.TabIndex = 1
        '
        'LvHasilCari
        '
        Me.LvHasilCari.Location = New System.Drawing.Point(15, 46)
        Me.LvHasilCari.Name = "LvHasilCari"
        Me.LvHasilCari.Size = New System.Drawing.Size(493, 350)
        Me.LvHasilCari.TabIndex = 2
        Me.LvHasilCari.UseCompatibleStateImageBehavior = False
        '
        'BtnPilih
        '
        Me.BtnPilih.Location = New System.Drawing.Point(386, 402)
        Me.BtnPilih.Name = "BtnPilih"
        Me.BtnPilih.Size = New System.Drawing.Size(51, 23)
        Me.BtnPilih.TabIndex = 3
        Me.BtnPilih.Text = "Pilih"
        Me.BtnPilih.UseVisualStyleBackColor = True
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(456, 402)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(52, 23)
        Me.BtnTutup.TabIndex = 4
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'BtnCari
        '
        Me.BtnCari.Location = New System.Drawing.Point(514, 17)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(38, 23)
        Me.BtnCari.TabIndex = 5
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'FormCariKain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 450)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnPilih)
        Me.Controls.Add(Me.LvHasilCari)
        Me.Controls.Add(Me.TxtCari)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormCariKain"
        Me.Text = "FormCariKain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents LvHasilCari As ListView
    Friend WithEvents BtnPilih As Button
    Friend WithEvents BtnTutup As Button
    Friend WithEvents BtnCari As Button
End Class
