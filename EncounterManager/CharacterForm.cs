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

namespace EncounterManager
{
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
        }

        public CharacterForm(Character character)
        {
            InitializeComponent();
            try
            {
                _nameBox.Text = character.Name;
                _iniBonusBox.Text = character.IniBonus.ToString();
                _hpBox.Text = character.MaxHP.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could Not Load Character", "Error", MessageBoxButtons.OK);
            }
        }

        private void _cancelBtn_Click( object sender, EventArgs e )
        {
            Close();
        }

        private void OnSave( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            try
            {
                Character character = new Character
                {
                    Name = _nameBox.Text,
                    IniBonus = TryParse(_iniBonusBox),
                    CurrIni = 0,
                    MaxHP = TryParse(_hpBox),
                    CurrHP = TryParse(_hpBox)
                };
                Character = character;
            } catch (Exception ex)
            {
                MessageBox.Show("Could Not Save Character", "Error", MessageBoxButtons.OK);
            }
        }

        private int TryParse( TextBox box )
        {
            var result = Int32.TryParse(box.Text, out int value);
            if (!result)
            {
                throw new Exception();
            }
            return value;
        }

        public Character Character { get; set; }
        //TODO Validate null entries/ default them to 0

        private void _nameBox_Validating( object sender, CancelEventArgs e )
        {
            var textbox = sender as TextBox;
            if (String.IsNullOrEmpty(textbox.Text))
            {
                _errorProvider.SetError(textbox, "All Fields Required");
                e.Cancel = true;
            } else
                _errorProvider.SetError(textbox, "");
        }

        private void _iniBonusBox_Validating( object sender, CancelEventArgs e )
        {
            var textbox = sender as TextBox;
            var match = Regex.Match(textbox.Text, "-?[0-9]", RegexOptions.IgnoreCase);
            if (String.IsNullOrEmpty(textbox.Text))
            {
                _errorProvider.SetError(textbox, "All Fields Required");
                e.Cancel = true;
            } 
            else if (!match.Success)
            {
                _errorProvider.SetError(textbox, "May only contain numbers");
                e.Cancel = true;
            }
            else
                _errorProvider.SetError(textbox, "");
        }

        private void _hpBox_Validating( object sender, CancelEventArgs e )
        {
            var textbox = sender as TextBox;
            var result = Int32.TryParse(textbox.Text, out int value);
            var match = Regex.Match(textbox.Text, "[^0-9]", RegexOptions.IgnoreCase);

            if (match.Success)
            {
                _errorProvider.SetError(textbox, "May only contain numbers");
                e.Cancel = true;
            } else if (!result)
            {
                _errorProvider.SetError(textbox, "All Fields Required");
                e.Cancel = true;
            } else if(value <= 0)
            {
                _errorProvider.SetError(textbox, "HP cannot be negative");
                e.Cancel = true;
            }
            else
                _errorProvider.SetError(textbox, "");
        }
    }
}
