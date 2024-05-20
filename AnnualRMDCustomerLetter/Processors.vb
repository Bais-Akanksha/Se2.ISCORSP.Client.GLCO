Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.AnnualRMDCustomerLetter.Processors

#Region " AnnualRMDCustomerLetter "

    Public Class AnnualRMDCustomerLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0
        Public WatchDogData As WatchDogHelper
        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.AnnualRMDCustomerLetter"
            MyBase.Name = "AnnualRMDCustomerLetter"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("HDR", New GLCO.AnnualRMDCustomerLetter.CLM.HDR)
            Me.[CLM].Add("Policies", New GLCO.AnnualRMDCustomerLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.AnnualRMDCustomerLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.AnnualRMDCustomerLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.AnnualRMDCustomerLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.AnnualRMDCustomerLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.AnnualRMDCustomerLetter.CLM.Carrier)
            Me.[CLM].Add("PolValues", New GLCO.AnnualRMDCustomerLetter.CLM.PolValues)
            Me.[CLM].Add("PolValue", New GLCO.AnnualRMDCustomerLetter.CLM.PolValue)
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
        Protected Overrides Sub PostFileEndHandler(ByRef e As ISIEventsArgs)
            MyBase.PostFileEndHandler(e)
            Try
                WatchDogData = New WatchDogHelper(Args)
                WatchDogData.SendPayloadtoCarrierDashboard()
            Catch ex As System.Exception
                Result.Status = False
            Throw ex
            End Try
        End Sub
    End Class

#Region " AnnualRMDCustomerLetter Redirect"

    Public Class AnnualRMDCustomerLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0
        Public WatchDogData As WatchDogHelper

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.AnnualRMDCustomerLetterRedirect"
            MyBase.Name = "AnnualRMDCustomerLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("HDR", New GLCO.AnnualRMDCustomerLetter.CLM.HDR)
            Me.[CLM].Add("Policies", New GLCO.AnnualRMDCustomerLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.AnnualRMDCustomerLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.AnnualRMDCustomerLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.AnnualRMDCustomerLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.AnnualRMDCustomerLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.AnnualRMDCustomerLetter.CLM.Carrier)
            Me.[CLM].Add("PolValues", New GLCO.AnnualRMDCustomerLetter.CLM.PolValues)
            Me.[CLM].Add("PolValue", New GLCO.AnnualRMDCustomerLetter.CLM.PolValue)
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
        Protected Overrides Sub PostFileEndHandler(ByRef e As ISIEventsArgs)
            MyBase.PostFileEndHandler(e)
            Try
                WatchDogData = New WatchDogHelper(Args)
                WatchDogData.SendPayloadtoCarrierDashboard()
            Catch ex As System.Exception
                Result.Status = False
                Throw ex
            End Try
        End Sub
    End Class

#End Region

#End Region

End Namespace
