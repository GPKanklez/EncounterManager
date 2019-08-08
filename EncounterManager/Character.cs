using System;

namespace EncounterManager
{
    public class Character {
        public Character() { }
        
        public string Name { get; set; }
        public int IniBonus { get; set; }
        public int CurrIni { get; set; }
        public int MaxHP { get; set; }
        public int CurrHP { get; set; }
        //public int Id { get; set; }
    }
}
