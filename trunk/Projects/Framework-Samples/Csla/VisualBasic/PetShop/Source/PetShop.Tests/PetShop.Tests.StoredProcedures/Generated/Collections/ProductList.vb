'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.8.X CodeSmith Templates.
'       Changes to this template will not be lost.
'
'     Template: DynamicRootList.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic

Imports Csla

Public Partial Class ProductList
#Region "Authorization Rules"

    Private Shared Sub AddObjectAuthorizationRules()
        ''More information on these rules can be found here (http://www.devx.com/codemag/Article/40663/1763/page/2).

        'Dim canWrite As String() = { "AdminUser", "RegularUser" }
        'Dim canRead As String() = { "AdminUser", "RegularUser", "ReadOnlyUser" }
        'Dim admin As String() = { "AdminUser" }

        'AuthorizationRules.AllowCreate(GetType(ProductList), admin)
        'AuthorizationRules.AllowDelete(GetType(ProductList), admin)
        'AuthorizationRules.AllowEdit(GetType(ProductList), canWrite)
        'AuthorizationRules.AllowGet(GetType(ProductList), canRead)

        ''ProductId
        'AuthorizationRules.AllowWrite(_productIdProperty, canWrite)
        'AuthorizationRules.AllowRead(_productIdProperty, canRead)

        ''CategoryId
        'AuthorizationRules.AllowWrite(_categoryIdProperty, canWrite)
        'AuthorizationRules.AllowRead(_categoryIdProperty, canRead)

        ''Name
        'AuthorizationRules.AllowWrite(_nameProperty, canWrite)
        'AuthorizationRules.AllowRead(_nameProperty, canRead)

        ''Descn
        'AuthorizationRules.AllowWrite(_descnProperty, canWrite)
        'AuthorizationRules.AllowRead(_descnProperty, canRead)

        ''Image
        'AuthorizationRules.AllowWrite(_imageProperty, canWrite)
        'AuthorizationRules.AllowRead(_imageProperty, canRead)

        ''CategoryMember
        'AuthorizationRules.AllowRead(_categoryMemberProperty, canRead)

    End Sub

    #End Region
End Class