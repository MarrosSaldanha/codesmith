'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.0.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'ItemList.vb.
'
'     Template: EditableChildList.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic

Imports Csla
Imports Csla.Data

<Serializable()> _
Public Partial Class ItemList 
    Inherits BusinessListBase(Of ItemList, Item)

    #Region "Contructor(s)"

    Private Sub New()
        AllowNew = true
        MarkAsChild()
    End Sub

    #End Region

    #Region "Factory Methods" 

    Friend Shared Function NewList() As ItemList
        Return DataPortal.CreateChild(Of ItemList)()
    End Function

    Friend Shared Function GetByItemId(ByVal itemId As System.String) As ItemList 
        Dim criteria As New ItemCriteria()
		criteria.ItemId = itemId

        Return DataPortal.FetchChild(Of ItemList)(criteria)
    End Function

    Friend Shared Function GetByProductIdItemIdListPriceName(ByVal productId As System.String, ByVal itemId As System.String, ByVal listPrice As System.Nullable(Of System.Decimal), ByVal name As System.String) As ItemList 
        Dim criteria As New ItemCriteria()
		criteria.ProductId = productId
		criteria.ItemId = itemId
		criteria.ListPrice = listPrice.Value
		criteria.Name = name

        Return DataPortal.FetchChild(Of ItemList)(criteria)
    End Function

    Friend Shared Function GetByProductId(ByVal productId As System.String) As ItemList 
        Dim criteria As New ItemCriteria()
		criteria.ProductId = productId

        Return DataPortal.FetchChild(Of ItemList)(criteria)
    End Function

    Friend Shared Function GetBySupplier(ByVal supplier As System.Nullable(Of System.Int32)) As ItemList 
        Dim criteria As New ItemCriteria()
		criteria.Supplier = supplier.Value

        Return DataPortal.FetchChild(Of ItemList)(criteria)
    End Function

    Friend Shared Function GetAll() As ItemList
        Return DataPortal.FetchChild(Of ItemList)(New ItemCriteria())
    End Function

    #End Region

    #Region "Properties"

    Protected Overrides Function AddNewCore() As Object
        Dim item As Item = PetShop.Business.Item.NewItem()
                Me.Add(item)
                Return item
    End Function

    #End Region

    #Region "Exists Command"

    Public Shared Function Exists(ByVal criteria As ItemCriteria) As Boolean
        Return PetShop.Business.Item.Exists(criteria)
    End Function

    #End Region

    End Class