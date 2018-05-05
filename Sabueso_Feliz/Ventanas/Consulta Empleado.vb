Imports System.Data.SqlClient

Public Class Consulta_Empleado
    Dim cadena_conexion As String = "Data Source=desktop-gr9mgk8\sqlexpress;Initial Catalog=Veterinaria_DB;Integrated Security=True"

    Dim acceso As New Acceso_a_Datos With {
        ._CadenaConexion = "Data Source=desktop-gr9mgk8\sqlexpress;Initial Catalog=Veterinaria_DB;Integrated Security=True" _
        , ._Tabla = "empleados"
        }


    Private Sub cargar_grilla()
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(cadena_conexion)

        Dim consulta As String = "SELECT * FROM empleados "

        cmd.Parameters.Clear()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta

        Dim tabla As DataTable = New DataTable()

        cn.Open()
        cmd.Connection = cn
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        da.Fill(tabla)
        cn.Close()


        Me.DGVConsulta.Rows.Clear()
        Me.DGVConsulta.DataSource = tabla

    End Sub

    Private Sub ConsultaEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub

End Class