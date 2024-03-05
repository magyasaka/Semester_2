Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbOperator.Items.Add("+")
        cmbOperator.Items.Add("-")
        cmbOperator.Items.Add("x")
        cmbOperator.Items.Add("/")
        cmbOperator.Items.Add("Sisa")
        cmbOperator.Items.Add("Pangkat")
        cmbOperator.Items.Add("<>")
        cmbOperator.Items.Add("<")
        cmbOperator.Items.Add(">")
        cmbOperator.Items.Add("<=")
        cmbOperator.Items.Add(">=")
        cmbOperator.Items.Add("Like")
        cmbOperator.Items.Add("Not")
        cmbOperator.Items.Add("And")
        cmbOperator.Items.Add("Or")
        cmbOperator.Items.Add("Xor")
        cmbOperator.Items.Add("+p")
        cmbOperator.Items.Add("&")
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Select Case cmbOperator.Text
            Case "+"
                txtHasil.Text = Val(txtNilai1.Text) + Val(txtNilai2.Text)
            Case "-"
                txtHasil.Text = Val(txtNilai1.Text) - Val(txtNilai2.Text)
            Case "x"
                txtHasil.Text = Val(txtNilai1.Text) * Val(txtNilai2.Text)
            Case "/"
                txtHasil.Text = Val(txtNilai1.Text) / Val(txtNilai2.Text)
            Case "Sisa"
                txtHasil.Text = Val(txtNilai1.Text) Mod Val(txtNilai2.Text)
            Case "Pangkat"
                txtHasil.Text = Val(txtNilai1.Text) ^ Val(txtNilai2.Text)
            Case "<>"
                txtHasil.Text = txtNilai1.Text <> txtNilai2.Text
            Case "<"
                txtHasil.Text = txtNilai1.Text < txtNilai2.Text
            Case ">"
                txtHasil.Text = txtNilai1.Text > txtNilai2.Text
            Case "<="
                txtHasil.Text = txtNilai1.Text <= txtNilai2.Text
            Case ">="
                txtHasil.Text = txtNilai1.Text >= txtNilai2.Text
            Case "Like"
                txtHasil.Text = txtNilai1.Text Like txtNilai2.Text
            Case "Not"
                txtHasil.Text = Not txtNilai1.Text = txtNilai2.Text
            Case "And"
                txtHasil.Text = txtNilai1.Text = "POLINES" And txtNilai2.Text = "POLINES"
            Case "Or"
                txtHasil.Text = txtNilai1.Text = "POLINES" Or txtNilai2.Text = "POLINES"
            Case "Xor"
                txtHasil.Text = txtNilai1.Text = "POLINES" Xor txtNilai2.Text = "POLINES"
            Case "+P"
                txtHasil.Text = txtNilai1.Text + txtNilai2.Text
            Case "&"
                txtHasil.Text = txtNilai1.Text & txtNilai2.Text
        End Select

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form0 As New Form0
        form0.Show()
        Me.Hide()
    End Sub
End Class