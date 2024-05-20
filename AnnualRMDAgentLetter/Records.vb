Imports Se2.ISI.Base.Presentation

Namespace Se2.ISCORSP.Client.GLCO.AnnualRMDAgentLetter.Records


#Region " AnnualRMDAgentLetter "

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

#Region " InvestAdvisors "

    <Serializable()>
    Public Class InvestAdvisors
        Inherits DTL

#Region " Constructors "

        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "INVESTADVISORS"
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
#Region " InvestAdvisor "
    Public Class InvestAdvisor
        Inherits DTL

        Private Shadows Enum FieldList
            IVA_COMP_NAME
            IVA_CYCLE_DATE
            IVA_SERVICE_NAME
            IVA_SERVICE_DESC
            IVA_SOURCE
            IVA_FULL_NAME
            IVA_ADDR_LINE1
            IVA_ADDR_LINE2
            IVA_ADDR_LINE3
            'IVA_ADDR_LINE4
            IVA_CITY
            IVA_STATE
            IVA_ZIP
            IVA_PRDCT_COMP
            IVA_PRCSG_COMP
            IVA_TAX_ID
            IVA_EXTERNAL_ID
            IVA_MASTER_NUM
            IVA_TRACKING_ID
            IVA_DOC_TYPE
            IVA_IMO_IND
            IVA_CURR_YR
            IVA_PREV_YR
            IVA_NEXT_YR
            'IVA_RMD_AGE
            'IVA_RMD_BIRTH_YEAR
            IVA_ROLE_ID
            IVA_SYS_CODE
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "INVESTADVISOR"
            Me.NodeParent = "INVESTADVISORS"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("IVA_COMP_NAME", "COMPANY_NAME"))
                .Add(New FieldDef("IVA_CYCLE_DATE", "", FieldType.Date, "yyyy-MM-dd", "CYCLEDATE"))
                .Add(New FieldDef("IVA_SERVICE_NAME", "S:Letters"))
                .Add(New FieldDef("IVA_SERVICE_DESC", "S:Annual Required Minimum Distribution"))
                .Add(New FieldDef("IVA_SOURCE", "S:SE2"))
                .Add(New FieldDef("IVA_FULL_NAME", "F:IVA_FULL_NAME"))
                .Add(New FieldDef("IVA_ADDR_LINE1", "ADDRESS1"))
                .Add(New FieldDef("IVA_ADDR_LINE2", "ADDRESS2"))
                .Add(New FieldDef("IVA_ADDR_LINE3", "ADDRESS3"))
                '.Add(New FieldDef("IVA_ADDR_LINE4", "F:ACCOUNT_STATUS"))
                .Add(New FieldDef("IVA_CITY", "CITY"))
                .Add(New FieldDef("IVA_STATE", "STATE_CODE"))
                .Add(New FieldDef("IVA_ZIP", "F:FULL_ZIP_CODE"))
                .Add(New FieldDef("IVA_PRDCT_COMP", "PRODUCT_CODE_ID"))
                .Add(New FieldDef("IVA_PRCSG_COMP", "PRCSSNG_CODE_ID"))
                .Add(New FieldDef("IVA_TAX_ID", "TAX_ID"))
                .Add(New FieldDef("IVA_EXTERNAL_ID", "EXT_ID"))
                .Add(New FieldDef("IVA_MASTER_NUM", "MASTER_NUM"))
                .Add(New FieldDef("IVA_TRACKING_ID", "F:TrackingID"))
                .Add(New FieldDef("IVA_DOC_TYPE", "S:ANRMD"))
                .Add(New FieldDef("IVA_IMO_IND", "F:MASTER_NUM"))
                .Add(New FieldDef("IVA_CURR_YR", "F:Get_CurrYear"))
                .Add(New FieldDef("IVA_PREV_YR", "F:Get_PrevYear"))
                .Add(New FieldDef("IVA_NEXT_YR", "F:Get_NextYear"))
                '.Add(New FieldDef("IVA_RMD_AGE", "F:TrackingID"))
                '.Add(New FieldDef("IVA_RMD_BIRTH_YEAR", "F:TrackingID"))
                .Add(New FieldDef("IVA_ROLE_ID", "ROLE_ID"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property IVA_COMP_NAME As FieldDef
            Get
                Return Fields(FieldList.IVA_COMP_NAME)
            End Get
        End Property
        Public ReadOnly Property IVA_CYCLE_DATE As FieldDef
            Get
                Return Fields(FieldList.IVA_CYCLE_DATE)
            End Get
        End Property
        Public ReadOnly Property IVA_SERVICE_NAME As FieldDef
            Get
                Return Fields(FieldList.IVA_SERVICE_NAME)
            End Get
        End Property
        Public ReadOnly Property IVA_SERVICE_DESC As FieldDef
            Get
                Return Fields(FieldList.IVA_SERVICE_DESC)
            End Get
        End Property
        Public ReadOnly Property IVA_SOURCE As FieldDef
            Get
                Return Fields(FieldList.IVA_SOURCE)
            End Get
        End Property
        Public ReadOnly Property IVA_FULL_NAME As FieldDef
            Get
                Return Fields(FieldList.IVA_FULL_NAME)
            End Get
        End Property
        Public ReadOnly Property IVA_ADDR_LINE1 As FieldDef
            Get
                Return Fields(FieldList.IVA_ADDR_LINE1)
            End Get
        End Property
        Public ReadOnly Property IVA_ADDR_LINE2 As FieldDef
            Get
                Return Fields(FieldList.IVA_ADDR_LINE2)
            End Get
        End Property
        Public ReadOnly Property IVA_ADDR_LINE3 As FieldDef
            Get
                Return Fields(FieldList.IVA_ADDR_LINE3)
            End Get
        End Property
        'Public ReadOnly Property IVA_ADDR_LINE4 As FieldDef
        '    Get
        '        Return Fields(FieldList.IVA_ADDR_LINE4)
        '    End Get
        'End Property
        Public ReadOnly Property IVA_CITY As FieldDef
            Get
                Return Fields(FieldList.IVA_CITY)
            End Get
        End Property
        Public ReadOnly Property IVA_STATE As FieldDef
            Get
                Return Fields(FieldList.IVA_STATE)
            End Get
        End Property
        Public ReadOnly Property IVA_ZIP As FieldDef
            Get
                Return Fields(FieldList.IVA_ZIP)
            End Get
        End Property
        Public ReadOnly Property IVA_PRDCT_COMP As FieldDef
            Get
                Return Fields(FieldList.IVA_PRDCT_COMP)
            End Get
        End Property
        Public ReadOnly Property IVA_TAX_ID As FieldDef
            Get
                Return Fields(FieldList.IVA_TAX_ID)
            End Get
        End Property
        Public ReadOnly Property IVA_EXTERNAL_ID As FieldDef
            Get
                Return Fields(FieldList.IVA_EXTERNAL_ID)
            End Get
        End Property
        Public ReadOnly Property IVA_MASTER_NUM As FieldDef
            Get
                Return Fields(FieldList.IVA_MASTER_NUM)
            End Get
        End Property
        Public ReadOnly Property IVA_TRACKING_ID As FieldDef
            Get
                Return Fields(FieldList.IVA_TRACKING_ID)
            End Get
        End Property
        Public ReadOnly Property IVA_DOC_TYPE As FieldDef
            Get
                Return Fields(FieldList.IVA_DOC_TYPE)
            End Get
        End Property
        Public ReadOnly Property IVA_IMO_IND As FieldDef
            Get
                Return Fields(FieldList.IVA_IMO_IND)
            End Get
        End Property
        Public ReadOnly Property IVA_CURR_YR As FieldDef
            Get
                Return Fields(FieldList.IVA_CURR_YR)
            End Get
        End Property
        Public ReadOnly Property IVA_PREV_YR As FieldDef
            Get
                Return Fields(FieldList.IVA_PREV_YR)
            End Get
        End Property
        Public ReadOnly Property IVA_NEXT_YR As FieldDef
            Get
                Return Fields(FieldList.IVA_NEXT_YR)
            End Get
        End Property
        'Public ReadOnly Property IVA_RMD_AGE As FieldDef
        '    Get
        '        Return Fields(FieldList.IVA_RMD_AGE)
        '    End Get
        'End Property
        'Public ReadOnly Property IVA_RMD_BIRTH_YEAR As FieldDef
        '    Get
        '        Return Fields(FieldList.IVA_RMD_BIRTH_YEAR)
        '    End Get
        'End Property

        Public ReadOnly Property IVA_ROLE_ID As FieldDef
            Get
                Return Fields(FieldList.IVA_ROLE_ID)
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
            Me.NodeName = "CARRIERINFORMATION"
            Me.NodeParent = "INVESTADVISOR"
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

    Public Class CARRIER
        Inherits DTL

        Private Shadows Enum FieldList
            'CARRIER_CONT
            CARRIER_CARRIER_NAME
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
            Me.NodeName = "CARRIER"
            Me.NodeParent = "CARRIERINFORMATION"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                '.Add(New FieldDef("CARRIER_CONT", "CONT"))
                .Add(New FieldDef("CARRIER_CARRIER_NAME", "CO_NAME"))
                .Add(New FieldDef("CARRIER_ADDR_LINE1", "ADDR_LINE_1"))
                .Add(New FieldDef("CARRIER_ADDR_LINE2", "ADDR_LINE_2"))
                .Add(New FieldDef("CARRIER_ADDR_LINE3", "ADDR_LINE_3"))
                .Add(New FieldDef("CARRIER_CITY", "CITY"))
                .Add(New FieldDef("CARRIER_STATE", "STATE"))
                .Add(New FieldDef("CARRIER_ZIP", "ZIP_CODE"))
                .Add(New FieldDef("CARRIER_WEB_ADDR", "WEB_ADDRESS"))
                .Add(New FieldDef("CARRIER_PHONE_NUM", "UNFRMTTD_PHONE"))
                .Add(New FieldDef("CARRIER_FAX_NUM", "FAX_NUM"))
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
        'Public ReadOnly Property CARRIER_CONT As FieldDef
        '    Get
        '        Return Fields(FieldList.CARRIER_CONT)
        '    End Get
        'End Property
        Public ReadOnly Property CARRIER_CARRIER_NAME As FieldDef
            Get
                Return Fields(FieldList.CARRIER_CARRIER_NAME)
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


#Region " Clients  "
    <Serializable()>
    Public Class Clients
        Inherits DTL

#Region " Constructors "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "CLIENTS"
            Me.NodeParent = "CARRIER"
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
#Region " Client "

    Public Class Client
        Inherits DTL

        Private Shadows Enum FieldList
            CLT_CONT
            CLT_PLN_CODE
            CLT_PRODUCT
            'CLT_PRDCT_MKTG_NAME
            CLT_QUAL_DESC
            CLT_STATUS
            CLT_POL_NUM
            CLT_FULL_NAME
            CLT_RESV_AMT
            'CLT_IRS_ULT
            'CLT_RMD_AMT
            CLT_FAIR_MKT_VAL
            CLT_SSW_IND
            CLT_DOB
            CLT_WATCHLIST
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "CLIENT"
            Me.NodeParent = "CLIENTS"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("CLT_CONT", "CONT"))
                .Add(New FieldDef("CLT_PLN_CODE", "PLN_CODE"))
                .Add(New FieldDef("CLT_PRODUCT", "PRD_DESC"))
                '.Add(New FieldDef("CLT_PRDCT_MKTG_NAME", "CONT"))
                .Add(New FieldDef("CLT_QUAL_DESC", "QUAL_DESC"))
                .Add(New FieldDef("CLT_STATUS", "STATUS"))
                .Add(New FieldDef("CLT_POL_NUM", "POLNUM"))
                .Add(New FieldDef("CLT_FULL_NAME", "F:CLIENT_FULL_NAME"))
                '.Add(New FieldDef("CLT_RESV_AMT", "DP_RMD_RESV_AMT"))
                .Add(New FieldDef("CLT_RESV_AMT", 0, FieldType.Number, "0.00", "DP_RMD_RESV_AMT"))
                '.Add(New FieldDef("CLT_IRS_ULT", ""))
                '.Add(New FieldDef("CLT_RMD_AMT", ""))
                '.Add(New FieldDef("CLT_FAIR_MKT_VAL", "PRIOR_YEAR_ACCT_VAL"))
                .Add(New FieldDef("CLT_FAIR_MKT_VAL", 0, FieldType.Number, "0.00", "PRIOR_YEAR_ACCT_VAL"))
                .Add(New FieldDef("CLT_SSW_IND", "F:SSW_IND"))
                .Add(New FieldDef("CLT_DOB", "DOB"))
                .Add(New FieldDef("CLT_WATCHLIST", "F:"))

            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property CLT_CONT As FieldDef
            Get
                Return Fields(FieldList.CLT_CONT)
            End Get
        End Property
        Public ReadOnly Property CLT_PLN_CODE As FieldDef
            Get
                Return Fields(FieldList.CLT_PLN_CODE)
            End Get
        End Property
        Public ReadOnly Property CLT_PRODUCT As FieldDef
            Get
                Return Fields(FieldList.CLT_PRODUCT)
            End Get
        End Property

        'Public ReadOnly Property CLT_PRDCT_MKTG_NAME As FieldDef
        '    Get
        '        Return Fields(FieldList.CLT_PRDCT_MKTG_NAME)
        '    End Get
        'End Property
        Public ReadOnly Property CLT_QUAL_DESC As FieldDef
            Get
                Return Fields(FieldList.CLT_QUAL_DESC)
            End Get
        End Property
        Public ReadOnly Property CLT_STATUS As FieldDef
            Get
                Return Fields(FieldList.CLT_STATUS)
            End Get
        End Property
        Public ReadOnly Property CLT_POL_NUM As FieldDef
            Get
                Return Fields(FieldList.CLT_POL_NUM)
            End Get
        End Property
        Public ReadOnly Property CLT_FULL_NAME As FieldDef
            Get
                Return Fields(FieldList.CLT_FULL_NAME)
            End Get
        End Property
        Public ReadOnly Property CLT_RESV_AMT As FieldDef
            Get
                Return Fields(FieldList.CLT_RESV_AMT)
            End Get
        End Property
        'Public ReadOnly Property CLT_IRS_ULT As FieldDef
        '    Get
        '        Return Fields(FieldList.CLT_IRS_ULT)
        '    End Get
        'End Property
        'Public ReadOnly Property CLT_RMD_AMT As FieldDef
        '    Get
        '        Return Fields(FieldList.CLT_RMD_AMT)
        '    End Get
        'End Property
        Public ReadOnly Property CLT_FAIR_MKT_VAL As FieldDef
            Get
                Return Fields(FieldList.CLT_FAIR_MKT_VAL)
            End Get
        End Property
        'Public ReadOnly Property CLT_SSW_IND As FieldDef
        '    Get
        '        Return Fields(FieldList.CLT_SSW_IND)
        '    End Get
        'End Property
        Public ReadOnly Property CLT_DOB As FieldDef
            Get
                Return Fields(FieldList.CLT_DOB)
            End Get
        End Property
        'Public ReadOnly Property CLT_WATCHLIST As FieldDef
        '    Get
        '        Return Fields(FieldList.CLT_WATCHLIST)
        '    End Get
        'End Property

#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#End Region

End Namespace
