using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;


namespace bb_exporter;

public class LongToStringConverter : JsonConverter<long>
{
    public override void WriteJson(JsonWriter writer, long value, JsonSerializer serializer)
    {
        writer.WriteValue(value.ToString());
    }

    public override long ReadJson(JsonReader reader, Type objectType, long existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        if(reader.TokenType == JsonToken.String)
        {
            if(long.TryParse(reader.Value?.ToString(), out var result))
            {
                return result;
            }
        }

        return Convert.ToInt64(reader.Value);
    }
}