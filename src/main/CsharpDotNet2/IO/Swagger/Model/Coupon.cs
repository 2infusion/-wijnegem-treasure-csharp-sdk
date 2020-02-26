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
  public class Coupon {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets Weight
    /// </summary>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public string Weight { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Image
    /// </summary>
    [DataMember(Name="image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image")]
    public string Image { get; set; }

    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or Sets ExpireDate
    /// </summary>
    [DataMember(Name="expireDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expireDate")]
    public string ExpireDate { get; set; }

    /// <summary>
    /// Gets or Sets ValidatedAt
    /// </summary>
    [DataMember(Name="validatedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validatedAt")]
    public string ValidatedAt { get; set; }

    /// <summary>
    /// Gets or Sets Partner
    /// </summary>
    [DataMember(Name="partner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partner")]
    public Partner Partner { get; set; }

    /// <summary>
    /// Gets or Sets OpenTreasure
    /// </summary>
    [DataMember(Name="openTreasure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openTreasure")]
    public OpenTreasure OpenTreasure { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Coupon {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Image: ").Append(Image).Append("\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  ExpireDate: ").Append(ExpireDate).Append("\n");
      sb.Append("  ValidatedAt: ").Append(ValidatedAt).Append("\n");
      sb.Append("  Partner: ").Append(Partner).Append("\n");
      sb.Append("  OpenTreasure: ").Append(OpenTreasure).Append("\n");
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
