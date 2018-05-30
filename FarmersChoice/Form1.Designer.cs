namespace FarmersChoice
{
    partial class Form1
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
            this.groupSerialSettings = new System.Windows.Forms.GroupBox();
            this.baudRatesLabel = new System.Windows.Forms.Label();
            this.baudRates = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comPorts = new System.Windows.Forms.ComboBox();
            this.groupSendData = new System.Windows.Forms.GroupBox();
            this.sendData = new System.Windows.Forms.Button();
            this.dataToSendLabel = new System.Windows.Forms.Label();
            this.dataToSend = new System.Windows.Forms.TextBox();
            this.groupReceiveData = new System.Windows.Forms.GroupBox();
            this.receivedDataLabel = new System.Windows.Forms.Label();
            this.receivedData = new System.Windows.Forms.TextBox();
            this.receiveData = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupWeighing = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.netWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.crateWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedProduct = new System.Windows.Forms.TextBox();
            this.itemWeight = new System.Windows.Forms.TextBox();
            this.groupSerialSettings.SuspendLayout();
            this.groupSendData.SuspendLayout();
            this.groupReceiveData.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupWeighing.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSerialSettings
            // 
            this.groupSerialSettings.Controls.Add(this.baudRatesLabel);
            this.groupSerialSettings.Controls.Add(this.baudRates);
            this.groupSerialSettings.Controls.Add(this.label1);
            this.groupSerialSettings.Controls.Add(this.comPorts);
            this.groupSerialSettings.Location = new System.Drawing.Point(18, 33);
            this.groupSerialSettings.Name = "groupSerialSettings";
            this.groupSerialSettings.Size = new System.Drawing.Size(743, 88);
            this.groupSerialSettings.TabIndex = 0;
            this.groupSerialSettings.TabStop = false;
            this.groupSerialSettings.Text = "Serial Connection Settings";
            // 
            // baudRatesLabel
            // 
            this.baudRatesLabel.AutoSize = true;
            this.baudRatesLabel.Location = new System.Drawing.Point(448, 46);
            this.baudRatesLabel.Name = "baudRatesLabel";
            this.baudRatesLabel.Size = new System.Drawing.Size(82, 17);
            this.baudRatesLabel.TabIndex = 3;
            this.baudRatesLabel.Text = "Baud Rates";
            // 
            // baudRates
            // 
            this.baudRates.FormattingEnabled = true;
            this.baudRates.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.baudRates.Location = new System.Drawing.Point(538, 43);
            this.baudRates.Name = "baudRates";
            this.baudRates.Size = new System.Drawing.Size(186, 24);
            this.baudRates.TabIndex = 2;
            this.baudRates.SelectedIndexChanged += new System.EventHandler(this.baudRates_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Com Ports";
            // 
            // comPorts
            // 
            this.comPorts.FormattingEnabled = true;
            this.comPorts.Location = new System.Drawing.Point(110, 39);
            this.comPorts.Name = "comPorts";
            this.comPorts.Size = new System.Drawing.Size(121, 24);
            this.comPorts.TabIndex = 0;
            this.comPorts.SelectedIndexChanged += new System.EventHandler(this.comPorts_SelectedIndexChanged);
            // 
            // groupSendData
            // 
            this.groupSendData.Controls.Add(this.sendData);
            this.groupSendData.Controls.Add(this.dataToSendLabel);
            this.groupSendData.Controls.Add(this.dataToSend);
            this.groupSendData.Location = new System.Drawing.Point(18, 154);
            this.groupSendData.Name = "groupSendData";
            this.groupSendData.Size = new System.Drawing.Size(348, 195);
            this.groupSendData.TabIndex = 1;
            this.groupSendData.TabStop = false;
            this.groupSendData.Text = "Send Data";
            // 
            // sendData
            // 
            this.sendData.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sendData.Location = new System.Drawing.Point(34, 107);
            this.sendData.Name = "sendData";
            this.sendData.Size = new System.Drawing.Size(264, 45);
            this.sendData.TabIndex = 2;
            this.sendData.Text = "Send Data";
            this.sendData.UseVisualStyleBackColor = true;
            this.sendData.Click += new System.EventHandler(this.SendData_Click);
            // 
            // dataToSendLabel
            // 
            this.dataToSendLabel.AutoSize = true;
            this.dataToSendLabel.Location = new System.Drawing.Point(34, 38);
            this.dataToSendLabel.Name = "dataToSendLabel";
            this.dataToSendLabel.Size = new System.Drawing.Size(89, 17);
            this.dataToSendLabel.TabIndex = 1;
            this.dataToSendLabel.Text = "Data to send";
            // 
            // dataToSend
            // 
            this.dataToSend.Location = new System.Drawing.Point(34, 61);
            this.dataToSend.Multiline = true;
            this.dataToSend.Name = "dataToSend";
            this.dataToSend.Size = new System.Drawing.Size(264, 27);
            this.dataToSend.TabIndex = 0;
            // 
            // groupReceiveData
            // 
            this.groupReceiveData.Controls.Add(this.receivedDataLabel);
            this.groupReceiveData.Controls.Add(this.receivedData);
            this.groupReceiveData.Controls.Add(this.receiveData);
            this.groupReceiveData.Location = new System.Drawing.Point(440, 154);
            this.groupReceiveData.Name = "groupReceiveData";
            this.groupReceiveData.Size = new System.Drawing.Size(321, 195);
            this.groupReceiveData.TabIndex = 2;
            this.groupReceiveData.TabStop = false;
            this.groupReceiveData.Text = "Receive Data";
            // 
            // receivedDataLabel
            // 
            this.receivedDataLabel.AutoSize = true;
            this.receivedDataLabel.Location = new System.Drawing.Point(29, 107);
            this.receivedDataLabel.Name = "receivedDataLabel";
            this.receivedDataLabel.Size = new System.Drawing.Size(101, 17);
            this.receivedDataLabel.TabIndex = 2;
            this.receivedDataLabel.Text = "Received Data";
            // 
            // receivedData
            // 
            this.receivedData.Location = new System.Drawing.Point(29, 130);
            this.receivedData.Multiline = true;
            this.receivedData.Name = "receivedData";
            this.receivedData.Size = new System.Drawing.Size(273, 32);
            this.receivedData.TabIndex = 1;
            // 
            // receiveData
            // 
            this.receiveData.Location = new System.Drawing.Point(29, 38);
            this.receiveData.Name = "receiveData";
            this.receiveData.Size = new System.Drawing.Size(273, 46);
            this.receiveData.TabIndex = 0;
            this.receiveData.Text = "Receive Data";
            this.receiveData.UseVisualStyleBackColor = true;
            this.receiveData.Click += new System.EventHandler(this.ReceiveData_Click);
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Location = new System.Drawing.Point(26, 45);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(121, 17);
            this.log.TabIndex = 3;
            this.log.Text = "Weight from scale";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 723);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 25);
            this.statusStrip.TabIndex = 4;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 19);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 20);
            // 
            // groupWeighing
            // 
            this.groupWeighing.Controls.Add(this.button1);
            this.groupWeighing.Controls.Add(this.netWeight);
            this.groupWeighing.Controls.Add(this.label4);
            this.groupWeighing.Controls.Add(this.crateWeight);
            this.groupWeighing.Controls.Add(this.label3);
            this.groupWeighing.Controls.Add(this.label2);
            this.groupWeighing.Controls.Add(this.selectedProduct);
            this.groupWeighing.Controls.Add(this.itemWeight);
            this.groupWeighing.Controls.Add(this.log);
            this.groupWeighing.Location = new System.Drawing.Point(23, 396);
            this.groupWeighing.Name = "groupWeighing";
            this.groupWeighing.Size = new System.Drawing.Size(737, 324);
            this.groupWeighing.TabIndex = 5;
            this.groupWeighing.TabStop = false;
            this.groupWeighing.Text = "Weighing Results";
            
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Eras Bold ITC", 17.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(467, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 157);
            this.button1.TabIndex = 11;
            this.button1.Text = "Record Weight";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // netWeight
            // 
            this.netWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netWeight.Location = new System.Drawing.Point(153, 233);
            this.netWeight.Name = "netWeight";
            this.netWeight.ReadOnly = true;
            this.netWeight.Size = new System.Drawing.Size(243, 28);
            this.netWeight.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Net Weight";
            // 
            // crateWeight
            // 
            this.crateWeight.Location = new System.Drawing.Point(468, 63);
            this.crateWeight.Name = "crateWeight";
            this.crateWeight.Size = new System.Drawing.Size(223, 22);
            this.crateWeight.TabIndex = 8;
            this.crateWeight.Enter += new System.EventHandler(this.CrateWeight_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Crate Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selected Item";
            // 
            // selectedProduct
            // 
            this.selectedProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedProduct.Location = new System.Drawing.Point(153, 141);
            this.selectedProduct.Name = "selectedProduct";
            this.selectedProduct.ReadOnly = true;
            this.selectedProduct.Size = new System.Drawing.Size(243, 28);
            this.selectedProduct.TabIndex = 5;
            // 
            // itemWeight
            // 
            this.itemWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemWeight.Location = new System.Drawing.Point(153, 38);
            this.itemWeight.Name = "itemWeight";
            this.itemWeight.ReadOnly = true;
            this.itemWeight.Size = new System.Drawing.Size(243, 28);
            this.itemWeight.TabIndex = 4;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 748);
            this.Controls.Add(this.groupWeighing);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupReceiveData);
            this.Controls.Add(this.groupSendData);
            this.Controls.Add(this.groupSerialSettings);
            this.Name = "Form1";
            this.Text = "Farmer\'s Choice Digital Weighing Scale";
            this.groupSerialSettings.ResumeLayout(false);
            this.groupSerialSettings.PerformLayout();
            this.groupSendData.ResumeLayout(false);
            this.groupSendData.PerformLayout();
            this.groupReceiveData.ResumeLayout(false);
            this.groupReceiveData.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupWeighing.ResumeLayout(false);
            this.groupWeighing.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSerialSettings;
        private System.Windows.Forms.Label baudRatesLabel;
        private System.Windows.Forms.ComboBox baudRates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comPorts;
        private System.Windows.Forms.GroupBox groupSendData;
        private System.Windows.Forms.Button sendData;
        private System.Windows.Forms.Label dataToSendLabel;
        private System.Windows.Forms.TextBox dataToSend;
        private System.Windows.Forms.GroupBox groupReceiveData;
        private System.Windows.Forms.Label receivedDataLabel;
        private System.Windows.Forms.TextBox receivedData;
        private System.Windows.Forms.Button receiveData;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.GroupBox groupWeighing;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox netWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox crateWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox selectedProduct;
        private System.Windows.Forms.TextBox itemWeight;
    }
}

