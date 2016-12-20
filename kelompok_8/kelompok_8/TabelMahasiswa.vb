Public Class TabelMahasiswa

    Private Sub MahasiswaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MahasiswaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dbkelompok8DataSet)

    End Sub

    Private Sub TambahButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahButton.Click
        NimMahasiswaTextBox.Enabled = True
        NamaMahasiswaTextBox.Enabled = True
        AlamatMahasiswaTextBox.Enabled = True

        MahasiswaBindingSource.AddNew()
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        NamaMahasiswaTextBox.Enabled = True
        AlamatMahasiswaTextBox.Enabled = True

    End Sub

    Private Sub HapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusButton.Click
        MahasiswaBindingSource.RemoveCurrent()
        MessageBox.Show("Data Telah Terhapus")
    End Sub

    Private Sub SimpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanButton.Click
        Me.Validate()
        Me.MahasiswaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dbkelompok8DataSet)

        MessageBox.Show("Data Telah Tersimpan")

        NimMahasiswaTextBox.Enabled = False
        NamaMahasiswaTextBox.Enabled = False
        AlamatMahasiswaTextBox.Enabled = False

    End Sub
End Class