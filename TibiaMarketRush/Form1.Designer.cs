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
            this.configurarBotãoDeAcceptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.configurarBotãoDeAcceptToolStripMenuItem});
            this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            this.configurarToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.configurarToolStripMenuItem.Text = "Configurar";
            // 
            // configurarLocalDeEscreverNomeDosItemsToolStripMenuItem
            // 
            this.configurarLocalDeEscreverNomeDosItemsToolStripMenuItem.Name = "configurarLocalDeEscreverNomeDosItemsToolStripMenuItem";
            this.configurarLocalDeEscreverNomeDosItemsToolStripMenuItem.Size = new System.Drawing.Size(404, 22);
            this.configurarLocalDeEscreverNomeDosItemsToolStripMenuItem.Text = "Configurar local de escrever nome dos items";
            this.configurarLocalDeEscreverNomeDosItemsToolStripMenuItem.Click += new System.EventHandler(this.ConfigurarLocalDeEscreverNomeDosItemsToolStripMenuItem_Click);
            // 
            // configurarLocalOndeOPrimeiroItemApareceApósAPesquisaToolStripMenuItem
            // 
            this.configurarLocalOndeOPrimeiroItemApareceApósAPesquisaToolStripMenuItem.Name = "configurarLocalOndeOPrimeiroItemApareceApósAPesquisaToolStripMenuItem";
            this.configurarLocalOndeOPrimeiroItemApareceApósAPesquisaToolStripMenuItem.Size = new System.Drawing.Size(404, 22);
            this.configurarLocalOndeOPrimeiroItemApareceApósAPesquisaToolStripMenuItem.Text = "Configurar local onde o primeiro item aparece após a pesquisa";
            this.configurarLocalOndeOPrimeiroItemApareceApósAPesquisaToolStripMenuItem.Click += new System.EventHandler(this.ConfigurarLocalOndeOPrimeiroItemApareceApósAPesquisaToolStripMenuItem_Click);
            // 
            // configurarLocalOndeOValorDoPrimeiroItemApareceToolStripMenuItem
            // 
            this.configurarLocalOndeOValorDoPrimeiroItemApareceToolStripMenuItem.Name = "configurarLocalOndeOValorDoPrimeiroItemApareceToolStripMenuItem";
            this.configurarLocalOndeOValorDoPrimeiroItemApareceToolStripMenuItem.Size = new System.Drawing.Size(404, 22);
            this.configurarLocalOndeOValorDoPrimeiroItemApareceToolStripMenuItem.Text = "Configurar local onde o valor do primeiro item aparece";
            this.configurarLocalOndeOValorDoPrimeiroItemApareceToolStripMenuItem.Click += new System.EventHandler(this.ConfigurarLocalOndeOValorDoPrimeiroItemApareceToolStripMenuItem_Click);
            // 
            // configurarBotãoDeAcceptToolStripMenuItem
            // 
            this.configurarBotãoDeAcceptToolStripMenuItem.Name = "configurarBotãoDeAcceptToolStripMenuItem";
            this.configurarBotãoDeAcceptToolStripMenuItem.Size = new System.Drawing.Size(404, 22);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 358);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tibia Market Rush";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

