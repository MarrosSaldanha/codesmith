﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v2.0.1.1739, CSLA Framework: v3.8.2.
'       Changes to this template will not be lost.
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

Namespace PetShop.Tests.ParameterizedSQL
    Public Partial Class OrderStatus
        #Region "Business Rules"
    
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
            ''More information on these rules can be found here (http://www.devx.com/codemag/Article/40663/1763/page/2).
    
            'Dim canWrite As String() = { "AdminUser", "RegularUser" }
            'Dim canRead As String() = { "AdminUser", "RegularUser", "ReadOnlyUser" }
            'Dim admin As String() = { "AdminUser" }
    
            'AuthorizationRules.AllowCreate(GetType(OrderStatus), admin)
            'AuthorizationRules.AllowDelete(GetType(OrderStatus), admin)
            'AuthorizationRules.AllowEdit(GetType(OrderStatus), canWrite)
            'AuthorizationRules.AllowGet(GetType(OrderStatus), canRead)
    
            ''OrderId
            'AuthorizationRules.AllowWrite(_orderIdProperty, canWrite)
            'AuthorizationRules.AllowRead(_orderIdProperty, canRead)
    
            ''LineNum
            'AuthorizationRules.AllowWrite(_lineNumProperty, canWrite)
            'AuthorizationRules.AllowRead(_lineNumProperty, canRead)
    
            ''Timestamp
            'AuthorizationRules.AllowWrite(_timestampProperty, canWrite)
            'AuthorizationRules.AllowRead(_timestampProperty, canRead)
    
            ''Status
            'AuthorizationRules.AllowWrite(_statusProperty, canWrite)
            'AuthorizationRules.AllowRead(_statusProperty, canRead)
    
            ''OrderMember
            'AuthorizationRules.AllowRead(_orderMemberProperty, canRead)
    
    ' NOTE: Many-To-Many support coming soon.
        End Sub
    
        #End Region
    End Class
End Namespace