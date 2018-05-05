Public Class Combo
    Public Sub Cargar(ByRef _combo As ComboBox, ByVal _tabla As DataTable)
        _combo.DataSource = _tabla
        _combo.DisplayMember = _tabla.Columns(1).ColumnName
        _combo.ValueMember = _tabla.Columns(0).ColumnName
    End Sub

    Public Sub Cargar(ByRef _combo As ComboBox, ByVal _nombreTabla As String, ByVal _displayMember As String, ByVal _valueMember As String)
        Dim _conexion As New Acceso_a_Datos
        _conexion._Tabla = _nombreTabla
        _combo.DataSource = _conexion.Leo_Tabla()
        _combo.DisplayMember = _displayMember
        _combo.ValueMember = _valueMember

    End Sub
End Class
