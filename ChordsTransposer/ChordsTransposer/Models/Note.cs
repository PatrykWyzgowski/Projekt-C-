using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChordsTransposer.Models
{
    public class Note
    {
        internal static readonly List<string> possibleNoteNames = new List<string>
        { "H", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "B" };
        internal string noteName;

        public Note(string noteName)
        {
            bool noteOnList = possibleNoteNames.Any(s => s.Equals(noteName, StringComparison.OrdinalIgnoreCase));
            if (noteOnList)
            {
                this.noteName = noteName;
            }
            else
            {
                //here comes Da exception
                Console.WriteLine("You fool!");
            }
        }
    }
}