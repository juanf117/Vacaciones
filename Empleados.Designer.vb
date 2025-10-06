<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Empleados
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
        Me.gvEmpleados = New System.Windows.Forms.DataGridView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        CType(Me.gvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvEmpleados
        '
        Me.gvEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvEmpleados.Location = New System.Drawing.Point(0, 43)
        Me.gvEmpleados.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gvEmpleados.Name = "gvEmpleados"
        Me.gvEmpleados.RowHeadersWidth = 51
        Me.gvEmpleados.RowTemplate.Height = 24
        Me.gvEmpleados.Size = New System.Drawing.Size(600, 323)
        Me.gvEmpleados.TabIndex = 0
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(13, 13)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(192, 23)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar empleado"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.gvEmpleados)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Empleados"
        Me.Text = "Empleados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gvEmpleados As DataGridView
    Friend WithEvents btnAgregar As Button
End Class
