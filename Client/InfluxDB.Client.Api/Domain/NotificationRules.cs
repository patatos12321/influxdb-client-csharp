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
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// NotificationRules
    /// </summary>
    [DataContract]
    public partial class NotificationRules :  IEquatable<NotificationRules>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationRules" /> class.
        /// </summary>
        /// <param name="notificationRules">notificationRules.</param>
        /// <param name="links">links.</param>
        public NotificationRules(List<NotificationRule> notificationRules = default(List<NotificationRule>), Links links = default(Links))
        {
            this._NotificationRules = notificationRules;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets _NotificationRules
        /// </summary>
        [DataMember(Name="notificationRules", EmitDefaultValue=false)]
        public List<NotificationRule> _NotificationRules { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public Links Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationRules {\n");
            sb.Append("  _NotificationRules: ").Append(_NotificationRules).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as NotificationRules);
        }

        /// <summary>
        /// Returns true if NotificationRules instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationRules to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationRules input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._NotificationRules == input._NotificationRules ||
                    this._NotificationRules != null &&
                    this._NotificationRules.SequenceEqual(input._NotificationRules)
                ) && 
                (
                    
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this._NotificationRules != null)
                    hashCode = hashCode * 59 + this._NotificationRules.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }

}
