﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contact.DistributedContext.Test.ContactServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseEntityOfint", Namespace="http://schemas.datacontract.org/2004/07/Contacts.Domain")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Contact.DistributedContext.Test.ContactServiceReference.EMailDTO))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Contact.DistributedContext.Test.ContactServiceReference.TelephoneDTO))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Contact.DistributedContext.Test.ContactServiceReference.PhoneTypeDTO))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Contact.DistributedContext.Test.ContactServiceReference.CityDTO))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Contact.DistributedContext.Test.ContactServiceReference.CountryDTO))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Contact.DistributedContext.Test.ContactServiceReference.ContactDTO))]
    public partial class BaseEntityOfint : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EMailDTO", Namespace="http://schemas.datacontract.org/2004/07/Contacts.Application.Aggregates")]
    [System.SerializableAttribute()]
    public partial class EMailDTO : Contact.DistributedContext.Test.ContactServiceReference.BaseEntityOfint {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TelephoneDTO", Namespace="http://schemas.datacontract.org/2004/07/Contacts.Application.Aggregates")]
    [System.SerializableAttribute()]
    public partial class TelephoneDTO : Contact.DistributedContext.Test.ContactServiceReference.BaseEntityOfint {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Contact.DistributedContext.Test.ContactServiceReference.PhoneTypeDTO PhoneTypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Contact.DistributedContext.Test.ContactServiceReference.PhoneTypeDTO PhoneType {
            get {
                return this.PhoneTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneTypeField, value) != true)) {
                    this.PhoneTypeField = value;
                    this.RaisePropertyChanged("PhoneType");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PhoneTypeDTO", Namespace="http://schemas.datacontract.org/2004/07/Contacts.Application.Aggregates")]
    [System.SerializableAttribute()]
    public partial class PhoneTypeDTO : Contact.DistributedContext.Test.ContactServiceReference.BaseEntityOfint {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CityDTO", Namespace="http://schemas.datacontract.org/2004/07/Contacts.Application.ValueObjects")]
    [System.SerializableAttribute()]
    public partial class CityDTO : Contact.DistributedContext.Test.ContactServiceReference.BaseEntityOfint {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Contact.DistributedContext.Test.ContactServiceReference.CountryDTO CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PostalCodeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Contact.DistributedContext.Test.ContactServiceReference.CountryDTO Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostalCode {
            get {
                return this.PostalCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.PostalCodeField, value) != true)) {
                    this.PostalCodeField = value;
                    this.RaisePropertyChanged("PostalCode");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CountryDTO", Namespace="http://schemas.datacontract.org/2004/07/Contacts.Application.ValueObjects")]
    [System.SerializableAttribute()]
    public partial class CountryDTO : Contact.DistributedContext.Test.ContactServiceReference.BaseEntityOfint {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ContactDTO", Namespace="http://schemas.datacontract.org/2004/07/Contacts.Application.Aggregates")]
    [System.SerializableAttribute()]
    public partial class ContactDTO : Contact.DistributedContext.Test.ContactServiceReference.BaseEntityOfint {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Contact.DistributedContext.Test.ContactServiceReference.CityDTO CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Contact.DistributedContext.Test.ContactServiceReference.EMailDTO EMailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Contact.DistributedContext.Test.ContactServiceReference.TelephoneDTO TelephoneField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Contact.DistributedContext.Test.ContactServiceReference.CityDTO City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Contact.DistributedContext.Test.ContactServiceReference.EMailDTO EMail {
            get {
                return this.EMailField;
            }
            set {
                if ((object.ReferenceEquals(this.EMailField, value) != true)) {
                    this.EMailField = value;
                    this.RaisePropertyChanged("EMail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Contact.DistributedContext.Test.ContactServiceReference.TelephoneDTO Telephone {
            get {
                return this.TelephoneField;
            }
            set {
                if ((object.ReferenceEquals(this.TelephoneField, value) != true)) {
                    this.TelephoneField = value;
                    this.RaisePropertyChanged("Telephone");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ContactServiceReference.IContactService")]
    public interface IContactService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/AddContact", ReplyAction="http://tempuri.org/IContactService/AddContactResponse")]
        void AddContact(Contact.DistributedContext.Test.ContactServiceReference.ContactDTO contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/EditContact", ReplyAction="http://tempuri.org/IContactService/EditContactResponse")]
        void EditContact(Contact.DistributedContext.Test.ContactServiceReference.ContactDTO contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/DeleteContact", ReplyAction="http://tempuri.org/IContactService/DeleteContactResponse")]
        void DeleteContact(Contact.DistributedContext.Test.ContactServiceReference.ContactDTO contact);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IContactServiceChannel : Contact.DistributedContext.Test.ContactServiceReference.IContactService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ContactServiceClient : System.ServiceModel.ClientBase<Contact.DistributedContext.Test.ContactServiceReference.IContactService>, Contact.DistributedContext.Test.ContactServiceReference.IContactService {
        
        public ContactServiceClient() {
        }
        
        public ContactServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ContactServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContactServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContactServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddContact(Contact.DistributedContext.Test.ContactServiceReference.ContactDTO contact) {
            base.Channel.AddContact(contact);
        }
        
        public void EditContact(Contact.DistributedContext.Test.ContactServiceReference.ContactDTO contact) {
            base.Channel.EditContact(contact);
        }
        
        public void DeleteContact(Contact.DistributedContext.Test.ContactServiceReference.ContactDTO contact) {
            base.Channel.DeleteContact(contact);
        }
    }
}
