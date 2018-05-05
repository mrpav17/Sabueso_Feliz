<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_Empleado
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
        Me.DGVConsulta = New System.Windows.Forms.DataGridView()
        Me.lblTituloConsulta = New System.Windows.Forms.Label()
        CType(Me.DGVConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVConsulta
        '
        Me.DGVConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVConsulta.Location = New System.Drawing.Point(12, 87)
        Me.DGVConsulta.Name = "DGVConsulta"
        Me.DGVConsulta.Size = New System.Drawing.Size(776, 351)
        Me.DGVConsulta.TabIndex = 0
        '
        'lblTituloConsulta
        '
        Me.lblTituloConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloConsulta.Location = New System.Drawing.Point(218, 20)
        Me.lblTituloConsulta.Name = "lblTituloConsulta"
        Me.lblTituloConsulta.Size = New System.Drawing.Size(357, 51)
        Me.lblTituloConsulta.TabIndex = 1
        Me.lblTituloConsulta.Text = "Empleados Registrados"
        '
        'Consulta_Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTituloConsulta)
        Me.Controls.Add(Me.DGVConsulta)
        Me.Name = "Consulta_Empleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta_Empleado"
        CType(Me.DGVConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVConsulta As DataGridView
    Friend WithEvents lblTituloConsulta As Label
End Class
