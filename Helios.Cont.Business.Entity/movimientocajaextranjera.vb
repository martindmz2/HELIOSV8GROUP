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

Partial Public Class movimientocajaextranjera
    Public Property codigo As Integer
    Public Property idDocumento As Integer
    Public Property idDocumentoCaja As Nullable(Of Integer)
    Public Property identidad As Integer
    Public Property fecha As Nullable(Of Date)
    Public Property tipomovimiento As Nullable(Of Integer)
    Public Property moneda As Nullable(Of Integer)
    Public Property tipocambioorigen As Nullable(Of Decimal)
    Public Property tipocambio As Nullable(Of Decimal)
    Public Property importe As Nullable(Of Decimal)
    Public Property usuarioActualizacion As Nullable(Of Integer)
    Public Property fechaActualizacion As Nullable(Of Date)

    Public Overridable Property documentoCaja As documentoCaja

End Class
