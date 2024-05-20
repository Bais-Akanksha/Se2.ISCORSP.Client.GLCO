Imports Se2.ISI.Base
Imports Se2.ISI.Base.Utility
Imports Se2.ISI.Base.Presentation
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.DS.ReferenceData.ReferenceData
Imports System.Configuration


Namespace Se2.ISCORSP.Client.GLCO.FIAPolicyPage.CLM
#Region " HEADER "

    Public Class Header
        Inherits BaseLogic

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.COLUMNHEADERS
        End Sub

#Region " POPULATION FUNCTIONS "

        Public Function GetFileName(ByVal value As Se2Args) As Object
            Return value.SourceHeader.CONTENTS
        End Function

        Public Function GetCycleDate(ByVal value As Se2Args) As Object
            Return value.SourceHeader.CYCLE_DATE
        End Function

#End Region

    End Class

#End Region

#Region " COLUMN HEADERS "

    Public Class ColumnHeaders
        Inherits BaseLogic

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.COLUMNHEADERS
        End Sub

#Region " POPULATION FUNCTIONS "

        Public Function GetColumnHeaders(ByVal value As Se2Args) As Object
            Dim HeaderDef As RecordDef
            Select Case value.cmdLnArgs.PROCESSOR.ToUpper
                Case "POLICY"
                    HeaderDef = New Records.POLICY
                Case "VALUES"
                    HeaderDef = New Records.VALUES
                Case "ROLES", "ROLE"
                    HeaderDef = New Records.ROLES
                Case "PHONE"
                    HeaderDef = New Records.PHONE
                Case "ADDRESS"
                    HeaderDef = New Records.ADDRESS
                Case "FEATURE"
                    HeaderDef = New Records.FEATURE
                Case Else
                    HeaderDef = New Records.POLICY
            End Select

            Return HeaderDef.FieldList(",", """", """")
        End Function

#End Region

    End Class

#End Region


#Region " Policies "
    Public Class POLICIES
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.POLICIES

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.POLICIES
            Se2Source = New SourceLayouts.POLICIES
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region
#Region " Policy "
    Public Class POLICY
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.POLICY
        Public ReferenceData As New DSReference

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.POLICY
            Se2Source = New SourceLayouts.POLICY
            MyBase.Se2Source = Me.Se2Source
        End Sub
        Public Function GET_REC_TYPE(ByVal value As Se2Args) As Object
            'ClientRecord.NodeDescription = Se2Source.CN_CONT
            'fld.ElementDescription = Se2Source.CN_CONT
            Dim rownum As Object = Nothing
            If value.Accumulators.ContainsKey("ROW_DATA_COUNT") Then
                rownum = value.Accumulators.Item("ROW_DATA_COUNT")
                value.Accumulators("ROW_DATA_COUNT") = Convert.ToInt32(rownum) + 1
            Else
                value.Accumulators.AddToValue("ROW_DATA_COUNT", 1)
            End If
            Return "POLICY"
        End Function
        Public Function Get_Minimum_Maturity_Date(ByVal value As Se2Args) As Object
            Return DateAdd(DateInterval.Year, Se2Source.CN_GNTY_PERD, Se2Source.CN_ISSUE_DATE)
        End Function

        Public Function Get_Current_Payout_Amount(ByVal value As Se2Args) As Object
            Return Se2Source.PA_FIXED_PAY_AMT + Se2Source.PA_VAR_PAY_AMT
        End Function

        Public Function GET_NEXT_ANNIV_DATE(ByVal value As Se2Args) As Object

            Dim Anniv_Date As Date

            If Se2Source.CN_ISSUE_DATE.Month = 2 And Se2Source.CN_ISSUE_DATE.Day = 29 Then  'Leap year they want to see 3/1 as the next anniversary date
                Anniv_Date = New Date(Se2Source.CN_ISSUE_DATE.Year + 1, 3, 1)
            Else
                Anniv_Date = DateAdd(DateInterval.Year, 1, Se2Source.CN_ISSUE_DATE)
            End If

            Return Anniv_Date

        End Function

        Public Function Get_Policy_Status(ByVal value As Se2Args) As Object
            Dim Pol_Status As String = Nothing
            Select Case Se2Source.CN_STATUS.ToUpper
                Case "A"
                    Pol_Status = "ACTIVE"
            End Select
            Return Pol_Status
        End Function



        Public Function Get_Annuity_Option(ByVal value As Se2Args) As Object
            Dim Template_Option As String = ""
            If Trim(Se2Source.ANN_OPTION) = "Period Certain 5 - 30" Then
                Template_Option = "ANNUITY OPTION 1"
            ElseIf Trim(Se2Source.ANN_OPTION) = "Life Only" Then
                Template_Option = "ANNUITY OPTION 2"
            ElseIf Trim(Se2Source.ANN_OPTION) = "Life w Period Certain" Then
                Template_Option = "ANNUITY OPTION 3"
            ElseIf Trim(Se2Source.ANN_OPTION) = "Qual Joint Life And Survivor" Or Trim(Se2Source.ANN_OPTION) = "Qualified Joint &amp; Survivor" Then
                Template_Option = "ANNUITY OPTION 4a"
            ElseIf Trim(Se2Source.ANN_OPTION) = "Joint And 2 / 3 Contingent" Or Trim(Se2Source.ANN_OPTION) = "Qualified Joint &amp; 66% Survivor" Then
                Template_Option = "ANNUITY OPTION 4b"
            ElseIf Trim(Se2Source.ANN_OPTION) = "Joint And Survivor" Or Trim(Se2Source.ANN_OPTION) = "Joint &amp; 100% Survivor" Then
                Template_Option = "ANNUITY OPTION 5a"
            ElseIf Trim(Se2Source.ANN_OPTION) = "Joint And 2 / 3 Survivor" Or Trim(Se2Source.ANN_OPTION) = "Joint and 66% Survivor" Then
                Template_Option = "ANNUITY OPTION 5b"

            Else Template_Option = ""

            End If

            Return Template_Option
        End Function
        Public Function GetCycleDate(ByVal value As Se2Args) As Object
            Return value.SourceHeader.CYCLE_DATE
        End Function

        Public Function TrackingID(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            retval += System.Guid.NewGuid.ToString

            If Not value.Accumulators.ContainsKey("TrackingID") Then
                value.Accumulators.Add("TrackingID", retval)
            Else
                value.Accumulators.Item("TrackingID") = retval
            End If

            Return retval
        End Function

        Public Function Get_CONT_IMAGE(ByVal value As Se2Args) As Object
            Dim Pol_Cont_Image As String = ""
            Pol_Cont_Image = Se2Source.CN_CONT + ".pdf"
            Return Pol_Cont_Image
        End Function

        Public Function Get_IMAGE_Path(ByVal value As Se2Args) As String
            Dim grpID As String
            Dim Environ As String
            Dim retval As String
            Environ = value.cmdLnArgs.ENV
            grpID = value.cmdLnArgs.GROUPID
            retval = ReferenceData.RoleType.LC5xToDataServices_Code(Environ & "+" & grpID)
            Return retval
        End Function

        Public Function Get_VARIATION_DESC(ByVal value As Se2Args) As Object
            Dim VARIATION_DESC As String = Nothing
            Select Case Se2Source.SURR_PERIOD.ToUpper
                Case "5 YEAR"
                    VARIATION_DESC = "5"
                Case "7 YEAR SURRENDER"
                    VARIATION_DESC = "7"
                Case "10 YEAR WITH NO BONUS"
                    VARIATION_DESC = "10"
                Case "10 YEAR WITH BONUS"
                    VARIATION_DESC = "10"
                Case Else
                    VARIATION_DESC = Se2Source.SURR_PERIOD
            End Select
            Return VARIATION_DESC
        End Function


    End Class
#End Region

#Region " Values "
    Public Class VALUES
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.VALUES

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.VALUES
            Se2Source = New SourceLayouts.VALUES
            MyBase.Se2Source = Me.Se2Source
        End Sub



    End Class
#End Region
#Region " Value "
    Public Class VALUE
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.VALUE

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.VALUE
            Se2Source = New SourceLayouts.VALUE
            MyBase.Se2Source = Me.Se2Source
        End Sub
        Public Function Get_Alloc_Pct(ByVal values As Se2Args) As Object
            Return (Se2Source.VALUE / Se2Source.INIT_PREM) * 100
        End Function

    End Class
#End Region

#Region " Roles "
    Public Class ROLES
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.ROLES

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.ROLES
            Se2Source = New SourceLayouts.ROLES
            MyBase.Se2Source = Me.Se2Source
        End Sub


    End Class
#End Region
#Region " Role "
    Public Class ROLE
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.ROLE
        Public ReferenceData As New DSReference

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.ROLE
            Se2Source = New SourceLayouts.ROLE
            MyBase.Se2Source = Me.Se2Source
        End Sub


        Public Function Get_Name_Type(ByVal value As Se2Args) As Object
            Dim NameType As String = Nothing
            Select Case Se2Source.NAME_TYPE.ToUpper
                Case "IN"
                    NameType = "PRSN"
                Case "TR"
                    NameType = "TRUST"
                Case "OT"
                    NameType = "OTHER"
                Case "CO"
                    NameType = "ORG"
                Case Else
                    NameType = Se2Source.NAME_TYPE
            End Select
            Return NameType
        End Function

        Public Function Get_Gender(ByVal value As Se2Args) As Object
            Dim Gender_Type As String = Nothing
            Select Case Se2Source.SEX.ToUpper
                Case String.Empty
                    Gender_Type = "O"
                Case Else
                    Gender_Type = Se2Source.SEX
            End Select
            Return Gender_Type
        End Function
        Public Function ROLE_DESC(ByVal value As Se2Args) As String
            Dim retval As String

            retval = ReferenceData.RoleType.LC5xToDataServices_Code(Se2Source.ROLE_ID & "+" & Se2Source.OPT_ID)

            Return retval
        End Function
        Public Function Get_MAIL_TYPE(ByVal value As Se2Args) As Object
            Dim Del_Flag As String = Nothing

            Dim MAIL_FLAG As String = Se2Source.MAIL_TO.ToUpper

            If Se2Source.ROLE_ID = "-12" And MAIL_FLAG = "AGENT" Then
                Del_Flag = "TRUE"
            ElseIf (Se2Source.ROLE_ID = "0" And Se2Source.OPT_DESC.Contains("Primary")) And MAIL_FLAG.Contains("OWNER") Then
                Del_Flag = "TRUE"
            Else
                Del_Flag = "FALSE"
            End If

            'If (Se2Source.ROLE_ID = "-12" And MAIL_FLAG = "AGENT") Then
            '    Del_Flag = "TRUE"
            'ElseIf MAIL_FLAG.Contains("OWNER") And (Se2Source.ROLE_ID = "0" And Se2Source.OPT_DESC.Contains("Primary")) Then
            '    Del_Flag = "TRUE"
            'Else
            '    Del_Flag = "FALSE"
            'End If

            Return Del_Flag
        End Function

    End Class
#End Region


#Region " Phones "

    Public Class PHONES
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.PHONES

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.PHONES
            Se2Source = New SourceLayouts.PHONES
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region
#Region " Phone "

    Public Class PHONE
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.PHONE
        Public ReferenceData As New DSReference

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.PHONE
            Se2Source = New SourceLayouts.PHONE
            MyBase.Se2Source = Me.Se2Source
        End Sub
        Public Function ROLE_DESC(ByVal value As Se2Args) As String
            Dim retval As String

            retval = ReferenceData.RoleType.LC5xToDataServices_Code(Se2Source.ROLE_ID & "+" & Se2Source.OPT_ID)

            Return retval
        End Function
    End Class
#End Region


#Region " Addresses "

    Public Class ADDRESSES
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.ADDRESSES

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.ADDRESSES
            Se2Source = New SourceLayouts.ADDRESSES
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region
#Region " Address "

    Public Class ADDRESS
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.ADDRESS

        Public ReferenceData As New DSReference

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.ADDRESS
            Se2Source = New SourceLayouts.ADDRESS
            MyBase.Se2Source = Me.Se2Source
        End Sub


        Public Function Get_Address_Type_Code(ByVal value As Se2Args) As Object
            Dim Address_Type As String = Nothing
            Select Case Se2Source.ADDRESS_TYPE.ToUpper
                Case "A"
                    Address_Type = "ADDR"
                Case "B"
                    Address_Type = "BADDR"
                Case "H"
                    Address_Type = "HADDR"
                Case "M"
                    Address_Type = "MADDR"
                Case "O"
                    Address_Type = "OADDR"
                Case "P"
                    Address_Type = "PO BOX"
                Case "S"
                    Address_Type = "SADDR"
                Case "T"
                    Address_Type = "TADDR"
                Case "V"
                    Address_Type = "VADDR"
                Case "$$"
                    Address_Type = "OADDR"
                Case Else
                    Address_Type = Se2Source.ADDRESS_TYPE
            End Select
            Return Address_Type
        End Function
        Public Function ROLE_DESC(ByVal value As Se2Args) As String
            Dim retval As String

            retval = ReferenceData.RoleType.LC5xToDataServices_Code(Se2Source.ROLE_ID & "+" & Se2Source.OPT_ID)

            Return retval
        End Function
    End Class
#End Region

#Region " Features "
    Public Class FEATURES
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.FEATURES
        Public Sub New()
            MyBase.New
            ClientRecord = New Records.FEATURES
            Se2Source = New SourceLayouts.FEATURES
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class


#End Region
#Region " Feature "
    Public Class FEATURE
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.FEATURE

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.FEATURE
            Se2Source = New SourceLayouts.FEATURE
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region

#Region " LTYINCOMERATES "
    Public Class LTYINCOMERATES
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.LTYINCOMERATES
        Public Sub New()
            MyBase.New
            ClientRecord = New Records.LTYINCOMERATES
            Se2Source = New SourceLayouts.LTYINCOMERATES
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class


#End Region
#Region " LTYINCOMERATE "
    Public Class LTYINCOMERATE
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.LTYINCOMERATE

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.LTYINCOMERATE
            Se2Source = New SourceLayouts.LTYINCOMERATE
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region

End Namespace