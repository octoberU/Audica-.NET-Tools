using System;
using System.IO;
using System.IO.Compression;
using NAudio.Midi;
using Newtonsoft.Json;
namespace AudicaTools
{
    public class Audica
    {
        public Difficulty beginner;
        public Difficulty moderate;
        public Difficulty advanced;
        public Difficulty expert;

        public MidiFile midi;

        public Description desc;

        public MoggSong moggSong;
        public MoggSong moggSongSustainL;
        public MoggSong moggSongSustainR;

        public Mogg song;
        public Mogg songSustainL;
        public Mogg songSustainR;

        public Audica(string filePath)
        {
            CheckPath(filePath);
            ZipArchive zip = ZipFile.OpenRead(filePath);
            this.desc = ReadJsonEntry<Description>(zip, "song.desc");
            this.expert = ReadJsonEntry<Difficulty>(zip, "expert.cues");
            this.advanced = ReadJsonEntry<Difficulty>(zip, "advanced.cues");
            this.moderate = ReadJsonEntry<Difficulty>(zip, "moderate.cues");
            this.beginner = ReadJsonEntry<Difficulty>(zip, "beginner.cues");
            this.moggSong = new MoggSong(zip.GetEntry(this.desc.moggSong).Open());
            //this.moggSongSustainL = new MoggSong(zip.GetEntry(this.desc.sustainSongLeft).Open());
            //this.moggSongSustainR = new MoggSong(zip.GetEntry(this.desc.sustainSongRight).Open());
        }

        private static void CheckPath(string filePath)
        {
            if (!File.Exists(filePath))
                throw new ArgumentException("Audica file path doesn't exist", filePath);
            else if (!filePath.Contains(".audica"))
                throw new ArgumentException("File path doesn't lead to an .audica file", filePath);
        }

        private static T ReadJsonEntry<T>(ZipArchive zip, string entryName)
        {
            if (zip.GetEntry(entryName) == null) return default(T);
            var descStream = zip.GetEntry(entryName)
                .Open();
            using (var reader = new StreamReader(descStream))
            {
                string text = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(text);
            }
        }

        public static Description GetDescOnly(string filePath)
        {
            CheckPath(filePath);
            ZipArchive zip = ZipFile.OpenRead(filePath);
            return ReadJsonEntry<Description>(zip, "song.desc");
        }
    }

}