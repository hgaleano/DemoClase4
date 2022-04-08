Imports System.Web.Mvc

Namespace Controllers
    Public Class EmpleadoController
        Inherits Controller

        ' GET: Empleado
        Function Index() As ActionResult
            Dim ListEmpleados As New List(Of Empleado)
            Return View(ListEmpleados)
        End Function

        ' GET: Empleado/Details/5
        Function Details(ByVal id As Integer) As ActionResult
            Return View()
        End Function



        ' GET: Empleado/Create
        Function Create() As ActionResult
            Return View()
        End Function
        Function resultado(nombre As String, edad As Integer) As ActionResult
            ViewData("nombre") = nombre
            ViewData("edad") = edad
            Return View()
        End Function



        ' POST: Empleado/Create
        <HttpPost()>
        Function Create(ByVal empleado As Empleado) As ActionResult
            Try
                ' TODO: Add insert logic here
                Dim objEmpleado As New Empleado
                objEmpleado = empleado
                Dim Edad As Integer = 0
                Edad = objEmpleado.CalcularEdad(empleado.FechaNacimiento)

                Return RedirectToAction("resultado", "Empleado", New With {.nombre = objEmpleado.Nombre, .edad = Edad})
            Catch
                Return View()
            End Try
        End Function

        ' GET: Empleado/Edit/5
        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Empleado/Edit/5
        <HttpPost()>
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Empleado/Delete/5
        Function Delete(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Empleado/Delete/5
        <HttpPost()>
        Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function
    End Class
End Namespace