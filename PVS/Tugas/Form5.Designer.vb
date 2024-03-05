<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        GroupBox1 = New GroupBox()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        GroupBox2 = New GroupBox()
        Button8 = New Button()
        Button7 = New Button()
        GroupBox3 = New GroupBox()
        TextBox3 = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(20, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(171, 41)
        Label1.TabIndex = 0
        Label1.Text = "Kalkulator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Montserrat", 10.8F)
        Label2.Location = New Point(23, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 25)
        Label2.TabIndex = 1
        Label2.Text = "Agka Pertama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Montserrat", 10.8F)
        Label3.Location = New Point(23, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 25)
        Label3.TabIndex = 2
        Label3.Text = "Agka Kedua"
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Montserrat", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(20, 103)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(183, 40)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Montserrat", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(23, 188)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(183, 40)
        TextBox2.TabIndex = 4
        ' 
        ' GroupBox1
        ' 
        GroupBox1.AutoSize = True
        GroupBox1.Controls.Add(Button6)
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Font = New Font("Montserrat", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(23, 274)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(174, 162)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Action"
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(118, 84)
        Button6.Name = "Button6"
        Button6.Size = New Size(50, 50)
        Button6.TabIndex = 5
        Button6.Text = "%"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(62, 84)
        Button5.Name = "Button5"
        Button5.Size = New Size(50, 50)
        Button5.TabIndex = 4
        Button5.Text = "^"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(6, 84)
        Button4.Name = "Button4"
        Button4.Size = New Size(50, 50)
        Button4.TabIndex = 3
        Button4.Text = "/"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(118, 28)
        Button3.Name = "Button3"
        Button3.Size = New Size(50, 50)
        Button3.TabIndex = 2
        Button3.Text = "x"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(62, 28)
        Button2.Name = "Button2"
        Button2.Size = New Size(50, 50)
        Button2.TabIndex = 1
        Button2.Text = "-"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(6, 28)
        Button1.Name = "Button1"
        Button1.Size = New Size(50, 50)
        Button1.TabIndex = 0
        Button1.Text = "+"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.AutoSize = True
        GroupBox2.Controls.Add(Button8)
        GroupBox2.Controls.Add(Button7)
        GroupBox2.Font = New Font("Montserrat", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(229, 274)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(206, 106)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Option"
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Montserrat", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button8.Location = New Point(106, 28)
        Button8.Name = "Button8"
        Button8.Size = New Size(94, 50)
        Button8.TabIndex = 1
        Button8.Text = "🔙"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Button7.Location = New Point(6, 29)
        Button7.Name = "Button7"
        Button7.Size = New Size(94, 49)
        Button7.TabIndex = 0
        Button7.Text = "🗑️"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.AutoSize = True
        GroupBox3.Controls.Add(TextBox3)
        GroupBox3.Font = New Font("Montserrat", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(229, 73)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(206, 183)
        GroupBox3.TabIndex = 7
        GroupBox3.TabStop = False
        GroupBox3.Text = "Result"
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Location = New Point(6, 30)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(194, 125)
        TextBox3.TabIndex = 0
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(598, 486)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kalkulator"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox3 As TextBox
End Class
