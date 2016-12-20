<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TabelMataKuliah
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
        Dim KodeMataKuliahLabel As System.Windows.Forms.Label
        Dim NamaMataKuliahLabel As System.Windows.Forms.Label
        Dim DeskripsiMataKuliahLabel As System.Windows.Forms.Label
        Dim Dosen_NIPLabel As System.Windows.Forms.Label
        Dim Dosen_Mahasiswa_NIMLabel As System.Windows.Forms.Label
        Dim Ruang_KodeRuangLabel As System.Windows.Forms.Label
        Me.Dbkelompok8DataSet = New kelompok_8.dbkelompok8DataSet()
        Me.Mata_kuliahBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mata_kuliahTableAdapter = New kelompok_8.dbkelompok8DataSetTableAdapters.mata_kuliahTableAdapter()
        Me.TableAdapterManager = New kelompok_8.dbkelompok8DataSetTableAdapters.TableAdapterManager()
        Me.Mata_kuliahDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeMataKuliahTextBox = New System.Windows.Forms.TextBox()
        Me.NamaMataKuliahTextBox = New System.Windows.Forms.TextBox()
        Me.DeskripsiMataKuliahTextBox = New System.Windows.Forms.TextBox()
        Me.Dosen_NIPTextBox = New System.Windows.Forms.TextBox()
        Me.Dosen_Mahasiswa_NIMTextBox = New System.Windows.Forms.TextBox()
        Me.Ruang_KodeRuangTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SimpanButton = New System.Windows.Forms.Button()
        Me.HapusButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.TambahButton = New System.Windows.Forms.Button()
        KodeMataKuliahLabel = New System.Windows.Forms.Label()
        NamaMataKuliahLabel = New System.Windows.Forms.Label()
        DeskripsiMataKuliahLabel = New System.Windows.Forms.Label()
        Dosen_NIPLabel = New System.Windows.Forms.Label()
        Dosen_Mahasiswa_NIMLabel = New System.Windows.Forms.Label()
        Ruang_KodeRuangLabel = New System.Windows.Forms.Label()
        CType(Me.Dbkelompok8DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mata_kuliahBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mata_kuliahDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KodeMataKuliahLabel
        '
        KodeMataKuliahLabel.AutoSize = True
        KodeMataKuliahLabel.Location = New System.Drawing.Point(20, 67)
        KodeMataKuliahLabel.Name = "KodeMataKuliahLabel"
        KodeMataKuliahLabel.Size = New System.Drawing.Size(94, 13)
        KodeMataKuliahLabel.TabIndex = 1
        KodeMataKuliahLabel.Text = "Kode Mata Kuliah:"
        '
        'NamaMataKuliahLabel
        '
        NamaMataKuliahLabel.AutoSize = True
        NamaMataKuliahLabel.Location = New System.Drawing.Point(20, 93)
        NamaMataKuliahLabel.Name = "NamaMataKuliahLabel"
        NamaMataKuliahLabel.Size = New System.Drawing.Size(97, 13)
        NamaMataKuliahLabel.TabIndex = 3
        NamaMataKuliahLabel.Text = "Nama Mata Kuliah:"
        '
        'DeskripsiMataKuliahLabel
        '
        DeskripsiMataKuliahLabel.AutoSize = True
        DeskripsiMataKuliahLabel.Location = New System.Drawing.Point(20, 119)
        DeskripsiMataKuliahLabel.Name = "DeskripsiMataKuliahLabel"
        DeskripsiMataKuliahLabel.Size = New System.Drawing.Size(112, 13)
        DeskripsiMataKuliahLabel.TabIndex = 5
        DeskripsiMataKuliahLabel.Text = "Deskripsi Mata Kuliah:"
        '
        'Dosen_NIPLabel
        '
        Dosen_NIPLabel.AutoSize = True
        Dosen_NIPLabel.Location = New System.Drawing.Point(20, 145)
        Dosen_NIPLabel.Name = "Dosen_NIPLabel"
        Dosen_NIPLabel.Size = New System.Drawing.Size(62, 13)
        Dosen_NIPLabel.TabIndex = 7
        Dosen_NIPLabel.Text = "Dosen-NIP:"
        '
        'Dosen_Mahasiswa_NIMLabel
        '
        Dosen_Mahasiswa_NIMLabel.AutoSize = True
        Dosen_Mahasiswa_NIMLabel.Location = New System.Drawing.Point(20, 171)
        Dosen_Mahasiswa_NIMLabel.Name = "Dosen_Mahasiswa_NIMLabel"
        Dosen_Mahasiswa_NIMLabel.Size = New System.Drawing.Size(120, 13)
        Dosen_Mahasiswa_NIMLabel.TabIndex = 9
        Dosen_Mahasiswa_NIMLabel.Text = "Dosen-Mahasiswa-NIM:"
        '
        'Ruang_KodeRuangLabel
        '
        Ruang_KodeRuangLabel.AutoSize = True
        Ruang_KodeRuangLabel.Location = New System.Drawing.Point(20, 197)
        Ruang_KodeRuangLabel.Name = "Ruang_KodeRuangLabel"
        Ruang_KodeRuangLabel.Size = New System.Drawing.Size(100, 13)
        Ruang_KodeRuangLabel.TabIndex = 11
        Ruang_KodeRuangLabel.Text = "ruang-Kode Ruang:"
        '
        'Dbkelompok8DataSet
        '
        Me.Dbkelompok8DataSet.DataSetName = "dbkelompok8DataSet"
        Me.Dbkelompok8DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Mata_kuliahBindingSource
        '
        Me.Mata_kuliahBindingSource.DataMember = "mata_kuliah"
        Me.Mata_kuliahBindingSource.DataSource = Me.Dbkelompok8DataSet
        '
        'Mata_kuliahTableAdapter
        '
        Me.Mata_kuliahTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dosenTableAdapter = Nothing
        Me.TableAdapterManager.mahasiswa_has_mata_kuliahTableAdapter = Nothing
        Me.TableAdapterManager.mahasiswaTableAdapter = Nothing
        Me.TableAdapterManager.mata_kuliahTableAdapter = Me.Mata_kuliahTableAdapter
        Me.TableAdapterManager.ruangTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = kelompok_8.dbkelompok8DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Mata_kuliahDataGridView
        '
        Me.Mata_kuliahDataGridView.AutoGenerateColumns = False
        Me.Mata_kuliahDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Mata_kuliahDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Mata_kuliahDataGridView.DataSource = Me.Mata_kuliahBindingSource
        Me.Mata_kuliahDataGridView.Location = New System.Drawing.Point(263, 64)
        Me.Mata_kuliahDataGridView.Name = "Mata_kuliahDataGridView"
        Me.Mata_kuliahDataGridView.Size = New System.Drawing.Size(334, 220)
        Me.Mata_kuliahDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "KodeMataKuliah"
        Me.DataGridViewTextBoxColumn1.HeaderText = "KodeMataKuliah"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NamaMataKuliah"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NamaMataKuliah"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DeskripsiMataKuliah"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DeskripsiMataKuliah"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Dosen_NIP"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Dosen_NIP"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Dosen_Mahasiswa_NIM"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Dosen_Mahasiswa_NIM"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ruang_KodeRuang"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ruang_KodeRuang"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'KodeMataKuliahTextBox
        '
        Me.KodeMataKuliahTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_kuliahBindingSource, "KodeMataKuliah", True))
        Me.KodeMataKuliahTextBox.Location = New System.Drawing.Point(146, 64)
        Me.KodeMataKuliahTextBox.Name = "KodeMataKuliahTextBox"
        Me.KodeMataKuliahTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KodeMataKuliahTextBox.TabIndex = 2
        '
        'NamaMataKuliahTextBox
        '
        Me.NamaMataKuliahTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_kuliahBindingSource, "NamaMataKuliah", True))
        Me.NamaMataKuliahTextBox.Location = New System.Drawing.Point(146, 90)
        Me.NamaMataKuliahTextBox.Name = "NamaMataKuliahTextBox"
        Me.NamaMataKuliahTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NamaMataKuliahTextBox.TabIndex = 4
        '
        'DeskripsiMataKuliahTextBox
        '
        Me.DeskripsiMataKuliahTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_kuliahBindingSource, "DeskripsiMataKuliah", True))
        Me.DeskripsiMataKuliahTextBox.Location = New System.Drawing.Point(146, 116)
        Me.DeskripsiMataKuliahTextBox.Name = "DeskripsiMataKuliahTextBox"
        Me.DeskripsiMataKuliahTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DeskripsiMataKuliahTextBox.TabIndex = 6
        '
        'Dosen_NIPTextBox
        '
        Me.Dosen_NIPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_kuliahBindingSource, "Dosen_NIP", True))
        Me.Dosen_NIPTextBox.Location = New System.Drawing.Point(146, 142)
        Me.Dosen_NIPTextBox.Name = "Dosen_NIPTextBox"
        Me.Dosen_NIPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Dosen_NIPTextBox.TabIndex = 8
        '
        'Dosen_Mahasiswa_NIMTextBox
        '
        Me.Dosen_Mahasiswa_NIMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_kuliahBindingSource, "Dosen_Mahasiswa_NIM", True))
        Me.Dosen_Mahasiswa_NIMTextBox.Location = New System.Drawing.Point(146, 168)
        Me.Dosen_Mahasiswa_NIMTextBox.Name = "Dosen_Mahasiswa_NIMTextBox"
        Me.Dosen_Mahasiswa_NIMTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Dosen_Mahasiswa_NIMTextBox.TabIndex = 10
        '
        'Ruang_KodeRuangTextBox
        '
        Me.Ruang_KodeRuangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_kuliahBindingSource, "ruang_KodeRuang", True))
        Me.Ruang_KodeRuangTextBox.Location = New System.Drawing.Point(146, 194)
        Me.Ruang_KodeRuangTextBox.Name = "Ruang_KodeRuangTextBox"
        Me.Ruang_KodeRuangTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Ruang_KodeRuangTextBox.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 38)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Data Mata Kuliah Politani"
        '
        'SimpanButton
        '
        Me.SimpanButton.Location = New System.Drawing.Point(31, 267)
        Me.SimpanButton.Name = "SimpanButton"
        Me.SimpanButton.Size = New System.Drawing.Size(200, 30)
        Me.SimpanButton.TabIndex = 17
        Me.SimpanButton.Text = "Simpan"
        Me.SimpanButton.UseVisualStyleBackColor = True
        '
        'HapusButton
        '
        Me.HapusButton.Location = New System.Drawing.Point(169, 231)
        Me.HapusButton.Name = "HapusButton"
        Me.HapusButton.Size = New System.Drawing.Size(63, 30)
        Me.HapusButton.TabIndex = 16
        Me.HapusButton.Text = "Hapus"
        Me.HapusButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(100, 231)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(63, 30)
        Me.EditButton.TabIndex = 15
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'TambahButton
        '
        Me.TambahButton.Location = New System.Drawing.Point(31, 231)
        Me.TambahButton.Name = "TambahButton"
        Me.TambahButton.Size = New System.Drawing.Size(63, 30)
        Me.TambahButton.TabIndex = 14
        Me.TambahButton.Text = "Tambah"
        Me.TambahButton.UseVisualStyleBackColor = True
        '
        'TabelMataKuliah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 303)
        Me.Controls.Add(Me.SimpanButton)
        Me.Controls.Add(Me.HapusButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.TambahButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(KodeMataKuliahLabel)
        Me.Controls.Add(Me.KodeMataKuliahTextBox)
        Me.Controls.Add(NamaMataKuliahLabel)
        Me.Controls.Add(Me.NamaMataKuliahTextBox)
        Me.Controls.Add(DeskripsiMataKuliahLabel)
        Me.Controls.Add(Me.DeskripsiMataKuliahTextBox)
        Me.Controls.Add(Dosen_NIPLabel)
        Me.Controls.Add(Me.Dosen_NIPTextBox)
        Me.Controls.Add(Dosen_Mahasiswa_NIMLabel)
        Me.Controls.Add(Me.Dosen_Mahasiswa_NIMTextBox)
        Me.Controls.Add(Ruang_KodeRuangLabel)
        Me.Controls.Add(Me.Ruang_KodeRuangTextBox)
        Me.Controls.Add(Me.Mata_kuliahDataGridView)
        Me.Name = "TabelMataKuliah"
        Me.Text = "TabelMataKuliah"
        CType(Me.Dbkelompok8DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mata_kuliahBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mata_kuliahDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dbkelompok8DataSet As kelompok_8.dbkelompok8DataSet
    Friend WithEvents Mata_kuliahBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mata_kuliahTableAdapter As kelompok_8.dbkelompok8DataSetTableAdapters.mata_kuliahTableAdapter
    Friend WithEvents TableAdapterManager As kelompok_8.dbkelompok8DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Mata_kuliahDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeMataKuliahTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaMataKuliahTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeskripsiMataKuliahTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Dosen_NIPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Dosen_Mahasiswa_NIMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ruang_KodeRuangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SimpanButton As System.Windows.Forms.Button
    Friend WithEvents HapusButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents TambahButton As System.Windows.Forms.Button
End Class
