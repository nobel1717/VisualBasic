Imports System.Configuration
Imports System.Data.SqlClient

Public Class Form1

    Private Sub LimpiarCampos()
        txtCedula.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtEdad.Clear()
        txtCorreo.Clear()
    End Sub

    Private Function ValidarTextoSoloLetras(texto As String) As Boolean
        For Each c As Char In texto
            If Not Char.IsLetter(c) AndAlso Not Char.IsWhiteSpace(c) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function ValidarCorreo(correo As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
            "^[^@\s]+@[^@\s]+\.[^@\s]+$")
        Return emailRegex.IsMatch(correo)
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not ValidarTextoSoloLetras(txtNombre.Text) Then
            MessageBox.Show("El campo Nombre debe contener solo letras.")
            Return
        End If

        If Not ValidarTextoSoloLetras(txtApellido.Text) Then
            MessageBox.Show("El campo Apellido debe contener solo letras.")
            Return
        End If

        If Not IsNumeric(txtEdad.Text) Then
            MessageBox.Show("El campo Edad debe contener solo números.")
            Return
        End If

        If Not ValidarCorreo(txtCorreo.Text) Then
            MessageBox.Show("El correo electrónico no es válido.")
            Return
        End If

        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Dim queryVerificarCedula As String = "SELECT COUNT(*) FROM Clientes WHERE Cedula = @Cedula"
                Dim cmdVerificarCedula As New SqlCommand(queryVerificarCedula, connection)
                cmdVerificarCedula.Parameters.AddWithValue("@Cedula", txtCedula.Text)

                Dim count As Integer = Convert.ToInt32(cmdVerificarCedula.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("La cédula ya está registrada.")
                    Return
                End If

                Dim query As String = "INSERT INTO Clientes (Cedula, Nombre, Apellido, Edad, Correo) VALUES (@Cedula, @Nombre, @Apellido, @Edad, @Correo)"
                Dim command As New SqlCommand(query, connection)

                command.Parameters.AddWithValue("@Cedula", txtCedula.Text)
                command.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                command.Parameters.AddWithValue("@Apellido", txtApellido.Text)
                command.Parameters.AddWithValue("@Edad", Convert.ToInt32(txtEdad.Text))
                command.Parameters.AddWithValue("@Correo", txtCorreo.Text)

                command.ExecuteNonQuery()
                MessageBox.Show("Registro agregado correctamente.")
                LimpiarCampos()

            Catch ex As Exception
                MessageBox.Show("Error al agregar el registro: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT Nombre, Apellido, Edad, Correo FROM Clientes WHERE Cedula = @Cedula"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Cedula", txtCedula.Text)

                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    txtNombre.Text = reader("Nombre").ToString()
                    txtApellido.Text = reader("Apellido").ToString()
                    txtEdad.Text = reader("Edad").ToString()
                    txtCorreo.Text = reader("Correo").ToString()
                Else
                    MessageBox.Show("Registro no encontrado.")
                End If

            Catch ex As Exception
                MessageBox.Show("Error al consultar el registro: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "UPDATE Clientes SET Nombre = @Nombre, Apellido = @Apellido, Edad = @Edad, Correo = @Correo WHERE Cedula = @Cedula"
                Dim command As New SqlCommand(query, connection)

                command.Parameters.AddWithValue("@Cedula", txtCedula.Text)
                command.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                command.Parameters.AddWithValue("@Apellido", txtApellido.Text)
                command.Parameters.AddWithValue("@Edad", Convert.ToInt32(txtEdad.Text))
                command.Parameters.AddWithValue("@Correo", txtCorreo.Text)

                command.ExecuteNonQuery()
                MessageBox.Show("Registro actualizado correctamente.")
                LimpiarCampos()

            Catch ex As Exception
                MessageBox.Show("Error al actualizar el registro: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "DELETE FROM Clientes WHERE Cedula = @Cedula"
                Dim command As New SqlCommand(query, connection)

                command.Parameters.AddWithValue("@Cedula", txtCedula.Text)

                command.ExecuteNonQuery()
                MessageBox.Show("Registro eliminado correctamente.")
                LimpiarCampos()

            Catch ex As Exception
                MessageBox.Show("Error al eliminar el registro: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnIrForm2_Click(sender As Object, e As EventArgs) Handles btnIrForm2.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub
End Class
