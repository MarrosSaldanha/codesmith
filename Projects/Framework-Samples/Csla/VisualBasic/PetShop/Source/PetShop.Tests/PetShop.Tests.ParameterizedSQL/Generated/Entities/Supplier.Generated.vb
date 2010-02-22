﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.1413, CSLA Framework: v3.8.2.
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

    Private Sub New(ByVal suppId As System.Int32)
        Using(BypassPropertyChecks)
            _suppId = suppId
        End Using
    End Sub

    Friend Sub New(Byval reader As SafeDataReader)
        Map(reader)
    End Sub

    #End Region
    #Region "Validation Rules"

    Protected Overrides Sub AddBusinessRules()

        If AddBusinessValidationRules() Then Exit Sub

        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_nameProperty, 80))
        ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _statusProperty)
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_statusProperty, 2))
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_addr1Property, 80))
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_addr2Property, 80))
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_cityProperty, 80))
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_stateProperty, 80))
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_zipProperty, 5))
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_phoneProperty, 40))
    End Sub

    #End Region

    #Region "Properties"


    Private Shared ReadOnly _suppIdProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As Supplier) p.SuppId)
    Private _suppId As System.Int32 = _suppIdProperty.DefaultValue
    
		<System.ComponentModel.DataObjectField(true, false)> _
    Public Property SuppId() As System.Int32
        Get 
            Return GetProperty(_suppIdProperty, _suppId) 
        End Get
        Set (value As System.Int32)
            SetProperty(_suppIdProperty, _suppId, value)
        End Set
    End Property

    Private Shared ReadOnly _originalSuppIdProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As Supplier) p.OriginalSuppId)
    Private _originalSuppId As System.Int32 = _originalSuppIdProperty.DefaultValue
    ''' <summary>
    ''' Holds the original value for SuppId. This is used for non identity primary keys.
    ''' </summary>
    Friend Property OriginalSuppId() As System.Int32
        Get 
            Return GetProperty(_originalSuppIdProperty, _originalSuppId) 
        End Get
        Set (value As System.Int32)
            SetProperty(_originalSuppIdProperty, _originalSuppId, value)
        End Set
    End Property
    

    Private Shared ReadOnly _nameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Supplier) p.Name)
    Private _name As System.String = _nameProperty.DefaultValue
    
    Public Property Name() As System.String
        Get 
            Return GetProperty(_nameProperty, _name) 
        End Get
        Set (value As System.String)
            SetProperty(_nameProperty, _name, value)
        End Set
    End Property
    

    Private Shared ReadOnly _statusProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Supplier) p.Status)
    Private _status As System.String = _statusProperty.DefaultValue
    
    Public Property Status() As System.String
        Get 
            Return GetProperty(_statusProperty, _status) 
        End Get
        Set (value As System.String)
            SetProperty(_statusProperty, _status, value)
        End Set
    End Property
    

    Private Shared ReadOnly _addr1Property As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Supplier) p.Addr1)
    Private _addr1 As System.String = _addr1Property.DefaultValue
    
    Public Property Addr1() As System.String
        Get 
            Return GetProperty(_addr1Property, _addr1) 
        End Get
        Set (value As System.String)
            SetProperty(_addr1Property, _addr1, value)
        End Set
    End Property
    

    Private Shared ReadOnly _addr2Property As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Supplier) p.Addr2)
    Private _addr2 As System.String = _addr2Property.DefaultValue
    
    Public Property Addr2() As System.String
        Get 
            Return GetProperty(_addr2Property, _addr2) 
        End Get
        Set (value As System.String)
            SetProperty(_addr2Property, _addr2, value)
        End Set
    End Property
    

    Private Shared ReadOnly _cityProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Supplier) p.City)
    Private _city As System.String = _cityProperty.DefaultValue
    
    Public Property City() As System.String
        Get 
            Return GetProperty(_cityProperty, _city) 
        End Get
        Set (value As System.String)
            SetProperty(_cityProperty, _city, value)
        End Set
    End Property
    

    Private Shared ReadOnly _stateProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Supplier) p.State)
    Private _state As System.String = _stateProperty.DefaultValue
    
    Public Property State() As System.String
        Get 
            Return GetProperty(_stateProperty, _state) 
        End Get
        Set (value As System.String)
            SetProperty(_stateProperty, _state, value)
        End Set
    End Property
    

    Private Shared ReadOnly _zipProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Supplier) p.Zip)
    Private _zip As System.String = _zipProperty.DefaultValue
    
    Public Property Zip() As System.String
        Get 
            Return GetProperty(_zipProperty, _zip) 
        End Get
        Set (value As System.String)
            SetProperty(_zipProperty, _zip, value)
        End Set
    End Property
    

    Private Shared ReadOnly _phoneProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Supplier) p.Phone)
    Private _phone As System.String = _phoneProperty.DefaultValue
    
    Public Property Phone() As System.String
        Get 
            Return GetProperty(_phoneProperty, _phone) 
        End Get
        Set (value As System.String)
            SetProperty(_phoneProperty, _phone, value)
        End Set
    End Property
    
    'OneToMany
    Private Shared ReadOnly _itemsProperty As PropertyInfo(Of ItemList) = RegisterProperty(Of ItemList)(Function(p As Supplier) p.Items, Csla.RelationshipTypes.Child)
Public ReadOnly Property Items() As ItemList 
        Get
            If Not (FieldManager.FieldExists(_itemsProperty)) Then
                Dim criteria As New PetShop.Tests.ParameterizedSQL.ItemCriteria()
                criteria.Supplier = SuppId

                If (Me.IsNew Or Not PetShop.Tests.ParameterizedSQL.ItemList.Exists(criteria)) Then
                    LoadProperty(_itemsProperty, PetShop.Tests.ParameterizedSQL.ItemList.NewList())
                Else
                    LoadProperty(_itemsProperty, PetShop.Tests.ParameterizedSQL.ItemList.GetBySupplier(SuppId))
                End If
            End If
            
            Return GetProperty(_itemsProperty) 
        End Get
    End Property
    
    #End Region


    #Region "Factory Methods"

    Public Shared Function NewSupplier() As Supplier 
        Return DataPortal.Create(Of Supplier)()
    End Function

    Public Shared Function GetBySuppId(ByVal suppId As System.Int32) As Supplier 
        Dim criteria As New SupplierCriteria ()
        criteria.SuppId = suppId
        
        Return DataPortal.Fetch(Of Supplier)(criteria)
    End Function

    Public Shared Sub DeleteSupplier(ByVal suppId As System.Int32)
        DataPortal.Delete(New SupplierCriteria (suppId))
    End Sub

    #End Region

    #Region "Exists Command"

    Public Shared Function Exists(ByVal criteria As SupplierCriteria ) As Boolean
        Return ExistsCommand.Execute(criteria)
    End Function

    #End Region


End Class
