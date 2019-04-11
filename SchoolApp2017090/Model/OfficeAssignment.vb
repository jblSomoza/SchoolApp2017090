Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Namespace JhonyLopez.SchoolApp2017090.Model
    Public Class OfficeAssignment
#Region "Campos"
        Private _InstructorID As Integer
        Private _Location As String
        Private _Timestamp As Date
#End Region

#Region "Llaves"
        Public Overridable Property Person() As Person
#End Region

#Region "Propiedades"
        <Key>
        <ForeignKey("Person")>
        Public Property InstructorID As Integer
            Get
                Return _InstructorID
            End Get
            Set(value As Integer)
                _InstructorID = value
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

        Public Property Timestamp As Date
            Get
                Return _Timestamp
            End Get
            Set(value As Date)
                _Timestamp = value
            End Set
        End Property
#End Region
    End Class
End Namespace
