﻿Imports MahApps.Metro.Controls
Public Class OfficeAssignmentView
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DataContext = New OfficeAssignmentModelView
    End Sub
End Class
