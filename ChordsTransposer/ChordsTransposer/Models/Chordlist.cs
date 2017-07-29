using System;
using System.Collections.Generic;

namespace ChordsTransposer.Models
{
    public class ChordList
    {
        private List<Chord> chordsInserted = new List<Chord>();
        //public string userChords = "";

        public ChordList(string userChords)
        {
            foreach (string chord in userChords.Split
                (new char[] {' ' }, StringSplitOptions.RemoveEmptyEntries))
            {
                chordsInserted.Add(new Chord(new Note(chord)));
            }
        }
    }
}