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

Partial Public Class User
    Public Property IdUser As Integer
    Public Property Name As String
    Public Property Surname As String
    Public Property Email As String
    Public Property Password As String
    Public Property Birthday As Date
    Public Property Avatar As Byte()

    Public Overridable Property [Event] As ICollection(Of [Event]) = New HashSet(Of [Event])
    Public Overridable Property Gift As ICollection(Of Gift) = New HashSet(Of Gift)
    Public Overridable Property Relation As ICollection(Of Relation) = New HashSet(Of Relation)
    Public Overridable Property Relation1 As ICollection(Of Relation) = New HashSet(Of Relation)

End Class
