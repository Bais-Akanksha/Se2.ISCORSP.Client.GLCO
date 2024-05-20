Imports Se2.ISI.Base.Presentation

Namespace Se2.ISCORSP.Client.GLCO.Intake.SourceLayouts

#Region " MCSCS "

#Region "COMM700"
    <Serializable()>
    Public Class COMM700
        Inherits SourceDef

#Region " PRIVATE PROPERTIES "

#End Region

#Region " PRIVATE METHODS "

#End Region

#Region " FIELD ARRAY ENUM "
        Public Enum FieldList
            REC_TYPE
            Field1
            Period_Ending
            Firm_MA_ID
            Firm_Ext_ID
            Firm_Name
            Firm_Addr_Line1
            Firm_Addr_Line2
            Firm_Addr_Line3
            Field9
            Firm_City
            Firm_State
            Firm_Zip
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE).Replace("""", "").Trim()
            End Get
        End Property
        Public ReadOnly Property Field1() As String
            Get
                Return Values(FieldList.Field1)
            End Get
        End Property
        Public ReadOnly Property Period_Ending() As String
            Get
                Return Values(FieldList.Period_Ending)
            End Get
        End Property

        Public ReadOnly Property Firm_MA_ID() As String
            Get
                Return Values(FieldList.Firm_MA_ID)
            End Get
        End Property
        Public ReadOnly Property Firm_Ext_ID() As String
            Get
                Return Values(FieldList.Firm_Ext_ID)
            End Get
        End Property
        Public ReadOnly Property Firm_Name() As String
            Get
                Return Values(FieldList.Firm_Name)
            End Get
        End Property
        Public ReadOnly Property Firm_Addr_Line1() As String
            Get
                Return Values(FieldList.Firm_Addr_Line1)
            End Get
        End Property
        Public ReadOnly Property Firm_Addr_Line2() As String
            Get
                Return Values(FieldList.Firm_Addr_Line2)
            End Get
        End Property
        Public ReadOnly Property Firm_Addr_Line3() As String
            Get
                Return Values(FieldList.Firm_Addr_Line3)
            End Get
        End Property
        Public ReadOnly Property Field9() As String
            Get
                Return Values(FieldList.Field9)
            End Get
        End Property
        Public ReadOnly Property Firm_City() As String
            Get
                Return Values(FieldList.Firm_City)
            End Get
        End Property
        Public ReadOnly Property Firm_State() As String
            Get
                Return Values(FieldList.Firm_State)
            End Get
        End Property
        Public ReadOnly Property Firm_Zip() As String
            Get
                Return Values(FieldList.Firm_Zip).Replace("""", "").Trim()
            End Get
        End Property
#End Region

#Region " OVERRIDES "

#End Region

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
        Public Sub New(ByVal FieldList As List(Of String))
            MyBase.New("~"c, FieldList)
        End Sub

#End Region

    End Class
#End Region

#Region "COMM701"
    <Serializable()>
    Public Class COMM701
        Inherits SourceDef

#Region " PRIVATE PROPERTIES "

#End Region

#Region " PRIVATE METHODS "

#End Region

#Region " FIELD ARRAY ENUM "
        Public Enum FieldList
            REC_TYPE
            Firm_Ext_ID
            Field1
            Firm_Beg_Bal_Curr_Period
            Firm_Ernd_Comm_Curr_Period
            Firm_Adv_Pmts_Curr_Period
            Firm_Annz_Pmts_Curr_Period
            Firm_ChgBks_Revs_Curr_Period
            'Field2
            Firm_Ernd_Comm_YTD
            Firm_Adv_Pmts_YTD
            Firm_Annz_Pmts_YTD
            Firm_ChgBks_Revs_YTD
            Firm_Asst_Alloc_YTD
            Firm_Misc_YTD
            Firm_Misc_Curr_Period
            'Field3
            Firm_Net_Remit_Curr_Period
            Firm_Net_Remit_YTD
            Firm_Asst_Alloc_Curr_Period
            Firm_Fees_Curr_Period
            Firm_Fees_YTD
            IMO_Ind
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE).Replace("""", "").Trim()
            End Get
        End Property
        Public ReadOnly Property Firm_Ext_ID() As String
            Get
                Return Values(FieldList.Firm_Ext_ID)
            End Get
        End Property
        Public ReadOnly Property Field1() As String
            Get
                Return Values(FieldList.Field1)
            End Get
        End Property
        Public ReadOnly Property Firm_Beg_Bal_Curr_Period() As String
            Get
                Return Values(FieldList.Firm_Beg_Bal_Curr_Period)
            End Get
        End Property
        Public ReadOnly Property Firm_Ernd_Comm_Curr_Period() As String
            Get
                Return Values(FieldList.Firm_Ernd_Comm_Curr_Period)
            End Get
        End Property
        Public ReadOnly Property Firm_Adv_Pmts_Curr_Period() As String
            Get
                Return Values(FieldList.Firm_Adv_Pmts_Curr_Period)
            End Get
        End Property

        Public ReadOnly Property Firm_Annz_Pmts_Curr_Period() As String
            Get
                Return Values(FieldList.Firm_Annz_Pmts_Curr_Period)
            End Get
        End Property
        Public ReadOnly Property Firm_ChgBks_Revs_Curr_Period() As String
            Get
                Return Values(FieldList.Firm_ChgBks_Revs_Curr_Period)
            End Get
        End Property
        'Public ReadOnly Property Field2() As String
        '    Get
        '        Return Values(FieldList.Field2)
        '    End Get
        'End Property
        Public ReadOnly Property Firm_Ernd_Comm_YTD() As String
            Get
                Return Values(FieldList.Firm_Ernd_Comm_YTD)
            End Get
        End Property
        Public ReadOnly Property Firm_Adv_Pmts_YTD() As String
            Get
                Return Values(FieldList.Firm_Adv_Pmts_YTD)
            End Get
        End Property
        Public ReadOnly Property Firm_Annz_Pmts_YTD() As String
            Get
                Return Values(FieldList.Firm_Annz_Pmts_YTD)
            End Get
        End Property
        Public ReadOnly Property Firm_ChgBks_Revs_YTD() As String
            Get
                Return Values(FieldList.Firm_ChgBks_Revs_YTD)
            End Get
        End Property
        Public ReadOnly Property Firm_Asst_Alloc_YTD() As String
            Get
                Return Values(FieldList.Firm_Asst_Alloc_YTD)
            End Get
        End Property
        Public ReadOnly Property Firm_Misc_YTD() As String
            Get
                Return Values(FieldList.Firm_Misc_YTD)
            End Get
        End Property
        Public ReadOnly Property Firm_Misc_Curr_Period() As String
            Get
                Return Values(FieldList.Firm_Misc_Curr_Period)
            End Get
        End Property
        'Public ReadOnly Property Field3() As String
        '    Get
        '        Return Values(FieldList.Field3)
        '    End Get
        'End Property
        Public ReadOnly Property Firm_Net_Remit_Curr_Period() As String
            Get
                Return Values(FieldList.Firm_Net_Remit_Curr_Period)
            End Get
        End Property
        Public ReadOnly Property Firm_Net_Remit_YTD() As String
            Get
                Return Values(FieldList.Firm_Net_Remit_YTD)
            End Get
        End Property
        Public ReadOnly Property Firm_Asst_Alloc_Curr_Period() As String
            Get
                Return Values(FieldList.Firm_Asst_Alloc_Curr_Period)
            End Get
        End Property
        Public ReadOnly Property Firm_Fees_Curr_Period() As String
            Get
                Return Values(FieldList.Firm_Fees_Curr_Period)
            End Get
        End Property
        Public ReadOnly Property Firm_Fees_YTD() As String
            Get
                Return Values(FieldList.Firm_Fees_YTD)
            End Get
        End Property
        Public ReadOnly Property IMO_Ind() As String
            Get
                Return Values(FieldList.IMO_Ind).Replace("""", "").Trim()
            End Get
        End Property

#End Region

#Region " OVERRIDES "

#End Region

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
        Public Sub New(ByVal FieldList As List(Of String))
            MyBase.New("~"c, FieldList)
        End Sub

#End Region

    End Class
#End Region

#Region "COMM702"
    <Serializable()>
    Public Class COMM702
        Inherits SourceDef

#Region " FIELD ARRAY ENUM "
        Public Enum FieldList
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
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE).Replace("""", "").Trim()
            End Get
        End Property
        Public ReadOnly Property PROD_NAME() As String
            Get
                Return Values(FieldList.PROD_NAME)
            End Get
        End Property
        Public ReadOnly Property PROD_CODE() As String
            Get
                Return Values(FieldList.PROD_CODE)
            End Get
        End Property
        Public ReadOnly Property PROD_ERND_COMM_PERIOD() As String
            Get
                Return Values(FieldList.PROD_ERND_COMM_PERIOD)
            End Get
        End Property
        Public ReadOnly Property PROD_ADV_PMTS_PERIOD() As String
            Get
                Return Values(FieldList.PROD_ADV_PMTS_PERIOD)
            End Get
        End Property
        Public ReadOnly Property PROD_ANNZ_PMTS_PERIOD() As String
            Get
                Return Values(FieldList.PROD_ANNZ_PMTS_PERIOD)
            End Get
        End Property
        Public ReadOnly Property PROD_RECOVERIES_PERIOD() As String
            Get
                Return Values(FieldList.PROD_RECOVERIES_PERIOD)
            End Get
        End Property
        Public ReadOnly Property PROD_ASSET_BASED_COMM_PERIOD() As String
            Get
                Return Values(FieldList.PROD_ASSET_BASED_COMM_PERIOD)
            End Get
        End Property
        Public ReadOnly Property PROD_MISC_PERIOD() As String
            Get
                Return Values(FieldList.PROD_MISC_PERIOD)
            End Get
        End Property
        Public ReadOnly Property PROD_REMIT_PERIOD() As String
            Get
                Return Values(FieldList.PROD_REMIT_PERIOD)
            End Get
        End Property
        Public ReadOnly Property PROD_ISSUING_COMPANY() As String
            Get
                Return Values(FieldList.PROD_ISSUING_COMPANY)
            End Get
        End Property
        Public ReadOnly Property PROD_FEES_PERIOD() As String
            Get
                Return Values(FieldList.PROD_FEES_PERIOD).Replace("""", "").Trim()
            End Get
        End Property
#End Region

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
        Public Sub New(ByVal FieldList As List(Of String))
            MyBase.New("~"c, FieldList)
        End Sub

#End Region

    End Class
#End Region

#Region "COMM703"
    <Serializable()>
    Public Class COMM703
        Inherits SourceDef

#Region " PRIVATE PROPERTIES "

#End Region

#Region " PRIVATE METHODS "

#End Region

#Region " FIELD ARRAY ENUM "
        Public Enum FieldList
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
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE).Replace("""", "").Trim()
            End Get
        End Property
        Public ReadOnly Property Firm_Product_Name() As String
            Get
                Return Values(FieldList.Firm_Product_Name)
            End Get
        End Property
        Public ReadOnly Property Firm_Product_Code() As String
            Get
                Return Values(FieldList.Firm_Product_Code)
            End Get
        End Property
        Public ReadOnly Property Firm_Ernd_Comm_YTD() As String
            Get
                Return Values(FieldList.Firm_Ernd_Comm_YTD)
            End Get
        End Property
        Public ReadOnly Property Firm_Adv_Pmts_YTD() As String
            Get
                Return Values(FieldList.Firm_Adv_Pmts_YTD)
            End Get
        End Property
        Public ReadOnly Property Firm_Annz_Pmts_YTD() As String
            Get
                Return Values(FieldList.Firm_Annz_Pmts_YTD)
            End Get
        End Property
        Public ReadOnly Property Firm_ChgBks_YTD() As String
            Get
                Return Values(FieldList.Firm_ChgBks_YTD)
            End Get
        End Property
        Public ReadOnly Property Firm_Asset_Based_YTD() As String
            Get
                Return Values(FieldList.Firm_Asset_Based_YTD)
            End Get
        End Property
        Public ReadOnly Property Firm_Misc_YTD() As String
            Get
                Return Values(FieldList.Firm_Misc_YTD)
            End Get
        End Property
        Public ReadOnly Property Firm_Net_Remit_YTD() As String
            Get
                Return Values(FieldList.Firm_Net_Remit_YTD)
            End Get
        End Property
        Public ReadOnly Property Firm_Issu_Company() As String
            Get
                Return Values(FieldList.Firm_Issu_Company).Replace("""", "").Trim()
            End Get
        End Property

#End Region

#Region " OVERRIDES "

#End Region

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
        Public Sub New(ByVal FieldList As List(Of String))
            MyBase.New("~"c, FieldList)
        End Sub

#End Region

    End Class
#End Region

#Region "COMM704"
    <Serializable()>
    Public Class COMM704
        Inherits SourceDef

#Region " PRIVATE PROPERTIES "

#End Region

#Region " PRIVATE METHODS "

#End Region

#Region " FIELD ARRAY ENUM "
        Public Enum FieldList
            REC_TYPE
            Firm_EXT_ID
            Firm_Name
            Firm_Alt_ID
            Firm_Tax_ID
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE).Replace("""", "").Trim()
            End Get
        End Property
        Public ReadOnly Property Firm_EXT_ID() As String
            Get
                Return Values(FieldList.Firm_EXT_ID)
            End Get
        End Property
        Public ReadOnly Property Firm_Name() As String
            Get
                Return Values(FieldList.Firm_Name)
            End Get
        End Property
        Public ReadOnly Property Firm_Alt_ID() As String
            Get
                Return Values(FieldList.Firm_Alt_ID)
            End Get
        End Property
        Public ReadOnly Property Firm_Tax_ID() As String
            Get
                Return Values(FieldList.Firm_Tax_ID).Replace("""", "").Trim()
            End Get
        End Property

#End Region

#Region " OVERRIDES "

#End Region

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
        Public Sub New(ByVal FieldList As List(Of String))
            MyBase.New("~"c, FieldList)
        End Sub

#End Region

    End Class
#End Region

#Region "COMM706"
    <Serializable()>
    Public Class COMM706
        Inherits SourceDef

#Region " PRIVATE PROPERTIES "

#End Region

#Region " PRIVATE METHODS "

#End Region

#Region " FIELD ARRAY ENUM "
        Public Enum FieldList
            REC_TYPE
            Contract_Num
            Contract_Own_Name
            Contract_Prod_Code
            Contract_Tran_Code
            Contract_Pmt_Amt
            Field1
            Field2
            Contract_Firm_Comm_Amt
            Contract_Rep_Comm_Amt
            Contract_Firm_Comm_Rate
            Contract_Rep_Comm_Rate
            Contract_Owner_Age
            Contract_Pmt_date

        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE).Replace("""", "").Trim()
            End Get
        End Property
        Public ReadOnly Property Contract_Num() As String
            Get
                Return Values(FieldList.Contract_Num)
            End Get
        End Property
        Public ReadOnly Property Contract_Own_Name() As String
            Get
                Return Values(FieldList.Contract_Own_Name)
            End Get
        End Property
        Public ReadOnly Property Contract_Prod_Code() As String
            Get
                Return Values(FieldList.Contract_Prod_Code)
            End Get
        End Property
        Public ReadOnly Property Contract_Tran_Code() As String
            Get
                Return Values(FieldList.Contract_Tran_Code)
            End Get
        End Property
        Public ReadOnly Property Contract_Pmt_Amt() As String
            Get
                Return Values(FieldList.Contract_Pmt_Amt)
            End Get
        End Property

        Public ReadOnly Property Field1() As String
            Get
                Return Values(FieldList.Field1)
            End Get
        End Property
        Public ReadOnly Property Field2() As String
            Get
                Return Values(FieldList.Field2)
            End Get
        End Property
        Public ReadOnly Property Contract_Firm_Comm_Amt() As String
            Get
                Return Values(FieldList.Contract_Firm_Comm_Amt)
            End Get
        End Property
        Public ReadOnly Property Contract_Rep_Comm_Amt() As String
            Get
                Return Values(FieldList.Contract_Rep_Comm_Amt)
            End Get
        End Property
        Public ReadOnly Property Contract_Firm_Comm_Rate() As String
            Get
                Return Values(FieldList.Contract_Firm_Comm_Rate)
            End Get
        End Property
        Public ReadOnly Property Contract_Rep_Comm_Rate() As String
            Get
                Return Values(FieldList.Contract_Rep_Comm_Rate)
            End Get
        End Property
        Public ReadOnly Property Contract_Owner_Age() As String
            Get
                Return Values(FieldList.Contract_Owner_Age)
            End Get
        End Property
        Public ReadOnly Property Contract_Pmt_date() As String
            Get
                Return Values(FieldList.Contract_Pmt_date).Replace("""", "").Trim()
            End Get
        End Property

#End Region

#Region " OVERRIDES "

#End Region

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
        Public Sub New(ByVal FieldList As List(Of String))
            MyBase.New("~"c, FieldList)
        End Sub

#End Region

    End Class
#End Region

#Region "COMM719"
    <Serializable()>
    Public Class COMM719
        Inherits SourceDef

#Region " PRIVATE PROPERTIES "

#End Region

#Region " PRIVATE METHODS "

#End Region

#Region " FIELD ARRAY ENUM "
        Public Enum FieldList
            REC_TYPE
            Iss_Comp_Short_Name
            Iss_Comp_Long_Name

        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE).Replace("""", "").Trim()
            End Get
        End Property
        Public ReadOnly Property Iss_Comp_Short_Name() As String
            Get
                Return Values(FieldList.Iss_Comp_Short_Name)
            End Get
        End Property
        Public ReadOnly Property Iss_Comp_Long_Name() As String
            Get
                Return Values(FieldList.Iss_Comp_Long_Name).Replace("""", "").Trim()
            End Get
        End Property

#End Region

#Region " OVERRIDES "

#End Region

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
        Public Sub New(ByVal FieldList As List(Of String))
            MyBase.New("~"c, FieldList)
        End Sub

#End Region

    End Class
#End Region

#End Region

#Region " POST_HEADER "

    <Serializable()>
    Public Class POST_HEADER
        Inherits SourceDef

#Region " PRIVATE PROPERTIES "

#End Region

#Region " PRIVATE METHODS "

#End Region

#Region " FIELD ARRAY ENUM "

        Public Enum FieldList
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

#End Region

#Region " PUBLIC PROPERTIES "


#End Region

#Region " OVERRIDES "

#End Region

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
        Public Sub New(ByVal FieldList As List(Of String))
            MyBase.New("~"c, FieldList)
        End Sub

#End Region

    End Class
#End Region

End Namespace


