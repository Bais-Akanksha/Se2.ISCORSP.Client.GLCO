Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.FIA3AnnivStmt.Processors

#Region " FIA3AnnivStmt "

    Public Class FIA3AnnivStmt
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.FIA3AnnivStmt"
            MyBase.Name = "FIA3AnnivStmt"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.FIA3AnnivStmt.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.FIA3AnnivStmt.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.FIA3AnnivStmt.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.FIA3AnnivStmt.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.FIA3AnnivStmt.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.FIA3AnnivStmt.CLM.Carrier)
            Me.[CLM].Add("Features", New GLCO.FIA3AnnivStmt.CLM.Features)
            Me.[CLM].Add("Feature", New GLCO.FIA3AnnivStmt.CLM.Feature)
            Me.[CLM].Add("PolValues", New GLCO.FIA3AnnivStmt.CLM.PolValues)
            Me.[CLM].Add("PolValue", New GLCO.FIA3AnnivStmt.CLM.PolValue)
            Me.[CLM].Add("FundValues", New GLCO.FIA3AnnivStmt.CLM.FundValues)
            Me.[CLM].Add("FundValue", New GLCO.FIA3AnnivStmt.CLM.FundValue)
            Me.[CLM].Add("PriorAnnvFunds", New GLCO.FIA3AnnivStmt.CLM.PriorAnnvFunds)
            Me.[CLM].Add("PriorAnnvFund", New GLCO.FIA3AnnivStmt.CLM.PriorAnnvFund)
            Me.[CLM].Add("TransHst", New GLCO.FIA3AnnivStmt.CLM.TransHst)
            Me.[CLM].Add("TxnHst", New GLCO.FIA3AnnivStmt.CLM.TxnHst)
            Me.[CLM].Add("TransFndHst", New GLCO.FIA3AnnivStmt.CLM.TransFndHst)
            Me.[CLM].Add("TxnFndHst", New GLCO.FIA3AnnivStmt.CLM.TxnFndHst)
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

#Region " FIA3AnnivStmt Redirect"

    Public Class FIA3AnnivStmtRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.FIA3AnnivStmtRedirect"
            MyBase.Name = "FIA3AnnivStmtRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.FIA3AnnivStmt.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.FIA3AnnivStmt.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.FIA3AnnivStmt.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.FIA3AnnivStmt.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.FIA3AnnivStmt.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.FIA3AnnivStmt.CLM.Carrier)
            Me.[CLM].Add("Features", New GLCO.FIA3AnnivStmt.CLM.Features)
            Me.[CLM].Add("Feature", New GLCO.FIA3AnnivStmt.CLM.Feature)
            Me.[CLM].Add("PolValues", New GLCO.FIA3AnnivStmt.CLM.PolValues)
            Me.[CLM].Add("PolValue", New GLCO.FIA3AnnivStmt.CLM.PolValue)
            Me.[CLM].Add("FundValues", New GLCO.FIA3AnnivStmt.CLM.FundValues)
            Me.[CLM].Add("FundValue", New GLCO.FIA3AnnivStmt.CLM.FundValue)
            Me.[CLM].Add("PriorAnnvFunds", New GLCO.FIA3AnnivStmt.CLM.PriorAnnvFunds)
            Me.[CLM].Add("PriorAnnvFund", New GLCO.FIA3AnnivStmt.CLM.PriorAnnvFund)
            Me.[CLM].Add("TransHst", New GLCO.FIA3AnnivStmt.CLM.TransHst)
            Me.[CLM].Add("TxnHst", New GLCO.FIA3AnnivStmt.CLM.TxnHst)
            Me.[CLM].Add("TransFndHst", New GLCO.FIA3AnnivStmt.CLM.TransFndHst)
            Me.[CLM].Add("TxnFndHst", New GLCO.FIA3AnnivStmt.CLM.TxnFndHst)

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
