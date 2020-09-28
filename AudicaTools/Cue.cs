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
        public GridOffset gridOffset;
        public float zOffset;
        public int handType;
        public int behavior;

        [Serializable]
        public struct GridOffset
        {
            public float x;
            public float y;
        }
    }

}