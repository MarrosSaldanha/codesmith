'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.8.X CodeSmith Templates.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'LineItemList.vb.
'
'     Template: EditableRootList.DataAccess.StoredProcedures.cst
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

Public Partial Class LineItemList

    Private Shadows Sub DataPortal_Fetch(ByVal criteria As LineItemCriteria)
        RaiseListChangedEvents = False

        ' Fetch Child objects.
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand("[dbo].[CSLA_LineItem_Select]", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                        Do
                            Me.Add(New LineItem(reader))
                        Loop While reader.Read()
                    Else
                        Throw New Exception(String.Format("The record was not found in 'LineItem' using the following criteria: {0}.", criteria))
                    End If
                End Using
            End Using
        End Using

        RaiseListChangedEvents = True
    End Sub

    Protected Overrides Sub DataPortal_Update()
        Child_Update()
    End Sub

End Class