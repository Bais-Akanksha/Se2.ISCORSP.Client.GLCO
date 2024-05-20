Imports Se2.ISI.Base
Imports Se2.ISI.Base.Utility
Imports Se2.ISI.Base.Presentation
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.DS.ReferenceData.ReferenceData
Imports System.Configuration

Namespace Se2.ISCORSP.Client.GLCO.AnnualRMDAgentLetter.CLM



#Region " InvestAdvisors "
    Public Class InvestAdvisors
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.InvestAdvisors


        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.InvestAdvisors
            Se2Source = New SourceLayouts.InvestAdvisors
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region
#Region " InvestAdvisor "
    Public Class InvestAdvisor
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.InvestAdvisor

        Public ReferenceData As New DSReference
        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.InvestAdvisor
            Se2Source = New SourceLayouts.InvestAdvisor
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "

        Public Function IVA_FULL_NAME(ByVal value As Se2Args) As String
            Dim retval As String

            If Se2Source.MID_NAME = "" Then
                retval = Trim(Se2Source.FST_NAME & " " & Se2Source.LST_NAME & " " & Se2Source.SUFFIX)
            Else
                retval = Trim(Se2Source.FST_NAME & " " & Se2Source.MID_NAME & " " & Se2Source.LST_NAME & " " & Se2Source.SUFFIX)
            End If

            Return retval

        End Function
        Public Function MASTER_NUM(ByVal value As Se2Args) As String
            Dim retval As String = ""

            If Se2Source.MASTER_NUM.StartsWith("M") Then
                retval = "Y"
            Else
                retval = "N"
            End If

            Return retval

        End Function
        Public Function FULL_ZIP_CODE(ByVal value As Se2Args) As String

            Dim retval As String

            retval = Se2Source.ZIP & Se2Source.ZIP_SUFFIX

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

        Public Function Get_CurrYear(ByVal value As Se2Args) As String
            Dim regDate As Date = Convert.ToDateTime(Se2Source.CYCLEDATE)
            'Dim FinalDate As Date = (DateAdd(DateInterval.Year, -1, regDate))
            regDate = DateSerial(regDate.Year, regDate.Month, regDate.Day)
            Return CType(regDate.ToString("yyyy"), String)
        End Function

        Public Function Get_PrevYear(ByVal value As Se2Args) As String
            Dim regDate As Date = Convert.ToDateTime(Se2Source.CYCLEDATE)
            Dim FinalDate As Date = (DateAdd(DateInterval.Year, -1, regDate))
            FinalDate = DateSerial(FinalDate.Year, FinalDate.Month, FinalDate.Day)
            Return CType(FinalDate.ToString("yyyy"), String)
        End Function

        Public Function Get_NextYear(ByVal value As Se2Args) As String
            Dim regDate As Date = Convert.ToDateTime(Se2Source.CYCLEDATE)
            Dim FinalDate As Date = (DateAdd(DateInterval.Year, +1, regDate))
            FinalDate = DateSerial(FinalDate.Year, FinalDate.Month, FinalDate.Day)
            Return CType(FinalDate.ToString("yyyy"), String)
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


        Public Function CARRIER_FAX_NUM(ByVal value As Se2Args) As String
            Dim retval As String

            retval = Se2Source.FAX_AREA_CODE & Se2Source.FAX_NUM

            Return retval

        End Function

#End Region


    End Class

#End Region

#Region " Clients "
    Public Class Clients
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.Clients

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Clients
            Se2Source = New SourceLayouts.Clients
            MyBase.Se2Source = Me.Se2Source
        End Sub
    End Class
#End Region
#Region " Client "

    Public Class Client
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.Client

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.Client
            Se2Source = New SourceLayouts.Client
            MyBase.Se2Source = Me.Se2Source
        End Sub


#Region " POPULATION FUNCTIONS "


        Public Function CLIENT_FULL_NAME(ByVal value As Se2Args) As String
            Dim retval As String

            If Se2Source.MID_NAME = "" Then
                retval = Trim(Se2Source.FST_NAME & " " & Se2Source.LST_NAME & " " & Se2Source.SUFFIX)
            Else
                retval = Trim(Se2Source.FST_NAME & " " & Se2Source.MID_NAME & " " & Se2Source.LST_NAME & " " & Se2Source.SUFFIX)
            End If

            Return retval

        End Function
        Public Function SSW_IND(ByVal value As Se2Args) As String
            Dim retval As String

            If CInt(Se2Source.SP_TYPE) >= 1 Then
                retval = "Y"
            Else
                retval = "N"
            End If

            Return retval
        End Function
#End Region


    End Class

#End Region
End Namespace
