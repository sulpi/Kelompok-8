Public Class mahasiswa1

    Shared Function LoginToolStripMenuItem() As Object
        Throw New NotImplementedException
    End Function

    Shared Function LogoutToolStripMenuItem() As Object
        Throw New NotImplementedException
    End Function

    Shared Function TransaksiToolStripMenuItem() As Object
        Throw New NotImplementedException
    End Function

    Shared Function MasterToolStripMenuItem() As Object
        Throw New NotImplementedException
    End Function

    Shared Function LaporanToolStripMenuItem() As Object
        Throw New NotImplementedException
    End Function

    Shared Function UtilityToolStripMenuItem() As Object
        Throw New NotImplementedException
    End Function

    Private Sub MahasiswaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MahasiswaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dbkelompok8DataSet)

    End Sub

    Private Sub mahasiswa1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dbkelompok8DataSet.dosen' table. You can move, or remove it, as needed.
        Me.DosenTableAdapter.Fill(Me.Dbkelompok8DataSet.dosen)
        'TODO: This line of code loads data into the 'Dbkelompok8DataSet.mahasiswa' table. You can move, or remove it, as needed.
        Me.MahasiswaTableAdapter.Fill(Me.Dbkelompok8DataSet.mahasiswa)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        NimMahasiswaTextBox.Enabled = True
        NamaMahasiswaTextBox.Enabled = True
        AlamatMahasiswaTextBox = True
        MahasiswaBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Validate()
        Me.MahasiswaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dbkelompok8DataSet)

        MessageBox.Show("data telah tersimpan")

        NimMahasiswaTextBox.Enabled = False
        NamaMahasiswaTextBox.Enabled = False
        AlamatMahasiswaTextBox = False

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("hapus data?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult Then
            MahasiswaBindingSource.RemoveCurrent()

            Me.Validate()
            Me.MahasiswaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Dbkelompok8DataSet)

            MessageBox.Show("data telah terhapus")
        End If
    End Sub
End Class