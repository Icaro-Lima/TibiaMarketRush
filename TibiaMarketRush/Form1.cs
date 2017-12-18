using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

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

        private int ConfigInExecution;

        public AddItem AddItem;

        public BackgroundWorker BackgroundWorker;

        public Form1()
        {
            InitializeComponent();

            System.Threading.Thread.Sleep(4000);
            TibiaImageReader tibiaImageReader = new TibiaImageReader();

            ButtonStop.Enabled = false;

            HookEvents = Hook.GlobalEvents();

            AddItem = new AddItem();

            BackgroundWorker = new BackgroundWorker()
            {
                WorkerSupportsCancellation = true
            };

            ConfigInExecution = -1;

            SearchTextPosition = Properties.Settings.Default.SearchTextPosition;
            FirstItemPosition = Properties.Settings.Default.FirstItemPosition;
            FirstValuePositionTop = Properties.Settings.Default.FirstValuePositionTop;
            FirstValuePositionBottom = Properties.Settings.Default.FirstValuePositionBottom;
            AcceptButtonPosition = Properties.Settings.Default.AcceptButtonPosition;

            IsSearchTextPositionConfigured = Properties.Settings.Default.IsSearchTextPositionConfigured;
            IsFirstItemPositionConfigured = Properties.Settings.Default.IsFirstItemPositionConfigured;
            IsFirstValuePositionConfigured = Properties.Settings.Default.IsFirstValuePositionConfigured;
            IsAcceptButtonPositionConfigured = Properties.Settings.Default.IsAcceptButtonPositionConfigured;

            AskToConfigurePositions();
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
            ConfigInExecution = 0;
            HookEvents.MouseClick += HookEvents_MouseClick;
        }

        private void ConfigurarLocalOndeOPrimeiroItemApareceApósAPesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Capturaremos seu próximo click com o botão direito do mouse para saber a localização do primeiro item que aparece após uma pesquisa.");
            ConfigInExecution = 1;
            HookEvents.MouseClick += HookEvents_MouseClick;
        }

        private void ConfigurarLocalOndeOValorDoPrimeiroItemApareceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Capturaremos os seus próximos dois clicks com o botão direito do mouse para saber a área onde aparece o valor do item.");
            ConfigInExecution = 2;
            HookEvents.MouseClick += HookEvents_MouseClick;
        }

        private void ConfigurarBotãoDeAcceptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Capturaremos o seu próximo click com o botão direito do mouse para saber a posição onde se encontra o botão accept na parte onde você compra o item.");
            ConfigInExecution = 4;
            HookEvents.MouseClick += HookEvents_MouseClick;
        }

        private void HookEvents_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                HookEvents.MouseClick -= HookEvents_MouseClick;

                if (ConfigInExecution == 0)
                {
                    SearchTextPosition = e.Location;
                    IsSearchTextPositionConfigured = true;
                    MessageBox.Show("Posição capturada!");

                    ConfigInExecution = -1;
                }
                else if (ConfigInExecution == 1)
                {
                    FirstItemPosition = e.Location;
                    IsFirstItemPositionConfigured = true;
                    MessageBox.Show("Posição capturada!");

                    ConfigInExecution = -1;
                }
                else if (ConfigInExecution == 2)
                {
                    FirstValuePositionTop = e.Location;
                    ConfigInExecution = 3;
                    HookEvents.MouseClick += HookEvents_MouseClick;
                }
                else if (ConfigInExecution == 3)
                {
                    FirstValuePositionBottom = e.Location;
                    IsFirstValuePositionConfigured = true;
                    MessageBox.Show("Posições configuradas!");

                    ConfigInExecution = -1;
                }
                else if (ConfigInExecution == 4)
                {
                    AcceptButtonPosition = e.Location;
                    IsAcceptButtonPositionConfigured = true;
                    MessageBox.Show("Posição configurada!");

                    ConfigInExecution = -1;
                }
            }
        }

        private bool IsToBuy(ulong npcPrice, ulong marketPrice)
        {
            if (RadioButtonProfitByValue.Checked)
            {
                if (npcPrice - marketPrice >= (ulong)NumericUpDownProfitByValue.Value)
                {
                    return true;
                }
            }
            else
            {
                if ((decimal)npcPrice / marketPrice >= NumericUpDownProfitByPercentage.Value / 100)
                {
                    return true;
                }
            }

            return false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SearchTextPosition = SearchTextPosition;
            Properties.Settings.Default.FirstItemPosition = FirstItemPosition;
            Properties.Settings.Default.FirstValuePositionTop = FirstValuePositionTop;
            Properties.Settings.Default.FirstValuePositionBottom = FirstValuePositionBottom;
            Properties.Settings.Default.AcceptButtonPosition = AcceptButtonPosition;

            Properties.Settings.Default.IsSearchTextPositionConfigured = IsSearchTextPositionConfigured;
            Properties.Settings.Default.IsFirstItemPositionConfigured = IsFirstItemPositionConfigured;
            Properties.Settings.Default.IsFirstValuePositionConfigured = IsFirstValuePositionConfigured;
            Properties.Settings.Default.IsAcceptButtonPositionConfigured = IsAcceptButtonPositionConfigured;

            Properties.Settings.Default.Save();
        }

        private void AdicionarItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem.ShowDialog();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            BackgroundWorker.DoWork += BackgroundWorker_DoWork;
            BackgroundWorker.RunWorkerAsync();

            ButtonStart.Enabled = false;
            ButtonStop.Enabled = true;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(4000);

            WindowsInput.InputSimulator inputSimulator = new WindowsInput.InputSimulator();
            WindowsInput.MouseSimulator mouseSimulator = new WindowsInput.MouseSimulator(inputSimulator);

            List<Item> items = AddItem.GetAllItems();
            ulong spent = 0;

            Cursor = new Cursor(Cursor.Current.Handle);

            foreach (Item item in items)
            {
                if (BackgroundWorker.CancellationPending || spent >= NumericUpDownMaxSpent.Value)
                {
                    return;
                }



            }
        }
    }
}
