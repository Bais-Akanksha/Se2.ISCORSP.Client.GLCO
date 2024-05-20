Imports Se2.ISI.Base
Imports Se2.ISI.Base.Utility
Imports Se2.ISI.Base.Presentation
Imports Se2.ISI.Base.Processing
Imports System.Configuration

Namespace Se2.ISCORSP.Client.GLCO.FinancialConfirm.CLM

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

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Policy
            Se2Source = New SourceLayouts.Policy
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "
        Public Function MAIL_TYPE_IND(ByVal value As Se2Args) As String
            Dim retval As String = ""

            If Se2Source.MAIL_TYPE = "2" Then
                retval = "U"
            ElseIf Se2Source.MAIL_TYPE = "-999" Then
                retval = "F"
            End If

            Return retval

        End Function

        Public Function MKT_PRDCT(ByVal value As Se2Args) As String
            Dim retval As String
            If Se2Source.VARIATION_GROUP_DESC = "N" Then
                retval = Trim(Se2Source.MKT_PRDCT_NAME & " " & Se2Source.SUPERSCRIPT)
            Else
                retval = Se2Source.VARIATION_GROUP_DESC
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

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.ROLE
            Se2Source = New SourceLayouts.Role
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "
        Public Function CUST_FULL_NAME(ByVal value As Se2Args) As String
            Dim retval As String = Se2Source.FST & " " & Se2Source.LST & " " & Se2Source.SUFFIX

            If Se2Source.FST = "" Then
                retval = Se2Source.LST
            ElseIf Se2Source.SUFFIX = "" Then
                retval = Se2Source.FST & " " & Se2Source.LST
            Else
                Return retval
            End If

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
                StoreEmail.addParms("@DocumentType", "FINCM")
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

#Region " Transaction Summaries "
    Public Class TransactionSummaries
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.TransactionSummaries

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.TransactionSummaries
            Se2Source = New SourceLayouts.TransactionSummaries
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region
#Region " TransactionSummary "

    Public Class TransactionSummary
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.TransactionSummary

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.TransactionSummary
            Se2Source = New SourceLayouts.TransactionSummary
            MyBase.Se2Source = Me.Se2Source
        End Sub

#Region " POPULATION FUNCTIONS "
        Public Function TXN_TYPE_DESC(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            If Se2Source.TXN_TYPE = "11" Then
                retval = "Systematic Withdrawal"
            ElseIf Se2Source.TXN_TYPE = "44" Then
                retval = "Minimum Required Distribution"
            ElseIf Se2Source.TXN_TYPE = "36" Then
                retval = "Rebalance Transfer"
            ElseIf Se2Source.TXN_TYPE = "213" Then
                retval = "Advisory Fee Withdrawal"
            Else retval = Se2Source.TXN_TYPE_DESC
            End If

            Return retval

        End Function

        Public Function TOTAL_TXN_AMT(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            If Se2Source.TXN_TYPE = "20" And Se2Source.TXN_STATUS <> "U" Then
                retval = (Se2Source.TXN_TOTAL * -1).ToString
            ElseIf Se2Source.TXN_TYPE = "20" And Se2Source.TXN_STATUS = "U" Then
                retval = (Se2Source.TXN_TOTAL).ToString
            ElseIf Se2Source.PLN_CODE = "772" And Se2Source.TXN_STATUS <> "U" And Se2Source.TXN_TYPE = "1" Then
                retval = (Se2Source.TXN_AMT).ToString
            ElseIf Se2Source.PLN_CODE = "772" And Se2Source.TXN_STATUS <> "U" And Se2Source.TXN_TYPE = "6" Then
                retval = (Se2Source.TXN_AMT).ToString
            ElseIf Se2Source.PLN_CODE = "772" And Se2Source.TXN_STATUS <> "U" And Se2Source.TXN_TYPE = "7" Then
                retval = (Se2Source.TXN_AMT).ToString
            ElseIf Se2Source.PLN_CODE = "772" And Se2Source.TXN_STATUS = "U" And Se2Source.TXN_TYPE = "1" Then
                retval = (Se2Source.TXN_AMT * -1).ToString
            ElseIf Se2Source.PLN_CODE = "772" And Se2Source.TXN_STATUS = "U" And Se2Source.TXN_TYPE = "6" Then
                retval = (Se2Source.TXN_AMT * -1).ToString
            ElseIf Se2Source.PLN_CODE = "772" And Se2Source.TXN_STATUS = "U" And Se2Source.TXN_TYPE = "7" Then
                retval = (Se2Source.TXN_AMT * -1).ToString
            ElseIf Se2Source.PLN_CODE = "887" And Se2Source.TXN_STATUS <> "U" And Se2Source.TXN_TYPE = "1" Then
                retval = (Se2Source.TXN_AMT).ToString
            ElseIf Se2Source.PLN_CODE = "887" And Se2Source.TXN_STATUS <> "U" And Se2Source.TXN_TYPE = "11" Then
                retval = (Se2Source.TXN_TOTAL).ToString
            ElseIf Se2Source.PLN_CODE = "887" And Se2Source.TXN_STATUS <> "U" And Se2Source.TXN_TYPE = "18" Then
                retval = (Se2Source.TXN_TOTAL).ToString
            ElseIf Se2Source.PLN_CODE = "887" And Se2Source.TXN_STATUS <> "U" And Se2Source.TXN_TYPE = "21" Then
                retval = (Se2Source.TXN_TOTAL).ToString
            ElseIf Se2Source.TXN_STATUS = "U" Then
                retval = (Se2Source.TXN_TOTAL * -1).ToString
            ElseIf Se2Source.TXN_STATUS <> "U" Then
                retval = (Se2Source.TXN_TOTAL).ToString
            End If

            Return retval

        End Function

        Public Function FEDERAL_TAX_WTHD(ByVal value As Se2Args) As Object
            Dim retval As String

            retval = (Se2Source.FEDERAL_WTHLD * -1).ToString

            Return retval

        End Function

        Public Function STATE_TAX_WTHD(ByVal value As Se2Args) As Object
            Dim retval As String

            retval = (Se2Source.STATE_WTHLD * -1).ToString

            Return retval

        End Function
#End Region


    End Class

#End Region


#Region " Transaction Details "
    Public Class TransactionDetails
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.TransactionDetails

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.TransactionDetails
            Se2Source = New SourceLayouts.TransactionDetails
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region
#Region " Transaction Detail "

    Public Class TransactionDetail
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.TransactionDetail

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.TransactionDetail
            Se2Source = New SourceLayouts.TransactionDetail
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "
        Public Function FUND_ACCDIV(ByVal value As Se2Args) As String
            Dim retval As String = ""

            'lgp-10006 - commenting out div_code
            retval = Se2Source.ACC_CODE
            '& "+" & Se2Source.DIV_CODE

            Return retval

        End Function
        Public Function TXN_TYPE_DESC(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            If Se2Source.TXN_TYPE = "11" Then
                retval = "Systematic Withdrawal"
            ElseIf Se2Source.TXN_TYPE = "44" Then
                retval = "Minimum Required Distribution"
            ElseIf Se2Source.TXN_TYPE = "36" Then
                retval = "Rebalance Transfer"
            ElseIf Se2Source.TXN_TYPE = "213" Then
                retval = "Advisory Fee Withdrawal"
            Else retval = Se2Source.TXN_TYPE_DESC
            End If

            Return retval

        End Function
#End Region
        Public Function FUND_TXN_AMT(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            If Se2Source.TXN_TYPE = "20" And Se2Source.TXN_STATUS <> "U" Then
                retval = (Se2Source.FUND_TXN_AMT * -1).ToString
            ElseIf Se2Source.TXN_TYPE = "20" And Se2Source.TXN_STATUS = "U" Then
                retval = (Se2Source.FUND_TXN_AMT).ToString
            ElseIf Se2Source.TXN_STATUS = "U" Then
                retval = (Se2Source.FUND_TXN_AMT * -1).ToString
            ElseIf Se2Source.TXN_STATUS <> "U" Then
                retval = (Se2Source.FUND_TXN_AMT).ToString


                End If

            Return retval

        End Function

    End Class

#End Region

#Region " Transaction Total "
    Public Class TransactionTotals
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.TransactionTotals

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.TransactionTotals
            Se2Source = New SourceLayouts.TransactionTotals
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region
#Region " TransactionTotal "

    Public Class TransactionTotal
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.TransactionTotal

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.TransactionTotal
            Se2Source = New SourceLayouts.TransactionTotal
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "
        Public Function TOTAL_TXN_AMT(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            If Se2Source.TXN_STATUS = "U" Then
                retval = (Se2Source.TXN_TOTAL * -1).ToString
            ElseIf Se2Source.TXN_STATUS <> "U" Then
                retval = (Se2Source.TXN_TOTAL).ToString

            End If

            Return retval

        End Function
#End Region


    End Class

#End Region

#Region " Fee Details "
    Public Class FeeDetails
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.FeeDetails

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.FeeDetails
            Se2Source = New SourceLayouts.FeeDetails
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region
#Region " FeeDetail "

    Public Class FeeDetail
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.FeeDetail

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.FeeDetail
            Se2Source = New SourceLayouts.FeeDetail
            MyBase.Se2Source = Me.Se2Source
        End Sub

#Region " POPULATION FUNCTIONS "
        Public Function FEE_VALUE(ByVal value As Se2Args) As Object
            Dim retval As String = ""

            retval = (Se2Source.FEE_AMT * -1).ToString

            Return retval

        End Function

#End Region

    End Class

#End Region

#Region " Account Details "
    Public Class AccountDetails
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.AccountDetails

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.AccountDetails
            Se2Source = New SourceLayouts.AccountDetails
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region
#Region " Account Detail "

    Public Class AccountDetail
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.AccountDetail

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.AccountDetail
            Se2Source = New SourceLayouts.AccountDetail
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "
        Public Function FUND_ACCDIV(ByVal value As Se2Args) As String
            Dim retval As String = ""

            retval = Se2Source.ACC_CODE
            '& "+" & Se2Source.DIV_CODE

            Return retval

        End Function
#End Region


    End Class

#End Region

#Region " Account Totals "
    Public Class AccountTotals
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.AccountTotals

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.AccountTotals
            Se2Source = New SourceLayouts.AccountTotals
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region
#Region " Account Totals "

    Public Class AccountTotal
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.AccountTotal

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.AccountTotal
            Se2Source = New SourceLayouts.AccountTotal
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "
        'Public Function TOTAL_VALUE(ByVal value As Se2Args) As Object
        '    Dim retval As String = ""
        '    retval = Math.Round(Se2Source.VALUE, 2).ToString

        '    'retval += "00"

        '    Return retval
        'End Function
#End Region


    End Class

#End Region

End Namespace
