using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmersChoice
{
    public partial class ItemSelection : Form
    {
        public ItemSelection()
        {
            InitializeComponent();
        }

        public string selectedItem;

        private void PorkBelly_Click(object sender, EventArgs e)
        {
            selectedItem = "Pork Belly";
            this.Dispose();
        }

        private void PrimeRib_Click(object sender, EventArgs e)
        {
            selectedItem = "Prime Rib";
            this.Dispose();
        }

        private void LambChop_Click(object sender, EventArgs e)
        {
            selectedItem = "Lamb Chop";
            this.Dispose();
        }

        private void Sirloin_Click(object sender, EventArgs e)
        {
            selectedItem = "Sirloin";
            this.Dispose();
        }
    }
}
