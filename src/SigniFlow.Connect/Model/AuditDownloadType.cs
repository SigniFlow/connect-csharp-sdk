using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace SigniFlow.Connect.Model
{
    /// <summary>
    /// #### Sets download type to either   &#x60;0 &#x3D; Document 1 &#x3D; Combined&#x60;
    /// </summary>
    /// <value>#### Sets download type to either   &#x60;0 &#x3D; Document 1 &#x3D; Combined&#x60;</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum AuditDownloadType
    {
        /// <summary>
        /// Enum Document for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        Document = 0,

        /// <summary>
        /// Enum Combined for value: 1
        /// </summary>
        [EnumMember(Value = "1")]
        Combined = 1

    }
}
