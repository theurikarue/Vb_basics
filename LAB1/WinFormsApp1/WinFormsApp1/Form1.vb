Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        ' Create an instance of Form2
        Dim form2Instance As New Form2()
        form2Instance.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub


    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        ' Maximize the form and change background color to red when clicked
        WindowState = FormWindowState.Maximized
        BackColor = Color.Red
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Assign tooltips to buttons
        ToolTip1.SetToolTip(Button1, "Load Object Demonstrations")
        ToolTip2.SetToolTip(Button2, "Terminate Application")
    End Sub
End Class





