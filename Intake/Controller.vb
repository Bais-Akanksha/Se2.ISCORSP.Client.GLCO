Imports System.IO
Imports Se2.ISI.Base.Objects
Imports Se2.ISI.Base.Utility
Imports Se2.ISI.Base.Exception
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.Messaging
Imports Se2.ISCORSP.Client.GLCO.Intake.Processors

Namespace Se2.ISCORSP.Client.GLCO.Intake

    Public Class Controller
        Inherits BaseController

        Private curProcessor As IProcessor
        Private Results As New List(Of Result)
        Public Event ControllerFinished(ByVal e As List(Of Result))
        Private messageIDList As Dictionary(Of String, Integer)
        Private _MsgItem As MessageItem = Nothing
        Private _ProcessorSkipErrors As New List(Of String)

        Public Sub New()

            MyBase.New()

            Processors.Add(New ProcessorNV("MCSCS", New Parsers.MCSCS))

        End Sub
        Public Overrides Function Process() As List(Of Result)

            Dim Processor As String = Args.cmdLnArgs.PROCESSOR
            Return ProcessSingle(Processor)

        End Function
        Private Function ProcessSingle(ByVal Processor As String) As List(Of Result)

            Dim se2Ex As se2Exception
            se2Ex = Nothing

            For Each NVProcessor As ProcessorNV In Processors
                Try
                    If (DirectCast(NVProcessor.Value, IProcessor).Name.ToUpper = Args.cmdLnArgs.PROCESSOR.ToUpper) Then
                        NVProcessor.Value.Args = Me.Args
                        NVProcessor.Value.InitDataSource()

                        Results.Add(NVProcessor.Value.Process)
                    End If
                Catch ex As Exception

                    If TypeOf ex Is se2Exception Then
                        se2Ex = DirectCast(ex, se2Exception)
                    Else
                        se2Ex = New se2Exception(ex)
                    End If
                    If Results.Count > 0 Then
                        Results(0).Status = False
                    End If
                    se2Ex.Controller = Me.GetType.FullName
                    se2Ex.Processor = NVProcessor.Value.GetType.FullName
                    se2Ex.InterfaceKey = CType(NVProcessor.Value, IProcessor).InstanceKey
                    se2Ex.SeverityLevel = EXCEPTION_SEVERITY.HIGH
                    se2ExceptionHandler.HandleExceptionPublishing(se2Ex)

                End Try
            Next

            RaiseEvent ControllerFinished(Results)
            Return Results

        End Function

    End Class

End Namespace