Imports System.Data.Entity 'Relacion con la base de datos
Imports System.Data.SqlClient '
Imports System.Data.Entity.ModelConfiguration.Conventions 'Convenciones 

Namespace JhonyLopez.SchoolApp2017090.Model
    Public Class SchoolApp2017090DataContext
        Inherits DbContext
        Public Property Courses() As DbSet(Of Course)
        Public Property Departments() As DbSet(Of Department)
        Public Property CourseInstructors() As DbSet(Of CourseInstructor)
        Public Property OnlineCourses() As DbSet(Of OnlineCourse)
        Public Property OnsiteCourses() As DbSet(Of OnsiteCourse)
        Public Property StudentGrades() As DbSet(Of StudentGrade)
        Public Property Persons() As DbSet(Of Person)
        Public Property OfficeAssigments() As DbSet(Of OfficeAssignment)
    End Class
End Namespace
