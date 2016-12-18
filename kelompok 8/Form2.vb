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
        MahasiswaBindingSource.AddNew()
    End Sub
End Class