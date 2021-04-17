Public Class Form1
    Dim clicks As Double
    Dim s As Double
    Dim op As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        s = s + 1
        Label5.Text = s
        If s = 10 Then
            Timer1.Enabled = False
            Button6.Enabled = False
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button6.Enabled = True
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clicks = 0
        Label4.Text = ""
        s = 0
        Label4.Text = 0
        Label5.Text = 0
        Label5.Text = 0
        Button1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label6.Text = (clicks)
        op = "/"
        If op = "/" Then
            Label6.Text = clicks / s
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Timer1.Enabled = False
        Button6.Enabled = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        clicks = clicks + 1
        Label4.Text = clicks
    End Sub
End Class
