<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.dgvDecodificado = New System.Windows.Forms.DataGridView()
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.dgvCodificado = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvDecodificado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCodificado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDecodificado
        '
        Me.dgvDecodificado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDecodificado.Location = New System.Drawing.Point(32, 138)
        Me.dgvDecodificado.Name = "dgvDecodificado"
        Me.dgvDecodificado.Size = New System.Drawing.Size(418, 309)
        Me.dgvDecodificado.TabIndex = 0
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(297, 22)
        Me.txtTexto.MaxLength = 100
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(278, 73)
        Me.txtTexto.TabIndex = 2
        '
        'dgvCodificado
        '
        Me.dgvCodificado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCodificado.Location = New System.Drawing.Point(476, 138)
        Me.dgvCodificado.Name = "dgvCodificado"
        Me.dgvCodificado.Size = New System.Drawing.Size(418, 309)
        Me.dgvCodificado.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Texto:"
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(600, 23)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(104, 40)
        Me.btnMostrar.TabIndex = 5
        Me.btnMostrar.Text = "MOSTRAR"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Texto Ajustado sin codificar:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(473, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Texto Ajustado Codificado:"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 544)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCodificado)
        Me.Controls.Add(Me.txtTexto)
        Me.Controls.Add(Me.dgvDecodificado)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        CType(Me.dgvDecodificado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCodificado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDecodificado As System.Windows.Forms.DataGridView
    Friend WithEvents txtTexto As System.Windows.Forms.TextBox
    Friend WithEvents dgvCodificado As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
