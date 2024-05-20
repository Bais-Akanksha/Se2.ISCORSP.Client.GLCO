Imports Se2.ISI.Base.Presentation

Namespace Se2.ISCORSP.Client.GLCO.FixedAnnivStmt.SourceLayouts

#Region " FixedAnnivStmt "

#Region " Policies "

    Public Class Policies
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
#Region " Policy "
    Public Class Policy
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            CYCLEDATE
            POL_NUM
            CVG_ID
            CONT
            PLN_CODE
            STATUS
            ISSUE_DATE
            ISSUE_STATE
            TERM_DATE
            CO_CODE
            CO_NAME
            CO_ID
            QUALIFIED_FLG
            QUAL_CODE
            QUAL_DESC
            PRD_DESC
            MAIL_TYPE
            PRODUCT_CO
            PLN_TYPE
            PRCSSNG_CO
            MKT_PRDCT_NAME
            MIN_GUAR_RATE
            VARIATION_GROUP_DESC
            LTC_RIDER_FLAG
            RELATED_CONT
            LTC_SPEC_ID
            LTC_SPEC_CODE
            LTC_RIDER_CLASS
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
        Public ReadOnly Property PLN_CODE As String
            Get
                Return Values(FieldList.PLN_CODE)
            End Get
        End Property
        Public ReadOnly Property STATUS As String
            Get
                Return Values(FieldList.STATUS)
            End Get
        End Property
        Public ReadOnly Property ISSUE_DATE As String
            Get
                Return Values(FieldList.ISSUE_DATE)
            End Get
        End Property
        Public ReadOnly Property ISSUE_STATE As String
            Get
                Return Values(FieldList.ISSUE_STATE)
            End Get
        End Property
        Public ReadOnly Property TERM_DATE As String
            Get
                Return Values(FieldList.TERM_DATE)
            End Get
        End Property
        Public ReadOnly Property CO_CODE As String
            Get
                Return Values(FieldList.CO_CODE)
            End Get
        End Property
        Public ReadOnly Property CO_NAME As String
            Get
                Return Values(FieldList.CO_NAME)
            End Get
        End Property
        Public ReadOnly Property CO_ID As String
            Get
                Return Values(FieldList.CO_ID)
            End Get
        End Property
        Public ReadOnly Property QUALIFIED_FLG As String
            Get
                Return Values(FieldList.QUALIFIED_FLG)
            End Get
        End Property
        Public ReadOnly Property QUAL_CODE As String
            Get
                Return Values(FieldList.QUAL_CODE)
            End Get
        End Property
        Public ReadOnly Property QUAL_DESC As String
            Get
                Return Values(FieldList.QUAL_DESC)
            End Get
        End Property
        Public ReadOnly Property PRD_DESC As String
            Get
                Return Values(FieldList.PRD_DESC)
            End Get
        End Property
        Public ReadOnly Property MAIL_TYPE As String
            Get
                Return Values(FieldList.MAIL_TYPE)
            End Get
        End Property
        Public ReadOnly Property PRODUCT_CO As String
            Get
                Return Values(FieldList.PRODUCT_CO)
            End Get
        End Property
        Public ReadOnly Property PLN_TYPE As String
            Get
                Return Values(FieldList.PLN_TYPE)
            End Get
        End Property
        Public ReadOnly Property PRCSSNG_CO As String
            Get
                Return Values(FieldList.PRCSSNG_CO)
            End Get
        End Property
        Public ReadOnly Property MKT_PRDCT_NAME As String
            Get
                Return Values(FieldList.MKT_PRDCT_NAME)
            End Get
        End Property
        Public ReadOnly Property MIN_GUAR_RATE As String
            Get
                Return Values(FieldList.MIN_GUAR_RATE)
            End Get
        End Property
        Public ReadOnly Property VARIATION_GROUP_DESC As String
            Get
                Return Values(FieldList.VARIATION_GROUP_DESC)
            End Get
        End Property
        Public ReadOnly Property LTC_RIDER_FLAG As String
            Get
                Return Values(FieldList.LTC_RIDER_FLAG)
            End Get
        End Property
        Public ReadOnly Property RELATED_CONT As String
            Get
                Return Values(FieldList.RELATED_CONT)
            End Get
        End Property

        Public ReadOnly Property LTC_SPEC_ID As String
            Get
                Return Values(FieldList.LTC_SPEC_ID)
            End Get
        End Property
        Public ReadOnly Property LTC_SPEC_CODE As String
            Get
                Return Values(FieldList.LTC_SPEC_CODE)
            End Get
        End Property
        Public ReadOnly Property LTC_RIDER_CLASS As String
            Get
                Return Values(FieldList.LTC_RIDER_CLASS)
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

#Region " Roles "

    Public Class Roles
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
#Region " Role "
    Public Class Role
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            RECORD_SUBTYPE
            POL_NUM
            CVG_ID
            CONT
            ROLE_ID
            OPT_ID
            NAME_ID
            ADDRESS_ID
            PERCENT_SPLIT
            SALUTE
            FST
            MID
            LST
            SUFFIX
            TAX_ID
            NAME_TYPE
            EMAIL
            ADDRESS1
            ADDRESS2
            ADDRESS3
            CITY
            STATE_CODE
            ZIP
            ZIP_SUFFIX
            CTRY_CODE
            ADDRESS_TYPE
            EXT_ID
            NEXT_HIGHER
            PHONE_TYPE
            PH_CTRY_CODE
            AREA_CODE
            EXC
            PH_SUFFIX
            EXT
            MASTER_NUMBER
            MAIL_FLAG
            MAIL_TYPE
            JT_ADDR_DIFF
            OPT_DESC
            'MAIL_FLAG_CONTPROF  'not used for GLCO block as Agents do not receive copies.
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
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
        Public ReadOnly Property ROLE_ID As String
            Get
                Return Values(FieldList.ROLE_ID)
            End Get
        End Property
        Public ReadOnly Property OPT_ID As String
            Get
                Return Values(FieldList.OPT_ID)
            End Get
        End Property
        Public ReadOnly Property NAME_ID As String
            Get
                Return Values(FieldList.NAME_ID)
            End Get
        End Property
        Public ReadOnly Property ADDRESS_ID As String
            Get
                Return Values(FieldList.ADDRESS_ID)
            End Get
        End Property
        Public ReadOnly Property PERCENT_SPLIT As Decimal
            Get
                Return CType(Values(FieldList.PERCENT_SPLIT), Decimal)
            End Get
        End Property
        Public ReadOnly Property SALUTE As String
            Get
                Return Values(FieldList.SALUTE)
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
        Public ReadOnly Property LST As String
            Get
                Return Values(FieldList.LST)
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
        Public ReadOnly Property NAME_TYPE As String
            Get
                Return Values(FieldList.NAME_TYPE)
            End Get
        End Property
        Public ReadOnly Property EMAIL As String
            Get
                Return Values(FieldList.EMAIL)
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
        Public ReadOnly Property CTRY_CODE As String
            Get
                Return Values(FieldList.CTRY_CODE)
            End Get
        End Property
        Public ReadOnly Property ADDRESS_TYPE As String
            Get
                Return Values(FieldList.ADDRESS_TYPE)
            End Get
        End Property
        Public ReadOnly Property EXT_ID As String
            Get
                Return Values(FieldList.EXT_ID)
            End Get
        End Property
        Public ReadOnly Property NEXT_HIGHER As String
            Get
                Return Values(FieldList.NEXT_HIGHER)
            End Get
        End Property
        Public ReadOnly Property PHONE_TYPE As String
            Get
                Return Values(FieldList.PHONE_TYPE)
            End Get
        End Property
        Public ReadOnly Property PH_CTRY_CODE As String
            Get
                Return Values(FieldList.PH_CTRY_CODE)
            End Get
        End Property
        Public ReadOnly Property AREA_CODE As String
            Get
                Return Values(FieldList.AREA_CODE)
            End Get
        End Property
        Public ReadOnly Property EXC As String
            Get
                Return Values(FieldList.EXC)
            End Get
        End Property
        Public ReadOnly Property PH_SUFFIX As String
            Get
                Return Values(FieldList.PH_SUFFIX)
            End Get
        End Property
        Public ReadOnly Property EXT As String
            Get
                Return Values(FieldList.EXT)
            End Get
        End Property
        Public ReadOnly Property MASTER_NUMBER As String
            Get
                Return Values(FieldList.MASTER_NUMBER)
            End Get
        End Property
        Public ReadOnly Property MAIL_FLAG As String
            Get
                Return Values(FieldList.MAIL_FLAG)
            End Get
        End Property
        Public ReadOnly Property MAIL_TYPE As String
            Get
                Return Values(FieldList.MAIL_TYPE)
            End Get
        End Property
        Public ReadOnly Property JT_ADDR_DIFF As String
            Get
                Return Values(FieldList.JT_ADDR_DIFF)
            End Get
        End Property
        Public ReadOnly Property OPT_DESC As String
            Get
                Return Values(FieldList.OPT_DESC)
            End Get
        End Property
        'Public ReadOnly Property MAIL_FLAG_CONTPROF As String
        '    Get
        '        Return Values(FieldList.MAIL_FLAG_CONTPROF)
        '    End Get
        'End Property
#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class

#End Region

#Region " Carrier Information "

    Public Class CarrierInformation
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
#Region " Carrier "
    Public Class Carrier
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            RECORD_SUBTYPE
            CONT
            CO_ID
            PLN_CODE
            CO_NAME
            ADDR_LINE_1
            ADDR_LINE_2
            ADDR_LINE_3
            CITY
            STATE
            ZIP_CODE
            WEB_ADDRESS
            UNFRMTTD_PHONE
            PHONE_NUM
            FAX_AREA_CODE
            FAX_NUM
            OFFICE_HOURS
            OFFICE_DAYS
            BUDGET_CENTER
            POB_LINE_1
            POB_LINE_2
            POB_LINE_3
            POB_CITY
            POB_STATE
            POB_ZIP_CODE
            MAIL_LINE_1
            MAIL_LINE_2
            MAIL_LINE_3
            MAIL_CITY
            MAIL_STATE
            MAIL_ZIP_CODE
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
        Public ReadOnly Property CONT As String
            Get
                Return Values(FieldList.CONT)
            End Get
        End Property
        Public ReadOnly Property CO_ID As String
            Get
                Return Values(FieldList.CO_ID)
            End Get
        End Property
        Public ReadOnly Property PLN_CODE As String
            Get
                Return Values(FieldList.PLN_CODE)
            End Get
        End Property
        Public ReadOnly Property CO_NAME As String
            Get
                Return Values(FieldList.CO_NAME)
            End Get
        End Property
        Public ReadOnly Property ADDR_LINE_1 As String
            Get
                Return Values(FieldList.ADDR_LINE_1)
            End Get
        End Property
        Public ReadOnly Property ADDR_LINE_2 As String
            Get
                Return Values(FieldList.ADDR_LINE_2)
            End Get
        End Property
        Public ReadOnly Property ADDR_LINE_3 As String
            Get
                Return Values(FieldList.ADDR_LINE_3)
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
        Public ReadOnly Property ZIP_CODE As String
            Get
                Return Values(FieldList.ZIP_CODE)
            End Get
        End Property
        Public ReadOnly Property WEB_ADDRESS As String
            Get
                Return Values(FieldList.WEB_ADDRESS)
            End Get
        End Property
        Public ReadOnly Property UNFRMTTD_PHONE As String
            Get
                Return Values(FieldList.UNFRMTTD_PHONE)
            End Get
        End Property
        Public ReadOnly Property PHONE_NUM As String
            Get
                Return Values(FieldList.PHONE_NUM)
            End Get
        End Property
        Public ReadOnly Property FAX_AREA_CODE As String
            Get
                Return Values(FieldList.FAX_AREA_CODE)
            End Get
        End Property
        Public ReadOnly Property FAX_NUM As String
            Get
                Return Values(FieldList.FAX_NUM)
            End Get
        End Property
        Public ReadOnly Property OFFICE_HOURS As String
            Get
                Return Values(FieldList.OFFICE_HOURS)
            End Get
        End Property
        Public ReadOnly Property OFFICE_DAYS As String
            Get
                Return Values(FieldList.OFFICE_DAYS)
            End Get
        End Property
        Public ReadOnly Property BUDGET_CENTER As String
            Get
                Return Values(FieldList.BUDGET_CENTER)
            End Get
        End Property
        Public ReadOnly Property POB_LINE_1 As String
            Get
                Return Values(FieldList.POB_LINE_1)
            End Get
        End Property
        Public ReadOnly Property POB_LINE_2 As String
            Get
                Return Values(FieldList.POB_LINE_2)
            End Get
        End Property
        Public ReadOnly Property POB_LINE_3 As String
            Get
                Return Values(FieldList.POB_LINE_3)
            End Get
        End Property
        Public ReadOnly Property POB_CITY As String
            Get
                Return Values(FieldList.POB_CITY)
            End Get
        End Property
        Public ReadOnly Property POB_STATE As String
            Get
                Return Values(FieldList.POB_STATE)
            End Get
        End Property
        Public ReadOnly Property POB_ZIP_CODE As String
            Get
                Return Values(FieldList.POB_ZIP_CODE)
            End Get
        End Property
        Public ReadOnly Property MAIL_LINE_1 As String
            Get
                Return Values(FieldList.MAIL_LINE_1)
            End Get
        End Property
        Public ReadOnly Property MAIL_LINE_2 As String
            Get
                Return Values(FieldList.MAIL_LINE_2)
            End Get
        End Property
        Public ReadOnly Property MAIL_LINE_3 As String
            Get
                Return Values(FieldList.MAIL_LINE_3)
            End Get
        End Property
        Public ReadOnly Property MAIL_CITY As String
            Get
                Return Values(FieldList.MAIL_CITY)
            End Get
        End Property
        Public ReadOnly Property MAIL_STATE As String
            Get
                Return Values(FieldList.MAIL_STATE)
            End Get
        End Property
        Public ReadOnly Property MAIL_ZIP_CODE As String
            Get
                Return Values(FieldList.MAIL_ZIP_CODE)
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

#Region " PolValues "

    Public Class PolValues
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
#Region " PolValue "
    Public Class PolValue
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            RECORD_SUBTYPE
            POL_NUM
            CVG_ID
            CONT
            PLN_CODE
            CURR_ANNIV_DATE
            CURR_ACCT_VAL
            CASH_VAL
            ANNIV_DEATH_BNFT
            SURR_CHRG
            PYTD_WITHD
            PYTD_PREM
            PRIOR_ANNIV_DATE
            PRIOR_ACCT_VAL
            LTC_EXTENDED_BEN
            GUAR_PERIOD
            LTC_MAX_DAILY_BNFT
            LTC_CLAIM_WAIVER
            LTC_PYTD_WITHD_PREM
            CURR_LTC_PREM_AMT
            LTC_PYTD_WITHD_BNFT
            LTC_ASSESEMENT_CHRG
            RELATED_CONT
            LTC_RIDER_BNFT
            LTC_AGG_DAILY_MAX
            LTC_RC_VARIATION_GROUP_ID
            LTC_VARIATION_GROUP_ID
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
        Public ReadOnly Property CURR_ANNIV_DATE As String
            Get
                Return Values(FieldList.CURR_ANNIV_DATE)
            End Get
        End Property
        Public ReadOnly Property CURR_ACCT_VAL As Decimal
            Get
                Return CType(Values(FieldList.CURR_ACCT_VAL), Decimal)
            End Get
        End Property
        Public ReadOnly Property CASH_VAL As String
            Get
                Return Values(FieldList.CASH_VAL)
            End Get
        End Property
        Public ReadOnly Property ANNIV_DEATH_BNFT As String
            Get
                Return Values(FieldList.ANNIV_DEATH_BNFT)
            End Get
        End Property
        Public ReadOnly Property SURR_CHRG As Decimal
            Get
                Return CType(Values(FieldList.SURR_CHRG), Decimal)
            End Get
        End Property
        Public ReadOnly Property PYTD_WITHD As Decimal
            Get
                Return CType(Values(FieldList.PYTD_WITHD), Decimal)
            End Get
        End Property
        Public ReadOnly Property PYTD_PREM As Decimal
            Get
                Return CType(Values(FieldList.PYTD_PREM), Decimal)
            End Get
        End Property
        Public ReadOnly Property PRIOR_ANNIV_DATE As String
            Get
                Return Values(FieldList.PRIOR_ANNIV_DATE)
            End Get
        End Property
        Public ReadOnly Property PRIOR_ACCT_VAL As Decimal
            Get
                Return CType(Values(FieldList.PRIOR_ACCT_VAL), Decimal)
            End Get
        End Property
        Public ReadOnly Property LTC_EXTENDED_BEN As String
            Get
                Return Values(FieldList.LTC_EXTENDED_BEN)
            End Get
        End Property
        Public ReadOnly Property GUAR_PERIOD As String
            Get
                Return Values(FieldList.GUAR_PERIOD)
            End Get
        End Property
        Public ReadOnly Property LTC_MAX_DAILY_BNFT As String
            Get
                Return Values(FieldList.LTC_MAX_DAILY_BNFT)
            End Get
        End Property
        Public ReadOnly Property LTC_CLAIM_WAIVER As String
            Get
                Return Values(FieldList.LTC_CLAIM_WAIVER)
            End Get
        End Property
        Public ReadOnly Property LTC_PYTD_WITHD_PREM As Decimal
            Get
                Return CType(Values(FieldList.LTC_PYTD_WITHD_PREM), Decimal)
            End Get
        End Property
        Public ReadOnly Property CURR_LTC_PREM_AMT As String
            Get
                Return Values(FieldList.CURR_LTC_PREM_AMT)
            End Get
        End Property
        Public ReadOnly Property LTC_PYTD_WITHD_BNFT As Decimal
            Get
                Return CType(Values(FieldList.LTC_PYTD_WITHD_BNFT), Decimal)
            End Get
        End Property
        Public ReadOnly Property LTC_ASSESEMENT_CHRG As Decimal
            Get
                Return CType(Values(FieldList.LTC_ASSESEMENT_CHRG), Decimal)
            End Get
        End Property
        Public ReadOnly Property RELATED_CONT As String
            Get
                Return Values(FieldList.RELATED_CONT)
            End Get
        End Property
        Public ReadOnly Property LTC_RIDER_BNFT As String
            Get
                Return Values(FieldList.LTC_RIDER_BNFT)
            End Get
        End Property
        Public ReadOnly Property LTC_AGG_DAILY_MAX As String
            Get
                Return Values(FieldList.LTC_AGG_DAILY_MAX)
            End Get
        End Property
        Public ReadOnly Property LTC_RC_VARIATION_GROUP_ID As String
            Get
                Return Values(FieldList.LTC_RC_VARIATION_GROUP_ID)
            End Get
        End Property
        Public ReadOnly Property LTC_VARIATION_GROUP_ID As String
            Get
                Return Values(FieldList.LTC_VARIATION_GROUP_ID)
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

#Region " FundValues "

    Public Class FundValues
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
#Region " FundValue "
    Public Class FundValue
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            RECORD_SUBTYPE
            POL_NUM
            CVG_ID
            CONT
            FUND_CODE
            ACC_CODE
            DIV_CODE
            MRKT_FUND_NAME
            VALUE
            RATE
            ADJUSTED_RATE

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
        Public ReadOnly Property FUND_CODE As String
            Get
                Return Values(FieldList.FUND_CODE)
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
        Public ReadOnly Property MRKT_FUND_NAME As String
            Get
                Return Values(FieldList.MRKT_FUND_NAME)
            End Get
        End Property
        Public ReadOnly Property VALUE As String
            Get
                Return Values(FieldList.VALUE)
            End Get
        End Property
        Public ReadOnly Property RATE As Decimal
            Get
                Return CType(Values(FieldList.RATE), Decimal)
            End Get
        End Property
        Public ReadOnly Property ADJUSTED_RATE As String
            Get
                Return Values(FieldList.ADJUSTED_RATE)
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

#Region " Features "

    Public Class Features
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
#Region " Feature "
    Public Class Feature
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            RECORD_SUBTYPE
            CONT
            SPEC_CODE
            SPEC_CODE_DESC
            VARIATION_GROUP_ID
            VARIATION_GROUP_DESC
            SPEC_DESC
            SPEC_ID
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
        Public ReadOnly Property CONT As String
            Get
                Return Values(FieldList.CONT)
            End Get
        End Property
        Public ReadOnly Property SPEC_CODE As String
            Get
                Return Values(FieldList.SPEC_CODE)
            End Get
        End Property
        Public ReadOnly Property SPEC_CODE_DESC As String
            Get
                Return Values(FieldList.SPEC_CODE_DESC)
            End Get
        End Property
        Public ReadOnly Property VARIATION_GROUP_ID As String
            Get
                Return Values(FieldList.VARIATION_GROUP_ID)
            End Get
        End Property
        Public ReadOnly Property VARIATION_GROUP_DESC As String
            Get
                Return Values(FieldList.VARIATION_GROUP_DESC)
            End Get
        End Property
        Public ReadOnly Property SPEC_DESC As String
            Get
                Return Values(FieldList.SPEC_DESC)
            End Get

        End Property
        Public ReadOnly Property SPEC_ID As String
            Get
                Return Values(FieldList.SPEC_ID)
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

#Region " TransHst "

    Public Class TransHst
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
#Region " TxnHst "
    Public Class TxnHst
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            RECORD_SUBTYPE
            POL_NUM
            CVG_ID
            CONT
            TXN_DATE
            TXN_NUM
            TXN_TYPE_DESC
            TXN_TYPE
            TOTAL_FUND_TXN_AMT

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
        Public ReadOnly Property TXN_DATE As String
            Get
                Return Values(FieldList.TXN_DATE)
            End Get
        End Property
        Public ReadOnly Property TXN_NUM As String
            Get
                Return Values(FieldList.TXN_NUM)
            End Get
        End Property
        Public ReadOnly Property TXN_TYPE_DESC As String
            Get
                Return Values(FieldList.TXN_TYPE_DESC)
            End Get
        End Property
        Public ReadOnly Property TXN_TYPE As String
            Get
                Return Values(FieldList.TXN_TYPE)
            End Get
        End Property
        Public ReadOnly Property TOTAL_FUND_TXN_AMT As Decimal
            Get
                Return CType(Values(FieldList.TOTAL_FUND_TXN_AMT), Decimal)
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

#Region " TransFndHst "

    Public Class TransFndHst
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
#Region " TxnFndHst "
    Public Class TxnFndHst
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            RECORD_TYPE
            RECORD_SUBTYPE
            POL_NUM
            CVG_ID
            CONT
            TXN_NUM
            ACC_CODE
            DIV_CODE
            MRKT_FUND_NAME
            FUND_TXN_AMT
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
        Public ReadOnly Property TXN_NUM As String
            Get
                Return Values(FieldList.TXN_NUM)
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
        Public ReadOnly Property MRKT_FUND_NAME As String
            Get
                Return Values(FieldList.MRKT_FUND_NAME)
            End Get
        End Property
        Public ReadOnly Property FUND_TXN_AMT As String
            Get
                Return Values(FieldList.FUND_TXN_AMT)
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
