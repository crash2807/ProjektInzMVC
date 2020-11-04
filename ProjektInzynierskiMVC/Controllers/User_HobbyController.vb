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
    Public Class User_HobbyController
        Inherits System.Web.Mvc.Controller

        Private db As New s17041Entities

        ' GET: User_Hobby
        Function Index() As ActionResult
            Return View(db.User_Hobby.ToList())
        End Function

        ' GET: User_Hobby/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim user_Hobby As User_Hobby = db.User_Hobby.Find(id)
            If IsNothing(user_Hobby) Then
                Return HttpNotFound()
            End If
            Return View(user_Hobby)
        End Function

        ' GET: User_Hobby/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: User_Hobby/Create

        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="IdUser,IdHobby")> ByVal user_Hobby As User_Hobby) As ActionResult
            If ModelState.IsValid Then
                db.User_Hobby.Add(user_Hobby)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(user_Hobby)
        End Function

        ' GET: User_Hobby/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim user_Hobby As User_Hobby = db.User_Hobby.Find(id)
            If IsNothing(user_Hobby) Then
                Return HttpNotFound()
            End If
            Return View(user_Hobby)
        End Function

        ' POST: User_Hobby/Edit/5

        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="IdUser,IdHobby")> ByVal user_Hobby As User_Hobby) As ActionResult
            If ModelState.IsValid Then
                db.Entry(user_Hobby).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(user_Hobby)
        End Function

        ' GET: User_Hobby/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim user_Hobby As User_Hobby = db.User_Hobby.Find(id)
            If IsNothing(user_Hobby) Then
                Return HttpNotFound()
            End If
            Return View(user_Hobby)
        End Function

        ' POST: User_Hobby/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim user_Hobby As User_Hobby = db.User_Hobby.Find(id)
            db.User_Hobby.Remove(user_Hobby)
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
