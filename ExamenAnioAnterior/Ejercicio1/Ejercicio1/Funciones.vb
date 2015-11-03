Module Funciones
    ' Convierte un String en Integer y devuelve true en caso de exito
    Function validarNum(ByVal num As String) As Boolean

        Dim numeroInt As Integer
        Dim comprobar As Boolean

        Try
            numeroInt = Convert.ToInt32(num)
            comprobar = True

        Catch ex As Exception
            Console.WriteLine("Error: No has introducido un número")
            comprobar = False
        End Try

        Return comprobar
    End Function
    Sub mostrarConsola()
        Console.WriteLine()
        Console.WriteLine("Pulse enter para Salir")
        Console.ReadLine()
    End Sub

    ' Funcion que te devuelve el numero mayor
    ' Devuelve 0 en caso de que sean iguales

    Function numMayor(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Dim resultado As Integer
        If (num1 > num2) Then
            resultado = num1
        ElseIf (num1 < num2) Then
            resultado = num2
        Else
            resultado = 0
        End If
        Return resultado
    End Function


    ' Funcion que devuelve el menor de los tres numeros pasados por parametro
    ' 0 si son iguales
    Function numMenor(ByVal num1, ByVal num2, ByVal num3) As Integer
        Dim menor As Integer

        If (num1 <= num2) Then
            If (num1 <= num3) Then
                menor = num1
            Else
                menor = num3
            End If
        Else
            menor = num2
        End If
        Return menor
    End Function

    ' Devuelve el mes dado el numero de mes
    Function meses(ByVal n As Integer) As String
        Dim mes() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo",
                                "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
        Return mes(n)
    End Function

    ' Imprime un array de enteros
    Sub imprimirArray(ByVal array() As Integer)
        Console.WriteLine()
        For i = 0 To array.Length - 1
            If (i = 0) Then
                Console.Write("[ ")
            End If
            Console.Write(array(i))
            If (i <> array.Length - 1) Then
                Console.Write(", ")
            Else
                Console.Write(" ]")
            End If
        Next
        Console.WriteLine()
    End Sub

    ' Imprime un array de Strings
    Sub imprimirArray(ByVal array() As String)
        Console.WriteLine()
        For i = 0 To array.Length - 1
            If (i = 0) Then
                Console.Write("[ ")
            End If
            Console.Write(array(i))
            If (i <> array.Length - 1) Then
                Console.Write(", ")
            Else
                Console.Write(" ]")
            End If
        Next
        Console.WriteLine()
    End Sub

    ' Sumar los elementos del array de enteros
    Function sumArray(ByVal array() As Double) As Double
        Dim suma As Double
        suma = 0
        For i = 0 To array.Length - 1
            suma = suma + array(i)
        Next

        Return suma
    End Function
    Function avgArray(ByVal array() As Double) As Double
        Dim media As Double
        media = sumArray(array) / array.Length
        Return media
    End Function
    Sub invertirArray(ByVal array() As String)
        For i = array.Length - 1 To 0 Step -1
            If (i = array.Length - 1) Then
                Console.Write("[ ")
            End If
            Console.Write(array(i))
            If (i <> 0) Then
                Console.Write(", ")
            Else
                Console.Write(" ]")
            End If
        Next
        Console.WriteLine()
    End Sub

    '' Devuelve el iva de una cantidad
    Function getIVA(ByVal n As Double)

        Const IVA As Double = 0.21
        Dim impuesto As Double
        impuesto = n * IVA
        Return impuesto

    End Function

    ' Te dice si el numero es negativo o no
    Function numNegativo(ByVal num As Double)
        Dim resultado As Boolean
        If (num < 0) Then
            resultado = True
        Else
            resultado = False
        End If

        Return resultado
    End Function
    ' PARTE CALCULADORA
    Function Suma(ByVal a As Double, ByVal b As Double) As Double
        Return a + b
    End Function
    Function Resta(ByVal a As Double, ByVal b As Double) As Double
        Return a - b
    End Function
    Function Multiplicacion(ByVal a As Double, ByVal b As Double) As Double
        Return a * b
    End Function
    Function Division(ByVal a As Double, ByVal b As Double) As Double
        Return a / b
    End Function
    Function Resto(ByVal a As Double, ByVal b As Double) As Double
        Return a Mod b
    End Function

    ' Funcion que realiza un numero aleatorio en el rango de dos numeros pasados por parametro

    Function aleatorio(ByVal limInferior As Integer, ByVal limSuperior As Integer) As Integer
        Randomize()
        Dim resultado, sup As Integer
        sup = limSuperior - 1
        resultado = CInt(Math.Floor(sup - limInferior + 1) * Rnd() + limInferior)
        Return resultado
    End Function


    Public Function log2(ByVal n As Double) As Double
        Dim p As Double
        p = Math.Log(n) / Math.Log(2)
        Return p
    End Function



End Module


