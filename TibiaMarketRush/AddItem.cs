using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TibiaMarketRush
{
    public partial class AddItem : Form
    {
        public Dictionary<string, List<Item>> Npcs { get; private set; }

        public AddItem()
        {
            InitializeComponent();

            ListBoxItems.Enabled = false;
            ButtonAddItem.Enabled = false;

            Npcs = new Dictionary<string, List<Item>>();

            if (System.IO.Directory.Exists("npcs"))
            {
                string[] paths = System.IO.Directory.GetFiles("npcs");

                foreach (string path in paths)
                {
                    string npc = System.IO.Path.GetFileNameWithoutExtension(path);

                    ComboBoxNpcs.Items.Add(npc);
                    Npcs[npc] = new List<Item>();

                    using (System.IO.StreamReader streamReader = new System.IO.StreamReader(path))
                    {
                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            string[] tokens = line.Split(';');

                            Npcs[npc].Add(new Item(tokens[0], ulong.Parse(tokens[1])));
                        }
                    }
                }
            }
        }

        private void AddItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!System.IO.Directory.Exists("npcs"))
            {
                System.IO.Directory.CreateDirectory("npcs");
            }

            foreach (string npc in Npcs.Keys)
            {
                using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter("npcs\\" + npc + ".txt", false))
                {
                    List<Item> items = Npcs[npc];
                    foreach (Item item in items)
                    {
                        streamWriter.WriteLine(item.Name + ";" + item.Value);
                    }
                }
            }
        }

        private void ButtonAddItem_Click(object sender, EventArgs e)
        {
            Item item = new Item(TextBoxItemName.Text, (ulong)NumericUpDownItemValue.Value);

            Npcs[(string)ComboBoxNpcs.SelectedItem].Add(item);
            ListBoxItems.Items.Add(item);

            TextBoxItemName.Clear();
        }

        private void ComboBoxNpcs_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Item> items = Npcs[(string)ComboBoxNpcs.SelectedItem];
            ListBoxItems.Items.Clear();
            foreach (Item item in items)
            {
                ListBoxItems.Items.Add(item);
            }

            ListBoxItems.Enabled = true;
            ButtonAddItem.Enabled = true;
        }

        private void ButtonAddNpc_Click(object sender, EventArgs e)
        {
            if (!Npcs.ContainsKey(TextBoxNpc.Text))
            {
                ComboBoxNpcs.Items.Add(TextBoxNpc.Text);
                Npcs[TextBoxNpc.Text] = new List<Item>();
            }

            TextBoxNpc.Clear();
        }

        private void ButtonDeleteNpc_Click(object sender, EventArgs e)
        {
            if (ComboBoxNpcs.SelectedIndex != -1)
            {
                Npcs.Remove((string)ComboBoxNpcs.SelectedItem);
                ComboBoxNpcs.Items.RemoveAt(ComboBoxNpcs.SelectedIndex);

                if (ComboBoxNpcs.SelectedIndex == -1)
                {
                    ListBoxItems.Enabled = false;
                    ButtonAddItem.Enabled = false;
                }
            }
        }
    }
}
