Imports Se2.ISI.Base.Presentation

Namespace Se2.ISCORSP.Client.GLCO.Intake.Records


#Region "MCSCS"

#Region "COMM700"

    <Serializable()>
    Public Class COMM700
        Inherits RecordDef

        Private Shadows Enum FieldList

            REC_TYPE
            Period_Ending
            Firm_MA_ID
            Firm_Ext_ID
            Firm_Name
            Firm_Addr_Line1
            Firm_Addr_Line2
            Firm_Addr_Line3
            Firm_City
            Firm_State
            Firm_Zip

        End Enum

#Region " CONSTRUCTORS "

        Public Sub New()

            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.DET
            Delimiter = ControlChars.Quote + "," + ControlChars.Quote
            Terminator = vbCrLf
            Initialize()

        End Sub
        Private Sub Initialize()

            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("REC_TYPE", "F:REC_TYPE"))
            Fields.Add(New FieldDef("Period_Ending", "Period_Ending"))
            Fields.Add(New FieldDef("Firm_MA_ID", "Firm_MA_ID"))
            Fields.Add(New FieldDef("Firm_Ext_ID ", "Firm_Ext_ID"))
            Fields.Add(New FieldDef("Firm_Name", "Firm_Name"))
            Fields.Add(New FieldDef("Firm_Addr_Line1", "Firm_Addr_Line1"))
            Fields.Add(New FieldDef("Firm_Addr_Line2", "Firm_Addr_Line2"))
            Fields.Add(New FieldDef("Firm_Addr_Line3", "Firm_Addr_Line3"))
            Fields.Add(New FieldDef("Firm_City ", "Firm_City"))
            Fields.Add(New FieldDef("Firm_State", "Firm_State"))
            Fields.Add(New FieldDef("Firm_Zip ", "Firm_Zip"))
        End Sub

#End Region

#Region " PROPERTIES "

#End Region

#Region " METHODS "


#End Region

    End Class

#End Region

#Region "COMM701"

    <Serializable()>
    Public Class COMM701
        Inherits RecordDef

        Private Shadows Enum FieldList
            REC_TYPE
            Firm_Ext_ID
            Firm_Beg_Bal_Curr_Period
            Firm_Ernd_Comm_Curr_Period
            Firm_Adv_Pmts_Curr_Period
            Firm_Annz_Pmts_Curr_Period
            Firm_ChgBks_Revs_Curr_Period
            Firm_Ernd_Comm_YTD
            Firm_Adv_Pmts_YTD
            Firm_Annz_Pmts_YTD
            Firm_ChgBks_Revs_YTD
            Firm_Asst_Alloc_YTD
            Firm_Misc_YTD
            Firm_Misc_Curr_Period
            Firm_Net_Remit_Curr_Period
            Firm_Net_Remit_YTD
            Firm_Asst_Alloc_Curr_Period
            Firm_Fees_Curr_Period
            Firm_Fees_YTD
            IMO_Ind

        End Enum

#Region " CONSTRUCTORS "

        Public Sub New()

            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.DET
            Delimiter = ControlChars.Quote + "," + ControlChars.Quote
            Terminator = vbCrLf

            Initialize()

        End Sub
        Private Sub Initialize()

            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("REC_TYPE", "F:REC_TYPE"))
            Fields.Add(New FieldDef("Firm_Ext_ID ", "Firm_Ext_ID"))
            Fields.Add(New FieldDef("Firm_Beg_Bal_Curr_Period", "Firm_Beg_Bal_Curr_Period"))
            Fields.Add(New FieldDef("Firm_Ernd_Comm_Curr_Period", "Firm_Ernd_Comm_Curr_Period"))
            Fields.Add(New FieldDef("Firm_Adv_Pmts_Curr_Period", "Firm_Adv_Pmts_Curr_Period"))
            Fields.Add(New FieldDef("Firm_Annz_Pmts_Curr_Period", "Firm_Annz_Pmts_Curr_Period"))
            Fields.Add(New FieldDef("Firm_ChgBks_Revs_Curr_Period", "Firm_ChgBks_Revs_Curr_Period"))
            Fields.Add(New FieldDef("Firm_Ernd_Comm_YTD", "Firm_Ernd_Comm_YTD"))
            Fields.Add(New FieldDef("Firm_Adv_Pmts_YTD", "Firm_Adv_Pmts_YTD"))
            Fields.Add(New FieldDef("Firm_Annz_Pmts_YTD", "Firm_Annz_Pmts_YTD"))
            Fields.Add(New FieldDef("Firm_ChgBks_Revs_YTD", "Firm_ChgBks_Revs_YTD"))
            Fields.Add(New FieldDef("Firm_Asst_Alloc_YTD", "Firm_Asst_Alloc_YTD"))
            Fields.Add(New FieldDef("Firm_Misc_YTD", "Firm_Misc_YTD"))
            Fields.Add(New FieldDef("Firm_Misc_Curr_Period", "Firm_Misc_Curr_Period"))
            Fields.Add(New FieldDef("Firm_Net_Remit_Curr_Period", "Firm_Net_Remit_Curr_Period"))
            Fields.Add(New FieldDef("Firm_Net_Remit_YTD", "Firm_Net_Remit_YTD"))
            Fields.Add(New FieldDef("Firm_Asst_Alloc_Curr_Period", "Firm_Asst_Alloc_Curr_Period"))
            Fields.Add(New FieldDef("Firm_Fees_Curr_Period", "Firm_Fees_Curr_Period"))
            Fields.Add(New FieldDef("Firm_Fees_YTD", "Firm_Fees_YTD"))
            Fields.Add(New FieldDef("IMO_Ind", "IMO_Ind"))

        End Sub

#End Region

#Region " PROPERTIES "

#End Region

#Region " METHODS "

#End Region

    End Class

#End Region

#Region "COMM702"
    <Serializable()>
    Public Class COMM702
        Inherits RecordDef
        Private Shadows Enum FieldList
            REC_TYPE
            PROD_NAME
            PROD_CODE
            PROD_ERND_COMM_PERIOD
            PROD_ADV_PMTS_PERIOD
            PROD_ANNZ_PMTS_PERIOD
            PROD_RECOVERIES_PERIOD
            PROD_ASSET_BASED_COMM_PERIOD
            PROD_MISC_PERIOD
            PROD_REMIT_PERIOD
            PROD_ISSUING_COMPANY
            PROD_FEES_PERIOD
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()

            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.DET
            Delimiter = ControlChars.Quote + "," + ControlChars.Quote
            Terminator = vbCrLf
            Initialize()
        End Sub
        Private Sub Initialize()

            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("REC_TYPE", "F:REC_TYPE"))
            Fields.Add(New FieldDef("PROD_NAME ", "PROD_NAME"))
            Fields.Add(New FieldDef("PROD_CODE", "PROD_CODE"))
            Fields.Add(New FieldDef("PROD_ERND_COMM_PERIOD", "PROD_ERND_COMM_PERIOD"))
            Fields.Add(New FieldDef("PROD_ADV_PMTS_PERIOD", "PROD_ADV_PMTS_PERIOD"))
            Fields.Add(New FieldDef("PROD_ANNZ_PMTS_PERIOD", "PROD_ANNZ_PMTS_PERIOD"))
            Fields.Add(New FieldDef("PROD_RECOVERIES_PERIOD", "PROD_RECOVERIES_PERIOD"))
            Fields.Add(New FieldDef("PROD_ASSET_BASED_COMM_PERIOD", "PROD_ASSET_BASED_COMM_PERIOD"))
            Fields.Add(New FieldDef("PROD_MISC_PERIOD ", "PROD_MISC_PERIOD"))
            Fields.Add(New FieldDef("PROD_REMIT_PERIOD", "PROD_REMIT_PERIOD"))
            Fields.Add(New FieldDef("PROD_ISSUING_COMPANY ", "PROD_ISSUING_COMPANY"))
            Fields.Add(New FieldDef("PROD_FEES_PERIOD ", "PROD_FEES_PERIOD"))
        End Sub

#End Region

    End Class
#End Region

#Region "COMM703"

    <Serializable()>
    Public Class COMM703
        Inherits RecordDef

        Private Shadows Enum FieldList
            REC_TYPE
            Firm_Product_Name
            Firm_Product_Code
            Firm_Ernd_Comm_YTD
            Firm_Adv_Pmts_YTD
            Firm_Annz_Pmts_YTD
            Firm_ChgBks_YTD
            Firm_Asset_Based_YTD
            Firm_Misc_YTD
            Firm_Net_Remit_YTD
            Firm_Issu_Company

        End Enum

#Region " CONSTRUCTORS "

        Public Sub New()

            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.DET
            Delimiter = ControlChars.Quote + "," + ControlChars.Quote
            Terminator = vbCrLf

            Initialize()

        End Sub
        Private Sub Initialize()

            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("REC_TYPE", "F:REC_TYPE"))
            Fields.Add(New FieldDef("Firm_Product_Name", "Firm_Product_Name"))
            Fields.Add(New FieldDef("Firm_Product_Code", "Firm_Product_Code"))
            Fields.Add(New FieldDef("Firm_Ernd_Comm_YTD", "Firm_Ernd_Comm_YTD"))
            Fields.Add(New FieldDef("Firm_Adv_Pmts_YTD", "Firm_Adv_Pmts_YTD"))
            Fields.Add(New FieldDef("Firm_Annz_Pmts_YTD", "Firm_Annz_Pmts_YTD"))
            Fields.Add(New FieldDef("Firm_ChgBks_YTD", "Firm_ChgBks_YTD"))
            Fields.Add(New FieldDef("Firm_Asset_Based_YTD", "Firm_Asset_Based_YTD"))
            Fields.Add(New FieldDef("Firm_Misc_YTD", "Firm_Misc_YTD"))
            Fields.Add(New FieldDef("Firm_Net_Remit_YTD", "Firm_Net_Remit_YTD"))
            Fields.Add(New FieldDef("Firm_Issu_Company", "Firm_Issu_Company"))

        End Sub

#End Region

#Region " PROPERTIES "

#End Region

#Region " METHODS "

#End Region

    End Class

#End Region

#Region "COMM704"

    <Serializable()>
    Public Class COMM704
        Inherits RecordDef

        Private Shadows Enum FieldList
            REC_TYPE
            Firm_EXT_ID
            Firm_Name
            Firm_Alt_ID
            Firm_Tax_ID
        End Enum

#Region " CONSTRUCTORS "

        Public Sub New()

            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.DET
            Delimiter = ControlChars.Quote + "," + ControlChars.Quote
            Terminator = vbCrLf

            Initialize()

        End Sub
        Private Sub Initialize()

            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("REC_TYPE", "F:REC_TYPE"))
            Fields.Add(New FieldDef("Firm_EXT_ID", "Firm_EXT_ID"))
            Fields.Add(New FieldDef("Firm_Name", "Firm_Name"))
            Fields.Add(New FieldDef("Firm_Alt_ID", "Firm_Alt_ID"))
            Fields.Add(New FieldDef("Firm_Tax_ID", "Firm_Tax_ID"))

        End Sub

#End Region

#Region " PROPERTIES "

#End Region

#Region " METHODS "

#End Region

    End Class

#End Region

#Region "COMM706"

    <Serializable()>
    Public Class COMM706
        Inherits RecordDef

        Private Shadows Enum FieldList
            REC_TYPE
            Contract_Num
            Contract_Own_Name
            Contract_Prod_Code
            Contract_Tran_Code
            Contract_Pmt_Amt
            Contract_Firm_Comm_Amt
            Contract_Rep_Comm_Amt
            Contract_Firm_Comm_Rate
            Contract_Rep_Comm_Rate
            Contract_Owner_Age
            Contract_Pmt_date

        End Enum

#Region " CONSTRUCTORS "

        Public Sub New()

            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.DET
            Delimiter = ControlChars.Quote + "," + ControlChars.Quote
            Terminator = vbCrLf

            Initialize()

        End Sub
        Private Sub Initialize()

            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("REC_TYPE", "F:REC_TYPE"))
            Fields.Add(New FieldDef("Contract_Num ", "Contract_Num"))
            Fields.Add(New FieldDef("Contract_Own_Name", "Contract_Own_Name"))
            Fields.Add(New FieldDef("Contract_Prod_Code", "Contract_Prod_Code"))
            Fields.Add(New FieldDef("Contract_Tran_Code", "Contract_Tran_Code"))
            Fields.Add(New FieldDef("Contract_Pmt_Amt", "Contract_Pmt_Amt"))
            Fields.Add(New FieldDef("Contract_Firm_Comm_Amt", "Contract_Firm_Comm_Amt"))
            Fields.Add(New FieldDef("Contract_Rep_Comm_Amt", "Contract_Rep_Comm_Amt"))
            Fields.Add(New FieldDef("Contract_Firm_Comm_Rate", "Contract_Firm_Comm_Rate"))
            Fields.Add(New FieldDef("Contract_Rep_Comm_Rate", "Contract_Rep_Comm_Rate"))
            Fields.Add(New FieldDef("Contract_Owner_Age", "Contract_Owner_Age"))
            Fields.Add(New FieldDef("Contract_Pmt_date", "Contract_Pmt_date"))

        End Sub

#End Region

#Region " PROPERTIES "

#End Region

#Region " METHODS "

#End Region

    End Class

#End Region

#Region "COMM719"

    <Serializable()>
    Public Class COMM719
        Inherits RecordDef

        Private Shadows Enum FieldList
            REC_TYPE
            Iss_Comp_Short_Name
            Iss_Comp_Long_Name

        End Enum

#Region " CONSTRUCTORS "

        Public Sub New()

            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.DET
            Delimiter = ControlChars.Quote + "," + ControlChars.Quote
            Terminator = vbCrLf

            Initialize()

        End Sub
        Private Sub Initialize()

            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("REC_TYPE", "F:REC_TYPE"))
            Fields.Add(New FieldDef("Iss_Comp_Short_Name ", "Iss_Comp_Short_Name"))
            Fields.Add(New FieldDef("Iss_Comp_Long_Name", "Iss_Comp_Long_Name"))

        End Sub

#End Region

#Region " PROPERTIES "

#End Region

#Region " METHODS "

#End Region

    End Class

#End Region

#End Region

#Region " PSHEADER "

    <Serializable()>
    Public Class PSHEADER
        Inherits RecordDef

        Private Shadows Enum FieldList
            REC_TYPE
            HS_RUNDATE
            HS_CYCLEDATE
            HS_STARTDATE
            HS_ENDDATE
            HS_CONTENTS
            HS_GROUPID
            HS_SOURCE
            HS_STORETABLE
            HS_COUNT
        End Enum

#Region " CONSTRUCTORS "

        Public Sub New()

            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.PSTHDR
            Delimiter = "~"
            Terminator = vbCrLf
            Initialize()

        End Sub
        Private Sub Initialize()

            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("REC_TYPE", "S:HEADER"))
            Fields.Add(New FieldDef("HS_RUNDATE", "F:Get_RunDate"))
            Fields.Add(New FieldDef("HS_CYCLEDATE", "F:Get_CycleDate"))
            Fields.Add(New FieldDef("HS_STARTDATE", "F:Get_StartDate"))
            Fields.Add(New FieldDef("HS_ENDDATE", "F:Get_EndDate"))
            Fields.Add(New FieldDef("HS_CONTENTS", "F:Get_Contents"))
            Fields.Add(New FieldDef("HS_GROUPID", "F:Get_Groupid"))
            Fields.Add(New FieldDef("HS_SOURCE", "F:Get_Source"))
            Fields.Add(New FieldDef("HS_STORETABLE", "F:Get_Table"))
            Fields.Add(New FieldDef("HS_COUNT", "F:Get_Count"))

        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property HS_RUNDATE() As FieldDef
            Get
                Return Fields(FieldList.HS_RUNDATE)
            End Get
        End Property
        Public ReadOnly Property HS_CONTENTS() As FieldDef
            Get
                Return Fields(FieldList.HS_CONTENTS)
            End Get
        End Property
        Public ReadOnly Property HS_COUNT() As FieldDef
            Get
                Return Fields(FieldList.HS_COUNT)
            End Get
        End Property
        Public ReadOnly Property HS_CYCLEDATE() As FieldDef
            Get
                Return Fields(FieldList.HS_CYCLEDATE)
            End Get
        End Property
        Public ReadOnly Property HS_ENDDATE() As FieldDef
            Get
                Return Fields(FieldList.HS_ENDDATE)
            End Get
        End Property
        Public ReadOnly Property HS_SOURCE() As FieldDef
            Get
                Return Fields(FieldList.HS_SOURCE)
            End Get
        End Property
        Public ReadOnly Property HS_STORETABLE() As FieldDef
            Get
                Return Fields(FieldList.HS_STORETABLE)
            End Get
        End Property
        Public ReadOnly Property HS_STARTDATE() As FieldDef
            Get
                Return Fields(FieldList.HS_STARTDATE)
            End Get
        End Property


#End Region

#Region " METHODS "

#End Region

    End Class

#End Region
End Namespace