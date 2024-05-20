Imports System.IO
Imports Se2.ISI.Base.Exception
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.Queue

Namespace Se2.ISCORSP.Client.GLCO.LTCAutomation.Processors

#Region " LTCAutomation "

    Public Class LTCAutomation
        Inherits BaseProcessor

        Private Outputcount As Integer = 0
        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.LTCAutomation"
            MyBase.Name = "LTCAutomation"
            'isXMLFile = True
            ' MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("LTCAutomation", New GLCO.LTCAutomation.CLM.LTCAutomation)

            'Me.[CLM].Add("Inforce", New GLCO.LTCAutomation.CLM.LTCAutomation)
            ' MyBase.IncludeInstanceIDInFileName = True
            NotificationSeconds = 1
        End Sub

        Public Overrides Function InitDataSource() As Boolean
            Try
                Me.DataSource = New DataSource.BASE_DATA(Args.cmdLnArgs)
                Return True
            Catch ex As Exception
                Dim Output As New List(Of String)
                If Not IsNothing(ex.InnerException) Then
                    Do Until IsNothing(ex.InnerException)
                        Output.Add(Now.ToString("HH:mm:ss") & "  " & ex.Message)
                        Output.Add(Now.ToString("HH:mm:ss") & "  " & ex.StackTrace)
                        ex = ex.InnerException
                    Loop
                Else
                    Output.Add(Now.ToString("HH:mm:ss") & "  " & ex.Message)
                    Output.Add(Now.ToString("HH:mm:ss") & "  " & ex.StackTrace)
                End If

                Result.ResultSet.Add("DataSource Init Error", Output)

                Dim se2ex As New se2Exception(DirectCast(ex, System.Exception), DirectCast(ex, System.Exception).Message, EXCEPTION_SEVERITY.SEVERE)
                se2ExceptionHandler.HandleExceptionPublishing(se2ex)

                Return False
            End Try
        End Function



    End Class


#End Region



End Namespace
