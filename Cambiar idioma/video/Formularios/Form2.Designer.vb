<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingresar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.Btn_salir = New System.Windows.Forms.Button()
        Me.Btn_Idioma = New System.Windows.Forms.Button()
        Me.Label1_usuario = New System.Windows.Forms.Label()
        Me.Label2_contraseña = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.groupb_ingresar = New System.Windows.Forms.GroupBox()
        Me.groupb_ingresar.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_aceptar
        '
        Me.btn_aceptar.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_aceptar.Location = New System.Drawing.Point(27, 170)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 0
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'Btn_salir
        '
        Me.Btn_salir.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btn_salir.Location = New System.Drawing.Point(189, 170)
        Me.Btn_salir.Name = "Btn_salir"
        Me.Btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.Btn_salir.TabIndex = 1
        Me.Btn_salir.Text = "Salir"
        Me.Btn_salir.UseVisualStyleBackColor = True
        '
        'Btn_Idioma
        '
        Me.Btn_Idioma.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btn_Idioma.Location = New System.Drawing.Point(108, 170)
        Me.Btn_Idioma.Name = "Btn_Idioma"
        Me.Btn_Idioma.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Idioma.TabIndex = 2
        Me.Btn_Idioma.Text = "Idioma"
        Me.Btn_Idioma.UseVisualStyleBackColor = True
        '
        'Label1_usuario
        '
        Me.Label1_usuario.AutoSize = True
        Me.Label1_usuario.Location = New System.Drawing.Point(18, 23)
        Me.Label1_usuario.Name = "Label1_usuario"
        Me.Label1_usuario.Size = New System.Drawing.Size(43, 13)
        Me.Label1_usuario.TabIndex = 3
        Me.Label1_usuario.Text = "Usuario"
        '
        'Label2_contraseña
        '
        Me.Label2_contraseña.AutoSize = True
        Me.Label2_contraseña.Location = New System.Drawing.Point(18, 90)
        Me.Label2_contraseña.Name = "Label2_contraseña"
        Me.Label2_contraseña.Size = New System.Drawing.Size(61, 13)
        Me.Label2_contraseña.TabIndex = 4
        Me.Label2_contraseña.Text = "Contraseña"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(21, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(116, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(21, 121)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(116, 20)
        Me.TextBox2.TabIndex = 6
        '
        'groupb_ingresar
        '
        Me.groupb_ingresar.Controls.Add(Me.TextBox2)
        Me.groupb_ingresar.Controls.Add(Me.TextBox1)
        Me.groupb_ingresar.Controls.Add(Me.Label2_contraseña)
        Me.groupb_ingresar.Controls.Add(Me.Label1_usuario)
        Me.groupb_ingresar.Controls.Add(Me.Btn_Idioma)
        Me.groupb_ingresar.Controls.Add(Me.Btn_salir)
        Me.groupb_ingresar.Controls.Add(Me.btn_aceptar)
        Me.groupb_ingresar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.groupb_ingresar.Location = New System.Drawing.Point(12, 14)
        Me.groupb_ingresar.Name = "groupb_ingresar"
        Me.groupb_ingresar.Size = New System.Drawing.Size(293, 215)
        Me.groupb_ingresar.TabIndex = 7
        Me.groupb_ingresar.TabStop = False
        Me.groupb_ingresar.Text = "Ingresar"
        '
        'Ingresar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 244)
        Me.Controls.Add(Me.groupb_ingresar)
        Me.Name = "Ingresar"
        Me.Text = "Form2"
        Me.groupb_ingresar.ResumeLayout(False)
        Me.groupb_ingresar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents Btn_salir As System.Windows.Forms.Button
    Friend WithEvents Btn_Idioma As System.Windows.Forms.Button
    Friend WithEvents Label1_usuario As System.Windows.Forms.Label
    Friend WithEvents Label2_contraseña As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents groupb_ingresar As System.Windows.Forms.GroupBox
End Class
