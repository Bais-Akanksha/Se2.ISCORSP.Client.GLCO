Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.FixedAnnivStmt.Processors

#Region " FixedAnnivStmt "

    Public Class FixedAnnivStmt
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.FixedAnnivStmt"
            MyBase.Name = "FixedAnnivStmt"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.FixedAnnivStmt.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.FixedAnnivStmt.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.FixedAnnivStmt.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.FixedAnnivStmt.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.FixedAnnivStmt.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.FixedAnnivStmt.CLM.Carrier)
            Me.[CLM].Add("PolValues", New GLCO.FixedAnnivStmt.CLM.PolValues)
            Me.[CLM].Add("PolValue", New GLCO.FixedAnnivStmt.CLM.PolValue)
            Me.[CLM].Add("FundValues", New GLCO.FixedAnnivStmt.CLM.FundValues)
            Me.[CLM].Add("FundValue", New GLCO.FixedAnnivStmt.CLM.FundValue)
            Me.[CLM].Add("Features", New GLCO.FixedAnnivStmt.CLM.Features)
            Me.[CLM].Add("Feature", New GLCO.FixedAnnivStmt.CLM.Feature)
            Me.[CLM].Add("TransHst", New GLCO.FixedAnnivStmt.CLM.TransHst)
            Me.[CLM].Add("TxnHst", New GLCO.FixedAnnivStmt.CLM.TxnHst)
            Me.[CLM].Add("TransFndHst", New GLCO.FixedAnnivStmt.CLM.TransFndHst)
            Me.[CLM].Add("TxnFndHst", New GLCO.FixedAnnivStmt.CLM.TxnFndHst)
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

    Public Class FixedAnnivStmtRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.FixedAnnivStmtRedirect"
            MyBase.Name = "FixedAnnivStmtRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.FixedAnnivStmt.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.FixedAnnivStmt.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.FixedAnnivStmt.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.FixedAnnivStmt.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.FixedAnnivStmt.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.FixedAnnivStmt.CLM.Carrier)
            Me.[CLM].Add("PolValues", New GLCO.FixedAnnivStmt.CLM.PolValues)
            Me.[CLM].Add("PolValue", New GLCO.FixedAnnivStmt.CLM.PolValue)
            Me.[CLM].Add("FundValues", New GLCO.FixedAnnivStmt.CLM.FundValues)
            Me.[CLM].Add("FundValue", New GLCO.FixedAnnivStmt.CLM.FundValue)
            Me.[CLM].Add("Features", New GLCO.FixedAnnivStmt.CLM.Features)
            Me.[CLM].Add("Feature", New GLCO.FixedAnnivStmt.CLM.Feature)
            Me.[CLM].Add("TransHst", New GLCO.FixedAnnivStmt.CLM.TransHst)
            Me.[CLM].Add("TxnHst", New GLCO.FixedAnnivStmt.CLM.TxnHst)
            Me.[CLM].Add("TransFndHst", New GLCO.FixedAnnivStmt.CLM.TransFndHst)
            Me.[CLM].Add("TxnFndHst", New GLCO.FixedAnnivStmt.CLM.TxnFndHst)
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
