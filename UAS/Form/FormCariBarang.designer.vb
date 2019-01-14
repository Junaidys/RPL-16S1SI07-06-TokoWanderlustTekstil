<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCariBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCariBarang))
        Me.LVCariBarang = New System.Windows.Forms.ListView()
        Me.txtBarang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LVCariBarang
        '
        Me.LVCariBarang.Location = New System.Drawing.Point(50, 84)
        Me.LVCariBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.LVCariBarang.Name = "LVCariBarang"
        Me.LVCariBarang.Size = New System.Drawing.Size(1061, 436)
        Me.LVCariBarang.TabIndex = 8
        Me.LVCariBarang.UseCompatibleStateImageBehavior = False
        '
        'txtBarang
        '
        Me.txtBarang.Location = New System.Drawing.Point(161, 21)
        Me.txtBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBarang.Name = "txtBarang"
        Me.txtBarang.Size = New System.Drawing.Size(836, 22)
        Me.txtBarang.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nama Barang"
        '
        'btnCari
        '
        Me.btnCari.Image = CType(resources.GetObject("btnCari.Image"), System.Drawing.Image)
        Me.btnCari.Location = New System.Drawing.Point(1013, 13)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(98, 52)
        Me.btnCari.TabIndex = 5
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Image = CType(resources.GetObject("btnTutup.Image"), System.Drawing.Image)
        Me.btnTutup.Location = New System.Drawing.Point(1013, 552)
        Me.btnTutup.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(98, 52)
        Me.btnTutup.TabIndex = 10
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'FormCariBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1182, 643)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.LVCariBarang)
        Me.Controls.Add(Me.txtBarang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCari)
        Me.Name = "FormCariBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCariBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LVCariBarang As ListView
    Friend WithEvents txtBarang As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents btnTutup As Button
End Class
