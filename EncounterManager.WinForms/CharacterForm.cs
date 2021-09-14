using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EncounterManager.Data;

namespace EncounterManager
{
    public partial class CharacterForm : Form
    {
        public Character Character { get; set; }
        private Character _backup { get; set; }
        public CharacterForm()
        {
            InitializeComponent();
            Character = new Character();
            BindControls();
        }

        public CharacterForm(Character character)
        {
            InitializeComponent();
            Character = new Character(character);
            _backup = character;
            BindControls();
        }

        protected void BindControls()
        {
            var nameBinding = new Binding("Text", Character, "Name");
            _nameBox.DataBindings.Add(nameBinding);
            var iniBinding = new Binding("Text", Character, "IniBonus");
            _iniBonusBox.DataBindings.Add(iniBinding);
            var hpBinding = new Binding("Text", Character, "MaxHp");
            _hpBox.DataBindings.Add(hpBinding);
            var acBinding = new Binding("Text", Character, "AC");
            tbAC.DataBindings.Add(acBinding);

        }

        private void _cancelBtn_Click( object sender, EventArgs e )
        {
            Character = _backup;
            Close();
        }

        private void OnSave( object sender, EventArgs e )
        {
            if (_nameBox.Text != "")
            {
                Character.CurrHP = Character.MaxHP;
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                _errorProvider.SetError(_nameBox, "Name cannot be blank");
            }
            
        }

    }
}
