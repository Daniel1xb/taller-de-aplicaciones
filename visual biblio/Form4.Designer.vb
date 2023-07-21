<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tablita = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.tablita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(38, 300)
        Me.DateTimePicker1.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(226, 27)
        Me.DateTimePicker1.TabIndex = 38
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1984, George Orwell", "Una arruga en el tiempo, Madeleine L’Engle", "A sangre fría, Truman Capote", "Hijos de la medianoche, Salman Rushdie", "El Principito, Antoine de Saint-Exupéry", "Cumbres borrascosas, Emily Brontë", "El corazón de las tinieblas, Joseph Conrad", "Lolita, Vladimir Nabokov", "Fortunata y Jacinta, Benito Pérez Galdós", "El extranjero, Alberto Camus", "La dama de blanco, Wilkie Collins", "Madame Bovary, Gustave Flaubert", "La metamorfosis, Franz Kafka", "Grandes esperanzas, Charles Dickens", "Fahrenheit 451, Ray Bradbury", "La historia interminable, Michael Ende", "El señor de las moscas, William Golding", "El Gran Gatsby, F. Scott Fitzgerald", "Las uvas de la ira, John Steinbeck", "Perdida, Gillian Flynn", "Nuestra señora de París, Victor Hugo", "El nombre de la rosa, Umberto Eco", "Las ciudades invisibles, Italo Calvino", "Rayuela, Julio Cortázar", "Crimen y castigo, Fiódor Dostoyevski"})
        Me.ComboBox1.Location = New System.Drawing.Point(38, 243)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(198, 21)
        Me.ComboBox1.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label5.Location = New System.Drawing.Point(39, 329)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(283, 31)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Fecha de devolución"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label10.Location = New System.Drawing.Point(39, 266)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(242, 31)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Fecha de entrega"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label9.Location = New System.Drawing.Point(32, 206)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 31)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Libro"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label8.Location = New System.Drawing.Point(32, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 31)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Rut"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label3.Location = New System.Drawing.Point(32, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 31)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Apellido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(57, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 20)
        Me.Label7.TabIndex = 40
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(38, 363)
        Me.DateTimePicker2.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker2.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(226, 27)
        Me.DateTimePicker2.TabIndex = 39
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(38, 183)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(198, 20)
        Me.TextBox3.TabIndex = 36
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(38, 130)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(198, 20)
        Me.TextBox2.TabIndex = 35
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(38, 69)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(198, 20)
        Me.TextBox1.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label2.Location = New System.Drawing.Point(32, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 31)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Nombre"
        '
        'tablita
        '
        Me.tablita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablita.Location = New System.Drawing.Point(375, 150)
        Me.tablita.Name = "tablita"
        Me.tablita.Size = New System.Drawing.Size(657, 321)
        Me.tablita.TabIndex = 46
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.visual_biblio.My.Resources.Resources._580b585b2edbce24c47b276b
        Me.PictureBox1.Location = New System.Drawing.Point(532, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ravie", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label1.ImageKey = "(ninguno)"
        Me.Label1.Location = New System.Drawing.Point(370, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 30)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Biblioteca"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Teal
        Me.Button4.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Image = Global.visual_biblio.My.Resources.Resources.boton_entrar_png_4
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button4.Location = New System.Drawing.Point(551, 502)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 43)
        Me.Button4.TabIndex = 51
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Image = Global.visual_biblio.My.Resources.Resources.boton_entrar_png_4
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(726, 502)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 43)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Leer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Teal
        Me.Button3.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Image = Global.visual_biblio.My.Resources.Resources.boton_entrar_png_4
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button3.Location = New System.Drawing.Point(902, 502)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 43)
        Me.Button3.TabIndex = 49
        Me.Button3.Text = "Ingresar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Image = Global.visual_biblio.My.Resources.Resources.boton_entrar_png_4
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(901, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 43)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "Admin"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button5.Image = Global.visual_biblio.My.Resources.Resources.boton_entrar_png_4
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button5.Location = New System.Drawing.Point(998, 32)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(34, 35)
        Me.Button5.TabIndex = 53
        Me.Button5.Text = "X"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.visual_biblio.My.Resources.Resources._81d
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1108, 548)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tablita)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.tablita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tablita As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
End Class
