Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.FIAPolicyPage.Processors

    Public Class POLICYPAGE
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.FIAPolicyPage"
            MyBase.Name = "POLICYPAGE"
            isXMLFile = True
            MyBase.RootNode = "Se2PolicyPages"
            Me.[CLM].Add("Policies", New GLCO.FIAPolicyPage.CLM.POLICIES)
            Me.[CLM].Add("Policy", New GLCO.FIAPolicyPage.CLM.POLICY)
            Me.[CLM].Add("Values", New GLCO.FIAPolicyPage.CLM.VALUES)
            Me.[CLM].Add("Value", New GLCO.FIAPolicyPage.CLM.VALUE)
            Me.[CLM].Add("Roles", New GLCO.FIAPolicyPage.CLM.ROLES)
            Me.[CLM].Add("Role", New GLCO.FIAPolicyPage.CLM.ROLE)
            Me.[CLM].Add("Phones", New GLCO.FIAPolicyPage.CLM.PHONES)
            Me.[CLM].Add("Phone", New GLCO.FIAPolicyPage.CLM.PHONE)
            Me.[CLM].Add("Addresses", New GLCO.FIAPolicyPage.CLM.ADDRESSES)
            Me.[CLM].Add("Address", New GLCO.FIAPolicyPage.CLM.ADDRESS)
            Me.[CLM].Add("Features", New GLCO.FIAPolicyPage.CLM.FEATURES)
            Me.[CLM].Add("Feature", New GLCO.FIAPolicyPage.CLM.FEATURE)
            'Me.[CLM].Add("Illustrations", New GLCO.FIAPolicyPage.CLM.ILLUSTRATIONS)
            'Me.[CLM].Add("Illustration", New GLCO.FIAPolicyPage.CLM.ILLUSTRATIONVALUES)
            Me.[CLM].Add("LtyIncomeRates", New GLCO.FIAPolicyPage.CLM.LTYINCOMERATES)
            Me.[CLM].Add("LtyIncomeRate", New GLCO.FIAPolicyPage.CLM.LTYINCOMERATE)
            NotificationSeconds = 1
        End Sub

        Public Overrides Function InitDataSource() As Boolean
            Try
                Me.DataSource = New DataSource.BASE_DATA(Args.cmdLnArgs)
                Return True
            Catch
                Return False
            End Try
        End Function

    End Class
End Namespace