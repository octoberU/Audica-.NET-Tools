using System;
using System.IO;
namespace AudicaTools
{
    public class Mogg
    {
        public byte[] bytes;

        public Mogg(byte[] bytes)
        {
            this.bytes = bytes;
        }

        public void ExportToOgg(string filePath)
        {
            //ogg export courtesy of the Audica Modding Discord
            byte[] oggStartLocation = new byte[4];

            oggStartLocation[0] = bytes[4];
            oggStartLocation[1] = bytes[5];
            oggStartLocation[2] = bytes[6];
            oggStartLocation[3] = bytes[7];

            int start = BitConverter.ToInt32(oggStartLocation, 0);

            byte[] dst = new byte[bytes.Length - start];
            Array.Copy(bytes, start, dst, 0, dst.Length);
            File.WriteAllBytes(filePath, dst);
        }
    }

}