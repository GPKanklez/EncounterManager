using System;

namespace EncounterManager
{
    public class Character {
        public Character() { }
        
        public string Name { get; set; }
        public int IniBonus { get; set; }
        public int MaxHP { get; set; }

        private int _id;
    }
}
