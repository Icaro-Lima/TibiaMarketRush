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

        public WindowsInput.InputSimulator InputSimulator;
        public WindowsInput.MouseSimulator MouseSimulator;
        public WindowsInput.KeyboardSimulator KeyboardSimulator;

        public Point SearchTextPosition;
        public Point FirstItemPosition;
        public Point FirstValuePositionTop;
        public Point FirstValuePositionBottom;
        public Point FirstCountPositionTop;
        public Point FirstCountPositionBottom;
        public Point ChangeCountPosition;
        public Point AcceptButtonPosition;

        public bool IsSearchTextPositionConfigured;
        public bool IsFirstItemPositionConfigured;
        public bool IsFirstValuePositionConfigured;
        public bool IsFirstCountPositionConfigured;
        public bool IsChangeCountPositionConfigured;
        public bool IsAcceptButtonPositionConfigured;

        private int ConfigInExecution;

        public BackgroundWorker BackgroundWorker;

        public Form1()
        {
            InitializeComponent();

            InputSimulator = new WindowsInput.InputSimulator();
            MouseSimulator = new WindowsInput.MouseSimulator(InputSimulator);
            KeyboardSimulator = new WindowsInput.KeyboardSimulator(InputSimulator);

            ButtonStop.Enabled = false;

            HookEvents = Hook.GlobalEvents();

            BackgroundWorker = new BackgroundWorker()
            {
                WorkerSupportsCancellation = true
            };
            BackgroundWorker.DoWork += BackgroundWorker_DoWork;
            BackgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;

            ConfigInExecution = -1;

            RadioButtonProfitByValue.Checked = Properties.Settings.Default.RadioButtonProfitByValue_Checked;
            RadioButtonProfitByPercentage.Checked = Properties.Settings.Default.RadioButtonProfitByPercentage_Checked;
            NumericUpDownMaxSpent.Value = Properties.Settings.Default.NumericUpDownMaxSpent_Value;
            NumericUpDownProfitByValue.Value = Properties.Settings.Default.NumericUpDownProfitByValue_Value;
            NumericUpDownProfitByPercentage.Value = Properties.Settings.Default.NumericUpDownProfitByPercentage_Value;

            SearchTextPosition = Properties.Settings.Default.SearchTextPosition;
            FirstItemPosition = Properties.Settings.Default.FirstItemPosition;
            FirstValuePositionTop = Properties.Settings.Default.FirstValuePositionTop;
            FirstValuePositionBottom = Properties.Settings.Default.FirstValuePositionBottom;
            FirstCountPositionTop = Properties.Settings.Default.FirstCountPositionTop;
            FirstCountPositionBottom = Properties.Settings.Default.FirstCountPositionBottom;
            ChangeCountPosition = Properties.Settings.Default.ChangeCountPosition;
            AcceptButtonPosition = Properties.Settings.Default.AcceptButtonPosition;

            IsSearchTextPositionConfigured = Properties.Settings.Default.IsSearchTextPositionConfigured;
            IsFirstItemPositionConfigured = Properties.Settings.Default.IsFirstItemPositionConfigured;
            IsFirstValuePositionConfigured = Properties.Settings.Default.IsFirstValuePositionConfigured;
            IsFirstCountPositionConfigured = Properties.Settings.Default.IsFirstCountPositionConfigured;
            IsChangeCountPositionConfigured = Properties.Settings.Default.IsChangeCountPositionConfigured;
            IsAcceptButtonPositionConfigured = Properties.Settings.Default.IsAcceptButtonPositionConfigured;

            NumericUpDownDelayToRiskOperations.Value = Properties.Settings.Default.NumericUpDownDelayToRiskOperations_Value;

            AskToConfigurePositions();
        }

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
            else if (!IsFirstCountPositionConfigured)
            {
                MessageBox.Show("Lembre-se de configurar a posição onde aparece a quantidade de items do primeiro lance.");
            }
            else if (!IsAcceptButtonPositionConfigured)
            {
                MessageBox.Show("Lembre-se de configurar a posição do botão de accept.");
            }
            else if (!IsChangeCountPositionConfigured)
            {
                MessageBox.Show("Lembre-se de configurar a posição do botão que aumenta a quantidade de items que você vai comprar.");
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


        private void ConfigurarLocalOndeAQuantidadeDeItemsDoPrimeiroLanceApareceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Capturaremos os seus próximos dois clicks com o botão direito do mouse para saber a área onde aparece a quantidade dos items.");
            ConfigInExecution = 5;
            HookEvents.MouseClick += HookEvents_MouseClick;
        }

        private void configurarLocalOndeAumentaAQuantidadeDeItemsQueDesejaComprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Capturaremos o seu próximo click com o botão direito do mouse para saber a posição onde se encontra o botão que aumenta a quantidade de items que você vai comprar.");
            ConfigInExecution = 7;
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
                else if (ConfigInExecution == 5)
                {
                    FirstCountPositionTop = e.Location;
                    ConfigInExecution = 6;
                    HookEvents.MouseClick += HookEvents_MouseClick;
                }
                else if (ConfigInExecution == 6)
                {
                    FirstCountPositionBottom = e.Location;
                    IsFirstCountPositionConfigured = true;
                    MessageBox.Show("Posições configuradas!");

                    ConfigInExecution = -1;
                }
                else if (ConfigInExecution == 7)
                {
                    ChangeCountPosition = e.Location;
                    IsChangeCountPositionConfigured = true;
                    MessageBox.Show("Posição capturada!");

                    ConfigInExecution = -1;
                }
            }
        }

        private bool IsToBuy(ulong npcPrice, ulong marketPrice)
        {
            if (RadioButtonProfitByValue.Checked)
            {
                if (npcPrice >= marketPrice && npcPrice - marketPrice >= (ulong)NumericUpDownProfitByValue.Value)
                {
                    return true;
                }
            }
            else
            {
                if ((decimal)npcPrice / marketPrice >= 1 + NumericUpDownProfitByPercentage.Value / 100)
                {
                    return true;
                }
            }

            return false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.RadioButtonProfitByValue_Checked = RadioButtonProfitByValue.Checked;
            Properties.Settings.Default.RadioButtonProfitByPercentage_Checked = RadioButtonProfitByPercentage.Checked;
            Properties.Settings.Default.NumericUpDownMaxSpent_Value = NumericUpDownMaxSpent.Value;
            Properties.Settings.Default.NumericUpDownProfitByValue_Value = NumericUpDownProfitByValue.Value;
            Properties.Settings.Default.NumericUpDownProfitByPercentage_Value = NumericUpDownProfitByPercentage.Value;

            Properties.Settings.Default.SearchTextPosition = SearchTextPosition;
            Properties.Settings.Default.FirstItemPosition = FirstItemPosition;
            Properties.Settings.Default.FirstValuePositionTop = FirstValuePositionTop;
            Properties.Settings.Default.FirstValuePositionBottom = FirstValuePositionBottom;
            Properties.Settings.Default.FirstCountPositionTop = FirstCountPositionTop;
            Properties.Settings.Default.FirstCountPositionBottom = FirstCountPositionBottom;
            Properties.Settings.Default.ChangeCountPosition = ChangeCountPosition;
            Properties.Settings.Default.AcceptButtonPosition = AcceptButtonPosition;

            Properties.Settings.Default.IsSearchTextPositionConfigured = IsSearchTextPositionConfigured;
            Properties.Settings.Default.IsFirstItemPositionConfigured = IsFirstItemPositionConfigured;
            Properties.Settings.Default.IsFirstValuePositionConfigured = IsFirstValuePositionConfigured;
            Properties.Settings.Default.IsFirstCountPositionConfigured = IsFirstCountPositionConfigured;
            Properties.Settings.Default.IsChangeCountPositionConfigured = IsChangeCountPositionConfigured;
            Properties.Settings.Default.IsAcceptButtonPositionConfigured = IsAcceptButtonPositionConfigured;

            Properties.Settings.Default.NumericUpDownDelayToRiskOperations_Value = (int)NumericUpDownDelayToRiskOperations.Value;

            Properties.Settings.Default.Save();
        }

        private void AdicionarItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.ShowDialog();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (AskToConfigurePositions())
            {
                MessageBox.Show("Use a tecla 'Esc' para parar.");

                BackgroundWorker.RunWorkerAsync();

                HookEvents.KeyPress += HookEvents_KeyPress;

                ButtonStart.Enabled = false;
                ButtonStop.Enabled = true;
            }
        }

        private void HookEvents_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                BackgroundWorker.CancelAsync();
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 400; i++)
            {
                if (BackgroundWorker.CancellationPending)
                {
                    e.Cancel = true;

                    return;
                }
                System.Threading.Thread.Sleep(10);
            }

            TibiaImageReader tibiaImageReader = new TibiaImageReader();
            AddItem addItem = new AddItem();

            List<Item> items = addItem.GetAllItems();
            ulong spent = 0;
            foreach (Item item in items)
            {
                if (BackgroundWorker.CancellationPending || spent >= NumericUpDownMaxSpent.Value)
                {
                    if (BackgroundWorker.CancellationPending)
                    {
                        e.Cancel = true;
                    }

                    return;
                }

                MouseSimulator.MoveMouseTo((double)SearchTextPosition.X / Screen.PrimaryScreen.Bounds.Width * ushort.MaxValue, (double)SearchTextPosition.Y / Screen.PrimaryScreen.Bounds.Height * ushort.MaxValue);
                MouseSimulator.LeftButtonClick();
                System.Threading.Thread.Sleep(150);
                KeyboardSimulator.ModifiedKeyStroke(WindowsInput.Native.VirtualKeyCode.CONTROL, WindowsInput.Native.VirtualKeyCode.VK_A);
                System.Threading.Thread.Sleep(150);
                KeyboardSimulator.TextEntry(item.Name);
                System.Threading.Thread.Sleep((int)NumericUpDownDelayToRiskOperations.Value);
                MouseSimulator.MoveMouseTo((double)FirstItemPosition.X / Screen.PrimaryScreen.Bounds.Width * ushort.MaxValue, (double)FirstItemPosition.Y / Screen.PrimaryScreen.Bounds.Height * ushort.MaxValue);
                MouseSimulator.LeftButtonDoubleClick();
                System.Threading.Thread.Sleep((int)NumericUpDownDelayToRiskOperations.Value);

                try
                {
                    while (true)
                    {
                        if (BackgroundWorker.CancellationPending || spent >= NumericUpDownMaxSpent.Value)
                        {
                            if (BackgroundWorker.CancellationPending)
                            {
                                e.Cancel = true;
                            }

                            return;
                        }

                        uint marketValue = tibiaImageReader.GetValueOfCurrentItem(FirstValuePositionTop, FirstValuePositionBottom);

                        if (IsToBuy(item.Value, marketValue) && (!CheckBoxMonitored.Checked || MessageBox.Show("Pode comprar? Item: " + item.Name + " Valor: " + item.Value, "", MessageBoxButtons.YesNo) == DialogResult.Yes) && marketValue + spent <= NumericUpDownMaxSpent.Value)
                        {
                            uint quantyToBuy = (uint)(NumericUpDownMaxSpent.Value - spent) / marketValue;
                            uint quantyIsBuy = Math.Min(quantyToBuy, tibiaImageReader.GetValueOfCurrentItem(FirstCountPositionTop, FirstCountPositionBottom));

                            for (int i = 1; i < quantyIsBuy; i++)
                            {
                                MouseSimulator.MoveMouseTo((double)ChangeCountPosition.X / Screen.PrimaryScreen.Bounds.Width * ushort.MaxValue, (double)ChangeCountPosition.Y / Screen.PrimaryScreen.Bounds.Height * ushort.MaxValue);
                                System.Threading.Thread.Sleep(100);
                                MouseSimulator.LeftButtonClick();

                                TextBoxSpent.Text = uint.Parse(TextBoxSpent.Text) + marketValue + "";
                                TextBoxProfit.Text = uint.Parse(TextBoxProfit.Text) + item.Value - marketValue + "";
                            }

                            MouseSimulator.MoveMouseTo((double)AcceptButtonPosition.X / Screen.PrimaryScreen.Bounds.Width * ushort.MaxValue, (double)AcceptButtonPosition.Y / Screen.PrimaryScreen.Bounds.Height * ushort.MaxValue);
                            System.Threading.Thread.Sleep(50);
                            MouseSimulator.LeftButtonClick();

                            spent += quantyIsBuy * marketValue;
                            TextBoxSpent.Text = uint.Parse(TextBoxSpent.Text) + marketValue + "";
                            TextBoxProfit.Text = uint.Parse(TextBoxProfit.Text) + item.Value - marketValue + "";
                        }
                        else
                        {
                            break;
                        }

                        System.Threading.Thread.Sleep((int)NumericUpDownDelayToRiskOperations.Value);
                    }
                }
                catch { }
            }
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (CheckBoxLoop.Checked && !e.Cancelled)
            {
                BackgroundWorker.RunWorkerAsync();
            }
            else
            {
                HookEvents.KeyPress -= HookEvents_KeyPress;

                ButtonStart.Enabled = true;
                ButtonStop.Enabled = false;
            }
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            BackgroundWorker.CancelAsync();
        }
    }
}
