using ChordsTransposer.Models;
using System.Collections.Generic;
using System;
namespace ChordsTransposer.Models
{
    internal class Chord : Note
    {
        private string chordCharacter;

        public string ChordCharacter
        {
            get { return chordCharacter; }
        }


        public Chord(string chordName) : base(chordName)
        {
            chordCharacter = "";
        }

        public Chord(string chordName, string chordCharacter) : base(chordName)
        {
            this.chordCharacter = chordCharacter;
        }

        public void TransposeBySemitones(int semitones)
        {
            for (int i = 0; i < 12; i++)
            {
                if (String.Equals(PossibleNoteNames[i], NoteName, StringComparison.OrdinalIgnoreCase))
                {
                    int temp = (i + (semitones >= 0 ? semitones : (semitones + 12))) % 12;
                    NoteName = PossibleNoteNames[temp];
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}