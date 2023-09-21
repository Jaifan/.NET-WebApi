using System.Text.Json.Serialization;

namespace test.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MvpClass
    {
        frontend = 1,
        backend = 2,
        fullstack = 3,
    }
}