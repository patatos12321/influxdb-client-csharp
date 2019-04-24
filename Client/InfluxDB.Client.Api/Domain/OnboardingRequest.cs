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
    /// OnboardingRequest
    /// </summary>
    [DataContract]
    public partial class OnboardingRequest :  IEquatable<OnboardingRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnboardingRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OnboardingRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OnboardingRequest" /> class.
        /// </summary>
        /// <param name="username">username (required).</param>
        /// <param name="password">password (required).</param>
        /// <param name="org">org (required).</param>
        /// <param name="bucket">bucket (required).</param>
        /// <param name="retentionPeriodHrs">retentionPeriodHrs.</param>
        public OnboardingRequest(string username = default(string), string password = default(string), string org = default(string), string bucket = default(string), int? retentionPeriodHrs = default(int?))
        {
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new InvalidDataException("username is a required property for OnboardingRequest and cannot be null");
            }
            else
            {
                this.Username = username;
            }
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new InvalidDataException("password is a required property for OnboardingRequest and cannot be null");
            }
            else
            {
                this.Password = password;
            }
            // to ensure "org" is required (not null)
            if (org == null)
            {
                throw new InvalidDataException("org is a required property for OnboardingRequest and cannot be null");
            }
            else
            {
                this.Org = org;
            }
            // to ensure "bucket" is required (not null)
            if (bucket == null)
            {
                throw new InvalidDataException("bucket is a required property for OnboardingRequest and cannot be null");
            }
            else
            {
                this.Bucket = bucket;
            }
            this.RetentionPeriodHrs = retentionPeriodHrs;
        }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Org
        /// </summary>
        [DataMember(Name="org", EmitDefaultValue=false)]
        public string Org { get; set; }

        /// <summary>
        /// Gets or Sets Bucket
        /// </summary>
        [DataMember(Name="bucket", EmitDefaultValue=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// Gets or Sets RetentionPeriodHrs
        /// </summary>
        [DataMember(Name="retentionPeriodHrs", EmitDefaultValue=false)]
        public int? RetentionPeriodHrs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnboardingRequest {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Org: ").Append(Org).Append("\n");
            sb.Append("  Bucket: ").Append(Bucket).Append("\n");
            sb.Append("  RetentionPeriodHrs: ").Append(RetentionPeriodHrs).Append("\n");
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
            return this.Equals(input as OnboardingRequest);
        }

        /// <summary>
        /// Returns true if OnboardingRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OnboardingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnboardingRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Org == input.Org ||
                    (this.Org != null &&
                    this.Org.Equals(input.Org))
                ) && 
                (
                    this.Bucket == input.Bucket ||
                    (this.Bucket != null &&
                    this.Bucket.Equals(input.Bucket))
                ) && 
                (
                    this.RetentionPeriodHrs == input.RetentionPeriodHrs ||
                    (this.RetentionPeriodHrs != null &&
                    this.RetentionPeriodHrs.Equals(input.RetentionPeriodHrs))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Org != null)
                    hashCode = hashCode * 59 + this.Org.GetHashCode();
                if (this.Bucket != null)
                    hashCode = hashCode * 59 + this.Bucket.GetHashCode();
                if (this.RetentionPeriodHrs != null)
                    hashCode = hashCode * 59 + this.RetentionPeriodHrs.GetHashCode();
                return hashCode;
            }
        }

    }

}
