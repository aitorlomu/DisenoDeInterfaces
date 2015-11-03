Public Class Inicio

    Private lcaracteres As ListaCaracteres

    Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        lcaracteres = New ListaCaracteres

    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click

        ' LimpiarDataGridview

        lcaracteres = New ListaCaracteres
        Dim caracteres() As Char
        Dim matriz(,) As Char
        Dim matrizAux(,) As Char
        Dim fila, columna As Double
        Dim laux As ListaCaracteres
        Dim aux() As String

        limpiarDgv(dgvDecodificado) ' limpiamos los datagridview
        limpiarDgv(dgvCodificado)


        ' Comprobar que hay texto, y en caso contrario mostrar un mensaje indicandolo.
        If txtTexto.Text = "" Then
            MsgBox("No hay texto")
        End If

        ' Se recoge el texto introducido en el textbox y se introduce en el atributo lcaracteres.
        caracteres = txtTexto.Text.ToCharArray()

        For i = 0 To caracteres.Length - 1
            lcaracteres.Insertar_Ultimo(caracteres(i))
        Next

        ' Contando el numero de caracteres se determina la dimension de la matriz más cuadrada para almacenar el mensaje.
        fila = Math.Sqrt(caracteres.Length)
        columna = Math.Sqrt(caracteres.Length)

        If (fila Mod 2 <> 0 Or columna Mod 2 <> 0) Then
            fila = fila + 1
            columna = columna + 1
        End If

        ReDim matriz(fila, columna)
        ReDim matrizAux(fila, columna)

        ' En dgvDecodificado se muestra el mensaje sin codificar desde lcaracteres utilizando.

        ' Establecemos las columnas y filas del datagridview

        dgvDecodificado.ColumnCount = matriz.GetUpperBound(1) ' mismas columnas que el tamaño de la tabla
        dgvCodificado.ColumnCount = matriz.GetUpperBound(1)

        ReDim aux(matriz.GetUpperBound(1))

        'Guardamos lcaracteres en un auxiliar para no perderlo

        laux = New ListaCaracteres()

        'Cargamos los datos en la matriz
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                matriz(i, j) = lcaracteres.Dev_Primero()
                laux.Insertar_Ultimo(matriz(i, j))
                aux(j) = CStr(lcaracteres.Dev_Primero)
                lcaracteres.Quitar_Primero()
            Next
            dgvDecodificado.Rows.Add(aux)
        Next


        ' En dgvCodificado se muestra el mensaje codificado (se permutan filas por columnas) tambien desde el atributo lcaracteres
        'Traspuesta
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                matrizAux(i, j) = matriz(j, i)
                aux(j) = CStr(matrizAux(i, j))
            Next
            dgvCodificado.Rows.Add(aux)
        Next

    End Sub

    Sub ajustaCeldas()
        For i = 0 To dgvDecodificado.RowCount - 1
            dgvDecodificado.Rows.Item(i).Height = (dgvDecodificado.Size.Height / dgvDecodificado.RowCount)
        Next
    End Sub

    Sub estilodgv(ByVal dgv As DataGridView)

        dgv.ReadOnly = True ' celdas de solo lectura
        dgv.AllowUserToAddRows = False ' para que no se muestre la ultima fila en blanco
        dgv.ColumnHeadersVisible = False ' para que no se muestre el titulo de la columna
        dgv.RowHeadersVisible = False ' para que no se muestre la columna vacia de cada fila

        dgv.EditMode = DataGridViewEditMode.EditProgrammatically
        dgv.SelectionMode = DataGridViewSelectionMode.CellSelect  'modos de seleccion muy importante FullRowSelect
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' para ajustarse el tamaño de las columnas a las dimensiones del datagridview
        dgv.AllowUserToResizeColumns = False ' no permitir redimensionar columnas
        dgv.AllowUserToResizeRows = False ' no permitir redimensionar filas

    End Sub

End Class
