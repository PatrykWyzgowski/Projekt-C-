using System;
using System.Collections.Generic;

namespace ChordsTransposer.Models
{
    public class ChordList
    {
        public string userChords = "";
        public List<string> stringsInserted = new List<string>();
        public List<string> chordsNamesInserted = new List<string>();
        public List<string> chordsCharactersInserted = new List<string>();
        public List<string> chordsInserted = new List<string>();

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
                chordsInserted.Insert(i, chordsNamesInserted[i] + chordsCharactersInserted[i]);
            }
        }
    }
}