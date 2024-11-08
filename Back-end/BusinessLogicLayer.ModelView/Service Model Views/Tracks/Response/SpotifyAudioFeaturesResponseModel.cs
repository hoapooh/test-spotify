﻿using Newtonsoft.Json;

namespace BusinessLogicLayer.ModelView.Service_Model_Views.Tracks.Response
{
    public class SpotifyAudioFeaturesResponseModel
    {
        [JsonProperty("acousticness")]
        public float Acousticness { get; set; }

        [JsonProperty("danceability")]
        public float Danceability { get; set; }

        [JsonProperty("duration_ms")]
        public int Duration { get; set; }

        [JsonProperty("energy")]
        public float Energy { get; set; }

        [JsonProperty("instrumentalness")]
        public float Instrumentalness { get; set; }

        [JsonProperty("key")]
        public int Key { get; set; }

        [JsonProperty("liveness")]
        public float Liveness { get; set; }

        [JsonProperty("loudness")]
        public float Loudness { get; set; }

        [JsonProperty("mode")]
        public int Mode { get; set; }

        [JsonProperty("speechiness")]
        public float Speechiness { get; set; }

        [JsonProperty("tempo")]
        public float Tempo { get; set; }

        [JsonProperty("time_signature")]
        public int TimeSignature { get; set; }

        [JsonProperty("valence")]
        public float Valence { get; set; }
    }
}
