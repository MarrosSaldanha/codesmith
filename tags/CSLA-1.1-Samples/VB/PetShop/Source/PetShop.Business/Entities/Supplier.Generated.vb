'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.7.X CodeSmith Templates.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Supplier.vb.
'
'     Template path: EditableRoot.Generated.cst
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
Public Partial Class Supplier 
    Inherits BusinessBase(Of Supplier)

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
       
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs("Name", 80))
		ValidationRules.AddRule(AddressOf CommonRules.StringRequired, "Status")
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs("Status", 2))
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs("Addr1", 80))
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs("Addr2", 80))
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs("City", 80))
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs("State", 80))
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs("Zip", 5))
		ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs("Phone", 40))
	End Sub
	
	#End Region
	
	#Region "Business Methods"


	
	Private Shared ReadOnly _suppIdProperty As PropertyInfo(Of Integer) = RegisterProperty(Of Integer)(Function(p As Supplier) p.SuppId)
		<System.ComponentModel.DataObjectField(true, false)> _
	Public Property SuppId() As Integer
		Get 
			Return GetProperty(_suppIdProperty)
		End Get
        Set (ByVal value As Integer)
            OnPropertyChanging("SuppId")
            SetProperty(_suppIdProperty, value)
            OnPropertyChanged("SuppId")
        End Set
	End Property
	
	
	Private Shared ReadOnly _nameProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Supplier) p.Name)
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
	
	
	Private Shared ReadOnly _statusProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Supplier) p.Status)
	Public Property Status() As String
		Get 
			Return GetProperty(_statusProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("Status")
            SetProperty(_statusProperty, value)
            OnPropertyChanged("Status")
        End Set
	End Property
	
	
	Private Shared ReadOnly _addr1Property As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Supplier) p.Addr1)
	Public Property Addr1() As String
		Get 
			Return GetProperty(_addr1Property)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("Addr1")
            SetProperty(_addr1Property, value)
            OnPropertyChanged("Addr1")
        End Set
	End Property
	
	
	Private Shared ReadOnly _addr2Property As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Supplier) p.Addr2)
	Public Property Addr2() As String
		Get 
			Return GetProperty(_addr2Property)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("Addr2")
            SetProperty(_addr2Property, value)
            OnPropertyChanged("Addr2")
        End Set
	End Property
	
	
	Private Shared ReadOnly _cityProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Supplier) p.City)
	Public Property City() As String
		Get 
			Return GetProperty(_cityProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("City")
            SetProperty(_cityProperty, value)
            OnPropertyChanged("City")
        End Set
	End Property
	
	
	Private Shared ReadOnly _stateProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Supplier) p.State)
	Public Property State() As String
		Get 
			Return GetProperty(_stateProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("State")
            SetProperty(_stateProperty, value)
            OnPropertyChanged("State")
        End Set
	End Property
	
	
	Private Shared ReadOnly _zipProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Supplier) p.Zip)
	Public Property Zip() As String
		Get 
			Return GetProperty(_zipProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("Zip")
            SetProperty(_zipProperty, value)
            OnPropertyChanged("Zip")
        End Set
	End Property
	
	
	Private Shared ReadOnly _phoneProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As Supplier) p.Phone)
	Public Property Phone() As String
		Get 
			Return GetProperty(_phoneProperty)
		End Get
        Set (ByVal value As String)
            OnPropertyChanging("Phone")
            SetProperty(_phoneProperty, value)
            OnPropertyChanged("Phone")
        End Set
	End Property
	
	Private Shared ReadOnly _itemsProperty As PropertyInfo(Of ItemList) = RegisterProperty(Of ItemList)(Function(p As Supplier) p.Items, Csla.RelationshipTypes.LazyLoad)
	Public ReadOnly Property Items() As ItemList 
		Get
            If Not (FieldManager.FieldExists(_itemsProperty)) Then
                SetProperty(_itemsProperty, ItemList.GetBySupplier(SuppId))

            End If
            Return GetProperty(_itemsProperty) 
        End Get
    End Property
    
	#End Region
	
	#Region "Factory Methods"
	
	Public Shared Function NewSupplier() As Supplier 
		Return DataPortal.Create(Of Supplier)()
	End Function
	
	Public Shared Function GetSupplier(ByVal suppId As Integer) As Supplier 		
		Return DataPortal.Fetch(Of Supplier)(New SupplierCriteria(suppId))
	End Function

    Public Shared Sub DeleteSupplier(ByVal suppId As Integer)
	    DataPortal.Delete(New SupplierCriteria(suppId))
	End Sub

    #End Region
    

End Class