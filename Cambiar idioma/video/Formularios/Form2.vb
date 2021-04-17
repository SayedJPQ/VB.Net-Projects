Public Class Ingresar

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1_usuario.Click

    End Sub

    Private Sub Btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_salir.Click
        Me.Close()
    End Sub

    Private Sub Btn_Idioma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Idioma.Click
        Me.Hide()
        Idioma.Show()
    End Sub
End Class