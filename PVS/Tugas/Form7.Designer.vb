<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        LabelDari = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        LabelKe = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Label5 = New Label()
        Button2 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(100, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(285, 39)
        Label1.TabIndex = 0
        Label1.Text = "Converter Program"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Montserrat", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 32)
        Label2.TabIndex = 1
        Label2.Text = "↩️"
        ' 
        ' LabelDari
        ' 
        LabelDari.AutoSize = True
        LabelDari.Font = New Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelDari.Location = New Point(100, 90)
        LabelDari.Name = "LabelDari"
        LabelDari.Size = New Size(0, 27)
        LabelDari.TabIndex = 2
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"KM", "HM", "DAM", "M", "DM", "CM", "MM"})
        ComboBox1.Location = New Point(84, 85)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(74, 32)
        ComboBox1.TabIndex = 3
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"KM", "HM", "DAM", "M", "DM", "CM", "MM"})
        ComboBox2.Location = New Point(84, 165)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(74, 32)
        ComboBox2.TabIndex = 5
        ' 
        ' LabelKe
        ' 
        LabelKe.AutoSize = True
        LabelKe.Font = New Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelKe.Location = New Point(100, 170)
        LabelKe.Name = "LabelKe"
        LabelKe.Size = New Size(0, 27)
        LabelKe.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(206, 85)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(198, 32)
        TextBox1.TabIndex = 6
        TextBox1.TextAlign = HorizontalAlignment.Right
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(206, 165)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(198, 32)
        TextBox2.TabIndex = 7
        TextBox2.TextAlign = HorizontalAlignment.Right
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(206, 217)
        Button1.Name = "Button1"
        Button1.Size = New Size(89, 33)
        Button1.TabIndex = 8
        Button1.Text = "Clear"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Montserrat ExtraLight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.AppWorkspace
        Label5.Location = New Point(84, 120)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 43)
        Label5.TabIndex = 9
        Label5.Text = "🔃"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(315, 217)
        Button2.Name = "Button2"
        Button2.Size = New Size(89, 33)
        Button2.TabIndex = 10
        Button2.Text = "Convert"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(27, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(16, 24)
        Label3.TabIndex = 11
        Label3.Text = "-"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(26, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(16, 24)
        Label4.TabIndex = 12
        Label4.Text = "-"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        ClientSize = New Size(563, 283)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox2)
        Controls.Add(LabelKe)
        Controls.Add(ComboBox1)
        Controls.Add(LabelDari)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form7"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form7"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelDari As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents LabelKe As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
