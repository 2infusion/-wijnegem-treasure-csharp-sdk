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
  public class Treasure {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Y
    /// </summary>
    [DataMember(Name="y", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "y")]
    public decimal? Y { get; set; }

    /// <summary>
    /// Gets or Sets X
    /// </summary>
    [DataMember(Name="x", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "x")]
    public decimal? X { get; set; }

    /// <summary>
    /// Gets or Sets FloorLevel
    /// </summary>
    [DataMember(Name="floorLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "floorLevel")]
    public decimal? FloorLevel { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Treasure {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Y: ").Append(Y).Append("\n");
      sb.Append("  X: ").Append(X).Append("\n");
      sb.Append("  FloorLevel: ").Append(FloorLevel).Append("\n");
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
