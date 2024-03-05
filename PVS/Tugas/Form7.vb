Public Class Form7
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim form0 As New Form0
        form0.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label3.Text = ComboBox1.SelectedItem
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Label4.Text = ComboBox2.SelectedItem
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim panjangDari = ComboBox1.SelectedIndex
        Dim panjangKe = ComboBox2.SelectedIndex

        Select Case panjangDari
            Case 0
                Select Case panjangKe
                    Case 0
                        TextBox2.Text = Val(TextBox1.Text) * 1
                    Case 1
                        TextBox2.Text = Val(TextBox1.Text) * 10
                    Case 2
                        TextBox2.Text = Val(TextBox1.Text) * 100
                    Case 3
                        TextBox2.Text = Val(TextBox1.Text) * 1000
                    Case 4
                        TextBox2.Text = Val(TextBox1.Text) * 10000
                    Case 5
                        TextBox2.Text = Val(TextBox1.Text) * 100000
                    Case 6
                        TextBox2.Text = Val(TextBox1.Text) * 1000000
                End Select
            Case 1
                Select Case panjangKe
                    Case 0
                        TextBox2.Text = Val(TextBox1.Text) / 10
                    Case 1
                        TextBox2.Text = Val(TextBox1.Text) * 1
                    Case 2
                        TextBox2.Text = Val(TextBox1.Text) * 10
                    Case 3
                        TextBox2.Text = Val(TextBox1.Text) * 100
                    Case 4
                        TextBox2.Text = Val(TextBox1.Text) * 1000
                    Case 5
                        TextBox2.Text = Val(TextBox1.Text) * 10000
                    Case 6
                        TextBox2.Text = Val(TextBox1.Text) * 100000
                End Select
            Case 2
                Select Case panjangKe
                    Case 0
                        TextBox2.Text = Val(TextBox1.Text) / 100
                    Case 1
                        TextBox2.Text = Val(TextBox1.Text) / 10
                    Case 2
                        TextBox2.Text = Val(TextBox1.Text) * 1
                    Case 3
                        TextBox2.Text = Val(TextBox1.Text) * 10
                    Case 4
                        TextBox2.Text = Val(TextBox1.Text) * 100
                    Case 5
                        TextBox2.Text = Val(TextBox1.Text) * 1000
                    Case 6
                        TextBox2.Text = Val(TextBox1.Text) * 10000
                End Select
            Case 3
                Select Case panjangKe
                    Case 0
                        TextBox2.Text = Val(TextBox1.Text) / 1000
                    Case 1
                        TextBox2.Text = Val(TextBox1.Text) / 100
                    Case 2
                        TextBox2.Text = Val(TextBox1.Text) / 10
                    Case 3
                        TextBox2.Text = Val(TextBox1.Text) * 1
                    Case 4
                        TextBox2.Text = Val(TextBox1.Text) * 10
                    Case 5
                        TextBox2.Text = Val(TextBox1.Text) * 100
                    Case 6
                        TextBox2.Text = Val(TextBox1.Text) * 1000
                End Select
            Case 4
                Select Case panjangKe
                    Case 0
                        TextBox2.Text = Val(TextBox1.Text) / 10000
                    Case 1
                        TextBox2.Text = Val(TextBox1.Text) / 1000
                    Case 2
                        TextBox2.Text = Val(TextBox1.Text) / 100
                    Case 3
                        TextBox2.Text = Val(TextBox1.Text) / 10
                    Case 4
                        TextBox2.Text = Val(TextBox1.Text) * 1
                    Case 5
                        TextBox2.Text = Val(TextBox1.Text) * 10
                    Case 6
                        TextBox2.Text = Val(TextBox1.Text) * 100
                End Select
            Case 5
                Select Case panjangKe
                    Case 0
                        TextBox2.Text = Val(TextBox1.Text) / 100000
                    Case 1
                        TextBox2.Text = Val(TextBox1.Text) / 10000
                    Case 2
                        TextBox2.Text = Val(TextBox1.Text) / 1000
                    Case 3
                        TextBox2.Text = Val(TextBox1.Text) / 100
                    Case 4
                        TextBox2.Text = Val(TextBox1.Text) / 10
                    Case 5
                        TextBox2.Text = Val(TextBox1.Text) * 1
                    Case 6
                        TextBox2.Text = Val(TextBox1.Text) * 10
                End Select
            Case 6
                Select Case panjangKe
                    Case 0
                        TextBox2.Text = Val(TextBox1.Text) / 1000000
                    Case 1
                        TextBox2.Text = Val(TextBox1.Text) / 100000
                    Case 2
                        TextBox2.Text = Val(TextBox1.Text) / 10000
                    Case 3
                        TextBox2.Text = Val(TextBox1.Text) / 1000
                    Case 4
                        TextBox2.Text = Val(TextBox1.Text) / 100
                    Case 5
                        TextBox2.Text = Val(TextBox1.Text) / 10
                    Case 6
                        TextBox2.Text = Val(TextBox1.Text) * 1
                End Select
        End Select

    End Sub
End Class