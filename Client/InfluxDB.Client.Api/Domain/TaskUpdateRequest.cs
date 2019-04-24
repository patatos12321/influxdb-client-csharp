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
    /// TaskUpdateRequest
    /// </summary>
    [DataContract]
    public partial class TaskUpdateRequest :  IEquatable<TaskUpdateRequest>
    {
        /// <summary>
        /// Starting state of the task. &#39;inactive&#39; tasks are not run until they are updated to &#39;active&#39;
        /// </summary>
        /// <value>Starting state of the task. &#39;inactive&#39; tasks are not run until they are updated to &#39;active&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,
            
            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 2
        }

        /// <summary>
        /// Starting state of the task. &#39;inactive&#39; tasks are not run until they are updated to &#39;active&#39;
        /// </summary>
        /// <value>Starting state of the task. &#39;inactive&#39; tasks are not run until they are updated to &#39;active&#39;</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskUpdateRequest" /> class.
        /// </summary>
        /// <param name="status">Starting state of the task. &#39;inactive&#39; tasks are not run until they are updated to &#39;active&#39; (default to StatusEnum.Active).</param>
        /// <param name="flux">The Flux script to run for this task..</param>
        /// <param name="name">Override the &#39;name&#39; option in the flux script..</param>
        /// <param name="every">Override the &#39;every&#39; option in the flux script..</param>
        /// <param name="cron">Override the &#39;cron&#39; option in the flux script..</param>
        /// <param name="offset">Override the &#39;offset&#39; option in the flux script..</param>
        /// <param name="token">Override the existing token associated with the task..</param>
        public TaskUpdateRequest(StatusEnum? status = StatusEnum.Active, string flux = default(string), string name = default(string), string every = default(string), string cron = default(string), string offset = default(string), string token = default(string))
        {
            // use default value if no "status" provided
            if (status == null)
            {
                this.Status = StatusEnum.Active;
            }
            else
            {
                this.Status = status;
            }
            this.Flux = flux;
            this.Name = name;
            this.Every = every;
            this.Cron = cron;
            this.Offset = offset;
            this.Token = token;
        }


        /// <summary>
        /// The Flux script to run for this task.
        /// </summary>
        /// <value>The Flux script to run for this task.</value>
        [DataMember(Name="flux", EmitDefaultValue=false)]
        public string Flux { get; set; }

        /// <summary>
        /// Override the &#39;name&#39; option in the flux script.
        /// </summary>
        /// <value>Override the &#39;name&#39; option in the flux script.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Override the &#39;every&#39; option in the flux script.
        /// </summary>
        /// <value>Override the &#39;every&#39; option in the flux script.</value>
        [DataMember(Name="every", EmitDefaultValue=false)]
        public string Every { get; set; }

        /// <summary>
        /// Override the &#39;cron&#39; option in the flux script.
        /// </summary>
        /// <value>Override the &#39;cron&#39; option in the flux script.</value>
        [DataMember(Name="cron", EmitDefaultValue=false)]
        public string Cron { get; set; }

        /// <summary>
        /// Override the &#39;offset&#39; option in the flux script.
        /// </summary>
        /// <value>Override the &#39;offset&#39; option in the flux script.</value>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public string Offset { get; set; }

        /// <summary>
        /// Override the existing token associated with the task.
        /// </summary>
        /// <value>Override the existing token associated with the task.</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskUpdateRequest {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Flux: ").Append(Flux).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Every: ").Append(Every).Append("\n");
            sb.Append("  Cron: ").Append(Cron).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as TaskUpdateRequest);
        }

        /// <summary>
        /// Returns true if TaskUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Flux == input.Flux ||
                    (this.Flux != null &&
                    this.Flux.Equals(input.Flux))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Every == input.Every ||
                    (this.Every != null &&
                    this.Every.Equals(input.Every))
                ) && 
                (
                    this.Cron == input.Cron ||
                    (this.Cron != null &&
                    this.Cron.Equals(input.Cron))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Flux != null)
                    hashCode = hashCode * 59 + this.Flux.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Every != null)
                    hashCode = hashCode * 59 + this.Every.GetHashCode();
                if (this.Cron != null)
                    hashCode = hashCode * 59 + this.Cron.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                return hashCode;
            }
        }

    }

}
