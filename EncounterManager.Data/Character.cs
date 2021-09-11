using System;
using System.ComponentModel.DataAnnotations;

namespace EncounterManager.Data
{
    public class Character {
        public Character() { CurrHP = MaxHP; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int IniBonus { get; set; }
        public int CurrIni { get; set; }
        [Required]
        public int MaxHP { get; set; }
        public int CurrHP { get; set; }
        //public int Id { get; set; }
    }
}
