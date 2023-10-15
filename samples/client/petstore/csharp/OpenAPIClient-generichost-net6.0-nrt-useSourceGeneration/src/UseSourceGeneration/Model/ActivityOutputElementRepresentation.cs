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
    /// ActivityOutputElementRepresentation
    /// </summary>
    public partial class ActivityOutputElementRepresentation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityOutputElementRepresentation" /> class.
        /// </summary>
        /// <param name="prop1">prop1</param>
        /// <param name="prop2">prop2</param>
        [JsonConstructor]
        public ActivityOutputElementRepresentation(Option<string> prop1 = default, Option<Object> prop2 = default)
        {
            Prop1 = prop1;
            Prop2 = prop2;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Prop1
        /// </summary>
        [JsonPropertyName("prop1")]
        public Option<string> Prop1 { get; set; }

        /// <summary>
        /// Gets or Sets Prop2
        /// </summary>
        [JsonPropertyName("prop2")]
        public Option<Object> Prop2 { get; set; }

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
            sb.Append("class ActivityOutputElementRepresentation {\n");
            sb.Append("  Prop1: ").Append(Prop1).Append("\n");
            sb.Append("  Prop2: ").Append(Prop2).Append("\n");
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
    /// A Json converter for type <see cref="ActivityOutputElementRepresentation" />
    /// </summary>
    public class ActivityOutputElementRepresentationJsonConverter : JsonConverter<ActivityOutputElementRepresentation>
    {
        /// <summary>
        /// Deserializes json to <see cref="ActivityOutputElementRepresentation" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ActivityOutputElementRepresentation Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> prop1 = default;
            Option<Object?> prop2 = default;

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
                        case "prop1":
                            prop1 = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "prop2":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                prop2 = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (prop1.Value == null)
                throw new ArgumentNullException(nameof(prop1), "Property is not nullable for class ActivityOutputElementRepresentation.");

            if (prop2.Value == null)
                throw new ArgumentNullException(nameof(prop2), "Property is not nullable for class ActivityOutputElementRepresentation.");

            Option<string> prop1ParsedValue = new Option<string>(prop1.Value);
            Option<Object> prop2ParsedValue = new Option<Object>(prop2.Value);

            return new ActivityOutputElementRepresentation(prop1ParsedValue, prop2ParsedValue);
        }

        /// <summary>
        /// Serializes a <see cref="ActivityOutputElementRepresentation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="activityOutputElementRepresentation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ActivityOutputElementRepresentation activityOutputElementRepresentation, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, activityOutputElementRepresentation, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ActivityOutputElementRepresentation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="activityOutputElementRepresentation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, ActivityOutputElementRepresentation activityOutputElementRepresentation, JsonSerializerOptions jsonSerializerOptions)
        {
            if (activityOutputElementRepresentation.Prop1.Value == null)
                throw new ArgumentNullException(nameof(activityOutputElementRepresentation.Prop1), "Property is required for class ActivityOutputElementRepresentation.");

            if (activityOutputElementRepresentation.Prop2.Value == null)
                throw new ArgumentNullException(nameof(activityOutputElementRepresentation.Prop2), "Property is required for class ActivityOutputElementRepresentation.");

            if (activityOutputElementRepresentation.Prop1.IsSet)
                writer.WriteString("prop1", activityOutputElementRepresentation.Prop1.Value);
            if (activityOutputElementRepresentation.Prop2.IsSet)
                writer.WritePropertyName("prop2");
                JsonSerializer.Serialize(writer, activityOutputElementRepresentation.Prop2, jsonSerializerOptions);
        }
    }

    /// <summary>
    /// The ActivityOutputElementRepresentationSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(ActivityOutputElementRepresentation))]
    public partial class ActivityOutputElementRepresentationSerializationContext : JsonSerializerContext { }
}
