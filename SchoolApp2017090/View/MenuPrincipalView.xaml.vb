Imports MahApps.Metro.Controls
Public Class MenuPrincipalView

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub MenuItem_Click(sender As Object, e As RoutedEventArgs)
        Dim ventana As New StudentGradeView
        ventana.ShowDialog()
    End Sub

    Private Sub MenuItem_Click_1(sender As Object, e As RoutedEventArgs)
        Dim ventana As New DepartmentView
        ventana.ShowDialog()

    End Sub

    Private Sub MenuItem_Click_2(sender As Object, e As RoutedEventArgs)
        Dim ventana As New CourseView
        ventana.ShowDialog()
    End Sub

    Private Sub MenuItem_Click_3(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub MenuItem_Click_4(sender As Object, e As RoutedEventArgs)
        Dim ventana As New PersonView
        ventana.ShowDialog()
    End Sub

    Private Sub MenuItem_Click_5(sender As Object, e As RoutedEventArgs)
        System.Windows.Application.Current.Shutdown()
    End Sub

    Private Sub MenuItem_Click_6(sender As Object, e As RoutedEventArgs)
        Dim ventana As New CourseInstructorView
        ventana.ShowDialog()
    End Sub

    Private Sub MenuItem_Click_7(sender As Object, e As RoutedEventArgs)
        Dim ventana As New OnsiteCourseView
        ventana.ShowDialog()
    End Sub

    Private Sub MenuItem_Click_8(sender As Object, e As RoutedEventArgs)
        Dim ventana As New OnlineCourseView
        ventana.ShowDialog()
    End Sub

    Private Sub MenuItem_Click_9(sender As Object, e As RoutedEventArgs)
        Dim ventana As New OfficeAssignmentView
        ventana.ShowDialog()
    End Sub
End Class
