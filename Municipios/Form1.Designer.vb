<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Destino = New System.Windows.Forms.ComboBox()
        Me.Origen = New System.Windows.Forms.ComboBox()
        Me.distancia = New System.Windows.Forms.RadioButton()
        Me.tiempo = New System.Windows.Forms.RadioButton()
        Me.Invertir = New System.Windows.Forms.LinkLabel()
        Me.Ruta = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Resultado = New System.Windows.Forms.TextBox()
        Me.distancia2 = New System.Windows.Forms.RadioButton()
        Me.tiempo2 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(395, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Ruta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Destino)
        Me.GroupBox1.Controls.Add(Me.Origen)
        Me.GroupBox1.Controls.Add(Me.distancia)
        Me.GroupBox1.Controls.Add(Me.tiempo)
        Me.GroupBox1.Controls.Add(Me.Invertir)
        Me.GroupBox1.Controls.Add(Me.Ruta)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 176)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "¿Cómo llegar?  (Dijkstra)"
        '
        'Destino
        '
        Me.Destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Destino.FormattingEnabled = True
        Me.Destino.Items.AddRange(New Object() {"Armeria", "Colima", "Comala", "Coquimatlan", "Cuauhtemoc", "Ixtlahuacan", "Manzanillo", "Minatitlan", "Tecoman", "Villa de Alvarez"})
        Me.Destino.Location = New System.Drawing.Point(68, 70)
        Me.Destino.Name = "Destino"
        Me.Destino.Size = New System.Drawing.Size(402, 24)
        Me.Destino.TabIndex = 1
        '
        'Origen
        '
        Me.Origen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Origen.FormattingEnabled = True
        Me.Origen.Items.AddRange(New Object() {"Armeria", "Colima", "Comala", "Coquimatlan", "Cuauhtemoc", "Ixtlahuacan", "Manzanillo", "Minatitlan", "Tecoman", "Villa de Alvarez"})
        Me.Origen.Location = New System.Drawing.Point(68, 35)
        Me.Origen.Name = "Origen"
        Me.Origen.Size = New System.Drawing.Size(402, 24)
        Me.Origen.TabIndex = 0
        '
        'distancia
        '
        Me.distancia.AutoSize = True
        Me.distancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.distancia.Location = New System.Drawing.Point(250, 99)
        Me.distancia.Name = "distancia"
        Me.distancia.Size = New System.Drawing.Size(111, 20)
        Me.distancia.TabIndex = 5
        Me.distancia.Text = "Distancia (km)"
        Me.distancia.UseVisualStyleBackColor = True
        '
        'tiempo
        '
        Me.tiempo.AutoSize = True
        Me.tiempo.Checked = True
        Me.tiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tiempo.Location = New System.Drawing.Point(127, 99)
        Me.tiempo.Name = "tiempo"
        Me.tiempo.Size = New System.Drawing.Size(105, 20)
        Me.tiempo.TabIndex = 4
        Me.tiempo.TabStop = True
        Me.tiempo.Text = "Tiempo (min)"
        Me.tiempo.UseVisualStyleBackColor = True
        '
        'Invertir
        '
        Me.Invertir.AutoSize = True
        Me.Invertir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invertir.Location = New System.Drawing.Point(65, 95)
        Me.Invertir.Name = "Invertir"
        Me.Invertir.Size = New System.Drawing.Size(39, 13)
        Me.Invertir.TabIndex = 3
        Me.Invertir.TabStop = True
        Me.Invertir.Text = "Invertir"
        '
        'Ruta
        '
        Me.Ruta.AutoSize = True
        Me.Ruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ruta.Location = New System.Drawing.Point(5, 136)
        Me.Ruta.Name = "Ruta"
        Me.Ruta.Size = New System.Drawing.Size(0, 16)
        Me.Ruta.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Destino"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Origen"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(244, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Generar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Resultado)
        Me.GroupBox2.Controls.Add(Me.distancia2)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.tiempo2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 199)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 277)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Obtener el Árbol (Kruskal)"
        '
        'Resultado
        '
        Me.Resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resultado.Location = New System.Drawing.Point(11, 85)
        Me.Resultado.Multiline = True
        Me.Resultado.Name = "Resultado"
        Me.Resultado.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Resultado.Size = New System.Drawing.Size(459, 180)
        Me.Resultado.TabIndex = 6
        '
        'distancia2
        '
        Me.distancia2.AutoSize = True
        Me.distancia2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.distancia2.Location = New System.Drawing.Point(127, 54)
        Me.distancia2.Name = "distancia2"
        Me.distancia2.Size = New System.Drawing.Size(111, 20)
        Me.distancia2.TabIndex = 5
        Me.distancia2.Text = "Distancia (km)"
        Me.distancia2.UseVisualStyleBackColor = True
        '
        'tiempo2
        '
        Me.tiempo2.AutoSize = True
        Me.tiempo2.Checked = True
        Me.tiempo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tiempo2.Location = New System.Drawing.Point(11, 54)
        Me.tiempo2.Name = "tiempo2"
        Me.tiempo2.Size = New System.Drawing.Size(105, 20)
        Me.tiempo2.TabIndex = 4
        Me.tiempo2.TabStop = True
        Me.tiempo2.Text = "Tiempo (min)"
        Me.tiempo2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Obtener el árbol por medio de: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 488)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Kruskal y Dijkstra"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ruta As System.Windows.Forms.Label
    Friend WithEvents Invertir As System.Windows.Forms.LinkLabel
    Friend WithEvents distancia As System.Windows.Forms.RadioButton
    Friend WithEvents tiempo As System.Windows.Forms.RadioButton
    Friend WithEvents Destino As System.Windows.Forms.ComboBox
    Friend WithEvents Origen As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents distancia2 As System.Windows.Forms.RadioButton
    Friend WithEvents tiempo2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Resultado As System.Windows.Forms.TextBox

End Class
