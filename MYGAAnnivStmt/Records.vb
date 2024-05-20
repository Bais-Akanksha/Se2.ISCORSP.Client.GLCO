Imports Se2.ISI.Base.Presentation

Namespace Se2.ISCORSP.Client.GLCO.MYGAAnnivStmt.Records


#Region " MYGAAnnivStmt "

#Region " HDR "
    Public Class HDR
        Inherits RecordDef

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New(PresentationFormat.Delimited)
            Length = -999
            Terminator = vbCrLf
            Type = RecordType.HDR
            Initialize()
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("XMLEncoding", "", FieldType.String, "", "S:<?xml version=""1.0"" encoding=""utf-8""?>"))
        End Sub

#End Region

    End Class
#End Region

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

#Region " Policies "

    <Serializable()>
    Public Class Policies
        Inherits DTL

#Region " Constructors "

        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "Policies"
            Me.NodeParent = "DataServicesLetter"
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
#Region " Policy "
    Public Class Policy
        Inherits DTL

        Private Shadows Enum FieldList
            POL_CONT
            POL_PLAN_CODE
            POL_PRODUCT
            POL_QUAL_DESC
            POL_COMP_NAME
            POL_CYCLE_DATE
            POL_SERVICE_NAME
            POL_SERVICE_DESC
            POL_SOURCE
            POL_STATUS
            POL_POL_NUM
            POL_PRDCT_COMP
            POL_LOB
            POL_PRCSG_COMP
            POL_TRACKING_ID
            POL_PRDCT_MKTG_NAME
            POL_ISSUE_DATE
            POL_CORRO_PRDCT_NAME

        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "Policy"
            Me.NodeParent = "Policies"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("POL_CONT", "CONT"))
                .Add(New FieldDef("POL_PLAN_CODE", "PLN_CODE"))
                .Add(New FieldDef("POL_PRODUCT", "PRD_DESC"))
                .Add(New FieldDef("POL_QUAL_DESC", "QUAL_DESC"))
                .Add(New FieldDef("POL_COMP_NAME", "CO_NAME"))
                .Add(New FieldDef("POL_CYCLE_DATE", "", FieldType.Date, "yyyy-MM-dd", "CYCLEDATE"))
                .Add(New FieldDef("POL_SERVICE_NAME", "S:Statement"))
                .Add(New FieldDef("POL_SERVICE_DESC", "S:MYGA Anniversary Statement"))
                .Add(New FieldDef("POL_SOURCE", "S:SE2"))
                .Add(New FieldDef("POL_STATUS", "F:ACCOUNT_STATUS"))
                .Add(New FieldDef("POL_POL_NUM", "POL_NUM"))
                .Add(New FieldDef("POL_PRDCT_COMP", "PRODUCT_CO"))
                .Add(New FieldDef("POL_LOB", "F:LINE_OF_BUSINESS"))
                .Add(New FieldDef("POL_PRCSG_COMP", "PRCSSNG_CO"))
                .Add(New FieldDef("POL_TRACKING_ID", "F:TrackingID"))
                .Add(New FieldDef("POL_PRDCT_MKTG_NAME", "MKT_PRDCT_NAME"))
                .Add(New FieldDef("POL_ISSUE_DATE", "", FieldType.Date, "yyyy-MM-dd", "ISSUE_DATE"))
                .Add(New FieldDef("POL_CORRO_PRDCT_NAME", "F:CORRO_PRDCT_NAME"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property POL_CONT As FieldDef
            Get
                Return Fields(FieldList.POL_CONT)
            End Get
        End Property
        Public ReadOnly Property POL_PLAN_CODE As FieldDef
            Get
                Return Fields(FieldList.POL_PLAN_CODE)
            End Get
        End Property
        Public ReadOnly Property POL_PRODUCT As FieldDef
            Get
                Return Fields(FieldList.POL_PRODUCT)
            End Get
        End Property
        Public ReadOnly Property POL_QUAL_DESC As FieldDef
            Get
                Return Fields(FieldList.POL_QUAL_DESC)
            End Get
        End Property
        Public ReadOnly Property POL_COMP_NAME As FieldDef
            Get
                Return Fields(FieldList.POL_COMP_NAME)
            End Get
        End Property
        Public ReadOnly Property POL_CYCLE_DATE As FieldDef
            Get
                Return Fields(FieldList.POL_CYCLE_DATE)
            End Get
        End Property
        Public ReadOnly Property POL_SERVICE_NAME As FieldDef
            Get
                Return Fields(FieldList.POL_SERVICE_NAME)
            End Get
        End Property
        Public ReadOnly Property POL_SERVICE_DESC As FieldDef
            Get
                Return Fields(FieldList.POL_SERVICE_DESC)
            End Get
        End Property
        Public ReadOnly Property POL_SOURCE As FieldDef
            Get
                Return Fields(FieldList.POL_SOURCE)
            End Get
        End Property
        Public ReadOnly Property POL_STATUS As FieldDef
            Get
                Return Fields(FieldList.POL_STATUS)
            End Get
        End Property
        Public ReadOnly Property POL_POL_NUM As FieldDef
            Get
                Return Fields(FieldList.POL_POL_NUM)
            End Get
        End Property
        Public ReadOnly Property POL_PRDCT_COMP As FieldDef
            Get
                Return Fields(FieldList.POL_PRDCT_COMP)
            End Get
        End Property
        Public ReadOnly Property POL_LOB As FieldDef
            Get
                Return Fields(FieldList.POL_LOB)
            End Get
        End Property
        Public ReadOnly Property POL_PRCSG_COMP As FieldDef
            Get
                Return Fields(FieldList.POL_PRCSG_COMP)
            End Get
        End Property
        Public ReadOnly Property POL_TRACKING_ID As FieldDef
            Get
                Return Fields(FieldList.POL_TRACKING_ID)
            End Get
        End Property
        Public ReadOnly Property POL_PRDCT_MKTG_NAME As FieldDef
            Get
                Return Fields(FieldList.POL_PRDCT_MKTG_NAME)
            End Get
        End Property
        Public ReadOnly Property POL_ISSUE_DATE As FieldDef
            Get
                Return Fields(FieldList.POL_ISSUE_DATE)
            End Get
        End Property
        Public ReadOnly Property POL_CORRO_PRDCT_NAME As FieldDef
            Get
                Return Fields(FieldList.POL_CORRO_PRDCT_NAME)
            End Get
        End Property
#End Region

#Region " METHODS "

#End Region
    End Class


#End Region

#Region " Roles "

    <Serializable()>
    Public Class Roles
        Inherits DTL

#Region " Constructors "

        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "Roles"
            Me.NodeParent = "Policy"
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
#Region " Role "

    Public Class ROLE
        Inherits DTL

        Private Shadows Enum FieldList
            ROL_CONT
            ROL_CODE
            ROL_PCT
            ROL_FULL_NAME
            ROL_PREFIX
            ROL_FST_NAME
            ROL_MI
            ROL_LST_NAME
            ROL_SUFFIX
            ROL_NAME_TYPE
            ADDR_LINE1
            ADDR_LINE2
            ADDR_LINE3
            ADDR_CITY
            ADDR_STATE
            ADDR_ZIP
            ADDR_TYPE
            ROL_EMAIL
            ROL_PHONE_NUM
            ROL_PHONE_TYPE
            ROL_EXTERNAL_ID
            ROL_MASTER_NUM
            ROL_TAX_ID
            ROL_DELIVERY_FLAG
            ROL_DELIVERY_DESC
            ROL_ROLE_ID

        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "Role"
            Me.NodeParent = "Roles"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("ROL_CONT", "CONT"))
                .Add(New FieldDef("ROL_CODE", "F:ROLE_DESC"))
                .Add(New FieldDef("ROL_PCT", "F:ROLE_PERCENT_SPLIT"))
                .Add(New FieldDef("ROL_FULL_NAME", "F:CUST_FULL_NAME"))
                .Add(New FieldDef("ROL_PREFIX", "SALUTE"))
                .Add(New FieldDef("ROL_FST_NAME", "FST"))
                .Add(New FieldDef("ROL_MI", "MID"))
                .Add(New FieldDef("ROL_LST_NAME", "LST"))
                .Add(New FieldDef("ROL_SUFFIX", "SUFFIX"))
                .Add(New FieldDef("ROL_NAME_TYPE", "F:NAME_TYPE"))
                .Add(New FieldDef("ADDR_LINE1", "ADDRESS1"))
                .Add(New FieldDef("ADDR_LINE2", "ADDRESS2"))
                .Add(New FieldDef("ADDR_LINE3", "ADDRESS3"))
                .Add(New FieldDef("ADDR_CITY", "CITY"))
                .Add(New FieldDef("ADDR_STATE", "STATE_CODE"))
                .Add(New FieldDef("ADDR_ZIP", "F:FULL_ZIP_CODE"))
                .Add(New FieldDef("ADDR_TYPE", "F:ADDRESS_TYPE"))
                .Add(New FieldDef("ROL_EMAIL", "F:GetEmailAddress"))
                .Add(New FieldDef("ROL_PHONE_NUM", "F:PHONE_NUMBER"))
                .Add(New FieldDef("ROL_PHONE_TYPE", "F:PHONE_TYPE"))
                .Add(New FieldDef("ROL_EXTERNAL_ID", "EXT_ID"))
                .Add(New FieldDef("ROL_MASTER_NUM", "MASTER_NUMBER"))
                .Add(New FieldDef("ROL_TAX_ID", "TAX_ID"))
                .Add(New FieldDef("ROL_DELIVERY_FLAG", "F:MAIL_FLAG"))
                .Add(New FieldDef("ROL_DELIVERY_DESC", "F:MAIL_TYPE_IND"))
                .Add(New FieldDef("ROL_ROLE_ID", "ROLE_ID"))

            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property ROL_CONT As FieldDef
            Get
                Return Fields(FieldList.ROL_CONT)
            End Get
        End Property
        Public ReadOnly Property ROL_CODE As FieldDef
            Get
                Return Fields(FieldList.ROL_CODE)
            End Get
        End Property
        Public ReadOnly Property ROL_PCT As FieldDef
            Get
                Return Fields(FieldList.ROL_PCT)
            End Get
        End Property
        Public ReadOnly Property ROL_FULL_NAME As FieldDef
            Get
                Return Fields(FieldList.ROL_FULL_NAME)
            End Get
        End Property
        Public ReadOnly Property ROL_PREFIX As FieldDef
            Get
                Return Fields(FieldList.ROL_PREFIX)
            End Get
        End Property
        Public ReadOnly Property ROL_FST_NAME As FieldDef
            Get
                Return Fields(FieldList.ROL_FST_NAME)
            End Get
        End Property
        Public ReadOnly Property ROL_MI As FieldDef
            Get
                Return Fields(FieldList.ROL_MI)
            End Get
        End Property
        Public ReadOnly Property ROL_LST_NAME As FieldDef
            Get
                Return Fields(FieldList.ROL_LST_NAME)
            End Get
        End Property
        Public ReadOnly Property ROL_SUFFIX As FieldDef
            Get
                Return Fields(FieldList.ROL_SUFFIX)
            End Get
        End Property
        Public ReadOnly Property ROL_NAME_TYPE As FieldDef
            Get
                Return Fields(FieldList.ROL_NAME_TYPE)
            End Get
        End Property
        Public ReadOnly Property ADDR_LINE1 As FieldDef
            Get
                Return Fields(FieldList.ADDR_LINE1)
            End Get
        End Property
        Public ReadOnly Property ADDR_LINE2 As FieldDef
            Get
                Return Fields(FieldList.ADDR_LINE2)
            End Get
        End Property
        Public ReadOnly Property ADDR_LINE3 As FieldDef
            Get
                Return Fields(FieldList.ADDR_LINE3)
            End Get
        End Property
        Public ReadOnly Property ADDR_CITY As FieldDef
            Get
                Return Fields(FieldList.ADDR_CITY)
            End Get
        End Property
        Public ReadOnly Property ADDR_STATE As FieldDef
            Get
                Return Fields(FieldList.ADDR_STATE)
            End Get
        End Property
        Public ReadOnly Property ADDR_ZIP As FieldDef
            Get
                Return Fields(FieldList.ADDR_ZIP)
            End Get
        End Property
        Public ReadOnly Property ADDR_TYPE As FieldDef
            Get
                Return Fields(FieldList.ADDR_TYPE)
            End Get
        End Property
        Public ReadOnly Property ROL_EMAIL As FieldDef
            Get
                Return Fields(FieldList.ROL_EMAIL)
            End Get
        End Property
        Public ReadOnly Property ROL_PHONE_NUM As FieldDef
            Get
                Return Fields(FieldList.ROL_PHONE_NUM)
            End Get
        End Property
        Public ReadOnly Property ROL_PHONE_TYPE As FieldDef
            Get
                Return Fields(FieldList.ROL_PHONE_TYPE)
            End Get
        End Property
        Public ReadOnly Property ROL_EXTERNAL_ID As FieldDef
            Get
                Return Fields(FieldList.ROL_EXTERNAL_ID)
            End Get
        End Property
        Public ReadOnly Property ROL_MASTER_NUM As FieldDef
            Get
                Return Fields(FieldList.ROL_MASTER_NUM)
            End Get
        End Property
        Public ReadOnly Property ROL_TAX_ID As FieldDef
            Get
                Return Fields(FieldList.ROL_TAX_ID)
            End Get
        End Property
        Public ReadOnly Property ROL_DELIVERY_FLAG As FieldDef
            Get
                Return Fields(FieldList.ROL_DELIVERY_FLAG)
            End Get
        End Property
        Public ReadOnly Property ROL_DELIVERY_DESC As FieldDef
            Get
                Return Fields(FieldList.ROL_DELIVERY_DESC)
            End Get
        End Property
        Public ReadOnly Property ROL_ROLE_ID As FieldDef
            Get
                Return Fields(FieldList.ROL_ROLE_ID)
            End Get
        End Property
#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " Carrier Information "
    <Serializable()>
    Public Class CarrierInformation
        Inherits DTL

#Region " Constructors "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "CarrierInformation"
            Me.NodeParent = "Policy"
        End Sub

        Private Shadows Enum FieldList
            REC_TYPE

        End Enum

        Private Sub Initialize()

        End Sub

#End Region

#Region " Properties "


#End Region

#Region "Methods"

#End Region

    End Class


#End Region
#Region " Carrier "

    Public Class Carrier
        Inherits DTL

        Private Shadows Enum FieldList
            CARRIER_CONT
            CARRIER_NAME
            CARRIER_ADDR_LINE1
            CARRIER_ADDR_LINE2
            CARRIER_ADDR_LINE3
            CARRIER_CITY
            CARRIER_STATE
            CARRIER_ZIP
            CARRIER_WEB_ADDR
            CARRIER_PHONE_NUM
            CARRIER_FAX_NUM
            CARRIER_OFFICE_HOURS
            CARRIER_OFFICE_DAYS
            CARRIER_BUDGET_CNTR
            CARRIER_POB_ADDR_LINE1
            CARRIER_POB_ADDR_LINE2
            CARRIER_POB_ADDR_LINE3
            CARRIER_POB_CITY
            CARRIER_POB_STATE
            CARRIER_POB_ZIP
            CARRIER_MAIL_ADDR_LINE1
            CARRIER_MAIL_ADDR_LINE2
            CARRIER_MAIL_ADDR_LINE3
            CARRIER_MAIL_CITY
            CARRIER_MAIL_STATE
            CARRIER_MAIL_ZIP
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "Carrier"
            Me.NodeParent = "CarrierInformation"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("CARRIER_CONT", "CONT"))
                .Add(New FieldDef("CARRIER_CARRIER_NAME", "CO_NAME"))
                .Add(New FieldDef("CARRIER_ADDR_LINE1", "ADDR_LINE_1"))
                .Add(New FieldDef("CARRIER_ADDR_LINE2", "ADDR_LINE_2"))
                .Add(New FieldDef("CARRIER_ADDR_LINE3", "ADDR_LINE_3"))
                .Add(New FieldDef("CARRIER_CITY", "CITY"))
                .Add(New FieldDef("CARRIER_STATE", "STATE"))
                .Add(New FieldDef("CARRIER_ZIP", "ZIP_CODE"))
                .Add(New FieldDef("CARRIER_WEB_ADDR", "WEB_ADDRESS"))
                .Add(New FieldDef("CARRIER_PHONE_NUM", "F:CARRIER_PHONE_NUM"))
                .Add(New FieldDef("CARRIER_FAX_NUM", "F:CARRIER_FAX_NUM"))
                .Add(New FieldDef("CARRIER_OFFICE_HOURS", "OFFICE_HOURS"))
                .Add(New FieldDef("CARRIER_OFFICE_DAYS", "OFFICE_DAYS"))
                .Add(New FieldDef("CARRIER_BUDGET_CNTR", "BUDGET_CENTER"))
                .Add(New FieldDef("CARRIER_POB_ADDR_LINE1", "POB_LINE_1"))
                .Add(New FieldDef("CARRIER_POB_ADDR_LINE2", "POB_LINE_2"))
                .Add(New FieldDef("CARRIER_POB_ADDR_LINE3", "POB_LINE_3"))
                .Add(New FieldDef("CARRIER_POB_CITY", "POB_CITY"))
                .Add(New FieldDef("CARRIER_POB_STATE", "POB_STATE"))
                .Add(New FieldDef("CARRIER_POB_ZIP", "POB_ZIP_CODE"))
                .Add(New FieldDef("CARRIER_MAIL_ADDR_LINE1", "MAIL_LINE_1"))
                .Add(New FieldDef("CARRIER_MAIL_ADDR_LINE2", "MAIL_LINE_2"))
                .Add(New FieldDef("CARRIER_MAIL_ADDR_LINE3", "MAIL_LINE_3"))
                .Add(New FieldDef("CARRIER_MAIL_CITY", "MAIL_CITY"))
                .Add(New FieldDef("CARRIER_MAIL_STATE", "MAIL_STATE"))
                .Add(New FieldDef("CARRIER_MAIL_ZIP", "MAIL_ZIP_CODE"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property CARRIER_CONT As FieldDef
            Get
                Return Fields(FieldList.CARRIER_CONT)
            End Get
        End Property
        Public ReadOnly Property CARRIER_CARRIER_NAME As FieldDef
            Get
                Return Fields(FieldList.CARRIER_NAME)
            End Get
        End Property
        Public ReadOnly Property CARRIER_ADDR_LINE1 As FieldDef
            Get
                Return Fields(FieldList.CARRIER_ADDR_LINE1)
            End Get
        End Property
        Public ReadOnly Property CARRIER_ADDR_LINE2 As FieldDef
            Get
                Return Fields(FieldList.CARRIER_ADDR_LINE2)
            End Get
        End Property
        Public ReadOnly Property CARRIER_ADDR_LINE3 As FieldDef
            Get
                Return Fields(FieldList.CARRIER_ADDR_LINE3)
            End Get
        End Property
        Public ReadOnly Property CARRIER_CITY As FieldDef
            Get
                Return Fields(FieldList.CARRIER_CITY)
            End Get
        End Property
        Public ReadOnly Property CARRIER_STATE As FieldDef
            Get
                Return Fields(FieldList.CARRIER_STATE)
            End Get
        End Property
        Public ReadOnly Property CARRIER_ZIP As FieldDef
            Get
                Return Fields(FieldList.CARRIER_ZIP)
            End Get
        End Property
        Public ReadOnly Property CARRIER_WEB_ADDR As FieldDef
            Get
                Return Fields(FieldList.CARRIER_WEB_ADDR)
            End Get
        End Property
        Public ReadOnly Property CARRIER_PHONE_NUM As FieldDef
            Get
                Return Fields(FieldList.CARRIER_PHONE_NUM)
            End Get
        End Property
        Public ReadOnly Property CARRIER_FAX_NUM As FieldDef
            Get
                Return Fields(FieldList.CARRIER_FAX_NUM)
            End Get
        End Property
        Public ReadOnly Property CARRIER_OFFICE_HOURS As FieldDef
            Get
                Return Fields(FieldList.CARRIER_OFFICE_HOURS)
            End Get
        End Property
        Public ReadOnly Property CARRIER_OFFICE_DAYS As FieldDef
            Get
                Return Fields(FieldList.CARRIER_OFFICE_DAYS)
            End Get
        End Property
        Public ReadOnly Property CARRIER_BUDGET_CNTR As FieldDef
            Get
                Return Fields(FieldList.CARRIER_BUDGET_CNTR)
            End Get
        End Property
        Public ReadOnly Property CARRIER_POB_ADDR_LINE1 As FieldDef
            Get
                Return Fields(FieldList.CARRIER_POB_ADDR_LINE1)
            End Get
        End Property
        Public ReadOnly Property CARRIER_POB_ADDR_LINE2 As FieldDef
            Get
                Return Fields(FieldList.CARRIER_POB_ADDR_LINE2)
            End Get
        End Property
        Public ReadOnly Property CARRIER_POB_ADDR_LINE3 As FieldDef
            Get
                Return Fields(FieldList.CARRIER_POB_ADDR_LINE3)
            End Get
        End Property
        Public ReadOnly Property CARRIER_POB_CITY As FieldDef
            Get
                Return Fields(FieldList.CARRIER_POB_CITY)
            End Get
        End Property
        Public ReadOnly Property CARRIER_POB_STATE As FieldDef
            Get
                Return Fields(FieldList.CARRIER_POB_STATE)
            End Get
        End Property
        Public ReadOnly Property CARRIER_POB_ZIP As FieldDef
            Get
                Return Fields(FieldList.CARRIER_POB_ZIP)
            End Get

        End Property
        Public ReadOnly Property CARRIER_MAIL_ADDR_LINE1 As FieldDef
            Get
                Return Fields(FieldList.CARRIER_MAIL_ADDR_LINE1)
            End Get
        End Property
        Public ReadOnly Property CARRIER_MAIL_ADDR_LINE2 As FieldDef
            Get
                Return Fields(FieldList.CARRIER_MAIL_ADDR_LINE2)
            End Get
        End Property
        Public ReadOnly Property CARRIER_MAIL_ADDR_LINE3 As FieldDef
            Get
                Return Fields(FieldList.CARRIER_MAIL_ADDR_LINE3)
            End Get
        End Property
        Public ReadOnly Property CARRIER_MAIL_CITY As FieldDef
            Get
                Return Fields(FieldList.CARRIER_MAIL_CITY)
            End Get
        End Property
        Public ReadOnly Property CARRIER_MAIL_STATE As FieldDef
            Get
                Return Fields(FieldList.CARRIER_MAIL_STATE)
            End Get
        End Property
        Public ReadOnly Property CARRIER_MAIL_ZIP As FieldDef
            Get
                Return Fields(FieldList.CARRIER_MAIL_ZIP)
            End Get
        End Property
#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " PolValues "
    <Serializable()>
    Public Class PolValues
        Inherits DTL

#Region " Constructors "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "PolValues"
            Me.NodeParent = "Policy"
        End Sub

        Private Shadows Enum FieldList
            REC_TYPE

        End Enum

        Private Sub Initialize()

        End Sub

#End Region

#Region " Properties "


#End Region

#Region "Methods"

#End Region

    End Class


#End Region
#Region " PolValue "

    Public Class PolValue
        Inherits DTL

        Private Shadows Enum FieldList
            PVAL_CONT
            PVAL_TXN_EFF_DATE
            PVAL_END_ACCUM_VAL
            PVAL_CASH_VAL
            PVAL_DEATH_BNFT_VAL
            PVAL_SURR_CHRG
            PVAL_PYTD_PREM
            PVAL_PYTD_WITHD
            PVAL_PYTD_INTEREST_CREDITED
            PVAL_BEGIN_DATE
            PVAL_BEGIN_ACCUM_VAL
            PVAL_PYTD_ADV_WITHD
            PVAL_LTC_RIDER_FLAG_ANNUICARE
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "PolValue"
            Me.NodeParent = "PolValues"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("PVAL_CONT", "CONT"))
                .Add(New FieldDef("PVAL_TXN_EFF_DATE", "", FieldType.Date, "yyyy-MM-dd", "CURR_ANNIV_DATE"))
                .Add(New FieldDef("PVAL_END_ACCUM_VAL", "CURR_ACCT_VAL"))
                .Add(New FieldDef("PVAL_CASH_VAL", "F:CASH_SURR_VALUE"))
                .Add(New FieldDef("PVAL_DEATH_BNFT_VAL", "DEATH_BEN"))
                .Add(New FieldDef("PVAL_SURR_CHRG", "SURR_CHRG"))
                .Add(New FieldDef("PVAL_PYTD_PREM", "PYTD_PREM"))
                .Add(New FieldDef("PVAL_PYTD_WITHD", "PYTD_WITHD"))
                .Add(New FieldDef("PVAL_PYTD_INTEREST_CREDITED", "F:INTEREST_CREDITED"))
                .Add(New FieldDef("PVAL_BEGIN_DATE", "", FieldType.Date, "yyyy-MM-dd", "PRIOR_ANNIV_DATE"))
                .Add(New FieldDef("PVAL_BEGIN_ACCUM_VAL", "PRIOR_ACCT_VAL"))
                .Add(New FieldDef("PVAL_PYTD_ADV_WITHD", "PYTD_ADV_WITHD"))
                .Add(New FieldDef("PVAL_LTC_RIDER_FLAG_ANNUICARE", "LTC_RIDER_FLAG_ANNUICARE"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property PVAL_CONT As FieldDef
            Get
                Return Fields(FieldList.PVAL_CONT)
            End Get
        End Property
        Public ReadOnly Property PVAL_TXN_EFF_DATE As FieldDef
            Get
                Return Fields(FieldList.PVAL_TXN_EFF_DATE)
            End Get
        End Property
        Public ReadOnly Property PVAL_END_ACCUM_VAL As FieldDef
            Get
                Return Fields(FieldList.PVAL_END_ACCUM_VAL)
            End Get
        End Property
        Public ReadOnly Property PVAL_CASH_VAL As FieldDef
            Get
                Return Fields(FieldList.PVAL_CASH_VAL)
            End Get
        End Property
        Public ReadOnly Property PVAL_DEATH_BNFT_VAL As FieldDef
            Get
                Return Fields(FieldList.PVAL_DEATH_BNFT_VAL)
            End Get
        End Property
        Public ReadOnly Property PVAL_SURR_CHRG As FieldDef
            Get
                Return Fields(FieldList.PVAL_SURR_CHRG)
            End Get
        End Property
        Public ReadOnly Property PVAL_PYTD_PREM As FieldDef
            Get
                Return Fields(FieldList.PVAL_PYTD_PREM)
            End Get
        End Property
        Public ReadOnly Property PVAL_PYTD_WITHD As FieldDef
            Get
                Return Fields(FieldList.PVAL_PYTD_WITHD)
            End Get
        End Property
        Public ReadOnly Property PVAL_PYTD_INTEREST_CREDITED As FieldDef
            Get
                Return Fields(FieldList.PVAL_PYTD_INTEREST_CREDITED)
            End Get
        End Property
        Public ReadOnly Property PVAL_BEGIN_DATE As FieldDef
            Get
                Return Fields(FieldList.PVAL_BEGIN_DATE)
            End Get
        End Property
        Public ReadOnly Property PVAL_BEGIN_ACCUM_VAL As FieldDef
            Get
                Return Fields(FieldList.PVAL_BEGIN_ACCUM_VAL)
            End Get
        End Property
        Public ReadOnly Property PVAL_PYTD_ADV_WITHD As FieldDef
            Get
                Return Fields(FieldList.PVAL_PYTD_ADV_WITHD)
            End Get
        End Property
        Public ReadOnly Property PVAL_LTC_RIDER_FLAG_ANNUICARE As FieldDef
            Get
                Return Fields(FieldList.PVAL_LTC_RIDER_FLAG_ANNUICARE)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region

    End Class

#End Region

#Region " FundValues "
    <Serializable()>
    Public Class FundValues
        Inherits DTL

#Region " Constructors "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "FundValues"
            Me.NodeParent = "Policy"
        End Sub

        Private Shadows Enum FieldList
            REC_TYPE

        End Enum

        Private Sub Initialize()

        End Sub

#End Region

#Region " Properties "


#End Region

#Region "Methods"

#End Region

    End Class


#End Region
#Region " FundValue "

    Public Class FundValue
        Inherits DTL

        Private Shadows Enum FieldList
            FND_CONT
            FND_ACC_CODE
            FND_DIV_CODE
            FND_FUND_CORR_NAME
            FND_END_BAL
            FND_INT_RATE
            FND_DEPOSIT_DATE
            FND_RENEW_DATE
            FND_GNTY_PERD

        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "FundValue"
            Me.NodeParent = "FundValues"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("FND_CONT", "CONT"))
                .Add(New FieldDef("FND_ACC_CODE", "ACC_CODE"))
                .Add(New FieldDef("FND_DIV_CODE", "DIV_CODE"))
                .Add(New FieldDef("FND_FUND_CORR_NAME", "CORRO_FUND_NAME"))
                .Add(New FieldDef("FND_END_BAL", "VALUE"))
                .Add(New FieldDef("FND_INT_RATE", 0, FieldType.Number, "0.00", "RATE"))
                .Add(New FieldDef("FND_DEPOSIT_DATE", "", FieldType.Date, "yyyy-MM-dd", "DPST_DATE"))
                .Add(New FieldDef("FND_RENEW_DATE", "", FieldType.Date, "yyyy-MM-dd", "RATE_END_DATE"))
                .Add(New FieldDef("FND_GNTY_PRD", "GNTY_PRD"))
                '

            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property FND_CONT As FieldDef
            Get
                Return Fields(FieldList.FND_CONT)
            End Get
        End Property
        Public ReadOnly Property FND_ACC_CODE As FieldDef
            Get
                Return Fields(FieldList.FND_ACC_CODE)
            End Get
        End Property
        Public ReadOnly Property FND_DIV_CODE As FieldDef
            Get
                Return Fields(FieldList.FND_DIV_CODE)
            End Get
        End Property
        Public ReadOnly Property FND_FUND_CORR_NAME As FieldDef
            Get
                Return Fields(FieldList.FND_FUND_CORR_NAME)
            End Get
        End Property
        Public ReadOnly Property FND_END_BAL As FieldDef
            Get
                Return Fields(FieldList.FND_END_BAL)
            End Get
        End Property

        Public ReadOnly Property FND_INT_RATE As FieldDef
            Get
                Return Fields(FieldList.FND_INT_RATE)
            End Get
        End Property
        Public ReadOnly Property FND_DEPOSIT_DATE As FieldDef
            Get
                Return Fields(FieldList.FND_DEPOSIT_DATE)
            End Get
        End Property
        Public ReadOnly Property FND_RENEW_DATE As FieldDef
            Get
                Return Fields(FieldList.FND_RENEW_DATE)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region

    End Class

#End Region

#Region " PriorAnnvFunds "
    <Serializable()>
    Public Class PriorAnnvFunds
        Inherits DTL

#Region " Constructors "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "PriorAnnvFunds"
            Me.NodeParent = "Policy"
        End Sub

        Private Shadows Enum FieldList
            REC_TYPE

        End Enum

        Private Sub Initialize()

        End Sub

#End Region

#Region " Properties "


#End Region

#Region "Methods"

#End Region

    End Class


#End Region
#Region " PriorAnnvFund "

    Public Class PriorAnnvFund
        Inherits DTL

        Private Shadows Enum FieldList
            PAF_CONT
            PAF_ACC_CODE
            PAF_DIV_CODE
            PAF_FUND_CORR_NAME
            PAF_BEGIN_BAL
            PAF_INTEREST_RATE
            PAF_DEPOSIT_DATE
            PAF_RENEW_DATE
            PAF_END_GTRY_PERD

        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "PriorAnnvFund"
            Me.NodeParent = "PriorAnnvFunds"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("PAF_CONT", "CONT"))
                .Add(New FieldDef("PAF_ACC_CODE", "ACC_CODE"))
                .Add(New FieldDef("PAF_DIV_CODE", "DIV_CODE"))
                .Add(New FieldDef("PAF_FUND_CORR_NAME", "CORRO_FUND_NAME"))
                .Add(New FieldDef("PAF_BEGIN_BAL", "PRIOR_FUND_BAL"))
                .Add(New FieldDef("PAF_INTEREST_RATE", 0, FieldType.Number, "0.00", "RATE"))
                .Add(New FieldDef("PAF_DEPOSIT_DATE", "", FieldType.Date, "yyyy-MM-dd", "DPST_DATE"))
                .Add(New FieldDef("PAF_RENEW_DATE", "", FieldType.Date, "yyyy-MM-dd", "RATE_END_DATE"))
                .Add(New FieldDef("PAF_END_GTRY_PERD", "F:END_PERIOD_IND"))
                .Add(New FieldDef("PAF_GTRY_PERD", "GNTY_PERD"))


            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property PAF_CONT As FieldDef
            Get
                Return Fields(FieldList.PAF_CONT)
            End Get
        End Property
        Public ReadOnly Property PAF_ACC_CODE As FieldDef
            Get
                Return Fields(FieldList.PAF_ACC_CODE)
            End Get
        End Property
        Public ReadOnly Property PAF_DIV_CODE As FieldDef
            Get
                Return Fields(FieldList.PAF_DIV_CODE)
            End Get
        End Property
        Public ReadOnly Property PAF_FUND_CORR_NAME As FieldDef
            Get
                Return Fields(FieldList.PAF_FUND_CORR_NAME)
            End Get
        End Property
        Public ReadOnly Property PAF_BEGIN_BAL As FieldDef
            Get
                Return Fields(FieldList.PAF_BEGIN_BAL)
            End Get
        End Property
        Public ReadOnly Property PAF_INTEREST_RATE As FieldDef
            Get
                Return Fields(FieldList.PAF_INTEREST_RATE)
            End Get
        End Property
        Public ReadOnly Property PAF_DEPOSIT_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_DEPOSIT_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_RENEW_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_RENEW_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_END_GTRY_PERD As FieldDef
            Get
                Return Fields(FieldList.PAF_END_GTRY_PERD)
            End Get
        End Property



#End Region

#Region " METHODS "

#End Region

    End Class

#End Region

#Region " TransHst "
    <Serializable()>
    Public Class TransHst
        Inherits DTL

#Region " Constructors "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "TransHst"
            Me.NodeParent = "Policy"
        End Sub

        Private Shadows Enum FieldList
            REC_TYPE

        End Enum

        Private Sub Initialize()

        End Sub

#End Region

#Region " Properties "


#End Region

#Region "Methods"

#End Region

    End Class


#End Region
#Region " TxnHst "

    Public Class TxnHst
        Inherits DTL

        Private Shadows Enum FieldList
            TXH_CONT
            TXH_TXN_DATE
            TXH_TXN_NUM
            TXH_TXN_DESC
            TXH_TXN_TOTAL_AMT

        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "TxnHst"
            Me.NodeParent = "TransHst"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("TXH_CONT", "CONT"))
                .Add(New FieldDef("TXH_TXN_DATE", "", FieldType.Date, "yyyy-MM-dd", "TXN_DATE"))
                .Add(New FieldDef("TXH_TXN_NUM", "TXN_NUM"))
                .Add(New FieldDef("TXH_TXN_DESC", "F:TXN_TYPE_DESC"))
                .Add(New FieldDef("TXH_TXN_TOTAL_AMT", "TOTAL_FUND_TXN_AMT"))

            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property TXH_CONT As FieldDef
            Get
                Return Fields(FieldList.TXH_CONT)
            End Get
        End Property
        Public ReadOnly Property TXH_TXN_DATE As FieldDef
            Get
                Return Fields(FieldList.TXH_TXN_DATE)
            End Get
        End Property
        Public ReadOnly Property TXH_TXN_NUM As FieldDef
            Get
                Return Fields(FieldList.TXH_TXN_NUM)
            End Get
        End Property
        Public ReadOnly Property TXH_TXN_DESC As FieldDef
            Get
                Return Fields(FieldList.TXH_TXN_DESC)
            End Get
        End Property
        Public ReadOnly Property TXH_TXN_TOTAL_AMT As FieldDef
            Get
                Return Fields(FieldList.TXH_TXN_TOTAL_AMT)
            End Get
        End Property


#End Region

#Region " METHODS "

#End Region

    End Class

#End Region

#Region " TransFndHst "
    <Serializable()>
    Public Class TransFndHst
        Inherits DTL

#Region " Constructors "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "TransFndHst"
            Me.NodeParent = "TransHst"
        End Sub

        Private Shadows Enum FieldList
            REC_TYPE

        End Enum

        Private Sub Initialize()

        End Sub

#End Region

#Region " Properties "


#End Region

#Region "Methods"

#End Region

    End Class


#End Region
#Region " TxnFndHst "

    Public Class TxnFndHst
        Inherits DTL

        Private Shadows Enum FieldList
            TFH_CONT
            TFH_TXN_NUM
            TFH_ACC_CODE
            TFH_DIV_CODE
            TFH_FUND_CORR_NAME
            TFH_FUND_AMT


        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "TxnFndHst"
            Me.NodeParent = "TransFndHst"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("TFH_CONT", "CONT"))
                .Add(New FieldDef("TFH_TXN_NUM", "TXN_NUM"))
                .Add(New FieldDef("TFH_ACC_CODE", "ACC_CODE"))
                .Add(New FieldDef("TFH_DIV_CODE", "DIV_CODE"))
                .Add(New FieldDef("TFH_FUND_CORR_NAME", "CORRO_FUND_NAME"))
                .Add(New FieldDef("TFH_FUND_AMT", "FUND_TXN_AMT"))

            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property TFH_CONT As FieldDef
            Get
                Return Fields(FieldList.TFH_CONT)
            End Get
        End Property
        Public ReadOnly Property TFH_TXN_NUME As FieldDef
            Get
                Return Fields(FieldList.TFH_TXN_NUM)
            End Get
        End Property
        Public ReadOnly Property TFH_ACC_CODE As FieldDef
            Get
                Return Fields(FieldList.TFH_ACC_CODE)
            End Get
        End Property
        Public ReadOnly Property TFH_DIV_CODE As FieldDef
            Get
                Return Fields(FieldList.TFH_DIV_CODE)
            End Get
        End Property
        Public ReadOnly Property TFH_FUND_CORR_NAME As FieldDef
            Get
                Return Fields(FieldList.TFH_FUND_CORR_NAME)
            End Get
        End Property
        Public ReadOnly Property TFH_FUND_AMT As FieldDef
            Get
                Return Fields(FieldList.TFH_FUND_AMT)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region

    End Class

#End Region


#Region " RenewalRates "
    <Serializable()>
    Public Class RenewalRates
        Inherits DTL

#Region " Constructors "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "RenewalRates"
            Me.NodeParent = "Policy"
        End Sub

        Private Shadows Enum FieldList
            REC_TYPE

        End Enum

        Private Sub Initialize()

        End Sub

#End Region

#Region " Properties "


#End Region

#Region "Methods"

#End Region

    End Class


#End Region
#Region " RenewRates "

    Public Class RenewRates
        Inherits DTL

        Private Shadows Enum FieldList
            RNW_CONT
            RNW_ACC_CODE
            RNW_DIV_CODE
            RNW_FUND_CORR_NAME
            RNW_INT_RATE
            RNW_INDEX_GUAR_PERIOD

        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "RenewRates"
            Me.NodeParent = "RenewalRates"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("RNW_CONT", "CONT"))
                .Add(New FieldDef("RNW_ACC_CODE", "ACC_CODE"))
                .Add(New FieldDef("RNW_DIV_CODE", "DIV_CODE"))
                .Add(New FieldDef("RNW_FUND_CORR_NAME", "F:CORRO_FUND_NAME"))
                .Add(New FieldDef("RNW_INT_RATE", 0, FieldType.Number, "0.00", "INT_RATE"))
                .Add(New FieldDef("RNW_INDEX_GUAR_PERIOD", "GUAR_PERIOD"))

            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property RNW_CONT As FieldDef
            Get
                Return Fields(FieldList.RNW_CONT)
            End Get
        End Property
        Public ReadOnly Property RNW_ACC_CODE As FieldDef
            Get
                Return Fields(FieldList.RNW_ACC_CODE)
            End Get
        End Property
        Public ReadOnly Property RNW_DIV_CODE As FieldDef
            Get
                Return Fields(FieldList.RNW_DIV_CODE)
            End Get
        End Property
        Public ReadOnly Property RNW_FUND_CORR_NAME As FieldDef
            Get
                Return Fields(FieldList.RNW_FUND_CORR_NAME)
            End Get
        End Property
        Public ReadOnly Property RNW_INT_RATE As FieldDef
            Get
                Return Fields(FieldList.RNW_INT_RATE)
            End Get
        End Property
        Public ReadOnly Property RNW_INDEX_GUAR_PERIOD As FieldDef
            Get
                Return Fields(FieldList.RNW_INDEX_GUAR_PERIOD)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region

    End Class

#End Region




#End Region

End Namespace
