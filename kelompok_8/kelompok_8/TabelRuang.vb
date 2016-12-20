Public Class TabelRuang

    Private Sub RuangBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.RuangBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dbkelompok8DataSet)

    End Sub

    Private Sub TambahButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahButton.Click
        KodeRuangTextBox.Enabled = True
        LokasiTextBox.Enabled = True
        KapasitasRuangTextBox.Enabled = True

        RuangBindingSource.AddNew()
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        LokasiTextBox.Enabled = True
        KapasitasRuangTextBox.Enabled = True
    End Sub

    Private Sub HapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusButton.Click
        RuangBindingSource.RemoveCurrent()

        MessageBox.Show("Data Telah Terhapus")
    End Sub

    Private Sub SimpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanButton.Click
        Me.Validate()
        Me.RuangBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dbkelompok8DataSet)

        MessageBox.Show("Data Telah Tersimpan")

        LokasiTextBox.Enabled = False
        KapasitasRuangTextBox.Enabled = False
    End Sub
End Class