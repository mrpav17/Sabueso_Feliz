<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarEmpleado
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.cmbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.lblNroDoc = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.TxtFechaNac = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkMat = New System.Windows.Forms.CheckBox()
        Me.txtFechaIng = New System.Windows.Forms.MaskedTextBox()
        Me.txtNroDoc = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Chocolate
        Me.lblTitulo.Location = New System.Drawing.Point(56, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(230, 50)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Registrar Empleado"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Location = New System.Drawing.Point(12, 67)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(86, 13)
        Me.lblTipoDoc.TabIndex = 1
        Me.lblTipoDoc.Text = "Tipo Documento"
        '
        'cmbTipoDoc
        '
        Me.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDoc.FormattingEnabled = True
        Me.cmbTipoDoc.Location = New System.Drawing.Point(132, 67)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoDoc.TabIndex = 2
        '
        'lblNroDoc
        '
        Me.lblNroDoc.AutoSize = True
        Me.lblNroDoc.Location = New System.Drawing.Point(12, 108)
        Me.lblNroDoc.Name = "lblNroDoc"
        Me.lblNroDoc.Size = New System.Drawing.Size(85, 13)
        Me.lblNroDoc.TabIndex = 3
        Me.lblNroDoc.Text = "Nro. Documento"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(10, 151)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(12, 199)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 5
        Me.lblApellido.Text = "Apellido"
        '
        'TxtFechaNac
        '
        Me.TxtFechaNac.Location = New System.Drawing.Point(132, 238)
        Me.TxtFechaNac.Mask = "00/00/0000"
        Me.TxtFechaNac.Name = "TxtFechaNac"
        Me.TxtFechaNac.Size = New System.Drawing.Size(121, 20)
        Me.TxtFechaNac.TabIndex = 6
        Me.TxtFechaNac.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha Nacimiento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fecha Ingreso"
        '
        'chkMat
        '
        Me.chkMat.AutoSize = True
        Me.chkMat.Location = New System.Drawing.Point(16, 318)
        Me.chkMat.Name = "chkMat"
        Me.chkMat.Size = New System.Drawing.Size(69, 17)
        Me.chkMat.TabIndex = 9
        Me.chkMat.Text = "Matricula"
        Me.chkMat.UseVisualStyleBackColor = True
        '
        'txtFechaIng
        '
        Me.txtFechaIng.Location = New System.Drawing.Point(132, 278)
        Me.txtFechaIng.Mask = "00/00/0000"
        Me.txtFechaIng.Name = "txtFechaIng"
        Me.txtFechaIng.Size = New System.Drawing.Size(121, 20)
        Me.txtFechaIng.TabIndex = 10
        Me.txtFechaIng.ValidatingType = GetType(Date)
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Location = New System.Drawing.Point(132, 108)
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(121, 20)
        Me.txtNroDoc.TabIndex = 11
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(132, 148)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(121, 20)
        Me.TxtNombre.TabIndex = 12
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(132, 192)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(121, 20)
        Me.TxtApellido.TabIndex = 13
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(132, 315)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(121, 20)
        Me.txtMatricula.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 353)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Sucursal"
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(132, 350)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(121, 21)
        Me.cmbSucursal.TabIndex = 16
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(199, 383)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 17
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(73, 383)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 18
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'AgregarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 418)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.txtNroDoc)
        Me.Controls.Add(Me.txtFechaIng)
        Me.Controls.Add(Me.chkMat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtFechaNac)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblNroDoc)
        Me.Controls.Add(Me.cmbTipoDoc)
        Me.Controls.Add(Me.lblTipoDoc)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "AgregarEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblTipoDoc As Label
    Friend WithEvents cmbTipoDoc As ComboBox
    Friend WithEvents lblNroDoc As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents TxtFechaNac As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkMat As CheckBox
    Friend WithEvents txtFechaIng As MaskedTextBox
    Friend WithEvents txtNroDoc As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbSucursal As ComboBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnLimpiar As Button
End Class
