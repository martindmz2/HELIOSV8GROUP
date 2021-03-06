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

Partial Public Class ControlAsistencia
    Public Property IDAsistencia As Integer
    Public Property IDPersonal As Integer
    Public Property IDCargo As Integer
    Public Property TipoAcesso As String
    Public Property Fecha As Nullable(Of Date)
    Public Property Hora As Nullable(Of System.TimeSpan)
    Public Property HoraPersonal As Nullable(Of System.TimeSpan)
    Public Property HoraExtras As Nullable(Of Integer)
    Public Property HorasFaltas As Nullable(Of Integer)
    Public Property Tolerancia As Nullable(Of System.TimeSpan)
    Public Property Penalidad As Nullable(Of System.TimeSpan)
    Public Property Anotaciones As String
    Public Property FaltaJustificada As Nullable(Of Boolean)
    Public Property Tardanza As Nullable(Of System.TimeSpan)
    Public Property FechaModificacion As Nullable(Of Date)
    Public Property UsuarioModificacion As String

    Public Overridable Property PlanillaGeneral As ICollection(Of PlanillaGeneral) = New HashSet(Of PlanillaGeneral)

End Class
