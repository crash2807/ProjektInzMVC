Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports ProjektInzynierskiMVC

Namespace Controllers
    Public Class HobbiesController
        Inherits System.Web.Mvc.Controller

        Private db As New s17041Entities

        ' GET: Hobbies
        Function Index() As ActionResult
            Return View(db.Hobby.ToList())
        End Function

        ' GET: Hobbies/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim hobby As Hobby = db.Hobby.Find(id)
            If IsNothing(hobby) Then
                Return HttpNotFound()
            End If
            Return View(hobby)
        End Function

        ' GET: Hobbies/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Hobbies/Create

        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="IdHobby,HobbyName,Description")> ByVal hobby As Hobby) As ActionResult
            If ModelState.IsValid Then
                db.Hobby.Add(hobby)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(hobby)
        End Function

        ' GET: Hobbies/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim hobby As Hobby = db.Hobby.Find(id)
            If IsNothing(hobby) Then
                Return HttpNotFound()
            End If
            Return View(hobby)
        End Function

        ' POST: Hobbies/Edit/5

        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="IdHobby,HobbyName,Description")> ByVal hobby As Hobby) As ActionResult
            If ModelState.IsValid Then
                db.Entry(hobby).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(hobby)
        End Function

        ' GET: Hobbies/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim hobby As Hobby = db.Hobby.Find(id)
            If IsNothing(hobby) Then
                Return HttpNotFound()
            End If
            Return View(hobby)
        End Function

        ' POST: Hobbies/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim hobby As Hobby = db.Hobby.Find(id)
            db.Hobby.Remove(hobby)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
