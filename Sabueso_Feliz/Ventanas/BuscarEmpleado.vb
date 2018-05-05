Imports System.Data.SqlClient

Public Class BuscarEmpleado
    Dim cadena_conexion As String = "Data Source=desktop-gr9mgk8\sqlexpress;Initial Catalog=Veterinaria_DB;Integrated Security=True"

    Dim acceso As New Acceso_a_Datos With {
        ._CadenaConexion = "Data Source=desktop-gr9mgk8\sqlexpress;Initial Catalog=Veterinaria_DB;Integrated Security=True" _
        , ._Tabla = "empleados"
        }

    Private Sub BuscarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_combo()

    End Sub

    Private Function buscar_en_grilla(ByVal que_buscar As String) As Boolean
        Dim c As Integer
        For c = 0 To Consulta_Empleado.DGVConsulta.RowCount - 1
            If Consulta_Empleado.DGVConsulta.Rows(c).Cells("nro_doc").Value = que_buscar Then
                MsgBox("Si existe un Empleado con ese Documento.")
                Return True
                Exit For
            End If
            Return False
        Next
    End Function


    Private Sub cargar_grilla()
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(cadena_conexion)

        Dim consulta As String = "SELECT * FROM empleados Where  (tipo_doc = @tipo_doc) AND (nro_doc = @nro_doc)"

        cmd.Parameters.AddWithValue("@nro_Doc", Me.txtNroDoc.Text)

        cmd.Parameters.Clear()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.Parameters.AddWithValue("@nro_Doc", Me.txtNroDoc.Text)
        cmd.Parameters.AddWithValue("@tipo_doc", Me.cmbTipoDoc.SelectedValue)

        Dim tabla As DataTable = New DataTable()

        cn.Open()
        cmd.Connection = cn
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        da.Fill(tabla)
        cn.Close()


        Me.DGVBuscar.Rows.Clear()
        Me.DGVBuscar.DataSource = tabla

    End Sub

    Private Sub Cargar_combo()
        Dim combo As New Combo
        combo.Cargar(Me.cmbTipoDoc, "tipos_doc", "nombre_tipo_doc", "id_tipo_doc")
    End Sub

    Private Sub BuscarEmpleado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Quiere cerrar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Me.cmbTipoDoc.SelectedIndex = -1 Then
            MsgBox("No selecciono el tipo de documento")
            Me.cmbTipoDoc.Focus()
            Exit Sub
        End If

        If Me.txtNroDoc.Text = "" Then
            MessageBox.Show("El número de documento esta vacio",
                            "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Stop _
                , MessageBoxDefaultButton.Button1)
            Me.txtNroDoc.Focus()
            Exit Sub
        End If


        Me.cargar_grilla()


    End Sub
End Class