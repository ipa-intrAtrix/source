Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http

Public Class WebApiConfig
    Public Shared Sub Register(ByVal config As HttpConfiguration)
        config.Routes.MapHttpRoute( _
            name:="DefaultApi", _
            routeTemplate:="api/{controller}/{id}", _
            defaults:=New With {.id = RouteParameter.Optional} _
        )
        
        'Heben Sie die Kommentierung der folgenden Codezeile auf, um Abfrageunterstützung für Aktionen mit dem Rückgabetyp "IQueryable" oder "IQueryable(Of T)" zu aktivieren.
        'Damit die Verarbeitung unerwarteter oder böswilliger Abfragen vermieden wird, verwenden Sie die Überprüfungseinstellungen für "QueryableAttribute" zum Überprüfen eingehender Abfragen.
        'Weitere Informationen finden Sie unter "http://go.microsoft.com/fwlink/?LinkId=279712".
        'config.EnableQuerySupport()
    End Sub
End Class