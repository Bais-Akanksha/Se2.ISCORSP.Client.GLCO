Imports System.Data
Imports System.Data.DataTableExtensions
Imports System.Runtime.CompilerServices
Imports Newtonsoft.Json.Linq

Namespace Se2.ISCORSP.Client.GLCO.EDelivery.ObjectBuilder
    Module DataRowExtensions
        <Extension()>
        Function GetItemValue(ByVal row As DataRow, ByVal column As String) As Object
            Return If(row.Table.Columns.Contains(column), row(column), Nothing)
        End Function
    End Module
    '#Region "NewBusinessStoreObjectBuilder"
    '    Public Class NewBusinessStoreObject
    '        Private DSet As JToken
    '        Public Sub New()

    '        End Sub

    '        Public Sub Initialize(DS As JToken)
    '            DSet = DS
    '        End Sub

    '        Public Function BuildObj() As Object()
    '            Dim ListObj As New List(Of String)

    '            'ListObj.Add("Policies")
    '            ListObj.Add(BuildPolicy)
    '            'ListObj.Add("Roles")
    '            'For Each Role As String In BuildRoles()
    '            '    ListObj.Add(Role)
    '            'Next

    '            Return ListObj.ToArray
    '        End Function
    '        Public Function BuildPolicy() As String
    '            Dim sb As New System.Text.StringBuilder

    '            sb.Append("EDelivery")
    '            sb.Append(AddField("caseData.policyNumber"))
    '            sb.Append(AddField("caseData.caseId"))
    '            sb.Append(AddField("caseData.id"))
    '            sb.Append(AddField("evidenceData.type")) 'TRANSACTIONTYPE UW Support 
    '            sb.Append(AddField("evidenceData.currentStatus")) 'TRANSACTIONSTATUS UW Support 
    '            Dim rolelist As List(Of JToken) = DSet.SelectToken("caseData.parties").ToList
    '            For Each role As JToken In rolelist
    '                If role.SelectToken("role").ToString = "Insured" Then
    '                    sb.Append(AddField("email", role))
    '                    sb.Append(AddField("communicationPreference", role))
    '                    sb.Append(AddField("firstName", role))
    '                    sb.Append(AddField("lastName", role))
    '                End If
    '            Next role
    '            For Each role As JToken In rolelist
    '                If role.SelectToken("role").ToString = "Agent" Then
    '                    sb.Append(AddField("details.agent.carrierAgencyName", role))
    '                    sb.Append(AddField("firstName", role))
    '                    sb.Append(AddField("lastName", role))
    '                    sb.Append(AddField("phone", role))
    '                    sb.Append(AddField("email", role))
    '                    sb.Append(AddField("details.agent.carrierAgentWebsites[0]", role)) ' only need first website 
    '                    sb.Append(AddField("name", role))
    '                End If
    '            Next
    '            sb.Append(AddField("evidenceData.details"))
    '            For Each role As JToken In rolelist
    '                If role.SelectToken("role").ToString = "Owner" Then
    '                    sb.Append(AddField("firstName", role))
    '                    sb.Append(AddField("lastName", role))
    '                End If
    '            Next
    '            sb.Append(AddField("caseData.underwriting.decision")) 'UW decision 
    '            sb.Append(AddField("caseData.coverage.productName"))
    '            sb.Append(AddField("caseData.underwriting.approvedFaceAmount"))
    '            sb.Append(AddField("caseData.underwriting.underwritingRiskClass"))
    '            Dim PhysicianFound As Boolean = False
    '            If Not IsNothing(DSet.SelectToken("evidenceData.people")) Then
    '                Dim docrolelist As List(Of JToken) = DSet.SelectToken("evidenceData.people").ToList
    '                For Each role As JToken In docrolelist
    '                    If role.SelectToken("role").ToString = "Physician" Then
    '                        sb.Append(AddField("name", role))
    '                        PhysicianFound = True
    '                    End If
    '                Next
    '                If Not PhysicianFound Then
    '                    sb.Append("~")
    '                End If
    '            Else
    '                sb.Append("~")
    '            End If
    '            'sb.Append(AddField("evidenceData.people.name"))


    '            Return sb.ToString
    '        End Function

    '        Private Function AddField(ByVal projection As String, ByVal Optional startIndex As Integer = 0) As String
    '            Dim returnvalue As New System.Text.StringBuilder
    '            returnvalue.Append("~")

    '            Dim returnjt As JToken = DSet.SelectToken(projection)
    '            If Not IsNothing(returnjt) Then
    '                returnvalue.Append(returnjt.ToString)
    '            End If

    '            Return returnvalue.ToString
    '        End Function
    '        Private Function AddField(ByVal projection As String, ByRef childSet As JToken, ByVal Optional startIndex As Integer = 0) As String
    '            Dim returnvalue As New System.Text.StringBuilder
    '            returnvalue.Append("~")

    '            Dim returnjt As JToken = childSet.SelectToken(projection)
    '            If Not IsNothing(returnjt) Then
    '                returnvalue.Append(returnjt.ToString)
    '            End If

    '            Return returnvalue.ToString
    '        End Function

    '    End Class
    '#End Region

#Region "XMLObjectBuilder"
    Public Class XMLObject
        Private DSet As DataSet
        Public Sub New()

        End Sub

        Public Sub Initialize(DS As DataSet)
            DSet = DS
        End Sub


        Public Function BuildObj() As Object()
            Dim BuildInforce As New InforceObj
            'Dim roleXMLString As String
            Dim InforceXML As String
            Dim ListObj As New List(Of String)

            BuildInforce.Initialize(DSet)
            InforceXML = BuildInforce.BuildInforce()

            ListObj.Add(InforceXML)


            Return ListObj.ToArray


        End Function

    End Class
    Public Class ObjectBuilder
        Protected POLRow As Integer
        Protected ZeroBasedArray As Boolean = True

        Protected Function GetValue(ByRef srcTable As DataTable, ByVal fldName As String, Optional ByVal xValue As String = Nothing) As String

            Dim retval As String = String.Empty

            'If returnArrayList And Not ZeroBasedArray Then
            '    retval += "" ' "|"
            'End If

            If Not IsNothing(srcTable) Then
                Dim chldTable As New DataTable

                If Not IsNothing(srcTable.Rows(POLRow).Item(fldName)) Then
                    retval = srcTable.Rows(POLRow).Item(fldName).ToString
                    Return retval
                End If


            End If
            If IsNothing(srcTable) Then
                retval = ""
            End If

            Return retval
        End Function

    End Class




    Public Class InforceObj
        Inherits ObjectBuilder
        Private DSet As DataSet
        ' Private PolicyHdrData_Table As DataTable
        Private Policy_Table As DataTable
        Private Role_Table As DataTable
        Dim CTable As DataTable

        Public Sub New()

        End Sub
        Public Sub Initialize(DS As DataSet)
            ZeroBasedArray = False
            DSet = DS
            ' PolicyHdrData_Table = DS.Tables("PolicyHdrData")
            Policy_Table = DS.Tables("Policy")
            Role_Table = DS.Tables("Role")
        End Sub
        Public Function BuildInforce() As String
            Dim sb As New System.Text.StringBuilder
            'Dim insuredRoleTypeID As String = GetValue(Role_Table, "ROL_CODE", "'INSURED'")
            Dim ownerRoleTypeID As String = GetValue(Role_Table, "ROL_CODE", "'PRIM OWNER'")
            'Dim agentRoleTypeID As String = GetValue(Role_Table, "ROL_CODE", "'DIRECT REP'")

            sb.Append("Inforce~")
            sb.Append(GetValue(Policy_Table, "POL_CONT"))
            sb.Append("~")
            sb.Append(GetValue(Role_Table, "ROL_EMAIL", ownerRoleTypeID))
            sb.Append("~")
            sb.Append(GetValue(Role_Table, "ROL_DELIVERY_DESC", ownerRoleTypeID))
            sb.Append("~")
            sb.Append(GetValue(Role_Table, "ROL_FULL_NAME", ownerRoleTypeID))
            sb.Append("~")
            sb.Append(GetValue(Role_Table, "ROL_FST_NAME", ownerRoleTypeID))
            sb.Append("~")
            sb.Append(GetValue(Role_Table, "ROL_LST_NAME", ownerRoleTypeID))
            'sb.Append("~")
            'sb.Append(GetValue(Role_Table, "ROL_FULL_NAME", insuredRoleTypeID))
            'sb.Append("~")
            'sb.Append(GetValue(Role_Table, "ROL_FST_NAME", insuredRoleTypeID))
            'sb.Append("~")
            'sb.Append(GetValue(Role_Table, "ROL_LST_NAME", insuredRoleTypeID))
            'sb.Append("~")
            'sb.Append(GetValue(Role_Table, "ROL_FULL_NAME", agentRoleTypeID))
            'sb.Append("~")
            'sb.Append(GetValue(Role_Table, "ROL_EMAIL", agentRoleTypeID))
            'sb.Append("~")
            'sb.Append(GetValue(Role_Table, "ROL_FST_NAME", agentRoleTypeID))
            'sb.Append("~")
            'sb.Append(GetValue(Role_Table, "ROL_LST_NAME", agentRoleTypeID))
            'sb.Append("~")
            'sb.Append(GetValue(Role_Table, "ROL_PHONE_NUM", agentRoleTypeID))

            Return sb.ToString
        End Function


#Region "Functions"


#End Region


    End Class


#End Region
End Namespace
