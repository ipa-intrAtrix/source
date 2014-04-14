Imports NHibernate.Criterion
Imports ipa_intrAtrix.Models.Contracts
Imports NHibernate

Namespace Models

    Public Class CustomerHelper
        Public Function GetCustomerNetworks() As IList(Of CustomerNetwork)
            Dim customerNetworks As IList(Of CustomerNetwork)
            Using session As ISession = NHibernateHelper.GetCurrentSession()

                Dim criteria As ICriteria = session.CreateCriteria(GetType(CustomerNetwork))
                customerNetworks = criteria.List(Of CustomerNetwork)()
            End Using

            Return customerNetworks
        End Function

        Public Function GetCustomerNetworkById(id As Integer) As CustomerNetwork
            Using session As ISession = NHibernateHelper.GetCurrentSession()
                Return session.CreateCriteria(Of CustomerNetwork)().Add(Restrictions.Eq("CustId", id)).UniqueResult(Of CustomerNetwork)()
            End Using
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