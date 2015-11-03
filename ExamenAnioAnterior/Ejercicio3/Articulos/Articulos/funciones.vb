Module funciones

    Sub estilodgv(ByVal dgv As DataGridView)

        dgv.ReadOnly = True
        dgv.AllowUserToAddRows = False ' para que no se muestre la ultima fila en blanco
        dgv.ColumnHeadersVisible = True ' para que se muestre el titulo de la columna
        dgv.RowHeadersVisible = False ' para que no se muestre la columna vacia de cada fila

        With dgv.ColumnHeadersDefaultCellStyle
            .Font = New Font("Tahoma", 8, FontStyle.Bold)
            .ForeColor = Color.Black
            .BackColor = Color.Beige
            .SelectionForeColor = Color.Yellow
            .SelectionBackColor = Color.Blue
        End With

        dgv.EditMode = DataGridViewEditMode.EditProgrammatically
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        With (dgv)
            .RowsDefaultCellStyle.BackColor = Color.Linen
            .AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise
        End With

        With dgv.DefaultCellStyle
            .Font = New Font("Tahoma", 8)
            .ForeColor = Color.Black
            .BackColor = Color.Beige
            .SelectionForeColor = Color.Yellow
            .SelectionBackColor = Color.Silver
        End With
    End Sub

    Sub estilodgv2(ByVal dgv As DataGridView)

        dgv.ReadOnly = True
        dgv.AllowUserToAddRows = False ' para que no se muestre la ultima fila en blanco
        dgv.ColumnHeadersVisible = True ' para que se muestre el titulo de la columna
        dgv.RowHeadersVisible = False ' para que no se muestre la columna vacia de cada fila

        With dgv.ColumnHeadersDefaultCellStyle
            .Font = New Font("Tahoma", 8, FontStyle.Bold)
            .ForeColor = Color.Black
            .BackColor = Color.Beige
            .SelectionForeColor = Color.Yellow
            .SelectionBackColor = Color.Blue
        End With

        dgv.EditMode = DataGridViewEditMode.EditProgrammatically
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        With (dgv)
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise
        End With

        With dgv.DefaultCellStyle
            .Font = New Font("Tahoma", 9)
            .ForeColor = Color.Black
            .BackColor = Color.Beige
            .SelectionForeColor = Color.Yellow
            .SelectionBackColor = Color.Blue
        End With
    End Sub

    Sub estilodgvArt(ByVal dgv As DataGridView)

        dgv.ReadOnly = True
        dgv.AllowUserToAddRows = False ' para que no se muestre la ultima fila en blanco
        dgv.ColumnHeadersVisible = True ' para que se muestre el titulo de la columna
        dgv.RowHeadersVisible = False ' para que no se muestre la columna vacia de cada fila

        With dgv.ColumnHeadersDefaultCellStyle
            .Font = New Font("Tahoma", 8, FontStyle.Bold)
            .ForeColor = Color.Black
            .BackColor = Color.Beige
            .SelectionForeColor = Color.Yellow
            .SelectionBackColor = Color.Blue
        End With

        dgv.EditMode = DataGridViewEditMode.EditProgrammatically
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        With (dgv)
            .RowsDefaultCellStyle.BackColor = Color.Linen
            .AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise
        End With

        With dgv.DefaultCellStyle
            .Font = New Font("Tahoma", 8)
            .ForeColor = Color.Black
            .BackColor = Color.Beige
            .SelectionForeColor = Color.Brown
            .SelectionBackColor = Color.Silver
        End With
    End Sub

    Sub rellenacombobox(ByVal combo As ComboBox, ByVal sOracle As String, ByVal inicio As String)
        Dim Data As New DataSet
        Dim Search As New ConnectDB

        Data = Search.getData(sOracle, "tabla")
        Dim ttablas As DataTable = Data.Tables("tabla")
        If Not inicio = "" Then
            Dim newrow2 As DataRow = ttablas.NewRow()
            newrow2(0) = -1
            newrow2(1) = inicio
            ttablas.Rows.InsertAt(newrow2, 0)
        End If
        combo.DataSource = ttablas
        combo.DisplayMember = ttablas.Columns(1).ToString
        combo.ValueMember = ttablas.Columns(0).ToString
    End Sub
End Module
