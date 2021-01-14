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
  public class CurrencyPairNameValue {
    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets LocalCurrencySymbol
    /// </summary>
    [DataMember(Name="localCurrencySymbol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "localCurrencySymbol")]
    public string LocalCurrencySymbol { get; set; }

    /// <summary>
    /// Gets or Sets Values
    /// </summary>
    [DataMember(Name="values", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "values")]
    public List<CurrencyValue> Values { get; set; }

    /// <summary>
    /// Gets or Sets Order
    /// </summary>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public int? Order { get; set; }

    /// <summary>
    /// Gets or Sets FxOrder
    /// </summary>
    [DataMember(Name="fxOrder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fxOrder")]
    public int? FxOrder { get; set; }

    /// <summary>
    /// Gets or Sets FxId
    /// </summary>
    [DataMember(Name="fxId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fxId")]
    public string FxId { get; set; }

    /// <summary>
    /// Gets or Sets Paragraph
    /// </summary>
    [DataMember(Name="paragraph", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paragraph")]
    public string Paragraph { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CurrencyPairNameValue {\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  LocalCurrencySymbol: ").Append(LocalCurrencySymbol).Append("\n");
      sb.Append("  Values: ").Append(Values).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
      sb.Append("  FxOrder: ").Append(FxOrder).Append("\n");
      sb.Append("  FxId: ").Append(FxId).Append("\n");
      sb.Append("  Paragraph: ").Append(Paragraph).Append("\n");
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
