'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.7.X CodeSmith Templates.
'	   Changes to this template will not be lost.
'
'     Template: EditableRoot.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Security
Imports Csla.Validation

Public Partial Class Inventory

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

        'AuthorizationRules.AllowCreate(GetType(Inventory), admin)
        'AuthorizationRules.AllowDelete(GetType(Inventory), admin)
        'AuthorizationRules.AllowEdit(GetType(Inventory), canWrite)
        'AuthorizationRules.AllowGet(GetType(Inventory), canRead)

        'ItemId
        'AuthorizationRules.AllowWrite(_itemIdProperty, canWrite)
        'AuthorizationRules.AllowRead(_itemIdProperty, canRead)
        
        'Qty
        'AuthorizationRules.AllowWrite(_qtyProperty, canWrite)
        'AuthorizationRules.AllowRead(_qtyProperty, canRead)
        
	End Sub
	
	Private Shared Sub AddObjectAuthorizationRules()
		' TODO: add authorization rules
		'AuthorizationRules.AllowEdit(typeof(Inventory), "Role")
	End Sub
	
	#End Region
    
End Class