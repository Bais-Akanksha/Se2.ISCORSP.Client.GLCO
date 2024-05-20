Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.BRCCEmailNotification.Processors

#Region " BRCCEmailNotification "

    Public Class BRCCEmailNotification
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.BRCCEmailNotification"
            MyBase.Name = "BRCCEmailNotification"
            isXMLFile = True
            MyBase.RootNode = "file"
            Me.[CLM].Add("header", New GLCO.BRCCEmailNotification.CLM.Header)
            Me.[CLM].Add("file", New GLCO.BRCCEmailNotification.CLM.File)
            Me.[CLM].Add("file-urattributes", New GLCO.BRCCEmailNotification.CLM.Fileurattributes)
            Me.[CLM].Add("urattribute", New GLCO.BRCCEmailNotification.CLM.Urattribute)
            Me.[CLM].Add("urattribute2", New GLCO.BRCCEmailNotification.CLM.Urattribute2)
            Me.[CLM].Add("urattribute3", New GLCO.BRCCEmailNotification.CLM.Urattributes3)
            Me.[CLM].Add("documents", New GLCO.BRCCEmailNotification.CLM.Documents)
            Me.[CLM].Add("document", New GLCO.BRCCEmailNotification.CLM.Document)
            Me.[CLM].Add("document-urattributes", New GLCO.BRCCEmailNotification.CLM.Documenturattributes)
            Me.[CLM].Add("document-urattribute1", New GLCO.BRCCEmailNotification.CLM.Documenturattribute1)
            Me.[CLM].Add("document-urattribute2", New GLCO.BRCCEmailNotification.CLM.Documenturattribute2)
            Me.[CLM].Add("document-urattribute3", New GLCO.BRCCEmailNotification.CLM.Documenturattribute3)
            Me.[CLM].Add("document-urattribute4", New GLCO.BRCCEmailNotification.CLM.Documenturattribute4)
            Me.[CLM].Add("document-urattribute5", New GLCO.BRCCEmailNotification.CLM.Documenturattribute5)
            Me.[CLM].Add("document-urattribute6", New GLCO.BRCCEmailNotification.CLM.Documenturattribute6)
            Me.[CLM].Add("document-urattribute7", New GLCO.BRCCEmailNotification.CLM.Documenturattribute7)
            Me.[CLM].Add("document-urattribute8", New GLCO.BRCCEmailNotification.CLM.Documenturattribute8)
            Me.[CLM].Add("document-urattribute9", New GLCO.BRCCEmailNotification.CLM.Documenturattribute9)
            Me.[CLM].Add("document-urattribute10", New GLCO.BRCCEmailNotification.CLM.Documenturattribute10)
            Me.[CLM].Add("document-urattribute11", New GLCO.BRCCEmailNotification.CLM.Documenturattribute11)
            Me.[CLM].Add("document-urattribute12", New GLCO.BRCCEmailNotification.CLM.Documenturattribute12)
            Me.[CLM].Add("document-urattribute13", New GLCO.BRCCEmailNotification.CLM.Documenturattribute13)
            Me.[CLM].Add("document-urattribute14", New GLCO.BRCCEmailNotification.CLM.Documenturattribute14)
            Me.[CLM].Add("document-urattribute15", New GLCO.BRCCEmailNotification.CLM.Documenturattribute15)
            'Me.[CLM].Add("documentCount", New GLCO.BRCCEmailNotification.CLM.DocumentCount)
            NotificationSeconds = 1
        End Sub

        Public Overrides Function InitDataSource() As Boolean
            Try
                Me.DataSource = New DataSource.BASE_DATA(Args.cmdLnArgs)
                Return True
            Catch
                Return False
            End Try
        End Function

    End Class



#End Region

End Namespace
