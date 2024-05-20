Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.FIAAnnivStmt.Processors

#Region " FIAAnnivStmt "

    Public Class FIAAnnivStmt
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.FIAAnnivStmt"
            MyBase.Name = "FIAAnnivStmt"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.FIAAnnivStmt.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.FIAAnnivStmt.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.FIAAnnivStmt.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.FIAAnnivStmt.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.FIAAnnivStmt.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.FIAAnnivStmt.CLM.Carrier)
            Me.[CLM].Add("Features", New GLCO.FIAAnnivStmt.CLM.Features)
            Me.[CLM].Add("Feature", New GLCO.FIAAnnivStmt.CLM.Feature)
            Me.[CLM].Add("PolValues", New GLCO.FIAAnnivStmt.CLM.PolValues)
            Me.[CLM].Add("PolValue", New GLCO.FIAAnnivStmt.CLM.PolValue)
            Me.[CLM].Add("FundValues", New GLCO.FIAAnnivStmt.CLM.FundValues)
            Me.[CLM].Add("FundValue", New GLCO.FIAAnnivStmt.CLM.FundValue)
            Me.[CLM].Add("PriorAnnvFunds", New GLCO.FIAAnnivStmt.CLM.PriorAnnvFunds)
            Me.[CLM].Add("PriorAnnvFund", New GLCO.FIAAnnivStmt.CLM.PriorAnnvFund)
            Me.[CLM].Add("TransHst", New GLCO.FIAAnnivStmt.CLM.TransHst)
            Me.[CLM].Add("TxnHst", New GLCO.FIAAnnivStmt.CLM.TxnHst)
            Me.[CLM].Add("TransFndHst", New GLCO.FIAAnnivStmt.CLM.TransFndHst)
            Me.[CLM].Add("TxnFndHst", New GLCO.FIAAnnivStmt.CLM.TxnFndHst)
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

#Region "FIAAnnivStmtRedirect"

    Public Class FIAAnnivStmtRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.FIAAnnivStmtRedirect"
            MyBase.Name = "FIAAnnivStmtRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.FIAAnnivStmt.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.FIAAnnivStmt.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.FIAAnnivStmt.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.FIAAnnivStmt.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.FIAAnnivStmt.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.FIAAnnivStmt.CLM.Carrier)
            Me.[CLM].Add("Features", New GLCO.FIAAnnivStmt.CLM.Features)
            Me.[CLM].Add("Feature", New GLCO.FIAAnnivStmt.CLM.Feature)
            Me.[CLM].Add("PolValues", New GLCO.FIAAnnivStmt.CLM.PolValues)
            Me.[CLM].Add("PolValue", New GLCO.FIAAnnivStmt.CLM.PolValue)
            Me.[CLM].Add("FundValues", New GLCO.FIAAnnivStmt.CLM.FundValues)
            Me.[CLM].Add("FundValue", New GLCO.FIAAnnivStmt.CLM.FundValue)
            Me.[CLM].Add("PriorAnnvFunds", New GLCO.FIAAnnivStmt.CLM.PriorAnnvFunds)
            Me.[CLM].Add("PriorAnnvFund", New GLCO.FIAAnnivStmt.CLM.PriorAnnvFund)
            Me.[CLM].Add("TransHst", New GLCO.FIAAnnivStmt.CLM.TransHst)
            Me.[CLM].Add("TxnHst", New GLCO.FIAAnnivStmt.CLM.TxnHst)
            Me.[CLM].Add("TransFndHst", New GLCO.FIAAnnivStmt.CLM.TransFndHst)
            Me.[CLM].Add("TxnFndHst", New GLCO.FIAAnnivStmt.CLM.TxnFndHst)
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
