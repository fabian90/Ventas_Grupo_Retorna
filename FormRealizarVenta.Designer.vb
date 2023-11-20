<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRealizarVenta
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
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.lblProductos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numCantidad = New System.Windows.Forms.NumericUpDown()
        Me.lstVentaActual = New System.Windows.Forms.ListBox()
        Me.btnRealizarVenta = New System.Windows.Forms.Button()
        Me.btnAgregarVenta = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnActualizarVenta = New System.Windows.Forms.Button()
        Me.btnEliminarVenta = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArichivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.numCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbProductos
        '
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(87, 36)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(238, 28)
        Me.cmbProductos.TabIndex = 0
        '
        'lblProductos
        '
        Me.lblProductos.AutoSize = True
        Me.lblProductos.Location = New System.Drawing.Point(6, 44)
        Me.lblProductos.Name = "lblProductos"
        Me.lblProductos.Size = New System.Drawing.Size(75, 20)
        Me.lblProductos.TabIndex = 1
        Me.lblProductos.Text = "Productos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(346, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cantidad"
        '
        'numCantidad
        '
        Me.numCantidad.Location = New System.Drawing.Point(432, 37)
        Me.numCantidad.Name = "numCantidad"
        Me.numCantidad.Size = New System.Drawing.Size(150, 27)
        Me.numCantidad.TabIndex = 3
        '
        'lstVentaActual
        '
        Me.lstVentaActual.FormattingEnabled = True
        Me.lstVentaActual.ItemHeight = 20
        Me.lstVentaActual.Location = New System.Drawing.Point(24, 216)
        Me.lstVentaActual.Name = "lstVentaActual"
        Me.lstVentaActual.Size = New System.Drawing.Size(588, 184)
        Me.lstVentaActual.TabIndex = 4
        '
        'btnRealizarVenta
        '
        Me.btnRealizarVenta.Location = New System.Drawing.Point(242, 454)
        Me.btnRealizarVenta.Name = "btnRealizarVenta"
        Me.btnRealizarVenta.Size = New System.Drawing.Size(125, 29)
        Me.btnRealizarVenta.TabIndex = 5
        Me.btnRealizarVenta.Text = "Realizar Venta"
        Me.btnRealizarVenta.UseVisualStyleBackColor = True
        '
        'btnAgregarVenta
        '
        Me.btnAgregarVenta.Location = New System.Drawing.Point(73, 108)
        Me.btnAgregarVenta.Name = "btnAgregarVenta"
        Me.btnAgregarVenta.Size = New System.Drawing.Size(125, 29)
        Me.btnAgregarVenta.TabIndex = 6
        Me.btnAgregarVenta.Text = "Agregar"
        Me.btnAgregarVenta.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnActualizarVenta)
        Me.GroupBox1.Controls.Add(Me.btnEliminarVenta)
        Me.GroupBox1.Controls.Add(Me.numCantidad)
        Me.GroupBox1.Controls.Add(Me.btnAgregarVenta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblProductos)
        Me.GroupBox1.Controls.Add(Me.cmbProductos)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 153)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ventas"
        '
        'btnActualizarVenta
        '
        Me.btnActualizarVenta.Location = New System.Drawing.Point(237, 108)
        Me.btnActualizarVenta.Name = "btnActualizarVenta"
        Me.btnActualizarVenta.Size = New System.Drawing.Size(125, 29)
        Me.btnActualizarVenta.TabIndex = 8
        Me.btnActualizarVenta.Text = "Actualizar"
        Me.btnActualizarVenta.UseVisualStyleBackColor = True
        '
        'btnEliminarVenta
        '
        Me.btnEliminarVenta.Location = New System.Drawing.Point(391, 108)
        Me.btnEliminarVenta.Name = "btnEliminarVenta"
        Me.btnEliminarVenta.Size = New System.Drawing.Size(125, 29)
        Me.btnEliminarVenta.TabIndex = 7
        Me.btnEliminarVenta.Text = "Eliminar"
        Me.btnEliminarVenta.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventarioToolStripMenuItem, Me.ArichivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(644, 28)
        Me.MenuStrip1.TabIndex = 8
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
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(439, 417)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 20)
        Me.lblTotal.TabIndex = 11
        '
        'FormRealizarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 495)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRealizarVenta)
        Me.Controls.Add(Me.lstVentaActual)
        Me.Name = "FormRealizarVenta"
        Me.Text = "FormRealizarVenta"
        CType(Me.numCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents lblProductos As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents numCantidad As NumericUpDown
    Friend WithEvents lstVentaActual As ListBox
    Friend WithEvents btnRealizarVenta As Button
    Friend WithEvents btnAgregarVenta As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEliminarVenta As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArichivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnActualizarVenta As Button
    Friend WithEvents lblTotal As Label
End Class
