Imports Se2.ISI.Base.Presentation

Namespace Se2.ISCORSP.Client.GLCO.SoA.SourceLayouts

#Region " SoA "

#Region " Header "

    Public Class Header
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            REC_TYPE
            Record_Count
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property

        Public ReadOnly Property Record_Count() As String
            Get
                Return Values(FieldList.Record_Count)
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

#Region " REC_100_Statement_Header "
    Public Class REC_100_Statement_Header
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            RECORD_SUBTYPE
            CYCLE_DATE
            CO_ID
            POL_NUM
            CVG_ID
            CONT
            PLN_CODE
            ROLE_ID
            REP_MASTER_NUMBER
            LST
            FST
            MID
            STATE_CODE
            ZIP
            'RECORD_TYPE
            'RECORD_SUBTYPE
            'CYCLE_DATE
            'CO_ID
            'POL_NUM
            'CVG_ID
            'CONT
            'PLN_CODE
            'ROLE_ID
            '      AGENT_CODE
            ''REP_PRSRT1_TEXT
            'LST
            'FST
            'MID
            ''SPCL_HNDLNG_CODE
            ''USER_RQST_ID
            'STATE_CODE
            'ZIP
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property RECORD_SUBTYPE As String
            Get
                Return Values(FieldList.RECORD_SUBTYPE)
            End Get
        End Property
        Public ReadOnly Property CYCLE_DATE As String
            Get
                Return Values(FieldList.CYCLE_DATE)
            End Get
        End Property
        Public ReadOnly Property CO_ID As String
            Get
                Return Values(FieldList.CO_ID)
            End Get
        End Property
        Public ReadOnly Property POL_NUM As String
            Get
                Return Values(FieldList.POL_NUM)
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
        Public ReadOnly Property PLN_CODE As String
            Get
                Return Values(FieldList.PLN_CODE)
            End Get
        End Property
        Public ReadOnly Property ROLE_ID As String
            Get
                Return Values(FieldList.ROLE_ID)
            End Get
        End Property
        Public ReadOnly Property REP_MASTER_NUMBER As String
            Get
                Return Values(FieldList.REP_MASTER_NUMBER)
            End Get
        End Property
        'Public ReadOnly Property REP_PRSRT1_TEXT As String
        '    Get
        '        Return Values(FieldList.REP_PRSRT1_TEXT)
        '    End Get
        'End Property
        Public ReadOnly Property LST As String
            Get
                Return Values(FieldList.LST)
            End Get
        End Property
        Public ReadOnly Property FST As String
            Get
                Return Values(FieldList.FST)
            End Get
        End Property
        Public ReadOnly Property MID As String
            Get
                Return Values(FieldList.MID)
            End Get
        End Property
        'Public ReadOnly Property SPCL_HNDLNG_CODE As String
        '    Get
        '        Return Values(FieldList.SPCL_HNDLNG_CODE)
        '    End Get
        'End Property
        'Public ReadOnly Property USER_RQST_ID As String
        '    Get
        '        Return Values(FieldList.USER_RQST_ID)
        '    End Get
        'End Property
        Public ReadOnly Property STATE_CODE As String
            Get
                Return Values(FieldList.STATE_CODE)
            End Get
        End Property
        Public ReadOnly Property ZIP As String
            Get
                Return Values(FieldList.ZIP)
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

#Region " REC_51_Sort_Key "
    Public Class REC_51_Sort_Key
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            RECORD_SUBTYPE
            CYCLE_DATE
            CO_ID
            POL_NUM
            CVG_ID
            CONT
            PLN_CODE
            ROLE_ID
            LST
            FST
            MID
            'ZERO
            'DSC_GROUP_DOC_CNT
            'SPCL_HNDLNG_CODE
            BRKR_MASTER_NUMBER
            BRKR_FST
            BRKR_LST
            BRKR_MID
            BRKR_SUFFIX
            REP_MASTER_NUMBER
            REP_FST
            REP_LST
            REP_MID
            REP_SUFFIX
            'CUST_PRNT_IND
            'CUST_ARC_IND
            ZIP
            STATE_CODE

        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property RECORD_SUBTYPE As String
            Get
                Return Values(FieldList.RECORD_SUBTYPE)
            End Get
        End Property
        Public ReadOnly Property CYCLE_DATE As String
            Get
                Return Values(FieldList.CYCLE_DATE)
            End Get
        End Property
        Public ReadOnly Property CO_ID As String
            Get
                Return Values(FieldList.CO_ID)
            End Get
        End Property
        Public ReadOnly Property POL_NUM As String
            Get
                Return Values(FieldList.POL_NUM)
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
        Public ReadOnly Property PLN_CODE As String
            Get
                Return Values(FieldList.PLN_CODE)
            End Get
        End Property
        Public ReadOnly Property ROLE_ID As String
            Get
                Return Values(FieldList.ROLE_ID)
            End Get
        End Property
        Public ReadOnly Property LST As String
            Get
                Return Values(FieldList.LST)
            End Get
        End Property
        Public ReadOnly Property FST As String
            Get
                Return Values(FieldList.FST)
            End Get
        End Property
        Public ReadOnly Property MID As String
            Get
                Return Values(FieldList.MID)
            End Get
        End Property
        'Public ReadOnly Property ZERO As String
        '  Get
        '    Return Values(FieldList.ZERO)
        '  End Get
        'End Property
        ''Handled By CLM
        'Public ReadOnly Property DSC_GROUP_DOC_CNT As String
        '  Get
        '    Return Values(FieldList.DSC_GROUP_DOC_CNT)
        '  End Get
        'End Property
        'Public ReadOnly Property SPCL_HNDLNG_CODE As String
        '  Get
        '    Return Values(FieldList.SPCL_HNDLNG_CODE)
        '  End Get
        'End Property
        Public ReadOnly Property BRKR_MASTER_NUMBER As String
            Get
                Return Values(FieldList.BRKR_MASTER_NUMBER)
            End Get
        End Property
        Public ReadOnly Property BRKR_FST As String
            Get
                Return Values(FieldList.BRKR_FST)
            End Get
        End Property
        Public ReadOnly Property BRKR_LST As String
            Get
                Return Values(FieldList.BRKR_LST)
            End Get
        End Property
        Public ReadOnly Property BRKR_MID As String
            Get
                Return Values(FieldList.BRKR_MID)
            End Get
        End Property
        Public ReadOnly Property BRKR_SUFFIX As String
            Get
                Return Values(FieldList.BRKR_SUFFIX)
            End Get
        End Property
        Public ReadOnly Property REP_MASTER_NUMBER As String
            Get
                Return Values(FieldList.REP_MASTER_NUMBER)
            End Get
        End Property
        Public ReadOnly Property REP_FST As String
            Get
                Return Values(FieldList.REP_FST)
            End Get
        End Property
        Public ReadOnly Property REP_LST As String
            Get
                Return Values(FieldList.REP_LST)
            End Get
        End Property
        Public ReadOnly Property REP_MID As String
            Get
                Return Values(FieldList.REP_MID)
            End Get
        End Property
        Public ReadOnly Property REP_SUFFIX As String
            Get
                Return Values(FieldList.REP_SUFFIX)
            End Get
        End Property
        'Public ReadOnly Property CUST_PRNT_IND As String
        '  Get
        '    Return Values(FieldList.CUST_PRNT_IND)
        '  End Get
        'End Property
        'Public ReadOnly Property CUST_ARC_IND As String
        '  Get
        '    Return Values(FieldList.CUST_ARC_IND)
        '  End Get
        'End Property
        Public ReadOnly Property ZIP As String
            Get
                Return Values(FieldList.ZIP)
            End Get
        End Property
        Public ReadOnly Property STATE_CODE As String
            Get
                Return Values(FieldList.STATE_CODE)
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

#Region " REC_52_Separator "
    Public Class REC_52_Separator
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            RECORD_SUBTYPE
            CYCLE_DATE
            CO_ID
            POL_NUM
            CVG_ID
            CONT
            PLN_CODE
            ROLE_ID
            ADDRESS1
            ADDRESS2
            ADDRESS3
            CITY
            STATE
            ZIP
            ZIP_SUFFIX
            LST
            FST
            MID
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property RECORD_SUBTYPE As String
            Get
                Return Values(FieldList.RECORD_SUBTYPE)
            End Get
        End Property
        Public ReadOnly Property CYCLE_DATE As String
            Get
                Return Values(FieldList.CYCLE_DATE)
            End Get
        End Property
        Public ReadOnly Property CO_ID As String
            Get
                Return Values(FieldList.CO_ID)
            End Get
        End Property
        Public ReadOnly Property POL_NUM As String
            Get
                Return Values(FieldList.POL_NUM)
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
        Public ReadOnly Property PLN_CODE As String
            Get
                Return Values(FieldList.PLN_CODE)
            End Get
        End Property
        Public ReadOnly Property ROLE_ID As String
            Get
                Return Values(FieldList.ROLE_ID)
            End Get
        End Property
        Public ReadOnly Property ADDRESS1 As String
            Get
                Return Values(FieldList.ADDRESS1)
            End Get
        End Property
        Public ReadOnly Property ADDRESS2 As String
            Get
                Return Values(FieldList.ADDRESS2)
            End Get
        End Property
        Public ReadOnly Property ADDRESS3 As String
            Get
                Return Values(FieldList.ADDRESS3)
            End Get
        End Property
        Public ReadOnly Property CITY As String
            Get
                Return Values(FieldList.CITY)
            End Get
        End Property
        Public ReadOnly Property STATE As String
            Get
                Return Values(FieldList.STATE)
            End Get
        End Property
        Public ReadOnly Property ZIP As String
            Get
                Return Values(FieldList.ZIP)
            End Get
        End Property
        Public ReadOnly Property ZIP_SUFFIX As String
            Get
                Return Values(FieldList.ZIP_SUFFIX)
            End Get
        End Property
        Public ReadOnly Property LST As String
            Get
                Return Values(FieldList.LST)
            End Get
        End Property
        Public ReadOnly Property FST As String
            Get
                Return Values(FieldList.FST)
            End Get
        End Property
        Public ReadOnly Property MID As String
            Get
                Return Values(FieldList.MID)
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

#Region " REC_101_File_Header "
    Public Class REC_101_File_Header
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            RECORD_SUBTYPE
            CYCLE_DATE
            CO_ID
            POL_NUM
            CVG_ID
            CONT
            PLN_CODE
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property RECORD_SUBTYPE As String
            Get
                Return Values(FieldList.RECORD_SUBTYPE)
            End Get
        End Property
        Public ReadOnly Property CYCLE_DATE As String
            Get
                Return Values(FieldList.CYCLE_DATE)
            End Get
        End Property
        Public ReadOnly Property CO_ID As String
            Get
                Return Values(FieldList.CO_ID)
            End Get
        End Property
        Public ReadOnly Property POL_NUM As String
            Get
                Return Values(FieldList.POL_NUM)
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
        Public ReadOnly Property PLN_CODE As String
            Get
                Return Values(FieldList.PLN_CODE)
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

#Region " REC_55_Mailing_Label "
    Public Class REC_55_Mailing_Label
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            RECORD_SUBTYPE
            CYCLE_DATE
            CO_ID
            POL_NUM
            CVG_ID
            CONT
            PLN_CODE
            'ROLE_ID
            LST
            FST
            MID
            ADDRESS1
            ADDRESS2
            ADDRESS3
            CITY
            STATE_CODE
            ZIP
            ZIP_SUFFIX
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property RECORD_SUBTYPE As String
            Get
                Return Values(FieldList.RECORD_SUBTYPE)
            End Get
        End Property
        Public ReadOnly Property CYCLE_DATE As String
            Get
                Return Values(FieldList.CYCLE_DATE)
            End Get
        End Property
        Public ReadOnly Property CO_ID As String
            Get
                Return Values(FieldList.CO_ID)
            End Get
        End Property
        Public ReadOnly Property POL_NUM As String
            Get
                Return Values(FieldList.POL_NUM)
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
        Public ReadOnly Property PLN_CODE As String
            Get
                Return Values(FieldList.PLN_CODE)
            End Get
        End Property
        Public ReadOnly Property LST As String
            Get
                Return Values(FieldList.LST)
            End Get
        End Property
        Public ReadOnly Property FST As String
            Get
                Return Values(FieldList.FST)
            End Get
        End Property
        Public ReadOnly Property MID As String
            Get
                Return Values(FieldList.MID)
            End Get
        End Property
        Public ReadOnly Property ADDRESS1 As String
            Get
                Return Values(FieldList.ADDRESS1)
            End Get
        End Property
        Public ReadOnly Property ADDRESS2 As String
            Get
                Return Values(FieldList.ADDRESS2)
            End Get
        End Property
        Public ReadOnly Property ADDRESS3 As String
            Get
                Return Values(FieldList.ADDRESS3)
            End Get
        End Property
        Public ReadOnly Property CITY As String
            Get
                Return Values(FieldList.CITY)
            End Get
        End Property
        Public ReadOnly Property STATE_CODE As String
            Get
                Return Values(FieldList.STATE_CODE)
            End Get
        End Property
        Public ReadOnly Property ZIP As String
            Get
                Return Values(FieldList.ZIP)
            End Get
        End Property
        Public ReadOnly Property ZIP_SUFFIX As String
            Get
                Return Values(FieldList.ZIP_SUFFIX)
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

#Region " REC_225_Statement_Heading "
    Public Class REC_225_Statement_Heading
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            RECORD_SUBTYPE
            CYCLE_DATE
            CO_ID
            POL_NUM
            CVG_ID
            CONT
            PLN_CODE
            ROLE_ID
            LST
            FST
            MID
            SUFFIX
            TAX_ID
            ADDRESS1
            ADDRESS2
            ADDRESS3
            CITY
            STATE_CODE
            ZIP
            ZIP_SUFFIX
            REP_FST
            REP_LST
            REP_MID
            REP_SUFFIX
            REP_TAX_ID
            REP_ADDRESS1
            REP_ADDRESS2
            REP_ADDRESS3
            REP_CITY
            REP_STATE_CODE
            REP_ZIP
            REP_AREA_CODE
            REP_EXC
            REP_PH_SUFFIX
            REP_MASTER_NUMBER
            ANNTNT_FST
            ANNTNT_LST
            ANNTNT_MID
            ISSUE_DATE
            QUAL_DESC
            EOQ_CASH_VALUE
            BRKR_FST
            BRKR_LST
            BRKR_MID
            BRKR_SUFFIX
            BRKR_TAX_ID
            BRKR_MASTER_NUMBER
            EOQ_ACCOUNTVAL


        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property RECORD_SUBTYPE As String
            Get
                Return Values(FieldList.RECORD_SUBTYPE)
            End Get
        End Property
        Public ReadOnly Property CYCLE_DATE As String
            Get
                Return Values(FieldList.CYCLE_DATE)
            End Get
        End Property
        Public ReadOnly Property CO_ID As String
            Get
                Return Values(FieldList.CO_ID)
            End Get
        End Property
        Public ReadOnly Property POL_NUM As String
            Get
                Return Values(FieldList.POL_NUM)
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
        Public ReadOnly Property PLN_CODE As String
            Get
                Return Values(FieldList.PLN_CODE)
            End Get
        End Property
        Public ReadOnly Property ROLE_ID As String
            Get
                Return Values(FieldList.ROLE_ID)
            End Get
        End Property
        Public ReadOnly Property LST As String
            Get
                Return Values(FieldList.LST)
            End Get
        End Property
        Public ReadOnly Property FST As String
            Get
                Return Values(FieldList.FST)
            End Get
        End Property
        Public ReadOnly Property MID As String
            Get
                Return Values(FieldList.MID)
            End Get
        End Property
        Public ReadOnly Property SUFFIX As String
            Get
                Return Values(FieldList.SUFFIX)
            End Get
        End Property
        Public ReadOnly Property TAX_ID As String
            Get
                Return Values(FieldList.TAX_ID)
            End Get
        End Property
        Public ReadOnly Property ADDRESS1 As String
            Get
                Return Values(FieldList.ADDRESS1)
            End Get
        End Property
        Public ReadOnly Property ADDRESS2 As String
            Get
                Return Values(FieldList.ADDRESS2)
            End Get
        End Property
        Public ReadOnly Property ADDRESS3 As String
            Get
                Return Values(FieldList.ADDRESS3)
            End Get
        End Property
        Public ReadOnly Property CITY As String
            Get
                Return Values(FieldList.CITY)
            End Get
        End Property
        Public ReadOnly Property STATE_CODE As String
            Get
                Return Values(FieldList.STATE_CODE)
            End Get
        End Property
        Public ReadOnly Property ZIP As String
            Get
                Return Values(FieldList.ZIP)
            End Get
        End Property
        Public ReadOnly Property ZIP_SUFFIX As String
            Get
                Return Values(FieldList.ZIP_SUFFIX)
            End Get
        End Property
        Public ReadOnly Property REP_FST As String
            Get
                Return Values(FieldList.REP_FST)
            End Get
        End Property
        Public ReadOnly Property REP_LST As String
            Get
                Return Values(FieldList.REP_LST)
            End Get
        End Property
        Public ReadOnly Property REP_MID As String
            Get
                Return Values(FieldList.REP_MID)
            End Get
        End Property
        Public ReadOnly Property REP_SUFFIX As String
            Get
                Return Values(FieldList.REP_SUFFIX)
            End Get
        End Property
        Public ReadOnly Property REP_TAX_ID As String
            Get
                Return Values(FieldList.REP_TAX_ID)
            End Get
        End Property
        Public ReadOnly Property REP_ADDRESS1 As String
            Get
                Return Values(FieldList.REP_ADDRESS1)
            End Get
        End Property
        Public ReadOnly Property REP_ADDRESS2 As String
            Get
                Return Values(FieldList.REP_ADDRESS2)
            End Get
        End Property
        Public ReadOnly Property REP_ADDRESS3 As String
            Get
                Return Values(FieldList.REP_ADDRESS3)
            End Get
        End Property
        Public ReadOnly Property REP_CITY As String
            Get
                Return Values(FieldList.REP_CITY)
            End Get
        End Property
        Public ReadOnly Property REP_STATE_CODE As String
            Get
                Return Values(FieldList.REP_STATE_CODE)
            End Get
        End Property
        Public ReadOnly Property REP_ZIP As String
            Get
                Return Values(FieldList.REP_ZIP)
            End Get
        End Property
        Public ReadOnly Property REP_AREA_CODE As String
            Get
                Return Values(FieldList.REP_AREA_CODE)
            End Get
        End Property
        Public ReadOnly Property REP_EXC As String
            Get
                Return Values(FieldList.REP_EXC)
            End Get
        End Property
        Public ReadOnly Property REP_PH_SUFFIX As String
            Get
                Return Values(FieldList.REP_PH_SUFFIX)
            End Get
        End Property
        Public ReadOnly Property REP_MASTER_NUMBER As String
            Get
                Return Values(FieldList.REP_MASTER_NUMBER)
            End Get
        End Property
        Public ReadOnly Property ANNTNT_FST As String
            Get
                Return Values(FieldList.ANNTNT_FST)
            End Get
        End Property
        Public ReadOnly Property ANNTNT_LST As String
            Get
                Return Values(FieldList.ANNTNT_LST)
            End Get
        End Property
        Public ReadOnly Property ANNTNT_MID As String
            Get
                Return Values(FieldList.ANNTNT_MID)
            End Get
        End Property
        Public ReadOnly Property ISSUE_DATE As String
            Get
                Return Values(FieldList.ISSUE_DATE)
            End Get
        End Property
        Public ReadOnly Property QUAL_DESC As String
            Get
                Return Values(FieldList.QUAL_DESC)
            End Get
        End Property
        Public ReadOnly Property EOQ_CASH_VALUE As String
            Get
                Return Values(FieldList.EOQ_CASH_VALUE)
            End Get
        End Property
        Public ReadOnly Property BRKR_FST As String
            Get
                Return Values(FieldList.BRKR_FST)
            End Get
        End Property
        Public ReadOnly Property BRKR_LST As String
            Get
                Return Values(FieldList.BRKR_LST)
            End Get
        End Property
        Public ReadOnly Property BRKR_MID As String
            Get
                Return Values(FieldList.BRKR_MID)
            End Get
        End Property
        Public ReadOnly Property BRKR_SUFFIX As String
            Get
                Return Values(FieldList.BRKR_SUFFIX)
            End Get
        End Property
        Public ReadOnly Property BRKR_TAX_ID As String
            Get
                Return Values(FieldList.BRKR_TAX_ID)
            End Get
        End Property
        Public ReadOnly Property BRKR_MASTER_NUMBER As String
            Get
                Return Values(FieldList.BRKR_MASTER_NUMBER)
            End Get
        End Property
        Public ReadOnly Property EOQ_ACCOUNTVAL As String
            Get
                Return Values(FieldList.EOQ_ACCOUNTVAL)
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

#Region " REC_265_Account_Summary "
    Public Class REC_265_Account_Summary
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            RECORD_SUBTYPE
            CYCLE_DATE
            CO_ID
            POL_NUM
            CVG_ID
            CONT
            PLN_CODE
            BOQ_ACCOUNTVAL
            BOY_ACCOUNTVAL
            BOQ_CYTD_PREM
            EOQ_CYTD_PREM
            BOQ_CYTD_WITHD
            EOQ_CYTD_WITHD
            EOQ_ACCOUNTVAL
            BOQ_CYTD_CALENDAR_FEES
            EOQ_CYTD_CALENDAR_FEES
            BOQ_CYTD_SURR_CHARGES
            EOQ_CYTD_SURR_CHARGES
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property RECORD_SUBTYPE As String
            Get
                Return Values(FieldList.RECORD_SUBTYPE)
            End Get
        End Property
        Public ReadOnly Property CYCLE_DATE As String
            Get
                Return Values(FieldList.CYCLE_DATE)
            End Get
        End Property
        Public ReadOnly Property CO_ID As String
            Get
                Return Values(FieldList.CO_ID)
            End Get
        End Property
        Public ReadOnly Property POL_NUM As String
            Get
                Return Values(FieldList.POL_NUM)
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
        Public ReadOnly Property PLN_CODE As String
            Get
                Return Values(FieldList.PLN_CODE)
            End Get
        End Property
        Public ReadOnly Property BOQ_ACCOUNTVAL As Decimal
            Get
                Return CType(Values(FieldList.BOQ_ACCOUNTVAL), Decimal)
            End Get
        End Property
        Public ReadOnly Property BOY_ACCOUNTVAL As Decimal
            Get
                Return CType(Values(FieldList.BOY_ACCOUNTVAL), Decimal)
            End Get
        End Property
        Public ReadOnly Property BOQ_CYTD_PREM As Decimal
            Get
                Return CType(Values(FieldList.BOQ_CYTD_PREM), Decimal)
            End Get
        End Property
        Public ReadOnly Property EOQ_CYTD_PREM As Decimal
            Get
                Return CType(Values(FieldList.EOQ_CYTD_PREM), Decimal)
            End Get
        End Property
        Public ReadOnly Property BOQ_CYTD_WITHD As Decimal
            Get
                Return CType(Values(FieldList.BOQ_CYTD_WITHD), Decimal)
            End Get
        End Property
        Public ReadOnly Property EOQ_CYTD_WITHD As Decimal
            Get
                Return CType(Values(FieldList.EOQ_CYTD_WITHD), Decimal)
            End Get
        End Property
        Public ReadOnly Property EOQ_ACCOUNTVAL As Decimal
            Get
                Return CType(Values(FieldList.EOQ_ACCOUNTVAL), Decimal)
            End Get
        End Property
        Public ReadOnly Property BOQ_CYTD_CALENDAR_FEES As Decimal
            Get
                Return CType(Values(FieldList.BOQ_CYTD_CALENDAR_FEES), Decimal)
            End Get
        End Property
        Public ReadOnly Property EOQ_CYTD_CALENDAR_FEES As Decimal
            Get
                Return CType(Values(FieldList.EOQ_CYTD_CALENDAR_FEES), Decimal)
            End Get
        End Property
        Public ReadOnly Property BOQ_CYTD_SURR_CHARGES As Decimal
            Get
                Return CType(Values(FieldList.BOQ_CYTD_SURR_CHARGES), Decimal)
            End Get
        End Property

        Public ReadOnly Property EOQ_CYTD_SURR_CHARGES As Decimal
            Get
                Return CType(Values(FieldList.EOQ_CYTD_SURR_CHARGES), Decimal)
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

#Region " REC_285_Account_Summary_Total "
    Public Class REC_285_Account_Summary_Total
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            RECORD_SUBTYPE
            CYCLE_DATE
            CO_ID
            POL_NUM
            CVG_ID
            CONT
            PLN_CODE
            EOQ_ACCOUNTVAL
            EOQ_LOANVAL
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property RECORD_SUBTYPE As String
            Get
                Return Values(FieldList.RECORD_SUBTYPE)
            End Get
        End Property
        Public ReadOnly Property CYCLE_DATE As String
            Get
                Return Values(FieldList.CYCLE_DATE)
            End Get
        End Property
        Public ReadOnly Property CO_ID As String
            Get
                Return Values(FieldList.CO_ID)
            End Get
        End Property
        Public ReadOnly Property POL_NUM As String
            Get
                Return Values(FieldList.POL_NUM)
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
        Public ReadOnly Property PLN_CODE As String
            Get
                Return Values(FieldList.PLN_CODE)
            End Get
        End Property
        Public ReadOnly Property EOQ_ACCOUNTVAL As String
            Get
                Return Values(FieldList.EOQ_ACCOUNTVAL)
            End Get
        End Property
        Public ReadOnly Property EOQ_LOANVAL As String
            Get
                Return Values(FieldList.EOQ_LOANVAL)
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

#Region " REC_290_Info_Record "
    Public Class REC_290_Info_Record
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            RECORD_SUBTYPE
            CYCLE_DATE
            CO_ID
            POL_NUM
            CVG_ID
            CONT
            PLN_CODE
            EOQ_DEATHBEN_AMT
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property RECORD_SUBTYPE As String
            Get
                Return Values(FieldList.RECORD_SUBTYPE)
            End Get
        End Property
        Public ReadOnly Property CYCLE_DATE As String
            Get
                Return Values(FieldList.CYCLE_DATE)
            End Get
        End Property
        Public ReadOnly Property CO_ID As String
            Get
                Return Values(FieldList.CO_ID)
            End Get
        End Property
        Public ReadOnly Property POL_NUM As String
            Get
                Return Values(FieldList.POL_NUM)
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
        Public ReadOnly Property PLN_CODE As String
            Get
                Return Values(FieldList.PLN_CODE)
            End Get
        End Property
        Public ReadOnly Property EOQ_DEATHBEN_AMT As String
            Get
                Return Values(FieldList.EOQ_DEATHBEN_AMT)
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

#Region " REC_605_Transaction_Summary "
    Public Class REC_605_Transaction_Summary
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            RECORD_SUBTYPE
            CYCLE_DATE
            POL_NUM
            CVG_ID
            CONT
            PLN_CODE
            ACC_CODE
            DIV_CODE
            FUND_CODE_DESC
            ACCT_TYPE
            EOQ_VALUE
            EOQ_UNITS
            EOQ_UNIT_VALUE
            'FUND_CUSIP
            EOQ_UNITS_TOTAL
            EOQ_ACCOUNTVAL
            EOQ_RATE
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property RECORD_SUBTYPE As String
            Get
                Return Values(FieldList.RECORD_SUBTYPE)
            End Get
        End Property
        Public ReadOnly Property CYCLE_DATE As String
            Get
                Return Values(FieldList.CYCLE_DATE)
            End Get
        End Property
        'Public ReadOnly Property CN_CO_ID As String
        '  Get
        '    Return Values(FieldList.CN_CO_ID)
        '  End Get
        'End Property
        Public ReadOnly Property POL_NUM As String
            Get
                Return Values(FieldList.POL_NUM)
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
        Public ReadOnly Property PLN_CODE As String
            Get
                Return Values(FieldList.PLN_CODE)
            End Get
        End Property
        Public ReadOnly Property ACC_CODE As String
            Get
                Return Values(FieldList.ACC_CODE)
            End Get
        End Property
        Public ReadOnly Property DIV_CODE As String
            Get
                Return Values(FieldList.DIV_CODE)
            End Get
        End Property
        Public ReadOnly Property FUND_CODE_DESC As String
            Get
                Return Values(FieldList.FUND_CODE_DESC)
            End Get
        End Property
        Public ReadOnly Property ACCT_TYPE As String
            Get
                Return Values(FieldList.ACCT_TYPE)
            End Get
        End Property
        Public ReadOnly Property EOQ_VALUE As Decimal
            Get
                Return CType(Values(FieldList.EOQ_VALUE), Decimal)
            End Get
        End Property
        Public ReadOnly Property EOQ_UNITS As Decimal
            Get
                Return CType(Values(FieldList.EOQ_UNITS), Decimal)
            End Get
        End Property
        Public ReadOnly Property EOQ_UNIT_VALUE As Decimal
            Get
                Return CType(Values(FieldList.EOQ_UNIT_VALUE), Decimal)
            End Get
        End Property
        Public ReadOnly Property EOQ_UNITS_TOTAL As Decimal
            Get
                Return CType(Values(FieldList.EOQ_UNITS_TOTAL), Decimal)
            End Get
        End Property
        Public ReadOnly Property EOQ_ACCOUNTVAL As Decimal
            Get
                Return CType(Values(FieldList.EOQ_ACCOUNTVAL), Decimal)
            End Get
        End Property
        Public ReadOnly Property EOQ_RATE As Decimal
            Get
                Return CType(Values(FieldList.EOQ_RATE), Decimal)
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

#Region " REC_625_Transaction_Summary_Total "
    Public Class REC_625_Transaction_Summary_Total
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            RECORD_SUBTYPE
            CYCLE_DATE
            POL_NUM
            CVG_ID
            CONT
            PLN_CODE
            EOQ_ACCOUNTVAL

        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property RECORD_SUBTYPE As String
            Get
                Return Values(FieldList.RECORD_SUBTYPE)
            End Get
        End Property
        Public ReadOnly Property CYCLE_DATE As String
            Get
                Return Values(FieldList.CYCLE_DATE)
            End Get
        End Property
        Public ReadOnly Property POL_NUM As String
            Get
                Return Values(FieldList.POL_NUM)
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
        Public ReadOnly Property PLN_CODE As String
            Get
                Return Values(FieldList.PLN_CODE)
            End Get
        End Property
        Public ReadOnly Property EOQ_ACCOUNTVAL As String
            Get
                Return Values(FieldList.EOQ_ACCOUNTVAL)
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

    '#Region " REC_830_Marketing_Message "
    '  Public Class REC_830_Marketing_Message
    '    Inherits SourceDef

    '#Region " FEILD ARRAY ENUM "
    '    Public Shadows Enum FieldList
    '      RECORD_TYPE
    '      RECORD_SUBTYPE
    '      CYCLE_DATE
    '      CN_CO_ID
    '      CN_POL_NUM
    '      CVG_ID
    '      CONT
    '      PLN_CODE
    '      ROLE_ID
    '      ADDRESS1
    '      ADDRESS2
    '      ADDRESS3
    '    End Enum
    '#End Region

    '#Region " PUBLIC PROPERTIES "
    '    Public ReadOnly Property RECORD_TYPE As String
    '      Get
    '        Return Values(FieldList.RECORD_TYPE)
    '      End Get
    '    End Property
    '    Public ReadOnly Property RECORD_SUBTYPE As String
    '      Get
    '        Return Values(FieldList.RECORD_SUBTYPE)
    '      End Get
    '    End Property
    '    Public ReadOnly Property CYCLE_DATE As String
    '      Get
    '        Return Values(FieldList.CYCLE_DATE)
    '      End Get
    '    End Property
    '    Public ReadOnly Property CN_CO_ID As String
    '      Get
    '        Return Values(FieldList.CN_CO_ID)
    '      End Get
    '    End Property
    '    Public ReadOnly Property CN_POL_NUM As String
    '      Get
    '        Return Values(FieldList.CN_POL_NUM)
    '      End Get
    '    End Property
    '    Public ReadOnly Property CVG_ID As String
    '      Get
    '        Return Values(FieldList.CVG_ID)
    '      End Get
    '    End Property
    '    Public ReadOnly Property CONT As String
    '      Get
    '        Return Values(FieldList.CONT)
    '      End Get
    '    End Property
    '    Public ReadOnly Property PLN_CODE As String
    '      Get
    '        Return Values(FieldList.PLN_CODE)
    '      End Get
    '    End Property
    '    Public ReadOnly Property ADDRESS1 As String
    '      Get
    '        Return Values(FieldList.ADDRESS1)
    '      End Get
    '    End Property
    '    Public ReadOnly Property ADDRESS2 As String
    '      Get
    '        Return Values(FieldList.ADDRESS2)
    '      End Get
    '    End Property
    '    Public ReadOnly Property ADDRESS3 As String
    '      Get
    '        Return Values(FieldList.ADDRESS3)
    '      End Get
    '    End Property
    '#End Region

    '#Region " CONSTRUCTORS "
    '    Public Sub New()
    '      MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
    '    End Sub
    '#End Region

    'End Class


#End Region


#Region " PoC_Source "
    Public Class PoC_Source
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            CN_POL_NUM
            CN_CO_ID
            NA_NAME_ID
            AS_ADDRESS_ID
            NA_FST
            NA_MID
            NA_LST
            CN_COMPANY_NAME
            AS_ADDRESS1
            AS_ADDRESS2
            AS_ADDRESS3
            AS_CITY
            AS_STATE_CODE
            AS_ZIP
            AS_ZIP_SUFFIX
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property RECORD_TYPE As String
            Get
                Return Values(FieldList.RECORD_TYPE)
            End Get
        End Property
        Public ReadOnly Property CN_POL_NUM As String
            Get
                Return Values(FieldList.CN_POL_NUM)
            End Get
        End Property
        Public ReadOnly Property CN_CO_ID As String
            Get
                Return Values(FieldList.CN_CO_ID)
            End Get
        End Property
        Public ReadOnly Property NA_NAME_ID As String
            Get
                Return Values(FieldList.NA_NAME_ID)
            End Get
        End Property
        Public ReadOnly Property AS_ADDRESS_ID As String
            Get
                Return Values(FieldList.AS_ADDRESS_ID)
            End Get
        End Property
        Public ReadOnly Property NA_FST As String
            Get
                Return Values(FieldList.NA_FST)
            End Get
        End Property
        Public ReadOnly Property NA_MID As String
            Get
                Return Values(FieldList.NA_MID)
            End Get
        End Property
        Public ReadOnly Property NA_LST As String
            Get
                Return Values(FieldList.NA_LST)
            End Get
        End Property
        Public ReadOnly Property CN_COMPANY_NAME As String
            Get
                Return Values(FieldList.CN_COMPANY_NAME)
            End Get
        End Property
        Public ReadOnly Property AS_ADDRESS1 As String
            Get
                Return Values(FieldList.AS_ADDRESS1)
            End Get
        End Property
        Public ReadOnly Property AS_ADDRESS2 As String
            Get
                Return Values(FieldList.AS_ADDRESS2)
            End Get
        End Property
        Public ReadOnly Property AS_ADDRESS3 As String
            Get
                Return Values(FieldList.AS_ADDRESS3)
            End Get
        End Property
        Public ReadOnly Property AS_CITY As String
            Get
                Return Values(FieldList.AS_CITY)
            End Get
        End Property
        Public ReadOnly Property AS_STATE_CODE As String
            Get
                Return Values(FieldList.AS_STATE_CODE)
            End Get
        End Property
        Public ReadOnly Property AS_ZIP As String
            Get
                Return Values(FieldList.AS_ZIP)
            End Get
        End Property
        Public ReadOnly Property AS_ZIP_SUFFIX As String
            Get
                Return Values(FieldList.AS_ZIP_SUFFIX)
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

    '#End Region

End Namespace
