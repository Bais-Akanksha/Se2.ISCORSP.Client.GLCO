Imports System.IO
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.Queue

Namespace Se2.ISCORSP.Client.GLCO.EDeliverySGReport.Processors

#Region " EDeliverySGReport "

    Public Class EDeliverySGReport
        Inherits BaseProcessor

        Private Outputcount As Integer = 0
        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.EDeliverySGReport"
            MyBase.Name = "EDeliverySGReport"
            'isXMLFile = True
            Me.IncludeInstanceIDInFileName = True
            Me.[CLM].Add("EDeliverySGReport", New GLCO.EDeliverySGReport.CLM.EDeliverySGReport)
            'Me.[CLM].Add("Email", New GLCO.EDelivery.CLM.EDelivery)
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
