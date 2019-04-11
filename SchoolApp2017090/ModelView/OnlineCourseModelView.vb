Imports System.ComponentModel
Imports SchoolApp2017090
Imports SchoolApp2017090.JhonyLopez.SchoolApp2017090.Model
Public Class OnlineCourseModelView
    Implements INotifyPropertyChanged, ICommand, IDataErrorInfo

#Region "Campos"
    Private _CourseID As New Course
    Private _URL As String

    Private _Course As Course

    Private _ListOnlineCourse As New List(Of OnlineCourse)
    Private _ListCourse As New List(Of Course)
    Private _Model As OnlineCourseModelView
    Private _Element As OnlineCourse

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

    Public Property URL As String
        Get
            Return _URL
        End Get
        Set(value As String)
            _URL = value
            NotificarCambio("URL")
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

    Public Property ListOnlineCourse As List(Of OnlineCourse)
        Get
            If _ListOnlineCourse.Count = 0 Then
                _ListOnlineCourse = (From N In DB.OnlineCourses Select N).ToList
            End If

            Return _ListOnlineCourse
        End Get
        Set(value As List(Of OnlineCourse))
            _ListOnlineCourse = value
            NotificarCambio("ListOnlineCourse")
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

    Public Property Model As OnlineCourseModelView
        Get
            Return _Model
        End Get
        Set(value As OnlineCourseModelView)
            _Model = value
        End Set
    End Property

    Public Property Element As OnlineCourse
        Get
            Return _Element
        End Get
        Set(value As OnlineCourse)
            _Element = value
            NotificarCambio("Element")
            If value IsNot Nothing Then
                Me.Course = _Element.Course
                Me.URL = _Element.URL
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

#Region "INotifyPropertyChange"
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

            Dim registro As New OnlineCourse

            registro.Course = Me.Course
            registro.URL = Me.URL
            DB.OnlineCourses.Add(registro)
            DB.SaveChanges()
            ListOnlineCourse = (From N In DB.OnlineCourses Select N).ToList

            Me.CourseID = Nothing
            Me.URL = Nothing

        ElseIf parameter.Equals("delete") Then
            Dim respuesta As MsgBoxResult = MsgBoxResult.No
            respuesta = MsgBox("Esta seguro de eliminar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Eliminar")

            If respuesta = MessageBoxResult.Yes Then
                DB.OnlineCourses.Remove(Me.Element)
                DB.SaveChanges()
                ListOnlineCourse = (From N In DB.OnlineCourses Select N).ToList
            End If

            Me.CourseID = Nothing
            Me.URL = Nothing

        ElseIf parameter.Equals("cancel") Then

            Me.BtnNew = True
            Me.BtnSave = False
            Me.BtnDelete = True
            Me.BtnUpdate = True
            Me.BtnCancel = False

            Me.CourseID = Nothing
            Me.URL = Nothing

        ElseIf parameter.Equals("update") Then
            If Me.Element IsNot Nothing Then
                Me.Element.Course = Me.CourseID
                Me.Element.URL = Me.URL
                Me.DB.Entry(Me.Element).State = System.Data.Entity.EntityState.Modified

                Me.CourseID = Nothing
                Me.URL = Nothing

            End If
        End If
    End Sub

    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        Return True
    End Function
#End Region

#Region "IDataError"
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
