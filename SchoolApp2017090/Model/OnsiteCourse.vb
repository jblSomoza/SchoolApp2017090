Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Namespace JhonyLopez.SchoolApp2017090.Model
    Public Class OnsiteCourse
#Region "Campos"
        Private _CourseID As Integer
        Private _Location As String
        Private _Days As String
        Private _Time As String
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

        Public Property Location As String
            Get
                Return _Location
            End Get
            Set(value As String)
                _Location = value
            End Set
        End Property

        Public Property Days As String
            Get
                Return _Days
            End Get
            Set(value As String)
                _Days = value
            End Set
        End Property

        Public Property Time As String
            Get
                Return _Time
            End Get
            Set(value As String)
                _Time = value
            End Set
        End Property
#End Region
    End Class
End Namespace
