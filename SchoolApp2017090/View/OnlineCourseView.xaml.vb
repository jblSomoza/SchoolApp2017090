﻿Imports MahApps.Metro.Controls
Public Class OnlineCourseView
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.DataContext = New OnlineCourseModelView
    End Sub
End Class
