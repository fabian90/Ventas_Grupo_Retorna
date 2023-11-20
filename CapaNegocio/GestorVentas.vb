Imports System.Collections.Generic
Imports Ventas.capaEntidades

Namespace capaNegocio
    Public Class GestorVentas
        Private _listaProductos As List(Of Producto)
        Private _ventasRealizadas As List(Of Venta)

        Public Sub New()
            _listaProductos = New List(Of Producto)
            _ventasRealizadas = New List(Of Venta)
        End Sub

        Public Sub AgregarProducto(producto As Producto)
            ' Agregar un producto a la lista
            _listaProductos.Add(producto)
        End Sub
        Public Function ObtenerListaProductos() As List(Of Producto)
            Return _listaProductos
        End Function
        Public Sub EliminarProducto(idProducto As Integer)
            Dim productoAEliminar = _listaProductos.FirstOrDefault(Function(p) p.ID = idProducto)
            If productoAEliminar IsNot Nothing Then
                _listaProductos.Remove(productoAEliminar)
            End If
        End Sub

        Public Sub ActualizarCantidadProducto(idProducto As Integer, nuevaCantidad As Integer)
            Dim productoAActualizar = _listaProductos.FirstOrDefault(Function(p) p.ID = idProducto)
            If productoAActualizar IsNot Nothing Then
                productoAActualizar.Stock = nuevaCantidad
            End If
        End Sub

        Public Function ProductoExiste(idProducto As Integer) As Boolean
            Return _listaProductos.Any(Function(p) p.ID = idProducto)
        End Function
        Public Function ObtenerProductos() As List(Of Producto)
            Return New List(Of Producto)(_listaProductos)
        End Function
        Public Sub RealizarVenta(detalleVentas As List(Of VentaDetalle))
            For Each detalleVenta As VentaDetalle In detalleVentas
                Dim producto As Producto = detalleVenta.Producto
                If producto.Stock >= detalleVenta.Cantidad Then
                    ' Actualizar el stock del producto
                    producto.Stock -= detalleVenta.Cantidad
                    Dim venta As New Venta With {
                        .Producto = producto,
                        .CantidadVendida = detalleVenta.Cantidad
                    }
                Else
                    Throw New InvalidOperationException($"No hay suficiente stock para el producto '{producto.Nombre}'.")
                End If
            Next
        End Sub

        Public Sub EliminarProductosDelInventario(productosAEliminar As List(Of Producto))
            For Each productoAEliminar As Producto In productosAEliminar
                Dim productoEnInventario As Producto = _listaProductos.FirstOrDefault(Function(p) p.ID = productoAEliminar.ID)

                If productoEnInventario IsNot Nothing Then
                    _listaProductos.Remove(productoEnInventario)
                End If
            Next
        End Sub
        Public Sub EliminarProductosVendidos()
            _listaProductos = _listaProductos.Where(Function(p) p.Stock > 0).ToList()
        End Sub

        Public Function ObtenerTotalVentas() As Decimal
            Return _ventasRealizadas.Sum(Function(v) v.Producto.Precio * v.CantidadVendida)
        End Function
    End Class
End Namespace
