﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.0.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
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
Imports System.Data.SqlClient

Imports Csla.Rules

Namespace PetShop.Tests.OF.ParameterizedSQL
    <Serializable()> _
    <Csla.Server.ObjectFactory(FactoryNames.OrderFactoryName)> _
    Public Partial Class Order 
        Inherits BusinessBase(Of Order)

#Region "Contructor(s)"

        public Sub New()
            ' require use of factory method 
        End Sub

#End Region
#Region "Business Rules"

        ''' <summary>
        ''' Contains the Codesmith generated validation rules.
        ''' </summary>
        Protected Overrides Sub AddBusinessRules()
            ' Call the base class, if this call isn't made than any declared System.ComponentModel.DataAnnotations rules will not work.
            MyBase.AddBusinessRules()

            If AddBusinessValidationRules() Then Exit Sub
    
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_userIdProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_userIdProperty, 20))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_shipAddr1Property))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_shipAddr1Property, 80))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_shipAddr2Property, 80))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_shipCityProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_shipCityProperty, 80))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_shipStateProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_shipStateProperty, 80))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_shipZipProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_shipZipProperty, 20))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_shipCountryProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_shipCountryProperty, 20))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_billAddr1Property))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_billAddr1Property, 80))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_billAddr2Property, 80))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_billCityProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_billCityProperty, 80))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_billStateProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_billStateProperty, 80))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_billZipProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_billZipProperty, 20))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_billCountryProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_billCountryProperty, 20))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_courierProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_courierProperty, 80))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_billToFirstNameProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_billToFirstNameProperty, 80))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_billToLastNameProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_billToLastNameProperty, 80))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_shipToFirstNameProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_shipToFirstNameProperty, 80))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_shipToLastNameProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_shipToLastNameProperty, 80))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_localeProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_localeProperty, 20))
        End Sub
    
#End Region

#Region "Properties"
    
        Private Shared ReadOnly _orderIdProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As Order) p.OrderId, "Order Id")
        
        <System.ComponentModel.DataObjectField(true, true)> _
        Public Property OrderId() As System.Int32
            Get 
                Return GetProperty(_orderIdProperty)
            End Get
            Friend Set (ByVal value As System.Int32)
                SetProperty(_orderIdProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _userIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.UserId, "User Id")
        
        Public Property UserId() As System.String
            Get 
                Return GetProperty(_userIdProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_userIdProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _orderDateProperty As PropertyInfo(Of System.DateTime) = RegisterProperty(Of System.DateTime)(Function(p As Order) p.OrderDate, "Order Date")
        
        Public Property OrderDate() As System.DateTime
            Get 
                Return GetProperty(_orderDateProperty)
            End Get
            Set (ByVal value As System.DateTime)
                SetProperty(_orderDateProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _shipAddr1Property As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.ShipAddr1, "Ship Addr 1")
        
        Public Property ShipAddr1() As System.String
            Get 
                Return GetProperty(_shipAddr1Property)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_shipAddr1Property, value)
            End Set
        End Property

        Private Shared ReadOnly _shipAddr2Property As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.ShipAddr2, "Ship Addr 2", vbNullString)
        
        Public Property ShipAddr2() As System.String
            Get 
                Return GetProperty(_shipAddr2Property)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_shipAddr2Property, value)
            End Set
        End Property

        Private Shared ReadOnly _shipCityProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.ShipCity, "Ship City")
        
        Public Property ShipCity() As System.String
            Get 
                Return GetProperty(_shipCityProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_shipCityProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _shipStateProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.ShipState, "Ship State")
        
        Public Property ShipState() As System.String
            Get 
                Return GetProperty(_shipStateProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_shipStateProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _shipZipProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.ShipZip, "Ship Zip")
        
        Public Property ShipZip() As System.String
            Get 
                Return GetProperty(_shipZipProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_shipZipProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _shipCountryProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.ShipCountry, "Ship Country")
        
        Public Property ShipCountry() As System.String
            Get 
                Return GetProperty(_shipCountryProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_shipCountryProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _billAddr1Property As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.BillAddr1, "Bill Addr 1")
        
        Public Property BillAddr1() As System.String
            Get 
                Return GetProperty(_billAddr1Property)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_billAddr1Property, value)
            End Set
        End Property

        Private Shared ReadOnly _billAddr2Property As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.BillAddr2, "Bill Addr 2", vbNullString)
        
        Public Property BillAddr2() As System.String
            Get 
                Return GetProperty(_billAddr2Property)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_billAddr2Property, value)
            End Set
        End Property

        Private Shared ReadOnly _billCityProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.BillCity, "Bill City")
        
        Public Property BillCity() As System.String
            Get 
                Return GetProperty(_billCityProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_billCityProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _billStateProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.BillState, "Bill State")
        
        Public Property BillState() As System.String
            Get 
                Return GetProperty(_billStateProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_billStateProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _billZipProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.BillZip, "Bill Zip")
        
        Public Property BillZip() As System.String
            Get 
                Return GetProperty(_billZipProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_billZipProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _billCountryProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.BillCountry, "Bill Country")
        
        Public Property BillCountry() As System.String
            Get 
                Return GetProperty(_billCountryProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_billCountryProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _courierProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.Courier, "Courier")
        
        Public Property Courier() As System.String
            Get 
                Return GetProperty(_courierProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_courierProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _totalPriceProperty As PropertyInfo(Of System.Decimal) = RegisterProperty(Of System.Decimal)(Function(p As Order) p.TotalPrice, "Total Price")
        
        Public Property TotalPrice() As System.Decimal
            Get 
                Return GetProperty(_totalPriceProperty)
            End Get
            Set (ByVal value As System.Decimal)
                SetProperty(_totalPriceProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _billToFirstNameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.BillToFirstName, "Bill To First Name")
        
        Public Property BillToFirstName() As System.String
            Get 
                Return GetProperty(_billToFirstNameProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_billToFirstNameProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _billToLastNameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.BillToLastName, "Bill To Last Name")
        
        Public Property BillToLastName() As System.String
            Get 
                Return GetProperty(_billToLastNameProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_billToLastNameProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _shipToFirstNameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.ShipToFirstName, "Ship To First Name")
        
        Public Property ShipToFirstName() As System.String
            Get 
                Return GetProperty(_shipToFirstNameProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_shipToFirstNameProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _shipToLastNameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.ShipToLastName, "Ship To Last Name")
        
        Public Property ShipToLastName() As System.String
            Get 
                Return GetProperty(_shipToLastNameProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_shipToLastNameProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _authorizationNumberProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As Order) p.AuthorizationNumber, "Authorization Number")
        
        Public Property AuthorizationNumber() As System.Int32
            Get 
                Return GetProperty(_authorizationNumberProperty)
            End Get
            Set (ByVal value As System.Int32)
                SetProperty(_authorizationNumberProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _localeProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.Locale, "Locale")
        
        Public Property Locale() As System.String
            Get 
                Return GetProperty(_localeProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_localeProperty, value)
            End Set
        End Property

    
    
    
        'OneToMany
        Private Shared ReadOnly _lineItemsProperty As PropertyInfo(Of LineItemList) = RegisterProperty(Of LineItemList)(Function(p As Order) p.LineItems, Csla.RelationshipTypes.Child)
    Public ReadOnly Property LineItems() As LineItemList
            Get
                Dim cancel As Boolean = False
                OnChildLoading(_lineItemsProperty, cancel)
                
                If Not cancel Then
                    If Not (FieldManager.FieldExists(_lineItemsProperty)) Then
                        Dim criteria As New PetShop.Tests.OF.ParameterizedSQL.LineItemCriteria()
                        criteria.OrderId = OrderId
    
                        If (Not PetShop.Tests.OF.ParameterizedSQL.LineItemList.Exists(criteria)) Then
                            LoadProperty(_lineItemsProperty, PetShop.Tests.OF.ParameterizedSQL.LineItemList.NewList())
                        Else
                            LoadProperty(_lineItemsProperty, PetShop.Tests.OF.ParameterizedSQL.LineItemList.GetByOrderId(OrderId))
                        End If
                    End If
                End If

                Return GetProperty(_lineItemsProperty) 
            End Get
        End Property

        'OneToMany
        Private Shared ReadOnly _orderStatusesProperty As PropertyInfo(Of OrderStatusList) = RegisterProperty(Of OrderStatusList)(Function(p As Order) p.OrderStatuses, Csla.RelationshipTypes.Child)
    Public ReadOnly Property OrderStatuses() As OrderStatusList
            Get
                Dim cancel As Boolean = False
                OnChildLoading(_orderStatusesProperty, cancel)
                
                If Not cancel Then
                    If Not (FieldManager.FieldExists(_orderStatusesProperty)) Then
                        Dim criteria As New PetShop.Tests.OF.ParameterizedSQL.OrderStatusCriteria()
                        criteria.OrderId = OrderId
    
                        If (Not PetShop.Tests.OF.ParameterizedSQL.OrderStatusList.Exists(criteria)) Then
                            LoadProperty(_orderStatusesProperty, PetShop.Tests.OF.ParameterizedSQL.OrderStatusList.NewList())
                        Else
                            LoadProperty(_orderStatusesProperty, PetShop.Tests.OF.ParameterizedSQL.OrderStatusList.GetByOrderId(OrderId))
                        End If
                    End If
                End If

                Return GetProperty(_orderStatusesProperty) 
            End Get
        End Property

#End Region
    
#Region "Synchronous Root Factory Methods"
        ''' <summary>
        ''' Creates a new object of type <see cref="Order"/>. 
        ''' </summary>
        ''' <returns>Returns a newly instantiated collection of type <see cref="Order"/>.</returns>    
        Public Shared Function NewOrder() As Order 
            Return DataPortal.Create(Of Order)()
        End Function
    
        ''' <summary>
        ''' Returns a <see cref="Order"/> object of the specified criteria. 
        ''' </summary>
        ''' <param name="orderId">No additional detail available.</param>
        ''' <returns>A <see cref="Order"/> object of the specified criteria.</returns>
        Public Shared Function GetByOrderId(ByVal orderId As System.Int32) As Order
            Dim criteria As New OrderCriteria()
                        criteria.OrderId = orderId
    
            Return DataPortal.Fetch(Of Order)(criteria)
        End Function
    
        Public Shared Sub DeleteOrder(ByVal orderId As System.Int32)
            DataPortal.Delete(Of Order)(New OrderCriteria (orderId))
        End Sub
#End Region
    
#Region "Asynchronous Root Factory Methods"
            
        Public Shared Sub NewOrderAsync(ByVal handler As EventHandler(Of DataPortalResult(Of Order)))
            Dim dp As New DataPortal(Of Order)()
            AddHandler dp.CreateCompleted, handler
            dp.BeginCreate()
        End Sub
    
        Public Shared Sub GetByOrderIdAsync(ByVal orderId As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of Order)))
            Dim dp As New DataPortal(Of Order)()
            AddHandler dp.FetchCompleted, handler
        
            Dim criteria As New OrderCriteria()
            criteria.OrderId = orderId
    
            dp.BeginFetch(criteria)
        End Sub
    
        Public Shared Sub DeleteOrderAsync(ByVal orderId As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of Order)))
            Dim dp As New DataPortal(Of Order)()
            AddHandler dp.DeleteCompleted, handler
            dp.BeginDelete(New OrderCriteria (orderId))
        End Sub
    
            
#End Region
    
#Region "Synchronous Child Factory Methods"
        ''' <summary>
        ''' Creates a new object of type <see cref="Order"/>. 
        ''' </summary>
        ''' <returns>Returns a newly instantiated collection of type <see cref="Order"/>.</returns>
        Friend Shared Function NewOrderChild() As Order
            Return DataPortal.CreateChild(Of Order)()
        End Function
    
        ''' <summary>
        ''' Returns a <see cref="Order"/> object of the specified criteria. 
        ''' </summary>
        ''' <param name="orderId">No additional detail available.</param>
        ''' <returns>A <see cref="Order"/> object of the specified criteria.</returns>
        Friend Shared Function GetByOrderIdChild(ByVal orderId As System.Int32) As Order
            Dim criteria As New OrderCriteria()
            criteria.OrderId = orderId
    
            Return DataPortal.Fetch(Of Order)(criteria)
        End Function

#End Region
    
#Region "Asynchronous Child Factory Methods"
    
        Friend Shared Sub NewOrderChildAsync(ByVal handler As EventHandler(Of DataPortalResult(Of Order)))
            Dim dp As New DataPortal(Of Order)()
            AddHandler dp.CreateCompleted, handler
            dp.BeginCreate()
        End Sub

        Friend Shared Sub GetByOrderIdChildAsync(ByVal orderId As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of Order)))
            Dim dp As New DataPortal(Of Order)()
            AddHandler dp.FetchCompleted, handler
        
            Dim criteria As New OrderCriteria()
            criteria.OrderId = orderId

            ' Mark as child?
            dp.BeginFetch(criteria)
        End Sub

#End Region

#Region "DataPortal partial methods"
    
        ''' <summary>
        ''' Codesmith generated stub method that is called when creating the <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Order"/> object has been created. 
        ''' </summary>
        Partial Private Sub OnCreated()
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when fetching the <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="OrderCriteria"/> object containg the criteria of the object to fetch.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        Partial Private Sub OnFetching(ByVal criteria As OrderCriteria, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Order"/> object has been fetched. 
        ''' </summary>    
        Partial Private Sub OnFetched()
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when mapping the <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByRef cancel As Boolean)
        End Sub
 
        ''' <summary>
        ''' Codesmith generated stub method that is called when mapping the <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Order"/> object has been mapped. 
        ''' </summary>
        Partial Private Sub OnMapped()
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called when inserting the <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        Partial Private Sub OnInserting(ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Order"/> object has been inserted. 
        ''' </summary>
        Partial Private Sub OnInserted()
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called when updating the <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Order"/> object has been updated. 
        ''' </summary>
        Partial Private Sub OnUpdated()
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called when self deleting the <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        Partial Private Sub OnSelfDeleting(ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Order"/> object has been deleted. 
        ''' </summary>
        Partial Private Sub OnSelfDeleted()
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called when deleting the <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="OrderCriteria"/> object containg the criteria of the object to delete.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        Partial Private Sub OnDeleting(ByVal criteria As OrderCriteria, ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Order"/> object with the specified criteria has been deleted. 
        ''' </summary>
        Partial Private Sub OnDeleted()
        End Sub
        Private Partial Sub OnChildLoading(ByVal childProperty As Global.Csla.Core.IPropertyInfo, ByRef cancel As Boolean)
        End Sub
    
#End Region
    
#Region "ChildPortal partial methods"


        ''' <summary>
        ''' Codesmith generated stub method that is called when creating the child <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnChildCreating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the child <see cref="Order"/> object has been created. 
        ''' </summary>
        Partial Private Sub OnChildCreated()
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when fetching the child <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="OrderCriteria"/> object containg the criteria of the object to fetch.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        Partial Private Sub OnChildFetching(ByVal criteria As OrderCriteria, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the child <see cref="Order"/> object has been fetched. 
        ''' </summary>
        Partial Private Sub OnChildFetched()
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when inserting the child <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        Partial Private Sub OnChildInserting(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when inserting the child <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="connection"></param>
        ''' <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        Partial Private Sub OnChildInserting(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the child <see cref="Order"/> object has been inserted. 
        ''' </summary>
        Partial Private Sub OnChildInserted()
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when updating the child <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnChildUpdating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when updating the child <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="connection"></param>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnChildUpdating(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the child <see cref="Order"/> object has been updated. 
        ''' </summary>
        Partial Private Sub OnChildUpdated()
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when self deleting the child <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        Partial Private Sub OnChildSelfDeleting(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the child <see cref="Order"/> object has been deleted. 
        ''' </summary>
        Partial Private Sub OnChildSelfDeleted()
        End Sub
    
#End Region
#Region "Exists Command"

        ''' <summary>
        ''' Determines if a record exists in the [dbo].[Orders] table in the database for the specified criteria. 
        ''' </summary>
        ''' <param name="criteria">The criteria parameter is an <see cref="Order"/> object.</param>
        ''' <returns>A boolean value of true is returned if a record is found.</returns>
        Public Shared Function Exists(ByVal criteria As OrderCriteria) As Boolean
            Return PetShop.Tests.OF.ParameterizedSQL.ExistsCommand.Execute(criteria)
        End Function

        ''' <summary>
        ''' Determines if a record exists in the [dbo].[Orders] table in the database for the specified criteria. 
        ''' </summary>
        Public Shared Sub ExistsAsync(ByVal criteria As OrderCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of ExistsCommand)))
            PetShop.Tests.OF.ParameterizedSQL.ExistsCommand.ExecuteAsync(criteria, handler)
        End Sub

#End Region
#Region "Overridden properties"
    
            ''' <summary>
            ''' Returns true if the business object or any of its children properties are dirty.
            ''' </summary>
            Public Overloads Overrides ReadOnly Property IsDirty() As Boolean
                Get
                    If MyBase.IsDirty Then
                        Return True
                    End If
    
    
    
    
                    If (FieldManager.FieldExists(_lineItemsProperty) AndAlso LineItems.IsDirty) Then
                        Return True
                    End If
                    If (FieldManager.FieldExists(_orderStatusesProperty) AndAlso OrderStatuses.IsDirty) Then
                        Return True
                    End If
                    Return False
                End Get
            End Property
    
#End Region
    
    End Class
End Namespace