/* 
 * Influx API Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// FluxSuggestions
    /// </summary>
    [DataContract]
    public partial class FluxSuggestions :  IEquatable<FluxSuggestions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FluxSuggestions" /> class.
        /// </summary>
        /// <param name="funcs">funcs.</param>
        public FluxSuggestions(List<FluxSuggestion> funcs = default(List<FluxSuggestion>))
        {
            this.Funcs = funcs;
        }

        /// <summary>
        /// Gets or Sets Funcs
        /// </summary>
        [DataMember(Name="funcs", EmitDefaultValue=false)]
        public List<FluxSuggestion> Funcs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FluxSuggestions {\n");
            sb.Append("  Funcs: ").Append(Funcs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FluxSuggestions);
        }

        /// <summary>
        /// Returns true if FluxSuggestions instances are equal
        /// </summary>
        /// <param name="input">Instance of FluxSuggestions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FluxSuggestions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Funcs == input.Funcs ||
                    this.Funcs != null &&
                    this.Funcs.SequenceEqual(input.Funcs)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Funcs != null)
                    hashCode = hashCode * 59 + this.Funcs.GetHashCode();
                return hashCode;
            }
        }

    }

}
