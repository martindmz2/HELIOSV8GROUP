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

Partial Public Class documentoAnticipoDetalle
    Public Property idDocumento As Integer
    Public Property secuencia As Integer
    Public Property idEmpresa As String
    Public Property idEstablecimiento As Integer
    Public Property codigoOperacion As String
    Public Property descripcion As String
    Public Property importeMN As Nullable(Of Decimal)
    Public Property importeME As Nullable(Of Decimal)
    Public Property docAfectado As Nullable(Of Integer)
    Public Property documentoAfectado As Nullable(Of Integer)
    Public Property documentoAfectadodetalle As Nullable(Of Integer)
    Public Property montoSolesRef As Nullable(Of Decimal)
    Public Property montoUsdRef As Nullable(Of Decimal)
    Public Property idAnticipo As String
    Public Property DetalleItem As String
    Public Property estadoAnticipo As String
    Public Property entregado As String
    Public Property fecha As Nullable(Of Date)
    Public Property diferTipoCambio As Nullable(Of Decimal)
    Public Property idCajaUsuario As Nullable(Of Integer)
    Public Property usuarioModificacion As String
    Public Property fechaActualizacion As Nullable(Of Date)

    Public Overridable Property documentoAnticipo As documentoAnticipo

End Class