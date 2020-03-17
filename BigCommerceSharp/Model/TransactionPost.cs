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
  public class TransactionPost {
    /// <summary>
    /// Store event that created the transaction. 
    /// </summary>
    /// <value>Store event that created the transaction. </value>
    [DataMember(Name="event", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event")]
    public string Event { get; set; }

    /// <summary>
    /// The payment method: `credit_card` - a credit-card transaction; `electronic_wallet` - an online wallet; `store_credit` - a transaction using store credit; `gift_certificate` - a transaction using a gift certificate; `custom` - manual payment methods; `token` - payment token; `nonce` - temporary payment token; `offsite` - online payment off the site (e.g., PayPal); `offline` - payment method that takes place offline. 
    /// </summary>
    /// <value>The payment method: `credit_card` - a credit-card transaction; `electronic_wallet` - an online wallet; `store_credit` - a transaction using store credit; `gift_certificate` - a transaction using a gift certificate; `custom` - manual payment methods; `token` - payment token; `nonce` - temporary payment token; `offsite` - online payment off the site (e.g., PayPal); `offline` - payment method that takes place offline. </value>
    [DataMember(Name="method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "method")]
    public string Method { get; set; }

    /// <summary>
    /// Amount of money in the transaction. 
    /// </summary>
    /// <value>Amount of money in the transaction. </value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public float? Amount { get; set; }

    /// <summary>
    /// Currency used for the transaction. 
    /// </summary>
    /// <value>Currency used for the transaction. </value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// The payment gateway, where applicable. 
    /// </summary>
    /// <value>The payment gateway, where applicable. </value>
    [DataMember(Name="gateway", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gateway")]
    public string Gateway { get; set; }

    /// <summary>
    /// The transaction ID returned by the payment gateway for this transaction item. 
    /// </summary>
    /// <value>The transaction ID returned by the payment gateway for this transaction item. </value>
    [DataMember(Name="gateway_transaction_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gateway_transaction_id")]
    public string GatewayTransactionId { get; set; }

    /// <summary>
    /// The datetime of the transaction. 
    /// </summary>
    /// <value>The datetime of the transaction. </value>
    [DataMember(Name="date_created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_created")]
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// True if the transaction performed was a test, or if the gateway is in test mode. 
    /// </summary>
    /// <value>True if the transaction performed was a test, or if the gateway is in test mode. </value>
    [DataMember(Name="test", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "test")]
    public bool? Test { get; set; }

    /// <summary>
    /// Status of the transaction. 
    /// </summary>
    /// <value>Status of the transaction. </value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Result of gateway fraud review, if any. Default is `false`. 
    /// </summary>
    /// <value>Result of gateway fraud review, if any. Default is `false`. </value>
    [DataMember(Name="fraud_review", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fraud_review")]
    public bool? FraudReview { get; set; }

    /// <summary>
    /// Identifier for an existing transaction upon which this transaction acts. 
    /// </summary>
    /// <value>Identifier for an existing transaction upon which this transaction acts. </value>
    [DataMember(Name="reference_transaction_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference_transaction_id")]
    public int? ReferenceTransactionId { get; set; }

    /// <summary>
    /// Gets or Sets Offline
    /// </summary>
    [DataMember(Name="offline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offline")]
    public Offline1 Offline { get; set; }

    /// <summary>
    /// Gets or Sets Custom
    /// </summary>
    [DataMember(Name="custom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom")]
    public Custom1 Custom { get; set; }

    /// <summary>
    /// Gets or Sets 
    /// </summary>
    [DataMember(Name="", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "")]
    public string  { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransactionPost {\n");
      sb.Append("  Event: ").Append(Event).Append("\n");
      sb.Append("  Method: ").Append(Method).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Gateway: ").Append(Gateway).Append("\n");
      sb.Append("  GatewayTransactionId: ").Append(GatewayTransactionId).Append("\n");
      sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
      sb.Append("  Test: ").Append(Test).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  FraudReview: ").Append(FraudReview).Append("\n");
      sb.Append("  ReferenceTransactionId: ").Append(ReferenceTransactionId).Append("\n");
      sb.Append("  Offline: ").Append(Offline).Append("\n");
      sb.Append("  Custom: ").Append(Custom).Append("\n");
      sb.Append("  : ").Append().Append("\n");
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
