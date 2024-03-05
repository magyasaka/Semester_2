<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtNilai1 = New TextBox()
        txtNilai2 = New TextBox()
        txtHasil = New TextBox()
        cmbOperator = New ComboBox()
        btnProses = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nilai 1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 20)
        Label2.TabIndex = 1
        Label2.Text = "Operator"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 20)
        Label3.TabIndex = 2
        Label3.Text = "Nilai 2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 236)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 20)
        Label4.TabIndex = 3
        Label4.Text = "Hasil"
        ' 
        ' txtNilai1
        ' 
        txtNilai1.Location = New Point(105, 30)
        txtNilai1.Name = "txtNilai1"
        txtNilai1.Size = New Size(125, 27)
        txtNilai1.TabIndex = 4
        ' 
        ' txtNilai2
        ' 
        txtNilai2.Location = New Point(105, 161)
        txtNilai2.Name = "txtNilai2"
        txtNilai2.Size = New Size(125, 27)
        txtNilai2.TabIndex = 6
        ' 
        ' txtHasil
        ' 
        txtHasil.Location = New Point(105, 233)
        txtHasil.Name = "txtHasil"
        txtHasil.Size = New Size(125, 27)
        txtHasil.TabIndex = 7
        ' 
        ' cmbOperator
        ' 
        cmbOperator.FormattingEnabled = True
        cmbOperator.Location = New Point(105, 95)
        cmbOperator.Name = "cmbOperator"
        cmbOperator.Size = New Size(151, 28)
        cmbOperator.TabIndex = 8
        ' 
        ' btnProses
        ' 
        btnProses.Location = New Point(227, 409)
        btnProses.Name = "btnProses"
        btnProses.Size = New Size(94, 29)
        btnProses.TabIndex = 9
        btnProses.Text = "Proses"
        btnProses.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(127, 409)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 10
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(333, 450)
        Controls.Add(Button1)
        Controls.Add(btnProses)
        Controls.Add(cmbOperator)
        Controls.Add(txtHasil)
        Controls.Add(txtNilai2)
        Controls.Add(txtNilai1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Operator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNilai1 As TextBox
    Friend WithEvents txtNilai2 As TextBox
    Friend WithEvents txtHasil As TextBox
    Friend WithEvents cmbOperator As ComboBox
    Friend WithEvents btnProses As Button
    Friend WithEvents Button1 As Button
End Class
