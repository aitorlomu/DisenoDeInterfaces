Public Class Inicio

    Private lcaracteres As ListaCaracteres

    Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        lcaracteres = New ListaCaracteres

    End Sub

    'Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click

    '    Dim caracteres() As Char
    '    Dim matriz(,) As Char

    '    ' Comprobar que hay texto, y en caso contrario mostrar un mensaje indicandolo.
    '    If txtTexto.Text = "" Then
    '        MsgBox("No lo hay señora hay texto")
    '    End If
    '    ' Se recoge el texto introducido en el textbox y se introduce en el atributo lcaracteres.
    '    caracteres = txtTexto.Text.ToCharArray()
    '    For i = 0 To caracteres.Length - 1
    '        lcaracteres.Insertar_Ultimo(caracteres(i))
    '    Next
    '    ' Contando el numero de caracteres se determina la dimension de la matriz más cuadrada para almacenar el mensaje.
    '    ReDim matriz(Math.Sqrt(caracteres.Length), Math.Sqrt(caracteres.Length))
    '    MsgBox(matriz.GetUpperBound(1))

    '    'dataGridViewMatriz(dgvDecodificado, tamanioColumnas, tamanioFilas)
    '    'dgvSoloLectura(dgvDecodificado)


    '    ' En dgvDecodificado se muestra el mensaje sin codificar desde lcaracteres utilizando.
    '    ' dataGridViewMatriz(dgvDecodificado, 5, 6)
    '    ' Establecemos las columnas y filas del datagridview

    '    'dgvDecodificado.ColumnCount = matriz.GetUpperBound(1) ' mismas columnas que el tamaño de la tabla

    '    'Dim aux(matriz.GetUpperBound(1)) As String

    '    '' Guardamos lcaracteres en un auxiliar para no perderlo
    '    'Dim laux As ListaCaracteres
    '    'laux = lcaracteres
    '    '' Cargamos los datos en la matriz
    '    'For i = 0 To matriz.GetUpperBound(0) - 1
    '    '    For j = 0 To matriz.GetUpperBound(1) - 1
    '    '        matriz(i, j) = lcaracteres.Dev_Primero()
    '    '        aux(j) = CStr(matriz(i, j))
    '    '        lcaracteres.Quitar_Primero()
    '    '    Next
    '    '    dgvDecodificado.Rows.Add(aux)
    '    'Next


    '    'lcaracteres = laux



    '    ' En dgvCodificado se muestra el mensaje codificado (se permutan filas por columnas) tambien desde el atributo lcaracteres

    'End Sub

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
