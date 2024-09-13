Module Module1
    Sub Main()
        Console.WriteLine("Ingrese el primer lado del triángulo:")
        Dim lado1 As Double = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Ingrese el segundo lado del triángulo:")
        Dim lado2 As Double = Convert.ToDouble(Console.ReadLine())

        CalcularHipotenusa(lado1, lado2)
    End Sub

    Sub CalcularHipotenusa(a As Double, b As Double)
        Dim hipotenusa As Double = Math.Sqrt(a ^ 2 + b ^ 2)
        Console.WriteLine("La hipotenusa del triángulo es: " & hipotenusa.ToString("F2"))
        Console.WriteLine("Presione cualquier tecla para salir :D")
        Console.ReadKey()
    End Sub

End Module
