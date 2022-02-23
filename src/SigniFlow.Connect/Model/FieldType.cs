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
    /// #### Document Prepper Field Types  &#x60; 0  &#x3D; Signature 1  &#x3D; NameText 2  &#x3D; DateText 3  &#x3D; EmailAddressText 4  &#x3D; ContactNumberText 5  &#x3D; PlainText 6  &#x3D; PlainTextOptional 7  &#x3D; FaceToface 8  &#x3D; Initial 9  &#x3D; CheckBox 10 &#x3D; F2FInitial 11 &#x3D; AddressText 12 &#x3D; CompanyNameText 13 &#x3D; OptionalCurrencyText 14 &#x3D; MandatoryCurrencyText 15 &#x3D; ReadOnlyText 16 &#x3D; NumericFieldOpt 17 &#x3D; NumericFieldMand 18 &#x3D; EmailInputOptional 19 &#x3D; EmailInput &#x60;
    /// </summary>
    /// <value>#### Document Prepper Field Types  &#x60; 0  &#x3D; Signature 1  &#x3D; NameText 2  &#x3D; DateText 3  &#x3D; EmailAddressText 4  &#x3D; ContactNumberText 5  &#x3D; PlainText 6  &#x3D; PlainTextOptional 7  &#x3D; FaceToface 8  &#x3D; Initial 9  &#x3D; CheckBox 10 &#x3D; F2FInitial 11 &#x3D; AddressText 12 &#x3D; CompanyNameText 13 &#x3D; OptionalCurrencyText 14 &#x3D; MandatoryCurrencyText 15 &#x3D; ReadOnlyText 16 &#x3D; NumericFieldOpt 17 &#x3D; NumericFieldMand 18 &#x3D; EmailInputOptional 19 &#x3D; EmailInput &#x60;</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FieldType
    {
        /// <summary>
        /// Enum Signature for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        Signature = 0,
        
        /// <summary>
        /// Enum NameText for value: 1
        /// </summary>
        [EnumMember(Value = "1")]
        NameText = 1,
        
        /// <summary>
        /// Enum DateText for value: 2
        /// </summary>
        [EnumMember(Value = "2")]
        DateText = 2,
        
        /// <summary>
        /// Enum EmailAddressText for value: 3
        /// </summary>
        [EnumMember(Value = "3")]
        EmailAddressText = 3,
        
        /// <summary>
        /// Enum ContactNumberText for value: 4
        /// </summary>
        [EnumMember(Value = "4")]
        ContactNumberText = 4,
        
        /// <summary>
        /// Enum PlainText for value: 5
        /// </summary>
        [EnumMember(Value = "5")]
        PlainText = 5,
        
        /// <summary>
        /// Enum PlainTextOptional for value: 6
        /// </summary>
        [EnumMember(Value = "6")]
        PlainTextOptional = 6,
        
        /// <summary>
        /// Enum FaceToface for value: 7
        /// </summary>
        [EnumMember(Value = "7")]
        FaceToface = 7,
        
        /// <summary>
        /// Enum Initial for value: 8
        /// </summary>
        [EnumMember(Value = "8")]
        Initial = 8,
        
        /// <summary>
        /// Enum CheckBox for value: 9
        /// </summary>
        [EnumMember(Value = "9")]
        CheckBox = 9,
        
        /// <summary>
        /// Enum F2FInitial for value: 10
        /// </summary>
        [EnumMember(Value = "10")]
        F2FInitial = 10,
        
        /// <summary>
        /// Enum AddressText for value: 11
        /// </summary>
        [EnumMember(Value = "11")]
        AddressText = 11,
        
        /// <summary>
        /// Enum CompanyNameText for value: 12
        /// </summary>
        [EnumMember(Value = "12")]
        CompanyNameText = 12,
        
        /// <summary>
        /// Enum OptionalCurrencyText for value: 13
        /// </summary>
        [EnumMember(Value = "13")]
        OptionalCurrencyText = 13,
        
        /// <summary>
        /// Enum ReadOnlyText for value: 14
        /// </summary>
        [EnumMember(Value = "14")]
        ReadOnlyText = 14,
        
        /// <summary>
        /// Enum NumericFieldOpt for value: 15
        /// </summary>
        [EnumMember(Value = "15")]
        NumericFieldOpt = 15,
        
        /// <summary>
        /// Enum NumericFieldMand for value: 16
        /// </summary>
        [EnumMember(Value = "16")]
        NumericFieldMand = 16,
        
        /// <summary>
        /// Enum EmailInputOptional for value: 17
        /// </summary>
        [EnumMember(Value = "17")]
        EmailInputOptional = 17,
        
        /// <summary>
        /// Enum EmailInput for value: 18
        /// </summary>
        [EnumMember(Value = "18")]
        EmailInput = 18,
        
        /// <summary>
        /// Enum NUMBER_19 for value: 19
        /// </summary>
        [EnumMember(Value = "19")]
        NUMBER_19 = 19
        
    }

}
