using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;

namespace TibiaMarketRush
{
    public partial class Form1 : Form
    {
        public IKeyboardMouseEvents HookEvents;

        public Point SearchTextPosition;
        public Point FirstItemPosition;
        public Point FirstValuePositionTop;
        public Point FirstValuePositionBottom;
        public Point AcceptButtonPosition;

        public bool IsSearchTextPositionConfigured;
        public bool IsFirstItemPositionConfigured;
        public bool IsFirstValuePositionConfigured;
        public bool IsAcceptButtonPositionConfigured;

        public Form1()
        {
            InitializeComponent();

            HookEvents = Hook.GlobalEvents();
        }

        /// <summary>
        /// Verifica e avisa se falta configurar alguma posição.
        /// </summary>
        /// <returns>Retorna true caso esteja tudo configurado e false caso contrário.</returns>
        private bool AskToConfigurePositions()
        {
            bool isAllConfigured = false;

            if (!IsSearchTextPositionConfigured)
            {
                MessageBox.Show("Lembre-se de configurar a posição do local onde digita o nome do item.");
            }
            else if (!IsFirstItemPositionConfigured)
            {
                MessageBox.Show("Lembre-se de configurar o local onde aparece o primeiro item, logo quando você digita o nome de algum na caixa de texto do market.");
            }
            else if (!IsFirstValuePositionConfigured)
            {
                MessageBox.Show("Lembre-se de configurar a posição onde aparece o valor do primeiro lance.");
            }
            else if (!IsAcceptButtonPositionConfigured)
            {
                MessageBox.Show("Lembre-se de configurar a posição do botão de accept.");
            }
            else
            {
                isAllConfigured = true;
            }

            return isAllConfigured;
        }

        private void ConfigurarLocalDeEscreverNomeDosItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Capturaremos seu próximo click com o botão direito do mouse para saber a localização da caixa de pesquisa do market, procure clicar no centro dela (com o botão direito!).\n\n*Obs: Caso você esteja com o market fechado, clique com o botão direito em algum lugar, abra o market e clique novamente na opção de configurar.");

            HookEvents.MouseClick += HookEvents_MouseClick;
        }

        private void HookEvents_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                HookEvents.MouseClick -= HookEvents_MouseClick;

                SearchTextPosition = e.Location;

                IsSearchTextPositionConfigured = true;

                MessageBox.Show("Posição capturada!");
            }
        }
    }
}
