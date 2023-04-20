using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Core.Models
{
    public class WeatherResponse
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("cod")]
        public long Cod { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("list")]
        public ListResult[] ListResults { get; set; }
    }

    public class ListResult
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("coord")]
        public Coord Coord { get; set; }

        [JsonPropertyName("main")]
        public Main Main { get; set; }

        [JsonPropertyName("dt")]
        public long Dt { get; set; }

        [JsonPropertyName("wind")]
        public Wind Wind { get; set; }

        [JsonPropertyName("sys")]
        public Sys Sys { get; set; }

        #nullable enable
        [JsonPropertyName("rain"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ConditionWithinTime? Rain { get; set; }

        [JsonPropertyName("snow"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ConditionWithinTime? Snow { get; set; }

        [JsonPropertyName("base"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Base { get; set; }

        #nullable disable
        [JsonPropertyName("clouds")]
        public Clouds Clouds { get; set; }

        [JsonPropertyName("weather")]
        public List<Weather> Weather { get; set; }

        
    }

    public class Clouds
    {
        [JsonPropertyName("all")]
        public int All { get; set; }
    }

    public class Coord
    {
        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        [JsonPropertyName("lon")]
        public double Lon { get; set; }
    }

    public class Main
    {
        [JsonPropertyName("temp")]
        public double Temp { get; set; }

        [JsonPropertyName("feels_like")]
        public double FeelsLike { get; set; }

        [JsonPropertyName("temp_min")]
        public double TempMin { get; set; }

        [JsonPropertyName("temp_max")]
        public double TempMax { get; set; }

        [JsonPropertyName("pressure")]
        public int Pressure { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }

        [JsonPropertyName("sea_level")]
        public int SeaLevel { get; set; }

        [JsonPropertyName("grnd_level")]
        public int GrndLevel { get; set; }
    }

    public class ConditionWithinTime
    {
        [JsonPropertyName("1h")]
        public double LastOneHour { get; set; }

        [JsonPropertyName("3h")]
        public double LastThreeHours { get; set; }
    }

    public class Sys
    {
        #nullable enable
        [JsonPropertyName("type"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? Type { get; set; }

        [JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? Id { get; set; }
        
        [JsonPropertyName("sunrise"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? Sunrise { get; set; }

        [JsonPropertyName("sunset"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? Sunset { get; set; }

        #nullable disable
        [JsonPropertyName("country")]
        public string Country { get; set; }

    }

    public class Weather
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("main")]
        public string Main { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }

    public class Wind
    {
        [JsonPropertyName("speed")]
        public double Speed { get; set; }

        [JsonPropertyName("deg")]
        public long Deg { get; set; }
    }
}

