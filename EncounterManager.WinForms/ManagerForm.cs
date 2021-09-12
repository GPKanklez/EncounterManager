using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using System.Text.RegularExpressions;
using EncounterManager.Data;
using EncounterManager.Utils;

namespace EncounterManager
{
    public partial class Manager : Form
    {
        #region   Constructors
        public Manager()
        {
            InitializeComponent();
        }
        #endregion

        #region Load Form
        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            //create clean grid if loading from another encounter
            if (Encounter == null)
                Encounter = new Encounter();
           
            //update grid and binding source to empty state
            RefreshUI();
        }
        #endregion

        #region Tool Strip File
        private void _newEncounterToolStripMenuItem_Click( object sender, EventArgs e )
        {
            //warning message box
            var result = MessageBox.Show("Would you like start a new encounter and lose all unsaved actions?", "Lose Unsaved Progress?", MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
                return;

            //set form to new encounter
            Encounter encounter = new Encounter();
            Encounter = encounter;
            Text = "New Encounter";

            RefreshUI();
        }

        private void _saveEncounterToolStripMenuItem_Click( object sender, EventArgs e )
        {
            //create save pop up, starting where the program is saved, set to save .txt files if not specified
            var form = new SaveFileDialog
            {
                InitialDirectory = Environment.CurrentDirectory,
                DefaultExt = ".txt",
                Filter = "Text|*.txt|All|*.*",
                Title = "Save Encounter"
            };

            //show form
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            //try to save text
            try
            {
                //get encounter name, set window text to match encounter name
                Encounter.Name = Path.GetFileNameWithoutExtension(form.FileName);
                Text = Encounter.Name;

                //create document writer
                using (StreamWriter stream = new StreamWriter(form.FileName))
                {

                    //write encounter name
                    stream.WriteLine(Encounter.Name);

                    //write each character, and their attributes
                    foreach (Character chrc in Encounter.Characters)
                    {
                        stream.Write(chrc.Name + ",");
                        stream.Write(chrc.IniBonus + ",");
                        stream.WriteLine(chrc.MaxHP);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Saving Encounter", MessageBoxButtons.OK);
            }
        }

        private void _loadEncounterToolStripMenuItem_Click( object sender, EventArgs e )
        {
            //open folder where program is stored, show text files only first
            var form = new OpenFileDialog
            {
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "Text|*.txt|All|*.*",
                Title = "Load Encounter"
            };

            //show form
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            //get file path
            string name = form.FileName;            

            //try parse encounter
            try
            {
                //prepare new encounter shell 
                Encounter encounter = new Encounter();

                //parse csv format
                using (TextFieldParser parser = new TextFieldParser(name))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    encounter.Name = parser.ReadLine();
                    while (!parser.EndOfData)
                    {
                        Character character = new Character();
                        //Process row
                        string[] fields = parser.ReadFields();

                        character.Name = fields[0];
                        character.IniBonus = Convert.ToInt32(fields[1]);
                        character.MaxHP = Convert.ToInt32(fields[2]);
                        character.CurrHP = character.MaxHP;
                        character.CurrIni = 0;

                        encounter.Characters.Add(character);
                    }
                }

                Encounter = encounter;
                Text = Encounter.Name;
                RefreshUI();
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error Reading Encounter", ex.Message, MessageBoxButtons.OK);
            }
        }

        private void _mergeEncounterToolStripMenuItem_Click( object sender, EventArgs e )
        {
            //open file form, starting where program is saved, showing text files
            var form = new OpenFileDialog
            {
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "Text|*.txt|All|*.*",
                Title = "Merge Encounter"
            };

            //show form
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            //Try to parse file
            try
            {
                //get file path
                string name = form.FileName;

                //parse csv of encounter to merge into existing
                using (TextFieldParser parser = new TextFieldParser(name))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    parser.ReadLine();
                    while (!parser.EndOfData)
                    {
                        Character character = new Character();
                        //Process row
                        string[] fields = parser.ReadFields();

                        character.Name = fields[0];
                        character.IniBonus = Convert.ToInt32(fields[1]);
                        character.MaxHP = Convert.ToInt32(fields[2]);
                        character.CurrHP = character.MaxHP;
                        character.CurrIni = 0;

                        Encounter.Characters.Add(character);
                    }
                }
                RefreshUI();
            } catch  (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Reading Encounter", MessageBoxButtons.OK);
            }
        }
               
        private void _exitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            //show confirmation box get user response
            var result = MessageBox.Show("Exit and lose all unsaved progress?", "Close Program?", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
                return;

            //exit program
            Close();
        }
        #endregion

        #region Encounter Strip
        private void _rollSelectedInitiativeToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if(_dataGridViewManager.SelectedRows.Count == 0)
            {
                MessageBox.Show("No Character Selected", "Error", MessageBoxButtons.OK);
                return;
            }

            //prepare variables for intiative calculation
            int bonus = 0;
            int roll = 0;
            var rand = new Random();

            //roll initiative for each selected character
            foreach (DataGridViewRow row in _dataGridViewManager.SelectedRows)
            {
                //try parse int
                bonus = Convert.ToInt32(row.Cells[iniBonusDataGridViewTextBoxColumn.Index].Value);

                //convert roll to 1 based index
                roll = rand.Next(20) + 1;

                //set intiative value
                row.Cells["CurrIni"].Value = roll + bonus;

                //if turn is set, uncheck turn
                row.Cells[0].Value = false;
            }

            //sort grid, set first turn, make intiative for encounter visible, hide intiative bonus
            _dataGridViewManager.Sort(_dataGridViewManager.Columns["CurrIni"], ListSortDirection.Descending);
            _dataGridViewManager.Rows[0].Cells[0].Value = true;
            _dataGridViewManager.Columns["CurrIni"].Visible = true;
            _dataGridViewManager.Columns[iniBonusDataGridViewTextBoxColumn.Index].Visible = false;

            //make it look pretty
            _dataGridViewManager.ClearSelection();
        }

        private void rollAsGroupToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if (_dataGridViewManager.SelectedRows.Count == 0 || _dataGridViewManager.SelectedRows.Count == 1)
            {
                MessageBox.Show("Group roll must select more than one character", "Error", MessageBoxButtons.OK);
                return;
            }

            //prepare variables for intiative calculation
            int bonus = 0;
            int roll = 0;
            var rand = new Random();

            //convert roll to 1 based index
            roll = rand.Next(20) + 1;

            //bonus value
            foreach (DataGridViewRow row in _dataGridViewManager.SelectedRows)
            {
                //try parse int
                bonus = Convert.ToInt32(row.Cells[iniBonusDataGridViewTextBoxColumn.Index].Value);

                //set intiative value
                row.Cells["CurrIni"].Value = roll + bonus;

                //if turn is set, uncheck turn
                row.Cells[0].Value = false;
            }                

            //sort grid, set first turn, make intiative for encounter visible, hide intiative bonus
            _dataGridViewManager.Sort(_dataGridViewManager.Columns["CurrIni"], ListSortDirection.Descending);
            _dataGridViewManager.Rows[0].Cells[0].Value = true;
            _dataGridViewManager.Columns["CurrIni"].Visible = true;
            _dataGridViewManager.Columns[iniBonusDataGridViewTextBoxColumn.Index].Visible = false;

            //make it look pretty
            _dataGridViewManager.ClearSelection();
        }

        private void _resetInitiativeToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if (_dataGridViewManager.Rows.Count == 0)
            {
                MessageBox.Show("Encounter is empty", "Error", MessageBoxButtons.OK);
                return;
            }

            //set intiative to zero for next roll
            foreach (DataGridViewRow row in _dataGridViewManager.Rows)
            {
                row.Cells["CurrIni"].Value = 0;
            };

            //reset grid for non combat information
            _dataGridViewManager.Columns["CurrIni"].Visible = false;
            _dataGridViewManager.Columns[iniBonusDataGridViewTextBoxColumn.Index].Visible = true;

            RefreshUI();
        }

        private void _resetHitPointsToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if (_dataGridViewManager.Rows.Count == 0)
            {
                MessageBox.Show("Encounter is empty", "Error", MessageBoxButtons.OK);
                return;
            }

            foreach (DataGridViewRow row in _dataGridViewManager.Rows)
            {
                //reset any damage taken
                row.Cells["CurrHP"].Value = Encounter.Characters.ElementAt(row.Index).MaxHP;
            };
        }

        #endregion

        #region Character Strip
        private void _addToolStripMenuItem_Click( object sender, EventArgs e )
        {

            _addBtn_Click(sender, e);
        }

        private void _updateToolStripMenuItem_Click( object sender, EventArgs e )
        {
            _updateBtn_Click(sender, e);
        }

        private void _deleteToolStripMenuItem_Click( object sender, EventArgs e )
        {
            _delBtn_Click(sender, e);
        }
        #endregion

        #region Lower Left Buttons
        private void _addBtn_Click( object sender, EventArgs e )
        {
                //create new character form
                var form = new CharacterForm();

                //Show character form modally
                var result = form.ShowDialog(this);
                if (result != DialogResult.OK)
                    return;

                //Add character to Encounter
                Encounter.Characters.Add(form.Character);

                //Update binding source and grid
                RefreshUI();
            
        }

        private void _updateBtn_Click( object sender, EventArgs e )
        {
            if (_dataGridViewManager.SelectedRows.Count == 0)
            {
                MessageBox.Show("No Character Selected", "Error", MessageBoxButtons.OK);
                return;
            }

            var selected = _dataGridViewManager.SelectedRows[0].DataBoundItem as Character;
            var index = _dataGridViewManager.SelectedRows[0].Index;

            //construct character form with preloaded character
            var form = new CharacterForm(selected);

            //Show character form modally
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            //edit selected character in encounter            
            Encounter.Characters.ElementAt(index).Name = form.Character.Name;
            Encounter.Characters.ElementAt(index).IniBonus = form.Character.IniBonus;
            Encounter.Characters.ElementAt(index).MaxHP = form.Character.MaxHP;
            Encounter.Characters.ElementAt(index).CurrHP = form.Character.MaxHP;

            //Update binding source and grid
            RefreshUI();
        }

        private void _copyBtn_Click( object sender, EventArgs e )
        {

            if (_dataGridViewManager.SelectedRows.Count == 0)
            {
                MessageBox.Show("No Character Selected", "Error", MessageBoxButtons.OK);
                return;
            }

            var selected = _dataGridViewManager.SelectedRows[0].DataBoundItem as Character;

            var match = Regex.Match(selected.Name, @"\((\d+)\)", RegexOptions.IgnoreCase);

            var copyName = selected.Name;
            int copyNum = 1;
            Match matchAllGrid;
            string matchName;

            if (match.Success)
            {
                matchName = copyName.Remove(match.Index) + @"\((\d+)\)";

                foreach (DataGridViewRow row in _dataGridViewManager.Rows)
                {
                    matchName = copyName.Remove(match.Index) + @"\((\d+)\)";
                    matchAllGrid = Regex.Match(row.Cells["nameDataGridViewTextBoxColumn"].Value.ToString(), matchName, RegexOptions.IgnoreCase);
                    if (matchAllGrid.Success)
                        copyNum++;
                }

                copyName = copyName.Remove(match.Index + 1);
                copyName += copyNum.ToString() + ")";

            } else
            {
                matchName = copyName + @"\((\d+)\)";
                foreach (DataGridViewRow row in _dataGridViewManager.Rows)
                {                   
                    matchAllGrid = Regex.Match(row.Cells["nameDataGridViewTextBoxColumn"].Value.ToString(), matchName, RegexOptions.IgnoreCase);
                    if (matchAllGrid.Success)
                        copyNum++;
                }
                copyName = selected.Name + "(" + copyNum.ToString() + ")";
            }

            Character copy = new Character()
            {
                Name = copyName,
                IniBonus = selected.IniBonus,
                CurrIni = 0,
                MaxHP = selected.MaxHP,
                CurrHP = selected.MaxHP
            };

            Encounter.Characters.Add(copy);
            RefreshUI();
        }

        private void _delBtn_Click( object sender, EventArgs e )
        {

            if(_dataGridViewManager.SelectedRows.Count == 0)
            {
                MessageBox.Show("No Character Selected", "Error", MessageBoxButtons.OK);
                return;
            }

            //confirm delete action and return if needed
            var result = MessageBox.Show("Are you sure you want to delete the selected characters?", "Delete Character", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
                return;

            //delete starting with last in list to avoid index errors
            var count = _dataGridViewManager.Rows.Count;

            for (int i = count - 1; i >= 0; i--)
            {
                if (_dataGridViewManager.Rows[i].Selected)
                {
                    Encounter.Characters.RemoveAt(i);
                }
            }
                   
            //update binding source and grid
            RefreshUI();            
        }
        #endregion

        #region Lower Right Buttons
        private void _slideUpBtn_Click( object sender, EventArgs e )
        {
            int index;
            try
            {
                //pull first selected row, and row index
                index = _dataGridViewManager.SelectedRows[0].Index;
            } catch (Exception ex)
            {
                MessageBox.Show("No Character Selected", "Error", MessageBoxButtons.OK);
                return;
            }

            if (index > 0 && index < _dataGridViewManager.Rows.Count)
            {
                Encounter.SwapCharacters(index, index -1 );

                RefreshUI();

                //keep that character selected
                _dataGridViewManager.Rows[index - 1].Selected = true;
            }
        }

        private void _slideDownBtn_Click( object sender, EventArgs e )
        {
            //get row number
            int index;
            try
            {
                //pull first selected row, and row index
                index = _dataGridViewManager.SelectedRows[0].Index;
            } catch (Exception ex)
            {
                //other classes of exceptions could happen here, we should do a Count check of SelectedRows
                MessageBox.Show("No Character Selected", "Error", MessageBoxButtons.OK);
                return;
            }

            if( index >= 0 && index < _dataGridViewManager.Rows.Count - 1 )
            {
                Encounter.SwapCharacters(index, index + 1 );

                RefreshUI();

                _dataGridViewManager.Rows[index + 1].Selected = true;
            }
        }

        private void _rollInitiativeBtn_Click( object sender, EventArgs e )
        {
            //roll initiative but with all selected
            _dataGridViewManager.SelectAll();
            _rollSelectedInitiativeToolStripMenuItem_Click(sender, e);
        }

        //TODO: Conver this logic into Encounter
        private void _nextTurnBtn_Click( object sender, EventArgs e )
        {
            //go through each player
            foreach (DataGridViewRow row in _dataGridViewManager.Rows)
            {
                //find who's turn it is
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    //make it not their turn
                    row.Cells[0].Value = false;
                    try
                    {
                        //make it the next characters turn
                        _dataGridViewManager.Rows[row.Index + 1].Cells[0].Value = true;
                    } catch
                    {
                        //if they're the last player in the list, loop to the top
                        _dataGridViewManager.Rows[0].Cells[0].Value = true;
                    }
                    break;
                };
            };
        }
        #endregion

        #region Event Handlers
        private void _dataGridViewManager_ColumnHeaderMouseClick( object sender, DataGridViewCellMouseEventArgs e )
        {
            if (_dataGridViewManager.Columns[e.ColumnIndex].IsDataBound)
            {
                //default sort is descending, switch if needed, then sort
                if (sort == ListSortDirection.Descending)
                    sort = ListSortDirection.Ascending;
                else
                    sort = ListSortDirection.Descending;

                _dataGridViewManager.Sort(_dataGridViewManager.Columns[e.ColumnIndex], sort);
            }
        }

        private void _dataGridViewManager_CellMouseDoubleClick( object sender, DataGridViewCellMouseEventArgs e )
        {
            _dataGridViewManager.BeginEdit(false);
        }
        private void Manager_MouseDown( object sender, MouseEventArgs e )
        {
            //if click on form, deselect row
            _dataGridViewManager.ClearSelection();
        }

        private void _mainMenuStrip_MouseDown( object sender, MouseEventArgs e )
        {
            //if click on menu strip, deselect row
            _dataGridViewManager.ClearSelection();
        }
        #endregion

        #region Methods
        private void RefreshUI()
        {
            //clear binding source
            view.Clear();

            //add all characters back into binding source
                foreach (Character chrc in Encounter.Characters)
                {
                    view.Add(chrc);
                } 

            //rebind and make pretty
            characterBindingSource.DataSource = view;
            _dataGridViewManager.ClearSelection();
        }

        private bool ShowConfirmation( string message, string title )
        {
            return (MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }

        private int TryParse( DataGridViewCell cell )
        {
            var result = Int32.TryParse(cell.Value as string, out int value);
            if (!result)
            {
                throw new Exception();
            }
            return value;
        }
#endregion

        #region Variables
        //variable declaration
        ListSortDirection sort = new ListSortDirection();
        SortableBindingList<Character> view = new SortableBindingList<Character>();
        public Encounter Encounter { get; set; }

        #endregion

        private void copySelectedToolStripMenuItem_Click( object sender, EventArgs e )
        {
            _copyBtn_Click(sender, e);
        }

        private void _dataGridViewManager_KeyDown( object sender, KeyEventArgs e )
        {
            if(e.KeyCode == Keys.Delete)
            {
                _delBtn_Click(sender, e);
            }
        }

        #region dragAndDrop
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;
        private void _dataGridViewManager_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {

                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = _dataGridViewManager.DoDragDrop(
                    _dataGridViewManager.Rows[rowIndexFromMouseDown],
                    DragDropEffects.Move);
                }
            }
        }

        private void _dataGridViewManager_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            var hitTest = _dataGridViewManager.HitTest(e.X, e.Y);
            rowIndexFromMouseDown = hitTest.RowIndex;

            if (hitTest.Type == DataGridViewHitTestType.None)
            {
                _dataGridViewManager.ClearSelection();
            }
            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)),
                                    dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void _dataGridViewManager_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void _dataGridViewManager_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = _dataGridViewManager.PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop =
                _dataGridViewManager.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                Encounter.SwapCharacters(rowIndexFromMouseDown, rowIndexOfItemUnderMouseToDrop);
                RefreshUI();

            }
        }
        #endregion
        //this isn't handling properly and only matters for adding and removing elements through the gridview methods itself
        private void _collectionChanged(object sender, CollectionChangeEventArgs e)
        {
            switch (e.Action)
            {
                case CollectionChangeAction.Add:
                    Encounter.Characters.Add(e.Element as Character);
                    break;
                case CollectionChangeAction.Remove:
                    Encounter.Characters.Remove(e.Element as Character);
                    break;
                case CollectionChangeAction.Refresh:
                    Encounter.Characters.Remove(e.Element as Character);
                    Encounter.Characters.Add(e.Element as Character);
                    break;
            }
        }
    }
}
