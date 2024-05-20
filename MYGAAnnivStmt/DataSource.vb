﻿Imports System.Data.SqlClient
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.Data

Namespace Se2.ISCORSP.Client.GLCO.MYGAAnnivStmt.DataSource

#Region " MYGAAnnivStmt "

    Public Class BASE_DATA
        Inherits Se2.ISI.Base.Data.DataSource

        Private cmdArgs As Se2CmdArgs

#Region " CONSTRUCTORS "

        Public Sub New(ByVal Args As Se2CmdArgs)
            cmdArgs = Args
            Source = IDataSource.SourceType.MSSql
            ProcName = "[SE2CORSP].[BASE]"
            DataColumn = 1
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
            Cmpy = "CORSP"
            If cmdArgs.PROCESSOR = "MYGAAnnivStmtRedirect" Then
                Flag = "U"
            End If

            Parms = New List(Of IDataParameter)
            Parms.Add(New SqlClient.SqlParameter("@cycledate", currCycleDate))
            Parms.Add(New SqlClient.SqlParameter("@groupid", GroupID))
            Parms.Add(New SqlClient.SqlParameter("@cmpy", Cmpy))
            Parms.Add(New SqlClient.SqlParameter("@ClientProcedure", "GLCO_MYGAAnnivStmt"))
            Parms.Add(New SqlClient.SqlParameter("@Flag", Flag))
            'Parms.Add(New SqlClient.SqlParameter("@contract", "7280000146"))
        End Sub
    End Class

#End Region

End Namespace