Public Class Form2
    Dim tutup As String
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        tutup = MessageBox.Show("anda yakin menutup?", "local variable", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tutup = MsgBoxResult.Yes Then
            End
        Else
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form0 As New Form0
        form0.Show()
        Me.Hide()
    End Sub
End Class