﻿Public Class frmBuscarEmpleados
    Dim objConexion As New db_conexion
    Public _ide As Integer
    Private Sub frmBuscarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grbBuscar.DataSource = objConexion.obtenerDatos().Tables("empleados").DefaultView
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        seleccionarCliente()
    End Sub

    Private Sub filtrarDatosEmpleados(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grbBuscar.DataSource
        bs.Filter = "codigo like '%" & valor & "%'  or nombre like '%" & valor & "%'"
        grbBuscar.DataSource = bs
    End Sub
    Private Sub seleccionarCliente()
        _ide = grbBuscar.CurrentRow.Cells("idempleados").Value.ToString()
        Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        _ide = 0
        Close()
    End Sub

    Private Sub txtBuscarEmpleados_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarEmpleados.KeyUp
        filtrarDatosEmpleados(txtBuscarEmpleados.Text)
        If e.KeyCode = 13 Then
            seleccionarCliente()
        End If
    End Sub

    Private Sub grbBuscar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grbBuscar.CellContentClick

    End Sub

    Private Sub txtBuscarEmpleados_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarEmpleados.TextChanged

    End Sub
End Class