﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ItemsViewer.SR_Items {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="XItem", Namespace="http://schemas.datacontract.org/2004/07/Shared")]
    [System.SerializableAttribute()]
    public partial class XItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
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
        public int Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SR_Items.IServiceItems")]
    public interface IServiceItems {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceItems/QueryAllItems", ReplyAction="http://tempuri.org/IServiceItems/QueryAllItemsResponse")]
        ItemsViewer.SR_Items.XItem[] QueryAllItems();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceItems/QueryAllItems", ReplyAction="http://tempuri.org/IServiceItems/QueryAllItemsResponse")]
        System.Threading.Tasks.Task<ItemsViewer.SR_Items.XItem[]> QueryAllItemsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceItems/GetCategories", ReplyAction="http://tempuri.org/IServiceItems/GetCategoriesResponse")]
        string[] GetCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceItems/GetCategories", ReplyAction="http://tempuri.org/IServiceItems/GetCategoriesResponse")]
        System.Threading.Tasks.Task<string[]> GetCategoriesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceItemsChannel : ItemsViewer.SR_Items.IServiceItems, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceItemsClient : System.ServiceModel.ClientBase<ItemsViewer.SR_Items.IServiceItems>, ItemsViewer.SR_Items.IServiceItems {
        
        public ServiceItemsClient() {
        }
        
        public ServiceItemsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceItemsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceItemsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceItemsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ItemsViewer.SR_Items.XItem[] QueryAllItems() {
            return base.Channel.QueryAllItems();
        }
        
        public System.Threading.Tasks.Task<ItemsViewer.SR_Items.XItem[]> QueryAllItemsAsync() {
            return base.Channel.QueryAllItemsAsync();
        }
        
        public string[] GetCategories() {
            return base.Channel.GetCategories();
        }
        
        public System.Threading.Tasks.Task<string[]> GetCategoriesAsync() {
            return base.Channel.GetCategoriesAsync();
        }
    }
}