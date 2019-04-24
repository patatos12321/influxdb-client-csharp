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
    /// Users
    /// </summary>
    [DataContract]
    public partial class Users :  IEquatable<Users>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Users" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        /// <param name="users">users.</param>
        public Users(UsersLinks links = default(UsersLinks), List<User> users = default(List<User>))
        {
            this.Links = links;
            this._Users = users;
        }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public UsersLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets _Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<User> _Users { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Users {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  _Users: ").Append(_Users).Append("\n");
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
            return this.Equals(input as Users);
        }

        /// <summary>
        /// Returns true if Users instances are equal
        /// </summary>
        /// <param name="input">Instance of Users to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Users input)
        {
            if (input == null)
                return false;

            return 
                (
                    
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this._Users == input._Users ||
                    this._Users != null &&
                    this._Users.SequenceEqual(input._Users)
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
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this._Users != null)
                    hashCode = hashCode * 59 + this._Users.GetHashCode();
                return hashCode;
            }
        }

    }

}
