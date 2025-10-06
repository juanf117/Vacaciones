<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalcularVacaciones
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
        Me.components = New System.ComponentModel.Container()
        Me.dtFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.epError = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.epError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtFechaInicio
        '
        Me.dtFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicio.Location = New System.Drawing.Point(110, 6)
        Me.dtFechaInicio.Margin = New System.Windows.Forms.Padding(2)
        Me.dtFechaInicio.Name = "dtFechaInicio"
        Me.dtFechaInicio.Size = New System.Drawing.Size(180, 23)
        Me.dtFechaInicio.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 11)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Fecha Inicio:"
        '
        'dtFechaFin
        '
        Me.dtFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFin.Location = New System.Drawing.Point(110, 45)
        Me.dtFechaFin.Margin = New System.Windows.Forms.Padding(2)
        Me.dtFechaFin.Name = "dtFechaFin"
        Me.dtFechaFin.Size = New System.Drawing.Size(180, 23)
        Me.dtFechaFin.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Fecha Fin:"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(110, 78)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 27
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'epError
        '
        Me.epError.ContainerControl = Me
        '
        'CalcularVacaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 113)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.dtFechaFin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtFechaInicio)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CalcularVacaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calcular Vacaciones"
        CType(Me.epError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents dtFechaInicio As DateTimePicker
    Friend WithEvents Label5 As Label
    Public WithEvents dtFechaFin As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents epError As ErrorProvider
End Class
