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
Imports System.ComponentModel.DataAnnotations

Partial Public Class Aluno

    <Display(Name:="Codigo do Aluno")> _
    <Required()>
    Public Property AlunoID As Integer
    <Display(Name:="Nome")> _
    <Required()> _
    Public Property AlunoNome As String
    <Display(Name:="Codigo Departamento")> _
   <Required()> _
    Public Property DepartamentoID As Integer
    <Display(Name:="Codigo Assunto")> _
    <Required()> _
    Public Property AssuntoID As Integer

    Public Overridable Property Assunto As Assunto
    Public Overridable Property Departamento As Departamento

End Class
