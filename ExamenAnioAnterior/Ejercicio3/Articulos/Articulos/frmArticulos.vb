Public Class frmArticulos
    Dim search As ConnectDB
    Dim data As DataSet

    Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        'Rellenamos composiciones

        Dim sSql As String = "Select distinct idcomposicion, composicion from composiciones,articulos" & _
                             " where composiciones.idcomposicion=articulos.refcomposicion and eliminado=-1 order by composicion"
        Dim sinicio As String = "-- Elige Composicion --"
        rellenacombobox(cboComposicion, sSql, sinicio)

        search = New ConnectDB
        data = New DataSet

        actualizardgv()
       
    End Sub

    Sub actualizardgv()

        data = search.getData("Select idarticulo,idcomposicion,idmedida,composicion,medida,precio from articulos,composiciones, medidas" & _
                             " where composiciones.idcomposicion=articulos.refcomposicion and" & _
                             " medidas.idmedida=articulos.refmedida and eliminado=-1 order by idarticulo", "tdata")

        Dim tarticulos As DataTable = data.Tables("tdata")

        estilodgv2(dgvArticulos)

        dgvArticulos.DataSource = tarticulos

        dgvArticulos.Columns(0).Visible = False
        dgvArticulos.Columns(1).Visible = False
        dgvArticulos.Columns(2).Visible = False

    End Sub

    Private Sub cboComposicion_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboComposicion.SelectionChangeCommitted



        data = search.getData("Select idarticulo,idcomposicion,idmedida,composicion,medida,precio from articulos,composiciones, medidas" & _
                            " where composiciones.idcomposicion=articulos.refcomposicion and" & _
                            " medidas.idmedida=articulos.refmedida and eliminado=-1 and composiciones.composicion = '" & cboComposicion.SelectedText & "' order by idarticulo", "tdata")
        ' CARGAR EN CBOMEDIDA LAS MEDIDAS EXISTENTES PARA LA COMPOSICION SELECCIONADA
        ' Y

        Dim tarticulos As DataTable = data.Tables("tdata")

        estilodgv2(dgvArticulos)

        dgvArticulos.DataSource = tarticulos

        dgvArticulos.Columns(0).Visible = False
        dgvArticulos.Columns(1).Visible = False
        dgvArticulos.Columns(2).Visible = False
        Dim sSql As String = "Select distinct idmedida, medida from medidas,articulos" & _
                             " where medidas.idmedida=articulos.refmedida and articulos.refcompos in (select composicion from composiciones where articulos.refmedida = medidas.idmedida) eliminado=-1 order by composicion"
        Dim sinicio As String = "-- Elige Medida --"
        rellenacombobox(cboComposicion, sSql, sinicio)


        ' FILTRAR EL DATAGRIDVIEW CON LOS ARTICULOS CORRESPONDIENTES A LA COMPOSICION SELECCIONADA
    End Sub

    Private Sub cboMedida_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMedida.SelectionChangeCommitted
        ' FILTRAR EL DATAGRIDVIEW CON LOS ARTICULOS CORRESPONDIENTES A LA COMPOSICION Y MEDIDA SELECCIONADA


        Dim composicion As String = cboComposicion.Text ' Nombre de la composicion
        Dim medida As String = cboMedida.Text
        data = search.getData("Select idarticulo,idcomposicion,idmedida,composicion,medida,precio from articulos,composiciones, medidas" & _
                            " where composiciones.idcomposicion=articulos.refcomposicion and" & _
                            " medidas.idmedida=articulos.refmedida and eliminado=-1 and medidas.medida = '" & medida & "'  and composiciones.composicion = '" & composicion & "' order by idarticulo", "tdata")

        ' CARGAR EN CBOMEDIDA LAS MEDIDAS EXISTENTES PARA LA COMPOSICION SELECCIONADA
        ' Y


        Dim tarticulos As DataTable = data.Tables("tdata")

        estilodgv2(dgvArticulos)

        dgvArticulos.DataSource = tarticulos

        dgvArticulos.Columns(0).Visible = False
        dgvArticulos.Columns(1).Visible = False
        dgvArticulos.Columns(2).Visible = False

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ' FILTRAR EL DATAGRIDVIEW CON LOS ARTICULOS CUYO PRECIO SEA MAYOR, IGUAL O MENOR AL INDICADO EN LA CAJA DE TEXTO TXTPRECIO
        Dim precio As String = txtPrecio.Text
        Dim precioInt As Integer = 0
        Try
            precioInt = CInt(precio)
        Catch ex As Exception
            MsgBox("Introduce un número entero")
        End Try

        If cboOperacion.Text = ">" Then
            data = search.getData("Select idarticulo,idcomposicion,idmedida,composicion,medida,precio from articulos,composiciones, medidas" & _
                             " where composiciones.idcomposicion=articulos.refcomposicion and" & _
                             " medidas.idmedida=articulos.refmedida and eliminado=-1 and articulos.precio > '" & precioInt & "' order by idarticulo", "tdata")
        ElseIf cboOperacion.Text = "<" Then
            data = search.getData("Select idarticulo,idcomposicion,idmedida,composicion,medida,precio from articulos,composiciones, medidas" & _
                             " where composiciones.idcomposicion=articulos.refcomposicion and" & _
                             " medidas.idmedida=articulos.refmedida and eliminado=-1 and articulos.precio < '" & precioInt & "' order by idarticulo", "tdata")
        ElseIf cboOperacion.Text = "=" Then
            data = search.getData("Select idarticulo,idcomposicion,idmedida,composicion,medida,precio from articulos,composiciones, medidas" & _
                                 " where composiciones.idcomposicion=articulos.refcomposicion and" & _
                                 " medidas.idmedida=articulos.refmedida and eliminado=-1 and articulos.precio = '" & precioInt & "' order by idarticulo", "tdata")
        End If

        Dim tarticulos As DataTable = data.Tables("tdata")

        estilodgv2(dgvArticulos)

        dgvArticulos.DataSource = tarticulos

        dgvArticulos.Columns(0).Visible = False
        dgvArticulos.Columns(1).Visible = False
        dgvArticulos.Columns(2).Visible = False

    End Sub



    Public Sub validarNumero(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal lbl As Label)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
            lbl.Visible = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            lbl.Visible = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
            lbl.Visible = False
        Else
            e.Handled = True
            lbl.Visible = True
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio.KeyPress
        validarNumero(e, lblValidar)
    End Sub
End Class
