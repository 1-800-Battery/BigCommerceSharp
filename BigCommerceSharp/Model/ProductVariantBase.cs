using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// Common Variant properties.
  /// </summary>
  [DataContract]
  public class ProductVariantBase {
    /// <summary>
    /// The cost price of the variant. Not affected by Price List prices.
    /// </summary>
    /// <value>The cost price of the variant. Not affected by Price List prices.</value>
    [DataMember(Name="cost_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cost_price")]
    public double? CostPrice { get; set; }

    /// <summary>
    /// This variant's base price on the storefront. If a Price List ID is used, the Price List value will be used. If a Price List ID is not used, and this value is `null`, the product's default price (set in the Product resource's `price` field) will be used as the base price.
    /// </summary>
    /// <value>This variant's base price on the storefront. If a Price List ID is used, the Price List value will be used. If a Price List ID is not used, and this value is `null`, the product's default price (set in the Product resource's `price` field) will be used as the base price.</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public double? Price { get; set; }

    /// <summary>
    /// This variant's sale price on the storefront. If a Price List ID is used, the Price List value will be used. If a Price List ID is not used, and this value is null, the product's sale price (set in the Product resource's `price` field) will be used as the sale price.
    /// </summary>
    /// <value>This variant's sale price on the storefront. If a Price List ID is used, the Price List value will be used. If a Price List ID is not used, and this value is null, the product's sale price (set in the Product resource's `price` field) will be used as the sale price.</value>
    [DataMember(Name="sale_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sale_price")]
    public double? SalePrice { get; set; }

    /// <summary>
    /// This variant's retail price on the storefront. If a Price List ID is used, the Price List value will be used. If a Price List ID is not used, and this value is null, the product's retail price (set in the Product resource's `price` field) will be used as the retail price.
    /// </summary>
    /// <value>This variant's retail price on the storefront. If a Price List ID is used, the Price List value will be used. If a Price List ID is not used, and this value is null, the product's retail price (set in the Product resource's `price` field) will be used as the retail price.</value>
    [DataMember(Name="retail_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "retail_price")]
    public double? RetailPrice { get; set; }

    /// <summary>
    /// This variant's base weight on the storefront. If this value is null, the product's default weight (set in the Product resource's weight field) will be used as the base weight.
    /// </summary>
    /// <value>This variant's base weight on the storefront. If this value is null, the product's default weight (set in the Product resource's weight field) will be used as the base weight.</value>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public double? Weight { get; set; }

    /// <summary>
    /// Width of the variant, which can be used when calculating shipping costs. If this value is `null`, the product's default width (set in the Product resource's `width` field) will be used as the base width. 
    /// </summary>
    /// <value>Width of the variant, which can be used when calculating shipping costs. If this value is `null`, the product's default width (set in the Product resource's `width` field) will be used as the base width. </value>
    [DataMember(Name="width", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "width")]
    public double? Width { get; set; }

    /// <summary>
    /// Height of the variant, which can be used when calculating shipping costs. If this value is `null`, the product's default height (set in the Product resource's `height` field) will be used as the base height. 
    /// </summary>
    /// <value>Height of the variant, which can be used when calculating shipping costs. If this value is `null`, the product's default height (set in the Product resource's `height` field) will be used as the base height. </value>
    [DataMember(Name="height", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "height")]
    public double? Height { get; set; }

    /// <summary>
    /// Depth of the variant, which can be used when calculating shipping costs. If this value is `null`, the product's default depth (set in the Product resource's `depth` field) will be used as the base depth. 
    /// </summary>
    /// <value>Depth of the variant, which can be used when calculating shipping costs. If this value is `null`, the product's default depth (set in the Product resource's `depth` field) will be used as the base depth. </value>
    [DataMember(Name="depth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "depth")]
    public double? Depth { get; set; }

    /// <summary>
    /// Flag used to indicate whether the variant has free shipping. If `true`, the shipping cost for the variant will be zero. 
    /// </summary>
    /// <value>Flag used to indicate whether the variant has free shipping. If `true`, the shipping cost for the variant will be zero. </value>
    [DataMember(Name="is_free_shipping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_free_shipping")]
    public bool? IsFreeShipping { get; set; }

    /// <summary>
    /// A fixed shipping cost for the variant. If defined, this value will be used during checkout instead of normal shipping-cost calculation. 
    /// </summary>
    /// <value>A fixed shipping cost for the variant. If defined, this value will be used during checkout instead of normal shipping-cost calculation. </value>
    [DataMember(Name="fixed_cost_shipping_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fixed_cost_shipping_price")]
    public double? FixedCostShippingPrice { get; set; }

    /// <summary>
    /// If `true`, this variant will not be purchasable on the storefront.
    /// </summary>
    /// <value>If `true`, this variant will not be purchasable on the storefront.</value>
    [DataMember(Name="purchasing_disabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purchasing_disabled")]
    public bool? PurchasingDisabled { get; set; }

    /// <summary>
    /// If `purchasing_disabled` is `true`, this message should show on the storefront when the variant is selected.
    /// </summary>
    /// <value>If `purchasing_disabled` is `true`, this message should show on the storefront when the variant is selected.</value>
    [DataMember(Name="purchasing_disabled_message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purchasing_disabled_message")]
    public string PurchasingDisabledMessage { get; set; }

    /// <summary>
    /// The UPC code used in feeds for shopping comparison sites and external channel integrations.
    /// </summary>
    /// <value>The UPC code used in feeds for shopping comparison sites and external channel integrations.</value>
    [DataMember(Name="upc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "upc")]
    public string Upc { get; set; }

    /// <summary>
    /// Inventory level for the variant, which is used when the product's inventory_tracking is set to `variant`.
    /// </summary>
    /// <value>Inventory level for the variant, which is used when the product's inventory_tracking is set to `variant`.</value>
    [DataMember(Name="inventory_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inventory_level")]
    public int? InventoryLevel { get; set; }

    /// <summary>
    /// When the variant hits this inventory level, it is considered low stock.
    /// </summary>
    /// <value>When the variant hits this inventory level, it is considered low stock.</value>
    [DataMember(Name="inventory_warning_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inventory_warning_level")]
    public int? InventoryWarningLevel { get; set; }

    /// <summary>
    /// Identifies where in a warehouse the variant is located.
    /// </summary>
    /// <value>Identifies where in a warehouse the variant is located.</value>
    [DataMember(Name="bin_picking_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bin_picking_number")]
    public string BinPickingNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductVariantBase {\n");
      sb.Append("  CostPrice: ").Append(CostPrice).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  SalePrice: ").Append(SalePrice).Append("\n");
      sb.Append("  RetailPrice: ").Append(RetailPrice).Append("\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      sb.Append("  Width: ").Append(Width).Append("\n");
      sb.Append("  Height: ").Append(Height).Append("\n");
      sb.Append("  Depth: ").Append(Depth).Append("\n");
      sb.Append("  IsFreeShipping: ").Append(IsFreeShipping).Append("\n");
      sb.Append("  FixedCostShippingPrice: ").Append(FixedCostShippingPrice).Append("\n");
      sb.Append("  PurchasingDisabled: ").Append(PurchasingDisabled).Append("\n");
      sb.Append("  PurchasingDisabledMessage: ").Append(PurchasingDisabledMessage).Append("\n");
      sb.Append("  Upc: ").Append(Upc).Append("\n");
      sb.Append("  InventoryLevel: ").Append(InventoryLevel).Append("\n");
      sb.Append("  InventoryWarningLevel: ").Append(InventoryWarningLevel).Append("\n");
      sb.Append("  BinPickingNumber: ").Append(BinPickingNumber).Append("\n");
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
