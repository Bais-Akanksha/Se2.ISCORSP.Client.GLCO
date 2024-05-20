Imports Se2.ISI.Base.Presentation

Namespace Se2.ISCORSP.Client.GLCO.AnnualRMDLetter.Records


#Region " AnnualRMDLetter "

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
            POL_CURR_YR
            POL_PREV_YR
            POL_NEXT_YR
            POL_FAIR_MKT_VAL


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
                .Add(New FieldDef("POL_QUAL_DESC", "F:QUAL_DESC"))
                .Add(New FieldDef("POL_COMP_NAME", "CO_NAME"))
                .Add(New FieldDef("POL_CYCLE_DATE", "", FieldType.Date, "yyyy-MM-dd", "CYCLEDATE"))
                .Add(New FieldDef("POL_SERVICE_NAME", "S:Letters"))
                .Add(New FieldDef("POL_SERVICE_DESC", "S:Annual Required Minimum Distribution"))
                .Add(New FieldDef("POL_SOURCE", "S:SE2"))
                .Add(New FieldDef("POL_STATUS", "F:ACCOUNT_STATUS"))
                .Add(New FieldDef("POL_POL_NUM", "POL_NUM"))
                .Add(New FieldDef("POL_PRDCT_COMP", "PRODUCT_CO"))
                .Add(New FieldDef("POL_LOB", "F:LINE_OF_BUSINESS"))
                .Add(New FieldDef("POL_PRCSG_COMP", "PRCSSNG_CO"))
                .Add(New FieldDef("POL_CURR_YR", "F:GET_CURR_YR"))
                .Add(New FieldDef("POL_PREV_YR", "F:GET_PREV_YR"))
                .Add(New FieldDef("POL_NEXT_YR", "F:GET_NEXT_YR"))
                .Add(New FieldDef("POL_FAIR_MKT_VAL", "PRIOR_YEAR_ACCT_VAL"))

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
        Public ReadOnly Property POL_CURR_YR As FieldDef
            Get
                Return Fields(FieldList.POL_CURR_YR)
            End Get
        End Property
        Public ReadOnly Property POL_PREV_YR As FieldDef
            Get
                Return Fields(FieldList.POL_PREV_YR)
            End Get
        End Property
        Public ReadOnly Property POL_NEXT_YR As FieldDef
            Get
                Return Fields(FieldList.POL_NEXT_YR)
            End Get
        End Property
        Public ReadOnly Property POL_FAIR_MKT_VAL As FieldDef
            Get
                Return Fields(FieldList.POL_FAIR_MKT_VAL)
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
            ROL_DOB

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
                .Add(New FieldDef("ROL_EMAIL", "EMAIL"))
                .Add(New FieldDef("ROL_PHONE_NUM", "F:PHONE_NUMBER"))
                .Add(New FieldDef("ROL_PHONE_TYPE", "F:PHONE_TYPE"))
                .Add(New FieldDef("ROL_EXTERNAL_ID", "EXT_ID"))
                .Add(New FieldDef("ROL_MASTER_NUM", "MASTER_NUMBER"))
                .Add(New FieldDef("ROL_TAX_ID", "TAX_ID"))
                .Add(New FieldDef("ROL_DELIVERY_FLAG", "F:MAIL_FLAG"))
                .Add(New FieldDef("ROL_DELIVERY_DESC", "F:MAIL_TYPE_IND"))
                .Add(New FieldDef("ROL_ROLE_ID", "ROLE_ID"))
                .Add(New FieldDef("ROL_DOB", "", FieldType.Date, "yyyy-MM-dd", "DOB"))

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
        Public ReadOnly Property ROL_DOB As FieldDef
            Get
                Return Fields(FieldList.ROL_DOB)
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
            PVAL_RESV_AMT
            PVAL_IRS_ULT
            PVAL_RMD_AMT


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
                .Add(New FieldDef("PVAL_RESV_AMT", "F:GET_RMD_RESV_AMT"))
                .Add(New FieldDef("PVAL_IRS_ULT", 0, FieldType.Number, "0.00", "IRS_ULT"))
                .Add(New FieldDef("PVAL_RMD_AMT", 0, FieldType.Number, "0.00", "F:GET_ANNUAL_RMD"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property PVAL_CONT As FieldDef
            Get
                Return Fields(FieldList.PVAL_CONT)
            End Get
        End Property
        Public ReadOnly Property PVAL_RESV_AMT As FieldDef
            Get
                Return Fields(FieldList.PVAL_RESV_AMT)
            End Get
        End Property
        Public ReadOnly Property PVAL_IRS_ULT As FieldDef
            Get
                Return Fields(FieldList.PVAL_IRS_ULT)
            End Get
        End Property
        Public ReadOnly Property PVAL_RMD_AMT As FieldDef
            Get
                Return Fields(FieldList.PVAL_RMD_AMT)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region

    End Class

#End Region


#End Region

End Namespace
