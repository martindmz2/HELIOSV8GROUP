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

Partial Public Class servicioInfraestructura
    Public Property idServicioInfraestructura As Integer
    Public Property idEmpresa As String
    Public Property idEstablecimiento As Nullable(Of Integer)
    Public Property descripcionServicio As String
    Public Property tipoServicio As String
    Public Property usuarioModificacion As String
    Public Property fechaModificacion As Nullable(Of Date)

    Public Overridable Property ruta_HorarioServicios As ICollection(Of ruta_HorarioServicios) = New HashSet(Of ruta_HorarioServicios)
    Public Overridable Property servicioInfraestructuraDet As ICollection(Of servicioInfraestructuraDet) = New HashSet(Of servicioInfraestructuraDet)

End Class