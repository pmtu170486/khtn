﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyConsole.EmployeeServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NhanVien", Namespace="http://schemas.datacontract.org/2004/07/wsEmployees.dao")]
    [System.SerializableAttribute()]
    public partial class NhanVien : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeServices.IEmployeeSer")]
    public interface IEmployeeSer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeSer/getall", ReplyAction="http://tempuri.org/IEmployeeSer/getallResponse")]
        MyConsole.EmployeeServices.NhanVien[] getall();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeSer/getall", ReplyAction="http://tempuri.org/IEmployeeSer/getallResponse")]
        System.Threading.Tasks.Task<MyConsole.EmployeeServices.NhanVien[]> getallAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeSer/create", ReplyAction="http://tempuri.org/IEmployeeSer/createResponse")]
        void create(MyConsole.EmployeeServices.NhanVien nv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeSer/create", ReplyAction="http://tempuri.org/IEmployeeSer/createResponse")]
        System.Threading.Tasks.Task createAsync(MyConsole.EmployeeServices.NhanVien nv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeSer/delete", ReplyAction="http://tempuri.org/IEmployeeSer/deleteResponse")]
        void delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeSer/delete", ReplyAction="http://tempuri.org/IEmployeeSer/deleteResponse")]
        System.Threading.Tasks.Task deleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeSer/update", ReplyAction="http://tempuri.org/IEmployeeSer/updateResponse")]
        void update(MyConsole.EmployeeServices.NhanVien nv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeSer/update", ReplyAction="http://tempuri.org/IEmployeeSer/updateResponse")]
        System.Threading.Tasks.Task updateAsync(MyConsole.EmployeeServices.NhanVien nv);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeSerChannel : MyConsole.EmployeeServices.IEmployeeSer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeSerClient : System.ServiceModel.ClientBase<MyConsole.EmployeeServices.IEmployeeSer>, MyConsole.EmployeeServices.IEmployeeSer {
        
        public EmployeeSerClient() {
        }
        
        public EmployeeSerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeSerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeSerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeSerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MyConsole.EmployeeServices.NhanVien[] getall() {
            return base.Channel.getall();
        }
        
        public System.Threading.Tasks.Task<MyConsole.EmployeeServices.NhanVien[]> getallAsync() {
            return base.Channel.getallAsync();
        }
        
        public void create(MyConsole.EmployeeServices.NhanVien nv) {
            base.Channel.create(nv);
        }
        
        public System.Threading.Tasks.Task createAsync(MyConsole.EmployeeServices.NhanVien nv) {
            return base.Channel.createAsync(nv);
        }
        
        public void delete(int id) {
            base.Channel.delete(id);
        }
        
        public System.Threading.Tasks.Task deleteAsync(int id) {
            return base.Channel.deleteAsync(id);
        }
        
        public void update(MyConsole.EmployeeServices.NhanVien nv) {
            base.Channel.update(nv);
        }
        
        public System.Threading.Tasks.Task updateAsync(MyConsole.EmployeeServices.NhanVien nv) {
            return base.Channel.updateAsync(nv);
        }
    }
}