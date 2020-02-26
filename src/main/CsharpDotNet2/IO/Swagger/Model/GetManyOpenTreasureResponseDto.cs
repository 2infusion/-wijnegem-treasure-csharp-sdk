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
  public class GetManyOpenTreasureResponseDto {
    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public List<OpenTreasure> Data { get; set; }

    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public decimal? Count { get; set; }

    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public decimal? Total { get; set; }

    /// <summary>
    /// Gets or Sets Page
    /// </summary>
    [DataMember(Name="page", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "page")]
    public decimal? Page { get; set; }

    /// <summary>
    /// Gets or Sets PageCount
    /// </summary>
    [DataMember(Name="pageCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageCount")]
    public decimal? PageCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetManyOpenTreasureResponseDto {\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
      sb.Append("  Page: ").Append(Page).Append("\n");
      sb.Append("  PageCount: ").Append(PageCount).Append("\n");
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
