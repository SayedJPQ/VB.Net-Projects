Public Class Idioma

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim valor = Me.ComboBox1.Text
        '' MessageBox.Show(valor)
        If (valor = "Español") Then
            System.Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("Es")
            idioma_es()
        Else
            System.Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("En")
            idioma_en()
        End If
    End Sub
    Private Function idioma_en()
        Label1_selec_idioma.Text = video.My.Resources.Ingles.Label1_selec_idioma
        idioma_btnaceptar.Text = video.My.Resources.Ingles.idioma_btnaceptar
        idioma_btnsalir.Text = video.My.Resources.Ingles.idioma_btnsalir
        ''Formulario 2
        Ingresar.Label1_usuario.Text = video.My.Resources.Ingles.Label1_usuario
        Ingresar.Label2_contraseña.Text = video.My.Resources.Ingles.Label2_contraseña
        Ingresar.btn_aceptar.Text = video.My.Resources.Ingles.btn_aceptar
        Ingresar.Btn_salir.Text = video.My.Resources.Ingles.Btn_salir
        Ingresar.Btn_Idioma.Text = video.My.Resources.Ingles.Btn_Idioma
        Ingresar.groupb_ingresar.Text = video.My.Resources.Ingles.groupb_ingresar

    End Function
    Private Function idioma_es()
        Label1_selec_idioma.Text = video.My.Resources.Español.Label1_selec_idioma
        idioma_btnaceptar.Text = video.My.Resources.Español.idioma_btnaceptar
        idioma_btnsalir.Text = video.My.Resources.Español.idioma_btnsalir
        ''Formulario Ingresar
        Ingresar.Label1_usuario.Text = video.My.Resources.Español.Label1_usuario
        Ingresar.Label2_contraseña.Text = video.My.Resources.Español.Label2_contraseña
        Ingresar.btn_aceptar.Text = video.My.Resources.Español.btn_aceptar
        Ingresar.Btn_salir.Text = video.My.Resources.Español.Btn_salir
        Ingresar.Btn_Idioma.Text = video.My.Resources.Español.Btn_Idioma
        Ingresar.groupb_ingresar.Text = video.My.Resources.Español.groupb_ingresar
    End Function

    Private Sub idioma_btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idioma_btnsalir.Click
        Me.Close()
    End Sub

    Private Sub idioma_btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idioma_btnaceptar.Click
        Me.Hide()
        Ingresar.Show()
    End Sub
End Class
