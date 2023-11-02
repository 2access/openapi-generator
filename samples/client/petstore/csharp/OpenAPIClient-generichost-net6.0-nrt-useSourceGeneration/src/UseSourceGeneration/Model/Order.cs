// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = UseSourceGeneration.Client.ClientUtils;
using System.Text.Json.Serialization.Metadata;
using UseSourceGeneration.Client;

namespace UseSourceGeneration.Model
{
    /// <summary>
    /// Order
    /// </summary>
    public partial class Order : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="petId">petId</param>
        /// <param name="quantity">quantity</param>
        /// <param name="shipDate">shipDate</param>
        /// <param name="status">Order Status</param>
        /// <param name="complete">complete (default to false)</param>
        [JsonConstructor]
        public Order(Option<long?> id = default, Option<long?> petId = default, Option<int?> quantity = default, Option<DateTime?> shipDate = default, Option<StatusEnum?> status = default, Option<bool?> complete = default)
        {
            IdOption = id;
            PetIdOption = petId;
            QuantityOption = quantity;
            ShipDateOption = shipDate;
            StatusOption = status;
            CompleteOption = complete;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Order Status
        /// </summary>
        /// <value>Order Status</value>
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Placed for value: placed
            /// </summary>
            Placed = 1,

            /// <summary>
            /// Enum Approved for value: approved
            /// </summary>
            Approved = 2,

            /// <summary>
            /// Enum Delivered for value: delivered
            /// </summary>
            Delivered = 3
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static StatusEnum StatusEnumFromString(string value)
        {
            if (value.Equals("placed"))
                return StatusEnum.Placed;

            if (value.Equals("approved"))
                return StatusEnum.Approved;

            if (value.Equals("delivered"))
                return StatusEnum.Delivered;

            throw new NotImplementedException($"Could not convert value to type StatusEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StatusEnum? StatusEnumFromStringOrDefault(string value)
        {
            if (value.Equals("placed"))
                return StatusEnum.Placed;

            if (value.Equals("approved"))
                return StatusEnum.Approved;

            if (value.Equals("delivered"))
                return StatusEnum.Delivered;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="StatusEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string StatusEnumToJsonValue(StatusEnum? value)
        {
            if (value == StatusEnum.Placed)
                return "placed";

            if (value == StatusEnum.Approved)
                return "approved";

            if (value == StatusEnum.Delivered)
                return "delivered";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Used to track the state of Status
        /// </summary>
        [JsonIgnore]
        public Option<StatusEnum?> StatusOption { get; private set; } // option a

        /// <summary>
        /// Order Status
        /// </summary>
        /// <value>Order Status</value>
        [JsonPropertyName("status")]
        public StatusEnum? Status { get { return this.StatusOption; } set { this.StatusOption = new(value); } } // a

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        public Option<long?> IdOption { get; private set; } // option d

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public long? Id { get { return this. IdOption; } set { this.IdOption = new(value); } } // d

        /// <summary>
        /// Used to track the state of PetId
        /// </summary>
        [JsonIgnore]
        public Option<long?> PetIdOption { get; private set; } // option d

        /// <summary>
        /// Gets or Sets PetId
        /// </summary>
        [JsonPropertyName("petId")]
        public long? PetId { get { return this. PetIdOption; } set { this.PetIdOption = new(value); } } // d

        /// <summary>
        /// Used to track the state of Quantity
        /// </summary>
        [JsonIgnore]
        public Option<int?> QuantityOption { get; private set; } // option d

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [JsonPropertyName("quantity")]
        public int? Quantity { get { return this. QuantityOption; } set { this.QuantityOption = new(value); } } // d

        /// <summary>
        /// Used to track the state of ShipDate
        /// </summary>
        [JsonIgnore]
        public Option<DateTime?> ShipDateOption { get; private set; } // option d

        /// <summary>
        /// Gets or Sets ShipDate
        /// </summary>
        /// <example>2020-02-02T20:20:20.000222Z</example>
        [JsonPropertyName("shipDate")]
        public DateTime? ShipDate { get { return this. ShipDateOption; } set { this.ShipDateOption = new(value); } } // d

        /// <summary>
        /// Used to track the state of Complete
        /// </summary>
        [JsonIgnore]
        public Option<bool?> CompleteOption { get; private set; } // option d

        /// <summary>
        /// Gets or Sets Complete
        /// </summary>
        [JsonPropertyName("complete")]
        public bool? Complete { get { return this. CompleteOption; } set { this.CompleteOption = new(value); } } // d

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Order {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PetId: ").Append(PetId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Complete: ").Append(Complete).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Order" />
    /// </summary>
    public class OrderJsonConverter : JsonConverter<Order>
    {
        /// <summary>
        /// The format to use to serialize ShipDate
        /// </summary>
        public static string ShipDateFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="Order" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Order Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> id = default;
            Option<long?> petId = default;
            Option<int?> quantity = default;
            Option<DateTime?> shipDate = default;
            Option<Order.StatusEnum?> status = default;
            Option<bool?> complete = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "petId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                petId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "quantity":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                quantity = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "shipDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                shipDate = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "status":
                            string? statusRawValue = utf8JsonReader.GetString();
                            if (statusRawValue != null)
                                status = new Option<Order.StatusEnum?>(Order.StatusEnumFromStringOrDefault(statusRawValue));
                            break;
                        case "complete":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                complete = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class Order.");

            if (petId.IsSet && petId.Value == null)
                throw new ArgumentNullException(nameof(petId), "Property is not nullable for class Order.");

            if (quantity.IsSet && quantity.Value == null)
                throw new ArgumentNullException(nameof(quantity), "Property is not nullable for class Order.");

            if (shipDate.IsSet && shipDate.Value == null)
                throw new ArgumentNullException(nameof(shipDate), "Property is not nullable for class Order.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class Order.");

            if (complete.IsSet && complete.Value == null)
                throw new ArgumentNullException(nameof(complete), "Property is not nullable for class Order.");

            return new Order(id, petId, quantity, shipDate, status, complete); // a
        }

        /// <summary>
        /// Serializes a <see cref="Order" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="order"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Order order, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, order, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Order" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="order"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, Order order, JsonSerializerOptions jsonSerializerOptions)
        {
            if (order.IdOption.IsSet)
                writer.WriteNumber("id", order.IdOption.Value!.Value); // 3

            if (order.PetIdOption.IsSet)
                writer.WriteNumber("petId", order.PetIdOption.Value!.Value); // 3

            if (order.QuantityOption.IsSet)
                writer.WriteNumber("quantity", order.QuantityOption.Value!.Value); // 3

            if (order.ShipDateOption.IsSet)
                writer.WriteString("shipDate", order.ShipDateOption.Value!.Value.ToString(ShipDateFormat)); // 5

            var statusRawValue = Order.StatusEnumToJsonValue(order.StatusOption.Value!.Value); // 7
            if (statusRawValue != null)
                writer.WriteString("status", statusRawValue);
            else
                writer.WriteNull("status");

            if (order.CompleteOption.IsSet)
                writer.WriteBoolean("complete", order.CompleteOption.Value!.Value); // 2
        }
    }

    /// <summary>
    /// The OrderSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(Order))]
    public partial class OrderSerializationContext : JsonSerializerContext { }
}
