Public Class Form1
    Dim hoy As String = Now.Date.ToString("dd/MM/yyyy")
    Dim fechanac As Integer
    Dim fechahoy As Integer
    Dim edad As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsDate(TextBox1.Text.Trim) Then
            MsgBox("Por favor ingrese fecha valida")
        Else
            If CDate(TextBox1.Text.Trim) > CDate(hoy) Then
                MsgBox("Las fecha no puede ser mayor a la de hoy")
            Else
                fechanac = CDate(TextBox1.Text.Trim).Date.Year
                fechahoy = CDate(hoy).Date.Year
                edad = fechahoy - fechanac
                TextBox2.Text = edad
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
