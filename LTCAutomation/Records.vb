Imports Se2.ISI.Base.Presentation

Namespace Se2.ISCORSP.Client.GLCO.LTCAutomation.Records

#Region " LTCAutomation "

#Region " DETL "


    Public Class DTL
        Inherits RecordDef

        Protected Const DateFmt As String = "yyyy-MM-dd"

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New(PresentationFormat.Fixed)
            Length = -999
            Terminator = vbCrLf
        End Sub


#End Region

#Region " PROPERTIES "


#End Region

#Region " METHODS "


#End Region

    End Class

#End Region

#Region " LTCAutomation "

    <Serializable()>
    Public Class LTCAutomation
        Inherits DTL

#Region " Constructors "

        Public Sub New()
            MyBase.New()
            Initialize()
            'Me.NodeName = "LTCAutomation"
            'Me.NodeParent = "DataServicesLetter"
        End Sub

        Private Shadows Enum FieldList
            Output
        End Enum

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("CONTRACT_NUMBER", "F:BODY"))
            End With
        End Sub
#End Region

#Region " Properties "


#End Region

#Region " Methods "

#End Region

    End Class
#End Region

#End Region

End Namespace
