Module FuncionesGUI
    ' Establece el tamaño del datagridview
    ' Le pasamos un datagridview y una lista de String que contendrá los nombres de las columnas
    Public Sub setupDataGridView(ByVal dgv As DataGridView, ByVal lista() As String)
        'Me.Controls.Add(dgvPrueba)
        dgv.ColumnCount = lista.Length ' Tamaño de las columnas
        dgv.RowCount = lista.Length
        ' Colores de la cabezera
        With dgv.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(dgv.Font, FontStyle.Bold)

        End With
        With dgv
            .Name = "dgvPrueba"

            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.Black
            ' Alternar colores para que se vea bonito
            .RowsDefaultCellStyle.BackColor = Color.LightBlue
            .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue

            .RowHeadersVisible = False ' Establece la columna cabezera visible o no

            For i = 0 To lista.Length - 1
                .Columns(i).Name = lista(i)
            Next
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect ' Modo de selección del datagrid
            .MultiSelect = False ' Multiselección activado o no
            .Dock = DockStyle.None ' Disposición del datagrid

        End With

        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub

    Public Sub setupDataGridViewFilasColumnas(ByVal dgv As DataGridView, ByVal filas As Integer, ByVal columnas As Integer)
        'Me.Controls.Add(dgvPrueba)
        dgv.ColumnCount = columnas ' Tamaño de las columnas
        dgv.RowCount = filas

        ' Colores de la cabezera
        With dgv.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(dgv.Font, FontStyle.Bold)

        End With
        With dgv
            .Name = "dgvPrueba"

            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.Black
            ' Alternar colores para que se vea bonito
            .RowsDefaultCellStyle.BackColor = Color.LightBlue
            .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue

            .RowHeadersVisible = False ' Establece la columna cabezera visible o no

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect ' Modo de selección del datagrid
            .MultiSelect = False ' Multiselección activado o no
            .Dock = DockStyle.None ' Disposición del datagrid

        End With

        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub

    Public Sub dataGridViewMatriz(ByVal dgv As DataGridView, ByVal columnas As Integer, ByVal filas As Integer)
        dgv.ColumnCount = columnas
        dgv.RowCount = filas

        With dgv
            .Name = "dgvPrueba"
            .ColumnHeadersVisible = False ' VISIBILIDAD DE LAS COLUMNAS CABECERA
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.Black
            ' Alternar colores para que se vea bonito
            .RowsDefaultCellStyle.BackColor = Color.LightBlue
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .RowHeadersVisible = False ' Establece la columna cabezera visible o no

            .SelectionMode = DataGridViewSelectionMode.CellSelect ' Modo de selección del datagrid
            .MultiSelect = False ' Multiselección activado o no
            .Dock = DockStyle.None ' Disposición del datagrid
        End With

    End Sub

    ' Establece el control datagridview de solo lectura

    Public Sub dgvSoloLectura(ByVal dgv As DataGridView)
        dgv.ReadOnly = True
        dgv.AllowUserToAddRows = False
        dgv.RowHeadersVisible = False
        dgv.EditMode = DataGridViewEditMode.EditProgrammatically
        dgv.AllowUserToResizeRows = False
        dgv.AllowUserToResizeColumns = False
    End Sub

    Public Sub limpiarDgv(ByVal dgv As DataGridView)
        Dim n As Integer
        n = dgv.Rows.Count
        Dim z As Integer

        For z = 0 To n
            dgv.Rows.Clear()
        Next
    End Sub

End Module
