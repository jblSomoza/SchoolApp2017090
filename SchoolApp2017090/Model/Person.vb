﻿Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Namespace JhonyLopez.SchoolApp2017090.Model
    Public Class Person
#Region "Campos"
        Private _PersonID As Integer
        Private _LastName As String
        Private _FirstName As String
        Private _HireDate As Date
        Private _EnrollmentDate As Date
#End Region

#Region "Llaves"
        Public Overridable Property StudentGrades() As ICollection(Of StudentGrade)
        Public Overridable Property CourseInstructors() As ICollection(Of CourseInstructor)
        Public Overridable Property OfficeAssignment() As OfficeAssignment
#End Region

#Region "Propiedades"
        <Key>
        Public Property PersonID As Integer
            Get
                Return _PersonID
            End Get
            Set(value As Integer)
                _PersonID = value
            End Set
        End Property

        Public Property LastName As String
            Get
                Return _LastName
            End Get
            Set(value As String)
                _LastName = value
            End Set
        End Property

        Public Property FirstName As String
            Get
                Return _FirstName
            End Get
            Set(value As String)
                _FirstName = value
            End Set
        End Property

        Public Property HireDate As Date
            Get
                Return _HireDate
            End Get
            Set(value As Date)
                _HireDate = value
            End Set
        End Property

        Public Property EnrollmentDate As Date
            Get
                Return _EnrollmentDate
            End Get
            Set(value As Date)
                _EnrollmentDate = value
            End Set
        End Property
#End Region
    End Class
End Namespace
