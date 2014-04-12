Imports ipa_intrAtrix.Models.Contracts
Imports NHibernate

Namespace Models
    Public Class ProviderHelper
        Public Function GetProviders() As IList(Of Provider)
            Dim providers As IList(Of Provider)
            Using session As ISession = NHibernateHelper.GetCurrentSession()

                Dim query As IQuery = session.CreateQuery("from Lieferant")
                providers = query.List(Of Provider)()
            End Using

            Return providers
        End Function

        Public Function GetProviderById(id As Integer) As Provider
            Dim provider As Provider = New Provider
            Using session As ISession = NHibernateHelper.GetCurrentSession()
                provider = session.Get(Of Provider)(id)
            End Using

            Return provider
        End Function

        Public Function CreateProvider(provider As Provider) As Integer
            Dim providerNo As Integer
            Using session As ISession = NHibernateHelper.GetCurrentSession()
                Using trans As ITransaction = session.BeginTransaction()
                    session.Save(provider)
                    trans.Commit()
                End Using
            End Using
            Return providerNo
        End Function

        Public Sub UpdateProvider(provider As Provider)
            Using session As ISession = NHibernateHelper.GetCurrentSession()
                Using trans As ITransaction = session.BeginTransaction()
                    session.Update(provider)
                    trans.Commit()
                End Using
            End Using
        End Sub

        Public Sub DeleteProvider(provider As Provider)
            Using session As ISession = NHibernateHelper.GetCurrentSession()
                Using trans As ITransaction = session.BeginTransaction()
                    session.Delete(provider)
                    trans.Commit()
                End Using
            End Using
        End Sub

    End Class
End Namespace