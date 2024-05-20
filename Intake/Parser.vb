Imports System.IO
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.Data

Namespace Se2.ISCORSP.Client.GLCO.Intake.Parsers


#Region " MCSCS"
    Public Class MCSCS
        Inherits BaseParser

        Private ErrorCount As Integer = 0
        Public Sub New()

            MyBase.New()
            MyBase.InstanceKey = "GLCO.CS"
            MyBase.Name = "MCSCS"

            NotificationSeconds = 1

            Me.ParseCLM = True
            Me.DefaultCLMKEY = "MCSCS"
            Me.UseDefaultCLM = True
            Me.TrimFields = False
            Me.IncludeGroupIDInFileName = True
            OneRecordPerFile = True

            Me.CLM.Add("COMM700", New CLM.COMM700)
            Me.CLM.Add("COMM701", New CLM.COMM701)
            Me.CLM.Add("COMM702", New CLM.COMM702)
            Me.CLM.Add("COMM703", New CLM.COMM703)
            Me.CLM.Add("COMM704", New CLM.COMM704)
            Me.CLM.Add("COMM706", New CLM.COMM706)
            Me.CLM.Add("COMM719", New CLM.COMM719)
            Me.CLM.Add("HDR", New CLM.PSHEADER)

        End Sub
        Public Overrides Function InitDataSource() As Boolean

            Try
                Me.DataSource = New DataSource.GENERIC(Args.cmdLnArgs)
                Return True
            Catch
                Return False
            End Try

        End Function
    End Class
#End Region
End Namespace
