Imports Se2.ISI.Base
Imports Se2.ISI.Base.Utility
Imports Se2.ISI.Base.Presentation
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.DS.ReferenceData.ReferenceData
Imports System.Configuration

Namespace Se2.ISCORSP.Client.GLCO.FIAAnnivStmt.CLM

#Region " Policies "
    Public Class Policies
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.Policies

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Policies
            Se2Source = New SourceLayouts.Policies
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region
#Region " Policy "
    Public Class Policy
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Policy

        Public ReferenceData As New DSReference
        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Policy
            Se2Source = New SourceLayouts.Policy
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "

        'Public Function QUAL_DESC(ByVal value As Se2Args) As String
        '    Dim retval As String

        '    retval = ReferenceData.QualType.LC5xToDataServices_Description(Se2Source.QUAL_CODE) -- source qual code was requested to be used for anniv stmt display.

        '    Return retval
        'End Function

        Public Function ACCOUNT_STATUS(ByVal value As Se2Args) As String
            Dim retval As String

            retval = ReferenceData.PolicyStatusType.LC5xToDataServices_Code(Se2Source.STATUS)

            Return retval
        End Function
        Public Function LINE_OF_BUSINESS(ByVal value As Se2Args) As String
            Dim retval As String

            retval = ReferenceData.LOBType.LC5xToDataServices_Code(Se2Source.PLN_TYPE)

            Return retval
        End Function

        Public Function MKT_PRDCT_NAME(ByVal value As Se2Args) As String
            Dim retval As String
            Dim _year As String
            If Se2Source.PLN_CODE = "887" Then
                If Se2Source.GGB_GRP_ID = "1" Then
                    _year = "5"
                ElseIf Se2Source.GGB_GRP_ID = "2" Then
                    _year = "7"
                ElseIf Se2Source.GGB_GRP_ID = "3" Then
                    _year = "10"
                ElseIf Se2Source.GGB_GRP_ID = "4" Then
                    _year = "14"
                Else
                    _year = ""
                End If
                retval = Trim(Se2Source.MKT_PRDCT_NAME) + _year
                Return retval
            End If

            If Se2Source.VARIATION_GROUP_DESC = "N" Then
                retval = Trim(Se2Source.MKT_PRDCT_NAME & " " & Se2Source.SUPERSCRIPT)
            Else
                retval = Trim(Se2Source.VARIATION_GROUP_DESC)
            End If

            Return retval

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
#End Region

    End Class

#End Region

#Region " Roles "
    Public Class Roles
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.Roles

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Roles
            Se2Source = New SourceLayouts.Roles
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region
#Region " Role "

    Public Class Role
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Role

        Public ReferenceData As New DSReference
        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.ROLE
            Se2Source = New SourceLayouts.Role
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "
        Public Function ROLE_DESC(ByVal value As Se2Args) As String
            Dim retval As String

            retval = ReferenceData.RoleType.LC5xToDataServices_Code(Se2Source.ROLE_ID & "+" & Se2Source.OPT_ID)

            Return retval
        End Function
        Public Function CUST_FULL_NAME(ByVal value As Se2Args) As String
            Dim retval As String

            If Se2Source.SUFFIX = "" Then
                retval = Se2Source.FST & " " & Se2Source.LST
            Else
                retval = Se2Source.FST & " " & Se2Source.LST & " " & Se2Source.SUFFIX
            End If

            Return retval

        End Function
        Public Function NAME_TYPE(ByVal value As Se2Args) As String
            Dim retval As String

            retval = ReferenceData.NameType.LC5xToDataServices_Code(Se2Source.NAME_TYPE)

            Return retval
        End Function

        Public Function ADDRESS_TYPE(ByVal value As Se2Args) As String
            Dim retval As String

            retval = ReferenceData.AddressType.LC5xToDataServices_Code(Se2Source.ADDRESS_TYPE)

            Return retval
        End Function
        Public Function PHONE_NUMBER(ByVal value As Se2Args) As String

            Dim retval As String = ""

            retval = Se2Source.AREA_CODE & Se2Source.EXC & Se2Source.PH_SUFFIX

            Return retval

        End Function

        Public Function FULL_ZIP_CODE(ByVal value As Se2Args) As String

            Dim retval As String

            retval = Se2Source.ZIP & Se2Source.ZIP_SUFFIX

            Return retval

        End Function
        Public Function PHONE_TYPE(ByVal value As Se2Args) As String
            Dim retval As String

            retval = ReferenceData.PhoneType.LC5xToDataServices_Code(Se2Source.PHONE_TYPE)

            Return retval
        End Function

        Public Function ROLE_PERCENT_SPLIT(ByVal value As Se2Args) As Object
            Dim retval As String = ""
            retval = Math.Round(Se2Source.PERCENT_SPLIT, 2).ToString

            Dim tmpStr() As String

            tmpStr = retval.Split("."c)

            retval = tmpStr(0) & "." & tmpStr(1).PadRight(2, "0"c)

            Return retval

        End Function

        Public Function MAIL_TYPE_IND(ByVal value As Se2Args) As String
            Dim retval As String = ""

            If Se2Source.MAIL_TYPE = "2" Then
                retval = "U"
            ElseIf Se2Source.MAIL_TYPE = "-25" Then
                retval = "E"
            ElseIf Se2Source.MAIL_TYPE = "-999" Then
                retval = "F"
            End If

            Return retval

        End Function

        Public Function MAIL_FLAG(ByVal value As Se2Args) As String
            If Se2Source.OPT_DESC = "Joint, Different Address" Then
                If Se2Source.JT_ADDR_DIFF = "Y" Then
                    Return "TRUE"
                ElseIf Se2Source.JT_ADDR_DIFF = "N" Then
                    Return "FALSE"
                Else
                    Return Se2Source.MAIL_FLAG
                End If
            Else
                Return Se2Source.MAIL_FLAG
            End If
        End Function

        Public Function GetEmailAddress(ByVal value As Se2Args) As Object
            Dim results As Boolean = True

            If CBool(Se2Source.MAIL_FLAG) Then


                Dim StoreEmail As New Se2.ISI.Base.Data.SQLExecutor
                StoreEmail.DataLocation = ConfigurationManager.AppSettings("connDOM")
                StoreEmail.ProcName = "[dbo].[DS.INSERT_LOG_STATUS_TRACKING]"



                Dim Parms As List(Of IDataParameter)


                Parms = New List(Of IDataParameter)

                StoreEmail.addParms("@TrackingID", CType(value.Accumulators.Item("TrackingID"), String))
                StoreEmail.addParms("@CompanyCode", "GLCO")
                StoreEmail.addParms("@Contract", Se2Source.CONT)
                StoreEmail.addParms("@Email", Se2Source.EMAIL)
                StoreEmail.addParms("@DeliveryMethod", MAIL_TYPE_IND(value))
                StoreEmail.addParms("@InsertUser", Environment.UserName)
                StoreEmail.addParms("@DocumentType", "ANN")
                StoreEmail.addParms("@CallingContext", Me.ToString)

                results = StoreEmail.ExecuteNonQuery

                If Not results Then

                End If
            End If

            Return Se2Source.EMAIL

        End Function

#End Region

    End Class

#End Region

#Region " CarrierInformation "
    Public Class CarrierInformation
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.CarrierInformation

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.CarrierInformation
            Se2Source = New SourceLayouts.CarrierInformation
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region
#Region " Carrier "

    Public Class Carrier
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Carrier

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Carrier
            Se2Source = New SourceLayouts.Carrier
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "

        Public Function CARRIER_PHONE_NUM(ByVal value As Se2Args) As String
            Dim retval As String

            retval = Se2Source.UNFRMTTD_PHONE & "(" & Se2Source.PHONE_NUM & ")"

            Return retval

        End Function

        Public Function CARRIER_FAX_NUM(ByVal value As Se2Args) As String
            Dim retval As String

            retval = Se2Source.FAX_AREA_CODE & Se2Source.FAX_NUM

            Return retval

        End Function

#End Region


    End Class

#End Region

#Region " Features "
    Public Class Features
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.Features
        Public Sub New()
            MyBase.New
            ClientRecord = New Records.FEATURES
            Se2Source = New SourceLayouts.Features
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class


#End Region
#Region " Feature "
    Public Class Feature
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.Feature

        Public ReferenceData As New DSReference
        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.FEATURE
            Se2Source = New SourceLayouts.Feature
            MyBase.Se2Source = Me.Se2Source
        End Sub
#Region " POPULATION FUNCTIONS "
        Public Function GetRiderActiveInd(ByVal value As Se2Args) As Object
            Dim retval As String = ""
            If Trim(Se2Source.SPEC_CODE) = "133" Then
                If Trim(Se2Source.VARIATION_GROUP_ID) = "1" Or Trim(Se2Source.VARIATION_GROUP_ID) = "3" Then
                    retval = "Y"
                ElseIf Trim(Se2Source.VARIATION_GROUP_ID) = "2" Then
                    retval = "N"
                End If
            Else
                retval = "N"
            End If
            Return retval
        End Function
        Public Function GetFeatDesc(ByVal value As Se2Args) As Object
            Dim retval As String = ""
            If Se2Source.PLN_CODE = "728" Then
                retval = Se2Source.VARIATION_GROUP_DESC
            ElseIf Se2Source.PLN_CODE = "772" Then
                retval = Se2Source.VARIATION_DESC
            ElseIf Se2Source.PLN_CODE = "887" Then
                retval = Se2Source.VARIATION_DESC
            Else
                retval = ""
            End If
            Return retval
        End Function
        Public Function GetRiderLevelAmt(ByVal value As Se2Args) As Object
            Dim retval As String = ""
            If Se2Source.PLN_CODE = "728" Then
                retval = ""
            ElseIf Se2Source.PLN_CODE = "772" Then
                retval = CType(Se2Source.GLWB_LEVEL_PAYOUT, String)
            ElseIf Se2Source.PLN_CODE = "887" Then
                retval = CType(Se2Source.GLWB_LEVEL_PAYOUT, String)
            Else
                retval = ""
            End If
            Return retval
        End Function
        Public Function GetRiderIncreAmt(ByVal value As Se2Args) As Object
            Dim retval As String = ""
            If Se2Source.PLN_CODE = "728" Then
                retval = ""
            ElseIf Se2Source.PLN_CODE = "772" Then
                retval = CType(Se2Source.GLWB_INCRE_PAYOUT, String)
            ElseIf Se2Source.PLN_CODE = "887" Then
                retval = CType(Se2Source.GLWB_INCRE_PAYOUT, String)
            Else
                retval = ""
            End If
            Return retval
        End Function

#End Region
    End Class

#End Region

#Region " PolValues "
    Public Class PolValues
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.PolValues

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.PolValues
            Se2Source = New SourceLayouts.PolValues
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region
#Region " PolValue "

    Public Class PolValue
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.PolValue

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.PolValue
            Se2Source = New SourceLayouts.PolValue
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "
        Public Function INTEREST_CREDITED(ByVal value As Se2Args) As String
            Dim retVal As String = ""

            retVal = (Se2Source.CURR_ACCT_VAL - Se2Source.PRIOR_ACCT_VAL - Se2Source.PYTD_PREM + (Se2Source.PYTD_WITHD * -1)).ToString

            Return retVal
        End Function

        Public Function GetPrem(ByVal value As Se2Args) As Object
            Dim retVal As String

            If Se2Source.PLN_CODE = "728" Then
                retVal = CType(Se2Source.PYTD_PREM, String)
            ElseIf Se2Source.PLN_CODE = "772" Then
                retVal = CType(Se2Source.TXN_AMT, String)
            ElseIf Se2Source.PLN_CODE = "887" Then
                retVal = CType(Se2Source.TXN_AMT, String)  'CType((Se2Source.PYTD_PREM - Se2Source.CHARGE), String)
            Else
                retVal = ""
            End If

            Return retVal

        End Function

        Public Function GetPremBonus(ByVal value As Se2Args) As Object
            Dim retVal As String
            If Se2Source.PLN_CODE = "772" Then
                retVal = (Se2Source.CHARGE * -1).ToString
            ElseIf Se2Source.PLN_CODE = "887" Then
                retVal = (Se2Source.CHARGE * -1).ToString
            Else
                retVal = ""
            End If

            Return retVal

        End Function
        Public Function CASH_SURR_VALUE(ByVal value As Se2Args) As String
            Dim retVal As String = ""

            retVal = (Se2Source.CURR_ACCT_VAL - Se2Source.SURR_CHRG).ToString

            Return retVal
        End Function

        Public Function INDEX_INTEREST_CREDIT(ByVal value As Se2Args) As Object
            Dim retVal As String

            retVal = (Se2Source.INDEX_INTEREST_CREDIT * -1).ToString

            Return retVal

        End Function
        Public Function FIXED_INTEREST_CREDITED(ByVal value As Se2Args) As String
            Dim retVal As String = ""
            Dim Fixedint As Decimal
            Dim EndingVal As Decimal = Se2Source.CURR_ACCT_VAL
            Dim BeginVal As Decimal = Se2Source.PRIOR_ACCT_VAL
            Dim IndxCredit As Decimal = Se2Source.INDEX_INTEREST_CREDIT * -1
            Dim PremiumPaid As Decimal = Se2Source.PYTD_PREM
            Dim withdrawals As Decimal = Se2Source.PYTD_WITHD
            Dim Riderfees As Decimal = Se2Source.RIDER_CHRG * -1

            'Ending value – beginning value – index credits – premiums paid + withdrawals + fees = fixed interest 

            Fixedint = (EndingVal - BeginVal - IndxCredit) - (PremiumPaid + withdrawals + Riderfees)
            retVal = Fixedint.ToString

            Return retVal

        End Function
        Public Function CALC_EARLY_DATE(ByVal value As Se2Args) As Object
            Dim retVal As String = ""
            Dim CycleDate As String = CType(value.SourceHeader.CYCLE_DATE, String)
            Dim GLWB_PAYOUT_DT_final As String
            Dim GLWB_PAYOUT_DT As String = Se2Source.GLWB_BENE_PAYOUT_ST_DATE
            GLWB_PAYOUT_DT = CType(Val(GLWB_PAYOUT_DT), String)

            GLWB_PAYOUT_DT_final = Left(CType(GLWB_PAYOUT_DT, String), 4) + "-" + Mid(CType(GLWB_PAYOUT_DT, String), 5, 2) + "-" + Right(CType(GLWB_PAYOUT_DT, String), 2)

            If Se2Source.PLN_CODE = "728" Then
                If Se2Source.GMWB_PHASE = 1 Then
                    retVal = "12/31/2999"
                ElseIf Se2Source.GMWB_PHASE = 0 Then
                    If Se2Source.CONT_YR <= 3 Then
                        retVal = CType(DateAdd(DateInterval.Year, 3, Se2Source.ISSUE_DATE), String)
                    ElseIf Se2Source.CONT_YR >= 4 Then
                        retVal = CycleDate
                    End If
                End If
            ElseIf Se2Source.PLN_CODE = "772" Then
                retVal = GLWB_PAYOUT_DT_final
            ElseIf Se2Source.PLN_CODE = "887" Then
                retVal = GLWB_PAYOUT_DT_final
            End If



            'SPECID=108339

            Return retVal
        End Function
        Public Function RIDER_CHARGE(ByVal value As Se2Args) As Decimal
            Dim retval As Decimal

            retval = Se2Source.RIDER_CHRG * -1

            Return retval

        End Function
        Public Function GetPremAmount(ByVal value As Se2Args) As Object
            Dim retVal As String
            If Se2Source.PLN_CODE = "772" And Se2Source.PLN_CODE = "728" Then
                retVal = ""
            Else
                retVal = Se2Source.PYTD_PREM_BONUS.ToString
            End If

            Return retVal

        End Function
        Public Function GetBonusAmount(ByVal value As Se2Args) As Object
            Dim retVal As String
            If Se2Source.PLN_CODE = "772" And Se2Source.PLN_CODE = "728" Then
                retVal = ""
            Else
                retVal = Se2Source.BONUS_INT_AMT.ToString
            End If

            Return retVal

        End Function

#End Region


    End Class

#End Region

#Region " FundValues "
    Public Class FundValues
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.FundValues

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.FundValues
            Se2Source = New SourceLayouts.FundValues
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region
#Region " FundValue "

    Public Class FundValue
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.FundValue

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.FundValue
            Se2Source = New SourceLayouts.FundValue
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "

        Public Function PARTICIPATION_RATE(ByVal value As Se2Args) As String

            Dim retval As String = ""
            retval = Math.Round((Se2Source.EQUITY_INDEX_PART_RATE * 100), 2).ToString


            Dim tmpStr() As String

            tmpStr = retval.Split("."c)

            retval = tmpStr(0) & "." & tmpStr(1).PadRight(2, "0"c).ToString

            Return retval

        End Function

        Public Function INDEX_CAP_RATE(ByVal value As Se2Args) As Object

            Dim retval As String = ""
            retval = Math.Round((Se2Source.EQUITY_INDEX_CAP_RATE * 100), 2).ToString


            Dim tmpStr() As String

            tmpStr = retval.Split("."c)

            retval = tmpStr(0) & "." & tmpStr(1).PadRight(2, "0"c).ToString

            Return retval

        End Function
        Public Function INDEX_SPREAD_RATE(ByVal value As Se2Args) As String

            Dim retval As String = ""
            retval = Math.Round((Se2Source.EQUITY_INDEX_SPREAD * 100), 2).ToString


            Dim tmpStr() As String

            tmpStr = retval.Split("."c)

            retval = tmpStr(0) & "." & tmpStr(1).PadRight(2, "0"c).ToString

            Return retval

        End Function
        Public Function INTEREST_RATE(ByVal value As Se2Args) As String

            Dim retval As String = ""
            retval = Math.Round(Se2Source.RATE, 2).ToString


            Dim tmpStr() As String

            tmpStr = retval.Split("."c)

            retval = tmpStr(0) & "." & tmpStr(1).PadRight(2, "0"c).ToString

            Return retval


        End Function

        Public Function INDEX_VALUE(ByVal value As Se2Args) As String

            Dim retval As String = ""
            retval = Math.Round(Se2Source.BEG_INDEX_VALUE, 2).ToString


            Dim tmpStr() As String

            tmpStr = retval.Split("."c)

            retval = tmpStr(0) & "." & tmpStr(1).PadRight(2, "0"c).ToString

            Return retval


        End Function
#End Region


    End Class

#End Region

#Region " PriorAnnvFunds "
    Public Class PriorAnnvFunds
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.PriorAnnvFunds

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.PriorAnnvFunds
            Se2Source = New SourceLayouts.PriorAnnvFunds
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region
#Region " PriorAnnvFund "

    Public Class PriorAnnvFund
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.PriorAnnvFund


        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.PriorAnnvFund
            Se2Source = New SourceLayouts.PriorAnnvFund
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "

        Public Function PRIOR_PART_RATE(ByVal value As Se2Args) As String

            Dim retval As String = ""
            retval = Math.Round(((Se2Source.APPLIED_PART_RATE) * 100), 2).ToString


            Return retval

        End Function
        Public Function PRIOR_INDEX_CAP_RATE(ByVal value As Se2Args) As Object

            Dim retval As String = ""
            retval = Math.Round((Se2Source.APPLIED_CAP_RATE * 100), 2).ToString

            Return retval

        End Function
        Public Function PRIOR_SPREAD_RATE(ByVal value As Se2Args) As String

            'Dim retval As String = ""
            'retval = Math.Round((Se2Source.SPREAD_RATE * 100), 2).ToString


            Dim retval As String = ""

            retval = "0.00" 'FIA plan code 728 does not have Index Strategy with Spread Rate so populating default value 

            Return retval


        End Function
        Public Function INDX_GRWTH_RATE(ByVal value As Se2Args) As String

            Dim retval As String = ""
            Select Case Se2Source.ACC_CODE
                Case "7E6", "7E7", "7E9", "7R7", "7R8", "7RS", "7RR", "7RB", "7RQ", "7RO", "7RC", "7RP", "7RN", "Z2C", "Z2D", "Z2E", "Z2F", "ZE0"
                    If Se2Source.INDEX_EOP <> 0 And Se2Source.INDEX_BOP_VAL <> 0 Then
                        retval = ((Se2Source.INDEX_EOP / Se2Source.INDEX_BOP_VAL) - 1).ToString
                    End If
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM"
                    retval = (Se2Source.EI_GROWTH_PERCENT).ToString
                Case Else
                    retval = "0.00"
            End Select

            Return retval

        End Function
        Public Function MTH1_INDX_CHG(ByVal value As Se2Args) As String
            Dim retval As String = ""

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP2 <> 0 And Se2Source.EI_BOP1 <> 0 Then
                        retval = ((Se2Source.EI_BOP2 / Se2Source.EI_BOP1) - 1).ToString
                    End If
                Case Else
                    retval = ""
            End Select

            Return retval

        End Function
        Public Function APPLD_CHG_MTH1(ByVal value As Se2Args) As Decimal
            Dim Index_Change1 As Decimal
            Dim Cap_rate As Decimal = Se2Source.APPLIED_CAP_RATE
            Dim retval As Decimal

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP2 <> 0 And Se2Source.EI_BOP1 <> 0 Then
                        Index_Change1 = ((Se2Source.EI_BOP2 / Se2Source.EI_BOP1) - 1)
                    End If
            End Select
            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    retval = Math.Min((Index_Change1), (Cap_rate))
                Case Else
                    retval = 0
            End Select

            Return retval

        End Function
        Public Function MTH2_INDX_CHG(ByVal value As Se2Args) As String
            Dim retval As String = ""

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP3 <> 0 And Se2Source.EI_BOP2 <> 0 Then
                        retval = ((Se2Source.EI_BOP3 / Se2Source.EI_BOP2) - 1).ToString
                    End If
                Case Else
                    retval = ""
            End Select

            Return retval

        End Function
        Public Function APPLD_CHG_MTH2(ByVal value As Se2Args) As Decimal
            Dim Index_Change1 As Decimal
            Dim Cap_rate As Decimal = Se2Source.APPLIED_CAP_RATE
            Dim retval As Decimal

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP3 <> 0 And Se2Source.EI_BOP2 <> 0 Then
                        Index_Change1 = ((Se2Source.EI_BOP3 / Se2Source.EI_BOP2) - 1)
                    End If
            End Select

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    retval = Math.Min((Index_Change1), (Cap_rate))
                Case Else
                    retval = 0
            End Select

            Return retval

        End Function
        Public Function MTH3_INDX_CHG(ByVal value As Se2Args) As String
            Dim retval As String = ""

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP4 <> 0 And Se2Source.EI_BOP3 <> 0 Then
                        retval = ((Se2Source.EI_BOP4 / Se2Source.EI_BOP3) - 1).ToString
                    End If
                Case Else
                    retval = ""
            End Select

            Return retval

        End Function
        Public Function APPLD_CHG_MTH3(ByVal value As Se2Args) As Decimal
            Dim Index_Change1 As Decimal
            Dim Cap_rate As Decimal = Se2Source.APPLIED_CAP_RATE
            Dim retval As Decimal

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP4 <> 0 And Se2Source.EI_BOP3 <> 0 Then
                        Index_Change1 = ((Se2Source.EI_BOP4 / Se2Source.EI_BOP3) - 1)
                    End If
            End Select

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    retval = Math.Min((Index_Change1), (Cap_rate))
                Case Else
                    retval = 0
            End Select

            Return retval

        End Function
        Public Function MTH4_INDX_CHG(ByVal value As Se2Args) As String
            Dim retval As String = ""

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP5 <> 0 And Se2Source.EI_BOP4 <> 0 Then
                        retval = ((Se2Source.EI_BOP5 / Se2Source.EI_BOP4) - 1).ToString
                    End If
                Case Else
                    retval = ""
            End Select

            Return retval

        End Function
        Public Function APPLD_CHG_MTH4(ByVal value As Se2Args) As Decimal
            Dim Index_Change1 As Decimal
            Dim Cap_rate As Decimal = Se2Source.APPLIED_CAP_RATE
            Dim retval As Decimal

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP5 <> 0 And Se2Source.EI_BOP4 <> 0 Then
                        Index_Change1 = ((Se2Source.EI_BOP5 / Se2Source.EI_BOP4) - 1)
                    End If
            End Select

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    retval = Math.Min((Index_Change1), (Cap_rate))
                Case Else
                    retval = 0
            End Select

            Return retval

        End Function
        Public Function MTH5_INDX_CHG(ByVal value As Se2Args) As String
            Dim retval As String = ""

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP6 <> 0 And Se2Source.EI_BOP5 <> 0 Then
                        retval = ((Se2Source.EI_BOP6 / Se2Source.EI_BOP5) - 1).ToString
                    End If
                Case Else
                    retval = ""
            End Select

            Return retval

        End Function
        Public Function APPLD_CHG_MTH5(ByVal value As Se2Args) As Decimal
            Dim Index_Change1 As Decimal
            Dim Cap_rate As Decimal = Se2Source.APPLIED_CAP_RATE
            Dim retval As Decimal

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP6 <> 0 And Se2Source.EI_BOP5 <> 0 Then
                        Index_Change1 = ((Se2Source.EI_BOP6 / Se2Source.EI_BOP5) - 1)
                    End If
            End Select

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    retval = Math.Min((Index_Change1), (Cap_rate))
                Case Else
                    retval = 0
            End Select

            Return retval

        End Function
        Public Function MTH6_INDX_CHG(ByVal value As Se2Args) As String
            Dim retval As String = ""

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP7 <> 0 And Se2Source.EI_BOP6 <> 0 Then
                        retval = ((Se2Source.EI_BOP7 / Se2Source.EI_BOP6) - 1).ToString
                    End If
                Case Else
                    retval = ""
            End Select

            Return retval

        End Function
        Public Function APPLD_CHG_MTH6(ByVal value As Se2Args) As Decimal
            Dim Index_Change1 As Decimal
            Dim Cap_rate As Decimal = Se2Source.APPLIED_CAP_RATE
            Dim retval As Decimal

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP6 <> 0 And Se2Source.EI_BOP7 <> 0 Then
                        Index_Change1 = ((Se2Source.EI_BOP7 / Se2Source.EI_BOP6) - 1)
                    End If
            End Select

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    retval = Math.Min((Index_Change1), (Cap_rate))
                Case Else
                    retval = 0
            End Select

            Return retval

        End Function
        Public Function MTH7_INDX_CHG(ByVal value As Se2Args) As String
            Dim retval As String = ""

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP8 <> 0 And Se2Source.EI_BOP7 <> 0 Then
                        retval = ((Se2Source.EI_BOP8 / Se2Source.EI_BOP7) - 1).ToString
                    End If
                Case Else
                    retval = ""
            End Select

            Return retval

        End Function
        Public Function APPLD_CHG_MTH7(ByVal value As Se2Args) As Decimal
            Dim Index_Change1 As Decimal
            Dim Cap_rate As Decimal = Se2Source.APPLIED_CAP_RATE
            Dim retval As Decimal

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP8 <> 0 And Se2Source.EI_BOP7 <> 0 Then
                        Index_Change1 = ((Se2Source.EI_BOP8 / Se2Source.EI_BOP7) - 1)
                    End If
            End Select

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    retval = Math.Min((Index_Change1), (Cap_rate))
                Case Else
                    retval = 0
            End Select

            Return retval

        End Function
        Public Function MTH8_INDX_CHG(ByVal value As Se2Args) As String
            Dim retval As String = ""

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP9 <> 0 And Se2Source.EI_BOP8 <> 0 Then
                        retval = ((Se2Source.EI_BOP9 / Se2Source.EI_BOP8) - 1).ToString
                    End If
                Case Else
                    retval = ""
            End Select

            Return retval

        End Function
        Public Function APPLD_CHG_MTH8(ByVal value As Se2Args) As Decimal
            Dim Index_Change1 As Decimal
            Dim Cap_rate As Decimal = Se2Source.APPLIED_CAP_RATE
            Dim retval As Decimal

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP9 <> 0 And Se2Source.EI_BOP8 <> 0 Then
                        Index_Change1 = ((Se2Source.EI_BOP9 / Se2Source.EI_BOP8) - 1)
                    End If
            End Select

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    retval = Math.Min((Index_Change1), (Cap_rate))
                Case Else
                    retval = 0
            End Select

            Return retval

        End Function
        Public Function MTH9_INDX_CHG(ByVal value As Se2Args) As String
            Dim retval As String = ""

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP10 <> 0 And Se2Source.EI_BOP9 <> 0 Then
                        retval = ((Se2Source.EI_BOP10 / Se2Source.EI_BOP9) - 1).ToString
                    End If
                Case Else
                    retval = ""
            End Select

            Return retval

        End Function
        Public Function APPLD_CHG_MTH9(ByVal value As Se2Args) As Decimal
            Dim Index_Change1 As Decimal
            Dim Cap_rate As Decimal = Se2Source.APPLIED_CAP_RATE
            Dim retval As Decimal

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP10 <> 0 And Se2Source.EI_BOP9 <> 0 Then
                        Index_Change1 = ((Se2Source.EI_BOP10 / Se2Source.EI_BOP9) - 1)
                    End If
            End Select

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    retval = Math.Min((Index_Change1), (Cap_rate))
                Case Else
                    retval = 0
            End Select

            Return retval

        End Function
        Public Function MTH10_INDX_CHG(ByVal value As Se2Args) As String
            Dim retval As String = ""

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP11 <> 0 And Se2Source.EI_BOP10 <> 0 Then
                        retval = ((Se2Source.EI_BOP11 / Se2Source.EI_BOP10) - 1).ToString
                    End If
                Case Else
                    retval = ""
            End Select

            Return retval

        End Function
        Public Function APPLD_CHG_MTH10(ByVal value As Se2Args) As Decimal
            Dim Index_Change1 As Decimal
            Dim Cap_rate As Decimal = Se2Source.APPLIED_CAP_RATE
            Dim retval As Decimal

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP11 <> 0 And Se2Source.EI_BOP10 <> 0 Then
                        Index_Change1 = ((Se2Source.EI_BOP11 / Se2Source.EI_BOP10) - 1)
                    End If
            End Select

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    retval = Math.Min((Index_Change1), (Cap_rate))
                Case Else
                    retval = 0
            End Select

            Return retval

        End Function
        Public Function MTH11_INDX_CHG(ByVal value As Se2Args) As String
            Dim retval As String = ""

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP12 <> 0 And Se2Source.EI_BOP11 <> 0 Then
                        retval = ((Se2Source.EI_BOP12 / Se2Source.EI_BOP11) - 1).ToString
                    End If
                Case Else
                    retval = ""
            End Select

            Return retval

        End Function
        Public Function APPLD_CHG_MTH11(ByVal value As Se2Args) As Decimal
            Dim Index_Change1 As Decimal
            Dim Cap_rate As Decimal = Se2Source.APPLIED_CAP_RATE
            Dim retval As Decimal

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.EI_BOP12 <> 0 And Se2Source.EI_BOP11 <> 0 Then
                        Index_Change1 = ((Se2Source.EI_BOP12 / Se2Source.EI_BOP11) - 1)
                    End If
            End Select

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    retval = Math.Min((Index_Change1), (Cap_rate))
                Case Else
                    retval = 0
            End Select

            Return retval

        End Function
        Public Function MTH12_INDX_CHG(ByVal value As Se2Args) As String
            Dim retval As String = ""

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.INDEX_EOP <> 0 And Se2Source.EI_BOP12 <> 0 Then
                        retval = ((Se2Source.INDEX_EOP / Se2Source.EI_BOP12) - 1).ToString
                    End If
                Case Else
                    retval = ""
            End Select

            Return retval

        End Function
        Public Function APPLD_CHG_MTH12(ByVal value As Se2Args) As Decimal
            Dim Index_Change1 As Decimal
            Dim Cap_rate As Decimal = Se2Source.APPLIED_CAP_RATE
            Dim retval As Decimal

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    If Se2Source.INDEX_EOP <> 0 And Se2Source.EI_BOP12 <> 0 Then
                        Index_Change1 = ((Se2Source.INDEX_EOP / Se2Source.EI_BOP12) - 1)
                    End If
            End Select

            Select Case Se2Source.ACC_CODE
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    retval = Math.Min((Index_Change1), (Cap_rate))
                Case Else
                    retval = 0
            End Select

            Return retval

        End Function
        Public Function INDEX_CREDIT_PERCENT(ByVal value As Se2Args) As String
            Dim retval As String = ""

            Select Case Se2Source.ACC_CODE
                Case "7E6", "7R7", "7RS", "7RR", "7RB", "7RQ"
                    retval = Math.Max(Math.Min(CType(Se2Source.EI_GROWTH_PERCENT, Decimal), CType(Se2Source.APPLIED_CAP_RATE, Decimal)), 0).ToString
                Case "7E7", "7E9", "7R8", "7RO", "7RC", "7RP", "7RN", "Z2C", "Z2D", "Z2E", "Z2F"
                    retval = (Math.Max(CType(Se2Source.EI_GROWTH_PERCENT, Decimal), 0)).ToString '* CType(Se2Source.APPLIED_PART_RATE, Decimal)).ToString -- 2/5 Removed calc to mulitple by PART_RATE as source file has this applied. 
                Case "7E8", "7R9", "7RK", "7RD", "7RL", "7RM", "ZE0"
                    retval = Math.Max(APPLD_CHG_MTH1(value) + APPLD_CHG_MTH2(value) + APPLD_CHG_MTH3(value) + APPLD_CHG_MTH4(value) + APPLD_CHG_MTH5(value) + APPLD_CHG_MTH6(value) + APPLD_CHG_MTH7(value) + APPLD_CHG_MTH8(value) + APPLD_CHG_MTH9(value) + APPLD_CHG_MTH10(value) + APPLD_CHG_MTH11(value) + APPLD_CHG_MTH12(value), 0).ToString
                Case Else
                    'return blank if not Se2Source.ACC_CODE
            End Select

            Return retval

        End Function

#End Region


    End Class

#End Region

#Region " TransHst "
    Public Class TransHst
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.TransHst

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.TransHst
            Se2Source = New SourceLayouts.TransHst
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region
#Region " TxnHst "

    Public Class TxnHst
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.TxnHst

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.TxnHst
            Se2Source = New SourceLayouts.TxnHst
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "
        Public Function TXN_TYPE_DESC(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            If Se2Source.TXN_TYPE = "11" Then
                retval = "Systematic Withdrawal"
            ElseIf Se2Source.TXN_TYPE = "44" Then
                retval = "Minimum Required Distribution"
            ElseIf Se2Source.TXN_TYPE = "60" Then
                retval = "Indexed Interest"
            Else retval = Se2Source.TXN_TYPE_DESC
            End If

            Return retval

        End Function

        Public Function TOTAL_TXN_AMT(ByVal value As Se2Args) As Decimal
            Dim retval As Decimal

            If Se2Source.TXN_TYPE = "60" Then
                retval = Se2Source.INDEX_INTEREST_CREDIT * -1
            Else retval = Se2Source.TOTAL_FUND_TXN_AMT
            End If

            Return retval


        End Function
#End Region


    End Class

#End Region

#Region " TransFndHst "
    Public Class TransFndHst
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.TransFndHst

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.TransFndHst
            Se2Source = New SourceLayouts.TransFndHst
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region
#Region " TxnFndHst "

    Public Class TxnFndHst
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.TxnFndHst

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.TxnFndHst
            Se2Source = New SourceLayouts.TxnFndHst
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "
        Public Function FUND_TXN_AMT(ByVal value As Se2Args) As Decimal
            Dim retval As Decimal

            If Se2Source.TXN_TYPE = "60" Then
                retval = (Se2Source.FUND_TXN_AMT * -1)
            Else retval = Se2Source.FUND_TXN_AMT
            End If

            Return retval


        End Function

#End Region


    End Class

#End Region



End Namespace
