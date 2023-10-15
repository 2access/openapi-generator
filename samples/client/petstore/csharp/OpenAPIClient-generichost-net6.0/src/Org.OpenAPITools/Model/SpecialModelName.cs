// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

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
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// SpecialModelName
    /// </summary>
    public partial class SpecialModelName : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialModelName" /> class.
        /// </summary>
        /// <param name="varSpecialModelName">varSpecialModelName</param>
        /// <param name="specialPropertyName">specialPropertyName</param>
        [JsonConstructor]
        public SpecialModelName(Option<string> varSpecialModelName = default, Option<long> specialPropertyName = default)
        {
            VarSpecialModelName = varSpecialModelName;
            SpecialPropertyName = specialPropertyName;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets VarSpecialModelName
        /// </summary>
        [JsonPropertyName("_special_model.name_")]
        public Option<string> VarSpecialModelName { get; set; }

        /// <summary>
        /// Gets or Sets SpecialPropertyName
        /// </summary>
        [JsonPropertyName("$special[property.name]")]
        public Option<long> SpecialPropertyName { get; set; }

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
            sb.Append("class SpecialModelName {\n");
            sb.Append("  VarSpecialModelName: ").Append(VarSpecialModelName).Append("\n");
            sb.Append("  SpecialPropertyName: ").Append(SpecialPropertyName).Append("\n");
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
    /// A Json converter for type <see cref="SpecialModelName" />
    /// </summary>
    public class SpecialModelNameJsonConverter : JsonConverter<SpecialModelName>
    {
        /// <summary>
        /// Deserializes json to <see cref="SpecialModelName" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override SpecialModelName Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> varSpecialModelName = default;
            Option<long?> specialPropertyName = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "_special_model.name_":
                            varSpecialModelName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "$special[property.name]":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                specialPropertyName = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (varSpecialModelName.Value == null)
                throw new ArgumentNullException(nameof(varSpecialModelName), "Property is not nullable for class SpecialModelName.");

            if (specialPropertyName.Value == null)
                throw new ArgumentNullException(nameof(specialPropertyName), "Property is not nullable for class SpecialModelName.");

            Option<string> varSpecialModelNameParsedValue = new Option<string>(varSpecialModelName.Value);
            Option<long> specialPropertyNameParsedValue = new Option<long>(specialPropertyName.Value.Value);

            return new SpecialModelName(varSpecialModelNameParsedValue, specialPropertyNameParsedValue);
        }

        /// <summary>
        /// Serializes a <see cref="SpecialModelName" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="specialModelName"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, SpecialModelName specialModelName, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, specialModelName, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="SpecialModelName" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="specialModelName"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, SpecialModelName specialModelName, JsonSerializerOptions jsonSerializerOptions)
        {
            if (specialModelName.VarSpecialModelName.Value == null)
                throw new ArgumentNullException(nameof(specialModelName.VarSpecialModelName), "Property is required for class SpecialModelName.");

            if (specialModelName.VarSpecialModelName.IsSet)
                writer.WriteString("_special_model.name_", specialModelName.VarSpecialModelName.Value);
            if (specialModelName.SpecialPropertyName.IsSet)
                writer.WriteNumber("$special[property.name]", specialModelName.SpecialPropertyName.Value);
        }
    }
}
