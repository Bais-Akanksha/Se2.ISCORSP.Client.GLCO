Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.SoA.Processors

#Region " PoC Processor "

    Public Class SoA

        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.MWA.SoA"
            MyBase.Name = "PoC_MWA"
            ''Me.[CLM].Add("Header", New CORSP.PoC_MWA.CLM.CTRLHeader)
            'Me.[CLM].Add("REC_100_Statement_Header", New MWA.SoA.CLM.REC_100_Statement_Header)
            'Me.[CLM].Add("REC_51_Sort_Key", New MWA.SoA.CLM.REC_51_Sort_Key)
            'Me.[CLM].Add("REC_52_Separator", New MWA.SoA.CLM.REC_52_Separator)
            'Me.[CLM].Add("REC_101_File_Header", New MWA.SoA.CLM.REC_101_File_Header)
            ''Me.[CLM].Add("InserterSetUp", New CORSP.PoC.CLM.REC_102_Inserter_SetUp)
            'Me.[CLM].Add("REC_55_Mailing_Label", New MWA.SoA.CLM.REC_55_Mailing_Label)
            'Me.[CLM].Add("REC_225_Statement_Heading", New MWA.SoA.CLM.REC_225_Statement_Heading)
            ''Me.[CLM].Add("PolicyInfo", New CORSP.PoC.CLM.REC_261_Policy_Info)
            'Me.[CLM].Add("REC_265_Account_Summary", New MWA.SoA.CLM.REC_265_Account_Summary)
            'Me.[CLM].Add("REC_285_Account_Summary_Total", New MWA.SoA.CLM.REC_285_Account_Summary_Total)
            'Me.[CLM].Add("REC_290_Info_Record", New MWA.SoA.CLM.REC_290_Info_Record)
            'Me.[CLM].Add("REC_605_Transaction_Summary", New MWA.SoA.CLM.REC_605_Transaction_Summary)
            'Me.[CLM].Add("REC_625_Transaction_Summary_Total", New MWA.SoA.CLM.REC_625_Transaction_Summary_Total)
            ''Me.[CLM].Add("EnhancedBenefits", New CORSP.PoC.CLM.REC_295_Enhanced_Benefits)

            Me.ProcessByChunk = True

            'Me.RecordChunks.Add("CONT", CType(Me.CLM.Item("REC_100_Statement_Header").Se2Source, MWA.SoA.SourceLayouts.REC_100_Statement_Header))

            Me.ChunkOrderStructure.Add("REC_100_Statement_Header")
            Me.ChunkOrderStructure.Add("REC_51_Sort_Key")
            Me.ChunkOrderStructure.Add("REC_52_Separator")
            Me.ChunkOrderStructure.Add("REC_100_Statement_Header")
            Me.ChunkOrderStructure.Add("REC_101_File_Header")
            Me.ChunkOrderStructure.Add("REC_51_Sort_Key")
            Me.ChunkOrderStructure.Add("REC_55_Mailing_Label")
            Me.ChunkOrderStructure.Add("REC_225_Statement_Heading")
            Me.ChunkOrderStructure.Add("REC_265_Account_Summary")
            Me.ChunkOrderStructure.Add("REC_285_Account_Summary_Total")
            Me.ChunkOrderStructure.Add("REC_290_Info_Record")
            Me.ChunkOrderStructure.Add("REC_605_Transaction_Summary")
            Me.ChunkOrderStructure.Add("REC_625_Transaction_Summary_Total")
            Me.ChunkOrderStructure.Add("REC_100_Statement_Header")
            Me.ChunkOrderStructure.Add("REC_51_Sort_Key")
            Me.ChunkOrderStructure.Add("REC_52_Separator")

            NotificationSeconds = 1
        End Sub

        Public Overrides Function InitDataSource() As Boolean
            Try
                Me.DataSource = New DataSource.SoA_DATA(Args.cmdLnArgs)
                Return True
            Catch
                Return False
            End Try
        End Function

    End Class

#End Region

End Namespace

