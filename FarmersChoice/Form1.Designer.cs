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
            this.groupReceiveData = new System.Windows.Forms.GroupBox();
            this.receivedDataLabel = new System.Windows.Forms.Label();
            this.receivedData = new System.Windows.Forms.TextBox();
            this.receiveData = new System.Windows.Forms.Button();
            this.crateWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupWeighing = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vendorName = new System.Windows.Forms.TextBox();
            this.vendorNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.classificationCodeLabel = new System.Windows.Forms.Label();
            this.classificationCode = new System.Windows.Forms.TextBox();
            this.recordWeightButton = new System.Windows.Forms.Button();
            this.netWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.animalType = new System.Windows.Forms.TextBox();
            this.itemWeight = new System.Windows.Forms.TextBox();
            this.farmersDetails = new System.Windows.Forms.GroupBox();
            this.receiptDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.meatPercent = new System.Windows.Forms.TextBox();
            this.receiptNumberLabel = new System.Windows.Forms.Label();
            this.receiptNumber = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupReceiveData.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupWeighing.SuspendLayout();
            this.farmersDetails.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupReceiveData
            // 
            this.groupReceiveData.Controls.Add(this.receivedDataLabel);
            this.groupReceiveData.Controls.Add(this.receivedData);
            this.groupReceiveData.Controls.Add(this.receiveData);
            this.groupReceiveData.Controls.Add(this.crateWeight);
            this.groupReceiveData.Controls.Add(this.label3);
            this.groupReceiveData.Location = new System.Drawing.Point(29, 40);
            this.groupReceiveData.Name = "groupReceiveData";
            this.groupReceiveData.Size = new System.Drawing.Size(731, 174);
            this.groupReceiveData.TabIndex = 2;
            this.groupReceiveData.TabStop = false;
            this.groupReceiveData.Text = "Receive Reading";
            // 
            // receivedDataLabel
            // 
            this.receivedDataLabel.AutoSize = true;
            this.receivedDataLabel.Location = new System.Drawing.Point(381, 55);
            this.receivedDataLabel.Name = "receivedDataLabel";
            this.receivedDataLabel.Size = new System.Drawing.Size(115, 17);
            this.receivedDataLabel.TabIndex = 2;
            this.receivedDataLabel.Text = "Received Weight";
            // 
            // receivedData
            // 
            this.receivedData.Location = new System.Drawing.Point(517, 48);
            this.receivedData.Multiline = true;
            this.receivedData.Name = "receivedData";
            this.receivedData.ReadOnly = true;
            this.receivedData.Size = new System.Drawing.Size(198, 32);
            this.receivedData.TabIndex = 1;
            this.receivedData.TabStop = false;
            // 
            // receiveData
            // 
            this.receiveData.Location = new System.Drawing.Point(29, 38);
            this.receiveData.Name = "receiveData";
            this.receiveData.Size = new System.Drawing.Size(273, 100);
            this.receiveData.TabIndex = 0;
            this.receiveData.Text = "Read Weight";
            this.receiveData.UseVisualStyleBackColor = true;
            this.receiveData.Click += new System.EventHandler(this.ReceiveData_Click);
            // 
            // crateWeight
            // 
            this.crateWeight.Location = new System.Drawing.Point(517, 106);
            this.crateWeight.Name = "crateWeight";
            this.crateWeight.Size = new System.Drawing.Size(198, 22);
            this.crateWeight.TabIndex = 1;
            this.crateWeight.Enter += new System.EventHandler(this.CrateWeight_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Crate Weight";
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
            this.statusStrip.Location = new System.Drawing.Point(0, 730);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(792, 25);
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
            this.groupWeighing.Controls.Add(this.label6);
            this.groupWeighing.Controls.Add(this.vendorName);
            this.groupWeighing.Controls.Add(this.vendorNo);
            this.groupWeighing.Controls.Add(this.label5);
            this.groupWeighing.Controls.Add(this.classificationCodeLabel);
            this.groupWeighing.Controls.Add(this.classificationCode);
            this.groupWeighing.Controls.Add(this.recordWeightButton);
            this.groupWeighing.Controls.Add(this.netWeight);
            this.groupWeighing.Controls.Add(this.label4);
            this.groupWeighing.Controls.Add(this.label2);
            this.groupWeighing.Controls.Add(this.animalType);
            this.groupWeighing.Controls.Add(this.itemWeight);
            this.groupWeighing.Controls.Add(this.log);
            this.groupWeighing.Location = new System.Drawing.Point(29, 419);
            this.groupWeighing.Name = "groupWeighing";
            this.groupWeighing.Size = new System.Drawing.Size(737, 311);
            this.groupWeighing.TabIndex = 5;
            this.groupWeighing.TabStop = false;
            this.groupWeighing.Text = "Weighing Results";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Vendor Name";
            // 
            // vendorName
            // 
            this.vendorName.Location = new System.Drawing.Point(512, 103);
            this.vendorName.Multiline = true;
            this.vendorName.Name = "vendorName";
            this.vendorName.ReadOnly = true;
            this.vendorName.Size = new System.Drawing.Size(198, 28);
            this.vendorName.TabIndex = 16;
            this.vendorName.TabStop = false;
            // 
            // vendorNo
            // 
            this.vendorNo.Location = new System.Drawing.Point(512, 39);
            this.vendorNo.Multiline = true;
            this.vendorNo.Name = "vendorNo";
            this.vendorNo.ReadOnly = true;
            this.vendorNo.Size = new System.Drawing.Size(198, 27);
            this.vendorNo.TabIndex = 15;
            this.vendorNo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Vendor No.";
            // 
            // classificationCodeLabel
            // 
            this.classificationCodeLabel.AutoSize = true;
            this.classificationCodeLabel.Location = new System.Drawing.Point(25, 170);
            this.classificationCodeLabel.Name = "classificationCodeLabel";
            this.classificationCodeLabel.Size = new System.Drawing.Size(127, 17);
            this.classificationCodeLabel.TabIndex = 13;
            this.classificationCodeLabel.Text = "Classification Code";
            // 
            // classificationCode
            // 
            this.classificationCode.Location = new System.Drawing.Point(175, 167);
            this.classificationCode.Multiline = true;
            this.classificationCode.Name = "classificationCode";
            this.classificationCode.ReadOnly = true;
            this.classificationCode.Size = new System.Drawing.Size(197, 28);
            this.classificationCode.TabIndex = 12;
            this.classificationCode.TabStop = false;
            // 
            // recordWeightButton
            // 
            this.recordWeightButton.Font = new System.Drawing.Font("Eras Bold ITC", 17.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordWeightButton.Location = new System.Drawing.Point(486, 170);
            this.recordWeightButton.Name = "recordWeightButton";
            this.recordWeightButton.Size = new System.Drawing.Size(224, 94);
            this.recordWeightButton.TabIndex = 4;
            this.recordWeightButton.Text = "Record Weight";
            this.recordWeightButton.UseVisualStyleBackColor = true;
            this.recordWeightButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // netWeight
            // 
            this.netWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netWeight.Location = new System.Drawing.Point(175, 233);
            this.netWeight.Name = "netWeight";
            this.netWeight.ReadOnly = true;
            this.netWeight.Size = new System.Drawing.Size(197, 28);
            this.netWeight.TabIndex = 10;
            this.netWeight.TabStop = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Animal Type";
            // 
            // animalType
            // 
            this.animalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalType.Location = new System.Drawing.Point(175, 103);
            this.animalType.Name = "animalType";
            this.animalType.ReadOnly = true;
            this.animalType.Size = new System.Drawing.Size(197, 28);
            this.animalType.TabIndex = 5;
            this.animalType.TabStop = false;
            // 
            // itemWeight
            // 
            this.itemWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemWeight.Location = new System.Drawing.Point(175, 38);
            this.itemWeight.Name = "itemWeight";
            this.itemWeight.ReadOnly = true;
            this.itemWeight.Size = new System.Drawing.Size(197, 28);
            this.itemWeight.TabIndex = 4;
            this.itemWeight.TabStop = false;
            // 
            // farmersDetails
            // 
            this.farmersDetails.Controls.Add(this.receiptDetails);
            this.farmersDetails.Controls.Add(this.label1);
            this.farmersDetails.Controls.Add(this.meatPercent);
            this.farmersDetails.Controls.Add(this.receiptNumberLabel);
            this.farmersDetails.Controls.Add(this.receiptNumber);
            this.farmersDetails.Location = new System.Drawing.Point(29, 238);
            this.farmersDetails.Name = "farmersDetails";
            this.farmersDetails.Size = new System.Drawing.Size(731, 156);
            this.farmersDetails.TabIndex = 7;
            this.farmersDetails.TabStop = false;
            this.farmersDetails.Text = "Farmer\'s Details";
            // 
            // receiptDetails
            // 
            this.receiptDetails.AutoSize = true;
            this.receiptDetails.Location = new System.Drawing.Point(15, 120);
            this.receiptDetails.Name = "receiptDetails";
            this.receiptDetails.Size = new System.Drawing.Size(0, 17);
            this.receiptDetails.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Meat Percent";
            // 
            // meatPercent
            // 
            this.meatPercent.Location = new System.Drawing.Point(407, 69);
            this.meatPercent.Name = "meatPercent";
            this.meatPercent.Size = new System.Drawing.Size(303, 22);
            this.meatPercent.TabIndex = 3;
            this.meatPercent.Leave += new System.EventHandler(this.meatPercent_Leave);
            // 
            // receiptNumberLabel
            // 
            this.receiptNumberLabel.AutoSize = true;
            this.receiptNumberLabel.Location = new System.Drawing.Point(15, 40);
            this.receiptNumberLabel.Name = "receiptNumberLabel";
            this.receiptNumberLabel.Size = new System.Drawing.Size(110, 17);
            this.receiptNumberLabel.TabIndex = 1;
            this.receiptNumberLabel.Text = "Receipt Number";
            // 
            // receiptNumber
            // 
            this.receiptNumber.Location = new System.Drawing.Point(15, 69);
            this.receiptNumber.Name = "receiptNumber";
            this.receiptNumber.Size = new System.Drawing.Size(306, 22);
            this.receiptNumber.TabIndex = 2;
            this.receiptNumber.Leave += new System.EventHandler(this.receiptNumber_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.configToolStripMenuItem.Text = "Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 755);
            this.Controls.Add(this.farmersDetails);
            this.Controls.Add(this.groupWeighing);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupReceiveData);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Farmer\'s Choice Digital Weighing Scale";
            this.groupReceiveData.ResumeLayout(false);
            this.groupReceiveData.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupWeighing.ResumeLayout(false);
            this.groupWeighing.PerformLayout();
            this.farmersDetails.ResumeLayout(false);
            this.farmersDetails.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupReceiveData;
        private System.Windows.Forms.Label receivedDataLabel;
        private System.Windows.Forms.TextBox receivedData;
        private System.Windows.Forms.Button receiveData;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.GroupBox groupWeighing;
        private System.Windows.Forms.Button recordWeightButton;
        private System.Windows.Forms.TextBox netWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox crateWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox animalType;
        private System.Windows.Forms.TextBox itemWeight;
        private System.Windows.Forms.GroupBox farmersDetails;
        private System.Windows.Forms.TextBox classificationCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox meatPercent;
        private System.Windows.Forms.Label receiptNumberLabel;
        private System.Windows.Forms.TextBox receiptNumber;
        private System.Windows.Forms.Label classificationCodeLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label receiptDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vendorName;
        private System.Windows.Forms.TextBox vendorNo;
        private System.Windows.Forms.Label label5;
    }
}

