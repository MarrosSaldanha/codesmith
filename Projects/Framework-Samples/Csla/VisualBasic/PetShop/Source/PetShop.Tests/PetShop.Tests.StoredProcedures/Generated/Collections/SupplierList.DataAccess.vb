﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v2.0.0.1440, CSLA Framework: v3.8.2.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'SupplierList.vb.
'
'     Template: EditableChildList.DataAccess.StoredProcedures.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Csla
Imports Csla.Data
Imports Csla.Validation

Public Partial Class SupplierList

    Protected Overrides Sub Child_Create()
        Dim cancel As Boolean = False
        OnCreating(cancel)
        If (cancel) Then
            Return
        End If

        OnCreated()
    End Sub

    Private Shadows Sub Child_Fetch(ByVal criteria As SupplierCriteria)
        Dim cancel As Boolean = False
        OnFetching(criteria, cancel)
        If (cancel) Then
            Return
        End If

        RaiseListChangedEvents = False

        ' Fetch Child objects.
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand("[dbo].[CSLA_Supplier_Select]", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                command.Parameters.AddWithValue("@p_NameHasValue", criteria.NameHasValue)
				command.Parameters.AddWithValue("@p_Addr1HasValue", criteria.Addr1HasValue)
				command.Parameters.AddWithValue("@p_Addr2HasValue", criteria.Addr2HasValue)
				command.Parameters.AddWithValue("@p_CityHasValue", criteria.CityHasValue)
				command.Parameters.AddWithValue("@p_StateHasValue", criteria.StateHasValue)
				command.Parameters.AddWithValue("@p_ZipHasValue", criteria.ZipHasValue)
				command.Parameters.AddWithValue("@p_PhoneHasValue", criteria.PhoneHasValue)
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                        Do
                            Me.Add(New Supplier(reader))
                        Loop While reader.Read()
                    Else
                        Throw New Exception(String.Format("The record was not found in 'Supplier' using the following criteria: {0}.", criteria))
                    End If
                End Using
            End Using
        End Using

        RaiseListChangedEvents = True

        OnFetched()
    End Sub

    Protected Overrides Sub DataPortal_Update()
        Child_Update()
    End Sub
    
    #Region "Data access partial methods"

    Partial Private Sub OnCreating(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnFetching(ByVal criteria As SupplierCriteria, ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnFetched()
    End Sub
    Partial Private Sub OnMapping(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnMapped()
    End Sub
    
    #End Region
End Class