Imports NHibernate.Cfg
Imports NHibernate
Imports System.Reflection

Namespace Models
    Public NotInheritable Class NHibernateHelper
        Private Shared _sessionFactory As ISessionFactory

        Private Shared Sub OpenSession()
            Dim configuration As New Configuration
            configuration.AddAssembly(Assembly.GetCallingAssembly())
            _sessionFactory = configuration.BuildSessionFactory()
        End Sub

        Public Shared Function GetCurrentSession() As ISession
            If IsNothing(_sessionFactory) Then
                OpenSession()
            End If

            Return _sessionFactory.OpenSession()
        End Function

        Public Shared Sub CloseSessionFactory()
            If Not IsNothing(_sessionFactory) Then
                _sessionFactory.Close()
            End If
        End Sub

    End Class
End Namespace