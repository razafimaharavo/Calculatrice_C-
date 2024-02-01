using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatice
{
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Calculatrice_Load(object sender, EventArgs e)
        {
            foreach (Button b in Controls.OfType<Button>().Where(x => x.Tag != null))
            {
                b.Click += B_Click; 
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            var lebtnClique = (Button)sender;
            txtCalc.Text += lebtnClique.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(txtCalc.Text.Length > 0)
            {
                txtCalc.Text = txtCalc.Text.Remove(txtCalc.Text.Length - 1);
            }
           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                //txtCalc.Text = dt.Compute(txtCalc.Text, "").ToString();
                txtCalc.Text = dt.Compute(txtCalc.Text.Replace(",", "."), "").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtCalc.Clear();
        }
    }
}
