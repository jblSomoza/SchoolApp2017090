Imports System.ComponentModel
Imports SchoolApp2017090
Imports SchoolApp2017090.JhonyLopez.SchoolApp2017090.Model
Public Class OfficeAssignmentModelView
    Implements INotifyPropertyChanged, ICommand, IDataErrorInfo

#Region "Campos"
    Private _InstructorID As Integer
    Private _Location As String
    Private _Timestamp As Date

    Private _Person As Person

    Private _ListOfficeAssignment As New List(Of OfficeAssignment)
    Private _Model As OfficeAssignmentModelView
    Private _Element As OfficeAssignment

    Private DB As New SchoolApp2017090DataContext

    Private _BtnNew As Boolean = True
    Private _BtnSave As Boolean = False
    Private _BtnDelete As Boolean = True
    Private _BtnCancel As Boolean = False
    Private _BtnUpdate As Boolean = True

#End Region

#Region "Propiedades"
    Public Property InstructorID As Integer
        Get
            Return _InstructorID
        End Get
        Set(value As Integer)
            _InstructorID = value
            NotificarCambio("InstructorID")
        End Set
    End Property

    Public Property Location As String
        Get
            Return _Location
        End Get
        Set(value As String)
            _Location = value
            NotificarCambio("Location")
        End Set
    End Property

    Public Property Timestamp As Date
        Get
            Return _Timestamp
        End Get
        Set(value As Date)
            _Timestamp = value
            NotificarCambio("Timestamp")
        End Set
    End Property

    Public Property Person As Person
        Get
            Return _Person
        End Get
        Set(value As Person)
            _Person = value
            NotificarCambio("Person")
        End Set
    End Property

    Public Property ListOfficeAssignment As List(Of OfficeAssignment)
        Get
            If _ListOfficeAssignment.Count = 0 Then
                _ListOfficeAssignment = (From N In DB.OfficeAssigments Select N).ToList
            End If

            Return _ListOfficeAssignment
        End Get
        Set(value As List(Of OfficeAssignment))
            _ListOfficeAssignment = value
        End Set
    End Property

    Public Property Model As OfficeAssignmentModelView
        Get
            Return _Model
        End Get
        Set(value As OfficeAssignmentModelView)
            _Model = value
        End Set
    End Property

    Public Property Element As OfficeAssignment
        Get
            Return _Element
        End Get
        Set(value As OfficeAssignment)
            _Element = value
            NotificarCambio("Element")
            If value IsNot Nothing Then
                Me.InstructorID = _Element.InstructorID
                Me.Location = _Element.Location
                Me.Timestamp = _Element.Timestamp
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

            Dim registro As New OfficeAssignment

            registro.Person = Me.Person
            registro.Location = Me.Location
            registro.Timestamp = Me.Timestamp

            DB.OfficeAssigments.Add(registro)
            DB.SaveChanges()
            ListOfficeAssignment = (From N In DB.OfficeAssigments Select N).ToList
            Me.InstructorID = Nothing
            Me.Location = Nothing
            Me.Timestamp = Nothing

        ElseIf parameter.Equals("delete") Then
            Dim respuesta As MsgBoxResult = MsgBoxResult.No
            respuesta = MsgBox("¿Esta seguro de eliminar?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton2, "Eliminar")

            If respuesta = MessageBoxResult.Yes Then
                DB.OfficeAssigments.Remove(Me.Element)
                DB.SaveChanges()
                ListOfficeAssignment = (From N In DB.OfficeAssigments Select N).ToList
                Me.InstructorID = Nothing
                Me.Location = Nothing
                Me.Timestamp = Nothing
            End If

        ElseIf parameter.Equals("cancel") Then

            Me.BtnNew = True
            Me.BtnSave = False
            Me.BtnDelete = True
            Me.BtnUpdate = True
            Me.BtnCancel = False

            Me.InstructorID = Nothing
            Me.Location = Nothing
            Me.Timestamp = Nothing

        ElseIf parameter.Equals("update") Then
            If Me.Element IsNot Nothing Then
                Me.Element.InstructorID = Me.InstructorID
                Me.Element.Location = Me.Location
                Me.Timestamp = Me.Timestamp

                Me.DB.Entry(Me.Element).State = System.Data.Entity.EntityState.Modified
                Me.DB.SaveChanges()
                ListOfficeAssignment = (From N In DB.OfficeAssigments Select N).ToList
                Me.InstructorID = Nothing
                Me.Location = Nothing
                Me.Timestamp = Nothing
            End If
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
