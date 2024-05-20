Imports System.Data.SqlClient
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.Data

Namespace Se2.ISCORSP.Client.GLCO.EDelivery.DataSource

#Region " EDelivery "

    Public Class BASE_DATA
        Inherits Se2.ISI.Base.Data.DataSource

        Private cmdArgs As Se2CmdArgs

#Region " CONSTRUCTORS "

        Public Sub New(ByVal Args As Se2CmdArgs)
            cmdArgs = Args
            Source = IDataSource.SourceType.MSSql
            ProcName = "[SE2CORSP].[GLCO_EDelivery]"
            'DataColumn = 1
            SetParameters()
        End Sub

#End Region

        Public Overrides Sub SetParameters()
            Dim currCycleDate As Date
            Dim GroupID As String
            Dim Cmpy As String
            Dim Flag As String = "F"

            currCycleDate = cmdArgs.CYCLEDATE
            GroupID = "181"
            Cmpy = "GLCO"


            Parms = New List(Of IDataParameter)
            Parms.Add(New SqlClient.SqlParameter("@cycledate", currCycleDate))
            Parms.Add(New SqlClient.SqlParameter("@cmpy", Cmpy))
            If cmdArgs.CUSTOM.ContainsKey("Document Type") Then
                If cmdArgs.CUSTOM.Item("Document Type").ToString <> "WLCEM" Then
                    Parms.Add(New SqlClient.SqlParameter("@doctype", cmdArgs.CUSTOM.Item("Document Type")))
                    Parms.Add(New SqlClient.SqlParameter("@instanceid", cmdArgs.TRACKINGID))

                End If
            Else
                Parms.Add(New SqlClient.SqlParameter("@doctype", cmdArgs.CUSTOM.Item("DocumentType")))
                Parms.Add(New SqlClient.SqlParameter("@instanceid", ""))
            End If


        End Sub
    End Class

#End Region

End Namespace

