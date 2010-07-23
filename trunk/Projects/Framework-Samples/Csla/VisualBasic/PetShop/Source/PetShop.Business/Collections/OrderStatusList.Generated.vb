﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v3.8.4.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'OrderStatusList.vb.
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

Namespace PetShop.Business
    <Serializable()> _
    Public Partial Class OrderStatusList 
        Inherits BusinessListBase(Of OrderStatusList, OrderStatus)
    
#Region "Contructor(s)"
        Private Sub New()
            AllowNew = true
            MarkAsChild()
        End Sub
    
#End Region
    
#Region "Synchronous Factory Methods" 
    
        Friend Shared Function NewList() As OrderStatusList
            Return DataPortal.CreateChild(Of OrderStatusList)()
        End Function
    
        Friend Shared Function GetByOrderIdLineNum(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As OrderStatusList 
            Dim criteria As New OrderStatusCriteria()
            criteria.OrderId = orderId
			criteria.LineNum = lineNum
    
            Return DataPortal.FetchChild(Of OrderStatusList)(criteria)
        End Function
    
        Friend Shared Function GetByOrderId(ByVal orderId As System.Int32) As OrderStatusList 
            Dim criteria As New OrderStatusCriteria()
            criteria.OrderId = orderId
    
            Return DataPortal.FetchChild(Of OrderStatusList)(criteria)
        End Function
    
        Friend Shared Function GetAll() As OrderStatusList
            Return DataPortal.FetchChild(Of OrderStatusList)(New OrderStatusCriteria())
        End Function
    
#End Region
    
#Region "Method Overrides"
    
        Protected Overrides Function AddNewCore() As Object
            Dim item As OrderStatus = PetShop.Business.OrderStatus.NewOrderStatus()

            Dim cancel As Boolean = False
            OnAddNewCore(item, cancel)
            If Not (cancel) Then
                ' Check to see if someone set the item to null in the OnAddNewCore.
                If(item Is Nothing) Then
                    item = PetShop.Business.OrderStatus.NewOrderStatus()
                End If
            ' Pass the parent value down to the child.
                Dim order As Order = CType(Me.Parent, Order)
                If Not(order Is Nothing)
                    item.OrderId = order.OrderId
                End If
                Add(item)
            End If

            Return item
        End Function
    
#End Region
#Region "DataPortal partial methods"
    
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnCreated()
        End Sub
        Partial Private Sub OnFetching(ByVal criteria As OrderStatusCriteria, ByRef cancel As Boolean)
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
        Partial Private Sub OnAddNewCore(ByVal item As OrderStatus, ByRef cancel As Boolean)
        End Sub
    
#End Region

#Region "Exists Command"

        Public Shared Function Exists(ByVal criteria As OrderStatusCriteria) As Boolean
            Return PetShop.Business.OrderStatus.Exists(criteria)
        End Function

#End Region
    End Class
End Namespace