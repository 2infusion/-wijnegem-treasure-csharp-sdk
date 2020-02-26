using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserInfo {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets FirstName
    /// </summary>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or Sets Lastname
    /// </summary>
    [DataMember(Name="lastname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastname")]
    public string Lastname { get; set; }

    /// <summary>
    /// Gets or Sets Birthdate
    /// </summary>
    [DataMember(Name="birthdate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "birthdate")]
    public string Birthdate { get; set; }

    /// <summary>
    /// Gets or Sets Gender
    /// </summary>
    [DataMember(Name="gender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gender")]
    public string Gender { get; set; }

    /// <summary>
    /// Gets or Sets Postalcode
    /// </summary>
    [DataMember(Name="postalcode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postalcode")]
    public string Postalcode { get; set; }

    /// <summary>
    /// Gets or Sets InRelation
    /// </summary>
    [DataMember(Name="inRelation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inRelation")]
    public bool? InRelation { get; set; }

    /// <summary>
    /// Gets or Sets AmountChildren
    /// </summary>
    [DataMember(Name="amountChildren", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amountChildren")]
    public decimal? AmountChildren { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserInfo {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  Lastname: ").Append(Lastname).Append("\n");
      sb.Append("  Birthdate: ").Append(Birthdate).Append("\n");
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      sb.Append("  Postalcode: ").Append(Postalcode).Append("\n");
      sb.Append("  InRelation: ").Append(InRelation).Append("\n");
      sb.Append("  AmountChildren: ").Append(AmountChildren).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
