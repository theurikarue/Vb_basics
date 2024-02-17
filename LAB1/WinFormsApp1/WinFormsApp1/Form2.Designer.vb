<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Button1 = New Button()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        TextBox1 = New TextBox()
        GroupBox2 = New GroupBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        GroupBox3 = New GroupBox()
        RadioButton9 = New RadioButton()
        RadioButton8 = New RadioButton()
        RadioButton7 = New RadioButton()
        GroupBox4 = New GroupBox()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(94, 393)
        Button1.Name = "Button1"
        Button1.Size = New Size(109, 29)
        Button1.TabIndex = 0
        Button1.Text = "Load Picture"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(813, 403)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 1
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.HighlightText
        PictureBox1.Image = My.Resources.Resources.IMG_20240206_WA0048
        PictureBox1.Location = New Point(61, 182)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(232, 133)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.Control
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(61, 56)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(232, 61)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        GroupBox1.Text = "Display Test"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(33, 26)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(166, 27)
        TextBox1.TabIndex = 0
        TextBox1.Text = " Sample text"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.Control
        GroupBox2.Controls.Add(CheckBox6)
        GroupBox2.Controls.Add(CheckBox5)
        GroupBox2.Controls.Add(CheckBox4)
        GroupBox2.Location = New Point(421, 184)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(160, 174)
        GroupBox2.TabIndex = 22
        GroupBox2.TabStop = False
        GroupBox2.Text = "Display Test"
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(15, 124)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(102, 24)
        CheckBox6.TabIndex = 16
        CheckBox6.Text = "Bold Italic "
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(15, 83)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(62, 24)
        CheckBox5.TabIndex = 15
        CheckBox5.Text = "Bold"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.BackColor = SystemColors.Control
        CheckBox4.Location = New Point(15, 35)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(63, 24)
        CheckBox4.TabIndex = 14
        CheckBox4.Text = "Italic"
        CheckBox4.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = SystemColors.Control
        GroupBox3.Controls.Add(RadioButton9)
        GroupBox3.Controls.Add(RadioButton8)
        GroupBox3.Controls.Add(RadioButton7)
        GroupBox3.Location = New Point(746, 184)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(161, 174)
        GroupBox3.TabIndex = 23
        GroupBox3.TabStop = False
        GroupBox3.Text = "Font Color "
        ' 
        ' RadioButton9
        ' 
        RadioButton9.AutoSize = True
        RadioButton9.Location = New Point(19, 124)
        RadioButton9.Name = "RadioButton9"
        RadioButton9.Size = New Size(56, 24)
        RadioButton9.TabIndex = 2
        RadioButton9.TabStop = True
        RadioButton9.Text = "Red"
        RadioButton9.UseVisualStyleBackColor = True
        ' 
        ' RadioButton8
        ' 
        RadioButton8.AutoSize = True
        RadioButton8.Location = New Point(19, 83)
        RadioButton8.Name = "RadioButton8"
        RadioButton8.Size = New Size(59, 24)
        RadioButton8.TabIndex = 1
        RadioButton8.TabStop = True
        RadioButton8.Text = "Blue"
        RadioButton8.UseVisualStyleBackColor = True
        ' 
        ' RadioButton7
        ' 
        RadioButton7.AutoSize = True
        RadioButton7.Location = New Point(19, 34)
        RadioButton7.Name = "RadioButton7"
        RadioButton7.Size = New Size(69, 24)
        RadioButton7.TabIndex = 0
        RadioButton7.TabStop = True
        RadioButton7.Text = "Green"
        RadioButton7.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = SystemColors.Control
        GroupBox4.Controls.Add(RadioButton3)
        GroupBox4.Controls.Add(RadioButton2)
        GroupBox4.Controls.Add(RadioButton1)
        GroupBox4.Location = New Point(369, 44)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(538, 89)
        GroupBox4.TabIndex = 24
        GroupBox4.TabStop = False
        GroupBox4.Text = "GroupBox4"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(389, 38)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(82, 24)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Tahoma"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(230, 38)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(90, 24)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Magneto"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(52, 38)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(108, 24)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Garamound"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1029, 483)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form2"
        Text = "Object Demonstrations"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog1 As New OpenFileDialog()

        ' Set the file filter to only allow image files
        openFileDialog1.Filter = "Image Files(.BMP;.JPG;.GIF;.PNG)|.BMP;.JPG;.GIF;.PNG|All files (.)|."
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                ' Get the filename of the selected file
                Dim selectedFileName As String = openFileDialog1.FileName

                ' Display the selected image in the PictureBox control
                PictureBox1.Image = Image.FromFile(selectedFileName)
            Catch ex As Exception
                ' Error handling if loading the image fails
                MessageBox.Show("Error loading image: " & ex.Message)

            End Try
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Dim welcomeForm As New Form1
        welcomeForm.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Font = New Font("Garamond", TextBox1.Font.Size, TextBox1.Font.Style)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Font = New Font("Magneto", TextBox1.Font.Size, TextBox1.Font.Style)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TextBox1.Font = New Font("Tahoma", TextBox1.Font.Size, TextBox1.Font.Style)
    End Sub

    Friend WithEvents RadioButton1 As RadioButton

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Italic)
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Bold)
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        Dim fontStyle As FontStyle = FontStyle.Bold Or FontStyle.Italic
        TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, fontStyle)
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        TextBox1.ForeColor = Color.Green
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        TextBox1.ForeColor = Color.Blue
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        TextBox1.ForeColor = Color.Red
    End Sub
End Class
