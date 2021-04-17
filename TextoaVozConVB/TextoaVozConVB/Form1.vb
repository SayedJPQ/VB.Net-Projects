Imports SpeechLib
Imports System.Threading

Public Class Form1
    Dim speech As SpVoice = New SpVoice()
    Dim speechRate As Integer = 0 ' Rango desde -10 hasta 10 
    Dim volume As Integer = 80 ' Rango desde 0 hasta 100.
    Dim paused As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each Token As ISpeechObjectToken In speech.GetVoices(String.Empty, String.Empty)
            ComboBox1.Items.Add(Token.GetDescription(49))

            ComboBox1.SelectedIndex = 0
            TrackBarVelocidad.Value = speechRate
            TrackBarVolumen.Value = volume
        Next
    End Sub

    Private Sub btnHablar_Click(sender As Object, e As EventArgs) Handles btnHablar.Click
        If (paused) = True Then
            speech.Resume()
            paused = False

        Else

            speech.Rate = speechRate
            speech.Volume = volume
            speech.Speak(TextBox1.Text, SpeechVoiceSpeakFlags.SVSFlagsAsync)
        End If
    End Sub

    Private Sub btnPausar_Click(sender As Object, e As EventArgs) Handles btnPausar.Click
        speech.Pause()
        paused = True
    End Sub

    Private Sub btnWAV_Click(sender As Object, e As EventArgs) Handles btnWAV.Click
        Dim sfd As SaveFileDialog = New SaveFileDialog()
        sfd.Filter = "All files (*.*)|*.*|wav files (*.wav)|*.wav"
        sfd.Title = "Save to a wave file"
        sfd.FilterIndex = 2
        sfd.RestoreDirectory = True
        If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim SpFileMode As SpeechStreamFileMode = SpeechStreamFileMode.SSFMCreateForWrite
            Dim SpFileStream As SpFileStream = New SpFileStream()
            SpFileStream.Open(sfd.FileName, SpFileMode, False)
            speech.AudioOutputStream = SpFileStream
            speech.Rate = speechRate
            speech.Volume = volume
            speech.Speak(TextBox1.Text, SpeechVoiceSpeakFlags.SVSFlagsAsync)
            speech.WaitUntilDone(Timeout.Infinite)
            SpFileStream.Close()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        speech.Voice = speech.GetVoices(String.Empty, String.Empty).Item(ComboBox1.SelectedIndex)
    End Sub

    Private Sub TrackBarVelocidad_Scroll(sender As Object, e As EventArgs) Handles TrackBarVelocidad.Scroll
        speechRate = TrackBarVelocidad.Value
    End Sub

    Private Sub TrackBarVolumen_Scroll(sender As Object, e As EventArgs) Handles TrackBarVolumen.Scroll
        volume = TrackBarVolumen.Value
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
