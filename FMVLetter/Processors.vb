Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.FMVLetter.Processors

#Region " FMVLetter "

    Public Class FMVLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.FMVLetter"
            MyBase.Name = "FMVLetter"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.FMVLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.FMVLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.FMVLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.FMVLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.FMVLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.FMVLetter.CLM.Carrier)
            Me.[CLM].Add("PolValues", New GLCO.FMVLetter.CLM.PolValues)
            Me.[CLM].Add("PolValue", New GLCO.FMVLetter.CLM.PolValue)
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

#Region " FMVLetter Redirect"

    Public Class FMVLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.FMVLetterRedirect"
            MyBase.Name = "FMVLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.FMVLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.FMVLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.FMVLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.FMVLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.FMVLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.FMVLetter.CLM.Carrier)

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

