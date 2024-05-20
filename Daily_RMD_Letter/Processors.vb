Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.DailyRMDLetter.Processors

#Region " DailyRMDLetter "

		Public Class DailyRMDLetter
				Inherits BaseProcessor

				Private ErrorCount As Integer = 0

				Public Sub New()
						MyBase.New()
						MyBase.InterfaceKey = "ISCORSP.GLCO.DailyRMDLetter"
						MyBase.Name = "DailyRMDLetter"
						isXMLFile = True
						MyBase.RootNode = "DailyRMDLetter"
						Me.[CLM].Add("Policies", New GLCO.DailyRMDLetter.CLM.Policies)
						Me.[CLM].Add("Policy", New GLCO.DailyRMDLetter.CLM.Policy)
						Me.[CLM].Add("Roles", New GLCO.DailyRMDLetter.CLM.Roles)
						Me.[CLM].Add("Role", New GLCO.DailyRMDLetter.CLM.Role)
						Me.[CLM].Add("CarrierInformation", New GLCO.DailyRMDLetter.CLM.CarrierInformation)
						Me.[CLM].Add("Carrier", New GLCO.DailyRMDLetter.CLM.Carrier)
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

#Region " Daily RMD Letter Redirect"

	Public Class DailyRMDLetterRedirect
		Inherits BaseProcessor

		Private ErrorCount As Integer = 0

		Public Sub New()
			MyBase.New()
			MyBase.InterfaceKey = "ISCORSP.GLCO.DailyRMDLetterRedirect"
			MyBase.Name = "DailyRMDLetterRedirect"
			isXMLFile = True
			MyBase.RootNode = "DailyRMDLetter"
			Me.[CLM].Add("Policies", New GLCO.DailyRMDLetter.CLM.Policies)
			Me.[CLM].Add("Policy", New GLCO.DailyRMDLetter.CLM.Policy)
			Me.[CLM].Add("Roles", New GLCO.DailyRMDLetter.CLM.Roles)
			Me.[CLM].Add("Role", New GLCO.DailyRMDLetter.CLM.Role)
			Me.[CLM].Add("CarrierInformation", New GLCO.DailyRMDLetter.CLM.CarrierInformation)
			Me.[CLM].Add("Carrier", New GLCO.DailyRMDLetter.CLM.Carrier)

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

End Namespace
