Imports Se2.ISI.Base.Presentation

Namespace Se2.ISCORSP.Client.GLCO.FIAPolicyPage.SourceLayouts

#Region " Policies "

    Public Class POLICIES
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

    Public Class POLICY
        Inherits SourceDef

#Region " Field Array Enum "
        Public Shadows Enum FieldList
            REC_TYPE
            CN_CONT
            CN_POL_NUM
            CN_COMPANY_NAME
            POL_MAIL_TYPE
            CN_PLN_CODE
            CN_PRD_DESC
            CN_PLN_TYPE
            CN_QUAL_DESC
            CN_TAX_CATEG_DESC
            CN_STATUS
            CN_ISSUE_DATE
            CN_ISSUE_STATE
            CN_PREM
            CN_PREM_MODE
            CN_DB_DESC
            CN_BASIS_POINT_TOTAL
            EX_EXCHANGE_TYPE
            CN_PAYOUT_OPT
            CN_MAT_DATE
            PA_FIXED_PAY_AMT            ' used in calculation
            PA_VAR_PAY_AMT              ' used in calculation
            PA_PAY_MODE
            PA_GNTY_PERD
            CN_FIRST_PAYOUT_PMT_DATE
            CN_PAYOUT_STOP_DATE
            CN_FIXED_PAY_AMT
            CN_VAR_PAY_AMT
            CN_MIN_GUAR_RATE
            CN_GNTY_PERD
            CN_PRIM_RT_CLASS
            CN_JT_RT_CLASS
            CN_PRIM_FLATEX
            CN_JT_FLATEX
            YEAR1_RATE
            YEAR2_RATE
            MVA_INDEX_RATE
            MVA_INDEX_VAL
            UDV1
            NEXT_ANNIV_DATE
            BAIL_WIND
            SURR_PERIOD
            FIXED_RATE_BAND1
            FIXED_RATE_BAND2
            FIXED_RATE_BAND3
            CAP_RATE_BAND1
            CAP_RATE_BAND2
            CAP_RATE_BAND3
            MARGIN_RATE_BAND1
            MARGIN_RATE_BAND2
            MARGIN_RATE_BAND3
            MAT_AGE
            ANN_OPTION

            ''LGP-16536
            PREM_BONUS_PERC
            RIDER_FEE_PERC
            PAY_INCR_PERC
            LEVEL_PAYOUT_FACTOR
            INCREASING_PAYOUT_FACTOR
            GLWB_WAIT_PERIOD

        End Enum
#End Region

#Region " Public Properties "
        Public ReadOnly Property REC_TYPE As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property CN_CONT As String
            Get
                Return Values(FieldList.CN_CONT)
            End Get
        End Property
        Public ReadOnly Property CN_POL_NUM As Int32
            Get
                Return Convert.ToInt32(Values(FieldList.CN_POL_NUM))
            End Get
        End Property
        Public ReadOnly Property CN_COMPANY_NAME As String
            Get
                Return Values(FieldList.CN_COMPANY_NAME)
            End Get
        End Property
        Public ReadOnly Property POL_MAIL_TYPE As String
            Get
                Return Values(FieldList.POL_MAIL_TYPE)
            End Get
        End Property
        Public ReadOnly Property CN_PLN_CODE As String
            Get
                Return Values(FieldList.CN_PLN_CODE)
            End Get
        End Property
        Public ReadOnly Property CN_PRD_DESC As String
            Get
                Return Values(FieldList.CN_PRD_DESC)
            End Get
        End Property
        Public ReadOnly Property CN_PLN_TYPE As String
            Get
                Return Values(FieldList.CN_PLN_TYPE)
            End Get
        End Property
        Public ReadOnly Property CN_QUAL_DESC As String
            Get
                Return Values(FieldList.CN_QUAL_DESC)
            End Get
        End Property
        Public ReadOnly Property CN_TAX_CATEG_DESC As String
            Get
                Return Values(FieldList.CN_TAX_CATEG_DESC)
            End Get
        End Property
        Public ReadOnly Property CN_STATUS As String
            Get
                Return Values(FieldList.CN_STATUS)
            End Get
        End Property
        Public ReadOnly Property CN_ISSUE_DATE As Date
            Get
                Return CDate(Values(FieldList.CN_ISSUE_DATE))
            End Get
        End Property
        Public ReadOnly Property CN_ISSUE_STATE As String
            Get
                Return Values(FieldList.CN_ISSUE_STATE)
            End Get
        End Property
        Public ReadOnly Property CN_PREM As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.CN_PREM))
            End Get
        End Property
        Public ReadOnly Property CN_PREM_MODE As String
            Get
                Return Values(FieldList.CN_PREM_MODE)
            End Get
        End Property
        Public ReadOnly Property CN_DB_DESC As String
            Get
                Return Values(FieldList.CN_DB_DESC)
            End Get
        End Property
        Public ReadOnly Property CN_BASIS_POINT_TOTAL As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.CN_BASIS_POINT_TOTAL))
            End Get
        End Property
        Public ReadOnly Property EX_EXCHANGE_TYPE As Integer
            Get
                Return Convert.ToInt32(Values(FieldList.EX_EXCHANGE_TYPE))
            End Get
        End Property
        Public ReadOnly Property CN_PAYOUT_OPT As String
            Get
                Return Values(FieldList.CN_PAYOUT_OPT)
            End Get
        End Property
        Public ReadOnly Property CN_MAT_DATE As Date
            Get
                Return CDate(Values(FieldList.CN_MAT_DATE))
            End Get
        End Property
        Public ReadOnly Property PA_FIXED_PAY_AMT As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.PA_FIXED_PAY_AMT))
            End Get
        End Property
        Public ReadOnly Property PA_VAR_PAY_AMT As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.PA_VAR_PAY_AMT))
            End Get
        End Property
        Public ReadOnly Property PA_PAY_MODE As String
            Get
                Return Values(FieldList.PA_PAY_MODE)
            End Get
        End Property
        Public ReadOnly Property PA_GNTY_PERD As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.PA_GNTY_PERD))
            End Get
        End Property
        Public ReadOnly Property CN_FIRST_PAYOUT_PMT_DATE As Date
            Get
                Return CDate(Values(FieldList.CN_FIRST_PAYOUT_PMT_DATE))
            End Get
        End Property
        Public ReadOnly Property CN_PAYOUT_STOP_DATE As Date
            Get
                Return CDate(Values(FieldList.CN_PAYOUT_STOP_DATE))
            End Get
        End Property
        Public ReadOnly Property CN_FIXED_PAY_AMT As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.CN_FIXED_PAY_AMT))
            End Get
        End Property
        Public ReadOnly Property CN_VAR_PAY_AMT As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.CN_VAR_PAY_AMT))
            End Get
        End Property
        Public ReadOnly Property CN_MIN_GUAR_RATE As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.CN_MIN_GUAR_RATE))
            End Get
        End Property
        Public ReadOnly Property CN_GNTY_PERD As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.CN_GNTY_PERD))
            End Get
        End Property
        Public ReadOnly Property CN_PRIM_RT_CLASS As String
            Get
                Return Values(FieldList.CN_PRIM_RT_CLASS)
            End Get
        End Property
        Public ReadOnly Property CN_JT_RT_CLASS As String
            Get
                Return Values(FieldList.CN_JT_RT_CLASS)
            End Get
        End Property
        Public ReadOnly Property CN_PRIM_FLATEX As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.CN_PRIM_FLATEX))
            End Get
        End Property
        Public ReadOnly Property CN_JT_FLATEX As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.CN_JT_FLATEX))
            End Get
        End Property
        Public ReadOnly Property YEAR1_RATE As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.YEAR1_RATE))
            End Get
        End Property
        Public ReadOnly Property YEAR2_RATE As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.YEAR2_RATE))
            End Get
        End Property
        Public ReadOnly Property MVA_INDEX_RATE As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.MVA_INDEX_RATE))
            End Get
        End Property
        Public ReadOnly Property MVA_INDEX_VAL As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.MVA_INDEX_VAL))
            End Get
        End Property
        Public ReadOnly Property UDV1 As String
            Get
                Return Values(FieldList.UDV1)
            End Get
        End Property
        Public ReadOnly Property NEXT_ANNIV_DATE As Date
            Get
                Dim v As String = Values(FieldList.NEXT_ANNIV_DATE)
                Return CDate(Values(FieldList.NEXT_ANNIV_DATE))
            End Get
        End Property
        Public ReadOnly Property BAIL_WIND As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.BAIL_WIND))
            End Get
        End Property
        Public ReadOnly Property SURR_PERIOD As String
            Get
                Return Values(FieldList.SURR_PERIOD)
            End Get
        End Property
        Public ReadOnly Property FIXED_RATE_BAND1 As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.FIXED_RATE_BAND1))
            End Get
        End Property
        Public ReadOnly Property FIXED_RATE_BAND2 As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.FIXED_RATE_BAND2))
            End Get
        End Property
        Public ReadOnly Property FIXED_RATE_BAND3 As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.FIXED_RATE_BAND3))
            End Get
        End Property
        Public ReadOnly Property CAP_RATE_BAND1 As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.CAP_RATE_BAND1))
            End Get
        End Property
        Public ReadOnly Property CAP_RATE_BAND2 As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.CAP_RATE_BAND2))
            End Get
        End Property
        Public ReadOnly Property CAP_RATE_BAND3 As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.CAP_RATE_BAND3))
            End Get
        End Property
        Public ReadOnly Property MARGIN_RATE_BAND1 As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.MARGIN_RATE_BAND1))
            End Get
        End Property
        Public ReadOnly Property MARGIN_RATE_BAND2 As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.MARGIN_RATE_BAND2))
            End Get
        End Property
        Public ReadOnly Property MARGIN_RATE_BAND3 As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.MARGIN_RATE_BAND3))
            End Get
        End Property
        Public ReadOnly Property MAT_AGE As String
            Get
                Return Values(FieldList.MAT_AGE)
            End Get
        End Property
        Public ReadOnly Property ANN_OPTION As String
            Get
                Return Values(FieldList.ANN_OPTION)
            End Get
        End Property


        ''LGP-16536 
        Public ReadOnly Property PREM_BONUS_PERC As String
            Get
                Return Values(FieldList.PREM_BONUS_PERC)
            End Get
        End Property

        Public ReadOnly Property RIDER_FEE_PERC As String
            Get
                Return Values(FieldList.RIDER_FEE_PERC)
            End Get
        End Property

        Public ReadOnly Property PAY_INCR_PERC As String
            Get
                Return Values(FieldList.PAY_INCR_PERC)
            End Get
        End Property
        Public ReadOnly Property LEVEL_PAYOUT_FACTOR As String
            Get
                Return Values(FieldList.LEVEL_PAYOUT_FACTOR)
            End Get
        End Property
        Public ReadOnly Property INCREASING_PAYOUT_FACTOR As String
            Get
                Return Values(FieldList.INCREASING_PAYOUT_FACTOR)
            End Get
        End Property
        Public ReadOnly Property GLWB_WAIT_PERIOD As String
            Get
                Return Values(FieldList.GLWB_WAIT_PERIOD)
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

#Region " Values "
    Public Class VALUES
        Inherits SourceDef

#Region " Field Arry Enum "
        Public Shadows Enum FieldList
            REC_TYPE

        End Enum

#End Region

#Region " Properties "
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
#Region " Value "
    Public Class VALUE
        Inherits SourceDef

#Region " Field Arry Enum "
        Public Shadows Enum FieldList
            REC_TYPE
            CONT
            PLN_CODE
            ACC_CODE
            DIV_CODE
            FUND_CODE
            FUND_CODE_DESC
            DIV_NAME
            ACCT_TYPE
            INIT_PREM
            VALUE
            UNITS
            UNIT_VALUE
            BASIS_POINT
            RATE
            RATE_GNTY_PERIOD
            RENEW_DATE
            BONUS_AMT
            BEG_INDEX_VAL
            CAP_RATE
            PART_RATE
            INDEX_SPREAD
            FUND_TOTAL  'not yet confirm
            'LC_ACC_CODE ' Based on the confirmation, we will use this
            BAIL_RATE
            PERF_TRIG_RATE

        End Enum

#End Region

#Region " Properties "
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
        Public ReadOnly Property PLN_CODE As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.PLN_CODE))
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
        Public ReadOnly Property FUND_CODE As String
            Get
                Return Values(FieldList.FUND_CODE)
            End Get
        End Property
        Public ReadOnly Property FUND_CODE_DESC As String
            Get
                Return Values(FieldList.FUND_CODE_DESC)
            End Get
        End Property
        Public ReadOnly Property DIV_NAME As String
            Get
                Return Values(FieldList.DIV_NAME)
            End Get
        End Property
        Public ReadOnly Property ACCT_TYPE As String
            Get
                Return Values(FieldList.ACCT_TYPE)
            End Get
        End Property
        Public ReadOnly Property INIT_PREM As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.INIT_PREM))
            End Get
        End Property
        Public ReadOnly Property VALUE As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.VALUE))
            End Get
        End Property
        Public ReadOnly Property UNITS As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.UNITS))
            End Get
        End Property
        Public ReadOnly Property UNIT_VALUE As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.UNIT_VALUE))
            End Get
        End Property
        Public ReadOnly Property BASIS_POINT As String
            Get
                Return Values(FieldList.BASIS_POINT)
            End Get
        End Property
        Public ReadOnly Property RATE As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.RATE))
            End Get
        End Property
        Public ReadOnly Property RATE_GNTY_PERIOD As Int32
            Get
                Return Convert.ToInt32(Values(FieldList.RATE_GNTY_PERIOD))
            End Get
        End Property
        Public ReadOnly Property RENEW_DATE As String
            Get
                Return Values(FieldList.RENEW_DATE)
            End Get
        End Property
        Public ReadOnly Property BONUS_AMT As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.BONUS_AMT))
            End Get
        End Property
        Public ReadOnly Property BEG_INDEX_VAL As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.BEG_INDEX_VAL))
            End Get
        End Property
        Public ReadOnly Property CAP_RATE As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.CAP_RATE))
            End Get
        End Property
        Public ReadOnly Property PART_RATE As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.PART_RATE))
            End Get
        End Property
        Public ReadOnly Property INDEX_SPREAD As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.INDEX_SPREAD))
            End Get
        End Property
        Public ReadOnly Property BAIL_RATE As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.BAIL_RATE))
            End Get
        End Property
        Public ReadOnly Property PERF_TRIG_RATE As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.PERF_TRIG_RATE))
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

#Region " Roles "
    Public Class ROLES
        Inherits SourceDef

#Region " Field Array Enum "
        Public Shadows Enum FieldList
            REC_TYPE
        End Enum
#End Region

#Region " Properties "
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
    Public Class ROLE
        Inherits SourceDef

#Region " Field Array Enum "
        Public Shadows Enum FieldList
            REC_TYPE
            CONT
            PLN_CODE
            ROLE_ID
            OPT_ID
            ROLE_DESC
            OPT_DESC
            NAME_ID
            ADDRESS_ID
            SEASONAL_IND
            PERCENT_SPLIT
            NAME_TYPE
            FST
            LST
            MID
            'SUFFIX
            TAX_ID
            DOB
            SEX
            SALUTE
            RELATIONSHIP_ID
            RELATIONSHIP
            EXT_ID
            EMAIL
            ISSUE_AGE
            MAIL_FLAG_POLPGS
            MAIL_TO
        End Enum
#End Region

#Region " Properties "
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
        Public ReadOnly Property PLN_CODE As Int32
            Get
                Return Convert.ToInt32(Values(FieldList.PLN_CODE))
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
        Public ReadOnly Property ROLE_DESC As String
            Get
                Return Values(FieldList.ROLE_DESC)
            End Get
        End Property
        Public ReadOnly Property OPT_DESC As String
            Get
                Return Values(FieldList.OPT_DESC)
            End Get
        End Property
        Public ReadOnly Property NAME_ID As Int32
            Get
                Return Convert.ToInt32(Values(FieldList.NAME_ID))
            End Get
        End Property

        Public ReadOnly Property ADDRESS_ID As Int32
            Get
                Return Convert.ToInt32(Values(FieldList.ADDRESS_ID))
            End Get
        End Property
        Public ReadOnly Property SEASONAL_IND As String
            Get
                Return Values(FieldList.SEASONAL_IND)
            End Get
        End Property
        Public ReadOnly Property PERCENT_SPLIT As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.PERCENT_SPLIT))
            End Get
        End Property
        Public ReadOnly Property NAME_TYPE As String
            Get
                Return Values(FieldList.NAME_TYPE)
            End Get
        End Property
        Public ReadOnly Property FST As String
            Get
                Return Values(FieldList.FST)
            End Get
        End Property
        Public ReadOnly Property LST As String
            Get
                Return Values(FieldList.LST)
            End Get
        End Property
        Public ReadOnly Property MID As String
            Get
                Return Values(FieldList.MID)
            End Get
        End Property
        'Public ReadOnly Property SUFFIX As String
        '    Get
        '        Return Values(FieldList.SUFFIX)
        '    End Get
        'End Property
        Public ReadOnly Property TAX_ID As String
            Get
                Return Values(FieldList.TAX_ID)
            End Get
        End Property
        Public ReadOnly Property DOB As Date
            Get
                Return CDate(Values(FieldList.DOB))
            End Get
        End Property
        Public ReadOnly Property SEX As String
            Get
                Return Values(FieldList.SEX)
            End Get
        End Property
        Public ReadOnly Property SALUTE As String
            Get
                Return Values(FieldList.SALUTE)
            End Get
        End Property
        Public ReadOnly Property RELATIONSHIP_ID As String
            Get
                Return Values(FieldList.RELATIONSHIP_ID)
            End Get
        End Property
        Public ReadOnly Property RELATIONSHIP As String
            Get
                Return Values(FieldList.RELATIONSHIP)
            End Get
        End Property
        Public ReadOnly Property EXT_ID As String
            Get
                Return Values(FieldList.EXT_ID)
            End Get
        End Property
        Public ReadOnly Property EMAIL As String
            Get
                Return Values(FieldList.EMAIL)
            End Get
        End Property
        Public ReadOnly Property ISSUE_AGE As Int32
            Get
                Return Convert.ToInt32(Values(FieldList.ISSUE_AGE))
            End Get
        End Property
        Public ReadOnly Property MAIL_FLAG_POLPGS As String
            Get
                Return Values(FieldList.MAIL_FLAG_POLPGS)
            End Get
        End Property
        Public ReadOnly Property MAIL_TO As String
            Get
                Return Values(FieldList.MAIL_TO)
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

#Region " Phones "
    Public Class PHONES
        Inherits SourceDef

#Region " Field Array Enum"
        Public Shadows Enum FieldList
            REC_TYPE

        End Enum
#End Region

#Region " Properties "
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
#Region " Phone "
    Public Class PHONE
        Inherits SourceDef

#Region " Field Array Enum"
        Public Shadows Enum FieldList
            REC_TYPE
            CONT
            PHONE_ID
            NAME_ID
            'ROLE_DESC
            ROLE_ID
            OPT_ID
            PHONE_TYPE
            PH_CTRY_CODE
            AREA_CODE
            EXC
            PH_SUFFIX
            EXT
        End Enum
#End Region

#Region " Properties "
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
        Public ReadOnly Property PHONE_ID As Int32
            Get
                Return Convert.ToInt32(Values(FieldList.PHONE_ID))
            End Get
        End Property
        Public ReadOnly Property NAME_ID As Int32
            Get
                Return Convert.ToInt32(Values(FieldList.NAME_ID))
            End Get
        End Property
        'Public ReadOnly Property ROLE_DESC As String
        '    Get
        '        Return Values(FieldList.ROLE_DESC)
        '    End Get
        'End Property
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
#End Region

#Region " Constructors "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class
#End Region

#Region " Addresses "
    Public Class ADDRESSES
        Inherits SourceDef

#Region " Field Array Enum "
        Public Shadows Enum FieldList
            REC_TYPE

        End Enum
#End Region

#Region " Properties "
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
#Region " Address "
    Public Class ADDRESS
        Inherits SourceDef

#Region " Field Array Enum "
        Public Shadows Enum FieldList
            REC_TYPE
            CONT
            ADDRESS_ID
            NAME_ID
            ROLE_ID
            OPT_ID
            ADDRESS_TYPE
            ADDRESS1
            ADDRESS2
            ADDRESS3
            CITY
            STATE_CODE
            ZIP
            ZIP_SUFFIX
            CTRY_CODE
        End Enum
#End Region

#Region " Properties "
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
        Public ReadOnly Property ADDRESS_ID As Int32
            Get
                Return Convert.ToInt32(Values(FieldList.ADDRESS_ID))
            End Get
        End Property
        Public ReadOnly Property NAME_ID As Int32
            Get
                Return Convert.ToInt32(Values(FieldList.NAME_ID))
            End Get
        End Property
        'Public ReadOnly Property ROLE_DESC As String
        '    Get
        '        Return Values(FieldList.ROLE_DESC)
        '    End Get
        'End Property
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
        Public ReadOnly Property ADDRESS_TYPE As String
            Get
                Return Values(FieldList.ADDRESS_TYPE)
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
#End Region

#Region " Constructors "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class
#End Region

#Region " Features "
    Public Class FEATURES
        Inherits SourceDef

#Region " Field Array Enum"
        Public Shadows Enum FieldList
            REC_TYPE

        End Enum
#End Region

#Region " Properties "
        Public ReadOnly Property REC_TYPE As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property




#End Region

#Region " Constructors "

#End Region

    End Class
#End Region
#Region " Feature "
    Public Class FEATURE
        Inherits SourceDef

#Region " Field Array Enum"
        Public Shadows Enum FieldList
            REC_TYPE
            CONT
            SPEC_CODE
            SPEC_CODE_DESC
            VARIATION_GROUP_ID
            VARIATION_GROUP_DESC
            BASIS_POINT_CHARGE
            RIDER_FEE
            SPEC_DESC
            SPEC_ID
        End Enum
#End Region

#Region " Properties "
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
        Public ReadOnly Property BASIS_POINT_CHARGE As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.BASIS_POINT_CHARGE))
            End Get
        End Property
        Public ReadOnly Property RIDER_FEE As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.RIDER_FEE))
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

#Region " Constructors "

#End Region

    End Class
#End Region

#Region " LTYINCOMERATES "
    Public Class LTYINCOMERATES
        Inherits SourceDef

#Region " Field Array Enum"
        Public Shadows Enum FieldList
            REC_TYPE

        End Enum
#End Region

#Region " Properties "
        Public ReadOnly Property REC_TYPE As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property




#End Region

#Region " Constructors "

#End Region

    End Class
#End Region
#Region " LTYINCOMERATE "
    Public Class LTYINCOMERATE
        Inherits SourceDef

#Region " Field Array Enum"
        Public Shadows Enum FieldList
            REC_TYPE
            CONT
            SPEC_CODE
            SPEC_CODE_DESC
            VARIATION_GROUP_ID
            VARIATION_GROUP_DESC
            BASIS_POINT_CHARGE
            RIDER_FEE
            SPEC_DESC
            SPEC_ID
        End Enum
#End Region

#Region " Properties "
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
        Public ReadOnly Property BASIS_POINT_CHARGE As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.BASIS_POINT_CHARGE))
            End Get
        End Property
        Public ReadOnly Property RIDER_FEE As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.RIDER_FEE))
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

#Region " Constructors "

#End Region

    End Class
#End Region

End Namespace
