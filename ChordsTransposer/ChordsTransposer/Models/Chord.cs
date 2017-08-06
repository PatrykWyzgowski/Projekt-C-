using ChordsTransposer.Models;
using System.Collections.Generic;
namespace ChordsTransposer.Models
{
    public class Chord
    {
        internal Note chordName { get; set; }
        internal string chordCharacter { get; set; }
        //private PossibleNotesInitialiser initialiser = new PossibleNotesInitialiser();

        public Chord(Note chordName)
        {
            this.chordName = chordName;
            chordCharacter = "";
        }

        public Chord(Note chordName, string chordCharacter)
        {
            this.chordName = chordName;
            this.chordCharacter = chordCharacter;
        }

        void TransposeBySemitones(int semitones)
        {
            for (int i = 0; i < 12; i++)
            {
                int temp = (i + semitones) % 12;

                if (Note.possibleNoteNames[i] == chordName.noteName)
                {
                    chordName.noteName = Note.possibleNoteNames[temp];
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