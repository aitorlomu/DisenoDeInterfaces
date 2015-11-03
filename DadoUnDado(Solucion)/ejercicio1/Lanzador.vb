Module Lanzador

    Public TotalTiradas As Integer
    Public numeroASuperar As Integer
    Public dado As Dado
    Public contadorSoluciones As Integer

    Sub Main()

        contadorSoluciones = 0
        TotalTiradas = generaAleatorioEntero(2, 4)

        Console.WriteLine("RESOLUCIÓN DEL EJERCICIO DEL DADO UN DADO")

        Console.WriteLine("---------------------------")
        Console.WriteLine("El número de tiradas aleatorias (entre 2 y 4) ya ha sido calculado y es de: ")
        Console.WriteLine("........     " & TotalTiradas)

        If validaNumeroASuperar() Then
            ' Aquí se continúa con el proceso de cálculo.
            dado = New Dado(6)

            For i = 0 To dado.ppResultadosPosibles.Length - 1
                caminoRecursivo(" ---> " & dado.ppResultadosPosibles(i), dado.ppResultadosPosibles(i), 1, TotalTiradas)
            Next
            If contadorSoluciones = 0 Then
                Console.WriteLine("Ese resultado es inalcanzable")
            Else
                Console.WriteLine("La cantidad de combinaciones distintas es: " & contadorSoluciones)
            End If

        Else
            Console.WriteLine("Hubo datos incorrectos, el programa se cerrará")

        End If
        Console.ReadLine()

    End Sub

    ' Busqueda recursiva de soluciones
    Private Sub caminoRecursivo(ByVal cadena As String, ByVal resultadoAcumulado As Integer, ByVal tiradasHechas As Integer, ByVal tiradasMaximas As Integer)

        If tiradasHechas = tiradasMaximas Then
            If resultadoAcumulado > numeroASuperar Then
                contadorSoluciones = contadorSoluciones + 1
                Console.Write("Combinación número " & contadorSoluciones & "    " & cadena)
                Console.WriteLine()
            End If
        Else
            If tiradasHechas < tiradasMaximas Then
                For i = 0 To dado.ppResultadosPosibles.Length - 1
                    caminoRecursivo(cadena & "      " & dado.ppResultadosPosibles(i), dado.ppResultadosPosibles(i) + resultadoAcumulado, tiradasHechas + 1, TotalTiradas)
                Next
            End If
        End If

    End Sub
    
    ' Comprobacion de introdución de datos correctamente
    Public Function validaNumeroASuperar() As Boolean
        Dim datosValidos As Boolean = True
        Console.WriteLine("Introduzca la cantidad numérica a superar")
        Try
            numeroASuperar = Convert.ToInt32(Console.ReadLine())
            If numeroASuperar <= 0 Then
                datosValidos = False
                Console.WriteLine("El número de tiradas ha de ser mayor que cero y entero")
                Return False
            End If
        Catch ex As Exception
            datosValidos = False
            Console.WriteLine("El número de tiradas ha de ser mayor que cero y entero")
            Return datosValidos
        End Try
        Return datosValidos
    End Function


End Module
