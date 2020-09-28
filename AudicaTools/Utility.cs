using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AudicaTools
{
    internal static class Utility
    {
        public static MemoryStream GenerateStreamFromString(string value)
        {
            return new MemoryStream(Encoding.UTF8.GetBytes(value ?? ""));
        }
    }
}
