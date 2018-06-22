using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmersChoice
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
            comPorts.Items.AddRange(SerialPort.GetPortNames());
        }

        private void Config_Load(object sender, EventArgs e)
        {
            weighingScaleId.Text = Properties.Settings.Default.weighingScaleId;
            comPorts.SelectedText = Properties.Settings.Default.comPort;
            baudRates.SelectedText = Properties.Settings.Default.baudRate;
            databaseHost.Text = Properties.Settings.Default.databaseHost;
            databaseName.Text = Properties.Settings.Default.databaseName;
            databaseUser.Text = Properties.Settings.Default.databaseUser;
            databasePassword.Text = Properties.Settings.Default.databasePassword;
        }

        private void comPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void baudRates_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveConfig_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to change system configuration?", "System Config Update", MessageBoxButtons.YesNoCancel))
            {
                Properties.Settings.Default.weighingScaleId = weighingScaleId.Text;
                Properties.Settings.Default.comPort = comPorts.SelectedItem.ToString();
                Properties.Settings.Default.baudRate = baudRates.SelectedItem.ToString();
                Properties.Settings.Default.databaseHost = databaseHost.Text;
                Properties.Settings.Default.databaseName = databaseName.Text;
                Properties.Settings.Default.databaseUser = databaseUser.Text;
                Properties.Settings.Default.databasePassword = databasePassword.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
        }
    }
}
