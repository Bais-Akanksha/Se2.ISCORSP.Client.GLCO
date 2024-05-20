Imports Se2.ISI.Base
Imports Se2.ISI.Base.Utility
Imports Se2.ISI.Base.Presentation
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.Queue
Imports System.Configuration
Imports Newtonsoft.Json
'switch to sendgridemailservice to change it


Namespace Se2.ISCORSP.Client.GLCO.EDeliverySGReport.CLM

#Region " EDeliverySGReport "
    Public Class EDeliverySGReport
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.EDeliverySGReport

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.EDeliverySGReport
            Se2Source = New SourceLayouts.EDeliverySGReport
            MyBase.Se2Source = Me.Se2Source
        End Sub

#Region " POPULATION FUNCTIONS "
        Public Function BODY(ByVal value As Se2Args) As String
            Dim retval As String = ""

            Dim responses As List(Of SGResponse) = JsonConvert.DeserializeObject(Of List(Of SGResponse))(Se2Source.Content)
            retval = ""

            For Each response As SGResponse In responses
                'If response.event <> "delivered" Then

                Dim Publisher As New MessageProcessor

                Publisher.AddProps("Sender", "DataServices")
                Publisher.AddProps("Receiver", "ECM")
                Publisher.AddProps("Transaction", "WFT")
                Publisher.AddProps("NMSCorrelationID", Se2Source.MULE_CORRELATION_ID)


                Dim ECMmsg As New OnBaseDocumentCreation
                ECMmsg.ProcCoAbbr = "GLCO"
                ECMmsg.Source = "Data Services"
                ECMmsg.SourceCode = "M"
                ECMmsg.TransactionName = "EMAIL REQUIRED"
                ECMmsg.RefID = value.cmdLnArgs.TRACKINGID
                ECMmsg.KeyWords = New Dictionary(Of String, String)
                ECMmsg.KeyWords.Add("Contract #", response.se2trackingid)
                If response.event = "delivered" Then
                    ECMmsg.KeyWords.Add("ROUTE", "Complete")
                End If

                Dim HTML As New HTMLFile

                HTML.Description = "Contract: " & response.se2trackingid & " failed on email delivery with code: " & response.event & ".<BR> Please refer to email bounce back processing procedures.<BR> Email Address: " & response.email
                HTML.Header = "Email Status Undelivered"
                ECMmsg.HTMLFile = New List(Of HTMLFile)
                ECMmsg.HTMLFile.Add(HTML)

                Dim message As String = JsonConvert.SerializeObject(ECMmsg)


                Publisher.PublishMessage(ConfigurationManager.AppSettings("ACTIVEMQ_QUEUE_ECM"), message)

                retval += "Contract: " & response.se2trackingid & " failed with code: " & response.event & " for: " & response.email & " and was sent to ECM."
                'Else
                '    retval += "Contract: " & response.se2trackingid & " for: " & response.email & " delivered successfully."
                'End If
            Next
            Console.WriteLine(retval)

            Return retval
        End Function
#End Region

    End Class
#End Region

    Public Class SGResponse
        Public Property [event] As String
        Public Property email As String
        Public Property se2trackingid As String
        Public Property transactionid As String
        Public Property timestamp As Integer
        Public Property transactiontype As String
    End Class

    'Public Class ECMIngestionMessage
    '    Inherits IMessage

    '    Public TransactionName As String
    '    Public RefID As String
    '    Public Payload As String
    'End Class

    Public Class OnBaseDocumentCreation
        Public RefID As String
        Public ProcCoAbbr As String
        Public Source As String
        Public SourceCode As String
        Public TransactionName As String
        Public KeyWords As Dictionary(Of String, String)
        Public DocumentFile As List(Of OnBaseDocumentFileInfo)
        Public HTMLFile As List(Of HTMLFile)
    End Class

    Public Class HTMLFile
        Public Header As String
        Public Description As String
    End Class

    Public Class OnBaseDocumentFileInfo
        Public FileMimeType As String
        Public FileExtension As String
        Public FileBase64 As String
    End Class


End Namespace
