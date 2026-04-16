using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SigniFlow.Connect.Model
{
    [DataContract(Name = "PlaceholderInfoField")]
    public class PlaceholderInfoField : IEquatable<PlaceholderInfoField>
    {
        [DataMember(Name = "AccessListField")]
        public List<FullWorkFlowRequestAccessField>? FullWorkFlowRequestAccessField { get; set; }

        [DataMember(Name = "AllowMultipleField")]
        public bool AllowMultiple { get; set; }

        [DataMember(Name = "DocumentNameField")]
        public string DocumentName { get; set; }

        [DataMember(Name = "ForceUploadField")]
        public bool ForceUpload { get; set; }

        [DataMember(Name = "PlaceholderGroupIDField")]
        public string PlaceholderGroupID { get; set; }

        [DataMember(Name = "SendNotificationField")]
        public bool SendNotification { get; set; }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = 41;

                if (this.FullWorkFlowRequestAccessField != null)
                {
                    foreach (var item in this.FullWorkFlowRequestAccessField)
                    {
                        hashCode = hashCode * 59 + item.GetHashCode();
                    }
                }
                
                hashCode = hashCode * 59 + this.AllowMultiple.GetHashCode();
                hashCode = hashCode * 59 + (this.DocumentName != null ? this.DocumentName.GetHashCode() : 0);
                hashCode = hashCode * 59 + this.ForceUpload.GetHashCode();
                hashCode = hashCode * 59 + (this.PlaceholderGroupID != null ? this.PlaceholderGroupID.GetHashCode() : 0);
                hashCode = hashCode * 59 + this.SendNotification.GetHashCode();
                return hashCode;
            }
        }
        
        public bool Equals(PlaceholderInfoField other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(FullWorkFlowRequestAccessField, other.FullWorkFlowRequestAccessField) && AllowMultiple == other.AllowMultiple && DocumentName == other.DocumentName && ForceUpload == other.ForceUpload && PlaceholderGroupID == other.PlaceholderGroupID && SendNotification == other.SendNotification;
        }
    }
}