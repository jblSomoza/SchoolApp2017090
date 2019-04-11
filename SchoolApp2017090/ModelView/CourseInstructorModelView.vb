Imports System.ComponentModel
Imports SchoolApp2017090
Imports SchoolApp2017090.JhonyLopez.SchoolApp2017090.Model
Public Class CourseInstructorModelView
    Implements INotifyPropertyChanged, ICommand, IDataErrorInfo

#Region "Campos"
    Private _CourseID As New Course
    Private _PersonID As New Person

    Private _Course As Course
    Private _Person As Person

    Private _ListCourse As New List(Of Course)
    Private _ListPerson As New List(Of Person)
    Private _ListCourseInstructor As New List(Of CourseInstructor)
    Private _Model As CourseInstructorModelView
    Private _Element As CourseInstructor

    Private DB As New SchoolApp2017090DataContext

    Private _BtnNew As Boolean = True
    Private _BtnSave As Boolean = False
    Private _BtnDelete As Boolean = True
    Private _BtnCancel As Boolean = False
    Private _BtnUpdate As Boolean = True
#End Region

#Region "Propiedades"
    Public Property CourseID As Course
        Get
            Return _CourseID
        End Get
        Set(value As Course)
            _CourseID = value
            NotificarCambio("CourseID")
        End Set
    End Property

    Public Property PersonID As Person
        Get
            Return _PersonID
        End Get
        Set(value As Person)
            _PersonID = value
            NotificarCambio("PersonID")
        End Set
    End Property

    Public Property Course As Course
        Get
            Return _Course
        End Get
        Set(value As Course)
            _Course = value
        End Set
    End Property

    Public Property Person As Person
        Get
            Return _Person
        End Get
        Set(value As Person)
            _Person = value
        End Set
    End Property

    Public Property ListCourse As List(Of Course)
        Get
            If _ListCourse.Count = 0 Then
                _ListCourse = (From N In DB.Courses Select N).ToList
            End If

            Return _ListCourse
        End Get
        Set(value As List(Of Course))
            _ListCourse = value
            NotificarCambio("ListCourse")
        End Set
    End Property

    Public Property ListPerson As List(Of Person)
        Get
            If _ListPerson.Count = 0 Then
                _ListPerson = (From N In DB.Persons Select N).ToList
            End If

            Return _ListPerson
        End Get
        Set(value As List(Of Person))
            _ListPerson = value
            NotificarCambio("ListPerson")
        End Set
    End Property

    Public Property ListCourseInstructor As List(Of CourseInstructor)
        Get
            If _ListCourse.Count = 0 Then
                _ListCourse = (From N In DB.Courses Select N).ToList
            End If

            Return _ListCourseInstructor
        End Get
        Set(value As List(Of CourseInstructor))
            _ListCourseInstructor = value
            NotificarCambio("ListCourseInstructor")
        End Set
    End Property

    Public Property Model As CourseInstructorModelView
        Get
            Return _Model
        End Get
        Set(value As CourseInstructorModelView)
            _Model = value
        End Set
    End Property

    Public Property Element As CourseInstructor
        Get
            Return _Element
        End Get
        Set(value As CourseInstructor)
            _Element = value
            NotificarCambio("Element")
            If value IsNot Nothing Then
                Me.CourseID = _Element.Course
                Me.PersonID = _Element.Person
            End If
        End Set
    End Property

    Public Property BtnNew As Boolean
        Get
            Return _BtnNew
        End Get
        Set(value As Boolean)
            _BtnNew = value
            NotificarCambio("BtnNew")
        End Set
    End Property

    Public Property BtnSave As Boolean
        Get
            Return _BtnSave
        End Get
        Set(value As Boolean)
            _BtnSave = value
            NotificarCambio("BtnSave")
        End Set
    End Property

    Public Property BtnDelete As Boolean
        Get
            Return _BtnDelete
        End Get
        Set(value As Boolean)
            _BtnDelete = value
            NotificarCambio("BtnDelete")
        End Set
    End Property

    Public Property BtnCancel As Boolean
        Get
            Return _BtnCancel
        End Get
        Set(value As Boolean)
            _BtnCancel = value
            NotificarCambio("BtnCancel")
        End Set
    End Property

    Public Property BtnUpdate As Boolean
        Get
            Return _BtnUpdate
        End Get
        Set(value As Boolean)
            _BtnUpdate = value
            NotificarCambio("BtnUpdate")
        End Set
    End Property
#End Region

#Region "Constructor"
    Public Sub New()
        Me.Model = Me
    End Sub
#End Region

#Region "INotifyPropertyChanged"
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
#End Region

#Region "ICommand"
    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged

    Public Sub Execute(parameter As Object) Implements ICommand.Execute
        If parameter.Equals("new") Then
            Me.BtnNew = False
            Me.BtnSave = True
            Me.BtnDelete = False
            Me.BtnCancel = True
            Me.BtnUpdate = False

        ElseIf parameter.Equals("save") Then
            Me.BtnNew = True
            Me.BtnSave = False
            Me.BtnDelete = True
            Me.BtnCancel = False
            Me.BtnUpdate = True

            Dim registro As New CourseInstructor

            registro.Course = Me.Course
            registro.Person = Me.Person
            DB.CourseInstructors.Add(registro)
            DB.SaveChanges()
            ListCourseInstructor = (From N In DB.CourseInstructors Select N).ToList
            Me.CourseID = Nothing
            Me.PersonID = Nothing

        ElseIf parameter.Equals("delete") Then
            Dim respuesta As MsgBoxResult = MsgBoxResult.No
            respuesta = MsgBox("Esta seguro de eliminar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Eliminar")

            If respuesta = MessageBoxResult.Yes Then
                DB.CourseInstructors.Remove(Me.Element)
                DB.SaveChanges()
                ListCourseInstructor = (From N In DB.CourseInstructors Select N).ToList
                Me.CourseID = Nothing
                Me.PersonID = Nothing
            End If

        ElseIf parameter.Equals("cancel") Then

            Me.BtnNew = True
            Me.BtnSave = False
            Me.BtnDelete = True
            'Me.BtnUpdate = True
            Me.BtnCancel = False

            Me.CourseID = Nothing
            Me.PersonID = Nothing 
        End If

    End Sub

    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        Return True
    End Function
#End Region

#Region "IDataErrorInfo"
    Public ReadOnly Property [Error] As String Implements IDataErrorInfo.Error
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Default Public ReadOnly Property Item(columnName As String) As String Implements IDataErrorInfo.Item
        Get
            Throw New NotImplementedException()
        End Get
    End Property

#End Region

#Region "Notificar Cambio"
    Public Sub NotificarCambio(ByVal Propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(Propiedad))
    End Sub
#End Region
End Class
