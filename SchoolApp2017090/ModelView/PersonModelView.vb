Imports System.ComponentModel
Imports SchoolApp2017090
Imports SchoolApp2017090.JhonyLopez.SchoolApp2017090.Model
Public Class PersonModelView
    Implements INotifyPropertyChanged, ICommand, IDataErrorInfo

#Region "Campos"
    Private _PersonID As Integer
    Private _LastName As String
    Private _FirstName As String
    Private _HireDate As Date
    Private _EnrollmentDate As Date

    Private _ListPerson As New List(Of Person)
    Private _Model As PersonModelView
    Private _Element As Person

    Private DB As New SchoolApp2017090DataContext

    Private _BtnNew As Boolean = True
    Private _BtnSave As Boolean = False
    Private _BtnDelete As Boolean = True
    Private _BtnUpdate As Boolean = True
    Private _BtnCancel As Boolean = False
#End Region

#Region "Propiedades"
    Public Property PersonID As Integer
        Get
            Return _PersonID
        End Get
        Set(value As Integer)
            _PersonID = value
            NotificarCambio("PersonID")
        End Set
    End Property

    Public Property LastName As String
        Get
            Return _LastName
        End Get
        Set(value As String)
            _LastName = value
            NotificarCambio("LastName")
        End Set
    End Property

    Public Property FirstName As String
        Get
            Return _FirstName
        End Get
        Set(value As String)
            _FirstName = value
            NotificarCambio("FirstName")
        End Set
    End Property

    Public Property HireDate As Date
        Get
            Return _HireDate
        End Get
        Set(value As Date)
            _HireDate = value
            NotificarCambio("HireDate")
        End Set
    End Property

    Public Property EnrollmentDate As Date
        Get
            Return _EnrollmentDate
        End Get
        Set(value As Date)
            _EnrollmentDate = value
            NotificarCambio("EnrollmentDate")
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

    Public Property Model As PersonModelView
        Get
            Return _Model
        End Get
        Set(value As PersonModelView)
            _Model = value
        End Set
    End Property

    Public Property Element As Person
        Get
            Return _Element
        End Get
        Set(value As Person)
            _Element = value
            NotificarCambio("Element")

            If value IsNot Nothing Then
                Me.PersonID = _Element.PersonID
                Me.LastName = _Element.LastName
                Me.FirstName = _Element.FirstName
                Me.HireDate = _Element.HireDate
                Me.EnrollmentDate = _Element.EnrollmentDate
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

    Public Property BtnUpdate As Boolean
        Get
            Return _BtnUpdate
        End Get
        Set(value As Boolean)
            _BtnUpdate = value
            NotificarCambio("BtnUpdate")
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
    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        Return True
    End Function
    Public Sub Execute(parameter As Object) Implements ICommand.Execute
        If parameter.Equals("new") Then
            BtnNew = False
            BtnSave = True
            BtnDelete = False
            BtnUpdate = False
            BtnCancel = True

        ElseIf parameter.Equals("save") Then
            Dim registro As New Person

            Me.BtnNew = True
            Me.BtnSave = False
            Me.BtnDelete = True
            Me.BtnUpdate = True
            Me.BtnCancel = False

            registro.PersonID = Me.PersonID
            registro.LastName = Me.LastName
            registro.FirstName = Me.FirstName
            registro.HireDate = Me.HireDate
            registro.EnrollmentDate = Me.EnrollmentDate

            DB.Persons.Add(registro)
            DB.SaveChanges()
            ListPerson = (From N In DB.Persons Select N).ToList

            Me.PersonID = Nothing
            Me.LastName = Nothing
            Me.FirstName = Nothing
            Me.HireDate = Nothing
            Me.EnrollmentDate = Nothing

        ElseIf parameter.Equals("delete") Then
            Dim respuesta As MsgBoxResult = MsgBoxResult.No
            respuesta = MsgBox("¿Esta seguro de eliminar el registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Eliminar")

            If respuesta = MessageBoxResult.Yes Then
                DB.Persons.Remove(Me.Element)
                DB.SaveChanges()
                ListPerson = (From N In DB.Persons Select N).ToList
            End If

            Me.PersonID = Nothing
            Me.LastName = Nothing
            Me.FirstName = Nothing
            Me.HireDate = Nothing
            Me.EnrollmentDate = Nothing

        ElseIf parameter.Equals("cancel") Then
            Me.BtnNew = True
            Me.BtnSave = False
            Me.BtnDelete = True
            Me.BtnUpdate = True
            Me.BtnCancel = False

            Me.PersonID = Nothing
            Me.LastName = Nothing
            Me.FirstName = Nothing
            Me.HireDate = Nothing
            Me.EnrollmentDate = Nothing

        ElseIf parameter.Equals("update") Then
            If Me.Element IsNot Nothing Then
                Me.Element.PersonID = Me.PersonID
                Me.Element.FirstName = Me.FirstName
                Me.Element.LastName = Me.LastName
                Me.HireDate = Me.HireDate
                Me.EnrollmentDate = Me.EnrollmentDate
                Me.DB.Entry(Me.Element).State = System.Data.Entity.EntityState.Modified
                Me.DB.SaveChanges()
                ListPerson = (From N In DB.Persons Select N).ToList
            End If

            Me.PersonID = Nothing
            Me.LastName = Nothing
            Me.FirstName = Nothing
            Me.HireDate = Nothing
            Me.EnrollmentDate = Nothing

        End If
    End Sub
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
