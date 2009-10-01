'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.7.X CodeSmith Templates.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Order.vb.
'
'     Template: SwitchableObject.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Data
Imports Csla.Validation

<Serializable()> _
Public Partial Class Order 
    Inherits BusinessBase(Of Order)
    
    #Region "Contructor(s)"

	Private Sub New()
    	' require use of factory method 
End Sub
    
    Friend Sub New(Byval reader As SafeDataReader)
        Fetch(reader)
	End Sub
    
	#End Region
    
	#Region "Validation Rules"
	
	Protected Overrides Sub AddBusinessRules()
	
        If AddBusinessValidationRules() Then Exit Sub
       
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _userIdProperty)
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_userIdProperty, 20))
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _shipAddr1Property)
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_shipAddr1Property, 80))
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_shipAddr2Property, 80))
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _shipCityProperty)
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_shipCityProperty, 80))
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _shipStateProperty)
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_shipStateProperty, 80))
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _shipZipProperty)
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_shipZipProperty, 20))
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _shipCountryProperty)
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_shipCountryProperty, 20))
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _billAddr1Property)
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_billAddr1Property, 80))
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_billAddr2Property, 80))
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _billCityProperty)
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_billCityProperty, 80))
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _billStateProperty)
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_billStateProperty, 80))
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _billZipProperty)
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_billZipProperty, 20))
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _billCountryProperty)
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_billCountryProperty, 20))
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _courierProperty)
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_courierProperty, 80))
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _billToFirstNameProperty)
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_billToFirstNameProperty, 80))
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _billToLastNameProperty)
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_billToLastNameProperty, 80))
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _shipToFirstNameProperty)
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_shipToFirstNameProperty, 80))
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _shipToLastNameProperty)
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_shipToLastNameProperty, 80))
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _localeProperty)
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_localeProperty, 20))
	End Sub
	
	#End Region
	
	#Region "Business Methods"


	
	Private Shared ReadOnly _orderIdProperty As PropertyInfo(Of Integer) = RegisterProperty(Of Integer)(Function(p As Order) p.OrderId)
		<System.ComponentModel.DataObjectField(true, true)> _
	Public ReadOnly Property OrderId() As Integer
		Get 
			Return GetProperty(_orderIdProperty)
		End Get
	End Property
	
	
	Private Shared ReadOnly _userIdProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Order) p.UserId)
	Public Property UserId() As String
		Get 
			Return GetProperty(_userIdProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("UserId")
            SetProperty(_userIdProperty, value)
            OnPropertyChanged("UserId")
        End Set
	End Property
	
	
	Private Shared ReadOnly _orderDateProperty As PropertyInfo(Of SmartDate) = RegisterProperty(Of SmartDate)(Function(p As Order) p.OrderDate)
	Public Property OrderDate() As SmartDate
		Get 
			Return GetProperty(_orderDateProperty)
		End Get
        Set (ByVal value As SmartDate)
            OnPropertyChanging("OrderDate")
            SetProperty(_orderDateProperty, value)
            OnPropertyChanged("OrderDate")
        End Set
	End Property
	
	
	Private Shared ReadOnly _shipAddr1Property As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Order) p.ShipAddr1)
	Public Property ShipAddr1() As String
		Get 
			Return GetProperty(_shipAddr1Property)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("ShipAddr1")
            SetProperty(_shipAddr1Property, value)
            OnPropertyChanged("ShipAddr1")
        End Set
	End Property
	
	
	Private Shared ReadOnly _shipAddr2Property As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Order) p.ShipAddr2)
	Public Property ShipAddr2() As String
		Get 
			Return GetProperty(_shipAddr2Property)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("ShipAddr2")
            SetProperty(_shipAddr2Property, value)
            OnPropertyChanged("ShipAddr2")
        End Set
	End Property
	
	
	Private Shared ReadOnly _shipCityProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Order) p.ShipCity)
	Public Property ShipCity() As String
		Get 
			Return GetProperty(_shipCityProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("ShipCity")
            SetProperty(_shipCityProperty, value)
            OnPropertyChanged("ShipCity")
        End Set
	End Property
	
	
	Private Shared ReadOnly _shipStateProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Order) p.ShipState)
	Public Property ShipState() As String
		Get 
			Return GetProperty(_shipStateProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("ShipState")
            SetProperty(_shipStateProperty, value)
            OnPropertyChanged("ShipState")
        End Set
	End Property
	
	
	Private Shared ReadOnly _shipZipProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Order) p.ShipZip)
	Public Property ShipZip() As String
		Get 
			Return GetProperty(_shipZipProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("ShipZip")
            SetProperty(_shipZipProperty, value)
            OnPropertyChanged("ShipZip")
        End Set
	End Property
	
	
	Private Shared ReadOnly _shipCountryProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Order) p.ShipCountry)
	Public Property ShipCountry() As String
		Get 
			Return GetProperty(_shipCountryProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("ShipCountry")
            SetProperty(_shipCountryProperty, value)
            OnPropertyChanged("ShipCountry")
        End Set
	End Property
	
	
	Private Shared ReadOnly _billAddr1Property As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Order) p.BillAddr1)
	Public Property BillAddr1() As String
		Get 
			Return GetProperty(_billAddr1Property)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("BillAddr1")
            SetProperty(_billAddr1Property, value)
            OnPropertyChanged("BillAddr1")
        End Set
	End Property
	
	
	Private Shared ReadOnly _billAddr2Property As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Order) p.BillAddr2)
	Public Property BillAddr2() As String
		Get 
			Return GetProperty(_billAddr2Property)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("BillAddr2")
            SetProperty(_billAddr2Property, value)
            OnPropertyChanged("BillAddr2")
        End Set
	End Property
	
	
	Private Shared ReadOnly _billCityProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Order) p.BillCity)
	Public Property BillCity() As String
		Get 
			Return GetProperty(_billCityProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("BillCity")
            SetProperty(_billCityProperty, value)
            OnPropertyChanged("BillCity")
        End Set
	End Property
	
	
	Private Shared ReadOnly _billStateProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Order) p.BillState)
	Public Property BillState() As String
		Get 
			Return GetProperty(_billStateProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("BillState")
            SetProperty(_billStateProperty, value)
            OnPropertyChanged("BillState")
        End Set
	End Property
	
	
	Private Shared ReadOnly _billZipProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Order) p.BillZip)
	Public Property BillZip() As String
		Get 
			Return GetProperty(_billZipProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("BillZip")
            SetProperty(_billZipProperty, value)
            OnPropertyChanged("BillZip")
        End Set
	End Property
	
	
	Private Shared ReadOnly _billCountryProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Order) p.BillCountry)
	Public Property BillCountry() As String
		Get 
			Return GetProperty(_billCountryProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("BillCountry")
            SetProperty(_billCountryProperty, value)
            OnPropertyChanged("BillCountry")
        End Set
	End Property
	
	
	Private Shared ReadOnly _courierProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Order) p.Courier)
	Public Property Courier() As String
		Get 
			Return GetProperty(_courierProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("Courier")
            SetProperty(_courierProperty, value)
            OnPropertyChanged("Courier")
        End Set
	End Property
	
	
	Private Shared ReadOnly _totalPriceProperty As PropertyInfo(Of Decimal) = RegisterProperty(Of Decimal)(Function(p As Order) p.TotalPrice)
	Public Property TotalPrice() As Decimal
		Get 
			Return GetProperty(_totalPriceProperty)
		End Get
        Set (ByVal value As Decimal)
            OnPropertyChanging("TotalPrice")
            SetProperty(_totalPriceProperty, value)
            OnPropertyChanged("TotalPrice")
        End Set
	End Property
	
	
	Private Shared ReadOnly _billToFirstNameProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Order) p.BillToFirstName)
	Public Property BillToFirstName() As String
		Get 
			Return GetProperty(_billToFirstNameProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("BillToFirstName")
            SetProperty(_billToFirstNameProperty, value)
            OnPropertyChanged("BillToFirstName")
        End Set
	End Property
	
	
	Private Shared ReadOnly _billToLastNameProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Order) p.BillToLastName)
	Public Property BillToLastName() As String
		Get 
			Return GetProperty(_billToLastNameProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("BillToLastName")
            SetProperty(_billToLastNameProperty, value)
            OnPropertyChanged("BillToLastName")
        End Set
	End Property
	
	
	Private Shared ReadOnly _shipToFirstNameProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Order) p.ShipToFirstName)
	Public Property ShipToFirstName() As String
		Get 
			Return GetProperty(_shipToFirstNameProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("ShipToFirstName")
            SetProperty(_shipToFirstNameProperty, value)
            OnPropertyChanged("ShipToFirstName")
        End Set
	End Property
	
	
	Private Shared ReadOnly _shipToLastNameProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Order) p.ShipToLastName)
	Public Property ShipToLastName() As String
		Get 
			Return GetProperty(_shipToLastNameProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("ShipToLastName")
            SetProperty(_shipToLastNameProperty, value)
            OnPropertyChanged("ShipToLastName")
        End Set
	End Property
	
	
	Private Shared ReadOnly _authorizationNumberProperty As PropertyInfo(Of Integer) = RegisterProperty(Of Integer)(Function(p As Order) p.AuthorizationNumber)
	Public Property AuthorizationNumber() As Integer
		Get 
			Return GetProperty(_authorizationNumberProperty)
		End Get
        Set (ByVal value As Integer)
            OnPropertyChanging("AuthorizationNumber")
            SetProperty(_authorizationNumberProperty, value)
            OnPropertyChanged("AuthorizationNumber")
        End Set
	End Property
	
	
	Private Shared ReadOnly _localeProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Order) p.Locale)
	Public Property Locale() As String
		Get 
			Return GetProperty(_localeProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("Locale")
            SetProperty(_localeProperty, value)
            OnPropertyChanged("Locale")
        End Set
	End Property
	
	Private Shared ReadOnly _lineItemProperty As PropertyInfo(Of LineItem) = RegisterProperty(Of LineItem)(Function(p As Order) p.LineItem, Csla.RelationshipTypes.LazyLoad)
	Public ReadOnly Property LineItem() As LineItem
		Get
            If Not (FieldManager.FieldExists(_lineItemProperty))
                SetProperty(_lineItemProperty, LineItem.GetLineItem(OrderId))
            End If
            
               Return GetProperty(_lineItemProperty) 
        End Get
    End Property

	Private Shared ReadOnly _orderStatusProperty As PropertyInfo(Of OrderStatus) = RegisterProperty(Of OrderStatus)(Function(p As Order) p.OrderStatus, Csla.RelationshipTypes.LazyLoad)
	Public ReadOnly Property OrderStatus() As OrderStatus
		Get
            If Not (FieldManager.FieldExists(_orderStatusProperty))
                SetProperty(_orderStatusProperty, OrderStatus.GetOrderStatus(OrderId))
            End If
            
               Return GetProperty(_orderStatusProperty) 
        End Get
    End Property

' NOTE: Many-To-Many support coming soon.
	#End Region
			
	#Region "Root Factory Methods"
	
	Public Shared Function NewOrder() As Order 
		Return DataPortal.Create(Of Order)()
	End Function
	
	Public Shared Function GetOrder(ByVal orderId As Integer) As Order 		
		Return DataPortal.Fetch(Of Order)(New OrderCriteria(orderId))
	End Function

    Public Shared Sub DeleteOrder(ByVal orderId As Integer)
	    DataPortal.Delete(New OrderCriteria(orderId))
	End Sub
	
	#End Region
	
	#Region "Child Factory Methods"
	
	Friend Shared Function NewOrderChild() As Order
	    Return DataPortal.CreateChild(Of Order)()
	End Function
    
    Friend Shared Function GetOrderChild(ByVal orderId As Integer) As Order 		
		Return DataPortal.FetchChild(Of Order)(New OrderCriteria(orderId))
	End Function

	#End Region
	

End Class