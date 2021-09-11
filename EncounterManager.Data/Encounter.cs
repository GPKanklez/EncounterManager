using System;
using System.Collections.Generic;
using System.Text;

namespace EncounterManager.Data
{
    public class Encounter
    {
        public Encounter() {
            Characters = new List<Character>();
        }
        public List<Character> Characters { get; set; }
        public string FilePath { get; set; }       
        public string Name { get; set; }

        public void SwapCharacters(int startIndex, int endIndex) 
        {
            //Could throw custom exceptions here, but this shouldn't be able to fail if it's called correctly
            var character = Characters[startIndex];
            Characters.RemoveAt(startIndex);
            Characters.Insert(endIndex, character);
        }

    }
}
