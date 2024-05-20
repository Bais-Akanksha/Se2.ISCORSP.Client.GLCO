Imports System.Data.SqlClient
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.Data
Imports System.Configuration
Imports System.IO
Imports Newtonsoft.Json

Namespace Se2.ISCORSP.Client.GLCO.LTCAutomation.DataSource

#Region " LTCAutomation "

    Public Class BASE_DATA
        Inherits Se2.ISI.Base.Data.DataSource
        Private cmdArgs As Se2CmdArgs


#Region " CONSTRUCTORS "

        Public Sub New(ByVal Args As Se2CmdArgs)
            cmdArgs = Args
            Source = IDataSource.SourceType.Custom
            ProcName = "[SE2CORSP].[GLCO_LTCAutomation]"
            DataColumn = 2
            BuildInputValues()

        End Sub
        Public Overrides Sub SetParameters()

        End Sub

#End Region

        Public Overrides Sub BuildInputValues()
            Dim dset As New DataSet
            Dim DS As Linq.JToken
            Dim results As New DataTable

            'Ethan went and messed things up by using "TransactionName"  It's been fixed but it's not in QA yet.
            'Thus we're checking for both....
            Dim TXNName As String = ""
            If cmdArgs.CUSTOM.ContainsKey("TransactionName") Then
                TXNName = cmdArgs.CUSTOM("TransactionName")
            Else
                TXNName = cmdArgs.CUSTOM("Transaction")
            End If



            Dim GetControllers As New Se2.ISI.Base.Data.SQLExecutor
                GetControllers.DataLocation = ConfigurationManager.AppSettings("connSTOR")
                GetControllers.ProcName = "[SE2CORSP].[GLCO_LTCAutomation]"
                Parms = New List(Of IDataParameter)
                GetControllers.addParms("@instanceid", cmdArgs.TRACKINGID)
            'GetControllers.addParms("@DocType", TXNName)
            'GetControllers.addParms("@contract", cmdArgs.CUSTOM("ContractNumber"))
            GetControllers.addParms("@cmpy", "GLCO")

                results = GetControllers.ExecuteDatatable


            DS = Linq.JToken.Parse(results.Rows(0)(0).ToString())
            Dim Obj As ObjectBuilder.NewBusinessStoreObject = New ObjectBuilder.NewBusinessStoreObject
            Obj.Initialize(DS)
            Me.Values = Obj.BuildObj()
            Me.SourceContainsHeader = False


        End Sub
    End Class

#End Region


End Namespace