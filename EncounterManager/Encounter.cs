using System;
using System.Collections.Generic;
using System.Text;

namespace EncounterManager
{
    public class Encounter
    {
        public Encounter() { }

        public List<Character> Characters
        {
            get
            {
                return _characters;
            }
            set
            {
                _characters.Clear();
                foreach (var chrc in value)
                {
                    _characters.Add(chrc);
                }
            }
        }
        public string FilePath { get; set; }       
        public string Name { get; set; }

        private List<Character> _characters = new List<Character>();
    }
}
