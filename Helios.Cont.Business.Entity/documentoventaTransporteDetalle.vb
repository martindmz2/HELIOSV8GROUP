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

Partial Public Class documentoventaTransporteDetalle
    Public Property idDocumento As Integer
    Public Property secuencia As Integer
    Public Property tipoExistencia As String
    Public Property destino As String
    Public Property tipo As String
    Public Property codigoBarraSerie As String
    Public Property detalle As String
    Public Property sku As String
    Public Property cantidad As Nullable(Of Decimal)
    Public Property unidadMedida As String
    Public Property importe As Nullable(Of Decimal)
    Public Property agencia_id As Nullable(Of Integer)
    Public Property estado As String
    Public Property manifiesto As String
    Public Property idDistribucion As Nullable(Of Integer)
    Public Property estadoDiustribucion As String
    Public Property usuarioActualizacion As Nullable(Of Integer)
    Public Property fechaActualizacion As Nullable(Of Date)

    Public Overridable Property documentoventaTransporte As documentoventaTransporte

End Class