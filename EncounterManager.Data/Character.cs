using System;
using System.ComponentModel.DataAnnotations;

namespace EncounterManager.Data
{
    public class Character : BaseModel
    {
        public Character() { }
        /// <summary>
        /// Returns a new instance of passed character
        /// </summary>
        /// <param name="character"></param>
        public Character(Character character) {
            Name = character.Name;
            IniBonus = character.IniBonus;
            CurrIni = character.CurrIni;
            MaxHP = character.MaxHP;
            CurrHP = character.CurrHP;
            AC = character.AC;
        }
        private string name;
        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string Name {
            get => name;
            set => SetProperty(ref name, value);
        }
        private int iniBonus;
        [Required]
        public int IniBonus {
            get => iniBonus;
            set => SetProperty(ref iniBonus, value);
        }
        public int CurrIni { get; set; }
        private int maxHP;
        [Required]
        public int MaxHP {
            get => maxHP;
            set => SetProperty(ref maxHP, value);
        }
        [Required]
        private int ac;
        public int AC
        {
            get => ac;
            set => SetProperty(ref ac, value);
        }
        [MaxLength(1500)]
        public string Notes { get; set; }
        public int CurrHP { get; set; }
        //public int Id { get; set; }
    }
}
