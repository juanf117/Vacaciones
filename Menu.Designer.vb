<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescansadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeVacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(530, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroToolStripMenuItem, Me.VacacionesToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        Me.RegistroToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RegistroToolStripMenuItem.Text = "Registro"
        '
        'VacacionesToolStripMenuItem
        '
        Me.VacacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DescansadasToolStripMenuItem, Me.ControlDeVacacionesToolStripMenuItem})
        Me.VacacionesToolStripMenuItem.Name = "VacacionesToolStripMenuItem"
        Me.VacacionesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VacacionesToolStripMenuItem.Text = "Vacaciones"
        '
        'DescansadasToolStripMenuItem
        '
        Me.DescansadasToolStripMenuItem.Name = "DescansadasToolStripMenuItem"
        Me.DescansadasToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.DescansadasToolStripMenuItem.Text = "Descansadas"
        '
        'ControlDeVacacionesToolStripMenuItem
        '
        Me.ControlDeVacacionesToolStripMenuItem.Name = "ControlDeVacacionesToolStripMenuItem"
        Me.ControlDeVacacionesToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ControlDeVacacionesToolStripMenuItem.Text = "Control de Vacaciones"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 383)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Menu"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VacacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescansadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlDeVacacionesToolStripMenuItem As ToolStripMenuItem
End Class
