Imports Se2.ISI.Base
Imports Se2.ISI.Base.Utility
Imports Se2.ISI.Base.Presentation
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.Messaging
Imports Newtonsoft.Json
Imports Se2.ISI.Base.DS.ReferenceData.ReferenceData
Imports System.Configuration


Namespace Se2.ISCORSP.Client.GLCO.EDelivery.CLM
#Region " EDelivery "
    Public Class EDelivery
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.EDelivery

        Public Property SGEmailService As SendGridEmailService

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.EDelivery
            Se2Source = New SourceLayouts.EDelivery
            MyBase.Se2Source = Me.Se2Source

            SGEmailService = New SendGridEmailService("ISCORSP.GLCO.EDelivery", Se2Source, Me, "GLCO")
        End Sub

#Region " POPULATION FUNCTIONS "
        Public Function BODY(ByVal value As Se2Args) As String
            Dim retval As New System.Text.StringBuilder

            Dim subject As String = SGEmailService.DataList.EncodedDataListSet.Item("EDeliverySubject").DataItem

            Dim contentlist As String = SGEmailService.BuildEmailBodyFromTemplate("EDeliveryTemplate")

            Dim a As New SendGridEmailService.successresponse

            If Se2Source.DELIVERYMETHOD = "E" Then
                Dim message As New SendGridEmailService.Body

                message = SGEmailService.DecorateMessage(contentlist, subject, "edelivery@gilico.com", Se2Source.EMAIL, Nothing, "GLCO_Do_not_reply@se2.com")

                '' As per Ethan adding the below block to capture the entire data into the tracking table added on 11/21/23 as per Ethan ******* '''''
                message.tracking_settings.enabled = True
                message.custom_args.se2trackingid = Se2Source.CONT
                message.custom_args.transactionid = Se2Source.TRANSACTIONID
                message.custom_args.transactiontype = "edelivery"
                message.custom_args.companycode = "GLCO"
                message.custom_args.emailoriginator = "DataServices"
                message.custom_args = SGEmailService.PackCustomArgs(message.custom_args)
                '' End adding the below block to capture the entire data into the tracking table added on 11/21/23 as per Ethan ******* '''''

                retval.Append("Post:" & vbCrLf & JsonConvert.SerializeObject(message) & vbCrLf & "Response:" & vbCrLf)

                a = SGEmailService.SendEmail(message)

                Dim outcome As String = a.message & vbCrLf

                retval.Append(outcome)
                'retval += SGEmailService.SendEmail(message).message
                If Not value.Accumulators.ContainsKey("DMReport") Then
                    value.Accumulators.Add("DMReport", "Delivery method: " & Se2Source.DELIVERYMETHOD)
                End If
            Else
                SGEmailService.SGsuccess = True
                retval.Append("Delivery method: " & Se2Source.DELIVERYMETHOD & " not delivered.")
                If Not value.Accumulators.ContainsKey("DMReport") Then
                    value.Accumulators.Add("DMReport", "Delivery method: " & Se2Source.DELIVERYMETHOD)
                End If
            End If

            retval.Append(vbNewLine & "ContractNumber:  " & Se2Source.CONT)
            Console.WriteLine(retval)
            retval.Append(vbNewLine & "MCPInstanceID:  " & Se2Source.TRANSACTIONID)
            Console.WriteLine(retval)
            retval.Append(vbNewLine & "eventID:  " & Se2Source.TRACKINGID)
            Console.WriteLine(retval)

            If Not SGEmailService.SGsuccess Then
                Dim failresult As New Se2.ISI.Base.Objects.Result

                failresult.Status = False
                failresult.Fail = True

                failresult.DisplayMessage.Add("Failed Via lack of success from SendGridEmailService")

                If Not IsNothing(a.message) Then
                    failresult.DisplayMessage.Add(a.message)
                End If

                Me.Result = failresult
            End If
            Dim results As Boolean = True
            Dim StoreEmail As New Se2.ISI.Base.Data.SQLExecutor

            StoreEmail.DataLocation = ConfigurationManager.AppSettings("connDOM")
            StoreEmail.ProcName = "[dbo].[DS.INSERT_LOG_STATUS_TRACKING]"

            Dim Parms As List(Of IDataParameter)
            Parms = New List(Of IDataParameter)

            StoreEmail.addParms("@TrackingID", Se2Source.TRACKINGID)
            StoreEmail.addParms("@CompanyCode", "GLCO")
            StoreEmail.addParms("@Contract", Se2Source.CONT)
            StoreEmail.addParms("@Email", Se2Source.EMAIL)
            StoreEmail.addParms("@DeliveryMethod", Se2Source.DELIVERYMETHOD)
            StoreEmail.addParms("@InsertUser", Environment.UserName)
            ' StoreEmail.addParms("@DocumentType", "eDevliery")
            StoreEmail.addParms("@DocumentType", "eDelivery") ''on 11/21/23
            StoreEmail.addParms("@CallingContext", Me.ToString)

            results = StoreEmail.ExecuteNonQuery

            If Not results Then

            End If
            Return retval.ToString



        End Function



        Public Function EDeliveryLogo(ByVal encouragement As String) As Object
            Dim retval As String = ""
            retval += SGEmailService.DataList.EncodedDataListSet.Item("EDeliveryLogo").DataItem
            Return retval
        End Function
        Public Function BuildEDelivery(ByVal polnum As String, ByVal emailaddress As String, ByVal emailbody As String, ByVal ccemailaddress As String) As SendGridEmailService.Body

            Dim subject As String = SGEmailService.DataList.EncodedDataListSet.Item("EDeliverySubject").DataItem
            Dim message As SendGridEmailService.Body = SGEmailService.DecorateMessage(emailbody, subject, "edelivery@gilico.com", Se2Source.EMAIL, Nothing, Nothing)

            message.tracking_settings.enabled = True
            message.custom_args.se2trackingid = Se2Source.CONT
            message.custom_args.transactionid = Se2Source.TRANSACTIONID
            message.custom_args.transactiontype = "edelivery"
            message.custom_args.companycode = "GLCO"
            message.custom_args.emailoriginator = "DataServices"
            message.custom_args = SGEmailService.PackCustomArgs(message.custom_args)


            Return message

        End Function
#End Region

    End Class
#End Region


End Namespace
