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
using System.Data.SqlClient;

namespace FarmersChoice
{
    public partial class Form1 : Form
    {
        string sysInformation;
        string _connectionString = $"Server={Properties.Settings.Default.databaseHost};Initial Catalog={Properties.Settings.Default.databaseName};Persist Security Info=False;User ID={Properties.Settings.Default.databaseUser};Password={Properties.Settings.Default.databasePassword};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public Form1()
        {
            InitializeComponent();   

            //Disable weighing group of input
            groupWeighing.Enabled = false;

            //Log terminal information at the status bar (not information)
            sysInformation = "Terminal: " + Properties.Settings.Default.weighingScaleId;

            //Disable crate weight text box. Can be disabled in design view
            crateWeight.Enabled = false;

            //If config is blank, disable entry
            if (Properties.Settings.Default.baudRate == null || Properties.Settings.Default.comPort == null || Properties.Settings.Default.weighingScaleId == null || Properties.Settings.Default.databaseHost == null || Properties.Settings.Default.databaseName == null || Properties.Settings.Default.databaseUser == null || Properties.Settings.Default.databasePassword == null)
            {
                groupReceiveData.Enabled = false;
                farmersDetails.Enabled = false;
                recordWeightButton.Enabled = false;
                receiveData.Enabled = false;
                MessageBox.Show("Please configure application settings to proceed");
            }

            //Display system information on the status label
            toolStripStatusLabel.Text = sysInformation;
        }

        //Read weight from the scale
        private void ReceiveData_Click(object sender, EventArgs e)
        {
            //Local Variables
            string port = Properties.Settings.Default.comPort;    // Store the selected COM port name to "port" varaiable
            int baudRate = Convert.ToInt32(Properties.Settings.Default.baudRate); // Convert the baud rate string "9600" to int32 9600

            //Random data for testing in case there is not weighing scale
            //double receivedData = new Random().NextDouble() * (new Random()).Next(10000); 
            //receivedData = Math.Round(receivedData, 2);

            double dataReceived = 0.00;

            //Intialise com port
            SerialPort COMport = new SerialPort(port, baudRate);
            COMport.ReadTimeout = 3500; //Setting ReadTimeout =3500 ms or 3.5 seconds

            try
            {
                //Open com port to read data
                COMport.Open();
            }
            catch (Exception ex)
            {
                //Show error message in case cannot connect
                MessageBox.Show(ex.Message);
            }

            try
            {
                //If we managed to open port
                if (COMport.IsOpen == true)
                {
                    //MessageBox.Show("Port Opened");
                    toolStripStatusLabel.Text = port + Environment.NewLine + baudRate;
                    statusStrip.Refresh();

                    //Read data
                    string data = COMport.ReadLine().ToString();

                    //Replace unwanted characters from string to remain with value convertible to double
                    StringBuilder sb = new StringBuilder(data);
                    sb.Replace("US,GS,    ", "");
                    sb.Replace("KG", "");

                    // Close the Port
                    COMport.Close();                                  
                    toolStripStatusLabel.Text = data + "  Received from Port";
                    statusStrip.Refresh();

                    dataReceived = Convert.ToDouble(sb.ToString());

                }
                else
                {
                    // groupSendData.Enabled = true; // Enable the Transmit Groupbox
                    MessageBox.Show("Unable to read from COM port. Please make sure the weighing scale is connected to the printer and correct configuration set");
                    COMport.Close();                                  // Close the Port
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (dataReceived > 0)
            {

                //Set the respective text boxes with data
                receivedData.Text = Math.Round(dataReceived, 2).ToString();
                itemWeight.Text = Math.Round(dataReceived, 2).ToString();
                
                //Enable crate weight textbox
                crateWeight.Enabled = true;
                crateWeight.Text = "0.00";

                //calculate net weight, less crate weight and set value of box
                var netweight = Math.Round(dataReceived, 2) - Convert.ToDouble(crateWeight.Text);
                netWeight.Text = netweight.ToString();

            }

        }

        //Update net weight value when care weight changes
        private void CrateWeight_TextChanged(object sender, EventArgs e)
        {
            if(crateWeight.Text != "")
            {
                double netweight = Convert.ToDouble(itemWeight.Text) - Convert.ToDouble(crateWeight.Text);
                netWeight.Text = Math.Round(netweight, 2).ToString();
            }
        }
        
        //Persist data to database
        private void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = netWeight.Text + " KG " + animalType.Text;
            //insert into your database weight,selected_product,machine values (netWeight.Text,selectedProduct.Text,SystemInformation)
            

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                String query = " INSERT INTO dbo.WeighedResults (Date, AnimalType, ReceiptNo,VendorNo,Weight,MeatPercent,ClassificationCode) VALUES (@date,@animalType,@receiptNo,@vendorNo,@netWeight,@meatPercent,@classificationCode)";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    DateTime time = DateTime.Now;
                    cmd.Parameters.AddWithValue("@date", time);
                    cmd.Parameters.AddWithValue("@animalType", animalType.Text); 
                    cmd.Parameters.AddWithValue("@receiptNo", receiptNumber.Text); 
                    cmd.Parameters.AddWithValue("@vendorNo", vendorNo.Text);
                    cmd.Parameters.AddWithValue("@netWeight", Convert.ToDecimal(netWeight.Text)); 
                    cmd.Parameters.AddWithValue("@meatPercent", Convert.ToInt16(meatPercent.Text));
                    cmd.Parameters.AddWithValue("@classificationCode", classificationCode.Text);

                    connection.Open();
                    try
                    {

                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    toolStripStatusLabel.Text = "Data Saved";
                    MessageBox.Show("Weight has been recorded");
                    this.ClearTextboxes(this.Controls);
                    statusStrip.Refresh();
                }
            }

        }

        //Evaluate classification upon meat percent input. This function should be re-written to have conditions in database
        private void meatPercent_Leave(object sender, EventArgs e)
        {
            
            if (meatPercent.Text != "")
            {
                groupWeighing.Enabled = true;
                //Exclusice farms. These should be in a look-up table
                string[] specialFarms = { "PF99901", "PF99902", "PF99903", "PF99904", "PF99905" };
                var meatPercentVal = Convert.ToByte(meatPercent.Text);
                var netWeightVal = Convert.ToDouble(itemWeight.Text) - Convert.ToDouble(crateWeight.Text);
                if(specialFarms.Contains(vendorNo.Text))
                {
                    if (meatPercentVal >= 0 && meatPercentVal <= 20 && animalType.Text == "G0110" && netWeightVal < 40)
                    {
                        classificationCode.Text = "RMPK-SUB40";
                    }
                    if (meatPercentVal >= 0 && meatPercentVal <= 100 && animalType.Text == "G0110" && netWeightVal >= 40 && netWeightVal <= 49)
                    {
                        classificationCode.Text = "RM-CLS05";
                    }
                    if (meatPercentVal >= 8 && meatPercentVal <= 10 && animalType.Text == "G0110" && netWeightVal >= 56 && netWeightVal <= 59)
                    {
                        classificationCode.Text = "RM-CLS02";
                    }
                    if (meatPercentVal >= 0 && meatPercentVal <= 7 && animalType.Text == "G0110" && netWeightVal >= 56 && netWeightVal <= 75)
                    {
                        classificationCode.Text = "RM-CLS02";
                    }
                    if (meatPercentVal >= 11 && meatPercentVal <= 100 && animalType.Text == "G0110" && netWeightVal >= 56 && netWeightVal <= 75)
                    {
                        classificationCode.Text = "RM-CLS02";
                    }
                    if (meatPercentVal >= 8 && meatPercentVal <= 10 && animalType.Text == "G0110" && netWeightVal >= 60 && netWeightVal <= 75)
                    {
                        classificationCode.Text = "RM-CLS01";
                    }
                    if (meatPercentVal >= 0 && meatPercentVal <= 100 && animalType.Text == "G0110" && netWeightVal >= 76 && netWeightVal <= 85)
                    {
                        classificationCode.Text = "RM-CLS03";
                    }
                    if (meatPercentVal >= 0 && meatPercentVal <= 100 && animalType.Text == "G0110" && netWeightVal >= 50 && netWeightVal <= 55)
                    {
                        classificationCode.Text = "RM-CLS04";
                    }
                    if (meatPercentVal >= 0 && meatPercentVal <= 100 && animalType.Text == "G0110" && netWeightVal >= 86 && netWeightVal <= 100)
                    {
                        classificationCode.Text = "RM-CLS06";
                    }
                    if (meatPercentVal >= 0 && meatPercentVal <= 100 && animalType.Text == "G0110" && netWeightVal >= 101 && netWeightVal <= 120)
                    {
                        classificationCode.Text = "RM-CLS07";
                    }

                    if (meatPercentVal >= 0 && meatPercentVal <= 100 && animalType.Text == "G0110" && netWeightVal > 120)
                    {
                        classificationCode.Text = "RM-CLS08";
                    }
                    if (animalType.Text == "G0111")
                    {
                        classificationCode.Text = "SOW-RM";
                    }
                    if (animalType.Text == "G0113" && netWeightVal >= 5 && netWeightVal <= 7)
                    {
                        classificationCode.Text = "RM-SK1";
                    }
                    if (animalType.Text == "G0113" && netWeightVal >= 7 && netWeightVal < 9)
                    {
                        classificationCode.Text = "RM-SK2";
                    }
                    if (animalType.Text == "G0113" && netWeightVal >= 9 && netWeightVal < 16)
                    {
                        classificationCode.Text = "RM-SK3";
                    }
                    if (animalType.Text == "G0113" && netWeightVal >= 17 && netWeightVal < 20)
                    {
                        classificationCode.Text = "RM-SK4";
                    }
                    if (animalType.Text == "G0113" && netWeightVal >= 9 && netWeightVal < 20)
                    {
                        classificationCode.Text = "RM-SK5";
                    }
                }
                else
                {
                    if (meatPercentVal >= 0 && meatPercentVal <= 20 && animalType.Text == "G0110" && netWeightVal < 40)
                    {
                        classificationCode.Text = "PK-SUB40";
                    }
                    if (meatPercentVal >= 0 && meatPercentVal <= 100 && animalType.Text == "G0110" && netWeightVal >= 40 && netWeightVal <= 49)
                    {
                        classificationCode.Text = "CLS-05";
                    }
                    if (meatPercentVal >= 8 && meatPercentVal <= 10 && animalType.Text == "G0101" && netWeightVal >= 50 && netWeightVal <= 59)
                    {
                        classificationCode.Text = "CLS-02";
                    }
                    if (meatPercentVal >= 0 && meatPercentVal <= 7 && animalType.Text == "G0101" && netWeightVal >= 56 && netWeightVal <= 75)
                    {
                        classificationCode.Text = "CLS-02";
                    }
                    if (meatPercentVal >= 11 && meatPercentVal <= 100 && animalType.Text == "G0110" && netWeightVal >= 56 && netWeightVal <= 75)
                    {
                        classificationCode.Text = "CLS-02";
                    }
                    if (meatPercentVal >= 8 && meatPercentVal <= 10 && animalType.Text == "G0110" && netWeightVal >= 60 && netWeightVal <= 75)
                    {
                        classificationCode.Text = "CLS-01";
                    }
                    if (meatPercentVal >= 0 && meatPercentVal <= 100 && animalType.Text == "G0110" && netWeightVal >= 76 && netWeightVal <= 85)
                    {
                        classificationCode.Text = "CLS-03";
                    }
                    if (meatPercentVal >= 0 && meatPercentVal <= 100 && animalType.Text == "G0110" && netWeightVal >= 50 && netWeightVal <= 55)
                    {
                        classificationCode.Text = "CLS-04";
                    }
                    if (meatPercentVal >= 0 && meatPercentVal <= 100 && animalType.Text == "G0110" && netWeightVal >= 86 && netWeightVal <= 100)
                    {
                        classificationCode.Text = "CLS-06";
                    }
                    if (meatPercentVal >= 0 && meatPercentVal <= 100 && animalType.Text == "G0110" && netWeightVal >= 101 && netWeightVal <= 120)
                    {
                        classificationCode.Text = "CLS-07";
                    }

                    if (meatPercentVal >= 0 && meatPercentVal <= 100 && animalType.Text == "G0101" && netWeightVal > 120)
                    {
                        classificationCode.Text = "CLS-08";
                    }
                    if (animalType.Text == "G0111")
                    {
                        classificationCode.Text = "SOW-3P";
                    }
                    if (animalType.Text == "G0113" && netWeightVal >= 5 && netWeightVal < 8)
                    {
                        classificationCode.Text = "3P-SK4";
                    }
                    if (animalType.Text == "G0113" && netWeightVal >= 9 && netWeightVal < 20)
                    {
                        classificationCode.Text = "3P-SK5";
                    }
                }           
            }
            else
            {

            }
        }

        //Retrieve livestock acceptance details and fill respective textboxes when receipt number entered.
        private void receiptNumber_Leave(object sender, EventArgs e)
        {
            if (receiptNumber.Text == "")
            {
                MessageBox.Show("Please fill in receipt number");
            }
            else
            {       
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    String query = @"SELECT VendorNo, VendorName, AnimalType, Description FROM  dbo.fromNav WHERE ReceiptNo = @ReceiptNo";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReceiptNo", receiptNumber.Text);
     
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Invalid receipt number. Please confirm before proceeding");
                                meatPercent.Enabled = false;
                            }
                            else
                            {
                                vendorNo.Text = reader["VendorNo"].ToString();
                                vendorName.Text = reader["VendorName"].ToString();
                                animalType.Text = reader["AnimalType"].ToString();
                                meatPercent.Enabled = true;
                                // receiptDetails.Text = $"Receipt no: {receiptNumber.Text} Vendor Name: {vendorName} Animal Type: {animalType}";                           
                            }                    
                        }

                    }
                }
            }
        }

        //Clear all textbox values
        private void ClearTextboxes(System.Windows.Forms.Control.ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                ClearTextboxes(ctrl.Controls);
            }
        }

        //Load config menu when menu button clicked
        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config configForm = new Config();
            configForm.Show();
        }

        //Exit application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Are you sure you want to close the application?", "Application Exit", MessageBoxButtons.OKCancel))
            {
                Application.Exit();
            }
        }
    }
}
