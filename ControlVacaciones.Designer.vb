<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlVacaciones
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gvVacaciones = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGanadas = New System.Windows.Forms.TextBox()
        Me.txtDescansadas = New System.Windows.Forms.TextBox()
        Me.txtDisponibles = New System.Windows.Forms.TextBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gvVacaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.Controls.Add(Me.btnCalcular)
        Me.GroupBox1.Controls.Add(Me.dtFecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbxEmpleado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 143)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(147, 101)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 24
        Me.btnCalcular.Text = "Calcular Vacaciones"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'dtFecha
        '
        Me.dtFecha.Enabled = False
        Me.dtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(136, 56)
        Me.dtFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(180, 23)
        Me.dtFecha.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha de Ingreso:"
        '
        'cbxEmpleado
        '
        Me.cbxEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxEmpleado.FormattingEnabled = True
        Me.cbxEmpleado.Location = New System.Drawing.Point(95, 23)
        Me.cbxEmpleado.Name = "cbxEmpleado"
        Me.cbxEmpleado.Size = New System.Drawing.Size(422, 24)
        Me.cbxEmpleado.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empleado:"
        '
        'gvVacaciones
        '
        Me.gvVacaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvVacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvVacaciones.Location = New System.Drawing.Point(12, 161)
        Me.gvVacaciones.Name = "gvVacaciones"
        Me.gvVacaciones.Size = New System.Drawing.Size(747, 248)
        Me.gvVacaciones.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(233, 425)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Vacaciones Descansadas:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 425)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Vacaciones Ganadas:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(524, 425)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Vacaciones Disponibles:"
        '
        'txtGanadas
        '
        Me.txtGanadas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtGanadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGanadas.Location = New System.Drawing.Point(159, 422)
        Me.txtGanadas.Name = "txtGanadas"
        Me.txtGanadas.ReadOnly = True
        Me.txtGanadas.Size = New System.Drawing.Size(66, 22)
        Me.txtGanadas.TabIndex = 30
        '
        'txtDescansadas
        '
        Me.txtDescansadas.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtDescansadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescansadas.Location = New System.Drawing.Point(409, 422)
        Me.txtDescansadas.Name = "txtDescansadas"
        Me.txtDescansadas.ReadOnly = True
        Me.txtDescansadas.Size = New System.Drawing.Size(66, 22)
        Me.txtDescansadas.TabIndex = 31
        '
        'txtDisponibles
        '
        Me.txtDisponibles.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDisponibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisponibles.Location = New System.Drawing.Point(687, 422)
        Me.txtDisponibles.Name = "txtDisponibles"
        Me.txtDisponibles.ReadOnly = True
        Me.txtDisponibles.Size = New System.Drawing.Size(66, 22)
        Me.txtDisponibles.TabIndex = 32
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(293, 101)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 25
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'ControlVacaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 450)
        Me.Controls.Add(Me.txtDisponibles)
        Me.Controls.Add(Me.txtDescansadas)
        Me.Controls.Add(Me.txtGanadas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gvVacaciones)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ControlVacaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Vacaciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.gvVacaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbxEmpleado As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtFecha As DateTimePicker
    Friend WithEvents btnCalcular As Button
    Friend WithEvents gvVacaciones As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGanadas As TextBox
    Friend WithEvents txtDescansadas As TextBox
    Friend WithEvents txtDisponibles As TextBox
    Friend WithEvents btnImprimir As Button
End Class
