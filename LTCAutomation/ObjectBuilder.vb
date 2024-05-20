Imports System.Data
Imports System.Data.DataTableExtensions
Imports System.Runtime.CompilerServices
Imports Newtonsoft.Json.Linq

Namespace Se2.ISCORSP.Client.GLCO.LTCAutomation.ObjectBuilder
    Module DataRowExtensions
        <Extension()>
        Function GetItemValue(ByVal row As DataRow, ByVal column As String) As Object
            Return If(row.Table.Columns.Contains(column), row(column), Nothing)
        End Function
    End Module
#Region "NewBusinessStoreObjectBuilder"
    Public Class NewBusinessStoreObject
        Private DSet As JToken
        Public Sub New()

        End Sub

        Public Sub Initialize(DS As JToken)
            DSet = DS
        End Sub

        Public Function BuildObj() As Object()
            Dim ListObj As New List(Of String)

            ListObj.Add(BuildPolicy)

            Return ListObj.ToArray
        End Function
        Public Function BuildPolicy() As String
            Dim sb As New System.Text.StringBuilder

            sb.Append("LTCAutomation")
            sb.Append(AddField("contractnumber"))
            If AddField("error") = "~" Then
                sb.Append(AddField("Error"))
            Else
                sb.Append(AddField("error"))
            End If

            Return sb.ToString
        End Function

        Private Function AddField(ByVal projection As String, ByVal Optional startIndex As Integer = 0) As String
            Dim returnvalue As New System.Text.StringBuilder
            returnvalue.Append("~")

            Dim returnjt As JToken = DSet.SelectToken(projection)
            If Not IsNothing(returnjt) Then
                returnvalue.Append(returnjt.ToString)
            End If

            Return returnvalue.ToString
        End Function
        Private Function AddField(ByVal projection As String, ByRef childSet As JToken, ByVal Optional startIndex As Integer = 0) As String
            Dim returnvalue As New System.Text.StringBuilder
            returnvalue.Append("~")

            Dim returnjt As JToken = childSet.SelectToken(projection)
            If Not IsNothing(returnjt) Then
                returnvalue.Append(returnjt.ToString)
            End If

            Return returnvalue.ToString
        End Function

    End Class
#End Region


End Namespace
