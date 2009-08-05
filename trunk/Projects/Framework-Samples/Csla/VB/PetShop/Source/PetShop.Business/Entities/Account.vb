'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.7.X CodeSmith Templates.
'	   Changes to this template will not be lost.
'
'     Template: EditableChild.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Security
Imports Csla.Validation

Public Partial Class Account

	#Region "Validation Rules"
	
	''' <summary>
    ''' All custom rules need to be placed in this method.
    ''' </summary>
    ''' <Returns>Return true to override the generated rules If false generated rules will be run.</Returns>
	Protected Function AddBusinessValidationRules() As Boolean
	
		' TODO: add validation rules
		'ValidationRules.AddRule(RuleMethod, "")

	    Return False
	
	End Function
	
	#End Region
	
	#Region "Authorization Rules"
	
	Protected Overrides Sub AddAuthorizationRules()
		'Dim canWrite As String() = { "AdminUser", "RegularUser" }
        'Dim canRead As String() = { "AdminUser", "RegularUser", "ReadOnlyUser" }
        'Dim admin As String() = { "AdminUser" }

        'AuthorizationRules.AllowCreate(GetType(Account), admin)
        'AuthorizationRules.AllowDelete(GetType(Account), admin)
        'AuthorizationRules.AllowEdit(GetType(Account), canWrite)
        'AuthorizationRules.AllowGet(GetType(Account), canRead)

        'AccountId
        'AuthorizationRules.AllowRead(_accountIdProperty, canRead)
        
        'Email
        'AuthorizationRules.AllowWrite(_emailProperty, canWrite)
        'AuthorizationRules.AllowRead(_emailProperty, canRead)
        
        'FirstName
        'AuthorizationRules.AllowWrite(_firstNameProperty, canWrite)
        'AuthorizationRules.AllowRead(_firstNameProperty, canRead)
        
        'LastName
        'AuthorizationRules.AllowWrite(_lastNameProperty, canWrite)
        'AuthorizationRules.AllowRead(_lastNameProperty, canRead)
        
        'Address1
        'AuthorizationRules.AllowWrite(_address1Property, canWrite)
        'AuthorizationRules.AllowRead(_address1Property, canRead)
        
        'Address2
        'AuthorizationRules.AllowWrite(_address2Property, canWrite)
        'AuthorizationRules.AllowRead(_address2Property, canRead)
        
        'City
        'AuthorizationRules.AllowWrite(_cityProperty, canWrite)
        'AuthorizationRules.AllowRead(_cityProperty, canRead)
        
        'State
        'AuthorizationRules.AllowWrite(_stateProperty, canWrite)
        'AuthorizationRules.AllowRead(_stateProperty, canRead)
        
        'Zip
        'AuthorizationRules.AllowWrite(_zipProperty, canWrite)
        'AuthorizationRules.AllowRead(_zipProperty, canRead)
        
        'Country
        'AuthorizationRules.AllowWrite(_countryProperty, canWrite)
        'AuthorizationRules.AllowRead(_countryProperty, canRead)
        
        'Phone
        'AuthorizationRules.AllowWrite(_phoneProperty, canWrite)
        'AuthorizationRules.AllowRead(_phoneProperty, canRead)
        
        'UniqueID
        'AuthorizationRules.AllowWrite(_uniqueIDProperty, canWrite)
        'AuthorizationRules.AllowRead(_uniqueIDProperty, canRead)
        
        'Profile
        'AuthorizationRules.AllowRead(_profileProperty, canRead)
        
	End Sub
	
	Private Shared Sub AddObjectAuthorizationRules()
		' TODO: add authorization rules
		'AuthorizationRules.AllowEdit(typeof(Account), "Role")
	End Sub
	
	#End Region
    
End Class