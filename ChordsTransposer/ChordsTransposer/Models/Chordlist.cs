using System;
using System.Collections.Generic;

namespace ChordsTransposer.Models
{
    public class ChordList
    {
        public string userChords = "";
        public List<string> stringsInserted = new List<string>();
        public List<Note> chordsNamesInserted = new List<Note>();
        public List<string> chordsCharactersInserted = new List<string>();
        public List<Chord> chordsInserted = new List<Chord>();

        public ChordList(string userChords)
        {
            foreach (string chordString in userChords.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
            {
                stringsInserted.Add(chordString);
            }

            foreach (string chordNameString in userChords.Split(new char[] { ' ', 'm' }, StringSplitOptions.RemoveEmptyEntries))
            {
                chordsNamesInserted.Add(new Note(chordNameString));
            }

            for (int i = 0; i < stringsInserted.Count; i++)
            {
                if (stringsInserted[i].Contains("m"))
                {
                    chordsCharactersInserted.Insert(i, "m");
                }
                else
                {
                    chordsCharactersInserted.Insert(i, "");
                }
            }

            for (int i = 0; i < chordsNamesInserted.Count; i++)
            {
                chordsInserted.Insert(i, new Chord(chordsNamesInserted[i], chordsCharactersInserted[i]));
            }
        }
    }
}

