Imports SpeechLib
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim speech As New SpVoice()
        MsgBox("You have " & speech.GetVoices.Count & " voices installed")
    End Sub
End Class
