using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace FarmersChoice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            baudRates.Enabled = false;
            receiveData.Enabled = false;
            sendData.Enabled = false;
            comPorts.Items.AddRange(SerialPort.GetPortNames());
            String SystemInformation;//Used for Storing System Information 
            SystemInformation = "Terminal: " + System.Environment.MachineName;
            toolStripStatusLabel.Text = SystemInformation;
            groupWeighing.Enabled = false;
        }


        private void comPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            baudRates.Enabled = true;
        }

        private void baudRates_SelectedIndexChanged(object sender, EventArgs e)
        {
            sendData.Enabled = true;
            receiveData.Enabled = true;
        }

        private void SendData_Click(object sender, EventArgs e)
        {
            groupReceiveData.Enabled = false;

            //Local Variables
            string port = comPorts.SelectedItem.ToString();    // Store the selected COM port name to "Port_Name" varaiable
            int baudRate = Convert.ToInt32(baudRates.SelectedItem); // Convert the string "9600" to int32 9600
            string data = dataToSend.Text;                             //Store the string in Textbox to variable "Data"
            SerialPort COMport = new SerialPort(port, baudRate); //Create a new  SerialPort Object (defaullt setting -> 8N1)

            try
            {
                COMport.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(COMport.IsOpen == true)
            {
                //MessageBox.Show("Port Opened");
                COMport.WriteLine(data);                // Send Data
                COMport.Close();                        // Close the Port
                groupReceiveData.Enabled = true; // Enable the Receive Groupbox
            }
            else
            {
                groupSendData.Enabled = true; // Enable the Receive Groupbox
                MessageBox.Show("Unable to Write to COM port ");
                COMport.Close();
            }
        }

        private void ReceiveData_Click(object sender, EventArgs e)
        {
            groupSendData.Enabled = false;
            //Local Variables
            string port = comPorts.SelectedItem.ToString();    // Store the selected COM port name to "Port_Name" varaiable
            int baudRate = Convert.ToInt32(baudRates.SelectedItem); // Convert the string "9600" to int32 9600
            double ReceivedData = new Random().NextDouble() * (new Random()).Next(10000);
            ReceivedData = Math.Round(ReceivedData, 2);
            SerialPort COMport = new SerialPort(port, baudRate);
            receivedData.Text = ReceivedData.ToString();
            COMport.ReadTimeout = 3500; //Setting ReadTimeout =3500 ms or 3.5 seconds

            try
            {
                COMport.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {

                //If we are able to open the port 
                if (COMport.IsOpen == true)
                {
                    //MessageBox.Show("Port Opened");
                    toolStripStatusLabel.Text = port + Environment.NewLine + baudRate;
                    statusStrip.Refresh();

                    //ReceivedData = COMport.ReadLine();                // Wait for data reception

                    #region
                    toolStripStatusLabel.Text = "Waiting for Data...............";
                    statusStrip.Refresh();

                    //toolStripProgressBar.Text = ReceivedData;

                    COMport.Close();                                  // Close the Port
                    toolStripStatusLabel.Text = ReceivedData + "  Received from Port";
                    statusStrip.Refresh();

                    #endregion
                    groupSendData.Enabled = true; // Enable the Transmit Groupbox
                }
                else
                {
                    groupSendData.Enabled = true; // Enable the Transmit Groupbox
                    MessageBox.Show("Unable to read from COM port ");
                    COMport.Close();                                  // Close the Port
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(ReceivedData > 0)
            {
                ItemSelection popup = new ItemSelection();

                popup.ShowDialog();

                string userEnteredText = popup.selectedItem;

                //popup.Dispose();
                itemWeight.Text = Math.Round(ReceivedData, 2).ToString();
                selectedProduct.Text = userEnteredText;
                
                toolStripStatusLabel.Text = ReceivedData + "  " + userEnteredText;
                statusStrip.Refresh();
                groupWeighing.Enabled = true;
            }

        }

        

        private void CrateWeight_TextChanged(object sender, EventArgs e)
        {
            if(crateWeight.Text != "")
            {
                double netweight = Convert.ToDouble(itemWeight.Text) - Convert.ToDouble(crateWeight.Text);
                netWeight.Text = Math.Round(netweight, 2).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = netWeight.Text + " KG " + selectedProduct.Text;
            statusStrip.Refresh();
        }
    }
}
