Imports Se2.ISI.Base
Imports Se2.ISI.Base.Utility
Imports Se2.ISI.Base.Presentation
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.SoA.CLM
    '#Region "CONTROL HEADER "

    '  Public Class CTRLHeader
    '    Inherits BaseLogic
    '    Public SourceSystem As String = ""

    '    Public Shadows Property Se2Source As SourceLayouts.Header

    '    Public Sub New()
    '      MyBase.New()
    '      ClientRecord = New Records.HeaderDetail
    '      Se2Source = New SourceLayouts.Header
    '      MyBase.Se2Source = Me.Se2Source
    '    End Sub

    '#Region " POPULATION FUNCTIONS "

    '    Public Function Record_Count(ByVal value As Se2Args) As Object
    '      Dim RecordCount As Integer = CInt(Se2Source.Record_Count)

    '      value.Accumulators.Add("Record_Count", RecordCount)

    '      Return ""

    '    End Function

    '#End Region

    '  End Class

    '#End Region
#Region " 100 Statement Header"
    Public Class REC_100_Statement_Header
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.REC_100_Statement_Header

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.REC_100_Statement_Header
            Se2Source = New SourceLayouts.REC_100_Statement_Header
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "

        Public Function Dsgn_Code(ByVal value As Se2Args) As Object
            Dim DesignCode As String = ""

            If value.Accumulators.ContainsKey("CurrentContract") Then
                If value.Accumulators.Item("CurrentContract").ToString = Se2Source.CONT Then
                    If CInt(value.Accumulators.Item("100Count")) = 1 Then
                        DesignCode = "070"
                        value.Accumulators.Item("100Count") = 2
                    Else
                        DesignCode = "106"
                        value.Accumulators.Item("100Count") = 3
                    End If
                Else
                    DesignCode = "106"
                    value.Accumulators.Item("CurrentContract") = Se2Source.CONT
                    value.Accumulators.Item("100Count") = 1
                End If
            Else
                value.Accumulators.Add("CurrentContract", Se2Source.CONT)
                value.Accumulators.Add("100Count", 1)
                DesignCode = "106"
            End If

            Return DesignCode
        End Function
        Public Function PLN_CODE(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            If CInt(value.Accumulators.Item("100Count")) = 2 Then
                retval = Se2Source.PLN_CODE
            End If

            Return retval
        End Function
        Public Function ROLE_ID(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            If CInt(value.Accumulators.Item("100Count")) = 2 Then
                retval = "1"
            End If

            Return retval
        End Function
        Public Function REP_MASTER_NUMBER(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            If CInt(value.Accumulators.Item("100Count")) = 2 Then
                retval = Se2Source.REP_MASTER_NUMBER
            End If

            Return retval
        End Function
        Public Function LST(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            If CInt(value.Accumulators.Item("100Count")) = 2 Then
                retval = Se2Source.LST
            End If

            Return retval
        End Function
        Public Function FST(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            If CInt(value.Accumulators.Item("100Count")) = 2 Then
                retval = Se2Source.FST
            End If

            Return retval
        End Function
        Public Function GET_SORT3(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            If CInt(value.Accumulators.Item("100Count")) = 2 Then
                retval = Left(Se2Source.MID, 1)
            End If

            Return retval
        End Function
        Public Function STATE_CODE(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            If CInt(value.Accumulators.Item("100Count")) = 2 Then
                retval = Se2Source.STATE_CODE
            End If

            Return retval
        End Function
        Public Function ZIP(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            If CInt(value.Accumulators.Item("100Count")) = 2 Then
                retval = Se2Source.ZIP
            End If

            Return retval
        End Function
#End Region

    End Class

#End Region

#Region " 51 Sort Key "

    Public Class REC_51_Sort_Key
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.REC_51_Sort_Key

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.REC_51_Sort_Key
            Se2Source = New SourceLayouts.REC_51_Sort_Key
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "
        Public Function GET_CUST_NAME(ByVal value As Se2Args) As String
            Dim retval As String

            '7/18 Commented out customer middle name to match corsp

            'If Se2Source.MID = "" Then
            retval = Se2Source.LST & " " & Se2Source.FST

            'Else
            '    retval = Se2Source.LST & " " & Se2Source.FST & " " & Se2Source.MID

            'End If

            Return retval
        End Function
        Public Function SPRTR_CNTRL_CODE(ByVal value As Se2Args) As String
            Dim retval As String = ""

            Select Case CInt(value.Accumulators.Item("100Count")).ToString
                Case "1"
                    retval = "0"
                Case "2"
                    retval = "1"
                Case "3"
                    retval = "9"
            End Select

            Return retval
        End Function
        Public Function DSC_GROUP_DOC_CNT(ByVal value As Se2Args) As Object

            Dim remainingCount As Integer = 0

            If value.Accumulators.ContainsKey("Row_Count") Then
                'remainingCount = CInt(value.Accumulators("Record_Count")) - CInt(value.Accumulators("Row_Count"))
                value.Accumulators.AddToValue("Row_Count", 1)
            Else
                'remainingCount = CInt(value.Accumulators("Record_Count"))
                value.Accumulators.Add("Row_Count", 1)
            End If
            Return remainingCount
        End Function

        Public Function Base_File_Name(ByVal value As Se2Args) As Object
            Dim baseFileName As String = "PSOA"

            baseFileName += value.cmdLnArgs.CYCLEDATE.ToString("yy")

            Dim findquarter As Decimal = CDec(value.cmdLnArgs.CYCLEDATE.ToString("MM")) / 12 * 4

            baseFileName += Math.Floor(findquarter).ToString.PadLeft(2, "0"c)

            Return baseFileName
        End Function

        Public Function DateTimeStamp(ByVal value As Se2Args) As Object
            Return CDate(value.cmdLnArgs.CYCLEDATE).ToString("yyyyMMddHHmmss")
        End Function

        Public Function GET_BRKR_NAME(ByVal value As Se2Args) As Object

            Dim brokerName As String = ""

            brokerName = Se2Source.BRKR_LST

            brokerName.Replace(" "c, "_"c)

            Return brokerName

        End Function

        Public Function GET_REP_NAME(ByVal value As Se2Args) As String

            Dim retval As String

            If Se2Source.REP_MID = "" Then
                retval = Se2Source.REP_FST & " " & Se2Source.REP_LST & " " & Se2Source.REP_SUFFIX
            Else
                retval = Se2Source.REP_FST & " " & Se2Source.REP_MID.Substring(0, 1) & " " & Se2Source.REP_LST & " " & Se2Source.REP_SUFFIX

            End If

            retval.Replace(" "c, "_"c)

            Return retval

        End Function

        Public Function Sort_Type(ByVal value As Se2Args) As String

            Dim retval As String

            If Se2Source.ZIP = "66636" Then
                retval = "C"
            ElseIf Se2Source.STATE_CODE = "FN" Then
                retval = "B"
            Else
                retval = "7"
            End If

            Return retval

        End Function

#End Region

    End Class

#End Region

#Region " 52 Separator "

    Public Class REC_52_Separator
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.REC_52_Separator

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.REC_52_Separator
            Se2Source = New SourceLayouts.REC_52_Separator
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "
        Public Function Name(ByVal value As Se2Args) As String

            Dim retval As String

            If Se2Source.MID = "" Then
                retval = Se2Source.FST & " " & Se2Source.LST

            Else
                retval = Se2Source.FST & " " & Se2Source.MID & " " & Se2Source.LST

            End If

            Return retval

        End Function
        'Public Function Address(ByVal value As Se2Args) As Object

        '    Dim ownerAddress As String = ""

        '    ownerAddress = Se2Source.ADDRESS1 & " " & Se2Source.ADDRESS2 & " " & Se2Source.ADDRESS3

        '    Return ownerAddress

        'End Function

        Public Function Address1(ByVal value As Se2Args) As Object

            Dim address As New List(Of String)
            address.Add(Se2Source.ADDRESS1)
            If Se2Source.ADDRESS2 <> "" Then
                address.Add(Se2Source.ADDRESS2)

            End If
            If Se2Source.ADDRESS3 <> "" Then
                address.Add(Se2Source.ADDRESS3)

            End If
            address.Add(Se2Source.CITY & " " & Se2Source.STATE & " " & Se2Source.ZIP)
            address.Add("")
            address.Add("")
            If value.Accumulators.ContainsKey("52Address") Then
                value.Accumulators.Item("52Address") = address
            Else
                value.Accumulators.Add("52Address", address)

            End If
            Return CType(value.Accumulators.Item("52Address"), List(Of String))(0)


        End Function

        Public Function Address2(ByVal value As Se2Args) As Object

            Dim retval As String = ""

            retval = CType(value.Accumulators.Item("52Address"), List(Of String))(1)

            Return retval

        End Function
        Public Function Address3(ByVal value As Se2Args) As Object

            Dim retval As String = ""

            retval = CType(value.Accumulators.Item("52Address"), List(Of String))(2)

            Return retval

        End Function
        Public Function Address4(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            retval = CType(value.Accumulators.Item("52Address"), List(Of String))(3)

            Return retval

        End Function


        'Public Function CityStateZip(ByVal value As Se2Args) As Object

        '    Dim ownerCityStateZip As String = ""

        '    ownerCityStateZip = Se2Source.CITY & " " & Se2Source.STATE & " " & Se2Source.ZIP

        '    Return ownerCityStateZip

        'End Function
#End Region


    End Class

#End Region

#Region " 101 File Header "

    Public Class REC_101_File_Header
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.REC_101_File_Header

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.REC_101_File_Header
            Se2Source = New SourceLayouts.REC_101_File_Header
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "
        Public Function Begin_Date(ByVal Datevalue As Se2Args) As String
            Dim retval As String

            retval = Year(CDate(Se2Source.CYCLE_DATE)) & (Month(CDate(Se2Source.CYCLE_DATE)) - 2).ToString.PadLeft(2, "0"c) & "01"

            Return retval

        End Function
        Public Function Year_Begin_Date(ByVal Datevalue As Se2Args) As String
            Dim retval As String

            retval = Year(CDate(Se2Source.CYCLE_DATE)) & "0101"

            Return retval

        End Function
        Public Function Qtr_Begin_Date(ByVal Datevalue As Se2Args) As String
            Dim retval As String

            retval = Year(CDate(Se2Source.CYCLE_DATE)) & (Month(CDate(Se2Source.CYCLE_DATE)) - 2).ToString.PadLeft(2, "0"c) & "01"

            Return retval

        End Function
        Public Function Stmt_Month1(ByVal Datevalue As Se2Args) As String
            Dim retval As String

            retval = MonthName(Month(CDate(Se2Source.CYCLE_DATE)) - 2, False)

            Return retval

        End Function
        Public Function Stmt_Month2(ByVal Datevalue As Se2Args) As String
            Dim retval As String

            retval = MonthName(Month(CDate(Se2Source.CYCLE_DATE)) - 1, False)

            Return retval

        End Function
        Public Function Stmt_Month3(ByVal Datevalue As Se2Args) As String
            Dim retval As String

            retval = MonthName(Month(CDate(Se2Source.CYCLE_DATE)), False)

            Return retval

        End Function

#End Region

    End Class

#End Region

    '#Region " 102 Inserter Set-up "

    '    Public Class REC_102_Inserter_SetUp
    '        Inherits BaseLogic

    '        Public Shadows Property Se2Source As SourceLayouts.PoC_Source

    '        Public Sub New()
    '            MyBase.New()
    '            ClientRecord = New Records.REC_102_Inserter_SetUp
    '            Se2Source = New SourceLayouts.PoC_Source
    '            MyBase.Se2Source = Me.Se2Source
    '        End Sub


    '#Region " POPULATION FUNCTIONS "

    '#End Region

    '    End Class

    '#End Region

#Region " 55 Mailing Label "

    Public Class REC_55_Mailing_Label
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.REC_55_Mailing_Label

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.REC_55_Mailing_Label
            Se2Source = New SourceLayouts.REC_55_Mailing_Label
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "

        Public Function Sort_Type(ByVal value As Se2Args) As String

            Dim retval As String

            If Se2Source.ZIP = "66636" Then
                retval = "C"
            ElseIf Se2Source.STATE_CODE = "FN" Then
                retval = "B"
            Else
                retval = "7"
            End If

            Return retval

        End Function
        Public Function Name(ByVal value As Se2Args) As String

            Dim retval As String

            If Se2Source.MID = "" Then
                retval = Se2Source.FST & " " & Se2Source.LST

            Else
                retval = Se2Source.FST & " " & Se2Source.MID & " " & Se2Source.LST

            End If

            Return retval

        End Function
        Public Function Address1(ByVal value As Se2Args) As Object

            Dim address As New List(Of String)
            address.Add(Se2Source.ADDRESS1)
            If Se2Source.ADDRESS2 <> "" Then
                address.Add(Se2Source.ADDRESS2)
            End If
            If Se2Source.ADDRESS3 <> "" Then
                address.Add(Se2Source.ADDRESS3)
            End If
            address.Add(Se2Source.CITY & " " & Se2Source.STATE_CODE & " " & Se2Source.ZIP)
            address.Add("")
            address.Add("")

            If value.Accumulators.ContainsKey("55Address") Then
                value.Accumulators.Item("55Address") = address
            Else
                value.Accumulators.Add("55Address", address)
            End If

            Return CType(value.Accumulators.Item("55Address"), List(Of String))(0)

        End Function

        Public Function Address2(ByVal value As Se2Args) As Object

            Dim retval As String = ""

            retval = CType(value.Accumulators.Item("55Address"), List(Of String))(1)

            Return retval

        End Function
        Public Function Address3(ByVal value As Se2Args) As Object

            Dim retval As String = ""

            retval = CType(value.Accumulators.Item("55Address"), List(Of String))(2)

            Return retval

        End Function
        Public Function Address4(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            retval = CType(value.Accumulators.Item("55Address"), List(Of String))(3)

            Return retval

        End Function
        Public Function Base_File_Name(ByVal value As Se2Args) As Object
            Dim baseFileName As String = "PSOA"

            baseFileName += value.cmdLnArgs.CYCLEDATE.ToString("yy")

            Dim findquarter As Decimal = CDec(value.cmdLnArgs.CYCLEDATE.ToString("MM")) / 12 * 4

            baseFileName += Math.Floor(findquarter).ToString.PadLeft(2, "0"c)

            Return baseFileName
        End Function
#End Region

    End Class

#End Region

#Region " 225 Statement Heading "

    Public Class REC_225_Statement_Heading
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.REC_225_Statement_Heading

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.REC_225_Statement_Heading
            Se2Source = New SourceLayouts.REC_225_Statement_Heading
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "

        Public Function RepIndexText(ByVal value As Se2Args) As Object

            Dim RepIndex As String = ""

            RepIndex = "TAXID##" & Se2Source.TAX_ID & "##CONTRACT##VA" & Se2Source.CONT & "##RMAN##" & Se2Source.REP_MASTER_NUMBER & "Y##RLNAME##" & Se2Source.REP_LST & "##RFNAME##" & Se2Source.REP_FST & "##"

            Return RepIndex

        End Function

        Public Function BrkrIndexText(ByVal value As Se2Args) As Object

            Dim BrkrIndex As String = ""

            BrkrIndex = "##BMAN##" & Se2Source.BRKR_MASTER_NUMBER & "Y##LNAME##" & Se2Source.LST & "##FNAME##" & Se2Source.FST & "##PAYOR##" & " " & "##"

            Return BrkrIndex

        End Function

        Public Function Name(ByVal value As Se2Args) As Object

            Dim retval As String

            If Se2Source.MID = "" Then
                retval = Se2Source.FST & " " & Se2Source.LST

            Else
                retval = Se2Source.FST & " " & Se2Source.MID & " " & Se2Source.LST

            End If

            If Se2Source.SUFFIX <> "" Then
                retval += " " & Se2Source.SUFFIX
            End If

            Return retval

        End Function
        Public Function Address1(ByVal value As Se2Args) As Object

            Dim address As New List(Of String)
            address.Add(Se2Source.ADDRESS1)
            If Se2Source.ADDRESS2 <> "" Then
                address.Add(Se2Source.ADDRESS2)
            End If
            If Se2Source.ADDRESS3 <> "" Then
                address.Add(Se2Source.ADDRESS3)
            End If
            address.Add(Se2Source.CITY & "  " & Se2Source.STATE_CODE & " " & Se2Source.ZIP)
            address.Add("")
            address.Add("")

            If value.Accumulators.ContainsKey("225Address") Then
                value.Accumulators.Item("225Address") = address
            Else
                value.Accumulators.Add("225Address", address)
            End If

            Return CType(value.Accumulators.Item("225Address"), List(Of String))(0)

        End Function

        Public Function Address2(ByVal value As Se2Args) As Object

            Dim retval As String = ""

            retval = CType(value.Accumulators.Item("225Address"), List(Of String))(1)

            Return retval

        End Function
        Public Function Address3(ByVal value As Se2Args) As Object

            Dim retval As String = ""

            retval = CType(value.Accumulators.Item("225Address"), List(Of String))(2)

            Return retval

        End Function
        Public Function Address4(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            retval = CType(value.Accumulators.Item("225Address"), List(Of String))(3)

            Return retval

        End Function
        Public Function GET_REP_NAME(ByVal value As Se2Args) As String

            Dim retval As String

            If Se2Source.REP_MID = "" Then
                retval = Se2Source.REP_FST & " " & Se2Source.REP_LST & " " & Se2Source.REP_SUFFIX
            Else
                retval = Se2Source.REP_FST & " " & Se2Source.REP_MID & " " & Se2Source.REP_LST & " " & Se2Source.REP_SUFFIX

            End If

            retval = retval.Trim

            Return retval

        End Function

        Public Function REP_Address1(ByVal value As Se2Args) As Object

            Dim repaddress As New List(Of String)
            repaddress.Add(Se2Source.REP_ADDRESS1)
            If Se2Source.REP_ADDRESS2 <> "" Then
                repaddress.Add(Se2Source.REP_ADDRESS2)
            End If
            If Se2Source.REP_ADDRESS3 <> "" Then
                repaddress.Add(Se2Source.REP_ADDRESS3)
            End If
            repaddress.Add(Se2Source.REP_CITY & "  " & Se2Source.REP_STATE_CODE & " " & Se2Source.REP_ZIP)
            repaddress.Add("")
            repaddress.Add("")

            If value.Accumulators.ContainsKey("225REPAddress") Then
                value.Accumulators.Item("225REPAddress") = repaddress
            Else
                value.Accumulators.Add("225REPAddress", repaddress)
            End If

            Return CType(value.Accumulators.Item("225REPAddress"), List(Of String))(0)

        End Function

        Public Function REP_Address2(ByVal value As Se2Args) As Object

            Dim retval As String = ""

            retval = CType(value.Accumulators.Item("225REPAddress"), List(Of String))(1)

            Return retval

        End Function
        Public Function REP_Address3(ByVal value As Se2Args) As Object

            Dim retval As String = ""

            retval = CType(value.Accumulators.Item("225REPAddress"), List(Of String))(2)

            Return retval

        End Function
        Public Function REP_Address4(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            retval = CType(value.Accumulators.Item("225REPAddress"), List(Of String))(3)

            Return retval

        End Function
        Public Function AnntName(ByVal value As Se2Args) As String

            Dim retval As String

            If Se2Source.ANNTNT_MID = "" Then
                retval = Se2Source.ANNTNT_FST & " " & Se2Source.ANNTNT_LST
            Else
                retval = Se2Source.ANNTNT_FST & " " & Se2Source.ANNTNT_MID & " " & Se2Source.ANNTNT_LST

            End If

            Return retval

        End Function

        Public Function GET_BRKR_NAME(ByVal value As Se2Args) As Object

            Dim brokerName As String = ""

            brokerName = Se2Source.BRKR_LST

            'If brokerName.Length > 10 Then
            '    brokerName = brokerName.Substring(0, 10)
            'End If

            Return brokerName

        End Function
        Public Function GET_REP_PHONE(ByVal value As Se2Args) As Object

            Dim repphone As String = ""

            repphone = Se2Source.REP_AREA_CODE & "-" & Se2Source.REP_EXC & "-" & Se2Source.REP_PH_SUFFIX

            'If brokerName.Length > 10 Then
            '    brokerName = brokerName.Substring(0, 10)
            'End If

            Return repphone

        End Function

#End Region

    End Class

#End Region

    '#Region " 261 Policy Info "

    '    Public Class REC_261_Policy_Info
    '        Inherits BaseLogic

    '        Public Shadows Property Se2Source As SourceLayouts.PoC_Source

    '        Public Sub New()
    '            MyBase.New()
    '            ClientRecord = New Records.REC_261_Policy_Info
    '            Se2Source = New SourceLayouts.PoC_Source
    '            MyBase.Se2Source = Me.Se2Source
    '        End Sub


    '#Region " POPULATION FUNCTIONS "

    '#End Region

    '    End Class

    '#End Region
#Region " 265 Account Summary "

    Public Class REC_265_Account_Summary
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.REC_265_Account_Summary

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.REC_265_Account_Summary
            Se2Source = New SourceLayouts.REC_265_Account_Summary
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "

        Public Function QTD_PREM(ByVal value As Se2Args) As Object
            Dim retVal As String = ""

            retVal = (Se2Source.EOQ_CYTD_PREM - Se2Source.BOQ_CYTD_PREM).ToString
            Return retVal

        End Function

        Public Function QTD_WITHD(ByVal value As Se2Args) As Object
            Dim retVal As String = ""

            retVal = ((Se2Source.EOQ_CYTD_WITHD - Se2Source.BOQ_CYTD_WITHD + Se2Source.BOQ_CYTD_CALENDAR_FEES - Se2Source.EOQ_CYTD_CALENDAR_FEES + Se2Source.EOQ_CYTD_SURR_CHARGES - Se2Source.BOQ_CYTD_SURR_CHARGES) * -1).ToString
            Return retVal

        End Function

        Public Function YTD_WITHD(ByVal value As Se2Args) As Object
            Dim retVal As String = ""

            retVal = (((Se2Source.EOQ_CYTD_WITHD + Se2Source.EOQ_CYTD_SURR_CHARGES) * -1) + (Se2Source.EOQ_CYTD_CALENDAR_FEES)).ToString
            Return retVal

        End Function

        Public Function QTD_Chnge_Amt(ByVal value As Se2Args) As Object
            Dim retVal As Object = ""


            retVal = ((Se2Source.EOQ_ACCOUNTVAL - Se2Source.BOQ_ACCOUNTVAL) + (Se2Source.EOQ_CYTD_WITHD - Se2Source.BOQ_CYTD_WITHD) + ((Se2Source.EOQ_CYTD_CALENDAR_FEES - Se2Source.BOQ_CYTD_CALENDAR_FEES) * -1) + (Se2Source.EOQ_CYTD_SURR_CHARGES - Se2Source.BOQ_CYTD_SURR_CHARGES) - (Se2Source.EOQ_CYTD_PREM - Se2Source.BOQ_CYTD_PREM))
            Return retVal

        End Function

        Public Function YTD_Chnge_Amt(ByVal value As Se2Args) As Object
            Dim retVal As Object = ""

            retVal = ((Se2Source.EOQ_ACCOUNTVAL - Se2Source.BOY_ACCOUNTVAL) + ((Se2Source.EOQ_CYTD_WITHD + Se2Source.EOQ_CYTD_SURR_CHARGES) + (Se2Source.EOQ_CYTD_CALENDAR_FEES * -1))) - (Se2Source.EOQ_CYTD_PREM)
            Return retVal

        End Function
#End Region

    End Class

#End Region

#Region " 285 Account Summary Total "

    Public Class REC_285_Account_Summary_Total
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.REC_285_Account_Summary_Total

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.REC_285_Account_Summary_Total
            Se2Source = New SourceLayouts.REC_285_Account_Summary_Total
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "

#End Region

    End Class

#End Region

#Region " 290 Info_Record "

    Public Class REC_290_Info_Record
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.REC_290_Info_Record

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.REC_290_Info_Record
            Se2Source = New SourceLayouts.REC_290_Info_Record
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "

#End Region

    End Class

#End Region

    '#Region " 295 Enhanced Benefits "

    '    Public Class REC_295_Enhanced_Benefits
    '        Inherits BaseLogic

    '        Public Shadows Property Se2Source As SourceLayouts.PoC_Source

    '        Public Sub New()
    '            MyBase.New()
    '            ClientRecord = New Records.REC_295_Enhanced_Benefits
    '            Se2Source = New SourceLayouts.PoC_Source
    '            MyBase.Se2Source = Me.Se2Source
    '        End Sub


    '#Region " POPULATION FUNCTIONS "

    '#End Region

    '    End Class

    '#End Region

#Region " REC_605_Transaction_Summary "

    Public Class REC_605_Transaction_Summary
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.REC_605_Transaction_Summary

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.REC_605_Transaction_Summary
            Se2Source = New SourceLayouts.REC_605_Transaction_Summary

            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "



        Public Function FUND_CODE_DESC(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            If Se2Source.ACCT_TYPE = "F" Then
                retval += Se2Source.FUND_CODE_DESC & " at " & Math.Round(Se2Source.EOQ_RATE, 2).ToString & "%"
            Else
                retval += Se2Source.FUND_CODE_DESC
            End If

            Return retval
        End Function

        Public Function Fund_Type(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            If Se2Source.ACCT_TYPE = "V" Then
                retval = "VARIABLE"
            ElseIf Se2Source.ACCT_TYPE = "F" Then
                retval = "FIXED"
            Else
                retval = ""

            End If

            Return retval
        End Function

        Public Function EOQ_VALUE(ByVal value As Se2Args) As Object
            Dim retval As String = ""
            retval = Math.Round(Se2Source.EOQ_VALUE, 2).ToString

            retval += "00"

            Return retval
        End Function

        Public Function EOQ_UNITS(ByVal value As Se2Args) As Object
            Dim retval As String = ""
            retval = Math.Round(Se2Source.EOQ_UNITS, 6).ToString

            Dim tmpStr() As String

            tmpStr = retval.Split("."c)

            retval = tmpStr(0) & "." & tmpStr(1).PadRight(6, "0"c)

            Return retval
        End Function

        Public Function FUND_PCT(ByVal value As Se2Args) As Object
            Dim retval As String = ""
            If Se2Source.EOQ_VALUE <> 0 Then
                retval = Math.Round(((Se2Source.EOQ_VALUE / Se2Source.EOQ_ACCOUNTVAL) * 100), 2).ToString
            End If

            If retval.Contains("."c) Then
                retval += "00"
            Else
                retval += ".0000"
            End If

            Return retval
        End Function

        Public Function EOQ_UNIT_VALUE(ByVal value As Se2Args) As Object
            Dim retval As String = ""
            retval = Math.Round(Se2Source.EOQ_UNIT_VALUE, 6).ToString

            Dim tmpStr() As String

            tmpStr = retval.Split("."c)

            retval = tmpStr(0) & "." & tmpStr(1).PadRight(6, "0"c)

            Return retval
        End Function

#End Region

    End Class

#End Region

#Region " REC_625_Transaction_Summary_Total "

    Public Class REC_625_Transaction_Summary_Total
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.REC_625_Transaction_Summary_Total

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.REC_625_Transaction_Summary_Total
            Se2Source = New SourceLayouts.REC_625_Transaction_Summary_Total

            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "

#End Region

    End Class

#End Region

    '#Region " 830 Marketing Message "

    '    Public Class REC_830_Marketing_Message
    '        Inherits BaseLogic

    '        Public Shadows Property Se2Source As SourceLayouts.REC_830_Marketing_Message

    '        Public Sub New()
    '            MyBase.New()
    '            ClientRecord = New Records.REC_830_Marketing_Message
    '            Se2Source = New SourceLayouts.REC_830_Marketing_Message

    '            MyBase.Se2Source = Me.Se2Source
    '        End Sub


    '#Region " POPULATION FUNCTIONS "

    '#End Region

    '    End Class

    '#End Region
End Namespace
