Imports ipa_intrAtrix.Models.Contracts
Imports NHibernate

Namespace Models

    Public Class CustomerHelper
        Public Function GetCustomerNetworks() As IList(Of CustomerNetwork)
            Dim customerNetworks As IList(Of CustomerNetwork)
            Using session As ISession = NHibernateHelper.GetCurrentSession()

                Dim query As IQuery = session.CreateQuery("from Kundennetzwerk")
                customerNetworks = query.List(Of CustomerNetwork)()
            End Using

            Return customerNetworks
        End Function

        Public Function GetCustomerNetworkById(id As Integer) As CustomerNetwork
            Dim customerNetwork As CustomerNetwork = New CustomerNetwork
            Using session As ISession = NHibernateHelper.GetCurrentSession()
                customerNetwork = session.Get(Of CustomerNetwork)(id)
            End Using

            Return customerNetwork
        End Function

        Public Function CreateCustomerNetwork(customerNetwork As CustomerNetwork) As Integer
            Dim customerNetworkNo As Integer
            Using session As ISession = NHibernateHelper.GetCurrentSession()
                Using trans As ITransaction = session.BeginTransaction()
                    session.Save(customerNetwork)
                    trans.Commit()
                End Using
            End Using
            Return customerNetworkNo
        End Function

        Public Sub UpdateCustomerNetwork(customerNetwork As CustomerNetwork)
            Using session As ISession = NHibernateHelper.GetCurrentSession()
                Using trans As ITransaction = session.BeginTransaction()
                    session.Update(customerNetwork)
                    trans.Commit()
                End Using
            End Using
        End Sub

        Public Sub DeleteCustomerNetwork(customerNetwork As CustomerNetwork)
            Using session As ISession = NHibernateHelper.GetCurrentSession()
                Using trans As ITransaction = session.BeginTransaction()
                    session.Delete(customerNetwork)
                    trans.Commit()
                End Using
            End Using
        End Sub
    End Class
End Namespace