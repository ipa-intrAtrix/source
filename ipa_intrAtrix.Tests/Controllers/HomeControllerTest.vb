Imports System.Web.Mvc
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class HomeControllerTest

    <TestMethod()> Public Sub Index()
        ' Arrange
        Dim controller As New HomeController()

        ' Act
        Dim result As ViewResult = DirectCast(controller.Index(), ViewResult)

        ' Assert
        Dim viewData As ViewDataDictionary = result.ViewData
        Assert.AreEqual("Dies ist die Startseite des Intranets von Atrix - IntrAtrix", viewData("Message"))
    End Sub
End Class
