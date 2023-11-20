Namespace capaEntidades

    Public Class VentaDetalle
        Public Property Producto As Producto
        Public Property Cantidad As Integer
        Public ReadOnly Property PrecioUnitario As Decimal
            Get
                Return Producto.Precio
            End Get
        End Property
        Public ReadOnly Property TotalPorProducto As Decimal
            Get
                Return Cantidad * PrecioUnitario
            End Get
        End Property

        Public Sub New(producto As Producto, cantidad As Integer)
            Me.Producto = producto
            Me.Cantidad = cantidad
        End Sub
    End Class
End Namespace
