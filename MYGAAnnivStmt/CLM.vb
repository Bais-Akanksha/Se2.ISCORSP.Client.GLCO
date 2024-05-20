Imports Se2.ISI.Base
Imports Se2.ISI.Base.Utility
Imports Se2.ISI.Base.Presentation
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.DS.ReferenceData.ReferenceData
Imports System.Configuration

Namespace Se2.ISCORSP.Client.GLCO.MYGAAnnivStmt.CLM

#Region " HDR "
    Public Class HDR
        Inherits BaseLogic

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.HDR
        End Sub
    End Class
#End Region

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

        'Public Function MKT_PRDCT_NAME(ByVal value As Se2Args) As String
        '    Dim retval As String

        '    retval = Se2Source.MKT_PRDCT_NAME & " " & Se2Source.SUPERSCRIPT

        '    Return retval

        'End Function

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
        Public Function CORRO_PRDCT_NAME(ByVal value As Se2Args) As String
            Dim retval As String
            If Se2Source.PLN_CODE = "732" Then
                retval = Se2Source.CORRO_PRDCT_NAME
            Else
                retval = Se2Source.PRIM_RT_CLASS
            End If
            ' retval = Se2Source.CORRO_PRDCT_NAME + Se2Source.GUAR_PERIOD


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
                retval = Trim(Se2Source.FST & " " & Se2Source.LST)
            Else
                retval = Trim(Se2Source.FST & " " & Se2Source.LST & " " & Se2Source.SUFFIX)
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

            retVal = (Se2Source.CURR_ACCT_VAL - Se2Source.PRIOR_ACCT_VAL - Se2Source.PYTD_PREM + ((Se2Source.PYTD_WITHD + Se2Source.PYTD_ADV_WITHD) * -1)).ToString

            Return retVal
        End Function

        Public Function CASH_SURR_VALUE(ByVal value As Se2Args) As String
            Dim retVal As String = ""

            retVal = (Se2Source.CURR_ACCT_VAL - Se2Source.SURR_CHRG).ToString

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
        Public Function END_PERIOD_IND(ByVal value As Se2Args) As String
            Dim retVal As String = ""

            If Se2Source.RATE_END_DATE = Se2Source.CURR_ANNIV_DATE Then 'And Se2Source.CURR_FUND_BAL > 0 
                retVal = "Y"
            Else retVal = "N"
            End If

            Return retVal
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
                retval = "Interest Earned"
            ElseIf Se2Source.TXN_TYPE = "36" Then
                retval = "Transfer"
            ElseIf Se2Source.TXN_TYPE = "213" Then
                retval = "Advisory Fee Withdrawal"
            Else retval = Se2Source.TXN_TYPE_DESC
            End If

            Return retval

        End Function

        'Public Function TOTAL_TXN_AMT(ByVal value As Se2Args) As Decimal
        '    Dim retval As Decimal

        '    If Se2Source.TXN_TYPE = "60" Then
        '        retval = Se2Source.INDEX_INTEREST_CREDIT * -1
        '    Else retval = Se2Source.TOTAL_FUND_TXN_AMT
        '    End If

        '    Return retval


        'End Function
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
        'Public Function FUND_TXN_AMT(ByVal value As Se2Args) As Decimal
        '    Dim retval As Decimal

        '    If Se2Source.TXN_TYPE = "60" Then
        '        retval = (Se2Source.FUND_TXN_AMT * -1)
        '    Else retval = Se2Source.FUND_TXN_AMT
        '    End If

        '    Return retval


        'End Function

#End Region


    End Class

#End Region

#Region " RenewalRates "
    Public Class RenewalRates
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.RenewalRates

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.RenewalRates
            Se2Source = New SourceLayouts.RenewalRates
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region
#Region " RenewRates "

    Public Class RenewRates
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.RenewRates

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.RenewRates
            Se2Source = New SourceLayouts.RenewRates
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "
        'Guaranty Rate Lock CORRO_FUND_NAME
        Public Function CORRO_FUND_NAME(ByVal value As Se2Args) As String
            Dim retVal As String = ""

            retVal = "Guaranty Rate Lock " + Se2Source.GUAR_PERIOD


            Return retVal
        End Function

#End Region


    End Class

#End Region


End Namespace
