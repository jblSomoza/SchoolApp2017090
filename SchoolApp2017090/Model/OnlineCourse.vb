Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Namespace JhonyLopez.SchoolApp2017090.Model
    Public Class OnlineCourse
#Region "Campos"
        Private _CourseID As Integer
        Private _URL As String
#End Region

#Region "Llaves"
        Public Overridable Property Course() As Course
#End Region

#Region "Propiedades"
        <Key>
        <ForeignKey("Course")>
        Public Property CourseID As Integer
            Get
                Return _CourseID
            End Get
            Set(value As Integer)
                _CourseID = value
            End Set
        End Property

        Public Property URL As String
            Get
                Return _URL
            End Get
            Set(value As String)
                _URL = value
            End Set
        End Property
#End Region
    End Class
End Namespace
