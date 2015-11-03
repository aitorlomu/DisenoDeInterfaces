Public Class Dado

    Private numeroCaras As Integer
    Private resultadosPosibles() As Integer

    Public Property ppNumeroCaras As Integer
        Get
            Return numeroCaras
        End Get
        Set(ByVal value As Integer)
            numeroCaras = value
        End Set
    End Property

    Public Property ppResultadosPosibles As Integer()
        Get
            Return resultadosPosibles
        End Get
        Set(ByVal value As Integer())
            resultadosPosibles = value
        End Set
    End Property

    Public Sub New()
        Me.New(6)
    End Sub

    Public Sub New(ByVal numeroCaras As Integer)
        Me.ppNumeroCaras = numeroCaras
        Me.ppResultadosPosibles = calculaResultadosPosibles()
    End Sub

    Public Function calculaResultadosPosibles() As Integer()
        Dim resultados(ppNumeroCaras - 1) As Integer

        For i = 0 To resultados.Length - 1
            resultados(i) = i + 1
        Next

        Return resultados
    End Function


End Class
