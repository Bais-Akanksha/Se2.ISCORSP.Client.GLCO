Imports Se2.ISI.Base.Presentation

Namespace Se2.ISCORSP.Client.GLCO.EDelivery.Records


#Region " EDelivery "

#Region " DETL "


    Public Class DTL
        Inherits RecordDef

        Protected Const DateFmt As String = "yyyy-MM-dd"

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New(PresentationFormat.Fixed)
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

#Region " EDelivery "

    <Serializable()>
    Public Class EDelivery
        Inherits DTL

#Region " Constructors "

        Public Sub New()
            MyBase.New()
            Initialize()
            'Me.NodeName = "EDelivery"
            'Me.NodeParent = "DataServicesLetter"
        End Sub

        Private Shadows Enum FieldList
            Output
        End Enum

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("CONTRACT_NUMBER", "F:BODY"))
            End With
        End Sub
#End Region

#Region " Properties "


#End Region

#Region " Methods "

#End Region

    End Class
#End Region
    '#Region " Email "
    '    Public Class Email
    '        Inherits DTL

    '        Private Shadows Enum FieldList
    '            CONTRACT_NUMBER
    '            NOTIFICATION
    '            EMAIL_TO
    '            SUBJECT
    '            CONTENT
    '            FORMAT
    '            SENDER

    '        End Enum

    '#Region " CONSTRUCTORS "
    '        Public Sub New()
    '            MyBase.New()
    '            Initialize()
    '            Me.NodeName = "EDelivery"
    '            Me.NodeParent = "Email"
    '        End Sub

    '        Private Sub Initialize()
    '            Fields = New List(Of FieldDef)
    '            With Fields
    '                .Add(New FieldDef("CONTRACT_NUMBER", "CONT"))
    '                .Add(New FieldDef("NOTIFICATION", "S:{"))
    '                .Add(New FieldDef("EMAIL_TO", "EMAIL"))
    '                .Add(New FieldDef("SUBJECT", "F:SUBJECT_DESC"))
    '                .Add(New FieldDef("CONTENT", "F:EMAIL_TEXT"))
    '                .Add(New FieldDef("FORMAT", "S:html"))
    '                .Add(New FieldDef("SENDER", "S:dataservices"))
    '            End With
    '        End Sub
    '#End Region

    '#Region " PROPERTIES "

    '        Public ReadOnly Property CONTRACT_NUMBER As FieldDef
    '            Get
    '                Return Fields(FieldList.CONTRACT_NUMBER)
    '            End Get
    '        End Property
    '        Public ReadOnly Property NOTIFICATION As FieldDef
    '            Get
    '                Return Fields(FieldList.NOTIFICATION)
    '            End Get
    '        End Property
    '        Public ReadOnly Property EMAIL_TO As FieldDef
    '            Get
    '                Return Fields(FieldList.EMAIL_TO)
    '            End Get
    '        End Property
    '        Public ReadOnly Property SUBJECT As FieldDef
    '            Get
    '                Return Fields(FieldList.SUBJECT)
    '            End Get
    '        End Property
    '        Public ReadOnly Property CONTENT As FieldDef
    '            Get
    '                Return Fields(FieldList.CONTENT)
    '            End Get
    '        End Property
    '        'Public ReadOnly Property FORMAT As FieldDef
    '        '    Get
    '        '        Return Fields(FieldList.FORMAT)
    '        '    End Get
    '        'End Property
    '        Public ReadOnly Property SENDER As FieldDef
    '            Get
    '                Return Fields(FieldList.SENDER)
    '            End Get
    '        End Property

    '#End Region

    '#Region " METHODS "

    '#End Region
    '    End Class


    '#End Region
    '#Region " Inforce EDelivery "

    '    <Serializable()>
    '    Public Class InforceEDelivery
    '        Inherits DTL

    '#Region " Constructors "

    '        Public Sub New()
    '            MyBase.New()
    '            Initialize()
    '            'Me.NodeName = "EDelivery"
    '            'Me.NodeParent = "DataServicesLetter"
    '        End Sub

    '        Private Shadows Enum FieldList
    '            Output
    '        End Enum

    '        Private Sub Initialize()
    '            Fields = New List(Of FieldDef)
    '            With Fields
    '                .Add(New FieldDef("CONTRACT_NUMBER", "F:INFORCE_BODY"))
    '            End With
    '        End Sub
    '#End Region

    '#Region " Properties "


    '#End Region

    '#Region " Methods "

    '#End Region

    '    End Class
    '#End Region

#End Region

End Namespace
