﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v3.8.4.
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

Namespace PetShop.Tests.OF.ParameterizedSQL
    <Serializable()> _
    <Csla.Server.ObjectFactory(FactoryNames.ItemListFactoryName)> _
    Public Partial Class ItemList 
        Inherits BusinessListBase(Of ItemList, Item)
    
#Region "Contructor(s)"
        Private Sub New()
            AllowNew = true
            MarkAsChild()
        End Sub
    
#End Region
    
#Region "Synchronous Factory Methods" 
    
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
    
#Region "Method Overrides"
    
        Protected Overrides Function AddNewCore() As Object
            Dim item As Item = PetShop.Tests.OF.ParameterizedSQL.Item.NewItem()

            Dim cancel As Boolean = False
            OnAddNewCore(item, cancel)
            If Not (cancel) Then
                ' Check to see if someone set the item to null in the OnAddNewCore.
                If(item Is Nothing) Then
                    item = PetShop.Tests.OF.ParameterizedSQL.Item.NewItem()
                End If
            ' Pass the parent value down to the child.
                'Dim product As Product = CType(Me.Parent, Product)
                'If Not(product Is Nothing)
                '    item.ProductId = product.ProductId
                'End If
            ' Pass the parent value down to the child.
                'Dim supplier As Supplier = CType(Me.Parent, Supplier)
                'If Not(supplier Is Nothing)
                '    item.Supplier = supplier.SuppId
                'End If
                Add(item)
            End If

            Return item
        End Function
    
#End Region
#Region "Property overrides"
    
            ''' <summary>
            ''' Returns true if any children are dirty
            ''' </summary>
            Public Shadows ReadOnly Property IsDirty() As Boolean
                Get
                    For Each item As Item In Me.Items
                        If item.IsDirty Then
                            Return True
                        End If
                    Next
            
                    Return False
                End Get
            End Property
    
#End Region
    
#Region "DataPortal partial methods"
    
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnCreated()
        End Sub
        Partial Private Sub OnFetching(ByVal criteria As ItemCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnFetched()
        End Sub
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnMapped()
        End Sub
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnUpdated()
        End Sub
        Partial Private Sub OnAddNewCore(ByVal item As Item, ByRef cancel As Boolean)
        End Sub
    
#End Region

#Region "Exists Command"

        Public Shared Function Exists(ByVal criteria As ItemCriteria) As Boolean
            Return PetShop.Tests.OF.ParameterizedSQL.Item.Exists(criteria)
        End Function

#End Region
    End Class
End Namespace