Imports System.IO
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.Queue

Namespace Se2.ISCORSP.Client.GLCO.EDelivery.Processors

#Region " EDelivery "

    Public Class EDelivery
        Inherits BaseProcessor

        Private Outputcount As Integer = 0
        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.EDelivery"
            MyBase.Name = "EDelivery"
            'isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("EDelivery", New GLCO.EDelivery.CLM.EDelivery)
            'Me.[CLM].Add("Inforce", New GLCO.EDelivery.CLM.EDelivery)
            MyBase.IncludeInstanceIDInFileName = True
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

        'Public Overrides Sub End_Process_Record()
        '    MyBase.End_Process_Record()
        '    Try
        '        If Outputcount = 0 Then
        '            If Not IsNothing(CurrentCLM) Then
        '                If Not IsNothing(CurrentCLM.Se2Source) Then
        '                    Console.WriteLine(CurrentCLM.ToString)

        '                    Console.WriteLine(Me.CurrentCLM.ClientRecord.ToString)

        '                    Dim Publisher As New MessageProcessor

        '                    Publisher.AddProps("Sender", "DataServices")
        '                    Publisher.AddProps("Receiver", "Spectrum-ESB")
        '                    Publisher.AddProps("TransactionName", "PolicyPage-EDelivery") 'what name do we need 
        '                    Publisher.AddProps("StatusResponseRequired", "No")
        '                    If Me.Args.Accumulators.ContainsKey("SourceTrxId") Then
        '                        Publisher.AddProps("NMSCorrelationID", Me.Args.Accumulators.Item("SourceTrxId").ToString)
        '                    End If

        '                    Dim message As String = ""
        '                    message += "Contract: " & Me.Args.cmdLnArgs.FILENAMEKEY & vbNewLine
        '                    message += "MCPInstanceID: " & Me.Args.cmdLnArgs.TRACKINGID & vbNewLine
        '                    If Args.cmdLnArgs.CUSTOM.ContainsKey("Document Type") Then
        '                        message += "Document Type: " & Args.cmdLnArgs.CUSTOM.Item("Document Type") & vbNewLine
        '                    Else
        '                        message += "Document Type: " & Args.cmdLnArgs.CUSTOM.Item("DocumentType") & vbNewLine
        '                    End If
        '                    message += "ProcessedRecords: " & Me.Args.ProcessedRecords & vbNewLine
        '                        If Me.Args.Accumulators.ContainsKey("DMReport") Then
        '                            message += Me.Args.Accumulators.Item("DMReport").ToString
        '                        End If
        '                        Publisher.PublishMessage("spectrum.transaction.log", message)
        '                    End If
        '                End If
        '            Outputcount += 1
        '        End If
        '    Catch ex As System.Exception
        '        Throw ex
        '    End Try

        'End Sub

    End Class


#End Region



End Namespace
