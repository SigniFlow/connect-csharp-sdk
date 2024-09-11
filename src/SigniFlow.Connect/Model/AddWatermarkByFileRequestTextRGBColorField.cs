/*
 * SigniFlow API
 *
 * API for adding watermarks to documents
 *
 * The version of the OpenAPI document: 1.0.0
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
    /// RGB color values for the watermark text
    /// </summary>
    [DataContract(Name = "AddWatermarkByFileRequest_TextRGBColorField")]
    public partial class AddWatermarkByFileRequestTextRGBColorField : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddWatermarkByFileRequestTextRGBColorField" /> class.
        /// </summary>
        /// <param name="blueField">Blue color value (0-255).</param>
        /// <param name="greenField">Green color value (0-255).</param>
        /// <param name="redField">Red color value (0-255).</param>
        public AddWatermarkByFileRequestTextRGBColorField(int blueField = default(int), int greenField = default(int), int redField = default(int))
        {
            this.BlueField = blueField;
            this.GreenField = greenField;
            this.RedField = redField;
        }

        /// <summary>
        /// Blue color value (0-255)
        /// </summary>
        /// <value>Blue color value (0-255)</value>
        [DataMember(Name = "BlueField", EmitDefaultValue = true)]
        public int BlueField { get; set; }

        /// <summary>
        /// Green color value (0-255)
        /// </summary>
        /// <value>Green color value (0-255)</value>
        [DataMember(Name = "GreenField", EmitDefaultValue = true)]
        public int GreenField { get; set; }

        /// <summary>
        /// Red color value (0-255)
        /// </summary>
        /// <value>Red color value (0-255)</value>
        [DataMember(Name = "RedField", EmitDefaultValue = true)]
        public int RedField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddWatermarkByFileRequestTextRGBColorField {\n");
            sb.Append("  BlueField: ").Append(BlueField).Append("\n");
            sb.Append("  GreenField: ").Append(GreenField).Append("\n");
            sb.Append("  RedField: ").Append(RedField).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
