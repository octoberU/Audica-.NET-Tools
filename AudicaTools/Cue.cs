using System;
using System.Numerics;
namespace AudicaTools
{
    [Serializable]
    public class Cue
    {
        public float tick;
        public float tickLength;
        public int pitch;
        public int velocity;
        public Vector2 gridOffset;
        public float zOffset;
        public int handType;
        public int behavior;
    }

}