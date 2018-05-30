namespace FarmersChoice
{
    partial class ItemSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemSelection));
            this.lambChop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.porkBelly = new System.Windows.Forms.Button();
            this.primeRib = new System.Windows.Forms.Button();
            this.sirloin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lambChop
            // 
            this.lambChop.Image = ((System.Drawing.Image)(resources.GetObject("lambChop.Image")));
            this.lambChop.Location = new System.Drawing.Point(58, 604);
            this.lambChop.Name = "lambChop";
            this.lambChop.Size = new System.Drawing.Size(610, 275);
            this.lambChop.TabIndex = 0;
            this.lambChop.UseVisualStyleBackColor = true;
            this.lambChop.Click += new System.EventHandler(this.LambChop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 47.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(519, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Item";
            // 
            // porkBelly
            // 
            this.porkBelly.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("porkBelly.BackgroundImage")));
            this.porkBelly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.porkBelly.FlatAppearance.BorderSize = 0;
            this.porkBelly.Location = new System.Drawing.Point(58, 176);
            this.porkBelly.Name = "porkBelly";
            this.porkBelly.Size = new System.Drawing.Size(530, 407);
            this.porkBelly.TabIndex = 2;
            this.porkBelly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.porkBelly.UseVisualStyleBackColor = true;
            this.porkBelly.Click += new System.EventHandler(this.PorkBelly_Click);
            // 
            // primeRib
            // 
            this.primeRib.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("primeRib.BackgroundImage")));
            this.primeRib.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.primeRib.FlatAppearance.BorderSize = 0;
            this.primeRib.Location = new System.Drawing.Point(683, 176);
            this.primeRib.Name = "primeRib";
            this.primeRib.Size = new System.Drawing.Size(660, 407);
            this.primeRib.TabIndex = 3;
            this.primeRib.UseVisualStyleBackColor = true;
            this.primeRib.Click += new System.EventHandler(this.PrimeRib_Click);
            // 
            // sirloin
            // 
            this.sirloin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sirloin.BackgroundImage")));
            this.sirloin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sirloin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sirloin.Location = new System.Drawing.Point(700, 604);
            this.sirloin.Name = "sirloin";
            this.sirloin.Size = new System.Drawing.Size(543, 284);
            this.sirloin.TabIndex = 4;
            this.sirloin.UseVisualStyleBackColor = true;
            this.sirloin.Click += new System.EventHandler(this.Sirloin_Click);
            // 
            // ItemSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1601, 1028);
            this.Controls.Add(this.sirloin);
            this.Controls.Add(this.primeRib);
            this.Controls.Add(this.porkBelly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lambChop);
            this.Name = "ItemSelection";
            this.Text = "Farmer\'s Choice Item Selection Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lambChop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button porkBelly;
        private System.Windows.Forms.Button primeRib;
        private System.Windows.Forms.Button sirloin;
    }
}