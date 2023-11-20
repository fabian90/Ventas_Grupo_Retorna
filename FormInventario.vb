Imports System.IO
Imports System.Xml.Serialization
Imports Ventas.capaEntidades
Imports Ventas.capaNegocio

Public Class FormInventario


    Private _gestorVentas As GestorVentas

    Public Sub New(gestorVentas As GestorVentas)
        InitializeComponent()
        _gestorVentas = gestorVentas
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        ProcesarProducto()
    End Sub

    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click
        If lstMostrarProductos.SelectedItem IsNot Nothing Then
            Dim idProductoSeleccionado As Integer = ObtenerIdProductoDesdeItem(lstMostrarProductos.SelectedItem.ToString())
            _gestorVentas.EliminarProducto(idProductoSeleccionado)
            LimpiarControles()
            MostrarProductosEnListBox()
        Else
            MessageBox.Show("Por favor, selecciona un producto de la lista antes de intentar eliminarlo.", "Producto No Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnActualizarCantidad_Click(sender As Object, e As EventArgs) Handles btnActualizarCantidad.Click
        ProcesarProducto()
    End Sub
    Private Sub lstMostrarProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMostrarProductos.SelectedIndexChanged
        If lstMostrarProductos.SelectedItem IsNot Nothing Then
            Dim idProductoSeleccionado As Integer = ObtenerIdProductoDesdeItem(lstMostrarProductos.SelectedItem.ToString())
            Dim productoSeleccionado As Producto = _gestorVentas.ObtenerProductos().FirstOrDefault(Function(p) p.ID = idProductoSeleccionado)
            numIdProducto.Text = productoSeleccionado.ID.ToString()
            txtNombreProducto.Text = productoSeleccionado.Nombre
            numPrecioProducto.Value = productoSeleccionado.Precio
            numStockProducto.Value = productoSeleccionado.Stock
        End If
    End Sub
    Private Sub ProcesarProducto()
        If ValidarEntrada() Then
            Dim nuevoProducto As Producto = ObtenerProductoDesdeControles()
            Dim productoExistente As Producto = _gestorVentas.ObtenerProductos().FirstOrDefault(Function(p) p.ID = nuevoProducto.ID)

            If productoExistente IsNot Nothing Then
                If btnActualizarCantidad.Focused Then
                    Dim cantidadNueva As Integer = CInt(numStockProducto.Value)
                    _gestorVentas.ActualizarCantidadProducto(nuevoProducto.ID, cantidadNueva)
                Else
                    MessageBox.Show("El ID del producto ya existe. Por favor, elige un ID único o utiliza la opción 'Actualizar Cantidad'.", "ID Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            Else
                _gestorVentas.AgregarProducto(nuevoProducto)
            End If

            LimpiarControles()
            MostrarProductosEnListBox()
        Else
            MessageBox.Show("Por favor, completa todos los campos correctamente.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub MostrarProductosEnListBox()
        lstMostrarProductos.Items.Clear()
        Dim productos = _gestorVentas.ObtenerProductos()
        For Each producto In productos
            lstMostrarProductos.Items.Add($"ID: {producto.ID}, Nombre: {producto.Nombre}, Precio: {producto.Precio:C}, Stock: {producto.Stock}")
        Next
    End Sub

    Private Sub LimpiarControles()
        numIdProducto.Value = 0
        txtNombreProducto.Clear()
        numPrecioProducto.Value = 0
        numStockProducto.Value = 0
    End Sub

    Private Function ValidarEntrada() As Boolean
        Return Not String.IsNullOrEmpty(numIdProducto.Text) AndAlso Not String.IsNullOrEmpty(txtNombreProducto.Text)
    End Function

    Private Function ObtenerProductoDesdeControles() As Producto
        Dim idProducto As Integer = CInt(numIdProducto.Text)
        Dim nombreProducto As String = txtNombreProducto.Text
        Dim precioProducto As Decimal = CDec(numPrecioProducto.Value)
        Dim stockProducto As Integer = CInt(numStockProducto.Value)

        Return New Producto With {
            .ID = idProducto,
            .Nombre = nombreProducto,
            .Precio = precioProducto,
            .Stock = stockProducto
        }
    End Function

    Private Function ObtenerIdProductoDesdeItem(item As String) As Integer
        Dim idParte As String = item.Split(","c)(0)
        Return Convert.ToInt32(idParte.Split(":"c)(1).Trim())
    End Function
    Public Sub ActualizarListaProductos()
        Dim listaProductos As List(Of Producto) = _gestorVentas.ObtenerListaProductos()
        lstMostrarProductos.Items.Clear()
        For Each producto As Producto In listaProductos
            lstMostrarProductos.Items.Add($"{producto.Nombre} - Precio: {producto.Precio.ToString("C")} - Stock: {producto.Stock}")
        Next
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        Dim formInventario As New FormInventario(_gestorVentas)
        formInventario.Show()
    End Sub

    Private Sub ArichivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArichivoToolStripMenuItem.Click
        Dim formRealizarVenta As New FormRealizarVenta(_gestorVentas)
        formRealizarVenta.Show()
    End Sub
End Class