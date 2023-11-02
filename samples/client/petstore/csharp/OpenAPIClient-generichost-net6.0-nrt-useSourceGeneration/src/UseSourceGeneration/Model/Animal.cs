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
    /// Animal
    /// </summary>
    public partial class Animal : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Animal" /> class.
        /// </summary>
        /// <param name="className">className</param>
        /// <param name="color">color (default to &quot;red&quot;)</param>
        [JsonConstructor]
        public Animal(string className, Option<string?> color = default)
        {
            ClassName = className;
            ColorOption = color;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets ClassName
        /// </summary>
        [JsonPropertyName("className")]
        public string ClassName { get; set; } // d

        /// <summary>
        /// Used to track the state of Color
        /// </summary>
        [JsonIgnore]
        public Option<string?> ColorOption { get; private set; } // option d

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [JsonPropertyName("color")]
        public string? Color { get { return this. ColorOption; } set { this.ColorOption = new(value); } } // d

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
            sb.Append("class Animal {\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Animal" />
    /// </summary>
    public class AnimalJsonConverter : JsonConverter<Animal>
    {
        /// <summary>
        /// Deserializes json to <see cref="Animal" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Animal Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> className = default;
            Option<string?> color = default;

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
                        case "className":
                            className = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "color":
                            color = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!className.IsSet)
                throw new ArgumentException("Property is required for class Animal.", nameof(className));

            if (className.IsSet && className.Value == null)
                throw new ArgumentNullException(nameof(className), "Property is not nullable for class Animal.");

            if (color.IsSet && color.Value == null)
                throw new ArgumentNullException(nameof(color), "Property is not nullable for class Animal.");

            return new Animal(className.Value!, color); // a
        }

        /// <summary>
        /// Serializes a <see cref="Animal" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="animal"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Animal animal, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, animal, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Animal" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="animal"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, Animal animal, JsonSerializerOptions jsonSerializerOptions)
        {
            if (animal.ClassName == null)
                throw new ArgumentNullException(nameof(animal.ClassName), "Property is required for class Animal.");

            if (animal.ColorOption.IsSet && animal.Color == null)
                throw new ArgumentNullException(nameof(animal.Color), "Property is required for class Animal.");

            writer.WriteString("className", animal.ClassName); // 1

            if (animal.ColorOption.IsSet)
                writer.WriteString("color", animal.Color); // 1
        }
    }

    /// <summary>
    /// The AnimalSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(Animal))]
    public partial class AnimalSerializationContext : JsonSerializerContext { }
}
