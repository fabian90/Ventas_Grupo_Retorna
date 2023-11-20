Imports Ventas.capaEntidades
Imports Ventas.capaNegocio

Public Class FormRealizarVenta
    Private _gestorVentas As GestorVentas
    Private _ventaActual As List(Of VentaDetalle)
    Private _cantidadVenta As Integer
    Private gestorVentas As GestorVentas

    Public Sub New(gestorVentas As GestorVentas)
        InitializeComponent()
        _gestorVentas = gestorVentas
        _ventaActual = New List(Of VentaDetalle)()
        CargarProductos()
    End Sub

    Private Sub CargarProductos()
        cmbProductos.Items.Clear()
        Dim productos As List(Of Producto) = _gestorVentas.ObtenerListaProductos()
        For Each producto As Producto In productos
            cmbProductos.Items.Add($"{producto.Nombre} - ID: {producto.ID}")
        Next
        If cmbProductos.Items.Count > 0 Then
            cmbProductos.SelectedIndex = 0
        End If
    End Sub
    Private Sub btnAgregarVenta_Click(sender As Object, e As EventArgs) Handles btnAgregarVenta.Click
        If cmbProductos.SelectedItem IsNot Nothing Then
            Dim productoSeleccionado As String = cmbProductos.SelectedItem.ToString()
            Dim partes() As String = productoSeleccionado.Split({" - ID: "}, StringSplitOptions.RemoveEmptyEntries)
            Dim nombreProducto As String = partes(0)
            Dim idProducto As Integer

            If Integer.TryParse(partes(1), idProducto) Then

                Dim producto As Producto = _gestorVentas.ObtenerListaProductos().Find(Function(p) p.ID = idProducto)

                Dim cantidadTotalSolicitada As Integer = _ventaActual.
                    Where(Function(detalle) detalle.Producto.ID = producto.ID).
                    Sum(Function(detalle) detalle.Cantidad) + numCantidad.Value
                If producto IsNot Nothing Then
                    If numCantidad.Value > 0 Then
                        If producto.Stock >= cantidadTotalSolicitada Then
                            _ventaActual.Add(New VentaDetalle(producto, numCantidad.Value))
                            ActualizarVentaActual()
                        Else
                            MessageBox.Show("Error: La cantidad solicitada supera la existencia del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Error: La cantidad ingresada debe ser un número entero mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Error: No se encontró el producto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Error: ID de producto no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnEliminarVenta_Click(sender As Object, e As EventArgs) Handles btnEliminarVenta.Click
        If _ventaActual.Count > 0 Then
            If lstVentaActual.SelectedItem IsNot Nothing Then
                Dim indiceSeleccionado As Integer = lstVentaActual.SelectedIndex
                _ventaActual.RemoveAt(indiceSeleccionado)
                ActualizarVentaActual()
                MostrarVentaActual()
            Else
                MessageBox.Show("Por favor, selecciona un producto de la venta actual antes de intentar eliminarlo.", "Producto No Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("No hay productos en la venta. Agrega productos antes de realizar la venta.", "Venta Vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnActualizarCantidadVenta_Click(sender As Object, e As EventArgs) Handles btnActualizarVenta.Click
        If _ventaActual.Count > 0 Then
            If lstVentaActual.SelectedItem IsNot Nothing Then
                Dim indiceSeleccionado As Integer = lstVentaActual.SelectedIndex
                Dim nuevaCantidad As String = InputBox("Ingrese la nueva cantidad:", "Actualizar Cantidad", _ventaActual(indiceSeleccionado).Cantidad.ToString())
                If Integer.TryParse(nuevaCantidad, Nothing) AndAlso CInt(nuevaCantidad) > 0 Then
                    _ventaActual(indiceSeleccionado).Cantidad = CInt(nuevaCantidad)
                    ActualizarVentaActual()
                    MostrarVentaActual()
                Else
                    MessageBox.Show("Por favor, ingresa una cantidad válida mayor a cero.", "Cantidad Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Por favor, selecciona un producto de la venta actual antes de intentar actualizar la cantidad.", "Producto No Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("No hay productos en la venta. Agrega productos antes de realizar la venta.", "Venta Vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub lstVentaActual_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstVentaActual.SelectedIndexChanged
        If _ventaActual.Count > 0 AndAlso lstVentaActual.SelectedItem IsNot Nothing Then
            Dim indiceSeleccionado As Integer = lstVentaActual.SelectedIndex
            Dim detalleVentaSeleccionado As VentaDetalle = _ventaActual(indiceSeleccionado)
            cmbProductos.SelectedItem = detalleVentaSeleccionado.Producto
            numCantidad.Value = detalleVentaSeleccionado.Cantidad
        End If
    End Sub
    Private Sub ActualizarVentaActual()
        lstVentaActual.Items.Clear()
        Dim totalVenta As Decimal = 0

        For Each detalleVenta As VentaDetalle In _ventaActual
            Dim subtotal As Decimal = detalleVenta.Producto.Precio * detalleVenta.Cantidad
            lstVentaActual.Items.Add($"{detalleVenta.Producto.Nombre} - Cantidad: {detalleVenta.Cantidad}--Precio Neto: {detalleVenta.PrecioUnitario} - Subtotal: {subtotal.ToString("C")}")
            totalVenta += subtotal
        Next
        lblTotal.Text = $"Total: {totalVenta.ToString("C")}"
    End Sub
    Private Sub MostrarVentaActual()
        Dim totalVenta As Decimal = 0

        For Each detalleVenta As VentaDetalle In _ventaActual
            totalVenta += detalleVenta.TotalPorProducto
        Next

        lblTotal.Text = $"Total Venta Actual: {totalVenta:C}"
    End Sub
    Private Sub btnRealizarVenta_Click(sender As Object, e As EventArgs) Handles btnRealizarVenta.Click
        Try
            _gestorVentas.RealizarVenta(_ventaActual)
            _ventaActual.Clear()
            ActualizarVentaActual()
            LimpiarControles()
            _gestorVentas.EliminarProductosDelInventario(_ventaActual.Select(Function(detalle) detalle.Producto).ToList())

            For Each detalleVenta As VentaDetalle In _ventaActual
                _gestorVentas.ActualizarCantidadProducto(detalleVenta.Producto.ID, detalleVenta.Producto.Stock)
            Next
            _gestorVentas.EliminarProductosVendidos()
            Dim formularioInventario As FormInventario = CType(Application.OpenForms("FormInventario"), FormInventario)
            If formularioInventario IsNot Nothing Then
                formularioInventario.ActualizarListaProductos()
            End If
            MessageBox.Show("Venta realizada con éxito. Productos actualizados en el inventario.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarControles()
        cmbProductos.SelectedIndex = -1
        numCantidad.Value = 0
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        Dim formInventario As New FormInventario(_gestorVentas)
        formInventario.Show()
    End Sub

    Private Sub ArichivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArichivoToolStripMenuItem.Click
        Dim formRealizarVenta As New FormRealizarVenta(_gestorVentas)
        formRealizarVenta.Show()
    End Sub

    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedIndexChanged

    End Sub
End Class