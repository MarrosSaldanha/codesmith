﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a CodeSmith Template.
'
'     DO Not MODIfY contents of this file. Changes to this
'     file will be lost if the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------
Imports System
Imports System.Linq

Namespace Tracker.Core.Data
    ''' <summary>
    ''' Class representing data for the Tracker database.
    ''' </summary>
    
    <System.Runtime.Serialization.DataContract(IsReference:=True)> _
    <System.ComponentModel.DataAnnotations.ScaffoldTable(True)> _
    <System.ComponentModel.DataAnnotations.MetadataType(GetType(GetUsersWithRolesResult1.Metadata))> _
    Partial Public Class GetUsersWithRolesResult1

#Region "Static Constructor"
        ''' <summary>
        ''' Initializes the <see cref="GetUsersWithRolesResult1"/> class.
        ''' </summary>
        Shared Sub New()
            AddSharedRules()
        End Sub
#End Region

#Region "Default Constructor"
        ''' <summary>
        ''' Initializes a new instance of the <see cref="GetUsersWithRolesResult1"/> class.
        ''' </summary>
        <System.Diagnostics.DebuggerNonUserCode()> _
        Public Sub New()
            Initialize()
        End Sub

        Private Sub Initialize()
            OnCreated()
        End Sub
#End Region

#Region "Column Mapped Properties"

        Private _id As Integer

        ''' <summary>
        ''' Gets or sets the Id column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="Id", Storage:="_id", DbType:="int NOT NULL", CanBeNull:=False, UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)> _
        <System.Runtime.Serialization.DataMember(Order:=1)> _
        Public Property Id() As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                If ((Me._id = value) = False) Then
                    OnIdChanging(value)
                    _id = value
                    OnIdChanged()
                End If
            End Set
        End Property

        Private _emailAddress As String

        ''' <summary>
        ''' Gets or sets the EmailAddress column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="EmailAddress", Storage:="_emailAddress", DbType:="nvarchar(250) NOT NULL", CanBeNull:=False, UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)> _
        <ComponentModel.DataAnnotations.StringLength(250)> _
        <System.Runtime.Serialization.DataMember(Order:=2)> _
        Public Property EmailAddress() As String
            Get
                Return _emailAddress
            End Get
            Set(ByVal value As String)
                If (String.Equals(Me._emailAddress, value) = False) Then
                    OnEmailAddressChanging(value)
                    _emailAddress = value
                    OnEmailAddressChanged()
                End If
            End Set
        End Property

        Private _firstName As String

        ''' <summary>
        ''' Gets or sets the FirstName column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="FirstName", Storage:="_firstName", DbType:="nvarchar(200)", UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)> _
        <ComponentModel.DataAnnotations.StringLength(200)> _
        <System.Runtime.Serialization.DataMember(Order:=3)> _
        Public Property FirstName() As String
            Get
                Return _firstName
            End Get
            Set(ByVal value As String)
                If (String.Equals(Me._firstName, value) = False) Then
                    OnFirstNameChanging(value)
                    _firstName = value
                    OnFirstNameChanged()
                End If
            End Set
        End Property

        Private _lastName As String

        ''' <summary>
        ''' Gets or sets the LastName column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="LastName", Storage:="_lastName", DbType:="nvarchar(200)", UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)> _
        <ComponentModel.DataAnnotations.StringLength(200)> _
        <System.Runtime.Serialization.DataMember(Order:=4)> _
        Public Property LastName() As String
            Get
                Return _lastName
            End Get
            Set(ByVal value As String)
                If (String.Equals(Me._lastName, value) = False) Then
                    OnLastNameChanging(value)
                    _lastName = value
                    OnLastNameChanged()
                End If
            End Set
        End Property

        Private _avatar As System.Data.Linq.Binary

        ''' <summary>
        ''' Gets or sets the Avatar column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="Avatar", Storage:="_avatar", DbType:="varbinary(MAX)", UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)> _
        <System.Runtime.Serialization.DataMember(Order:=5)> _
        Public Property Avatar() As System.Data.Linq.Binary
            Get
                Return _avatar
            End Get
            Set(ByVal value As System.Data.Linq.Binary)
                If (Object.Equals(Me._avatar, value) = False) Then
                    OnAvatarChanging(value)
                    _avatar = value
                    OnAvatarChanged()
                End If
            End Set
        End Property

        Private _createdDate As Date

        ''' <summary>
        ''' Gets or sets the CreatedDate column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="CreatedDate", Storage:="_createdDate", DbType:="datetime NOT NULL", CanBeNull:=False, UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)> _
        <System.Runtime.Serialization.DataMember(Order:=6)> _
        Public Property CreatedDate() As Date
            Get
                Return _createdDate
            End Get
            Set(ByVal value As Date)
                If ((Me._createdDate = value) = False) Then
                    OnCreatedDateChanging(value)
                    _createdDate = value
                    OnCreatedDateChanged()
                End If
            End Set
        End Property

        Private _modifiedDate As Date

        ''' <summary>
        ''' Gets or sets the ModifiedDate column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="ModifiedDate", Storage:="_modifiedDate", DbType:="datetime NOT NULL", CanBeNull:=False, UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)> _
        <System.Runtime.Serialization.DataMember(Order:=7)> _
        Public Property ModifiedDate() As Date
            Get
                Return _modifiedDate
            End Get
            Set(ByVal value As Date)
                If ((Me._modifiedDate = value) = False) Then
                    OnModifiedDateChanging(value)
                    _modifiedDate = value
                    OnModifiedDateChanged()
                End If
            End Set
        End Property

        Private _rowVersion As System.Data.Linq.Binary = Nothing

        ''' <summary>
        ''' Gets the RowVersion column value.
        ''' </summary>
        <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
        <System.Data.Linq.Mapping.Column(Name:="RowVersion", Storage:="_rowVersion", DbType:="timestamp NOT NULL", IsDbGenerated:=True, IsVersion:=True, CanBeNull:=False, UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)> _
        <System.Runtime.Serialization.DataMember(Order:=8)> _
        Public Property RowVersion() As System.Data.Linq.Binary
            Get
                Return _rowVersion
            End Get
            Set(ByVal value As System.Data.Linq.Binary)
                If (Object.Equals(Me._rowVersion, value) = False) Then
                    OnRowVersionChanging(value)
                    _rowVersion = value
                    OnRowVersionChanged()
                End If
            End Set
        End Property

        Private _passwordHash As String

        ''' <summary>
        ''' Gets or sets the PasswordHash column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="PasswordHash", Storage:="_passwordHash", DbType:="char(86) NOT NULL", CanBeNull:=False, UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)> _
        <ComponentModel.DataAnnotations.StringLength(86)> _
        <System.Runtime.Serialization.DataMember(Order:=9)> _
        Public Property PasswordHash() As String
            Get
                Return _passwordHash
            End Get
            Set(ByVal value As String)
                If (String.Equals(Me._passwordHash, value) = False) Then
                    OnPasswordHashChanging(value)
                    _passwordHash = value
                    OnPasswordHashChanged()
                End If
            End Set
        End Property

        Private _passwordSalt As String

        ''' <summary>
        ''' Gets or sets the PasswordSalt column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="PasswordSalt", Storage:="_passwordSalt", DbType:="char(5) NOT NULL", CanBeNull:=False, UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)> _
        <ComponentModel.DataAnnotations.StringLength(5)> _
        <System.Runtime.Serialization.DataMember(Order:=10)> _
        Public Property PasswordSalt() As String
            Get
                Return _passwordSalt
            End Get
            Set(ByVal value As String)
                If (String.Equals(Me._passwordSalt, value) = False) Then
                    OnPasswordSaltChanging(value)
                    _passwordSalt = value
                    OnPasswordSaltChanged()
                End If
            End Set
        End Property

        Private _comment As String

        ''' <summary>
        ''' Gets or sets the Comment column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="Comment", Storage:="_comment", DbType:="text", UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)> _
        <System.Runtime.Serialization.DataMember(Order:=11)> _
        Public Property Comment() As String
            Get
                Return _comment
            End Get
            Set(ByVal value As String)
                If (String.Equals(Me._comment, value) = False) Then
                    OnCommentChanging(value)
                    _comment = value
                    OnCommentChanged()
                End If
            End Set
        End Property

        Private _isApproved As Boolean

        ''' <summary>
        ''' Gets or sets the IsApproved column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="IsApproved", Storage:="_isApproved", DbType:="bit NOT NULL", CanBeNull:=False, UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)> _
        <System.Runtime.Serialization.DataMember(Order:=12)> _
        Public Property IsApproved() As Boolean
            Get
                Return _isApproved
            End Get
            Set(ByVal value As Boolean)
                If ((Me._isApproved = value) = False) Then
                    OnIsApprovedChanging(value)
                    _isApproved = value
                    OnIsApprovedChanged()
                End If
            End Set
        End Property

        Private _lastLoginDate As Nullable(Of Date)

        ''' <summary>
        ''' Gets or sets the LastLoginDate column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="LastLoginDate", Storage:="_lastLoginDate", DbType:="datetime", UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)> _
        <System.Runtime.Serialization.DataMember(Order:=13)> _
        Public Property LastLoginDate() As Nullable(Of Date)
            Get
                Return _lastLoginDate
            End Get
            Set(ByVal value As Nullable(Of Date))
                If (Me._lastLoginDate.Equals(value) = False) Then
                    OnLastLoginDateChanging(value)
                    _lastLoginDate = value
                    OnLastLoginDateChanged()
                End If
            End Set
        End Property

        Private _lastActivityDate As Date

        ''' <summary>
        ''' Gets or sets the LastActivityDate column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="LastActivityDate", Storage:="_lastActivityDate", DbType:="datetime NOT NULL", CanBeNull:=False, UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)> _
        <System.Runtime.Serialization.DataMember(Order:=14)> _
        Public Property LastActivityDate() As Date
            Get
                Return _lastActivityDate
            End Get
            Set(ByVal value As Date)
                If ((Me._lastActivityDate = value) = False) Then
                    OnLastActivityDateChanging(value)
                    _lastActivityDate = value
                    OnLastActivityDateChanged()
                End If
            End Set
        End Property

        Private _lastPasswordChangeDate As Nullable(Of Date)

        ''' <summary>
        ''' Gets or sets the LastPasswordChangeDate column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="LastPasswordChangeDate", Storage:="_lastPasswordChangeDate", DbType:="datetime", UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)> _
        <System.Runtime.Serialization.DataMember(Order:=15)> _
        Public Property LastPasswordChangeDate() As Nullable(Of Date)
            Get
                Return _lastPasswordChangeDate
            End Get
            Set(ByVal value As Nullable(Of Date))
                If (Me._lastPasswordChangeDate.Equals(value) = False) Then
                    OnLastPasswordChangeDateChanging(value)
                    _lastPasswordChangeDate = value
                    OnLastPasswordChangeDateChanged()
                End If
            End Set
        End Property

        Private _avatarType As String

        ''' <summary>
        ''' Gets or sets the AvatarType column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="AvatarType", Storage:="_avatarType", DbType:="nvarchar(150)", UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)> _
        <ComponentModel.DataAnnotations.StringLength(150)> _
        <System.Runtime.Serialization.DataMember(Order:=16)> _
        Public Property AvatarType() As String
            Get
                Return _avatarType
            End Get
            Set(ByVal value As String)
                If (String.Equals(Me._avatarType, value) = False) Then
                    OnAvatarTypeChanging(value)
                    _avatarType = value
                    OnAvatarTypeChanged()
                End If
            End Set
        End Property
#End Region

#Region "Association Mapped Properties"

#End Region

#Region "Extensibility Method Definitions"

        ''' <summary>Called by the Shared constructor to add shared rules.</summary>
        Partial Private Shared Sub AddSharedRules()
        End Sub
        ''' <summary>Called when this instance is loaded.</summary>
        Partial Private Sub OnLoaded()
        End Sub
        ''' <summary>Called when this instance is being saved.</summary>
        Partial Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
        End Sub
        ''' <summary>Called when this instance is created.</summary>
        Partial Private Sub OnCreated()
        End Sub
        ''' <summary>Called when Id is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnIdChanging(ByVal value As Integer)
        End Sub
        ''' <summary>Called after Id has Changed.</summary>
        Partial Private Sub OnIdChanged()
        End Sub
        ''' <summary>Called when EmailAddress is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnEmailAddressChanging(ByVal value As String)
        End Sub
        ''' <summary>Called after EmailAddress has Changed.</summary>
        Partial Private Sub OnEmailAddressChanged()
        End Sub
        ''' <summary>Called when FirstName is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnFirstNameChanging(ByVal value As String)
        End Sub
        ''' <summary>Called after FirstName has Changed.</summary>
        Partial Private Sub OnFirstNameChanged()
        End Sub
        ''' <summary>Called when LastName is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnLastNameChanging(ByVal value As String)
        End Sub
        ''' <summary>Called after LastName has Changed.</summary>
        Partial Private Sub OnLastNameChanged()
        End Sub
        ''' <summary>Called when Avatar is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnAvatarChanging(ByVal value As System.Data.Linq.Binary)
        End Sub
        ''' <summary>Called after Avatar has Changed.</summary>
        Partial Private Sub OnAvatarChanged()
        End Sub
        ''' <summary>Called when CreatedDate is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnCreatedDateChanging(ByVal value As Date)
        End Sub
        ''' <summary>Called after CreatedDate has Changed.</summary>
        Partial Private Sub OnCreatedDateChanged()
        End Sub
        ''' <summary>Called when ModifiedDate is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnModifiedDateChanging(ByVal value As Date)
        End Sub
        ''' <summary>Called after ModifiedDate has Changed.</summary>
        Partial Private Sub OnModifiedDateChanged()
        End Sub
        ''' <summary>Called when RowVersion is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnRowVersionChanging(ByVal value As System.Data.Linq.Binary)
        End Sub
        ''' <summary>Called after RowVersion has Changed.</summary>
        Partial Private Sub OnRowVersionChanged()
        End Sub
        ''' <summary>Called when PasswordHash is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnPasswordHashChanging(ByVal value As String)
        End Sub
        ''' <summary>Called after PasswordHash has Changed.</summary>
        Partial Private Sub OnPasswordHashChanged()
        End Sub
        ''' <summary>Called when PasswordSalt is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnPasswordSaltChanging(ByVal value As String)
        End Sub
        ''' <summary>Called after PasswordSalt has Changed.</summary>
        Partial Private Sub OnPasswordSaltChanged()
        End Sub
        ''' <summary>Called when Comment is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnCommentChanging(ByVal value As String)
        End Sub
        ''' <summary>Called after Comment has Changed.</summary>
        Partial Private Sub OnCommentChanged()
        End Sub
        ''' <summary>Called when IsApproved is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnIsApprovedChanging(ByVal value As Boolean)
        End Sub
        ''' <summary>Called after IsApproved has Changed.</summary>
        Partial Private Sub OnIsApprovedChanged()
        End Sub
        ''' <summary>Called when LastLoginDate is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnLastLoginDateChanging(ByVal value As Nullable(Of Date))
        End Sub
        ''' <summary>Called after LastLoginDate has Changed.</summary>
        Partial Private Sub OnLastLoginDateChanged()
        End Sub
        ''' <summary>Called when LastActivityDate is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnLastActivityDateChanging(ByVal value As Date)
        End Sub
        ''' <summary>Called after LastActivityDate has Changed.</summary>
        Partial Private Sub OnLastActivityDateChanged()
        End Sub
        ''' <summary>Called when LastPasswordChangeDate is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnLastPasswordChangeDateChanging(ByVal value As Nullable(Of Date))
        End Sub
        ''' <summary>Called after LastPasswordChangeDate has Changed.</summary>
        Partial Private Sub OnLastPasswordChangeDateChanged()
        End Sub
        ''' <summary>Called when AvatarType is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnAvatarTypeChanging(ByVal value As String)
        End Sub
        ''' <summary>Called after AvatarType has Changed.</summary>
        Partial Private Sub OnAvatarTypeChanged()
        End Sub
#End Region

#Region "Serialization"

        Private serializing As Boolean

        ''' <summary>
        ''' Called when serializing.
        ''' </summary>
        ''' <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        <System.Runtime.Serialization.OnSerializing(), _
         System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> _
        Public Sub OnSerializing(ByVal context As System.Runtime.Serialization.StreamingContext)
            serializing = True
        End Sub

        ''' <summary>
        ''' Called when serializing.
        ''' </summary>
        ''' <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        <System.Runtime.Serialization.OnSerialized(), _
         System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> _
        Public Sub OnSerialized(ByVal context As System.Runtime.Serialization.StreamingContext)
            serializing = False
        End Sub

        ''' <summary>
        ''' Called when deserializing.
        ''' </summary>
        ''' <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        <System.Runtime.Serialization.OnDeserializing(), _
         System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> _
        Public Sub OnDeserializing(ByVal context As System.Runtime.Serialization.StreamingContext)
            Initialize()
        End Sub
        
        ''' <summary>
        ''' Deserializes an instance of <see cref="GetUsersWithRolesResult1"/> from XML.
        ''' </summary>
        ''' <param name="xml">The XML string representing a <see cref="GetUsersWithRolesResult1"/> instance.</param>
        ''' <returns>An instance of <see cref="GetUsersWithRolesResult1"/> that is deserialized from the XML string.</returns>
        Public Shared Function FromXml(ByVal xml As String) As GetUsersWithRolesResult1
            Dim deserializer = New System.Runtime.Serialization.DataContractSerializer(GetType(GetUsersWithRolesResult1))
            
            Using sr = New System.IO.StringReader(xml)
                Using reader = System.Xml.XmlReader.Create(sr)
                    Return TryCast(deserializer.ReadObject(reader), GetUsersWithRolesResult1)
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Deserializes an instance of <see cref="GetUsersWithRolesResult1"/>.
        ''' </summary>
        ''' <param name="buffer">The byte array representing a <see cref="GetUsersWithRolesResult1"/> instance.</param>
        ''' <returns>An instance of <see cref="GetUsersWithRolesResult1"/> that is deserialized from the byte array.</returns>
        Public Shared Function FromBinary(ByVal buffer As Byte()) As GetUsersWithRolesResult1
            Dim deserializer = New System.Runtime.Serialization.DataContractSerializer(GetType(GetUsersWithRolesResult1))

            Using ms = New System.IO.MemoryStream(buffer)
                Using reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max)
                    Return TryCast(deserializer.ReadObject(reader), GetUsersWithRolesResult1)
                End Using
            End Using
        End Function
#End Region
    End Class
End Namespace

