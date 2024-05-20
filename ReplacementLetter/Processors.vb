Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.ReplacementLetter.Processors

#Region " ReplacementLetter "

    Public Class ReplacementLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.ReplacementLetter"
            MyBase.Name = "ReplacementLetter"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.ReplacementLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.ReplacementLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.ReplacementLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.ReplacementLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.ReplacementLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.ReplacementLetter.CLM.Carrier)
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

#Region " ReplacementLetter Redirect"

    Public Class ReplacementLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.ReplacementLetterRedirect"
            MyBase.Name = "ReplacementLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.ReplacementLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.ReplacementLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.ReplacementLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.ReplacementLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.ReplacementLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.ReplacementLetter.CLM.Carrier)

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
