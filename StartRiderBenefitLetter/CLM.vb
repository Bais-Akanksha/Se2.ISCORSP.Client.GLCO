Imports Se2.ISI.Base
Imports Se2.ISI.Base.Utility
Imports Se2.ISI.Base.Presentation
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.DS.ReferenceData.ReferenceData
Imports System.Configuration

Namespace Se2.ISCORSP.Client.GLCO.StartRiderBenefitLetter.CLM

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

        Public Function QUAL_DESC(ByVal value As Se2Args) As String
            Dim retval As String

            retval = ReferenceData.QualType.LC5xToDataServices_Description(Se2Source.QUAL_CODE)

            Return retval
        End Function

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
        Public Function LIFETIME_PMNT_AMT(ByVal value As Se2Args) As Object
            Dim retval As String = ""
            retval = Math.Round(Se2Source.TX_GWB_ANNUAL_LIMIT, 2).ToString

            Dim tmpStr() As String

            tmpStr = retval.Split("."c)

            retval = tmpStr(0) & "." & tmpStr(1).PadRight(2, "0"c)

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
                StoreEmail.addParms("@DocumentType", "RDRSTART")
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
            MyBase.New()
            ClientRecord = New Records.Features
            Se2Source = New SourceLayouts.Features
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region
#Region " Feature "

    Public Class Feature
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Feature

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Feature
            Se2Source = New SourceLayouts.Feature
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "



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


        Public Function ANNUAL_LIMIT_PYMT(ByVal value As Se2Args) As String
            Dim retval As String = ""

            If Se2Source.SP_MODE_CODE = "M" Then
                retval = Math.Round((Se2Source.TX_GWB_ANNUAL_LIMIT / 12), 2).ToString
            ElseIf Se2Source.SP_MODE_CODE = "S" Then
                retval = Math.Round((Se2Source.TX_GWB_ANNUAL_LIMIT / 2), 2).ToString
            ElseIf Se2Source.SP_MODE_CODE = "Q" Then
                retval = Math.Round((Se2Source.TX_GWB_ANNUAL_LIMIT / 4), 2).ToString
            ElseIf Se2Source.SP_MODE_CODE = "A" Then
                retval = Math.Round((Se2Source.TX_GWB_ANNUAL_LIMIT / 1), 2).ToString
            ElseIf Se2Source.SP_MODE_CODE = "B" Then
                retval = Math.Round((Se2Source.TX_GWB_ANNUAL_LIMIT / 6), 2).ToString
            Else retval = ""
            End If

            Return retval

        End Function

        Public Function SWP_FREQ(ByVal value As Se2Args) As String
            Dim retval As String = ""

            If Se2Source.SP_MODE_CODE = "M" Then
                retval = "monthly"
            ElseIf Se2Source.SP_MODE_CODE = "S" Then
                retval = "semi-annually"
            ElseIf Se2Source.SP_MODE_CODE = "Q" Then
                retval = "quarterly"
            ElseIf Se2Source.SP_MODE_CODE = "A" Then
                retval = "annually"
            ElseIf Se2Source.SP_MODE_CODE = "B" Then
                retval = "bi-monthly"
            Else retval = ""
            End If

            Return retval
        End Function
        Public Function GMWB_AMT_TYPE(ByVal value As Se2Args) As String
            Dim retval As String = ""

            If Se2Source.TX_AMT_TYPE = "31" Then
                retval = "Single Life"
            ElseIf Se2Source.TX_AMT_TYPE = "32" Then
                retval = "Joint Life"
            Else retval = ""
            End If

            Return retval
        End Function
#End Region



    End Class

#End Region

End Namespace
