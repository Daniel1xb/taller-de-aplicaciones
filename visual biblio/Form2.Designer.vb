<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.tablita = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Libro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.agregar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablita, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(29, 411)
        Me.DateTimePicker2.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker2.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(226, 27)
        Me.DateTimePicker2.TabIndex = 20
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(29, 231)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(198, 20)
        Me.TextBox3.TabIndex = 17
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(29, 178)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(198, 20)
        Me.TextBox2.TabIndex = 16
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(29, 117)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(198, 20)
        Me.TextBox1.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label2.Location = New System.Drawing.Point(23, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 31)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.visual_biblio.My.Resources.Resources._580b585b2edbce24c47b276b
        Me.PictureBox1.Location = New System.Drawing.Point(466, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
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
        Me.Label1.Location = New System.Drawing.Point(304, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 30)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Biblioteca"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Image = Global.visual_biblio.My.Resources.Resources.boton_entrar_png_4
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(1054, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 35)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(48, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 20)
        Me.Label7.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label3.Location = New System.Drawing.Point(23, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 31)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Apellido"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label8.Location = New System.Drawing.Point(23, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 31)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Rut"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label9.Location = New System.Drawing.Point(23, 254)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 31)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Libro"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label10.Location = New System.Drawing.Point(30, 314)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(242, 31)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Fecha de entrega"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label5.Location = New System.Drawing.Point(30, 377)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(283, 31)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Fecha de devolución"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1984, George Orwell", "Una arruga en el tiempo, Madeleine L’Engle", "A sangre fría, Truman Capote", "Hijos de la medianoche, Salman Rushdie", "El Principito, Antoine de Saint-Exupéry", "Cumbres borrascosas, Emily Brontë", "El corazón de las tinieblas, Joseph Conrad", "Lolita, Vladimir Nabokov", "Fortunata y Jacinta, Benito Pérez Galdós", "El extranjero, Alberto Camus", "La dama de blanco, Wilkie Collins", "Madame Bovary, Gustave Flaubert", "La metamorfosis, Franz Kafka", "Grandes esperanzas, Charles Dickens", "Fahrenheit 451, Ray Bradbury", "La historia interminable, Michael Ende", "El señor de las moscas, William Golding", "El Gran Gatsby, F. Scott Fitzgerald", "Las uvas de la ira, John Steinbeck", "Perdida, Gillian Flynn", "Nuestra señora de París, Victor Hugo", "El nombre de la rosa, Umberto Eco", "Las ciudades invisibles, Italo Calvino", "Rayuela, Julio Cortázar", "Crimen y castigo, Fiódor Dostoyevski"})
        Me.ComboBox1.Location = New System.Drawing.Point(29, 291)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(198, 21)
        Me.ComboBox1.TabIndex = 18
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Teal
        Me.Button3.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Image = Global.visual_biblio.My.Resources.Resources.boton_entrar_png_4
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button3.Location = New System.Drawing.Point(971, 475)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 43)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Ingresar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(29, 348)
        Me.DateTimePicker1.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(226, 27)
        Me.DateTimePicker1.TabIndex = 19
        '
        'tablita
        '
        Me.tablita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablita.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Apellido, Me.Rut, Me.Libro, Me.Fecha1, Me.Fecha2})
        Me.tablita.Location = New System.Drawing.Point(319, 117)
        Me.tablita.Name = "tablita"
        Me.tablita.Size = New System.Drawing.Size(769, 321)
        Me.tablita.TabIndex = 37
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        '
        'Rut
        '
        Me.Rut.HeaderText = "Rut"
        Me.Rut.Name = "Rut"
        '
        'Libro
        '
        Me.Libro.HeaderText = "Libro"
        Me.Libro.Name = "Libro"
        Me.Libro.Width = 140
        '
        'Fecha1
        '
        Me.Fecha1.HeaderText = "Fecha de entrega"
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.Width = 143
        '
        'Fecha2
        '
        Me.Fecha2.HeaderText = "Fecha de devolución"
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.Width = 143
        '
        'agregar
        '
        Me.agregar.BackColor = System.Drawing.Color.Teal
        Me.agregar.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.agregar.Image = Global.visual_biblio.My.Resources.Resources.boton_entrar_png_4
        Me.agregar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.agregar.Location = New System.Drawing.Point(781, 475)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(131, 43)
        Me.agregar.TabIndex = 38
        Me.agregar.Text = "Agregar"
        Me.agregar.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.visual_biblio.My.Resources.Resources._81d
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1114, 530)
        Me.Controls.Add(Me.agregar)
        Me.Controls.Add(Me.tablita)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablita, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents tablita As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Rut As DataGridViewTextBoxColumn
    Friend WithEvents Libro As DataGridViewTextBoxColumn
    Friend WithEvents Fecha1 As DataGridViewTextBoxColumn
    Friend WithEvents Fecha2 As DataGridViewTextBoxColumn
    Friend WithEvents agregar As Button
End Class
