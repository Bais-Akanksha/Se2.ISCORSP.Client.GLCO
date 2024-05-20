Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.AddressChangeLetter.Processors

#Region " AddressChangeLetter "

    Public Class AddressChangeLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.AddressChangeLetter"
            MyBase.Name = "AddressChangeLetter"
            isXMLFile = True
            MyBase.RootNode = "AddressChangeLetter"
            Me.[CLM].Add("Policies", New GLCO.AddressChangeLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.AddressChangeLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.AddressChangeLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.AddressChangeLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.AddressChangeLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.AddressChangeLetter.CLM.Carrier)
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

#Region " Address Change Letter Redirect"

    Public Class AddressChangeLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.AddressChangeLetterRedirect"
            MyBase.Name = "AddressChangeLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "AddressChangeLetter"
            Me.[CLM].Add("Policies", New GLCO.AddressChangeLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.AddressChangeLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.AddressChangeLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.AddressChangeLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.AddressChangeLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.AddressChangeLetter.CLM.Carrier)

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
