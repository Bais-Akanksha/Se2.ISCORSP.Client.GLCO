Imports System.Data.SqlClient
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.Data

Namespace Se2.ISCORSP.Client.GLCO.EDeliverySGReport.DataSource

#Region " EDeliverySGReport "

    Public Class BASE_DATA
        Inherits Se2.ISI.Base.Data.DataSource

        Private cmdArgs As Se2CmdArgs

#Region " CONSTRUCTORS "

        Public Sub New(ByVal Args As Se2CmdArgs)
            cmdArgs = Args
            Source = IDataSource.SourceType.MSSql
            ProcName = "[SE2CORSP].[GLCO_SendGrid_Response]"
            'DataColumn = 1
            SetParameters()
        End Sub

#End Region

        Public Overrides Sub SetParameters()
            Parms = New List(Of IDataParameter)
            Parms.Add(New SqlClient.SqlParameter("@cmpy", "GLCO"))
            Parms.Add(New SqlClient.SqlParameter("@instanceid", cmdArgs.TRACKINGID))
        End Sub
    End Class

#End Region

End Namespace