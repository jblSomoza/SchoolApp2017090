﻿Imports MahApps.Metro.Controls
Public Class PersonView
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.DataContext = New PersonModelView
    End Sub
End Class
