// File: MainForm.cs
using ProtoBuf;
using System;
using System.ComponentModel;
using System.Text.Json;
using System.Windows.Forms;

namespace AngryBirdsEpicAllStarsSaveEditor
{
    public partial class MainForm : MetroSet_UI.Forms.MetroSetForm
    {
        public MainForm()
        {
            InitializeComponent();
            dataGridRed.CellBeginEdit += GridViewMastery_CellBeginEdit;
            dataGridChuck.CellBeginEdit += GridViewMastery_CellBeginEdit;
            dataGridMatilda.CellBeginEdit += GridViewMastery_CellBeginEdit;
            dataGridBomb.CellBeginEdit += GridViewMastery_CellBeginEdit;
            dataGridBlues.CellBeginEdit += GridViewMastery_CellBeginEdit;
            dataGridRed.CellValidating += GridViewMastery_CellValidating;
            dataGridChuck.CellValidating += GridViewMastery_CellValidating;
            dataGridMatilda.CellValidating += GridViewMastery_CellValidating;
            dataGridBomb.CellValidating += GridViewMastery_CellValidating;
            dataGridBlues.CellValidating += GridViewMastery_CellValidating;
            creditsLabel.ForeColor = Color.Silver;
        }


        private int previousLevel = 1; // Dummy XP
        private object previousValue;  // Dummy Mastery

        public static readonly Dictionary<string, string> ClassNameLookup = new()
        {
            // RED
            { "class_knight", "Knight" },
            { "class_guardian", "Guardian" },
            { "class_samurai", "Samurai" },
            { "class_avenger", "Avenger" },
            { "class_paladin", "Paladin" },
            { "class_stoneguard", "Stone Guard" },
            { "class_frostguard", "Ronin" },

            // CHUCK
            { "class_mage", "Mage" },
            { "class_lightningbird", "Lightning Bird" },
            { "class_wizard", "Wizard" },
            { "class_illusionist", "Illusionist" },
            { "class_rainbird", "Rainbird" },
            { "class_thunderbird", "Thunderbird" },
            { "class_rocketbird", "Sorcerer" },

            // MATILDA
            { "class_cleric", "Cleric" },
            { "class_druid", "Druid" },
            { "class_witch", "Witch" },
            { "class_princess", "Princess" },
            { "class_bard", "Bard" },
            { "class_priest", "Priest" },
            { "class_angel", "Lunar Healer" },

            // BOMB
            { "class_pirate", "Pirate" },
            { "class_berserk", "Berserker" },
            { "class_seadog", "Sea Dog" },
            { "class_cannoneer", "Cannoneer" },
            { "class_captn", "Capt'n" },
            { "class_winterfighter", "Frost Savage" },
            { "class_naturebird", "Corsair" },

            // BLUES
            { "class_rogues", "Rogues" },
            { "class_skulkers", "Skulkers" },
            { "class_tricksters", "Tricksters" },
            { "class_marksmen", "Marksmen" },
            { "class_treasurehunters", "Treasure Hunters" },
            { "class_spies", "Spies" },
            { "class_chaos_agent", "Ninjas" }
        };

        private static string GetClassBird(string nameId)
        {
            if (new[] { "class_knight", "class_guardian", "class_samurai", "class_avenger", "class_paladin", "class_stoneguard", "class_frostguard" }.Contains(nameId))
                return "Red";
            if (new[] { "class_mage", "class_lightningbird", "class_wizard", "class_illusionist", "class_rainbird", "class_thunderbird", "class_rocketbird" }.Contains(nameId))
                return "Chuck";
            if (new[] { "class_cleric", "class_druid", "class_witch", "class_princess", "class_bard", "class_angel", "class_priest" }.Contains(nameId))
                return "Matilda";
            if (new[] { "class_pirate", "class_berserk", "class_seadog", "class_cannoneer", "class_captn", "class_winterfighter", "class_naturebird"}.Contains(nameId))
                return "Bomb";
            if (new[] { "class_rogues", "class_skulkers", "class_tricksters", "class_marksmen", "class_treasurehunters", "class_spies", "class_chaos_agent" }.Contains(nameId))
                return "Blues";
            return "Unknown";
        }
        public class ClassDisplayEntry
        {
            public string Class { get; set; }
            public int Mastery { get; set; }
        }

        private void PopulateBirdClassTabs()
        {
            var classItems = SaveEditorLogic.PlayerDataObject.Inventory.ClassItems;

            var redList = new BindingList<ClassDisplayEntry>();
            var chuckList = new BindingList<ClassDisplayEntry>();
            var matildaList = new BindingList<ClassDisplayEntry>();
            var bombList = new BindingList<ClassDisplayEntry>();
            var bluesList = new BindingList<ClassDisplayEntry>();

            foreach (var item in classItems)
            {
                string displayName = ClassNameLookup.TryGetValue(item.NameId, out var name)
                    ? name
                    : item.NameId;

                var entry = new ClassDisplayEntry
                {
                    Class = displayName,
                    Mastery = item.Level
                };

                switch (GetClassBird(item.NameId))
                {
                    case "Red": redList.Add(entry); break;
                    case "Chuck": chuckList.Add(entry); break;
                    case "Matilda": matildaList.Add(entry); break;
                    case "Bomb": bombList.Add(entry); break;
                    case "Blues": bluesList.Add(entry); break;
                }
            }

            // Ensure grids exit edit mode before rebinding
            dataGridRed.EndEdit();
            dataGridChuck.EndEdit();
            dataGridMatilda.EndEdit();
            dataGridBomb.EndEdit();
            dataGridBlues.EndEdit();

            ConfigureClassGrid(dataGridRed);
            ConfigureClassGrid(dataGridChuck);
            ConfigureClassGrid(dataGridMatilda);
            ConfigureClassGrid(dataGridBomb);
            ConfigureClassGrid(dataGridBlues);

            dataGridRed.DataSource = redList;
            dataGridChuck.DataSource = chuckList;
            dataGridMatilda.DataSource = matildaList;
            dataGridBomb.DataSource = bombList;
            dataGridBlues.DataSource = bluesList;

            FormatGridView();
        }


        private void ConfigureClassGrid(DataGridView grid)
        {
            grid.AutoGenerateColumns = false;
            grid.Columns.Clear();

            var classColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Class",
                HeaderText = "Class",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 100,
                ReadOnly = true
            };

            var masteryColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Mastery",
                HeaderText = "Mastery",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 26
            };

            grid.Columns.Add(classColumn);
            grid.Columns.Add(masteryColumn);
        }

        private void FormatGridView()
        {
            // Dictionary to map bird names to their corresponding DataGridView controls
            var birdGrids = new Dictionary<string, DataGridView>
            {
                { "Red", dataGridRed },
                { "Chuck", dataGridChuck },
                { "Matilda", dataGridMatilda },
                { "Bomb", dataGridBomb },
                { "Blues", dataGridBlues }
            };

            // Common style settings
            Color textColor = Color.Black;
            Color selectionTextColor = Color.Black;
            Font font = new Font("Segoe UI", 10, FontStyle.Regular);

            // Apply the style to each grid
            foreach (var grid in birdGrids.Values)
            {
                grid.AllowUserToResizeRows = false;
                grid.AllowUserToResizeColumns = false;
                grid.AllowUserToAddRows = false;
                grid.DefaultCellStyle.ForeColor = textColor;
                grid.DefaultCellStyle.SelectionForeColor = selectionTextColor;
                grid.DefaultCellStyle.Font = font;
            }

        }
        
        private void GridViewMastery_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var grid = sender as DataGridView;
            previousValue = grid[e.ColumnIndex, e.RowIndex].Value;
        }

        private void GridViewMastery_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var grid = sender as DataGridView;

            // Only validate Mastery column (index 1)
            if (e.ColumnIndex == 1)
            {
                string input = e.FormattedValue?.ToString() ?? "";

                if (!int.TryParse(input, out int result) || result < 1 || result > 100)
                {
                    MessageBox.Show("Mastery must be an integer between 1 and 100.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (grid.EditingControl is TextBox tb)
                    {
                        // Revert edit box text directly
                        tb.Text = previousValue?.ToString();
                    }

                    e.Cancel = true;
                }
            }
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveEditorLogic.LoadFile(openFileDialog.FileName);
                    MessageBox.Show("File loaded successfully.");
                    //SaveEditorLogic.SaveToJson("player.json");
                    LoadPlayerSave();
                }
            }
        }
        private void LoadPlayerSave()
        {
            if (SaveEditorLogic.PlayerDataObject?.Inventory?.ClassItems != null)
            {
                var classItems = SaveEditorLogic.PlayerDataObject.Inventory.ClassItems;
                if (classItems != null)
                {
                    PopulateBirdClassTabs();
                }
            }

            if (SaveEditorLogic.PlayerDataObject?.Level != null)
            {
                int level = SaveEditorLogic.PlayerDataObject.Level;
                expTextBox.Text = level.ToString();
                previousLevel = level;
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SaveEditorLogic.loadedPath))
            {
                MessageBox.Show("No file loaded to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveEditorLogic.SaveToBase64File(SaveEditorLogic.loadedPath,
                dataGridRed, dataGridChuck, dataGridMatilda, dataGridBomb, dataGridBlues);

            MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EXPTextBox_Cell_Validating(object sender, EventArgs e)
        {
            if (!int.TryParse(expTextBox.Text.Trim(), out int level) || level < 1 || level > 100)
            {
                MessageBox.Show("Level must be an integer between 1 and 100.", "Invalid Level", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                expTextBox.Text = previousLevel.ToString(); // revert to last known good value
            }
            else
            {
                // Valid: update player data and cache the value
                if (SaveEditorLogic.PlayerDataObject?.Level != null)
                {
                    SaveEditorLogic.PlayerDataObject.Level = level;
                    previousLevel = level;
                }
            }
        }
    }

}