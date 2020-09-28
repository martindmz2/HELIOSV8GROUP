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

Partial Public Class documentoVentaExterna_sc
    Public Property idDocumento As Integer
    Public Property codigoLibro As String
    Public Property idEmpresa As String
    Public Property idEstablecimiento As Nullable(Of Integer)
    Public Property fechaDoc As Nullable(Of Date)
    Public Property fechaVcto As Nullable(Of Date)
    Public Property fechaContable As String
    Public Property origenVenta As String
    Public Property serie As String
    Public Property numeroDoc As String
    Public Property idCliente As String
    Public Property monedaDoc As String
    Public Property tasaIgv As Nullable(Of Decimal)
    Public Property tcDolLoc As Nullable(Of Decimal)
    Public Property tipoRecaudo As String
    Public Property regimen As String
    Public Property tasaRegimen As Nullable(Of Decimal)
    Public Property nroRegimen As String
    Public Property bi01 As Nullable(Of Decimal)
    Public Property bi02 As Nullable(Of Decimal)
    Public Property isc01 As Nullable(Of Decimal)
    Public Property isc02 As Nullable(Of Decimal)
    Public Property igv01 As Nullable(Of Decimal)
    Public Property igv02 As Nullable(Of Decimal)
    Public Property otc01 As Nullable(Of Decimal)
    Public Property otc02 As Nullable(Of Decimal)
    Public Property bi01us As Nullable(Of Decimal)
    Public Property bi02us As Nullable(Of Decimal)
    Public Property isc01us As Nullable(Of Decimal)
    Public Property isc02us As Nullable(Of Decimal)
    Public Property igv01us As Nullable(Of Decimal)
    Public Property igv02us As Nullable(Of Decimal)
    Public Property otc01us As Nullable(Of Decimal)
    Public Property otc02us As Nullable(Of Decimal)
    Public Property importeTotal As Nullable(Of Decimal)
    Public Property importeUS As Nullable(Of Decimal)
    Public Property estadoCobro As String
    Public Property glosa As String
    Public Property usuarioActualizacion As String
    Public Property fechaActualizacion As Nullable(Of Date)

    Public Overridable Property documento As documento
    Public Overridable Property documentoVentaExternaDetalle_sc As ICollection(Of documentoVentaExternaDetalle_sc) = New HashSet(Of documentoVentaExternaDetalle_sc)

End Class