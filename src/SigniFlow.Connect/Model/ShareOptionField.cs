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
    /// #### Share Portfolio Option Field Types &#x60; 0 &#x3D; Business    // Share with an entire business 1 &#x3D; Department  // Share with a specific department 2 &#x3D; Team        // Share with a specific team 3 &#x3D; User        // Share with a specific user &#x60;
    /// </summary>
    /// <value>#### Share Portfolio Option Field Types &#x60; 0 &#x3D; Business    // Share with an entire business 1 &#x3D; Department  // Share with a specific department 2 &#x3D; Team        // Share with a specific team 3 &#x3D; User        // Share with a specific user &#x60;</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ShareOptionField
    {
        /// <summary>
        /// Enum Business for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        Business = 0,
        
        /// <summary>
        /// Enum Department for value: 1
        /// </summary>
        [EnumMember(Value = "1")]
        Department = 1,
        
        /// <summary>
        /// Enum Team for value: 2
        /// </summary>
        [EnumMember(Value = "2")]
        Team = 2,
        
        /// <summary>
        /// Enum User for value: 3
        /// </summary>
        [EnumMember(Value = "3")]
        User = 3
        
    }

}
