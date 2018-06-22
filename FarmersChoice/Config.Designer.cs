namespace FarmersChoice
{
    partial class Config
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
            this.comPorts = new System.Windows.Forms.ComboBox();
            this.groupSerialSettings = new System.Windows.Forms.GroupBox();
            this.baudRatesLabel = new System.Windows.Forms.Label();
            this.baudRates = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.databasePassword = new System.Windows.Forms.TextBox();
            this.databaseUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.databaseName = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.Label();
            this.databaseHost = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.weighingScaleId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveConfig = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupSerialSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // groupSerialSettings
            // 
            this.groupSerialSettings.Controls.Add(this.baudRatesLabel);
            this.groupSerialSettings.Controls.Add(this.baudRates);
            this.groupSerialSettings.Controls.Add(this.label1);
            this.groupSerialSettings.Controls.Add(this.comPorts);
            this.groupSerialSettings.Location = new System.Drawing.Point(31, 263);
            this.groupSerialSettings.Name = "groupSerialSettings";
            this.groupSerialSettings.Size = new System.Drawing.Size(743, 89);
            this.groupSerialSettings.TabIndex = 1;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.databasePassword);
            this.groupBox1.Controls.Add(this.databaseUser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.databaseName);
            this.groupBox1.Controls.Add(this.Host);
            this.groupBox1.Controls.Add(this.databaseHost);
            this.groupBox1.Location = new System.Drawing.Point(31, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Connection Strings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "DB Password";
            // 
            // databasePassword
            // 
            this.databasePassword.Location = new System.Drawing.Point(451, 169);
            this.databasePassword.Multiline = true;
            this.databasePassword.Name = "databasePassword";
            this.databasePassword.Size = new System.Drawing.Size(270, 29);
            this.databasePassword.TabIndex = 6;
            this.databasePassword.UseSystemPasswordChar = true;
            // 
            // databaseUser
            // 
            this.databaseUser.Location = new System.Drawing.Point(34, 173);
            this.databaseUser.Multiline = true;
            this.databaseUser.Name = "databaseUser";
            this.databaseUser.Size = new System.Drawing.Size(337, 27);
            this.databaseUser.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "DB User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Database";
            // 
            // databaseName
            // 
            this.databaseName.Location = new System.Drawing.Point(451, 79);
            this.databaseName.Multiline = true;
            this.databaseName.Name = "databaseName";
            this.databaseName.Size = new System.Drawing.Size(270, 30);
            this.databaseName.TabIndex = 2;
            // 
            // Host
            // 
            this.Host.AutoSize = true;
            this.Host.Location = new System.Drawing.Point(31, 44);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(37, 17);
            this.Host.TabIndex = 1;
            this.Host.Text = "Host";
            // 
            // databaseHost
            // 
            this.databaseHost.Location = new System.Drawing.Point(34, 79);
            this.databaseHost.Multiline = true;
            this.databaseHost.Name = "databaseHost";
            this.databaseHost.Size = new System.Drawing.Size(337, 30);
            this.databaseHost.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.weighingScaleId);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(31, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weighing Station Details";
            // 
            // weighingScaleId
            // 
            this.weighingScaleId.Location = new System.Drawing.Point(174, 37);
            this.weighingScaleId.Multiline = true;
            this.weighingScaleId.Name = "weighingScaleId";
            this.weighingScaleId.Size = new System.Drawing.Size(272, 30);
            this.weighingScaleId.TabIndex = 1;
            this.weighingScaleId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Weighing Scale ID";
            // 
            // saveConfig
            // 
            this.saveConfig.Location = new System.Drawing.Point(590, 684);
            this.saveConfig.Name = "saveConfig";
            this.saveConfig.Size = new System.Drawing.Size(184, 50);
            this.saveConfig.TabIndex = 4;
            this.saveConfig.Text = "Save Settings";
            this.saveConfig.UseVisualStyleBackColor = true;
            this.saveConfig.Click += new System.EventHandler(this.saveConfig_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 36);
            this.label6.TabIndex = 5;
            this.label6.Text = "System Configuration";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 781);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saveConfig);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupSerialSettings);
            this.Name = "Config";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.groupSerialSettings.ResumeLayout(false);
            this.groupSerialSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comPorts;
        private System.Windows.Forms.GroupBox groupSerialSettings;
        private System.Windows.Forms.Label baudRatesLabel;
        private System.Windows.Forms.ComboBox baudRates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox databasePassword;
        private System.Windows.Forms.TextBox databaseUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox databaseName;
        private System.Windows.Forms.Label Host;
        private System.Windows.Forms.TextBox databaseHost;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox weighingScaleId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveConfig;
        private System.Windows.Forms.Label label6;
    }
}