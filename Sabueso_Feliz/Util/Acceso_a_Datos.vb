Public Class Acceso_a_Datos
    Dim conexion As Data.SqlClient.SqlConnection
    Dim cmd As Data.SqlClient.SqlCommand
    Dim string_conexion As String = "Data Source=desktop-gr9mgk8\sqlexpress;Initial Catalog=Veterinaria_DB;Integrated Security=True"
    Dim tabla As String = ""

    Public Property _CadenaConexion() As String
        Get
            Return string_conexion
        End Get
        Set(value As String)
            string_conexion = value
        End Set
    End Property

    Public Property _Tabla() As String
        Get
            Return tabla
        End Get
        Set(value As String)
            tabla = value
        End Set
    End Property

    Public Sub New()
        Me.conexion = New Data.SqlClient.SqlConnection
        Me.cmd = New Data.SqlClient.SqlCommand
    End Sub

    Friend Sub InsertarGenerico(v As String)
        Throw New NotImplementedException()
    End Sub

    Public Sub New(ByVal _CadenaConexion As String)
        Me._CadenaConexion = _CadenaConexion
        Me.conexion = New Data.SqlClient.SqlConnection
        Me.cmd = New Data.SqlClient.SqlCommand
    End Sub

    Public Sub New(ByVal _CadenaConexion As String, ByVal _NombreTabla As String)
        Me._CadenaConexion = _CadenaConexion
        Me.conexion = New Data.SqlClient.SqlConnection
        Me.cmd = New Data.SqlClient.SqlCommand
        Me.tabla = _NombreTabla
    End Sub

    Private Sub _Conectar()
        Me.conexion.ConnectionString = Me.string_conexion
        Me.conexion.Open()
        Me.cmd.Connection = conexion
        Me.cmd.CommandType = CommandType.Text
    End Sub


    Public Function _Consulta(ByVal comando As String) As DataTable
        Dim _tabla As New DataTable
        Me._Conectar()
        Me.cmd.CommandText = comando
        _tabla.Load(Me.cmd.ExecuteReader())
        Me.conexion.Close()
        Return _tabla
    End Function

    Public Sub _Borrar(ByVal comando As String)
        Me._Conectar()
        Me.cmd.CommandText = comando
        cmd.ExecuteNonQuery()
        Me.conexion.Close()
    End Sub

    Public Function _Modificar(ByVal comando As String) As Boolean
        Dim _tabla As New DataTable
        Me._Conectar()
        Me.cmd.CommandText = comando
        Me.cmd.ExecuteNonQuery()
        Me.conexion.Close()
        Return True
    End Function


    Public Function Leo_Tabla() As Data.DataTable
        Return Me._Consulta("Select * from " & Me.tabla)
    End Function

    Public Function Leo_Tabla(ByVal restriccion As String) As Data.DataTable
        Return Me._Consulta("Select * from " & Me.tabla & " Where " & restriccion)
    End Function



    Public Function Insertar(ByVal valores As String) As String
        'Esta funcion analiza un conjunto de datos suministrados desde un formulario y contrstuye un comando insert
        'a partir de una tabla determinada.
        'Los datos tienen que venir dentro de un string con el formato
        'campo1 = valor, campo2= valor

        Dim txt_Insert As String = ""
        txt_Insert = Me.Armo_insert() 'Este metodo construye la cabecera del insert
        txt_Insert += Me.Asigno_valores_insert(valores)

        MsgBox(txt_Insert)
        Me._Conectar()
        Me.cmd.CommandText = txt_Insert
        cmd.ExecuteNonQuery()
        Me.conexion.Close()


    End Function



    Private Function Armo_insert() As String
        'Esta funcion construye la cabecera del insert.
        'INSERT INTO "TABLA" (COLUMNA1, COLUMNA2, ..., COLUMNAX) VALUES (

        Dim tabla As DataTable
        Dim contador As Integer = 1
        Dim txt As String = ""

        tabla = Me.Leo_Tabla()

        txt = "Insert into " & Me.tabla & "("

        While tabla.Columns.Count() > contador
            txt += tabla.Columns(contador).Caption
            contador += 1
            If contador < tabla.Columns.Count() Then
                txt += ","
            End If
        End While

        txt += ") Values ("
        Return txt
    End Function

    Private Function Asigno_valores_insert(ByVal txt_insertar As String) As String
        Dim objeto_tabla As DataTable

        Dim contador As Integer = 1 'contador del bucle
        Dim campo As Integer = 0 'ubicacion del campo
        Dim coma As Integer = 0 'ubicacion de la ','
        Dim igual As Integer = 0 'ubicacion del '='
        Dim txt_origen As String = "" 'texto origen
        Dim nombre_campo As String = "" 'campo a buscar
        Dim valor As String = "" 'valor del campo
        Dim txt As String = "" 'texto que se va formando para el insert
        Dim tipo_dato As String = ""

        objeto_tabla = Me.Leo_Tabla()
        txt_origen = txt_insertar.Trim() 'Lleva los datos de entrada a una variable de entrada y los convierte en mayusucla

        While objeto_tabla.Columns.Count() > contador
            nombre_campo = objeto_tabla.Columns(contador).Caption.Trim() 'extrae de la tabla el nombre de los campos en orden ascendente
            tipo_dato = objeto_tabla.Columns(contador).DataType.ToString 'identifica el tipo de datos que este objeto puede almacenar, para rgnaizar la asignación de su contenido

            campo = txt_origen.IndexOf(nombre_campo)

            If campo <> -1 Then
                igual = txt_origen.IndexOf("=", campo)
                coma = txt_origen.IndexOf(",", campo)

                If coma <> -1 Then
                    valor = Me.Acomodo_al_tipo_dato(txt_origen.Substring(igual + 1, coma - igual - 1), tipo_dato)
                Else
                    valor = Me.Acomodo_al_tipo_dato(txt_origen.Substring(igual + 1), tipo_dato)
                End If
            Else
                igual = -1
                coma = -1
                valor = "null"
            End If

            txt += valor
            contador += 1

            If contador < objeto_tabla.Columns.Count() Then
                txt += ","
            End If

        End While

        txt += ")"
        Return txt

    End Function



    Private Function Acomodo_al_tipo_dato(ByVal texto As String, ByVal tipo_dato As String) As String
        Select Case tipo_dato
            Case "System.String"
                Return "'" & texto & "'"
            Case "System.Int16"
                Return texto
            Case "System.Int32"
                Return texto
            Case "System.Int64"
                Return texto
            Case "System.Byte"
                Return texto
            Case "System.Double"
                Return texto
            Case "System.Decimal"
                Return texto
            Case "System.DateTime"
                Return "'" & texto & "'"
            Case "System.DateTimeKind"
                Return "'" & texto & "'"
            Case Else
                Return texto
        End Select
    End Function

End Class
