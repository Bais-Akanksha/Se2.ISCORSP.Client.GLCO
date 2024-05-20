Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.TransferLetter.Processors

#Region " Transfer Letter "

    Public Class TransferLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.TransferLetter"
            MyBase.Name = "TransferLetter"
            isXMLFile = True
            MyBase.RootNode = "TransferLetter"
            Me.[CLM].Add("Policies", New GLCO.TransferLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.TransferLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.TransferLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.TransferLetter.CLM.Role)
            Me.[CLM].Add("Exchanges", New GLCO.TransferLetter.CLM.Exchanges)
            Me.[CLM].Add("Exchange", New GLCO.TransferLetter.CLM.Exchange)
            Me.[CLM].Add("CarrierInformation", New GLCO.TransferLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.TransferLetter.CLM.Carrier)

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

#Region " Transfer Letter Redirect"

    Public Class TransferLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.TransferLetterRedirect"
            MyBase.Name = "TransferLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "TransferLetter"
            Me.[CLM].Add("Policies", New GLCO.TransferLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.TransferLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.TransferLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.TransferLetter.CLM.Role)
            Me.[CLM].Add("Exchanges", New GLCO.TransferLetter.CLM.Exchanges)
            Me.[CLM].Add("Exchange", New GLCO.TransferLetter.CLM.Exchange)
            Me.[CLM].Add("CarrierInformation", New GLCO.TransferLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.TransferLetter.CLM.Carrier)

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

#Region " Transfer Letter Fax"

    Public Class TransferLetterFax
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.TransferLetterFax"
            MyBase.Name = "TransferLetterFax"
            isXMLFile = True
            MyBase.RootNode = "TransferLetter"
            Me.[CLM].Add("Policies", New GLCO.TransferLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.TransferLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.TransferLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.TransferLetter.CLM.Role)
            Me.[CLM].Add("Exchanges", New GLCO.TransferLetter.CLM.Exchanges)
            Me.[CLM].Add("Exchange", New GLCO.TransferLetter.CLM.Exchange)
            Me.[CLM].Add("CarrierInformation", New GLCO.TransferLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.TransferLetter.CLM.Carrier)

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

