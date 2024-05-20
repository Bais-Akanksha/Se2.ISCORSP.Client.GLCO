Imports Se2.ISI.Base.Presentation

Namespace Se2.ISCORSP.Client.GLCO.EDeliverySGReport.SourceLayouts

#Region " EDeliverySGReport "

#Region " EDeliverySGReport "

    Public Class EDeliverySGReport
        Inherits SourceDef

#Region " Field Array Enum "
        Public Shadows Enum FieldList
            REC_TYPE
            Content
            MULE_CORRELATION_ID
        End Enum
#End Region

#Region " Public Properties "
        Public ReadOnly Property REC_TYPE As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property Content As String
            Get
                Return Values(FieldList.Content)
            End Get
        End Property
        Public ReadOnly Property MULE_CORRELATION_ID As String
            Get
                Return Values(FieldList.MULE_CORRELATION_ID)
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
#Region " Email "
    Public Class Email
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            CYCLEDATE
            POL_NUM
            CVG_ID
            CONT
            EMAIL
            TRACKING_ID

        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property POL_NUM As String
            Get
                Return Values(FieldList.POL_NUM)
            End Get
        End Property
        Public ReadOnly Property CYCLEDATE As String
            Get
                Return Values(FieldList.CYCLEDATE)
            End Get
        End Property
        Public ReadOnly Property CVG_ID As String
            Get
                Return Values(FieldList.CVG_ID)
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
        Public ReadOnly Property TRACKING_ID As String
            Get
                Return Values(FieldList.TRACKING_ID)
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




#End Region

End Namespace
