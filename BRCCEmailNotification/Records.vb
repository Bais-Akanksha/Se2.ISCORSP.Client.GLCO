Imports Se2.ISI.Base.Presentation

Namespace Se2.ISCORSP.Client.GLCO.BRCCEmailNotification.Records


#Region " BRCCEmailNotification "

#Region " DETL "


    Public Class DTL
        Inherits RecordDef

        Protected Const DateFmt As String = "yyyy-MM-dd"

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New(PresentationFormat.XML)
            Length = -999
            Terminator = vbCrLf
        End Sub


#End Region

#Region " PROPERTIES "


#End Region

#Region " METHODS "


#End Region

    End Class

#End Region

#Region " Header "

    '<Serializable()>
    Public Class Header
        Inherits RecordDef

#Region " Constructors "

        Public Sub New()
            MyBase.New()
            Initialize()
            Me.Type = RecordType.HDR
            Terminator = vbCrLf
            ' Me.NodeName = "Header"
            ' Me.NodeParent = "Header"
            'Me.WriteNodeTags = False
        End Sub

        Private Shadows Enum FieldList
            REC_TYPE

        End Enum


        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("REC_TYPE", "S:<?xml version=""1.0"" encoding=""UTF-8""?>"))
            End With
        End Sub
#End Region

#Region " Properties "
        Public ReadOnly Property REC_TYPE As FieldDef
            Get
                Return Fields(FieldList.REC_TYPE)
            End Get
        End Property

#End Region

#Region " Methods "

#End Region

    End Class
#End Region

#Region " File "

    <Serializable()>
    Public Class File
        Inherits DTL

#Region " Constructors "

        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "file"
            Me.NodeParent = "file"
            Me.WriteNodeTags = False
        End Sub

        Private Shadows Enum FieldList
            REC_TYPE

        End Enum


        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("documentCount", "F:TOTAL_COUNT"))
            End With
        End Sub
#End Region

#Region " Properties "


#End Region

#Region " Methods "

#End Region

    End Class
#End Region

#Region " file-urattributes "

    <Serializable()>
    Public Class Fileurattributes
        Inherits DTL

#Region " Constructors "

        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "file-urattributes"
            Me.NodeParent = "file"
        End Sub

        Private Shadows Enum FieldList
            REC_TYPE

        End Enum

        Private Sub Initialize()

        End Sub
#End Region

#Region " Properties "


#End Region

#Region " Methods "

#End Region

    End Class
#End Region

#Region " urattribute "
    Public Class Urattribute
        Inherits Fileurattributes

        Private Shadows Enum FieldList
            name
            value
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "urattribute"
            Me.NodeParent = "file-urattributes"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("name", "FILE_ID"))
                .Add(New FieldDef("value", "GLCO_EMAIL"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property Name As FieldDef
            Get
                Return Fields(FieldList.name)
            End Get
        End Property
        Public ReadOnly Property Value As FieldDef
            Get
                Return Fields(FieldList.value)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region
    End Class


#End Region

#Region " urattribute2 "
    Public Class Urattibute2
        Inherits Fileurattributes

        Private Shadows Enum FieldList
            name
            value
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "urattribute"
            Me.NodeParent = "file-urattributes"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("name", "FILE_SOURCE_SYSTEM_ID"))
                .Add(New FieldDef("value", "SE2"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property Name As FieldDef
            Get
                Return Fields(FieldList.name)
            End Get
        End Property
        Public ReadOnly Property Value As FieldDef
            Get
                Return Fields(FieldList.value)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region
    End Class
#End Region

#Region " urattribute3 "
    Public Class Urattibute3
        Inherits Fileurattributes

        Private Shadows Enum FieldList
            name
            value
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "urattribute"
            Me.NodeParent = "file-urattributes"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("name", "FILE_ORIGINATING_SOURCE_SYSTEM_ID"))
                .Add(New FieldDef("value", "SE2"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property Name As FieldDef
            Get
                Return Fields(FieldList.name)
            End Get
        End Property
        Public ReadOnly Property Value As FieldDef
            Get
                Return Fields(FieldList.value)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region
    End Class
#End Region

#Region " Documents "

    '<Serializable()>
    Public Class Documents
        Inherits DTL

#Region " Constructors "

        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "documents"
            Me.NodeParent = "file"
        End Sub

        Private Shadows Enum FieldList
            REC_TYPE

        End Enum

        Private Sub Initialize()

        End Sub
#End Region


#Region " Properties "


#End Region

#Region " Methods "

#End Region
    End Class
#End Region

#Region " Document "

    '<Serializable()>
    Public Class Document
        Inherits Documents
        Private Shadows Enum FieldList
            sequence_number
        End Enum

#Region " Constructors "

        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "document"
            Me.NodeParent = "documents"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("sequenceNum", "F:SEQUENCE_NUM"))
            End With
        End Sub
#End Region

#Region " Properties "
        Public ReadOnly Property Sequence_number As FieldDef
            Get
                Return Fields(FieldList.sequence_number)
            End Get
        End Property
#End Region

#Region " Methods "

#End Region
    End Class
#End Region

#Region " document-urattributes "

    <Serializable()>
    Public Class Documenturattributes
        Inherits Documents

#Region " Constructors "

        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "document-urattributes"
            Me.NodeParent = "document"
        End Sub

        Private Shadows Enum FieldList
            REC_TYPE

        End Enum


        Private Sub Initialize()

        End Sub

#End Region

#Region " PROPERTIES "

#End Region

#Region " METHODS "

#End Region

    End Class
#End Region

#Region " document-urattribute1 "
    Public Class Documenturattribute1
        Inherits Documenturattributes

        Private Shadows Enum FieldList
            name
            value
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "urattribute"
            Me.NodeParent = "document-urattributes"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("name", "DOC_SOURCE_SYSTEM_BRAND_ID"))
                .Add(New FieldDef("value", "SE2_GILICO"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property Name As FieldDef
            Get
                Return Fields(FieldList.name)
            End Get
        End Property
        Public ReadOnly Property Value As FieldDef
            Get
                Return Fields(FieldList.value)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region
    End Class
#End Region

#Region " document-urattribute2 "
    Public Class Documenturattribute2
        Inherits Documenturattributes

        Private Shadows Enum FieldList
            name
            value
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "urattribute"
            Me.NodeParent = "document-urattributes"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("name", "DOC_SOURCE_CONSUMER_ID"))
                .Add(New FieldDef("value", "GLCO_ID"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property Name As FieldDef
            Get
                Return Fields(FieldList.name)
            End Get
        End Property
        Public ReadOnly Property Value As FieldDef
            Get
                Return Fields(FieldList.value)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " document-urattribute3 "
    Public Class Documenturattribute3
        Inherits Documenturattributes

        Private Shadows Enum FieldList
            name
            value
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "urattribute"
            Me.NodeParent = "document-urattributes"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("name", "DOC_CONTENT_TYPE"))
                .Add(New FieldDef("value", "Policy"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property Name As FieldDef
            Get
                Return Fields(FieldList.name)
            End Get
        End Property
        Public ReadOnly Property Value As FieldDef
            Get
                Return Fields(FieldList.value)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " document-urattribute4 "
    Public Class Documenturattribute4
        Inherits Documenturattributes

        Private Shadows Enum FieldList
            name
            value
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "urattribute"
            Me.NodeParent = "document-urattributes"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("name", "DOC_PREFERENCE_CONTENTTYPE1"))
                .Add(New FieldDef("value", "Notice"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property Name As FieldDef
            Get
                Return Fields(FieldList.name)
            End Get
        End Property
        Public ReadOnly Property Value As FieldDef
            Get
                Return Fields(FieldList.value)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " document-urattribute5 "
    Public Class Documenturattribute5
        Inherits Documenturattributes

        Private Shadows Enum FieldList
            name
            value
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "urattribute"
            Me.NodeParent = "document-urattributes"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("name", "DOC_PREFERENCE_VALUE1"))
                .Add(New FieldDef("value", "E"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property Name As FieldDef
            Get
                Return Fields(FieldList.name)
            End Get
        End Property
        Public ReadOnly Property Value As FieldDef
            Get
                Return Fields(FieldList.value)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " document-urattribute6 "
    Public Class Documenturattribute6
        Inherits Documenturattributes

        Private Shadows Enum FieldList
            name
            value
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "urattribute"
            Me.NodeParent = "document-urattributes"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("name", "DOC_SEND_NAME"))
                .Add(New FieldDef("value", "Name"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property Name As FieldDef
            Get
                Return Fields(FieldList.name)
            End Get
        End Property
        Public ReadOnly Property Value As FieldDef
            Get
                Return Fields(FieldList.value)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " document-urattribute7 "
    Public Class Documenturattribute7
        Inherits Documenturattributes

        Private Shadows Enum FieldList
            name
            value
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "urattribute"
            Me.NodeParent = "document-urattributes"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("name", "DOC_CUSTOMER_EMAIL_ADDRESS"))
                .Add(New FieldDef("value", "EMAIL"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property Name As FieldDef
            Get
                Return Fields(FieldList.name)
            End Get
        End Property
        Public ReadOnly Property Value As FieldDef
            Get
                Return Fields(FieldList.value)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " document-urattribute8 "
    Public Class Documenturattribute8
        Inherits Documenturattributes

        Private Shadows Enum FieldList
            name
            value
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "urattribute"
            Me.NodeParent = "document-urattributes"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("name", "DOC_ENVELOPE_NAME"))
                .Add(New FieldDef("value", "S:"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property Name As FieldDef
            Get
                Return Fields(FieldList.name)
            End Get
        End Property
        Public ReadOnly Property Value As FieldDef
            Get
                Return Fields(FieldList.value)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " document-urattribute9 "
    Public Class Documenturattribute9
        Inherits Documenturattributes

        Private Shadows Enum FieldList
            name
            value
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "urattribute"
            Me.NodeParent = "document-urattributes"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("name", "DOC_ACCOUNT_NUMBER"))
                .Add(New FieldDef("value", "S:"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property Name As FieldDef
            Get
                Return Fields(FieldList.name)
            End Get
        End Property
        Public ReadOnly Property Value As FieldDef
            Get
                Return Fields(FieldList.value)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " document-urattribute10 "
    Public Class Documenturattribute10
        Inherits Documenturattributes

        Private Shadows Enum FieldList
            name
            value
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "urattribute"
            Me.NodeParent = "document-urattributes"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("name", "DOC_TOTAL_AMOUNT_DUE"))
                .Add(New FieldDef("value", "S:"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property Name As FieldDef
            Get
                Return Fields(FieldList.name)
            End Get
        End Property
        Public ReadOnly Property Value As FieldDef
            Get
                Return Fields(FieldList.value)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " document-urattribute11 "
    Public Class Documenturattribute11
        Inherits Documenturattributes

        Private Shadows Enum FieldList
            name
            value
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "urattribute"
            Me.NodeParent = "document-urattributes"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("name", "DOC_PERIOD_START_DATE"))
                .Add(New FieldDef("value", "S:"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property Name As FieldDef
            Get
                Return Fields(FieldList.name)
            End Get
        End Property
        Public ReadOnly Property Value As FieldDef
            Get
                Return Fields(FieldList.value)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " document-urattribute12 "
    Public Class Documenturattribute12
        Inherits Documenturattributes

        Private Shadows Enum FieldList
            name
            value
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "urattribute"
            Me.NodeParent = "document-urattributes"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("name", "DOC_PERIOD_END_DATE"))
                .Add(New FieldDef("value", "S:"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property Name As FieldDef
            Get
                Return Fields(FieldList.name)
            End Get
        End Property
        Public ReadOnly Property Value As FieldDef
            Get
                Return Fields(FieldList.value)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " document-urattribute13 "
    Public Class Documenturattribute13
        Inherits Documenturattributes

        Private Shadows Enum FieldList
            name
            value
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "urattribute"
            Me.NodeParent = "document-urattributes"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("name", "DOC_DUE_DATE"))
                .Add(New FieldDef("value", "S:"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property Name As FieldDef
            Get
                Return Fields(FieldList.name)
            End Get
        End Property
        Public ReadOnly Property Value As FieldDef
            Get
                Return Fields(FieldList.value)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " document-urattribute14 "
    Public Class Documenturattribute14
        Inherits Documenturattributes

        Private Shadows Enum FieldList
            name
            value
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "urattribute"
            Me.NodeParent = "document-urattributes"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("name", "DOC_PRINT_SUPPRESS"))
                .Add(New FieldDef("value", "NO"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property Name As FieldDef
            Get
                Return Fields(FieldList.name)
            End Get
        End Property
        Public ReadOnly Property Value As FieldDef
            Get
                Return Fields(FieldList.value)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " document-urattribute15 "
    Public Class Documenturattribute15
        Inherits Documenturattributes

        Private Shadows Enum FieldList
            name
            value
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "urattribute"
            Me.NodeParent = "document-urattributes"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("name", "DOC_HISTORICAL_MAIL"))
                .Add(New FieldDef("value", "NO"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property Name As FieldDef
            Get
                Return Fields(FieldList.name)
            End Get
        End Property
        Public ReadOnly Property Value As FieldDef
            Get
                Return Fields(FieldList.value)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " DocumentCount "

    Public Class DocumentCount
        Inherits RecordDef
        Private Shadows Enum FieldList
            documentCount
        End Enum

#Region " Constructors "

        Public Sub New()
            MyBase.New(PresentationFormat.XML)
            Length = -999
            Terminator = vbCrLf
            Initialize()
            'Me.NodeName = "documentCount"
            Me.NodeParent = "file"
        End Sub

        'Public Sub New()
        '    MyBase.New(PresentationFormat.XML)
        '    Length = -999
        '    Terminator = vbCrLf
        'End Sub
        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("documentCount", "F:TOTAL_COUNT"))
            End With
        End Sub
#End Region

#Region " Properties "
        Public ReadOnly Property DocumentCount As FieldDef
            Get
                Return Fields(FieldList.documentCount)
            End Get
        End Property
#End Region

#Region " Methods "

#End Region
    End Class
#End Region

#End Region

End Namespace
