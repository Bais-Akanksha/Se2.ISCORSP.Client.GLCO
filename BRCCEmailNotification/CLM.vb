Imports Se2.ISI.Base
Imports Se2.ISI.Base.Utility
Imports Se2.ISI.Base.Presentation
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.BRCCEmailNotification.CLM
#Region " Header "
    Public Class Header
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.Header

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Header
            Se2Source = New SourceLayouts.Header
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region

#Region " file "
    Public Class File
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.File

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.File
            Se2Source = New SourceLayouts.File
            MyBase.Se2Source = Me.Se2Source
        End Sub

        Public Function TOTAL_COUNT(ByVal value As Se2Args) As String

            Return value.Accumulators.Item("SEQUENCE_NUM").ToString.PadLeft(3, "0"c)

        End Function

    End Class
#End Region

#Region " file-urattributes "
    Public Class Fileurattributes
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.fileurattributes

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.fileurattributes
            Se2Source = New SourceLayouts.fileurattributes
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region

#Region " urattribute "
    Public Class Urattribute
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.urattribute

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Urattribute
            Se2Source = New SourceLayouts.Urattribute
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "


#End Region

    End Class

#End Region

#Region " urattribute2"
    Public Class Urattribute2
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Urattribute2

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Urattibute2
            Se2Source = New SourceLayouts.Urattribute2
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "


#End Region

    End Class

#End Region

#Region " urattribute3 "
    Public Class Urattributes3
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Urattribute3

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Urattibute3
            Se2Source = New SourceLayouts.Urattribute3
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "


#End Region

    End Class

#End Region

#Region " documents "
    Public Class Documents
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.Documents

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Documents
            Se2Source = New SourceLayouts.Documents
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region

#Region " document "
    Public Class Document
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.Document

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Document
            Se2Source = New SourceLayouts.Document
            MyBase.Se2Source = Me.Se2Source
        End Sub

#Region " POPULATION FUNCTIONS "
        Public Function SEQUENCE_NUM(ByVal value As Se2Args) As String
            If value.Accumulators.ContainsKey("SEQUENCE_NUM") Then
                value.Accumulators.AddToValue("SEQUENCE_NUM", 1)
            Else
                value.Accumulators.Add("SEQUENCE_NUM", 1)
            End If

            Return value.Accumulators.Item("SEQUENCE_NUM").ToString.PadLeft(3, "0"c)

        End Function

#End Region
    End Class
#End Region

#Region " document-urattributes "
    Public Class Documenturattributes
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.documenturattributes

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Documenturattributes
            Se2Source = New SourceLayouts.documenturattributes
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region

#Region " document-urattribute1 "
    Public Class Documenturattribute1
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Documenturattribute1
        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Documenturattribute1
            Se2Source = New SourceLayouts.Documenturattribute1
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "


#End Region

    End Class
#End Region

#Region " document-urattribute2 "
    Public Class Documenturattribute2
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Documenturattribute2
        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Documenturattribute2
            Se2Source = New SourceLayouts.Documenturattribute2
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "


#End Region
    End Class
#End Region

#Region " document-urattribute3 "
    Public Class Documenturattribute3
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Documenturattribute3
        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Documenturattribute3
            Se2Source = New SourceLayouts.Documenturattribute3
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "


#End Region
    End Class
#End Region

#Region " document-urattribute4 "
    Public Class Documenturattribute4
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Documenturattribute4
        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Documenturattribute4
            Se2Source = New SourceLayouts.Documenturattribute4
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "


#End Region
    End Class
#End Region

#Region " document-urattribute5 "
    Public Class Documenturattribute5
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Documenturattribute5
        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Documenturattribute5
            Se2Source = New SourceLayouts.Documenturattribute5
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "


#End Region
    End Class
#End Region

#Region " document-urattribute6 "
    Public Class Documenturattribute6
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Documenturattribute6
        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Documenturattribute6
            Se2Source = New SourceLayouts.Documenturattribute6
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "


#End Region
    End Class
#End Region

#Region " document-urattribute7 "
    Public Class Documenturattribute7
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Documenturattribute7
        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Documenturattribute7
            Se2Source = New SourceLayouts.Documenturattribute7
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "


#End Region
    End Class
#End Region

#Region " document-urattribute8 "
    Public Class Documenturattribute8
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Documenturattribute8
        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Documenturattribute8
            Se2Source = New SourceLayouts.Documenturattribute8
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "


#End Region
    End Class
#End Region

#Region " document-urattribute9 "
    Public Class Documenturattribute9
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Documenturattribute9
        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Documenturattribute9
            Se2Source = New SourceLayouts.Documenturattribute9
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "


#End Region
    End Class
#End Region

#Region " document-urattribute10 "
    Public Class Documenturattribute10
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Documenturattribute10
        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Documenturattribute10
            Se2Source = New SourceLayouts.Documenturattribute10
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "


#End Region
    End Class
#End Region

#Region " document-urattribute11 "
    Public Class Documenturattribute11
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Documenturattribute11
        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Documenturattribute11
            Se2Source = New SourceLayouts.Documenturattribute11
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "


#End Region
    End Class
#End Region

#Region " document-urattribute12 "
    Public Class Documenturattribute12
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Documenturattribute12
        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Documenturattribute12
            Se2Source = New SourceLayouts.Documenturattribute12
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "


#End Region
    End Class
#End Region

#Region " document-urattribute13 "
    Public Class Documenturattribute13
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Documenturattribute13
        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Documenturattribute13
            Se2Source = New SourceLayouts.Documenturattribute13
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "


#End Region
    End Class
#End Region

#Region " document-urattribute14 "
    Public Class Documenturattribute14
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Documenturattribute14
        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Documenturattribute14
            Se2Source = New SourceLayouts.Documenturattribute14
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "


#End Region
    End Class
#End Region

#Region " document-urattribute15 "
    Public Class Documenturattribute15
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Documenturattribute15
        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Documenturattribute15
            Se2Source = New SourceLayouts.Documenturattribute15
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "


#End Region
    End Class
#End Region

#Region " documentCount "
    Public Class DocumentCount
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.DocumentCount

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.DocumentCount
            Se2Source = New SourceLayouts.DocumentCount
            MyBase.Se2Source = Me.Se2Source
        End Sub

#Region " POPULATION FUNCTIONS "
        Public Function TOTAL_COUNT(ByVal value As Se2Args) As String

            Return value.Accumulators.Item("SEQUENCE_NUM").ToString.PadLeft(3, "0"c)

        End Function

#End Region
    End Class
#End Region


End Namespace
