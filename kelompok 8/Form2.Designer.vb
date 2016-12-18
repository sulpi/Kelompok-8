<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mahasiswa1
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
        Dim NimMahasiswaLabel As System.Windows.Forms.Label
        Dim NamaMahasiswaLabel As System.Windows.Forms.Label
        Dim AlamatMahasiswaLabel As System.Windows.Forms.Label
        Me.Dbkelompok8DataSet = New kelompok_8.dbkelompok8DataSet()
        Me.MahasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MahasiswaTableAdapter = New kelompok_8.dbkelompok8DataSetTableAdapters.mahasiswaTableAdapter()
        Me.TableAdapterManager = New kelompok_8.dbkelompok8DataSetTableAdapters.TableAdapterManager()
        Me.Mahasiswa = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DosenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DosenTableAdapter = New kelompok_8.dbkelompok8DataSetTableAdapters.dosenTableAdapter()
        Me.NimMahasiswaTextBox = New System.Windows.Forms.TextBox()
        Me.NamaMahasiswaTextBox = New System.Windows.Forms.TextBox()
        Me.AlamatMahasiswaTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        NimMahasiswaLabel = New System.Windows.Forms.Label()
        NamaMahasiswaLabel = New System.Windows.Forms.Label()
        AlamatMahasiswaLabel = New System.Windows.Forms.Label()
        CType(Me.Dbkelompok8DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MahasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DosenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dbkelompok8DataSet
        '
        Me.Dbkelompok8DataSet.DataSetName = "dbkelompok8DataSet"
        Me.Dbkelompok8DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MahasiswaBindingSource
        '
        Me.MahasiswaBindingSource.DataMember = "mahasiswa"
        Me.MahasiswaBindingSource.DataSource = Me.Dbkelompok8DataSet
        '
        'MahasiswaTableAdapter
        '
        Me.MahasiswaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dosenTableAdapter = Nothing
        Me.TableAdapterManager.mahasiswa_has_mata_kuliahTableAdapter = Nothing
        Me.TableAdapterManager.mahasiswaTableAdapter = Me.MahasiswaTableAdapter
        Me.TableAdapterManager.mata_kuliahTableAdapter = Nothing
        Me.TableAdapterManager.ruangTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = kelompok_8.dbkelompok8DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Mahasiswa
        '
        Me.Mahasiswa.AutoGenerateColumns = False
        Me.Mahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Mahasiswa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Mahasiswa.DataSource = Me.MahasiswaBindingSource
        Me.Mahasiswa.Location = New System.Drawing.Point(318, 29)
        Me.Mahasiswa.Name = "Mahasiswa"
        Me.Mahasiswa.Size = New System.Drawing.Size(343, 235)
        Me.Mahasiswa.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NimMahasiswa"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NimMahasiswa"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NamaMahasiswa"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NamaMahasiswa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "AlamatMahasiswa"
        Me.DataGridViewTextBoxColumn3.HeaderText = "AlamatMahasiswa"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(NimMahasiswaLabel)
        Me.GroupBox1.Controls.Add(Me.NimMahasiswaTextBox)
        Me.GroupBox1.Controls.Add(NamaMahasiswaLabel)
        Me.GroupBox1.Controls.Add(Me.NamaMahasiswaTextBox)
        Me.GroupBox1.Controls.Add(AlamatMahasiswaLabel)
        Me.GroupBox1.Controls.Add(Me.AlamatMahasiswaTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 246)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "data"
        '
        'DosenBindingSource
        '
        Me.DosenBindingSource.DataMember = "dosen"
        Me.DosenBindingSource.DataSource = Me.Dbkelompok8DataSet
        '
        'DosenTableAdapter
        '
        Me.DosenTableAdapter.ClearBeforeFill = True
        '
        'NimMahasiswaLabel
        '
        NimMahasiswaLabel.AutoSize = True
        NimMahasiswaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NimMahasiswaLabel.Location = New System.Drawing.Point(6, 36)
        NimMahasiswaLabel.Name = "NimMahasiswaLabel"
        NimMahasiswaLabel.Size = New System.Drawing.Size(106, 16)
        NimMahasiswaLabel.TabIndex = 0
        NimMahasiswaLabel.Text = "Nim Mahasiswa:"
        '
        'NimMahasiswaTextBox
        '
        Me.NimMahasiswaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "NimMahasiswa", True))
        Me.NimMahasiswaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NimMahasiswaTextBox.Location = New System.Drawing.Point(140, 33)
        Me.NimMahasiswaTextBox.Name = "NimMahasiswaTextBox"
        Me.NimMahasiswaTextBox.Size = New System.Drawing.Size(135, 21)
        Me.NimMahasiswaTextBox.TabIndex = 1
        '
        'NamaMahasiswaLabel
        '
        NamaMahasiswaLabel.AutoSize = True
        NamaMahasiswaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamaMahasiswaLabel.Location = New System.Drawing.Point(6, 63)
        NamaMahasiswaLabel.Name = "NamaMahasiswaLabel"
        NamaMahasiswaLabel.Size = New System.Drawing.Size(119, 16)
        NamaMahasiswaLabel.TabIndex = 2
        NamaMahasiswaLabel.Text = "Nama Mahasiswa:"
        '
        'NamaMahasiswaTextBox
        '
        Me.NamaMahasiswaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "NamaMahasiswa", True))
        Me.NamaMahasiswaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaMahasiswaTextBox.Location = New System.Drawing.Point(140, 60)
        Me.NamaMahasiswaTextBox.Name = "NamaMahasiswaTextBox"
        Me.NamaMahasiswaTextBox.Size = New System.Drawing.Size(135, 21)
        Me.NamaMahasiswaTextBox.TabIndex = 3
        '
        'AlamatMahasiswaLabel
        '
        AlamatMahasiswaLabel.AutoSize = True
        AlamatMahasiswaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AlamatMahasiswaLabel.Location = New System.Drawing.Point(6, 90)
        AlamatMahasiswaLabel.Name = "AlamatMahasiswaLabel"
        AlamatMahasiswaLabel.Size = New System.Drawing.Size(124, 16)
        AlamatMahasiswaLabel.TabIndex = 4
        AlamatMahasiswaLabel.Text = "Alamat Mahasiswa:"
        '
        'AlamatMahasiswaTextBox
        '
        Me.AlamatMahasiswaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "AlamatMahasiswa", True))
        Me.AlamatMahasiswaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlamatMahasiswaTextBox.Location = New System.Drawing.Point(140, 87)
        Me.AlamatMahasiswaTextBox.Name = "AlamatMahasiswaTextBox"
        Me.AlamatMahasiswaTextBox.Size = New System.Drawing.Size(135, 21)
        Me.AlamatMahasiswaTextBox.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 31)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(94, 166)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 31)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(172, 166)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 31)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(15, 203)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(229, 31)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Simpan"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'mahasiswa1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(673, 282)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Mahasiswa)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mahasiswa1"
        Me.Text = "MAHASISWA"
        CType(Me.Dbkelompok8DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MahasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DosenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dbkelompok8DataSet As kelompok_8.dbkelompok8DataSet
    Friend WithEvents MahasiswaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MahasiswaTableAdapter As kelompok_8.dbkelompok8DataSetTableAdapters.mahasiswaTableAdapter
    Friend WithEvents TableAdapterManager As kelompok_8.dbkelompok8DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Mahasiswa As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DosenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DosenTableAdapter As kelompok_8.dbkelompok8DataSetTableAdapters.dosenTableAdapter
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NimMahasiswaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaMahasiswaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatMahasiswaTextBox As System.Windows.Forms.TextBox
End Class
