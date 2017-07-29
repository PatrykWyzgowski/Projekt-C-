using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChordsTransposer.Models
{
    public class Note
    {
        private readonly List<string> possibleNotes =new List<string> {"H","C","C#","D","D#","E","F","F#","G","G#","A","B"};
        private string noteName;

        public Note(string noteName)
        {
            if (possibleNotes.Contains(noteName))
            {
                this.noteName = noteName;
            }
            else
            {
                //return oufOfRange
            }
        }
    }
}