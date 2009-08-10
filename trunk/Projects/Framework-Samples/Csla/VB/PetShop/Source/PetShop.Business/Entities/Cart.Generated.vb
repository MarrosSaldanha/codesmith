'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.7.X CodeSmith Templates.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Cart.vb.
'
'     Template: EditableChild.Generated.cst
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
Public Partial Class Cart 
    Inherits BusinessBase(Of Cart)

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
       
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, "ItemId")
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs("ItemId", 10))
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, "Name")
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs("Name", 80))
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, "Type")
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs("Type", 80))
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, "CategoryId")
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs("CategoryId", 10))
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, "ProductId")
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs("ProductId", 10))
	End Sub
	
	#End Region
    
    #Region "Business Methods"


	
	Private Shared ReadOnly _cartIdProperty As PropertyInfo(Of Integer) = RegisterProperty(Of Integer)(Function(p As Cart) p.CartId)
		<System.ComponentModel.DataObjectField(true, true)> _
	Public ReadOnly Property CartId() As Integer
		Get 
			Return GetProperty(_cartIdProperty)
		End Get
	End Property
	
	
	Private Shared ReadOnly _itemIdProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Cart) p.ItemId)
	Public Property ItemId() As String
		Get 
			Return GetProperty(_itemIdProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("ItemId")
            SetProperty(_itemIdProperty, value)
            OnPropertyChanged("ItemId")
        End Set
	End Property
	
	
	Private Shared ReadOnly _nameProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Cart) p.Name)
	Public Property Name() As String
		Get 
			Return GetProperty(_nameProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("Name")
            SetProperty(_nameProperty, value)
            OnPropertyChanged("Name")
        End Set
	End Property
	
	
	Private Shared ReadOnly _typeProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Cart) p.Type)
	Public Property Type() As String
		Get 
			Return GetProperty(_typeProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("Type")
            SetProperty(_typeProperty, value)
            OnPropertyChanged("Type")
        End Set
	End Property
	
	
	Private Shared ReadOnly _priceProperty As PropertyInfo(Of Decimal) = RegisterProperty(Of Decimal)(Function(p As Cart) p.Price)
	Public Property Price() As Decimal
		Get 
			Return GetProperty(_priceProperty)
		End Get
        Set (ByVal value As Decimal)
            OnPropertyChanging("Price")
            SetProperty(_priceProperty, value)
            OnPropertyChanged("Price")
        End Set
	End Property
	
	
	Private Shared ReadOnly _categoryIdProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Cart) p.CategoryId)
	Public Property CategoryId() As String
		Get 
			Return GetProperty(_categoryIdProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("CategoryId")
            SetProperty(_categoryIdProperty, value)
            OnPropertyChanged("CategoryId")
        End Set
	End Property
	
	
	Private Shared ReadOnly _productIdProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Cart) p.ProductId)
	Public Property ProductId() As String
		Get 
			Return GetProperty(_productIdProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("ProductId")
            SetProperty(_productIdProperty, value)
            OnPropertyChanged("ProductId")
        End Set
	End Property
	
	
	Private Shared ReadOnly _isShoppingCartProperty As PropertyInfo(Of Boolean) = RegisterProperty(Of Boolean)(Function(p As Cart) p.IsShoppingCart)
	Public Property IsShoppingCart() As Boolean
		Get 
			Return GetProperty(_isShoppingCartProperty)
		End Get
        Set (ByVal value As Boolean)
            OnPropertyChanging("IsShoppingCart")
            SetProperty(_isShoppingCartProperty, value)
            OnPropertyChanged("IsShoppingCart")
        End Set
	End Property
	
	
	Private Shared ReadOnly _quantityProperty As PropertyInfo(Of Integer) = RegisterProperty(Of Integer)(Function(p As Cart) p.Quantity)
	Public Property Quantity() As Integer
		Get 
			Return GetProperty(_quantityProperty)
		End Get
        Set (ByVal value As Integer)
            OnPropertyChanging("Quantity")
            SetProperty(_quantityProperty, value)
            OnPropertyChanged("Quantity")
        End Set
	End Property
	
    Private Shared _uniqueIDProperty As PropertyInfo(Of Integer) = RegisterProperty(Of Integer)(Function(p As Cart) p.UniqueID)
	Public Property UniqueID() As Integer 
		Get  
			Return GetProperty(_uniqueIDProperty)				
		End Get
        Set (ByVal value As Integer)
            OnPropertyChanging("UniqueID")
            SetProperty(_uniqueIDProperty, value) 
            OnPropertyChanged("UniqueID")
        End Set
	End Property
	
	Private Shared ReadOnly _profileProperty As PropertyInfo(Of Profile) = RegisterProperty(Of Profile)(Function(p As Cart) p.Profile, Csla.RelationshipTypes.LazyLoad)
	Public ReadOnly Property Profile() As Profile
		Get
        
            If Not(FieldManager.FieldExists(_profileProperty))
                SetProperty(_profileProperty, Profile.GetProfile(UniqueID))
            End If
            
            Return GetProperty(_profileProperty) 
        End Get
    End Property
    
	#End Region
			
	#Region "Factory Methods"
	
	Friend Shared Function NewCart() As Cart 
		Return DataPortal.Create(Of Cart)()
	End Function
	
	Friend Shared Function GetCart(ByVal cartId As Integer) As Cart 		
		Return DataPortal.Fetch(Of Cart)(New CartCriteria(cartId))
	End Function
	
	#End Region
	

End Class
