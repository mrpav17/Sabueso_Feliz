<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PantallaPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodosLosEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnimalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarMascotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarMascotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaboratoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarLaboratorioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarLaboratorioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarMedicamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarMedicamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarMedicamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucursalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarSucursalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarSucursalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarSucursalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.ClienteToolStripMenuItem, Me.AnimalesToolStripMenuItem, Me.LaboratoriosToolStripMenuItem, Me.MedicamentosToolStripMenuItem, Me.SucursalToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(592, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarEmpleadoToolStripMenuItem, Me.ConsultarEmpleadoToolStripMenuItem, Me.ModificarEmpleadoToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'AgregarEmpleadoToolStripMenuItem
        '
        Me.AgregarEmpleadoToolStripMenuItem.Name = "AgregarEmpleadoToolStripMenuItem"
        Me.AgregarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AgregarEmpleadoToolStripMenuItem.Text = "Agregar Empleado"
        '
        'ConsultarEmpleadoToolStripMenuItem
        '
        Me.ConsultarEmpleadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodosLosEmpleadosToolStripMenuItem, Me.BuscarEmpleadoToolStripMenuItem})
        Me.ConsultarEmpleadoToolStripMenuItem.Name = "ConsultarEmpleadoToolStripMenuItem"
        Me.ConsultarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ConsultarEmpleadoToolStripMenuItem.Text = "Consultar Empleado"
        '
        'TodosLosEmpleadosToolStripMenuItem
        '
        Me.TodosLosEmpleadosToolStripMenuItem.Name = "TodosLosEmpleadosToolStripMenuItem"
        Me.TodosLosEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.TodosLosEmpleadosToolStripMenuItem.Text = "Todos los empleados"
        '
        'BuscarEmpleadoToolStripMenuItem
        '
        Me.BuscarEmpleadoToolStripMenuItem.Name = "BuscarEmpleadoToolStripMenuItem"
        Me.BuscarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.BuscarEmpleadoToolStripMenuItem.Text = "Buscar Empleado"
        '
        'ModificarEmpleadoToolStripMenuItem
        '
        Me.ModificarEmpleadoToolStripMenuItem.Name = "ModificarEmpleadoToolStripMenuItem"
        Me.ModificarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ModificarEmpleadoToolStripMenuItem.Text = " Eliminar Empleado"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarClienteToolStripMenuItem, Me.ConsultarClienteToolStripMenuItem, Me.ModificarClienteToolStripMenuItem})
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'AgregarClienteToolStripMenuItem
        '
        Me.AgregarClienteToolStripMenuItem.Name = "AgregarClienteToolStripMenuItem"
        Me.AgregarClienteToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.AgregarClienteToolStripMenuItem.Text = "Agregar Cliente"
        '
        'ConsultarClienteToolStripMenuItem
        '
        Me.ConsultarClienteToolStripMenuItem.Name = "ConsultarClienteToolStripMenuItem"
        Me.ConsultarClienteToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ConsultarClienteToolStripMenuItem.Text = "Consultar Cliente"
        '
        'ModificarClienteToolStripMenuItem
        '
        Me.ModificarClienteToolStripMenuItem.Name = "ModificarClienteToolStripMenuItem"
        Me.ModificarClienteToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ModificarClienteToolStripMenuItem.Text = "Eliminar Cliente"
        '
        'AnimalesToolStripMenuItem
        '
        Me.AnimalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.ConsultarMascotaToolStripMenuItem, Me.ModificarMascotaToolStripMenuItem})
        Me.AnimalesToolStripMenuItem.Name = "AnimalesToolStripMenuItem"
        Me.AnimalesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.AnimalesToolStripMenuItem.Text = "Mascotas"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar Mascota"
        '
        'ConsultarMascotaToolStripMenuItem
        '
        Me.ConsultarMascotaToolStripMenuItem.Name = "ConsultarMascotaToolStripMenuItem"
        Me.ConsultarMascotaToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ConsultarMascotaToolStripMenuItem.Text = "Consultar Mascota"
        '
        'ModificarMascotaToolStripMenuItem
        '
        Me.ModificarMascotaToolStripMenuItem.Name = "ModificarMascotaToolStripMenuItem"
        Me.ModificarMascotaToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ModificarMascotaToolStripMenuItem.Text = "Eliminar Mascota"
        '
        'LaboratoriosToolStripMenuItem
        '
        Me.LaboratoriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarLaboratorioToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.EliminarLaboratorioToolStripMenuItem})
        Me.LaboratoriosToolStripMenuItem.Name = "LaboratoriosToolStripMenuItem"
        Me.LaboratoriosToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.LaboratoriosToolStripMenuItem.Text = "Laboratorios"
        '
        'AgregarLaboratorioToolStripMenuItem
        '
        Me.AgregarLaboratorioToolStripMenuItem.Name = "AgregarLaboratorioToolStripMenuItem"
        Me.AgregarLaboratorioToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.AgregarLaboratorioToolStripMenuItem.Text = "Agregar Laboratorio"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ConsultarToolStripMenuItem.Text = " Consultar Laboratorio"
        '
        'EliminarLaboratorioToolStripMenuItem
        '
        Me.EliminarLaboratorioToolStripMenuItem.Name = "EliminarLaboratorioToolStripMenuItem"
        Me.EliminarLaboratorioToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.EliminarLaboratorioToolStripMenuItem.Text = "Eliminar Laboratorio"
        '
        'MedicamentosToolStripMenuItem
        '
        Me.MedicamentosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarMedicamentoToolStripMenuItem, Me.ConsultarMedicamentoToolStripMenuItem, Me.EliminarMedicamentoToolStripMenuItem})
        Me.MedicamentosToolStripMenuItem.Name = "MedicamentosToolStripMenuItem"
        Me.MedicamentosToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.MedicamentosToolStripMenuItem.Text = "Medicamentos"
        '
        'AgregarMedicamentoToolStripMenuItem
        '
        Me.AgregarMedicamentoToolStripMenuItem.Name = "AgregarMedicamentoToolStripMenuItem"
        Me.AgregarMedicamentoToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.AgregarMedicamentoToolStripMenuItem.Text = "Agregar Medicamento"
        '
        'ConsultarMedicamentoToolStripMenuItem
        '
        Me.ConsultarMedicamentoToolStripMenuItem.Name = "ConsultarMedicamentoToolStripMenuItem"
        Me.ConsultarMedicamentoToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ConsultarMedicamentoToolStripMenuItem.Text = "Consultar Medicamento"
        '
        'EliminarMedicamentoToolStripMenuItem
        '
        Me.EliminarMedicamentoToolStripMenuItem.Name = "EliminarMedicamentoToolStripMenuItem"
        Me.EliminarMedicamentoToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.EliminarMedicamentoToolStripMenuItem.Text = "Eliminar Medicamento"
        '
        'SucursalToolStripMenuItem
        '
        Me.SucursalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarSucursalToolStripMenuItem, Me.ConsultarSucursalToolStripMenuItem, Me.EliminarSucursalToolStripMenuItem})
        Me.SucursalToolStripMenuItem.Name = "SucursalToolStripMenuItem"
        Me.SucursalToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.SucursalToolStripMenuItem.Text = "Sucursal"
        '
        'AgregarSucursalToolStripMenuItem
        '
        Me.AgregarSucursalToolStripMenuItem.Name = "AgregarSucursalToolStripMenuItem"
        Me.AgregarSucursalToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.AgregarSucursalToolStripMenuItem.Text = "Agregar Sucursal"
        '
        'ConsultarSucursalToolStripMenuItem
        '
        Me.ConsultarSucursalToolStripMenuItem.Name = "ConsultarSucursalToolStripMenuItem"
        Me.ConsultarSucursalToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ConsultarSucursalToolStripMenuItem.Text = "Consultar Sucursal"
        '
        'EliminarSucursalToolStripMenuItem
        '
        Me.EliminarSucursalToolStripMenuItem.Name = "EliminarSucursalToolStripMenuItem"
        Me.EliminarSucursalToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.EliminarSucursalToolStripMenuItem.Text = "Eliminar Sucursal"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarUsuarioToolStripMenuItem, Me.ConsultarUsuarioToolStripMenuItem, Me.EliminarUsuarioToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'AgregarUsuarioToolStripMenuItem
        '
        Me.AgregarUsuarioToolStripMenuItem.Name = "AgregarUsuarioToolStripMenuItem"
        Me.AgregarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AgregarUsuarioToolStripMenuItem.Text = "Agregar Usuario"
        '
        'ConsultarUsuarioToolStripMenuItem
        '
        Me.ConsultarUsuarioToolStripMenuItem.Name = "ConsultarUsuarioToolStripMenuItem"
        Me.ConsultarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ConsultarUsuarioToolStripMenuItem.Text = "Consultar Usuario"
        '
        'EliminarUsuarioToolStripMenuItem
        '
        Me.EliminarUsuarioToolStripMenuItem.Name = "EliminarUsuarioToolStripMenuItem"
        Me.EliminarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.EliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(41, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(482, 71)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Veterinaria el Sabueso Feliz"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(12, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(562, 315)
        Me.Label2.TabIndex = 2
        '
        'PantallaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PantallaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnimalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarMascotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarMascotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaboratoriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarLaboratorioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarLaboratorioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarMedicamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarMedicamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarMedicamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SucursalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarSucursalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarSucursalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarSucursalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TodosLosEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarEmpleadoToolStripMenuItem As ToolStripMenuItem
End Class
