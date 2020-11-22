﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EverbridgeClientSide.DoorServiceNamespace {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Door", Namespace="http://schemas.datacontract.org/2004/07/EverbridgeWCF")]
    [System.SerializableAttribute()]
    public partial class Door : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool isLockedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool isOpenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string labelField;
        
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
        public long id {
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
        public bool isLocked {
            get {
                return this.isLockedField;
            }
            set {
                if ((this.isLockedField.Equals(value) != true)) {
                    this.isLockedField = value;
                    this.RaisePropertyChanged("isLocked");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isOpen {
            get {
                return this.isOpenField;
            }
            set {
                if ((this.isOpenField.Equals(value) != true)) {
                    this.isOpenField = value;
                    this.RaisePropertyChanged("isOpen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string label {
            get {
                return this.labelField;
            }
            set {
                if ((object.ReferenceEquals(this.labelField, value) != true)) {
                    this.labelField = value;
                    this.RaisePropertyChanged("label");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DoorServiceNamespace.IDoorService", CallbackContract=typeof(EverbridgeClientSide.DoorServiceNamespace.IDoorServiceCallback))]
    public interface IDoorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoorService/addNewDoor", ReplyAction="http://tempuri.org/IDoorService/addNewDoorResponse")]
        bool addNewDoor(string label);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoorService/addNewDoor", ReplyAction="http://tempuri.org/IDoorService/addNewDoorResponse")]
        System.Threading.Tasks.Task<bool> addNewDoorAsync(string label);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoorService/closeDoor", ReplyAction="http://tempuri.org/IDoorService/closeDoorResponse")]
        bool closeDoor(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoorService/closeDoor", ReplyAction="http://tempuri.org/IDoorService/closeDoorResponse")]
        System.Threading.Tasks.Task<bool> closeDoorAsync(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoorService/getAllDoors", ReplyAction="http://tempuri.org/IDoorService/getAllDoorsResponse")]
        EverbridgeClientSide.DoorServiceNamespace.Door[] getAllDoors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoorService/getAllDoors", ReplyAction="http://tempuri.org/IDoorService/getAllDoorsResponse")]
        System.Threading.Tasks.Task<EverbridgeClientSide.DoorServiceNamespace.Door[]> getAllDoorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoorService/getDoor", ReplyAction="http://tempuri.org/IDoorService/getDoorResponse")]
        EverbridgeClientSide.DoorServiceNamespace.Door getDoor(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoorService/getDoor", ReplyAction="http://tempuri.org/IDoorService/getDoorResponse")]
        System.Threading.Tasks.Task<EverbridgeClientSide.DoorServiceNamespace.Door> getDoorAsync(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoorService/lockDoor", ReplyAction="http://tempuri.org/IDoorService/lockDoorResponse")]
        bool lockDoor(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoorService/lockDoor", ReplyAction="http://tempuri.org/IDoorService/lockDoorResponse")]
        System.Threading.Tasks.Task<bool> lockDoorAsync(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoorService/openDoor", ReplyAction="http://tempuri.org/IDoorService/openDoorResponse")]
        bool openDoor(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoorService/openDoor", ReplyAction="http://tempuri.org/IDoorService/openDoorResponse")]
        System.Threading.Tasks.Task<bool> openDoorAsync(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoorService/removeDoor", ReplyAction="http://tempuri.org/IDoorService/removeDoorResponse")]
        bool removeDoor(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoorService/removeDoor", ReplyAction="http://tempuri.org/IDoorService/removeDoorResponse")]
        System.Threading.Tasks.Task<bool> removeDoorAsync(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoorService/unlockDoor", ReplyAction="http://tempuri.org/IDoorService/unlockDoorResponse")]
        bool unlockDoor(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoorService/unlockDoor", ReplyAction="http://tempuri.org/IDoorService/unlockDoorResponse")]
        System.Threading.Tasks.Task<bool> unlockDoorAsync(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoorService/updateDoorLabel", ReplyAction="http://tempuri.org/IDoorService/updateDoorLabelResponse")]
        bool updateDoorLabel(long id, string label);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoorService/updateDoorLabel", ReplyAction="http://tempuri.org/IDoorService/updateDoorLabelResponse")]
        System.Threading.Tasks.Task<bool> updateDoorLabelAsync(long id, string label);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDoorServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDoorService/notifyUserOnChange")]
        void notifyUserOnChange();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDoorServiceChannel : EverbridgeClientSide.DoorServiceNamespace.IDoorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DoorServiceClient : System.ServiceModel.DuplexClientBase<EverbridgeClientSide.DoorServiceNamespace.IDoorService>, EverbridgeClientSide.DoorServiceNamespace.IDoorService {
        
        public DoorServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public DoorServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public DoorServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public DoorServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public DoorServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public bool addNewDoor(string label) {
            return base.Channel.addNewDoor(label);
        }
        
        public System.Threading.Tasks.Task<bool> addNewDoorAsync(string label) {
            return base.Channel.addNewDoorAsync(label);
        }
        
        public bool closeDoor(long id) {
            return base.Channel.closeDoor(id);
        }
        
        public System.Threading.Tasks.Task<bool> closeDoorAsync(long id) {
            return base.Channel.closeDoorAsync(id);
        }
        
        public EverbridgeClientSide.DoorServiceNamespace.Door[] getAllDoors() {
            return base.Channel.getAllDoors();
        }
        
        public System.Threading.Tasks.Task<EverbridgeClientSide.DoorServiceNamespace.Door[]> getAllDoorsAsync() {
            return base.Channel.getAllDoorsAsync();
        }
        
        public EverbridgeClientSide.DoorServiceNamespace.Door getDoor(long id) {
            return base.Channel.getDoor(id);
        }
        
        public System.Threading.Tasks.Task<EverbridgeClientSide.DoorServiceNamespace.Door> getDoorAsync(long id) {
            return base.Channel.getDoorAsync(id);
        }
        
        public bool lockDoor(long id) {
            return base.Channel.lockDoor(id);
        }
        
        public System.Threading.Tasks.Task<bool> lockDoorAsync(long id) {
            return base.Channel.lockDoorAsync(id);
        }
        
        public bool openDoor(long id) {
            return base.Channel.openDoor(id);
        }
        
        public System.Threading.Tasks.Task<bool> openDoorAsync(long id) {
            return base.Channel.openDoorAsync(id);
        }
        
        public bool removeDoor(long id) {
            return base.Channel.removeDoor(id);
        }
        
        public System.Threading.Tasks.Task<bool> removeDoorAsync(long id) {
            return base.Channel.removeDoorAsync(id);
        }
        
        public bool unlockDoor(long id) {
            return base.Channel.unlockDoor(id);
        }
        
        public System.Threading.Tasks.Task<bool> unlockDoorAsync(long id) {
            return base.Channel.unlockDoorAsync(id);
        }
        
        public bool updateDoorLabel(long id, string label) {
            return base.Channel.updateDoorLabel(id, label);
        }
        
        public System.Threading.Tasks.Task<bool> updateDoorLabelAsync(long id, string label) {
            return base.Channel.updateDoorLabelAsync(id, label);
        }
    }
}
