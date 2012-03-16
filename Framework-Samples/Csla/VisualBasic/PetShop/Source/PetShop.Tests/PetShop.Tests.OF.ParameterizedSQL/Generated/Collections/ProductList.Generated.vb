﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.0.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Product.vb.
'
'     Template: DynamicRootList.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Linq

Imports Csla
Imports Csla.Data

Namespace PetShop.Tests.OF.ParameterizedSQL
    <Serializable()> _
    <Csla.Server.ObjectFactory(FactoryNames.ProductListFactoryName)> _
    Public Partial Class ProductList
        Inherits DynamicBindingListBase(Of Product)
    
#Region "Constructor(s)"

        public Sub New()
            AllowNew = True
        End Sub

#End Region

#Region "Synchronous Factory Methods"

        ''' <summary>
        ''' Creates a new list collection of type <see cref="ProductList"/>. 
        ''' </summary>
        ''' <returns>Returns a newly instantiated collection of type <see cref="ProductList"/>.</returns>
        Public Shared Function NewList() As ProductList
            Return DataPortal.Create(Of ProductList)()
        End Function

        ''' <summary>
        ''' Returns a <see cref="ProductList"/> collection of <see cref="Product"/> items with the specified criteria. 
        ''' </summary>
        ''' <param name="productId">No additional detail available.</param>
        ''' <returns>Collection of all <see cref="Product"/> items.</returns>    
        Public Shared Function GetByProductId(ByVal productId As System.String) As ProductList 
            Dim criteria As New ProductCriteria()
                        criteria.ProductId = productId

            Return DataPortal.Fetch(Of ProductList)(criteria)
        End Function

        ''' <summary>
        ''' Returns a <see cref="ProductList"/> collection of <see cref="Product"/> items with the specified criteria. 
        ''' </summary>
        ''' <param name="name">No additional detail available.</param>
        ''' <returns>Collection of all <see cref="Product"/> items.</returns>    
        Public Shared Function GetByName(ByVal name As System.String) As ProductList 
            Dim criteria As New ProductCriteria()
                        criteria.Name = name

            Return DataPortal.Fetch(Of ProductList)(criteria)
        End Function

        ''' <summary>
        ''' Returns a <see cref="ProductList"/> collection of <see cref="Product"/> items with the specified criteria. 
        ''' </summary>
        ''' <param name="categoryId">No additional detail available.</param>
        ''' <returns>Collection of all <see cref="Product"/> items.</returns>    
        Public Shared Function GetByCategoryId(ByVal categoryId As System.String) As ProductList 
            Dim criteria As New ProductCriteria()
                        criteria.CategoryId = categoryId

            Return DataPortal.Fetch(Of ProductList)(criteria)
        End Function

        ''' <summary>
        ''' Returns a <see cref="ProductList"/> collection of <see cref="Product"/> items with the specified criteria. 
        ''' </summary>
        ''' <param name="categoryId">No additional detail available.</param>
        ''' <param name="name">No additional detail available.</param>
        ''' <returns>Collection of all <see cref="Product"/> items.</returns>    
        Public Shared Function GetByCategoryIdName(ByVal categoryId As System.String, ByVal name As System.String) As ProductList 
            Dim criteria As New ProductCriteria()
                        criteria.CategoryId = categoryId
            criteria.Name = name

            Return DataPortal.Fetch(Of ProductList)(criteria)
        End Function

        ''' <summary>
        ''' Returns a <see cref="ProductList"/> collection of <see cref="Product"/> items with the specified criteria. 
        ''' </summary>
        ''' <param name="categoryId">No additional detail available.</param>
        ''' <param name="productId">No additional detail available.</param>
        ''' <param name="name">No additional detail available.</param>
        ''' <returns>Collection of all <see cref="Product"/> items.</returns>    
        Public Shared Function GetByCategoryIdProductIdName(ByVal categoryId As System.String, ByVal productId As System.String, ByVal name As System.String) As ProductList 
            Dim criteria As New ProductCriteria()
                        criteria.CategoryId = categoryId
            criteria.ProductId = productId
            criteria.Name = name

            Return DataPortal.Fetch(Of ProductList)(criteria)
        End Function

        Public Shared Function GetByCriteria(ByVal criteria As ProductCriteria) As ProductList
            Return DataPortal.Fetch(Of ProductList)(criteria)
        End Function

        ''' <summary>
        ''' Returns a <see cref="ProductList"/> collection of all <see cref="Product"/> items. 
        ''' </summary>
        ''' <returns>Collection of all Product items.</returns>    
        Public Shared Function GetAll() As ProductList
            Return DataPortal.Fetch(Of ProductList)(New ProductCriteria())
        End Function

#End Region

#Region "Asynchronous Factory Methods"

        Public Shared Sub NewListAsync(ByVal handler As EventHandler(Of DataPortalResult(Of ProductList)))
            Dim dp As New DataPortal(Of ProductList)()
            AddHandler dp.CreateCompleted, handler
            dp.BeginCreate()
        End Sub
    
        Public Shared Sub GetByProductIdAsync(ByVal productId As System.String, ByVal handler As EventHandler(Of DataPortalResult(Of ProductList)))
            Dim dp As New DataPortal(Of ProductList)()
            AddHandler dp.FetchCompleted, handler
        
            Dim criteria As New ProductCriteria()
            criteria.ProductId = productId
    
            dp.BeginFetch(criteria)
        End Sub
    
        Public Shared Sub GetByNameAsync(ByVal name As System.String, ByVal handler As EventHandler(Of DataPortalResult(Of ProductList)))
            Dim dp As New DataPortal(Of ProductList)()
            AddHandler dp.FetchCompleted, handler
        
            Dim criteria As New ProductCriteria()
            criteria.Name = name
    
            dp.BeginFetch(criteria)
        End Sub
    
        Public Shared Sub GetByCategoryIdAsync(ByVal categoryId As System.String, ByVal handler As EventHandler(Of DataPortalResult(Of ProductList)))
            Dim dp As New DataPortal(Of ProductList)()
            AddHandler dp.FetchCompleted, handler
        
            Dim criteria As New ProductCriteria()
            criteria.CategoryId = categoryId
    
            dp.BeginFetch(criteria)
        End Sub
    
        Public Shared Sub GetByCategoryIdNameAsync(ByVal categoryId As System.String, ByVal name As System.String, ByVal handler As EventHandler(Of DataPortalResult(Of ProductList)))
            Dim dp As New DataPortal(Of ProductList)()
            AddHandler dp.FetchCompleted, handler
        
            Dim criteria As New ProductCriteria()
            criteria.CategoryId = categoryId
            criteria.Name = name
    
            dp.BeginFetch(criteria)
        End Sub
    
        Public Shared Sub GetByCategoryIdProductIdNameAsync(ByVal categoryId As System.String, ByVal productId As System.String, ByVal name As System.String, ByVal handler As EventHandler(Of DataPortalResult(Of ProductList)))
            Dim dp As New DataPortal(Of ProductList)()
            AddHandler dp.FetchCompleted, handler
        
            Dim criteria As New ProductCriteria()
            criteria.CategoryId = categoryId
            criteria.ProductId = productId
            criteria.Name = name
    
            dp.BeginFetch(criteria)
        End Sub

        Public Shared Sub GetByCriteriaAsync(ByVal criteria As ProductCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of ProductList)))
            Dim dp As New DataPortal(Of ProductList)()
            AddHandler dp.FetchCompleted, handler

            ' Mark as child?
            dp.BeginFetch(criteria)
        End Sub

        Public Shared Sub GetAllAsync(ByVal handler As EventHandler(Of DataPortalResult(Of ProductList)))
            Dim dp As New DataPortal(Of ProductList)()
            AddHandler dp.FetchCompleted, handler
            dp.BeginFetch(New ProductCriteria())
        End Sub 

#end Region

#Region "Method Overrides"

        Protected Overrides Function AddNewCore() As Object
            Dim item As Product = PetShop.Tests.OF.ParameterizedSQL.Product.NewProductChild()
    
            Dim cancel As Boolean = False
            OnAddNewCore(item, cancel)
            If Not (cancel) Then
                ' Check to see if someone set the item to null In the OnAddNewCore.
                If(item Is Nothing) Then
                    item = PetShop.Tests.OF.ParameterizedSQL.Product.NewProductChild()
                End If
                
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
                    For Each item As Product In Me.Items
                        If item.IsDirty Then
                            Return True
                        End If
                    Next
            
                    Return False
                End Get
            End Property
    
#End Region
    
#Region "DataPortal partial methods"
    
        ''' <summary>
        ''' Codesmith generated stub method that is called when creating the child <see cref="Product"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the child <see cref="Product"/> object has been created. 
        ''' </summary>
        Partial Private Sub OnCreated()
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when fetching the child <see cref="Product"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="ProductCriteria"/> object containg the criteria of the object to fetch.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        Partial Private Sub OnFetching(ByVal criteria As ProductCriteria, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the child <see cref="Product"/> object has been fetched. 
        ''' </summary>
        Partial Private Sub OnFetched()
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when mapping the child <see cref="Product"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when mapping the child <see cref="Product"/> object. 
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the child <see cref="Product"/> object has been mapped. 
        ''' </summary>
        Partial Private Sub OnMapped()
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when updating the <see cref="Product"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Product"/> object has been updated. 
        ''' </summary>
        Partial Private Sub OnUpdated()
        End Sub
        Partial Private Sub OnAddNewCore(ByRef item As Product, ByRef cancel As Boolean)
        End Sub
    
#End Region
#Region "Exists Command"

        ''' <summary>
        ''' Determines if a record exists in the Product in the database for the specified criteria. 
        ''' </summary>
        ''' <param name="criteria">The criteria parameter is a <see cref="ProductList"/> object.</param>
        ''' <returns>A boolean value of true is returned if a record is found.</returns>
        Public Shared Function Exists(ByVal criteria As ProductCriteria) As Boolean
            Return PetShop.Tests.OF.ParameterizedSQL.Product.Exists(criteria)
        End Function

        ''' <summary>
        ''' Determines if a record exists in the Product in the database for the specified criteria. 
        ''' </summary>
        Public Shared Sub ExistsAsync(ByVal criteria As ProductCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of ExistsCommand)))
            PetShop.Tests.OF.ParameterizedSQL.Product.ExistsAsync(criteria, handler)
        End Sub

#End Region
 
#region "Enhancements"

        Public Function GetProduct(ByVal productId As System.String) As Product
            Return Me.FirstOrDefault(Function(i As Product) i.ProductId = productId)
        End Function
        
        Public Overloads Function Contains(ByVal productId As System.String) As Boolean
            Return Me.Where(Function(i As Product) i.ProductId = productId).Count() > 0
        End Function
        
#End Region
    End Class
End Namespace