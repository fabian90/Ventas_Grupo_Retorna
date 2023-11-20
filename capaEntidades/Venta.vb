Namespace capaEntidades
    Public Class Venta
        Public Property Producto As Producto
        Public Property CantidadVendida As Integer
        Public Property DetalleVenta As List(Of VentaDetalle)
        Public Property FechaVenta As Date
        Public Sub New()

        End Sub
        Public Sub New(detalleVenta As List(Of VentaDetalle))
            Me.DetalleVenta = detalleVenta
            Me.FechaVenta = Date.Now
        End Sub
    End Class
End Namespace