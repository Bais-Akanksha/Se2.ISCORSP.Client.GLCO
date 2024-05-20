Imports Se2.ISI.Base.Presentation

Namespace Se2.ISCORSP.Client.GLCO.BeneChangeLetter.Records


#Region " BeneChangeLetter "

#Region " DETL "


		Public Class DTL
				Inherits RecordDef

				Protected Const DateFmt As String = "yyyy-MM-dd"

#Region " CONSTRUCTORS "

				Public Sub New()
						MyBase.New(PresentationFormat.XML)
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

#Region " Policies "

		<Serializable()>
		Public Class Policies
				Inherits DTL

#Region " Constructors "

				Public Sub New()
						MyBase.New()
						Initialize()
						Me.NodeName = "Policies"
						Me.NodeParent = "BeneChangeLetter"
				End Sub

				Private Shadows Enum FieldList
						REC_TYPE

				End Enum

				Private Sub Initialize()

				End Sub
#End Region

#Region " Properties "


#End Region

#Region " Methods "

#End Region

		End Class
#End Region
#Region " Policy "
		Public Class Policy
        Inherits DTL

        Private Shadows Enum FieldList
            Contract_Num
            Plan_Code
            Product_Name
            Qual_Type
            Company_Name
            Document_Date
            Service_Name
            Service_Desc
            Intermediary_Name
            eDelivery_Ind
            Contract_Status
            CSR_Name
            Pol_Num
            Product_Company
            Line_of_Business
            Processing_Company
            Pol_Tracking_ID

        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "Policy"
            Me.NodeParent = "Policies"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("Contract_Num", "CONT"))
                .Add(New FieldDef("Plan_Code", "PLN_CODE"))
                .Add(New FieldDef("Product_Name", "PRD_DESC"))
                .Add(New FieldDef("Qual_Type", "QUAL_DESC"))
                .Add(New FieldDef("Company_Name", "CO_NAME"))
                .Add(New FieldDef("Document_Date", "", FieldType.Date, "yyyy-MM-dd", "CYCLEDATE"))
				.Add(New FieldDef("Service_Name", "S:Letters"))
				.Add(New FieldDef("Service_Desc", "S:Beneficiary Change Letter"))
				.Add(New FieldDef("Intermediary_Name", "S:SE2"))
                .Add(New FieldDef("eDelivery_Ind", "S:"))   'currently static until edelivery is implemented for client.
                .Add(New FieldDef("Contract_Status", "STATUS"))
                .Add(New FieldDef("CSR_Name", "S:"))
                .Add(New FieldDef("Pol_Num", "POL_NUM"))
                .Add(New FieldDef("Product_Company", "PRODUCT_CO"))
                .Add(New FieldDef("Line_of_Business", "PLN_TYPE"))
                .Add(New FieldDef("Processing_Company", "PRCSSNG_CO"))
                .Add(New FieldDef("Pol_Tracking_ID", "F:TrackingID"))
            End With
				End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property Contract_Num As FieldDef
            Get
                Return Fields(FieldList.Contract_Num)
            End Get
        End Property
        Public ReadOnly Property Plan_Code As FieldDef
            Get
                Return Fields(FieldList.Plan_Code)
            End Get
        End Property
        Public ReadOnly Property Product_Name As FieldDef
            Get
                Return Fields(FieldList.Product_Name)
            End Get
        End Property
        Public ReadOnly Property Qual_Type As FieldDef
            Get
                Return Fields(FieldList.Qual_Type)
            End Get
        End Property
        Public ReadOnly Property Company_Name As FieldDef
            Get
                Return Fields(FieldList.Company_Name)
            End Get
        End Property
        Public ReadOnly Property Document_Date As FieldDef
            Get
                Return Fields(FieldList.Document_Date)
            End Get
        End Property
        Public ReadOnly Property Service_Name As FieldDef
            Get
                Return Fields(FieldList.Service_Name)
            End Get
        End Property
        Public ReadOnly Property Service_Desc As FieldDef
            Get
                Return Fields(FieldList.Service_Desc)
            End Get
        End Property
        Public ReadOnly Property Intermediary_Name As FieldDef
            Get
                Return Fields(FieldList.Intermediary_Name)
            End Get
        End Property
        Public ReadOnly Property eDelivery_Ind As FieldDef
            Get
                Return Fields(FieldList.eDelivery_Ind)
            End Get
        End Property
        Public ReadOnly Property Contract_Status As FieldDef
            Get
                Return Fields(FieldList.Contract_Status)
            End Get
        End Property
        Public ReadOnly Property CSR_Name As FieldDef
            Get
                Return Fields(FieldList.CSR_Name)
            End Get
        End Property
        Public ReadOnly Property Pol_Num As FieldDef
            Get
                Return Fields(FieldList.Pol_Num)
            End Get
        End Property
        Public ReadOnly Property Product_Company As FieldDef
            Get
                Return Fields(FieldList.Product_Company)
            End Get
        End Property
        Public ReadOnly Property Line_of_Business As FieldDef
            Get
                Return Fields(FieldList.Line_of_Business)
            End Get
        End Property
        Public ReadOnly Property Processing_Company As FieldDef
            Get
                Return Fields(FieldList.Processing_Company)
            End Get
        End Property
        Public ReadOnly Property Pol_Tracking_ID As FieldDef
            Get
                Return Fields(FieldList.Pol_Tracking_ID)
            End Get
        End Property
#End Region

#Region " METHODS "

#End Region
    End Class


#End Region

#Region " Roles "

		<Serializable()>
		Public Class Roles
				Inherits DTL

#Region " Constructors "

				Public Sub New()
						MyBase.New()
						Initialize()
						Me.NodeName = "Roles"
						Me.NodeParent = "Policy"
				End Sub

				Private Shadows Enum FieldList
						REC_TYPE
				End Enum

				Private Sub Initialize()

				End Sub
#End Region

#Region " Properties "

#End Region

#Region " Methods "

#End Region

		End Class
#End Region
#Region " Role "

    Public Class ROLE
        Inherits DTL

        Private Shadows Enum FieldList
            Contract_Num
            Role_ID
            Role_Option
            Role_Percent
            Full_Name
            Prefix
            First_Name
            MI
            Last_Name
            Suffix
            Name_Type
            Addr_Line_1
            Addr_Line_2
            Addr_Line_3
            City
            State
            Zip
            Address_Type
            Email
            Phone_Num
            Phone_Type
            Rep_ID
            Master_Number
            Tax_ID
            Delivery_Flag
            Delivery_Destination_Type

        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "Role"
            Me.NodeParent = "Roles"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("Contract_Num", "CONT"))
                .Add(New FieldDef("Role_ID", "ROLE_ID"))
                .Add(New FieldDef("Role_Option", "OPT_ID"))
                .Add(New FieldDef("Role_Percent", "F:ROLE_PERCENT_SPLIT"))
                .Add(New FieldDef("Full_Name", "F:CUST_FULL_NAME"))
                .Add(New FieldDef("Prefix", "SALUTE"))
                .Add(New FieldDef("First_Name", "FST"))
                .Add(New FieldDef("MI", "MID"))
                .Add(New FieldDef("Last_Name", "LST"))
                .Add(New FieldDef("Suffix", "SUFFIX"))
                .Add(New FieldDef("Name_Type", "NAME_TYPE"))
                .Add(New FieldDef("Addr_Line_1", "ADDRESS1"))
                .Add(New FieldDef("Addr_Line_2", "ADDRESS2"))
                .Add(New FieldDef("Addr_Line_3", "ADDRESS3"))
                .Add(New FieldDef("City", "CITY"))
                .Add(New FieldDef("State", "STATE_CODE"))
                .Add(New FieldDef("Zip", "F:FULL_ZIP_CODE"))
                .Add(New FieldDef("Address_Type", "ADDRESS_TYPE"))
                .Add(New FieldDef("Email", "F:GetEmailAddress"))
                .Add(New FieldDef("Phone_Num", "F:PHONE_NUMBER"))
                .Add(New FieldDef("Phone_Type", "PHONE_TYPE"))
                .Add(New FieldDef("Rep_ID", "EXT_ID"))
                .Add(New FieldDef("Master_Number", "MASTER_NUMBER"))
                .Add(New FieldDef("Tax_ID", "TAX_ID"))
                .Add(New FieldDef("Delivery_Flag", "F:MAIL_FLAG"))
                .Add(New FieldDef("Delivery_Destination_Type", "F:MAIL_TYPE_IND"))

            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property Contract_Num As FieldDef
            Get
                Return Fields(FieldList.Contract_Num)
            End Get
        End Property
        Public ReadOnly Property Role_ID As FieldDef
            Get
                Return Fields(FieldList.Role_ID)
            End Get
        End Property
        Public ReadOnly Property Role_Option As FieldDef
            Get
                Return Fields(FieldList.Role_Option)
            End Get
        End Property
        Public ReadOnly Property Role_Percent As FieldDef
            Get
                Return Fields(FieldList.Role_Percent)
            End Get
        End Property
        Public ReadOnly Property Full_Name As FieldDef
            Get
                Return Fields(FieldList.Full_Name)
            End Get
        End Property
        Public ReadOnly Property Prefix As FieldDef
            Get
                Return Fields(FieldList.Prefix)
            End Get
        End Property
        Public ReadOnly Property First_Name As FieldDef
            Get
                Return Fields(FieldList.First_Name)
            End Get
        End Property
        Public ReadOnly Property MI As FieldDef
            Get
                Return Fields(FieldList.MI)
            End Get
        End Property
        Public ReadOnly Property Last_Name As FieldDef
            Get
                Return Fields(FieldList.Last_Name)
            End Get
        End Property
        Public ReadOnly Property Suffix As FieldDef
            Get
                Return Fields(FieldList.Suffix)
            End Get
        End Property
        Public ReadOnly Property Name_Type As FieldDef
            Get
                Return Fields(FieldList.Name_Type)
            End Get
        End Property
        Public ReadOnly Property Addr_Line_1 As FieldDef
            Get
                Return Fields(FieldList.Addr_Line_1)
            End Get
        End Property
        Public ReadOnly Property Addr_Line_2 As FieldDef
            Get
                Return Fields(FieldList.Addr_Line_2)
            End Get
        End Property
        Public ReadOnly Property Addr_Line_3 As FieldDef
            Get
                Return Fields(FieldList.Addr_Line_3)
            End Get
        End Property
        Public ReadOnly Property City As FieldDef
            Get
                Return Fields(FieldList.City)
            End Get
        End Property
        Public ReadOnly Property State As FieldDef
            Get
                Return Fields(FieldList.State)
            End Get
        End Property
        Public ReadOnly Property Zip As FieldDef
            Get
                Return Fields(FieldList.Zip)
            End Get
        End Property
        Public ReadOnly Property Address_Type As FieldDef
            Get
                Return Fields(FieldList.Address_Type)
            End Get
        End Property
        Public ReadOnly Property Phone_Num As FieldDef
            Get
                Return Fields(FieldList.Phone_Num)
            End Get
        End Property
        Public ReadOnly Property Phone_Type As FieldDef
            Get
                Return Fields(FieldList.Phone_Type)
            End Get
        End Property
        Public ReadOnly Property Rep_ID As FieldDef
            Get
                Return Fields(FieldList.Rep_ID)
            End Get
        End Property
        Public ReadOnly Property Master_Number As FieldDef
            Get
                Return Fields(FieldList.Master_Number)
            End Get
        End Property
        Public ReadOnly Property Tax_ID As FieldDef
            Get
                Return Fields(FieldList.Tax_ID)
            End Get
        End Property
        Public ReadOnly Property Delivery_Flag As FieldDef
            Get
                Return Fields(FieldList.Delivery_Flag)
            End Get
        End Property
        Public ReadOnly Property Delivery_Destination_Type As FieldDef
            Get
                Return Fields(FieldList.Delivery_Destination_Type)
            End Get
        End Property
#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#Region " Carrier Information "
    <Serializable()>
		Public Class CarrierInformation
				Inherits DTL

#Region " Constructors "
				Public Sub New()
						MyBase.New()
						Initialize()
						Me.NodeName = "CarrierInformation"
						Me.NodeParent = "Policy"
				End Sub

				Private Shadows Enum FieldList
						REC_TYPE

				End Enum

				Private Sub Initialize()

				End Sub

#End Region

#Region " Properties "


#End Region

#Region "Methods"

#End Region

		End Class


#End Region
#Region " Carrier "

    Public Class Carrier
        Inherits DTL

        Private Shadows Enum FieldList
            Contract_Num
            Carrier_Name
            Carrier_Address1
            Carrier_Address2
            Carrier_Address3
            Carrier_City
            Carrier_State
            Carrier_Zip
            Carrier_Web_Address
            Carrier_Phone_Num
            Carrier_Fax_Num
            Carrier_Office_Hours
            Carrier_Office_Days
            Budget_Center
            Carrier_PO_Box_Address1
            Carrier_PO_Box_Address2
            Carrier_PO_Box_Address3
            Carrier_PO_Box_City
            Carrier_PO_Box_State
            Carrier_PO_Box_Zip
            Carrier_Mail_Address1
            Carrier_Mail_Address2
            Carrier_Mail_Address3
            Carrier_Mail_City
            Carrier_Mail_State
            Carrier_Mail_Zip
        End Enum

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New()
            Initialize()
            Me.NodeName = "Carrier"
            Me.NodeParent = "CarrierInformation"
        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            With Fields
                .Add(New FieldDef("Contract_Num", "CONT"))
                .Add(New FieldDef("Carrier_Name", "CO_NAME"))
                .Add(New FieldDef("Carrier_Address1", "ADDR_LINE_1"))
                .Add(New FieldDef("Carrier_Address2", "ADDR_LINE_2"))
                .Add(New FieldDef("Carrier_Address3", "ADDR_LINE_3"))
                .Add(New FieldDef("Carrier_City", "CITY"))
                .Add(New FieldDef("Carrier_State", "STATE"))
                .Add(New FieldDef("Carrier_Zip", "ZIP_CODE"))
                .Add(New FieldDef("Carrier_Web_Address", "WEB_ADDRESS"))
                .Add(New FieldDef("Carrier_Phone_Num", "F:CARRIER_PHONE_NUM"))
                .Add(New FieldDef("Carrier_Fax_Num", "F:CARRIER_FAX_NUM"))
                .Add(New FieldDef("Carrier_Office_Hours", "OFFICE_HOURS"))
                .Add(New FieldDef("Carrier_Office_Days", "OFFICE_DAYS"))
                .Add(New FieldDef("Budget_Center", "BUDGET_CENTER"))
                .Add(New FieldDef("Carrier_PO_Box_Address1", "POB_LINE_1"))
                .Add(New FieldDef("Carrier_PO_Box_Address2", "POB_LINE_2"))
                .Add(New FieldDef("Carrier_PO_Box_Address3", "POB_LINE_3"))
                .Add(New FieldDef("Carrier_PO_Box_City", "POB_CITY"))
                .Add(New FieldDef("Carrier_PO_Box_State", "POB_STATE"))
                .Add(New FieldDef("Carrier_PO_Box_Zip", "POB_ZIP_CODE"))
                .Add(New FieldDef("Carrier_Mail_Address1", "MAIL_LINE_1"))
                .Add(New FieldDef("Carrier_Mail_Address2", "MAIL_LINE_2"))
                .Add(New FieldDef("Carrier_Mail_Address3", "MAIL_LINE_3"))
                .Add(New FieldDef("Carrier_Mail_City", "MAIL_CITY"))
                .Add(New FieldDef("Carrier_Mail_State", "MAIL_STATE"))
                .Add(New FieldDef("Carrier_Mail_Zip", "MAIL_ZIP_CODE"))
            End With
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property Contract_Num As FieldDef
            Get
                Return Fields(FieldList.Contract_Num)
            End Get
        End Property
        Public ReadOnly Property Carrier_Name As FieldDef
            Get
                Return Fields(FieldList.Carrier_Name)
            End Get
        End Property
        Public ReadOnly Property Carrier_Address1 As FieldDef
            Get
                Return Fields(FieldList.Carrier_Address1)
            End Get
        End Property
        Public ReadOnly Property Carrier_Address2 As FieldDef
            Get
                Return Fields(FieldList.Carrier_Address2)
            End Get
        End Property
        Public ReadOnly Property Carrier_Address3 As FieldDef
            Get
                Return Fields(FieldList.Carrier_Address3)
            End Get
        End Property
        Public ReadOnly Property Carrier_City As FieldDef
            Get
                Return Fields(FieldList.Carrier_City)
            End Get
        End Property
        Public ReadOnly Property Carrier_State As FieldDef
            Get
                Return Fields(FieldList.Carrier_State)
            End Get
        End Property
        Public ReadOnly Property Carrier_Zip As FieldDef
            Get
                Return Fields(FieldList.Carrier_Zip)
            End Get
        End Property
        Public ReadOnly Property Carrier_Web_Address As FieldDef
            Get
                Return Fields(FieldList.Carrier_Web_Address)
            End Get
        End Property
        Public ReadOnly Property Carrier_Phone_Num As FieldDef
            Get
                Return Fields(FieldList.Carrier_Phone_Num)
            End Get
        End Property
        Public ReadOnly Property Carrier_Fax_Num As FieldDef
            Get
                Return Fields(FieldList.Carrier_Fax_Num)
            End Get
        End Property
        Public ReadOnly Property Carrier_Office_Hours As FieldDef
            Get
                Return Fields(FieldList.Carrier_Office_Hours)
            End Get
        End Property
        Public ReadOnly Property Carrier_Office_Days As FieldDef
            Get
                Return Fields(FieldList.Carrier_Office_Days)
            End Get
        End Property
        Public ReadOnly Property Budget_Center As FieldDef
            Get
                Return Fields(FieldList.Budget_Center)
            End Get
        End Property
        Public ReadOnly Property Carrier_PO_Box_Address1 As FieldDef
            Get
                Return Fields(FieldList.Carrier_PO_Box_Address1)
            End Get
        End Property
        Public ReadOnly Property Carrier_PO_Box_Address2 As FieldDef
            Get
                Return Fields(FieldList.Carrier_PO_Box_Address2)
            End Get
        End Property
        Public ReadOnly Property Carrier_PO_Box_Address3 As FieldDef
            Get
                Return Fields(FieldList.Carrier_PO_Box_Address3)
            End Get
        End Property
        Public ReadOnly Property Carrier_PO_Box_City As FieldDef
            Get
                Return Fields(FieldList.Carrier_PO_Box_City)
            End Get
        End Property
        Public ReadOnly Property Carrier_PO_Box_State As FieldDef
            Get
                Return Fields(FieldList.Carrier_PO_Box_State)
            End Get
        End Property
        Public ReadOnly Property Carrier_PO_Box_Zip As FieldDef
            Get
                Return Fields(FieldList.Carrier_PO_Box_Zip)
            End Get

        End Property
        Public ReadOnly Property Carrier_Mail_Address1 As FieldDef
            Get
                Return Fields(FieldList.Carrier_Mail_Address1)
            End Get
        End Property
        Public ReadOnly Property Carrier_Mail_Address2 As FieldDef
            Get
                Return Fields(FieldList.Carrier_Mail_Address2)
            End Get
        End Property
        Public ReadOnly Property Carrier_Mail_Address3 As FieldDef
            Get
                Return Fields(FieldList.Carrier_Mail_Address3)
            End Get
        End Property
        Public ReadOnly Property Carrier_Mail_City As FieldDef
            Get
                Return Fields(FieldList.Carrier_Mail_City)
            End Get
        End Property
        Public ReadOnly Property Carrier_Mail_State As FieldDef
            Get
                Return Fields(FieldList.Carrier_Mail_State)
            End Get
        End Property
        Public ReadOnly Property Carrier_Mail_Zip As FieldDef
            Get
                Return Fields(FieldList.Carrier_Mail_Zip)
            End Get
        End Property
#End Region

#Region " METHODS "

#End Region
    End Class

#End Region

#End Region

End Namespace
