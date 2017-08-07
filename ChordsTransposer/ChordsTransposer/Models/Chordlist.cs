using System;
using System.Collections.Generic;

namespace ChordsTransposer.Models
{
    public class ChordList
    {
        private string userChords;
        private List<string> stringsInserted = new List<string>();
        public List<string> chordsNamesInserted = new List<string>();
        private List<string> chordsCharactersInserted = new List<string>();
        private List<Chord> chordsInserted = new List<Chord>();

        internal List<Chord> ChordsInserted
        {
            get { return chordsInserted; }
        }

        public string UserChords
        {
            get { return userChords; }
            set { this.userChords = UserChords; }
        }

        public ChordList(string userChords)
        {
            //stringsInserted = new List<string>();
            //chordsNamesInserted = new List<string>();
            //chordsCharactersInserted = new List<string>();
            //chordsInserted = new List<Chord>();

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

