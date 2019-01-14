<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TampilDataKain
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
        Me.dgtampilkain = New System.Windows.Forms.DataGridView()
        CType(Me.dgtampilkain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgtampilkain
        '
        Me.dgtampilkain.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.dgtampilkain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtampilkain.Location = New System.Drawing.Point(27, 58)
        Me.dgtampilkain.Name = "dgtampilkain"
        Me.dgtampilkain.Size = New System.Drawing.Size(686, 478)
        Me.dgtampilkain.TabIndex = 0
        '
        'TampilDataKain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(725, 548)
        Me.Controls.Add(Me.dgtampilkain)
        Me.Name = "TampilDataKain"
        Me.Text = "TampilDataKain"
        CType(Me.dgtampilkain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgtampilkain As DataGridView
End Class
