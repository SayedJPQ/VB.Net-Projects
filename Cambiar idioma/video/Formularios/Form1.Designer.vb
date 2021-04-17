<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Idioma
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
        Me.Label1_selec_idioma = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.idioma_btnaceptar = New System.Windows.Forms.Button()
        Me.idioma_btnsalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1_selec_idioma
        '
        Me.Label1_selec_idioma.AutoSize = True
        Me.Label1_selec_idioma.Location = New System.Drawing.Point(28, 34)
        Me.Label1_selec_idioma.Name = "Label1_selec_idioma"
        Me.Label1_selec_idioma.Size = New System.Drawing.Size(96, 13)
        Me.Label1_selec_idioma.TabIndex = 0
        Me.Label1_selec_idioma.Text = "Seleccionar idioma"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Español", "English"})
        Me.ComboBox1.Location = New System.Drawing.Point(130, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'idioma_btnaceptar
        '
        Me.idioma_btnaceptar.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.idioma_btnaceptar.Location = New System.Drawing.Point(49, 90)
        Me.idioma_btnaceptar.Name = "idioma_btnaceptar"
        Me.idioma_btnaceptar.Size = New System.Drawing.Size(75, 23)
        Me.idioma_btnaceptar.TabIndex = 2
        Me.idioma_btnaceptar.Text = "Aceptar"
        Me.idioma_btnaceptar.UseVisualStyleBackColor = True
        '
        'idioma_btnsalir
        '
        Me.idioma_btnsalir.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.idioma_btnsalir.Location = New System.Drawing.Point(159, 90)
        Me.idioma_btnsalir.Name = "idioma_btnsalir"
        Me.idioma_btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.idioma_btnsalir.TabIndex = 3
        Me.idioma_btnsalir.Text = "Salir"
        Me.idioma_btnsalir.UseVisualStyleBackColor = True
        '
        'Idioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 139)
        Me.Controls.Add(Me.idioma_btnsalir)
        Me.Controls.Add(Me.idioma_btnaceptar)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1_selec_idioma)
        Me.Name = "Idioma"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1_selec_idioma As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents idioma_btnaceptar As System.Windows.Forms.Button
    Friend WithEvents idioma_btnsalir As System.Windows.Forms.Button

End Class
