using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChordsTransposer.Models
{
    public class Note
    {
        public static readonly List<string> possibleNoteNames = new List<string> { "H", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "B" };
        private string noteName;

        public Note(string noteName)
        {
            if (possibleNoteNames.Contains(noteName))
            {
                this.noteName = noteName;
            }
            else
            {
                //should return oufOfRange
            }
        }

    }
    public class PossibleNotesInitialiser
    {

        public static readonly List<Note> possibleNotes = new List<Note>();

        public PossibleNotesInitialiser()
       {
            foreach (string noteName in Note.possibleNoteNames)
            {
                if (Note.possibleNoteNames.Contains(noteName))
                {
                    continue;
                }
                else
                    possibleNotes.Add(new Note(noteName));
            }
        }
    }
}