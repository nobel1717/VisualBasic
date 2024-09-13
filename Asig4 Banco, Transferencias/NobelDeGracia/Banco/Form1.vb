Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Clientes(9) As ClienteBanco
    Private ClienteIndex As Integer = 0

    Private Sub btnIngresarCliente_Click(sender As Object, e As EventArgs) Handles btnIngresarCliente.Click
        If ClienteIndex < Clientes.Length Then
            Clientes(ClienteIndex).NumeroCuenta = Convert.ToInt32(txtNumeroCuenta.Text)
            Clientes(ClienteIndex).NombreCliente = txtNombreCliente.Text
            Clientes(ClienteIndex).Saldo = Convert.ToDouble(txtMontoInicial.Text)

            ClienteIndex += 1

            MessageBox.Show("Cliente ingresado con éxito.")
        Else
            MessageBox.Show("No se pueden ingresar más clientes.")
        End If
    End Sub

    Public Structure ClienteBanco
        Public NumeroCuenta As Integer
        Public NombreCliente As String
        Public TipoTransaccion As String
        Public Saldo As Double
    End Structure

    Private Sub btnRealizarTransaccion_Click(sender As Object, e As EventArgs) Handles btnRealizarTransaccion.Click
        Dim numCuenta As Integer = Convert.ToInt32(InputBox("Ingrese el número de cuenta del cliente:"))
        Dim encontrado As Boolean = False

        For i As Integer = 0 To Clientes.Length - 1
            If Clientes(i).NumeroCuenta = numCuenta Then
                Dim tipoTransaccion As Integer = Convert.ToInt32(InputBox("Ingrese el tipo de transacción (1 para Depósito, 2 para Retiro):"))

                Dim monto As Double = Convert.ToDouble(InputBox("Ingrese el monto:"))

                If tipoTransaccion = 1 Then
                    Clientes(i).Saldo += monto
                ElseIf tipoTransaccion = 2 Then
                    If monto <= Clientes(i).Saldo Then
                        Clientes(i).Saldo -= monto
                    Else
                        MessageBox.Show("Saldo insuficiente para realizar el retiro.")
                    End If
                Else
                    MessageBox.Show("Tipo de transacción no válido.")
                End If

                MessageBox.Show("El nuevo saldo del cliente es: " & Clientes(i).Saldo.ToString("F2"))

                encontrado = True
                Exit For
            End If
        Next

        If Not encontrado Then
            MessageBox.Show("Cliente no encontrado.")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
