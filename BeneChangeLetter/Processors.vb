Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.BeneChangeLetter.Processors

#Region " BeneChangeLetter "

	Public Class BeneChangeLetter
		Inherits BaseProcessor

		Private ErrorCount As Integer = 0

		Public Sub New()
			MyBase.New()
			MyBase.InterfaceKey = "ISCORSP.GLCO.BeneChangeLetter"
			MyBase.Name = "BeneChangeLetter"
			isXMLFile = True
			MyBase.RootNode = "BeneChangeLetter"
			Me.[CLM].Add("Policies", New GLCO.BeneChangeLetter.CLM.Policies)
			Me.[CLM].Add("Policy", New GLCO.BeneChangeLetter.CLM.Policy)
			Me.[CLM].Add("Roles", New GLCO.BeneChangeLetter.CLM.Roles)
			Me.[CLM].Add("Role", New GLCO.BeneChangeLetter.CLM.Role)
			Me.[CLM].Add("CarrierInformation", New GLCO.BeneChangeLetter.CLM.CarrierInformation)
			Me.[CLM].Add("Carrier", New GLCO.BeneChangeLetter.CLM.Carrier)
			NotificationSeconds = 1
		End Sub

		Public Overrides Function InitDataSource() As Boolean
			Try
				Me.DataSource = New DataSource.BASE_DATA(Args.cmdLnArgs)
				Return True
			Catch
				Return False
			End Try
		End Function

	End Class

#Region " Bene Change Letter Redirect"

	Public Class BeneChangeLetterRedirect
		Inherits BaseProcessor

		Private ErrorCount As Integer = 0

		Public Sub New()
			MyBase.New()
			MyBase.InterfaceKey = "ISCORSP.GLCO.BeneChangeLetterRedirect"
			MyBase.Name = "BeneChangeLetterRedirect"
			isXMLFile = True
			MyBase.RootNode = "BeneChangeLetter"
			Me.[CLM].Add("Policies", New GLCO.BeneChangeLetter.CLM.Policies)
			Me.[CLM].Add("Policy", New GLCO.BeneChangeLetter.CLM.Policy)
			Me.[CLM].Add("Roles", New GLCO.BeneChangeLetter.CLM.Roles)
			Me.[CLM].Add("Role", New GLCO.BeneChangeLetter.CLM.Role)
			Me.[CLM].Add("CarrierInformation", New GLCO.BeneChangeLetter.CLM.CarrierInformation)
			Me.[CLM].Add("Carrier", New GLCO.BeneChangeLetter.CLM.Carrier)

			NotificationSeconds = 1
		End Sub

		Public Overrides Function InitDataSource() As Boolean
			Try
				Me.DataSource = New DataSource.BASE_DATA(Args.cmdLnArgs)
				Return True
			Catch
				Return False
			End Try
		End Function

	End Class

#End Region

#End Region

End Namespace
