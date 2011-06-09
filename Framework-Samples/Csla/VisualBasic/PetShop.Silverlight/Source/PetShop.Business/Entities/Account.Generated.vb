﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v4.0.0.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Account.vb.
'
'     Template: EditableChild.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Rules
#If SILVERLIGHT Then
Imports Csla.Serialization
#Else
Imports Csla.Data
Imports System.Data.SqlClient
#End If

Namespace PetShop.Business
    <Serializable()> _
    Public Partial Class Account
        Inherits BusinessBase(Of Account)
    
#Region "Contructor(s)"
    
#If Not SILVERLIGHT Then
        Private Sub New()
            ' require use of factory method.
            MarkAsChild()
        End Sub
#Else
    public Sub New()
            ' require use of factory method.
            MarkAsChild()
        End Sub
#End If
    
        Friend Sub New(ByVal accountId As System.Int32)
            Using(BypassPropertyChecks)
            LoadProperty(_accountIdProperty, accountId)
            End Using
    
            MarkAsChild()
        End Sub
    
#If Not SILVERLIGHT Then
        Friend Sub New(Byval reader As SafeDataReader)
            Map(reader)
    
            MarkAsChild()
        End Sub
#End If
#End Region    
    
#Region "Business Rules"
    
        Protected Overrides Sub AddBusinessRules()
    
            If AddBusinessValidationRules() Then Exit Sub
    
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_emailProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_emailProperty, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_firstNameProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_firstNameProperty, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_lastNameProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_lastNameProperty, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_address1Property))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_address1Property, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_address2Property, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_cityProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_cityProperty, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_stateProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_stateProperty, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_zipProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_zipProperty, 20))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_countryProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_countryProperty, 20))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_phoneProperty, 20))
        End Sub
    
#End Region

#Region "Properties"
    
        Private Shared ReadOnly _accountIdProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As Account) p.AccountId, String.Empty)
#If Not SILVERLIGHT Then
        
		<System.ComponentModel.DataObjectField(true, true)> _
        Public Property AccountId() As System.Int32
#Else
        Public Property AccountId() As System.Int32
#End If
            Get 
                Return GetProperty(_accountIdProperty)
            End Get
            Friend Set (ByVal value As System.Int32)
                SetProperty(_accountIdProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _uniqueIDProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As Account) p.UniqueID, String.Empty)
#If Not SILVERLIGHT Then
        
        Public Property UniqueID() As System.Int32
#Else
        Public Property UniqueID() As System.Int32
#End If
            Get 
                Return GetProperty(_uniqueIDProperty)
            End Get
            Set (ByVal value As System.Int32)
                SetProperty(_uniqueIDProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _emailProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Account) p.Email, String.Empty)
#If Not SILVERLIGHT Then
        
        Public Property Email() As System.String
#Else
        Public Property Email() As System.String
#End If
            Get 
                Return GetProperty(_emailProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_emailProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _firstNameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Account) p.FirstName, String.Empty)
#If Not SILVERLIGHT Then
        
        Public Property FirstName() As System.String
#Else
        Public Property FirstName() As System.String
#End If
            Get 
                Return GetProperty(_firstNameProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_firstNameProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _lastNameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Account) p.LastName, String.Empty)
#If Not SILVERLIGHT Then
        
        Public Property LastName() As System.String
#Else
        Public Property LastName() As System.String
#End If
            Get 
                Return GetProperty(_lastNameProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_lastNameProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _address1Property As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Account) p.Address1, String.Empty)
#If Not SILVERLIGHT Then
        
        Public Property Address1() As System.String
#Else
        Public Property Address1() As System.String
#End If
            Get 
                Return GetProperty(_address1Property)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_address1Property, value)
            End Set
        End Property

        Private Shared ReadOnly _address2Property As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Account) p.Address2, String.Empty, vbNullString)
#If Not SILVERLIGHT Then
        
        Public Property Address2() As System.String
#Else
        Public Property Address2() As System.String
#End If
            Get 
                Return GetProperty(_address2Property)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_address2Property, value)
            End Set
        End Property

        Private Shared ReadOnly _cityProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Account) p.City, String.Empty)
#If Not SILVERLIGHT Then
        
        Public Property City() As System.String
#Else
        Public Property City() As System.String
#End If
            Get 
                Return GetProperty(_cityProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_cityProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _stateProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Account) p.State, String.Empty)
#If Not SILVERLIGHT Then
        
        Public Property State() As System.String
#Else
        Public Property State() As System.String
#End If
            Get 
                Return GetProperty(_stateProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_stateProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _zipProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Account) p.Zip, String.Empty)
#If Not SILVERLIGHT Then
        
        Public Property Zip() As System.String
#Else
        Public Property Zip() As System.String
#End If
            Get 
                Return GetProperty(_zipProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_zipProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _countryProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Account) p.Country, String.Empty)
#If Not SILVERLIGHT Then
        
        Public Property Country() As System.String
#Else
        Public Property Country() As System.String
#End If
            Get 
                Return GetProperty(_countryProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_countryProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _phoneProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Account) p.Phone, String.Empty, vbNullString)
#If Not SILVERLIGHT Then
        
        Public Property Phone() As System.String
#Else
        Public Property Phone() As System.String
#End If
            Get 
                Return GetProperty(_phoneProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_phoneProperty, value)
            End Set
        End Property

        'AssociatedManyToOne
        Private Shared ReadOnly _profileMemberProperty As PropertyInfo(Of Profile) = RegisterProperty(Of Profile)(Function(p As Account) p.ProfileMember, Csla.RelationshipTypes.Child)
        Public ReadOnly Property ProfileMember() As Profile
            Get
                Dim cancel As Boolean = False
                OnChildLoading(_profileMemberProperty, cancel)
                
                If Not cancel Then
                    If(False) Then
                        Return Nothing
                    End If
    
                    If Not(FieldManager.FieldExists(_profileMemberProperty))
                        Dim criteria As New PetShop.Business.ProfileCriteria()
                        criteria.UniqueID = UniqueID

#If SILVERLIGHT Then
                        'Markbusy()
                        PetShop.Business.Profile.Exists(criteria, Sub(o, e)
                            If Not (e.Error Is Nothing) Then
                                Throw e.Error
                            End If
                            
                            If (e.Object.Result) Then
                                PetShop.Business.Profile.GetByUniqueIDAsync(UniqueID, Sub(o1, e1)
                                    If Not (e1.Error Is Nothing) Then
                                        Throw e1.Error
                                    End If

                                    Me.LoadProperty(_profileMemberProperty, e1.Object)

                                    'MarkIdle()
                                    OnPropertyChanged(_profileMemberProperty)
                                End Sub)
                            End If
                        End Sub)
#Else
                        If (PetShop.Business.Profile.Exists(criteria)) Then
                            LoadProperty(_profileMemberProperty, PetShop.Business.Profile.GetByUniqueID(UniqueID))
                        End If
#End If
                    End If
                End If

                Return GetProperty(_profileMemberProperty) 
            End Get
        End Property

#End Region
    
#Region "Synchronous Factory Methods"

#If Not SILVERLIGHT Then
        Friend Shared Function NewAccount() As Account 
            Return DataPortal.Create(Of Account)()
        End Function
    
        Friend Shared Function GetByAccountId(ByVal accountId As System.Int32) As Account
            Dim criteria As New AccountCriteria()
            criteria.AccountId = accountId
    
            Return DataPortal.FetchChild(Of Account)(criteria)
        End Function
    
        Friend Shared Function GetByUniqueID(ByVal uniqueID As System.Int32) As Account
            Dim criteria As New AccountCriteria()
            criteria.UniqueID = uniqueID
    
            Return DataPortal.FetchChild(Of Account)(criteria)
        End Function
#End If
    
#End Region
    
#Region "Asynchronous Factory Methods"

#If SILVERLIGHT Then
        Friend Shared Sub NewAccountAsync(ByVal handler As EventHandler(Of DataPortalResult(Of Account)))
            Dim dp As New DataPortal(Of Account)()
            AddHandler dp.CreateCompleted, handler
            dp.BeginCreate()
        End Sub
    
        Friend Shared Sub GetByAccountIdAsync(ByVal accountId As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of AsyncChildLoader(Of Account))))
            Dim criteria As New AccountCriteria()
            criteria.AccountId = accountId

            DataPortal.BeginFetch(Of AsyncChildLoader(Of Account))(criteria, handler)
        End Sub
    
        Friend Shared Sub GetByUniqueIDAsync(ByVal uniqueID As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of AsyncChildLoader(Of Account))))
            Dim criteria As New AccountCriteria()
            criteria.UniqueID = uniqueID

            DataPortal.BeginFetch(Of AsyncChildLoader(Of Account))(criteria, handler)
        End Sub
#End If

#End Region
    
#Region "ChildPortal partial methods"
    
#If Not SILVERLIGHT Then
        Partial Private Sub OnChildCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildCreated()
        End Sub
        Partial Private Sub OnChildFetching(ByVal criteria As AccountCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildFetched()
        End Sub
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnMapped()
        End Sub
        Partial Private Sub OnChildInserting(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildInserted()
        End Sub
        Partial Private Sub OnChildUpdating(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildUpdated()
        End Sub
        Partial Private Sub OnChildSelfDeleting(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildSelfDeleted()
        End Sub
        Partial Private Sub OnDeleting(ByVal criteria As AccountCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnDeleting(ByVal criteria As AccountCriteria, ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnDeleted()
        End Sub
#End If
        Private Partial Sub OnChildLoading(ByVal childProperty As Csla.Core.IPropertyInfo, ByRef cancel As Boolean)
        End Sub
    
#End Region

#Region "Exists Command"
#If Not SILVERLIGHT Then

        Public Shared Function Exists(ByVal criteria As AccountCriteria) As Boolean
            Return PetShop.Business.ExistsCommand.Execute(criteria)
        End Function

#Else

        Public Shared Sub Exists(ByVal criteria As AccountCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of ExistsCommand)))
            PetShop.Business.ExistsCommand.Execute(criteria, handler)
        End Sub

#End If

#End Region
    End Class
End Namespace