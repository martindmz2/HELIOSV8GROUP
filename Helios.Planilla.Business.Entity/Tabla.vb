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

Partial Public Class Tabla
    Public Property IDTabla As Integer
    Public Property IDSunat As Nullable(Of Integer)
    Public Property DescripcionCorta As String
    Public Property DescripcionLarga As String
    Public Property Estado As Nullable(Of Boolean)
    Public Property UsuarioModificacion As String
    Public Property FechaModificacion As Nullable(Of Date)

    Public Overridable Property TablaDetalle As ICollection(Of TablaDetalle) = New HashSet(Of TablaDetalle)

End Class