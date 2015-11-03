<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvArticulos = New System.Windows.Forms.DataGridView()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblArticulos = New System.Windows.Forms.Label()
        Me.cboComposicion = New System.Windows.Forms.ComboBox()
        Me.lblComposicion = New System.Windows.Forms.Label()
        Me.lblMedida = New System.Windows.Forms.Label()
        Me.cboMedida = New System.Windows.Forms.ComboBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cboOperacion = New System.Windows.Forms.ComboBox()
        Me.lblValidar = New System.Windows.Forms.Label()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvArticulos
        '
        Me.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArticulos.Location = New System.Drawing.Point(24, 126)
        Me.dgvArticulos.Name = "dgvArticulos"
        Me.dgvArticulos.Size = New System.Drawing.Size(655, 313)
        Me.dgvArticulos.TabIndex = 0
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(24, 76)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(103, 44)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(133, 76)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(103, 44)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(242, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 44)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Eliminar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblArticulos
        '
        Me.lblArticulos.AutoSize = True
        Me.lblArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArticulos.Location = New System.Drawing.Point(43, 9)
        Me.lblArticulos.Name = "lblArticulos"
        Me.lblArticulos.Size = New System.Drawing.Size(158, 29)
        Me.lblArticulos.TabIndex = 4
        Me.lblArticulos.Text = "ARTICULOS"
        '
        'cboComposicion
        '
        Me.cboComposicion.FormattingEnabled = True
        Me.cboComposicion.Location = New System.Drawing.Point(508, 6)
        Me.cboComposicion.Name = "cboComposicion"
        Me.cboComposicion.Size = New System.Drawing.Size(154, 21)
        Me.cboComposicion.TabIndex = 5
        '
        'lblComposicion
        '
        Me.lblComposicion.AutoSize = True
        Me.lblComposicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComposicion.Location = New System.Drawing.Point(328, 7)
        Me.lblComposicion.Name = "lblComposicion"
        Me.lblComposicion.Size = New System.Drawing.Size(169, 16)
        Me.lblComposicion.TabIndex = 6
        Me.lblComposicion.Text = "Filtrar por Composicion"
        '
        'lblMedida
        '
        Me.lblMedida.AutoSize = True
        Me.lblMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedida.Location = New System.Drawing.Point(363, 34)
        Me.lblMedida.Name = "lblMedida"
        Me.lblMedida.Size = New System.Drawing.Size(131, 16)
        Me.lblMedida.TabIndex = 8
        Me.lblMedida.Text = "Filtrar por Medida"
        '
        'cboMedida
        '
        Me.cboMedida.FormattingEnabled = True
        Me.cboMedida.Location = New System.Drawing.Point(508, 33)
        Me.cboMedida.Name = "cboMedida"
        Me.cboMedida.Size = New System.Drawing.Size(154, 21)
        Me.cboMedida.TabIndex = 7
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(371, 77)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(124, 16)
        Me.lblPrecio.TabIndex = 9
        Me.lblPrecio.Text = "Filtrar por Precio"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(540, 76)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(78, 20)
        Me.txtPrecio.TabIndex = 10
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(624, 76)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(55, 19)
        Me.btnBuscar.TabIndex = 11
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'cboOperacion
        '
        Me.cboOperacion.FormattingEnabled = True
        Me.cboOperacion.Items.AddRange(New Object() {">", "=", "<"})
        Me.cboOperacion.Location = New System.Drawing.Point(500, 75)
        Me.cboOperacion.Name = "cboOperacion"
        Me.cboOperacion.Size = New System.Drawing.Size(34, 21)
        Me.cboOperacion.TabIndex = 12
        '
        'lblValidar
        '
        Me.lblValidar.AutoSize = True
        Me.lblValidar.ForeColor = System.Drawing.Color.Red
        Me.lblValidar.Location = New System.Drawing.Point(537, 59)
        Me.lblValidar.Name = "lblValidar"
        Me.lblValidar.Size = New System.Drawing.Size(100, 13)
        Me.lblValidar.TabIndex = 13
        Me.lblValidar.Text = "Solo admite enteros"
        Me.lblValidar.Visible = False
        '
        'frmArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 472)
        Me.Controls.Add(Me.lblValidar)
        Me.Controls.Add(Me.cboOperacion)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblMedida)
        Me.Controls.Add(Me.cboMedida)
        Me.Controls.Add(Me.lblComposicion)
        Me.Controls.Add(Me.cboComposicion)
        Me.Controls.Add(Me.lblArticulos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgvArticulos)
        Me.Name = "frmArticulos"
        Me.Text = "Articulos"
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblArticulos As System.Windows.Forms.Label
    Friend WithEvents cboComposicion As System.Windows.Forms.ComboBox
    Friend WithEvents lblComposicion As System.Windows.Forms.Label
    Friend WithEvents lblMedida As System.Windows.Forms.Label
    Friend WithEvents cboMedida As System.Windows.Forms.ComboBox
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents cboOperacion As System.Windows.Forms.ComboBox
    Friend WithEvents lblValidar As System.Windows.Forms.Label

End Class
