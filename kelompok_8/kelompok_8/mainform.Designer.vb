<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainform
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
        Me.MenuUtamaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DosenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MataKuliahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DosenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuUtamaToolStripMenuItem, Me.TentangToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(366, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuUtamaToolStripMenuItem
        '
        Me.MenuUtamaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MahasiswaToolStripMenuItem, Me.DosenToolStripMenuItem, Me.MataKuliahToolStripMenuItem, Me.DosenToolStripMenuItem1})
        Me.MenuUtamaToolStripMenuItem.Name = "MenuUtamaToolStripMenuItem"
        Me.MenuUtamaToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.MenuUtamaToolStripMenuItem.Text = "Menu Utama"
        '
        'MahasiswaToolStripMenuItem
        '
        Me.MahasiswaToolStripMenuItem.Name = "MahasiswaToolStripMenuItem"
        Me.MahasiswaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MahasiswaToolStripMenuItem.Text = "Mahasiswa"
        '
        'DosenToolStripMenuItem
        '
        Me.DosenToolStripMenuItem.Name = "DosenToolStripMenuItem"
        Me.DosenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DosenToolStripMenuItem.Text = "Dosen"
        '
        'MataKuliahToolStripMenuItem
        '
        Me.MataKuliahToolStripMenuItem.Name = "MataKuliahToolStripMenuItem"
        Me.MataKuliahToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MataKuliahToolStripMenuItem.Text = "Mata Kuliah"
        '
        'DosenToolStripMenuItem1
        '
        Me.DosenToolStripMenuItem1.Name = "DosenToolStripMenuItem1"
        Me.DosenToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.DosenToolStripMenuItem1.Text = "Ruang"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 164)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "mainform"
        Me.Text = "mainform"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuUtamaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MahasiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DosenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MataKuliahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DosenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
