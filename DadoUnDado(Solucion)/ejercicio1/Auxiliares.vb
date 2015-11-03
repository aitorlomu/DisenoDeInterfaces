Module Auxiliares

    ' Genera un número aleatorio ENTERO entre dos valores dados.
    Function generaAleatorioEntero(ByVal limiteInferior As Integer, ByVal limiteSuperior As Integer) As Integer
        Dim aleatorioGenerado As Integer
        Randomize()
        aleatorioGenerado = CInt(Math.Floor((limiteSuperior - limiteInferior + 1) * Rnd())) + limiteInferior
        Return aleatorioGenerado
    End Function

    ' Genera un número aleatorio DOUBLE entre dos valores dados.
    Function generaAleatorioDouble(ByVal limiteInferior As Double, ByVal limiteSuperior As Double) As Double
        Dim aleatorioGenerado As Double
        Randomize()
        aleatorioGenerado = ((limiteSuperior - limiteInferior + 1) * Rnd()) + limiteInferior
        Return aleatorioGenerado
    End Function

End Module
