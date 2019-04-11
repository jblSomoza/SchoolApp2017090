﻿Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Namespace JhonyLopez.SchoolApp2017090.Model
    Public Class Course
#Region "Campos"
        Private _CourseID As Integer
        Private _Title As String
        Private _Credits As Integer
        Private _DepartmentID As Integer
#End Region

#Region "Llaves"
        Public Overridable Property Department() As Department
        Public Overridable Property StudentGrades() As ICollection(Of StudentGrade)
        Public Overridable Property CourseInstructors() As ICollection(Of CourseInstructor)
        Public Overridable Property OnsiteCourse() As OnsiteCourse
        Public Overridable Property OnlineCourse() As OnlineCourse
#End Region

#Region "Propiedades"
        <Key>
        Public Property CourseID As Integer
            Get
                Return _CourseID
            End Get
            Set(value As Integer)
                _CourseID = value
            End Set
        End Property

        Public Property Title As String
            Get
                Return _Title
            End Get
            Set(value As String)
                _Title = value
            End Set
        End Property

        Public Property Credits As Integer
            Get
                Return _Credits
            End Get
            Set(value As Integer)
                _Credits = value
            End Set
        End Property
        <ForeignKey("Department")>
        Public Property DepartmentID As Integer
            Get
                Return _DepartmentID
            End Get
            Set(value As Integer)
                _DepartmentID = value
            End Set
        End Property
#End Region
    End Class
End Namespace
