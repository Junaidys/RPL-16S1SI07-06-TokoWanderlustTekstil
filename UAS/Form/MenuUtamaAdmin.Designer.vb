<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuUtamaAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OlahDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OlahDataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OlahDataOperatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OlahDataSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OlahDataToolStripMenuItem, Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(742, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OlahDataToolStripMenuItem
        '
        Me.OlahDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OlahDataBarangToolStripMenuItem, Me.OlahDataOperatorToolStripMenuItem, Me.OlahDataSupplierToolStripMenuItem})
        Me.OlahDataToolStripMenuItem.Name = "OlahDataToolStripMenuItem"
        Me.OlahDataToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.OlahDataToolStripMenuItem.Text = "Olah Data"
        '
        'OlahDataBarangToolStripMenuItem
        '
        Me.OlahDataBarangToolStripMenuItem.Name = "OlahDataBarangToolStripMenuItem"
        Me.OlahDataBarangToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OlahDataBarangToolStripMenuItem.Text = "Olah Data Barang"
        '
        'OlahDataOperatorToolStripMenuItem
        '
        Me.OlahDataOperatorToolStripMenuItem.Name = "OlahDataOperatorToolStripMenuItem"
        Me.OlahDataOperatorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OlahDataOperatorToolStripMenuItem.Text = "Olah Data Operator"
        '
        'OlahDataSupplierToolStripMenuItem
        '
        Me.OlahDataSupplierToolStripMenuItem.Name = "OlahDataSupplierToolStripMenuItem"
        Me.OlahDataSupplierToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OlahDataSupplierToolStripMenuItem.Text = "Olah Data Supplier"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataKasirToolStripMenuItem, Me.DataSupplierToolStripMenuItem, Me.DataBarangToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'DataKasirToolStripMenuItem
        '
        Me.DataKasirToolStripMenuItem.Name = "DataKasirToolStripMenuItem"
        Me.DataKasirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataKasirToolStripMenuItem.Text = "Data Operator"
        '
        'DataSupplierToolStripMenuItem
        '
        Me.DataSupplierToolStripMenuItem.Name = "DataSupplierToolStripMenuItem"
        Me.DataSupplierToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataSupplierToolStripMenuItem.Text = "Data Supplier"
        '
        'DataBarangToolStripMenuItem
        '
        Me.DataBarangToolStripMenuItem.Name = "DataBarangToolStripMenuItem"
        Me.DataBarangToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataBarangToolStripMenuItem.Text = "Data Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(314, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Halaman Admin"
        '
        'MenuUtamaAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(742, 485)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuUtamaAdmin"
        Me.Text = "MenuUtamaAdmin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OlahDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OlahDataBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OlahDataOperatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OlahDataSupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataKasirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataSupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBarangToolStripMenuItem As ToolStripMenuItem
End Class
