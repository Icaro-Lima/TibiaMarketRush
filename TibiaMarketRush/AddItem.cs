using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TibiaMarketRush
{
    public partial class AddItem : Form
    {
        public Dictionary<string, DataTable> Npcs { get; private set; }

        public AddItem()
        {
            InitializeComponent();

            Npcs = new Dictionary<string, DataTable>();

            dataGridView1.Enabled = false;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                dataGridView1.DataSource = Npcs[(string)comboBox1.SelectedItem];
                dataGridView1.Enabled = true;
            }
            else
            {
                dataGridView1.Enabled = false;
            }
        }

        private void DataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (!int.TryParse((string)e.FormattedValue, out int result))
                {
                    e.Cancel = true;
                }
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(TextBoxNpc.Text);
            Npcs.Add(TextBoxNpc.Text, new DataTable());
            TextBoxNpc.Clear();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                Npcs.Remove((string)comboBox1.SelectedItem);
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }
        }
    }
}
