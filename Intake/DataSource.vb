Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.Data
Imports Se2.ISI

Namespace Se2.ISCORSP.Client.GLCO.Intake.DataSource

#Region " GENERIC "

    Public Class GENERIC
        Inherits Base.Data.DataSource

        Private cmdArgs As Se2CmdArgs

#Region " CONSTRUCTORS "

        Public Sub New(ByVal Args As Se2CmdArgs)

            cmdArgs = Args
            Source = IDataSource.SourceType.File
            DataLocation = Args.SRCFILE
            SetParameters()

        End Sub

        Public Overrides Sub SetParameters()

            Dim currCycleDate As Date
            currCycleDate = cmdArgs.CYCLEDATE
            SourceContainsHeader = False
        End Sub

#End Region

    End Class

#End Region

End Namespace
