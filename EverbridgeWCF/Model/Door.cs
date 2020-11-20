using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EverbridgeWCF {

    [DataContract]
    public class Door {
        private bool isOpen_;
        private bool isLocked_;

        [DataMember]
        public long id { get; set; }
        [DataMember]
        public String label { get; set; }

        [DataMember]
        public bool isOpen {
            get => isOpen_;
            set {
                if (value && isLocked) throw new ArgumentException("trying to open locked door");
                isOpen_ = value;
            }
        }
        [DataMember]
        public bool isLocked {
            get => isLocked_;
            set {
                if (isOpen && value) throw new ArgumentException("trying to lock opened door");
                isLocked_ = value;
            }
        }

        public Door() { }

        public Door(long id, string label, bool isOpen, bool isLocked) {
            this.id = id;
            this.label = label;
            this.isOpen = isOpen;
            this.isLocked = isLocked;
        }

        public override string ToString() {
            return $"id:{id}\tisLocked:{isLocked}\tisOpen:{isOpen}\tlabel:{label}";
        }

        public override bool Equals(object obj) {
            return obj is Door door &&
                   id.Equals(door.id) &&
                   label == door.label &&
                   isOpen == door.isOpen &&
                   isLocked == door.isLocked;
        }

        public override int GetHashCode() {
            int hashCode = -847107279;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(label);
            hashCode = hashCode * -1521134295 + isOpen.GetHashCode();
            hashCode = hashCode * -1521134295 + isLocked.GetHashCode();
            return hashCode;
        }
    }

}