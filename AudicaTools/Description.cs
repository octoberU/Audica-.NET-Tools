using System;
namespace AudicaTools
{
    [Serializable]
    public class Description
    {
        public string songID;
        public string moggSong;
        public string title;
        public string artist;
        public string author;
        public string midiFile;
        public string targetDrums;
        public string sustainSongLeft;
        public string sustainSongRight;
        public string fxSong;
        public string songEndEvent;
        public string highScoreEvent;
        public string songEndPitchAdjust;
        public float prerollSeconds;
        public double previewStartSeconds;
        public bool useMidiForCues;
        public bool hidden;
    }

}