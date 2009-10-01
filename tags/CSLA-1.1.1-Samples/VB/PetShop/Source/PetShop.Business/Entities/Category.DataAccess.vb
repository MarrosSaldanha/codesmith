
'------------------------------------------------------------------------------
' <autogenerated>
'     Me code was generated Imports CSLA 3.7.X CodeSmith Templates.
'     Changes to Me file will be lost after each regeneration.
'     To extend the functionality of Me class, please modify the partial class 'Category.vb.
'
'     Template: EditableRoot.DataAccess.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Data
Imports Csla.Validation

Imports PetShop.Data

Public Partial Class Category
		
	#Region "Data Access"

	<RunLocal()> _
	Protected Shadows Sub DataPortal_Create()
		'MyBase.DataPortal_Create()

		ValidationRules.CheckRules()
	End Sub

	Private Shadows Sub DataPortal_Fetch(ByVal criteria As CategoryCriteria)
	    Using reader As SafeDataReader = DataAccessLayer.Instance.CategoryFetch(criteria.StateBag)
            If reader.Read() Then
	            Fetch(reader)
            End If
        End Using
    End Sub
	
    Private Sub Fetch(ByVal reader As SafeDataReader)
		LoadProperty(_categoryIdProperty, reader.GetString("CategoryId"))
		LoadProperty(_nameProperty, reader.GetString("Name"))
		LoadProperty(_descnProperty, reader.GetString("Descn"))


        MarkOld()
    End Sub
	
	<Transactional(TransactionalTypes.TransactionScope)> _
	Protected Overrides Sub DataPortal_Insert()
		Using reader As SafeDataReader = DataAccessLayer.Instance.CategoryInsert(ReadProperty(_categoryIdProperty), ReadProperty(_nameProperty), ReadProperty(_descnProperty))
			If reader.Read() Then

			End If
		End Using
        
        FieldManager.UpdateChildren(Me)
	End Sub
	
	<Transactional(TransactionalTypes.TransactionScope)> _
	Protected Overrides Sub DataPortal_Update()
        Using reader As SafeDataReader = DataAccessLayer.Instance.CategoryUpdate(ReadProperty(_categoryIdProperty), ReadProperty(_nameProperty), ReadProperty(_descnProperty))
        End Using
        
        FieldManager.UpdateChildren(Me)
	End Sub
	
	<Transactional(TransactionalTypes.TransactionScope)> _
	Protected Overrides Sub DataPortal_DeleteSelf()
        DataPortal_Delete(new CategoryCriteria(CategoryId))
    End Sub
	
	<Transactional(TransactionalTypes.TransactionScope)> _
	Protected Overrides Sub DataPortal_Delete(ByVal criteria As Object)
		Dim theCriteria As CategoryCriteria = DirectCast(criteria, CategoryCriteria)
        If Not theCriteria Is Nothing Then
			Using reader As SafeDataReader = DataAccessLayer.Instance.CategoryDelete(theCriteria.StateBag)
			End Using
		End If
    End Sub

    #End Region
End Class