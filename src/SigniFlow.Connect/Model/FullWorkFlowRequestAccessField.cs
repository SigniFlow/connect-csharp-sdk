using System;
using System.Runtime.Serialization;

namespace SigniFlow.Connect.Model
{
    [DataContract(Name = "FullWorkFlowRequestAccessField")]
    public class FullWorkFlowRequestAccessField : IEquatable<FullWorkFlowRequestAccessField>
    {
        [DataMember(Name = "AccessField")]
        public AccessLevelField AccessField { get; set; }
        
        [DataMember(Name = "ReferenceIDField")]
        public int ReferenceIDField { get; set; }
        
        [DataMember(Name = "ShareOptionField")]
        public ShareOptionField ShareOptionField { get; set; }
        
        [DataMember(Name = "UniqueIDField")]
        public string UniqueIDField { get; set; }
        
        [DataMember(Name = "UserEmailField")]
        public string UserEmailField { get; set; }
        
        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = 41;
                hashCode = hashCode * 59 + this.AccessField.GetHashCode();
                hashCode = hashCode * 59 + this.ReferenceIDField.GetHashCode();
                hashCode = hashCode * 59 + this.ShareOptionField.GetHashCode();
                hashCode = hashCode * 59 + this.UniqueIDField.GetHashCode();
                hashCode = hashCode * 59 + this.UserEmailField.GetHashCode();
            
                return hashCode;
            }
        }

        public bool Equals(FullWorkFlowRequestAccessField other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return AccessField == other.AccessField && ReferenceIDField == other.ReferenceIDField && ShareOptionField == other.ShareOptionField && UniqueIDField == other.UniqueIDField && UserEmailField == other.UserEmailField;
        }
    }
}