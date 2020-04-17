using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class FrmRandomComb : Form
    {
        public FrmRandomComb()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CmbGen.ResetText();
            CmbGen.Items.Clear();
            Random r = new Random();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 50) - 1; i++)
            {
                CmbGen.Items.Add(r.Next(100, 999));
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            CmbGen.ResetText();
            CmbGen.Items.Clear();
        }
    }
}
