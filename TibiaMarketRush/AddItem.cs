using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TibiaMarketRush
{
    public partial class AddItem : Form
    {
        private bool Modified;

        public AddItem()
        {
            InitializeComponent();

            if (System.IO.File.Exists("items.txt"))
            {
                using (System.IO.StreamReader streamReader = new System.IO.StreamReader("items.txt"))
                {
                    richTextBox1.Clear();
                    richTextBox1.AppendText(streamReader.ReadToEnd());
                    Modified = false;
                }
            }
        }

        public List<Item> GetAllItems()
        {
            List<Item> items = new List<Item>();
            foreach (string line in richTextBox1.Lines)
            {
                if (line.TrimStart().StartsWith("//") || line.Trim().Length == 0)
                {
                    continue;
                }

                string[] args = line.Split('\t');
                items.Add(new Item(args[0], ulong.Parse(args[1].Replace(" ", "").Replace("gp", ""))));
            }

            return items;
        }

        private bool Validate(out string problemLine)
        {
            problemLine = "";

            foreach (string line in richTextBox1.Lines)
            {
                if (line.TrimStart().StartsWith("//") || line.Trim().Length == 0)
                {
                    continue;
                }

                try
                {
                    string[] args = line.Split('\t');
                    int.Parse(args[1].Replace(" ", "").Replace("gp", ""));
                }
                catch
                {
                    problemLine = line;

                    return false;
                }
            }

            return true;
        }

        private bool Save()
        {
            if (Validate(out string problemLine))
            {
                using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter("items.txt"))
                {
                    streamWriter.Write(richTextBox1.Text);
                }

                Modified = false;
                return true;
            }
            else
            {
                MessageBox.Show("A linha: '" + problemLine + "' apresenta problema de formatação.");

                return false;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void AddItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Modified)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja salvar as alterações antes de fechar?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {
                    if (!Save())
                    {
                        e.Cancel = true;
                    }
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            Modified = true;
        }
    }
}
