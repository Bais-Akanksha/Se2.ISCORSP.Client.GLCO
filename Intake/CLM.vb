Imports Se2.ISI.Base
Imports Se2.ISI.Base.Utility
Imports Se2.ISI.Base.Presentation
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.Exception
Imports Se2.ISI.Base.Xlat
Imports Se2.ISI.Base.Messaging
Imports System
Imports System.Text.RegularExpressions

Namespace Se2.ISCORSP.Client.GLCO.Intake.CLM


#Region " PSHEADER "

    Public Class PSHEADER
        Inherits BaseLogic
        Public Shadows Property Se2Source As SourceLayouts.POST_HEADER
        Public Sub New()

            MyBase.New()
            ClientRecord = New Records.PSHEADER
            Se2Source = New SourceLayouts.POST_HEADER
            MyBase.Se2Source = Me.Se2Source

        End Sub

#Region " POPULATION FUNCTIONS "

        Public Function Get_RunDate(ByVal value As Se2Args) As Object
            Return Date.Today.ToString("MM/dd/yyy")
        End Function
        Public Function Get_CycleDate(ByVal value As Se2Args) As Object
            Return value.cmdLnArgs.CYCLEDATE.ToString("MM/dd/yyy")
        End Function
        Public Function Get_StartDate(ByVal value As Se2Args) As Object
            Return value.cmdLnArgs.CYCLEDATE.ToString("MM/dd/yyy")
        End Function
        Public Function Get_EndDate(ByVal value As Se2Args) As Object
            Return value.cmdLnArgs.CYCLEDATE.ToString("MM/dd/yyy")
        End Function
        Public Function Get_Groupid(ByVal value As Se2Args) As Object
            If Not IsNothing(value.cmdLnArgs.GROUPID) Then
                Return value.cmdLnArgs.GROUPID
            Else
                Return ""
            End If
        End Function
        Public Function Get_Contents(ByVal value As Se2Args) As Object
            Return value.cmdLnArgs.CUSTOM("CONTENTS")
        End Function
        Public Function Get_Count(ByVal value As Se2Args) As Object
            If value.cmdLnArgs.PROCESSOR <> "MCSCS" Then
                Return value.ProcessedRecords
            End If

            Return CInt(CType(Me.CLMMessages.Item("ParentRecordList")(0).Value, ICustomLogic).Messages("COUNT")(0).Value)


        End Function
        Public Function Get_Table(ByVal value As Se2Args) As Object

            Select Case value.cmdLnArgs.PROCESSOR
                Case "MCSCS"
                    Select Case Me.CLMMessages.Item("ParentRecordList")(0).Value.ToString.Substring(Me.CLMMessages.Item("ParentRecordList")(0).Value.ToString.LastIndexOf(".") + 1)
                        Case "COMM700"
                            Return "GLCO_COMMSTMT_RT700"
                        Case "COMM701"
                            Return "GLCO_COMMSTMT_RT701"
                        Case "COMM702"
                            Return "GLCO_COMMSTMT_RT702"
                        Case "COMM703"
                            Return "GLCO_COMMSTMT_RT703"
                        Case "COMM704"
                            Return "GLCO_COMMSTMT_RT704"
                        Case "COMM706"
                            Return "GLCO_COMMSTMT_RT706"
                        Case "COMM719"
                            Return "GLCO_COMMSTMT_RT719"
                        Case Else
                            Return "NONONO"
                    End Select
            End Select
            Return ""

        End Function
        Public Function Get_Source(ByVal value As Se2Args) As Object

            Return value.cmdLnArgs.CUSTOM("SOURCE")

        End Function

#End Region

    End Class

#End Region


#Region " MCSCS "

#Region " COMM700 "
    Public Class COMM700
        Inherits BaseLogic
        Public SourceSystem As String = ""

        Public Shadows Property Se2Source As SourceLayouts.COMM700
        Public Sub New()

            MyBase.New()
            ClientRecord = New Records.COMM700
            Se2Source = New SourceLayouts.COMM700
            MyBase.Se2Source = Me.Se2Source
            ParseMapItems = New List(Of ParseMapItem)
            ParseMapItems.Add(New ParseMapItem(ControlChars.Quote + "700", 0, 5))

        End Sub

#Region " POPULATION FUNCTIONS "

        Public Function REC_TYPE(ByVal value As Se2Args) As String
            'ClientRecord.Delimiter = "~"


            'Se2Source.Record = Se2Source.Record.Replace("""", "").Trim()
            'Dim regex As Regex = New Regex("(.+?)")
            'Dim match As Match = regex.Match(Se2Source.REC_TYPE)
            'Dim str As String
            'If Not String.IsNullOrEmpty(Se2Source.REC_TYPE) Then
            '    str = Se2Source.REC_TYPE + ControlChars.Quote.ToString()
            '    Return str.Replace("""", "").Trim()

            'End If


            If Not Me.CLMMessages.ContainsKey("COUNT") Then
                Dim _List As New List(Of MessageItem)
                Dim _count As New MessageItem
                _count.Value = CInt(0)
                _List.Add(_count)
                Me.CLMMessages.Add("COUNT", _List)
            End If

            Me.CLMMessages("COUNT").Item(0).Value = CInt(Me.CLMMessages("COUNT").Item(0).Value) + 1

            Return Se2Source.REC_TYPE
        End Function
#End Region
    End Class


#End Region

#Region " COMM701 "
    Public Class COMM701
        Inherits BaseLogic
        Public SourceSystem As String = ""
        Public Shadows Property Se2Source As SourceLayouts.COMM701
        Public Sub New()

            MyBase.New()
            ClientRecord = New Records.COMM701
            Se2Source = New SourceLayouts.COMM701
            MyBase.Se2Source = Me.Se2Source
            ParseMapItems = New List(Of ParseMapItem)
            ParseMapItems.Add(New ParseMapItem(ControlChars.Quote + "701", 0, 5))

        End Sub

#Region " POPULATION FUNCTIONS "
        Public Function REC_TYPE(ByVal value As Se2Args) As String
            If Not Me.CLMMessages.ContainsKey("COUNT") Then
                Dim _List As New List(Of MessageItem)
                Dim _count As New MessageItem
                _count.Value = CInt(0)
                _List.Add(_count)
                Me.CLMMessages.Add("COUNT", _List)
            End If

            Me.CLMMessages("COUNT").Item(0).Value = CInt(Me.CLMMessages("COUNT").Item(0).Value) + 1
            Return Se2Source.REC_TYPE
        End Function
#End Region

    End Class
#End Region

#Region " COMM702 "
    Public Class COMM702
        Inherits BaseLogic
        Public SourceSystem As String = ""
        Public Shadows Property Se2Source As SourceLayouts.COMM702
        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.COMM702
            Se2Source = New SourceLayouts.COMM702
            MyBase.Se2Source = Me.Se2Source
            ParseMapItems = New List(Of ParseMapItem)
            ParseMapItems.Add(New ParseMapItem(ControlChars.Quote + "702", 0, 5))
        End Sub
#Region " POPULATION FUNCTIONS "
        Public Function REC_TYPE(ByVal value As Se2Args) As String
            If Not Me.CLMMessages.ContainsKey("COUNT") Then
                Dim _List As New List(Of MessageItem)
                Dim _count As New MessageItem
                _count.Value = CInt(0)
                _List.Add(_count)
                Me.CLMMessages.Add("COUNT", _List)
            End If

            Me.CLMMessages("COUNT").Item(0).Value = CInt(Me.CLMMessages("COUNT").Item(0).Value) + 1
            Return Se2Source.REC_TYPE
        End Function
#End Region
    End Class
#End Region

#Region " COMM703 "
    Public Class COMM703
        Inherits BaseLogic
        Public SourceSystem As String = ""
        Public Shadows Property Se2Source As SourceLayouts.COMM703
        Public Sub New()

            MyBase.New()
            ClientRecord = New Records.COMM703
            Se2Source = New SourceLayouts.COMM703
            MyBase.Se2Source = Me.Se2Source
            ParseMapItems = New List(Of ParseMapItem)
            ParseMapItems.Add(New ParseMapItem(ControlChars.Quote + "703", 0, 5))

        End Sub

#Region " POPULATION FUNCTIONS "
        Public Function REC_TYPE(ByVal value As Se2Args) As String
            If Not Me.CLMMessages.ContainsKey("COUNT") Then
                Dim _List As New List(Of MessageItem)
                Dim _count As New MessageItem
                _count.Value = CInt(0)
                _List.Add(_count)
                Me.CLMMessages.Add("COUNT", _List)
            End If

            Me.CLMMessages("COUNT").Item(0).Value = CInt(Me.CLMMessages("COUNT").Item(0).Value) + 1
            Return Se2Source.REC_TYPE
        End Function
#End Region

    End Class
#End Region

#Region " COMM704 "
    Public Class COMM704
        Inherits BaseLogic
        Public SourceSystem As String = ""
        Public Shadows Property Se2Source As SourceLayouts.COMM704
        Public Sub New()

            MyBase.New()
            ClientRecord = New Records.COMM704
            Se2Source = New SourceLayouts.COMM704
            MyBase.Se2Source = Me.Se2Source
            ParseMapItems = New List(Of ParseMapItem)
            ParseMapItems.Add(New ParseMapItem(ControlChars.Quote + "704", 0, 5))

        End Sub

#Region " POPULATION FUNCTIONS "
        Public Function REC_TYPE(ByVal value As Se2Args) As String
            If Not Me.CLMMessages.ContainsKey("COUNT") Then
                Dim _List As New List(Of MessageItem)
                Dim _count As New MessageItem
                _count.Value = CInt(0)
                _List.Add(_count)
                Me.CLMMessages.Add("COUNT", _List)
            End If

            Me.CLMMessages("COUNT").Item(0).Value = CInt(Me.CLMMessages("COUNT").Item(0).Value) + 1
            Return Se2Source.REC_TYPE
        End Function
#End Region

    End Class
#End Region

#Region " COMM706 "
    Public Class COMM706
        Inherits BaseLogic
        Public SourceSystem As String = ""
        Public Shadows Property Se2Source As SourceLayouts.COMM706
        Public Sub New()

            MyBase.New()
            ClientRecord = New Records.COMM706
            Se2Source = New SourceLayouts.COMM706
            MyBase.Se2Source = Me.Se2Source
            ParseMapItems = New List(Of ParseMapItem)
            ParseMapItems.Add(New ParseMapItem(ControlChars.Quote + "706", 0, 5))

        End Sub

#Region " POPULATION FUNCTIONS "
        Public Function REC_TYPE(ByVal value As Se2Args) As String
            If Not Me.CLMMessages.ContainsKey("COUNT") Then
                Dim _List As New List(Of MessageItem)
                Dim _count As New MessageItem
                _count.Value = CInt(0)
                _List.Add(_count)
                Me.CLMMessages.Add("COUNT", _List)
            End If

            Me.CLMMessages("COUNT").Item(0).Value = CInt(Me.CLMMessages("COUNT").Item(0).Value) + 1
            Return Se2Source.REC_TYPE
        End Function
#End Region

    End Class
#End Region

#Region " COMM719 "
    Public Class COMM719
        Inherits BaseLogic
        Public SourceSystem As String = ""
        Public Shadows Property Se2Source As SourceLayouts.COMM719
        Public Sub New()

            MyBase.New()
            ClientRecord = New Records.COMM719
            Se2Source = New SourceLayouts.COMM719
            MyBase.Se2Source = Me.Se2Source
            ParseMapItems = New List(Of ParseMapItem)
            ParseMapItems.Add(New ParseMapItem(ControlChars.Quote + "719", 0, 5))

        End Sub

#Region " POPULATION FUNCTIONS "
        Public Function REC_TYPE(ByVal value As Se2Args) As String
            If Not Me.CLMMessages.ContainsKey("COUNT") Then
                Dim _List As New List(Of MessageItem)
                Dim _count As New MessageItem
                _count.Value = CInt(0)
                _List.Add(_count)
                Me.CLMMessages.Add("COUNT", _List)
            End If

            Me.CLMMessages("COUNT").Item(0).Value = CInt(Me.CLMMessages("COUNT").Item(0).Value) + 1
            Return Se2Source.REC_TYPE
        End Function
#End Region

    End Class
#End Region

#End Region
End Namespace


