Imports Se2.ISI.Base.Presentation

Namespace Se2.ISCORSP.Client.GLCO.FIAAnnivStmt.Records


#Region " FIAAnnivStmt "

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
            POL_MATURITY_DATE
            POL_PRDCT_MKTG_NAME
            POL_ISSUE_DATE
            POL_DOC_TYPE
            POL_SYS_CODE


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
                .Add(New FieldDef("POL_SERVICE_DESC", "S:Anniversary Statement"))
                .Add(New FieldDef("POL_SOURCE", "S:SE2"))
                .Add(New FieldDef("POL_STATUS", "F:ACCOUNT_STATUS"))
                .Add(New FieldDef("POL_POL_NUM", "POL_NUM"))
                .Add(New FieldDef("POL_PRDCT_COMP", "PRODUCT_CO"))
                .Add(New FieldDef("POL_LOB", "F:LINE_OF_BUSINESS"))
                .Add(New FieldDef("POL_PRCSG_COMP", "PRCSSNG_CO"))
                .Add(New FieldDef("POL_TRACKING_ID", "F:TrackingID"))
                .Add(New FieldDef("POL_MATURITY_DATE", "", FieldType.Date, "yyyy-MM-dd", "MAT_DATE"))
                .Add(New FieldDef("POL_PRDCT_MKTG_NAME", "F:MKT_PRDCT_NAME"))
                .Add(New FieldDef("POL_ISSUE_DATE", "", FieldType.Date, "yyyy-MM-dd", "ISSUE_DATE"))
                .Add(New FieldDef("POL_DOC_TYPE", "S:ANN"))
                .Add(New FieldDef("POL_SYS_CODE", "SYSTEM_CODE"))
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
        Public ReadOnly Property POL_MATURITY_DATE As FieldDef
            Get
                Return Fields(FieldList.POL_MATURITY_DATE)
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
        Public ReadOnly Property POL_DOC_TYPE As FieldDef
            Get
                Return Fields(FieldList.POL_DOC_TYPE)
            End Get
        End Property
        Public ReadOnly Property POL_SYS_CODE As FieldDef
            Get
                Return Fields(FieldList.POL_SYS_CODE)
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

#Region " Features "

    <Serializable()>
    Public Class FEATURES
        Inherits DTL

#Region " Constructors "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "Features"
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
#Region " Feature "
    Public Class FEATURE
        Inherits DTL
        Private Shadows Enum FieldList
            REC_TYPE
            FEA_CONT
            FEA_FEAT_DESC
            FEA_FEAT_SPEC_CODE
            FEA_FEAT_SPEC_ID
            FEA_FEAT_VARIATION_GROUP_ID
            FEA_RIDER_ELECTED_IND
            FEA_LEVEL_AMT
            FEA_INCREASE_AMT
        End Enum

#Region " Constructors "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "Feature"
            Me.NodeParent = "Features"
        End Sub



        Private Sub Initialize()
            With Fields
                '.Add(New FieldDef("REC_TYPE", "S:FEATURE"))
                .Add(New FieldDef("FEA_CONT", "CONT"))
                .Add(New FieldDef("FEA_FEAT_DESC", "F:GetFeatDesc"))
                .Add(New FieldDef("FEA_FEAT_SPEC_CODE", "SPEC_CODE"))
                .Add(New FieldDef("FEA_FEAT_SPEC_ID", "SPEC_ID"))
                .Add(New FieldDef("FEA_FEAT_VARIATION_GROUP_ID", "VARIATION_GROUP_ID"))
                .Add(New FieldDef("FEA_RIDER_ELECTED_IND", "F:GetRiderActiveInd"))
                .Add(New FieldDef("FEA_LEVEL_AMT", 0, FieldType.Number, "0.00", "F:GetRiderLevelAmt"))
                .Add(New FieldDef("FEA_INCREASE_AMT", 0, FieldType.Number, "0.00", "F:GetRiderIncreAmt"))
            End With
        End Sub

#End Region

#Region " Properties "

        Public ReadOnly Property REC_TYPE As FieldDef
            Get
                Return Fields(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property FEA_CONT As FieldDef
            Get
                Return Fields(FieldList.FEA_CONT)
            End Get
        End Property
        Public ReadOnly Property FEA_FEAT_DESC As FieldDef
            Get
                Return Fields(FieldList.FEA_FEAT_DESC)
            End Get
        End Property
        Public ReadOnly Property FEA_FEAT_SPEC_CODE As FieldDef
            Get
                Return Fields(FieldList.FEA_FEAT_SPEC_CODE)
            End Get
        End Property
        Public ReadOnly Property FEA_FEAT_SPEC_ID As FieldDef
            Get
                Return Fields(FieldList.FEA_FEAT_SPEC_ID)
            End Get
        End Property

        Public ReadOnly Property FEA_FEAT_VARIATION_GROUP_ID As FieldDef
            Get
                Return Fields(FieldList.FEA_FEAT_VARIATION_GROUP_ID)
            End Get
        End Property
        Public ReadOnly Property FEA_LEVEL_AMT As FieldDef
            Get
                Return Fields(FieldList.FEA_LEVEL_AMT)
            End Get
        End Property
        Public ReadOnly Property FEA_INCREASE_AMT As FieldDef
            Get
                Return Fields(FieldList.FEA_INCREASE_AMT)
            End Get
        End Property

#End Region

#Region " Methods "

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
            PVAL_GMWB_RATCHET_BASE
            PVAL_GWB_ANNUAL_LIMIT
            PVAL_PYTD_PREM
            PVAL_PREM_BONUS
            PVAL_PYTD_WITHD
            PVAL_PYTD_INTEREST_CREDITED
            PVAL_BEGIN_DATE
            PVAL_BEGIN_ACCUM_VAL
            PVAL_NEXT_ANNIV_DATE
            PVAL_GWB_BENEFIT_START_DATE
            PVAL_PYTD_INDEX_INTEREST_CREDITED
            PVAL_PYTD_FIXED_INTEREST_CREDITED
            PVAL_RIDER_CHRG
            PVAL_GLWB_PHASE_CHANGE
            PVAL_EARLY_DATE
            PVAL_PYTD_PREM_BONUS
            PVAL_BONUS_INT_AMT
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
                .Add(New FieldDef("PVAL_DEATH_BNFT_VAL", 0, FieldType.Number, "0.00", "DEATH_BEN"))
                .Add(New FieldDef("PVAL_SURR_CHRG", 0, FieldType.Number, "0.00", "SURR_CHRG"))
                .Add(New FieldDef("PVAL_GMWB_RATCHET_BASE", 0, FieldType.Number, "0.00", "GMWB_RATCHET_BASE"))
                .Add(New FieldDef("PVAL_GWB_ANNUAL_LIMIT", 0, FieldType.Number, "0.00", "GWB_ANNUAL_LIMIT"))
                .Add(New FieldDef("PVAL_PYTD_PREM", 0, FieldType.Number, "0.00", "F:GetPrem"))                         'F:GetPrem
                .Add(New FieldDef("PVAL_PREM_BONUS", 0, FieldType.Number, "0.00", "F:GetPremBonus"))
                .Add(New FieldDef("PVAL_PYTD_WITHD", "PYTD_WITHD"))
                .Add(New FieldDef("PVAL_PYTD_INTEREST_CREDITED", "F:INTEREST_CREDITED"))
                .Add(New FieldDef("PVAL_BEGIN_DATE", "", FieldType.Date, "yyyy-MM-dd", "PRIOR_ANNIV_DATE"))
                .Add(New FieldDef("PVAL_BEGIN_ACCUM_VAL", "PRIOR_ACCT_VAL"))
                .Add(New FieldDef("PVAL_NEXT_ANNIV_DATE", "", FieldType.Date, "yyyy-MM-dd", "NEXT_ANNIV_DATE"))
                .Add(New FieldDef("PVAL_GWB_BENEFIT_START_DATE", "", FieldType.Date, "yyyy-MM-dd", "GLWB_BNFT_START_DATE"))
                .Add(New FieldDef("PVAL_PYTD_INDEX_INTEREST_CREDITED", "F:INDEX_INTEREST_CREDIT"))
                .Add(New FieldDef("PVAL_PYTD_FIXED_INTEREST_CREDITED", "F:FIXED_INTEREST_CREDITED"))
                .Add(New FieldDef("PVAL_RIDER_CHRG", 0, FieldType.Number, "0.00", "F:RIDER_CHARGE"))
                .Add(New FieldDef("PVAL_GLWB_PHASE_CHANGE", "GMWB_PHASE"))
                .Add(New FieldDef("PVAL_EARLY_DATE", "", FieldType.Date, "yyyy-MM-dd", "F:CALC_EARLY_DATE"))
                .Add(New FieldDef("PVAL_PYTD_PREM_BONUS", "F:GetPremAmount"))
                .Add(New FieldDef("PVAL_BONUS_INT_AMT", "F:GetBonusAmount"))
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
        Public ReadOnly Property PVAL_GMWB_RATCHET_BASE As FieldDef
            Get
                Return Fields(FieldList.PVAL_GMWB_RATCHET_BASE)
            End Get
        End Property
        Public ReadOnly Property PVAL_GWB_ANNUAL_LIMIT As FieldDef
            Get
                Return Fields(FieldList.PVAL_GWB_ANNUAL_LIMIT)
            End Get
        End Property
        Public ReadOnly Property PVAL_PYTD_PREM As FieldDef
            Get
                Return Fields(FieldList.PVAL_PYTD_PREM)
            End Get
        End Property
        Public ReadOnly Property PVAL_PREM_BONUS As FieldDef
            Get
                Return Fields(FieldList.PVAL_PREM_BONUS)
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
        Public ReadOnly Property PVAL_NEXT_ANNIV_DATE As FieldDef
            Get
                Return Fields(FieldList.PVAL_NEXT_ANNIV_DATE)
            End Get
        End Property
        Public ReadOnly Property PVAL_GWB_BENEFIT_START_DATE As FieldDef
            Get
                Return Fields(FieldList.PVAL_GWB_BENEFIT_START_DATE)
            End Get
        End Property
        Public ReadOnly Property PVAL_PYTD_INDEX_INTEREST_CREDITED As FieldDef
            Get
                Return Fields(FieldList.PVAL_PYTD_INDEX_INTEREST_CREDITED)
            End Get
        End Property
        Public ReadOnly Property PVAL_PYTD_FIXED_INTEREST_CREDITED As FieldDef
            Get
                Return Fields(FieldList.PVAL_PYTD_FIXED_INTEREST_CREDITED)
            End Get
        End Property
        Public ReadOnly Property PVAL_RIDER_CHRG As FieldDef
            Get
                Return Fields(FieldList.PVAL_RIDER_CHRG)
            End Get
        End Property

        Public ReadOnly Property PVAL_GLWB_PHASE_CHANGE As FieldDef
            Get
                Return Fields(FieldList.PVAL_GLWB_PHASE_CHANGE)
            End Get
        End Property
        Public ReadOnly Property PVAL_EARLY_DATE As FieldDef
            Get
                Return Fields(FieldList.PVAL_EARLY_DATE)
            End Get
        End Property


        Public ReadOnly Property PVAL_PYTD_PREM_BONUS As FieldDef
            Get
                Return Fields(FieldList.PVAL_PYTD_PREM_BONUS)
            End Get
        End Property
        Public ReadOnly Property PVAL_BONUS_INT_AMT As FieldDef
            Get
                Return Fields(FieldList.PVAL_BONUS_INT_AMT)
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
            'FND_TXN_NUM
            FND_FUND_MKTG_NAME
            FND_END_BAL
            FND_PART_RATE
            FND_CAP_RATE
            FND_SPREAD_RATE
            FND_INT_RATE
            FND_END_INDEX_VALUE
            FND_ORIG_DEPST_DATE

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
                '.Add(New FieldDef("FND_TXN_NUM", "TXN_NUM"))
                .Add(New FieldDef("FND_FUND_MKTG_NAME", "MRKT_FUND_NAME"))
                .Add(New FieldDef("FND_END_BAL", "VALUE"))
                .Add(New FieldDef("FND_PART_RATE", "F:PARTICIPATION_RATE"))
                .Add(New FieldDef("FND_CAP_RATE", "F:INDEX_CAP_RATE"))
                .Add(New FieldDef("FND_SPREAD_RATE", "F:INDEX_SPREAD_RATE"))
                .Add(New FieldDef("FND_INT_RATE", "F:INTEREST_RATE"))
                .Add(New FieldDef("FND_END_INDEX_VALUE", "F:INDEX_VALUE"))
                .Add(New FieldDef("FND_ORIG_DEPST_DATE", "ORIG_DEPST_DATE"))


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
        'Public ReadOnly Property FND_TXN_NUM As FieldDef
        '    Get
        '        Return Fields(FieldList.FND_TXN_NUM)
        '    End Get
        'End Property
        Public ReadOnly Property FND_FUND_MKTG_NAME As FieldDef
            Get
                Return Fields(FieldList.FND_FUND_MKTG_NAME)
            End Get
        End Property
        Public ReadOnly Property FND_END_BAL As FieldDef
            Get
                Return Fields(FieldList.FND_END_BAL)
            End Get
        End Property
        Public ReadOnly Property FND_PART_RATE As FieldDef
            Get
                Return Fields(FieldList.FND_PART_RATE)
            End Get
        End Property
        Public ReadOnly Property FND_CAP_RATE As FieldDef
            Get
                Return Fields(FieldList.FND_CAP_RATE)
            End Get
        End Property
        Public ReadOnly Property FND_SPREAD_RATE As FieldDef
            Get
                Return Fields(FieldList.FND_SPREAD_RATE)
            End Get
        End Property
        Public ReadOnly Property FND_INT_RATE As FieldDef
            Get
                Return Fields(FieldList.FND_INT_RATE)
            End Get
        End Property
        Public ReadOnly Property FND_END_INDEX_VALUE As FieldDef
            Get
                Return Fields(FieldList.FND_END_INDEX_VALUE)
            End Get
        End Property
        Public ReadOnly Property FND_ORIG_DEPST_DATE As FieldDef
            Get
                Return Fields(FieldList.FND_ORIG_DEPST_DATE)
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
            PAF_FUND_MKTG_NAME
            PAF_BEGIN_BAL
            PAF_PART_RATE
            PAF_CAP_RATE
            PAF_SPREAD_RATE
            PAF_INTEREST_RATE
            PAF_INDX_BEGIN_BAL
            PAF_INDX_GROWTH_RATE
            PAF_INDX_CREDIT_PERC
            PAF_BOP1_DATE
            PAF_BOP1_VAL
            PAF_MTH_INDX1_CHG_PERC
            PAF_MTH_INDX1_APPLD_CHG_PERC
            PAF_EOP1_DATE
            PAF_EOP1_VAL
            PAF_BOP2_DATE
            PAF_BOP2_VAL
            PAF_MTH_INDX2_CHG_PERC
            PAF_MTH_INDX2_APPLD_CHG_PERC
            PAF_EOP2_DATE
            PAF_EOP2_VAL
            PAF_BOP3_DATE
            PAF_BOP3_VAL
            PAF_MTH_INDX3_CHG_PERC
            PAF_MTH_INDX3_APPLD_CHG_PERC
            PAF_EOP3_DATE
            PAF_EOP3_VAL
            PAF_BOP4_DATE
            PAF_BOP4_VAL
            PAF_MTH_INDX4_CHG_PERC
            PAF_MTH_INDX4_APPLD_CHG_PERC
            PAF_EOP4_DATE
            PAF_EOP4_VAL
            PAF_BOP5_DATE
            PAF_BOP5_VAL
            PAF_MTH_INDX5_CHG_PERC
            PAF_MTH_INDX5_APPLD_CHG_PERC
            PAF_EOP5_DATE
            PAF_EOP5_VAL
            PAF_BOP6_DATE
            PAF_BOP6_VAL
            PAF_MTH_INDX6_CHG_PERC
            PAF_MTH_INDX6_APPLD_CHG_PERC
            PAF_EOP6_DATE
            PAF_EOP6_VAL
            PAF_BOP7_DATE
            PAF_BOP7_VAL
            PAF_MTH_INDX7_CHG_PERC
            PAF_MTH_INDX7_APPLD_CHG_PERC
            PAF_EOP7_DATE
            PAF_EOP7_VAL
            PAF_BOP8_DATE
            PAF_BOP8_VAL
            PAF_MTH_INDX8_CHG_PERC
            PAF_MTH_INDX8_APPLD_CHG_PERC
            PAF_EOP8_DATE
            PAF_EOP8_VAL
            PAF_BOP9_DATE
            PAF_BOP9_VAL
            PAF_MTH_INDX9_CHG_PERC
            PAF_MTH_INDX9_APPLD_CHG_PERC
            PAF_EOP9_DATE
            PAF_EOP9_VAL
            PAF_BOP10_DATE
            PAF_BOP10_VAL
            PAF_MTH_INDX10_CHG_PERC
            PAF_MTH_INDX10_APPLD_CHG_PERC
            PAF_EOP10_DATE
            PAF_EOP10_VAL
            PAF_BOP11_DATE
            PAF_BOP11_VAL
            PAF_MTH_INDX11_CHG_PERC
            PAF_MTH_INDX11_APPLD_CHG_PERC
            PAF_EOP11_DATE
            PAF_EOP11_VAL
            PAF_BOP12_DATE
            PAF_BOP12_VAL
            PAF_MTH_INDX12_CHG_PERC
            PAF_MTH_INDX12_APPLD_CHG_PERC
            PAF_EOP12_DATE
            PAF_ORIG_DEPST_DATE

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
                .Add(New FieldDef("PAF_FUND_MKTG_NAME", "MRKT_FUND_NAME"))
                .Add(New FieldDef("PAF_BEGIN_BAL", "PRIOR_FUND_BAL"))
                .Add(New FieldDef("PAF_PART_RATE", 0, FieldType.Number, "0.00", "F:PRIOR_PART_RATE"))
                .Add(New FieldDef("PAF_CAP_RATE", 0, FieldType.Number, "0.00", "F:PRIOR_INDEX_CAP_RATE"))
                .Add(New FieldDef("PAF_SPREAD_RATE", "F:PRIOR_SPREAD_RATE"))
                .Add(New FieldDef("PAF_INTEREST_RATE", 0, FieldType.Number, "0.00", "INT_RATE"))
                .Add(New FieldDef("PAF_INDX_BEGIN_BAL", 0, FieldType.Number, "0.00", "INDEX_BOP_VAL"))
                .Add(New FieldDef("PAF_INDX_GROWTH_RATE", 0, FieldType.Number, "0.000000", "F:INDX_GRWTH_RATE"))
                .Add(New FieldDef("PAF_INDX_CREDIT_PERC", 0, FieldType.Number, "0.000000", "F:INDEX_CREDIT_PERCENT"))
                .Add(New FieldDef("PAF_BOP1_DATE", "EI_BOP1_DATE"))
                .Add(New FieldDef("PAF_BOP1_VAL", 0, FieldType.Number, "0.00", "EI_BOP1"))
                .Add(New FieldDef("PAF_MTH_INDX1_CHG_PERC", 0, FieldType.Number, "0.000000", "F:MTH1_INDX_CHG"))
                .Add(New FieldDef("PAF_MTH_INDX1_APPLD_CHG_PERC", 0, FieldType.Number, "0.000000", "F:APPLD_CHG_MTH1"))
                .Add(New FieldDef("PAF_EOP1_DATE", "EI_BOP2_DATE"))
                .Add(New FieldDef("PAF_EOP1_VAL", 0, FieldType.Number, "0.00", "EI_BOP2"))
                .Add(New FieldDef("PAF_BOP2_DATE", "EI_BOP2_DATE"))
                .Add(New FieldDef("PAF_BOP2_VAL", 0, FieldType.Number, "0.00", "EI_BOP2"))
                .Add(New FieldDef("PAF_MTH_INDX2_CHG_PERC", 0, FieldType.Number, "0.000000", "F:MTH2_INDX_CHG"))
                .Add(New FieldDef("PAF_MTH_INDX2_APPLD_CHG_PERC", 0, FieldType.Number, "0.000000", "F:APPLD_CHG_MTH2"))
                .Add(New FieldDef("PAF_EOP2_DATE", "EI_BOP3_DATE"))
                .Add(New FieldDef("PAF_EOP2_VAL", 0, FieldType.Number, "0.00", "EI_BOP3"))
                .Add(New FieldDef("PAF_BOP3_DATE", "EI_BOP3_DATE"))
                .Add(New FieldDef("PAF_BOP3_VAL", 0, FieldType.Number, "0.00", "EI_BOP3"))
                .Add(New FieldDef("PAF_MTH_INDX3_CHG_PERC", 0, FieldType.Number, "0.000000", "F:MTH3_INDX_CHG"))
                .Add(New FieldDef("PAF_MTH_INDX3_APPLD_CHG_PERC", 0, FieldType.Number, "0.000000", "F:APPLD_CHG_MTH3"))
                .Add(New FieldDef("PAF_EOP3_DATE", "EI_BOP4_DATE"))
                .Add(New FieldDef("PAF_EOP3_VAL", 0, FieldType.Number, "0.00", "EI_BOP4"))
                .Add(New FieldDef("PAF_BOP4_DATE", "EI_BOP4_DATE"))
                .Add(New FieldDef("PAF_BOP4_VAL", 0, FieldType.Number, "0.00", "EI_BOP4"))
                .Add(New FieldDef("PAF_MTH_INDX4_CHG_PERC", 0, FieldType.Number, "0.000000", "F:MTH4_INDX_CHG"))
                .Add(New FieldDef("PAF_MTH_INDX4_APPLD_CHG_PERC", 0, FieldType.Number, "0.000000", "F:APPLD_CHG_MTH4"))
                .Add(New FieldDef("PAF_EOP4_DATE", "EI_BOP5_DATE"))
                .Add(New FieldDef("PAF_EOP4_VAL", 0, FieldType.Number, "0.00", "EI_BOP5"))
                .Add(New FieldDef("PAF_BOP5_DATE", "EI_BOP5_DATE"))
                .Add(New FieldDef("PAF_BOP5_VAL", 0, FieldType.Number, "0.00", "EI_BOP5"))
                .Add(New FieldDef("PAF_MTH_INDX5_CHG_PERC", 0, FieldType.Number, "0.000000", "F:MTH5_INDX_CHG"))
                .Add(New FieldDef("PAF_MTH_INDX5_APPLD_CHG_PERC", 0, FieldType.Number, "0.000000", "F:APPLD_CHG_MTH5"))
                .Add(New FieldDef("PAF_EOP5_DATE", "EI_BOP6_DATE"))
                .Add(New FieldDef("PAF_EOP5_VAL", 0, FieldType.Number, "0.00", "EI_BOP6"))
                .Add(New FieldDef("PAF_BOP6_DATE", "EI_BOP6_DATE"))
                .Add(New FieldDef("PAF_BOP6_VAL", 0, FieldType.Number, "0.00", "EI_BOP6"))
                .Add(New FieldDef("PAF_MTH_INDX6_CHG_PERC", 0, FieldType.Number, "0.000000", "F:MTH6_INDX_CHG"))
                .Add(New FieldDef("PAF_MTH_INDX6_APPLD_CHG_PERC", 0, FieldType.Number, "0.000000", "F:APPLD_CHG_MTH6"))
                .Add(New FieldDef("PAF_EOP6_DATE", "EI_BOP7_DATE"))
                .Add(New FieldDef("PAF_EOP6_VAL", 0, FieldType.Number, "0.00", "EI_BOP7"))
                .Add(New FieldDef("PAF_BOP7_DATE", "EI_BOP7_DATE"))
                .Add(New FieldDef("PAF_BOP7_VAL", 0, FieldType.Number, "0.00", "EI_BOP7"))
                .Add(New FieldDef("PAF_MTH_INDX7_CHG_PERC", 0, FieldType.Number, "0.000000", "F:MTH7_INDX_CHG"))
                .Add(New FieldDef("PAF_MTH_INDX7_APPLD_CHG_PERC", 0, FieldType.Number, "0.000000", "F:APPLD_CHG_MTH7"))
                .Add(New FieldDef("PAF_EOP7_DATE", "EI_BOP8_DATE"))
                .Add(New FieldDef("PAF_EOP7_VAL", 0, FieldType.Number, "0.00", "EI_BOP8"))
                .Add(New FieldDef("PAF_BOP8_DATE", "EI_BOP8_DATE"))
                .Add(New FieldDef("PAF_BOP8_VAL", 0, FieldType.Number, "0.00", "EI_BOP8"))
                .Add(New FieldDef("PAF_MTH_INDX8_CHG_PERC", 0, FieldType.Number, "0.000000", "F:MTH8_INDX_CHG"))
                .Add(New FieldDef("PAF_MTH_INDX8_APPLD_CHG_PERC", 0, FieldType.Number, "0.000000", "F:APPLD_CHG_MTH8"))
                .Add(New FieldDef("PAF_EOP8_DATE", "EI_BOP9_DATE"))
                .Add(New FieldDef("PAF_EOP8_VAL", 0, FieldType.Number, "0.00", "EI_BOP9"))
                .Add(New FieldDef("PAF_BOP9_DATE", "EI_BOP9_DATE"))
                .Add(New FieldDef("PAF_BOP9_VAL", 0, FieldType.Number, "0.00", "EI_BOP9"))
                .Add(New FieldDef("PAF_MTH_INDX9_CHG_PERC", 0, FieldType.Number, "0.000000", "F:MTH9_INDX_CHG"))
                .Add(New FieldDef("PAF_MTH_INDX9_APPLD_CHG_PERC", 0, FieldType.Number, "0.000000", "F:APPLD_CHG_MTH9"))
                .Add(New FieldDef("PAF_EOP9_DATE", "EI_BOP10_DATE"))
                .Add(New FieldDef("PAF_EOP9_VAL", 0, FieldType.Number, "0.00", "EI_BOP10"))
                .Add(New FieldDef("PAF_BOP10_DATE", "EI_BOP10_DATE"))
                .Add(New FieldDef("PAF_BOP10_VAL", 0, FieldType.Number, "0.00", "EI_BOP10"))
                .Add(New FieldDef("PAF_MTH_INDX10_CHG_PERC", 0, FieldType.Number, "0.000000", "F:MTH10_INDX_CHG"))
                .Add(New FieldDef("PAF_MTH_INDX10_APPLD_CHG_PERC", 0, FieldType.Number, "0.000000", "F:APPLD_CHG_MTH10"))
                .Add(New FieldDef("PAF_EOP10_DATE", "EI_BOP11_DATE"))
                .Add(New FieldDef("PAF_EOP10_VAL", 0, FieldType.Number, "0.00", "EI_BOP11"))
                .Add(New FieldDef("PAF_BOP11_DATE", "EI_BOP11_DATE"))
                .Add(New FieldDef("PAF_BOP11_VAL", 0, FieldType.Number, "0.00", "EI_BOP11"))
                .Add(New FieldDef("PAF_MTH_INDX11_CHG_PERC", 0, FieldType.Number, "0.000000", "F:MTH11_INDX_CHG"))
                .Add(New FieldDef("PAF_MTH_INDX11_APPLD_CHG_PERC", 0, FieldType.Number, "0.000000", "F:APPLD_CHG_MTH11"))
                .Add(New FieldDef("PAF_EOP11_DATE", "EI_BOP12_DATE"))
                .Add(New FieldDef("PAF_EOP11_VAL", 0, FieldType.Number, "0.00", "EI_BOP12"))
                .Add(New FieldDef("PAF_BOP12_DATE", "EI_BOP12_DATE"))
                .Add(New FieldDef("PAF_BOP12_VAL", 0, FieldType.Number, "0.00", "EI_BOP12"))
                .Add(New FieldDef("PAF_MTH_INDX12_CHG_PERC", 0, FieldType.Number, "0.000000", "F:MTH12_INDX_CHG"))
                .Add(New FieldDef("PAF_MTH_INDX12_APPLD_CHG_PERC", 0, FieldType.Number, "0.000000", "F:APPLD_CHG_MTH12"))
                .Add(New FieldDef("PAF_EOP12_DATE", "CURR_ANNIV_DATE"))
                .Add(New FieldDef("PAF_ORIG_DEPST_DATE", "ORIG_DEPST_DATE"))

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
        Public ReadOnly Property PAF_FUND_MKTG_NAME As FieldDef
            Get
                Return Fields(FieldList.PAF_FUND_MKTG_NAME)
            End Get
        End Property
        Public ReadOnly Property PAF_PART_RATE As FieldDef
            Get
                Return Fields(FieldList.PAF_PART_RATE)
            End Get
        End Property
        Public ReadOnly Property PAF_CAP_RATE As FieldDef
            Get
                Return Fields(FieldList.PAF_CAP_RATE)
            End Get
        End Property
        Public ReadOnly Property PAF_SPREAD_RATE As FieldDef
            Get
                Return Fields(FieldList.PAF_SPREAD_RATE)
            End Get
        End Property
        Public ReadOnly Property PAF_INTEREST_RATE As FieldDef
            Get
                Return Fields(FieldList.PAF_INTEREST_RATE)
            End Get
        End Property
        Public ReadOnly Property PAF_INDX_BEGIN_BAL As FieldDef
            Get
                Return Fields(FieldList.PAF_INDX_BEGIN_BAL)
            End Get
        End Property
        Public ReadOnly Property PAF_INDX_GROWTH_RATE As FieldDef
            Get
                Return Fields(FieldList.PAF_INDX_GROWTH_RATE)
            End Get
        End Property
        Public ReadOnly Property PAF_INDX_CREDIT_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_INDX_CREDIT_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP1_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP1_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP1_VAL As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP1_VAL)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX1_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX1_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX1_APPLD_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX1_APPLD_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_EOP1_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_EOP1_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP2_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP2_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP2_VAL As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP2_VAL)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX2_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX2_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX2_APPLD_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX2_APPLD_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_EOP2_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_EOP2_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP3_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP3_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP3_VAL As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP1_VAL)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX3_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX3_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX3_APPLD_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX3_APPLD_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_EOP3_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_EOP3_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP4_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP4_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP4_VAL As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP4_VAL)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX4_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX4_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX4_APPLD_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX4_APPLD_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_EOP4_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_EOP4_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP5_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP5_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP5_VAL As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP5_VAL)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX5_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX5_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX5_APPLD_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX5_APPLD_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_EOP5_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_EOP5_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP6_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP6_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP6_VAL As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP6_VAL)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX6_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX6_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX6_APPLD_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX6_APPLD_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_EOP6_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP1_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP7_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP7_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP7_VAL As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP7_VAL)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX7_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX7_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX7_APPLD_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX7_APPLD_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_EOP7_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_EOP7_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP8_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP8_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP8_VAL As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP8_VAL)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX8_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX8_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX8_APPLD_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX8_APPLD_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_EOP8_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_EOP8_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP9_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP9_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP9_VAL As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP9_VAL)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX9_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX9_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX9_APPLD_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX9_APPLD_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_EOP9_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_EOP9_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP10_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP10_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP10_VAL As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP10_VAL)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX10_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX10_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX10_APPLD_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX10_APPLD_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_EOP10_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_EOP10_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP11_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_EOP11_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP11_VAL As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP11_VAL)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX11_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX11_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX11_APPLD_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX11_APPLD_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_EOP11_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_EOP11_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP12_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP12_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_BOP12_VAL As FieldDef
            Get
                Return Fields(FieldList.PAF_BOP12_VAL)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX12_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX12_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_MTH_INDX12_APPLD_CHG_PERC As FieldDef
            Get
                Return Fields(FieldList.PAF_MTH_INDX12_APPLD_CHG_PERC)
            End Get
        End Property
        Public ReadOnly Property PAF_EOP12_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_EOP12_DATE)
            End Get
        End Property
        Public ReadOnly Property PAF_ORIG_DEPST_DATE As FieldDef
            Get
                Return Fields(FieldList.PAF_ORIG_DEPST_DATE)
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
                .Add(New FieldDef("TXH_TXN_TOTAL_AMT", "F:TOTAL_TXN_AMT"))

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
            TFH_FUND_MKTG_NAME
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
                .Add(New FieldDef("TFH_FUND_MKTG_NAME", "MRKT_FUND_NAME"))
                .Add(New FieldDef("TFH_FUND_AMT", "F:FUND_TXN_AMT"))

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
        Public ReadOnly Property TFH_FUND_MKTG_NAME As FieldDef
            Get
                Return Fields(FieldList.TFH_FUND_MKTG_NAME)
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





#End Region

End Namespace
