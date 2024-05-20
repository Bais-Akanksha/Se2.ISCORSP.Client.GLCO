Imports Se2.ISI.Base.Presentation

Namespace Se2.ISCORSP.Client.GLCO.EDelivery.SourceLayouts

#Region " EDelivery "

#Region " EDelivery "

    Public Class EDelivery
        Inherits SourceDef

#Region " Field Array Enum "
        Public Shadows Enum FieldList
            REC_TYPE
            CONT
            EMAIL
            TRACKINGID
            TRANSACTIONID
            DELIVERYMETHOD
            COMPANYCODE
        End Enum
#End Region

#Region " Public Properties "
        Public ReadOnly Property REC_TYPE As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property CONT As String
            Get
                Return Values(FieldList.CONT)
            End Get
        End Property
        Public ReadOnly Property EMAIL As String
            Get
                Return Values(FieldList.EMAIL)
            End Get
        End Property
        Public ReadOnly Property TRACKINGID As String
            Get
                Return Values(FieldList.TRACKINGID)
            End Get
        End Property
        Public ReadOnly Property TRANSACTIONID As String
            Get
                Return Values(FieldList.TRANSACTIONID)
            End Get
        End Property
        Public ReadOnly Property DELIVERYMETHOD As String
            Get
                Return Values(FieldList.DELIVERYMETHOD)
            End Get
        End Property
        Public ReadOnly Property COMPANYCODE As String
            Get
                Return Values(FieldList.COMPANYCODE)
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
    '#Region " Email "
    '    Public Class Email
    '        Inherits SourceDef

    '#Region " FEILD ARRAY ENUM "
    '        Public Shadows Enum FieldList
    '            RECORD_TYPE
    '            CYCLEDATE
    '            POL_NUM
    '            CVG_ID
    '            CONT
    '            EMAIL
    '            TRACKING_ID

    '        End Enum
    '#End Region

    '#Region " PUBLIC PROPERTIES "
    '        Public ReadOnly Property POL_NUM As String
    '            Get
    '                Return Values(FieldList.POL_NUM)
    '            End Get
    '        End Property
    '        Public ReadOnly Property CYCLEDATE As String
    '            Get
    '                Return Values(FieldList.CYCLEDATE)
    '            End Get
    '        End Property
    '        Public ReadOnly Property CVG_ID As String
    '            Get
    '                Return Values(FieldList.CVG_ID)
    '            End Get
    '        End Property
    '        Public ReadOnly Property CONT As String
    '            Get
    '                Return Values(FieldList.CONT)
    '            End Get
    '        End Property
    '        Public ReadOnly Property EMAIL As String
    '            Get
    '                Return Values(FieldList.EMAIL)
    '            End Get
    '        End Property
    '        Public ReadOnly Property TRACKING_ID As String
    '            Get
    '                Return Values(FieldList.TRACKING_ID)
    '            End Get
    '        End Property


    '#End Region

    '#Region " CONSTRUCTORS "
    '        Public Sub New()
    '            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
    '        End Sub
    '#End Region

    '    End Class

    '#End Region

    '#Region " InforceEDelivery "
    '    Public Class InforceEDelivery
    '        Inherits SourceDef


    '#Region " Field Array Enum "
    '        Public Shadows Enum FieldList
    '            REC_TYPE
    '            CONT
    '            OwnerEmail
    '            DeliveryDesc
    '            OwnerFullName
    '            OwnerFirstName
    '            OwnerLastName
    '            InsuredFullName
    '            InsuredFirstName
    '            InsuredLastName
    '            'AgentFullName
    '            'AgentEmail
    '            'AgentFirstName
    '            'AgentLastName
    '            'AgentPhone

    '        End Enum
    '#End Region
    '#Region " Public Properties "
    '        Public ReadOnly Property REC_TYPE As String
    '            Get
    '                Return Values(FieldList.REC_TYPE)
    '            End Get
    '        End Property
    '        Public ReadOnly Property CONT As String
    '            Get
    '                Return Values(FieldList.CONT)
    '            End Get
    '        End Property
    '        Public ReadOnly Property OwnerEmail As String
    '            Get
    '                Return Values(FieldList.OwnerEmail)
    '            End Get
    '        End Property
    '        Public ReadOnly Property DeliveryDesc As String
    '            Get
    '                Return Values(FieldList.DeliveryDesc)
    '            End Get
    '        End Property
    '        Public ReadOnly Property OwnerFullName As String
    '            Get
    '                Return Values(FieldList.OwnerFullName)
    '            End Get
    '        End Property
    '        Public ReadOnly Property OwnerFirstName As String
    '            Get
    '                Return Values(FieldList.OwnerFirstName)
    '            End Get
    '        End Property
    '        Public ReadOnly Property OwnerLastName As String
    '            Get
    '                Return Values(FieldList.OwnerLastName)
    '            End Get
    '        End Property
    '        Public ReadOnly Property InsuredFullName As String
    '            Get
    '                Return Values(FieldList.InsuredFullName)
    '            End Get
    '        End Property
    '        Public ReadOnly Property InsuredFirstName As String
    '            Get
    '                Return Values(FieldList.InsuredFirstName)
    '            End Get
    '        End Property
    '        Public ReadOnly Property InsuredLastName As String
    '            Get
    '                Return Values(FieldList.InsuredLastName)
    '            End Get
    '        End Property
    '        'Public ReadOnly Property AgentFullName As String
    '        '    Get
    '        '        Return Values(FieldList.AgentFullName)
    '        '    End Get
    '        'End Property
    '        'Public ReadOnly Property AgentEmail As String
    '        '    Get
    '        '        Return Values(FieldList.AgentEmail)
    '        '    End Get
    '        'End Property

    '        'Public ReadOnly Property AgentFirstName As String
    '        '    Get
    '        '        Return Values(FieldList.AgentFirstName)
    '        '    End Get
    '        'End Property
    '        'Public ReadOnly Property AgentLastName As String
    '        '    Get
    '        '        Return Values(FieldList.AgentLastName)
    '        '    End Get
    '        'End Property
    '        'Public ReadOnly Property AgentPhone As String
    '        '    Get
    '        '        Return Values(FieldList.AgentPhone)
    '        '    End Get
    '        'End Property

    '#End Region

    '#Region " Constructors "
    '        Public Sub New()
    '            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
    '        End Sub
    '#End Region
    '    End Class

    '#End Region


#End Region

End Namespace
