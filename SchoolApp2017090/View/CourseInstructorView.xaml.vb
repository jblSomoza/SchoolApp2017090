Imports MahApps.Metro.Controls
Public Class CourseInstructorView
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DataContext = New CourseInstructorModelView
    End Sub

End Class
