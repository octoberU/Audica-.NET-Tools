using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace AudicaTools
{
    [Serializable]
    public class Difficulty
    {
        public List<Cue> cues;
        public List<Cue> repeaters;
        public float targetSpeed;

        public MemoryStream GetMemoryStream()
        {
            var jsonString = JsonConvert.SerializeObject(this);
            return Utility.GenerateStreamFromString(jsonString);
        }
    }

}