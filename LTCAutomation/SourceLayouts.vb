Imports Se2.ISI.Base.Presentation

Namespace Se2.ISCORSP.Client.GLCO.LTCAutomation.SourceLayouts


#Region " LTCAutomation "

    Public Class LTCAutomation
        Inherits SourceDef

#Region " Field Array Enum "
        Public Shadows Enum FieldList
            REC_TYPE
            CONT
            ERRORDESCRIPTION

        End Enum
#End Region

#Region " Public Properties "
        Public ReadOnly Property REC_TYPE As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property CONT As String
            Get
                Return Values(FieldList.CONT)
            End Get
        End Property
        Public ReadOnly Property ERRORDESCRIPTION As String
            Get
                Return Values(FieldList.ERRORDESCRIPTION)
            End Get
        End Property

#End Region

#Region " Constructors "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region


    End Class
#End Region


End Namespace
