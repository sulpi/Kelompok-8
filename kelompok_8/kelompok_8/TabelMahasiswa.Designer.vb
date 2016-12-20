<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TabelMahasiswa
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
        Me.MahasiswaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NimMahasiswaTextBox = New System.Windows.Forms.TextBox()
        Me.NamaMahasiswaTextBox = New System.Windows.Forms.TextBox()
        Me.AlamatMahasiswaTextBox = New System.Windows.Forms.TextBox()
        Me.TambahButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.HapusButton = New System.Windows.Forms.Button()
        Me.SimpanButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        NimMahasiswaLabel = New System.Windows.Forms.Label()
        NamaMahasiswaLabel = New System.Windows.Forms.Label()
        AlamatMahasiswaLabel = New System.Windows.Forms.Label()
        CType(Me.Dbkelompok8DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MahasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MahasiswaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NimMahasiswaLabel
        '
        NimMahasiswaLabel.AutoSize = True
        NimMahasiswaLabel.Location = New System.Drawing.Point(12, 70)
        NimMahasiswaLabel.Name = "NimMahasiswaLabel"
        NimMahasiswaLabel.Size = New System.Drawing.Size(84, 13)
        NimMahasiswaLabel.TabIndex = 1
        NimMahasiswaLabel.Text = "Nim Mahasiswa:"
        '
        'NamaMahasiswaLabel
        '
        NamaMahasiswaLabel.AutoSize = True
        NamaMahasiswaLabel.Location = New System.Drawing.Point(12, 96)
        NamaMahasiswaLabel.Name = "NamaMahasiswaLabel"
        NamaMahasiswaLabel.Size = New System.Drawing.Size(94, 13)
        NamaMahasiswaLabel.TabIndex = 3
        NamaMahasiswaLabel.Text = "Nama Mahasiswa:"
        '
        'AlamatMahasiswaLabel
        '
        AlamatMahasiswaLabel.AutoSize = True
        AlamatMahasiswaLabel.Location = New System.Drawing.Point(12, 122)
        AlamatMahasiswaLabel.Name = "AlamatMahasiswaLabel"
        AlamatMahasiswaLabel.Size = New System.Drawing.Size(98, 13)
        AlamatMahasiswaLabel.TabIndex = 5
        AlamatMahasiswaLabel.Text = "Alamat Mahasiswa:"
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
        'MahasiswaDataGridView
        '
        Me.MahasiswaDataGridView.AutoGenerateColumns = False
        Me.MahasiswaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MahasiswaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.MahasiswaDataGridView.DataSource = Me.MahasiswaBindingSource
        Me.MahasiswaDataGridView.Location = New System.Drawing.Point(298, 67)
        Me.MahasiswaDataGridView.Name = "MahasiswaDataGridView"
        Me.MahasiswaDataGridView.Size = New System.Drawing.Size(340, 166)
        Me.MahasiswaDataGridView.TabIndex = 1
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
        'NimMahasiswaTextBox
        '
        Me.NimMahasiswaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "NimMahasiswa", True))
        Me.NimMahasiswaTextBox.Location = New System.Drawing.Point(127, 67)
        Me.NimMahasiswaTextBox.Name = "NimMahasiswaTextBox"
        Me.NimMahasiswaTextBox.Size = New System.Drawing.Size(147, 20)
        Me.NimMahasiswaTextBox.TabIndex = 2
        '
        'NamaMahasiswaTextBox
        '
        Me.NamaMahasiswaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "NamaMahasiswa", True))
        Me.NamaMahasiswaTextBox.Location = New System.Drawing.Point(127, 93)
        Me.NamaMahasiswaTextBox.Name = "NamaMahasiswaTextBox"
        Me.NamaMahasiswaTextBox.Size = New System.Drawing.Size(147, 20)
        Me.NamaMahasiswaTextBox.TabIndex = 4
        '
        'AlamatMahasiswaTextBox
        '
        Me.AlamatMahasiswaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "AlamatMahasiswa", True))
        Me.AlamatMahasiswaTextBox.Location = New System.Drawing.Point(127, 119)
        Me.AlamatMahasiswaTextBox.Name = "AlamatMahasiswaTextBox"
        Me.AlamatMahasiswaTextBox.Size = New System.Drawing.Size(147, 20)
        Me.AlamatMahasiswaTextBox.TabIndex = 6
        '
        'TambahButton
        '
        Me.TambahButton.Location = New System.Drawing.Point(47, 167)
        Me.TambahButton.Name = "TambahButton"
        Me.TambahButton.Size = New System.Drawing.Size(63, 30)
        Me.TambahButton.TabIndex = 7
        Me.TambahButton.Text = "Tambah"
        Me.TambahButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(116, 167)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(63, 30)
        Me.EditButton.TabIndex = 8
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'HapusButton
        '
        Me.HapusButton.Location = New System.Drawing.Point(185, 167)
        Me.HapusButton.Name = "HapusButton"
        Me.HapusButton.Size = New System.Drawing.Size(63, 30)
        Me.HapusButton.TabIndex = 9
        Me.HapusButton.Text = "Hapus"
        Me.HapusButton.UseVisualStyleBackColor = True
        '
        'SimpanButton
        '
        Me.SimpanButton.Location = New System.Drawing.Point(47, 203)
        Me.SimpanButton.Name = "SimpanButton"
        Me.SimpanButton.Size = New System.Drawing.Size(200, 30)
        Me.SimpanButton.TabIndex = 10
        Me.SimpanButton.Text = "Simpan"
        Me.SimpanButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 38)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Data Mahasiswa Politani"
        '
        'TabelMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 253)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SimpanButton)
        Me.Controls.Add(Me.HapusButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.TambahButton)
        Me.Controls.Add(NimMahasiswaLabel)
        Me.Controls.Add(Me.NimMahasiswaTextBox)
        Me.Controls.Add(NamaMahasiswaLabel)
        Me.Controls.Add(Me.NamaMahasiswaTextBox)
        Me.Controls.Add(AlamatMahasiswaLabel)
        Me.Controls.Add(Me.AlamatMahasiswaTextBox)
        Me.Controls.Add(Me.MahasiswaDataGridView)
        Me.Name = "TabelMahasiswa"
        Me.Text = "TabelMahasiswa"
        CType(Me.Dbkelompok8DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MahasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MahasiswaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dbkelompok8DataSet As kelompok_8.dbkelompok8DataSet
    Friend WithEvents MahasiswaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MahasiswaTableAdapter As kelompok_8.dbkelompok8DataSetTableAdapters.mahasiswaTableAdapter
    Friend WithEvents TableAdapterManager As kelompok_8.dbkelompok8DataSetTableAdapters.TableAdapterManager
    Friend WithEvents MahasiswaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NimMahasiswaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaMahasiswaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatMahasiswaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TambahButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents HapusButton As System.Windows.Forms.Button
    Friend WithEvents SimpanButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
