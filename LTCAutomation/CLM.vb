Imports Se2.ISI.Base
Imports Se2.ISI.Base.Utility
Imports Se2.ISI.Base.Presentation
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.Messaging
Imports Newtonsoft.Json
Imports Se2.ISI.Base.DS.ReferenceData.ReferenceData
Imports System.Configuration


Namespace Se2.ISCORSP.Client.GLCO.LTCAutomation.CLM


#Region " LTCAutomation "
    Public Class LTCAutomation
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.LTCAutomation
        Public Property SGsuccess As Boolean = False
        Public Property SGEmailService As SendGridEmailService

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.LTCAutomation
            Se2Source = New SourceLayouts.LTCAutomation
            MyBase.Se2Source = Me.Se2Source
            SGEmailService = New SendGridEmailService("ISCORSP.GLCO.LTCAutomation", Se2Source, Me, "GLCO")
        End Sub

#Region " POPULATION FUNCTIONS "
        Public Function BODY(ByVal value As Se2Args) As String
            Dim retval As New System.Text.StringBuilder
            Dim emailbody As String = ""
            Dim toemail As String = ""
            Dim ccemail As String = Nothing


            emailbody = SGEmailService.BuildEmailBodyFromTemplate("GLCOLTCAutomationTemplate")
            'if its QA hard code your eamilid
            toemail = "claimsintake@ltcg.com,gilico.ops.se2@gilico.com,GILICO_WF@se2.com"

            'ccemail = "jagadeesan.g@se2.com"


            Dim a As New SendGridEmailService.successresponse

            'If Se2Source.DeliveryDesc = "E" Then
            Dim message As New SendGridEmailService.Body

            message = BuildLTCAutomationMessage(Se2Source.CONT, toemail, emailbody, ccemail)

            retval.Append("Post:" & vbCrLf & JsonConvert.SerializeObject(message) & vbCrLf & "Response:" & vbCrLf)

            a = SGEmailService.SendEmail(message)

            Dim outcome As String = a.message & vbCrLf

            retval.Append(outcome)


            If Not value.Accumulators.ContainsKey("DMReport") Then
                value.Accumulators.Add("DMReport", "Delivery method: " & "E") 'Se2Source.DeliveryDesc)
            End If
            'Else
            '    SGEmailService.SGsuccess = True
            '    retval.Append("Delivery method: " & Se2Source.DeliveryDesc & " not delivered.")
            '    If Not value.Accumulators.ContainsKey("DMReport") Then
            '        value.Accumulators.Add("DMReport", "Delivery method: " & Se2Source.DeliveryDesc)
            '    End If
            'End If

            Dim DSTrackingID As String = System.Guid.NewGuid.ToString

            retval.Append(vbNewLine & "ContractNumber:  " & Se2Source.CONT)
            Console.WriteLine(retval)
            retval.Append(vbNewLine & "MCPInstanceID:  " & value.cmdLnArgs.TRACKINGID)
            Console.WriteLine(retval)
            retval.Append(vbNewLine & "DSTrackingID:  " & DSTrackingID)
            Console.WriteLine(retval)

            If Not SGEmailService.SGsuccess Then
                Dim failresult As New Se2.ISI.Base.Objects.Result

                failresult.Status = False
                failresult.Fail = True

                failresult.DisplayMessage.Add("Failed Via lack of success from SendGridEmailService")

                If Not IsNothing(a.message) Then
                    failresult.DisplayMessage.Add(a.message)
                End If

                failresult.DisplayMessage.Add(a.message)

                Me.Result = failresult
            End If

            'log to Logging.DataServicesStatusTracking table
            Dim results As Boolean = True
            Dim StoreEmail As New Se2.ISI.Base.Data.SQLExecutor

            StoreEmail.DataLocation = ConfigurationManager.AppSettings("connDOM")
            StoreEmail.ProcName = "[dbo].[DS.INSERT_LOG_STATUS_TRACKING]"

            Dim Parms As List(Of IDataParameter)
            Parms = New List(Of IDataParameter)

            StoreEmail.addParms("@TrackingID", DSTrackingID)
            StoreEmail.addParms("@CompanyCode", "GLCO")
            StoreEmail.addParms("@Contract", Se2Source.CONT)
            StoreEmail.addParms("@Email", toemail)
            StoreEmail.addParms("@DeliveryMethod", "E") 'Se2Source.DeliveryDesc)
            StoreEmail.addParms("@InsertUser", Environment.UserName)
            StoreEmail.addParms("@DocumentType", "LTCTransError")
            StoreEmail.addParms("@CallingContext", Me.ToString)

            results = StoreEmail.ExecuteNonQuery

            If Not results Then

            End If
            Return retval.ToString
        End Function
        Public Function contractNumber(ByVal encourgement As String) As Object
            Return Se2Source.CONT
        End Function
        Public Function ErroDescription(ByVal encourgement As String) As Object
            Return Se2Source.ERRORDESCRIPTION
        End Function
        Public Function BuildLTCAutomationMessage(ByVal polnum As String, ByVal emailaddress As String, ByVal emailbody As String, ByVal ccemailaddress As String) As SendGridEmailService.Body

            ' Dim subject As String = SGEmailService.DataList.EncodedDataListSet.Item("GLCOLTCAutomationSubject").DataItem
            Dim subject As String = SGEmailService.ParseEncodedDataListItem("GLCOLTCAutomationSubject")
            Dim bcclist As String = Nothing '"" '"Thirumoothi.Nallasamy@se2.com"

            Dim message As SendGridEmailService.Body = SGEmailService.DecorateMessage(emailbody, subject, "GLCO_Do_not_reply@se2.com", emailaddress, ccemailaddress, bcclist)

            message.tracking_settings.enabled = True
            message.custom_args.se2trackingid = polnum
            message.custom_args.transactiontype = "LTCTransError"
            message.custom_args.companycode = "GLCO"
            message.custom_args.emailoriginator = "DataServices"

            message.custom_args = SGEmailService.PackCustomArgs(message.custom_args)

            Return message

        End Function

#End Region
    End Class
#End Region
End Namespace
