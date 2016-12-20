<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TabelRuang
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
        Dim KodeRuangLabel As System.Windows.Forms.Label
        Dim LokasiLabel As System.Windows.Forms.Label
        Dim KapasitasRuangLabel As System.Windows.Forms.Label
        Me.Dbkelompok8DataSet = New kelompok_8.dbkelompok8DataSet()
        Me.RuangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RuangTableAdapter = New kelompok_8.dbkelompok8DataSetTableAdapters.ruangTableAdapter()
        Me.TableAdapterManager = New kelompok_8.dbkelompok8DataSetTableAdapters.TableAdapterManager()
        Me.RuangDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeRuangTextBox = New System.Windows.Forms.TextBox()
        Me.LokasiTextBox = New System.Windows.Forms.TextBox()
        Me.KapasitasRuangTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SimpanButton = New System.Windows.Forms.Button()
        Me.HapusButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.TambahButton = New System.Windows.Forms.Button()
        KodeRuangLabel = New System.Windows.Forms.Label()
        LokasiLabel = New System.Windows.Forms.Label()
        KapasitasRuangLabel = New System.Windows.Forms.Label()
        CType(Me.Dbkelompok8DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RuangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RuangDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KodeRuangLabel
        '
        KodeRuangLabel.AutoSize = True
        KodeRuangLabel.Location = New System.Drawing.Point(12, 59)
        KodeRuangLabel.Name = "KodeRuangLabel"
        KodeRuangLabel.Size = New System.Drawing.Size(70, 13)
        KodeRuangLabel.TabIndex = 1
        KodeRuangLabel.Text = "Kode Ruang:"
        '
        'LokasiLabel
        '
        LokasiLabel.AutoSize = True
        LokasiLabel.Location = New System.Drawing.Point(12, 85)
        LokasiLabel.Name = "LokasiLabel"
        LokasiLabel.Size = New System.Drawing.Size(41, 13)
        LokasiLabel.TabIndex = 3
        LokasiLabel.Text = "Lokasi:"
        '
        'KapasitasRuangLabel
        '
        KapasitasRuangLabel.AutoSize = True
        KapasitasRuangLabel.Location = New System.Drawing.Point(12, 111)
        KapasitasRuangLabel.Name = "KapasitasRuangLabel"
        KapasitasRuangLabel.Size = New System.Drawing.Size(91, 13)
        KapasitasRuangLabel.TabIndex = 5
        KapasitasRuangLabel.Text = "Kapasitas Ruang:"
        '
        'Dbkelompok8DataSet
        '
        Me.Dbkelompok8DataSet.DataSetName = "dbkelompok8DataSet"
        Me.Dbkelompok8DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RuangBindingSource
        '
        Me.RuangBindingSource.DataMember = "ruang"
        Me.RuangBindingSource.DataSource = Me.Dbkelompok8DataSet
        '
        'RuangTableAdapter
        '
        Me.RuangTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dosenTableAdapter = Nothing
        Me.TableAdapterManager.mahasiswa_has_mata_kuliahTableAdapter = Nothing
        Me.TableAdapterManager.mahasiswaTableAdapter = Nothing
        Me.TableAdapterManager.mata_kuliahTableAdapter = Nothing
        Me.TableAdapterManager.ruangTableAdapter = Me.RuangTableAdapter
        Me.TableAdapterManager.UpdateOrder = kelompok_8.dbkelompok8DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RuangDataGridView
        '
        Me.RuangDataGridView.AutoGenerateColumns = False
        Me.RuangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RuangDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.RuangDataGridView.DataSource = Me.RuangBindingSource
        Me.RuangDataGridView.Location = New System.Drawing.Point(239, 56)
        Me.RuangDataGridView.Name = "RuangDataGridView"
        Me.RuangDataGridView.Size = New System.Drawing.Size(344, 220)
        Me.RuangDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "KodeRuang"
        Me.DataGridViewTextBoxColumn1.HeaderText = "KodeRuang"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Lokasi"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Lokasi"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "KapasitasRuang"
        Me.DataGridViewTextBoxColumn3.HeaderText = "KapasitasRuang"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'KodeRuangTextBox
        '
        Me.KodeRuangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RuangBindingSource, "KodeRuang", True))
        Me.KodeRuangTextBox.Location = New System.Drawing.Point(109, 56)
        Me.KodeRuangTextBox.Name = "KodeRuangTextBox"
        Me.KodeRuangTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KodeRuangTextBox.TabIndex = 2
        '
        'LokasiTextBox
        '
        Me.LokasiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RuangBindingSource, "Lokasi", True))
        Me.LokasiTextBox.Location = New System.Drawing.Point(109, 82)
        Me.LokasiTextBox.Name = "LokasiTextBox"
        Me.LokasiTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LokasiTextBox.TabIndex = 4
        '
        'KapasitasRuangTextBox
        '
        Me.KapasitasRuangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RuangBindingSource, "KapasitasRuang", True))
        Me.KapasitasRuangTextBox.Location = New System.Drawing.Point(109, 108)
        Me.KapasitasRuangTextBox.Name = "KapasitasRuangTextBox"
        Me.KapasitasRuangTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KapasitasRuangTextBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 38)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Data Ruang Politani"
        '
        'SimpanButton
        '
        Me.SimpanButton.Location = New System.Drawing.Point(15, 186)
        Me.SimpanButton.Name = "SimpanButton"
        Me.SimpanButton.Size = New System.Drawing.Size(200, 30)
        Me.SimpanButton.TabIndex = 21
        Me.SimpanButton.Text = "Simpan"
        Me.SimpanButton.UseVisualStyleBackColor = True
        '
        'HapusButton
        '
        Me.HapusButton.Location = New System.Drawing.Point(153, 150)
        Me.HapusButton.Name = "HapusButton"
        Me.HapusButton.Size = New System.Drawing.Size(63, 30)
        Me.HapusButton.TabIndex = 20
        Me.HapusButton.Text = "Hapus"
        Me.HapusButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(84, 150)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(63, 30)
        Me.EditButton.TabIndex = 19
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'TambahButton
        '
        Me.TambahButton.Location = New System.Drawing.Point(15, 150)
        Me.TambahButton.Name = "TambahButton"
        Me.TambahButton.Size = New System.Drawing.Size(63, 30)
        Me.TambahButton.TabIndex = 18
        Me.TambahButton.Text = "Tambah"
        Me.TambahButton.UseVisualStyleBackColor = True
        '
        'TabelRuang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 283)
        Me.Controls.Add(Me.SimpanButton)
        Me.Controls.Add(Me.HapusButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.TambahButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(KodeRuangLabel)
        Me.Controls.Add(Me.KodeRuangTextBox)
        Me.Controls.Add(LokasiLabel)
        Me.Controls.Add(Me.LokasiTextBox)
        Me.Controls.Add(KapasitasRuangLabel)
        Me.Controls.Add(Me.KapasitasRuangTextBox)
        Me.Controls.Add(Me.RuangDataGridView)
        Me.Name = "TabelRuang"
        Me.Text = "TabelRuang"
        CType(Me.Dbkelompok8DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RuangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RuangDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dbkelompok8DataSet As kelompok_8.dbkelompok8DataSet
    Friend WithEvents RuangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RuangTableAdapter As kelompok_8.dbkelompok8DataSetTableAdapters.ruangTableAdapter
    Friend WithEvents TableAdapterManager As kelompok_8.dbkelompok8DataSetTableAdapters.TableAdapterManager
    Friend WithEvents RuangDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeRuangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LokasiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KapasitasRuangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SimpanButton As System.Windows.Forms.Button
    Friend WithEvents HapusButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents TambahButton As System.Windows.Forms.Button
End Class
