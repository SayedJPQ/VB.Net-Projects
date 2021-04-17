Public Class Form1
    Dim num1 As Double
    Dim num2 As Double
    Dim op As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & 1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & 5
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & 3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & 4
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & 6
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & 7
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & 8
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & 9
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & 0
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Try
            If (num1 = 0) Then
                MsgBox("No se realizo la operacion", 0, "Debes colocar un numero valido")
            Else
                num2 = TextBox1.Text
                If op = "+" Then
                    TextBox1.Text = num1 + num2
                End If
                If op = "-" Then
                    TextBox1.Text = num1 - num2
                End If
                If op = "*" Then
                    TextBox1.Text = num1 * num2
                End If
                If op = "/" Then
                    TextBox1.Text = num1 / num2
                End If
            End If
        Catch ex As System.InvalidCastException
            MsgBox("Por favor solo coloque un punto", 0, "Atencion")
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            num1 = TextBox1.Text
            TextBox1.Text = ""
            op = "+"
            TextBox1.Focus()
        Catch ex As System.InvalidCastException
            MsgBox("Por favor coloque solo un punto", 0, "Atencion")
        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            num1 = TextBox1.Text
            TextBox1.Text = ""
            op = "-"
            TextBox1.Focus()
        Catch ex As System.InvalidCastException
            MsgBox("Por favor coloque solo un punto", 0, "Atencion")
        End Try
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Try
            num1 = TextBox1.Text
            TextBox1.Text = ""
            op = "*"
            TextBox1.Focus()
        Catch ex As System.InvalidCastException
            MsgBox("Por favor coloque solo un punto", 0, "Atencion")
        End Try
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Try
            num1 = TextBox1.Text
            TextBox1.Text = ""
            op = "/"
            TextBox1.Focus()
        Catch ex As System.InvalidCastException
            MsgBox("Por favor coloque solo un punto", 0, "Atencion")
        End Try
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text = TextBox1.Text & "."
    End Sub
End Class
