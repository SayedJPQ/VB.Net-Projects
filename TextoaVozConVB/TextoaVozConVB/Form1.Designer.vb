<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TrackBarVelocidad = New System.Windows.Forms.TrackBar()
        Me.TrackBarVolumen = New System.Windows.Forms.TrackBar()
        Me.btnWAV = New System.Windows.Forms.Button()
        Me.btnHablar = New System.Windows.Forms.Button()
        Me.btnPausar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.TrackBarVelocidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarVolumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(587, 69)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lector de texto"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(114, 88)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(256, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Seleccionar voz"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(508, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 18)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Volumen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 380)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 18)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Velocidad del habla"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 115)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(492, 189)
        Me.TextBox1.TabIndex = 19
        '
        'TrackBarVelocidad
        '
        Me.TrackBarVelocidad.Location = New System.Drawing.Point(10, 342)
        Me.TrackBarVelocidad.Minimum = -10
        Me.TrackBarVelocidad.Name = "TrackBarVelocidad"
        Me.TrackBarVelocidad.Size = New System.Drawing.Size(237, 45)
        Me.TrackBarVelocidad.TabIndex = 18
        '
        'TrackBarVolumen
        '
        Me.TrackBarVolumen.Location = New System.Drawing.Point(524, 115)
        Me.TrackBarVolumen.Maximum = 100
        Me.TrackBarVolumen.Name = "TrackBarVolumen"
        Me.TrackBarVolumen.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBarVolumen.Size = New System.Drawing.Size(45, 189)
        Me.TrackBarVolumen.TabIndex = 17
        Me.TrackBarVolumen.TickFrequency = 5
        Me.TrackBarVolumen.Value = 80
        '
        'btnWAV
        '
        Me.btnWAV.Location = New System.Drawing.Point(14, 313)
        Me.btnWAV.Name = "btnWAV"
        Me.btnWAV.Size = New System.Drawing.Size(75, 23)
        Me.btnWAV.TabIndex = 24
        Me.btnWAV.Text = "Crear audio"
        Me.btnWAV.UseVisualStyleBackColor = True
        '
        'btnHablar
        '
        Me.btnHablar.Location = New System.Drawing.Point(95, 313)
        Me.btnHablar.Name = "btnHablar"
        Me.btnHablar.Size = New System.Drawing.Size(75, 23)
        Me.btnHablar.TabIndex = 23
        Me.btnHablar.Text = "Hablar"
        Me.btnHablar.UseVisualStyleBackColor = True
        '
        'btnPausar
        '
        Me.btnPausar.Location = New System.Drawing.Point(176, 313)
        Me.btnPausar.Name = "btnPausar"
        Me.btnPausar.Size = New System.Drawing.Size(75, 23)
        Me.btnPausar.TabIndex = 22
        Me.btnPausar.Text = "Pausar"
        Me.btnPausar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 418)
        Me.Controls.Add(Me.btnWAV)
        Me.Controls.Add(Me.btnHablar)
        Me.Controls.Add(Me.btnPausar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TrackBarVelocidad)
        Me.Controls.Add(Me.TrackBarVolumen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TrackBarVelocidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarVolumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TrackBarVelocidad As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBarVolumen As System.Windows.Forms.TrackBar
    Private WithEvents btnWAV As System.Windows.Forms.Button
    Private WithEvents btnHablar As System.Windows.Forms.Button
    Private WithEvents btnPausar As System.Windows.Forms.Button

End Class
