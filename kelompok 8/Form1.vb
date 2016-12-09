Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If TextBox1.Text = "nama" And TextBox2.Text = "password" Then
            ProgressBar1.Increment(10)
            If ProgressBar1.Value = ProgressBar1.Maximum Then
                Timer1.Stop()
                ProgressBar1.Value = 0
                MsgBox("Kamu Masuk", MsgBoxStyle.Information)
                Form2.Show()
            End If
        Else
            Timer1.Start()
            ProgressBar1.Increment(10)
            If ProgressBar1.Value = ProgressBar1.Maximum Then
                Timer1.Stop()
                ProgressBar1.Value = 0
                MsgBox("gagal masuk", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

End Class
