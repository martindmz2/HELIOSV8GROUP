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

Partial Public Class centrocosto
    Public Property idEmpresa As String
    Public Property idCentroCosto As Integer
    Public Property nombre As String
    Public Property TipoEstab As String
    Public Property ubigeo As String
    Public Property otrasReferencias As String
    Public Property idpadre As Nullable(Of Integer)
    Public Property IDProducto As Nullable(Of Integer)
    Public Property predeterminada As Nullable(Of Boolean)
    Public Property direccion As String
    Public Property telefono As String
    Public Property telefono2 As String
    Public Property detalleAdicional As String
    Public Property nroOrganizacion As Nullable(Of Integer)
    Public Property tipo As String
    Public Property tipoOrganizacion As String
    Public Property estado As String
    Public Property tipoSegmento As String
    Public Property nivel As Nullable(Of Integer)
    Public Property usuarioActualizacion As String
    Public Property fechaActualizacion As Nullable(Of Date)

    Public Overridable Property almacen As ICollection(Of almacen) = New HashSet(Of almacen)
    Public Overridable Property empresa As empresa
    Public Overridable Property centroCostoHorario As ICollection(Of centroCostoHorario) = New HashSet(Of centroCostoHorario)
    Public Overridable Property centroCostosXNComercial As ICollection(Of centroCostosXNComercial) = New HashSet(Of centroCostosXNComercial)
    Public Overridable Property configuracionInicio As configuracionInicio
    Public Overridable Property empresaCierreMensual As ICollection(Of empresaCierreMensual) = New HashSet(Of empresaCierreMensual)
    Public Overridable Property empresaPeriodo As ICollection(Of empresaPeriodo) = New HashSet(Of empresaPeriodo)
    Public Overridable Property jerarquia As ICollection(Of jerarquia) = New HashSet(Of jerarquia)
    Public Overridable Property perfilAnexo As ICollection(Of perfilAnexo) = New HashSet(Of perfilAnexo)

End Class