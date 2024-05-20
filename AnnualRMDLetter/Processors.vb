Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.AnnualRMDLetter.Processors

#Region " AnnualRMDLetter"

    Public Class AnnualRMDLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.AnnualRMDLetter"
            MyBase.Name = "AnnualRMDLetter"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.AnnualRMDLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.AnnualRMDLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.AnnualRMDLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.AnnualRMDLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.AnnualRMDLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.AnnualRMDLetter.CLM.Carrier)
            Me.[CLM].Add("PolValues", New GLCO.AnnualRMDLetter.CLM.PolValues)
            Me.[CLM].Add("PolValue", New GLCO.AnnualRMDLetter.CLM.PolValue)
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

#Region " Annual RMD Letter Redirect"

    Public Class AnnualRMDLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.AnnualRMDLetterRedirect"
            MyBase.Name = "AnnualRMDLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "AnnualRMDLetter"
            Me.[CLM].Add("Policies", New GLCO.AnnualRMDLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.AnnualRMDLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.AnnualRMDLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.AnnualRMDLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.AnnualRMDLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.AnnualRMDLetter.CLM.Carrier)
            Me.[CLM].Add("PolValues", New GLCO.AnnualRMDLetter.CLM.PolValues)
            Me.[CLM].Add("PolValue", New GLCO.AnnualRMDLetter.CLM.PolValue)

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
