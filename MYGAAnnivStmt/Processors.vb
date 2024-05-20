Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.MYGAAnnivStmt.Processors

#Region " MYGAAnnivStmt "

    Public Class MYGAAnnivStmt
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.MYGAAnnivStmt"
            MyBase.Name = "MYGAAnnivStmt"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("HDR", New GLCO.MYGAAnnivStmt.CLM.HDR)
            Me.[CLM].Add("Policies", New GLCO.MYGAAnnivStmt.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.MYGAAnnivStmt.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.MYGAAnnivStmt.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.MYGAAnnivStmt.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.MYGAAnnivStmt.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.MYGAAnnivStmt.CLM.Carrier)
            Me.[CLM].Add("PolValues", New GLCO.MYGAAnnivStmt.CLM.PolValues)
            Me.[CLM].Add("PolValue", New GLCO.MYGAAnnivStmt.CLM.PolValue)
            Me.[CLM].Add("FundValues", New GLCO.MYGAAnnivStmt.CLM.FundValues)
            Me.[CLM].Add("FundValue", New GLCO.MYGAAnnivStmt.CLM.FundValue)
            Me.[CLM].Add("PriorAnnvFunds", New GLCO.MYGAAnnivStmt.CLM.PriorAnnvFunds)
            Me.[CLM].Add("PriorAnnvFund", New GLCO.MYGAAnnivStmt.CLM.PriorAnnvFund)
            Me.[CLM].Add("TransHst", New GLCO.MYGAAnnivStmt.CLM.TransHst)
            Me.[CLM].Add("TxnHst", New GLCO.MYGAAnnivStmt.CLM.TxnHst)
            Me.[CLM].Add("TransFndHst", New GLCO.MYGAAnnivStmt.CLM.TransFndHst)
            Me.[CLM].Add("TxnFndHst", New GLCO.MYGAAnnivStmt.CLM.TxnFndHst)
            Me.[CLM].Add("RenewalRates", New GLCO.MYGAAnnivStmt.CLM.RenewalRates)
            Me.[CLM].Add("RenewRates", New GLCO.MYGAAnnivStmt.CLM.RenewRates)
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

#Region "MYGAAnnivStmtRedirect"

    Public Class MYGAAnnivStmtRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.MYGAAnnivStmtRedirect"
            MyBase.Name = "MYGAAnnivStmtRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("HDR", New GLCO.MYGAAnnivStmt.CLM.HDR)
            Me.[CLM].Add("Policies", New GLCO.MYGAAnnivStmt.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.MYGAAnnivStmt.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.MYGAAnnivStmt.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.MYGAAnnivStmt.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.MYGAAnnivStmt.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.MYGAAnnivStmt.CLM.Carrier)
            Me.[CLM].Add("PolValues", New GLCO.MYGAAnnivStmt.CLM.PolValues)
            Me.[CLM].Add("PolValue", New GLCO.MYGAAnnivStmt.CLM.PolValue)
            Me.[CLM].Add("FundValues", New GLCO.MYGAAnnivStmt.CLM.FundValues)
            Me.[CLM].Add("FundValue", New GLCO.MYGAAnnivStmt.CLM.FundValue)
            Me.[CLM].Add("PriorAnnvFunds", New GLCO.MYGAAnnivStmt.CLM.PriorAnnvFunds)
            Me.[CLM].Add("PriorAnnvFund", New GLCO.MYGAAnnivStmt.CLM.PriorAnnvFund)
            Me.[CLM].Add("TransHst", New GLCO.MYGAAnnivStmt.CLM.TransHst)
            Me.[CLM].Add("TxnHst", New GLCO.MYGAAnnivStmt.CLM.TxnHst)
            Me.[CLM].Add("TransFndHst", New GLCO.MYGAAnnivStmt.CLM.TransFndHst)
            Me.[CLM].Add("TxnFndHst", New GLCO.MYGAAnnivStmt.CLM.TxnFndHst)
            Me.[CLM].Add("RenewalRates", New GLCO.MYGAAnnivStmt.CLM.RenewalRates)
            Me.[CLM].Add("RenewRates", New GLCO.MYGAAnnivStmt.CLM.RenewRates)
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

#End Region

#End Region

End Namespace
