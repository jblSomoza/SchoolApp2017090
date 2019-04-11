Imports System.ComponentModel
Imports SchoolApp2017090
Imports SchoolApp2017090.JhonyLopez.SchoolApp2017090.Model
Public Class StudentGradeModelView
    Implements INotifyPropertyChanged, ICommand, IDataErrorInfo

#Region "Campos"
    Private _EnrollmentID As Integer
    Private _CourseID As Course
    Private _StudentID As Integer
    Private _Grade As String

    Private _ListStudentGrade As New List(Of StudentGrade)
    Private _ListCourse As New List(Of Course)
    Private _Model As StudentGradeModelView
    Private _Element As StudentGrade

    Private _Course As New Course
    Private DB As New SchoolApp2017090DataContext

    Private _BtnNew As Boolean = True
    Private _BtnSave As Boolean = False
    Private _BtnDelete As Boolean = True
    Private _BtnCancel As Boolean = False
    Private _BtnUpdate As Boolean = True

#End Region

#Region "Propiedades"
    Public Property EnrollmentID As Integer
        Get
            Return _EnrollmentID
        End Get
        Set(value As Integer)
            _EnrollmentID = value
            NotificarCambio("EnrollmentID")
        End Set
    End Property

    Public Property CourseID As Course
        Get
            Return _CourseID
        End Get
        Set(value As Course)
            _CourseID = value
            NotificarCambio("CourseID")
        End Set
    End Property

    Public Property StudentID As Integer
        Get
            Return _StudentID
        End Get
        Set(value As Integer)
            _StudentID = value
            NotificarCambio("StudentID")
        End Set
    End Property

    Public Property Grade As String
        Get
            Return _Grade
        End Get
        Set(value As String)
            _Grade = value
            NotificarCambio("Grade")
        End Set
    End Property

    Public Property ListStudentGrade As List(Of StudentGrade)
        Get
            If _ListStudentGrade.Count = 0 Then
                _ListStudentGrade = (From N In DB.StudentGrades Select N).ToList
            End If
            Return _ListStudentGrade
        End Get
        Set(value As List(Of StudentGrade))
            _ListStudentGrade = value
            NotificarCambio("ListStudentGrade")
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

    Public Property Model As StudentGradeModelView
        Get
            Return _Model
        End Get
        Set(value As StudentGradeModelView)
            _Model = value
            NotificarCambio("Model")
        End Set
    End Property

    Public Property Element As StudentGrade
        Get
            Return _Element
        End Get
        Set(value As StudentGrade)
            _Element = value
            If value IsNot Nothing Then
                Me.EnrollmentID = _Element.EnrollmentID
                Me.CourseID = _Element.Course
                Me.StudentID = _Element.StudentID
                Me.Grade = _Element.Grade
            End If
        End Set
    End Property

    Public Property Course As Course
        Get
            Return _Course
        End Get
        Set(value As Course)
            _Course = value
            NotificarCambio("Course")
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
            Me.BtnUpdate = True

        ElseIf parameter.Equals("save") Then
            Me.BtnNew = True
            Me.BtnSave = False
            Me.BtnDelete = True
            Me.BtnCancel = True
            Me.BtnUpdate = False

            Dim registro As New StudentGrade

            registro.EnrollmentID = Me.EnrollmentID
            registro.Course = Me.Course
            registro.StudentID = Me.StudentID
            registro.Grade = Me.Grade
            DB.StudentGrades.Add(registro)
            DB.SaveChanges()
            ListStudentGrade = (From N In DB.StudentGrades Select N).ToList

            Me.EnrollmentID = Nothing
            Me.CourseID = Nothing
            Me.StudentID = Nothing
            Me.Grade = Nothing

        ElseIf parameter.Equals("delete") Then
            Dim respuesta As MsgBoxResult = MsgBoxResult.No
            respuesta = MsgBox("Esta seguro de eliminar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Eliminar")

            If respuesta = MessageBoxResult.Yes Then
                DB.StudentGrades.Remove(Me.Element)
                DB.SaveChanges()
                ListStudentGrade = (From N In DB.StudentGrades Select N).ToList
            End If

            Me.EnrollmentID = Nothing
            Me.CourseID = Nothing
            Me.StudentID = Nothing
            Me.Grade = Nothing

        ElseIf parameter.Equals("cancel") Then
            Me.BtnNew = True
            Me.BtnSave = False
            Me.BtnDelete = True
            Me.BtnUpdate = True
            Me.BtnCancel = False

            Me.EnrollmentID = Nothing
            Me.CourseID = Nothing
            Me.StudentID = Nothing
            Me.Grade = Nothing

        ElseIf parameter.Equals("update") Then
            If Me.Element IsNot Nothing Then
                Me.Element.EnrollmentID = Me.EnrollmentID
                Me.Element.Course = Me.Course
                Me.Element.StudentID = Me.StudentID
                Me.Element.Grade = Me.Grade
                Me.DB.Entry(Me.Element).State = System.Data.Entity.EntityState.Modified
                Me.DB.SaveChanges()
                ListStudentGrade = (From N In DB.StudentGrades Select N).ToList
            End If

            Me.EnrollmentID = Nothing
            Me.CourseID = Nothing
            Me.StudentID = Nothing
            Me.Grade = Nothing
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
