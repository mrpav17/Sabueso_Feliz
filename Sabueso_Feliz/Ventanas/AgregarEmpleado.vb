Imports System.Data.SqlClient

Public Class AgregarEmpleado

    Dim cadena_conexion As String = "Data Source=desktop-gr9mgk8\sqlexpress;Initial Catalog=Veterinaria_DB;Integrated Security=True"

    Dim acceso As New Acceso_a_Datos With {
        ._CadenaConexion = "Data Source=desktop-gr9mgk8\sqlexpress;Initial Catalog=Veterinaria_DB;Integrated Security=True" _
        , ._Tabla = "empleados"
        }


    Private Sub AgregarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_combo_doc()
        cargar_combo_suc()
        txtMatricula.Enabled = False
    End Sub

    Private Sub cargar_combo_doc()
        Dim combo As New Combo()
        combo.Cargar(Me.cmbTipoDoc, "tipos_doc", "nombre_tipo_doc", "id_tipo_doc")
    End Sub

    Private Sub cargar_combo_suc()
        Dim combo As New Combo()
        combo.Cargar(Me.cmbSucursal, "sucursales", "nombre", "id_sucursal")
    End Sub

    Private Sub AgregarEmpleado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("ｿQuiere cerrar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub InsertarNuevoEmpleado()
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(cadena_conexion)

        Dim consulta As String = "INSERT INTO empleados (tipo_doc, nro_doc, nombre, apellido, fecha_nacimiento, fecha_ingreso, matricula, sucursal) VALUES (@tipoDoc, @nroDoc, @nom, @ape, @fechaNac, @fechaIng, @mat, @suc);"

        cmd.Parameters.Clear()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.Parameters.AddWithValue("@tipoDoc", Me.cmbTipoDoc.SelectedValue)
        cmd.Parameters.AddWithValue("@nroDoc", Me.txtNroDoc.Text)
        cmd.Parameters.AddWithValue("@nom", Me.TxtNombre.Text)
        cmd.Parameters.AddWithValue("@ape", Me.TxtApellido.Text)
        cmd.Parameters.AddWithValue("@fechaNac", Me.TxtFechaNac.Text)
        cmd.Parameters.AddWithValue("@fechaIng", Me.txtFechaIng.Text)
        cmd.Parameters.AddWithValue("@mat", Me.txtMatricula.Text)
        cmd.Parameters.AddWithValue("@suc", Me.cmbSucursal.SelectedValue)


        Dim tabla As DataTable = New DataTable()

        cn.Open()
        cmd.Connection = cn
        cmd.ExecuteNonQuery()
        cn.Close()

    End Sub

    Private Sub TxtFechaNac_Validated(sender As Object, e As EventArgs) Handles TxtFechaNac.Validated, txtFechaIng.Validated
        If sender.text = "  /  /" Then
            Exit Sub
        End If

        If IsDate(sender.Text) Then
            If Not sender.Text = Format(CDate(sender.text), "dd/mm/yyyy") Then
            Else
                MsgBox("Fecha invalida", vbOKOnly + vbCritical, "Atención")
                sender.Focus()
                Exit Sub
            End If
        Else
            MsgBox("Fecha invalida", vbOKOnly + vbCritical, "Atención")
            sender.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtNroDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroDoc.KeyPress
        Select Case Asc(e.KeyChar)
            Case 24, 4, 19, 127, 13, 9, 15, 14, 8
                Exit Sub
        End Select

        If IsNumeric(e.KeyChar) = False Then
            MsgBox("Este carater no es un numero ( " + e.KeyChar + " )", vbCritical, "Importante")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub chkMatricula_CheckedChanged(sender As Object, e As EventArgs) Handles chkMat.CheckedChanged
        If Me.chkMat.Checked = True Then
            Me.txtMatricula.Enabled = True
        Else
            Me.txtMatricula.Enabled = False
        End If
    End Sub

    Private Function existeDoc(ByVal tipo_doc As Integer, ByVal nro_doc As String) As Boolean
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(cadena_conexion)

        Dim consulta As String = "SELECT * FROM empleados WHERE (tipo_doc = @tipo_doc) AND (nro_doc = @nro_doc)"

        cmd.Parameters.Clear()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.Parameters.AddWithValue("@tipo_doc", tipo_doc)
        cmd.Parameters.AddWithValue("@nro_doc", nro_doc)

        Dim tabla As DataTable = New DataTable()

        cn.Open()
        cmd.Connection = cn
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        da.Fill(tabla)
        cn.Close()

        If tabla.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub limpiar()
        Dim objactual As Object
        For Each objactual In Me.Controls
            Select Case TypeName(objactual)
                Case "TextBox", "MaskedTextBox"
                    objactual.Text = ""
                Case "ComboBox"
                    Dim esteobj As ComboBox = objactual
                    esteobj.SelectedIndex = -1
            End Select
        Next

        chkMat.Checked = False

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If Me.TxtNombre.Text = "" Then
            MessageBox.Show("El nombre esta vacio",
                "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Stop _
                , MessageBoxDefaultButton.Button1)
            Me.TxtNombre.Focus()
            Exit Sub
        End If

        If Me.TxtApellido.Text = "" Then
            MessageBox.Show("El apellido esta vacio",
                "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Stop _
                , MessageBoxDefaultButton.Button1)
            Me.TxtApellido.Focus()
            Exit Sub

        End If

        If Me.cmbTipoDoc.SelectedIndex = -1 Then
            MsgBox("No selecciono el tipo de documento")
            Me.cmbTipoDoc.Focus()
            Exit Sub
        End If

        If Me.txtNroDoc.Text = "" Then
            MessageBox.Show("El n伹ero de documento esta vacio",
                            "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Stop _
                , MessageBoxDefaultButton.Button1)
            Me.txtNroDoc.Focus()
            Exit Sub
        End If

        If existeDoc(Me.cmbTipoDoc.SelectedValue, Me.txtNroDoc.Text) Then
            MessageBox.Show("El documento ingresado ya existe", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Empleado registrado con exito", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            InsertarNuevoEmpleado()
            Consulta_Empleado.Show()
        End If
    End Sub

End Class
