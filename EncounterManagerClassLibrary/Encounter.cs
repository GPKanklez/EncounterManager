using System;
using System.Collections.Generic;
using System.Text;

namespace EncounterManager
{
    class Encounter
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
        
        private string _name;
        private List<Character> _characters = new List<Character>();
    }
}
