Public Class TabelDosen

    Private Sub DosenBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DosenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dbkelompok8DataSet)

    End Sub

    Private Sub TambahButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahButton.Click
        NipDosenTextBox.Enabled = True
        NamaDosenTextBox.Enabled = True
        AlamatDosenTextBox.Enabled = True
        Mahasiswa_NIMTextBox.Enabled = True
        Mata_kuliah_KodeMataKuliahTextBox1.Enabled = True

        DosenBindingSource.AddNew()
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        NamaDosenTextBox.Enabled = True
        AlamatDosenTextBox.Enabled = True
        Mahasiswa_NIMTextBox.Enabled = True
        Mata_kuliah_KodeMataKuliahTextBox1.Enabled = True

    End Sub

    Private Sub HapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusButton.Click
        DosenBindingSource.RemoveCurrent()
        MessageBox.Show("Data Telah Terhapus")
    End Sub

    Private Sub SimpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanButton.Click
        Me.Validate()
        Me.DosenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dbkelompok8DataSet)

        MessageBox.Show("Data Telah Tersimpan")

        NamaDosenTextBox.Enabled = False
        AlamatDosenTextBox.Enabled = False
        Mahasiswa_NIMTextBox.Enabled = False
        Mata_kuliah_KodeMataKuliahTextBox1.Enabled = False
    End Sub

    Private Sub NipDosenTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NipDosenTextBox.TextChanged

    End Sub
End Class