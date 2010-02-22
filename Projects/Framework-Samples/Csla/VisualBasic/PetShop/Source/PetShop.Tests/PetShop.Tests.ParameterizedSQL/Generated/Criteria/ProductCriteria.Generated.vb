﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.1413, CSLA Framework: v3.8.2.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Product.vb.
'
'     Template: Criteria.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

#Region "Using declarations"

Imports System
Imports System.Collections.Generic
Imports System.Runtime.InteropServices

Imports Csla

#End Region

<Serializable(), ClassInterface(ClassInterfaceType.None)> _
Public Partial Class ProductCriteria
    Inherits CriteriaBase
    Implements IGeneratedCriteria

    #Region "Private Read-Only Members"
    
    Private ReadOnly _bag As New Dictionary(Of String, Object)()
    
    #End Region

    #Region "Constructors"

    Public Sub New()
        MyBase.New(GetType(Product))
    End Sub
    
    Public Sub New(ByVal productId As System.String) 
        MyBase.New(GetType(Product))
        
        Me.ProductId = productId
    End Sub

    #End Region

    #Region "Public Properties"
    
    #Region "Read-Write"

    
    Public Property ProductId() As System.String
        Get
            Return GetValue(Of System.String)("ProductId")
        End Get
        Set
            _bag("ProductId") = value
        End Set
    End Property
    
    Public Property CategoryId() As System.String
        Get
            Return GetValue(Of System.String)("CategoryId")
        End Get
        Set
            _bag("CategoryId") = value
        End Set
    End Property
    
    Public Property Name() As System.String
        Get
            Return GetValue(Of System.String)("Name")
        End Get
        Set
            _bag("Name") = value
        End Set
    End Property
    
    Public Property Description() As System.String
        Get
            Return GetValue(Of System.String)("Descn")
        End Get
        Set
            _bag("Descn") = value
        End Set
    End Property
    
    Public Property Image() As System.String
        Get
            Return GetValue(Of System.String)("Image")
        End Get
        Set
            _bag("Image") = value
        End Set
    End Property

    #End Region
    
    #Region "Read-Only"

    ''' <summary>
    ''' Returns a list of all the modified properties and values.
    ''' </summary>
    Public ReadOnly Property StateBag() As Dictionary(Of String, Object) Implements IGeneratedCriteria.StateBag
        Get
            Return _bag
        End Get
    End Property

    ''' <summary>
    ''' Returns a list of all the modified properties and values.
    ''' </summary>
    Public ReadOnly Property TableFullName() As String Implements IGeneratedCriteria.TableFullName
        Get
            Return "[dbo].Product"
        End Get
    End Property

    #End Region

    #End Region

    #region "Overrides"

    Public Overrides Function ToString() As String
        If _bag.Count = 0 Then
            Return "No criterion was specified"
        End If

        Dim result As String = String.Empty
        For Each key As KeyValuePair(Of String, Object) In _bag
            result += String.Format("[{0}] = '{1}' AND ", key.Key, key.Value)
        Next

        Return result.Remove(result.Length - 5, 5)
    End Function

    #End Region

    #Region "Private Methods"
    
    Private Function GetValue(Of T)(name As String) As T
        Dim value As New Object
        If _bag.TryGetValue(name, value) Then
            Return DirectCast(value, T)
        End If
    
        Return Nothing
    End Function
    
    #End Region

End Class