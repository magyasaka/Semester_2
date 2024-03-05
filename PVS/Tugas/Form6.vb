Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form0 As New Form0
        form0.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox2.Text = Val(TextBox1.Text) * 4 / 5
        TextBox3.Text = (9 / 5 * Val(TextBox1.Text)) - 32
        TextBox4.Text = Val(TextBox1.Text) + 273
    End Sub

End Class