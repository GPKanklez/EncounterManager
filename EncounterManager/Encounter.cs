using System;
using System.Collections.Generic;
using System.Text;

namespace EncounterManager
{
    public class Encounter
    {
        public Encounter() {
            Characters = new List<Character>();
        }
        public List<Character> Characters { get; set; }
        public string FilePath { get; set; }       
        public string Name { get; set; }

    }
}
