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
  public class OpenTreasure {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Treasure
    /// </summary>
    [DataMember(Name="treasure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "treasure")]
    public Treasure Treasure { get; set; }

    /// <summary>
    /// Gets or Sets Coupon
    /// </summary>
    [DataMember(Name="coupon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "coupon")]
    public Coupon Coupon { get; set; }

    /// <summary>
    /// Gets or Sets Round
    /// </summary>
    [DataMember(Name="round", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "round")]
    public decimal? Round { get; set; }

    /// <summary>
    /// Gets or Sets CreateAt
    /// </summary>
    [DataMember(Name="createAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createAt")]
    public string CreateAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OpenTreasure {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Treasure: ").Append(Treasure).Append("\n");
      sb.Append("  Coupon: ").Append(Coupon).Append("\n");
      sb.Append("  Round: ").Append(Round).Append("\n");
      sb.Append("  CreateAt: ").Append(CreateAt).Append("\n");
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
