Imports Se2.ISI.Base.Presentation

Namespace Se2.ISCORSP.Client.GLCO.BRCCEmailNotification.SourceLayouts

#Region " BRCCEmailNotification "

#Region " header "

    Public Class Header
        Inherits SourceDef

#Region " Field Array Enum "
        Public Shadows Enum FieldList
            REC_TYPE
        End Enum
#End Region

#Region " Public Properties "
        Public ReadOnly Property REC_TYPE As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property

#End Region

#Region " Constructors "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region


    End Class
#End Region

#Region " file "

    Public Class File
        Inherits SourceDef

#Region " Field Array Enum "
        Public Shadows Enum FieldList
            REC_TYPE
        End Enum
#End Region

#Region " Public Properties "
        Public ReadOnly Property REC_TYPE As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property

#End Region

#Region " Constructors "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region


    End Class
#End Region

#Region " file-urattributes "

    Public Class Fileurattributes
        Inherits SourceDef

#Region " Field Array Enum "
        Public Shadows Enum FieldList
            REC_TYPE
        End Enum
#End Region

#Region " Public Properties "
        Public ReadOnly Property REC_TYPE As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property

#End Region

#Region " Constructors "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region


    End Class
#End Region

#Region " file-urattributes "
    Public Class Urattribute
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            FILE_ID
            GLCO_EMAIL
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property FILE_ID As String
            Get
                Return Values(FieldList.FILE_ID)
            End Get
        End Property
        Public ReadOnly Property GLCO_EMAIL As String
            Get
                Return Values(FieldList.GLCO_EMAIL)
            End Get
        End Property

#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class

#End Region

#Region " file-urattribute2 "
    Public Class Urattribute2
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            FILE_SOURCE_SYSTEM_ID
            SE2

        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property FILE_SOURCE_SYSTEM_ID As String
            Get
                Return Values(FieldList.FILE_SOURCE_SYSTEM_ID)
            End Get
        End Property
        Public ReadOnly Property SE2 As String
            Get
                Return Values(FieldList.SE2)
            End Get
        End Property

#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class
#End Region

#Region " file-urattribute3 "
    Public Class Urattribute3
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            FILE_ORIGINATING_SOURCE_SYSTEM_ID
            SE2

        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property FILE_ORIGINATING_SOURCE_SYSTEM_ID As String
            Get
                Return Values(FieldList.FILE_ORIGINATING_SOURCE_SYSTEM_ID)
            End Get
        End Property
        Public ReadOnly Property SE2 As String
            Get
                Return Values(FieldList.SE2)
            End Get
        End Property

#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class
#End Region

#Region " documents "

    Public Class Documents
        Inherits SourceDef

#Region " Field Array Enum "
        Public Shadows Enum FieldList
            REC_TYPE
        End Enum
#End Region

#Region " Public Properties "
        Public ReadOnly Property REC_TYPE As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property

#End Region

#Region " Constructors "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region


    End Class
#End Region

#Region " document "

    Public Class Document
        Inherits SourceDef

#Region " Field Array Enum "
        Public Shadows Enum FieldList
            REC_TYPE
            sequence_number
        End Enum
#End Region

#Region " Public Properties "
        Public ReadOnly Property REC_TYPE As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property Sequence_Number As String
            Get
                Return Values(FieldList.sequence_number)
            End Get
        End Property

#End Region

#Region " Constructors "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region


    End Class
#End Region

#Region " document-urattribute "

    Public Class Documenturattributes
        Inherits SourceDef

#Region " Field Array Enum "
        Public Shadows Enum FieldList
            REC_TYPE
        End Enum
#End Region

#Region " Public Properties "
        Public ReadOnly Property REC_TYPE As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property

#End Region

#Region " Constructors "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region


    End Class
#End Region

#Region " document-urattribute1 "
    Public Class Documenturattribute1
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            CONT
            DOC_SOURCE_SYSTEM_BRAND_ID
            SE2_GILICO
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property CONT As String
            Get
                Return Values(FieldList.CONT)
            End Get
        End Property
        Public ReadOnly Property DOC_SOURCE_SYSTEM_BRAND_ID As String
            Get
                Return Values(FieldList.DOC_SOURCE_SYSTEM_BRAND_ID)
            End Get
        End Property
        Public ReadOnly Property SE2_GILICO As String
            Get
                Return Values(FieldList.SE2_GILICO)
            End Get
        End Property

#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class
#End Region

#Region " document-urattribute2 "
    Public Class Documenturattribute2
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            CONT
            DOC_SOURCE_CONSUMER_ID
            GLCO_ID
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property CONT As String
            Get
                Return Values(FieldList.CONT)
            End Get
        End Property
        Public ReadOnly Property DOC_SOURCE_CONSUMER_ID As String
            Get
                Return Values(FieldList.DOC_SOURCE_CONSUMER_ID)
            End Get
        End Property
        Public ReadOnly Property GLCO_ID As String
            Get
                Return Values(FieldList.GLCO_ID)
            End Get
        End Property

#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class
#End Region

#Region " document-urattribute3 "
    Public Class Documenturattribute3
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            CONT
            DOC_CONTENT_TYPE
            Policy
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property CONT As String
            Get
                Return Values(FieldList.CONT)
            End Get
        End Property
        Public ReadOnly Property DOC_CONTENT_TYPE As String
            Get
                Return Values(FieldList.DOC_CONTENT_TYPE)
            End Get
        End Property
        Public ReadOnly Property Policy As String
            Get
                Return Values(FieldList.Policy)
            End Get
        End Property

#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class
#End Region

#Region " document-urattribute4 "
    Public Class Documenturattribute4
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            CONT
            DOC_PREFERENCE_CONTENTTYPE1
            Notice
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property CONT As String
            Get
                Return Values(FieldList.CONT)
            End Get
        End Property
        Public ReadOnly Property DOC_PREFERENCE_CONTENTTYPE1 As String
            Get
                Return Values(FieldList.DOC_PREFERENCE_CONTENTTYPE1)
            End Get
        End Property
        Public ReadOnly Property Notice As String
            Get
                Return Values(FieldList.Notice)
            End Get
        End Property

#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class
#End Region

#Region " document-urattribute5 "
    Public Class Documenturattribute5
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            CONT
            DOC_PREFERENCE_VALUE1
            E
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property CONT As String
            Get
                Return Values(FieldList.CONT)
            End Get
        End Property
        Public ReadOnly Property DOC_PREFERENCE_VALUE1 As String
            Get
                Return Values(FieldList.DOC_PREFERENCE_VALUE1)
            End Get
        End Property
        Public ReadOnly Property E As String
            Get
                Return Values(FieldList.E)
            End Get
        End Property

#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class
#End Region

#Region " document-urattribute6 "
    Public Class Documenturattribute6
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            CONT
            DOC_SEND_NAME
            Name
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property CONT As String
            Get
                Return Values(FieldList.CONT)
            End Get
        End Property
        Public ReadOnly Property DOC_SEND_NAME As String
            Get
                Return Values(FieldList.DOC_SEND_NAME)
            End Get
        End Property
        Public ReadOnly Property Name As String
            Get
                Return Values(FieldList.Name)
            End Get
        End Property

#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class
#End Region

#Region " document-urattribute7 "
    Public Class Documenturattribute7
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            CONT
            DOC_CUSTOMER_EMAIL_ADDRESS
            EMAIL
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property CONT As String
            Get
                Return Values(FieldList.CONT)
            End Get
        End Property
        Public ReadOnly Property DOC_CUSTOMER_EMAIL_ADDRESS As String
            Get
                Return Values(FieldList.DOC_CUSTOMER_EMAIL_ADDRESS)
            End Get
        End Property
        Public ReadOnly Property EMAIL As String
            Get
                Return Values(FieldList.EMAIL)
            End Get
        End Property

#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class
#End Region

#Region " document-urattribute8 "
    Public Class Documenturattribute8
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            CONT
            DOC_ENVELOPE_NAME

        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property CONT As String
            Get
                Return Values(FieldList.CONT)
            End Get
        End Property
        Public ReadOnly Property DOC_ENVELOPE_NAME As String
            Get
                Return Values(FieldList.DOC_ENVELOPE_NAME)
            End Get
        End Property

#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class
#End Region

#Region " document-urattribute9 "
    Public Class Documenturattribute9
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            CONT
            DOC_ACCOUNT_NUMBER

        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property CONT As String
            Get
                Return Values(FieldList.CONT)
            End Get
        End Property
        Public ReadOnly Property DOC_ACCOUNT_NUMBER As String
            Get
                Return Values(FieldList.DOC_ACCOUNT_NUMBER)
            End Get
        End Property

#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class
#End Region

#Region " document-urattribute10 "
    Public Class Documenturattribute10
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            CONT
            DOC_TOTAL_AMOUNT_DUE

        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property CONT As String
            Get
                Return Values(FieldList.CONT)
            End Get
        End Property
        Public ReadOnly Property DOC_TOTAL_AMOUNT_DUE As String
            Get
                Return Values(FieldList.DOC_TOTAL_AMOUNT_DUE)
            End Get
        End Property

#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class
#End Region

#Region " document-urattribute11 "
    Public Class Documenturattribute11
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            CONT
            DOC_PERIOD_START_DATE

        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property CONT As String
            Get
                Return Values(FieldList.CONT)
            End Get
        End Property
        Public ReadOnly Property DOC_PERIOD_START_DATE As String
            Get
                Return Values(FieldList.DOC_PERIOD_START_DATE)
            End Get
        End Property

#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class
#End Region

#Region " document-urattribute12 "
    Public Class Documenturattribute12
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            CONT
            DOC_PERIOD_END_DATE

        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property CONT As String
            Get
                Return Values(FieldList.CONT)
            End Get
        End Property
        Public ReadOnly Property DOC_PERIOD_END_DATE As String
            Get
                Return Values(FieldList.DOC_PERIOD_END_DATE)
            End Get
        End Property

#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class
#End Region

#Region " document-urattribute13 "
    Public Class Documenturattribute13
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            CONT
            DOC_DUE_DATE

        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property CONT As String
            Get
                Return Values(FieldList.CONT)
            End Get
        End Property
        Public ReadOnly Property DOC_DUE_DATE As String
            Get
                Return Values(FieldList.DOC_DUE_DATE)
            End Get
        End Property

#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class
#End Region

#Region " document-urattribute14 "
    Public Class Documenturattribute14
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            CONT
            DOC_PRINT_SUPPRESS
            NO
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property CONT As String
            Get
                Return Values(FieldList.CONT)
            End Get
        End Property
        Public ReadOnly Property DOC_PRINT_SUPPRESS As String
            Get
                Return Values(FieldList.DOC_PRINT_SUPPRESS)
            End Get
        End Property
        Public ReadOnly Property NO As String
            Get
                Return Values(FieldList.NO)
            End Get
        End Property
#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class
#End Region

#Region " document-urattribute15 "
    Public Class Documenturattribute15
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            CONT
            DOC_HISTORICAL_MAIL
            NO
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property CONT As String
            Get
                Return Values(FieldList.CONT)
            End Get
        End Property
        Public ReadOnly Property DOC_HISTORICAL_MAIL As String
            Get
                Return Values(FieldList.DOC_HISTORICAL_MAIL)
            End Get
        End Property
        Public ReadOnly Property NO As String
            Get
                Return Values(FieldList.NO)
            End Get
        End Property
#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class
#End Region

#Region " document-Count "

    Public Class DocumentCount
        Inherits SourceDef

#Region " Field Array Enum "
        Public Shadows Enum FieldList
            REC_TYPE

        End Enum
#End Region

#Region " Public Properties "
        Public ReadOnly Property REC_TYPE As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property

#End Region

#Region " Constructors "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region


    End Class
#End Region

#End Region

End Namespace
