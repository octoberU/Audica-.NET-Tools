using System;
using System.Collections.Generic;
namespace AudicaTools
{
    [Serializable]
    public class Difficulty
    {
        public List<Cue> cues;
        public List<Cue> repeaters;
        public float targetSpeed;
    }

}