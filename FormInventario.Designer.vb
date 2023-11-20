<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInventario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpAgregarProducto = New System.Windows.Forms.GroupBox()
        Me.btnActualizarCantidad = New System.Windows.Forms.Button()
        Me.numIdProducto = New System.Windows.Forms.NumericUpDown()
        Me.numStockProducto = New System.Windows.Forms.NumericUpDown()
        Me.numPrecioProducto = New System.Windows.Forms.NumericUpDown()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblAgregar = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstMostrarProductos = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArichivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpAgregarProducto.SuspendLayout()
        CType(Me.numIdProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numStockProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrecioProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAgregarProducto
        '
        Me.grpAgregarProducto.Controls.Add(Me.btnActualizarCantidad)
        Me.grpAgregarProducto.Controls.Add(Me.numIdProducto)
        Me.grpAgregarProducto.Controls.Add(Me.numStockProducto)
        Me.grpAgregarProducto.Controls.Add(Me.numPrecioProducto)
        Me.grpAgregarProducto.Controls.Add(Me.btnEliminarProducto)
        Me.grpAgregarProducto.Controls.Add(Me.btnAgregarProducto)
        Me.grpAgregarProducto.Controls.Add(Me.txtNombreProducto)
        Me.grpAgregarProducto.Controls.Add(Me.Label1)
        Me.grpAgregarProducto.Controls.Add(Me.lblPrecio)
        Me.grpAgregarProducto.Controls.Add(Me.lblNombre)
        Me.grpAgregarProducto.Controls.Add(Me.lblAgregar)
        Me.grpAgregarProducto.Location = New System.Drawing.Point(106, 31)
        Me.grpAgregarProducto.Name = "grpAgregarProducto"
        Me.grpAgregarProducto.Size = New System.Drawing.Size(594, 216)
        Me.grpAgregarProducto.TabIndex = 0
        Me.grpAgregarProducto.TabStop = False
        Me.grpAgregarProducto.Text = "Agregar Producto"
        '
        'btnActualizarCantidad
        '
        Me.btnActualizarCantidad.Location = New System.Drawing.Point(236, 171)
        Me.btnActualizarCantidad.Name = "btnActualizarCantidad"
        Me.btnActualizarCantidad.Size = New System.Drawing.Size(94, 29)
        Me.btnActualizarCantidad.TabIndex = 13
        Me.btnActualizarCantidad.Text = "Actualizar"
        Me.btnActualizarCantidad.UseVisualStyleBackColor = True
        '
        'numIdProducto
        '
        Me.numIdProducto.Location = New System.Drawing.Point(96, 44)
        Me.numIdProducto.Name = "numIdProducto"
        Me.numIdProducto.Size = New System.Drawing.Size(132, 27)
        Me.numIdProducto.TabIndex = 12
        '
        'numStockProducto
        '
        Me.numStockProducto.Location = New System.Drawing.Point(326, 107)
        Me.numStockProducto.Name = "numStockProducto"
        Me.numStockProducto.Size = New System.Drawing.Size(158, 27)
        Me.numStockProducto.TabIndex = 11
        '
        'numPrecioProducto
        '
        Me.numPrecioProducto.Location = New System.Drawing.Point(96, 107)
        Me.numPrecioProducto.Name = "numPrecioProducto"
        Me.numPrecioProducto.Size = New System.Drawing.Size(132, 27)
        Me.numPrecioProducto.TabIndex = 10
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.Location = New System.Drawing.Point(349, 171)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(94, 29)
        Me.btnEliminarProducto.TabIndex = 9
        Me.btnEliminarProducto.Text = "Eliminar"
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Location = New System.Drawing.Point(116, 171)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(94, 29)
        Me.btnAgregarProducto.TabIndex = 8
        Me.btnAgregarProducto.Text = "Agregar"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(324, 45)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(210, 27)
        Me.txtNombreProducto.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(245, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Stock"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(6, 109)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(50, 20)
        Me.lblPrecio.TabIndex = 2
        Me.lblPrecio.Text = "Precio"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(245, 46)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(64, 20)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'lblAgregar
        '
        Me.lblAgregar.AutoSize = True
        Me.lblAgregar.Location = New System.Drawing.Point(6, 46)
        Me.lblAgregar.Name = "lblAgregar"
        Me.lblAgregar.Size = New System.Drawing.Size(24, 20)
        Me.lblAgregar.TabIndex = 0
        Me.lblAgregar.Text = "ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstMostrarProductos)
        Me.GroupBox1.Location = New System.Drawing.Point(66, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(679, 300)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de productos"
        '
        'lstMostrarProductos
        '
        Me.lstMostrarProductos.BackColor = System.Drawing.SystemColors.Info
        Me.lstMostrarProductos.FormattingEnabled = True
        Me.lstMostrarProductos.ItemHeight = 20
        Me.lstMostrarProductos.Location = New System.Drawing.Point(40, 45)
        Me.lstMostrarProductos.Name = "lstMostrarProductos"
        Me.lstMostrarProductos.Size = New System.Drawing.Size(594, 204)
        Me.lstMostrarProductos.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventarioToolStripMenuItem, Me.ArichivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(787, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'ArichivoToolStripMenuItem
        '
        Me.ArichivoToolStripMenuItem.Name = "ArichivoToolStripMenuItem"
        Me.ArichivoToolStripMenuItem.Size = New System.Drawing.Size(123, 24)
        Me.ArichivoToolStripMenuItem.Text = "Realizar Ventas"
        '
        'FormInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 645)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpAgregarProducto)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormInventario"
        Me.Text = "Inventario"
        Me.grpAgregarProducto.ResumeLayout(False)
        Me.grpAgregarProducto.PerformLayout()
        CType(Me.numIdProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numStockProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrecioProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpAgregarProducto As GroupBox
    Friend WithEvents lblAgregar As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents lstMostrarProductos As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArichivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents numStockProducto As NumericUpDown
    Friend WithEvents numPrecioProducto As NumericUpDown
    Friend WithEvents numIdProducto As NumericUpDown
    Friend WithEvents btnActualizarCantidad As Button
End Class
