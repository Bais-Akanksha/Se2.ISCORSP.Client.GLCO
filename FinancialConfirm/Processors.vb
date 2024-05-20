Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.FinancialConfirm.Processors

#Region " Financial Confirm"

    Public Class FinancialConfirm
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.FinancialConfirm"
            MyBase.Name = "FinancialConfirm"
            isXMLFile = True
            MyBase.RootNode = "FinancialConfirm"
            Me.[CLM].Add("Policies", New GLCO.FinancialConfirm.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.FinancialConfirm.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.FinancialConfirm.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.FinancialConfirm.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.FinancialConfirm.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.FinancialConfirm.CLM.Carrier)
            Me.[CLM].Add("TransactionSummaries", New GLCO.FinancialConfirm.CLM.TransactionSummaries)
            Me.[CLM].Add("TransactionSummary", New GLCO.FinancialConfirm.CLM.TransactionSummary)
             Me.[CLM].Add("TransactionDetails", New GLCO.FinancialConfirm.CLM.TransactionDetails)
            Me.[CLM].Add("TransactionDetail", New GLCO.FinancialConfirm.CLM.TransactionDetail)
            Me.[CLM].Add("TransactionTotals", New GLCO.FinancialConfirm.CLM.TransactionTotals)
            Me.[CLM].Add("TransactionTotal", New GLCO.FinancialConfirm.CLM.TransactionTotal)
            Me.[CLM].Add("FeeDetails", New GLCO.FinancialConfirm.CLM.FeeDetails)
            Me.[CLM].Add("FeeDetail", New GLCO.FinancialConfirm.CLM.FeeDetail)
            Me.[CLM].Add("AccountDetails", New GLCO.FinancialConfirm.CLM.AccountDetails)
            Me.[CLM].Add("AccountDetail", New GLCO.FinancialConfirm.CLM.AccountDetail)
            Me.[CLM].Add("AccountTotals", New GLCO.FinancialConfirm.CLM.AccountTotals)
            Me.[CLM].Add("AccountTotal", New GLCO.FinancialConfirm.CLM.AccountTotal)

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

#Region " Financial Confirm Redirect"

    Public Class FinancialConfirmRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.FinancialConfirmRedirect"
            MyBase.Name = "FinancialConfirmRedirect"
            isXMLFile = True
            MyBase.RootNode = "FinancialConfirm"
            Me.[CLM].Add("Policies", New GLCO.FinancialConfirm.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.FinancialConfirm.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.FinancialConfirm.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.FinancialConfirm.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.FinancialConfirm.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.FinancialConfirm.CLM.Carrier)
            Me.[CLM].Add("TransactionSummaries", New GLCO.FinancialConfirm.CLM.TransactionSummaries)
            Me.[CLM].Add("TransactionSummary", New GLCO.FinancialConfirm.CLM.TransactionSummary)
            Me.[CLM].Add("TransactionDetails", New GLCO.FinancialConfirm.CLM.TransactionDetails)
            Me.[CLM].Add("TransactionDetail", New GLCO.FinancialConfirm.CLM.TransactionDetail)
            Me.[CLM].Add("TransactionTotals", New GLCO.FinancialConfirm.CLM.TransactionTotals)
            Me.[CLM].Add("TransactionTotal", New GLCO.FinancialConfirm.CLM.TransactionTotal)
            Me.[CLM].Add("FeeDetails", New GLCO.FinancialConfirm.CLM.FeeDetails)
            Me.[CLM].Add("FeeDetail", New GLCO.FinancialConfirm.CLM.FeeDetail)
            Me.[CLM].Add("AccountDetails", New GLCO.FinancialConfirm.CLM.AccountDetails)
            Me.[CLM].Add("AccountDetail", New GLCO.FinancialConfirm.CLM.AccountDetail)
            Me.[CLM].Add("AccountTotals", New GLCO.FinancialConfirm.CLM.AccountTotals)
            Me.[CLM].Add("AccountTotal", New GLCO.FinancialConfirm.CLM.AccountTotal)

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
End Namespace

