using System.Text.Json;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Text.Json.Serialization;

namespace WDevOrg.Models
{
    /// <summary>
    /// A JSON object from editor.js
    /// </summary>
    public class EditorJson
    {
        [JsonPropertyName("time")]
        public long Time { get; set; }

        [JsonPropertyName("blocks")]
        public List<Block> Blocks { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
    /// <summary>
    /// A single editor.js block
    /// </summary>
    public class Block
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("data")]
        public BlockData Data { get; set; }
    }
    /// <summary>
    /// A single block's data
    /// </summary>
    public class BlockData
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("level")]
        public int? Level { get; set; }

        [JsonPropertyName("style")]
        public string Style { get; set; }

        [JsonPropertyName("items")]
        public List<string> Items { get; set; }
    }

    /// <summary>
    /// A converter for the database
    /// </summary>
    public class EditorJsonConverter : ValueConverter<EditorJson, string>
    {
        public EditorJsonConverter() : base(
            v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
            v => JsonSerializer.Deserialize<EditorJson>(v, (JsonSerializerOptions)null)
           )
        {
        }
    }
}