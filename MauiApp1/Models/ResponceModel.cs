﻿using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;

namespace MauiApp1
{


    public partial class Response
    {
        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("current")]
        public Current Current { get; set; }
    }

    public partial class Current
    {
        [JsonProperty("last_updated_epoch")]
        public long LastUpdatedEpoch { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("temp_c")]
        public double TempC { get; set; }

        [JsonProperty("temp_f")]
        public double TempF { get; set; }

        [JsonProperty("is_day")]
        public long IsDay { get; set; }

        [JsonProperty("condition")]
        public Condition Condition { get; set; }

        [JsonProperty("wind_mph")]
        public double WindMph { get; set; }

        [JsonProperty("wind_kph")]
        public double WindKph { get; set; }

        [JsonProperty("wind_degree")]
        public long WindDegree { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }

        [JsonProperty("pressure_mb")]
        public long PressureMb { get; set; }

        [JsonProperty("pressure_in")]
        public double PressureIn { get; set; }

        [JsonProperty("precip_mm")]
        public double PrecipMm { get; set; }

        [JsonProperty("precip_in")]
        public long PrecipIn { get; set; }

        [JsonProperty("humidity")]
        public long Humidity { get; set; }

        [JsonProperty("cloud")]
        public long Cloud { get; set; }

        [JsonProperty("feelslike_c")]
        public double FeelslikeC { get; set; }

        [JsonProperty("feelslike_f")]
        public double FeelslikeF { get; set; }

        [JsonProperty("windchill_c")]
        public double WindchillC { get; set; }

        [JsonProperty("windchill_f")]
        public double WindchillF { get; set; }

        [JsonProperty("heatindex_c")]
        public double HeatindexC { get; set; }

        [JsonProperty("heatindex_f")]
        public double HeatindexF { get; set; }

        [JsonProperty("dewpoint_c")]
        public double DewpointC { get; set; }

        [JsonProperty("dewpoint_f")]
        public double DewpointF { get; set; }

        [JsonProperty("vis_km")]
        public long VisKm { get; set; }

        [JsonProperty("vis_miles")]
        public long VisMiles { get; set; }

        [JsonProperty("uv")]
        public double Uv { get; set; }

        [JsonProperty("gust_mph")]
        public double GustMph { get; set; }

        [JsonProperty("gust_kph")]
        public long GustKph { get; set; }
    }

    public partial class Condition
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("code")]
        public long Code { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("tz_id")]
        public string TzId { get; set; }

        [JsonProperty("localtime_epoch")]
        public long LocaltimeEpoch { get; set; }

        [JsonProperty("localtime")]
        public string Localtime { get; set; }
    }
}