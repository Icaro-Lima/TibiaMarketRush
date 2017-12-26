namespace TibiaMarketRush
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarLocalDeEscreverNomeDosItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarLocalOndeOPrimeiroItemApareceApósAPesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarLocalOndeOValorDoPrimeiroItemApareceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarLocalOndeAQuantidadeDeItemsDoPrimeiroLanceApareceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarLocalOndeAumentaAQuantidadeDeItemsQueDesejaComprarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarBotãoDeAcceptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.GroupBoxBuyCondition = new System.Windows.Forms.GroupBox();
            this.NumericUpDownMaxSpent = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NumericUpDownProfitByPercentage = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownProfitByValue = new System.Windows.Forms.NumericUpDown();
            this.RadioButtonProfitByValue = new System.Windows.Forms.RadioButton();
            this.RadioButtonProfitByPercentage = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.GroupBoxBuyCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMaxSpent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownProfitByPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownProfitByValue)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarToolStripMenuItem,
            this.adicionarItemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MenuStripMain";
            // 
            // configurarToolStripMenuItem
            // 
            this.configurarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarLocalDeEscreverNomeDosItemsToolStripMenuItem,
            this.configurarLocalOndeOPrimeiroItemApareceApósAPesquisaToolStripMenuItem,
            this.configurarLocalOndeOValorDoPrimeiroItemApareceToolStripMenuItem,
            this.configurarLocalOndeAQuantidadeDeItemsDoPrimeiroLanceApareceToolStripMenuItem,
            this.configurarLocalOndeAumentaAQuantidadeDeItemsQueDesejaComprarToolStripMenuItem,
            this.configurarBotãoDeAcceptToolStripMenuItem});
            this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            this.configurarToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.configurarToolStripMenuItem.Text = "Configurar";
            // 
            // configurarLocalDeEscreverNomeDosItemsToolStripMenuItem
            // 
            this.configurarLocalDeEscreverNomeDosItemsToolStripMenuItem.Name = "configurarLocalDeEscreverNomeDosItemsToolStripMenuItem";
            this.configurarLocalDeEscreverNomeDosItemsToolStripMenuItem.Size = new System.Drawing.Size(466, 22);
            this.configurarLocalDeEscreverNomeDosItemsToolStripMenuItem.Text = "Configurar local de escrever nome dos items";
            this.configurarLocalDeEscreverNomeDosItemsToolStripMenuItem.Click += new System.EventHandler(this.ConfigurarLocalDeEscreverNomeDosItemsToolStripMenuItem_Click);
            // 
            // configurarLocalOndeOPrimeiroItemApareceApósAPesquisaToolStripMenuItem
            // 
            this.configurarLocalOndeOPrimeiroItemApareceApósAPesquisaToolStripMenuItem.Name = "configurarLocalOndeOPrimeiroItemApareceApósAPesquisaToolStripMenuItem";
            this.configurarLocalOndeOPrimeiroItemApareceApósAPesquisaToolStripMenuItem.Size = new System.Drawing.Size(466, 22);
            this.configurarLocalOndeOPrimeiroItemApareceApósAPesquisaToolStripMenuItem.Text = "Configurar local onde o primeiro item aparece após a pesquisa";
            this.configurarLocalOndeOPrimeiroItemApareceApósAPesquisaToolStripMenuItem.Click += new System.EventHandler(this.ConfigurarLocalOndeOPrimeiroItemApareceApósAPesquisaToolStripMenuItem_Click);
            // 
            // configurarLocalOndeOValorDoPrimeiroItemApareceToolStripMenuItem
            // 
            this.configurarLocalOndeOValorDoPrimeiroItemApareceToolStripMenuItem.Name = "configurarLocalOndeOValorDoPrimeiroItemApareceToolStripMenuItem";
            this.configurarLocalOndeOValorDoPrimeiroItemApareceToolStripMenuItem.Size = new System.Drawing.Size(466, 22);
            this.configurarLocalOndeOValorDoPrimeiroItemApareceToolStripMenuItem.Text = "Configurar local onde o valor do primeiro item aparece";
            this.configurarLocalOndeOValorDoPrimeiroItemApareceToolStripMenuItem.Click += new System.EventHandler(this.ConfigurarLocalOndeOValorDoPrimeiroItemApareceToolStripMenuItem_Click);
            // 
            // configurarLocalOndeAQuantidadeDeItemsDoPrimeiroLanceApareceToolStripMenuItem
            // 
            this.configurarLocalOndeAQuantidadeDeItemsDoPrimeiroLanceApareceToolStripMenuItem.Name = "configurarLocalOndeAQuantidadeDeItemsDoPrimeiroLanceApareceToolStripMenuItem";
            this.configurarLocalOndeAQuantidadeDeItemsDoPrimeiroLanceApareceToolStripMenuItem.Size = new System.Drawing.Size(466, 22);
            this.configurarLocalOndeAQuantidadeDeItemsDoPrimeiroLanceApareceToolStripMenuItem.Text = "Configurar local onde a quantidade de items do primeiro lance aparece";
            this.configurarLocalOndeAQuantidadeDeItemsDoPrimeiroLanceApareceToolStripMenuItem.Click += new System.EventHandler(this.ConfigurarLocalOndeAQuantidadeDeItemsDoPrimeiroLanceApareceToolStripMenuItem_Click);
            // 
            // configurarLocalOndeAumentaAQuantidadeDeItemsQueDesejaComprarToolStripMenuItem
            // 
            this.configurarLocalOndeAumentaAQuantidadeDeItemsQueDesejaComprarToolStripMenuItem.Name = "configurarLocalOndeAumentaAQuantidadeDeItemsQueDesejaComprarToolStripMenuItem";
            this.configurarLocalOndeAumentaAQuantidadeDeItemsQueDesejaComprarToolStripMenuItem.Size = new System.Drawing.Size(466, 22);
            this.configurarLocalOndeAumentaAQuantidadeDeItemsQueDesejaComprarToolStripMenuItem.Text = "Configurar local onde aumenta a quantidade de items que deseja comprar";
            this.configurarLocalOndeAumentaAQuantidadeDeItemsQueDesejaComprarToolStripMenuItem.Click += new System.EventHandler(this.configurarLocalOndeAumentaAQuantidadeDeItemsQueDesejaComprarToolStripMenuItem_Click);
            // 
            // configurarBotãoDeAcceptToolStripMenuItem
            // 
            this.configurarBotãoDeAcceptToolStripMenuItem.Name = "configurarBotãoDeAcceptToolStripMenuItem";
            this.configurarBotãoDeAcceptToolStripMenuItem.Size = new System.Drawing.Size(466, 22);
            this.configurarBotãoDeAcceptToolStripMenuItem.Text = "Configurar botão de accept";
            this.configurarBotãoDeAcceptToolStripMenuItem.Click += new System.EventHandler(this.ConfigurarBotãoDeAcceptToolStripMenuItem_Click);
            // 
            // adicionarItemToolStripMenuItem
            // 
            this.adicionarItemToolStripMenuItem.Name = "adicionarItemToolStripMenuItem";
            this.adicionarItemToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.adicionarItemToolStripMenuItem.Text = "Adicionar item";
            this.adicionarItemToolStripMenuItem.Click += new System.EventHandler(this.AdicionarItemToolStripMenuItem_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(12, 323);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Iniciar";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(93, 323);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(75, 23);
            this.ButtonStop.TabIndex = 2;
            this.ButtonStop.Text = "Parar";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // GroupBoxBuyCondition
            // 
            this.GroupBoxBuyCondition.AutoSize = true;
            this.GroupBoxBuyCondition.Controls.Add(this.NumericUpDownMaxSpent);
            this.GroupBoxBuyCondition.Controls.Add(this.label1);
            this.GroupBoxBuyCondition.Controls.Add(this.NumericUpDownProfitByPercentage);
            this.GroupBoxBuyCondition.Controls.Add(this.NumericUpDownProfitByValue);
            this.GroupBoxBuyCondition.Controls.Add(this.RadioButtonProfitByValue);
            this.GroupBoxBuyCondition.Controls.Add(this.RadioButtonProfitByPercentage);
            this.GroupBoxBuyCondition.Location = new System.Drawing.Point(12, 27);
            this.GroupBoxBuyCondition.Name = "GroupBoxBuyCondition";
            this.GroupBoxBuyCondition.Size = new System.Drawing.Size(673, 110);
            this.GroupBoxBuyCondition.TabIndex = 3;
            this.GroupBoxBuyCondition.TabStop = false;
            this.GroupBoxBuyCondition.Text = "Condição de compra";
            // 
            // NumericUpDownMaxSpent
            // 
            this.NumericUpDownMaxSpent.Location = new System.Drawing.Point(186, 19);
            this.NumericUpDownMaxSpent.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.NumericUpDownMaxSpent.Name = "NumericUpDownMaxSpent";
            this.NumericUpDownMaxSpent.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownMaxSpent.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gastar até:";
            // 
            // NumericUpDownProfitByPercentage
            // 
            this.NumericUpDownProfitByPercentage.Location = new System.Drawing.Point(186, 71);
            this.NumericUpDownProfitByPercentage.Name = "NumericUpDownProfitByPercentage";
            this.NumericUpDownProfitByPercentage.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownProfitByPercentage.TabIndex = 4;
            this.NumericUpDownProfitByPercentage.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // NumericUpDownProfitByValue
            // 
            this.NumericUpDownProfitByValue.Location = new System.Drawing.Point(186, 45);
            this.NumericUpDownProfitByValue.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.NumericUpDownProfitByValue.Name = "NumericUpDownProfitByValue";
            this.NumericUpDownProfitByValue.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownProfitByValue.TabIndex = 3;
            this.NumericUpDownProfitByValue.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // RadioButtonProfitByValue
            // 
            this.RadioButtonProfitByValue.AutoSize = true;
            this.RadioButtonProfitByValue.Checked = true;
            this.RadioButtonProfitByValue.Location = new System.Drawing.Point(9, 45);
            this.RadioButtonProfitByValue.Name = "RadioButtonProfitByValue";
            this.RadioButtonProfitByValue.Size = new System.Drawing.Size(135, 17);
            this.RadioButtonProfitByValue.TabIndex = 1;
            this.RadioButtonProfitByValue.TabStop = true;
            this.RadioButtonProfitByValue.Text = "Lucro em cima de valor";
            this.RadioButtonProfitByValue.UseVisualStyleBackColor = true;
            // 
            // RadioButtonProfitByPercentage
            // 
            this.RadioButtonProfitByPercentage.AutoSize = true;
            this.RadioButtonProfitByPercentage.Location = new System.Drawing.Point(6, 71);
            this.RadioButtonProfitByPercentage.Name = "RadioButtonProfitByPercentage";
            this.RadioButtonProfitByPercentage.Size = new System.Drawing.Size(174, 17);
            this.RadioButtonProfitByPercentage.TabIndex = 0;
            this.RadioButtonProfitByPercentage.Text = "Lucro em cima de porcentagem";
            this.RadioButtonProfitByPercentage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 358);
            this.Controls.Add(this.GroupBoxBuyCondition);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tibia Market Rush";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GroupBoxBuyCondition.ResumeLayout(false);
            this.GroupBoxBuyCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMaxSpent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownProfitByPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownProfitByValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarLocalDeEscreverNomeDosItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarBotãoDeAcceptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarLocalOndeOPrimeiroItemApareceApósAPesquisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarLocalOndeOValorDoPrimeiroItemApareceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarItemToolStripMenuItem;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.GroupBox GroupBoxBuyCondition;
        private System.Windows.Forms.RadioButton RadioButtonProfitByValue;
        private System.Windows.Forms.RadioButton RadioButtonProfitByPercentage;
        private System.Windows.Forms.NumericUpDown NumericUpDownProfitByPercentage;
        private System.Windows.Forms.NumericUpDown NumericUpDownProfitByValue;
        private System.Windows.Forms.NumericUpDown NumericUpDownMaxSpent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem configurarLocalOndeAQuantidadeDeItemsDoPrimeiroLanceApareceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarLocalOndeAumentaAQuantidadeDeItemsQueDesejaComprarToolStripMenuItem;
    }
}

