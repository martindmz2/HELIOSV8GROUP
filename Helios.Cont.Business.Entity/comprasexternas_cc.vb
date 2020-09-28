'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class comprasexternas_cc
    Public Property idDocumento As Integer
    Public Property codigoLibro As String
    Public Property idEmpresa As String
    Public Property idCentroCosto As Nullable(Of Integer)
    Public Property origenCompra As String
    Public Property fechaContable As String
    Public Property tipoDoc As String
    Public Property fechaPagoEmision As Nullable(Of Date)
    Public Property aduana As String
    Public Property anioEmision As String
    Public Property numeroDoc As String
    Public Property idProveedor As String
    Public Property monedaDoc As String
    Public Property tasaIgv As Nullable(Of Decimal)
    Public Property tcDolLoc As Nullable(Of Decimal)
    Public Property bi01 As Nullable(Of Decimal)
    Public Property bi02 As Nullable(Of Decimal)
    Public Property bi03 As Nullable(Of Decimal)
    Public Property bi04 As Nullable(Of Decimal)
    Public Property isc01 As Nullable(Of Decimal)
    Public Property isc02 As Nullable(Of Decimal)
    Public Property isc03 As Nullable(Of Decimal)
    Public Property igv01 As Nullable(Of Decimal)
    Public Property igv02 As Nullable(Of Decimal)
    Public Property igv03 As Nullable(Of Decimal)
    Public Property otc01 As Nullable(Of Decimal)
    Public Property otc02 As Nullable(Of Decimal)
    Public Property otc03 As Nullable(Of Decimal)
    Public Property otc04 As Nullable(Of Decimal)
    Public Property bi01us As String
    Public Property bi02us As String
    Public Property bi03us As String
    Public Property bi04us As String
    Public Property isc01us As String
    Public Property isc02us As String
    Public Property isc03us As String
    Public Property igv01us As String
    Public Property igv02us As String
    Public Property igv03us As String
    Public Property otc01us As String
    Public Property otc02us As String
    Public Property otc03us As String
    Public Property otc04us As String
    Public Property importeSoles As Nullable(Of Decimal)
    Public Property importeDolares As Nullable(Of Decimal)
    Public Property estadoPago As String
    Public Property glosa As String
    Public Property usuarioActualizacion As String
    Public Property fechaActualizacion As Nullable(Of Date)

    Public Overridable Property compraexternadetalle As ICollection(Of compraexternadetalle) = New HashSet(Of compraexternadetalle)
    Public Overridable Property documento As documento

End Class