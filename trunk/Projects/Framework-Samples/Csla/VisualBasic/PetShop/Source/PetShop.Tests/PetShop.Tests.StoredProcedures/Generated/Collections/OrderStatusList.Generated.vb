﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.2.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'OrderStatusList.vb.
'
'     Template: EditableRootList.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Data

<Serializable()> _
Public Partial Class OrderStatusList 
    Inherits BusinessListBase(Of OrderStatusList, OrderStatus)

    #Region "Contructor(s)"
    
    Private Sub New()
        AllowNew = true
    End Sub
    
    #End Region

    #Region "Factory Methods"

    Public Shared Function NewList() As OrderStatusList
        Return DataPortal.Create(Of OrderStatusList)()
    End Function

    Public Shared Function GetByOrderIdLineNum(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As OrderStatusList 
        Dim criteria As New OrderStatusCriteria()
        criteria.OrderId = orderId
			criteria.LineNum = lineNum

        Return DataPortal.Fetch(Of OrderStatusList)(criteria)
    End Function

    Public Shared Function GetByOrderId(ByVal orderId As System.Int32) As OrderStatusList 
        Dim criteria As New OrderStatusCriteria()
        criteria.OrderId = orderId

        Return DataPortal.Fetch(Of OrderStatusList)(criteria)
    End Function

    Public Shared Function GetAll() As OrderStatusList
        Return DataPortal.Fetch(Of OrderStatusList)(New OrderStatusCriteria())
    End Function

    #End Region

    #Region "Properties"

    Protected Overrides Function AddNewCore() As Object
        Dim item As OrderStatus = PetShop.Tests.StoredProcedures.OrderStatus.NewOrderStatus()
        Me.Add(item)
        Return item
    End Function

    #End Region

    #Region "Exists Command"

    Public Shared Function Exists(ByVal criteria As OrderStatusCriteria) As Boolean
        Return PetShop.Tests.StoredProcedures.OrderStatus.Exists(criteria)
    End Function

    #End Region

End Class