Imports System.IO
Imports Se2.ISI.Base.Objects
Imports Se2.ISI.Base.Utility
Imports Se2.ISI.Base.Exception
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.Messaging
Imports Se2.ISCORSP.Client.GLCO.FIA3AnnivStmt.Processors

Namespace Se2.ISCORSP.Client.GLCO.FIA3AnnivStmt

    Public Class Controller
        Inherits BaseController

        Private curProcessor As IProcessor
        Private Results As New List(Of Result)
        Public Event ControllerFinished(ByVal e As List(Of Result))

        Public Sub New()
            MyBase.New()
            Processors.Add(New ProcessorNV("FIA3AnnivStmt", New Processors.FIA3AnnivStmt))
            Processors.Add(New ProcessorNV("FIA3AnnivStmtRedirect", New Processors.FIA3AnnivStmtRedirect))
        End Sub

        Public Overrides Function Process() As List(Of Result)
            Dim Processor As String
            If IsNothing(Args.cmdLnArgs.PROCESSOR) Then
                Processor = String.Empty
            Else
                Processor = Args.cmdLnArgs.PROCESSOR
            End If

            If Processor = String.Empty Then
                Return ProcessAll()
            Else
                Return ProcessSingle(Processor)
            End If

        End Function

        Private Function ProcessSingle(ByVal Processor As String) As List(Of Result)

            Dim se2Ex As se2Exception

            For Each NVProcessor As ProcessorNV In Processors
                'Try

                If (DirectCast(NVProcessor.Value, BaseProcessor).Name.ToUpper = Processor.ToUpper) Then
                        NVProcessor.Value.Args = Me.Args
                        NVProcessor.Value.InitDataSource()
                        Results.Add(NVProcessor.Value.Process)
                        If NVProcessor.Value.Args.ProcessedRecords > 1 Then
                            Console.WriteLine("POLICY_COUNT=" + NVProcessor.Value.Args.Accumulators("ROW_DATA_COUNT").ToString)
                            Console.WriteLine("TRACKING_ID=" + System.Guid.NewGuid.ToString)
                        Else
                            Console.WriteLine("POLICY_COUNT=0")
                            Console.WriteLine("TRACKING_ID=" + System.Guid.NewGuid.ToString)
                        End If
                    End If

                'Catch ex As Exception
                '    If TypeOf ex Is se2Exception Then
                '        se2Ex = DirectCast(ex, se2Exception)
                '    Else
                '        se2Ex = New se2Exception(ex)
                '    End If
                '    se2Ex.Controller = Me.GetType.FullName
                '    se2Ex.Processor = NVProcessor.Value.GetType.FullName
                '    se2Ex.InterfaceKey = CType(NVProcessor.Value, BaseProcessor).InterfaceKey
                '    se2Ex.SeverityLevel = EXCEPTION_SEVERITY.HIGH
                '    se2ExceptionHandler.HandleExceptionPublishing(se2Ex)
                'End Try
            Next

            RaiseEvent ControllerFinished(Results)
            Return Results

        End Function

        Private Function ProcessAll() As List(Of Result)

            Dim se2Ex As se2Exception

            For Each NVProcessor As ProcessorNV In Processors
                Try
                    Me.Args.cmdLnArgs.PROCESSOR = NVProcessor.Value.Name
                    NVProcessor.Value.Args = Me.Args
                    NVProcessor.Value.InitDataSource()
                    Results.Add(NVProcessor.Value.Process)
                    If NVProcessor.Value.Args.ProcessedRecords > 0 Then
                        Console.WriteLine("POLICY_COUNT=" + Convert.ToInt64(NVProcessor.Value.Args.Accumulators("ROW_DATA_COUNT")).ToString)
                        Console.WriteLine("TRACKING_ID=" + System.Guid.NewGuid.ToString)
                    End If
                Catch ex As Exception
                    If TypeOf ex Is se2Exception Then
                        se2Ex = DirectCast(ex, se2Exception)
                    Else
                        se2Ex = New se2Exception(ex)
                    End If
                    se2Ex.Controller = Me.GetType.FullName
                    se2Ex.Processor = NVProcessor.Value.GetType.FullName
                    se2Ex.InterfaceKey = CType(NVProcessor.Value, BaseProcessor).InterfaceKey
                    se2Ex.SeverityLevel = EXCEPTION_SEVERITY.HIGH
                    se2ExceptionHandler.HandleExceptionPublishing(se2Ex)
                End Try
            Next
            RaiseEvent ControllerFinished(Results)
            Return Results
        End Function

    End Class

End Namespace
