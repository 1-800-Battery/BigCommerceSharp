using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// Common Option properties.
  /// </summary>
  [DataContract]
  public class ProductOptionBase1 {
    /// <summary>
    /// The unique numerical ID of the option, increments sequentially. 
    /// </summary>
    /// <value>The unique numerical ID of the option, increments sequentially. </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The unique numerical ID of the product to which the option belongs. 
    /// </summary>
    /// <value>The unique numerical ID of the product to which the option belongs. </value>
    [DataMember(Name="product_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product_id")]
    public int? ProductId { get; set; }

    /// <summary>
    /// The name of the option shown on the storefront. 
    /// </summary>
    /// <value>The name of the option shown on the storefront. </value>
    [DataMember(Name="display_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// The type of option, which determines how it will display on the storefront. Acceptable values: `radio_buttons`, `rectangles`, `dropdown`, `product_list`, `product_list_with_images`, `swatch`. For reference, the former v2 API values are: RB = radio_buttons, RT = rectangles, S = dropdown, P = product_list, PI = product_list_with_images, CS = swatch. 
    /// </summary>
    /// <value>The type of option, which determines how it will display on the storefront. Acceptable values: `radio_buttons`, `rectangles`, `dropdown`, `product_list`, `product_list_with_images`, `swatch`. For reference, the former v2 API values are: RB = radio_buttons, RT = rectangles, S = dropdown, P = product_list, PI = product_list_with_images, CS = swatch. </value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Config
    /// </summary>
    [DataMember(Name="config", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "config")]
    public ConfigFull1 Config { get; set; }

    /// <summary>
    /// Order in which the option is displayed on the storefront. 
    /// </summary>
    /// <value>Order in which the option is displayed on the storefront. </value>
    [DataMember(Name="sort_order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort_order")]
    public int? SortOrder { get; set; }

    /// <summary>
    /// Product Option `option_value`.
    /// </summary>
    /// <value>Product Option `option_value`.</value>
    [DataMember(Name="option_values", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "option_values")]
    public Object OptionValues { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductOptionBase1 {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ProductId: ").Append(ProductId).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Config: ").Append(Config).Append("\n");
      sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
      sb.Append("  OptionValues: ").Append(OptionValues).Append("\n");
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
