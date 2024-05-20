Imports Se2.ISI.Base.Presentation

Namespace Se2.ISCORSP.Client.GLCO.SoA.Records


#Region " PoC Records "

#Region "HEADER "

    <Serializable()>
    Public Class HeaderDetail
        Inherits RecordDef


        Private Shadows Enum FieldList
            RecType
            FileName
            DateTime
            RecordCount
        End Enum


#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.DET
            ' FieldPrefix = """"
            ' FieldSuffix = """"
            Delimiter = "|"c
            Terminator = "" 'vbCrLf
            Initialize()

        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("RecordCount", "", FieldType.String, "", "F:Record_Count"))
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property RecType() As FieldDef
            Get
                Return Fields(FieldList.RecType)
            End Get
        End Property
        Public ReadOnly Property FileName() As FieldDef
            Get
                Return Fields(FieldList.FileName)
            End Get
        End Property
        Public ReadOnly Property DateTime() As FieldDef
            Get
                Return Fields(FieldList.DateTime)
            End Get
        End Property
        Public ReadOnly Property RecordCount() As FieldDef
            Get
                Return Fields(FieldList.RecordCount)
            End Get
        End Property
#End Region
    End Class
#End Region

#Region " 100 Statement Header"
    Public Class REC_100_Statement_Header
        Inherits RecordDef

        Private Shadows Enum FieldList
            Rec_ID
            Stmt_Key_Text
            Dsgn_Code
            Plan_Code
            Role_ID
            Agent_Code
            Rep_Prsrt1_Text
            Sort1_Text
            Sort2_Text
            Sort3_Text
            Spcl_Hndlng_Code
            User_Rqst_ID
            Mail_State_Code
            Mail_Zip_Code
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.DET
            FieldPrefix = Chr(34)
            FieldSuffix = Chr(34)
            Terminator = vbCrLf
            RecordChunk.ProcessEachRow = True
            Initialize()
            'MyBase.Length = 404
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("Rec_ID", "S:100"))
                .Add(New FieldDef("Stmt_Key_Text", "CONT"))
                .Add(New FieldDef("Dsgn_Code", "F:Dsgn_Code"))
                .Add(New FieldDef("Plan_Code", "F:PLN_CODE"))
                .Add(New FieldDef("Role_ID", "F:ROLE_ID"))
                .Add(New FieldDef("Agent_Code", "F:REP_MASTER_NUMBER"))
                .Add(New FieldDef("Rep_Prsrt1_Text", "S:"))
                .Add(New FieldDef("Sort1_Text", "F:LST"))
                .Add(New FieldDef("Sort2_Text", "F:FST"))
                .Add(New FieldDef("Sort3_Text", "F:GET_SORT3"))
                .Add(New FieldDef("Spcl_Hndlng_Code", "S:"))
                .Add(New FieldDef("User_Rqst_ID", "S:"))
                .Add(New FieldDef("Mail_State_Code", "F:STATE_CODE"))
                .Add(New FieldDef("Mail_Zip_Code", "F:ZIP"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property Rec_ID As FieldDef
            Get
                Return Fields(FieldList.Rec_ID)
            End Get
        End Property
        Public ReadOnly Property Stmt_Key_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Key_Text)
            End Get
        End Property
        Public ReadOnly Property Dsgn_Code As FieldDef
            Get
                Return Fields(FieldList.Dsgn_Code)
            End Get
        End Property
        Public ReadOnly Property Plan_Code As FieldDef
            Get
                Return Fields(FieldList.Plan_Code)
            End Get
        End Property
        Public ReadOnly Property Role_ID As FieldDef
            Get
                Return Fields(FieldList.Role_ID)
            End Get
        End Property
        Public ReadOnly Property Agent_Code As FieldDef
            Get
                Return Fields(FieldList.Agent_Code)
            End Get
        End Property
        Public ReadOnly Property Rep_Prsrt1_Text As FieldDef
            Get
                Return Fields(FieldList.Rep_Prsrt1_Text)
            End Get
        End Property
        Public ReadOnly Property Sort1_Text As FieldDef
            Get
                Return Fields(FieldList.Sort1_Text)
            End Get
        End Property
        Public ReadOnly Property Sort2_Text As FieldDef
            Get
                Return Fields(FieldList.Sort2_Text)
            End Get
        End Property
        Public ReadOnly Property Sort3_Text As FieldDef
            Get
                Return Fields(FieldList.Sort3_Text)
            End Get
        End Property
        Public ReadOnly Property Spcl_Hndlng_Code As FieldDef
            Get
                Return Fields(FieldList.Spcl_Hndlng_Code)
            End Get
        End Property
        Public ReadOnly Property User_Rqst_ID As FieldDef
            Get
                Return Fields(FieldList.User_Rqst_ID)
            End Get
        End Property
        Public ReadOnly Property Mail_State_Code As FieldDef
            Get
                Return Fields(FieldList.Mail_State_Code)
            End Get
        End Property
        Public ReadOnly Property Mail_Zip_Code As FieldDef
            Get
                Return Fields(FieldList.Mail_Zip_Code)
            End Get
        End Property
#End Region

#Region " METHODS "

#End Region
    End Class


#End Region

#Region " 51 Sort Key "

    Public Class REC_51_Sort_Key
        Inherits RecordDef

        Private Shadows Enum FieldList
            Rec_ID
            Sort_Type_Code
            Role_Num
            Sheet_Group_Code
            Role_Key_Text
            Stmt_Key_Text
            Sprtr_Cntrl_Code
            Asc_Group_Doc_Cnt
            Cust_Name
            DSC_GROUP_DOC_CNT
            Base_File_Name
            DateTimeStamp
            Asc_Group_Doc_Cnt2
            Brkr_Num
            Brkr_Name
            Rep_Num
            Rep_Name
            Cust_Prnt_Ind
            Cust_Arc_Ind
            Brkr_CD_Ind
            Rep_CD_Ind
            Rep_Arc_Ind
            Env_Type_Code
            Web_Archv_Ind
            Cust_Web_Arc_Ind
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.DET
            FieldPrefix = Chr(34)
            FieldSuffix = Chr(34)
            Terminator = vbCrLf
            RecordChunk.ProcessEachRow = True
            Initialize()
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("Rec_ID", "S:051"))
                .Add(New FieldDef("Sort_Type_Code", "F:Sort_Type"))
                .Add(New FieldDef("Role_Num", "S:1"))
                .Add(New FieldDef("Sheet_Group_Code", "S:1"))
                .Add(New FieldDef("Role_Key_Text", "F:GET_CUST_NAME"))
                .Add(New FieldDef("Stmt_Key_Text", "CONT"))
                .Add(New FieldDef("Sprtr_Cntrl_Code", "F:SPRTR_CNTRL_CODE"))
                .Add(New FieldDef("Asc_Group_Doc_Cnt", "S:000001"))
                .Add(New FieldDef("Cust_Name", "F:GET_CUST_NAME"))
                .Add(New FieldDef("Dsc_Group_Doc_Cnt", "S:000001"))
                .Add(New FieldDef("Base_File_Name", "F:Base_File_Name"))
                .Add(New FieldDef("DateTimeStamp", "F:DateTimeStamp"))
                .Add(New FieldDef("Asc_Group_Doc_Cnt2", "S:1"))
                .Add(New FieldDef("Brkr_Num", "BRKR_MASTER_NUMBER"))
                .Add(New FieldDef("Brkr_Name", "F:GET_BRKR_NAME"))
                .Add(New FieldDef("Rep_Num", "REP_MASTER_NUMBER"))
                .Add(New FieldDef("Rep_Name", "F:GET_REP_NAME"))
                .Add(New FieldDef("Cust_Prnt_Ind", "S:Y"))
                .Add(New FieldDef("Cust_Arc_Ind", "S:Y"))
                .Add(New FieldDef("Brkr_CD_Ind", "S:N"))
                .Add(New FieldDef("Rep_CD_Ind", "S:N"))
                .Add(New FieldDef("Rep_Arc_Ind", "S:N"))
                .Add(New FieldDef("Env_Type_Code", "S:MWDBL"))
                .Add(New FieldDef("Web_Archv_Ind", "S:N"))
                .Add(New FieldDef("Cust_Web_Arc_Ind", "S:N"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property Rec_ID As FieldDef
            Get
                Return Fields(FieldList.Rec_ID)
            End Get
        End Property
        Public ReadOnly Property Sort_Type_Code As FieldDef
            Get
                Return Fields(FieldList.Sort_Type_Code)
            End Get
        End Property
        Public ReadOnly Property Role_Num As FieldDef
            Get
                Return Fields(FieldList.Role_Num)
            End Get
        End Property
        Public ReadOnly Property Sheet_Group_Code As FieldDef
            Get
                Return Fields(FieldList.Sheet_Group_Code)
            End Get
        End Property
        Public ReadOnly Property Role_Key_Text As FieldDef
            Get
                Return Fields(FieldList.Role_Key_Text)
            End Get
        End Property
        Public ReadOnly Property Stmt_Key_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Key_Text)
            End Get
        End Property
        Public ReadOnly Property Sprtr_Cntrl_Code As FieldDef
            Get
                Return Fields(FieldList.Sprtr_Cntrl_Code)
            End Get
        End Property
        Public ReadOnly Property Asc_Group_Doc_Cnt As FieldDef
            Get
                Return Fields(FieldList.Asc_Group_Doc_Cnt)
            End Get
        End Property
        Public ReadOnly Property Cust_Name As FieldDef
            Get
                Return Fields(FieldList.Cust_Name)
            End Get
        End Property
        Public ReadOnly Property Dsc_Group_Doc_Cnt As FieldDef
            Get
                Return Fields(FieldList.DSC_GROUP_DOC_CNT)
            End Get
        End Property

        Public ReadOnly Property Base_File_Name As FieldDef
            Get
                Return Fields(FieldList.Base_File_Name)
            End Get
        End Property
        Public ReadOnly Property DateTimeStamp As FieldDef
            Get
                Return Fields(FieldList.DateTimeStamp)
            End Get
        End Property
        Public ReadOnly Property Asc_Group_Doc_Cnt2 As FieldDef
            Get
                Return Fields(FieldList.Asc_Group_Doc_Cnt2)
            End Get
        End Property
        Public ReadOnly Property Brkr_Num As FieldDef
            Get
                Return Fields(FieldList.Brkr_Num)
            End Get
        End Property
        Public ReadOnly Property Brkr_Name As FieldDef
            Get
                Return Fields(FieldList.Brkr_Name)
            End Get
        End Property
        Public ReadOnly Property Rep_Num As FieldDef
            Get
                Return Fields(FieldList.Rep_Num)
            End Get
        End Property
        Public ReadOnly Property Rep_Name As FieldDef
            Get
                Return Fields(FieldList.Rep_Name)
            End Get
        End Property
        Public ReadOnly Property Cust_Prnt_Ind As FieldDef
            Get
                Return Fields(FieldList.Cust_Prnt_Ind)
            End Get
        End Property
        Public ReadOnly Property Cust_Arc_Ind As FieldDef
            Get
                Return Fields(FieldList.Cust_Arc_Ind)
            End Get
        End Property
        Public ReadOnly Property Brkr_CD_Ind As FieldDef
            Get
                Return Fields(FieldList.Brkr_CD_Ind)
            End Get
        End Property
        Public ReadOnly Property Rep_CD_Ind As FieldDef
            Get
                Return Fields(FieldList.Rep_CD_Ind)
            End Get
        End Property
        Public ReadOnly Property Rep_Arc_Ind As FieldDef
            Get
                Return Fields(FieldList.Rep_Arc_Ind)
            End Get
        End Property
        Public ReadOnly Property Env_Type_Code As FieldDef
            Get
                Return Fields(FieldList.Env_Type_Code)
            End Get
        End Property
        Public ReadOnly Property Web_Archv_Ind As FieldDef
            Get
                Return Fields(FieldList.Web_Archv_Ind)
            End Get
        End Property
        Public ReadOnly Property Cust_Web_Arc_Ind As FieldDef
            Get
                Return Fields(FieldList.Cust_Web_Arc_Ind)
            End Get
        End Property
#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " 52 Separator "

    Public Class REC_52_Separator
        Inherits RecordDef

        Private Shadows Enum FieldList
            Rec_ID
            Stmt_Addr_Line1_Text
            Stmt_Addr_Line2_Text
            Stmt_Addr_Line3_Text
            Stmt_Addr_Line4_Text
            Stmt_Addr_Line5_Text
            Stmt_Addr_Line6_Text
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.DET
            FieldPrefix = Chr(34)
            FieldSuffix = Chr(34)
            Terminator = vbCrLf
            Initialize()
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("Rec_ID", "S:052"))
                .Add(New FieldDef("Stmt_Addr_Line1_Text", "F:Name"))
                .Add(New FieldDef("Stmt_Addr_Line2_Text", "F:Address1"))
                .Add(New FieldDef("Stmt_Addr_Line3_Text", "F:Address2"))
                .Add(New FieldDef("Stmt_Addr_Line4_Text", "F:Address3"))
                .Add(New FieldDef("Stmt_Addr_Line5_Text", "F:Address4"))
                .Add(New FieldDef("Stmt_Addr_Line6_Text", "S:"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property Rec_ID As FieldDef
            Get
                Return Fields(FieldList.Rec_ID)
            End Get
        End Property
        Public ReadOnly Property Stmt_Addr_Line1_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Addr_Line1_Text)
            End Get
        End Property
        Public ReadOnly Property Stmt_Addr_Line2_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Addr_Line2_Text)
            End Get
        End Property
        Public ReadOnly Property Stmt_Addr_Line3_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Addr_Line3_Text)
            End Get
        End Property
        Public ReadOnly Property Stmt_Addr_Line4_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Addr_Line4_Text)
            End Get
        End Property
        Public ReadOnly Property Stmt_Addr_Line5_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Addr_Line5_Text)
            End Get
        End Property
        Public ReadOnly Property Stmt_Addr_Line6_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Addr_Line6_Text)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " 101 File Header "

    Public Class REC_101_File_Header
        Inherits RecordDef

        Private Shadows Enum FieldList
            Rec_ID
            Stmt_Key_Text
            Stmt_Begin_Date
            Stmt_End_Date
            Stmt_Year_Begin_Date
            Stmt_Qtr_Begin_Date
            Stmt_Month1_Name
            Stmt_Month2_Name
            Stmt_Month3_Name
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.DET
            FieldPrefix = Chr(34)
            FieldSuffix = Chr(34)
            Terminator = vbCrLf
            Initialize()
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("Rec_ID", "S:101"))
                .Add(New FieldDef("Stmt_Key_Text", "CONT"))
                .Add(New FieldDef("Stmt_Begin_Date", "F:Begin_Date"))
                .Add(New FieldDef("Stmt_End_Date", "", FieldType.Date, "yyyyMMdd", "CYCLE_DATE"))
                .Add(New FieldDef("Stmt_Year_Begin_Date", "F:Year_Begin_Date"))
                .Add(New FieldDef("Stmt_Qtr_Begin_Date", "F:Qtr_Begin_Date"))
                .Add(New FieldDef("Stmt_Month1_Name", "F:Stmt_Month1"))
                .Add(New FieldDef("Stmt_Month2_Name", "F:Stmt_Month2"))
                .Add(New FieldDef("Stmt_Month3_Name", "F:Stmt_Month3"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property Rec_ID As FieldDef
            Get
                Return Fields(FieldList.Rec_ID)
            End Get
        End Property
        Public ReadOnly Property Stmt_Key_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Key_Text)
            End Get
        End Property
        Public ReadOnly Property Stmt_Begin_Date As FieldDef
            Get
                Return Fields(FieldList.Stmt_Begin_Date)
            End Get
        End Property
        Public ReadOnly Property Stmt_End_Date As FieldDef
            Get
                Return Fields(FieldList.Stmt_End_Date)
            End Get
        End Property
        Public ReadOnly Property Stmt_Year_Begin_Date As FieldDef
            Get
                Return Fields(FieldList.Stmt_Year_Begin_Date)
            End Get
        End Property
        Public ReadOnly Property Stmt_Qtr_Begin_Date As FieldDef
            Get
                Return Fields(FieldList.Stmt_Qtr_Begin_Date)
            End Get
        End Property
        Public ReadOnly Property Stmt_Month1_Name As FieldDef
            Get
                Return Fields(FieldList.Stmt_Month1_Name)
            End Get
        End Property
        Public ReadOnly Property Stmt_Month2_Name As FieldDef
            Get
                Return Fields(FieldList.Stmt_Month2_Name)
            End Get
        End Property
        Public ReadOnly Property Stmt_Month3_Name As FieldDef
            Get
                Return Fields(FieldList.Stmt_Month3_Name)
            End Get
        End Property
#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

    '#Region " 102 Inserter Set-up "

    'Public Class REC_102_Inserter_SetUp
    '    Inherits RecordDef

    '    Private Shadows Enum FieldList
    '        Rec_ID
    '        Stmt_Key_Text
    '        Insrtr_Stn_Num
    '        Stck_Desc
    '        Stck_Num
    '    End Enum

    '#Region " CONSTRUCTORS "
    '    Public Sub New()
    '        MyBase.New(PresentationFormat.Delimited)
    '        Type = RecordType.DET
    '        FieldPrefix = Chr(34)
    '        FieldSuffix = Chr(34)
    '        Terminator = vbCrLf
    '        Initialize()
    '    End Sub

    '    Private Sub Initialize()
    '        Fields = New List(Of FieldDef)
    '        With Fields
    '            .Add(New FieldDef("Rec_ID", Pad.Right, FieldType.String, " "c, "S:102"))
    '            .Add(New FieldDef("Stmt_Key_Text", Pad.Right, FieldType.String, " "c, "CONT"))
    '            .Add(New FieldDef("Insrtr_Stn_Num", "S:C"))
    '            .Add(New FieldDef("Stck_Desc", Pad.Right, FieldType.String, " "c, "S:"))
    '            .Add(New FieldDef("Stck_Num", Pad.Right, FieldType.String, " "c, "S:"))
    '        End With
    '    End Sub
    '#End Region

    '#Region " PROPERTIES "
    '    Public ReadOnly Property Rec_ID As FieldDef
    '        Get
    '            Return Fields(FieldList.Rec_ID)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Stmt_Key_Text As FieldDef
    '        Get
    '            Return Fields(FieldList.Stmt_Key_Text)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Insrtr_Stn_Num As FieldDef
    '        Get
    '            Return Fields(FieldList.Insrtr_Stn_Num)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Stck_Desc As FieldDef
    '        Get
    '            Return Fields(FieldList.Stck_Desc)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Stck_Num As FieldDef
    '        Get
    '            Return Fields(FieldList.Stck_Num)
    '        End Get
    '    End Property
    '#End Region

    '#Region " METHODS "

    '#End Region
    '    End Class

    '#End Region

#Region " 55 Mailing Label "

    Public Class REC_55_Mailing_Label
        Inherits RecordDef

        Private Shadows Enum FieldList
            Rec_ID
            Sort_Type_Code
            Role_Num
            Finder_Record
            Stmt_Key_Text
            Addr_Line1_Text
            Addr_Line2_Text
            Addr_Line3_Text
            Addr_Line4_Text
            Addr_Line5_Text
            Addr_Line6_Text
            Base_File_Name
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.DET
            FieldPrefix = Chr(34)
            FieldSuffix = Chr(34)
            Terminator = vbCrLf
            Initialize()
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("Rec_ID", "S:055"))
                .Add(New FieldDef("Sort_Type_Code", "F:Sort_Type"))
                .Add(New FieldDef("Role_Num", "S:1"))
                .Add(New FieldDef("Finder_Record", "S:"))
                .Add(New FieldDef("Stmt_Key_Text", "CONT"))
                .Add(New FieldDef("Addr_Line1_Text", "F:Name"))
                .Add(New FieldDef("Addr_Line2_Text", "F:Address1"))
                .Add(New FieldDef("Addr_Line3_Text", "F:Address2"))
                .Add(New FieldDef("Addr_Line4_Text", "F:Address3"))
                .Add(New FieldDef("Addr_Line5_Text", "F:Address4"))
                .Add(New FieldDef("Addr_Line6_Text", "S:"))
                .Add(New FieldDef("Base_File_Name", "F:Base_File_Name"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property Rec_ID As FieldDef
            Get
                Return Fields(FieldList.Rec_ID)
            End Get
        End Property
        Public ReadOnly Property Sort_Type_Code As FieldDef
            Get
                Return Fields(FieldList.Sort_Type_Code)
            End Get
        End Property
        Public ReadOnly Property Role_Num As FieldDef
            Get
                Return Fields(FieldList.Role_Num)
            End Get
        End Property
        Public ReadOnly Property Finder_Record As FieldDef
            Get
                Return Fields(FieldList.Finder_Record)
            End Get
        End Property
        Public ReadOnly Property Stmt_Key_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Key_Text)
            End Get
        End Property
        Public ReadOnly Property Addr_Line1_Text As FieldDef
            Get
                Return Fields(FieldList.Addr_Line1_Text)
            End Get
        End Property
        Public ReadOnly Property Addr_Line2_Text As FieldDef
            Get
                Return Fields(FieldList.Addr_Line2_Text)
            End Get
        End Property
        Public ReadOnly Property Addr_Line3_Text As FieldDef
            Get
                Return Fields(FieldList.Addr_Line3_Text)
            End Get
        End Property
        Public ReadOnly Property Addr_Line4_Text As FieldDef
            Get
                Return Fields(FieldList.Addr_Line4_Text)
            End Get
        End Property
        Public ReadOnly Property Addr_Line5_Text As FieldDef
            Get
                Return Fields(FieldList.Addr_Line5_Text)
            End Get
        End Property
        Public ReadOnly Property Addr_Line6_Text As FieldDef
            Get
                Return Fields(FieldList.Addr_Line6_Text)
            End Get
        End Property
        Public ReadOnly Property Base_File_Name As FieldDef
            Get
                Return Fields(FieldList.Base_File_Name)
            End Get
        End Property
#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " 225 Statement Heading "

    Public Class REC_225_Statement_Heading
        Inherits RecordDef

        Private Shadows Enum FieldList
            Rec_ID
            Stmt_Key_Text
            Src_Prdct_Text
            Index1_Text
            Index2_Text
            Hdr_Image_Path_Text
            Hdr_Image_Name
            Ftr_Path_Text
            Ftr_Name
            Stmt_Addr_Line1_Text
            Stmt_Addr_Line2_Text
            Stmt_Addr_Line3_Text
            Stmt_Addr_Line4_Text
            Stmt_Addr_Line5_Text
            Stmt_Addr_Line6_Text
            PostNet_Barcd_Rule_Text
            Rep_Name
            Rep_Addr_Line2_Text
            Rep_Addr_Line3_Text
            Rep_Addr_Line4_Text
            Rep_Addr_Line5_Text
            Rep_Addr_Line6_Text
            Rep_Phone_Text
            Hdng_Line2_Text
            Anntnt_Name
            Issue_Date
            Cntrct_Num
            Tax_Ctgry_Text
            Loan_Ind
            Cash_Srrndr_Val
            Pol_Num
            Prcssng_Co_Id
            Prdct_Co_Id
            Brkr_Name
            Accuml_Val
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.DET
            FieldPrefix = Chr(34)
            FieldSuffix = Chr(34)
            Terminator = vbCrLf
            Initialize()
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("Rec_ID", "S:225"))
                .Add(New FieldDef("Stmt_Key_Text", "CONT"))
                .Add(New FieldDef("Src_Prdct_Text", "PLN_CODE"))
                .Add(New FieldDef("Index1_Text", "F:RepIndexText"))
                .Add(New FieldDef("Index2_Text", "F:BrkrIndexText"))
                .Add(New FieldDef("Hdr_Image_Path_Text", "S:E:\RESOURCES\MODERNWOODMEN\IMAGES\"))
                .Add(New FieldDef("Hdr_Image_Name", "S:SOAMWA"))
                .Add(New FieldDef("Ftr_Path_Text", "S:E:\RESOURCES\MODERNWOODMEN\RTFS\"))
                .Add(New FieldDef("Ftr_Name", "S:FTRMODWD.rtf"))
                .Add(New FieldDef("Stmt_Addr_Line1_Text", "F:Name"))
                .Add(New FieldDef("Stmt_Addr_Line2_Text", "F:Address1"))
                .Add(New FieldDef("Stmt_Addr_Line3_Text", "F:Address2"))
                .Add(New FieldDef("Stmt_Addr_Line4_Text", "F:Address3"))
                .Add(New FieldDef("Stmt_Addr_Line5_Text", "F:Address4"))
                .Add(New FieldDef("Stmt_Addr_Line6_Text", "S:"))
                .Add(New FieldDef("PostNet_Barcd_Rule_Text", "S:"))
                .Add(New FieldDef("Rep_Name", "F:GET_REP_NAME"))
                .Add(New FieldDef("Rep_Addr_Line2_Text", "F:REP_Address1"))
                .Add(New FieldDef("Rep_Addr_Line3_Text", "F:REP_Address2"))
                .Add(New FieldDef("Rep_Addr_Line4_Text", "F:REP_Address3"))
                .Add(New FieldDef("Rep_Addr_Line5_Text", "F:REP_Address4"))
                .Add(New FieldDef("Rep_Addr_Line6_Text", "S:"))
                .Add(New FieldDef("Rep_Phone_Text", "S:")) 'NOT POPULATED BY CORSP "F:GET_REP_PHONE"))
                .Add(New FieldDef("Hdng_Line2_Text", "S:Modern Woodmen Flexible Premium Variable Annuity"))
                .Add(New FieldDef("Anntnt_Name", "F:AnntName"))
                .Add(New FieldDef("Issue_Date", "", FieldType.Date, "yyyyMMdd", "ISSUE_DATE"))
                .Add(New FieldDef("Cntrct_Num", "CONT"))
                .Add(New FieldDef("Tax_Ctgry_Text", "QUAL_DESC"))
                .Add(New FieldDef("Loan_Ind", "S:N")) 'All No for MWA
                .Add(New FieldDef("Cash_Srrndr_Val", "EOQ_CASH_VALUE"))
                .Add(New FieldDef("Pol_Num", "POL_NUM"))
                .Add(New FieldDef("Prcssng_Co_Id", "S:10"))
                .Add(New FieldDef("Prdct_Co_Id", "S:28"))
                .Add(New FieldDef("Brkr_Name", "F:GET_BRKR_NAME"))
                .Add(New FieldDef("Accuml_Val", "EOQ_ACCOUNTVAL"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property Rec_ID As FieldDef
            Get
                Return Fields(FieldList.Rec_ID)
            End Get
        End Property
        Public ReadOnly Property Stmt_Key_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Key_Text)
            End Get
        End Property
        Public ReadOnly Property Src_Prdct_Text As FieldDef
            Get
                Return Fields(FieldList.Src_Prdct_Text)
            End Get
        End Property
        Public ReadOnly Property Index1_Text As FieldDef
            Get
                Return Fields(FieldList.Index1_Text)
            End Get
        End Property
        Public ReadOnly Property Index2_Text As FieldDef
            Get
                Return Fields(FieldList.Index2_Text)
            End Get
        End Property
        Public ReadOnly Property Hdr_Image_Path_Text As FieldDef
            Get
                Return Fields(FieldList.Hdr_Image_Path_Text)
            End Get
        End Property
        Public ReadOnly Property Hdr_Image_Name As FieldDef
            Get
                Return Fields(FieldList.Hdr_Image_Name)
            End Get
        End Property
        Public ReadOnly Property Ftr_Path_Text As FieldDef
            Get
                Return Fields(FieldList.Ftr_Path_Text)
            End Get
        End Property
        Public ReadOnly Property Ftr_Name As FieldDef
            Get
                Return Fields(FieldList.Ftr_Name)
            End Get
        End Property
        Public ReadOnly Property Stmt_Addr_Line1_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Addr_Line1_Text)
            End Get
        End Property
        Public ReadOnly Property Stmt_Addr_Line2_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Addr_Line2_Text)
            End Get
        End Property
        Public ReadOnly Property Stmt_Addr_Line3_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Addr_Line3_Text)
            End Get
        End Property
        Public ReadOnly Property Stmt_Addr_Line4_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Addr_Line4_Text)
            End Get
        End Property
        Public ReadOnly Property Stmt_Addr_Line5_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Addr_Line5_Text)
            End Get
        End Property
        Public ReadOnly Property Stmt_Addr_Line6_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Addr_Line6_Text)
            End Get
        End Property
        Public ReadOnly Property PostNet_Barcd_Rule_Text As FieldDef
            Get
                Return Fields(FieldList.PostNet_Barcd_Rule_Text)
            End Get
        End Property
        Public ReadOnly Property Rep_Name As FieldDef
            Get
                Return Fields(FieldList.Rep_Name)
            End Get
        End Property
        Public ReadOnly Property Rep_Addr_Line2_Text As FieldDef
            Get
                Return Fields(FieldList.Rep_Addr_Line2_Text)
            End Get
        End Property
        Public ReadOnly Property Rep_Addr_Line3_Text As FieldDef
            Get
                Return Fields(FieldList.Rep_Addr_Line3_Text)
            End Get
        End Property
        Public ReadOnly Property Rep_Addr_Line4_Text As FieldDef
            Get
                Return Fields(FieldList.Rep_Addr_Line4_Text)
            End Get
        End Property
        Public ReadOnly Property Rep_Addr_Line5_Text As FieldDef
            Get
                Return Fields(FieldList.Rep_Addr_Line5_Text)
            End Get
        End Property
        Public ReadOnly Property Rep_Addr_Line6_Text As FieldDef
            Get
                Return Fields(FieldList.Rep_Addr_Line6_Text)
            End Get
        End Property
        Public ReadOnly Property Rep_Phone_Text As FieldDef
            Get
                Return Fields(FieldList.Rep_Phone_Text)
            End Get
        End Property
        Public ReadOnly Property Hdng_Line2_Text As FieldDef
            Get
                Return Fields(FieldList.Hdng_Line2_Text)
            End Get
        End Property
        Public ReadOnly Property Anntnt_Name As FieldDef
            Get
                Return Fields(FieldList.Anntnt_Name)
            End Get
        End Property
        Public ReadOnly Property Issue_Date As FieldDef
            Get
                Return Fields(FieldList.Issue_Date)
            End Get
        End Property
        Public ReadOnly Property Cntrct_Num As FieldDef
            Get
                Return Fields(FieldList.Cntrct_Num)
            End Get
        End Property
        Public ReadOnly Property Tax_Ctgry_Text As FieldDef
            Get
                Return Fields(FieldList.Tax_Ctgry_Text)
            End Get
        End Property
        Public ReadOnly Property Loan_Ind As FieldDef
            Get
                Return Fields(FieldList.Loan_Ind)
            End Get
        End Property
        Public ReadOnly Property Cash_Srrndr_Val As FieldDef
            Get
                Return Fields(FieldList.Cash_Srrndr_Val)
            End Get
        End Property
        Public ReadOnly Property Pol_Num As FieldDef
            Get
                Return Fields(FieldList.Pol_Num)
            End Get
        End Property
        Public ReadOnly Property Prcssng_Co_Id As FieldDef
            Get
                Return Fields(FieldList.Prcssng_Co_Id)
            End Get
        End Property
        Public ReadOnly Property Prdct_Co_Id As FieldDef
            Get
                Return Fields(FieldList.Prdct_Co_Id)
            End Get
        End Property
        Public ReadOnly Property Brkr_Name As FieldDef
            Get
                Return Fields(FieldList.Brkr_Name)
            End Get
        End Property
        Public ReadOnly Property Accuml_Val As FieldDef
            Get
                Return Fields(FieldList.Accuml_Val)
            End Get
        End Property
#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

    '#Region " 261 Policy Info "

    'Public Class REC_261_Policy_Info
    '    Inherits RecordDef

    '    Private Shadows Enum FieldList
    '        Rec_ID
    '        Stmt_Key_Text
    '        Insrd_Name
    '        Face_Amt
    '        Death_Bnft_Amt
    '        Accmltn_Val
    '        Cash_Srrndr_Val
    '        Pol_Num
    '        Issue_Date
    '        Death_Bnft_Opt
    '        Plnd_Prem_Amt
    '        Prem_Mode
    'End Enum

    '#Region " CONSTRUCTORS "
    '    Public Sub New()
    '        MyBase.New(PresentationFormat.Delimited)
    '        Type = RecordType.DET
    '        FieldPrefix = Chr(34)
    '        FieldSuffix = Chr(34)
    '        Terminator = vbCrLf
    '        Initialize()
    '    End Sub

    '    Private Sub Initialize()
    '        Fields = New List(Of FieldDef)
    '        With Fields
    '            .Add(New FieldDef("Rec_ID", Pad.Right, FieldType.String, " "c, "S:261"))
    '            .Add(New FieldDef("Stmt_Key_Text", Pad.Right, FieldType.String, " "c, "CONT"))
    '            .Add(New FieldDef("Insrd_Name", "S:C"))
    '            .Add(New FieldDef("Face_Amt", "S:C"))
    '            .Add(New FieldDef("Death_Bnft_Amt", "S:C"))
    '            .Add(New FieldDef("Accmltn_Val", "S:C"))
    '            .Add(New FieldDef("Cash_Srrndr_Val", "S:C"))
    '            .Add(New FieldDef("Pol_Num", "S:C"))
    '            .Add(New FieldDef("Issue_Date", "S:C"))
    '            .Add(New FieldDef("Death_Bnft_Opt", "S:C"))
    '            .Add(New FieldDef("Plnd_Prem_Amt", "S:C"))
    '            .Add(New FieldDef("Prem_Mode", "S:C"))
    '        End With
    '    End Sub
    '#End Region

    '#Region " PROPERTIES "
    '    Public ReadOnly Property Rec_ID As FieldDef
    '        Get
    '            Return Fields(FieldList.Rec_ID)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Stmt_Key_Text As FieldDef
    '        Get
    '            Return Fields(FieldList.Stmt_Key_Text)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Insrd_Name As FieldDef
    '        Get
    '            Return Fields(FieldList.Insrd_Name)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Face_Amt As FieldDef
    '        Get
    '            Return Fields(FieldList.Face_Amt)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Death_Bnft_Amt As FieldDef
    '        Get
    '            Return Fields(FieldList.Death_Bnft_Amt)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Accmltn_Val As FieldDef
    '        Get
    '            Return Fields(FieldList.Accmltn_Val)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Cash_Srrndr_Val As FieldDef
    '        Get
    '            Return Fields(FieldList.Cash_Srrndr_Val)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Pol_Num As FieldDef
    '        Get
    '            Return Fields(FieldList.Pol_Num)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Issue_Date As FieldDef
    '        Get
    '            Return Fields(FieldList.Issue_Date)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Death_Bnft_Opt As FieldDef
    '        Get
    '            Return Fields(FieldList.Death_Bnft_Opt)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Plnd_Prem_Amt As FieldDef
    '        Get
    '            Return Fields(FieldList.Plnd_Prem_Amt)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Prem_Mode As FieldDef
    '        Get
    '            Return Fields(FieldList.Prem_Mode)
    '        End Get
    '    End Property
    '#End Region

    '#Region " METHODS "

    '#End Region
    '    End Class

    '#End Region

#Region " 265 Account Summary "

    Public Class REC_265_Account_Summary
        Inherits RecordDef

        Private Shadows Enum FieldList
            Rec_ID
            Stmt_Key_Text
            QTD_Begin_Val
            YTD_Begin_Val
            QTD_Purch_Amt
            YTD_Purch_Amt
            QTD_Trnsfr_In_Amt
            YTD_Trnsfr_In_Amt
            QTD_Wdrl_Amt
            YTD_Wdrl_Amt
            QTD_Trnsfr_Out_Amt
            YTD_Trnsfr_Out_Amt
            QTD_Chng_Amt
            YTD_Chng_Amt
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.DET
            FieldPrefix = Chr(34)
            FieldSuffix = Chr(34)
            Terminator = vbCrLf
            Initialize()
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("Rec_ID", "S:265"))
                .Add(New FieldDef("Stmt_Key_Text", "CONT"))
                .Add(New FieldDef("QTD_Begin_Val", "BOQ_ACCOUNTVAL"))
                .Add(New FieldDef("YTD_Begin_Val", "BOY_ACCOUNTVAL"))
                .Add(New FieldDef("QTD_Purch_Amt", "F:QTD_PREM"))
                .Add(New FieldDef("YTD_Purch_Amt", "EOQ_CYTD_PREM"))
                .Add(New FieldDef("QTD_Trnsfr_In_Amt", "S:0.00"))
                .Add(New FieldDef("YTD_Trnsfr_In_Amt", "S:0.00"))
                .Add(New FieldDef("QTD_Wdrl_Amt", "F:QTD_WITHD"))
                .Add(New FieldDef("YTD_Wdrl_Amt", "F:YTD_WITHD"))
                .Add(New FieldDef("QTD_Trnsfr_Out_Amt", "S:0.00"))
                .Add(New FieldDef("YTD_Trnsfr_Out_Amt", "S:0.00"))
                .Add(New FieldDef("QTD_Chng_Amt", "F:QTD_Chnge_Amt"))
                .Add(New FieldDef("YTD_Chng_Amt", "F:YTD_Chnge_Amt"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property Rec_ID As FieldDef
            Get
                Return Fields(FieldList.Rec_ID)
            End Get
        End Property
        Public ReadOnly Property Stmt_Key_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Key_Text)
            End Get
        End Property
        Public ReadOnly Property QTD_Begin_Val As FieldDef
            Get
                Return Fields(FieldList.QTD_Begin_Val)
            End Get
        End Property
        Public ReadOnly Property YTD_Begin_Val As FieldDef
            Get
                Return Fields(FieldList.YTD_Begin_Val)
            End Get
        End Property
        Public ReadOnly Property QTD_Purch_Amt As FieldDef
            Get
                Return Fields(FieldList.QTD_Purch_Amt)
            End Get
        End Property
        Public ReadOnly Property YTD_Purch_Amt As FieldDef
            Get
                Return Fields(FieldList.YTD_Purch_Amt)
            End Get
        End Property
        Public ReadOnly Property QTD_Trnsfr_In_Amt As FieldDef
            Get
                Return Fields(FieldList.QTD_Trnsfr_In_Amt)
            End Get
        End Property
        Public ReadOnly Property YTD_Trnsfr_In_Amt As FieldDef
            Get
                Return Fields(FieldList.YTD_Trnsfr_In_Amt)
            End Get
        End Property
        Public ReadOnly Property QTD_Wdrl_Amt As FieldDef
            Get
                Return Fields(FieldList.QTD_Wdrl_Amt)
            End Get
        End Property
        Public ReadOnly Property YTD_Wdrl_Amt As FieldDef
            Get
                Return Fields(FieldList.YTD_Wdrl_Amt)
            End Get
        End Property
        Public ReadOnly Property QTD_Trnsfr_Out_Amt As FieldDef
            Get
                Return Fields(FieldList.QTD_Trnsfr_Out_Amt)
            End Get
        End Property
        Public ReadOnly Property YTD_Trnsfr_Out_Amt As FieldDef
            Get
                Return Fields(FieldList.YTD_Trnsfr_Out_Amt)
            End Get
        End Property
        Public ReadOnly Property QTD_Chng_Amt As FieldDef
            Get
                Return Fields(FieldList.QTD_Chng_Amt)
            End Get
        End Property
        Public ReadOnly Property YTD_Chng_Amt As FieldDef
            Get
                Return Fields(FieldList.YTD_Chng_Amt)
            End Get
        End Property
#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " 285 Account Summary Total "

    Public Class REC_285_Account_Summary_Total
        Inherits RecordDef

        Private Shadows Enum FieldList
            Rec_ID
            Stmt_Key_Text
            End_Val
            Plan_Start_Date
            Vested_Val
            Loan_Bal
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.DET
            FieldPrefix = Chr(34)
            FieldSuffix = Chr(34)
            Terminator = vbCrLf
            Initialize()
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("Rec_ID", "S:285"))
                .Add(New FieldDef("Stmt_Key_Text", "CONT"))
                .Add(New FieldDef("End_Val", "EOQ_ACCOUNTVAL"))
                .Add(New FieldDef("Plan_Start_Date", "S:"))
                .Add(New FieldDef("Vested_Val", "S:0.00"))
                .Add(New FieldDef("Loan_Bal", "EOQ_LOANVAL"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property Rec_ID As FieldDef
            Get
                Return Fields(FieldList.Rec_ID)
            End Get
        End Property
        Public ReadOnly Property Stmt_Key_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Key_Text)
            End Get
        End Property
        Public ReadOnly Property End_Val As FieldDef
            Get
                Return Fields(FieldList.End_Val)
            End Get
        End Property
        Public ReadOnly Property Plan_Start_Date As FieldDef
            Get
                Return Fields(FieldList.Plan_Start_Date)
            End Get
        End Property
        Public ReadOnly Property Vested_Val As FieldDef
            Get
                Return Fields(FieldList.Vested_Val)
            End Get
        End Property
        Public ReadOnly Property Loan_Bal As FieldDef
            Get
                Return Fields(FieldList.Loan_Bal)
            End Get
        End Property
#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " 290 Info_Record "

    Public Class REC_290_Info_Record
        Inherits RecordDef

        Private Shadows Enum FieldList
            Rec_ID
            Stmt_Key_Text
            Grntd_Min_Death_Bnft_Amt
            Ftnt_Path_Text
            Ftnt_Name
            Death_Bnft_Amt
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.DET
            FieldPrefix = Chr(34)
            FieldSuffix = Chr(34)
            Terminator = vbCrLf
            Initialize()
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("Rec_ID", "S:290"))
                .Add(New FieldDef("Stmt_Key_Text", "CONT"))
                .Add(New FieldDef("Grntd_Min_Death_Bnft_Amt", "EOQ_DEATHBEN_AMT"))
                .Add(New FieldDef("Ftnt_Path_Text", "S:E:\RESOURCES\MODERNWOODMEN\RTFS\"))
                .Add(New FieldDef("Ftnt_Name", "S:MWA_GMDBFt2.rtf"))
                .Add(New FieldDef("Death_Bnft_Amt", "S:"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property Rec_ID As FieldDef
            Get
                Return Fields(FieldList.Rec_ID)
            End Get
        End Property
        Public ReadOnly Property Stmt_Key_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Key_Text)
            End Get
        End Property
        Public ReadOnly Property Grntd_Min_Death_Bnft_Amt As FieldDef
            Get
                Return Fields(FieldList.Grntd_Min_Death_Bnft_Amt)
            End Get
        End Property
        Public ReadOnly Property Ftnt_Path_Text As FieldDef
            Get
                Return Fields(FieldList.Ftnt_Path_Text)
            End Get
        End Property
        Public ReadOnly Property Ftnt_Name As FieldDef
            Get
                Return Fields(FieldList.Ftnt_Name)
            End Get
        End Property
        Public ReadOnly Property Death_Bnft_Amt As FieldDef
            Get
                Return Fields(FieldList.Death_Bnft_Amt)
            End Get
        End Property
#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

    '#Region " 295 Enhanced Benefits "
    'Public Class REC_295_Enhanced_Benefits
    '    Inherits RecordDef

    '    Private Shadows Enum FieldList
    '        Rec_ID
    '        Stmt_Key_Text
    '        Txn_Fee_Desc
    '        Month1_Fee_Amt
    '        Month2_Fee_Amt
    '        Month3_Fee_Amt
    '    End Enum

    '#Region " CONSTRUCTORS "
    '    Public Sub New()
    '        MyBase.New(PresentationFormat.Delimited)
    '        Type = RecordType.DET
    '        FieldPrefix = Chr(34)
    '        FieldSuffix = Chr(34)
    '        Terminator = vbCrLf
    '        Initialize()
    '    End Sub

    '    Private Sub Initialize()
    '        Fields = New List(Of FieldDef)
    '        With Fields
    '            .Add(New FieldDef("Rec_ID", Pad.Right, FieldType.String, " "c, "S:295"))
    '            .Add(New FieldDef("Stmt_Key_Text", Pad.Right, FieldType.String, " "c, "CONT"))
    '            .Add(New FieldDef("Txn_Fee_Desc", "S:C"))
    '            .Add(New FieldDef("Month1_Fee_Amt", "S:C"))
    '            .Add(New FieldDef("Month2_Fee_Amt", "S:C"))
    '            .Add(New FieldDef("Month3_Fee_Amt", "S:C"))
    '        End With
    '    End Sub
    '#End Region

    '#Region " PROPERTIES "
    'Public ReadOnly Property Rec_ID As FieldDef
    '    Get
    '        Return Fields(FieldList.Rec_ID)
    '    End Get
    'End Property
    'Public ReadOnly Property Stmt_Key_Text As FieldDef
    '    Get
    '        Return Fields(FieldList.Stmt_Key_Text)
    '    End Get
    'End Property
    'Public ReadOnly Property Txn_Fee_Desc As FieldDef
    '    Get
    '        Return Fields(FieldList.Txn_Fee_Desc)
    '    End Get
    'End Property
    'Public ReadOnly Property Month1_Fee_Amt As FieldDef
    '    Get
    '        Return Fields(FieldList.Month1_Fee_Amt)
    '    End Get
    'End Property
    'Public ReadOnly Property Month2_Fee_Amt As FieldDef
    '    Get
    '        Return Fields(FieldList.Month2_Fee_Amt)
    '    End Get
    'End Property
    'Public ReadOnly Property Month3_Fee_Amt As FieldDef
    '    Get
    '        Return Fields(FieldList.Month3_Fee_Amt)
    '    End Get
    'End Property
    '#End Region

    '#Region " METHODS "

    '#End Region
    '    End Class

    '#End Region

#Region " 605 Transaction Summary (BASE) "

    Public Class REC_605_Transaction_Summary
        Inherits RecordDef

        Private Shadows Enum FieldList
            Rec_ID
            Stmt_Key_Text
            Fund_Name_Text
            Fund_Type_Code
            Fund_Begin_Val
            Fund_Purch_Amt
            Fund_Wdrl_Amt
            Fund_Chng_Amt
            Fund_End_Val
            Fund_End_Unit_Cnt
            Fund_Acct_Pct
            Fund_Xfer_Amt
            Fund_End_Price_Amt
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.DET
            FieldPrefix = Chr(34)
            FieldSuffix = Chr(34)
            Terminator = vbCrLf
            Initialize()
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("Rec_ID", "S:605"))
                .Add(New FieldDef("Stmt_Key_Text", "CONT"))
                .Add(New FieldDef("Fund_Name_Text", "F:FUND_CODE_DESC"))
                .Add(New FieldDef("Fund_Type_Code", "F:Fund_Type"))
                .Add(New FieldDef("Fund_Begin_Val", "S:"))
                .Add(New FieldDef("Fund_Purch_Amt", "S:"))
                .Add(New FieldDef("Fund_Wdrl_Amt", "S:"))
                .Add(New FieldDef("Fund_Chng_Amt", "S:"))
                .Add(New FieldDef("Fund_End_Val", "F:EOQ_VALUE"))
                .Add(New FieldDef("Fund_End_Unit_Cnt", "F:EOQ_UNITS"))
                .Add(New FieldDef("Fund_Acct_Pct", "F:FUND_PCT"))
                .Add(New FieldDef("Fund_Xfer_Amt", "S:"))
                .Add(New FieldDef("Fund_End_Price_Amt", "F:EOQ_UNIT_VALUE"))

            End With
        End Sub
#End Region


#Region " PROPERTIES "
        Public ReadOnly Property Rec_ID As FieldDef
            Get
                Return Fields(FieldList.Rec_ID)
            End Get
        End Property
        Public ReadOnly Property Stmt_Key_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Key_Text)
            End Get
        End Property
        Public ReadOnly Property Fund_Name_Text As FieldDef
            Get
                Return Fields(FieldList.Fund_Name_Text)
            End Get
        End Property
        Public ReadOnly Property Fund_Type_Code As FieldDef
            Get
                Return Fields(FieldList.Fund_Type_Code)
            End Get
        End Property
        Public ReadOnly Property Fund_Begin_Val As FieldDef
            Get
                Return Fields(FieldList.Fund_Begin_Val)
            End Get
        End Property
        Public ReadOnly Property Fund_Purch_Amt As FieldDef
            Get
                Return Fields(FieldList.Fund_Purch_Amt)
            End Get
        End Property
        Public ReadOnly Property Fund_Wdrl_Amt As FieldDef
            Get
                Return Fields(FieldList.Fund_Wdrl_Amt)
            End Get
        End Property
        Public ReadOnly Property Fund_Chng_Amt As FieldDef
            Get
                Return Fields(FieldList.Fund_Chng_Amt)
            End Get
        End Property
        Public ReadOnly Property Fund_End_Val As FieldDef
            Get
                Return Fields(FieldList.Fund_End_Val)
            End Get
        End Property
        Public ReadOnly Property Fund_End_Unit_Cnt As FieldDef
            Get
                Return Fields(FieldList.Fund_End_Unit_Cnt)
            End Get
        End Property
        Public ReadOnly Property Fund_Acct_Pct As FieldDef
            Get
                Return Fields(FieldList.Fund_Acct_Pct)
            End Get
        End Property
        Public ReadOnly Property Fund_Xfer_Amt As FieldDef
            Get
                Return Fields(FieldList.Fund_Xfer_Amt)
            End Get
        End Property

        Public ReadOnly Property Fund_End_Price_Amt As FieldDef
            Get
                Return Fields(FieldList.Fund_End_Price_Amt)
            End Get
        End Property
#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " 625 Transaction Summary Total "

    Public Class REC_625_Transaction_Summary_Total
        Inherits RecordDef

        Private Shadows Enum FieldList
            Rec_ID
            Stmt_Key_Text
            Total_Begin_Val
            Total_Purch_Amt
            Total_Wdrl_Amt
            Total_Chng_Amt
            Total_End_Val
            Total_Acct_Pct

        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.DET
            FieldPrefix = Chr(34)
            FieldSuffix = Chr(34)
            Terminator = vbCrLf
            Initialize()
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("Rec_ID", "S:625"))
                .Add(New FieldDef("Stmt_Key_Text", "CONT"))
                .Add(New FieldDef("Total_Begin_Val", "S:"))
                .Add(New FieldDef("Total_Purch_Amt", "S:"))
                .Add(New FieldDef("Total_Wdrl_Amt", "S:"))
                .Add(New FieldDef("Total_Chng_Amt", "S:"))
                .Add(New FieldDef("Total_End_Val", "EOQ_ACCOUNTVAL"))
                .Add(New FieldDef("Total_Acct_Pct", "S:100.00"))

            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property Rec_ID As FieldDef
            Get
                Return Fields(FieldList.Rec_ID)
            End Get
        End Property
        Public ReadOnly Property Stmt_Key_Text As FieldDef
            Get
                Return Fields(FieldList.Stmt_Key_Text)
            End Get
        End Property
        Public ReadOnly Property Total_Begin_Val As FieldDef
            Get
                Return Fields(FieldList.Total_Begin_Val)
            End Get
        End Property
        Public ReadOnly Property Total_Purch_Amt As FieldDef
            Get
                Return Fields(FieldList.Total_Purch_Amt)
            End Get
        End Property
        Public ReadOnly Property Total_Wdrl_Amt As FieldDef
            Get
                Return Fields(FieldList.Total_Wdrl_Amt)
            End Get
        End Property
        Public ReadOnly Property Total_Chng_Amt As FieldDef
            Get
                Return Fields(FieldList.Total_Chng_Amt)
            End Get
        End Property
        Public ReadOnly Property Total_End_Val As FieldDef
            Get
                Return Fields(FieldList.Total_End_Val)
            End Get
        End Property
        Public ReadOnly Property Total_Acct_Pct As FieldDef
            Get
                Return Fields(FieldList.Total_Acct_Pct)
            End Get
        End Property

#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

    '#Region " 630 Guarantee Period Account "

    'Public Class REC_630_Guarantee_Period_Account
    '    Inherits RecordDef

    '    Private Shadows Enum FieldList
    '        Rec_ID
    '        Stmt_Key_Text
    '        Fund_Name_Text
    '        Grntd_Rate_Pct
    '        Rate_Exp_Date
    '        Fund_End_Val
    '    End Enum

    '#Region " CONSTRUCTORS "
    '    Public Sub New()
    '        MyBase.New(PresentationFormat.Delimited)
    '        Type = RecordType.DET
    '        FieldPrefix = Chr(34)
    '        FieldSuffix = Chr(34)
    '        Terminator = vbCrLf
    '        Initialize()
    '    End Sub

    '    Private Sub Initialize()
    '        Fields = New List(Of FieldDef)
    '        With Fields
    '            .Add(New FieldDef("Rec_ID", Pad.Right, FieldType.String, " "c, "S:630"))
    '            .Add(New FieldDef("Stmt_Key_Text", "CONT"))
    '            .Add(New FieldDef("Fund_Name_Text", "S:"))
    '            .Add(New FieldDef("Grntd_Rate_Pct", "S:"))
    '            .Add(New FieldDef("Rate_Exp_Date", "S:"))
    '            .Add(New FieldDef("Fund_End_Val", "S:"))
    '        End With
    '    End Sub
    '#End Region

    '#Region " PROPERTIES "
    '    Public ReadOnly Property Rec_ID As FieldDef
    '        Get
    '            Return Fields(FieldList.Rec_ID)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Stmt_Key_Text As FieldDef
    '        Get
    '            Return Fields(FieldList.Stmt_Key_Text)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Fund_Name_Text As FieldDef
    '        Get
    '            Return Fields(FieldList.Fund_Name_Text)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Grntd_Rate_Pct As FieldDef
    '        Get
    '            Return Fields(FieldList.Grntd_Rate_Pct)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Rate_Exp_Date As FieldDef
    '        Get
    '            Return Fields(FieldList.Rate_Exp_Date)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Fund_End_Val As FieldDef
    '        Get
    '            Return Fields(FieldList.Fund_End_Val)
    '        End Get
    '    End Property
    '#End Region

    '#Region " METHODS "

    '#End Region
    '    End Class

    '#End Region

    '#Region " 830 Marketing Message "

    ' Public Class REC_830_Marketing_Message
    '    Inherits RecordDef

    '    Private Shadows Enum FieldList
    '        Rec_ID
    '        Stmt_Key_Text
    '        Mktg_Msg_Path_Text
    '        Mktg_Msg_Name
    '    End Enum

    '#Region " CONSTRUCTORS "
    '    Public Sub New()
    '        MyBase.New(PresentationFormat.Delimited)
    '        Type = RecordType.DET
    '        FieldPrefix = Chr(34)
    '        FieldSuffix = Chr(34)
    '        Terminator = vbCrLf
    '        Initialize()
    '    End Sub

    '    Private Sub Initialize()
    '        Fields = New List(Of FieldDef)
    '        With Fields
    '            .Add(New FieldDef("Rec_ID", Pad.Right, FieldType.String, " "c, "S:830"))
    '            .Add(New FieldDef("Stmt_Key_Text", Pad.Right, FieldType.String, " "c, "CONT"))
    '            .Add(New FieldDef("Mktg_Msg_Path_Text", "S:C"))
    '            .Add(New FieldDef("Mktg_Msg_Name", "S:C"))
    '        End With
    '    End Sub
    '#End Region

    '#Region " PROPERTIES "
    '        Public ReadOnly Property Rec_ID As FieldDef
    '            Get
    '                Return Fields(FieldList.Rec_ID)
    '            End Get
    '        End Property
    '        Public ReadOnly Property Stmt_Key_Text As FieldDef
    '            Get
    '                Return Fields(FieldList.Stmt_Key_Text)
    '            End Get
    '        End Property
    '        Public ReadOnly Property Mktg_Msg_Path_Text As FieldDef
    '            Get
    '                Return Fields(FieldList.Mktg_Msg_Path_Text)
    '            End Get
    '        End Property
    '        Public ReadOnly Property Mktg_Msg_Name As FieldDef
    '            Get
    '                Return Fields(FieldList.Mktg_Msg_Name)
    '            End Get
    '        End Property
    '#End Region

    '#Region " METHODS "

    '#End Region
    '    End Class

    '#End Region

    '#Region " 860 Info_Rec Marketing Message "

    'Public Class REC_860_InfoRec_Marketing_Message
    '    Inherits RecordDef

    '    Private Shadows Enum FieldList
    '        Rec_ID
    '        Stmt_Key_Text
    '        Footnote_Path_Text
    '        Footnote_Name
    '    End Enum

    '#Region " CONSTRUCTORS "
    '    Public Sub New()
    '        MyBase.New(PresentationFormat.Delimited)
    '        Type = RecordType.DET
    '        FieldPrefix = Chr(34)
    '        FieldSuffix = Chr(34)
    '        Terminator = vbCrLf
    '        Initialize()
    '    End Sub

    '    Private Sub Initialize()
    '        Fields = New List(Of FieldDef)
    '        With Fields
    '            .Add(New FieldDef("Rec_ID", Pad.Right, FieldType.String, " "c, "S:860"))
    '            .Add(New FieldDef("Stmt_Key_Text", "S:"))
    '            .Add(New FieldDef("Footnote_Path_Text", "S:"))
    '            .Add(New FieldDef("Footnote_Name", "S:"))
    '        End With
    '    End Sub
    '#End Region

    '#Region " PROPERTIES "
    '    Public ReadOnly Property Rec_ID As FieldDef
    '        Get
    '            Return Fields(FieldList.Rec_ID)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Stmt_Key_Text As FieldDef
    '        Get
    '            Return Fields(FieldList.Stmt_Key_Text)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Footnote_Path_Text As FieldDef
    '        Get
    '            Return Fields(FieldList.Footnote_Path_Text)
    '        End Get
    '    End Property
    '    Public ReadOnly Property Footnote_Name As FieldDef
    '        Get
    '            Return Fields(FieldList.Footnote_Name)
    '        End Get
    '    End Property
    '#End Region

    '#Region " METHODS "

    '#End Region
    '    End Class

    '#End Region

#End Region

End Namespace
