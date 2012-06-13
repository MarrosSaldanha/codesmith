﻿#pragma warning disable 1591
#pragma warning disable 0414        
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using Petshop.Data;

namespace Petshop.Data.Entities
{
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.Diagnostics.DebuggerDisplay("SuppId: {SuppId}")]
    public partial class Supplier : EntityBase
    {
        #region Static Constructor
        
        /// <summary>
        /// Initializes the <see cref="Account"/> class.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        static Supplier()
        {
            AddSharedRules();
        }
        
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public Supplier()
        {
            Initialize();
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        protected override void Initialize()
        {
            OnCreated();
        }
        
        #endregion
        
        #region Column Mapped Properties
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Int32 _suppId;
        
        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.Int32 SuppId
        {
            get { return _suppId; }
            set
            {
                OnSuppIdChanging(value, _suppId);
                SendPropertyChanging("SuppId");
                _suppId = value;
                SendPropertyChanged("SuppId");
                OnSuppIdChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _name;
        
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String Name
        {
            get { return _name; }
            set
            {
                OnNameChanging(value, _name);
                SendPropertyChanging("Name");
                _name = value;
                SendPropertyChanged("Name");
                OnNameChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _status;
        
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String Status
        {
            get { return _status; }
            set
            {
                OnStatusChanging(value, _status);
                SendPropertyChanging("Status");
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _addr1;
        
        [System.Runtime.Serialization.DataMember(Order = 4)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String Addr1
        {
            get { return _addr1; }
            set
            {
                OnAddr1Changing(value, _addr1);
                SendPropertyChanging("Addr1");
                _addr1 = value;
                SendPropertyChanged("Addr1");
                OnAddr1Changed(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _addr2;
        
        [System.Runtime.Serialization.DataMember(Order = 5)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String Addr2
        {
            get { return _addr2; }
            set
            {
                OnAddr2Changing(value, _addr2);
                SendPropertyChanging("Addr2");
                _addr2 = value;
                SendPropertyChanged("Addr2");
                OnAddr2Changed(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _city;
        
        [System.Runtime.Serialization.DataMember(Order = 6)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String City
        {
            get { return _city; }
            set
            {
                OnCityChanging(value, _city);
                SendPropertyChanging("City");
                _city = value;
                SendPropertyChanged("City");
                OnCityChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _state;
        
        [System.Runtime.Serialization.DataMember(Order = 7)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String State
        {
            get { return _state; }
            set
            {
                OnStateChanging(value, _state);
                SendPropertyChanging("State");
                _state = value;
                SendPropertyChanged("State");
                OnStateChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _zip;
        
        [System.Runtime.Serialization.DataMember(Order = 8)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String Zip
        {
            get { return _zip; }
            set
            {
                OnZipChanging(value, _zip);
                SendPropertyChanging("Zip");
                _zip = value;
                SendPropertyChanged("Zip");
                OnZipChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _phone;
        
        [System.Runtime.Serialization.DataMember(Order = 9)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String Phone
        {
            get { return _phone; }
            set
            {
                OnPhoneChanging(value, _phone);
                SendPropertyChanging("Phone");
                _phone = value;
                SendPropertyChanged("Phone");
                OnPhoneChanged(value);
            }
        }
        
        #endregion
        
        #region Associations Mappings
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private IList<Item> _itemList;
        
        [System.Runtime.Serialization.DataMember(Order = 10, EmitDefaultValue = false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual IList<Item> ItemList
        {
            get { return _itemList; }
            set
            {
                OnItemListChanging(value, _itemList);
                SendPropertyChanging("ItemList");
                _itemList = value;
                SendPropertyChanged("ItemList");
                OnItemListChanged(value);
            }
        }
        
        #endregion
        
        #region Extensibility Method
        
        static partial void AddSharedRules();
        
        partial void OnCreated();
        
        partial void OnSuppIdChanging(System.Int32 newValue, System.Int32 oldValue);
        
        partial void OnSuppIdChanged(System.Int32 value);
        
        partial void OnNameChanging(System.String newValue, System.String oldValue);
        
        partial void OnNameChanged(System.String value);
        
        partial void OnStatusChanging(System.String newValue, System.String oldValue);
        
        partial void OnStatusChanged(System.String value);
        
        partial void OnAddr1Changing(System.String newValue, System.String oldValue);
        
        partial void OnAddr1Changed(System.String value);
        
        partial void OnAddr2Changing(System.String newValue, System.String oldValue);
        
        partial void OnAddr2Changed(System.String value);
        
        partial void OnCityChanging(System.String newValue, System.String oldValue);
        
        partial void OnCityChanged(System.String value);
        
        partial void OnStateChanging(System.String newValue, System.String oldValue);
        
        partial void OnStateChanged(System.String value);
        
        partial void OnZipChanging(System.String newValue, System.String oldValue);
        
        partial void OnZipChanged(System.String value);
        
        partial void OnPhoneChanging(System.String newValue, System.String oldValue);
        
        partial void OnPhoneChanged(System.String value);
        
        
        partial void OnItemListChanging(IList<Item> newValue, IList<Item> oldValue);
        
        partial void OnItemListChanged(IList<Item> value);
        
        #endregion
        
        #region Clone
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual Supplier Clone()
        {
            return (Supplier)((ICloneable)this).Clone();
        }
        
        #endregion
        
        #region Serialization
        
        /// <summary>
        /// Deserializes an instance of <see cref="Account"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="Account"/> instance.</param>
        /// <returns>An instance of <see cref="Account"/> that is deserialized from the XML String.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static Supplier FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Supplier));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as Supplier;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Account"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="Account"/> instance.</param>
        /// <returns>An instance of <see cref="Account"/> that is deserialized from the byte array.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static Supplier FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Supplier));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as Supplier;
            }
        }
        
        #endregion
    }
}

#pragma warning restore 1591
#pragma warning restore 0414
