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
  public class CurrencyPairsWrapper {
    /// <summary>
    /// Gets or Sets Currencies
    /// </summary>
    [DataMember(Name="currencies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currencies")]
    public List<CurrencyPairNameValue> Currencies { get; set; }

    /// <summary>
    /// Gets or Sets LocalCountry
    /// </summary>
    [DataMember(Name="localCountry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "localCountry")]
    public string LocalCountry { get; set; }

    /// <summary>
    /// Gets or Sets LocalCurrencySymbol
    /// </summary>
    [DataMember(Name="localCurrencySymbol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "localCurrencySymbol")]
    public string LocalCurrencySymbol { get; set; }

    /// <summary>
    /// Gets or Sets LocalCurrencyCode
    /// </summary>
    [DataMember(Name="localCurrencyCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "localCurrencyCode")]
    public string LocalCurrencyCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CurrencyPairsWrapper {\n");
      sb.Append("  Currencies: ").Append(Currencies).Append("\n");
      sb.Append("  LocalCountry: ").Append(LocalCountry).Append("\n");
      sb.Append("  LocalCurrencySymbol: ").Append(LocalCurrencySymbol).Append("\n");
      sb.Append("  LocalCurrencyCode: ").Append(LocalCurrencyCode).Append("\n");
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
