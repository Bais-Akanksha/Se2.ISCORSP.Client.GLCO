Imports Se2.ISI.Base.Presentation
Namespace Se2.ISCORSP.Client.GLCO.FIAPolicyPage.Records


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

#Region " HEADER "

    <Serializable()>
    Public Class HEADER
        Inherits RecordDef


        Private Shadows Enum FieldList
            RecordIdent
            File
            CycleDate
            ProcessingCo
        End Enum


#Region " CONSTRUCTORS "

        Public Sub New()

            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.HDR
            Delimiter = ","c
            FieldPrefix = """"
            FieldSuffix = """"
            Length = -999
            Terminator = vbCrLf
            Initialize()

        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("RecordIdent", "S:HEADER"))
            Fields.Add(New FieldDef("File", "F:GetFileName"))
            Fields.Add(New FieldDef("CycleDate", #1/1/1900#, FieldType.Date, "yyyyMMdd", "F:GetCycleDate"))
            Fields.Add(New FieldDef("ProcessingCo", "S:SE2"))
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property RecordIdent() As FieldDef
            Get
                Return Fields(FieldList.RecordIdent)
            End Get
        End Property
        Public ReadOnly Property File() As FieldDef
            Get
                Return Fields(FieldList.File)
            End Get
        End Property
        Public ReadOnly Property CycleDate() As FieldDef
            Get
                Return Fields(FieldList.CycleDate)
            End Get
        End Property
        Public ReadOnly Property ProcessingCo() As FieldDef
            Get
                Return Fields(FieldList.ProcessingCo)
            End Get
        End Property

#End Region

#Region " METHODS "


#End Region


    End Class

#End Region

#Region " COLUMN HEADERS "

    <Serializable()>
    Public Class COLUMNHEADERS
        Inherits RecordDef


        Private Shadows Enum FieldList
            ColumnHeaders
        End Enum


#Region " CONSTRUCTORS "

        Public Sub New()

            MyBase.New(PresentationFormat.Fixed)
            Type = RecordType.HDR
            FieldPrefix = String.Empty
            FieldSuffix = String.Empty
            Length = -999
            Terminator = vbCrLf
            Initialize()

        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("ColumnHeaders", "F:GetColumnHeaders"))
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property ColumnHeaders() As FieldDef
            Get
                Return Fields(FieldList.ColumnHeaders)
            End Get
        End Property

#End Region

#Region " METHODS "


#End Region


    End Class

#End Region

#Region " TRAILER "

    <Serializable()>
    Public Class TRAILER
        Inherits RecordDef


        Private Shadows Enum FieldList
            TrailerID
            RecordCount
        End Enum


#Region " CONSTRUCTORS "

        Public Sub New()

            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.TRL
            Delimiter = ","c
            FieldPrefix = """"
            FieldSuffix = """"
            Length = -999
            Terminator = vbCrLf
            Initialize()

        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("TrailerID", "S:TRAILER"))
            Fields.Add(New FieldDef("RecordCount"))
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property TrailerID() As FieldDef
            Get
                Return Fields(FieldList.TrailerID)
            End Get
        End Property
        Public ReadOnly Property RecordCount() As FieldDef
            Get
                Return Fields(FieldList.RecordCount)
            End Get
        End Property

#End Region

#Region " METHODS "


#End Region


    End Class

#End Region

#Region " RECKEY "

    <Serializable()>
    Public Class RECKEY
        Inherits DTL

#Region " FIELD ARRAY ENUM "

#End Region

#Region " CONSTRUCTORS "

        Public Sub New()

            MyBase.New()
            Initialize()

        End Sub

        Private Sub Initialize()

            Fields = New List(Of FieldDef)
        End Sub
#End Region

#Region " PROPERTIES "

#End Region


    End Class


#End Region

#Region " Policies "

    <Serializable()>
    Public Class POLICIES
        Inherits DTL

#Region " Constructors "

        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "POLICIES"
            Me.NodeParent = "Se2PolicyPages"
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


    <Serializable()>
    Public Class POLICY
        Inherits DTL

#Region " Constructors "

        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "POLICY"
            Me.NodeParent = "POLICIES"

        End Sub

        Private Shadows Enum FieldList
            REC_TYPE
            POL_CONT
            POL_POL_NUM
            POL_COMPANY
            POL_SOURCE
            POL_MAIL_TYPE
            POL_PRDC_CODE
            POL_PRODUCT
            POL_PRODUCT_TYPE
            POL_QUAL_CODE
            POL_QUAL_PLAN_TYPE
            POL_STATUS
            POL_ISSUE_DATE
            POL_ISSUE_STATE
            POL_PREM_AMOUNT
            POL_PLAN_MOD_PREM
            POL_PREM_MODE
            POL_DB_DESC
            POL_BASIS_PT
            POL_EXCH_TYPE
            POL_ANN_DESC
            POL_MIN_MAT_DATE
            POL_MAX_MAT_DATE
            POL_PAYOUT_AMT
            POL_PAYOUT_FREQ
            POL_PAYOUT_PERIOD
            POL_PAYOUT_START
            POL_PAYOUT_END
            POL_FIXED_AMT
            POL_VAR_AMT
            POL_GTD_RATE
            POL_GTD_PERIOD
            POL_PRIM_RATE_CLASS
            POL_JT_RATE_CLASS
            POL_PRIM_FLATEX
            POL_JT_FLATEX
            POL_YEAR1_RATE
            POL_YEAR2_RATE
            POL_MVA_INDEX_RATE
            POL_MVA_INDEX_VAL
            POL_UDV1
            POL_NEXT_ANNIV_DATE
            POL_BAIL_WIND
            POL_SURR_PERIOD
            POL_FIXED_RATE_BAND1
            POL_FIXED_RATE_BAND2
            POL_FIXED_RATE_BAND3
            POL_CAP_RATE_BAND1
            POL_CAP_RATE_BAND2
            POL_CAP_RATE_BAND3
            POL_MARGIN_RATE_BAND1
            POL_MARGIN_RATE_BAND2
            POL_MARGIN_RATE_BAND3
            POL_TRACKING_ID

            ''LGP-16536
            POL_PREM_BONUS_PERC
            POL_RIDER_FEE_PERC
            POL_INCR_PAY  ''INCREASING_PAYOUT_FACTOR
            POL_GLWB_WAIT_PRD


        End Enum

        Private Sub Initialize()
            With Fields
                .Add(New FieldDef("REC_TYPE", "F:GET_REC_TYPE"))
                .Add(New FieldDef("POL_CONT", "CN_CONT"))
                .Add(New FieldDef("POL_POL_NUM", "CN_POL_NUM"))
                .Add(New FieldDef("POL_COMPANY", "CN_COMPANY_NAME"))
                .Add(New FieldDef("POL_SOURCE", " "c, FieldType.String, "", "S:Se2"))
                .Add(New FieldDef("POL_MAIL_TYPE", "1", FieldType.String, Format.ToString, "POL_MAIL_TYPE"))
                .Add(New FieldDef("POL_PRDC_CODE", "CN_PLN_CODE"))
                .Add(New FieldDef("POL_PRODUCT", "CN_PRD_DESC"))
                .Add(New FieldDef("POL_PRODUCT_TYPE", "CN_PLN_TYPE"))
                .Add(New FieldDef("POL_QUAL_CODE", "CN_QUAL_DESC"))
                .Add(New FieldDef("POL_QUAL_PLAN_TYPE", "CN_TAX_CATEG_DESC"))
                '.Add(New FieldDef("POL_STATUS", "CN_STATUS"))
                .Add(New FieldDef("POL_STATUS", "F:Get_Policy_Status")) ' New
                .Add(New FieldDef("POL_ISSUE_DATE", #1/1/1900#, FieldType.Date, DateFmt, "CN_ISSUE_DATE"))
                .Add(New FieldDef("POL_ISSUE_STATE", "CN_ISSUE_STATE"))
                .Add(New FieldDef("POL_PREM_AMOUNT", 0, FieldType.Number, "0.00", "CN_PREM"))
                .Add(New FieldDef("POL_PLAN_MOD_PREM", 0, FieldType.Number, "0.00", "S:0.00"))
                .Add(New FieldDef("POL_PREM_MODE", "CN_PREM_MODE"))
                .Add(New FieldDef("POL_DB_DESC", "CN_DB_DESC"))
                .Add(New FieldDef("POL_BASIS_PT", 0, FieldType.Number, "000", "CN_BASIS_POINT_TOTAL"))
                .Add(New FieldDef("POL_EXCH_TYPE", "EX_EXCHANGE_TYPE"))
                .Add(New FieldDef("POL_ANN_DESC", "CN_PAYOUT_OPT"))
                .Add(New FieldDef("POL_MIN_MAT_DATE", #1/1/1900#, FieldType.Date, DateFmt, "F:Get_Minimum_Maturity_Date"))
                .Add(New FieldDef("POL_MAX_MAT_DATE", #1/1/1900#, FieldType.Date, DateFmt, "CN_MAT_DATE"))
                .Add(New FieldDef("POL_PAYOUT_AMT", 0, FieldType.Number, "0.00", "F:Get_Current_Payout_Amount"))
                .Add(New FieldDef("POL_PAYOUT_FREQ", "PA_PAY_MODE"))
                .Add(New FieldDef("POL_PAYOUT_PERIOD", "PA_GNTY_PERD"))
                .Add(New FieldDef("POL_PAYOUT_START", #1/1/1900#, FieldType.Date, DateFmt, "CN_FIRST_PAYOUT_PMT_DATE"))
                .Add(New FieldDef("POL_PAYOUT_END", "#1/1/1900#", FieldType.Date, DateFmt, "CN_PAYOUT_STOP_DATE"))
                .Add(New FieldDef("POL_FIXED_AMT", 0, FieldType.Number, "0.00", "CN_FIXED_PAY_AMT"))
                .Add(New FieldDef("POL_VAR_AMT", 0, FieldType.Number, "0.00", "CN_VAR_PAY_AMT"))
                .Add(New FieldDef("POL_GTD_RATE", 0, FieldType.Number, "0.00", "CN_MIN_GUAR_RATE"))
                .Add(New FieldDef("POL_GTD_PERIOD", 0, FieldType.Number, "0.00", "CN_GNTY_PERD"))
                .Add(New FieldDef("POL_PRIM_RATE_CLASS", "CN_PRIM_RT_CLASS"))
                .Add(New FieldDef("POL_JT_RATE_CLASS", "CN_JT_RT_CLASS"))
                .Add(New FieldDef("POL_PRIM_FLATEX", 0, FieldType.Number, "0.00", "CN_PRIM_FLATEX"))
                .Add(New FieldDef("POL_JT_FLATEX", 0, FieldType.Number, "0.00", "CN_JT_FLATEX"))
                .Add(New FieldDef("POL_YEAR1_RATE", 0, FieldType.Number, "0.00", "YEAR1_RATE"))
                .Add(New FieldDef("POL_YEAR2_RATE", 0, FieldType.Number, "0.00", "YEAR2_RATE"))
                .Add(New FieldDef("POL_MVA_INDEX_RATE", 0, FieldType.Number, "0.00", "MVA_INDEX_RATE"))
                .Add(New FieldDef("POL_MVA_INDEX_VAL", 0, FieldType.Number, "0.00", "MVA_INDEX_VAL"))
                .Add(New FieldDef("POL_UDV1", "UDV1"))
                .Add(New FieldDef("POL_NEXT_ANNIV_DATE", #1/1/1900#, FieldType.Date, DateFmt, "NEXT_ANNIV_DATE"))
                .Add(New FieldDef("POL_BAIL_WIND", "S:0.00"))
                .Add(New FieldDef("POL_SURR_PERIOD", "F:Get_VARIATION_DESC"))
                .Add(New FieldDef("POL_FIXED_RATE_BAND1", 0, FieldType.Number, "0.00", "FIXED_RATE_BAND1"))
                .Add(New FieldDef("POL_FIXED_RATE_BAND2", 0, FieldType.Number, "0.00", "FIXED_RATE_BAND2"))
                .Add(New FieldDef("POL_FIXED_RATE_BAND3", 0, FieldType.Number, "0.00", "FIXED_RATE_BAND3"))
                .Add(New FieldDef("POL_CAP_RATE_BAND1", 0, FieldType.Number, "0.00", "CAP_RATE_BAND1"))
                .Add(New FieldDef("POL_CAP_RATE_BAND2", 0, FieldType.Number, "0.00", "CAP_RATE_BAND2"))
                .Add(New FieldDef("POL_CAP_RATE_BAND3", 0, FieldType.Number, "0.00", "CAP_RATE_BAND3"))
                .Add(New FieldDef("POL_MARGIN_RATE_BAND1", 0, FieldType.Number, "0.00", "MARGIN_RATE_BAND1"))
                .Add(New FieldDef("POL_MARGIN_RATE_BAND2", 0, FieldType.Number, "0.00", "MARGIN_RATE_BAND2"))
                .Add(New FieldDef("POL_MARGIN_RATE_BAND3", 0, FieldType.Number, "0.00", "MARGIN_RATE_BAND3"))
                .Add(New FieldDef("POL_TRACKING_ID", "F:TrackingID"))
                .Add(New FieldDef("POL_AP_IMAGE_PATH", "F:Get_IMAGE_Path"))
                .Add(New FieldDef("POL_AP_IMAGE", "F:Get_CONT_IMAGE"))

                ''''LGP-16536
                .Add(New FieldDef("POL_PREM_BONUS_PERC", 0, FieldType.Number, "0.00", "PREM_BONUS_PERC"))
                .Add(New FieldDef("POL_RIDER_FEE_PERC", 0, FieldType.Number, "0.00", "RIDER_FEE_PERC"))
                .Add(New FieldDef("POL_INCR_PAY", 0, FieldType.Number, "0.00", "INCREASING_PAYOUT_FACTOR"))
                .Add(New FieldDef("POL_GLWB_WAIT_PRD", "GLWB_WAIT_PERIOD"))


            End With
        End Sub
#End Region

#Region " Properties "

        Public ReadOnly Property REC_TYPE As FieldDef
            Get
                Return Fields(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property POL_CONT As FieldDef
            Get
                Return Fields(FieldList.POL_CONT)
            End Get
        End Property
        Public ReadOnly Property POL_POL_NUM As FieldDef
            Get
                Return Fields(FieldList.POL_POL_NUM)
            End Get
        End Property
        Public ReadOnly Property POL_COMPANY As FieldDef
            Get
                Return Fields(FieldList.POL_COMPANY)
            End Get
        End Property
        Public ReadOnly Property POL_SOURCE As FieldDef
            Get
                Return Fields(FieldList.POL_SOURCE)
            End Get
        End Property
        Public ReadOnly Property POL_MAIL_TYPE As FieldDef
            Get
                Return Fields(FieldList.POL_MAIL_TYPE)
            End Get
        End Property
        Public ReadOnly Property POL_PRDC_CODE As FieldDef
            Get
                Return Fields(FieldList.POL_PRDC_CODE)
            End Get
        End Property
        Public ReadOnly Property POL_PRODUCT As FieldDef
            Get
                Return Fields(FieldList.POL_PRODUCT)
            End Get
        End Property
        Public ReadOnly Property POL_PRODUCT_TYPE As FieldDef
            Get
                Return Fields(FieldList.POL_PRODUCT_TYPE)
            End Get
        End Property
        Public ReadOnly Property POL_QUAL_CODE As FieldDef
            Get
                Return Fields(FieldList.POL_QUAL_CODE)
            End Get
        End Property
        Public ReadOnly Property POL_QUAL_PLAN_TYPE As FieldDef
            Get
                Return Fields(FieldList.POL_QUAL_PLAN_TYPE)
            End Get
        End Property
        Public ReadOnly Property POL_STATUS As FieldDef
            Get
                Return Fields(FieldList.POL_STATUS)
            End Get
        End Property
        Public ReadOnly Property POL_ISSUE_DATE As FieldDef
            Get
                Return Fields(FieldList.POL_ISSUE_DATE)
            End Get
        End Property
        Public ReadOnly Property POL_ISSUE_STATE As FieldDef
            Get
                Return Fields(FieldList.POL_ISSUE_STATE)
            End Get
        End Property
        Public ReadOnly Property POL_PREM_AMOUNT As FieldDef
            Get
                Return Fields(FieldList.POL_PREM_AMOUNT)
            End Get
        End Property
        Public ReadOnly Property POL_PLAN_MOD_PREM As FieldDef
            Get
                Return Fields(FieldList.POL_PLAN_MOD_PREM)
            End Get
        End Property
        Public ReadOnly Property POL_PREM_MODE As FieldDef
            Get
                Return Fields(FieldList.POL_PREM_MODE)
            End Get
        End Property
        Public ReadOnly Property POL_DB_DESC As FieldDef
            Get
                Return Fields(FieldList.POL_DB_DESC)
            End Get
        End Property
        Public ReadOnly Property POL_BASIS_PT As FieldDef
            Get
                Return Fields(FieldList.POL_BASIS_PT)
            End Get
        End Property
        Public ReadOnly Property POL_EXCH_TYPE As FieldDef
            Get
                Return Fields(FieldList.POL_EXCH_TYPE)
            End Get
        End Property
        Public ReadOnly Property POL_ANN_DESC As FieldDef
            Get
                Return Fields(FieldList.POL_ANN_DESC)
            End Get
        End Property
        Public ReadOnly Property POL_MIN_MAT_DATE As FieldDef
            Get
                Return Fields(FieldList.POL_MIN_MAT_DATE)
            End Get
        End Property
        Public ReadOnly Property POL_MAX_MAT_DATE As FieldDef
            Get
                Return Fields(FieldList.POL_MAX_MAT_DATE)
            End Get
        End Property
        Public ReadOnly Property POL_PAYOUT_AMT As FieldDef
            Get
                Return Fields(FieldList.POL_PAYOUT_AMT)
            End Get
        End Property
        Public ReadOnly Property POL_PAYOUT_FREQ As FieldDef
            Get
                Return Fields(FieldList.POL_PAYOUT_FREQ)
            End Get
        End Property
        Public ReadOnly Property POL_PAYOUT_PERIOD As FieldDef
            Get
                Return Fields(FieldList.POL_PAYOUT_PERIOD)
            End Get
        End Property
        Public ReadOnly Property POL_PAYOUT_START As FieldDef
            Get
                Return Fields(FieldList.POL_PAYOUT_START)
            End Get
        End Property
        Public ReadOnly Property POL_PAYOUT_END As FieldDef
            Get
                Return Fields(FieldList.POL_PAYOUT_END)
            End Get
        End Property
        Public ReadOnly Property POL_FIXED_AMT As FieldDef
            Get
                Return Fields(FieldList.POL_FIXED_AMT)
            End Get
        End Property
        Public ReadOnly Property POL_VAR_AMT As FieldDef
            Get
                Return Fields(FieldList.POL_VAR_AMT)
            End Get
        End Property
        Public ReadOnly Property POL_GTD_RATE As FieldDef
            Get
                Return Fields(FieldList.POL_GTD_RATE)
            End Get
        End Property
        Public ReadOnly Property POL_GTD_PERIOD As FieldDef
            Get
                Return Fields(FieldList.POL_GTD_PERIOD)
            End Get
        End Property
        Public ReadOnly Property POL_PRIM_RATE_CLASS As FieldDef
            Get
                Return Fields(FieldList.POL_PRIM_RATE_CLASS)
            End Get
        End Property
        Public ReadOnly Property POL_JT_RATE_CLASS As FieldDef
            Get
                Return Fields(FieldList.POL_JT_RATE_CLASS)
            End Get
        End Property
        Public ReadOnly Property POL_PRIM_FLATEX As FieldDef
            Get
                Return Fields(FieldList.POL_PRIM_FLATEX)
            End Get
        End Property
        Public ReadOnly Property POL_JT_FLATEX As FieldDef
            Get
                Return Fields(FieldList.POL_JT_FLATEX)
            End Get
        End Property
        Public ReadOnly Property POL_YEAR1_RATE As FieldDef
            Get
                Return Fields(FieldList.POL_YEAR1_RATE)
            End Get
        End Property
        Public ReadOnly Property POL_YEAR2_RATE As FieldDef
            Get
                Return Fields(FieldList.POL_YEAR1_RATE)
            End Get
        End Property
        Public ReadOnly Property POL_MVA_INDEX_RATE As FieldDef
            Get
                Return Fields(FieldList.POL_MVA_INDEX_RATE)
            End Get
        End Property
        Public ReadOnly Property POL_MVA_INDEX_VAL As FieldDef
            Get
                Return Fields(FieldList.POL_MVA_INDEX_VAL)
            End Get
        End Property
        Public ReadOnly Property POL_UDV1 As FieldDef
            Get
                Return Fields(FieldList.POL_UDV1)
            End Get
        End Property
        Public ReadOnly Property POL_BAIL_WIND As FieldDef
            Get
                Return Fields(FieldList.POL_BAIL_WIND)
            End Get
        End Property
        Public ReadOnly Property POL_NEXT_ANNIV_DATE As FieldDef
            Get
                Return Fields(FieldList.POL_NEXT_ANNIV_DATE)
            End Get
        End Property
        Public ReadOnly Property POL_SURR_PERIOD As FieldDef
            Get
                Return Fields(FieldList.POL_SURR_PERIOD)
            End Get
        End Property
        Public ReadOnly Property POL_FIXED_RATE_BAND1 As FieldDef
            Get
                Return Fields(FieldList.POL_FIXED_RATE_BAND1)
            End Get
        End Property
        Public ReadOnly Property POL_FIXED_RATE_BAND2 As FieldDef
            Get
                Return Fields(FieldList.POL_FIXED_RATE_BAND2)
            End Get
        End Property
        Public ReadOnly Property POL_FIXED_RATE_BAND3 As FieldDef
            Get
                Return Fields(FieldList.POL_FIXED_RATE_BAND3)
            End Get
        End Property
        Public ReadOnly Property POL_CAP_RATE_BAND1 As FieldDef
            Get
                Return Fields(FieldList.POL_CAP_RATE_BAND1)
            End Get
        End Property
        Public ReadOnly Property POL_CAP_RATE_BAND2 As FieldDef
            Get
                Return Fields(FieldList.POL_CAP_RATE_BAND2)
            End Get
        End Property
        Public ReadOnly Property POL_CAP_RATE_BAND3 As FieldDef
            Get
                Return Fields(FieldList.POL_CAP_RATE_BAND3)
            End Get
        End Property
        Public ReadOnly Property POL_MARGIN_RATE_BAND1 As FieldDef
            Get
                Return Fields(FieldList.POL_MARGIN_RATE_BAND1)
            End Get
        End Property
        Public ReadOnly Property POL_MARGIN_RATE_BAND2 As FieldDef
            Get
                Return Fields(FieldList.POL_MARGIN_RATE_BAND2)
            End Get
        End Property
        Public ReadOnly Property POL_MARGIN_RATE_BAND3 As FieldDef
            Get
                Return Fields(FieldList.POL_MARGIN_RATE_BAND3)
            End Get
        End Property
        Public ReadOnly Property POL_TRACKING_ID As FieldDef
            Get
                Return Fields(FieldList.POL_TRACKING_ID)
            End Get
        End Property

        Public ReadOnly Property POL_PREM_BONUS_PERC As FieldDef
            Get
                Return Fields(FieldList.POL_PREM_BONUS_PERC)
            End Get
        End Property
        Public ReadOnly Property POL_RIDER_FEE_PERC As FieldDef
            Get
                Return Fields(FieldList.POL_RIDER_FEE_PERC)
            End Get
        End Property

        Public ReadOnly Property POL_INCR_PAY As FieldDef
            Get
                Return Fields(FieldList.POL_INCR_PAY)
            End Get
        End Property
        Public ReadOnly Property POL_GLWB_WAIT_PRD As FieldDef
            Get
                Return Fields(FieldList.POL_GLWB_WAIT_PRD)
            End Get
        End Property

#End Region

#Region " Methods "

#End Region

    End Class
#End Region

#Region " Values "
    <Serializable()>
    Public Class VALUES
        Inherits DTL

#Region " Constructors "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "VALUES"
            Me.NodeParent = "POLICY"
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
#Region " Value "

    <Serializable()>
    Public Class VALUE
        Inherits DTL

#Region " Constructors "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "VALUE"
            Me.NodeParent = "VALUES"
        End Sub

        Private Shadows Enum FieldList
            REC_TYPE
            VAL_CONT
            VAL_SOURCE
            VAL_PRDC_CODE
            VAL_ACCOUNT_CODE
            VAL_DIVISION_CODE
            VAL_FUND_CODE
            VAL_FUND_NAME
            VAL_DIVISION_NAME
            VAL_ACCOUNT_TYPE
            VAL_FUND_VALUE
            VAL_FUND_UNITS
            VAL_FUND_UNIT_VALUE
            VAL_BASIS_POINTS
            VAL_FUND_INT_RATE
            VAL_FUND_GNTY_PERD
            VAL_RENEWAL_DATE
            VAL_ALLOC_PERC
            VAL_BONUS_AMT
            VAL_BEG_INDEX_VAL
            VAL_IND_CAP_RATE
            VAL_IND_PART_RATE
            VAL_IND_SPREAD
            VAL_FUND_TOTAL
            VAL_BAIL_RATE
            VAL_PERF_TRIG_RATE


        End Enum

        Private Sub Initialize()
            With Fields
                .Add(New FieldDef("REC_TYPE", "S:VALUE"))
                .Add(New FieldDef("VAL_CONT", "CONT"))
                .Add(New FieldDef("VAL_SOURCE", " "c, FieldType.String, "", "S:Se2"))
                .Add(New FieldDef("VAL_PRDC_CODE", "PLN_CODE"))
                .Add(New FieldDef("VAL_ACCOUNT_CODE", "ACC_CODE"))
                .Add(New FieldDef("VAL_DIVISION_CODE", "DIV_CODE"))
                .Add(New FieldDef("VAL_FUND_CODE", "FUND_CODE"))
                .Add(New FieldDef("VAL_FUND_NAME", "FUND_CODE_DESC"))
                .Add(New FieldDef("VAL_DIVISION_NAME", "DIV_NAME"))
                .Add(New FieldDef("VAL_ACCOUNT_TYPE", "ACCT_TYPE"))
                .Add(New FieldDef("VAL_FUND_VALUE", 0, FieldType.Number, "0.00", "VALUE"))
                .Add(New FieldDef("VAL_FUND_UNITS", 0, FieldType.Number, "0.00", "UNITS"))
                .Add(New FieldDef("VAL_FUND_UNIT_VALUE", 0, FieldType.Number, "0.00", "UNIT_VALUE"))
                .Add(New FieldDef("VAL_BASIS_POINTS", 0, FieldType.Number, "0", "BASIS_POINT"))
                .Add(New FieldDef("VAL_FUND_INT_RATE", 0, FieldType.Number, "0.00", "RATE"))
                .Add(New FieldDef("VAL_FUND_GNTY_PERD", "RATE_GNTY_PERIOD"))
                .Add(New FieldDef("VAL_RENEWAL_DATE", "#1/1/1900#", FieldType.Date, DateFmt, "RENEW_DATE"))
                .Add(New FieldDef("VAL_ALLOC_PERC", 0, FieldType.Number, "0.00", "F:Get_Alloc_Pct"))
                .Add(New FieldDef("VAL_BONUS_AMT", "S:0.00"))
                .Add(New FieldDef("VAL_BEG_INDEX_VAL", 0.00, FieldType.Number, "0.00", "BEG_INDEX_VAL"))
                .Add(New FieldDef("VAL_IND_CAP_RATE", 0, FieldType.Number, "0.0000", "CAP_RATE"))
                .Add(New FieldDef("VAL_IND_PART_RATE", 0, FieldType.Number, "0.00", "PART_RATE"))
                .Add(New FieldDef("VAL_IND_SPREAD", 0, FieldType.Number, "0.00", "INDEX_SPREAD"))
                .Add(New FieldDef("VAL_FUND_TOTAL", "S:0.00"))
                .Add(New FieldDef("VAL_BAIL_RATE", "S:0.00"))
                .Add(New FieldDef("VAL_PERF_TRIG_RATE", "S:0.00"))

            End With
        End Sub

#End Region

#Region " Properties "

        Public ReadOnly Property REC_TYPE As FieldDef
            Get
                Return Fields(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property VAL_CONT As FieldDef
            Get
                Return Fields(FieldList.VAL_CONT)
            End Get
        End Property
        Public ReadOnly Property VAL_SOURCE As FieldDef
            Get
                Return Fields(FieldList.VAL_SOURCE)
            End Get
        End Property
        Public ReadOnly Property VAL_PRDC_CODE As FieldDef
            Get
                Return Fields(FieldList.VAL_PRDC_CODE)
            End Get
        End Property
        Public ReadOnly Property VAL_ACCOUNT_CODE As FieldDef
            Get
                Return Fields(FieldList.VAL_ACCOUNT_CODE)
            End Get
        End Property
        Public ReadOnly Property VAL_DIVISION_CODE As FieldDef
            Get
                Return Fields(FieldList.VAL_DIVISION_CODE)
            End Get
        End Property
        Public ReadOnly Property VAL_FUND_CODE As FieldDef
            Get
                Return Fields(FieldList.VAL_FUND_CODE)
            End Get
        End Property
        Public ReadOnly Property VAL_FUND_NAME As FieldDef
            Get
                Return Fields(FieldList.VAL_FUND_NAME)
            End Get
        End Property
        Public ReadOnly Property VAL_DIVISION_NAME As FieldDef
            Get
                Return Fields(FieldList.VAL_DIVISION_NAME)
            End Get
        End Property
        Public ReadOnly Property VAL_ACCOUNT_TYPE As FieldDef
            Get
                Return Fields(FieldList.VAL_ACCOUNT_TYPE)
            End Get
        End Property
        Public ReadOnly Property VAL_FUND_VALUE As FieldDef
            Get
                Return Fields(FieldList.VAL_FUND_VALUE)
            End Get
        End Property
        Public ReadOnly Property VAL_FUND_UNITS As FieldDef
            Get
                Return Fields(FieldList.VAL_FUND_UNITS)
            End Get
        End Property
        Public ReadOnly Property VAL_FUND_UNIT_VALUE As FieldDef
            Get
                Return Fields(FieldList.VAL_FUND_UNIT_VALUE)
            End Get
        End Property
        Public ReadOnly Property VAL_BASIS_POINTS As FieldDef
            Get
                Return Fields(FieldList.VAL_BASIS_POINTS)
            End Get
        End Property
        Public ReadOnly Property VAL_FUND_INT_RATE As FieldDef
            Get
                Return Fields(FieldList.VAL_FUND_INT_RATE)
            End Get
        End Property
        Public ReadOnly Property VAL_FUND_GNTY_PERD As FieldDef
            Get
                Return Fields(FieldList.VAL_FUND_GNTY_PERD)
            End Get
        End Property
        Public ReadOnly Property VAL_RENEWAL_DATE As FieldDef
            Get
                Return Fields(FieldList.VAL_RENEWAL_DATE)
            End Get
        End Property
        Public ReadOnly Property VAL_ALLOC_PERC As FieldDef
            Get
                Return Fields(FieldList.VAL_ALLOC_PERC)
            End Get
        End Property
        Public ReadOnly Property VAL_BONUS_AMT As FieldDef
            Get
                Return Fields(FieldList.VAL_BONUS_AMT)
            End Get
        End Property
        Public ReadOnly Property VAL_BEG_INDEX_VAL As FieldDef
            Get
                Return Fields(FieldList.VAL_BEG_INDEX_VAL)
            End Get
        End Property
        Public ReadOnly Property VAL_IND_CAP_RATE As FieldDef
            Get
                Return Fields(FieldList.VAL_IND_CAP_RATE)
            End Get
        End Property
        Public ReadOnly Property VAL_IND_PART_RATE As FieldDef
            Get
                Return Fields(FieldList.VAL_IND_PART_RATE)
            End Get
        End Property
        Public ReadOnly Property VAL_IND_SPREAD As FieldDef
            Get
                Return Fields(FieldList.VAL_IND_SPREAD)
            End Get
        End Property
        Public ReadOnly Property VAL_FUND_TOTAL As FieldDef
            Get
                Return Fields(FieldList.VAL_FUND_TOTAL)
            End Get
        End Property
        Public ReadOnly Property VAL_BAIL_RATE As FieldDef
            Get
                Return Fields(FieldList.VAL_BAIL_RATE)
            End Get
        End Property
        Public ReadOnly Property VAL_PERF_TRIG_RATE As FieldDef
            Get
                Return Fields(FieldList.VAL_PERF_TRIG_RATE)
            End Get
        End Property



#End Region

#Region "Methods"

#End Region

    End Class
#End Region

#Region " Roles "

    <Serializable()>
    Public Class ROLES
        Inherits DTL

#Region " Constructors "

        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "ROLES"
            Me.NodeParent = "POLICY"
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


    <Serializable()>
    Public Class ROLE
        Inherits DTL

#Region " Constructors "

        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "ROLE"
            Me.NodeParent = "ROLES"
        End Sub

        Private Shadows Enum FieldList
            REC_TYPE
            ROL_CONT
            ROL_SOURCE
            ROL_PRDC_CODE
            ROL_ID
            ROL_CODE
            ROL_NM_ID
            ROL_ADDR_ID
            ROL_SEASON_IND
            ROL_PCT
            ROL_NAME_TYPE
            ROL_FST_NAME
            ROL_LST_NAME
            ROL_MID_NAME
            ROL_LG_NAME
            ROL_TAX_ID
            ROL_DOB
            ROL_GENDER
            ROL_SALUTE
            ROL_REL_CODE
            ROL_REL_DESC
            ROL_EXT_ID
            ROL_EMAIL
            ROL_ISSUE_AGE
            ROL_DELIVERY_FLAG
        End Enum

        Private Sub Initialize()
            With Fields
                .Add(New FieldDef("REC_TYPE", "S:ROLE"))
                .Add(New FieldDef("ROL_CONT", "CONT"))
                .Add(New FieldDef("ROL_SOURCE", " "c, FieldType.String, "", "S:Se2"))
                .Add(New FieldDef("ROL_PRDC_CODE", "PLN_CODE"))
                .Add(New FieldDef("ROL_ID", "ROLE_ID"))
                .Add(New FieldDef("ROL_CODE", "F:ROLE_DESC"))           '"F:Get_RoleCode"))
                .Add(New FieldDef("ROL_NM_ID", "NAME_ID"))
                .Add(New FieldDef("ROL_ADDR_ID", "ADDRESS_ID"))
                .Add(New FieldDef("ROL_SEASON_IND", "SEASONAL_IND"))
                .Add(New FieldDef("ROL_PCT", 0, FieldType.Number, "00", "PERCENT_SPLIT"))
                .Add(New FieldDef("ROL_NAME_TYPE", "NAME_TYPE"))       '"F:Get_Name_Type"))
                .Add(New FieldDef("ROL_FST_NAME", "FST"))
                .Add(New FieldDef("ROL_LST_NAME", "LST"))
                .Add(New FieldDef("ROL_MID_NAME", "MID"))
                .Add(New FieldDef("ROL_LG_NAME", "LST"))
                '.Add(New FieldDef("ROL_SUFFIX", "SUFFIX"))
                .Add(New FieldDef("ROL_TAX_ID", 0, FieldType.Number, "0.00", "TAX_ID"))
                .Add(New FieldDef("ROL_DOB", "#1/1/1900#", FieldType.Date, DateFmt, "DOB"))
                .Add(New FieldDef("ROL_GENDER", "F:Get_Gender"))
                .Add(New FieldDef("ROL_SALUTE", "SALUTE"))
                .Add(New FieldDef("ROL_REL_CODE", "RELATIONSHIP_ID"))
                .Add(New FieldDef("ROL_REL_DESC", "RELATIONSHIP"))
                .Add(New FieldDef("ROL_EXT_ID", "EXT_ID"))
                .Add(New FieldDef("ROL_EMAIL", "EMAIL"))
                .Add(New FieldDef("ROL_ISSUE_AGE", "ISSUE_AGE"))
                .Add(New FieldDef("ROL_DELIVERY_FLAG", "F:Get_MAIL_TYPE"))
            End With
        End Sub
#End Region

#Region " Properties "
        Public ReadOnly Property Rec_Type As FieldDef
            Get
                Return Fields(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property ROL_CONT As FieldDef
            Get
                Return Fields(FieldList.ROL_CONT)
            End Get
        End Property
        Public ReadOnly Property ROL_SOURCE As FieldDef
            Get
                Return Fields(FieldList.ROL_SOURCE)
            End Get
        End Property
        Public ReadOnly Property ROL_PRDC_CODE As FieldDef
            Get
                Return Fields(FieldList.ROL_PRDC_CODE)
            End Get
        End Property
        Public ReadOnly Property ROL_ID As FieldDef
            Get
                Return Fields(FieldList.ROL_ID)
            End Get
        End Property
        Public ReadOnly Property ROL_CODE As FieldDef
            Get
                Return Fields(FieldList.ROL_CODE)
            End Get
        End Property
        Public ReadOnly Property ROL_NM_ID As FieldDef
            Get
                Return Fields(FieldList.ROL_NM_ID)
            End Get
        End Property
        Public ReadOnly Property ROL_ADDR_ID As FieldDef
            Get
                Return Fields(FieldList.ROL_ADDR_ID)
            End Get
        End Property
        Public ReadOnly Property ROL_SEASON_IND As FieldDef
            Get
                Return Fields(FieldList.ROL_SEASON_IND)
            End Get
        End Property
        Public ReadOnly Property ROL_PCT As FieldDef
            Get
                Return Fields(FieldList.ROL_PCT)
            End Get
        End Property
        Public ReadOnly Property ROL_NAME_TYPE As FieldDef
            Get
                Return Fields(FieldList.ROL_NAME_TYPE)
            End Get
        End Property
        Public ReadOnly Property ROL_FST_NAME As FieldDef
            Get
                Return Fields(FieldList.ROL_FST_NAME)
            End Get
        End Property
        Public ReadOnly Property ROL_LST_NAME As FieldDef
            Get
                Return Fields(FieldList.ROL_LST_NAME)
            End Get
        End Property
        Public ReadOnly Property ROL_MID_NAME As FieldDef
            Get
                Return Fields(FieldList.ROL_MID_NAME)
            End Get
        End Property
        Public ReadOnly Property ROL_LG_NAME As FieldDef
            Get
                Return Fields(FieldList.ROL_LG_NAME)
            End Get
        End Property
        Public ReadOnly Property ROL_TAX_ID As FieldDef
            Get
                Return Fields(FieldList.ROL_TAX_ID)
            End Get
        End Property
        Public ReadOnly Property ROL_DOB As FieldDef
            Get
                Return Fields(FieldList.ROL_DOB)
            End Get
        End Property
        Public ReadOnly Property ROL_GENDER As FieldDef
            Get
                Return Fields(FieldList.ROL_GENDER)
            End Get
        End Property
        Public ReadOnly Property ROL_SALUTE As FieldDef
            Get
                Return Fields(FieldList.ROL_SALUTE)
            End Get
        End Property
        Public ReadOnly Property ROL_REL_CODE As FieldDef
            Get
                Return Fields(FieldList.ROL_REL_CODE)
            End Get
        End Property
        Public ReadOnly Property ROL_REL_DESC As FieldDef
            Get
                Return Fields(FieldList.ROL_REL_DESC)
            End Get
        End Property
        Public ReadOnly Property ROL_EXT_ID As FieldDef
            Get
                Return Fields(FieldList.ROL_EXT_ID)
            End Get
        End Property
        Public ReadOnly Property ROL_EMAIL As FieldDef
            Get
                Return Fields(FieldList.ROL_EMAIL)
            End Get
        End Property
        Public ReadOnly Property ROL_ISSUE_AGE As FieldDef
            Get
                Return Fields(FieldList.ROL_ISSUE_AGE)
            End Get
        End Property
        Public ReadOnly Property ROL_DELIVERY_FLAG As FieldDef
            Get
                Return Fields(FieldList.ROL_DELIVERY_FLAG)
            End Get
        End Property
#End Region

#Region " Methods "

#End Region

    End Class
#End Region

#Region " Phones "

    <Serializable()>
    Public Class PHONES
        Inherits DTL

#Region " Constructors "

        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "PHONES"
            Me.NodeParent = "POLICY"
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
#Region " Phone "


    <Serializable()>
    Public Class PHONE
        Inherits DTL

#Region " Constructors "

        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "PHONE"
            Me.NodeParent = "PHONES"
        End Sub

        Private Shadows Enum FieldList
            REC_TYPE
            PHN_CONT
            PHN_PHONE_ID
            PHN_SOURCE
            PHN_NAME_ID
            PHN_ROLE_CODE
            PHN_TYPE_CODE
            PHN_CNTRY
            PHN_AREA_CODE
            PHN_EXCHANGE
            PHN_SUFFIX
            PHN_EXTENSION

        End Enum

        Private Sub Initialize()
            With Fields
                .Add(New FieldDef("REC_TYPE", "S:PHONE"))
                .Add(New FieldDef("PHN_CONT", "CONT"))
                .Add(New FieldDef("PHN_PHONE_ID", "PHONE_ID"))
                .Add(New FieldDef("PHN_SOURCE", " "c, FieldType.String, "", "S:Se2"))
                .Add(New FieldDef("PHN_NAME_ID", "NAME_ID"))
                .Add(New FieldDef("PHN_ROLE_CODE", "F:ROLE_DESC"))
                .Add(New FieldDef("PHN_TYPE_CODE", "PHONE_TYPE"))
                .Add(New FieldDef("PHN_CNTRY", "PH_CTRY_CODE"))
                .Add(New FieldDef("PHN_AREA_CODE", "AREA_CODE"))
                .Add(New FieldDef("PHN_EXCHANGE", "EXC"))
                .Add(New FieldDef("PHN_SUFFIX", "PH_SUFFIX"))
                .Add(New FieldDef("PHN_EXTENSION", "EXT"))
            End With
        End Sub
#End Region

#Region " Properties "
        Public ReadOnly Property REC_TYPE As FieldDef
            Get
                Return Fields(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property PHN_CONT As FieldDef
            Get
                Return Fields(FieldList.PHN_CONT)
            End Get
        End Property
        Public ReadOnly Property PHN_PHONE_ID As FieldDef
            Get
                Return Fields(FieldList.PHN_PHONE_ID)
            End Get
        End Property
        Public ReadOnly Property PHN_NAME_ID As FieldDef
            Get
                Return Fields(FieldList.PHN_NAME_ID)
            End Get
        End Property
        Public ReadOnly Property PHN_SOURCE As FieldDef
            Get
                Return Fields(FieldList.PHN_SOURCE)
            End Get
        End Property
        Public ReadOnly Property PHN_ROLE_CODE As FieldDef
            Get
                Return Fields(FieldList.PHN_ROLE_CODE)
            End Get
        End Property
        Public ReadOnly Property PHN_TYPE_CODE As FieldDef
            Get
                Return Fields(FieldList.PHN_TYPE_CODE)
            End Get
        End Property
        Public ReadOnly Property PHN_CNTRY As FieldDef
            Get
                Return Fields(FieldList.PHN_CNTRY)
            End Get
        End Property
        Public ReadOnly Property PHN_AREA_CODE As FieldDef
            Get
                Return Fields(FieldList.PHN_AREA_CODE)
            End Get
        End Property
        Public ReadOnly Property PHN_EXCHANGE As FieldDef
            Get
                Return Fields(FieldList.PHN_EXCHANGE)
            End Get
        End Property
        Public ReadOnly Property PHN_SUFFIX As FieldDef
            Get
                Return Fields(FieldList.PHN_SUFFIX)
            End Get
        End Property
        Public ReadOnly Property PHN_EXTENSION As FieldDef
            Get
                Return Fields(FieldList.PHN_EXTENSION)
            End Get
        End Property
#End Region

#Region " Methods "

#End Region

    End Class
#End Region

#Region " Addresses "

    <Serializable()>
    Public Class ADDRESSES
        Inherits DTL

#Region " Constructors "

        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "ADDRESSES"
            Me.NodeParent = "POLICY"
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
#Region " Address "


    <Serializable()>
    Public Class ADDRESS
        Inherits DTL

#Region " Constructors "

        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "ADDRESS"
            Me.NodeParent = "ADDRESSES"
        End Sub

        Private Shadows Enum FieldList
            REC_TYPE
            ADDR_CONT
            ADDR_ADDR_ID
            ADDR_SOURCE
            ADDR_ROLE_CODE
            ADDR_NM_ID
            ADDR_TYPE_CODE
            ADDR_LINE1
            ADDR_LINE2
            ADDR_LINE3
            ADDR_CITY
            ADDR_STATE
            ADDR_ZIP
            ADDR_ZIP_EXT
            ADDR_COUNTRY
        End Enum

        Private Sub Initialize()
            With Fields
                .Add(New FieldDef("REC_TYPE", "S:ADDRESS"))
                .Add(New FieldDef("ADDR_CONT", "CONT"))
                .Add(New FieldDef("ADDR_ADDR_ID", "ADDRESS_ID"))
                .Add(New FieldDef("ADDR_SOURCE", " "c, FieldType.String, " ", "S:Se2"))
                .Add(New FieldDef("ADDR_ROLE_CODE", "F:ROLE_DESC"))     'ROLE_DESC
                .Add(New FieldDef("ADDR_NM_ID", "NAME_ID"))
                .Add(New FieldDef("ADDR_TYPE_CODE", "F:Get_Address_Type_Code"))
                .Add(New FieldDef("ADDR_LINE1", "ADDRESS1"))
                .Add(New FieldDef("ADDR_LINE2", "ADDRESS2"))
                .Add(New FieldDef("ADDR_LINE3", "ADDRESS3"))
                .Add(New FieldDef("ADDR_CITY", "CITY"))
                .Add(New FieldDef("ADDR_STATE", "STATE_CODE"))
                .Add(New FieldDef("ADDR_ZIP", "ZIP"))
                .Add(New FieldDef("ADDR_ZIP_EXT", "ZIP_SUFFIX"))
                .Add(New FieldDef("ADDR_COUNTRY", "CTRY_CODE"))
            End With
        End Sub
#End Region

#Region " Properties "
        Public ReadOnly Property REC_TYPE As FieldDef
            Get
                Return Fields(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property ADDR_CONT As FieldDef
            Get
                Return Fields(FieldList.ADDR_CONT)
            End Get
        End Property
        Public ReadOnly Property ADDR_ADDR_ID As FieldDef
            Get
                Return Fields(FieldList.ADDR_ADDR_ID)
            End Get
        End Property
        Public ReadOnly Property ADDR_SOURCE As FieldDef
            Get
                Return Fields(FieldList.ADDR_SOURCE)
            End Get
        End Property
        Public ReadOnly Property ADDR_ROLE_CODE As FieldDef
            Get
                Return Fields(FieldList.ADDR_ROLE_CODE)
            End Get
        End Property
        Public ReadOnly Property ADDR_NM_ID As FieldDef
            Get
                Return Fields(FieldList.ADDR_NM_ID)
            End Get
        End Property
        Public ReadOnly Property ADDR_TYPE_CODE As FieldDef
            Get
                Return Fields(FieldList.ADDR_TYPE_CODE)
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
        Public ReadOnly Property ADDR_ZIP_EXT As FieldDef
            Get
                Return Fields(FieldList.ADDR_ZIP_EXT)
            End Get
        End Property
        Public ReadOnly Property ADDR_COUNTRY As FieldDef
            Get
                Return Fields(FieldList.ADDR_COUNTRY)
            End Get
        End Property
#End Region

#Region " Methods "

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
            Me.NodeName = "FEATURES"
            Me.NodeParent = "POLICY"
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


    <Serializable()>
    Public Class FEATURE
        Inherits DTL

#Region " Constructors "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "FEATURE"
            Me.NodeParent = "FEATURES"
        End Sub

        Private Shadows Enum FieldList
            REC_TYPE
            FEA_CONT
            FEA_SOURCE
            FEA_FEAT_DESC
            FEA_FEAT_TYPE
            FEA_RIDER_TYPE
            FEA_SPEC_CODE
            FEA_VAR_CODE
            FEA_RIDER_FEE
            FEA_BENEFIT_LIMIT
            FEA_INT_PREM
            FEA_MONTHLY_PREM
            FEA_IRA_ENDR
        End Enum

        Private Sub Initialize()
            With Fields
                .Add(New FieldDef("REC_TYPE", "S:FEATURE"))
                .Add(New FieldDef("FEA_CONT", "CONT"))
                .Add(New FieldDef("FEA_SOURCE", " "c, FieldType.String, " ", "S:Se2"))
                .Add(New FieldDef("FEA_FEAT_DESC", "VARIATION_GROUP_DESC"))
                .Add(New FieldDef("FEA_FEAT_TYPE", "SPEC_CODE_DESC"))
                .Add(New FieldDef("FEA_RIDER_TYPE", "S:0"))
                .Add(New FieldDef("FEA_SPEC_CODE", "SPEC_CODE"))
                .Add(New FieldDef("FEA_VAR_CODE", "VARIATION_GROUP_ID"))
                .Add(New FieldDef("FEA_RIDER_FEE", 0, FieldType.Number, "0.00", "RIDER_FEE"))
                .Add(New FieldDef("FEA_BENEFIT_LIMIT", 0, FieldType.Number, "0.00", "S:0"))
                .Add(New FieldDef("FEA_INT_PREM", 0, FieldType.Number, "0.00", "S:0"))
                .Add(New FieldDef("FEA_MONTHLY_PREM", 0, FieldType.Number, "0.00", "S:0"))
                .Add(New FieldDef("FEA_IRA_ENDR", "S:Y"))
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
        Public ReadOnly Property FEA_SOURCE As FieldDef
            Get
                Return Fields(FieldList.FEA_SOURCE)
            End Get
        End Property
        Public ReadOnly Property FEA_FEAT_DESC As FieldDef
            Get
                Return Fields(FieldList.FEA_FEAT_DESC)
            End Get
        End Property
        Public ReadOnly Property FEA_FEAT_TYPE As FieldDef
            Get
                Return Fields(FieldList.FEA_FEAT_TYPE)
            End Get
        End Property

        Public ReadOnly Property FEA_RIDER_TYPE As FieldDef
            Get
                Return Fields(FieldList.FEA_RIDER_TYPE)
            End Get
        End Property
        Public ReadOnly Property FEA_SPEC_CODE As FieldDef
            Get
                Return Fields(FieldList.FEA_SPEC_CODE)
            End Get
        End Property
        Public ReadOnly Property FEA_VAR_CODE As FieldDef
            Get
                Return Fields(FieldList.FEA_VAR_CODE)
            End Get
        End Property


        Public ReadOnly Property FEA_RIDER_FEE As FieldDef
            Get
                Return Fields(FieldList.FEA_RIDER_FEE)
            End Get
        End Property

        Public ReadOnly Property FEA_BENEFIT_LIMIT As FieldDef
            Get
                Return Fields(FieldList.FEA_BENEFIT_LIMIT)
            End Get
        End Property

        Public ReadOnly Property FEA_INT_PREM As FieldDef
            Get
                Return Fields(FieldList.FEA_INT_PREM)
            End Get
        End Property

        Public ReadOnly Property FEA_MONTHLY_PREM As FieldDef
            Get
                Return Fields(FieldList.FEA_MONTHLY_PREM)
            End Get
        End Property

        Public ReadOnly Property FEA_IRA_ENDR As FieldDef
            Get
                Return Fields(FieldList.FEA_IRA_ENDR)
            End Get
        End Property

#End Region

#Region " Methods "

#End Region

    End Class
#End Region

#Region " LTYINCOMERATES "

    <Serializable()>
    Public Class LTYINCOMERATES
        Inherits DTL

#Region " Constructors "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "LTYINCOMERATES"
            Me.NodeParent = "POLICY"
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
#Region " LTYINCOMERATE  "


    <Serializable()>
    Public Class LTYINCOMERATE
        Inherits DTL

#Region " Constructors "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "LTYINCOMERATE"
            Me.NodeParent = "LTYINCOMERATES"
        End Sub

        Private Shadows Enum FieldList
            REC_TYPE
            LTY_CONT
            LTY_ATTAINED_AGE
            LTY_PAY_INCR_PERC
            LTY_LEVEL_PAYOUT_FACTOR
        End Enum

        Private Sub Initialize()
            With Fields
                .Add(New FieldDef("REC_TYPE", "S:LTYINCOMERATE"))
                .Add(New FieldDef("LTY_CONT", "CONT"))
                .Add(New FieldDef("LTY_ATTAINED_AGE", "ATTAINED_AGE"))
                .Add(New FieldDef("LTY_PAY_INCR_PERC", 0, FieldType.Number, "0.00", "PAY_INCR_PERC"))
                .Add(New FieldDef("LTY_LEVEL_PAYOUT_FACTOR", 0, FieldType.Number, "0.00", "LEVEL_PAYOUT_FACTOR"))

            End With
        End Sub

#End Region

#Region " Properties "

        Public ReadOnly Property REC_TYPE As FieldDef
            Get
                Return Fields(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property LTY_CONT As FieldDef
            Get
                Return Fields(FieldList.LTY_CONT)
            End Get
        End Property
        Public ReadOnly Property LTY_ATTAINED_AGE As FieldDef
            Get
                Return Fields(FieldList.LTY_ATTAINED_AGE)
            End Get
        End Property
        Public ReadOnly Property LTY_PAY_INCR_PERC As FieldDef
            Get
                Return Fields(FieldList.LTY_PAY_INCR_PERC)
            End Get
        End Property
        Public ReadOnly Property LTY_LEVEL_PAYOUT_FACTOR As FieldDef
            Get
                Return Fields(FieldList.LTY_LEVEL_PAYOUT_FACTOR)
            End Get
        End Property


#End Region

#Region " Methods "

#End Region

    End Class
#End Region



End Namespace

