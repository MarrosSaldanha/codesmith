
'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.7.X CodeSmith Templates.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Account.vb.
'
'     Template: EditableChild.DataAccess.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Data

Imports PetShop.Data

Public Partial Class Account
		
	#Region "Data Access"
	
	<RunLocal()> _
    Protected Overrides Sub Child_Create()
		' TODO: load default values
		' omit this override if you have no defaults to set
		'MyBase.Child_Create()
    End Sub
	
	Private Sub Child_Fetch(ByVal reader As SafeDataReader)
		Fetch(reader)
        
        MarkAsChild()
	End Sub
	
	Private Sub Child_Insert()
	    Using reader As SafeDataReader = DataAccessLayer.Instance.AccountInsert(ReadProperty(_emailProperty), ReadProperty(_firstNameProperty), ReadProperty(_lastNameProperty), ReadProperty(_address1Property), ReadProperty(_address2Property), ReadProperty(_cityProperty), ReadProperty(_stateProperty), ReadProperty(_zipProperty), ReadProperty(_countryProperty), ReadProperty(_phoneProperty), ReadProperty(_uniqueIDProperty))
			If reader.Read() Then

				LoadProperty(_accountIdProperty, reader.GetInt32("AccountId"))
			End If
		End Using
	End Sub
	
	Private Sub Child_Update()
        Using reader As SafeDataReader = DataAccessLayer.Instance.AccountUpdate(ReadProperty(_accountIdProperty), ReadProperty(_emailProperty), ReadProperty(_firstNameProperty), ReadProperty(_lastNameProperty), ReadProperty(_address1Property), ReadProperty(_address2Property), ReadProperty(_cityProperty), ReadProperty(_stateProperty), ReadProperty(_zipProperty), ReadProperty(_countryProperty), ReadProperty(_phoneProperty), ReadProperty(_uniqueIDProperty))
        End Using
	End Sub
	
	Private Sub Child_DeleteSelf()
        DataPortal_Delete(new AccountCriteria(AccountId))
    End Sub
	
    <Transactional(TransactionalTypes.TransactionScope)> _
	Protected Overrides Sub DataPortal_Delete(ByVal criteria As Object)
		Dim theCriteria As AccountCriteria = DirectCast(criteria, AccountCriteria)
        If Not theCriteria Is Nothing Then
			Using reader As SafeDataReader = DataAccessLayer.Instance.AccountDelete(theCriteria.StateBag)
			End Using
		End If
    End Sub
    
	Private Sub Fetch(ByVal reader As SafeDataReader)
		LoadProperty(_accountIdProperty, reader.GetInt32("AccountId"))
		LoadProperty(_emailProperty, reader.GetString("Email"))
		LoadProperty(_firstNameProperty, reader.GetString("FirstName"))
		LoadProperty(_lastNameProperty, reader.GetString("LastName"))
		LoadProperty(_address1Property, reader.GetString("Address1"))
		LoadProperty(_address2Property, reader.GetString("Address2"))
		LoadProperty(_cityProperty, reader.GetString("City"))
		LoadProperty(_stateProperty, reader.GetString("State"))
		LoadProperty(_zipProperty, reader.GetString("Zip"))
		LoadProperty(_countryProperty, reader.GetString("Country"))
		LoadProperty(_phoneProperty, reader.GetString("Phone"))

		LoadProperty(_uniqueIDProperty, reader.GetInt32("UniqueID"))
        MarkAsChild()
        MarkOld()
    End Sub
	
    #End Region
    
End Class