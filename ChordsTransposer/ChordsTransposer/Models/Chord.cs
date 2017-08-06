﻿using ChordsTransposer.Models;
using System.Collections.Generic;
namespace ChordsTransposer.Models
{
    public class Chord
    {
        private Note chordName { get; set; }
        private int chordCharacter { get; set; }
        //private PossibleNotesInitialiser initialiser = new PossibleNotesInitialiser();

        public Chord(Note chordName)
    {
            this.chordName = chordName;
            chordCharacter = 0;
    }
    
    public Chord(Note chordName,int chordCharacter)
        {
            this.chordName = chordName;
            this.chordCharacter = chordCharacter;
        }

    public void TransposeBySemitones(int semitones)
        {
            for (int i = 0; i < 12; i++)
            {
                if (PossibleNotesInitialiser.possibleNotes[i] ==chordName)
                {
                    i+=semitones;
                    chordName = PossibleNotesInitialiser.possibleNotes[i];
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