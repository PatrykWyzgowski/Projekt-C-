using System;
using System.Collections.Generic;

namespace ChordsTransposer.Models
{
    internal class ChordList
    {
        private string userChords = "";
        private List<string> stringsInserted = new List<string>();
        private List<string> chordsNamesInserted = new List<string>();
        private List<string> chordsCharactersInserted = new List<string>();
        private List<Chord> chordsInserted = new List<Chord>();

        public List<Chord> ChordsInserted
        {
            get { return chordsInserted; }
        }

        public ChordList(string userChords)
        {
            foreach (string chordString in userChords.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
            {
                stringsInserted.Add(chordString);
            }

            foreach (string chordNameString in userChords.Split(new char[] { ' ', 'm' }, StringSplitOptions.RemoveEmptyEntries))
            {
                chordsNamesInserted.Add(chordNameString);
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

