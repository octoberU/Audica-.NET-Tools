using System;

namespace AudicaTools
{
    public class TempoData
    {
        public int tick;
        public UInt64 microsecondsPerQuarterNote;

        public TempoData(int tick, ulong microsecondsPerQuarterNote)
        {
            this.tick = tick;
            this.microsecondsPerQuarterNote = microsecondsPerQuarterNote;
        }

        public static double GetBPMFromMicrosecondsPerQuaterNote(UInt64 microsecondsPerQuarterNote)
        {
            return (double)60000000 / microsecondsPerQuarterNote;
        }

        public static UInt64 MicrosecondsPerQuarterNoteFromBPM(double bpm)
        {
            if (bpm == 0) { return 0; }
            return (UInt64)Math.Round((double)60000000 / bpm);
        }
    }
}
