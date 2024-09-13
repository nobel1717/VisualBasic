Module Module1

    Sub Main()
        Console.WriteLine("Ingrese el primer número:")
        Dim num1 As Double
        num1 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Ingrese el segundo número:")
        Dim num2 As Double = Convert.ToDouble(Console.ReadLine())

        Dim promedio As Double = CalcularPromedio(num1, num2)
        Console.WriteLine("El promedio de los dos números es: " & promedio.ToString("F2"))

        Console.WriteLine("Presione cualquier tecla para salir de la consola :D")
        Console.ReadKey()
    End Sub

    Function CalcularPromedio(a As Double, b As Double) As Double
        Return (a + b) / 2
    End Function

End Module
