using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChordsTransposer.Models
{
    internal class Chord
    {
        private Note chordName { get; set; }
        private bool chordCharacter { get; set; }

    public Chord(Note chordName)
    {
        this.chordName = chordName;
            chordCharacter = true;
    }
    
    public Chord(Note chordName,bool chordCharacter)
        {
            this.chordName = chordName;
            this.chordCharacter = chordCharacter;
        }
}
}