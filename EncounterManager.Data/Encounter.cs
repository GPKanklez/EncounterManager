using System;
using System.Collections.Generic;
using System.Text;

namespace EncounterManager.Data
{
    public class Encounter : BaseModel
    {
        public Encounter() {
            Characters = new List<Character>();
        }
        public List<Character> Characters { get; set; }
        public string Name { get; set; }

        public void SwapCharacters(int startIndex, int endIndex) 
        {
            //Could throw custom exceptions here, but this shouldn't be able to fail if it's called correctly
            var character = Characters[startIndex];
            Characters.RemoveAt(startIndex);
            Characters.Insert(endIndex, character);
        }
        /// <summary>
        /// Adds the list of characters from passed encounter to this encounter.
        /// </summary>
        /// <param name="encounter"></param>
        public void Merge(Encounter encounter) 
        {
            Characters.AddRange(encounter.Characters);
        }

    }
}
