'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class AutenticacionUsuario
    Public Property IDLogin As Integer
    Public Property IDUsuario As Integer
    Public Property [Alias] As String
    Public Property Contrasena As String
    Public Property CorreoElectronico As String
    Public Property PreguntaSecreta As String
    Public Property RespuestaSecreta As String
    Public Property Bloqueado As Boolean
    Public Property UsuarioActualizacion As String
    Public Property FechaActualizacion As Date
    Public Property UltimaFechaLogueo As Nullable(Of Date)
    Public Property UltimaFechaCambioPassword As Nullable(Of Date)

    Public Overridable Property Usuario As Usuario

End Class