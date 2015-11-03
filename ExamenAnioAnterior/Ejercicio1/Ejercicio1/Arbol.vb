Public Class Nodo
    Public dato As String
    Public ArbolIzquierdo As Nodo
    Public ArbolDerecho As Nodo
End Class

Public Class Arbol
    Private raiz As Nodo

    Public Sub New()
        raiz = Nothing
    End Sub

    Sub New(ByVal pdato As String)
        raiz = ObtenerNodo(pdato)
    End Sub

    Public Sub CrearArbol(ByVal pOctavos() As String)





        ' Se crea un arbol binario en el cual los nodos de mayor profundidad se corresponden con los valores del vector de cadenas pOctavos y al 50% se 
        ' van completando los niveles del arbol hasta llegar a la raiz que será el equipo ganador.



        Dim altura As Integer
        Dim nodos As Integer
        nodos = (pOctavos.Length * 2) - 1
        altura = log2(nodos + 1) ' Calculamos la altura del arbol según el número de nodos
        MsgBox(altura)
        ' Tenemos la altura generalizada
















        'Dim pnodo As Nodo = raiz
        'If pnodo Is Nothing And Not pOctavos Is Nothing Then

        '    raiz = ObtenerNodo(pOctavos(0))
        '    If raiz.ArbolIzquierdo Is Nothing Then
        '        raiz.ArbolIzquierdo = ObtenerNodo(pOctavos(0))

        '    End If
        '    If raiz.ArbolDerecho Is Nothing Then
        '        raiz.ArbolDerecho = ObtenerNodo(pOctavos(1))
        '    End If
        'End If
    End Sub

    Private Sub MostrarArbol(ByVal pnodo As Nodo)
        If Not pnodo Is Nothing Then
            MostrarArbol(pnodo.ArbolIzquierdo)
            Console.WriteLine(pnodo.dato)
            MostrarArbol(pnodo.ArbolDerecho)
        End If
    End Sub

    Public Function profundidad(ByVal pnodo As Nodo) As Integer
        If pnodo Is Nothing Then
            Return 0
        Else
            Return 1 + (Math.Max(profundidad(pnodo.ArbolIzquierdo), profundidad(pnodo.ArbolDerecho)))
        End If
    End Function

    Private Function ObtenerNodo(ByVal pdato As String) As Nodo
        Dim nodo As New Nodo()
        nodo.dato = pdato
        Return nodo
    End Function

    Public Sub MostrarPorConsola()
        Console.WriteLine()
        Console.WriteLine("Este es el contenido del arbol:")
        MostrarArbol(raiz)
    End Sub

    Public Sub MProfundidad()
        Console.WriteLine(profundidad(raiz))
    End Sub

End Class

Module Module1

    Sub Main()

        Dim Mundial As New Arbol()
        Dim Octavos As String() = {"España", "Alemania", "Brasil", "Italia"}

        Mundial.CrearArbol(Octavos)

        Mundial.MostrarPorConsola()

        Console.ReadLine()
    End Sub

End Module
