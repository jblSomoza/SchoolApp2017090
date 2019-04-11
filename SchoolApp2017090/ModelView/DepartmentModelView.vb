Imports System.ComponentModel
Imports SchoolApp2017090
Imports SchoolApp2017090.JhonyLopez.SchoolApp2017090.Model
Public Class DepartmentModelView

    Implements INotifyPropertyChanged, ICommand, IDataErrorInfo

#Region "Campos"
    Private _DepartmentID As Integer
    Private _Name As String
    Private _Budget As Decimal
    Private _StartDate As Date
    Private _Administrator As String

    Private _Model As DepartmentModelView
    Private _ListDepartment As New List(Of Department)
    Private _Element As Department

    Private DB As New SchoolApp2017090DataContext

    Private _BtnNew As Boolean = True
    Private _BtnSave As Boolean = False
    Private _BtnDelete As Boolean = True
    Private _BtnUpdate As Boolean = True
    Private _BtnCancel As Boolean = False

#End Region

#Region "Propiedades"
    Public Property DepartmentID As Integer
        Get
            Return _DepartmentID
        End Get
        Set(value As Integer)
            _DepartmentID = value
            NotificarCambio("DepartmentID")
        End Set
    End Property

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
            NotificarCambio("Name")
        End Set
    End Property

    Public Property Budget As Decimal
        Get
            Return _Budget
        End Get
        Set(value As Decimal)
            _Budget = value
            NotificarCambio("Budget")
        End Set
    End Property

    Public Property StartDate As Date
        Get
            Return _StartDate
        End Get
        Set(value As Date)
            _StartDate = value
            NotificarCambio("StartDate")
        End Set
    End Property

    Public Property Administrator As String
        Get
            Return _Administrator
        End Get
        Set(value As String)
            _Administrator = value
            NotificarCambio("Administrator")
        End Set
    End Property

    Public Property Model As DepartmentModelView
        Get
            Return _Model
        End Get
        Set(value As DepartmentModelView)
            _Model = value
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

    Public Property Element As Department
        Get
            Return _Element
        End Get
        Set(value As Department)
            _Element = value
            NotificarCambio("Element")

            If value IsNot Nothing Then
                Me.DepartmentID = _Element.DepartmentID
                Me.Name = _Element.Name
                Me.Budget = _Element.Budget
                Me.StartDate = _Element.StartDate
                Me.Administrator = _Element.Administrator
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

#Region "INotifityPropertyChanged"
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
#End Region

#Region "Icommand"
    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged
    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        Return True
    End Function

    Public Sub Execute(parameter As Object) Implements ICommand.Execute
        If parameter.Equals("new") Then
            Me.BtnNew = False
            Me.BtnSave = True
            Me.BtnDelete = False
            Me.BtnUpdate = False
            Me.BtnCancel = True

        ElseIf parameter.Equals("save") Then
            Dim registro As New Department

            Me.BtnNew = True
            Me.BtnSave = False
            Me.BtnDelete = True
            Me.BtnUpdate = True
            Me.BtnCancel = False

            registro.DepartmentID = Me.DepartmentID
            registro.Name = Me.Name
            registro.Budget = Me.Budget
            registro.StartDate = Me.StartDate
            registro.Administrator = Me.Administrator

            DB.Departments.Add(registro)
            DB.SaveChanges()
            ListDepartment = (From N In DB.Departments Select N).ToList

            Me.DepartmentID = Nothing
            Me.Name = Nothing
            Me.Budget = Nothing
            Me.StartDate = Nothing
            Me.Administrator = Nothing

        ElseIf parameter.Equals("delete") Then
            Dim respuesta As MsgBoxResult = MsgBoxResult.No
            respuesta = MsgBox("Esta seguro de eliminar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Eliminar")

            If respuesta = MessageBoxResult.Yes Then
                DB.Departments.Remove(Me.Element)
                DB.SaveChanges()
                ListDepartment = (From N In DB.Departments Select N).ToList

                Me.DepartmentID = Nothing
                Me.Name = Nothing
                Me.Budget = Nothing
                Me.StartDate = Nothing
                Me.Administrator = Nothing
            End If

        ElseIf parameter.Equals("cancel") Then

            Me.BtnNew = True
            Me.BtnSave = False
            Me.BtnDelete = True
            Me.BtnUpdate = True
            Me.BtnCancel = False

            Me.DepartmentID = Nothing
            Me.Name = Nothing
            Me.Budget = Nothing
            Me.StartDate = Nothing
            Me.Administrator = Nothing

        ElseIf parameter.Equals("update") Then

            If Me.Element IsNot Nothing Then
                Me.Element.Name = Me.Name
                Me.Element.Budget = Me.Budget
                Me.StartDate = Me.StartDate
                Me.Element.Administrator = Me.Administrator
                Me.DB.Entry(Me.Element).State = System.Data.Entity.EntityState.Modified
                Me.DB.SaveChanges()
                ListDepartment = (From N In DB.Departments Select N).ToList

                Me.DepartmentID = Nothing
                Me.Name = Nothing
                Me.Budget = Nothing
                Me.StartDate = Nothing
                Me.Administrator = Nothing
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

#Region "Notificar Cambio"
    Public Sub NotificarCambio(ByVal Propiedad As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(Propiedad))
    End Sub
#End Region
End Class
