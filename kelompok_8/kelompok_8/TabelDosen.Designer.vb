<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TabelDosen
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
        Dim NipDosenLabel As System.Windows.Forms.Label
        Dim NamaDosenLabel As System.Windows.Forms.Label
        Dim AlamatDosenLabel As System.Windows.Forms.Label
        Dim Mata_kuliah_KodeMataKuliahLabel1 As System.Windows.Forms.Label
        Dim Mahasiswa_NIMLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dbkelompok8DataSet = New kelompok_8.dbkelompok8DataSet()
        Me.DosenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DosenTableAdapter = New kelompok_8.dbkelompok8DataSetTableAdapters.dosenTableAdapter()
        Me.TableAdapterManager = New kelompok_8.dbkelompok8DataSetTableAdapters.TableAdapterManager()
        Me.DosenDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NipDosenTextBox = New System.Windows.Forms.TextBox()
        Me.NamaDosenTextBox = New System.Windows.Forms.TextBox()
        Me.AlamatDosenTextBox = New System.Windows.Forms.TextBox()
        Me.SimpanButton = New System.Windows.Forms.Button()
        Me.HapusButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.TambahButton = New System.Windows.Forms.Button()
        Me.Mata_kuliah_KodeMataKuliahTextBox1 = New System.Windows.Forms.TextBox()
        Me.Mahasiswa_NIMTextBox = New System.Windows.Forms.TextBox()
        NipDosenLabel = New System.Windows.Forms.Label()
        NamaDosenLabel = New System.Windows.Forms.Label()
        AlamatDosenLabel = New System.Windows.Forms.Label()
        Mata_kuliah_KodeMataKuliahLabel1 = New System.Windows.Forms.Label()
        Mahasiswa_NIMLabel = New System.Windows.Forms.Label()
        CType(Me.Dbkelompok8DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DosenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DosenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NipDosenLabel
        '
        NipDosenLabel.AutoSize = True
        NipDosenLabel.Location = New System.Drawing.Point(12, 59)
        NipDosenLabel.Name = "NipDosenLabel"
        NipDosenLabel.Size = New System.Drawing.Size(60, 13)
        NipDosenLabel.TabIndex = 13
        NipDosenLabel.Text = "Nip Dosen:"
        '
        'NamaDosenLabel
        '
        NamaDosenLabel.AutoSize = True
        NamaDosenLabel.Location = New System.Drawing.Point(12, 85)
        NamaDosenLabel.Name = "NamaDosenLabel"
        NamaDosenLabel.Size = New System.Drawing.Size(72, 13)
        NamaDosenLabel.TabIndex = 15
        NamaDosenLabel.Text = "Nama Dosen:"
        '
        'AlamatDosenLabel
        '
        AlamatDosenLabel.AutoSize = True
        AlamatDosenLabel.Location = New System.Drawing.Point(12, 111)
        AlamatDosenLabel.Name = "AlamatDosenLabel"
        AlamatDosenLabel.Size = New System.Drawing.Size(76, 13)
        AlamatDosenLabel.TabIndex = 17
        AlamatDosenLabel.Text = "Alamat Dosen:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 38)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Data Dosen Politani"
        '
        'Dbkelompok8DataSet
        '
        Me.Dbkelompok8DataSet.DataSetName = "dbkelompok8DataSet"
        Me.Dbkelompok8DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dosenTableAdapter = Me.DosenTableAdapter
        Me.TableAdapterManager.mahasiswa_has_mata_kuliahTableAdapter = Nothing
        Me.TableAdapterManager.mahasiswaTableAdapter = Nothing
        Me.TableAdapterManager.mata_kuliahTableAdapter = Nothing
        Me.TableAdapterManager.ruangTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = kelompok_8.dbkelompok8DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DosenDataGridView
        '
        Me.DosenDataGridView.AutoGenerateColumns = False
        Me.DosenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DosenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.DosenDataGridView.DataSource = Me.DosenBindingSource
        Me.DosenDataGridView.Location = New System.Drawing.Point(331, 56)
        Me.DosenDataGridView.Name = "DosenDataGridView"
        Me.DosenDataGridView.Size = New System.Drawing.Size(344, 215)
        Me.DosenDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NipDosen"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NipDosen"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NamaDosen"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NamaDosen"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "AlamatDosen"
        Me.DataGridViewTextBoxColumn3.HeaderText = "AlamatDosen"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Mahasiswa_NIM"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Mahasiswa_NIM"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "mata_kuliah_KodeMataKuliah"
        Me.DataGridViewTextBoxColumn5.HeaderText = "mata_kuliah_KodeMataKuliah"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'NipDosenTextBox
        '
        Me.NipDosenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "NipDosen", True))
        Me.NipDosenTextBox.Location = New System.Drawing.Point(169, 56)
        Me.NipDosenTextBox.Name = "NipDosenTextBox"
        Me.NipDosenTextBox.Size = New System.Drawing.Size(156, 20)
        Me.NipDosenTextBox.TabIndex = 14
        '
        'NamaDosenTextBox
        '
        Me.NamaDosenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "NamaDosen", True))
        Me.NamaDosenTextBox.Location = New System.Drawing.Point(169, 82)
        Me.NamaDosenTextBox.Name = "NamaDosenTextBox"
        Me.NamaDosenTextBox.Size = New System.Drawing.Size(156, 20)
        Me.NamaDosenTextBox.TabIndex = 16
        '
        'AlamatDosenTextBox
        '
        Me.AlamatDosenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "AlamatDosen", True))
        Me.AlamatDosenTextBox.Location = New System.Drawing.Point(169, 108)
        Me.AlamatDosenTextBox.Name = "AlamatDosenTextBox"
        Me.AlamatDosenTextBox.Size = New System.Drawing.Size(156, 20)
        Me.AlamatDosenTextBox.TabIndex = 18
        '
        'SimpanButton
        '
        Me.SimpanButton.Location = New System.Drawing.Point(82, 241)
        Me.SimpanButton.Name = "SimpanButton"
        Me.SimpanButton.Size = New System.Drawing.Size(200, 30)
        Me.SimpanButton.TabIndex = 22
        Me.SimpanButton.Text = "Simpan"
        Me.SimpanButton.UseVisualStyleBackColor = True
        '
        'HapusButton
        '
        Me.HapusButton.Location = New System.Drawing.Point(220, 205)
        Me.HapusButton.Name = "HapusButton"
        Me.HapusButton.Size = New System.Drawing.Size(63, 30)
        Me.HapusButton.TabIndex = 21
        Me.HapusButton.Text = "Hapus"
        Me.HapusButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(151, 205)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(63, 30)
        Me.EditButton.TabIndex = 20
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'TambahButton
        '
        Me.TambahButton.Location = New System.Drawing.Point(82, 205)
        Me.TambahButton.Name = "TambahButton"
        Me.TambahButton.Size = New System.Drawing.Size(63, 30)
        Me.TambahButton.TabIndex = 19
        Me.TambahButton.Text = "Tambah"
        Me.TambahButton.UseVisualStyleBackColor = True
        '
        'Mata_kuliah_KodeMataKuliahTextBox1
        '
        Me.Mata_kuliah_KodeMataKuliahTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "mata_kuliah_KodeMataKuliah", True))
        Me.Mata_kuliah_KodeMataKuliahTextBox1.Location = New System.Drawing.Point(169, 160)
        Me.Mata_kuliah_KodeMataKuliahTextBox1.Name = "Mata_kuliah_KodeMataKuliahTextBox1"
        Me.Mata_kuliah_KodeMataKuliahTextBox1.Size = New System.Drawing.Size(156, 20)
        Me.Mata_kuliah_KodeMataKuliahTextBox1.TabIndex = 40
        '
        'Mata_kuliah_KodeMataKuliahLabel1
        '
        Mata_kuliah_KodeMataKuliahLabel1.AutoSize = True
        Mata_kuliah_KodeMataKuliahLabel1.Location = New System.Drawing.Point(12, 163)
        Mata_kuliah_KodeMataKuliahLabel1.Name = "Mata_kuliah_KodeMataKuliahLabel1"
        Mata_kuliah_KodeMataKuliahLabel1.Size = New System.Drawing.Size(151, 13)
        Mata_kuliah_KodeMataKuliahLabel1.TabIndex = 39
        Mata_kuliah_KodeMataKuliahLabel1.Text = "mata kuliah-Kode Mata Kuliah:"
        '
        'Mahasiswa_NIMTextBox
        '
        Me.Mahasiswa_NIMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "Mahasiswa_NIM", True))
        Me.Mahasiswa_NIMTextBox.Location = New System.Drawing.Point(169, 134)
        Me.Mahasiswa_NIMTextBox.Name = "Mahasiswa_NIMTextBox"
        Me.Mahasiswa_NIMTextBox.Size = New System.Drawing.Size(156, 20)
        Me.Mahasiswa_NIMTextBox.TabIndex = 47
        '
        'Mahasiswa_NIMLabel
        '
        Mahasiswa_NIMLabel.AutoSize = True
        Mahasiswa_NIMLabel.Location = New System.Drawing.Point(12, 137)
        Mahasiswa_NIMLabel.Name = "Mahasiswa_NIMLabel"
        Mahasiswa_NIMLabel.Size = New System.Drawing.Size(86, 13)
        Mahasiswa_NIMLabel.TabIndex = 46
        Mahasiswa_NIMLabel.Text = "Mahasiswa-NIM:"
        '
        'TabelDosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 283)
        Me.Controls.Add(Mahasiswa_NIMLabel)
        Me.Controls.Add(Me.Mahasiswa_NIMTextBox)
        Me.Controls.Add(Mata_kuliah_KodeMataKuliahLabel1)
        Me.Controls.Add(Me.Mata_kuliah_KodeMataKuliahTextBox1)
        Me.Controls.Add(Me.SimpanButton)
        Me.Controls.Add(Me.HapusButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.TambahButton)
        Me.Controls.Add(NipDosenLabel)
        Me.Controls.Add(Me.NipDosenTextBox)
        Me.Controls.Add(NamaDosenLabel)
        Me.Controls.Add(Me.NamaDosenTextBox)
        Me.Controls.Add(AlamatDosenLabel)
        Me.Controls.Add(Me.AlamatDosenTextBox)
        Me.Controls.Add(Me.DosenDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TabelDosen"
        Me.Text = "TabelDosen"
        CType(Me.Dbkelompok8DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DosenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DosenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Dbkelompok8DataSet As kelompok_8.dbkelompok8DataSet
    Friend WithEvents DosenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DosenTableAdapter As kelompok_8.dbkelompok8DataSetTableAdapters.dosenTableAdapter
    Friend WithEvents TableAdapterManager As kelompok_8.dbkelompok8DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DosenDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NipDosenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaDosenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatDosenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SimpanButton As System.Windows.Forms.Button
    Friend WithEvents HapusButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents TambahButton As System.Windows.Forms.Button
    Friend WithEvents Mata_kuliah_KodeMataKuliahTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Mahasiswa_NIMTextBox As System.Windows.Forms.TextBox
End Class
