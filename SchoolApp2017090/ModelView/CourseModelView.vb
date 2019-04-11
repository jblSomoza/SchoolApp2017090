Imports System.ComponentModel
Imports SchoolApp2017090
Imports SchoolApp2017090.JhonyLopez.SchoolApp2017090.Model
Public Class CourseModelView

    Implements INotifyPropertyChanged, ICommand, IDataErrorInfo

#Region "Campos"

    Private _CourseID As Integer
    Private _Title As String
    Private _Credits As Decimal
    Private _Department As Department

    Private _ListDepartment As New List(Of Department)
    Private _Model As CourseModelView
    Private _ListCourse As New List(Of Course)
    Private _Element As Course

    Private _Course As New Course
    Private DB As New SchoolApp2017090DataContext

    Private _BtnNew As Boolean = True
    Private _BtnSave As Boolean = False
    Private _BtnDelete As Boolean = True
    Private _BtnCancel As Boolean = False
    Private _BtnUpdate As Boolean = True
#End Region

#Region "Propiedades"
    Public Property CourseID As Integer
        Get
            Return _CourseID
        End Get
        Set(value As Integer)
            _CourseID = value
            NotificarCambio("CourseID")
        End Set
    End Property

    Public Property Title As String
        Get
            Return _Title
        End Get
        Set(value As String)
            _Title = value
            NotificarCambio("Title")
        End Set
    End Property

    Public Property Credits As Decimal
        Get
            Return _Credits
        End Get
        Set(value As Decimal)
            _Credits = value
            NotificarCambio("Credits")
        End Set
    End Property

    Public Property Department As Department
        Get
            Return _Department
        End Get
        Set(value As Department)
            _Department = value
            NotificarCambio("Department")
        End Set
    End Property

    Public Property ListDepartment As List(Of Department)
        Get
            If _ListDepartment.Count = 0 Then
                _ListDepartment = (From N In DB.Departments Select N).ToList
            End If
            Return _ListDepartment
        End Get
        Set(value As List(Of Department))
            _ListDepartment = value
            NotificarCambio("ListDepartment")
        End Set
    End Property

    Public Property Model As CourseModelView
        Get
            Return _Model
        End Get
        Set(value As CourseModelView)
            _Model = value
            NotificarCambio("Model")
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

    Public Property Element As Course
        Get
            Return _Element
        End Get
        Set(value As Course)
            _Element = value
            NotificarCambio("NotificarCambio")
            If value IsNot Nothing Then
                Me.CourseID = _Element.CourseID
                Me.Title = _Element.Title
                Me.Credits = _Element.Credits
                Me.Department = _Element.Department
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
    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        Return True
    End Function

    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged

    Public Sub Execute(parameter As Object) Implements ICommand.Execute
        If parameter.Equals("new") Then
            Me.BtnNew = False
            Me.BtnSave = True
            Me.BtnDelete = False
            Me.BtnCancel = True
            Me.BtnUpdate = True

        ElseIf parameter.Equals("save") Then
            Me.BtnNew = True
            Me.BtnSave = False
            Me.BtnDelete = True
            Me.BtnCancel = True
            Me.BtnUpdate = False

            Dim registro As New Course

            registro.CourseID = Me.CourseID
            registro.Title = Me.Title
            registro.Credits = Me.Credits
            registro.Department = Me.Department
            DB.Courses.Add(registro)
            DB.SaveChanges()
            ListCourse = (From N In DB.Courses Select N).ToList
            Me.CourseID = 0
            Me.Title = ""
            Me.Credits = 0

        ElseIf parameter.Equals("cancel") Then
            Me.BtnNew = True
            Me.BtnSave = False
            Me.BtnDelete = True
            Me.BtnUpdate = True
            Me.BtnCancel = False
            Me.CourseID = 0
            Me.Title = ""
            Me.Credits = 0

        ElseIf parameter.Equals("delete") Then
            Dim respuesta As MsgBoxResult = MsgBoxResult.No
            respuesta = MsgBox("Esta seguro de eliminar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Eliminar")

            If respuesta = MessageBoxResult.Yes Then
                DB.Courses.Remove(Me.Element)
                DB.SaveChanges()
                ListCourse = (From N In DB.Courses Select N).ToList
                Me.CourseID = 0
                Me.Title = ""
                Me.Credits = 0
            End If

        ElseIf parameter.Equals("update") Then
            If Me.Element IsNot Nothing Then
                Me.Element.CourseID = Me.CourseID
                Me.Element.Title = Me.Title
                Me.Element.Credits = Me.Credits
                Me.Element.Department = Me.Department
                Me.DB.Entry(Me.Element).State = System.Data.Entity.EntityState.Modified
                Me.DB.SaveChanges()
                ListCourse = (From N In DB.Courses Select N).ToList
                Me.CourseID = 0
                Me.Title = ""
                Me.Credits = 0
            End If

        End If
    End Sub

#End Region

#Region "IDataErrorInfo"
    Default Public ReadOnly Property Item(columnName As String) As String Implements IDataErrorInfo.Item
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property [Error] As String Implements IDataErrorInfo.Error
        Get
            Throw New NotImplementedException()
        End Get
    End Property
#End Region

#Region "NotificarCambio"
    Public Sub NotificarCambio(ByVal Propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(Propiedad))
    End Sub
#End Region
End Class