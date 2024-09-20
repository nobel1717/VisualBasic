Public Class DataGridViewForm
    Private matriz(2, 4) As Integer

    Private Sub FormMatriz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ColumnCount = 6
        DataGridView1.RowCount = 4

        DataGridView1.Columns(0).HeaderText = "Col 1"
        DataGridView1.Columns(1).HeaderText = "Col 2"
        DataGridView1.Columns(2).HeaderText = "Col 3"
        DataGridView1.Columns(3).HeaderText = "Col 4"
        DataGridView1.Columns(4).HeaderText = "Col 5"
        DataGridView1.Columns(5).HeaderText = "Suma Filas"

        DataGridView1.Rows(3).HeaderCell.Value = "Suma Columnas"

        DataGridView1.Columns(5).Width = 100
        DataGridView1.RowHeadersWidth = 150

        For i As Integer = 0 To 4
            DataGridView1.Rows(3).Cells(i).ReadOnly = True
        Next
        DataGridView1.Columns(5).ReadOnly = True

        Try
            For i As Integer = 0 To 2
                For j As Integer = 0 To 4
                    Dim entrada As String = InputBox($"Ingrese el valor para la posición ({i + 1},{j + 1}):", "Entrada de Datos")
                    If IsNumeric(entrada) AndAlso Integer.TryParse(entrada, matriz(i, j)) Then
                        DataGridView1.Rows(i).Cells(j).Value = matriz(i, j)
                    Else
                        MessageBox.Show("Ingrese un número entero válido.")
                        j -= 1
                    End If
                Next
            Next

            CalcularSuma()

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message)
        End Try
    End Sub

    Private Sub CalcularSuma()
        For i As Integer = 0 To 2
            DataGridView1.Rows(i).Cells(5).Value = 0
        Next

        For j As Integer = 0 To 4
            DataGridView1.Rows(3).Cells(j).Value = 0
        Next

        For i As Integer = 0 To 2
            Dim sumaFila As Integer = 0
            For j As Integer = 0 To 4
                sumaFila += matriz(i, j)
                DataGridView1.Rows(i).Cells(5).Value = Convert.ToInt32(DataGridView1.Rows(i).Cells(5).Value) + matriz(i, j)
                DataGridView1.Rows(3).Cells(j).Value = Convert.ToInt32(DataGridView1.Rows(3).Cells(j).Value) + matriz(i, j)
            Next
            DataGridView1.Rows(i).Cells(5).Value = sumaFila
        Next
    End Sub

End Class
