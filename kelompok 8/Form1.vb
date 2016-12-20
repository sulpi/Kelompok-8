Public Class Form1

    Private Sub Text1_KeyPress(ByVal KeyAscii As Integer)
        If KeyAscii = vbKeyReturn Then
            Button2.SetBounds()
        End If
    End Sub


    Private Sub Text2_KeyPress(ByVal KeyAscii As Integer)
        If KeyAscii = vbKeyReturn Then
            Button1.SetBounds()
        End If
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.Text1.Text = "LABKOM" And Me.Text2.Text = "siswa" Then
        MsgBox ("Selamat datang di Lab Komputer"), , "Benar "
        Else
        MsgBox ("Password Anda Salah, Silahkan Coba Lagi !"), , "Salah"
            Exit Sub
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text1.Text = ""
        Me.Text2.Text = ""
    End Sub

    Private Function Text1() As Object
        Throw New NotImplementedException
    End Function

    Private Function Text2() As Object
        Throw New NotImplementedException
    End Function

    Private Function vbKeyReturn() As Integer
        Throw New NotImplementedException
    End Function

End Class
