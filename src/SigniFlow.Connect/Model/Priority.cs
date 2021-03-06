/*
 * WorkFlow API
 *
 * ## SigniFlow API used to automate esignature workflow creation and management. 
 *
 * The version of the OpenAPI document: 1.0
 * Contact: support@signiflow.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = SigniFlow.Connect.Client.OpenAPIDateConverter;

namespace SigniFlow.Connect.Model
{
    /// <summary>
    /// #### The priority level of the workflow.   &#x60;0 &#x3D; Low 1 &#x3D; Normal 2 &#x3D; High&#x60;
    /// </summary>
    /// <value>#### The priority level of the workflow.   &#x60;0 &#x3D; Low 1 &#x3D; Normal 2 &#x3D; High&#x60;</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Priority
    {
        /// <summary>
        /// Enum Low for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        Low = 0,
        
        /// <summary>
        /// Enum Normal for value: 1
        /// </summary>
        [EnumMember(Value = "1")]
        Normal = 1,
        
        /// <summary>
        /// Enum High for value: 2
        /// </summary>
        [EnumMember(Value = "2")]
        High = 2
        
    }

}
