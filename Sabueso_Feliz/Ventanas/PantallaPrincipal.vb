Public Class PantallaPrincipal
    Private Sub PantallaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AgregarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarEmpleadoToolStripMenuItem.Click
        AgregarEmpleado.Show()

    End Sub

    Private Sub ConsultarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarEmpleadoToolStripMenuItem.Click


    End Sub

    Private Sub TodosLosEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodosLosEmpleadosToolStripMenuItem.Click
        Consulta_Empleado.Show()
    End Sub

    Private Sub BuscarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarEmpleadoToolStripMenuItem.Click
        BuscarEmpleado.Show()
    End Sub
End Class
