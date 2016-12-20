Public Class TabelMataKuliah

    Private Sub Mata_kuliahBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Mata_kuliahBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dbkelompok8DataSet)

    End Sub

    Private Sub TambahButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahButton.Click
        KodeMataKuliahTextBox.Enabled = True
        NamaMataKuliahTextBox.Enabled = True
        DeskripsiMataKuliahTextBox.Enabled = True
        Dosen_NIPTextBox.Enabled = True
        Dosen_Mahasiswa_NIMTextBox.Enabled = True
        Ruang_KodeRuangTextBox.Enabled = True

        Mata_kuliahBindingSource.AddNew()
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        NamaMataKuliahTextBox.Enabled = True
        DeskripsiMataKuliahTextBox.Enabled = True
        Dosen_NIPTextBox.Enabled = True
        Dosen_Mahasiswa_NIMTextBox.Enabled = True
        Ruang_KodeRuangTextBox.Enabled = True
    End Sub

    Private Sub HapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusButton.Click
        Mata_kuliahBindingSource.RemoveCurrent()

        MessageBox.Show("Data Telah Terhapus")
    End Sub

    Private Sub SimpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanButton.Click
        Me.Validate()
        Me.Mata_kuliahBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dbkelompok8DataSet)

        MessageBox.Show("Data Telah Tersimpan")

        NamaMataKuliahTextBox.Enabled = False
        DeskripsiMataKuliahTextBox.Enabled = False
        Dosen_NIPTextBox.Enabled = False
        Dosen_Mahasiswa_NIMTextBox.Enabled = False
        Ruang_KodeRuangTextBox.Enabled = False
    End Sub
End Class