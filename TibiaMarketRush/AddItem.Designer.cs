namespace TibiaMarketRush
{
    partial class AddItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxNpcs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxNpc = new System.Windows.Forms.TextBox();
            this.ButtonAddNpc = new System.Windows.Forms.Button();
            this.ButtonDeleteNpc = new System.Windows.Forms.Button();
            this.ListBoxItems = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxItemName = new System.Windows.Forms.TextBox();
            this.NumericUpDownItemValue = new System.Windows.Forms.NumericUpDown();
            this.ButtonAddItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownItemValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Npc:";
            // 
            // ComboBoxNpcs
            // 
            this.ComboBoxNpcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxNpcs.FormattingEnabled = true;
            this.ComboBoxNpcs.Location = new System.Drawing.Point(93, 43);
            this.ComboBoxNpcs.Name = "ComboBoxNpcs";
            this.ComboBoxNpcs.Size = new System.Drawing.Size(260, 21);
            this.ComboBoxNpcs.TabIndex = 2;
            this.ComboBoxNpcs.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNpcs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adicionar npc:";
            // 
            // TextBoxNpc
            // 
            this.TextBoxNpc.Location = new System.Drawing.Point(93, 14);
            this.TextBoxNpc.Name = "TextBoxNpc";
            this.TextBoxNpc.Size = new System.Drawing.Size(260, 20);
            this.TextBoxNpc.TabIndex = 5;
            // 
            // ButtonAddNpc
            // 
            this.ButtonAddNpc.Location = new System.Drawing.Point(359, 12);
            this.ButtonAddNpc.Name = "ButtonAddNpc";
            this.ButtonAddNpc.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddNpc.TabIndex = 6;
            this.ButtonAddNpc.Text = "Adicionar";
            this.ButtonAddNpc.UseVisualStyleBackColor = true;
            this.ButtonAddNpc.Click += new System.EventHandler(this.ButtonAddNpc_Click);
            // 
            // ButtonDeleteNpc
            // 
            this.ButtonDeleteNpc.Location = new System.Drawing.Point(359, 41);
            this.ButtonDeleteNpc.Name = "ButtonDeleteNpc";
            this.ButtonDeleteNpc.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeleteNpc.TabIndex = 7;
            this.ButtonDeleteNpc.Text = "Deletar";
            this.ButtonDeleteNpc.UseVisualStyleBackColor = true;
            this.ButtonDeleteNpc.Click += new System.EventHandler(this.ButtonDeleteNpc_Click);
            // 
            // ListBoxItems
            // 
            this.ListBoxItems.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxItems.FormattingEnabled = true;
            this.ListBoxItems.IntegralHeight = false;
            this.ListBoxItems.Location = new System.Drawing.Point(12, 70);
            this.ListBoxItems.Name = "ListBoxItems";
            this.ListBoxItems.Size = new System.Drawing.Size(422, 393);
            this.ListBoxItems.TabIndex = 8;
            this.ListBoxItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ListBoxItems_KeyPress);
            this.ListBoxItems.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ListBoxItems_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adicionar item:";
            // 
            // TextBoxItemName
            // 
            this.TextBoxItemName.Location = new System.Drawing.Point(94, 471);
            this.TextBoxItemName.Name = "TextBoxItemName";
            this.TextBoxItemName.Size = new System.Drawing.Size(118, 20);
            this.TextBoxItemName.TabIndex = 10;
            // 
            // NumericUpDownItemValue
            // 
            this.NumericUpDownItemValue.Location = new System.Drawing.Point(218, 472);
            this.NumericUpDownItemValue.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.NumericUpDownItemValue.Name = "NumericUpDownItemValue";
            this.NumericUpDownItemValue.Size = new System.Drawing.Size(135, 20);
            this.NumericUpDownItemValue.TabIndex = 11;
            // 
            // ButtonAddItem
            // 
            this.ButtonAddItem.Location = new System.Drawing.Point(359, 469);
            this.ButtonAddItem.Name = "ButtonAddItem";
            this.ButtonAddItem.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddItem.TabIndex = 12;
            this.ButtonAddItem.Text = "Adicionar";
            this.ButtonAddItem.UseVisualStyleBackColor = true;
            this.ButtonAddItem.Click += new System.EventHandler(this.ButtonAddItem_Click);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 504);
            this.Controls.Add(this.ButtonAddItem);
            this.Controls.Add(this.NumericUpDownItemValue);
            this.Controls.Add(this.TextBoxItemName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListBoxItems);
            this.Controls.Add(this.ButtonDeleteNpc);
            this.Controls.Add(this.ButtonAddNpc);
            this.Controls.Add(this.TextBoxNpc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBoxNpcs);
            this.Controls.Add(this.label1);
            this.Name = "AddItem";
            this.Text = "Adicionar item";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddItem_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownItemValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxNpcs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxNpc;
        private System.Windows.Forms.Button ButtonAddNpc;
        private System.Windows.Forms.Button ButtonDeleteNpc;
        private System.Windows.Forms.ListBox ListBoxItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxItemName;
        private System.Windows.Forms.NumericUpDown NumericUpDownItemValue;
        private System.Windows.Forms.Button ButtonAddItem;
    }
}