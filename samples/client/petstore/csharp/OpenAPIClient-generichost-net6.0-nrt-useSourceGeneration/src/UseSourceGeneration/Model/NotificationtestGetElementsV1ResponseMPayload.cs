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
    /// NotificationtestGetElementsV1ResponseMPayload
    /// </summary>
    public partial class NotificationtestGetElementsV1ResponseMPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationtestGetElementsV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aObjVariableobject">aObjVariableobject</param>
        /// <param name="pkiNotificationtestID">pkiNotificationtestID</param>
        [JsonConstructor]
        public NotificationtestGetElementsV1ResponseMPayload(List<Dictionary<string, Object>> aObjVariableobject, int pkiNotificationtestID)
        {
            AObjVariableobject = aObjVariableobject;
            PkiNotificationtestID = pkiNotificationtestID;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets AObjVariableobject
        /// </summary>
        [JsonPropertyName("a_objVariableobject")]
        public List<Dictionary<string, Object>> AObjVariableobject { get; set; } // d

        /// <summary>
        /// Gets or Sets PkiNotificationtestID
        /// </summary>
        [JsonPropertyName("pkiNotificationtestID")]
        public int PkiNotificationtestID { get; set; } // d

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
            sb.Append("class NotificationtestGetElementsV1ResponseMPayload {\n");
            sb.Append("  AObjVariableobject: ").Append(AObjVariableobject).Append("\n");
            sb.Append("  PkiNotificationtestID: ").Append(PkiNotificationtestID).Append("\n");
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
    /// A Json converter for type <see cref="NotificationtestGetElementsV1ResponseMPayload" />
    /// </summary>
    public class NotificationtestGetElementsV1ResponseMPayloadJsonConverter : JsonConverter<NotificationtestGetElementsV1ResponseMPayload>
    {
        /// <summary>
        /// Deserializes json to <see cref="NotificationtestGetElementsV1ResponseMPayload" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override NotificationtestGetElementsV1ResponseMPayload Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<Dictionary<string, Object>>?> aObjVariableobject = default;
            Option<int?> pkiNotificationtestID = default;

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
                        case "a_objVariableobject":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                aObjVariableobject = new Option<List<Dictionary<string, Object>>?>(JsonSerializer.Deserialize<List<Dictionary<string, Object>>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "pkiNotificationtestID":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                pkiNotificationtestID = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!aObjVariableobject.IsSet)
                throw new ArgumentException("Property is required for class NotificationtestGetElementsV1ResponseMPayload.", nameof(aObjVariableobject));

            if (!pkiNotificationtestID.IsSet)
                throw new ArgumentException("Property is required for class NotificationtestGetElementsV1ResponseMPayload.", nameof(pkiNotificationtestID));

            if (aObjVariableobject.IsSet && aObjVariableobject.Value == null)
                throw new ArgumentNullException(nameof(aObjVariableobject), "Property is not nullable for class NotificationtestGetElementsV1ResponseMPayload.");

            if (pkiNotificationtestID.IsSet && pkiNotificationtestID.Value == null)
                throw new ArgumentNullException(nameof(pkiNotificationtestID), "Property is not nullable for class NotificationtestGetElementsV1ResponseMPayload.");

            return new NotificationtestGetElementsV1ResponseMPayload(aObjVariableobject.Value!, pkiNotificationtestID.Value!.Value!); // a
        }

        /// <summary>
        /// Serializes a <see cref="NotificationtestGetElementsV1ResponseMPayload" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="notificationtestGetElementsV1ResponseMPayload"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, NotificationtestGetElementsV1ResponseMPayload notificationtestGetElementsV1ResponseMPayload, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, notificationtestGetElementsV1ResponseMPayload, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="NotificationtestGetElementsV1ResponseMPayload" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="notificationtestGetElementsV1ResponseMPayload"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, NotificationtestGetElementsV1ResponseMPayload notificationtestGetElementsV1ResponseMPayload, JsonSerializerOptions jsonSerializerOptions)
        {
            if (notificationtestGetElementsV1ResponseMPayload.AObjVariableobject == null)
                throw new ArgumentNullException(nameof(notificationtestGetElementsV1ResponseMPayload.AObjVariableobject), "Property is required for class NotificationtestGetElementsV1ResponseMPayload.");

            writer.WritePropertyName("a_objVariableobject");
            JsonSerializer.Serialize(writer, notificationtestGetElementsV1ResponseMPayload.AObjVariableobject, jsonSerializerOptions); // 13
            writer.WriteNumber("pkiNotificationtestID", notificationtestGetElementsV1ResponseMPayload.PkiNotificationtestID); // 3
        }
    }

    /// <summary>
    /// The NotificationtestGetElementsV1ResponseMPayloadSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(NotificationtestGetElementsV1ResponseMPayload))]
    public partial class NotificationtestGetElementsV1ResponseMPayloadSerializationContext : JsonSerializerContext { }
}
